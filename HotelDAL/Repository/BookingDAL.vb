Imports System.Data

Public Class BookingDAL

    Public Function AddBooking(booking As BookingModel)
        Try
            Dim sql As New SqlHelper

            Dim query As String = "AddBooking"  'sp 

            sql.BuildParameter("@BookingCode", SqlDbType.NVarChar, "In", 50, booking.BookingCode, True)
            Dim result As String = sql.ExecuteNonQuery(query, IsStoredProcedure:=True)

            Return result

        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    Public Function GetBookingId(key As String)
        Try
            Dim sql As New SqlHelper
            Dim ds As New DataSet
            Dim query As String = "GetBookingId"

            sql.BuildParameter("@BookingCode", SqlDbType.NVarChar, "In", 50, key, True)
            sql.CreateTable(ds, query, "Booking", True, False)
            If Not ds Is Nothing AndAlso Not ds.Tables Is Nothing AndAlso ds.Tables.Contains("Booking") Then
                Dim booking = ds.Tables("Booking")

                Return booking

            End If
        Catch ex As Exception

        End Try
        Return Nothing
    End Function

End Class
