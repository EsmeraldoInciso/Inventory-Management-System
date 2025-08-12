Imports System.Diagnostics
Imports System.IO
Imports System.ServiceProcess
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
            LogAction(UserSession.UserID, "LOGIN", "User logged in successfully")
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

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartApache()
        StartMySQL()
    End Sub

    ' -------------------
    ' Apache Starter
    ' -------------------
    Private Sub StartApache()
        If Not StartServiceIfExists("apache") Then
            ' Fallback: run httpd.exe directly (no CMD window)
            Dim apacheExe As String = "C:\xampp\apache\bin\httpd.exe"
            If File.Exists(apacheExe) AndAlso Not IsProcessRunning("httpd") Then
                Dim psi As New ProcessStartInfo(apacheExe)
                psi.CreateNoWindow = True
                psi.UseShellExecute = False
                Process.Start(psi)
            End If
        End If
    End Sub

    ' -------------------
    ' MySQL Starter
    ' -------------------
    Private Sub StartMySQL()
        If Not StartServiceIfExists("mysql") Then
            ' Fallback: run mysqld.exe directly (no CMD window)
            Dim mysqlExe As String = "C:\xampp\mysql\bin\mysqld.exe"
            If File.Exists(mysqlExe) AndAlso Not IsProcessRunning("mysqld") Then
                Dim psi As New ProcessStartInfo(mysqlExe)
                psi.CreateNoWindow = True
                psi.UseShellExecute = False
                Process.Start(psi)
            End If
        End If
    End Sub

    ' -------------------
    ' Try to start a service if it exists
    ' -------------------
    Private Function StartServiceIfExists(partialName As String) As Boolean
        Try
            Dim services = ServiceController.GetServices().
                Where(Function(s) s.ServiceName.ToLower().Contains(partialName.ToLower())).ToList()

            If services.Any() Then
                For Each svc In services
                    If svc.Status = ServiceControllerStatus.Stopped OrElse svc.Status = ServiceControllerStatus.Paused Then
                        Process.Start("cmd.exe", "/c net start """ & svc.ServiceName & """")
                    End If
                Next
                Return True
            End If
        Catch
            ' ignore errors and return false
        End Try
        Return False
    End Function

    ' -------------------
    ' Check if a process is running
    ' -------------------
    Private Function IsProcessRunning(procName As String) As Boolean
        Return Process.GetProcessesByName(procName).Length > 0
    End Function
End Class
