<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoriesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoriesForm))
        Label1 = New Label()
        btnPrint = New Button()
        Label7 = New Label()
        txtSearch = New TextBox()
        dgCategories = New DataGridView()
        btnClear = New Button()
        btnUpdate = New Button()
        btnAdd = New Button()
        Label3 = New Label()
        Label2 = New Label()
        txtCategoryName = New TextBox()
        txtID = New TextBox()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        CType(dgCategories, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 37)
        Label1.TabIndex = 4
        Label1.Text = "Categories"
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrint.Cursor = Cursors.Hand
        btnPrint.FlatStyle = FlatStyle.Popup
        btnPrint.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
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
        Label7.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
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
        txtSearch.Font = New Font("Lucida Sans Unicode", 14F)
        txtSearch.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtSearch.Location = New Point(531, 42)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(503, 36)
        txtSearch.TabIndex = 12
        txtSearch.TabStop = False
        ' 
        ' dgCategories
        ' 
        dgCategories.AllowUserToAddRows = False
        dgCategories.AllowUserToDeleteRows = False
        dgCategories.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgCategories.BackgroundColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        dgCategories.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgCategories.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgCategories.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgCategories.DefaultCellStyle = DataGridViewCellStyle2
        dgCategories.GridColor = Color.Gainsboro
        dgCategories.Location = New Point(440, 80)
        dgCategories.MultiSelect = False
        dgCategories.Name = "dgCategories"
        dgCategories.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgCategories.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgCategories.RowHeadersVisible = False
        dgCategories.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgCategories.Size = New Size(715, 666)
        dgCategories.TabIndex = 11
        dgCategories.TabStop = False
        ' 
        ' btnClear
        ' 
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        btnClear.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnClear.Location = New Point(35, 337)
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
        btnUpdate.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnUpdate.Location = New Point(244, 284)
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
        btnAdd.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        btnAdd.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnAdd.Location = New Point(35, 284)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(190, 35)
        btnAdd.TabIndex = 19
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label3.Location = New Point(35, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(174, 23)
        Label3.TabIndex = 17
        Label3.Text = "Category Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 14F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        Label2.Location = New Point(35, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 23)
        Label2.TabIndex = 18
        Label2.Text = "ID:"
        ' 
        ' txtCategoryName
        ' 
        txtCategoryName.BackColor = Color.Gainsboro
        txtCategoryName.Font = New Font("Lucida Sans Unicode", 14F)
        txtCategoryName.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtCategoryName.Location = New Point(92, 160)
        txtCategoryName.Multiline = True
        txtCategoryName.Name = "txtCategoryName"
        txtCategoryName.Size = New Size(342, 96)
        txtCategoryName.TabIndex = 15
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.Gainsboro
        txtID.Enabled = False
        txtID.Font = New Font("Lucida Sans Unicode", 14F)
        txtID.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtID.Location = New Point(92, 80)
        txtID.Name = "txtID"
        txtID.Size = New Size(342, 36)
        txtID.TabIndex = 16
        txtID.TabStop = False
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
        ' CategoriesForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1167, 758)
        Controls.Add(btnClear)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtCategoryName)
        Controls.Add(txtID)
        Controls.Add(btnPrint)
        Controls.Add(Label7)
        Controls.Add(txtSearch)
        Controls.Add(dgCategories)
        Controls.Add(Label1)
        Name = "CategoriesForm"
        Text = "CategoriesForm"
        CType(dgCategories, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgCategories As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
