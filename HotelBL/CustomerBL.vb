Imports HotelDTO
Imports AutoMapper
Imports HotelDAL


Public Class CustomerBL


    Dim mapper As New Mapper(configuration:=New MapperConfiguration(Function(config)

                                                                        config.CreateMap(Of CustomerModel, CustomerDTO).ReverseMap()
                                                                        Return Nothing
                                                                    End Function))

    Public Function AddCustomer(DTO As CustomerDTO)
        Dim dl As New CustomerDAL()
        Dim mappedcustomer = mapper.Map(Of CustomerModel)(DTO)
        Dim result = dl.AddCustomer(mappedcustomer)
        Return result

    End Function

    Public Function GetCustomer()
        Dim dl As New CustomerDAL
        Dim result = dl.GetCustomer
        Return result


    End Function
    Public Function ShowPanel()
        Dim dl As New CustomerDAL
        Dim result = dl.showPanel
        Return result

    End Function


End Class
