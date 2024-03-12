<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterAdmin
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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtuname = New TextBox()
        txtpw = New TextBox()
        txtxpw = New TextBox()
        Button1 = New Button()
        Label5 = New Label()
        txtname = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(216, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 50)
        Label1.TabIndex = 0
        Label1.Text = "Register"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.interscope_logo
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(194, 285)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(276, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 2
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(276, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(276, 205)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 15)
        Label4.TabIndex = 4
        Label4.Text = "Confirm Password"
        ' 
        ' txtuname
        ' 
        txtuname.Location = New Point(392, 123)
        txtuname.Name = "txtuname"
        txtuname.Size = New Size(230, 23)
        txtuname.TabIndex = 5
        ' 
        ' txtpw
        ' 
        txtpw.Location = New Point(392, 156)
        txtpw.Name = "txtpw"
        txtpw.Size = New Size(230, 23)
        txtpw.TabIndex = 6
        txtpw.UseSystemPasswordChar = True
        ' 
        ' txtxpw
        ' 
        txtxpw.Location = New Point(392, 197)
        txtxpw.Name = "txtxpw"
        txtxpw.Size = New Size(230, 23)
        txtxpw.TabIndex = 7
        txtxpw.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(505, 274)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(276, 81)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 15)
        Label5.TabIndex = 9
        Label5.Text = "Full Name"
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(392, 81)
        txtname.Name = "txtname"
        txtname.Size = New Size(230, 23)
        txtname.TabIndex = 10
        ' 
        ' RegisterAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 450)
        Controls.Add(txtname)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(txtxpw)
        Controls.Add(txtpw)
        Controls.Add(txtuname)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "RegisterAdmin"
        Text = "Register Admin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtuname As TextBox
    Friend WithEvents txtpw As TextBox
    Friend WithEvents txtxpw As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtname As TextBox
End Class
