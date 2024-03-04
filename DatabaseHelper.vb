Imports MySql.Data.MySqlClient

Public Class DatabaseHelper
    Public Shared Function GetConnectionString() As String
        ' Replace these values with your MariaDB server information
        Dim server As String = "127.0.0.1:3306"
        Dim database As String = "records"
        Dim username As String = "root"
        Dim password As String = ""

        ' Construct the connection string
        Dim connectionString As String = $"Server={server};Database={database};User Id={username};Password={password};"

        Return connectionString
    End Function
End Class

