Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class StockInForm

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub StockInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearField()
        txtID.Text = ItemSession.ItemID
        txtItemCode.Text = ItemSession.ItemCode
        txtItemName.Text = ItemSession.ItemName
    End Sub

    Private Sub LoadAllStockIn()
        Dim query As String =
            "SELECT 
                created_at AS Date, 
                quantity AS Quantity,
                reference_no as 'Reference No.',
                remarks as Remarks
            FROM stock_movements
            ORDER BY created_at DESC"
        LoadDataToGrid(query, dgStockIn)

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
                ClearField()
                Dim toast As New ToastForm("Stock-in record inserted successfully!")
                toast.Show()
                ItemListForm.LoadAllItems("")
            Else
                Dim toast As New ToastForm("Insert failed.")
                toast.Show()
            End If
        Else
            Dim toast As New ToastForm("Quantity is required!.")
            toast.Show()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearField()
    End Sub

    Private Function IsFormReady() As Boolean
        If Trim(txtQuantity.Text) <> "" And Trim(txtReferenceNo.Text) <> "" And Trim(txtRemarks.Text) <> "" Then
            Return True
        End If

        Return False
    End Function
End Class