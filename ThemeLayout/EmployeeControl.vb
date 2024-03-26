Imports HotelBL
Imports HotelDTO

Public Class EmployeeControl

#Region "Methods"


    Private Sub EmployeeControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetRole()

        dgvEmployee.Width = pnlEmployee.Width / 2

    End Sub
    Public Function GetRole()
        Dim employeebl As New EmployeeBL
        Dim result As DataTable = employeebl.GetRole()
        Dim dr As DataRow
        dr = result.NewRow
        dr.ItemArray = New Object() {0, "--Select Role--"}
        result.Rows.InsertAt(dr, 0)
        cmbRole.ValueMember = "RoleId"
        cmbRole.DisplayMember = "RoleType"
        cmbRole.DataSource = result
        Return Nothing

    End Function


    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        Dim selectedroleid As Integer = cmbRole.SelectedValue

    End Sub

    ''' <summary>
    ''' Desccription: this method is  use to add employee record in Employee table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim employeebl As New EmployeeBL
        Dim employeedto As New EmployeeDTO

        employeedto.FirstName = txtFirstName.Text
        employeedto.MiddleName = txtMiddleName.Text
        employeedto.LastName = txtLastName.Text
        employeedto.UserNmae = txtUserName.Text
        employeedto.Password = txtPassword.Text
        employeedto.RoleID = cmbRole.SelectedValue
        employeedto.CreatedDate = dtpCreatedDate.Value
        Dim result = employeebl.AddEmployee(employeedto)

        If result Then
            MsgBox("Saved Successfully")

        Else
            MsgBox("oops something went wrong")
        End If

        Dim employeebll As New EmployeeBL
        Dim res = employeebll.GetEmployee
        dgvEmployee.DataSource = res

    End Sub


#End Region
End Class
