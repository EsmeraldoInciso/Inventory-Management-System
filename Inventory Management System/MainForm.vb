Public Class MainForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnLogout.Click
        If ConfirmDialog("Are you sure you want to logout?") Then
            LogAction(UserSession.UserID, "LOGOUT", "User logged out successfully")
            UserSession.ClearUserSession()
            Me.Hide()
            LoginForm.Show()
        End If

        'Dim confirm As New ConfirmationForm()
        'confirm.Message = "Are you sure you want to logout?"
        'If confirm.ShowDialog() = DialogResult.Yes Then

        'End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HighlightSidebarButton(btnDashboard)
        If UserSession.UserType <> 1 Then
            btnUsers.Visible = False
            btnCategories.Visible = False
            btnReports.Visible = False
            btnLogs.Visible = False
        End If
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
        HighlightSidebarButton(btnDashboard)
        LoadFormIntoPanel(New DashboardForm())
    End Sub

    Private Sub btnItemList_Click(sender As Object, e As EventArgs) Handles btnItemList.Click
        HighlightSidebarButton(btnItemList)
        LoadFormIntoPanel(New ItemListForm())
    End Sub

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        HighlightSidebarButton(btnCategories)
        LoadFormIntoPanel(New CategoriesForm())
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        HighlightSidebarButton(btnReports)
        LoadFormIntoPanel(New ReportsForm())
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        HighlightSidebarButton(btnUsers)
        LoadFormIntoPanel(New UsersForm())
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        HighlightSidebarButton(btnLogs)
        LoadFormIntoPanel(New LogsForm())
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

    Private Sub HighlightSidebarButton(selectedButton As Button)
        ' Reset all buttons in the sidebar
        For Each ctrl As Control In pnlSideBar.Controls ' Replace SidebarPanel with your panel name
            If TypeOf ctrl Is Button Then
                ctrl.BackColor = Color.FromArgb(255, 220, 220, 220)  ' Default color
                ctrl.ForeColor = Color.FromArgb(255, 33, 33, 33)
            End If
        Next

        ' Highlight the selected button
        selectedButton.BackColor = Color.FromArgb(255, 250, 250, 250)
        selectedButton.ForeColor = Color.FromArgb(255, 33, 33, 33)
    End Sub

    Private Sub MainForm_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        LogAction(UserSession.UserID, "LOGOUT", "User logged out successfully")
    End Sub
End Class