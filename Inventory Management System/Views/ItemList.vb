Imports System.Drawing.Printing

Public Class ItemListForm
    Dim pt As New PrintTemplates
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
                i.price as Price,
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
                description LIKE '%" + text + "%'
            LIMIT 50"
        LoadDataToGrid(query, dgItemList)
        dgItemList.Columns("category_id").Visible = False
        dgItemList.Columns("Price").DefaultCellStyle.Format = "0.00"

    End Sub

    Private Sub ClearField()
        LoadAllItems("")
        txtID.Clear()
        txtCode.Clear()
        txtItemName.Clear()
        txtItemDescription.Clear()
        txtItemPrice.Clear()
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
            If ConfirmDialog($"Are you sure you want to add item {txtItemName.Text}") Then
                Dim sql As String = "INSERT INTO items (item_code, item_name, description, price, category_id, unit, reorder_level) " &
                    "VALUES (@item_code, @item_name, @description, @price, @category_id, @unit, @reorder_level)"
                Dim parameters As New Dictionary(Of String, Object) From {
                    {"@item_code", Trim(txtCode.Text)},
                    {"@item_name", Trim(txtItemName.Text)},
                    {"@description", Trim(txtItemDescription.Text)},
                    {"@price", Trim(txtItemPrice.Text)},
                    {"@category_id", Trim(cbCategory.SelectedValue)},
                    {"@unit", cbUnit.Text},
                    {"@reorder_level", Trim(txtReorderLevel.Text)}
                }
                If InsertDatabase(sql, parameters) Then
                    LogAction(UserSession.UserID, "ADD ITEM", $"Added new item: {txtItemName.Text}", "items")
                    ClearField()
                    Dim toast As New ToastForm("Item inserted successfully!")
                    toast.Show()
                Else
                    Dim toast As New ToastForm("Insert failed.")
                    toast.Show()
                End If
            End If
        Else
            Dim toast As New ToastForm("All Fields are required!.")
            toast.Show()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If IsFormReady() Then
            If ConfirmDialog($"Are you sure you want to update item {txtItemName.Text}") Then
                Dim sql As String = "UPDATE items SET " &
                "item_code = @item_code, " &
                "item_name = @item_name, " &
                "description = @description, " &
                "price = @price, " &
                "category_id = @category_id, " &
                "unit = @unit, " &
                "reorder_level = @reorder_level " &
                "WHERE item_id = @item_id"

                Dim parameters As New Dictionary(Of String, Object) From {
                    {"@item_code", Trim(txtCode.Text)},
                    {"@item_name", Trim(txtItemName.Text)},
                    {"@description", Trim(txtItemDescription.Text)},
                    {"@price", Trim(txtItemPrice.Text)},
                    {"@category_id", Trim(cbCategory.SelectedValue)},
                    {"@unit", cbUnit.Text},
                    {"@reorder_level", Trim(txtReorderLevel.Text)},
                    {"@item_id", CInt(txtID.Text)}
                }

                If UpdateDatabase(sql, parameters) Then
                    LogAction(UserSession.UserID, "UPDATE ITEM", $"Updated item with id: {CInt(txtID.Text)}, item: {txtItemName.Text}", "items", CInt(txtID.Text))
                    ClearField()
                    Dim toast As New ToastForm("Item updated successfully!")
                    toast.Show()
                    Dim toast1 As New ToastForm($"Low Stock: sample | SOH: sample", True)
                    toast1.Show()
                Else
                    Dim toast As New ToastForm("Update failed.")
                    toast.Show()
                End If
            End If
        Else
            Dim toast As New ToastForm("All Fields are required!.")
            toast.Show()
        End If
    End Sub

    Private Sub dgItemList_SelectionChanged(sender As Object, e As EventArgs) Handles dgItemList.CellClick

        If dgItemList.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgItemList.SelectedRows(0)

            ' Populate textboxes
            txtID.Text = row.Cells("ID").Value.ToString()
            txtCode.Text = row.Cells("Code").Value.ToString()
            txtItemName.Text = row.Cells("Name").Value.ToString()
            txtItemDescription.Text = row.Cells("Description").Value.ToString()
            txtItemPrice.Text = Format(row.Cells("Price").Value, "0.00").ToString()
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
        If Trim(txtCode.Text) <> "" And Trim(txtItemName.Text) <> "" And Trim(txtItemDescription.Text) <> "" And Trim(txtItemPrice.Text) <> "" And Trim(txtReorderLevel.Text) <> "" And cbCategory.SelectedIndex <> -1 And cbUnit.SelectedIndex <> 0 Then
            Return True
        End If

        Return False
    End Function

    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        ItemSession.ClearItemSession()
        ItemSession.ItemID = txtID.Text
        ItemSession.ItemCode = txtCode.Text
        ItemSession.ItemUnit = cbUnit.SelectedItem
        ItemSession.ItemName = txtItemName.Text
        Dim popup As New StockInForm(Me)
        popup.ShowDialog()
    End Sub

    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click
        ItemSession.ClearItemSession()
        ItemSession.ItemID = txtID.Text
        ItemSession.ItemCode = txtCode.Text
        ItemSession.ItemUnit = cbUnit.SelectedItem
        ItemSession.ItemName = txtItemName.Text
        Dim popup As New StockOutForm(Me)
        popup.ShowDialog()
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
        For Each col As DataGridViewColumn In dgItemList.Columns
            If col.Name.ToLower() <> "password" Then
                dgvTemp.Columns.Add(col.Name, col.HeaderText)
            End If
        Next

        ' Copy rows
        For Each row As DataGridViewRow In dgItemList.Rows
            If Not row.IsNewRow Then
                Dim rowData As New List(Of Object)
                For Each col As DataGridViewColumn In dgItemList.Columns
                    If col.Name.ToLower() <> "password" Then
                        rowData.Add(row.Cells(col.Index).Value)
                    End If
                Next
                dgvTemp.Rows.Add(rowData.ToArray())
            End If
        Next
        pt.PrintDataGridViewReport(e, dgvTemp, "Item List Report")
    End Sub
End Class