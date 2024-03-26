Imports System.Data


''' <summary>
''' Description: this class is used to get & set record in RoomBookingDetails 
''' Created Date: 28/11/2023
''' Created By : Gaurav Baloni
''' </summary>
Public Class RoomBookingDetailsDAL


    ''' <summary>
    ''' this function is used for insert data in roombooking table and send response to roombookingbl class 
    ''' </summary>
    ''' <param name="book"></param>
    ''' <returns></returns>

    Public Function AddRoomBooking(book As RoomBookingDetailsModel)
        Dim sql As New SqlHelper
        Try
            '  Dim query As String = "Insert Into [RoomBooking](RoomTypeId,Adults,Kids,CheckInDate,CheckOutDate,PricePerNight,CouponId,CouponAmount,PaymentStatus) Values(@RoomTypeId,@Adults,@Kids,@CheckInDate,@CheckOutDate,@PricePerNight,@CouponId,@CouponAmount,@PaymentStatus)"

            Dim query As String = "AddRoomBooking"
            sql.BuildParameter("@RoomTypeId", SqlDbType.SmallInt, "In", 100, book.RoomTypeId)
            sql.BuildParameter("@CheckInDate", SqlDbType.DateTime, "In", 100, book.CheckInDate)
            sql.BuildParameter("@CheckoutDate", SqlDbType.DateTime, "In", 100, book.CheckOutDate)
            sql.BuildParameter("@Adults", SqlDbType.SmallInt, "In", 10, book.Adults)
            sql.BuildParameter("@Kids", SqlDbType.SmallInt, "In", 10, book.Kids)
            sql.BuildParameter("@MealId", SqlDbType.SmallInt, "In", 10, book.MealId)
            sql.BuildParameter("@NbrOfRooms", SqlDbType.Int, "In", 100, book.NbrOfRooms)
            sql.BuildParameter("@TotalAmount", SqlDbType.Money, "In", 100, book.TotalAmount)
            sql.BuildParameter("@Discount", SqlDbType.Money, "In", 100, book.Discount)
            sql.BuildParameter("@BookingId", SqlDbType.SmallInt, "In", 100, book.BookingId)
            Dim result As Boolean = sql.ExecuteNonQuery(query, IsStoredProcedure:=True)

            Return result
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing

    End Function

    ''' <summary>
    ''' this function is used for update the existing record in roombooking table
    ''' </summary>
    ''' <param name="Booking"></param>
    ''' <returns></returns>
    Public Function EditRoomBooking(Booking As RoomBookingDetailsModel)
        Try
            Dim sql As New SqlHelper
            Dim query As String = "UpdateRoomBookingDetails"  'sp 
            sql.BuildParameter("@RoomTypeId", SqlDbType.SmallInt, "In", 100, Booking.RoomTypeId)
            sql.BuildParameter("@CheckInDate", SqlDbType.DateTime, "In", 100, Booking.CheckInDate)
            sql.BuildParameter("@CheckoutDate", SqlDbType.DateTime, "In", 100, Booking.CheckOutDate)
            sql.BuildParameter("@Adults", SqlDbType.SmallInt, "In", 10, Booking.Adults)
            sql.BuildParameter("@Kids", SqlDbType.SmallInt, "In", 10, Booking.Kids)
            sql.BuildParameter("@MealId", SqlDbType.SmallInt, "In", 10, Booking.MealId)
            sql.BuildParameter("@NbrOfRooms", SqlDbType.Int, "In", 100, Booking.NbrOfRooms)
            sql.BuildParameter("@TotalAmount", SqlDbType.Money, "In", 100, Booking.TotalAmount)
            sql.BuildParameter("@Discount", SqlDbType.Money, "In", 100, Booking.Discount)
            sql.BuildParameter("@BookingId", SqlDbType.SmallInt, "In", 100, Booking.BookingId)

            Dim result As Boolean = sql.ExecuteNonQuery(query, IsStoredProcedure:=True)

            Return result

        Catch ex As Exception

        End Try
        Return Nothing
    End Function


    ''' <summary>
    ''' Description: this function hepls to delete the existing record in RoomBookingDetails tabele
    ''' </summary>
    ''' <param name="booking"></param>
    ''' <returns></returns>
    Public Function DeleteRoomBooking(booking As RoomBookingDetailsModel)
        Try
            Dim sql As New SqlHelper
            Dim query As String = "DeleteRoomBookingDetails"   ' sp
            sql.BuildParameter("@BookingId", SqlDbType.SmallInt, "In", 100, booking.BookingId)
            Dim result As Boolean = sql.ExecuteNonQuery(query, IsStoredProcedure:=True)

            Return result
        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    ''' <summary>
    ''' Description: this function is use to show data in booking rooms  grid from RoomBookingDetails tables
    ''' </summary>
    ''' <returns></returns>
    Public Function GetBooking()
        Dim sql As New SqlHelper
        Try
            Dim ds As New DataSet
            Dim query As String = "GetRoomBooking" ' sp 
            sql.CreateTable(ds, query, "RoomBookingDetails", True, False)

            If Not ds Is Nothing AndAlso Not ds.Tables Is Nothing AndAlso ds.Tables.Contains("RoomBookingDetails") Then

                Dim Book = ds.Tables("RoomBookingDetails")
                Return Book

            End If

        Catch ex As Exception

        End Try
        Return Nothing

    End Function

    ''' <summary>
    ''' Description this function is use to get data in booking grid of three tabels RoomBookingDetails,Vehicle,Customer Table
    ''' </summary>
    ''' <returns></returns>
    Public Function ShowData()
        Dim sql As New SqlHelper
        Try
            Dim ds As New DataSet

            Dim query As String = "" ' sp 
            sql.CreateTable(ds, query, "RoomBookingDetails", True, False)
            If Not ds Is Nothing AndAlso Not ds.Tables Is Nothing AndAlso ds.Tables.Contains("RoomBookingDetails") Then
                Dim Book = ds.Tables("RoomBookingDetails")

                Return Book
            End If
        Catch ex As Exception

        End Try
        Return Nothing

    End Function

    ''' <summary>
    ''' Description: this function is use to show details in guest registration grid data of with help of joins 
    ''' </summary>
    ''' <returns></returns>
    Public Function GetRoomDetails(key As String)

        Try
            Dim sql As New SqlHelper
            Dim ds As New DataSet
            Dim query As String = "GetRoomDetails"  'sp 
            sql.BuildParameter("@BookingId", SqlDbType.SmallInt, "In", 100, key)
            sql.CreateTable(ds, query, "RoomBookingDetails", True, False)
            If Not ds Is Nothing AndAlso Not ds.Tables Is Nothing AndAlso ds.Tables.Contains("RoomBookingDetails") Then
                Dim booking = ds.Tables("RoomBookingDetails")

                Return booking

            End If
        Catch ex As Exception

        End Try
        Return Nothing
    End Function



End Class
