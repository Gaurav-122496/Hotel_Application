
Imports HotelBL

Public Class Form3



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnHallTypes.Click

    End Sub

    Private Sub pnlCenter_Paint(sender As Object, e As PaintEventArgs) Handles pnlCenter.Paint




    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        pnlHotelConfiguration.Visible = False
        pnlLeftNavigation.Visible = True

    End Sub

    Private Sub BtnHotelConfiguration_Click(sender As Object, e As EventArgs) Handles BtnHotelConfiguration.Click

        If pnlHotelConfiguration.Visible = False Then

            pnlHotelConfiguration.Visible = True
        Else
            pnlHotelConfiguration.Visible = False

        End If

    End Sub

    '
    Public Sub Addusercontrol(user As UserControl)

        If pnlCenter.Controls.Contains(user) Then
            user.Show()

        Else

            pnlCenter.Controls.Clear()
            user.Top = False
            user.Dock = DockStyle.Fill
            pnlCenter.Controls.Add(user)
            user.BringToFront()
        End If

    End Sub

    Private Sub btnBookings_Click(sender As Object, e As EventArgs) Handles btnBookings.Click

        Dim book As New BookingControl
        Addusercontrol(book)

        Dim bl As New RoomBookingDetailsBL
        Dim result = bl.ShowData
        book.dgvBooking.DataSource = result




    End Sub

    Private Sub btnDashboard_MouseEnter(sender As Object, e As EventArgs) Handles btnDashboard.MouseEnter


    End Sub

    'Private Sub pnlCenter_MouseHover(sender As Object, e As EventArgs) Handles pnlCenter.MouseHover

    'End Sub

    Private Sub btnDashboard_MouseHover(sender As Object, e As EventArgs) Handles btnDashboard.MouseHover
        btnDashboard.BackColor = Color.Teal
        btnDashboard.ForeColor = Color.White


    End Sub

    Private Sub btnDashboard_MouseLeave(sender As Object, e As EventArgs) Handles btnDashboard.MouseLeave
        btnDashboard.BackColor = Color.Teal
        btnDashboard.ForeColor = Color.White

    End Sub

    Private Sub btnBookings_MouseHover(sender As Object, e As EventArgs) Handles btnBookings.MouseHover
        btnBookings.BackColor = Color.Teal
        btnBookings.ForeColor = Color.White
    End Sub

    Private Sub btnBookings_MouseLeave(sender As Object, e As EventArgs) Handles btnBookings.MouseLeave
        btnBookings.BackColor = Color.White
        btnBookings.ForeColor = Color.Black
    End Sub

    Private Sub btnBookingRoom_MouseHover(sender As Object, e As EventArgs) Handles btnBookingRoom.MouseHover
        btnBookingRoom.BackColor = Color.Teal
        btnBookingRoom.ForeColor = Color.White
    End Sub

    Private Sub btnBookingRoom_MouseLeave(sender As Object, e As EventArgs) Handles btnBookingRoom.MouseLeave
        btnBookingRoom.BackColor = Color.White
        btnBookingRoom.ForeColor = Color.Black

    End Sub

    Private Sub btnBookingHalls_MouseHover(sender As Object, e As EventArgs) Handles btnBookingHalls.MouseHover
        btnBookingHalls.BackColor = Color.Teal
        btnBookingHalls.ForeColor = Color.White

    End Sub

    Private Sub btnBookingHalls_MouseLeave(sender As Object, e As EventArgs) Handles btnBookingHalls.MouseLeave
        btnBookingHalls.BackColor = Color.White
        btnBookingHalls.ForeColor = Color.Black

    End Sub

    Private Sub btnGuests_MouseHover(sender As Object, e As EventArgs) Handles btnGuests.MouseHover
        btnGuests.BackColor = Color.Teal
        btnGuests.ForeColor = Color.White

    End Sub

    Private Sub btnGuests_MouseLeave(sender As Object, e As EventArgs) Handles btnGuests.MouseLeave
        btnGuests.BackColor = Color.White
        btnGuests.ForeColor = Color.Black

    End Sub

    Private Sub btnAvaliblityCalendar_MouseHover(sender As Object, e As EventArgs) Handles btnAvaliblityCalendar.MouseHover
        btnAvaliblityCalendar.BackColor = Color.Teal
        btnAvaliblityCalendar.ForeColor = Color.White

    End Sub

    Private Sub btnAvaliblityCalendar_MouseLeave(sender As Object, e As EventArgs) Handles btnAvaliblityCalendar.MouseLeave
        btnAvaliblityCalendar.BackColor = Color.White
        btnAvaliblityCalendar.ForeColor = Color.Black

    End Sub

    Private Sub BtnHotelConfiguration_MouseHover(sender As Object, e As EventArgs) Handles BtnHotelConfiguration.MouseHover
        BtnHotelConfiguration.BackColor = Color.Teal
        BtnHotelConfiguration.ForeColor = Color.White

    End Sub

    Private Sub BtnHotelConfiguration_MouseLeave(sender As Object, e As EventArgs) Handles BtnHotelConfiguration.MouseLeave
        BtnHotelConfiguration.BackColor = Color.White
        BtnHotelConfiguration.ForeColor = Color.Black

    End Sub

    Private Sub btnReports_MouseHover(sender As Object, e As EventArgs) Handles btnReports.MouseHover
        btnReports.BackColor = Color.Teal
        btnReports.ForeColor = Color.White

    End Sub

    Private Sub btnReports_MouseLeave(sender As Object, e As EventArgs) Handles btnReports.MouseLeave
        btnReports.BackColor = Color.White
        btnReports.ForeColor = Color.Black

    End Sub

    Private Sub btnSetting_MouseHover(sender As Object, e As EventArgs) Handles btnSetting.MouseHover
        btnSetting.BackColor = Color.Teal
        btnSetting.ForeColor = Color.White

    End Sub

    Private Sub btnSetting_MouseLeave(sender As Object, e As EventArgs) Handles btnSetting.MouseLeave
        btnSetting.BackColor = Color.White
        btnSetting.ForeColor = Color.Black

    End Sub

    Private Sub btnRoom_MouseHover(sender As Object, e As EventArgs) Handles btnRoom.MouseHover
        btnRoom.BackColor = Color.Teal
        btnRoom.ForeColor = Color.White

    End Sub

    Private Sub btnRoom_MouseLeave(sender As Object, e As EventArgs) Handles btnRoom.MouseLeave
        btnRoom.BackColor = Color.White
        btnRoom.ForeColor = Color.Black

    End Sub

    Private Sub BtnRoomTypes_MouseHover(sender As Object, e As EventArgs) Handles BtnRoomTypes.MouseHover
        BtnRoomTypes.BackColor = Color.Teal
        BtnRoomTypes.ForeColor = Color.White

    End Sub

    Private Sub BtnRoomTypes_MouseLeave(sender As Object, e As EventArgs) Handles BtnRoomTypes.MouseLeave
        BtnRoomTypes.BackColor = Color.White
        BtnRoomTypes.ForeColor = Color.Black

    End Sub

    Private Sub btnHall_MouseHover(sender As Object, e As EventArgs) Handles btnHall.MouseHover
        btnHall.BackColor = Color.Teal
        btnHall.ForeColor = Color.White

    End Sub

    Private Sub btnHall_MouseLeave(sender As Object, e As EventArgs) Handles btnHall.MouseLeave
        btnHall.BackColor = Color.White
        btnHall.ForeColor = Color.Black

    End Sub

    Private Sub btnHallTypes_MouseHover(sender As Object, e As EventArgs) Handles btnHallTypes.MouseHover
        btnHallTypes.BackColor = Color.Teal
        btnHallTypes.ForeColor = Color.White
    End Sub

    Private Sub btnHallTypes_MouseLeave(sender As Object, e As EventArgs) Handles btnHallTypes.MouseLeave
        btnHallTypes.BackColor = Color.White
        btnHallTypes.ForeColor = Color.Black

    End Sub

    Private Sub btnPriceManager_MouseHover(sender As Object, e As EventArgs) Handles btnPriceManager.MouseHover
        btnPriceManager.BackColor = Color.Teal
        btnPriceManager.ForeColor = Color.White


    End Sub

    Private Sub btnPriceManager_MouseLeave(sender As Object, e As EventArgs) Handles btnPriceManager.MouseLeave

        btnPriceManager.BackColor = Color.White
        btnPriceManager.ForeColor = Color.Black

    End Sub

    Private Sub BtnPaidServices_MouseHover(sender As Object, e As EventArgs) Handles BtnPaidServices.MouseHover
        BtnPaidServices.BackColor = Color.Teal
        BtnPaidServices.ForeColor = Color.White

    End Sub

    Private Sub BtnPaidServices_MouseLeave(sender As Object, e As EventArgs) Handles BtnPaidServices.MouseLeave
        BtnPaidServices.BackColor = Color.White
        BtnPaidServices.ForeColor = Color.Black

    End Sub

    Private Sub btnFloors_MouseHover(sender As Object, e As EventArgs) Handles btnFloors.MouseHover
        btnFloors.BackColor = Color.Teal
        btnFloors.ForeColor = Color.White

    End Sub

    Private Sub btnFloors_MouseLeave(sender As Object, e As EventArgs) Handles btnFloors.MouseLeave
        btnFloors.BackColor = Color.White
        btnFloors.ForeColor = Color.Black

    End Sub

    Private Sub btnHousekeeping_MouseHover(sender As Object, e As EventArgs) Handles btnHousekeeping.MouseHover
        btnHousekeeping.BackColor = Color.Teal
        btnHousekeeping.ForeColor = Color.White

    End Sub

    Private Sub btnHousekeeping_MouseLeave(sender As Object, e As EventArgs) Handles btnHousekeeping.MouseLeave
        btnHousekeeping.BackColor = Color.White
        btnHousekeeping.ForeColor = Color.Black

    End Sub

    Private Sub btnCoupon_MouseHover(sender As Object, e As EventArgs) Handles btnCoupon.MouseHover
        btnCoupon.BackColor = Color.Teal
        btnCoupon.ForeColor = Color.White

    End Sub

    Private Sub btnCoupon_MouseLeave(sender As Object, e As EventArgs) Handles btnCoupon.MouseLeave
        btnCoupon.BackColor = Color.White
        btnCoupon.ForeColor = Color.Black

    End Sub

    Private Sub btnDepartment_MouseHover(sender As Object, e As EventArgs) Handles btnDepartment.MouseHover
        btnDepartment.BackColor = Color.Teal
        btnDepartment.ForeColor = Color.White

    End Sub

    Private Sub btnDepartment_MouseLeave(sender As Object, e As EventArgs) Handles btnDepartment.MouseLeave
        btnDepartment.BackColor = Color.White
        btnDepartment.ForeColor = Color.Black

    End Sub

    Private Sub btnDesignation_MouseHover(sender As Object, e As EventArgs) Handles btnDesignation.MouseHover
        btnDesignation.BackColor = Color.Teal
        btnDesignation.ForeColor = Color.White

    End Sub

    Private Sub btnDesignation_MouseLeave(sender As Object, e As EventArgs) Handles btnDesignation.MouseLeave
        btnDesignation.BackColor = Color.White
        btnDesignation.ForeColor = Color.Black

    End Sub

    Private Sub btnEmployee_MouseHover(sender As Object, e As EventArgs) Handles btnEmployee.MouseHover
        btnEmployee.BackColor = Color.Teal
        btnEmployee.ForeColor = Color.White

    End Sub

    Private Sub btnEmployee_MouseLeave(sender As Object, e As EventArgs) Handles btnEmployee.MouseLeave
        btnEmployee.BackColor = Color.White
        btnEmployee.ForeColor = Color.Black

    End Sub

    Private Sub btnDashboard_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnDashboard.KeyPress
        btnDashboard.BackColor = Color.Teal
        btnDashboard.ForeColor = Color.White

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim dash As New BtndashControl
        Addusercontrol(dash)
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If pnlLeftNavigation.Visible = True Then
            pnlLeftNavigation.Visible = False
        Else
            pnlLeftNavigation.Visible = True

        End If

    End Sub

    Private Sub btnHall_Click(sender As Object, e As EventArgs) Handles btnHall.Click

    End Sub

    Private Sub btnBookingRoom_Click(sender As Object, e As EventArgs) Handles btnBookingRoom.Click
        Dim usercon As New BookedRoomControl
        Addusercontrol(usercon)



        Dim bl As New RoomBookingDetailsBL
        Dim result = bl.GetBooking
        usercon.dgvBookedRooms.DataSource = result




    End Sub

    Private Sub btnGuests_Click(sender As Object, e As EventArgs) Handles btnGuests.Click
        Dim guest As New GuestControl
        Addusercontrol(guest)

        ' Dim grid As New DataGridView
        Dim bl As New CustomerBL
        Dim result = bl.GetCustomer
        guest.dgvGuest.DataSource = result



    End Sub

    Private Sub btnBookingHalls_Click(sender As Object, e As EventArgs) Handles btnBookingHalls.Click
        Dim halls As New BookedHalls
        Addusercontrol(halls)

        Dim bl As New RoomBookingDetailsBL
        Dim result = bl.GetBooking
        halls.dgvBookedHals.DataSource = result

    End Sub

    Private Sub btnAvaliblityCalendar_Click(sender As Object, e As EventArgs) Handles btnAvaliblityCalendar.Click
        Dim Avaliblity As New AvaliblityControl
        Addusercontrol(Avaliblity)

    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        Dim setting As New SettingControl
        Addusercontrol(setting)

    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        Dim room As New RoomControl
        Addusercontrol(room)

    End Sub

    Private Sub BtnRoomTypes_Click(sender As Object, e As EventArgs) Handles BtnRoomTypes.Click
        Dim room As New RoomTypeControl
        Addusercontrol(room)

    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        Dim employee As New EmployeeControl
        Addusercontrol(employee)
    End Sub
End Class