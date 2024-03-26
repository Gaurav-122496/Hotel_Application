Imports System.Data

Public Class MealDAL
    Public Function GetMeal()

        Try
            Dim sql As New SqlHelper
            Dim ds As New DataSet
            Dim query As String = "GetMeal"   ' sp 
            sql.CreateTable(ds, query, "Meal", True, False)
            If Not ds Is Nothing AndAlso Not ds.Tables Is Nothing AndAlso ds.Tables.Contains("Meal") Then

                Dim Meal = ds.Tables("Meal")

                Return Meal
            End If

        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    Public Function GetMealPrice(key As String)
        Try
            Dim sql As New SqlHelper
            Dim ds As New DataSet
            Dim query As String = "GetMealPrice"   ' sp 
            sql.BuildParameter("@MealId", SqlDbType.SmallInt, "In", 100, key, True)

            sql.CreateTable(ds, query, "Meal", True, False)
            If Not ds Is Nothing AndAlso Not ds.Tables Is Nothing AndAlso ds.Tables.Contains("Meal") Then

                Dim Meal = ds.Tables("Meal")

                Return Meal
            End If

        Catch ex As Exception

        End Try
        Return Nothing
    End Function
End Class
