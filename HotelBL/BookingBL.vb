Imports AutoMapper
Imports HotelDAL
Imports HotelDTO

Public Class BookingBL

    Dim mapper As New Mapper(configuration:=New MapperConfiguration(Function(config)
                                                                        config.CreateMap(Of BookingModel, BookingDTO).ReverseMap()
                                                                        Return Nothing

                                                                    End Function))
    Public Function AddBooking(bookingdto As BookingDTO)

        Try
            Dim bookingdal As New BookingDAL
            Dim mapped = mapper.Map(Of BookingModel)(bookingdto)
            Dim result = bookingdal.AddBooking(mapped)
            Return result
        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    Public Function GetBookingId(key As String)
        Try
            Dim bookingdal As New BookingDAL
            Dim result = bookingdal.GetBookingId(key)
            Return result
        Catch ex As Exception

        End Try

        Return Nothing

    End Function

End Class
