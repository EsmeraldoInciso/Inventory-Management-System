Public Class MainForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnLogout.Click
        UserSession.ClearUserSession()
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HighlightSidebarButton(btnDashboard)
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
        HighlightSidebarButton(btnDashboard)
        LoadFormIntoPanel(New DashboardForm())
    End Sub

    Private Sub btnItemList_Click(sender As Object, e As EventArgs) Handles btnItemList.Click
        HighlightSidebarButton(btnItemList)
        LoadFormIntoPanel(New ItemListForm())
    End Sub

    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        HighlightSidebarButton(btnStockIn)
    End Sub

    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click
        HighlightSidebarButton(btnStockOut)
    End Sub

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        HighlightSidebarButton(btnCategories)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        HighlightSidebarButton(btnReports)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        HighlightSidebarButton(btnUsers)
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

    Private Sub HighlightSidebarButton(selectedButton As Button)
        ' Reset all buttons in the sidebar
        For Each ctrl As Control In pnlSideBar.Controls ' Replace SidebarPanel with your panel name
            If TypeOf ctrl Is Button Then
                ctrl.BackColor = Color.Peru  ' Default color
                ctrl.ForeColor = Color.SaddleBrown      ' Default text color
            End If
        Next

        ' Highlight the selected button
        selectedButton.BackColor = Color.SandyBrown
        selectedButton.ForeColor = Color.SaddleBrown
    End Sub


End Class