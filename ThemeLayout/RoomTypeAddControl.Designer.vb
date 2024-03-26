<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomTypeAddControl
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
        pnlRoomTypeAddControl = New Panel()
        btnBack = New Button()
        btnSave = New Button()
        DateTimePicker1 = New DateTimePicker()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        pnlRoomTypeAddControl.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlRoomTypeAddControl
        ' 
        pnlRoomTypeAddControl.BackColor = Color.White
        pnlRoomTypeAddControl.Controls.Add(btnBack)
        pnlRoomTypeAddControl.Controls.Add(btnSave)
        pnlRoomTypeAddControl.Controls.Add(DateTimePicker1)
        pnlRoomTypeAddControl.Controls.Add(TextBox5)
        pnlRoomTypeAddControl.Controls.Add(TextBox4)
        pnlRoomTypeAddControl.Controls.Add(TextBox3)
        pnlRoomTypeAddControl.Controls.Add(TextBox2)
        pnlRoomTypeAddControl.Controls.Add(TextBox1)
        pnlRoomTypeAddControl.Controls.Add(Label6)
        pnlRoomTypeAddControl.Controls.Add(Label5)
        pnlRoomTypeAddControl.Controls.Add(Label4)
        pnlRoomTypeAddControl.Controls.Add(Label3)
        pnlRoomTypeAddControl.Controls.Add(Label2)
        pnlRoomTypeAddControl.Controls.Add(Label1)
        pnlRoomTypeAddControl.Dock = DockStyle.Fill
        pnlRoomTypeAddControl.Location = New Point(0, 0)
        pnlRoomTypeAddControl.Name = "pnlRoomTypeAddControl"
        pnlRoomTypeAddControl.Size = New Size(954, 577)
        pnlRoomTypeAddControl.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnBack.FlatStyle = FlatStyle.Popup
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(704, 352)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 31)
        btnBack.TabIndex = 13
        btnBack.Text = "Back "
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(798, 352)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(67, 31)
        btnSave.TabIndex = 12
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(632, 57)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(278, 23)
        DateTimePicker1.TabIndex = 11
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(632, 173)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(278, 23)
        TextBox5.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(632, 117)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(278, 23)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(164, 182)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(281, 23)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(164, 121)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(281, 23)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(164, 60)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(281, 23)
        TextBox1.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(549, 181)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 15)
        Label6.TabIndex = 5
        Label6.Text = "Hotel Id"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(549, 120)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 15)
        Label5.TabIndex = 4
        Label5.Text = "Created By"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(549, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 15)
        Label4.TabIndex = 3
        Label4.Text = "Created Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(84, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 2
        Label3.Text = "Active "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(84, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 1
        Label2.Text = "Code"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(84, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 0
        Label1.Text = "Type  "
        ' 
        ' RoomTypeAddControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlRoomTypeAddControl)
        Name = "RoomTypeAddControl"
        Size = New Size(954, 577)
        pnlRoomTypeAddControl.ResumeLayout(False)
        pnlRoomTypeAddControl.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlRoomTypeAddControl As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
End Class
