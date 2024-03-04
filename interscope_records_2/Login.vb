Imports System.Runtime.CompilerServices
Imports System.Runtime.Intrinsics.Arm
Imports System.Security.Cryptography
Imports System.Text

Public Class Login
    Dim username As String
    Dim password As String

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        username = txtusername.Text

        password = txtpassword.Text

        Dim userDao As New UserDAO()

        If userDao.ValidateUser(username, password) Then
            MessageBox.Show("Login successful!")
            Me.Hide()
            Form1.Show()
            ' Redirect or perform other actions after successful login
        Else
            MessageBox.Show("Invalid username or password.")
        End If

    End Sub



    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If Me.Visible Then
            Me.Hide()
            RegisterAdmin.Show()
        Else

        End If
    End Sub
End Class

