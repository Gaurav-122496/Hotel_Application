Imports HotelDAL
Imports HotelDTO

Public Class MappingProfile
    Inherits AutoMapper.Profile

    Protected Sub New()
        CreateMap(Of CustomerModel, CustomerDTO).ReverseMap()
    End Sub
End Class
