Public Class ItemListForm
    Private Sub ItemListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBox(cbCategory, "categories", "category_name", "category_id")
        ClearField()
        If UserSession.UserType <> 1 Then
            txtCode.Enabled = False
            txtItemName.Enabled = False
            txtItemDescription.Enabled = False
            txtReorderLevel.Enabled = False
            cbCategory.Enabled = False
            cbUnit.Enabled = False
            btnAdd.Enabled = False
            btnPrint.Enabled = False
        End If

    End Sub

    Public Sub LoadAllItems(text As String)
        Dim query As String =
            "SELECT 
                i.item_id AS ID, 
                item_code AS Code, 
                item_name AS Name, 
                description AS Description, 
                c.category_name as Category,
                i.category_id,
                unit as Unit,
                reorder_level as 'Reorder Level',
                sl.quantity_on_hand as SOH
            FROM items i
            JOIN categories c
                ON i.category_id = c.category_id
            JOIN stock_levels sl
                ON i.item_id = sl.item_id
            WHERE 
                i.item_id LIKE '%" + text + "%' OR
                item_code LIKE '%" + text + "%' OR 
                item_name LIKE '%" + text + "%' OR 
                c.category_name LIKE '%" + text + "%' OR 
                unit LIKE '%" + text + "%' OR 
                reorder_level LIKE '%" + text + "%' OR 
                description LIKE '%" + text + "%'"
        LoadDataToGrid(query, dgItemList)
        dgItemList.Columns("category_id").Visible = False
    End Sub

    Private Sub ClearField()
        LoadAllItems("")
        txtID.Clear()
        txtCode.Clear()
        txtItemName.Clear()
        txtItemDescription.Clear()
        txtReorderLevel.Clear()
        txtSearch.Clear()
        cbCategory.SelectedIndex = -1
        cbUnit.SelectedIndex = 0
        If UserSession.UserType <> 1 Then
            btnAdd.Enabled = False
            btnUpdate.Enabled = False
            btnStockIn.Visible = False
            btnStockOut.Visible = False
        Else
            btnStockIn.Visible = False
            btnStockOut.Visible = False
            btnAdd.Enabled = True
            btnUpdate.Enabled = False
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadAllItems(txtSearch.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearField()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If IsFormReady() Then
            Dim sql As String = "INSERT INTO items (item_code, item_name, description, category_id, unit, reorder_level) " &
                    "VALUES (@item_code, @item_name, @description, @category_id, @unit, @reorder_level)"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@item_code", Trim(txtCode.Text)},
                {"@item_name", Trim(txtItemName.Text)},
                {"@description", Trim(txtItemDescription.Text)},
                {"@category_id", Trim(cbCategory.SelectedValue)},
                {"@unit", cbUnit.Text},
                {"@reorder_level", Trim(txtReorderLevel.Text)}
            }
            If InsertDatabase(sql, parameters) Then
                ClearField()
                Dim toast As New ToastForm("Item inserted successfully!")
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
        If IsFormReady() Then
            Dim sql As String = "UPDATE items SET " &
                "item_code = @item_code, " &
                "item_name = @item_name, " &
                "description = @description, " &
                "category_id = @category_id, " &
                "unit = @unit, " &
                "reorder_level = @reorder_level " &
                "WHERE item_id = @item_id"

            Dim parameters As New Dictionary(Of String, Object) From {
                {"@item_code", Trim(txtCode.Text)},
                {"@item_name", Trim(txtItemName.Text)},
                {"@description", Trim(txtItemDescription.Text)},
                {"@category_id", Trim(cbCategory.SelectedValue)},
                {"@unit", cbUnit.Text},
                {"@reorder_level", Trim(txtReorderLevel.Text)},
                {"@item_id", CInt(txtID.Text)}
            }

            If UpdateDatabase(sql, parameters) Then
                ClearField()
                Dim toast As New ToastForm("Item updated successfully!")
                toast.Show()
            Else
                Dim toast As New ToastForm("Update failed.")
                toast.Show()
            End If

        Else
            Dim toast As New ToastForm("All Fields are required!.")
            toast.Show()
        End If
    End Sub

    Private Sub dgItemList_SelectionChanged(sender As Object, e As EventArgs) Handles dgItemList.SelectionChanged, dgItemList.CellClick
        If dgItemList.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgItemList.SelectedRows(0)

            ' Populate textboxes
            txtID.Text = row.Cells("ID").Value.ToString()
            txtCode.Text = row.Cells("Code").Value.ToString()
            txtItemName.Text = row.Cells("Name").Value.ToString()
            txtItemDescription.Text = row.Cells("Description").Value.ToString()
            txtReorderLevel.Text = row.Cells("Reorder Level").Value.ToString()
            cbCategory.SelectedValue = row.Cells("category_id").Value
            cbUnit.SelectedItem = row.Cells("Unit").Value.ToString()
        End If
        If UserSession.UserType <> 1 Then
            btnAdd.Enabled = False
            btnUpdate.Enabled = False
            btnStockIn.Visible = False
            btnStockOut.Visible = True
        Else
            btnStockIn.Visible = True
            btnStockOut.Visible = True
            btnAdd.Enabled = False
            btnUpdate.Enabled = True
        End If

    End Sub

    Private Function IsFormReady() As Boolean
        If Trim(txtCode.Text) <> "" And Trim(txtItemName.Text) <> "" And Trim(txtItemDescription.Text) <> "" And Trim(txtReorderLevel.Text) <> "" And cbCategory.SelectedIndex <> -1 And cbUnit.SelectedIndex <> 0 Then
            Return True
        End If

        Return False
    End Function

    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        ItemSession.ClearItemSession()
        ItemSession.ItemID = txtID.Text
        ItemSession.ItemCode = txtCode.Text
        ItemSession.ItemName = txtItemName.Text
        StockInForm.ShowDialog()
    End Sub
End Class