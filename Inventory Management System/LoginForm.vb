Public Class LoginForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim uname As String = txtUsername.Text.Trim()
        Dim pword As String = txtPassword.Text.Trim()

        If uname = "" Or pword = "" Then
            Dim toast As New ToastForm("Please enter username and password.")
            toast.Show()
            Return
        End If

        If LoginUser(uname, pword) Then
            Me.Hide()
            Dim mainForm As New MainForm()
            mainForm.Show()
            'txtUsername.Clear()
            'txtPassword.Clear()
        Else
            Dim toast As New ToastForm("❌ Invalid username or password.")
            toast.Show()
        End If
    End Sub

    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        btnShowPassword.Visible = False
        btnHidePassword.Visible = True
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnHidePassword_Click(sender As Object, e As EventArgs) Handles btnHidePassword.Click
        btnShowPassword.Visible = True
        btnHidePassword.Visible = False
        txtPassword.UseSystemPasswordChar = False
    End Sub
End Class
