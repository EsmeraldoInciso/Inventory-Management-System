Public Class MainForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnLogout.Click
        UserSession.ClearUserSession()
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UserSession.UserType <> 1 Then btnUsers.Visible = False
        LoadFormIntoPanel(New DashboardForm())
        Dim toast As New ToastForm("✔️ Login successful!")
        toast.Show()
        timerDateTime.Start()
        lblUsersName.Text = "Good Day, " + UserSession.UserFirstname + "!"
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        LoadFormIntoPanel(New DashboardForm())
    End Sub

    Private Sub btnItemList_Click(sender As Object, e As EventArgs) Handles btnItemList.Click
        LoadFormIntoPanel(New ItemListForm())
    End Sub

    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click

    End Sub

    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click

    End Sub

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        LoadFormIntoPanel(New UsersForm())
    End Sub

    Private Sub timerDateTime_Tick(sender As Object, e As EventArgs) Handles timerDateTime.Tick
        lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy")
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub


    Private Sub LoadFormIntoPanel(childForm As Form)
        ' Clear existing controls
        pnlDisplay.Controls.Clear()

        ' Configure the child form
        With childForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
        End With

        ' Add and show it in the panel
        pnlDisplay.Controls.Add(childForm)
        childForm.Show()
    End Sub


End Class