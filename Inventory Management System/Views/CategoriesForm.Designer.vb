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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        CType(dgCategories, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)
        Label1.ForeColor = Color.SaddleBrown
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
        btnPrint.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btnPrint.ForeColor = Color.SaddleBrown
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
        Label7.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label7.Location = New Point(440, 45)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 20)
        Label7.TabIndex = 13
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
        txtSearch.TabIndex = 12
        txtSearch.TabStop = False
        ' 
        ' dgCategories
        ' 
        dgCategories.AllowUserToAddRows = False
        dgCategories.AllowUserToDeleteRows = False
        dgCategories.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgCategories.BackgroundColor = Color.SandyBrown
        dgCategories.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.SandyBrown
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = Color.SaddleBrown
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgCategories.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgCategories.Cursor = Cursors.Hand
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.SandyBrown
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.SaddleBrown
        DataGridViewCellStyle5.SelectionBackColor = Color.SaddleBrown
        DataGridViewCellStyle5.SelectionForeColor = Color.SandyBrown
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgCategories.DefaultCellStyle = DataGridViewCellStyle5
        dgCategories.GridColor = Color.Peru
        dgCategories.Location = New Point(440, 80)
        dgCategories.MultiSelect = False
        dgCategories.Name = "dgCategories"
        dgCategories.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.SandyBrown
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.SaddleBrown
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgCategories.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
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
        btnClear.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btnClear.ForeColor = Color.SaddleBrown
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
        btnUpdate.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btnUpdate.ForeColor = Color.SaddleBrown
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
        btnAdd.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btnAdd.ForeColor = Color.SaddleBrown
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
        Label3.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label3.Location = New Point(35, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 20)
        Label3.TabIndex = 17
        Label3.Text = "Category Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label2.Location = New Point(35, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 20)
        Label2.TabIndex = 18
        Label2.Text = "ID:"
        ' 
        ' txtCategoryName
        ' 
        txtCategoryName.BackColor = Color.SandyBrown
        txtCategoryName.Font = New Font("Lucida Sans Unicode", 12F)
        txtCategoryName.ForeColor = Color.SaddleBrown
        txtCategoryName.Location = New Point(92, 154)
        txtCategoryName.Multiline = True
        txtCategoryName.Name = "txtCategoryName"
        txtCategoryName.Size = New Size(342, 96)
        txtCategoryName.TabIndex = 15
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.SandyBrown
        txtID.Enabled = False
        txtID.Font = New Font("Lucida Sans Unicode", 12F)
        txtID.ForeColor = Color.SaddleBrown
        txtID.Location = New Point(92, 80)
        txtID.Name = "txtID"
        txtID.Size = New Size(342, 32)
        txtID.TabIndex = 16
        txtID.TabStop = False
        ' 
        ' CategoriesForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
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
End Class
