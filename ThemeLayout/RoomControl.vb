Public Class RoomControl


    Private Sub addcontrol(user As UserControl)
        pnlRoomControl.Controls.Clear()
        user.Dock = DockStyle.Fill
        pnlRoomControl.Controls.Add(user)
        user.BringToFront()
        user.Show()

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim room As New RoomAddControl
        addcontrol(room)

    End Sub
End Class
