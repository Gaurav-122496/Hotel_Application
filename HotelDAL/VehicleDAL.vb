Imports System.Data
Public Class VehicleDAL


    Public Function AddVehicleInfo(model As VehicleModel)

        Dim sql As New SqlHelper
        Try
            'Dim query As String = "insert Into [VehicleTbl](VehicleCompany,VehicleName,VehicleNumber,State,City,Pincode) Values(@VehicleCompany,@VehicleName,@VehicleNumber,@State,@City,@Pincode)"
            Dim query As String = "AddVehicle" 'sp 
            sql.BuildParameter("@VehicleCompany", SqlDbType.NVarChar, "In", 100, model.VehicleCompany)
            sql.BuildParameter("@VehicleName", SqlDbType.NVarChar, "In", 100, model.VehicleName)
            sql.BuildParameter("@VehicleNumber", SqlDbType.NVarChar, "In", 50, model.VehicleNumber)
            sql.BuildParameter("@State", SqlDbType.NVarChar, "In", 100, model.State)
            sql.BuildParameter("@city", SqlDbType.NVarChar, "In", 100, model.City)
            sql.BuildParameter("@Pincode", SqlDbType.NVarChar, "In", 50, model.Pincode)

            Dim result As Boolean = sql.ExecuteNonQuery(query, IsStoredProcedure:=True)

            Return result


        Catch ex As Exception

        End Try
        Return Nothing

    End Function

End Class
