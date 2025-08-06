

Public Module UserSession
    Public UserID As Integer
    Public UserFirstname As String
    Public UserLastname As String
    Public UserType As Integer
    Public UserStatus As Integer


    Public Sub ClearUserSession()
        UserID = 0
        UserFirstname = ""
        UserLastname = ""
        UserType = 2
        UserStatus = 0
    End Sub
End Module
