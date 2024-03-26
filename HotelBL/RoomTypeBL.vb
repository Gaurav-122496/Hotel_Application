Imports HotelDAL


''' <summary>
''' Description:this class is used for get and set data in RoomTypeDal 
''' CreatedBy : Gaurav Baloni 
''' Created Date: 29/11/2023
''' </summary>
Public Class RoomTypeBL

    ''' <summary>
    ''' this function is used to get RoomType From RoomTypeDal 
    ''' </summary>
    ''' <returns></returns>
    Public Function GetRoomType()
        Dim dl As New RoomTypeDAL
        Dim result = dl.GetRoomTypes()
        Return result

    End Function

    ''' <summary>
    ''' Description: this function is use to get number of particular roomtype
    ''' </summary>
    ''' <param name="key"></param>
    ''' <returns></returns>
    Public Function GetRoomCount(key As String)
        Dim dl As New RoomTypeDAL
        Dim resultcount = dl.GetRoomsCount(key)
        Return resultcount

    End Function

    ''' <summary>
    '''Descrioption: get price of Roomtype from roomtype table 
    ''' </summary>
    ''' <param name="key"></param>
    ''' <returns></returns>
    Public Function Getprice(key As String)
        Dim dl As New RoomTypeDAL
        Dim result = dl.GetPrice(key)
        Return result

    End Function
End Class
