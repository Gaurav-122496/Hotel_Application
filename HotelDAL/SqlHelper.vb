Imports System.Data
Imports System.Data.SqlClient

Public Class SqlHelper
    Private parameters As New ArrayList



    Dim connectionString As String = "Data Source=LENOVO\MSSQLSERVER01;Initial Catalog=HTM;Integrated Security=True"

    ''' <summary>
    ''' created a function ExecuteNonQuery which takes a string as parameter and returns the number of rows affected.
    ''' </summary>
    ''' <param name="query"></param>
    ''' <returns></returns>

    Public Function ExecuteNonQuery(query As String, Optional ByVal IsStoredProcedure As Boolean = True) As Boolean
        Try
            Dim rowsAffected As Boolean

            Dim con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand(query, con)

            cmd.CommandType = If(IsStoredProcedure, CommandType.StoredProcedure, CommandType.Text)

            If parameters.Count > 0 Then

                For Each param In parameters
                    cmd.Parameters.Add(param)
                Next

            End If


            rowsAffected = cmd.ExecuteNonQuery()

            con.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function



    ''' <summary>
    ''' this is the executeScalar method ....it takes 'SELECT' command as query and returns an object  .
    ''' to view how many rows are there in the table count the no of times the method has been called(done in userDAl class)
    ''' </summary>
    ''' <param name="query"></param>
    ''' <returns></returns>
    Public Function ExecuteScalar(query As String, Optional IsStoredProcedure As Boolean = False) As Integer
        Try
            Dim con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand(query, con)
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            Return result
            con.Close()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Sub BuildParameter(ByVal paramName As String, ByVal paramType As SqlDbType, ByVal ParamInOut As String, ByVal size As Integer, Optional ByVal value As String = "", Optional ByVal ClearParameters As Boolean = False)

        Dim param As New SqlParameter()
        Dim l_type As Type
        Try

            If ClearParameters = True Then
                Me.parameters.Clear()
            End If

            If Not paramName.StartsWith("@") Then
                paramName = String.Concat("@", paramName)
            End If
            param.ParameterName = paramName

            If paramType = SqlDbType.Int Then
                param.DbType = DbType.Int32
                l_type = GetType(Integer)

            ElseIf paramType = SqlDbType.DateTime Then
                param.DbType = DbType.Date
                l_type = GetType(DateTime)

            ElseIf paramType = SqlDbType.BigInt Then
                param.DbType = DbType.Int64
                l_type = GetType(Long)

            ElseIf paramType = SqlDbType.Bit Then
                param.DbType = DbType.Boolean
                l_type = GetType(Boolean)

            ElseIf paramType = SqlDbType.Char Then
                param.DbType = DbType.String
                l_type = GetType(String)

            ElseIf paramType = SqlDbType.Date Then
                param.DbType = DbType.Date
                l_type = GetType(Date)

            ElseIf paramType = SqlDbType.DateTime Then
                param.DbType = DbType.DateTime
                l_type = GetType(DateTime)

            ElseIf paramType = SqlDbType.Decimal Then
                param.DbType = DbType.Double
                l_type = GetType(Double)

                '  ElseIf paramType = SqlDbType.Float Then
                '     param.DbType = DbType.Currency
                '    l_type = GetType(Currency)
                '
                ' ElseIf paramType = SqlDbType.Money Then
                '    param.DbType = DbType.Currency
                '   l_type = GetType(Currency)

            ElseIf paramType = SqlDbType.NChar Then
                param.DbType = DbType.String
                l_type = GetType(String)

            ElseIf paramType = SqlDbType.NText Then
                param.DbType = DbType.String
                l_type = GetType(String)

            ElseIf paramType = SqlDbType.NVarChar Then
                param.DbType = DbType.String
                l_type = GetType(String)

            ElseIf paramType = SqlDbType.VarChar Then
                param.DbType = DbType.String
                l_type = GetType(String)

            End If

            param.Size = size

            Select Case ParamInOut
                Case "In"
                    param.Direction = ParameterDirection.Input
                    param.Value = value
                    'param.Value = UserDAL.CommonUtility.GetValue(value, l_type, False)

                Case "Out"
                    param.Direction = ParameterDirection.Output
            End Select

            parameters.Add(param)
        Catch ex As Exception


        End Try
    End Sub

    Public Sub CreateTable(ByVal dsTrk As DataSet, ByVal vSQL As String, ByVal vTable As String,
                           Optional ByVal IsStoredProcedure As Boolean = True,
                          Optional ByVal IsUpdate As Boolean = False)
        Try
            ' Dim SqlBuilder1 As SqlCommandBuilder
            Using conn As New SqlConnection(connectionString)
                Using sqlComm As New SqlCommand
                    Try

                        If dsTrk.Tables.Contains(vTable) = True And IsUpdate = False Then
                            dsTrk.Tables.Remove(vTable)
                        End If
                        Try
                            If IsStoredProcedure = True Then
                                sqlComm.CommandType = CommandType.StoredProcedure
                            Else
                                sqlComm.CommandType = CommandType.Text
                            End If

                            sqlComm.CommandText = vSQL
                            sqlComm.Connection = conn
                            sqlComm.Parameters.Clear()

                            If parameters.Count > 0 Then
                                For Each param As SqlParameter In parameters
                                    sqlComm.Parameters.Add(param)
                                Next
                                Me.parameters.Clear()
                            End If

                            Using da As New SqlDataAdapter(sqlComm)
                                Try
                                    'Dim da As New SqlDataAdapter(vSQL, m_ConnectionString)
                                    '' Code for Update
                                    If IsUpdate = True Then
                                        Using SqlBuilder As New SqlCommandBuilder(da)
                                            SqlBuilder.ConflictOption = ConflictOption.OverwriteChanges
                                            da.Update(dsTrk, vTable)
                                            sqlComm.Parameters.Clear()
                                            parameters.Clear()
                                        End Using
                                    Else
                                        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
                                        da.Fill(dsTrk, vTable)
                                        Dim dt As New DataTable
                                        dt = dsTrk.Tables(vTable)
                                        sqlComm.Parameters.Clear()
                                        parameters.Clear()
                                    End If

                                    'da = Nothing
                                    sqlComm.Parameters.Clear()
                                    parameters.Clear()

                                Catch ex As Exception

                                End Try
                            End Using
                            '  parameters = Nothing
                            sqlComm.Parameters.Clear()

                        Catch ex As Exception

                        End Try
                    Catch ex As Exception

                    End Try
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub


End Class
