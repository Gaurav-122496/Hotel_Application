<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(GuestControl))
        Panel2 = New Panel()
        Label1 = New Label()
        dgvGuest = New DataGridView()
        Panel2.SuspendLayout()
        CType(dgvGuest, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(dgvGuest)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(945, 566)
        Panel2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(805, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 15)
        Label1.TabIndex = 2
        Label1.Text = "         Dashboard >Guests"
        ' 
        ' dgvGuest
        ' 
        dgvGuest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvGuest.BackgroundColor = Color.White
        dgvGuest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGuest.Dock = DockStyle.Bottom
        dgvGuest.Location = New Point(0, 42)
        dgvGuest.Name = "dgvGuest"
        dgvGuest.RowTemplate.Height = 25
        dgvGuest.Size = New Size(945, 524)
        dgvGuest.TabIndex = 0
        ' 
        ' GuestControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel2)
        Name = "GuestControl"
        Size = New Size(945, 566)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvGuest, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvGuest As DataGridView
    Friend WithEvents Label1 As Label
End Class
