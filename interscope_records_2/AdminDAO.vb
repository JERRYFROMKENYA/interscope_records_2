Imports MySqlConnector
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class AdminDAO
    Dim connectionString As String = "Server=127.0.0.1;Database=label;User=root;Password=;Port=3306;"

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

    ' Create Admin
    Public Function CreateAdmin(username As String, password As String, fName As String) As Boolean
        Dim hashedPassword As String = HashPassword(password)
        Dim query As String = "INSERT INTO tbl_admin (username, password, fullname) VALUES (@Username, @Password, @Fname)"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", hashedPassword)
                command.Parameters.AddWithValue("@Fname", fName)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Check if the insertion was successful
                    Return rowsAffected > 0
                Catch ex As Exception
                    ' Log the exception
                    Console.WriteLine($"Error creating admin: {ex.Message}")
                    Return False
                End Try
            End Using
        End Using
    End Function

    ' Read Admin
    Public Function GetAdminByUsername(username As String) As Admin
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
                        admin.username = reader.GetString("username")
                        admin.fullname = reader.GetString("fullname")
                        ' You may want to retrieve other admin properties here
                        Return admin
                    Else
                        ' Admin not found
                        Return Nothing
                    End If
                Catch ex As Exception
                    ' Log the exception
                    Console.WriteLine($"Error reading admin: {ex.Message}")
                    Return Nothing
                End Try
            End Using
        End Using
    End Function

    ' Update Admin
    Public Function UpdateAdminPassword(username As String, newPassword As String) As Boolean
        Dim hashedPassword As String = HashPassword(newPassword)
        Dim query As String = "UPDATE tbl_admin SET password = @Password WHERE username = @Username"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Password", hashedPassword)
                command.Parameters.AddWithValue("@Username", username)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Check if the update was successful
                    Return rowsAffected > 0
                Catch ex As Exception
                    ' Log the exception
                    Console.WriteLine($"Error updating admin: {ex.Message}")
                    Return False
                End Try
            End Using
        End Using
    End Function

    ' Delete Admin
    Public Function DeleteAdmin(username As String) As Boolean
        Dim query As String = "DELETE FROM tbl_admin WHERE username = @Username"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Check if the deletion was successful
                    Return rowsAffected > 0
                Catch ex As Exception
                    ' Log the exception
                    Console.WriteLine($"Error deleting admin: {ex.Message}")
                    Return False
                End Try
            End Using
        End Using
    End Function

    ' Get All Admins
    Public Function GetAllAdmins() As List(Of Admin)
        Dim query As String = "SELECT * FROM tbl_admin"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Dim admins As New List(Of Admin)()

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    While reader.Read()
                        Dim admin As New Admin()
                        admin.username = If(Not IsDBNull(reader("username")), reader("username").ToString(), "")
                        admin.fullname = If(Not IsDBNull(reader("fullname")), reader("fullname").ToString(), "")
                        ' You may want to retrieve other admin properties here
                        admins.Add(admin)
                    End While

                    Return admins
                Catch ex As Exception
                    ' Log the exception
                    Console.WriteLine($"Error reading admins: {ex.Message}")
                    Return New List(Of Admin)()
                End Try
            End Using
        End Using
    End Function

    'Count
    Public Function GetAdminCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM tbl_admin"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim count As Integer = CInt(command.ExecuteScalar())
                    Return count
                Catch ex As Exception
                    ' Log the exception
                    Console.WriteLine($"Error getting admin count: {ex.Message}")
                    Return -1 ' Return -1 to indicate an error
                End Try
            End Using
        End Using
    End Function


End Class

Public Class Admin
    Public Property username As String
    Public Property fullname As String
    ' You can add other properties of the Admin entity here
End Class
