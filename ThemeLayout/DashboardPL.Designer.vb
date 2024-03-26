<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        pnlTop = New Panel()
        PictureBox2 = New PictureBox()
        btnMenu = New Button()
        ComboBox1 = New ComboBox()
        PictureBox1 = New PictureBox()
        pnlLeftNavigation = New Panel()
        pnlHotelConfiguration = New Panel()
        btnEmployee = New Button()
        btnDesignation = New Button()
        btnDepartment = New Button()
        btnCoupon = New Button()
        btnHousekeeping = New Button()
        btnFloors = New Button()
        btnPriceManager = New Button()
        BtnPaidServices = New Button()
        btnHallTypes = New Button()
        btnHall = New Button()
        BtnRoomTypes = New Button()
        btnRoom = New Button()
        btnSetting = New Button()
        btnReports = New Button()
        BtnHotelConfiguration = New Button()
        btnGuests = New Button()
        btnBookingHalls = New Button()
        btnBookingRoom = New Button()
        btnBookings = New Button()
        btnAvaliblityCalendar = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnDashboard = New Button()
        pnlCenter = New Panel()
        pnlTop.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlLeftNavigation.SuspendLayout()
        pnlHotelConfiguration.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTop
        ' 
        pnlTop.BackColor = Color.LightSkyBlue
        pnlTop.Controls.Add(PictureBox2)
        pnlTop.Controls.Add(btnMenu)
        pnlTop.Controls.Add(ComboBox1)
        pnlTop.Controls.Add(PictureBox1)
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(0, 0)
        pnlTop.Name = "pnlTop"
        pnlTop.Size = New Size(957, 42)
        pnlTop.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox2.BackColor = Color.Black
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(923, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(34, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' btnMenu
        ' 
        btnMenu.BackColor = Color.LightSkyBlue
        btnMenu.BackgroundImageLayout = ImageLayout.None
        btnMenu.FlatStyle = FlatStyle.Popup
        btnMenu.ForeColor = Color.Black
        btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), Image)
        btnMenu.Location = New Point(72, 3)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(31, 28)
        btnMenu.TabIndex = 0
        btnMenu.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ComboBox1.FormattingEnabled = True
        ComboBox1.ItemHeight = 15
        ComboBox1.Location = New Point(823, 8)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(94, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(42, 42)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' pnlLeftNavigation
        ' 
        pnlLeftNavigation.AccessibleRole = AccessibleRole.Outline
        pnlLeftNavigation.AutoScroll = True
        pnlLeftNavigation.BackColor = Color.White
        pnlLeftNavigation.Controls.Add(pnlHotelConfiguration)
        pnlLeftNavigation.Controls.Add(btnSetting)
        pnlLeftNavigation.Controls.Add(btnReports)
        pnlLeftNavigation.Controls.Add(BtnHotelConfiguration)
        pnlLeftNavigation.Controls.Add(btnGuests)
        pnlLeftNavigation.Controls.Add(btnBookingHalls)
        pnlLeftNavigation.Controls.Add(btnBookingRoom)
        pnlLeftNavigation.Controls.Add(btnBookings)
        pnlLeftNavigation.Controls.Add(btnAvaliblityCalendar)
        pnlLeftNavigation.Controls.Add(Label3)
        pnlLeftNavigation.Controls.Add(Label2)
        pnlLeftNavigation.Controls.Add(Label1)
        pnlLeftNavigation.Controls.Add(btnDashboard)
        pnlLeftNavigation.Dock = DockStyle.Left
        pnlLeftNavigation.Location = New Point(0, 42)
        pnlLeftNavigation.Name = "pnlLeftNavigation"
        pnlLeftNavigation.Size = New Size(169, 681)
        pnlLeftNavigation.TabIndex = 1
        ' 
        ' pnlHotelConfiguration
        ' 
        pnlHotelConfiguration.Controls.Add(btnEmployee)
        pnlHotelConfiguration.Controls.Add(btnDesignation)
        pnlHotelConfiguration.Controls.Add(btnDepartment)
        pnlHotelConfiguration.Controls.Add(btnCoupon)
        pnlHotelConfiguration.Controls.Add(btnHousekeeping)
        pnlHotelConfiguration.Controls.Add(btnFloors)
        pnlHotelConfiguration.Controls.Add(btnPriceManager)
        pnlHotelConfiguration.Controls.Add(BtnPaidServices)
        pnlHotelConfiguration.Controls.Add(btnHallTypes)
        pnlHotelConfiguration.Controls.Add(btnHall)
        pnlHotelConfiguration.Controls.Add(BtnRoomTypes)
        pnlHotelConfiguration.Controls.Add(btnRoom)
        pnlHotelConfiguration.Location = New Point(5, 310)
        pnlHotelConfiguration.Name = "pnlHotelConfiguration"
        pnlHotelConfiguration.Size = New Size(159, 352)
        pnlHotelConfiguration.TabIndex = 9
        ' 
        ' btnEmployee
        ' 
        btnEmployee.FlatStyle = FlatStyle.Flat
        btnEmployee.Image = CType(resources.GetObject("btnEmployee.Image"), Image)
        btnEmployee.ImageAlign = ContentAlignment.MiddleRight
        btnEmployee.Location = New Point(0, 325)
        btnEmployee.Name = "btnEmployee"
        btnEmployee.Size = New Size(156, 23)
        btnEmployee.TabIndex = 10
        btnEmployee.Text = "Employee"
        btnEmployee.TextAlign = ContentAlignment.MiddleLeft
        btnEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnDesignation
        ' 
        btnDesignation.FlatStyle = FlatStyle.Flat
        btnDesignation.Image = CType(resources.GetObject("btnDesignation.Image"), Image)
        btnDesignation.ImageAlign = ContentAlignment.MiddleRight
        btnDesignation.Location = New Point(0, 296)
        btnDesignation.Name = "btnDesignation"
        btnDesignation.Size = New Size(156, 23)
        btnDesignation.TabIndex = 10
        btnDesignation.Text = "Designation "
        btnDesignation.TextAlign = ContentAlignment.MiddleLeft
        btnDesignation.UseVisualStyleBackColor = True
        ' 
        ' btnDepartment
        ' 
        btnDepartment.FlatStyle = FlatStyle.Flat
        btnDepartment.Image = CType(resources.GetObject("btnDepartment.Image"), Image)
        btnDepartment.ImageAlign = ContentAlignment.MiddleRight
        btnDepartment.Location = New Point(0, 267)
        btnDepartment.Name = "btnDepartment"
        btnDepartment.Size = New Size(156, 23)
        btnDepartment.TabIndex = 10
        btnDepartment.Text = "Department"
        btnDepartment.TextAlign = ContentAlignment.MiddleLeft
        btnDepartment.UseVisualStyleBackColor = True
        ' 
        ' btnCoupon
        ' 
        btnCoupon.FlatStyle = FlatStyle.Flat
        btnCoupon.Image = CType(resources.GetObject("btnCoupon.Image"), Image)
        btnCoupon.ImageAlign = ContentAlignment.MiddleRight
        btnCoupon.Location = New Point(0, 238)
        btnCoupon.Name = "btnCoupon"
        btnCoupon.Size = New Size(156, 23)
        btnCoupon.TabIndex = 2
        btnCoupon.Text = "Coupon"
        btnCoupon.TextAlign = ContentAlignment.MiddleLeft
        btnCoupon.UseVisualStyleBackColor = True
        ' 
        ' btnHousekeeping
        ' 
        btnHousekeeping.FlatStyle = FlatStyle.Flat
        btnHousekeeping.Image = CType(resources.GetObject("btnHousekeeping.Image"), Image)
        btnHousekeeping.ImageAlign = ContentAlignment.MiddleRight
        btnHousekeeping.Location = New Point(0, 209)
        btnHousekeeping.Name = "btnHousekeeping"
        btnHousekeeping.Size = New Size(156, 23)
        btnHousekeeping.TabIndex = 2
        btnHousekeeping.Text = "Housekeeping Status" & vbCrLf
        btnHousekeeping.TextAlign = ContentAlignment.MiddleLeft
        btnHousekeeping.UseVisualStyleBackColor = True
        ' 
        ' btnFloors
        ' 
        btnFloors.FlatStyle = FlatStyle.Flat
        btnFloors.Image = CType(resources.GetObject("btnFloors.Image"), Image)
        btnFloors.ImageAlign = ContentAlignment.MiddleRight
        btnFloors.Location = New Point(0, 180)
        btnFloors.Name = "btnFloors"
        btnFloors.Size = New Size(156, 23)
        btnFloors.TabIndex = 2
        btnFloors.Text = "Floors "
        btnFloors.TextAlign = ContentAlignment.MiddleLeft
        btnFloors.UseVisualStyleBackColor = True
        ' 
        ' btnPriceManager
        ' 
        btnPriceManager.FlatStyle = FlatStyle.Flat
        btnPriceManager.Image = CType(resources.GetObject("btnPriceManager.Image"), Image)
        btnPriceManager.ImageAlign = ContentAlignment.MiddleRight
        btnPriceManager.Location = New Point(0, 151)
        btnPriceManager.Name = "btnPriceManager"
        btnPriceManager.Size = New Size(156, 23)
        btnPriceManager.TabIndex = 1
        btnPriceManager.Text = "PriceManager"
        btnPriceManager.TextAlign = ContentAlignment.MiddleLeft
        btnPriceManager.UseVisualStyleBackColor = True
        ' 
        ' BtnPaidServices
        ' 
        BtnPaidServices.FlatStyle = FlatStyle.Flat
        BtnPaidServices.Image = CType(resources.GetObject("BtnPaidServices.Image"), Image)
        BtnPaidServices.ImageAlign = ContentAlignment.MiddleRight
        BtnPaidServices.Location = New Point(0, 122)
        BtnPaidServices.Name = "BtnPaidServices"
        BtnPaidServices.Size = New Size(156, 23)
        BtnPaidServices.TabIndex = 4
        BtnPaidServices.Text = "Paid Services "
        BtnPaidServices.TextAlign = ContentAlignment.MiddleLeft
        BtnPaidServices.UseVisualStyleBackColor = True
        ' 
        ' btnHallTypes
        ' 
        btnHallTypes.FlatStyle = FlatStyle.Flat
        btnHallTypes.Image = CType(resources.GetObject("btnHallTypes.Image"), Image)
        btnHallTypes.ImageAlign = ContentAlignment.MiddleRight
        btnHallTypes.Location = New Point(0, 90)
        btnHallTypes.Name = "btnHallTypes"
        btnHallTypes.Size = New Size(156, 26)
        btnHallTypes.TabIndex = 3
        btnHallTypes.Text = "Hall Types "
        btnHallTypes.TextAlign = ContentAlignment.MiddleLeft
        btnHallTypes.UseVisualStyleBackColor = True
        ' 
        ' btnHall
        ' 
        btnHall.FlatStyle = FlatStyle.Flat
        btnHall.Image = CType(resources.GetObject("btnHall.Image"), Image)
        btnHall.ImageAlign = ContentAlignment.MiddleRight
        btnHall.Location = New Point(0, 61)
        btnHall.Name = "btnHall"
        btnHall.Size = New Size(156, 23)
        btnHall.TabIndex = 2
        btnHall.Text = "Hall"
        btnHall.TextAlign = ContentAlignment.MiddleLeft
        btnHall.UseVisualStyleBackColor = True
        ' 
        ' BtnRoomTypes
        ' 
        BtnRoomTypes.FlatStyle = FlatStyle.Flat
        BtnRoomTypes.Image = CType(resources.GetObject("BtnRoomTypes.Image"), Image)
        BtnRoomTypes.ImageAlign = ContentAlignment.MiddleRight
        BtnRoomTypes.Location = New Point(0, 32)
        BtnRoomTypes.Name = "BtnRoomTypes"
        BtnRoomTypes.Size = New Size(156, 23)
        BtnRoomTypes.TabIndex = 1
        BtnRoomTypes.Text = "Room Types "
        BtnRoomTypes.TextAlign = ContentAlignment.MiddleLeft
        BtnRoomTypes.UseVisualStyleBackColor = True
        ' 
        ' btnRoom
        ' 
        btnRoom.FlatStyle = FlatStyle.Flat
        btnRoom.Image = CType(resources.GetObject("btnRoom.Image"), Image)
        btnRoom.ImageAlign = ContentAlignment.MiddleRight
        btnRoom.Location = New Point(0, 3)
        btnRoom.Name = "btnRoom"
        btnRoom.Size = New Size(156, 23)
        btnRoom.TabIndex = 0
        btnRoom.Text = "Room"
        btnRoom.TextAlign = ContentAlignment.MiddleLeft
        btnRoom.UseVisualStyleBackColor = True
        ' 
        ' btnSetting
        ' 
        btnSetting.FlatStyle = FlatStyle.Flat
        btnSetting.Image = CType(resources.GetObject("btnSetting.Image"), Image)
        btnSetting.ImageAlign = ContentAlignment.MiddleLeft
        btnSetting.Location = New Point(3, 253)
        btnSetting.Name = "btnSetting"
        btnSetting.Size = New Size(161, 24)
        btnSetting.TabIndex = 1
        btnSetting.Text = "Setting "
        btnSetting.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Image = CType(resources.GetObject("btnReports.Image"), Image)
        btnReports.ImageAlign = ContentAlignment.MiddleLeft
        btnReports.Location = New Point(3, 224)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(161, 23)
        btnReports.TabIndex = 0
        btnReports.Text = "Reports "
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' BtnHotelConfiguration
        ' 
        BtnHotelConfiguration.FlatStyle = FlatStyle.Flat
        BtnHotelConfiguration.Image = CType(resources.GetObject("BtnHotelConfiguration.Image"), Image)
        BtnHotelConfiguration.ImageAlign = ContentAlignment.MiddleLeft
        BtnHotelConfiguration.Location = New Point(3, 283)
        BtnHotelConfiguration.Name = "BtnHotelConfiguration"
        BtnHotelConfiguration.Size = New Size(160, 23)
        BtnHotelConfiguration.TabIndex = 8
        BtnHotelConfiguration.Text = "    Hotel Configuration"
        BtnHotelConfiguration.UseVisualStyleBackColor = True
        ' 
        ' btnGuests
        ' 
        btnGuests.FlatStyle = FlatStyle.Flat
        btnGuests.Image = CType(resources.GetObject("btnGuests.Image"), Image)
        btnGuests.ImageAlign = ContentAlignment.MiddleLeft
        btnGuests.Location = New Point(4, 151)
        btnGuests.Name = "btnGuests"
        btnGuests.Size = New Size(160, 24)
        btnGuests.TabIndex = 4
        btnGuests.Text = "Guests "
        btnGuests.UseVisualStyleBackColor = True
        ' 
        ' btnBookingHalls
        ' 
        btnBookingHalls.FlatStyle = FlatStyle.Flat
        btnBookingHalls.Image = CType(resources.GetObject("btnBookingHalls.Image"), Image)
        btnBookingHalls.ImageAlign = ContentAlignment.MiddleLeft
        btnBookingHalls.Location = New Point(5, 107)
        btnBookingHalls.Name = "btnBookingHalls"
        btnBookingHalls.Size = New Size(160, 23)
        btnBookingHalls.TabIndex = 3
        btnBookingHalls.Text = "Booked Halls "
        btnBookingHalls.UseVisualStyleBackColor = True
        ' 
        ' btnBookingRoom
        ' 
        btnBookingRoom.FlatStyle = FlatStyle.Flat
        btnBookingRoom.Image = CType(resources.GetObject("btnBookingRoom.Image"), Image)
        btnBookingRoom.ImageAlign = ContentAlignment.MiddleLeft
        btnBookingRoom.Location = New Point(3, 78)
        btnBookingRoom.Name = "btnBookingRoom"
        btnBookingRoom.Size = New Size(162, 23)
        btnBookingRoom.TabIndex = 2
        btnBookingRoom.Text = "Booked Rooms"
        btnBookingRoom.UseVisualStyleBackColor = True
        ' 
        ' btnBookings
        ' 
        btnBookings.FlatStyle = FlatStyle.Flat
        btnBookings.Image = CType(resources.GetObject("btnBookings.Image"), Image)
        btnBookings.ImageAlign = ContentAlignment.MiddleLeft
        btnBookings.Location = New Point(4, 50)
        btnBookings.Name = "btnBookings"
        btnBookings.Size = New Size(160, 22)
        btnBookings.TabIndex = 1
        btnBookings.Text = "Bookings "
        btnBookings.UseVisualStyleBackColor = True
        ' 
        ' btnAvaliblityCalendar
        ' 
        btnAvaliblityCalendar.FlatStyle = FlatStyle.Flat
        btnAvaliblityCalendar.Image = CType(resources.GetObject("btnAvaliblityCalendar.Image"), Image)
        btnAvaliblityCalendar.ImageAlign = ContentAlignment.MiddleLeft
        btnAvaliblityCalendar.Location = New Point(3, 196)
        btnAvaliblityCalendar.Name = "btnAvaliblityCalendar"
        btnAvaliblityCalendar.Size = New Size(161, 22)
        btnAvaliblityCalendar.TabIndex = 7
        btnAvaliblityCalendar.Text = "       Avaliblity Calendar"
        btnAvaliblityCalendar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(2, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 6
        Label3.Text = "   Avaliblity "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(2, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 5
        Label2.Text = " Guest  "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(4, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 0
        Label1.Text = "   Booking"
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.White
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.ForeColor = SystemColors.ActiveCaptionText
        btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), Image)
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(5, 6)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(162, 23)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = " Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' pnlCenter
        ' 
        pnlCenter.AllowDrop = True
        pnlCenter.BackColor = Color.White
        pnlCenter.BackgroundImageLayout = ImageLayout.None
        pnlCenter.BorderStyle = BorderStyle.FixedSingle
        pnlCenter.Dock = DockStyle.Fill
        pnlCenter.Location = New Point(169, 42)
        pnlCenter.Name = "pnlCenter"
        pnlCenter.Size = New Size(788, 681)
        pnlCenter.TabIndex = 2
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(957, 723)
        Controls.Add(pnlCenter)
        Controls.Add(pnlLeftNavigation)
        Controls.Add(pnlTop)
        MinimumSize = New Size(957, 523)
        Name = "Form3"
        pnlTop.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlLeftNavigation.ResumeLayout(False)
        pnlLeftNavigation.PerformLayout()
        pnlHotelConfiguration.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlLeftNavigation As Panel
    Friend WithEvents pnlCenter As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBookings As Button
    Friend WithEvents btnGuests As Button
    Friend WithEvents btnBookingHalls As Button
    Friend WithEvents btnBookingRoom As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAvaliblityCalendar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnHotelConfiguration As Button
    Friend WithEvents pnlHotelConfiguration As Panel
    Friend WithEvents BtnPaidServices As Button
    Friend WithEvents btnHallTypes As Button
    Friend WithEvents btnHall As Button
    Friend WithEvents BtnRoomTypes As Button
    Friend WithEvents btnRoom As Button
    Friend WithEvents btnPriceManager As Button
    Friend WithEvents btnHousekeeping As Button
    Friend WithEvents btnFloors As Button
    Friend WithEvents btnCoupon As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnReports As Button
    Friend WithEvents btnSetting As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnDesignation As Button
    Friend WithEvents btnDepartment As Button
    Friend WithEvents btnMenu As Button
End Class
