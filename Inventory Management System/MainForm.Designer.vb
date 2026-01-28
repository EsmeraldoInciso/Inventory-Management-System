<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        btnClose = New Button()
        pnlSideBar = New Panel()
        Label1 = New Label()
        btnLogs = New Button()
        btnUsers = New Button()
        btnReports = New Button()
        btnDiscounts = New Button()
        btnCategories = New Button()
        lblTime = New Label()
        lblDate = New Label()
        btnLogout = New Button()
        btnItemList = New Button()
        btnDashboard = New Button()
        Panel1 = New Panel()
        pnlHeader = New Panel()
        btnRestoreDown = New Button()
        lblUsersName = New Label()
        btnMinimize = New Button()
        pnlDisplay = New Panel()
        timerDateTime = New Timer(components)
        pnlSideBar.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnClose.Location = New Point(1034, 6)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(30, 30)
        btnClose.TabIndex = 5
        btnClose.TabStop = False
        btnClose.Text = "x"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' pnlSideBar
        ' 
        pnlSideBar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnlSideBar.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        pnlSideBar.Controls.Add(Label1)
        pnlSideBar.Controls.Add(btnLogs)
        pnlSideBar.Controls.Add(btnUsers)
        pnlSideBar.Controls.Add(btnReports)
        pnlSideBar.Controls.Add(btnDiscounts)
        pnlSideBar.Controls.Add(btnCategories)
        pnlSideBar.Controls.Add(lblTime)
        pnlSideBar.Controls.Add(lblDate)
        pnlSideBar.Controls.Add(btnLogout)
        pnlSideBar.Controls.Add(btnItemList)
        pnlSideBar.Controls.Add(btnDashboard)
        pnlSideBar.Controls.Add(Panel1)
        pnlSideBar.Location = New Point(0, 0)
        pnlSideBar.Name = "pnlSideBar"
        pnlSideBar.Size = New Size(300, 788)
        pnlSideBar.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold Or FontStyle.Italic)
        Label1.ForeColor = Color.Gainsboro
        Label1.Location = New Point(15, 160)
        Label1.Name = "Label1"
        Label1.Size = New Size(270, 35)
        Label1.TabIndex = 11
        Label1.Text = "Tazza Coffee Shop"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLogs
        ' 
        btnLogs.BackColor = Color.Gainsboro
        btnLogs.Cursor = Cursors.Hand
        btnLogs.FlatAppearance.BorderColor = Color.SandyBrown
        btnLogs.FlatAppearance.BorderSize = 0
        btnLogs.FlatStyle = FlatStyle.Flat
        btnLogs.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnLogs.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnLogs.Image = My.Resources.Resources.log
        btnLogs.ImageAlign = ContentAlignment.MiddleLeft
        btnLogs.Location = New Point(15, 502)
        btnLogs.Name = "btnLogs"
        btnLogs.Size = New Size(270, 35)
        btnLogs.TabIndex = 10
        btnLogs.Text = "Logs"
        btnLogs.UseVisualStyleBackColor = False
        ' 
        ' btnUsers
        ' 
        btnUsers.BackColor = Color.Gainsboro
        btnUsers.Cursor = Cursors.Hand
        btnUsers.FlatAppearance.BorderColor = Color.SandyBrown
        btnUsers.FlatAppearance.BorderSize = 0
        btnUsers.FlatStyle = FlatStyle.Flat
        btnUsers.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnUsers.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnUsers.Image = My.Resources.Resources.group
        btnUsers.ImageAlign = ContentAlignment.MiddleLeft
        btnUsers.Location = New Point(15, 455)
        btnUsers.Name = "btnUsers"
        btnUsers.Size = New Size(270, 35)
        btnUsers.TabIndex = 7
        btnUsers.Text = "Users"
        btnUsers.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.Gainsboro
        btnReports.Cursor = Cursors.Hand
        btnReports.FlatAppearance.BorderColor = Color.SandyBrown
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnReports.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnReports.Image = My.Resources.Resources.report
        btnReports.ImageAlign = ContentAlignment.MiddleLeft
        btnReports.Location = New Point(15, 407)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(270, 35)
        btnReports.TabIndex = 6
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnDiscounts
        ' 
        btnDiscounts.BackColor = Color.Gainsboro
        btnDiscounts.Cursor = Cursors.Hand
        btnDiscounts.FlatAppearance.BorderColor = Color.SandyBrown
        btnDiscounts.FlatAppearance.BorderSize = 0
        btnDiscounts.FlatStyle = FlatStyle.Flat
        btnDiscounts.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnDiscounts.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnDiscounts.Image = My.Resources.Resources.discount_16
        btnDiscounts.ImageAlign = ContentAlignment.MiddleLeft
        btnDiscounts.Location = New Point(15, 359)
        btnDiscounts.Name = "btnDiscounts"
        btnDiscounts.Size = New Size(270, 35)
        btnDiscounts.TabIndex = 12
        btnDiscounts.Text = "Discounts"
        btnDiscounts.UseVisualStyleBackColor = False
        ' 
        ' btnCategories
        ' 
        btnCategories.BackColor = Color.Gainsboro
        btnCategories.Cursor = Cursors.Hand
        btnCategories.FlatAppearance.BorderColor = Color.SandyBrown
        btnCategories.FlatAppearance.BorderSize = 0
        btnCategories.FlatStyle = FlatStyle.Flat
        btnCategories.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnCategories.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnCategories.Image = My.Resources.Resources.category
        btnCategories.ImageAlign = ContentAlignment.MiddleLeft
        btnCategories.Location = New Point(15, 311)
        btnCategories.Name = "btnCategories"
        btnCategories.Size = New Size(270, 35)
        btnCategories.TabIndex = 5
        btnCategories.Text = "Categories"
        btnCategories.UseVisualStyleBackColor = False
        ' 
        ' lblTime
        ' 
        lblTime.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblTime.Font = New Font("Segoe UI", 14.0F, FontStyle.Italic)
        lblTime.ForeColor = Color.Gainsboro
        lblTime.Location = New Point(15, 697)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(270, 35)
        lblTime.TabIndex = 9
        lblTime.Text = "Time"
        lblTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDate
        ' 
        lblDate.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblDate.Font = New Font("Segoe UI", 14.0F, FontStyle.Italic)
        lblDate.ForeColor = Color.Gainsboro
        lblDate.Location = New Point(15, 667)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(270, 35)
        lblDate.TabIndex = 8
        lblDate.Text = "Date"
        lblDate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnLogout.BackColor = Color.Gainsboro
        btnLogout.Cursor = Cursors.Hand
        btnLogout.FlatAppearance.BorderColor = Color.SandyBrown
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnLogout.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnLogout.Image = My.Resources.Resources.log_out
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(15, 741)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(270, 35)
        btnLogout.TabIndex = 8
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnItemList
        ' 
        btnItemList.BackColor = Color.Gainsboro
        btnItemList.Cursor = Cursors.Hand
        btnItemList.FlatAppearance.BorderColor = Color.SandyBrown
        btnItemList.FlatAppearance.BorderSize = 0
        btnItemList.FlatStyle = FlatStyle.Flat
        btnItemList.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnItemList.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnItemList.Image = My.Resources.Resources.list_interface_symbol
        btnItemList.ImageAlign = ContentAlignment.MiddleLeft
        btnItemList.Location = New Point(15, 263)
        btnItemList.Name = "btnItemList"
        btnItemList.Size = New Size(270, 35)
        btnItemList.TabIndex = 2
        btnItemList.Text = "Product List"
        btnItemList.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Gainsboro
        btnDashboard.Cursor = Cursors.Hand
        btnDashboard.FlatAppearance.BorderColor = Color.SandyBrown
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnDashboard.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnDashboard.Image = My.Resources.Resources.dashboard
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(15, 215)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(270, 35)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.hot_coffee
        Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Panel1.Location = New Point(15, 15)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(270, 131)
        Panel1.TabIndex = 0
        Panel1.TabStop = True
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHeader.BackColor = Color.Gainsboro
        pnlHeader.Controls.Add(btnRestoreDown)
        pnlHeader.Controls.Add(lblUsersName)
        pnlHeader.Controls.Add(btnMinimize)
        pnlHeader.Controls.Add(btnClose)
        pnlHeader.Cursor = Cursors.SizeAll
        pnlHeader.Location = New Point(300, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1070, 50)
        pnlHeader.TabIndex = 7
        ' 
        ' btnRestoreDown
        ' 
        btnRestoreDown.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRestoreDown.AutoSize = True
        btnRestoreDown.Cursor = Cursors.Hand
        btnRestoreDown.FlatAppearance.BorderSize = 0
        btnRestoreDown.FlatStyle = FlatStyle.Flat
        btnRestoreDown.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRestoreDown.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnRestoreDown.Location = New Point(995, 6)
        btnRestoreDown.Name = "btnRestoreDown"
        btnRestoreDown.Size = New Size(33, 30)
        btnRestoreDown.TabIndex = 8
        btnRestoreDown.TabStop = False
        btnRestoreDown.Text = "❐"
        btnRestoreDown.UseVisualStyleBackColor = True
        ' 
        ' lblUsersName
        ' 
        lblUsersName.Font = New Font("Segoe UI", 14.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblUsersName.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        lblUsersName.Location = New Point(6, 9)
        lblUsersName.Name = "lblUsersName"
        lblUsersName.Size = New Size(437, 35)
        lblUsersName.TabIndex = 7
        lblUsersName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimize.AutoSize = True
        btnMinimize.Cursor = Cursors.Hand
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMinimize.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnMinimize.Location = New Point(962, 6)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(30, 30)
        btnMinimize.TabIndex = 6
        btnMinimize.TabStop = False
        btnMinimize.Text = "_"
        btnMinimize.UseVisualStyleBackColor = True
        ' 
        ' pnlDisplay
        ' 
        pnlDisplay.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDisplay.AutoScroll = True
        pnlDisplay.AutoScrollMinSize = New Size(0, 500)
        pnlDisplay.Location = New Point(306, 56)
        pnlDisplay.Name = "pnlDisplay"
        pnlDisplay.Size = New Size(1058, 720)
        pnlDisplay.TabIndex = 9
        ' 
        ' timerDateTime
        ' 
        timerDateTime.Enabled = True
        timerDateTime.Interval = 1000
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        ClientSize = New Size(1370, 788)
        Controls.Add(pnlDisplay)
        Controls.Add(pnlHeader)
        Controls.Add(pnlSideBar)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StockSense"
        WindowState = FormWindowState.Maximized
        pnlSideBar.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents pnlSideBar As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlDisplay As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnItemList As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents timerDateTime As Timer
    Friend WithEvents lblUsersName As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnCategories As Button
    Friend WithEvents btnDiscounts As Button
    Friend WithEvents btnLogs As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRestoreDown As Button
End Class