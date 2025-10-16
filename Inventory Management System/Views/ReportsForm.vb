Imports System.Drawing.Printing
Imports Windows.Win32.UI.Controls

Public Class ReportsForm
    Dim pt As New PrintTemplates
    Dim isLoaded As Boolean = False

    Private Sub LoadTransactions()
        Dim dateFilter As String = GetDateFilter("s", "updated_at")

        Dim query As String =
        $"SELECT 
            s.updated_at AS Date,
            i.item_code AS Code,
            i.item_name AS Item,
            i.price AS Price,
            s.quantity AS Qty,
            (s.quantity * i.price) AS `Sub-total`
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
        End If

        If dgv.Columns.Contains("Sub-total") Then
            dgv.Columns("Sub-total").DefaultCellStyle.Format = "₱#,##0.00"
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

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBox(cbUserName, "users", "CONCAT(user_firstname, ' ', user_lastname)", "user_id")
        cbUserName.SelectedIndex = 0
        cbDateRange.SelectedIndex = 0
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadLogs()
        LoadTransactions()
        lblNDLogs.Visible = (dgLogs.Rows.Count = 0)
        lblNDTransactions.Visible = (dgReports.Rows.Count = 0)
        If Not (dgReports.Rows.Count = 0) Then lblTotalTransactions.Text = GetTotalTransactions() Else lblTotalTransactions.Text = "Total Qty: 0 |  Total: ₱0.00"
        isLoaded = True
    End Sub

    Private Function GetTotalTransactions() As String

        Dim dateFilter As String = GetDateFilter("s", "updated_at")
        Dim query As String =
        $"SELECT 
            SUM(s.quantity) AS 'total-qty',
            SUM(s.quantity * i.price) AS `total`
          FROM items i
          JOIN stock_movements s ON i.item_id = s.item_id
          WHERE s.created_by = '{cbUserName.SelectedValue.ToString}' 
          AND s.movement_type = 'OUT'
          AND {dateFilter}
          ORDER BY s.updated_at DESC
          LIMIT 50"

        Dim dt As DataTable = Read(query)
        If dt.Rows.Count > 0 Then
            Return $"Total Qty: {Convert.ToInt32(dt.Rows(0)("total-qty"))} |  Total: ₱{Convert.ToDecimal(dt.Rows(0)("total")).ToString("N2")}"
        End If
        Return "Total Qty: 0 |  Total: ₱0.00"
    End Function

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If isLoaded Then
            PrintPreviewDialog1.Document = PrintDocument1

            ' Access the internal Form and maximize it
            Dim previewForm As Form = TryCast(PrintPreviewDialog1, Form)
            If previewForm IsNot Nothing Then
                previewForm.WindowState = FormWindowState.Maximized
            End If

            PrintPreviewDialog1.ShowDialog()
            'PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Create a temp DataGridView for printing
        Dim dgvTemp As New DataGridView()

        ' Copy only columns except password
        For Each col As DataGridViewColumn In dgReports.Columns
            If col.Name.ToLower() <> "password" Then
                dgvTemp.Columns.Add(col.Name, col.HeaderText)
            End If
        Next

        ' Copy rows with formatting
        For Each row As DataGridViewRow In dgReports.Rows
            If Not row.IsNewRow Then
                Dim rowData As New List(Of Object)
                For Each col As DataGridViewColumn In dgReports.Columns
                    If col.Name.ToLower() <> "password" Then
                        Dim cellValue = row.Cells(col.Index).Value

                        ' ✅ Format "Price" and "Sub-total" columns
                        If col.HeaderText = "Price" OrElse col.HeaderText = "Sub-total" Then
                            If IsNumeric(cellValue) Then
                                cellValue = "₱" & Convert.ToDecimal(cellValue).ToString("#,##0.00")
                            End If
                        End If

                        rowData.Add(cellValue)
                    End If
                Next
                dgvTemp.Rows.Add(rowData.ToArray())
            End If
        Next

        ' ✅ Print with formatted data
        pt.PrintDataGridViewReport(
            e,
            dgvTemp,
            $"{cbUserName.Text}'s Report ({cbDateRange.SelectedItem.ToString})",
            lblTotalTransactions.Text
        )
    End Sub


End Class