<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenDashControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pnlAcNextMid = New Panel()
        SuspendLayout()
        ' 
        ' pnlAcNextMid
        ' 
        pnlAcNextMid.AutoScroll = True
        pnlAcNextMid.BackColor = Color.White
        pnlAcNextMid.Dock = DockStyle.Fill
        pnlAcNextMid.Location = New Point(0, 0)
        pnlAcNextMid.Name = "pnlAcNextMid"
        pnlAcNextMid.Size = New Size(949, 559)
        pnlAcNextMid.TabIndex = 1
        ' 
        ' AddBookingControlNext
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(pnlAcNextMid)
        Name = "AddBookingControlNext"
        Size = New Size(949, 559)
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlAcNextMid As Panel
End Class
