
Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class StockInForm
    Dim movementID As Integer
    Dim dgvToolTip As New ToolTip()
    Private _itemList As ItemListForm

    Public Sub New(itemList As ItemListForm)
        InitializeComponent()
        _itemList = itemList
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ItemSession.ClearItemSession()
        Me.Close()
    End Sub

    Private Sub StockInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearField()
        txtID.Text = ItemSession.ItemID
        txtItemCode.Text = ItemSession.ItemCode
        txtItemName.Text = ItemSession.ItemName


        dgvToolTip.AutoPopDelay = 5000
        dgvToolTip.InitialDelay = 500
        dgvToolTip.ReshowDelay = 100
        dgvToolTip.ShowAlways = True

        AddHandler dgStockIn.MouseMove, AddressOf ShowGridToolTip
    End Sub

    Private Sub ShowGridToolTip(sender As Object, e As MouseEventArgs)
        dgvToolTip.SetToolTip(dgStockIn, "Double Tap To Select Data.")
    End Sub

    Private Sub LoadAllStockIn()
        Dim query As String =
            "SELECT 
                movement_id,
                created_at AS Date, 
                quantity AS Quantity,
                reference_no as 'Reference No.',
                remarks as Remarks
            FROM stock_movements
            WHERE movement_type = 'IN' AND item_id = " & ItemSession.ItemID & " AND created_by = " & UserSession.UserID & "
            ORDER BY created_at DESC
            LIMIT 50"
        LoadDataToGrid(query, dgStockIn)
        dgStockIn.Columns("movement_id").Visible = False
    End Sub

    Private Sub ClearField()
        LoadAllStockIn()
        txtQuantity.Clear()
        txtReferenceNo.Clear()
        txtRemarks.Clear()
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If IsFormReady() Then
            If ConfirmDialog($"Confirm stock-in?") Then
                Dim sql As String = "INSERT INTO stock_movements (item_id, movement_type, quantity, reference_no, remarks, created_by) " &
                    "VALUES (@item_id, @movement_type, @quantity, @reference_no, @remarks, @created_by)"
                Dim parameters As New Dictionary(Of String, Object) From {
                    {"@item_id", Trim(txtID.Text)},
                    {"@movement_type", "IN"},
                    {"@quantity", Trim(txtQuantity.Text)},
                    {"@reference_no", Trim(txtReferenceNo.Text)},
                    {"@remarks", Trim(txtRemarks.Text)},
                    {"@created_by", UserSession.UserID}
                }
                If InsertDatabase(sql, parameters) Then
                    LogAction(UserSession.UserID, "STOCK-IN", $"Added {txtQuantity.Text} {ItemSession.ItemUnit} of {txtItemName.Text}", "stock_movements")
                    ClearField()
                    Dim toast As New ToastForm("Stock-in record inserted successfully!")
                    toast.Show()
                    _itemList.LoadAllItems("")

                Else
                    Dim toast As New ToastForm("Insert failed.")
                    toast.Show()
                End If
            End If
        Else
            Dim toast As New ToastForm("All Fields are required!.")
            toast.Show()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim loginForm As New ValidationForm()

        If loginForm.ShowDialog() = DialogResult.OK AndAlso loginForm.IsLoginSuccessful Then
            If IsFormReady() Then
                If ConfirmDialog($"Confirm update stock-in?") Then
                    Dim sql As String = "UPDATE stock_movements SET " &
                    "quantity = @quantity, " &
                    "reference_no = @reference_no, " &
                    "remarks = @remarks " &
                    "WHERE movement_id = @movement_id"

                    Dim parameters As New Dictionary(Of String, Object) From {
                        {"@quantity", Trim(txtQuantity.Text)},
                        {"@reference_no", Trim(txtReferenceNo.Text)},
                        {"@remarks", Trim(txtRemarks.Text)},
                        {"@movement_id", CInt(movementID)}
                    }

                    If UpdateDatabase(sql, parameters) Then
                        LogAction(UserSession.UserID, "STOCK-IN", $"Updated entry id: {movementID}", "stock_movements")
                        ClearField()
                        Dim toast As New ToastForm("Stock-in updated successfully!")
                        toast.Show()
                        _itemList.LoadAllItems("")
                    Else
                        Dim toast As New ToastForm("Update failed.")
                        toast.Show()
                    End If
                End If
            Else
                Dim toast As New ToastForm("All Fields are required!.")
                toast.Show()
            End If
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearField()
    End Sub

    Private Sub dgStockIn_SelectionChanged(sender As Object, e As EventArgs) Handles dgStockIn.CellDoubleClick
        If dgStockIn.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgStockIn.SelectedRows(0)

            ' Populate textboxes
            movementID = row.Cells("movement_id").Value.ToString()
            txtQuantity.Text = row.Cells("Quantity").Value.ToString()
            txtReferenceNo.Text = row.Cells("Reference No.").Value.ToString()
            txtRemarks.Text = row.Cells("Remarks").Value.ToString()

            btnAdd.Enabled = False
            btnUpdate.Enabled = True
        End If
    End Sub

    Private Function IsFormReady() As Boolean
        If Trim(txtQuantity.Text) <> "" And Trim(txtReferenceNo.Text) <> "" And Trim(txtRemarks.Text) <> "" Then
            Return True
        End If

        Return False
    End Function
End Class