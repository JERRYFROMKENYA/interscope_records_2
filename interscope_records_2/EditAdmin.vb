Public Class EditAdmin
    Dim new_username As String
    Dim new_password As String
    Dim new_fullname As String
    Dim userDao As New UserDAO()
    Dim init_username As String

    Public Sub New(username As String)
        InitializeComponent()

        ' Assign the passed username to the init_username field
        init_username = username
    End Sub

    Private Sub EditAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fetch user details for the logged-in user
        Dim userDetails As Admin = userDao.GetUserDetailsByUsername(init_username)

        ' Populate the text boxes with user details
        If userDetails IsNot Nothing Then
            txt_username.Text = userDetails.username
            txt_fname.Text = userDetails.fullname
        Else
            MessageBox.Show("Error fetching user details")
            Me.Close() ' Close the form if user details cannot be fetched
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        ' Validate that the text boxes are not empty before proceeding
        If Not String.IsNullOrWhiteSpace(txt_fname.Text) Then
            new_fullname = txt_fname.Text


        End If

        If Not String.IsNullOrWhiteSpace(txt_username.Text) Then
            new_username = txt_username.Text

        End If

        If Not String.IsNullOrWhiteSpace(txt_password.Text) Then
            ' Now check for practicality
            If txt_password.Text <> txt_confirmpassword.Text Then
                MessageBox.Show("Check if passwords match")
                Return
            ElseIf txt_password.Text.Length < 8 Then
                MessageBox.Show("Weak password")
            Else
                new_password = txt_password.Text
                ' Check if the new username is unique
            End If
        End If
        If init_username <> new_username Then
            If userDao.ValidateUsername(new_username) Then
                MessageBox.Show("Your Username needs to be unique")


            End If
        End If


        ' Perform the update
        If userDao.UpdateUser(init_username, new_password, new_fullname, new_username) Then
            MessageBox.Show("User details updated successfully")
            Me.Close() ' Close the form after successful update
        Else
            MessageBox.Show("Error updating user details")
        End If


    End Sub
End Class
