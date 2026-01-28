<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportsForm
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
        btnRefresh = New Button()
        lblTotalTransactions = New Label()
        lblNDLogs = New Label()
        lblNDTransactions = New Label()
        btnPrint = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        pnlFilters = New Panel()
        pnlSummary = New Panel()
        lblSummaryTitle = New Label()
        CType(dgReports, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgLogs, ComponentModel.ISupportInitialize).BeginInit()
        pnlFilters.SuspendLayout()
        pnlSummary.SuspendLayout()
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
        dgReports.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgReports.BackgroundColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        dgReports.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgReports.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgReports.ColumnHeadersHeight = 35
        dgReports.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 11.0F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgReports.DefaultCellStyle = DataGridViewCellStyle2
        dgReports.EnableHeadersVisualStyles = False
        dgReports.GridColor = Color.LightGray
        dgReports.Location = New Point(12, 205)
        dgReports.MultiSelect = False
        dgReports.Name = "dgReports"
        dgReports.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 11.0F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgReports.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgReports.RowHeadersVisible = False
        dgReports.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgReports.RowTemplate.Height = 30
        dgReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgReports.Size = New Size(1097, 350)
        dgReports.TabIndex = 5
        dgReports.TabStop = False
        ' 
        ' dgLogs
        ' 
        dgLogs.AllowUserToAddRows = False
        dgLogs.AllowUserToDeleteRows = False
        dgLogs.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgLogs.BackgroundColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        dgLogs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgLogs.ColumnHeadersHeight = 30
        dgLogs.Cursor = Cursors.Hand
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        DataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgLogs.DefaultCellStyle = DataGridViewCellStyle5
        dgLogs.EnableHeadersVisualStyles = False
        dgLogs.GridColor = Color.LightGray
        dgLogs.Location = New Point(12, 600)
        dgLogs.MultiSelect = False
        dgLogs.Name = "dgLogs"
        dgLogs.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgLogs.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgLogs.RowHeadersVisible = False
        dgLogs.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgLogs.Size = New Size(1097, 350)
        dgLogs.TabIndex = 6
        dgLogs.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label7.Location = New Point(12, 175)
        Label7.Name = "Label7"
        Label7.Size = New Size(150, 23)
        Label7.TabIndex = 30
        Label7.Text = "Transactions:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label2.Location = New Point(12, 570)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 23)
        Label2.TabIndex = 31
        Label2.Text = "Activity Log:"
        ' 
        ' cbUserName
        ' 
        cbUserName.BackColor = Color.Gainsboro
        cbUserName.Cursor = Cursors.Hand
        cbUserName.DropDownStyle = ComboBoxStyle.DropDownList
        cbUserName.FlatStyle = FlatStyle.Popup
        cbUserName.Font = New Font("Lucida Sans Unicode", 12.0F)
        cbUserName.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        cbUserName.FormattingEnabled = True
        cbUserName.Location = New Point(70, 10)
        cbUserName.Name = "cbUserName"
        cbUserName.Size = New Size(220, 28)
        cbUserName.TabIndex = 32
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label9.Location = New Point(15, 14)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 20)
        Label9.TabIndex = 33
        Label9.Text = "User:"
        ' 
        ' cbDateRange
        ' 
        cbDateRange.BackColor = Color.Gainsboro
        cbDateRange.Cursor = Cursors.Hand
        cbDateRange.DropDownStyle = ComboBoxStyle.DropDownList
        cbDateRange.FlatStyle = FlatStyle.Popup
        cbDateRange.Font = New Font("Lucida Sans Unicode", 12.0F)
        cbDateRange.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        cbDateRange.FormattingEnabled = True
        cbDateRange.Items.AddRange(New Object() {"Today", "Last 7 Days", "Last 28 Days"})
        cbDateRange.Location = New Point(370, 10)
        cbDateRange.Name = "cbDateRange"
        cbDateRange.Size = New Size(180, 28)
        cbDateRange.TabIndex = 34
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label3.Location = New Point(310, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 20)
        Label3.TabIndex = 35
        Label3.Text = "Date:"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Lucida Sans Unicode", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(570, 8)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(100, 32)
        btnRefresh.TabIndex = 36
        btnRefresh.TabStop = False
        btnRefresh.Text = "🔄 Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' lblTotalTransactions
        ' 
        lblTotalTransactions.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTotalTransactions.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblTotalTransactions.ForeColor = Color.LawnGreen
        lblTotalTransactions.Location = New Point(465, 8)
        lblTotalTransactions.Name = "lblTotalTransactions"
        lblTotalTransactions.Size = New Size(630, 30)
        lblTotalTransactions.TabIndex = 37
        lblTotalTransactions.Text = "Qty: 0 | Discount: ₱0.00 | Total: ₱0.00"
        lblTotalTransactions.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblNDLogs
        ' 
        lblNDLogs.AutoSize = True
        lblNDLogs.BackColor = Color.White
        lblNDLogs.Font = New Font("Lucida Sans Unicode", 16.0F, FontStyle.Bold)
        lblNDLogs.ForeColor = Color.Silver
        lblNDLogs.Location = New Point(500, 680)
        lblNDLogs.Name = "lblNDLogs"
        lblNDLogs.Size = New Size(178, 27)
        lblNDLogs.TabIndex = 38
        lblNDLogs.Text = "No logs found"
        lblNDLogs.TextAlign = ContentAlignment.MiddleCenter
        lblNDLogs.Visible = False
        ' 
        ' lblNDTransactions
        ' 
        lblNDTransactions.AutoSize = True
        lblNDTransactions.BackColor = Color.White
        lblNDTransactions.Font = New Font("Lucida Sans Unicode", 16.0F, FontStyle.Bold)
        lblNDTransactions.ForeColor = Color.Silver
        lblNDTransactions.Location = New Point(450, 360)
        lblNDTransactions.Name = "lblNDTransactions"
        lblNDTransactions.Size = New Size(271, 27)
        lblNDTransactions.TabIndex = 39
        lblNDTransactions.Text = "No transactions found"
        lblNDTransactions.TextAlign = ContentAlignment.MiddleCenter
        lblNDTransactions.Visible = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.ForestGreen
        btnPrint.Cursor = Cursors.Hand
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Lucida Sans Unicode", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(680, 8)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(100, 32)
        btnPrint.TabIndex = 40
        btnPrint.TabStop = False
        btnPrint.Text = "🖨️ Print"
        btnPrint.UseVisualStyleBackColor = False
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
        ' pnlFilters
        ' 
        pnlFilters.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlFilters.BackColor = Color.White
        pnlFilters.Controls.Add(Label9)
        pnlFilters.Controls.Add(cbUserName)
        pnlFilters.Controls.Add(Label3)
        pnlFilters.Controls.Add(cbDateRange)
        pnlFilters.Controls.Add(btnRefresh)
        pnlFilters.Controls.Add(btnPrint)
        pnlFilters.Location = New Point(12, 55)
        pnlFilters.Name = "pnlFilters"
        pnlFilters.Size = New Size(1097, 50)
        pnlFilters.TabIndex = 41
        ' 
        ' pnlSummary
        ' 
        pnlSummary.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSummary.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        pnlSummary.Controls.Add(lblSummaryTitle)
        pnlSummary.Controls.Add(lblTotalTransactions)
        pnlSummary.Location = New Point(12, 115)
        pnlSummary.Name = "pnlSummary"
        pnlSummary.Size = New Size(1097, 45)
        pnlSummary.TabIndex = 42
        ' 
        ' lblSummaryTitle
        ' 
        lblSummaryTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblSummaryTitle.ForeColor = Color.White
        lblSummaryTitle.Location = New Point(15, 8)
        lblSummaryTitle.Name = "lblSummaryTitle"
        lblSummaryTitle.Size = New Size(150, 30)
        lblSummaryTitle.TabIndex = 0
        lblSummaryTitle.Text = "📊 SUMMARY"
        lblSummaryTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ReportsForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.Gainsboro
        ClientSize = New Size(1167, 788)
        Controls.Add(lblNDTransactions)
        Controls.Add(lblNDLogs)
        Controls.Add(pnlSummary)
        Controls.Add(pnlFilters)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(dgLogs)
        Controls.Add(dgReports)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ReportsForm"
        Text = "ReportsForm"
        CType(dgReports, ComponentModel.ISupportInitialize).EndInit()
        CType(dgLogs, ComponentModel.ISupportInitialize).EndInit()
        pnlFilters.ResumeLayout(False)
        pnlFilters.PerformLayout()
        pnlSummary.ResumeLayout(False)
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
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblTotalTransactions As Label
    Friend WithEvents lblNDLogs As Label
    Friend WithEvents lblNDTransactions As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents pnlFilters As Panel
    Friend WithEvents pnlSummary As Panel
    Friend WithEvents lblSummaryTitle As Label
End Class