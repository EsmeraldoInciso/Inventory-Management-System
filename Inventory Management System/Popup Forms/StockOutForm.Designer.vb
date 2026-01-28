<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockOutForm
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
        Panel1 = New Panel()
        btnExit = New Button()
        Label6 = New Label()
        txtItemName = New TextBox()
        btnClear = New Button()
        btnUpdate = New Button()
        btnDeduct = New Button()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtItemCode = New TextBox()
        txtRemarks = New TextBox()
        txtReferenceNo = New TextBox()
        txtQuantity = New TextBox()
        Label2 = New Label()
        txtID = New TextBox()
        dgStockOut = New DataGridView()
        Label1 = New Label()
        btnClose = New Button()
        Label8 = New Label()
        cbCustomerType = New ComboBox()
        pnlIdNumber = New Panel()
        Label9 = New Label()
        txtIdNumber = New TextBox()
        Label10 = New Label()
        txtUnitPrice = New TextBox()
        Label11 = New Label()
        txtPromoDiscount = New TextBox()
        Label12 = New Label()
        txtSubtotal = New TextBox()
        Label13 = New Label()
        txtCustomerDiscount = New TextBox()
        Label14 = New Label()
        txtTotal = New TextBox()
        Panel1.SuspendLayout()
        CType(dgStockOut, ComponentModel.ISupportInitialize).BeginInit()
        pnlIdNumber.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gainsboro
        Panel1.Controls.Add(txtPromoDiscount)
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtItemName)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnDeduct)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtItemCode)
        Panel1.Controls.Add(txtRemarks)
        Panel1.Controls.Add(txtReferenceNo)
        Panel1.Controls.Add(txtQuantity)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtID)
        Panel1.Controls.Add(dgStockOut)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnClose)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(cbCustomerType)
        Panel1.Controls.Add(pnlIdNumber)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(txtUnitPrice)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(txtSubtotal)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(txtCustomerDiscount)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(txtTotal)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(824, 864)
        Panel1.TabIndex = 8
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExit.Cursor = Cursors.Hand
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnExit.Location = New Point(791, 3)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(30, 30)
        btnExit.TabIndex = 28
        btnExit.TabStop = False
        btnExit.Text = "x"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label6.Location = New Point(29, 118)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 20)
        Label6.TabIndex = 27
        Label6.Text = "Name:"
        ' 
        ' txtItemName
        ' 
        txtItemName.BackColor = Color.Gainsboro
        txtItemName.Enabled = False
        txtItemName.Font = New Font("Lucida Sans Unicode", 12.0F)
        txtItemName.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtItemName.Location = New Point(180, 115)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(220, 32)
        txtItemName.TabIndex = 26
        txtItemName.TabStop = False
        ' 
        ' btnClear
        ' 
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnClear.Location = New Point(424, 410)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(364, 35)
        btnClear.TabIndex = 25
        btnClear.Text = "Clear Selection"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Gold
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnUpdate.Location = New Point(617, 365)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(171, 35)
        btnUpdate.TabIndex = 24
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDeduct
        ' 
        btnDeduct.BackColor = Color.LawnGreen
        btnDeduct.Cursor = Cursors.Hand
        btnDeduct.FlatStyle = FlatStyle.Popup
        btnDeduct.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeduct.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnDeduct.Location = New Point(424, 365)
        btnDeduct.Name = "btnDeduct"
        btnDeduct.Size = New Size(171, 35)
        btnDeduct.TabIndex = 23
        btnDeduct.Text = "Deduct"
        btnDeduct.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(409, 74)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 20)
        Label7.TabIndex = 22
        Label7.Text = "Code:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(409, 118)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 20)
        Label5.TabIndex = 22
        Label5.Text = "Remarks:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label4.Location = New Point(29, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 20)
        Label4.TabIndex = 22
        Label4.Text = "Reference No.:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label3.Location = New Point(29, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 22
        Label3.Text = "Quantity:"
        ' 
        ' txtItemCode
        ' 
        txtItemCode.BackColor = Color.Gainsboro
        txtItemCode.Enabled = False
        txtItemCode.Font = New Font("Lucida Sans Unicode", 12.0F)
        txtItemCode.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtItemCode.Location = New Point(520, 71)
        txtItemCode.Name = "txtItemCode"
        txtItemCode.Size = New Size(268, 32)
        txtItemCode.TabIndex = 21
        txtItemCode.TabStop = False
        ' 
        ' txtRemarks
        ' 
        txtRemarks.BackColor = Color.Gainsboro
        txtRemarks.Font = New Font("Lucida Sans Unicode", 12.0F)
        txtRemarks.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtRemarks.Location = New Point(520, 115)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.Size = New Size(268, 32)
        txtRemarks.TabIndex = 21
        txtRemarks.TabStop = False
        ' 
        ' txtReferenceNo
        ' 
        txtReferenceNo.BackColor = Color.Gainsboro
        txtReferenceNo.Font = New Font("Lucida Sans Unicode", 12.0F)
        txtReferenceNo.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtReferenceNo.Location = New Point(180, 205)
        txtReferenceNo.Name = "txtReferenceNo"
        txtReferenceNo.Size = New Size(220, 32)
        txtReferenceNo.TabIndex = 21
        txtReferenceNo.TabStop = False
        ' 
        ' txtQuantity
        ' 
        txtQuantity.BackColor = Color.Gainsboro
        txtQuantity.Font = New Font("Lucida Sans Unicode", 12.0F)
        txtQuantity.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtQuantity.Location = New Point(180, 160)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(220, 32)
        txtQuantity.TabIndex = 21
        txtQuantity.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label2.Location = New Point(29, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 20)
        Label2.TabIndex = 20
        Label2.Text = "ID:"
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.Gainsboro
        txtID.Enabled = False
        txtID.Font = New Font("Lucida Sans Unicode", 12.0F)
        txtID.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtID.Location = New Point(180, 71)
        txtID.Name = "txtID"
        txtID.Size = New Size(220, 32)
        txtID.TabIndex = 19
        txtID.TabStop = False
        ' 
        ' dgStockOut
        ' 
        dgStockOut.AllowUserToAddRows = False
        dgStockOut.AllowUserToDeleteRows = False
        dgStockOut.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgStockOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgStockOut.BackgroundColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        dgStockOut.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgStockOut.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgStockOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgStockOut.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgStockOut.DefaultCellStyle = DataGridViewCellStyle2
        dgStockOut.GridColor = Color.Gainsboro
        dgStockOut.Location = New Point(9, 491)
        dgStockOut.MultiSelect = False
        dgStockOut.Name = "dgStockOut"
        dgStockOut.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgStockOut.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgStockOut.RowHeadersVisible = False
        dgStockOut.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgStockOut.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgStockOut.Size = New Size(806, 282)
        dgStockOut.TabIndex = 12
        dgStockOut.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label1.Location = New Point(9, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(215, 37)
        Label1.TabIndex = 7
        Label1.Text = "Stock-Out Form"
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.SaddleBrown
        btnClose.Location = New Point(1415, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(30, 30)
        btnClose.TabIndex = 6
        btnClose.TabStop = False
        btnClose.Text = "x"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label8.Location = New Point(29, 253)
        Label8.Name = "Label8"
        Label8.Size = New Size(148, 20)
        Label8.TabIndex = 29
        Label8.Text = "Customer Type:"
        ' 
        ' cbCustomerType
        ' 
        cbCustomerType.BackColor = Color.Gainsboro
        cbCustomerType.Cursor = Cursors.Hand
        cbCustomerType.DropDownStyle = ComboBoxStyle.DropDownList
        cbCustomerType.FlatStyle = FlatStyle.Popup
        cbCustomerType.Font = New Font("Lucida Sans Unicode", 12.0F)
        cbCustomerType.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        cbCustomerType.FormattingEnabled = True
        cbCustomerType.Items.AddRange(New Object() {"Regular", "Senior Citizen", "PWD"})
        cbCustomerType.Location = New Point(180, 250)
        cbCustomerType.Name = "cbCustomerType"
        cbCustomerType.Size = New Size(220, 28)
        cbCustomerType.TabIndex = 30
        ' 
        ' pnlIdNumber
        ' 
        pnlIdNumber.Controls.Add(Label9)
        pnlIdNumber.Controls.Add(txtIdNumber)
        pnlIdNumber.Location = New Point(29, 285)
        pnlIdNumber.Name = "pnlIdNumber"
        pnlIdNumber.Size = New Size(378, 40)
        pnlIdNumber.TabIndex = 33
        pnlIdNumber.Visible = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label9.Location = New Point(3, 8)
        Label9.Name = "Label9"
        Label9.Size = New Size(110, 20)
        Label9.TabIndex = 31
        Label9.Text = "ID Number:"
        ' 
        ' txtIdNumber
        ' 
        txtIdNumber.BackColor = Color.Gainsboro
        txtIdNumber.Font = New Font("Lucida Sans Unicode", 12.0F)
        txtIdNumber.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtIdNumber.Location = New Point(151, 5)
        txtIdNumber.Name = "txtIdNumber"
        txtIdNumber.Size = New Size(220, 32)
        txtIdNumber.TabIndex = 32
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label10.Location = New Point(409, 163)
        Label10.Name = "Label10"
        Label10.Size = New Size(101, 20)
        Label10.TabIndex = 34
        Label10.Text = "Unit Price:"
        ' 
        ' txtUnitPrice
        ' 
        txtUnitPrice.BackColor = Color.Gainsboro
        txtUnitPrice.Enabled = False
        txtUnitPrice.Font = New Font("Lucida Sans Unicode", 12.0F)
        txtUnitPrice.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtUnitPrice.Location = New Point(560, 160)
        txtUnitPrice.Name = "txtUnitPrice"
        txtUnitPrice.Size = New Size(228, 32)
        txtUnitPrice.TabIndex = 35
        txtUnitPrice.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label11.Location = New Point(409, 203)
        Label11.Name = "Label11"
        Label11.Size = New Size(154, 20)
        Label11.TabIndex = 36
        Label11.Text = "Promo Discount:"
        ' 
        ' txtPromoDiscount
        ' 
        txtPromoDiscount.BackColor = Color.Gainsboro
        txtPromoDiscount.Enabled = False
        txtPromoDiscount.Font = New Font("Lucida Sans Unicode", 12.0F)
        txtPromoDiscount.ForeColor = Color.Green
        txtPromoDiscount.Location = New Point(560, 200)
        txtPromoDiscount.Name = "txtPromoDiscount"
        txtPromoDiscount.Size = New Size(228, 32)
        txtPromoDiscount.TabIndex = 37
        txtPromoDiscount.Text = "-"
        txtPromoDiscount.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label12.Location = New Point(409, 243)
        Label12.Name = "Label12"
        Label12.Size = New Size(88, 20)
        Label12.TabIndex = 38
        Label12.Text = "Subtotal:"
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.BackColor = Color.Gainsboro
        txtSubtotal.Enabled = False
        txtSubtotal.Font = New Font("Lucida Sans Unicode", 12.0F)
        txtSubtotal.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtSubtotal.Location = New Point(560, 240)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.Size = New Size(228, 32)
        txtSubtotal.TabIndex = 39
        txtSubtotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label13.Location = New Point(409, 283)
        Label13.Name = "Label13"
        Label13.Size = New Size(143, 20)
        Label13.TabIndex = 40
        Label13.Text = "Cust. Discount:"
        ' 
        ' txtCustomerDiscount
        ' 
        txtCustomerDiscount.BackColor = Color.Gainsboro
        txtCustomerDiscount.Enabled = False
        txtCustomerDiscount.Font = New Font("Lucida Sans Unicode", 12.0F)
        txtCustomerDiscount.ForeColor = Color.Green
        txtCustomerDiscount.Location = New Point(560, 280)
        txtCustomerDiscount.Name = "txtCustomerDiscount"
        txtCustomerDiscount.Size = New Size(228, 32)
        txtCustomerDiscount.TabIndex = 41
        txtCustomerDiscount.Text = "-"
        txtCustomerDiscount.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label14.Location = New Point(409, 328)
        Label14.Name = "Label14"
        Label14.Size = New Size(84, 23)
        Label14.TabIndex = 42
        Label14.Text = "TOTAL:"
        ' 
        ' txtTotal
        ' 
        txtTotal.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtTotal.Enabled = False
        txtTotal.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        txtTotal.ForeColor = Color.LawnGreen
        txtTotal.Location = New Point(560, 320)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(228, 36)
        txtTotal.TabIndex = 43
        txtTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' StockOutForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        ClientSize = New Size(830, 788)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "StockOutForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StockOutForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgStockOut, ComponentModel.ISupportInitialize).EndInit()
        pnlIdNumber.ResumeLayout(False)
        pnlIdNumber.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDeduct As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtReferenceNo As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents dgStockOut As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnExit As Button
    ' New discount-related controls
    Friend WithEvents Label8 As Label
    Friend WithEvents cbCustomerType As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIdNumber As TextBox
    Friend WithEvents pnlIdNumber As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPromoDiscount As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCustomerDiscount As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTotal As TextBox
End Class