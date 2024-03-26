<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookedHalls
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
        pnlBookedHalls = New Panel()
        dgvBookedHals = New DataGridView()
        pnlBookedHalls.SuspendLayout()
        CType(dgvBookedHals, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlBookedHalls
        ' 
        pnlBookedHalls.BackColor = Color.White
        pnlBookedHalls.Controls.Add(dgvBookedHals)
        pnlBookedHalls.Dock = DockStyle.Fill
        pnlBookedHalls.Location = New Point(0, 0)
        pnlBookedHalls.Name = "pnlBookedHalls"
        pnlBookedHalls.Size = New Size(944, 567)
        pnlBookedHalls.TabIndex = 1
        ' 
        ' dgvBookedHals
        ' 
        dgvBookedHals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBookedHals.BackgroundColor = Color.White
        dgvBookedHals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBookedHals.Dock = DockStyle.Bottom
        dgvBookedHals.GridColor = Color.White
        dgvBookedHals.Location = New Point(0, 120)
        dgvBookedHals.Name = "dgvBookedHals"
        dgvBookedHals.RowTemplate.Height = 25
        dgvBookedHals.Size = New Size(944, 447)
        dgvBookedHals.TabIndex = 3
        ' 
        ' BookedHalls
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlBookedHalls)
        Name = "BookedHalls"
        Size = New Size(944, 567)
        pnlBookedHalls.ResumeLayout(False)
        CType(dgvBookedHals, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlBookedHalls As Panel
    Friend WithEvents dgvBookedHals As DataGridView
End Class
