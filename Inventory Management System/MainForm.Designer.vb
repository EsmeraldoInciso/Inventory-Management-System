<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        btnClose = New Button()
        pnlSideBar = New Panel()
        btnUsers = New Button()
        btnReports = New Button()
        btnCategories = New Button()
        lblTime = New Label()
        lblDate = New Label()
        btnLogout = New Button()
        btnStockOut = New Button()
        btnStockIn = New Button()
        btnItemList = New Button()
        btnDashboard = New Button()
        Panel1 = New Panel()
        pnlHeader = New Panel()
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
        btnClose.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.SaddleBrown
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
        pnlSideBar.BackColor = Color.SaddleBrown
        pnlSideBar.Controls.Add(btnUsers)
        pnlSideBar.Controls.Add(btnReports)
        pnlSideBar.Controls.Add(btnCategories)
        pnlSideBar.Controls.Add(lblTime)
        pnlSideBar.Controls.Add(lblDate)
        pnlSideBar.Controls.Add(btnLogout)
        pnlSideBar.Controls.Add(btnStockOut)
        pnlSideBar.Controls.Add(btnStockIn)
        pnlSideBar.Controls.Add(btnItemList)
        pnlSideBar.Controls.Add(btnDashboard)
        pnlSideBar.Controls.Add(Panel1)
        pnlSideBar.Location = New Point(0, 0)
        pnlSideBar.Name = "pnlSideBar"
        pnlSideBar.Size = New Size(300, 850)
        pnlSideBar.TabIndex = 1
        ' 
        ' btnUsers
        ' 
        btnUsers.BackColor = Color.Peru
        btnUsers.Cursor = Cursors.Hand
        btnUsers.FlatAppearance.BorderColor = Color.SandyBrown
        btnUsers.FlatAppearance.BorderSize = 0
        btnUsers.FlatStyle = FlatStyle.Flat
        btnUsers.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUsers.ForeColor = Color.SaddleBrown
        btnUsers.Image = My.Resources.Resources.group
        btnUsers.ImageAlign = ContentAlignment.MiddleLeft
        btnUsers.Location = New Point(15, 479)
        btnUsers.Name = "btnUsers"
        btnUsers.Size = New Size(270, 35)
        btnUsers.TabIndex = 7
        btnUsers.Text = "Users"
        btnUsers.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.Peru
        btnReports.Cursor = Cursors.Hand
        btnReports.FlatAppearance.BorderColor = Color.SandyBrown
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReports.ForeColor = Color.SaddleBrown
        btnReports.Image = My.Resources.Resources.report
        btnReports.ImageAlign = ContentAlignment.MiddleLeft
        btnReports.Location = New Point(15, 431)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(270, 35)
        btnReports.TabIndex = 6
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnCategories
        ' 
        btnCategories.BackColor = Color.Peru
        btnCategories.Cursor = Cursors.Hand
        btnCategories.FlatAppearance.BorderColor = Color.SandyBrown
        btnCategories.FlatAppearance.BorderSize = 0
        btnCategories.FlatStyle = FlatStyle.Flat
        btnCategories.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCategories.ForeColor = Color.SaddleBrown
        btnCategories.Image = My.Resources.Resources.category
        btnCategories.ImageAlign = ContentAlignment.MiddleLeft
        btnCategories.Location = New Point(15, 383)
        btnCategories.Name = "btnCategories"
        btnCategories.Size = New Size(270, 35)
        btnCategories.TabIndex = 5
        btnCategories.Text = "Categories"
        btnCategories.UseVisualStyleBackColor = False
        ' 
        ' lblTime
        ' 
        lblTime.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblTime.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = Color.SandyBrown
        lblTime.Location = New Point(15, 759)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(270, 20)
        lblTime.TabIndex = 9
        lblTime.Text = "Time"
        lblTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDate
        ' 
        lblDate.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblDate.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblDate.ForeColor = Color.SandyBrown
        lblDate.Location = New Point(15, 728)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(270, 20)
        lblDate.TabIndex = 8
        lblDate.Text = "Date"
        lblDate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnLogout.BackColor = Color.Peru
        btnLogout.Cursor = Cursors.Hand
        btnLogout.FlatAppearance.BorderColor = Color.SandyBrown
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.SaddleBrown
        btnLogout.Image = My.Resources.Resources.log_out
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(15, 803)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(270, 35)
        btnLogout.TabIndex = 8
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnStockOut
        ' 
        btnStockOut.BackColor = Color.Peru
        btnStockOut.Cursor = Cursors.Hand
        btnStockOut.FlatAppearance.BorderColor = Color.SandyBrown
        btnStockOut.FlatAppearance.BorderSize = 0
        btnStockOut.FlatStyle = FlatStyle.Flat
        btnStockOut.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStockOut.ForeColor = Color.SaddleBrown
        btnStockOut.Image = My.Resources.Resources.out_of_the_box
        btnStockOut.ImageAlign = ContentAlignment.MiddleLeft
        btnStockOut.Location = New Point(15, 335)
        btnStockOut.Name = "btnStockOut"
        btnStockOut.Size = New Size(270, 35)
        btnStockOut.TabIndex = 4
        btnStockOut.Text = "Stock-Out"
        btnStockOut.UseVisualStyleBackColor = False
        ' 
        ' btnStockIn
        ' 
        btnStockIn.BackColor = Color.Peru
        btnStockIn.Cursor = Cursors.Hand
        btnStockIn.FlatAppearance.BorderColor = Color.SandyBrown
        btnStockIn.FlatAppearance.BorderSize = 0
        btnStockIn.FlatStyle = FlatStyle.Flat
        btnStockIn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStockIn.ForeColor = Color.SaddleBrown
        btnStockIn.Image = My.Resources.Resources.product
        btnStockIn.ImageAlign = ContentAlignment.MiddleLeft
        btnStockIn.Location = New Point(15, 287)
        btnStockIn.Name = "btnStockIn"
        btnStockIn.Size = New Size(270, 35)
        btnStockIn.TabIndex = 3
        btnStockIn.Text = "Stock-In"
        btnStockIn.UseVisualStyleBackColor = False
        ' 
        ' btnItemList
        ' 
        btnItemList.BackColor = Color.Peru
        btnItemList.Cursor = Cursors.Hand
        btnItemList.FlatAppearance.BorderColor = Color.SandyBrown
        btnItemList.FlatAppearance.BorderSize = 0
        btnItemList.FlatStyle = FlatStyle.Flat
        btnItemList.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnItemList.ForeColor = Color.SaddleBrown
        btnItemList.Image = My.Resources.Resources.list_interface_symbol
        btnItemList.ImageAlign = ContentAlignment.MiddleLeft
        btnItemList.Location = New Point(15, 239)
        btnItemList.Name = "btnItemList"
        btnItemList.Size = New Size(270, 35)
        btnItemList.TabIndex = 2
        btnItemList.Text = "Item List"
        btnItemList.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Peru
        btnDashboard.Cursor = Cursors.Hand
        btnDashboard.FlatAppearance.BorderColor = Color.SandyBrown
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.SaddleBrown
        btnDashboard.Image = My.Resources.Resources.dashboard
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(15, 191)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(270, 35)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.coffee
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
        pnlHeader.BackColor = Color.Peru
        pnlHeader.Controls.Add(lblUsersName)
        pnlHeader.Controls.Add(btnMinimize)
        pnlHeader.Controls.Add(btnClose)
        pnlHeader.Location = New Point(300, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1070, 50)
        pnlHeader.TabIndex = 7
        ' 
        ' lblUsersName
        ' 
        lblUsersName.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblUsersName.ForeColor = Color.SaddleBrown
        lblUsersName.Location = New Point(10, 15)
        lblUsersName.Name = "lblUsersName"
        lblUsersName.Size = New Size(437, 20)
        lblUsersName.TabIndex = 7
        lblUsersName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimize.Cursor = Cursors.Hand
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMinimize.ForeColor = Color.SaddleBrown
        btnMinimize.Location = New Point(998, 6)
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
        pnlDisplay.Location = New Point(306, 56)
        pnlDisplay.Name = "pnlDisplay"
        pnlDisplay.Size = New Size(1058, 782)
        pnlDisplay.TabIndex = 9
        ' 
        ' timerDateTime
        ' 
        timerDateTime.Enabled = True
        timerDateTime.Interval = 1000
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(1370, 850)
        Controls.Add(pnlDisplay)
        Controls.Add(pnlHeader)
        Controls.Add(pnlSideBar)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kapehan Ni Trish"
        WindowState = FormWindowState.Maximized
        pnlSideBar.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents pnlSideBar As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlDisplay As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnStockOut As Button
    Friend WithEvents btnStockIn As Button
    Friend WithEvents btnItemList As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents timerDateTime As Timer
    Friend WithEvents lblUsersName As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnCategories As Button
End Class
