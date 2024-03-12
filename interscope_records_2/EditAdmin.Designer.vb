<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        btn_edit = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txt_fname = New TextBox()
        txt_username = New TextBox()
        txt_password = New TextBox()
        txt_confirmpassword = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.interscope_logo
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(218, 269)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(300, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 29)
        Label1.TabIndex = 1
        Label1.Text = "Edit Admin"
        ' 
        ' btn_edit
        ' 
        btn_edit.Location = New Point(641, 297)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(75, 23)
        btn_edit.TabIndex = 2
        btn_edit.Text = "Edit"
        btn_edit.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(334, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 3
        Label2.Text = "Full Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(334, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 4
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(334, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 15)
        Label4.TabIndex = 5
        Label4.Text = "New Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(334, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 15)
        Label5.TabIndex = 6
        Label5.Text = "Confirm New Password"
        ' 
        ' txt_fname
        ' 
        txt_fname.Location = New Point(499, 80)
        txt_fname.Name = "txt_fname"
        txt_fname.Size = New Size(217, 23)
        txt_fname.TabIndex = 7
        ' 
        ' txt_username
        ' 
        txt_username.Location = New Point(499, 118)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(217, 23)
        txt_username.TabIndex = 8
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(499, 151)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(217, 23)
        txt_password.TabIndex = 9
        ' 
        ' txt_confirmpassword
        ' 
        txt_confirmpassword.Location = New Point(499, 188)
        txt_confirmpassword.Name = "txt_confirmpassword"
        txt_confirmpassword.Size = New Size(217, 23)
        txt_confirmpassword.TabIndex = 10
        ' 
        ' EditAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txt_confirmpassword)
        Controls.Add(txt_password)
        Controls.Add(txt_username)
        Controls.Add(txt_fname)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btn_edit)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "EditAdmin"
        Text = "Edit Admin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_edit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_confirmpassword As TextBox
End Class
