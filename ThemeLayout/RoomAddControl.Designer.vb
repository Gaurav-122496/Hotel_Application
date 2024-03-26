<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomAddControl
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(RoomAddControl))
        pnlRoomAddControl = New Panel()
        btnBack = New Button()
        btnSave = New Button()
        DateTimePicker1 = New DateTimePicker()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        pnlRoomAddControl.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlRoomAddControl
        ' 
        pnlRoomAddControl.Controls.Add(btnBack)
        pnlRoomAddControl.Controls.Add(btnSave)
        pnlRoomAddControl.Controls.Add(DateTimePicker1)
        pnlRoomAddControl.Controls.Add(TextBox6)
        pnlRoomAddControl.Controls.Add(TextBox5)
        pnlRoomAddControl.Controls.Add(TextBox3)
        pnlRoomAddControl.Controls.Add(TextBox2)
        pnlRoomAddControl.Controls.Add(TextBox1)
        pnlRoomAddControl.Controls.Add(Label6)
        pnlRoomAddControl.Controls.Add(Label5)
        pnlRoomAddControl.Controls.Add(Label4)
        pnlRoomAddControl.Controls.Add(Label3)
        pnlRoomAddControl.Controls.Add(Label2)
        pnlRoomAddControl.Controls.Add(Label1)
        pnlRoomAddControl.Dock = DockStyle.Fill
        pnlRoomAddControl.Location = New Point(0, 0)
        pnlRoomAddControl.Name = "pnlRoomAddControl"
        pnlRoomAddControl.Size = New Size(956, 567)
        pnlRoomAddControl.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnBack.FlatStyle = FlatStyle.Popup
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(709, 354)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 31)
        btnBack.TabIndex = 14
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.ForestGreen
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.ForeColor = Color.White
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageAlign = ContentAlignment.MiddleLeft
        btnSave.Location = New Point(828, 354)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(36, 31)
        btnSave.TabIndex = 13
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(634, 63)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(248, 23)
        DateTimePicker1.TabIndex = 12
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(635, 196)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(247, 23)
        TextBox6.TabIndex = 11
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(635, 126)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(247, 23)
        TextBox5.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(177, 201)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(272, 23)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(177, 131)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(272, 23)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(177, 64)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(272, 23)
        TextBox1.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(539, 209)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 15)
        Label6.TabIndex = 5
        Label6.Text = "Hotel Id "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(91, 204)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 15)
        Label5.TabIndex = 4
        Label5.Text = "Active"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(539, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 3
        Label4.Text = "Created By "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(539, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 15)
        Label3.TabIndex = 2
        Label3.Text = "Created Date " & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(91, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 1
        Label2.Text = "Number "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(91, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 15)
        Label1.TabIndex = 0
        Label1.Text = "Code"
        ' 
        ' RoomAddControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlRoomAddControl)
        Name = "RoomAddControl"
        Size = New Size(956, 567)
        pnlRoomAddControl.ResumeLayout(False)
        pnlRoomAddControl.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlRoomAddControl As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
End Class
