<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingControl
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(BookingControl))
        pnlBookingControlMid = New Panel()
        Label1 = New Label()
        btnAdd = New Button()
        dgvBooking = New DataGridView()
        pnlBookingControlMid.SuspendLayout()
        CType(dgvBooking, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlBookingControlMid
        ' 
        pnlBookingControlMid.Controls.Add(Label1)
        pnlBookingControlMid.Controls.Add(btnAdd)
        pnlBookingControlMid.Controls.Add(dgvBooking)
        pnlBookingControlMid.Dock = DockStyle.Fill
        pnlBookingControlMid.Location = New Point(0, 0)
        pnlBookingControlMid.Name = "pnlBookingControlMid"
        pnlBookingControlMid.Size = New Size(1027, 626)
        pnlBookingControlMid.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(875, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 15)
        Label1.TabIndex = 4
        Label1.Text = "         Dashboard > Booking "
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Right
        btnAdd.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.ForeColor = Color.White
        btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), Image)
        btnAdd.Location = New Point(976, 36)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(48, 30)
        btnAdd.TabIndex = 3
        btnAdd.TextAlign = ContentAlignment.MiddleRight
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' dgvBooking
        ' 
        dgvBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBooking.BackgroundColor = SystemColors.Control
        dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooking.Dock = DockStyle.Bottom
        dgvBooking.GridColor = SystemColors.Control
        dgvBooking.Location = New Point(0, 72)
        dgvBooking.Name = "dgvBooking"
        dgvBooking.RowTemplate.Height = 25
        dgvBooking.Size = New Size(1027, 554)
        dgvBooking.TabIndex = 2
        ' 
        ' BookingControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlBookingControlMid)
        Name = "BookingControl"
        Size = New Size(1027, 626)
        pnlBookingControlMid.ResumeLayout(False)
        pnlBookingControlMid.PerformLayout()
        CType(dgvBooking, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlBookingControlMid As Panel
    Friend WithEvents dgvBooking As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
End Class
