Imports System.Drawing.Printing


Public Class UsersForm
    Dim currentRow As Integer = 0
    Dim totalWidth As Integer = 0
    Dim columnLefts As New List(Of Integer)()
    Dim columnWidths As New List(Of Integer)()
    Dim cellHeight As Integer = 0
    Dim headerHeight As Integer = 0
    Dim pt As New PrintTemplates
    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllUsers()
        dgUsers.ClearSelection()
    End Sub

    Private Sub LoadAllUsers()
        Dim query As String =
            "SELECT 
                user_id AS ID, 
                user_firstname AS Firstname, 
                user_lastname AS Lastname, 
                username AS Username, 
                CASE 
                    WHEN user_type = 1 THEN 'Admin' 
                    ELSE 'User' 
                END AS Role,
                CASE
                    WHEN status = 1 THEN 'Active'
                    ELSE 'Inactive'
                END AS Status 
            FROM users"
        LoadDataToGrid(query, dgUsers)
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
        pt.PrintDataGridViewReport(e, dgUsers, "Users Report")
    End Sub

End Class