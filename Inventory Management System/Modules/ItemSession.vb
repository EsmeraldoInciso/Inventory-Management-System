Module ItemSession
    Public ItemID As Integer
    Public ItemName As String
    Public ItemCode As String
    Public ItemUnit As String


    Public Sub ClearItemSession()
        ItemID = 0
        ItemName = ""
        ItemCode = ""
        ItemUnit = ""
    End Sub
End Module
