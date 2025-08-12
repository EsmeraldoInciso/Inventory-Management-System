Public Class CategoriesForm
    Private Sub CategoriesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearField()
    End Sub

    Private Sub LoadAllCategories(text As String)
        Dim query As String =
            "SELECT 
                category_id AS ID, 
                category_name AS 'Category Name' 
            FROM categories
            WHERE 
                category_id LIKE '%" + text + "%' OR
                category_name LIKE '%" + text + "%'"
        LoadDataToGrid(query, dgCategories)

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadAllCategories(txtSearch.Text)
    End Sub

    Private Sub ClearField()
        LoadAllCategories("")
        txtID.Clear()
        txtCategoryName.Clear()
        txtSearch.Clear()
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Trim(txtCategoryName.Text) <> "" Then
            Dim sql As String = "INSERT INTO categories (category_name) " &
                    "VALUES (@category_name)"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@category_name", Trim(txtCategoryName.Text)}
            }
            If InsertDatabase(sql, parameters) Then
                LogAction(UserSession.UserID, "ADD CATEGORY", $"Added new category: {txtCategoryName.Text}", "categories")
                ClearField()
                Dim toast As New ToastForm("Category inserted successfully!")
                toast.Show()
            Else
                Dim toast As New ToastForm("Insert failed.")
                toast.Show()
            End If
        Else
            Dim toast As New ToastForm("Category Name is required!.")
            toast.Show()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Trim(txtCategoryName.Text) <> "" Then
            Dim sql As String = "UPDATE categories SET " &
                "category_name = @category_name " &
                "WHERE category_id = @category_id"

            Dim parameters As New Dictionary(Of String, Object) From {
                {"@category_name", txtCategoryName.Text},
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

        Else
            Dim toast As New ToastForm("Category Name is required!.")
            toast.Show()
        End If
    End Sub

    Private Sub dgCategories_SelectionChanged(sender As Object, e As EventArgs) Handles dgCategories.SelectionChanged, dgCategories.CellClick
        If dgCategories.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgCategories.SelectedRows(0)

            ' Populate textboxes
            txtID.Text = row.Cells("ID").Value.ToString()
            txtCategoryName.Text = row.Cells("Category Name").Value.ToString()
        End If
        btnAdd.Enabled = False
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearField()
    End Sub
End Class