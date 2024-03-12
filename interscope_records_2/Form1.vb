Public Class Form1
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Access the logged-in username from UserSession singleton
        Dim loggedInUsername As String = UserSession.Instance.LoggedInUsername
        ' Do something with the username, e.g., display a welcome message
        lblWelcome.Text = $"Welcome, {loggedInUsername}!"

        lbladmin.Text = New AdminDAO().GetAdminCount

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Hide()
        Admins.Show()


    End Sub
End Class