Public Class ValidationForm
    Public Property IsLoginSuccessful As Boolean = False

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim uname As String = txtUsername.Text.Trim()
        Dim pword As String = txtPassword.Text.Trim()

        If uname = "" Or pword = "" Then
            Dim toast As New ToastForm("Please enter password.")
            toast.Show()
            Return
        End If

        If LoginUser(uname, pword) Then
            IsLoginSuccessful = True
            Me.DialogResult = DialogResult.OK  ' ✅ Signals success
            Me.Close()
        Else
            Dim toast As New ToastForm("❌ Invalid password.")
            toast.Show()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        IsLoginSuccessful = False
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ValidationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = UserSession.Username
    End Sub
End Class
