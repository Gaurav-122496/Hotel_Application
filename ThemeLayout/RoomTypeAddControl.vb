Public Class RoomTypeAddControl
    Private Sub addcontrol(user As UserControl)
        pnlRoomTypeAddControl.Controls.Clear()
        user.Dock = DockStyle.Fill
        pnlRoomTypeAddControl.Controls.Add(user)
        user.BringToFront()
        user.Show()

    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim room As New RoomTypeControl
        addcontrol(room)

    End Sub
End Class
