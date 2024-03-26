<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BtndashControl
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(BtndashControl))
        pnlDashControl = New Panel()
        pnlRight = New Panel()
        Button1 = New Button()
        Label5 = New Label()
        TextBox4 = New TextBox()
        pnlLeft = New Panel()
        Label17 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label14 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        pnlDashControl.SuspendLayout()
        pnlRight.SuspendLayout()
        pnlLeft.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlDashControl
        ' 
        pnlDashControl.AutoScroll = True
        pnlDashControl.Controls.Add(pnlRight)
        pnlDashControl.Controls.Add(pnlLeft)
        pnlDashControl.Dock = DockStyle.Fill
        pnlDashControl.Location = New Point(0, 0)
        pnlDashControl.Name = "pnlDashControl"
        pnlDashControl.Size = New Size(1071, 681)
        pnlDashControl.TabIndex = 0
        ' 
        ' pnlRight
        ' 
        pnlRight.Controls.Add(Button1)
        pnlRight.Controls.Add(Label5)
        pnlRight.Controls.Add(TextBox4)
        pnlRight.Dock = DockStyle.Right
        pnlRight.Location = New Point(531, 0)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(540, 681)
        pnlRight.TabIndex = 22
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.White
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = Color.Black
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(437, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 30)
        Button1.TabIndex = 19
        Button1.Text = " AddBooking"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(3, 103)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 20)
        Label5.TabIndex = 8
        Label5.Text = "Booked Rooms "
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox4.Location = New Point(128, 105)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "search"
        TextBox4.Size = New Size(409, 23)
        TextBox4.TabIndex = 9
        TextBox4.Tag = ""
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' pnlLeft
        ' 
        pnlLeft.Controls.Add(Label17)
        pnlLeft.Controls.Add(Label15)
        pnlLeft.Controls.Add(Label16)
        pnlLeft.Controls.Add(Label14)
        pnlLeft.Controls.Add(PictureBox4)
        pnlLeft.Controls.Add(PictureBox3)
        pnlLeft.Controls.Add(Label4)
        pnlLeft.Controls.Add(TextBox3)
        pnlLeft.Dock = DockStyle.Left
        pnlLeft.Location = New Point(0, 0)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(525, 681)
        pnlLeft.TabIndex = 20
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(433, 53)
        Label17.Name = "Label17"
        Label17.Size = New Size(18, 20)
        Label17.TabIndex = 21
        Label17.Text = "4"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(139, 53)
        Label15.Name = "Label15"
        Label15.Size = New Size(23, 20)
        Label15.TabIndex = 20
        Label15.Text = "10"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(409, 13)
        Label16.Name = "Label16"
        Label16.Size = New Size(61, 20)
        Label16.TabIndex = 20
        Label16.Text = "Booked"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(109, 18)
        Label14.Name = "Label14"
        Label14.Size = New Size(59, 20)
        Label14.TabIndex = 19
        Label14.Text = "Rooms "
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(309, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(184, 80)
        PictureBox4.TabIndex = 19
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(5, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(179, 80)
        PictureBox3.TabIndex = 18
        PictureBox3.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(3, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 20)
        Label4.TabIndex = 1
        Label4.Text = "Availlabel Rooms" & vbCrLf
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox3.Location = New Point(139, 104)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "search"
        TextBox3.Size = New Size(383, 23)
        TextBox3.TabIndex = 2
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtndashControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(pnlDashControl)
        Name = "BtndashControl"
        Size = New Size(1071, 681)
        pnlDashControl.ResumeLayout(False)
        pnlRight.ResumeLayout(False)
        pnlRight.PerformLayout()
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDashControl As Panel
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents pnlRight As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
End Class
