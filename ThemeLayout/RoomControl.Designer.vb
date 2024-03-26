<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomControl
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(RoomControl))
        pnlRoomControl = New Panel()
        btnAdd = New Button()
        DataGridView1 = New DataGridView()
        pnlRoomControl.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlRoomControl
        ' 
        pnlRoomControl.Controls.Add(btnAdd)
        pnlRoomControl.Controls.Add(DataGridView1)
        pnlRoomControl.Dock = DockStyle.Fill
        pnlRoomControl.Location = New Point(0, 0)
        pnlRoomControl.Name = "pnlRoomControl"
        pnlRoomControl.Size = New Size(958, 580)
        pnlRoomControl.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Right
        btnAdd.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.ForeColor = Color.White
        btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), Image)
        btnAdd.Location = New Point(911, 183)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(44, 31)
        btnAdd.TabIndex = 1
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.Location = New Point(0, 220)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(958, 360)
        DataGridView1.TabIndex = 0
        ' 
        ' RoomControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlRoomControl)
        Name = "RoomControl"
        Size = New Size(958, 580)
        pnlRoomControl.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlRoomControl As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
