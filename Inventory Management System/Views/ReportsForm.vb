Imports Windows.Win32.UI.Controls

Public Class ReportsForm


    Private Sub LoadTransactions()
        Dim query As String =
            $"SELECT i.item_code as Code,
                    i.item_name as Item,
                    i.price as Price,
                    s.quantity as Qty,
                    (s.quantity * i.price) as `Sub-total`
              FROM items i
              JOIN stock_movements s ON i.item_id = s.item_id
              WHERE s.created_by = '{cbUserName.SelectedValue.ToString}' AND movement_type = 'IN'
              ORDER BY s.updated_at DESC
              LIMIT 50"

        LoadDataToGrid(query, dgReports)

    End Sub

    Private Sub LoadLogs()
        Dim query As String =
            $"SELECT 
                l.timestamp AS Date,
                l.action AS Action, 
                l.description AS Description
            FROM 
                logs l
            JOIN 
                users u 
            ON 
                l.user_id = u.user_id
            WHERE 
                l.user_id = '{cbUserName.SelectedValue.ToString}'
            ORDER BY 
                l.timestamp DESC
            LIMIT 50"
        LoadDataToGrid(query, dgLogs)

    End Sub

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBox(cbUserName, "users", "CONCAT(user_firstname, ' ', user_lastname)", "user_id")
        cbUserName.SelectedIndex = 0
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadLogs()
        LoadTransactions()
    End Sub
End Class