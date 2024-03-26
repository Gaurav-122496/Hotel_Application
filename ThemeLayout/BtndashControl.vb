Imports HotelBL
Public Class BtndashControl



    Private Sub BtndashControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlLeft.Dock = DockStyle.Left
        pnlRight.Dock = DockStyle.Right
        pnlLeft.Width = pnlDashControl.Width / 2
        pnlRight.Width = pnlDashControl.Width / 2


        Dim bl As New CustomerBL
        Dim result = bl.ShowPanel
        For i As Integer = 1 To result
            Dim panel As New Panel()
            panel.Size = New Size(132, 102)
            panel.Location = New Point(0 + (i - 1) * 135, 190)
            panel.BackColor = Color.LightBlue
            pnlRight.Controls.Add(panel)
        Next
    End Sub

    Public Function addcontrol(user As UserControl)
        pnlDashControl.Controls.Clear()
        user.Top = False
        user.Dock = DockStyle.Fill
        pnlDashControl.Controls.Add(user)
        user.BringToFront()
        Return Nothing

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim add As New AddBookingControl
        addcontrol(add)

    End Sub

    'Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    'End Sub

End Class
