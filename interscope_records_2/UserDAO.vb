Imports MySqlConnector
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class UserDAO
    Dim connectionString As String = "Server=127.0.0.1;Database=label;User=root;Password=;Port=3306;"
    Dim securityLogPath As String = "security_log.csv"
    'C:\Users\Jerry\source\repos\interscope_records_2\interscope_records_2\bin\Debug\net8.0-windows\security_log.csv
    Public Function GetUserDetailsByUsername(username As String) As Admin
        Dim query As String = "SELECT * FROM tbl_admin WHERE username = @Username"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    If reader.Read() Then
                        ' Create Admin object from the data
                        Dim admin As New Admin()
                        admin.username = If(Not IsDBNull(reader("username")), reader("username").ToString(), "")
                        admin.fullname = If(Not IsDBNull(reader("fullname")), reader("fullname").ToString(), "")
                        ' You may want to retrieve other admin properties here
                        Return admin
                    Else
                        ' Admin not found
                        Return Nothing
                    End If
                Catch ex As Exception
                    ' Log the exception
                    Console.WriteLine($"Error reading user details: {ex.Message}")
                    Return Nothing
                End Try
            End Using
        End Using
    End Function
    Private Sub LogAdminCreation(username As String)
        Try
            Dim fullPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, securityLogPath)
            Console.WriteLine($"Writing to security log: {fullPath}")
            Using writer As New StreamWriter(fullPath, True)
                Dim logEntry As String = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")},Admin Created,{username}"
                writer.WriteLine(logEntry)
            End Using
        Catch ex As Exception
            ' Log the exception
            Console.WriteLine($"Error writing to security log: {ex.Message}")
        End Try
    End Sub
    Private Sub LogUserLogin(username As String)
        Try
            Dim fullPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, securityLogPath)
            Console.WriteLine($"Writing to security log: {fullPath}")
            Using writer As New StreamWriter(fullPath, True)
                Dim logEntry As String = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")},User Login,{username}"
                writer.WriteLine(logEntry)
            End Using
        Catch ex As Exception
            ' Log the exception
            Console.WriteLine($"Error writing to security log: {ex.Message}")
        End Try
    End Sub
    ' Hashes the input password using SHA256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()

            For i As Integer = 0 To hashedBytes.Length - 1
                builder.Append(hashedBytes(i).ToString("x2"))
            Next

            Return builder.ToString()
        End Using
    End Function

    'Login Admin
    Public Function ValidateUser(username As String, password As String) As Boolean
        Dim hashedPassword As String = HashPassword(password)
        Dim query As String = "SELECT COUNT(*) FROM tbl_admin WHERE username = @Username AND password = @Password"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", hashedPassword)

                Try
                    connection.Open()
                    Dim count As Integer = CInt(command.ExecuteScalar())

                    If count > 0 Then
                        ' Log successful login
                        LogUserLogin(username)

                        ' Store logged-in username in UserSession singleton
                        UserSession.Instance.LoggedInUsername = username

                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    ' Log the exception
                    Console.WriteLine($"Error validating user: {ex.Message}")
                    Return False
                End Try
            End Using
        End Using
    End Function

    'Register Admin
    Public Function RegisterUser(username As String, password As String, fname As String) As Boolean
        Dim hashedPassword As String = HashPassword(password)
        Dim query As String = "INSERT INTO tbl_admin (username, password, fullname) VALUES (@Username, @Password, @Fname)"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", hashedPassword)
                command.Parameters.AddWithValue("@Fname", fname)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        ' Log successful admin creation
                        LogAdminCreation(username)
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    ' Log the exception
                    Console.WriteLine($"Error registering user: {ex.Message}")
                    Return False
                End Try
            End Using
        End Using
    End Function
    'Validate Username
    Public Function ValidateUsername(username As String) As Boolean

        Dim query As String = "SELECT COUNT(*) FROM tbl_admin WHERE username = @Username"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)


                Try
                    connection.Open()
                    Dim count As Integer = CInt(command.ExecuteScalar())

                    If count > 0 Then
                        ' Log successful login
                        LogUserLogin(username)

                        ' Store logged-in username in UserSession singleton
                        UserSession.Instance.LoggedInUsername = username

                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    ' Log the exception
                    Console.WriteLine($"Error validating user: {ex.Message}")
                    Return False
                End Try
            End Using
        End Using
    End Function
    'Update User
    Public Function UpdateUser(init_username As String, Optional password As String = Nothing, Optional fullname As String = Nothing, Optional new_username As String = Nothing) As Boolean
        Dim query As String = "UPDATE tbl_admin SET "
        Dim parameters As New List(Of MySqlParameter)()

        ' Check and add password parameter
        If Not String.IsNullOrEmpty(password) Then
            query &= "password = @Password, "
            parameters.Add(New MySqlParameter("@Password", HashPassword(password)))
        End If

        ' Check and add fullname parameter
        If Not String.IsNullOrEmpty(fullname) Then
            query &= "fullname = @Fullname, "
            parameters.Add(New MySqlParameter("@Fullname", fullname))
        End If
        If Not String.IsNullOrEmpty(new_username) Then
            query &= "username = @username, "
            parameters.Add(New MySqlParameter("@username", new_username))
        End If

        ' Remove trailing comma and space
        query = query.TrimEnd(", ".ToCharArray())

        ' Add the common part of the query
        query &= " WHERE username = @vUsername"
        parameters.Add(New MySqlParameter("@vUsername", init_username))
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddRange(parameters.ToArray())

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    ' Check if the update was successful
                    Return rowsAffected > 0
                Catch ex As Exception
                    ' Log the exception
                    Console.WriteLine($"Error updating user: {ex.Message}")
                    Return False
                End Try
            End Using
        End Using
    End Function



End Class

