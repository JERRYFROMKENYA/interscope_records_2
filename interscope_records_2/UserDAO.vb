Imports MySqlConnector
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class UserDAO
    Dim connectionString As String = "Server=127.0.0.1;Database=label;User=root;Password=;Port=3306;"
    Dim securityLogPath As String = "security_log.csv"

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
    Public Function RegisterUser(username As String, password As String) As Boolean
        Dim hashedPassword As String = HashPassword(password)
        Dim query As String = "INSERT INTO tbl_admin (username, password) VALUES (@Username, @Password)"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", hashedPassword)

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

End Class

