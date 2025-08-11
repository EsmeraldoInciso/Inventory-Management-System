<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        btnHidePassword = New Button()
        btnShowPassword = New Button()
        btnClose = New Button()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Unicode", 40F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SandyBrown
        Label1.Location = New Point(89, 192)
        Label1.Name = "Label1"
        Label1.Size = New Size(331, 65)
        Label1.TabIndex = 0
        Label1.Text = "StockSense"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SaddleBrown
        Label2.Location = New Point(218, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 34)
        Label2.TabIndex = 1
        Label2.Text = "Login"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SandyBrown
        Panel1.Controls.Add(btnHidePassword)
        Panel1.Controls.Add(btnShowPassword)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(500, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(500, 500)
        Panel1.TabIndex = 0
        ' 
        ' btnHidePassword
        ' 
        btnHidePassword.Cursor = Cursors.Hand
        btnHidePassword.FlatAppearance.BorderSize = 0
        btnHidePassword.FlatStyle = FlatStyle.Flat
        btnHidePassword.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHidePassword.ForeColor = Color.SaddleBrown
        btnHidePassword.Image = My.Resources.Resources.hide1
        btnHidePassword.Location = New Point(436, 258)
        btnHidePassword.Name = "btnHidePassword"
        btnHidePassword.Size = New Size(30, 30)
        btnHidePassword.TabIndex = 6
        btnHidePassword.TabStop = False
        btnHidePassword.UseVisualStyleBackColor = True
        ' 
        ' btnShowPassword
        ' 
        btnShowPassword.Cursor = Cursors.Hand
        btnShowPassword.FlatAppearance.BorderSize = 0
        btnShowPassword.FlatStyle = FlatStyle.Flat
        btnShowPassword.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShowPassword.ForeColor = Color.SaddleBrown
        btnShowPassword.Image = My.Resources.Resources.view1
        btnShowPassword.Location = New Point(436, 258)
        btnShowPassword.Name = "btnShowPassword"
        btnShowPassword.Size = New Size(30, 30)
        btnShowPassword.TabIndex = 5
        btnShowPassword.TabStop = False
        btnShowPassword.UseVisualStyleBackColor = True
        btnShowPassword.Visible = False
        ' 
        ' btnClose
        ' 
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.SaddleBrown
        btnClose.Location = New Point(467, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(30, 30)
        btnClose.TabIndex = 4
        btnClose.TabStop = False
        btnClose.Text = "x"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.SaddleBrown
        btnLogin.Location = New Point(80, 315)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(352, 35)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.SandyBrown
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.ForeColor = Color.SaddleBrown
        txtPassword.Location = New Point(80, 257)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(352, 32)
        txtPassword.TabIndex = 2
        txtPassword.Text = "123"
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.SandyBrown
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.ForeColor = Color.SaddleBrown
        txtUsername.Location = New Point(80, 191)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(352, 32)
        txtUsername.TabIndex = 1
        txtUsername.Text = "trish"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.SaddleBrown
        Label4.Location = New Point(80, 234)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 20)
        Label4.TabIndex = 0
        Label4.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SaddleBrown
        Label3.Location = New Point(80, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 0
        Label3.Text = "Username"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.SandyBrown
        Label5.Location = New Point(90, 259)
        Label5.Name = "Label5"
        Label5.Size = New Size(323, 23)
        Label5.TabIndex = 1
        Label5.Text = "Inventory Management System"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(1000, 500)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "StockSense (Login)"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnShowPassword As Button
    Friend WithEvents btnHidePassword As Button
    Friend WithEvents Label5 As Label

End Class
