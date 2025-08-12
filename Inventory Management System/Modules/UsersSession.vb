

Public Module UserSession
    Public UserID As Integer
    Public UserFirstname As String
    Public UserLastname As String
    Public UserType As Integer
    Public UserStatus As Integer
    Public Username As String


    Public Sub ClearUserSession()
        UserID = 0
        UserFirstname = ""
        UserLastname = ""
        UserType = 2
        UserStatus = 0
        Username = ""
    End Sub
End Module
