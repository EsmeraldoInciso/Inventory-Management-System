<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogsForm
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
        Label1 = New Label()
        dgLogs = New DataGridView()
        CType(dgLogs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 37)
        Label1.TabIndex = 4
        Label1.Text = "Logs"
        ' 
        ' dgLogs
        ' 
        dgLogs.AllowUserToAddRows = False
        dgLogs.AllowUserToDeleteRows = False
        dgLogs.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgLogs.BackgroundColor = Color.SandyBrown
        dgLogs.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.SandyBrown
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.SaddleBrown
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgLogs.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.SandyBrown
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.SaddleBrown
        DataGridViewCellStyle2.SelectionBackColor = Color.SaddleBrown
        DataGridViewCellStyle2.SelectionForeColor = Color.SandyBrown
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgLogs.DefaultCellStyle = DataGridViewCellStyle2
        dgLogs.GridColor = Color.Peru
        dgLogs.Location = New Point(12, 89)
        dgLogs.MultiSelect = False
        dgLogs.Name = "dgLogs"
        dgLogs.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.SandyBrown
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.SaddleBrown
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgLogs.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgLogs.RowHeadersVisible = False
        dgLogs.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgLogs.Size = New Size(1143, 657)
        dgLogs.TabIndex = 6
        dgLogs.TabStop = False
        ' 
        ' LogsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(1167, 758)
        Controls.Add(dgLogs)
        Controls.Add(Label1)
        Name = "LogsForm"
        Text = "LogsForm"
        CType(dgLogs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgLogs As DataGridView
End Class
