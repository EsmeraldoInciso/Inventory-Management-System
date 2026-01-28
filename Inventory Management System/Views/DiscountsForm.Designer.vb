<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiscountsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiscountsForm))
        Label1 = New Label()
        btnPrint = New Button()
        Label7 = New Label()
        txtSearch = New TextBox()
        dgDiscounts = New DataGridView()
        btnClear = New Button()
        btnUpdate = New Button()
        btnAdd = New Button()
        txtID = New TextBox()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        cbStatus = New ComboBox()
        Label9 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtDiscountName = New TextBox()
        Label4 = New Label()
        cbDiscountType = New ComboBox()
        Label5 = New Label()
        txtDiscountValue = New TextBox()
        Label6 = New Label()
        dtpStartDate = New DateTimePicker()
        Label8 = New Label()
        dtpEndDate = New DateTimePicker()
        chkNoExpiry = New CheckBox()
        Label10 = New Label()
        cbApplyTo = New ComboBox()
        Label11 = New Label()
        cbItem = New ComboBox()
        Label12 = New Label()
        cbCategory = New ComboBox()
        Label13 = New Label()
        cbCustomerType = New ComboBox()
        Label14 = New Label()
        txtMinQuantity = New TextBox()
        pnlItemSelect = New Panel()
        pnlCategorySelect = New Panel()
        pnlCustomerTypeSelect = New Panel()
        CType(dgDiscounts, ComponentModel.ISupportInitialize).BeginInit()
        pnlItemSelect.SuspendLayout()
        pnlCategorySelect.SuspendLayout()
        pnlCustomerTypeSelect.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 37)
        Label1.TabIndex = 4
        Label1.Text = "Discounts"
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrint.Cursor = Cursors.Hand
        btnPrint.FlatStyle = FlatStyle.Popup
        btnPrint.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        btnPrint.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnPrint.Location = New Point(1040, 42)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(115, 32)
        btnPrint.TabIndex = 14
        btnPrint.TabStop = False
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label7.Location = New Point(440, 45)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 23)
        Label7.TabIndex = 13
        Label7.Text = "Search:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.BackColor = Color.Gainsboro
        txtSearch.Font = New Font("Lucida Sans Unicode", 14.0F)
        txtSearch.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtSearch.Location = New Point(531, 42)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(503, 36)
        txtSearch.TabIndex = 12
        txtSearch.TabStop = False
        ' 
        ' dgDiscounts
        ' 
        dgDiscounts.AllowUserToAddRows = False
        dgDiscounts.AllowUserToDeleteRows = False
        dgDiscounts.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgDiscounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgDiscounts.BackgroundColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        dgDiscounts.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgDiscounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgDiscounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgDiscounts.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12.0F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgDiscounts.DefaultCellStyle = DataGridViewCellStyle2
        dgDiscounts.GridColor = Color.Gainsboro
        dgDiscounts.Location = New Point(440, 80)
        dgDiscounts.MultiSelect = False
        dgDiscounts.Name = "dgDiscounts"
        dgDiscounts.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12.0F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgDiscounts.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgDiscounts.RowHeadersVisible = False
        dgDiscounts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgDiscounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgDiscounts.Size = New Size(715, 666)
        dgDiscounts.TabIndex = 11
        dgDiscounts.TabStop = False
        ' 
        ' btnClear
        ' 
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        btnClear.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnClear.Location = New Point(20, 590)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(399, 35)
        btnClear.TabIndex = 21
        btnClear.Text = "Clear Selection"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Gold
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnUpdate.Location = New Point(229, 540)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(190, 35)
        btnUpdate.TabIndex = 20
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.LawnGreen
        btnAdd.Cursor = Cursors.Hand
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        btnAdd.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnAdd.Location = New Point(20, 540)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(190, 35)
        btnAdd.TabIndex = 19
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.Gainsboro
        txtID.Enabled = False
        txtID.Font = New Font("Lucida Sans Unicode", 14.0F)
        txtID.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtID.Location = New Point(150, 55)
        txtID.Name = "txtID"
        txtID.Size = New Size(269, 36)
        txtID.TabIndex = 16
        txtID.TabStop = False
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
        ' cbStatus
        ' 
        cbStatus.BackColor = Color.Gainsboro
        cbStatus.Cursor = Cursors.Hand
        cbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbStatus.FlatStyle = FlatStyle.Popup
        cbStatus.Font = New Font("Lucida Sans Unicode", 14.0F)
        cbStatus.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        cbStatus.Location = New Point(150, 490)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(269, 31)
        cbStatus.TabIndex = 23
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label9.Location = New Point(20, 493)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 23)
        Label9.TabIndex = 22
        Label9.Text = "Status:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label2.Location = New Point(20, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 23)
        Label2.TabIndex = 18
        Label2.Text = "ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label3.Location = New Point(20, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 23)
        Label3.TabIndex = 17
        Label3.Text = "Name:"
        ' 
        ' txtDiscountName
        ' 
        txtDiscountName.BackColor = Color.Gainsboro
        txtDiscountName.Font = New Font("Lucida Sans Unicode", 14.0F)
        txtDiscountName.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtDiscountName.Location = New Point(150, 100)
        txtDiscountName.Name = "txtDiscountName"
        txtDiscountName.Size = New Size(269, 36)
        txtDiscountName.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label4.Location = New Point(20, 148)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 23)
        Label4.TabIndex = 24
        Label4.Text = "Type:"
        ' 
        ' cbDiscountType
        ' 
        cbDiscountType.BackColor = Color.Gainsboro
        cbDiscountType.Cursor = Cursors.Hand
        cbDiscountType.DropDownStyle = ComboBoxStyle.DropDownList
        cbDiscountType.FlatStyle = FlatStyle.Popup
        cbDiscountType.Font = New Font("Lucida Sans Unicode", 14.0F)
        cbDiscountType.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        cbDiscountType.FormattingEnabled = True
        cbDiscountType.Items.AddRange(New Object() {"percentage", "fixed_amount"})
        cbDiscountType.Location = New Point(150, 145)
        cbDiscountType.Name = "cbDiscountType"
        cbDiscountType.Size = New Size(269, 31)
        cbDiscountType.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label5.Location = New Point(20, 193)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 23)
        Label5.TabIndex = 26
        Label5.Text = "Value:"
        ' 
        ' txtDiscountValue
        ' 
        txtDiscountValue.BackColor = Color.Gainsboro
        txtDiscountValue.Font = New Font("Lucida Sans Unicode", 14.0F)
        txtDiscountValue.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtDiscountValue.Location = New Point(150, 190)
        txtDiscountValue.Name = "txtDiscountValue"
        txtDiscountValue.Size = New Size(269, 36)
        txtDiscountValue.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label6.Location = New Point(20, 238)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 23)
        Label6.TabIndex = 28
        Label6.Text = "Start Date:"
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.CalendarForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        dtpStartDate.Font = New Font("Lucida Sans Unicode", 14.0F)
        dtpStartDate.Format = DateTimePickerFormat.Short
        dtpStartDate.Location = New Point(150, 235)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(269, 36)
        dtpStartDate.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        Label8.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label8.Location = New Point(20, 283)
        Label8.Name = "Label8"
        Label8.Size = New Size(107, 23)
        Label8.TabIndex = 30
        Label8.Text = "End Date:"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.CalendarForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        dtpEndDate.Font = New Font("Lucida Sans Unicode", 14.0F)
        dtpEndDate.Format = DateTimePickerFormat.Short
        dtpEndDate.Location = New Point(150, 280)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(269, 36)
        dtpEndDate.TabIndex = 5
        ' 
        ' chkNoExpiry
        ' 
        chkNoExpiry.AutoSize = True
        chkNoExpiry.Font = New Font("Lucida Sans Unicode", 12.0F)
        chkNoExpiry.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        chkNoExpiry.Location = New Point(150, 322)
        chkNoExpiry.Name = "chkNoExpiry"
        chkNoExpiry.Size = New Size(173, 27)
        chkNoExpiry.TabIndex = 6
        chkNoExpiry.Text = "No Expiry (Always)"
        chkNoExpiry.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        Label10.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label10.Location = New Point(20, 358)
        Label10.Name = "Label10"
        Label10.Size = New Size(102, 23)
        Label10.TabIndex = 32
        Label10.Text = "Apply To:"
        ' 
        ' cbApplyTo
        ' 
        cbApplyTo.BackColor = Color.Gainsboro
        cbApplyTo.Cursor = Cursors.Hand
        cbApplyTo.DropDownStyle = ComboBoxStyle.DropDownList
        cbApplyTo.FlatStyle = FlatStyle.Popup
        cbApplyTo.Font = New Font("Lucida Sans Unicode", 14.0F)
        cbApplyTo.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        cbApplyTo.FormattingEnabled = True
        cbApplyTo.Items.AddRange(New Object() {"All Items", "Specific Item", "Category", "Customer Type"})
        cbApplyTo.Location = New Point(150, 355)
        cbApplyTo.Name = "cbApplyTo"
        cbApplyTo.Size = New Size(269, 31)
        cbApplyTo.TabIndex = 7
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        Label11.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label11.Location = New Point(3, 8)
        Label11.Name = "Label11"
        Label11.Size = New Size(59, 23)
        Label11.TabIndex = 34
        Label11.Text = "Item:"
        ' 
        ' cbItem
        ' 
        cbItem.BackColor = Color.Gainsboro
        cbItem.Cursor = Cursors.Hand
        cbItem.DropDownStyle = ComboBoxStyle.DropDownList
        cbItem.FlatStyle = FlatStyle.Popup
        cbItem.Font = New Font("Lucida Sans Unicode", 14.0F)
        cbItem.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        cbItem.FormattingEnabled = True
        cbItem.Location = New Point(130, 5)
        cbItem.Name = "cbItem"
        cbItem.Size = New Size(269, 31)
        cbItem.TabIndex = 8
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        Label12.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label12.Location = New Point(3, 8)
        Label12.Name = "Label12"
        Label12.Size = New Size(105, 23)
        Label12.TabIndex = 36
        Label12.Text = "Category:"
        ' 
        ' cbCategory
        ' 
        cbCategory.BackColor = Color.Gainsboro
        cbCategory.Cursor = Cursors.Hand
        cbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cbCategory.FlatStyle = FlatStyle.Popup
        cbCategory.Font = New Font("Lucida Sans Unicode", 14.0F)
        cbCategory.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        cbCategory.FormattingEnabled = True
        cbCategory.Location = New Point(130, 5)
        cbCategory.Name = "cbCategory"
        cbCategory.Size = New Size(269, 31)
        cbCategory.TabIndex = 9
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        Label13.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label13.Location = New Point(3, 8)
        Label13.Name = "Label13"
        Label13.Size = New Size(121, 23)
        Label13.TabIndex = 38
        Label13.Text = "Cust. Type:"
        ' 
        ' cbCustomerType
        ' 
        cbCustomerType.BackColor = Color.Gainsboro
        cbCustomerType.Cursor = Cursors.Hand
        cbCustomerType.DropDownStyle = ComboBoxStyle.DropDownList
        cbCustomerType.FlatStyle = FlatStyle.Popup
        cbCustomerType.Font = New Font("Lucida Sans Unicode", 14.0F)
        cbCustomerType.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        cbCustomerType.FormattingEnabled = True
        cbCustomerType.Items.AddRange(New Object() {"senior", "pwd"})
        cbCustomerType.Location = New Point(130, 5)
        cbCustomerType.Name = "cbCustomerType"
        cbCustomerType.Size = New Size(269, 31)
        cbCustomerType.TabIndex = 10
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Lucida Sans Unicode", 14.0F, FontStyle.Bold)
        Label14.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label14.Location = New Point(20, 448)
        Label14.Name = "Label14"
        Label14.Size = New Size(93, 23)
        Label14.TabIndex = 40
        Label14.Text = "Min Qty:"
        ' 
        ' txtMinQuantity
        ' 
        txtMinQuantity.BackColor = Color.Gainsboro
        txtMinQuantity.Font = New Font("Lucida Sans Unicode", 14.0F)
        txtMinQuantity.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtMinQuantity.Location = New Point(150, 445)
        txtMinQuantity.Name = "txtMinQuantity"
        txtMinQuantity.Size = New Size(269, 36)
        txtMinQuantity.TabIndex = 11
        txtMinQuantity.Text = "1"
        ' 
        ' pnlItemSelect
        ' 
        pnlItemSelect.Controls.Add(Label11)
        pnlItemSelect.Controls.Add(cbItem)
        pnlItemSelect.Location = New Point(20, 395)
        pnlItemSelect.Name = "pnlItemSelect"
        pnlItemSelect.Size = New Size(399, 45)
        pnlItemSelect.TabIndex = 42
        pnlItemSelect.Visible = False
        ' 
        ' pnlCategorySelect
        ' 
        pnlCategorySelect.Controls.Add(Label12)
        pnlCategorySelect.Controls.Add(cbCategory)
        pnlCategorySelect.Location = New Point(20, 395)
        pnlCategorySelect.Name = "pnlCategorySelect"
        pnlCategorySelect.Size = New Size(399, 45)
        pnlCategorySelect.TabIndex = 43
        pnlCategorySelect.Visible = False
        ' 
        ' pnlCustomerTypeSelect
        ' 
        pnlCustomerTypeSelect.Controls.Add(Label13)
        pnlCustomerTypeSelect.Controls.Add(cbCustomerType)
        pnlCustomerTypeSelect.Location = New Point(20, 395)
        pnlCustomerTypeSelect.Name = "pnlCustomerTypeSelect"
        pnlCustomerTypeSelect.Size = New Size(399, 45)
        pnlCustomerTypeSelect.TabIndex = 44
        pnlCustomerTypeSelect.Visible = False
        ' 
        ' DiscountsForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1167, 758)
        Controls.Add(pnlCustomerTypeSelect)
        Controls.Add(pnlCategorySelect)
        Controls.Add(pnlItemSelect)
        Controls.Add(txtMinQuantity)
        Controls.Add(Label14)
        Controls.Add(cbApplyTo)
        Controls.Add(Label10)
        Controls.Add(chkNoExpiry)
        Controls.Add(dtpEndDate)
        Controls.Add(Label8)
        Controls.Add(dtpStartDate)
        Controls.Add(Label6)
        Controls.Add(txtDiscountValue)
        Controls.Add(Label5)
        Controls.Add(cbDiscountType)
        Controls.Add(Label4)
        Controls.Add(txtDiscountName)
        Controls.Add(Label3)
        Controls.Add(cbStatus)
        Controls.Add(Label9)
        Controls.Add(btnClear)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(Label2)
        Controls.Add(txtID)
        Controls.Add(btnPrint)
        Controls.Add(Label7)
        Controls.Add(txtSearch)
        Controls.Add(dgDiscounts)
        Controls.Add(Label1)
        Name = "DiscountsForm"
        Text = "DiscountsForm"
        CType(dgDiscounts, ComponentModel.ISupportInitialize).EndInit()
        pnlItemSelect.ResumeLayout(False)
        pnlItemSelect.PerformLayout()
        pnlCategorySelect.ResumeLayout(False)
        pnlCategorySelect.PerformLayout()
        pnlCustomerTypeSelect.ResumeLayout(False)
        pnlCustomerTypeSelect.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgDiscounts As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDiscountName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbDiscountType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDiscountValue As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents chkNoExpiry As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbApplyTo As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbItem As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbCustomerType As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtMinQuantity As TextBox
    Friend WithEvents pnlItemSelect As Panel
    Friend WithEvents pnlCategorySelect As Panel
    Friend WithEvents pnlCustomerTypeSelect As Panel
End Class