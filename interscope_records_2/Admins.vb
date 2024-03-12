Public Class Admins
    Dim adminDao As New AdminDAO()

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView when the form loads
        LoadAdminData()

        ' Customize DataGridView appearance
        CustomizeDataGridView()


    End Sub

    Private Sub LoadAdminData()
        ' Retrieve all admins from the database
        Dim admins As List(Of Admin) = adminDao.GetAllAdmins()

        ' Bind the data to the DataGridView
        AdminGrid.DataSource = admins
    End Sub

    Private Sub CustomizeDataGridView()
        ' Add Edit button column
        Dim editButtonColumn As New DataGridViewButtonColumn()
        editButtonColumn.HeaderText = "Edit"
        editButtonColumn.Text = "Edit"
        editButtonColumn.UseColumnTextForButtonValue = True
        AdminGrid.Columns.Add(editButtonColumn)

        ' Add Delete button column
        Dim deleteButtonColumn As New DataGridViewButtonColumn()
        deleteButtonColumn.HeaderText = "Delete"
        deleteButtonColumn.Text = "Delete"
        deleteButtonColumn.UseColumnTextForButtonValue = True
        AdminGrid.Columns.Add(deleteButtonColumn)


        ' Customize DataGridView appearance
        With AdminGrid
            ' Adjust column widths
            .Columns("username").Width = 300
            .Columns("fullname").Width = 300

            ' Center-align text in all cells
            For Each column As DataGridViewColumn In .Columns
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next

            ' Set visual styles
            .DefaultCellStyle.BackColor = Color.White
            .BackgroundColor = Color.LightGray
            .DefaultCellStyle.SelectionBackColor = Color.DodgerBlue
            .DefaultCellStyle.SelectionForeColor = Color.White
        End With


        ' Change column names
        AdminGrid.Columns("username").HeaderText = "Username"
        AdminGrid.Columns("fullname").HeaderText = "Full Name"
    End Sub

    Private Sub AdminGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AdminGrid.CellContentClick
        ' Handle button clicks
        If e.RowIndex >= 0 Then
            Dim rowIndex As Integer = e.RowIndex
            Dim columnIndex As Integer = e.ColumnIndex

            If columnIndex = AdminGrid.Columns.Count - 2 Then
                ' Edit button clicked
                Dim username As String = AdminGrid.Rows(rowIndex).Cells("Username").Value.ToString()
                ' Implement your edit logic here, e.g., open an edit form
                '    MessageBox.Show($"Edit button clicked for username: {username}")
                Dim editAdminForm As New EditAdmin(username)
                editAdminForm.Show()

            ElseIf columnIndex = AdminGrid.Columns.Count - 1 Then
                ' Delete button clicked
                Dim username As String = AdminGrid.Rows(rowIndex).Cells("Username").Value.ToString()
                ' Implement your delete logic here, e.g., show a confirmation dialog and delete the record
                ' Show a confirmation dialog before deleting
                Dim result As Boolean = MessageBox.Show($"Are you sure you want to delete the admin with username: {username}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = True Then
                    If adminDao.DeleteAdmin(username) = True Then
                        MessageBox.Show($"{username} deleted Successfully", "Admin Deleted")
                    Else
                        MessageBox.Show($"{username} deletion has failed", "Admin Deleted")
                    End If

                End If

            End If
            End If
    End Sub

    Private Sub lbladmin_Click(sender As Object, e As EventArgs) Handles lbladmin.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RegisterAdmin.Show()
    End Sub

    Private Sub lblrferesh_Click(sender As Object, e As EventArgs) Handles lbl_refresh.Click
        LoadAdminData()

    End Sub
End Class

