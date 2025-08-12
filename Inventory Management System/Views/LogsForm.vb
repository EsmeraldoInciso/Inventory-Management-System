Public Class LogsForm
    Private Sub LogsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllUsers()
    End Sub

    Private Sub LoadAllUsers()
        Dim query As String =
            "SELECT 
                l.timestamp AS Date,
                l.action AS Action, 
                l.description AS Description, 
                CONCAT(u.user_firstname, ' ', u.user_lastname) AS 'Performed By'
            FROM 
                logs l
            JOIN 
                users u 
            ON 
                l.user_id = u.user_id
            ORDER BY 
                l.timestamp DESC
            LIMIT 50"
        LoadDataToGrid(query, dgLogs)

    End Sub
End Class