Imports System.Data

''' <summary>
''' Description: this class is use to get RoomTypes from RoomType table and pass into roomType bl
''' Created Date:29/11/2023
''' createed by: gaurav baloni
''' </summary>
Public Class RoomTypeDAL


    ''' <summary>
    ''' Description: this  fun is use to get Roomtypes from roomtype table and return the data in their respective bl functions   
    ''' </summary>
    ''' <returns></returns>
    Public Function GetRoomTypes()

        Try
            Dim sql As New SqlHelper
            Dim ds As New DataSet
            Dim query As String = "GetRoomType"   ' sp 
            sql.CreateTable(ds, query, "RoomType", True, False)
            If Not ds Is Nothing AndAlso Not ds.Tables Is Nothing AndAlso ds.Tables.Contains("RoomType") Then

                Dim Book = ds.Tables("RoomType")

                Return Book
            End If

        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    ''' <summary>
    ''' Description: this fun is use to get roomtype numbers from table and pass in Roomtypebl 
    ''' </summary>
    ''' <param name="key"></param>
    ''' <returns></returns>
    Public Function GetRoomsCount(key As String)
        Try
            Dim sql As New SqlHelper
            Dim ds As New DataSet
            Dim query As String = "GetRoomCount"   ' sp 
            sql.BuildParameter("@RoomTypeId", SqlDbType.SmallInt, "In", 100, key, True)
            sql.CreateTable(ds, query, "Room", True, False)
            If Not ds Is Nothing AndAlso Not ds.Tables Is Nothing AndAlso ds.Tables.Contains("Room") Then

                Dim Book = ds.Tables("Room")

                Return Book

            End If
        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    ''' <summary>
    ''' this function is used for get price of rooms from tabele and pass into bl functions 
    ''' </summary>
    ''' <param name="key"></param>
    ''' <returns></returns>
    Public Function GetPrice(key As String)
        Try
            Dim ds As New DataSet
            Dim sql As New SqlHelper
            Dim query As String = "GetRoomPrice"   ' sp 
            sql.BuildParameter("@RoomTypeId", SqlDbType.SmallInt, "In", 100, key, True)
            sql.CreateTable(ds, query, "RoomType", True, False)
            If Not ds Is Nothing AndAlso Not ds.Tables Is Nothing AndAlso ds.Tables.Contains("RoomType") Then

                Dim Book = ds.Tables("RoomType")

                Return Book

            End If
        Catch ex As Exception

        End Try

        Return Nothing
    End Function
End Class
