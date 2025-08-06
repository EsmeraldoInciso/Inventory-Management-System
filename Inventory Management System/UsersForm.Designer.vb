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
        txtUsername = New TextBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Label6 = New Label()
        btnLogin = New Button()
        Button1 = New Button()
        Button3 = New Button()
        Label7 = New Label()
        TextBox4 = New TextBox()
        btnPrint = New Button()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        CType(dgUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgUsers
        ' 
        dgUsers.AllowUserToAddRows = False
        dgUsers.AllowUserToDeleteRows = False
        dgUsers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgUsers.BackgroundColor = Color.SandyBrown
        dgUsers.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.SandyBrown
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.SaddleBrown
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgUsers.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.SandyBrown
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.SaddleBrown
        DataGridViewCellStyle2.SelectionBackColor = Color.SaddleBrown
        DataGridViewCellStyle2.SelectionForeColor = Color.SandyBrown
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgUsers.DefaultCellStyle = DataGridViewCellStyle2
        dgUsers.GridColor = Color.Peru
        dgUsers.Location = New Point(440, 80)
        dgUsers.MultiSelect = False
        dgUsers.Name = "dgUsers"
        dgUsers.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.SandyBrown
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.SaddleBrown
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgUsers.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgUsers.RowHeadersVisible = False
        dgUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgUsers.Size = New Size(715, 666)
        dgUsers.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 37)
        Label1.TabIndex = 3
        Label1.Text = "Users"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.SandyBrown
        txtUsername.Font = New Font("Lucida Sans Unicode", 12F)
        txtUsername.ForeColor = Color.SaddleBrown
        txtUsername.Location = New Point(154, 80)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(280, 32)
        txtUsername.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.SandyBrown
        TextBox1.Font = New Font("Lucida Sans Unicode", 12F)
        TextBox1.ForeColor = Color.SaddleBrown
        TextBox1.Location = New Point(154, 128)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(280, 32)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.SandyBrown
        TextBox2.Font = New Font("Lucida Sans Unicode", 12F)
        TextBox2.ForeColor = Color.SaddleBrown
        TextBox2.Location = New Point(154, 176)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(280, 32)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.SandyBrown
        TextBox3.Font = New Font("Lucida Sans Unicode", 12F)
        TextBox3.ForeColor = Color.SaddleBrown
        TextBox3.Location = New Point(154, 224)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(280, 32)
        TextBox3.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(35, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 20)
        Label2.TabIndex = 5
        Label2.Text = "ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(35, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 20)
        Label3.TabIndex = 5
        Label3.Text = "First Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(35, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 20)
        Label4.TabIndex = 5
        Label4.Text = "Last Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(35, 227)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 20)
        Label5.TabIndex = 5
        Label5.Text = "Username:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.SandyBrown
        ComboBox1.Cursor = Cursors.Hand
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FlatStyle = FlatStyle.Popup
        ComboBox1.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.ForeColor = Color.SaddleBrown
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(154, 272)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(280, 28)
        ComboBox1.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(35, 275)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 20)
        Label6.TabIndex = 5
        Label6.Text = "Status:"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.LawnGreen
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.SaddleBrown
        btnLogin.Location = New Point(35, 325)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(190, 35)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Add"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gold
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.SaddleBrown
        Button1.Location = New Point(244, 325)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 35)
        Button1.TabIndex = 7
        Button1.Text = "Update"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.SaddleBrown
        Button3.Location = New Point(35, 378)
        Button3.Name = "Button3"
        Button3.Size = New Size(399, 35)
        Button3.TabIndex = 7
        Button3.Text = "Clear Selection"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(440, 45)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 20)
        Label7.TabIndex = 9
        Label7.Text = "Search:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox4.BackColor = Color.SandyBrown
        TextBox4.Font = New Font("Lucida Sans Unicode", 12F)
        TextBox4.ForeColor = Color.SaddleBrown
        TextBox4.Location = New Point(520, 42)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(514, 32)
        TextBox4.TabIndex = 8
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrint.Cursor = Cursors.Hand
        btnPrint.FlatStyle = FlatStyle.Popup
        btnPrint.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrint.ForeColor = Color.SaddleBrown
        btnPrint.Location = New Point(1040, 42)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(115, 32)
        btnPrint.TabIndex = 10
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
        ' UsersForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(1167, 758)
        Controls.Add(btnPrint)
        Controls.Add(Label7)
        Controls.Add(TextBox4)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(btnLogin)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(txtUsername)
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
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
