<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmationForm
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
        txtMessage = New Label()
        btnCancel = New Button()
        btnOK = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SandyBrown
        Panel1.Controls.Add(txtMessage)
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(btnOK)
        Panel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(2, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(436, 198)
        Panel1.TabIndex = 1
        ' 
        ' txtMessage
        ' 
        txtMessage.Font = New Font("Lucida Sans Unicode", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMessage.ForeColor = Color.SaddleBrown
        txtMessage.Location = New Point(42, 24)
        txtMessage.Name = "txtMessage"
        txtMessage.Size = New Size(352, 102)
        txtMessage.TabIndex = 9
        txtMessage.Text = "Text"
        txtMessage.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnCancel
        ' 
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatStyle = FlatStyle.Popup
        btnCancel.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.SaddleBrown
        btnCancel.Location = New Point(223, 129)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(171, 35)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnOK
        ' 
        btnOK.BackColor = Color.SaddleBrown
        btnOK.Cursor = Cursors.Hand
        btnOK.FlatStyle = FlatStyle.Popup
        btnOK.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOK.ForeColor = Color.SandyBrown
        btnOK.Location = New Point(42, 129)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(171, 35)
        btnOK.TabIndex = 7
        btnOK.Text = "OK"
        btnOK.UseVisualStyleBackColor = False
        ' 
        ' ConfirmationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(441, 204)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ConfirmationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ConfirmationForm"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtMessage As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
End Class
