Imports HotelBL

Public Class LoginPl


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    ''' <summary>
    ''' Description: this function is used to validate employee 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim username As String = txtUserName.Text.Trim

        Dim password As String = txtPassword.Text.Trim

        Dim employeebl As New EmployeeBL
        Dim result = employeebl.LoginEmployee(username, password)
        If result Then
            Form3.Show()
            Me.Hide()
        Else
            MsgBox("Enter Valid Details")

        End If

    End Sub
End Class
