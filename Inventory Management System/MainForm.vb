Imports System.Runtime.InteropServices


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
        LoadFormIntoPanel(New DashboardForm(Me))
        Dim toast As New ToastForm("✔️ Login successful!")
        toast.Show()
        timerDateTime.Start()
        lblUsersName.Text = "Good Day, " + UserSession.UserFirstname + "!"
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
        'Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        HighlightSidebarButton(btnDashboard)
        LoadFormIntoPanel(New DashboardForm(Me))
    End Sub

    Public Sub btnItemList_Click(sender As Object, e As EventArgs) Handles btnItemList.Click
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


    Public Sub LoadFormIntoPanel(childForm As Form)
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

    Public Sub HighlightSidebarButton(selectedButton As Button)
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

    ' Win32 API declarations
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, lParam As Integer) As IntPtr
    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown, lblUsersName.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub

    Private Sub pnlHeader_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDoubleClick, lblUsersName.MouseDoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub pnlHeader_DoubleClick(sender As Object, e As EventArgs) Handles pnlHeader.DoubleClick, lblUsersName.DoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnRestoreDown_Click(sender As Object, e As EventArgs) Handles btnRestoreDown.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            btnRestoreDown.Text = "❐"   ' Restore down symbol
        Else
            Me.WindowState = FormWindowState.Normal
            btnRestoreDown.Text = "▭"   ' Maximize symbol
        End If
    End Sub

    Private Sub btnDiscounts_Click(sender As Object, e As EventArgs) Handles btnDiscounts.Click
        HighlightSidebarButton(btnDiscounts)
        LoadFormIntoPanel(New DiscountsForm())
    End Sub
End Class