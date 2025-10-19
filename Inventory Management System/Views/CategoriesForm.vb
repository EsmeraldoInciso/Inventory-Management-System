Imports System.Drawing.Printing

Public Class CategoriesForm
    Dim pt As New PrintTemplates
    Private Sub CategoriesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearField()
    End Sub

    Private Sub LoadAllCategories(text As String)
        Dim query As String =
            "SELECT 
                category_id AS ID, 
                category_name AS 'Category Name', 
                CASE
                    WHEN status = 1 THEN 'Active'
                    ELSE 'Inactive'
                END AS Status
            FROM categories
            WHERE 
                category_id LIKE '%" + text + "%' OR
                category_name LIKE '%" + text + "%'"
        LoadDataToGrid(query, dgCategories)

    End Sub

    Private Sub dgItemList_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgCategories.CellFormatting
        If dgCategories.Columns(e.ColumnIndex).Name = "Status" AndAlso e.Value IsNot Nothing Then
            If e.Value.ToString() = "Inactive" Then
                dgCategories.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
                dgCategories.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.DarkGray
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadAllCategories(txtSearch.Text)
    End Sub

    Private Sub ClearField()
        LoadAllCategories("")
        txtID.Clear()
        cbStatus.SelectedIndex = 0
        txtCategoryName.Clear()
        txtSearch.Clear()
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Trim(txtCategoryName.Text) <> "" Then
            If ConfirmDialog($"Are you sure you want to add category {txtCategoryName.Text}") Then
                Dim sql As String = "INSERT INTO categories (category_name, status) " &
                    "VALUES (@category_name, @status)"
                Dim parameters As New Dictionary(Of String, Object) From {
                    {"@category_name", Trim(txtCategoryName.Text)},
                    {"@status", If(cbStatus.SelectedIndex = 1, 1, 0)}
                }
                If InsertDatabase(sql, parameters) Then
                    LogAction(UserSession.UserID, "ADD CATEGORY", $"Added new category: {txtCategoryName.Text}?", "categories")
                    ClearField()
                    Dim toast As New ToastForm("Category inserted successfully!")
                    toast.Show()
                Else
                    Dim toast As New ToastForm("Insert failed.")
                    toast.Show()
                End If
            End If
        Else
            Dim toast As New ToastForm("Category Name is required!.")
            toast.Show()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Trim(txtCategoryName.Text) <> "" Then
            If ConfirmDialog($"Are you sure you want to update category {txtCategoryName.Text}?") Then
                Dim sql As String = "UPDATE categories SET " &
                "category_name = @category_name, " &
                "status = @status " &
                "WHERE category_id = @category_id"

                Dim parameters As New Dictionary(Of String, Object) From {
                    {"@category_name", txtCategoryName.Text},
                    {"@status", If(cbStatus.SelectedIndex = 1, 1, 0)},
                    {"@category_id", CInt(txtID.Text)}
                }

                If UpdateDatabase(sql, parameters) Then
                    LogAction(UserSession.UserID, "UPDATE CATEGORY", $"Updated category with id: {txtID.Text}, category: {txtCategoryName.Text}", "categories")
                    ClearField()
                    Dim toast As New ToastForm("Category updated successfully!")
                    toast.Show()
                Else
                    Dim toast As New ToastForm("Update failed.")
                    toast.Show()
                End If
            End If
        Else
            Dim toast As New ToastForm("Category Name is required!.")
            toast.Show()
        End If
    End Sub

    Private Sub dgCategories_SelectionChanged(sender As Object, e As EventArgs) Handles dgCategories.CellClick
        If dgCategories.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgCategories.SelectedRows(0)

            ' Populate textboxes
            txtID.Text = row.Cells("ID").Value.ToString()
            txtCategoryName.Text = row.Cells("Category Name").Value.ToString()
            cbStatus.SelectedItem = row.Cells("Status").Value.ToString()
        End If
        btnAdd.Enabled = False
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearField()
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
        For Each col As DataGridViewColumn In dgCategories.Columns
            If col.Name.ToLower() <> "password" Then
                dgvTemp.Columns.Add(col.Name, col.HeaderText)
            End If
        Next

        ' Copy rows
        For Each row As DataGridViewRow In dgCategories.Rows
            If Not row.IsNewRow Then
                Dim rowData As New List(Of Object)
                For Each col As DataGridViewColumn In dgCategories.Columns
                    If col.Name.ToLower() <> "password" Then
                        rowData.Add(row.Cells(col.Index).Value)
                    End If
                Next
                dgvTemp.Rows.Add(rowData.ToArray())
            End If
        Next
        pt.PrintDataGridViewReport(e, dgvTemp, "Categories Report")
    End Sub
End Class