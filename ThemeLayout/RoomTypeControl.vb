Public Class RoomTypeControl

    Private Sub addcontrol(user As UserControl)
        pnlRoomTypeControl.Controls.Clear()
        user.Dock = DockStyle.Fill
        pnlRoomTypeControl.Controls.Add(user)
        user.BringToFront()
        user.Show()

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim add As New RoomTypeAddControl
        addcontrol(add)

    End Sub
End Class
