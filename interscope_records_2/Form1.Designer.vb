<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        ContactToolStripMenuItem = New ToolStripMenuItem()
        miniToolStrip = New StatusStrip()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        lblWelcome = New ToolStripStatusLabel()
        home = New GroupBox()
        btnAlbum = New Button()
        btnArtist = New Button()
        btnOrder = New Button()
        btnAdmin = New Button()
        lbldash = New Label()
        GroupBox4 = New GroupBox()
        lblorders = New Label()
        GBAlbums = New GroupBox()
        lblalbums = New Label()
        GroupBox2 = New GroupBox()
        lblartists = New Label()
        GroupBox1 = New GroupBox()
        lbladmin = New Label()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        home.SuspendLayout()
        GroupBox4.SuspendLayout()
        GBAlbums.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlLightLight
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, EditToolStripMenuItem, HelpToolStripMenuItem, ContactToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(37, 20)
        ToolStripMenuItem1.Text = "File"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' ContactToolStripMenuItem
        ' 
        ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        ContactToolStripMenuItem.Size = New Size(61, 20)
        ContactToolStripMenuItem.Text = "Contact"
        ' 
        ' miniToolStrip
        ' 
        miniToolStrip.AccessibleName = "New item selection"
        miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown
        miniToolStrip.AutoSize = False
        miniToolStrip.Dock = DockStyle.None
        miniToolStrip.Location = New Point(71, 1)
        miniToolStrip.Name = "miniToolStrip"
        miniToolStrip.Size = New Size(763, 22)
        miniToolStrip.TabIndex = 0
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, lblWelcome})
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(0, 17)
        ' 
        ' lblWelcome
        ' 
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(70, 17)
        lblWelcome.Text = "lblWelcome"
        ' 
        ' home
        ' 
        home.Controls.Add(btnAlbum)
        home.Controls.Add(btnArtist)
        home.Controls.Add(btnOrder)
        home.Controls.Add(btnAdmin)
        home.Controls.Add(lbldash)
        home.Controls.Add(GroupBox4)
        home.Controls.Add(GBAlbums)
        home.Controls.Add(GroupBox2)
        home.Controls.Add(GroupBox1)
        home.Dock = DockStyle.Fill
        home.Location = New Point(0, 24)
        home.Name = "home"
        home.Size = New Size(800, 404)
        home.TabIndex = 3
        home.TabStop = False
        ' 
        ' btnAlbum
        ' 
        btnAlbum.Location = New Point(87, 152)
        btnAlbum.Name = "btnAlbum"
        btnAlbum.Size = New Size(75, 23)
        btnAlbum.TabIndex = 9
        btnAlbum.Text = "Album"
        btnAlbum.UseVisualStyleBackColor = True
        ' 
        ' btnArtist
        ' 
        btnArtist.Location = New Point(87, 108)
        btnArtist.Name = "btnArtist"
        btnArtist.Size = New Size(75, 23)
        btnArtist.TabIndex = 8
        btnArtist.Text = "Artists"
        btnArtist.UseVisualStyleBackColor = True
        ' 
        ' btnOrder
        ' 
        btnOrder.Location = New Point(6, 152)
        btnOrder.Name = "btnOrder"
        btnOrder.Size = New Size(75, 23)
        btnOrder.TabIndex = 7
        btnOrder.Text = "Orders"
        btnOrder.UseVisualStyleBackColor = True
        ' 
        ' btnAdmin
        ' 
        btnAdmin.Location = New Point(6, 108)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(75, 23)
        btnAdmin.TabIndex = 5
        btnAdmin.Text = "Admin"
        btnAdmin.UseVisualStyleBackColor = True
        ' 
        ' lbldash
        ' 
        lbldash.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbldash.AutoSize = True
        lbldash.Font = New Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbldash.Location = New Point(0, 19)
        lbldash.Name = "lbldash"
        lbldash.Size = New Size(200, 45)
        lbldash.TabIndex = 4
        lbldash.Text = "Dashboard"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(lblorders)
        GroupBox4.Location = New Point(440, 236)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(200, 100)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Orders"
        ' 
        ' lblorders
        ' 
        lblorders.AutoSize = True
        lblorders.Location = New Point(72, 44)
        lblorders.Name = "lblorders"
        lblorders.Size = New Size(41, 15)
        lblorders.TabIndex = 0
        lblorders.Text = "Label3"
        ' 
        ' GBAlbums
        ' 
        GBAlbums.Controls.Add(lblalbums)
        GBAlbums.Location = New Point(210, 236)
        GBAlbums.Name = "GBAlbums"
        GBAlbums.Size = New Size(200, 100)
        GBAlbums.TabIndex = 2
        GBAlbums.TabStop = False
        GBAlbums.Text = "Albums"
        ' 
        ' lblalbums
        ' 
        lblalbums.AutoSize = True
        lblalbums.Location = New Point(69, 44)
        lblalbums.Name = "lblalbums"
        lblalbums.Size = New Size(41, 15)
        lblalbums.TabIndex = 0
        lblalbums.Text = "Label4"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lblartists)
        GroupBox2.Location = New Point(440, 108)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 100)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Artists"
        ' 
        ' lblartists
        ' 
        lblartists.AutoSize = True
        lblartists.Location = New Point(72, 50)
        lblartists.Name = "lblartists"
        lblartists.Size = New Size(41, 15)
        lblartists.TabIndex = 0
        lblartists.Text = "Label2"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lbladmin)
        GroupBox1.Location = New Point(210, 108)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 100)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Admin"
        ' 
        ' lbladmin
        ' 
        lbladmin.AutoSize = True
        lbladmin.Font = New Font("Bahnschrift", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbladmin.Location = New Point(75, 30)
        lbladmin.Name = "lbladmin"
        lbladmin.Size = New Size(35, 39)
        lbladmin.TabIndex = 0
        lbladmin.Text = "0"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 450)
        Controls.Add(home)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Interscope Records"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        home.ResumeLayout(False)
        home.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GBAlbums.ResumeLayout(False)
        GBAlbums.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents miniToolStrip As StatusStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblWelcome As ToolStripStatusLabel
    Friend WithEvents home As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GBAlbums As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbldash As Label
    Friend WithEvents lblorders As Label
    Friend WithEvents lblalbums As Label
    Friend WithEvents lblartists As Label
    Friend WithEvents lbladmin As Label
    Friend WithEvents btnArtist As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnAlbum As Button
End Class
