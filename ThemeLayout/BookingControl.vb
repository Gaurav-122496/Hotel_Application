Public Class BookingControl
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    'End Sub
    Private Sub addusercontrol(usercontrol As UserControl)
        If pnlBookingControlMid.Controls.Contains(usercontrol) Then
            usercontrol.BringToFront()
            usercontrol.Show()


        Else

            pnlBookingControlMid.Controls.Clear()
            usercontrol.Dock = DockStyle.Fill
            pnlBookingControlMid.Controls.Add(usercontrol)
            usercontrol.BringToFront()
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim uc As New AddBookingControl
        addusercontrol(uc)
    End Sub


    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookingControl.CellContentClick

    'End Sub

End Class
