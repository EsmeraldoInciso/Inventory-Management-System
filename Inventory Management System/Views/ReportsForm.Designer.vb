<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportsForm))
        Label1 = New Label()
        dgReports = New DataGridView()
        dgLogs = New DataGridView()
        Label7 = New Label()
        Label2 = New Label()
        cbUserName = New ComboBox()
        Label9 = New Label()
        cbDateRange = New ComboBox()
        Label3 = New Label()
        btnLoad = New Button()
        lblTotalTransactions = New Label()
        lblNDLogs = New Label()
        lblNDTransactions = New Label()
        btnPrint = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        CType(dgReports, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgLogs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 37)
        Label1.TabIndex = 4
        Label1.Text = "Reports"
        ' 
        ' dgReports
        ' 
        dgReports.AllowUserToAddRows = False
        dgReports.AllowUserToDeleteRows = False
        dgReports.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgReports.BackgroundColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        dgReports.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgReports.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgReports.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgReports.DefaultCellStyle = DataGridViewCellStyle2
        dgReports.GridColor = Color.Gainsboro
        dgReports.Location = New Point(552, 160)
        dgReports.MultiSelect = False
        dgReports.Name = "dgReports"
        dgReports.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgReports.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgReports.RowHeadersVisible = False
        dgReports.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgReports.Size = New Size(603, 546)
        dgReports.TabIndex = 5
        dgReports.TabStop = False
        ' 
        ' dgLogs
        ' 
        dgLogs.AllowUserToAddRows = False
        dgLogs.AllowUserToDeleteRows = False
        dgLogs.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dgLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgLogs.BackgroundColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        dgLogs.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgLogs.Cursor = Cursors.Hand
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgLogs.DefaultCellStyle = DataGridViewCellStyle5
        dgLogs.GridColor = Color.Gainsboro
        dgLogs.Location = New Point(12, 160)
        dgLogs.MultiSelect = False
        dgLogs.Name = "dgLogs"
        dgLogs.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgLogs.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgLogs.RowHeadersVisible = False
        dgLogs.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgLogs.Size = New Size(534, 586)
        dgLogs.TabIndex = 6
        dgLogs.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label7.Location = New Point(552, 134)
        Label7.Name = "Label7"
        Label7.Size = New Size(150, 23)
        Label7.TabIndex = 30
        Label7.Text = "Transactions:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label2.Location = New Point(12, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 23)
        Label2.TabIndex = 31
        Label2.Text = "Logs:"
        ' 
        ' cbUserName
        ' 
        cbUserName.BackColor = Color.Gainsboro
        cbUserName.Cursor = Cursors.Hand
        cbUserName.DropDownStyle = ComboBoxStyle.DropDownList
        cbUserName.FlatStyle = FlatStyle.Popup
        cbUserName.Font = New Font("Lucida Sans Unicode", 14F)
        cbUserName.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        cbUserName.FormattingEnabled = True
        cbUserName.Location = New Point(149, 75)
        cbUserName.Name = "cbUserName"
        cbUserName.Size = New Size(262, 31)
        cbUserName.TabIndex = 32
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label9.Location = New Point(15, 78)
        Label9.Name = "Label9"
        Label9.Size = New Size(128, 23)
        Label9.TabIndex = 33
        Label9.Text = "User Name:"
        ' 
        ' cbDateRange
        ' 
        cbDateRange.BackColor = Color.Gainsboro
        cbDateRange.Cursor = Cursors.Hand
        cbDateRange.DropDownStyle = ComboBoxStyle.DropDownList
        cbDateRange.FlatStyle = FlatStyle.Popup
        cbDateRange.Font = New Font("Lucida Sans Unicode", 14F)
        cbDateRange.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        cbDateRange.FormattingEnabled = True
        cbDateRange.Items.AddRange(New Object() {"Today", "Last 7 Days", "Last 28 Days"})
        cbDateRange.Location = New Point(571, 75)
        cbDateRange.Name = "cbDateRange"
        cbDateRange.Size = New Size(262, 31)
        cbDateRange.TabIndex = 34
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label3.Location = New Point(431, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 23)
        Label3.TabIndex = 35
        Label3.Text = "Date Range:"
        ' 
        ' btnLoad
        ' 
        btnLoad.BackColor = Color.LawnGreen
        btnLoad.Cursor = Cursors.Hand
        btnLoad.FlatStyle = FlatStyle.Popup
        btnLoad.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLoad.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnLoad.Location = New Point(849, 75)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(115, 32)
        btnLoad.TabIndex = 36
        btnLoad.TabStop = False
        btnLoad.Text = "Load"
        btnLoad.UseVisualStyleBackColor = False
        ' 
        ' lblTotalTransactions
        ' 
        lblTotalTransactions.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblTotalTransactions.Font = New Font("Lucida Sans Unicode", 20F, FontStyle.Bold Or FontStyle.Underline)
        lblTotalTransactions.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        lblTotalTransactions.Location = New Point(552, 709)
        lblTotalTransactions.Name = "lblTotalTransactions"
        lblTotalTransactions.Size = New Size(603, 37)
        lblTotalTransactions.TabIndex = 37
        lblTotalTransactions.Text = "Total Qty: 0 |  Total: ₱0.00"
        lblTotalTransactions.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblNDLogs
        ' 
        lblNDLogs.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblNDLogs.AutoSize = True
        lblNDLogs.BackColor = Color.White
        lblNDLogs.Font = New Font("Lucida Sans Unicode", 30F, FontStyle.Bold)
        lblNDLogs.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        lblNDLogs.Location = New Point(181, 431)
        lblNDLogs.Name = "lblNDLogs"
        lblNDLogs.Size = New Size(184, 48)
        lblNDLogs.TabIndex = 38
        lblNDLogs.Text = "No Data"
        lblNDLogs.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNDTransactions
        ' 
        lblNDTransactions.Anchor = AnchorStyles.None
        lblNDTransactions.AutoSize = True
        lblNDTransactions.BackColor = Color.White
        lblNDTransactions.Font = New Font("Lucida Sans Unicode", 30F, FontStyle.Bold)
        lblNDTransactions.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        lblNDTransactions.Location = New Point(770, 431)
        lblNDTransactions.Name = "lblNDTransactions"
        lblNDTransactions.Size = New Size(184, 48)
        lblNDTransactions.TabIndex = 39
        lblNDTransactions.Text = "No Data"
        lblNDTransactions.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnPrint
        ' 
        btnPrint.Cursor = Cursors.Hand
        btnPrint.FlatStyle = FlatStyle.Popup
        btnPrint.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrint.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnPrint.Location = New Point(970, 75)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(115, 32)
        btnPrint.TabIndex = 40
        btnPrint.TabStop = False
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
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
        ' ReportsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1167, 758)
        Controls.Add(btnPrint)
        Controls.Add(lblNDTransactions)
        Controls.Add(lblNDLogs)
        Controls.Add(lblTotalTransactions)
        Controls.Add(btnLoad)
        Controls.Add(cbDateRange)
        Controls.Add(Label3)
        Controls.Add(cbUserName)
        Controls.Add(Label9)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(dgLogs)
        Controls.Add(dgReports)
        Controls.Add(Label1)
        Name = "ReportsForm"
        Text = "ReportsForm"
        CType(dgReports, ComponentModel.ISupportInitialize).EndInit()
        CType(dgLogs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgReports As DataGridView
    Friend WithEvents dgLogs As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbUserName As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbDateRange As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLoad As Button
    Friend WithEvents lblTotalTransactions As Label
    Friend WithEvents lblNDLogs As Label
    Friend WithEvents lblNDTransactions As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
