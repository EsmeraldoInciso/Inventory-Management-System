
Imports System.Security.Cryptography
Imports System.Text

Module MyFunctionsModule
    Public Function HashPassword(input As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Dim sb As New StringBuilder()
            For Each b As Byte In hashBytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function
End Module
