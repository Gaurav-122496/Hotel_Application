Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports HotelBL
''Imports HotelDAL
Imports HotelDTO
Public Class AddBookingControl
#Region "Methods"

    Private Sub Addcontrol(usercontrol As UserControl)
        pnlContainer.Controls.Clear()
        usercontrol.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(usercontrol)
        usercontrol.BringToFront()
        usercontrol.Show()

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim book As New BookingControl
        Addcontrol(book)

        Dim bl As New RoomBookingDetailsBL
        Dim result = bl.ShowData
        book.dgvBooking.DataSource = result

    End Sub

    Private Sub AddBookingControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        pnlRoomDetails.Visible = True
        GetCategory()
        GetMeal()

        'Dim roombookingdetailsbl As New RoomBookingDetailsBL
        'Dim result = roombookingdetailsbl.GetRoomDetails
        'dgvRoomRight.DataSource = result

        btnUpdate.Visible = False
        btnDelete.Visible = False
    End Sub

    ''' <summary>
    '''  Description : this function is use   to get  RoomCategory from RoomTypeBl and show in combobox in UI
    ''' </summary>
    ''' <returns></returns>
    Public Function GetCategory()
        Dim bl As New RoomTypeBL
        Dim result As DataTable = bl.GetRoomType()
        Dim dr As DataRow
        dr = result.NewRow
        dr.ItemArray = New Object() {0, "--Select Room--"}
        result.Rows.InsertAt(dr, 0)
        cmbCategory.ValueMember = "RoomTypeId"
        cmbCategory.DisplayMember = "Type"
        cmbCategory.DataSource = result
        Return Nothing
    End Function


    ''' <summary>
    '''  Description: this funtion is used to get how many numbers in any RoomType and show in UI and pass 
    ''' </summary>
    ''' <param name="key"></param>
    ''' <returns></returns>
    Public Function GetRoomsNumber(key As String)

        Dim bl As New RoomTypeBL
        Dim result = bl.GetRoomCount(key)
        cmbRooms.ValueMember = "RoomId"
        cmbRooms.DisplayMember = "Number"
        Dim dr As DataRow
        Dim count As Integer = 1
        For Each dr In result.rows

            cmbRooms.Items.Add(count)
            count = count + 1
        Next
        Return Nothing

    End Function

    ''' <summary>
    ''' Description: this function is used to get meal from meal table how many mealtypes we have and show in combobox in UI
    ''' </summary>
    ''' <returns></returns>
    Public Function GetMeal()

        Dim bl As New MealBL
        Dim MealResult As DataTable = bl.GetMeal()
        Dim dr As DataRow
        dr = MealResult.NewRow
        dr.ItemArray = New Object() {0, "--Select Meal--"}
        MealResult.Rows.InsertAt(dr, 0)
        cmbMeal.ValueMember = "MealId"
        cmbMeal.DisplayMember = "MealType"
        cmbMeal.DataSource = MealResult
        Return Nothing

    End Function

    ''' <summary>
    ''' Description: this function is used to price of room of any type with help of valuemember it will return Pk of table 
    ''' </summary>
    ''' <param name="key"></param>
    ''' <returns></returns>
    Public Function getPrice(key As String)
        Dim bl As New RoomTypeBL
        Dim priceresult = bl.Getprice(key)

        If priceresult.Rows.Count > 0 Then
            Return (priceresult.Rows(0)("Price"))
        Else
            Return 0

        End If
    End Function

    ''' <summary>
    ''' Description: this function is used to get price of meal through MealType
    ''' </summary>
    ''' <param name="key"></param>
    ''' <returns></returns>
    Public Function getMealPrice(key As String)
        Dim bl As New MealBL
        Dim mealresult = bl.GetMealPrice(key)

        If mealresult.rows.count > 0 Then
            Return (mealresult.rows(0)("Price"))
        Else
            Return 0
        End If

    End Function

    ''' <summary>
    ''' this function is used to calculate amiunt  of room and gst and meal and numbers of rooms 
    ''' </summary>
    Private Sub CalculateTotalAmount()

        Dim selectedRoomTypeId As Integer = (cmbCategory.SelectedValue)
        Dim selectedRoomCount As Integer = (cmbRooms.SelectedItem)
        Dim selectedMealId As Integer = (cmbMeal.SelectedValue)
        Dim gstpercentage As String = "10%"

        Dim roomPrice As Integer = getPrice(selectedRoomTypeId)
        Dim mealPrice As Integer = getMealPrice(selectedMealId)
        Dim gstAmount As Decimal = 0.1 * roomPrice
        Dim totalAmount As Integer = (roomPrice * selectedRoomCount + gstAmount) + mealPrice
        lblGst.Text = gstpercentage
        lblTotalAmountt.Text = totalAmount.ToString

    End Sub


    ''' <summary>
    ''' Description: this fun is used for apply discount in toatalamount
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnApplyDiscount_Click(sender As Object, e As EventArgs) Handles BtnApplyDiscount.Click

        Dim discount As Integer = txtDiscount.Text
        Dim total As Integer = lblTotalAmountt.Text
        total = total - discount
        lblTotalAmountt.Text = total

    End Sub


    ''' <summary>
    ''' 1.save  data in Customer Table 
    ''' 2. save data in RoomBookingDetails Table 
    ''' 3. save data in Booking table 
    ''' 4. save data in Vehicle Table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        '' obj of customers 
        Dim customerdto As New CustomerDTO
        Dim customerbl As New CustomerBL

        ''obj of Vehicle 
        Dim vehicledto As New VehicleDTO
        Dim vehiclebl As New VehicleBL

        customerdto.FirstName = txtFirstName.Text
        customerdto.MiddleName = txtMiddleName.Text
        customerdto.LastName = txtLastName.Text
        customerdto.Gender = cmbGender.Text
        customerdto.Phone1 = txtPhone1.Text
        customerdto.Phone2 = txtPhone2.Text
        customerdto.Address1 = txtAddress1.Text
        customerdto.Address2 = txtAddress2.Text
        customerdto.IdProff = cmbIdproff.Text
        Dim result = customerbl.AddCustomer(customerdto)


        vehicledto.State = cmbState.Text
        vehicledto.City = cmbCity.Text
        vehicledto.Pincode = txtPincode.Text
        vehicledto.VehicleCompany = txtvehicleCompany.Text
        vehicledto.VehicleName = txtVehicleName.Text
        vehicledto.VehicleNumber = txtVehicleNumber.Text
        Dim ress = vehiclebl.AddVehicleInfo(vehicledto)
        If ress Then
            MsgBox(" customer Saved SuccessFully")
        Else
            MsgBox("Retry")

        End If
    End Sub
    ''' <summary>
    ''' Descriiption: this function  is use to get bookingid from booking table and pass into roomBookingDetails section to insert BookingId in RoomBookingDetais table
    ''' </summary>
    ''' <param name="key"></param>
    ''' <returns></returns>
    Public Function GetBookingId(key As String)
        Dim bookingbl As New BookingBL
        Dim result = bookingbl.GetBookingId(key)

        If result.rows.count > 0 Then
            Return (result.rows(0)("BookingId"))
        Else
            Return 0
        End If
    End Function

    Private Sub btnAddRoomBooking_Click(sender As Object, e As EventArgs) Handles btnAddRoomBooking.Click

        '' obj of RoomBookingDetails 
        Dim Roombookingdto As New RoomBookingDetailsDTO
        Dim roombookingbl As New RoomBookingDetailsBL
        ' obj of BookingBl and dto 
        Dim Bookingdto As New BookingDTO
        Dim bookingbl As New BookingBL

        Bookingdto.BookingCode = txtBookingCode.Text
        Dim result = bookingbl.AddBooking(Bookingdto)
        Dim bookingid As Integer = GetBookingId(Bookingdto.BookingCode)

        Roombookingdto.Adults = cmbAdults.Text
        Roombookingdto.Kids = cmbKids.Text
        Roombookingdto.RoomTypeId = cmbCategory.SelectedValue
        Roombookingdto.CheckInDate = dtpCheckIn.Value
        Roombookingdto.CheckOutDate = dtpCheckOut.Value
        Roombookingdto.NbrOfRooms = cmbRooms.Text
        Roombookingdto.MealId = cmbMeal.SelectedValue
        Roombookingdto.TotalAmount = lblTotalAmountt.Text.ToString
        Roombookingdto.Discount = txtDiscount.Text
        Roombookingdto.BookingId = bookingid
        Dim res = roombookingbl.AddRoomBooking(Roombookingdto)



        Dim roombookingdetailsbl As New RoomBookingDetailsBL
        Dim gridresult = roombookingdetailsbl.GetRoomDetails(bookingid)
        dgvRoomRight.DataSource = result

        If res Then
            MsgBox(" payment Saved successfully")
        Else
            MsgBox("Retry")

        End If

    End Sub

    ''' <summary>
    ''' description: update data in RoomBookingDetails Table 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        '' obj of RoomBookingDetails 
        Dim Roombookingdto As New RoomBookingDetailsDTO
        Dim roombookingbl As New RoomBookingDetailsBL

        ' obj of BookingBl and dto 
        Dim Bookingdto As New BookingDTO
        Dim bookingbl As New BookingBL

        Dim resultbox As DialogResult = MessageBox.Show("Are you sure you want to Update the data?", "Confirmation", MessageBoxButtons.YesNo)
        If resultbox = DialogResult.Yes Then

            Bookingdto.BookingCode = txtBookingCode.Text
            Dim bookingid As Integer = GetBookingId(Bookingdto.BookingCode)

            Roombookingdto.Adults = cmbAdults.Text
            Roombookingdto.Kids = cmbKids.Text
            Roombookingdto.RoomTypeId = cmbCategory.SelectedValue
            Roombookingdto.CheckInDate = dtpCheckIn.Value
            Roombookingdto.CheckOutDate = dtpCheckOut.Value
            Roombookingdto.NbrOfRooms = cmbRooms.Text
            Roombookingdto.MealId = cmbMeal.SelectedValue
            Roombookingdto.TotalAmount = lblTotalAmountt.Text.ToString
            Roombookingdto.Discount = txtDiscount.Text
            Roombookingdto.BookingId = bookingid
            Dim res = roombookingbl.EditRoomBooking(Roombookingdto)
            If res Then
                MsgBox("Update successfully")
            Else
                MsgBox("Retry")

            End If

        End If
    End Sub

    ''' <summary>
    ''' Description:This method is use to delete exixsting record from RoomBookingDetails table
    ''' </summary>
    ''' <param name="Sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDelete_Click(Sender As Object, e As EventArgs) Handles btnDelete.Click


        'obj of RoomBookingBl & Dto 
        Dim roombookingdto As New RoomBookingDetailsDTO
        Dim roombookingbl As New RoomBookingDetailsBL

        ' obj of BookingBl and dto 
        Dim Bookingdto As New BookingDTO
        Dim bookingbl As New BookingBL
        Bookingdto.BookingCode = txtBookingCode.Text
        Dim bookingid As Integer = GetBookingId(Bookingdto.BookingCode)

        Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo)

        If dialogResult = DialogResult.Yes Then

            roombookingdto.BookingId = bookingid
            Dim result = roombookingbl.DeleteRoomBooking(roombookingdto)

            If result Then
                MsgBox("Deleted Successfully")
            Else
                MsgBox("retry")
            End If

        End If




    End Sub


    Private Sub btnRoomDetails_Click(sender As Object, e As EventArgs) Handles btnRoomDetails.Click
        If pnlRoomDetails.Visible = True Then
            pnlRoomDetails.Visible = False
        Else
            pnlRoomDetails.Visible = True

        End If

    End Sub

    Private Sub btnAddress_Click(sender As Object, e As EventArgs) Handles btnAddress.Click

    End Sub

    Private Sub btnVehicleInformation_Click(sender As Object, e As EventArgs) Handles btnVehicleInformation.Click

    End Sub

    Private Sub btnPersonalInfromation_Click(sender As Object, e As EventArgs) Handles btnPersonalInfromation.Click

    End Sub

#End Region

#Region "Events "
    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        CalculateTotalAmount()

        Dim selectedRoomTypeId As Integer = (cmbCategory.SelectedValue)
        cmbRooms.Items.Clear()
        GetRoomsNumber(selectedRoomTypeId)
        getPrice(selectedRoomTypeId)

        Dim selectedRoomType As Integer = (cmbCategory.SelectedValue)
        Dim roomPrice As Integer = getPrice(selectedRoomType)
        lblRoomAmount.Text = roomPrice
    End Sub
    Private Sub cmbMeal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMeal.SelectedIndexChanged
        CalculateTotalAmount()

        Dim selectedMeal As Integer = (cmbMeal.SelectedValue)
        getMealPrice(selectedMeal)

        cmbRooms.Items.Clear()

        Dim selectedMealType As Integer = (cmbMeal.SelectedValue)

        Dim Mealprice As Integer = getMealPrice(selectedMealType)

        lblMealAmount.Text = Mealprice.ToString

    End Sub

    Private Sub cmbRooms_SelectionIndexChanged(sender As Object, e As EventArgs) Handles cmbRooms.SelectedIndexChanged
        CalculateTotalAmount()
    End Sub

    Private Sub dgvRoomRight_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvRoomRight.RowHeaderMouseClick

        btnUpdate.Visible = True
        btnDelete.Visible = True

        If e.RowIndex >= 0 Then

            lblTotalAmountt.Text = dgvRoomRight.Rows(e.RowIndex).Cells("TotalAmount").Value.ToString
            cmbRooms.Text = dgvRoomRight.Rows(e.RowIndex).Cells("NbrOfRooms").Value.ToString
            txtDiscount.Text = dgvRoomRight.Rows(e.RowIndex).Cells("Discount").Value.ToString
            cmbCategory.Text = dgvRoomRight.Rows(e.RowIndex).Cells("Type").Value.ToString
            cmbMeal.Text = dgvRoomRight.Rows(e.RowIndex).Cells("MealType").Value.ToString
            txtBookingCode.Text = dgvRoomRight.Rows(e.RowIndex).Cells("BookingCode").Value.ToString
            dtpCheckIn.Value = dgvRoomRight.Rows(e.RowIndex).Cells("CheckInDate").Value.ToString
            dtpCheckOut.Value = dgvRoomRight.Rows(e.RowIndex).Cells("CheckOutDate").Value.ToString

        End If
    End Sub


#End Region


    Private Sub txtVehicleName_TextChanged(sender As Object, e As EventArgs) Handles txtVehicleName.TextChanged

    End Sub

    Private Sub pnlRoomRight_Paint(sender As Object, e As PaintEventArgs) Handles pnlRoomRight.Paint

    End Sub

    Private Sub pnlContainer_Paint(sender As Object, e As PaintEventArgs) Handles pnlContainer.Paint

    End Sub
End Class
