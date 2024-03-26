Imports AutoMapper
Imports HotelDTO
Imports HotelDAL


''' <summary>
''' Description : this class is used to get and set  records in RoomBookingDetails
''' created by : Gaurav Baloni 
''' Created Date : 28/11/2023
''' </summary>
Public Class RoomBookingDetailsBL


    Dim mapper As New Mapper(configuration:=New MapperConfiguration(Function(config)
                                                                        config.CreateMap(Of RoomBookingDetailsModel, RoomBookingDetailsDTO).ReverseMap()
                                                                        Return Nothing

                                                                    End Function))
    ''' <summary>
    ''' this function is used for pass the data into Roombookingdal class and insert data to RoomBookingtable 
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <returns></returns>
    Public Function AddRoomBooking(dt As RoomBookingDetailsDTO)
        Try

            Dim dl As New RoomBookingdetailsDAL
            Dim mapped = mapper.Map(Of RoomBookingDetailsModel)(dt)
            Dim result = dl.AddRoomBooking(mapped)
            Return result
        Catch ex As Exception

        End Try

        Return Nothing

    End Function

    ''' <summary>
    ''' this function is used for updated the existing record from roombookingtable 
    ''' </summary>
    ''' <param name="roombookingdto"></param>
    ''' <returns></returns>
    Public Function EditRoomBooking(roombookingdto As RoomBookingDetailsDTO)
        Try
            Dim roombookingdal As New RoomBookingDetailsDAL
            Dim mapped = mapper.Map(Of RoomBookingDetailsModel)(roombookingdto)
            Dim result = roombookingdal.EditRoomBooking(mapped)
            Return result

        Catch ex As Exception
            Return Nothing

        End Try
    End Function

    ''' <summary>
    ''' Description: this function is use to pass any record in RoomBookingDetailsDal class and delete that record 
    ''' </summary>
    ''' <param name="Roombookingdto"></param>
    ''' <returns></returns>
    Public Function DeleteRoomBooking(Roombookingdto As RoomBookingDetailsDTO)
        Dim roombookingdal As New RoomBookingDetailsDAL
        Dim mapped = mapper.Map(Of RoomBookingDetailsModel)(Roombookingdto)
        Dim result = roombookingdal.DeleteRoomBooking(mapped)
        Return result

    End Function


    ''' <summary>
    '''  Description: this function is used to get table from Roombookingdal class and show in BookingRooms DataGrid
    ''' </summary>
    ''' <returns></returns>
    Public Function GetBooking()
        Dim dal As New RoomBookingdetailsDAL
        Dim result = dal.GetBooking
        Return result

    End Function

    ''' <summary>
    ''' Description: this function is use show data in Bookings grid of mutiples tabels and return tables
    ''' </summary>
    ''' <returns></returns>
    Public Function ShowData()
        Dim dl As New RoomBookingdetailsDAL
        Dim result = dl.showData
        Return result


    End Function

    ''' <summary>
    ''' Description: this function is use to show details in guest registration grid data of with help of joins 
    ''' </summary>
    ''' <returns></returns>

    Public Function GetRoomDetails(key As String)
        Dim dl As New RoomBookingDetailsDAL
        Dim result = dl.GetRoomDetails(key)
        Return result
    End Function

End Class
