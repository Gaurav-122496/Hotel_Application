Imports System.Data

''' <summary>
''' Description: this class is use to insert data in employee table
''' </summary>

Public Class EmployeeDAL

    Public Function AddEmployee(employeemodel As EmployeeModel)
        Try
            Dim sql As New SqlHelper
            Dim query As String = "AddEmployee"  ' sp 
            sql.BuildParameter("@FirstName", SqlDbType.NVarChar, "In", 100, employeemodel.FirstName, True)
            sql.BuildParameter("MiddleName", SqlDbType.NVarChar, "In", 100, employeemodel.MiddleName)
            sql.BuildParameter("@LastName", SqlDbType.NVarChar, "In", 100, employeemodel.LastName)
            sql.BuildParameter("@UserName", SqlDbType.NVarChar, "In", 100, employeemodel.UserNmae)
            sql.BuildParameter("@Password", SqlDbType.NVarChar, "In", 100, employeemodel.Password)
            sql.BuildParameter("@RoleId", SqlDbType.SmallInt, "In", 100, employeemodel.RoleId)
            sql.BuildParameter("@CreatedDate", SqlDbType.DateTime, "In", 100, employeemodel.CreatedDate)
            Dim result As Boolean = sql.ExecuteNonQuery(query, IsStoredProcedure:=True)
            Return result

        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    Public Function GetRole()
        Try
            Dim sql As New SqlHelper
            Dim ds As New DataSet
            Dim query As String = "GetRole" 'sp

            sql.CreateTable(ds, query, "Role", True, False)

            If Not ds Is Nothing AndAlso Not ds.Tables Is Nothing AndAlso ds.Tables.Contains("Role") Then
                Dim result = ds.Tables("Role")
                Return result

            End If
        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    Public Function GetEmployee()
        Try
            Dim sql As New SqlHelper
            Dim ds As New DataSet
            Dim query As String = "GetEmployee"   ' sp 
            sql.CreateTable(ds, query, "Employee", True, False)
            If Not ds Is Nothing AndAlso Not ds.Tables Is Nothing AndAlso ds.Tables.Contains("Employee") Then
                Dim employee = ds.Tables("Employee")
                Return employee

            End If
        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    Public Function LoginEmployee(username As String, password As String)
        Dim sql As New SqlHelper
        Dim ds As New DataSet
        Dim query As String = "ValidateUser"  'sp 
        sql.BuildParameter("@UserName", SqlDbType.NVarChar, "In", 100, username, True)
        sql.BuildParameter("@Password", SqlDbType.NVarChar, "In", 100, password)
        sql.CreateTable(ds, query, "Employee", True, False)
        If Not ds Is Nothing AndAlso Not ds.Tables Is Nothing AndAlso ds.Tables.Contains("Employee") Then
            Dim employee = ds.Tables("Employee")
            If employee.Rows.Count > 0 Then
                Return True
            Else
                Return False


            End If

        End If
        Return Nothing

    End Function

End Class
