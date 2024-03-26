<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeControl
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
        pnlEmployee = New Panel()
        dgvEmployee = New DataGridView()
        btnAdd = New Button()
        Panel1 = New Panel()
        Label9 = New Label()
        dtpCreatedDate = New DateTimePicker()
        cmbRole = New ComboBox()
        txtPassword = New TextBox()
        txtUserName = New TextBox()
        txtLastName = New TextBox()
        txtMiddleName = New TextBox()
        txtFirstName = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        pnlEmployee.SuspendLayout()
        CType(dgvEmployee, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlEmployee
        ' 
        pnlEmployee.BackColor = Color.White
        pnlEmployee.Controls.Add(dgvEmployee)
        pnlEmployee.Controls.Add(btnAdd)
        pnlEmployee.Controls.Add(Panel1)
        pnlEmployee.Controls.Add(dtpCreatedDate)
        pnlEmployee.Controls.Add(cmbRole)
        pnlEmployee.Controls.Add(txtPassword)
        pnlEmployee.Controls.Add(txtUserName)
        pnlEmployee.Controls.Add(txtLastName)
        pnlEmployee.Controls.Add(txtMiddleName)
        pnlEmployee.Controls.Add(txtFirstName)
        pnlEmployee.Controls.Add(Label7)
        pnlEmployee.Controls.Add(Label6)
        pnlEmployee.Controls.Add(Label5)
        pnlEmployee.Controls.Add(Label4)
        pnlEmployee.Controls.Add(Label3)
        pnlEmployee.Controls.Add(Label2)
        pnlEmployee.Controls.Add(Label1)
        pnlEmployee.Dock = DockStyle.Fill
        pnlEmployee.Location = New Point(0, 0)
        pnlEmployee.Name = "pnlEmployee"
        pnlEmployee.Size = New Size(969, 552)
        pnlEmployee.TabIndex = 0
        ' 
        ' dgvEmployee
        ' 
        dgvEmployee.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvEmployee.BackgroundColor = Color.White
        dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployee.Location = New Point(540, 3)
        dgvEmployee.Name = "dgvEmployee"
        dgvEmployee.RowTemplate.Height = 25
        dgvEmployee.Size = New Size(429, 549)
        dgvEmployee.TabIndex = 21
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(473, 358)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(61, 27)
        btnAdd.TabIndex = 20
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label9)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(540, 36)
        Panel1.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(200, 3)
        Label9.Name = "Label9"
        Label9.Size = New Size(134, 20)
        Label9.TabIndex = 18
        Label9.Text = "  Add  Employee   "
        ' 
        ' dtpCreatedDate
        ' 
        dtpCreatedDate.Location = New Point(320, 309)
        dtpCreatedDate.Name = "dtpCreatedDate"
        dtpCreatedDate.Size = New Size(214, 23)
        dtpCreatedDate.TabIndex = 16
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Location = New Point(320, 272)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(214, 23)
        cmbRole.TabIndex = 15
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(320, 232)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(214, 23)
        txtPassword.TabIndex = 12
        ' 
        ' txtUserName
        ' 
        txtUserName.Location = New Point(320, 189)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(214, 23)
        txtUserName.TabIndex = 11
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(320, 150)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(214, 23)
        txtLastName.TabIndex = 10
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(320, 110)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(214, 23)
        txtMiddleName.TabIndex = 9
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(320, 69)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(214, 23)
        txtFirstName.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(56, 317)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 15)
        Label7.TabIndex = 6
        Label7.Text = "CreatedDate"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(56, 275)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 15)
        Label6.TabIndex = 5
        Label6.Text = "Role"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(56, 232)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 4
        Label5.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(56, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 15)
        Label4.TabIndex = 3
        Label4.Text = "UserName"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(57, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 2
        Label3.Text = "LastName "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(57, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 1
        Label2.Text = "MiddleName"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 0
        Label1.Text = "FirstName"
        ' 
        ' EmployeeControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlEmployee)
        Name = "EmployeeControl"
        Size = New Size(969, 552)
        pnlEmployee.ResumeLayout(False)
        pnlEmployee.PerformLayout()
        CType(dgvEmployee, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlEmployee As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents dtpCreatedDate As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvEmployee As DataGridView
End Class
