Imports MySql.Data.MySqlClient
Imports System.Data

Module MySQLCRUDModule
    ' --- Ensure this is declared once ---
    Private ReadOnly connStr As String = "Server=localhost;Database=inventory_management_system;User Id=root;Password=;SslMode=none;"
    Private ReadOnly conn As New MySqlConnection(connStr)

    ' --- Open Connection ---
    Public Function OpenConn() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Return True
        Catch ex As MySqlException
            MessageBox.Show("Connection Error: " & ex.Message)
            Return False
        End Try
    End Function

    ' --- Close Connection ---
    Public Sub CloseConn()
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    ' --- LOGIN ---
    Public Function LoginUser(username As String, password As String) As Boolean
        Dim query As String = "SELECT * FROM users WHERE username = @username AND password = @password"
        Dim parameters As New Dictionary(Of String, Object) From {
        {"@username", username},
        {"@password", password}
    }

        Dim result As DataTable = Read(query, parameters)

        If result.Rows.Count > 0 Then
            Dim row = result.Rows(0)

            ' ✅ Store in global session
            UserSession.UserID = Convert.ToInt32(row("user_id"))
            UserSession.UserFirstname = row("user_firstname").ToString()
            UserSession.UserLastname = row("user_lastname").ToString()
            UserSession.UserType = Convert.ToInt32(row("user_type"))
            UserSession.UserStatus = Convert.ToInt32(row("status"))
            If Convert.ToInt32(row("status")) = 0 Then Return False
            Return True
        End If

        Return False
    End Function

    ' --- LOAD TO DATAGRIDVIEW ---
    Public Sub LoadDataToGrid(query As String, dgv As DataGridView, Optional parameters As Dictionary(Of String, Object) = Nothing)
        Try
            If OpenConn() Then
                Using cmd As New MySqlCommand(query, conn)
                    If parameters IsNot Nothing Then
                        For Each param In parameters
                            cmd.Parameters.AddWithValue(param.Key, param.Value)
                        Next
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgv.DataSource = dt
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("❌ Error loading data to grid: " & ex.Message)
        Finally
            CloseConn()
        End Try
    End Sub


    ' --- CREATE (INSERT) ---
    Public Function Insert(query As String, parameters As Dictionary(Of String, Object)) As Boolean
        Try
            If Not OpenConn() Then Return False
            Using cmd As New MySqlCommand(query, conn)
                For Each param In parameters
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Insert Error: " & ex.Message)
            Return False
        Finally
            CloseConn()
        End Try
    End Function

    ' --- READ (SELECT) ---
    Public Function Read(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As DataTable
        Dim dt As New DataTable()
        Try
            If Not OpenConn() Then Return dt
            Using cmd As New MySqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Read Error: " & ex.Message)
        Finally
            CloseConn()
        End Try
        Return dt
    End Function

    ' --- UPDATE ---
    Public Function Update(query As String, parameters As Dictionary(Of String, Object)) As Boolean
        Try
            If Not OpenConn() Then Return False
            Using cmd As New MySqlCommand(query, conn)
                For Each param In parameters
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Update Error: " & ex.Message)
            Return False
        Finally
            CloseConn()
        End Try
    End Function

    ' --- DELETE ---
    Public Function Delete(query As String, parameters As Dictionary(Of String, Object)) As Boolean
        Try
            If Not OpenConn() Then Return False
            Using cmd As New MySqlCommand(query, conn)
                For Each param In parameters
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Delete Error: " & ex.Message)
            Return False
        Finally
            CloseConn()
        End Try
    End Function
End Module
