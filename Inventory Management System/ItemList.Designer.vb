<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemListForm
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
        dgItemList = New DataGridView()
        btnPrint = New Button()
        Label7 = New Label()
        txtSearch = New TextBox()
        btnClear = New Button()
        btnUpdate = New Button()
        btnAdd = New Button()
        cbCategory = New ComboBox()
        Label9 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtCode = New TextBox()
        txtID = New TextBox()
        Label4 = New Label()
        txtItemName = New TextBox()
        Label5 = New Label()
        txtItemDescription = New TextBox()
        cbUnit = New ComboBox()
        Label6 = New Label()
        Label8 = New Label()
        txtReorderLevel = New TextBox()
        btnStockOut = New Button()
        btnStockIn = New Button()
        CType(dgItemList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 37)
        Label1.TabIndex = 1
        Label1.Text = "Item List"
        ' 
        ' dgItemList
        ' 
        dgItemList.AllowUserToAddRows = False
        dgItemList.AllowUserToDeleteRows = False
        dgItemList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgItemList.BackgroundColor = Color.SandyBrown
        dgItemList.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.SandyBrown
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.SaddleBrown
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgItemList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgItemList.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.SandyBrown
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.SaddleBrown
        DataGridViewCellStyle2.SelectionBackColor = Color.SaddleBrown
        DataGridViewCellStyle2.SelectionForeColor = Color.SandyBrown
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgItemList.DefaultCellStyle = DataGridViewCellStyle2
        dgItemList.GridColor = Color.Peru
        dgItemList.Location = New Point(440, 80)
        dgItemList.MultiSelect = False
        dgItemList.Name = "dgItemList"
        dgItemList.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.SandyBrown
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.SaddleBrown
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgItemList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgItemList.RowHeadersVisible = False
        dgItemList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgItemList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgItemList.Size = New Size(715, 666)
        dgItemList.TabIndex = 3
        dgItemList.TabStop = False
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
        btnPrint.TabIndex = 13
        btnPrint.TabStop = False
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(440, 45)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 20)
        Label7.TabIndex = 12
        Label7.Text = "Search:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.BackColor = Color.SandyBrown
        txtSearch.Font = New Font("Lucida Sans Unicode", 12F)
        txtSearch.ForeColor = Color.SaddleBrown
        txtSearch.Location = New Point(520, 42)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(514, 32)
        txtSearch.TabIndex = 11
        txtSearch.TabStop = False
        ' 
        ' btnClear
        ' 
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.SaddleBrown
        btnClear.Location = New Point(35, 536)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(399, 35)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear Selection"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Gold
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.SaddleBrown
        btnUpdate.Location = New Point(244, 483)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(190, 35)
        btnUpdate.TabIndex = 8
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.LawnGreen
        btnAdd.Cursor = Cursors.Hand
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.SaddleBrown
        btnAdd.Location = New Point(35, 483)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(190, 35)
        btnAdd.TabIndex = 7
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' cbCategory
        ' 
        cbCategory.BackColor = Color.SandyBrown
        cbCategory.Cursor = Cursors.Hand
        cbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cbCategory.FlatStyle = FlatStyle.Popup
        cbCategory.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbCategory.ForeColor = Color.SaddleBrown
        cbCategory.FormattingEnabled = True
        cbCategory.Items.AddRange(New Object() {"", "Active", "Inactive"})
        cbCategory.Location = New Point(154, 334)
        cbCategory.Name = "cbCategory"
        cbCategory.Size = New Size(280, 28)
        cbCategory.TabIndex = 4
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(35, 337)
        Label9.Name = "Label9"
        Label9.Size = New Size(94, 20)
        Label9.TabIndex = 16
        Label9.Text = "Category:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(35, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 20)
        Label3.TabIndex = 17
        Label3.Text = "Code:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(35, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 20)
        Label2.TabIndex = 18
        Label2.Text = "ID:"
        ' 
        ' txtCode
        ' 
        txtCode.BackColor = Color.SandyBrown
        txtCode.Font = New Font("Lucida Sans Unicode", 12F)
        txtCode.ForeColor = Color.SaddleBrown
        txtCode.Location = New Point(154, 128)
        txtCode.Name = "txtCode"
        txtCode.Size = New Size(280, 32)
        txtCode.TabIndex = 1
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.SandyBrown
        txtID.Enabled = False
        txtID.Font = New Font("Lucida Sans Unicode", 12F)
        txtID.ForeColor = Color.SaddleBrown
        txtID.Location = New Point(154, 80)
        txtID.Name = "txtID"
        txtID.Size = New Size(280, 32)
        txtID.TabIndex = 15
        txtID.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(35, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 20)
        Label4.TabIndex = 24
        Label4.Text = "Item Name:"
        ' 
        ' txtItemName
        ' 
        txtItemName.BackColor = Color.SandyBrown
        txtItemName.Font = New Font("Lucida Sans Unicode", 12F)
        txtItemName.ForeColor = Color.SaddleBrown
        txtItemName.Location = New Point(154, 175)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(280, 32)
        txtItemName.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(35, 226)
        Label5.Name = "Label5"
        Label5.Size = New Size(117, 20)
        Label5.TabIndex = 26
        Label5.Text = "Description:"
        ' 
        ' txtItemDescription
        ' 
        txtItemDescription.BackColor = Color.SandyBrown
        txtItemDescription.Font = New Font("Lucida Sans Unicode", 12F)
        txtItemDescription.ForeColor = Color.SaddleBrown
        txtItemDescription.Location = New Point(154, 223)
        txtItemDescription.Multiline = True
        txtItemDescription.Name = "txtItemDescription"
        txtItemDescription.Size = New Size(280, 96)
        txtItemDescription.TabIndex = 3
        ' 
        ' cbUnit
        ' 
        cbUnit.BackColor = Color.SandyBrown
        cbUnit.Cursor = Cursors.Hand
        cbUnit.DropDownStyle = ComboBoxStyle.DropDownList
        cbUnit.FlatStyle = FlatStyle.Popup
        cbUnit.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbUnit.ForeColor = Color.SaddleBrown
        cbUnit.FormattingEnabled = True
        cbUnit.Items.AddRange(New Object() {"", "Bag", "Box", "Pack", "Piece", "Pcs", "Dozen", "Tray"})
        cbUnit.Location = New Point(154, 378)
        cbUnit.Name = "cbUnit"
        cbUnit.Size = New Size(280, 28)
        cbUnit.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(35, 381)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 20)
        Label6.TabIndex = 27
        Label6.Text = "Unit:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(35, 425)
        Label8.Name = "Label8"
        Label8.Size = New Size(139, 20)
        Label8.TabIndex = 30
        Label8.Text = "Reorder Level:"
        ' 
        ' txtReorderLevel
        ' 
        txtReorderLevel.BackColor = Color.SandyBrown
        txtReorderLevel.Font = New Font("Lucida Sans Unicode", 12F)
        txtReorderLevel.ForeColor = Color.SaddleBrown
        txtReorderLevel.Location = New Point(180, 422)
        txtReorderLevel.Name = "txtReorderLevel"
        txtReorderLevel.Size = New Size(254, 32)
        txtReorderLevel.TabIndex = 6
        ' 
        ' btnStockOut
        ' 
        btnStockOut.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnStockOut.BackColor = Color.SaddleBrown
        btnStockOut.Cursor = Cursors.Hand
        btnStockOut.FlatAppearance.BorderColor = Color.SandyBrown
        btnStockOut.FlatAppearance.BorderSize = 0
        btnStockOut.FlatStyle = FlatStyle.Flat
        btnStockOut.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStockOut.ForeColor = Color.SandyBrown
        btnStockOut.Image = My.Resources.Resources.out_of_the_box
        btnStockOut.ImageAlign = ContentAlignment.MiddleLeft
        btnStockOut.Location = New Point(35, 710)
        btnStockOut.Name = "btnStockOut"
        btnStockOut.Size = New Size(399, 35)
        btnStockOut.TabIndex = 32
        btnStockOut.Text = "Stock-Out"
        btnStockOut.UseVisualStyleBackColor = False
        ' 
        ' btnStockIn
        ' 
        btnStockIn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnStockIn.BackColor = Color.SaddleBrown
        btnStockIn.Cursor = Cursors.Hand
        btnStockIn.FlatAppearance.BorderColor = Color.SandyBrown
        btnStockIn.FlatAppearance.BorderSize = 0
        btnStockIn.FlatStyle = FlatStyle.Flat
        btnStockIn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStockIn.ForeColor = Color.SandyBrown
        btnStockIn.Image = My.Resources.Resources.product
        btnStockIn.ImageAlign = ContentAlignment.MiddleLeft
        btnStockIn.Location = New Point(35, 661)
        btnStockIn.Name = "btnStockIn"
        btnStockIn.Size = New Size(399, 35)
        btnStockIn.TabIndex = 31
        btnStockIn.Text = "Stock-In"
        btnStockIn.UseVisualStyleBackColor = False
        ' 
        ' ItemListForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(1167, 758)
        Controls.Add(btnStockOut)
        Controls.Add(btnStockIn)
        Controls.Add(Label8)
        Controls.Add(txtReorderLevel)
        Controls.Add(cbUnit)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtItemDescription)
        Controls.Add(Label4)
        Controls.Add(txtItemName)
        Controls.Add(btnClear)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(cbCategory)
        Controls.Add(Label9)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtCode)
        Controls.Add(txtID)
        Controls.Add(btnPrint)
        Controls.Add(Label7)
        Controls.Add(txtSearch)
        Controls.Add(dgItemList)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "ItemListForm"
        ShowIcon = False
        Text = "Item List"
        CType(dgItemList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgItemList As DataGridView
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtItemDescription As TextBox
    Friend WithEvents cbUnit As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtReorderLevel As TextBox
    Friend WithEvents btnStockOut As Button
    Friend WithEvents btnStockIn As Button
End Class
