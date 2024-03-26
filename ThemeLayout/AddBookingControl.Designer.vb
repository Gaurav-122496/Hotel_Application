<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBookingControl
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AddBookingControl))
        pnlContainer = New Panel()
        txtBookingCode = New TextBox()
        Button1 = New Button()
        Panel2 = New Panel()
        dtpCheckOut = New DateTimePicker()
        Label17 = New Label()
        dtpCheckIn = New DateTimePicker()
        Label16 = New Label()
        pnlVehicleInformation = New Panel()
        Label25 = New Label()
        txtVehicleName = New TextBox()
        txtVehicleNumber = New TextBox()
        Label24 = New Label()
        txtvehicleCompany = New TextBox()
        Label23 = New Label()
        btnAddress = New Button()
        btnRoomDetails = New Button()
        pnlAddress = New Panel()
        Label31 = New Label()
        txtPincode = New TextBox()
        cmbCity = New ComboBox()
        Label22 = New Label()
        Label12 = New Label()
        cmbState = New ComboBox()
        Label10 = New Label()
        TextBox4 = New TextBox()
        cmbIdproff = New ComboBox()
        Label3 = New Label()
        Label9 = New Label()
        txtAddress2 = New TextBox()
        txtAddress1 = New TextBox()
        Label6 = New Label()
        pnlRoomDetails = New Panel()
        pnlRoomRight = New Panel()
        dgvRoomRight = New DataGridView()
        pnlRoomLeft = New Panel()
        btnUpdate = New Button()
        lblGst = New Label()
        lblTotalAmountt = New Label()
        btnAddRoomBooking = New Button()
        lblMealAmount = New Label()
        lblRoomAmount = New Label()
        lblTotalAmount = New Label()
        BtnApplyDiscount = New Button()
        txtDiscount = New TextBox()
        Label20 = New Label()
        cmbMeal = New ComboBox()
        cmbRooms = New ComboBox()
        cmbCategory = New ComboBox()
        Label19 = New Label()
        Label42 = New Label()
        Label18 = New Label()
        Label41 = New Label()
        Label13 = New Label()
        Label1 = New Label()
        btnVehicleInformation = New Button()
        pnlPersonalInformation = New Panel()
        Label32 = New Label()
        Label28 = New Label()
        Label27 = New Label()
        Label26 = New Label()
        txtFirstName = New TextBox()
        Label2 = New Label()
        btnPersonalInfromation = New Button()
        Label5 = New Label()
        cmbGender = New ComboBox()
        txtPhone2 = New TextBox()
        txtMiddleName = New TextBox()
        Label8 = New Label()
        Label4 = New Label()
        txtLastName = New TextBox()
        cmbKids = New ComboBox()
        Label11 = New Label()
        txtPhone1 = New TextBox()
        Label15 = New Label()
        Label7 = New Label()
        cmbAdults = New ComboBox()
        Label14 = New Label()
        PictureBox1 = New PictureBox()
        btnSave = New Button()
        btnDelete = New Button()
        pnlContainer.SuspendLayout()
        Panel2.SuspendLayout()
        pnlVehicleInformation.SuspendLayout()
        pnlAddress.SuspendLayout()
        pnlRoomDetails.SuspendLayout()
        pnlRoomRight.SuspendLayout()
        CType(dgvRoomRight, ComponentModel.ISupportInitialize).BeginInit()
        pnlRoomLeft.SuspendLayout()
        pnlPersonalInformation.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlContainer
        ' 
        pnlContainer.AutoScroll = True
        pnlContainer.BackColor = Color.White
        pnlContainer.Controls.Add(txtBookingCode)
        pnlContainer.Controls.Add(Button1)
        pnlContainer.Controls.Add(Panel2)
        pnlContainer.Controls.Add(pnlVehicleInformation)
        pnlContainer.Controls.Add(btnAddress)
        pnlContainer.Controls.Add(btnRoomDetails)
        pnlContainer.Controls.Add(pnlAddress)
        pnlContainer.Controls.Add(pnlRoomDetails)
        pnlContainer.Controls.Add(Label1)
        pnlContainer.Controls.Add(btnVehicleInformation)
        pnlContainer.Controls.Add(pnlPersonalInformation)
        pnlContainer.Controls.Add(PictureBox1)
        pnlContainer.Controls.Add(btnSave)
        pnlContainer.Dock = DockStyle.Fill
        pnlContainer.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        pnlContainer.Location = New Point(0, 0)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.Size = New Size(1017, 740)
        pnlContainer.TabIndex = 47
        ' 
        ' txtBookingCode
        ' 
        txtBookingCode.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBookingCode.Location = New Point(911, 6)
        txtBookingCode.Name = "txtBookingCode"
        txtBookingCode.Size = New Size(100, 22)
        txtBookingCode.TabIndex = 48
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.BackColor = Color.LightSkyBlue
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(0, 328)
        Button1.Name = "Button1"
        Button1.Size = New Size(1017, 23)
        Button1.TabIndex = 47
        Button1.Text = "Stay Dates"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(dtpCheckOut)
        Panel2.Controls.Add(Label17)
        Panel2.Controls.Add(dtpCheckIn)
        Panel2.Controls.Add(Label16)
        Panel2.Location = New Point(3, 350)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1014, 34)
        Panel2.TabIndex = 46
        ' 
        ' dtpCheckOut
        ' 
        dtpCheckOut.Anchor = AnchorStyles.Top
        dtpCheckOut.Location = New Point(345, 7)
        dtpCheckOut.Name = "dtpCheckOut"
        dtpCheckOut.Size = New Size(164, 22)
        dtpCheckOut.TabIndex = 125
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top
        Label17.AutoSize = True
        Label17.Location = New Point(267, 14)
        Label17.Name = "Label17"
        Label17.Size = New Size(58, 13)
        Label17.TabIndex = 123
        Label17.Text = "CheckOut"
        ' 
        ' dtpCheckIn
        ' 
        dtpCheckIn.Anchor = AnchorStyles.Top
        dtpCheckIn.Location = New Point(96, 7)
        dtpCheckIn.Name = "dtpCheckIn"
        dtpCheckIn.Size = New Size(156, 22)
        dtpCheckIn.TabIndex = 124
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top
        Label16.AutoSize = True
        Label16.Location = New Point(10, 14)
        Label16.Name = "Label16"
        Label16.Size = New Size(48, 13)
        Label16.TabIndex = 122
        Label16.Text = "CheckIn"
        ' 
        ' pnlVehicleInformation
        ' 
        pnlVehicleInformation.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlVehicleInformation.Controls.Add(Label25)
        pnlVehicleInformation.Controls.Add(txtVehicleName)
        pnlVehicleInformation.Controls.Add(txtVehicleNumber)
        pnlVehicleInformation.Controls.Add(Label24)
        pnlVehicleInformation.Controls.Add(txtvehicleCompany)
        pnlVehicleInformation.Controls.Add(Label23)
        pnlVehicleInformation.Location = New Point(0, 277)
        pnlVehicleInformation.Name = "pnlVehicleInformation"
        pnlVehicleInformation.Size = New Size(1020, 50)
        pnlVehicleInformation.TabIndex = 45
        ' 
        ' Label25
        ' 
        Label25.Anchor = AnchorStyles.Top
        Label25.AutoSize = True
        Label25.Location = New Point(258, 18)
        Label25.Name = "Label25"
        Label25.Size = New Size(84, 13)
        Label25.TabIndex = 120
        Label25.Text = "VehicleNumber"
        ' 
        ' txtVehicleName
        ' 
        txtVehicleName.Location = New Point(101, 12)
        txtVehicleName.Name = "txtVehicleName"
        txtVehicleName.Size = New Size(154, 22)
        txtVehicleName.TabIndex = 119
        ' 
        ' txtVehicleNumber
        ' 
        txtVehicleNumber.Anchor = AnchorStyles.Top
        txtVehicleNumber.Location = New Point(345, 12)
        txtVehicleNumber.Name = "txtVehicleNumber"
        txtVehicleNumber.Size = New Size(164, 22)
        txtVehicleNumber.TabIndex = 121
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(0, 15)
        Label24.Name = "Label24"
        Label24.Size = New Size(75, 13)
        Label24.TabIndex = 118
        Label24.Text = "Vehicle Name"
        ' 
        ' txtvehicleCompany
        ' 
        txtvehicleCompany.Anchor = AnchorStyles.Top
        txtvehicleCompany.Location = New Point(624, 15)
        txtvehicleCompany.Name = "txtvehicleCompany"
        txtvehicleCompany.Size = New Size(170, 22)
        txtvehicleCompany.TabIndex = 117
        ' 
        ' Label23
        ' 
        Label23.Anchor = AnchorStyles.Top
        Label23.AutoSize = True
        Label23.Location = New Point(520, 18)
        Label23.Name = "Label23"
        Label23.Size = New Size(94, 13)
        Label23.TabIndex = 116
        Label23.Text = "Vehicle Company"
        ' 
        ' btnAddress
        ' 
        btnAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnAddress.BackColor = Color.LightSkyBlue
        btnAddress.FlatStyle = FlatStyle.Popup
        btnAddress.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddress.ForeColor = Color.Black
        btnAddress.Location = New Point(0, 145)
        btnAddress.Name = "btnAddress"
        btnAddress.Size = New Size(1023, 25)
        btnAddress.TabIndex = 0
        btnAddress.Text = "Address Details"
        btnAddress.TextAlign = ContentAlignment.MiddleLeft
        btnAddress.UseVisualStyleBackColor = False
        ' 
        ' btnRoomDetails
        ' 
        btnRoomDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnRoomDetails.BackColor = Color.LightSkyBlue
        btnRoomDetails.FlatStyle = FlatStyle.Popup
        btnRoomDetails.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnRoomDetails.ForeColor = Color.Black
        btnRoomDetails.Location = New Point(0, 385)
        btnRoomDetails.Name = "btnRoomDetails"
        btnRoomDetails.Size = New Size(1017, 22)
        btnRoomDetails.TabIndex = 0
        btnRoomDetails.Text = "Room Details "
        btnRoomDetails.TextAlign = ContentAlignment.MiddleLeft
        btnRoomDetails.UseVisualStyleBackColor = False
        ' 
        ' pnlAddress
        ' 
        pnlAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlAddress.Controls.Add(Label31)
        pnlAddress.Controls.Add(txtPincode)
        pnlAddress.Controls.Add(cmbCity)
        pnlAddress.Controls.Add(Label22)
        pnlAddress.Controls.Add(Label12)
        pnlAddress.Controls.Add(cmbState)
        pnlAddress.Controls.Add(Label10)
        pnlAddress.Controls.Add(TextBox4)
        pnlAddress.Controls.Add(cmbIdproff)
        pnlAddress.Controls.Add(Label3)
        pnlAddress.Controls.Add(Label9)
        pnlAddress.Controls.Add(txtAddress2)
        pnlAddress.Controls.Add(txtAddress1)
        pnlAddress.Controls.Add(Label6)
        pnlAddress.Location = New Point(0, 169)
        pnlAddress.Name = "pnlAddress"
        pnlAddress.Size = New Size(1023, 80)
        pnlAddress.TabIndex = 44
        ' 
        ' Label31
        ' 
        Label31.Anchor = AnchorStyles.Top
        Label31.AutoSize = True
        Label31.BackColor = Color.Transparent
        Label31.FlatStyle = FlatStyle.System
        Label31.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label31.ForeColor = Color.Red
        Label31.Location = New Point(605, 1)
        Label31.Name = "Label31"
        Label31.Size = New Size(13, 17)
        Label31.TabIndex = 145
        Label31.Text = "*"
        ' 
        ' txtPincode
        ' 
        txtPincode.Anchor = AnchorStyles.Top
        txtPincode.Location = New Point(345, 47)
        txtPincode.Name = "txtPincode"
        txtPincode.Size = New Size(164, 22)
        txtPincode.TabIndex = 131
        ' 
        ' cmbCity
        ' 
        cmbCity.FormattingEnabled = True
        cmbCity.Items.AddRange(New Object() {"Dehradun ", "Mussoorie ", "haridwar"})
        cmbCity.Location = New Point(101, 47)
        cmbCity.Name = "cmbCity"
        cmbCity.Size = New Size(154, 21)
        cmbCity.TabIndex = 130
        ' 
        ' Label22
        ' 
        Label22.Anchor = AnchorStyles.Top
        Label22.AutoSize = True
        Label22.Location = New Point(267, 47)
        Label22.Name = "Label22"
        Label22.Size = New Size(48, 13)
        Label22.TabIndex = 129
        Label22.Text = "Pincode"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(6, 50)
        Label12.Name = "Label12"
        Label12.Size = New Size(26, 13)
        Label12.TabIndex = 128
        Label12.Text = "City"
        ' 
        ' cmbState
        ' 
        cmbState.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbState.FormattingEnabled = True
        cmbState.Items.AddRange(New Object() {"Uttrakhand ", "Uttarpradesh"})
        cmbState.Location = New Point(858, 8)
        cmbState.Name = "cmbState"
        cmbState.Size = New Size(165, 21)
        cmbState.TabIndex = 127
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Location = New Point(806, 14)
        Label10.Name = "Label10"
        Label10.Size = New Size(33, 13)
        Label10.TabIndex = 126
        Label10.Text = "State"
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top
        TextBox4.Location = New Point(624, 40)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(170, 22)
        TextBox4.TabIndex = 125
        ' 
        ' cmbIdproff
        ' 
        cmbIdproff.Anchor = AnchorStyles.Top
        cmbIdproff.FormattingEnabled = True
        cmbIdproff.Items.AddRange(New Object() {"ADHAR", "PAN", "LICENSE"})
        cmbIdproff.Location = New Point(624, 8)
        cmbIdproff.Name = "cmbIdproff"
        cmbIdproff.Size = New Size(170, 21)
        cmbIdproff.TabIndex = 124
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(4, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 13)
        Label3.TabIndex = 119
        Label3.Text = "Address1"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Location = New Point(564, 14)
        Label9.Name = "Label9"
        Label9.Size = New Size(42, 13)
        Label9.TabIndex = 121
        Label9.Text = "IdProff"
        ' 
        ' txtAddress2
        ' 
        txtAddress2.Anchor = AnchorStyles.Top
        txtAddress2.Location = New Point(345, 8)
        txtAddress2.Name = "txtAddress2"
        txtAddress2.Size = New Size(164, 22)
        txtAddress2.TabIndex = 123
        ' 
        ' txtAddress1
        ' 
        txtAddress1.Location = New Point(101, 8)
        txtAddress1.Name = "txtAddress1"
        txtAddress1.Size = New Size(154, 22)
        txtAddress1.TabIndex = 122
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Location = New Point(269, 11)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 13)
        Label6.TabIndex = 120
        Label6.Text = "Address2"
        ' 
        ' pnlRoomDetails
        ' 
        pnlRoomDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlRoomDetails.Controls.Add(pnlRoomRight)
        pnlRoomDetails.Controls.Add(pnlRoomLeft)
        pnlRoomDetails.Location = New Point(3, 410)
        pnlRoomDetails.Name = "pnlRoomDetails"
        pnlRoomDetails.Size = New Size(1011, 250)
        pnlRoomDetails.TabIndex = 43
        ' 
        ' pnlRoomRight
        ' 
        pnlRoomRight.BackColor = Color.White
        pnlRoomRight.Controls.Add(dgvRoomRight)
        pnlRoomRight.Dock = DockStyle.Top
        pnlRoomRight.Location = New Point(344, 0)
        pnlRoomRight.Name = "pnlRoomRight"
        pnlRoomRight.Size = New Size(667, 250)
        pnlRoomRight.TabIndex = 139
        ' 
        ' dgvRoomRight
        ' 
        dgvRoomRight.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRoomRight.BackgroundColor = Color.White
        dgvRoomRight.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRoomRight.Dock = DockStyle.Top
        dgvRoomRight.Location = New Point(0, 0)
        dgvRoomRight.Name = "dgvRoomRight"
        dgvRoomRight.RowTemplate.Height = 25
        dgvRoomRight.Size = New Size(667, 247)
        dgvRoomRight.TabIndex = 158
        ' 
        ' pnlRoomLeft
        ' 
        pnlRoomLeft.Controls.Add(btnDelete)
        pnlRoomLeft.Controls.Add(btnUpdate)
        pnlRoomLeft.Controls.Add(lblGst)
        pnlRoomLeft.Controls.Add(lblTotalAmountt)
        pnlRoomLeft.Controls.Add(btnAddRoomBooking)
        pnlRoomLeft.Controls.Add(lblMealAmount)
        pnlRoomLeft.Controls.Add(lblRoomAmount)
        pnlRoomLeft.Controls.Add(lblTotalAmount)
        pnlRoomLeft.Controls.Add(BtnApplyDiscount)
        pnlRoomLeft.Controls.Add(txtDiscount)
        pnlRoomLeft.Controls.Add(Label20)
        pnlRoomLeft.Controls.Add(cmbMeal)
        pnlRoomLeft.Controls.Add(cmbRooms)
        pnlRoomLeft.Controls.Add(cmbCategory)
        pnlRoomLeft.Controls.Add(Label19)
        pnlRoomLeft.Controls.Add(Label42)
        pnlRoomLeft.Controls.Add(Label18)
        pnlRoomLeft.Controls.Add(Label41)
        pnlRoomLeft.Controls.Add(Label13)
        pnlRoomLeft.Dock = DockStyle.Left
        pnlRoomLeft.Location = New Point(0, 0)
        pnlRoomLeft.Name = "pnlRoomLeft"
        pnlRoomLeft.Size = New Size(344, 250)
        pnlRoomLeft.TabIndex = 135
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(202, 220)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(53, 23)
        btnUpdate.TabIndex = 155
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' lblGst
        ' 
        lblGst.AutoSize = True
        lblGst.Location = New Point(142, 120)
        lblGst.Name = "lblGst"
        lblGst.Size = New Size(11, 13)
        lblGst.TabIndex = 154
        lblGst.Text = "-"
        ' 
        ' lblTotalAmountt
        ' 
        lblTotalAmountt.AutoSize = True
        lblTotalAmountt.Location = New Point(159, 193)
        lblTotalAmountt.Name = "lblTotalAmountt"
        lblTotalAmountt.Size = New Size(11, 13)
        lblTotalAmountt.TabIndex = 153
        lblTotalAmountt.Text = "-"
        ' 
        ' btnAddRoomBooking
        ' 
        btnAddRoomBooking.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnAddRoomBooking.FlatStyle = FlatStyle.Popup
        btnAddRoomBooking.ForeColor = Color.White
        btnAddRoomBooking.Location = New Point(142, 220)
        btnAddRoomBooking.Name = "btnAddRoomBooking"
        btnAddRoomBooking.Size = New Size(54, 23)
        btnAddRoomBooking.TabIndex = 151
        btnAddRoomBooking.Text = "Add"
        btnAddRoomBooking.UseVisualStyleBackColor = False
        ' 
        ' lblMealAmount
        ' 
        lblMealAmount.AutoSize = True
        lblMealAmount.Location = New Point(272, 90)
        lblMealAmount.Name = "lblMealAmount"
        lblMealAmount.Size = New Size(0, 13)
        lblMealAmount.TabIndex = 150
        ' 
        ' lblRoomAmount
        ' 
        lblRoomAmount.AutoSize = True
        lblRoomAmount.Location = New Point(272, 10)
        lblRoomAmount.Name = "lblRoomAmount"
        lblRoomAmount.Size = New Size(0, 13)
        lblRoomAmount.TabIndex = 149
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Location = New Point(172, 216)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(0, 13)
        lblTotalAmount.TabIndex = 148
        ' 
        ' BtnApplyDiscount
        ' 
        BtnApplyDiscount.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        BtnApplyDiscount.FlatStyle = FlatStyle.Popup
        BtnApplyDiscount.ForeColor = Color.White
        BtnApplyDiscount.Location = New Point(206, 145)
        BtnApplyDiscount.Name = "BtnApplyDiscount"
        BtnApplyDiscount.Size = New Size(49, 23)
        BtnApplyDiscount.TabIndex = 147
        BtnApplyDiscount.Text = "Apply"
        BtnApplyDiscount.UseVisualStyleBackColor = False
        ' 
        ' txtDiscount
        ' 
        txtDiscount.Location = New Point(96, 146)
        txtDiscount.Name = "txtDiscount"
        txtDiscount.Size = New Size(104, 22)
        txtDiscount.TabIndex = 146
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.Location = New Point(12, 116)
        Label20.Name = "Label20"
        Label20.Size = New Size(35, 17)
        Label20.TabIndex = 145
        Label20.Text = "GST "
        ' 
        ' cmbMeal
        ' 
        cmbMeal.FormattingEnabled = True
        cmbMeal.Location = New Point(96, 86)
        cmbMeal.Name = "cmbMeal"
        cmbMeal.Size = New Size(156, 21)
        cmbMeal.TabIndex = 144
        ' 
        ' cmbRooms
        ' 
        cmbRooms.FormattingEnabled = True
        cmbRooms.Location = New Point(96, 47)
        cmbRooms.Name = "cmbRooms"
        cmbRooms.Size = New Size(156, 21)
        cmbRooms.TabIndex = 143
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(96, 10)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(156, 21)
        cmbCategory.TabIndex = 142
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.Location = New Point(10, 86)
        Label19.Name = "Label19"
        Label19.Size = New Size(37, 17)
        Label19.TabIndex = 2
        Label19.Text = "Meal"
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label42.Location = New Point(10, 193)
        Label42.Name = "Label42"
        Label42.Size = New Size(95, 17)
        Label42.TabIndex = 141
        Label42.Text = "Total Amount "
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(10, 47)
        Label18.Name = "Label18"
        Label18.Size = New Size(50, 17)
        Label18.TabIndex = 1
        Label18.Text = "Rooms"
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label41.Location = New Point(12, 149)
        Label41.Name = "Label41"
        Label41.Size = New Size(55, 15)
        Label41.TabIndex = 140
        Label41.Text = "Discount"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(12, 10)
        Label13.Name = "Label13"
        Label13.Size = New Size(64, 17)
        Label13.TabIndex = 0
        Label13.Text = "Category"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(50, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 20)
        Label1.TabIndex = 42
        Label1.Text = "Guest Registration "
        ' 
        ' btnVehicleInformation
        ' 
        btnVehicleInformation.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnVehicleInformation.BackColor = Color.LightSkyBlue
        btnVehicleInformation.FlatStyle = FlatStyle.Popup
        btnVehicleInformation.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnVehicleInformation.ForeColor = Color.Black
        btnVehicleInformation.Location = New Point(0, 244)
        btnVehicleInformation.Name = "btnVehicleInformation"
        btnVehicleInformation.Size = New Size(1023, 33)
        btnVehicleInformation.TabIndex = 0
        btnVehicleInformation.Text = "Vehicle Details"
        btnVehicleInformation.TextAlign = ContentAlignment.MiddleLeft
        btnVehicleInformation.UseVisualStyleBackColor = False
        ' 
        ' pnlPersonalInformation
        ' 
        pnlPersonalInformation.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlPersonalInformation.Controls.Add(Label32)
        pnlPersonalInformation.Controls.Add(Label28)
        pnlPersonalInformation.Controls.Add(Label27)
        pnlPersonalInformation.Controls.Add(Label26)
        pnlPersonalInformation.Controls.Add(txtFirstName)
        pnlPersonalInformation.Controls.Add(Label2)
        pnlPersonalInformation.Controls.Add(btnPersonalInfromation)
        pnlPersonalInformation.Controls.Add(Label5)
        pnlPersonalInformation.Controls.Add(cmbGender)
        pnlPersonalInformation.Controls.Add(txtPhone2)
        pnlPersonalInformation.Controls.Add(txtMiddleName)
        pnlPersonalInformation.Controls.Add(Label8)
        pnlPersonalInformation.Controls.Add(Label4)
        pnlPersonalInformation.Controls.Add(txtLastName)
        pnlPersonalInformation.Controls.Add(cmbKids)
        pnlPersonalInformation.Controls.Add(Label11)
        pnlPersonalInformation.Controls.Add(txtPhone1)
        pnlPersonalInformation.Controls.Add(Label15)
        pnlPersonalInformation.Controls.Add(Label7)
        pnlPersonalInformation.Controls.Add(cmbAdults)
        pnlPersonalInformation.Controls.Add(Label14)
        pnlPersonalInformation.Location = New Point(3, 34)
        pnlPersonalInformation.Name = "pnlPersonalInformation"
        pnlPersonalInformation.Size = New Size(1017, 112)
        pnlPersonalInformation.TabIndex = 41
        ' 
        ' Label32
        ' 
        Label32.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label32.AutoSize = True
        Label32.BackColor = Color.Transparent
        Label32.FlatStyle = FlatStyle.System
        Label32.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label32.ForeColor = Color.Red
        Label32.Location = New Point(838, 28)
        Label32.Name = "Label32"
        Label32.Size = New Size(13, 17)
        Label32.TabIndex = 145
        Label32.Text = "*"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.BackColor = Color.Transparent
        Label28.FlatStyle = FlatStyle.System
        Label28.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label28.ForeColor = Color.Red
        Label28.Location = New Point(63, 66)
        Label28.Name = "Label28"
        Label28.Size = New Size(13, 17)
        Label28.TabIndex = 142
        Label28.Text = "*"
        ' 
        ' Label27
        ' 
        Label27.Anchor = AnchorStyles.Top
        Label27.AutoSize = True
        Label27.BackColor = Color.Transparent
        Label27.FlatStyle = FlatStyle.System
        Label27.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label27.ForeColor = Color.Red
        Label27.Location = New Point(606, 28)
        Label27.Name = "Label27"
        Label27.Size = New Size(13, 17)
        Label27.TabIndex = 141
        Label27.Text = "*"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.BackColor = Color.Transparent
        Label26.FlatStyle = FlatStyle.System
        Label26.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label26.ForeColor = Color.Red
        Label26.Location = New Point(63, 28)
        Label26.Name = "Label26"
        Label26.Size = New Size(13, 17)
        Label26.TabIndex = 140
        Label26.Text = "*"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(98, 31)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(154, 22)
        txtFirstName.TabIndex = 87
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(4, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 13)
        Label2.TabIndex = 86
        Label2.Text = "FirstName "
        ' 
        ' btnPersonalInfromation
        ' 
        btnPersonalInfromation.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnPersonalInfromation.BackColor = Color.LightSkyBlue
        btnPersonalInfromation.FlatStyle = FlatStyle.Popup
        btnPersonalInfromation.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnPersonalInfromation.ForeColor = Color.Black
        btnPersonalInfromation.Location = New Point(-3, 0)
        btnPersonalInfromation.Name = "btnPersonalInfromation"
        btnPersonalInfromation.Size = New Size(1029, 25)
        btnPersonalInfromation.TabIndex = 0
        btnPersonalInfromation.Text = "Personal  Details"
        btnPersonalInfromation.TextAlign = ContentAlignment.MiddleLeft
        btnPersonalInfromation.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Location = New Point(267, 33)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 13)
        Label5.TabIndex = 124
        Label5.Text = "MiddleName"
        ' 
        ' cmbGender
        ' 
        cmbGender.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"MALE", "FEMALE ", "OTHERS "})
        cmbGender.Location = New Point(852, 36)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(168, 21)
        cmbGender.TabIndex = 135
        ' 
        ' txtPhone2
        ' 
        txtPhone2.Anchor = AnchorStyles.Top
        txtPhone2.Location = New Point(342, 68)
        txtPhone2.Name = "txtPhone2"
        txtPhone2.Size = New Size(164, 22)
        txtPhone2.TabIndex = 133
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Anchor = AnchorStyles.Top
        txtMiddleName.Location = New Point(342, 31)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(164, 22)
        txtMiddleName.TabIndex = 130
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Location = New Point(268, 68)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 13)
        Label8.TabIndex = 127
        Label8.Text = "Mobile 2"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Location = New Point(552, 39)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 13)
        Label4.TabIndex = 125
        Label4.Text = "LastName "
        ' 
        ' txtLastName
        ' 
        txtLastName.Anchor = AnchorStyles.Top
        txtLastName.Location = New Point(621, 33)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(170, 22)
        txtLastName.TabIndex = 131
        ' 
        ' cmbKids
        ' 
        cmbKids.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbKids.FormattingEnabled = True
        cmbKids.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cmbKids.Location = New Point(852, 69)
        cmbKids.Name = "cmbKids"
        cmbKids.Size = New Size(168, 21)
        cmbKids.TabIndex = 139
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Location = New Point(798, 40)
        Label11.Name = "Label11"
        Label11.Size = New Size(48, 13)
        Label11.TabIndex = 128
        Label11.Text = "Gender "
        ' 
        ' txtPhone1
        ' 
        txtPhone1.Location = New Point(98, 68)
        txtPhone1.Name = "txtPhone1"
        txtPhone1.Size = New Size(154, 22)
        txtPhone1.TabIndex = 132
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(807, 66)
        Label15.Name = "Label15"
        Label15.Size = New Size(29, 15)
        Label15.TabIndex = 137
        Label15.Text = "Kids"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(3, 74)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 13)
        Label7.TabIndex = 126
        Label7.Text = "Mobile 1"
        ' 
        ' cmbAdults
        ' 
        cmbAdults.Anchor = AnchorStyles.Top
        cmbAdults.FormattingEnabled = True
        cmbAdults.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cmbAdults.Location = New Point(620, 68)
        cmbAdults.Name = "cmbAdults"
        cmbAdults.Size = New Size(171, 21)
        cmbAdults.TabIndex = 138
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(552, 67)
        Label14.Name = "Label14"
        Label14.Size = New Size(44, 15)
        Label14.TabIndex = 136
        Label14.Text = "Adults "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(41, 25)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 40
        PictureBox1.TabStop = False
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSave.BackColor = Color.FromArgb(CByte(0), CByte(187), CByte(0))
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.ForeColor = Color.White
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageAlign = ContentAlignment.MiddleLeft
        btnSave.Location = New Point(946, 663)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(68, 36)
        btnSave.TabIndex = 38
        btnSave.TextAlign = ContentAlignment.MiddleRight
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.LimeGreen
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(261, 220)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(51, 23)
        btnDelete.TabIndex = 156
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' AddBookingControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(pnlContainer)
        Name = "AddBookingControl"
        Size = New Size(1017, 740)
        pnlContainer.ResumeLayout(False)
        pnlContainer.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        pnlVehicleInformation.ResumeLayout(False)
        pnlVehicleInformation.PerformLayout()
        pnlAddress.ResumeLayout(False)
        pnlAddress.PerformLayout()
        pnlRoomDetails.ResumeLayout(False)
        pnlRoomRight.ResumeLayout(False)
        CType(dgvRoomRight, ComponentModel.ISupportInitialize).EndInit()
        pnlRoomLeft.ResumeLayout(False)
        pnlRoomLeft.PerformLayout()
        pnlPersonalInformation.ResumeLayout(False)
        pnlPersonalInformation.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlPersonalInformation As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPersonalInfromation As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbKids As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbAdults As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtPhone2 As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPhone1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlRoomDetails As Panel
    Friend WithEvents btnRoomDetails As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents pnlAddress As Panel
    Friend WithEvents btnAddress As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents cmbIdproff As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAddress2 As TextBox
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlVehicleInformation As Panel
    Friend WithEvents btnVehicleInformation As Button
    Friend WithEvents txtvehicleCompany As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtVehicleName As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtVehicleNumber As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPincode As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents pnlRoomLeft As Panel
    Friend WithEvents pnlRoomRight As Panel
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents dgvRoomRight As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbMeal As ComboBox
    Friend WithEvents cmbRooms As ComboBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents BtnApplyDiscount As Button
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblMealAmount As Label
    Friend WithEvents lblRoomAmount As Label
    Friend WithEvents txtBookingCode As TextBox
    Friend WithEvents btnAddRoomBooking As Button
    Friend WithEvents lblTotalAmountt As Label
    Friend WithEvents lblGst As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
End Class
