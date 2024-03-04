Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class RegisterAdmin

    Dim uname As String
    Dim password As String
    Dim cpassword As String
    Dim userDao As New UserDAO()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        uname = txtuname.Text
        password = txtpw.Text
        cpassword = txtxpw.Text

        If password <> cpassword Then
            MessageBox.Show("Check if passwords match")
            Return
        ElseIf password.Count < 8 Then
            MessageBox.Show("Weak password")
        Else
            If userDao.RegisterUser(uname, password) Then
                MessageBox.Show("Registration successful!")
                ' Additional actions after successful registration
                Me.Hide()
                Form1.Show()
            Else
                MessageBox.Show("Registration failed. Please try again.")
            End If



        End If




    End Sub

    Private Sub txtpw_TextChanged(sender As Object, e As EventArgs) Handles txtpw.TextChanged

    End Sub
End Class