<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomTypeControl
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
        pnlRoomTypeControl = New Panel()
        btnAdd = New Button()
        DataGridView1 = New DataGridView()
        pnlRoomTypeControl.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlRoomTypeControl
        ' 
        pnlRoomTypeControl.Controls.Add(btnAdd)
        pnlRoomTypeControl.Controls.Add(DataGridView1)
        pnlRoomTypeControl.Dock = DockStyle.Fill
        pnlRoomTypeControl.Location = New Point(0, 0)
        pnlRoomTypeControl.Name = "pnlRoomTypeControl"
        pnlRoomTypeControl.Size = New Size(964, 571)
        pnlRoomTypeControl.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Right
        btnAdd.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(858, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(103, 34)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Add Room Type"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.Location = New Point(0, 205)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(964, 366)
        DataGridView1.TabIndex = 0
        ' 
        ' RoomTypeControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlRoomTypeControl)
        Name = "RoomTypeControl"
        Size = New Size(964, 571)
        pnlRoomTypeControl.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlRoomTypeControl As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
End Class
