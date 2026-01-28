Public Class StockOutForm
    Dim movementID As Integer
    Dim dgvToolTip As New ToolTip()
    Private _itemList As ItemListForm

    ' Discount-related variables
    Private unitPrice As Double = 0
    Private categoryId As Integer = 0
    Private promoDiscountAmount As Double = 0
    Private promoDiscountName As String = ""
    Private promoDiscountValue As Double = 0
    Private promoDiscountType As String = ""
    Private customerDiscountAmount As Double = 0
    Private customerDiscountName As String = ""
    Private customerDiscountValue As Double = 0
    Private customerDiscountType As String = ""

    Public Sub New(itemList As ItemListForm)
        InitializeComponent()
        _itemList = itemList
    End Sub

    Private Sub StockOutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearField()
        txtID.Text = ItemSession.ItemID
        txtItemCode.Text = ItemSession.ItemCode
        txtItemName.Text = ItemSession.ItemName

        ' Load item price and category
        LoadItemDetails()

        ' Set default customer type
        cbCustomerType.SelectedIndex = 0

        dgvToolTip.AutoPopDelay = 5000
        dgvToolTip.InitialDelay = 500
        dgvToolTip.ReshowDelay = 100
        dgvToolTip.ShowAlways = True

        AddHandler dgStockOut.MouseMove, AddressOf ShowGridToolTip
    End Sub

    Private Sub ShowGridToolTip(sender As Object, e As MouseEventArgs)
        dgvToolTip.SetToolTip(dgStockOut, "Double Tap To Select Data.")
    End Sub

    Private Sub LoadItemDetails()
        Dim query As String = "SELECT price, category_id FROM items WHERE item_id = @id"
        Dim params As New Dictionary(Of String, Object) From {
            {"@id", ItemSession.ItemID}
        }
        Dim dt As DataTable = Read(query, params)

        If dt.Rows.Count > 0 Then
            unitPrice = Convert.ToDouble(dt.Rows(0)("price"))
            categoryId = Convert.ToInt32(dt.Rows(0)("category_id"))
            txtUnitPrice.Text = unitPrice.ToString("₱#,##0.00")
        End If

        ' Check for promo discount
        LoadPromoDiscount()
    End Sub

    Private Sub LoadPromoDiscount()
        ' Get item or category discount
        Dim query As String = "
            SELECT discount_id, discount_name, discount_type, discount_value 
            FROM discounts 
            WHERE status = 1 
            AND customer_type IS NULL
            AND (CURDATE() BETWEEN start_date AND end_date 
                 OR (start_date IS NULL AND end_date IS NULL))
            AND (item_id = @itemId 
                 OR category_id = @categoryId 
                 OR (item_id IS NULL AND category_id IS NULL))
            ORDER BY 
                CASE WHEN item_id IS NOT NULL THEN 1
                     WHEN category_id IS NOT NULL THEN 2
                     ELSE 3 END
            LIMIT 1"

        Dim params As New Dictionary(Of String, Object) From {
            {"@itemId", ItemSession.ItemID},
            {"@categoryId", categoryId}
        }
        Dim dt As DataTable = Read(query, params)

        If dt.Rows.Count > 0 Then
            promoDiscountType = dt.Rows(0)("discount_type").ToString()
            promoDiscountValue = Convert.ToDouble(dt.Rows(0)("discount_value"))
            promoDiscountName = dt.Rows(0)("discount_name").ToString()

            If promoDiscountType = "percentage" Then
                txtPromoDiscount.Text = $"-{promoDiscountValue}%"
                promoDiscountAmount = unitPrice * (promoDiscountValue / 100)
            Else
                txtPromoDiscount.Text = $"-₱{promoDiscountValue.ToString("#,##0.00")}"
                promoDiscountAmount = promoDiscountValue
            End If
        Else
            txtPromoDiscount.Text = "-"
            promoDiscountAmount = 0
            promoDiscountValue = 0
            promoDiscountType = ""
            promoDiscountName = ""
        End If

        CalculateTotals()
    End Sub

    Private Sub cbCustomerType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCustomerType.SelectedIndexChanged
        Dim customerType As String = cbCustomerType.SelectedItem?.ToString()

        ' Show/hide ID field for Senior/PWD
        If customerType = "Senior Citizen" OrElse customerType = "PWD" Then
            pnlIdNumber.Visible = True
            txtIdNumber.Focus()
        Else
            pnlIdNumber.Visible = False
            txtIdNumber.Clear()
        End If

        ' Load customer discount
        LoadCustomerDiscount()
    End Sub

    Private Sub LoadCustomerDiscount()
        Dim customerType As String = cbCustomerType.SelectedItem?.ToString()

        If customerType = "Regular" OrElse String.IsNullOrEmpty(customerType) Then
            txtCustomerDiscount.Text = "-"
            customerDiscountAmount = 0
            customerDiscountValue = 0
            customerDiscountType = ""
            customerDiscountName = ""
            CalculateTotals()
            Return
        End If

        ' Map UI selection to database value
        Dim dbCustomerType As String = ""
        If customerType = "Senior Citizen" Then
            dbCustomerType = "senior"
        ElseIf customerType = "PWD" Then
            dbCustomerType = "pwd"
        End If

        Dim query As String = "
            SELECT discount_id, discount_name, discount_type, discount_value 
            FROM discounts 
            WHERE status = 1 
            AND customer_type = @customerType
            AND (CURDATE() BETWEEN start_date AND end_date 
                 OR (start_date IS NULL AND end_date IS NULL))
            LIMIT 1"

        Dim params As New Dictionary(Of String, Object) From {
            {"@customerType", dbCustomerType}
        }
        Dim dt As DataTable = Read(query, params)

        If dt.Rows.Count > 0 Then
            customerDiscountType = dt.Rows(0)("discount_type").ToString()
            customerDiscountValue = Convert.ToDouble(dt.Rows(0)("discount_value"))
            customerDiscountName = dt.Rows(0)("discount_name").ToString()

            If customerDiscountType = "percentage" Then
                txtCustomerDiscount.Text = $"-{customerDiscountValue}% ({customerType})"
            Else
                txtCustomerDiscount.Text = $"-₱{customerDiscountValue.ToString("#,##0.00")} ({customerType})"
            End If

            ' Store for calculation
            customerDiscountAmount = customerDiscountValue
        Else
            txtCustomerDiscount.Text = "-"
            customerDiscountAmount = 0
            customerDiscountValue = 0
            customerDiscountType = ""
            customerDiscountName = ""
        End If

        CalculateTotals()
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        CalculateTotals()
    End Sub

    Private Function GetCalculatedTotals() As (Subtotal As Double, TotalDiscount As Double, Total As Double)
        Dim quantity As Integer = 0
        If IsNumeric(txtQuantity.Text) AndAlso CInt(txtQuantity.Text) > 0 Then
            quantity = CInt(txtQuantity.Text)
        End If

        ' Calculate discounted unit price (after promo)
        Dim discountedUnitPrice As Double = unitPrice - promoDiscountAmount
        If discountedUnitPrice < 0 Then discountedUnitPrice = 0

        ' Calculate subtotal
        Dim subtotal As Double = discountedUnitPrice * quantity

        ' Calculate promo discount total
        Dim totalPromoDiscount As Double = promoDiscountAmount * quantity

        ' Apply customer discount (Senior/PWD) to subtotal
        Dim customerDiscountTotal As Double = 0
        If customerDiscountAmount > 0 Then
            Dim customerType As String = cbCustomerType.SelectedItem?.ToString()
            If customerType = "Senior Citizen" OrElse customerType = "PWD" Then
                If customerDiscountType = "percentage" Then
                    customerDiscountTotal = subtotal * (customerDiscountAmount / 100)
                Else
                    customerDiscountTotal = customerDiscountAmount
                End If
            End If
        End If

        ' Calculate total discount
        Dim totalDiscount As Double = totalPromoDiscount + customerDiscountTotal

        ' Calculate total
        Dim total As Double = subtotal - customerDiscountTotal
        If total < 0 Then total = 0

        Return (subtotal, totalDiscount, total)
    End Function

    Private Sub CalculateTotals()
        Dim totals = GetCalculatedTotals()

        txtSubtotal.Text = totals.Subtotal.ToString("₱#,##0.00")
        txtTotal.Text = totals.Total.ToString("₱#,##0.00")
    End Sub

    Private Sub LoadAllStockOut()
        Dim query As String =
            "SELECT 
                movement_id,
                created_at AS Date, 
                quantity AS Quantity,
                unit_price AS 'Unit Price',
                discount_amount AS 'Discount',
                total_amount AS 'Total',
                customer_type AS 'Customer',
                reference_no AS 'Reference No.',
                remarks AS Remarks
            FROM stock_movements
            WHERE movement_type = 'OUT' AND item_id = " & ItemSession.ItemID & " AND created_by = " & UserSession.UserID & "
            ORDER BY created_at DESC
            LIMIT 50"
        LoadDataToGrid(query, dgStockOut)
        dgStockOut.Columns("movement_id").Visible = False

        ' Format currency columns
        If dgStockOut.Columns.Contains("Unit Price") Then
            dgStockOut.Columns("Unit Price").DefaultCellStyle.Format = "₱#,##0.00"
        End If
        If dgStockOut.Columns.Contains("Discount") Then
            dgStockOut.Columns("Discount").DefaultCellStyle.Format = "₱#,##0.00"
        End If
        If dgStockOut.Columns.Contains("Total") Then
            dgStockOut.Columns("Total").DefaultCellStyle.Format = "₱#,##0.00"
        End If
    End Sub

    Private Sub ClearField()
        LoadAllStockOut()
        txtQuantity.Clear()
        txtReferenceNo.Clear()
        txtRemarks.Clear()
        txtIdNumber.Clear()
        cbCustomerType.SelectedIndex = 0
        pnlIdNumber.Visible = False
        btnDeduct.Enabled = True
        btnUpdate.Enabled = False
        CalculateTotals()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnDeduct.Click
        If IsFormReady() Then
            If CheckItemCount() Then
                ' Validate ID number for Senior/PWD
                Dim selectedCustomerType As String = cbCustomerType.SelectedItem?.ToString()
                If (selectedCustomerType = "Senior Citizen" OrElse selectedCustomerType = "PWD") AndAlso String.IsNullOrWhiteSpace(txtIdNumber.Text) Then
                    Dim toast As New ToastForm("ID Number is required for Senior/PWD discount!")
                    toast.Show()
                    Return
                End If

                If ConfirmDialog($"Confirm stock-out? Total: {txtTotal.Text}") Then
                    ' Get calculated totals
                    Dim totals = GetCalculatedTotals()

                    ' Build remarks with discount info
                    Dim remarksText As String = Trim(txtRemarks.Text)
                    If Not String.IsNullOrEmpty(promoDiscountName) Then
                        remarksText &= If(String.IsNullOrEmpty(remarksText), "", " | ") & $"Promo: {promoDiscountName}"
                    End If
                    If Not String.IsNullOrEmpty(customerDiscountName) Then
                        remarksText &= If(String.IsNullOrEmpty(remarksText), "", " | ") & $"{customerDiscountName}"
                    End If

                    ' Determine customer type for database
                    Dim dbCustomerType As Object = DBNull.Value
                    Dim dbCustomerIdNumber As Object = DBNull.Value
                    If selectedCustomerType = "Senior Citizen" Then
                        dbCustomerType = "Senior"
                        dbCustomerIdNumber = txtIdNumber.Text
                    ElseIf selectedCustomerType = "PWD" Then
                        dbCustomerType = "PWD"
                        dbCustomerIdNumber = txtIdNumber.Text
                    End If

                    Dim sql As String = "INSERT INTO stock_movements (item_id, movement_type, quantity, unit_price, discount_amount, total_amount, customer_type, customer_id_number, reference_no, remarks, created_by) " &
                        "VALUES (@item_id, @movement_type, @quantity, @unit_price, @discount_amount, @total_amount, @customer_type, @customer_id_number, @reference_no, @remarks, @created_by)"

                    Dim parameters As New Dictionary(Of String, Object) From {
                        {"@item_id", Trim(txtID.Text)},
                        {"@movement_type", "OUT"},
                        {"@quantity", Trim(txtQuantity.Text)},
                        {"@unit_price", unitPrice},
                        {"@discount_amount", totals.TotalDiscount},
                        {"@total_amount", totals.Total},
                        {"@customer_type", dbCustomerType},
                        {"@customer_id_number", dbCustomerIdNumber},
                        {"@reference_no", Trim(txtReferenceNo.Text)},
                        {"@remarks", Trim(remarksText)},
                        {"@created_by", UserSession.UserID}
                    }

                    If InsertDatabase(sql, parameters) Then
                        LogAction(UserSession.UserID, "STOCK-OUT", $"Sold {txtQuantity.Text} {ItemSession.ItemUnit} of {txtItemName.Text} | Total: {txtTotal.Text}", "stock_movements")
                        ClearField()
                        Dim toast As New ToastForm("Stock-out recorded successfully!")
                        toast.Show()
                        _itemList.LoadAllItems("")
                    Else
                        Dim toast As New ToastForm("Insert failed.")
                        toast.Show()
                    End If
                End If
            Else
                Dim toast As New ToastForm("Insufficient Stock-On-Hand.")
                toast.Show()
            End If
        Else
            Dim toast As New ToastForm("Quantity is required!")
            toast.Show()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim loginForm As New ValidationForm()

        If loginForm.ShowDialog() = DialogResult.OK AndAlso loginForm.IsLoginSuccessful Then
            If IsFormReady() Then
                If CheckItemCount() Then
                    If ConfirmDialog($"Confirm update stock-out?") Then
                        ' Get calculated totals
                        Dim totals = GetCalculatedTotals()

                        ' Determine customer type for database
                        Dim selectedCustomerType As String = cbCustomerType.SelectedItem?.ToString()
                        Dim dbCustomerType As Object = DBNull.Value
                        Dim dbCustomerIdNumber As Object = DBNull.Value
                        If selectedCustomerType = "Senior Citizen" Then
                            dbCustomerType = "Senior"
                            dbCustomerIdNumber = txtIdNumber.Text
                        ElseIf selectedCustomerType = "PWD" Then
                            dbCustomerType = "PWD"
                            dbCustomerIdNumber = txtIdNumber.Text
                        End If

                        Dim sql As String = "UPDATE stock_movements SET " &
                            "quantity = @quantity, " &
                            "unit_price = @unit_price, " &
                            "discount_amount = @discount_amount, " &
                            "total_amount = @total_amount, " &
                            "customer_type = @customer_type, " &
                            "customer_id_number = @customer_id_number, " &
                            "reference_no = @reference_no, " &
                            "remarks = @remarks " &
                            "WHERE movement_id = @movement_id"

                        Dim parameters As New Dictionary(Of String, Object) From {
                            {"@quantity", Trim(txtQuantity.Text)},
                            {"@unit_price", unitPrice},
                            {"@discount_amount", totals.TotalDiscount},
                            {"@total_amount", totals.Total},
                            {"@customer_type", dbCustomerType},
                            {"@customer_id_number", dbCustomerIdNumber},
                            {"@reference_no", Trim(txtReferenceNo.Text)},
                            {"@remarks", Trim(txtRemarks.Text)},
                            {"@movement_id", CInt(movementID)}
                        }

                        If UpdateDatabase(sql, parameters) Then
                            LogAction(UserSession.UserID, "STOCK-OUT", $"Updated entry id: {movementID} | Total: {txtTotal.Text}", "stock_movements")
                            ClearField()
                            Dim toast As New ToastForm("Stock-out updated successfully!")
                            toast.Show()
                            _itemList.LoadAllItems("")
                        Else
                            Dim toast As New ToastForm("Update failed.")
                            toast.Show()
                        End If
                    End If
                Else
                    Dim toast As New ToastForm("Insufficient Stock-On-Hand.")
                    toast.Show()
                End If
            Else
                Dim toast As New ToastForm("All Fields are required!")
                toast.Show()
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearField()
    End Sub

    Private Sub dgStockOut_SelectionChanged(sender As Object, e As EventArgs) Handles dgStockOut.CellDoubleClick
        If dgStockOut.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgStockOut.SelectedRows(0)

            ' Populate textboxes
            movementID = CInt(row.Cells("movement_id").Value)
            txtQuantity.Text = row.Cells("Quantity").Value.ToString()
            txtReferenceNo.Text = If(row.Cells("Reference No.").Value IsNot DBNull.Value, row.Cells("Reference No.").Value.ToString(), "")
            txtRemarks.Text = If(row.Cells("Remarks").Value IsNot DBNull.Value, row.Cells("Remarks").Value.ToString(), "")

            ' Load customer type if exists
            If row.Cells("Customer").Value IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(row.Cells("Customer").Value.ToString()) Then
                Dim custType As String = row.Cells("Customer").Value.ToString()
                If custType = "Senior" Then
                    cbCustomerType.SelectedItem = "Senior Citizen"
                ElseIf custType = "PWD" Then
                    cbCustomerType.SelectedItem = "PWD"
                Else
                    cbCustomerType.SelectedIndex = 0
                End If
            Else
                cbCustomerType.SelectedIndex = 0
            End If

            btnDeduct.Enabled = False
            btnUpdate.Enabled = True
        End If
    End Sub

    Private Function IsFormReady() As Boolean
        If Trim(txtQuantity.Text) <> "" AndAlso IsNumeric(txtQuantity.Text) Then
            Return True
        End If
        Return False
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ItemSession.ClearItemSession()
        Me.Close()
    End Sub

    Private Function CheckItemCount() As Boolean
        Dim query As String = "SELECT quantity_on_hand FROM stock_levels WHERE item_id = @id"
        Dim params As New Dictionary(Of String, Object) From {
            {"@id", txtID.Text}
        }
        Dim dt As DataTable = Read(query, params)

        If dt.Rows.Count > 0 Then
            Dim stock As Integer = Convert.ToInt32(dt.Rows(0)("quantity_on_hand"))
            Dim requested As Integer = Convert.ToInt32(txtQuantity.Text)

            If stock >= requested Then
                Return True
            End If
        End If

        Return False
    End Function
End Class