Imports System.Drawing.Printing

Public Class DiscountsForm
    Dim pt As New PrintTemplates

    Private Sub DiscountsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate combo boxes
        PopulateComboBox(cbItem, "items", "item_name", "item_id")
        PopulateComboBox(cbCategory, "categories", "category_name", "category_id")
        ClearField()
    End Sub

    Public Sub LoadAllDiscounts(text As String)
        Dim query As String =
            "SELECT 
                d.discount_id AS ID, 
                d.discount_name AS Name, 
                d.discount_type AS Type,
                d.discount_value AS Value,
                CASE 
                    WHEN d.start_date IS NULL THEN 'Always'
                    ELSE DATE_FORMAT(d.start_date, '%Y-%m-%d')
                END AS 'Start',
                CASE 
                    WHEN d.end_date IS NULL THEN 'No Expiry'
                    ELSE DATE_FORMAT(d.end_date, '%Y-%m-%d')
                END AS 'End',
                CASE 
                    WHEN d.item_id IS NOT NULL THEN CONCAT('Item: ', i.item_name)
                    WHEN d.category_id IS NOT NULL THEN CONCAT('Cat: ', c.category_name)
                    WHEN d.customer_type IS NOT NULL THEN CONCAT('Cust: ', d.customer_type)
                    ELSE 'All Items'
                END AS 'Applies To',
                d.min_quantity AS 'Min Qty',
                d.item_id,
                d.category_id,
                d.customer_type,
                CASE
                    WHEN d.status = 1 THEN 'Active'
                    ELSE 'Inactive'
                END AS Status 
            FROM discounts d
            LEFT JOIN items i ON d.item_id = i.item_id
            LEFT JOIN categories c ON d.category_id = c.category_id
            WHERE 
                d.discount_id LIKE '%" & text & "%' OR
                d.discount_name LIKE '%" & text & "%' OR
                d.discount_type LIKE '%" & text & "%' OR
                d.customer_type LIKE '%" & text & "%'
            LIMIT 50"
        LoadDataToGrid(query, dgDiscounts)

        ' Hide internal ID columns
        If dgDiscounts.Columns.Contains("item_id") Then dgDiscounts.Columns("item_id").Visible = False
        If dgDiscounts.Columns.Contains("category_id") Then dgDiscounts.Columns("category_id").Visible = False
        If dgDiscounts.Columns.Contains("customer_type") Then dgDiscounts.Columns("customer_type").Visible = False
    End Sub

    Private Sub dgDiscounts_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgDiscounts.CellFormatting
        If dgDiscounts.Columns(e.ColumnIndex).Name = "Status" AndAlso e.Value IsNot Nothing Then
            If e.Value.ToString() = "Inactive" Then
                dgDiscounts.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
                dgDiscounts.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.DarkGray
            End If
        End If
    End Sub

    Private Sub ClearField()
        LoadAllDiscounts("")
        txtID.Clear()
        txtDiscountName.Clear()
        cbDiscountType.SelectedIndex = 0
        txtDiscountValue.Clear()
        dtpStartDate.Value = DateTime.Now
        dtpEndDate.Value = DateTime.Now.AddDays(7)
        chkNoExpiry.Checked = False
        cbApplyTo.SelectedIndex = 0
        cbItem.SelectedIndex = -1
        cbCategory.SelectedIndex = -1
        cbCustomerType.SelectedIndex = -1
        txtMinQuantity.Text = "1"
        cbStatus.SelectedIndex = 0
        txtSearch.Clear()

        ' Hide conditional panels
        pnlItemSelect.Visible = False
        pnlCategorySelect.Visible = False
        pnlCustomerTypeSelect.Visible = False

        ' Enable/disable date pickers
        dtpStartDate.Enabled = True
        dtpEndDate.Enabled = True

        btnAdd.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadAllDiscounts(txtSearch.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearField()
    End Sub

    Private Sub chkNoExpiry_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoExpiry.CheckedChanged
        dtpStartDate.Enabled = Not chkNoExpiry.Checked
        dtpEndDate.Enabled = Not chkNoExpiry.Checked
    End Sub

    Private Sub cbApplyTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbApplyTo.SelectedIndexChanged
        ' Hide all conditional panels first
        pnlItemSelect.Visible = False
        pnlCategorySelect.Visible = False
        pnlCustomerTypeSelect.Visible = False

        ' Show the appropriate panel based on selection
        Select Case cbApplyTo.SelectedItem?.ToString()
            Case "Specific Item"
                pnlItemSelect.Visible = True
            Case "Category"
                pnlCategorySelect.Visible = True
            Case "Customer Type"
                pnlCustomerTypeSelect.Visible = True
        End Select
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If IsFormReady() Then
            If ConfirmDialog($"Are you sure you want to add discount '{txtDiscountName.Text}'?") Then
                Dim sql As String = "INSERT INTO discounts (discount_name, discount_type, discount_value, start_date, end_date, item_id, category_id, customer_type, min_quantity, status) " &
                    "VALUES (@discount_name, @discount_type, @discount_value, @start_date, @end_date, @item_id, @category_id, @customer_type, @min_quantity, @status)"

                Dim parameters As New Dictionary(Of String, Object) From {
                    {"@discount_name", Trim(txtDiscountName.Text)},
                    {"@discount_type", cbDiscountType.SelectedItem.ToString()},
                    {"@discount_value", CDbl(txtDiscountValue.Text)},
                    {"@start_date", If(chkNoExpiry.Checked, DBNull.Value, dtpStartDate.Value.Date)},
                    {"@end_date", If(chkNoExpiry.Checked, DBNull.Value, dtpEndDate.Value.Date)},
                    {"@item_id", GetItemId()},
                    {"@category_id", GetCategoryId()},
                    {"@customer_type", GetCustomerType()},
                    {"@min_quantity", CInt(txtMinQuantity.Text)},
                    {"@status", If(cbStatus.SelectedIndex = 0, 1, 0)}
                }

                If InsertDatabase(sql, parameters) Then
                    LogAction(UserSession.UserID, "ADD DISCOUNT", $"Added new discount: {txtDiscountName.Text}", "discounts")
                    ClearField()
                    Dim toast As New ToastForm("Discount added successfully!")
                    toast.Show()
                Else
                    Dim toast As New ToastForm("Insert failed.")
                    toast.Show()
                End If
            End If
        Else
            Dim toast As New ToastForm("Please fill in all required fields!")
            toast.Show()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If IsFormReady() Then
            If ConfirmDialog($"Are you sure you want to update discount '{txtDiscountName.Text}'?") Then
                Dim sql As String = "UPDATE discounts SET " &
                    "discount_name = @discount_name, " &
                    "discount_type = @discount_type, " &
                    "discount_value = @discount_value, " &
                    "start_date = @start_date, " &
                    "end_date = @end_date, " &
                    "item_id = @item_id, " &
                    "category_id = @category_id, " &
                    "customer_type = @customer_type, " &
                    "min_quantity = @min_quantity, " &
                    "status = @status " &
                    "WHERE discount_id = @discount_id"

                Dim parameters As New Dictionary(Of String, Object) From {
                    {"@discount_name", Trim(txtDiscountName.Text)},
                    {"@discount_type", cbDiscountType.SelectedItem.ToString()},
                    {"@discount_value", CDbl(txtDiscountValue.Text)},
                    {"@start_date", If(chkNoExpiry.Checked, DBNull.Value, dtpStartDate.Value.Date)},
                    {"@end_date", If(chkNoExpiry.Checked, DBNull.Value, dtpEndDate.Value.Date)},
                    {"@item_id", GetItemId()},
                    {"@category_id", GetCategoryId()},
                    {"@customer_type", GetCustomerType()},
                    {"@min_quantity", CInt(txtMinQuantity.Text)},
                    {"@status", If(cbStatus.SelectedIndex = 0, 1, 0)},
                    {"@discount_id", CInt(txtID.Text)}
                }

                If UpdateDatabase(sql, parameters) Then
                    LogAction(UserSession.UserID, "UPDATE DISCOUNT", $"Updated discount with id: {txtID.Text}, name: {txtDiscountName.Text}", "discounts", CInt(txtID.Text))
                    ClearField()
                    Dim toast As New ToastForm("Discount updated successfully!")
                    toast.Show()
                Else
                    Dim toast As New ToastForm("Update failed.")
                    toast.Show()
                End If
            End If
        Else
            Dim toast As New ToastForm("Please fill in all required fields!")
            toast.Show()
        End If
    End Sub

    Private Sub dgDiscounts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDiscounts.CellClick
        If dgDiscounts.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgDiscounts.SelectedRows(0)

            ' Populate fields
            txtID.Text = row.Cells("ID").Value.ToString()
            txtDiscountName.Text = row.Cells("Name").Value.ToString()

            ' Set discount type
            Dim discountType As String = row.Cells("Type").Value.ToString()
            cbDiscountType.SelectedItem = discountType

            txtDiscountValue.Text = row.Cells("Value").Value.ToString()

            ' Handle dates
            Dim startVal As String = row.Cells("Start").Value.ToString()
            Dim endVal As String = row.Cells("End").Value.ToString()

            If startVal = "Always" OrElse endVal = "No Expiry" Then
                chkNoExpiry.Checked = True
            Else
                chkNoExpiry.Checked = False
                dtpStartDate.Value = DateTime.Parse(startVal)
                dtpEndDate.Value = DateTime.Parse(endVal)
            End If

            txtMinQuantity.Text = row.Cells("Min Qty").Value.ToString()
            cbStatus.SelectedItem = row.Cells("Status").Value.ToString()

            ' Determine Apply To selection
            Dim itemId = row.Cells("item_id").Value
            Dim categoryId = row.Cells("category_id").Value
            Dim customerType = row.Cells("customer_type").Value

            If itemId IsNot DBNull.Value AndAlso itemId IsNot Nothing Then
                cbApplyTo.SelectedItem = "Specific Item"
                cbItem.SelectedValue = itemId
            ElseIf categoryId IsNot DBNull.Value AndAlso categoryId IsNot Nothing Then
                cbApplyTo.SelectedItem = "Category"
                cbCategory.SelectedValue = categoryId
            ElseIf customerType IsNot DBNull.Value AndAlso customerType IsNot Nothing Then
                cbApplyTo.SelectedItem = "Customer Type"
                cbCustomerType.SelectedItem = customerType.ToString()
            Else
                cbApplyTo.SelectedItem = "All Items"
            End If
        End If

        btnAdd.Enabled = False
        btnUpdate.Enabled = True
    End Sub

    Private Function IsFormReady() As Boolean
        If Trim(txtDiscountName.Text) <> "" AndAlso
           Trim(txtDiscountValue.Text) <> "" AndAlso
           IsNumeric(txtDiscountValue.Text) AndAlso
           cbDiscountType.SelectedIndex >= 0 AndAlso
           cbApplyTo.SelectedIndex >= 0 AndAlso
           IsNumeric(txtMinQuantity.Text) Then

            ' Additional validation based on Apply To selection
            Select Case cbApplyTo.SelectedItem?.ToString()
                Case "Specific Item"
                    Return cbItem.SelectedIndex >= 0
                Case "Category"
                    Return cbCategory.SelectedIndex >= 0
                Case "Customer Type"
                    Return cbCustomerType.SelectedIndex >= 0
                Case Else
                    Return True
            End Select
        End If
        Return False
    End Function

    Private Function GetItemId() As Object
        If cbApplyTo.SelectedItem?.ToString() = "Specific Item" AndAlso cbItem.SelectedValue IsNot Nothing Then
            Return cbItem.SelectedValue
        End If
        Return DBNull.Value
    End Function

    Private Function GetCategoryId() As Object
        If cbApplyTo.SelectedItem?.ToString() = "Category" AndAlso cbCategory.SelectedValue IsNot Nothing Then
            Return cbCategory.SelectedValue
        End If
        Return DBNull.Value
    End Function

    Private Function GetCustomerType() As Object
        If cbApplyTo.SelectedItem?.ToString() = "Customer Type" AndAlso cbCustomerType.SelectedItem IsNot Nothing Then
            Return cbCustomerType.SelectedItem.ToString()
        End If
        Return DBNull.Value
    End Function

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1

        Dim previewForm As Form = TryCast(PrintPreviewDialog1, Form)
        If previewForm IsNot Nothing Then
            previewForm.WindowState = FormWindowState.Maximized
        End If

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim dgvTemp As New DataGridView()

        For Each col As DataGridViewColumn In dgDiscounts.Columns
            If col.Visible Then
                dgvTemp.Columns.Add(col.Name, col.HeaderText)
            End If
        Next

        For Each row As DataGridViewRow In dgDiscounts.Rows
            If Not row.IsNewRow Then
                Dim rowData As New List(Of Object)
                For Each col As DataGridViewColumn In dgDiscounts.Columns
                    If col.Visible Then
                        rowData.Add(row.Cells(col.Index).Value)
                    End If
                Next
                dgvTemp.Rows.Add(rowData.ToArray())
            End If
        Next

        pt.PrintDataGridViewReport(e, dgvTemp, "Discounts Report")
    End Sub
End Class