Public Class RoomAddControl
    Private Sub addcontrol(user As UserControl)
        pnlRoomAddControl.Controls.Clear()
        user.Dock = DockStyle.Fill
        pnlRoomAddControl.Controls.Add(user)
        user.BringToFront()
        user.Show()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim room As New RoomControl
        addcontrol(room)


    End Sub
End Class
