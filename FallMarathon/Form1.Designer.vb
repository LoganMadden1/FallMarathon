<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFallMarathon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTIme = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(656, 576)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(116, 127)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(77, 17)
        Me.lblStartTime.TabIndex = 2
        Me.lblStartTime.Text = "Start Time "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 418)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(394, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "For more information, view the Fall Marathon Facebook page."
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(355, 127)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(96, 17)
        Me.lblLocation.TabIndex = 4
        Me.lblLocation.Text = "Start Location"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(613, 127)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(72, 17)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Start Date"
        '
        'lblTIme
        '
        Me.lblTIme.AutoSize = True
        Me.lblTIme.Location = New System.Drawing.Point(124, 177)
        Me.lblTIme.Name = "lblTIme"
        Me.lblTIme.Size = New System.Drawing.Size(60, 17)
        Me.lblTIme.TabIndex = 6
        Me.lblTIme.Text = "8:00 AM"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(366, 177)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(74, 17)
        Me.lblStart.TabIndex = 7
        Me.lblStart.Text = "Ryan Park"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(602, 177)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(94, 17)
        Me.lblStartDate.TabIndex = 8
        Me.lblStartDate.Text = "May 20, 2017"
        '
        'frmFallMarathon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 622)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblTIme)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFallMarathon"
        Me.Text = "Fall Marathon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents lblStartTime As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTIme As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents lblStartDate As Label
End Class
