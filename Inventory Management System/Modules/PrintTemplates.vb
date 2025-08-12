Imports System.Drawing.Printing

Public Class PrintTemplates
    Public Sub PrintDataGridViewReport(e As PrintPageEventArgs, dgv As DataGridView, reportTitle As String)
        ' Static values persist across multiple pages
        Static currentRow As Integer = 0
        Static columnLefts As New List(Of Integer)
        Static columnWidths As New List(Of Integer)
        Static totalWidth As Integer = 0

        Dim cellHeight As Integer = 0
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top
        Dim tempWidth As Integer = 0
        Dim i As Integer

        ' === Draw Report Title and Date ===
        Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
        Dim dateFont As New Font("Arial", 12, FontStyle.Regular)
        Dim reportDate As String = DateTime.Now.ToString("MMMM dd, yyyy")

        ' Title on left
        e.Graphics.DrawString(reportTitle, titleFont, Brushes.Black, leftMargin, topMargin - 40)

        ' Date on right
        Dim dateSize As SizeF = e.Graphics.MeasureString(reportDate, dateFont)
        Dim dateX As Single = e.MarginBounds.Right - dateSize.Width
        e.Graphics.DrawString(reportDate, dateFont, Brushes.Black, dateX, topMargin - 40)

        topMargin += 10

        ' === Setup Columns Once (on first page only) ===
        If currentRow = 0 Then
            columnLefts.Clear()
            columnWidths.Clear()
            totalWidth = 0

            For Each column As DataGridViewColumn In dgv.Columns
                totalWidth += column.Width
            Next

            For Each column As DataGridViewColumn In dgv.Columns
                tempWidth = CType(Math.Floor(CType(column.Width, Double) / totalWidth * e.MarginBounds.Width), Integer)
                columnLefts.Add(leftMargin)
                columnWidths.Add(tempWidth)
                leftMargin += tempWidth
            Next
        End If

        ' === Draw Column Headers ===
        Dim headerFont As New Font("Arial", 10, FontStyle.Bold)
        cellHeight = dgv.Rows(0).Height + 5 ' Estimate cell height from first row
        For i = 0 To dgv.Columns.Count - 1
            e.Graphics.FillRectangle(Brushes.LightGray, New Rectangle(columnLefts(i), topMargin, columnWidths(i), cellHeight))
            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(columnLefts(i), topMargin, columnWidths(i), cellHeight))
            e.Graphics.DrawString(dgv.Columns(i).HeaderText, headerFont, Brushes.Black,
                                  New RectangleF(columnLefts(i), topMargin, columnWidths(i), cellHeight))
        Next
        topMargin += cellHeight

        ' === Draw Rows ===
        Dim isLastPage As Boolean = True
        Dim count As Integer = currentRow

        While count < dgv.Rows.Count
            Dim row As DataGridViewRow = dgv.Rows(count)
            cellHeight = row.Height + 5

            ' Check for page break (reserve space for footer)
            If topMargin + cellHeight >= e.MarginBounds.Bottom - 40 Then
                isLastPage = False
                e.HasMorePages = True
                Return
            End If

            ' Draw cells
            For i = 0 To dgv.Columns.Count - 1
                e.Graphics.DrawRectangle(Pens.Black, New Rectangle(columnLefts(i), topMargin, columnWidths(i), cellHeight))
                e.Graphics.DrawString(row.Cells(i).Value?.ToString(), dgv.Font, Brushes.Black,
                                      New RectangleF(columnLefts(i), topMargin, columnWidths(i), cellHeight))
            Next

            topMargin += cellHeight
            count += 1
            currentRow += 1
        End While

        ' === Draw Footer (Item Count) on Last Page Only ===
        If isLastPage Then
            Dim footerText As String = "Row Count: " & dgv.Rows.Count.ToString()
            Dim footerFont As New Font("Arial", 12, FontStyle.Regular)
            Dim textSize As SizeF = e.Graphics.MeasureString(footerText, footerFont)
            Dim footerX As Single = e.MarginBounds.Right - textSize.Width
            Dim footerY As Single = topMargin + 10
            e.Graphics.DrawString(footerText, footerFont, Brushes.Black, footerX, footerY)
        End If

        ' === Cleanup if last page ===
        If isLastPage Then
            currentRow = 0
            e.HasMorePages = False
        End If
    End Sub

End Class
