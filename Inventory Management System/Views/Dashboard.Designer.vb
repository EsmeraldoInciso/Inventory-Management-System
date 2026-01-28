<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
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
        Label1 = New Label()
        pnlShadow1 = New Panel()
        pnlCard1 = New Panel()
        lblTotalStockItems = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        lblCategories = New Label()
        Label5 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        lblLowStockAlerts = New Label()
        Label7 = New Label()
        Panel4 = New Panel()
        pnlPieMain = New Panel()
        Label6 = New Label()
        pnlPie = New Panel()
        pnlBarMain = New Panel()
        Label8 = New Label()
        pnlBar = New Panel()
        pnlLineMain = New Panel()
        Label9 = New Label()
        pnlLine = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        dgLowStocks = New DataGridView()
        dgRecentStockInOut = New DataGridView()
        Label3 = New Label()
        Label4 = New Label()
        pnlSalesBanner = New Panel()
        lblSalesLabel = New Label()
        lblSalesToday = New Label()
        btnViewReports = New Button()
        Panel8 = New Panel()
        pnlCard1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        pnlPieMain.SuspendLayout()
        pnlBarMain.SuspendLayout()
        pnlLineMain.SuspendLayout()
        CType(dgLowStocks, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgRecentStockInOut, ComponentModel.ISupportInitialize).BeginInit()
        pnlSalesBanner.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 37)
        Label1.TabIndex = 0
        Label1.Text = "Dashboard"
        ' 
        ' pnlShadow1
        ' 
        pnlShadow1.BackColor = SystemColors.ControlDarkDark
        pnlShadow1.Location = New Point(67, 101)
        pnlShadow1.Name = "pnlShadow1"
        pnlShadow1.Size = New Size(267, 151)
        pnlShadow1.TabIndex = 1
        ' 
        ' pnlCard1
        ' 
        pnlCard1.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        pnlCard1.BorderStyle = BorderStyle.FixedSingle
        pnlCard1.Controls.Add(lblTotalStockItems)
        pnlCard1.Controls.Add(Label2)
        pnlCard1.Cursor = Cursors.Hand
        pnlCard1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pnlCard1.Location = New Point(62, 95)
        pnlCard1.Name = "pnlCard1"
        pnlCard1.Size = New Size(267, 151)
        pnlCard1.TabIndex = 2
        ' 
        ' lblTotalStockItems
        ' 
        lblTotalStockItems.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalStockItems.ForeColor = SystemColors.ControlLightLight
        lblTotalStockItems.Location = New Point(-1, 4)
        lblTotalStockItems.Name = "lblTotalStockItems"
        lblTotalStockItems.Size = New Size(267, 93)
        lblTotalStockItems.TabIndex = 1
        lblTotalStockItems.Text = "0"
        lblTotalStockItems.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(-1, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(267, 40)
        Label2.TabIndex = 0
        Label2.Text = "Product Listed"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lblCategories)
        Panel1.Controls.Add(Label5)
        Panel1.Cursor = Cursors.Hand
        Panel1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(370, 95)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(267, 151)
        Panel1.TabIndex = 4
        ' 
        ' lblCategories
        ' 
        lblCategories.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCategories.ForeColor = SystemColors.ControlLightLight
        lblCategories.Location = New Point(-1, 4)
        lblCategories.Name = "lblCategories"
        lblCategories.Size = New Size(267, 93)
        lblCategories.TabIndex = 1
        lblCategories.Text = "0"
        lblCategories.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(-1, 84)
        Label5.Name = "Label5"
        Label5.Size = New Size(267, 40)
        Label5.TabIndex = 0
        Label5.Text = "Categories"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDarkDark
        Panel2.Location = New Point(375, 101)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(267, 151)
        Panel2.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(lblLowStockAlerts)
        Panel3.Controls.Add(Label7)
        Panel3.Cursor = Cursors.Hand
        Panel3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel3.Location = New Point(679, 95)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(267, 151)
        Panel3.TabIndex = 6
        ' 
        ' lblLowStockAlerts
        ' 
        lblLowStockAlerts.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLowStockAlerts.ForeColor = SystemColors.ControlLightLight
        lblLowStockAlerts.Location = New Point(-1, 4)
        lblLowStockAlerts.Name = "lblLowStockAlerts"
        lblLowStockAlerts.Size = New Size(267, 93)
        lblLowStockAlerts.TabIndex = 1
        lblLowStockAlerts.Text = "0"
        lblLowStockAlerts.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(-1, 84)
        Label7.Name = "Label7"
        Label7.Size = New Size(267, 40)
        Label7.TabIndex = 0
        Label7.Text = "Low Stock Alerts"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ControlDarkDark
        Panel4.Location = New Point(684, 101)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(267, 151)
        Panel4.TabIndex = 5
        ' 
        ' pnlPieMain
        ' 
        pnlPieMain.BackColor = SystemColors.ControlLightLight
        pnlPieMain.Controls.Add(Label6)
        pnlPieMain.Controls.Add(pnlPie)
        pnlPieMain.Location = New Point(62, 328)
        pnlPieMain.Name = "pnlPieMain"
        pnlPieMain.Size = New Size(380, 305)
        pnlPieMain.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label6.Location = New Point(0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(380, 45)
        Label6.TabIndex = 1
        Label6.Text = "Stock Distribution by Category"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlPie
        ' 
        pnlPie.Location = New Point(0, 48)
        pnlPie.Name = "pnlPie"
        pnlPie.Size = New Size(380, 257)
        pnlPie.TabIndex = 0
        ' 
        ' pnlBarMain
        ' 
        pnlBarMain.BackColor = SystemColors.ControlLightLight
        pnlBarMain.Controls.Add(Label8)
        pnlBarMain.Controls.Add(pnlBar)
        pnlBarMain.Location = New Point(454, 328)
        pnlBarMain.Name = "pnlBarMain"
        pnlBarMain.Size = New Size(382, 305)
        pnlBarMain.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label8.Location = New Point(0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(382, 45)
        Label8.TabIndex = 2
        Label8.Text = "Top 5 Fast-Moving Items"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlBar
        ' 
        pnlBar.Location = New Point(0, 48)
        pnlBar.Name = "pnlBar"
        pnlBar.Size = New Size(382, 257)
        pnlBar.TabIndex = 1
        ' 
        ' pnlLineMain
        ' 
        pnlLineMain.BackColor = SystemColors.ControlLightLight
        pnlLineMain.Controls.Add(Label9)
        pnlLineMain.Controls.Add(pnlLine)
        pnlLineMain.Location = New Point(848, 328)
        pnlLineMain.Name = "pnlLineMain"
        pnlLineMain.Size = New Size(382, 305)
        pnlLineMain.TabIndex = 9
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label9.Location = New Point(0, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(382, 45)
        Label9.TabIndex = 3
        Label9.Text = "Stock Movement Trend"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlLine
        ' 
        pnlLine.Location = New Point(0, 48)
        pnlLine.Name = "pnlLine"
        pnlLine.Size = New Size(382, 257)
        pnlLine.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ControlDarkDark
        Panel5.Location = New Point(853, 333)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(382, 305)
        Panel5.TabIndex = 12
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ControlDarkDark
        Panel6.Location = New Point(459, 333)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(382, 305)
        Panel6.TabIndex = 11
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.ControlDarkDark
        Panel7.Location = New Point(67, 333)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(380, 305)
        Panel7.TabIndex = 10
        ' 
        ' dgLowStocks
        ' 
        dgLowStocks.AllowUserToAddRows = False
        dgLowStocks.AllowUserToDeleteRows = False
        dgLowStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgLowStocks.BackgroundColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        dgLowStocks.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.Gainsboro
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgLowStocks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgLowStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgLowStocks.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12.0F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgLowStocks.DefaultCellStyle = DataGridViewCellStyle2
        dgLowStocks.GridColor = Color.Gainsboro
        dgLowStocks.Location = New Point(62, 713)
        dgLowStocks.MultiSelect = False
        dgLowStocks.Name = "dgLowStocks"
        dgLowStocks.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12.0F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgLowStocks.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgLowStocks.RowHeadersVisible = False
        dgLowStocks.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgLowStocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgLowStocks.Size = New Size(580, 351)
        dgLowStocks.TabIndex = 13
        dgLowStocks.TabStop = False
        ' 
        ' dgRecentStockInOut
        ' 
        dgRecentStockInOut.AllowUserToAddRows = False
        dgRecentStockInOut.AllowUserToDeleteRows = False
        dgRecentStockInOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgRecentStockInOut.BackgroundColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        dgRecentStockInOut.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = Color.Gainsboro
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgRecentStockInOut.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgRecentStockInOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgRecentStockInOut.Cursor = Cursors.Hand
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 12.0F)
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgRecentStockInOut.DefaultCellStyle = DataGridViewCellStyle5
        dgRecentStockInOut.GridColor = Color.Gainsboro
        dgRecentStockInOut.Location = New Point(651, 713)
        dgRecentStockInOut.MultiSelect = False
        dgRecentStockInOut.Name = "dgRecentStockInOut"
        dgRecentStockInOut.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 12.0F)
        DataGridViewCellStyle6.ForeColor = Color.Gainsboro
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgRecentStockInOut.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgRecentStockInOut.RowHeadersVisible = False
        dgRecentStockInOut.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgRecentStockInOut.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgRecentStockInOut.Size = New Size(580, 351)
        dgRecentStockInOut.TabIndex = 14
        dgRecentStockInOut.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label3.Location = New Point(62, 665)
        Label3.Name = "Label3"
        Label3.Size = New Size(580, 45)
        Label3.TabIndex = 15
        Label3.Text = "Low Stock List"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label4.Location = New Point(651, 665)
        Label4.Name = "Label4"
        Label4.Size = New Size(580, 45)
        Label4.TabIndex = 16
        Label4.Text = "Recent Stock Movements"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlSalesBanner
        ' 
        pnlSalesBanner.BackColor = Color.ForestGreen
        pnlSalesBanner.Controls.Add(lblSalesLabel)
        pnlSalesBanner.Controls.Add(lblSalesToday)
        pnlSalesBanner.Controls.Add(btnViewReports)
        pnlSalesBanner.Cursor = Cursors.Hand
        pnlSalesBanner.Location = New Point(62, 260)
        pnlSalesBanner.Name = "pnlSalesBanner"
        pnlSalesBanner.Size = New Size(884, 50)
        pnlSalesBanner.TabIndex = 17
        ' 
        ' lblSalesLabel
        ' 
        lblSalesLabel.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblSalesLabel.ForeColor = Color.White
        lblSalesLabel.Location = New Point(15, 8)
        lblSalesLabel.Name = "lblSalesLabel"
        lblSalesLabel.Size = New Size(180, 35)
        lblSalesLabel.TabIndex = 0
        lblSalesLabel.Text = "💰 SALES TODAY:"
        lblSalesLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSalesToday
        ' 
        lblSalesToday.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblSalesToday.ForeColor = Color.White
        lblSalesToday.Location = New Point(200, 5)
        lblSalesToday.Name = "lblSalesToday"
        lblSalesToday.Size = New Size(250, 40)
        lblSalesToday.TabIndex = 1
        lblSalesToday.Text = "₱0.00"
        lblSalesToday.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnViewReports
        ' 
        btnViewReports.BackColor = Color.White
        btnViewReports.Cursor = Cursors.Hand
        btnViewReports.FlatAppearance.BorderSize = 0
        btnViewReports.FlatStyle = FlatStyle.Flat
        btnViewReports.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnViewReports.ForeColor = Color.ForestGreen
        btnViewReports.Location = New Point(750, 10)
        btnViewReports.Name = "btnViewReports"
        btnViewReports.Size = New Size(120, 30)
        btnViewReports.TabIndex = 2
        btnViewReports.Text = "View Reports →"
        btnViewReports.UseVisualStyleBackColor = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.ControlDarkDark
        Panel8.Cursor = Cursors.Hand
        Panel8.Location = New Point(67, 267)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(884, 50)
        Panel8.TabIndex = 18
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoScrollMinSize = New Size(0, 500)
        BackColor = Color.Gainsboro
        ClientSize = New Size(1386, 788)
        Controls.Add(pnlSalesBanner)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(dgRecentStockInOut)
        Controls.Add(dgLowStocks)
        Controls.Add(pnlLineMain)
        Controls.Add(pnlBarMain)
        Controls.Add(pnlPieMain)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(pnlCard1)
        Controls.Add(pnlShadow1)
        Controls.Add(Label1)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel8)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "DashboardForm"
        ShowIcon = False
        Text = "Dashboard"
        pnlCard1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        pnlPieMain.ResumeLayout(False)
        pnlBarMain.ResumeLayout(False)
        pnlLineMain.ResumeLayout(False)
        CType(dgLowStocks, ComponentModel.ISupportInitialize).EndInit()
        CType(dgRecentStockInOut, ComponentModel.ISupportInitialize).EndInit()
        pnlSalesBanner.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlShadow1 As Panel
    Friend WithEvents pnlCard1 As Panel
    Friend WithEvents lblTotalStockItems As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCategories As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblLowStockAlerts As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnlPieMain As Panel
    Friend WithEvents pnlBarMain As Panel
    Friend WithEvents pnlLineMain As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents dgLowStocks As DataGridView
    Friend WithEvents dgRecentStockInOut As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlPie As Panel
    Friend WithEvents pnlBar As Panel
    Friend WithEvents pnlLine As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents pnlSalesBanner As Panel
    Friend WithEvents lblSalesLabel As Label
    Friend WithEvents lblSalesToday As Label
    Friend WithEvents btnViewReports As Button
    Friend WithEvents Panel8 As Panel
End Class