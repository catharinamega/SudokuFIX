<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM4_SEMBILAN
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
        Me.components = New System.ComponentModel.Container()
        Me.Bttn_GiveUp = New System.Windows.Forms.Button()
        Me.Bttn_Hint = New System.Windows.Forms.Button()
        Me.Bttn_close9 = New System.Windows.Forms.Button()
        Me.Timer1_sembilan = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_jam = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_menit = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_detik = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Bttn_GiveUp
        '
        Me.Bttn_GiveUp.Location = New System.Drawing.Point(485, 145)
        Me.Bttn_GiveUp.Name = "Bttn_GiveUp"
        Me.Bttn_GiveUp.Size = New System.Drawing.Size(75, 23)
        Me.Bttn_GiveUp.TabIndex = 7
        Me.Bttn_GiveUp.Text = "Give Up"
        Me.Bttn_GiveUp.UseVisualStyleBackColor = True
        '
        'Bttn_Hint
        '
        Me.Bttn_Hint.Location = New System.Drawing.Point(485, 107)
        Me.Bttn_Hint.Name = "Bttn_Hint"
        Me.Bttn_Hint.Size = New System.Drawing.Size(75, 23)
        Me.Bttn_Hint.TabIndex = 6
        Me.Bttn_Hint.Text = "Hint"
        Me.Bttn_Hint.UseVisualStyleBackColor = True
        '
        'Bttn_close9
        '
        Me.Bttn_close9.Location = New System.Drawing.Point(546, 12)
        Me.Bttn_close9.Name = "Bttn_close9"
        Me.Bttn_close9.Size = New System.Drawing.Size(31, 23)
        Me.Bttn_close9.TabIndex = 5
        Me.Bttn_close9.Text = "X"
        Me.Bttn_close9.UseVisualStyleBackColor = True
        '
        'Timer1_sembilan
        '
        Me.Timer1_sembilan.Interval = 1000
        '
        'lbl_jam
        '
        Me.lbl_jam.AutoSize = True
        Me.lbl_jam.Location = New System.Drawing.Point(416, 56)
        Me.lbl_jam.Name = "lbl_jam"
        Me.lbl_jam.Size = New System.Drawing.Size(39, 13)
        Me.lbl_jam.TabIndex = 17
        Me.lbl_jam.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(461, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = ":"
        '
        'lbl_menit
        '
        Me.lbl_menit.AutoSize = True
        Me.lbl_menit.Location = New System.Drawing.Point(477, 56)
        Me.lbl_menit.Name = "lbl_menit"
        Me.lbl_menit.Size = New System.Drawing.Size(39, 13)
        Me.lbl_menit.TabIndex = 15
        Me.lbl_menit.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(522, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = ":"
        '
        'lbl_detik
        '
        Me.lbl_detik.AutoSize = True
        Me.lbl_detik.Location = New System.Drawing.Point(538, 56)
        Me.lbl_detik.Name = "lbl_detik"
        Me.lbl_detik.Size = New System.Drawing.Size(39, 13)
        Me.lbl_detik.TabIndex = 13
        Me.lbl_detik.Text = "Label1"
        '
        'FORM4_SEMBILAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 410)
        Me.Controls.Add(Me.lbl_jam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_menit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_detik)
        Me.Controls.Add(Me.Bttn_GiveUp)
        Me.Controls.Add(Me.Bttn_Hint)
        Me.Controls.Add(Me.Bttn_close9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FORM4_SEMBILAN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "_4_SEMBILAN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bttn_GiveUp As Button
    Friend WithEvents Bttn_Hint As Button
    Friend WithEvents Bttn_close9 As Button
    Friend WithEvents lbl_jam As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_menit As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_detik As Label
    Friend WithEvents Timer1_sembilan As Timer
End Class
