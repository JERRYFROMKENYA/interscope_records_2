<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admins
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
        Button1 = New Button()
        lbladmin = New Label()
        AdminGrid = New DataGridView()
        StatusStrip1 = New StatusStrip()
        lbl_refresh = New ToolStripStatusLabel()
        CType(AdminGrid, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(713, 14)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 45)
        Button1.TabIndex = 0
        Button1.Text = "ADD ADMIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lbladmin
        ' 
        lbladmin.AutoSize = True
        lbladmin.Font = New Font("Bahnschrift", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbladmin.Location = New Point(12, 14)
        lbladmin.Name = "lbladmin"
        lbladmin.Size = New Size(131, 39)
        lbladmin.TabIndex = 3
        lbladmin.Text = "< Admin"
        ' 
        ' AdminGrid
        ' 
        AdminGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        AdminGrid.BackgroundColor = SystemColors.ControlLightLight
        AdminGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AdminGrid.GridColor = SystemColors.Window
        AdminGrid.Location = New Point(0, 65)
        AdminGrid.Name = "AdminGrid"
        AdminGrid.Size = New Size(800, 385)
        AdminGrid.TabIndex = 4
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {lbl_refresh})
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 5
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lbl_refresh
        ' 
        lbl_refresh.Image = My.Resources.Resources.interscope_logo
        lbl_refresh.Name = "lbl_refresh"
        lbl_refresh.Size = New Size(62, 17)
        lbl_refresh.Text = "Refresh"
        ' 
        ' Admins
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 450)
        Controls.Add(StatusStrip1)
        Controls.Add(AdminGrid)
        Controls.Add(lbladmin)
        Controls.Add(Button1)
        Name = "Admins"
        Text = "Admins"
        CType(AdminGrid, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lbladmin As Label
    Friend WithEvents AdminGrid As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lbl_refresh As ToolStripStatusLabel
End Class
