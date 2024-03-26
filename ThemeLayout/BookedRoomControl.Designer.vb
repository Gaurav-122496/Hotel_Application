<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookedRoomControl
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(BookedRoomControl))
        pnlBookedRoomMid = New Panel()
        Label1 = New Label()
        dgvBookedRooms = New DataGridView()
        pnlBookedRoomMid.SuspendLayout()
        CType(dgvBookedRooms, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlBookedRoomMid
        ' 
        pnlBookedRoomMid.BackColor = Color.White
        pnlBookedRoomMid.Controls.Add(Label1)
        pnlBookedRoomMid.Controls.Add(dgvBookedRooms)
        pnlBookedRoomMid.Dock = DockStyle.Fill
        pnlBookedRoomMid.Location = New Point(0, 0)
        pnlBookedRoomMid.Name = "pnlBookedRoomMid"
        pnlBookedRoomMid.Size = New Size(951, 581)
        pnlBookedRoomMid.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(758, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 15)
        Label1.TabIndex = 1
        Label1.Text = "         Dashboard >BookedRooms"
        ' 
        ' dgvBookedRooms
        ' 
        dgvBookedRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBookedRooms.BackgroundColor = Color.White
        dgvBookedRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBookedRooms.Dock = DockStyle.Bottom
        dgvBookedRooms.GridColor = Color.White
        dgvBookedRooms.Location = New Point(0, 86)
        dgvBookedRooms.Name = "dgvBookedRooms"
        dgvBookedRooms.RowTemplate.Height = 25
        dgvBookedRooms.Size = New Size(951, 495)
        dgvBookedRooms.TabIndex = 0
        ' 
        ' BookedRoomControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlBookedRoomMid)
        Name = "BookedRoomControl"
        Size = New Size(951, 581)
        pnlBookedRoomMid.ResumeLayout(False)
        pnlBookedRoomMid.PerformLayout()
        CType(dgvBookedRooms, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlBookedRoomMid As Panel
    Friend WithEvents dgvBookedRooms As DataGridView
    Friend WithEvents Label1 As Label
End Class
