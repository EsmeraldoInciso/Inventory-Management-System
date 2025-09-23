<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersForm))
        dgUsers = New DataGridView()
        Label1 = New Label()
        txtID = New TextBox()
        txtFirstname = New TextBox()
        txtLastname = New TextBox()
        txtUsername = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        cbRole = New ComboBox()
        Label6 = New Label()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnClear = New Button()
        Label7 = New Label()
        txtSearch = New TextBox()
        btnPrint = New Button()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        txtPassword = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        cbStatus = New ComboBox()
        CType(dgUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgUsers
        ' 
        dgUsers.AllowUserToAddRows = False
        dgUsers.AllowUserToDeleteRows = False
        dgUsers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgUsers.BackgroundColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        dgUsers.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgUsers.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgUsers.DefaultCellStyle = DataGridViewCellStyle2
        dgUsers.GridColor = Color.Gainsboro
        dgUsers.Location = New Point(440, 80)
        dgUsers.MultiSelect = False
        dgUsers.Name = "dgUsers"
        dgUsers.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgUsers.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgUsers.RowHeadersVisible = False
        dgUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgUsers.Size = New Size(715, 666)
        dgUsers.TabIndex = 2
        dgUsers.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 37)
        Label1.TabIndex = 3
        Label1.Text = "Users"
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.Gainsboro
        txtID.Enabled = False
        txtID.Font = New Font("Lucida Sans Unicode", 14F)
        txtID.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtID.Location = New Point(164, 80)
        txtID.Name = "txtID"
        txtID.Size = New Size(270, 36)
        txtID.TabIndex = 4
        txtID.TabStop = False
        ' 
        ' txtFirstname
        ' 
        txtFirstname.BackColor = Color.Gainsboro
        txtFirstname.Font = New Font("Lucida Sans Unicode", 14F)
        txtFirstname.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtFirstname.Location = New Point(164, 128)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(270, 36)
        txtFirstname.TabIndex = 1
        ' 
        ' txtLastname
        ' 
        txtLastname.BackColor = Color.Gainsboro
        txtLastname.Font = New Font("Lucida Sans Unicode", 14F)
        txtLastname.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtLastname.Location = New Point(164, 176)
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(270, 36)
        txtLastname.TabIndex = 2
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.Gainsboro
        txtUsername.Font = New Font("Lucida Sans Unicode", 14F)
        txtUsername.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtUsername.Location = New Point(164, 224)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(270, 36)
        txtUsername.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label2.Location = New Point(35, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 23)
        Label2.TabIndex = 5
        Label2.Text = "ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label3.Location = New Point(35, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 23)
        Label3.TabIndex = 5
        Label3.Text = "First Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label4.Location = New Point(35, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 23)
        Label4.TabIndex = 5
        Label4.Text = "Last Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label5.Location = New Point(35, 227)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 23)
        Label5.TabIndex = 5
        Label5.Text = "Username:"
        ' 
        ' cbRole
        ' 
        cbRole.BackColor = Color.Gainsboro
        cbRole.Cursor = Cursors.Hand
        cbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cbRole.FlatStyle = FlatStyle.Popup
        cbRole.Font = New Font("Lucida Sans Unicode", 14F)
        cbRole.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"", "Admin", "User"})
        cbRole.Location = New Point(164, 317)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(270, 31)
        cbRole.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label6.Location = New Point(35, 320)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 23)
        Label6.TabIndex = 5
        Label6.Text = "Role:"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.LawnGreen
        btnAdd.Cursor = Cursors.Hand
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        btnAdd.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnAdd.Location = New Point(35, 431)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(190, 35)
        btnAdd.TabIndex = 7
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Gold
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnUpdate.Location = New Point(244, 431)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(190, 35)
        btnUpdate.TabIndex = 8
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        btnClear.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnClear.Location = New Point(35, 484)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(399, 35)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear Selection"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label7.Location = New Point(440, 45)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 23)
        Label7.TabIndex = 9
        Label7.Text = "Search:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.BackColor = Color.Gainsboro
        txtSearch.Font = New Font("Lucida Sans Unicode", 14F)
        txtSearch.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtSearch.Location = New Point(531, 42)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(503, 36)
        txtSearch.TabIndex = 8
        txtSearch.TabStop = False
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrint.Cursor = Cursors.Hand
        btnPrint.FlatStyle = FlatStyle.Popup
        btnPrint.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        btnPrint.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnPrint.Location = New Point(1040, 42)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(115, 32)
        btnPrint.TabIndex = 10
        btnPrint.TabStop = False
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Gainsboro
        txtPassword.Font = New Font("Lucida Sans Unicode", 14F)
        txtPassword.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtPassword.Location = New Point(164, 271)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(270, 36)
        txtPassword.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        Label8.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label8.Location = New Point(35, 274)
        Label8.Name = "Label8"
        Label8.Size = New Size(114, 23)
        Label8.TabIndex = 5
        Label8.Text = "Password:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label9.Location = New Point(35, 366)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 23)
        Label9.TabIndex = 5
        Label9.Text = "Status:"
        ' 
        ' cbStatus
        ' 
        cbStatus.BackColor = Color.Gainsboro
        cbStatus.Cursor = Cursors.Hand
        cbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbStatus.FlatStyle = FlatStyle.Popup
        cbStatus.Font = New Font("Lucida Sans Unicode", 14F)
        cbStatus.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"", "Active", "Inactive"})
        cbStatus.Location = New Point(164, 363)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(270, 31)
        cbStatus.TabIndex = 6
        ' 
        ' UsersForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1167, 758)
        Controls.Add(btnPrint)
        Controls.Add(Label7)
        Controls.Add(txtSearch)
        Controls.Add(btnClear)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(cbStatus)
        Controls.Add(cbRole)
        Controls.Add(Label9)
        Controls.Add(Label6)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(txtLastname)
        Controls.Add(txtFirstname)
        Controls.Add(txtID)
        Controls.Add(Label1)
        Controls.Add(dgUsers)
        Name = "UsersForm"
        Text = "UsersForm"
        CType(dgUsers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgUsers As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbStatus As ComboBox
End Class
