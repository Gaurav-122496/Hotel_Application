Imports HotelDAL

Public Class MealBL

    Public Function GetMeal()
        Dim dl As New MealDAL()
        Dim result = dl.GetMeal()
        Return result

    End Function
    Public Function GetMealPrice(key As String)
        Dim dl As New MealDAL
        Dim result = dl.GetMealPrice(key)
        Return result
    End Function
End Class
