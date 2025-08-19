Public Class ConfirmationForm
    Public Property Message As String
    Private Sub ConfirmationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMessage.Text = Message
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub
End Class