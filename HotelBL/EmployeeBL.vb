Imports AutoMapper
Imports HotelDAL
Imports HotelDTO

Public Class EmployeeBL

    Dim mapper As New Mapper(configuration:=New MapperConfiguration(Function(config)
                                                                        config.CreateMap(Of EmployeeModel, EmployeeDTO).ReverseMap()
                                                                        Return Nothing

                                                                    End Function))

    Public Function AddEmployee(employeedto As EmployeeDTO)

        Dim employeedal As New EmployeeDAL
        Dim mapped = mapper.Map(Of EmployeeModel)(employeedto)
        Dim result = employeedal.AddEmployee(mapped)
        Return result
    End Function

    Public Function GetRole()
        Dim employeedal As New EmployeeDAL
        Dim result = employeedal.GetRole()
        Return result

    End Function

    Public Function GetEmployee()
        Dim employeedal As New EmployeeDAL
        Dim result = employeedal.GetEmployee
        Return result

    End Function


    Public Function LoginEmployee(username As String, password As String)
        Dim employeedal As New EmployeeDAL
        Dim result = employeedal.LoginEmployee(username, password)
        Return result

    End Function
End Class
