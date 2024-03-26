Imports AutoMapper
Imports HotelDTO
Imports HotelDAL
Public Class VehicleBL


    Dim mapper As New Mapper(configuration:=New MapperConfiguration(Function(config)

                                                                        config.CreateMap(Of VehicleModel, VehicleDTO).ReverseMap()
                                                                        Return Nothing
                                                                    End Function))

    Public Function AddVehicleInfo(dto As VehicleDTO)
        Try
            Dim dl As New VehicleDAL
            Dim mapped = mapper.Map(Of VehicleModel)(dto)
            Dim result = dl.AddVehicleInfo(mapped)
            Return result

        Catch ex As Exception
        End Try
        Return Nothing

    End Function
End Class
