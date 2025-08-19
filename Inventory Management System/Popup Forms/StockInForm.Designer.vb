<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockInForm
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
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnClose = New Button()
        Panel1 = New Panel()
        Label6 = New Label()
        txtItemName = New TextBox()
        btnClear = New Button()
        btnUpdate = New Button()
        btnAdd = New Button()
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
        dgStockIn = New DataGridView()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(dgStockIn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.SaddleBrown
        btnClose.Location = New Point(791, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(30, 30)
        btnClose.TabIndex = 6
        btnClose.TabStop = False
        btnClose.Text = "x"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SandyBrown
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtItemName)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnAdd)
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
        Panel1.Controls.Add(dgStockIn)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnClose)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(824, 864)
        Panel1.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(29, 118)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 20)
        Label6.TabIndex = 27
        Label6.Text = "Name:"
        ' 
        ' txtItemName
        ' 
        txtItemName.BackColor = Color.SandyBrown
        txtItemName.Enabled = False
        txtItemName.Font = New Font("Lucida Sans Unicode", 12F)
        txtItemName.ForeColor = Color.SaddleBrown
        txtItemName.Location = New Point(173, 115)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(220, 32)
        txtItemName.TabIndex = 26
        txtItemName.TabStop = False
        ' 
        ' btnClear
        ' 
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.SaddleBrown
        btnClear.Location = New Point(424, 205)
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
        btnUpdate.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.SaddleBrown
        btnUpdate.Location = New Point(617, 160)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(171, 35)
        btnUpdate.TabIndex = 24
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
        btnAdd.Location = New Point(424, 160)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(171, 35)
        btnAdd.TabIndex = 23
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(424, 74)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 20)
        Label7.TabIndex = 22
        Label7.Text = "Code:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(424, 118)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 20)
        Label5.TabIndex = 22
        Label5.Text = "Remarks:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(29, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 20)
        Label4.TabIndex = 22
        Label4.Text = "Reference No.:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(29, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 22
        Label3.Text = "Quantity:"
        ' 
        ' txtItemCode
        ' 
        txtItemCode.BackColor = Color.SandyBrown
        txtItemCode.Enabled = False
        txtItemCode.Font = New Font("Lucida Sans Unicode", 12F)
        txtItemCode.ForeColor = Color.SaddleBrown
        txtItemCode.Location = New Point(520, 71)
        txtItemCode.Name = "txtItemCode"
        txtItemCode.Size = New Size(268, 32)
        txtItemCode.TabIndex = 21
        txtItemCode.TabStop = False
        ' 
        ' txtRemarks
        ' 
        txtRemarks.BackColor = Color.SandyBrown
        txtRemarks.Font = New Font("Lucida Sans Unicode", 12F)
        txtRemarks.ForeColor = Color.SaddleBrown
        txtRemarks.Location = New Point(520, 115)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.Size = New Size(268, 32)
        txtRemarks.TabIndex = 21
        txtRemarks.TabStop = False
        ' 
        ' txtReferenceNo
        ' 
        txtReferenceNo.BackColor = Color.SandyBrown
        txtReferenceNo.Font = New Font("Lucida Sans Unicode", 12F)
        txtReferenceNo.ForeColor = Color.SaddleBrown
        txtReferenceNo.Location = New Point(173, 205)
        txtReferenceNo.Name = "txtReferenceNo"
        txtReferenceNo.Size = New Size(220, 32)
        txtReferenceNo.TabIndex = 21
        txtReferenceNo.TabStop = False
        ' 
        ' txtQuantity
        ' 
        txtQuantity.BackColor = Color.SandyBrown
        txtQuantity.Font = New Font("Lucida Sans Unicode", 12F)
        txtQuantity.ForeColor = Color.SaddleBrown
        txtQuantity.Location = New Point(173, 160)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(220, 32)
        txtQuantity.TabIndex = 21
        txtQuantity.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(29, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 20)
        Label2.TabIndex = 20
        Label2.Text = "ID:"
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.SandyBrown
        txtID.Enabled = False
        txtID.Font = New Font("Lucida Sans Unicode", 12F)
        txtID.ForeColor = Color.SaddleBrown
        txtID.Location = New Point(173, 71)
        txtID.Name = "txtID"
        txtID.Size = New Size(220, 32)
        txtID.TabIndex = 19
        txtID.TabStop = False
        ' 
        ' dgStockIn
        ' 
        dgStockIn.AllowUserToAddRows = False
        dgStockIn.AllowUserToDeleteRows = False
        dgStockIn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgStockIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgStockIn.BackgroundColor = Color.SandyBrown
        dgStockIn.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.SandyBrown
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle7.ForeColor = Color.SaddleBrown
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        dgStockIn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        dgStockIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgStockIn.Cursor = Cursors.Hand
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.SandyBrown
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle8.ForeColor = Color.SaddleBrown
        DataGridViewCellStyle8.SelectionBackColor = Color.SaddleBrown
        DataGridViewCellStyle8.SelectionForeColor = Color.SandyBrown
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        dgStockIn.DefaultCellStyle = DataGridViewCellStyle8
        dgStockIn.GridColor = Color.Peru
        dgStockIn.Location = New Point(9, 265)
        dgStockIn.MultiSelect = False
        dgStockIn.Name = "dgStockIn"
        dgStockIn.ReadOnly = True
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.SandyBrown
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle9.ForeColor = Color.SaddleBrown
        DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        dgStockIn.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        dgStockIn.RowHeadersVisible = False
        dgStockIn.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgStockIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgStockIn.Size = New Size(806, 590)
        dgStockIn.TabIndex = 12
        dgStockIn.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(9, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 37)
        Label1.TabIndex = 7
        Label1.Text = "Stock-In Form"
        ' 
        ' StockInForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(830, 870)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "StockInForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "StockInForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgStockIn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgStockIn As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtReferenceNo As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtItemCode As TextBox
End Class
