<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValidationForm
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
        Panel1 = New Panel()
        Label2 = New Label()
        btnCancel = New Button()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SandyBrown
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(436, 283)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SaddleBrown
        Label2.Location = New Point(67, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(308, 34)
        Label2.TabIndex = 9
        Label2.Text = "Please Input Password"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnCancel
        ' 
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatStyle = FlatStyle.Popup
        btnCancel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(223, 214)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(171, 35)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.SaddleBrown
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.SandyBrown
        btnLogin.Location = New Point(42, 214)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(171, 35)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.SandyBrown
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.ForeColor = Color.SaddleBrown
        txtPassword.Location = New Point(42, 168)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(352, 29)
        txtPassword.TabIndex = 6
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.SandyBrown
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.ForeColor = Color.SaddleBrown
        txtUsername.Location = New Point(42, 102)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(352, 29)
        txtUsername.TabIndex = 5
        txtUsername.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.SaddleBrown
        Label4.Location = New Point(42, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 20)
        Label4.TabIndex = 3
        Label4.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SaddleBrown
        Label3.Location = New Point(42, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 4
        Label3.Text = "Username"
        ' 
        ' ValidationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(441, 288)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ValidationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ValidationForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
End Class
