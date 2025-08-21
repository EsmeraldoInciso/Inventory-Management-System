
Imports LiveChartsCore
Imports LiveChartsCore.SkiaSharpView
Imports LiveChartsCore.SkiaSharpView.WinForms

Public Class DashboardForm
    Private Sub LoadPieChart()
        ' Query grouped by category
        Dim query As String = "
            SELECT 
                c.category_name AS Category, 
                COUNT(i.item_id) AS Total
            FROM items i
            JOIN categories c ON i.category_id = c.category_id
            GROUP BY c.category_name;
        "

        Dim dt As DataTable = Read(query)

        ' Create chart
        Dim pieChart As New PieChart() With {
        .Dock = DockStyle.Fill
    }

        ' Clear existing panels
        pnlPie.Controls.Clear()

        ' Build series list
        Dim seriesList As New List(Of ISeries)

        For Each row As DataRow In dt.Rows
            Dim categoryName As String = row("Category").ToString()
            Dim totalValue As Double = Convert.ToDouble(row("Total"))

            seriesList.Add(New PieSeries(Of Double) With {
            .Values = New Double() {totalValue},
            .Name = categoryName
        })
        Next

        ' Assign all series at once
        pieChart.Series = seriesList.ToArray()

        pnlPie.Controls.Add(pieChart)
    End Sub



    Private Sub LoadBarChart()
        ' Query: adjust table/column names if different
        Dim query As String = "
        SELECT i.item_name, SUM(m.quantity) AS TotalOut
        FROM stock_movements m
        JOIN items i ON m.item_id = i.item_id
        WHERE m.movement_type = 'OUT'
        GROUP BY i.item_name
        ORDER BY TotalOut DESC
        LIMIT 5;
    "

        Dim dt As DataTable = Read(query)

        ' Prepare lists for chart
        Dim values As New List(Of Double)()
        Dim labels As New List(Of String)()

        For Each row As DataRow In dt.Rows
            values.Add(Convert.ToDouble(row("TotalOut")))
            labels.Add(row("item_name").ToString())
        Next

        Dim barChart As New CartesianChart() With {
        .Dock = DockStyle.Fill
    }

        barChart.Series = {
        New ColumnSeries(Of Double) With {
            .Values = values
        }
    }

        barChart.XAxes = {
        New Axis With {.Labels = labels}
    }

        pnlBar.Controls.Clear()
        pnlBar.Controls.Add(barChart)
    End Sub


    Private Sub LoadLineChart()
        Dim query As String = "
            SELECT 
                DATE(m.created_at) AS MovementDate,
                SUM(CASE WHEN m.movement_type = 'IN' THEN m.quantity ELSE 0 END) AS StockIn,
                SUM(CASE WHEN m.movement_type = 'OUT' THEN m.quantity ELSE 0 END) AS StockOut
            FROM stock_movements m
            WHERE m.created_at >= DATE_SUB(CURDATE(), INTERVAL 30 DAY)
            GROUP BY DATE(m.created_at)
            ORDER BY MovementDate DESC
            LIMIT 7;
        "

        Dim dt As DataTable = Read(query)

        Dim stockInValues As New List(Of Double)()
        Dim stockOutValues As New List(Of Double)()
        Dim labels As New List(Of String)()

        For Each row As DataRow In dt.Rows
            stockInValues.Add(Convert.ToDouble(row("StockIn")))
            stockOutValues.Add(Convert.ToDouble(row("StockOut")))
            labels.Add(Convert.ToDateTime(row("MovementDate")).ToString("MM-dd"))
        Next

        Dim lineChart As New CartesianChart() With {
        .Dock = DockStyle.Fill
    }

        lineChart.Series = {
        New LineSeries(Of Double) With {.Values = stockInValues, .Name = "Stock In"},
        New LineSeries(Of Double) With {.Values = stockOutValues, .Name = "Stock Out"}
    }

        lineChart.XAxes = {
        New Axis With {.Labels = labels}
    }

        pnlLine.Controls.Clear()
        pnlLine.Controls.Add(lineChart)
    End Sub


    Private Function GetTotalStockItem() As Integer
        Dim query As String = "SELECT COUNT(*) AS total FROM items"
        Dim dt As DataTable = Read(query)
        If dt.Rows.Count > 0 Then
            Return Convert.ToInt32(dt.Rows(0)("total"))
        End If
        Return 0
    End Function

    Private Function GetTotalCategories() As Integer
        Dim query As String = "SELECT COUNT(*) AS total FROM categories"
        Dim dt As DataTable = Read(query)
        If dt.Rows.Count > 0 Then
            Return Convert.ToInt32(dt.Rows(0)("total"))
        End If
        Return 0
    End Function

    Private Function GetTotalLowStock() As Integer
        Dim query As String = "SELECT COUNT(*) AS total FROM items i JOIN stock_levels s ON i.item_id = s.item_id WHERE s.quantity_on_hand <= i.reorder_level"
        Dim dt As DataTable = Read(query)
        If dt.Rows.Count > 0 Then
            Return Convert.ToInt32(dt.Rows(0)("total"))
        End If
        Return 0
    End Function

    Public Sub LoadAllItems()
        Dim query As String =
            "SELECT 
                item_code AS Code, 
                item_name AS Name, 
                description AS Description,
                unit as Unit,
                s.quantity_on_hand as SOH
            FROM items i JOIN stock_levels s ON i.item_id = s.item_id WHERE s.quantity_on_hand <= i.reorder_level
            LIMIT 50"
        LoadDataToGrid(query, dgLowStocks)
    End Sub

    Public Sub LoadAllRecentStockMovement()
        Dim query As String =
            "SELECT
                sm.created_at AS Date,
                sm.movement_type as 'Type',
                sm.quantity AS Quantity,
                u.user_firstname as 'By'
            FROM stock_movements sm
            JOIN users u
            ON u.user_id = sm.created_by
            ORDER BY sm.created_at DESC
            LIMIT 15"
        LoadDataToGrid(query, dgRecentStockInOut)
    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPieChart()
        LoadBarChart()
        LoadLineChart()
        lblTotalStockItems.Text = GetTotalStockItem().ToString()
        lblCategories.Text = GetTotalCategories().ToString()
        lblLowStockAlerts.Text = GetTotalLowStock().ToString()
        LoadAllItems()
        LoadAllRecentStockMovement()
    End Sub
End Class