Imports System.Drawing.Printing

Public Class ReportsForm
    Dim pt As New PrintTemplates
    Dim isLoaded As Boolean = False

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBox(cbUserName, "users", "CONCAT(user_firstname, ' ', user_lastname)", "user_id")
        cbUserName.SelectedIndex = 0
        cbDateRange.SelectedIndex = 0

        ' Auto-load data on startup
        LoadData()
    End Sub

    Private Sub LoadData()
        LoadLogs()
        LoadTransactions()

        lblNDLogs.Visible = (dgLogs.Rows.Count = 0)
        lblNDTransactions.Visible = (dgReports.Rows.Count = 0)

        If dgReports.Rows.Count > 0 Then
            lblTotalTransactions.Text = GetTotalTransactions()
        Else
            lblTotalTransactions.Text = "Qty: 0 | Discount: ₱0.00 | Total: ₱0.00"
        End If

        isLoaded = True
    End Sub

    Private Sub LoadTransactions()
        Dim dateFilter As String = GetDateFilter("s", "updated_at")

        Dim query As String =
        $"SELECT 
            s.updated_at AS Date,
            i.item_code AS Code,
            i.item_name AS Item,
            COALESCE(s.unit_price, i.price) AS Price,
            s.quantity AS Qty,
            COALESCE(s.discount_amount, 0) AS Discount,
            COALESCE(s.total_amount, s.quantity * i.price) AS Total,
            COALESCE(s.customer_type, '-') AS Customer
          FROM items i
          JOIN stock_movements s ON i.item_id = s.item_id
          WHERE s.created_by = '{cbUserName.SelectedValue.ToString}' 
          AND s.movement_type = 'OUT'
          AND {dateFilter}
          ORDER BY s.updated_at DESC
          LIMIT 50"

        LoadDataToGrid(query, dgReports)
        FormatCurrencyColumns(dgReports)
    End Sub

    Private Sub FormatCurrencyColumns(dgv As DataGridView)
        If dgv.Columns.Contains("Price") Then
            dgv.Columns("Price").DefaultCellStyle.Format = "₱#,##0.00"
            dgv.Columns("Price").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If

        If dgv.Columns.Contains("Discount") Then
            dgv.Columns("Discount").DefaultCellStyle.Format = "₱#,##0.00"
            dgv.Columns("Discount").DefaultCellStyle.ForeColor = Color.Green
            dgv.Columns("Discount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If

        If dgv.Columns.Contains("Total") Then
            dgv.Columns("Total").DefaultCellStyle.Format = "₱#,##0.00"
            dgv.Columns("Total").DefaultCellStyle.Font = New Font(dgv.Font, FontStyle.Bold)
            dgv.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If

        If dgv.Columns.Contains("Qty") Then
            dgv.Columns("Qty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

        If dgv.Columns.Contains("Customer") Then
            dgv.Columns("Customer").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
    End Sub

    Private Sub LoadLogs()
        Dim dateFilter As String = GetDateFilter("l", "timestamp")

        Dim query As String =
        $"SELECT 
            l.timestamp AS Date,
            l.action AS Action,
            l.description AS Description
          FROM logs l
          JOIN users u ON l.user_id = u.user_id
          WHERE l.user_id = '{cbUserName.SelectedValue.ToString}' 
          AND {dateFilter}
          ORDER BY l.timestamp DESC
          LIMIT 50"

        LoadDataToGrid(query, dgLogs)
    End Sub

    Private Function GetDateFilter(ByVal tableAlias As String, ByVal columnName As String) As String
        Dim dateFilter As String = ""

        Select Case cbDateRange.SelectedItem?.ToString()
            Case "Today"
                dateFilter = $"DATE({tableAlias}.{columnName}) = CURDATE()"
            Case "Last 7 Days"
                dateFilter = $"{tableAlias}.{columnName} >= DATE_SUB(CURDATE(), INTERVAL 7 DAY)"
            Case "Last 28 Days"
                dateFilter = $"{tableAlias}.{columnName} >= DATE_SUB(CURDATE(), INTERVAL 28 DAY)"
            Case Else
                dateFilter = "1=1"
        End Select

        Return dateFilter
    End Function

    Private Function GetTotalTransactions() As String
        Dim dateFilter As String = GetDateFilter("s", "updated_at")

        Dim query As String =
        $"SELECT 
            COALESCE(SUM(s.quantity), 0) AS total_qty,
            COALESCE(SUM(s.discount_amount), 0) AS total_discount,
            COALESCE(SUM(s.total_amount), SUM(s.quantity * i.price)) AS total_sales
          FROM items i
          JOIN stock_movements s ON i.item_id = s.item_id
          WHERE s.created_by = '{cbUserName.SelectedValue.ToString}' 
          AND s.movement_type = 'OUT'
          AND {dateFilter}"

        Dim dt As DataTable = Read(query)
        If dt.Rows.Count > 0 AndAlso dt.Rows(0)("total_qty") IsNot DBNull.Value Then
            Dim totalQty As Integer = Convert.ToInt32(dt.Rows(0)("total_qty"))
            Dim totalDiscount As Decimal = If(dt.Rows(0)("total_discount") Is DBNull.Value, 0D, Convert.ToDecimal(dt.Rows(0)("total_discount")))
            Dim totalSales As Decimal = If(dt.Rows(0)("total_sales") Is DBNull.Value, 0D, Convert.ToDecimal(dt.Rows(0)("total_sales")))

            Return $"Qty: {totalQty} | Discount: ₱{totalDiscount.ToString("N2")} | Total: ₱{totalSales.ToString("N2")}"
        End If
        Return "Qty: 0 | Discount: ₱0.00 | Total: ₱0.00"
    End Function

    ' Auto-reload when filters change
    Private Sub cbUserName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUserName.SelectedIndexChanged
        If isLoaded Then LoadData()
    End Sub

    Private Sub cbDateRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDateRange.SelectedIndexChanged
        If isLoaded Then LoadData()
    End Sub

    ' Manual refresh button
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
        Dim toast As New ToastForm("Data refreshed!")
        toast.Show()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dgReports.Rows.Count = 0 Then
            Dim toast As New ToastForm("No data to print!")
            toast.Show()
            Return
        End If

        PrintPreviewDialog1.Document = PrintDocument1

        Dim previewForm As Form = TryCast(PrintPreviewDialog1, Form)
        If previewForm IsNot Nothing Then
            previewForm.WindowState = FormWindowState.Maximized
        End If

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim dgvTemp As New DataGridView()

        ' Copy columns
        For Each col As DataGridViewColumn In dgReports.Columns
            dgvTemp.Columns.Add(col.Name, col.HeaderText)
        Next

        ' Copy rows with formatting
        For Each row As DataGridViewRow In dgReports.Rows
            If Not row.IsNewRow Then
                Dim rowData As New List(Of Object)
                For Each col As DataGridViewColumn In dgReports.Columns
                    Dim cellValue = row.Cells(col.Index).Value

                    ' Format currency columns for printing
                    If col.HeaderText = "Price" OrElse col.HeaderText = "Discount" OrElse col.HeaderText = "Total" Then
                        If cellValue IsNot DBNull.Value AndAlso IsNumeric(cellValue) Then
                            cellValue = "₱" & Convert.ToDecimal(cellValue).ToString("#,##0.00")
                        End If
                    End If

                    ' Handle null customer type
                    If col.HeaderText = "Customer" AndAlso (cellValue Is DBNull.Value OrElse cellValue.ToString() = "") Then
                        cellValue = "-"
                    End If

                    rowData.Add(cellValue)
                Next
                dgvTemp.Rows.Add(rowData.ToArray())
            End If
        Next

        ' Print with formatted data
        pt.PrintDataGridViewReport(
            e,
            dgvTemp,
            $"{cbUserName.Text}'s Report ({cbDateRange.SelectedItem.ToString})",
            lblTotalTransactions.Text
        )
    End Sub

End Class