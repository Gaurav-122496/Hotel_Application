Imports System.Data



Public Class CustomerDAL



    Public Function AddCustomer(CustomerModel As CustomerModel)


        Dim sql As New SqlHelper

        Try
            'Dim query As String = "Insert Into [Customer](FirstName,MiddleName,LastName,Address1,Address2,Phone1,Phone2,IdProff,Gender) Values (@FirstName,@MiddleName,@LastName,@Address1,@Address2,@Phone1,@Phone2,@IdProff,@Gender)"

            Dim query As String = "AddCustomer"  'sp 

            sql.BuildParameter("@FirstName", SqlDbType.NVarChar, "In", 100, CustomerModel.FirstName, True)
            sql.BuildParameter("@MiddleName", SqlDbType.NVarChar, "In", 100, CustomerModel.MiddleName)
            sql.BuildParameter("@LastName", SqlDbType.NVarChar, "In", 100, CustomerModel.LastName)
            sql.BuildParameter("@Address1", SqlDbType.NVarChar, "In", 200, CustomerModel.Address1)
            sql.BuildParameter("@Address2", SqlDbType.NVarChar, "In", 200, CustomerModel.Address2)
            sql.BuildParameter("@Phone1", SqlDbType.NVarChar, "In", 50, CustomerModel.Phone1)
            sql.BuildParameter("@Phone2", SqlDbType.NVarChar, "In", 50, CustomerModel.Phone2)
            sql.BuildParameter("@IdProff", SqlDbType.NVarChar, "In", 20, CustomerModel.IdProff)
            sql.BuildParameter("@Gender", SqlDbType.NVarChar, "In", 20, CustomerModel.Gender)
            Dim result As Boolean = sql.ExecuteNonQuery(query, IsStoredProcedure:=True)
            Return result



        Catch ex As Exception

        End Try


        Return Nothing
    End Function

    Public Function GetCustomer()
        Dim sql As New SqlHelper
        Try
            Dim ds As New DataSet
            Dim query As String = "ShowCustomer" ' sp 
            sql.CreateTable(ds, query, "Customer", True, False)
            If Not ds Is Nothing AndAlso Not ds.Tables Is Nothing AndAlso ds.Tables.Contains("Customer") Then

                Dim Book = ds.Tables("Customer")
                Return Book

            End If
        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    Public Function showPanel()
        Dim sql As New SqlHelper
        Try
            Dim query As String = "ShowDataPanel" 'sp 
            Dim result = sql.ExecuteScalar(query, True)
            Return result
        Catch ex As Exception

        End Try
        Return Nothing

    End Function




End Class
