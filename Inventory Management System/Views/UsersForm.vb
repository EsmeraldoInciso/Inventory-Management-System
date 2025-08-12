Imports System.Drawing.Printing


Public Class UsersForm
    Dim pt As New PrintTemplates
    Dim passwordText As String

    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearField()
        dgUsers.ClearSelection()
    End Sub

    Private Sub LoadAllUsers(text As String)
        Dim query As String =
            "SELECT 
                user_id AS ID, 
                user_firstname AS Firstname, 
                user_lastname AS Lastname, 
                username AS Username, 
                password as Password,
                CASE 
                    WHEN user_type = 1 THEN 'Admin' 
                    ELSE 'User' 
                END AS Role,
                CASE
                    WHEN status = 1 THEN 'Active'
                    ELSE 'Inactive'
                END AS Status 
            FROM users
            WHERE 
                user_id LIKE '%" + text + "%' OR
                user_firstname LIKE '%" + text + "%' OR 
                user_lastname LIKE '%" + text + "%' OR 
                username LIKE '%" + text + "%'"
        LoadDataToGrid(query, dgUsers)
        dgUsers.Columns("Password").Visible = False

    End Sub

    Private Sub ClearField()
        LoadAllUsers("")
        txtID.Clear()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtSearch.Clear()
        cbRole.SelectedIndex = 0
        cbStatus.SelectedIndex = 0
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1

        ' Access the internal Form and maximize it
        Dim previewForm As Form = TryCast(PrintPreviewDialog1, Form)
        If previewForm IsNot Nothing Then
            previewForm.WindowState = FormWindowState.Maximized
        End If

        PrintPreviewDialog1.ShowDialog()
        'PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Create a temp DataGridView for printing
        Dim dgvTemp As New DataGridView()

        ' Copy only columns except password
        For Each col As DataGridViewColumn In dgUsers.Columns
            If col.Name.ToLower() <> "password" Then
                dgvTemp.Columns.Add(col.Name, col.HeaderText)
            End If
        Next

        ' Copy rows
        For Each row As DataGridViewRow In dgUsers.Rows
            If Not row.IsNewRow Then
                Dim rowData As New List(Of Object)
                For Each col As DataGridViewColumn In dgUsers.Columns
                    If col.Name.ToLower() <> "password" Then
                        rowData.Add(row.Cells(col.Index).Value)
                    End If
                Next
                dgvTemp.Rows.Add(rowData.ToArray())
            End If
        Next
        pt.PrintDataGridViewReport(e, dgvTemp, "Users Report")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadAllUsers(txtSearch.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If IsFormReady(True) Then
            Dim sql As String = "INSERT INTO users (user_firstname, user_lastname, username, password, user_type, status) " &
                    "VALUES (@firstname, @lastname, @username, @password, @user_type, @status)"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@firstname", Trim(txtFirstname.Text)},
                {"@lastname", Trim(txtLastname.Text)},
                {"@username", Trim(txtUsername.Text)},
                {"@password", HashPassword(Trim(txtPassword.Text))},
                {"@user_type", cbRole.SelectedIndex},
                {"@status", If(cbStatus.SelectedIndex = 1, 1, 0)}
            }
            If InsertDatabase(sql, parameters) Then
                LogAction(UserSession.UserID, "ADD USER", $"Added new user: {txtFirstname.Text} {txtLastname.Text}", "users")
                ClearField()
                Dim toast As New ToastForm("User inserted successfully!")
                toast.Show()
            Else
                Dim toast As New ToastForm("Insert failed.")
                toast.Show()
            End If
        Else
            Dim toast As New ToastForm("All Fields are required!.")
            toast.Show()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If IsFormReady(False) Then
            Dim sql As String = "UPDATE users SET " &
                "user_firstname = @firstname, " &
                "user_lastname = @lastname, " &
                "username = @username, " &
                "password = @password, " &
                "user_type = @user_type, " &
                "status = @status, " &
                "modified_at = NOW() " &
                "WHERE user_id = @user_id"

            Dim parameters As New Dictionary(Of String, Object) From {
                {"@firstname", txtFirstname.Text},
                {"@lastname", txtLastname.Text},
                {"@username", txtUsername.Text},
                {"@password", If(Trim(txtPassword.Text) <> "", HashPassword(txtPassword.Text), passwordText)},
                {"@user_type", cbRole.SelectedIndex},
                {"@status", If(cbStatus.SelectedIndex = 1, 1, 0)},
                {"@user_id", CInt(txtID.Text)}
            }

            If UpdateDatabase(sql, parameters) Then
                LogAction(UserSession.UserID, "UPDATE USER", $"Updated user with id: {CInt(txtID.Text)}, name: {txtFirstname.Text} {txtLastname.Text}", "users", CInt(txtID.Text))
                ClearField()
                Dim toast As New ToastForm("User updated successfully!")
                toast.Show()
            Else
                Dim toast As New ToastForm("Update failed.")
                toast.Show()
            End If

        Else
            Dim toast As New ToastForm("All Fields are required!. Except for Password.")
            toast.Show()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearField()
    End Sub

    Private Sub dgUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsers.CellContentClick

    End Sub

    Private Sub dgUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgUsers.SelectionChanged, dgUsers.CellClick
        If dgUsers.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgUsers.SelectedRows(0)

            ' Populate textboxes
            txtID.Text = row.Cells("ID").Value.ToString()
            txtFirstname.Text = row.Cells("Firstname").Value.ToString()
            txtLastname.Text = row.Cells("Lastname").Value.ToString()
            txtUsername.Text = row.Cells("Username").Value.ToString()
            passwordText = row.Cells("Password").Value.ToString()
            cbRole.SelectedItem = row.Cells("Role").Value.ToString()
            cbStatus.SelectedItem = row.Cells("Status").Value.ToString()
        End If
        btnAdd.Enabled = False
        btnUpdate.Enabled = True
    End Sub

    Private Function IsFormReady(needPassword As Boolean) As Boolean
        If needPassword Then
            If Trim(txtFirstname.Text) <> "" And Trim(txtLastname.Text) <> "" And Trim(txtUsername.Text) <> "" And Trim(txtPassword.Text) <> "" And cbRole.SelectedIndex <> 0 And cbStatus.SelectedIndex <> 0 Then
                Return True
            End If
        Else
            If Trim(txtFirstname.Text) <> "" And Trim(txtLastname.Text) <> "" And Trim(txtUsername.Text) <> "" And cbRole.SelectedIndex <> 0 And cbStatus.SelectedIndex <> 0 Then
                Return True
            End If
        End If

        Return False
    End Function
End Class