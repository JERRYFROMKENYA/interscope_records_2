<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtusername = New TextBox()
        txtpassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        btnlogin = New Button()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(358, 82)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(161, 23)
        txtusername.TabIndex = 0
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(358, 126)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(161, 23)
        txtpassword.TabIndex = 1
        txtpassword.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(266, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(266, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("Bahnschrift", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(236, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 39)
        Label3.TabIndex = 4
        Label3.Text = "Login"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.interscope_logo
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(218, 271)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = SystemColors.AppWorkspace
        btnlogin.FlatAppearance.BorderColor = Color.Yellow
        btnlogin.FlatAppearance.BorderSize = 0
        btnlogin.FlatStyle = FlatStyle.Flat
        btnlogin.ForeColor = SystemColors.ControlLightLight
        btnlogin.Location = New Point(444, 172)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(75, 23)
        btnlogin.TabIndex = 6
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Highlight
        Label4.Location = New Point(266, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 15)
        Label4.TabIndex = 7
        Label4.Text = "create a new admin"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(btnlogin)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtpassword)
        Controls.Add(txtusername)
        Name = "Login"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents Label4 As Label

End Class
