<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORM3_DELAPAN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Bttn_GiveUp = New System.Windows.Forms.Button()
        Me.Bttn_Hint = New System.Windows.Forms.Button()
        Me.Bttn_close8 = New System.Windows.Forms.Button()
        Me.Timer1_lapan = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_jam = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_menit = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_detik = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Bttn_GiveUp
        '
        Me.Bttn_GiveUp.Location = New System.Drawing.Point(509, 158)
        Me.Bttn_GiveUp.Name = "Bttn_GiveUp"
        Me.Bttn_GiveUp.Size = New System.Drawing.Size(75, 23)
        Me.Bttn_GiveUp.TabIndex = 7
        Me.Bttn_GiveUp.Text = "Give Up"
        Me.Bttn_GiveUp.UseVisualStyleBackColor = True
        '
        'Bttn_Hint
        '
        Me.Bttn_Hint.Location = New System.Drawing.Point(509, 120)
        Me.Bttn_Hint.Name = "Bttn_Hint"
        Me.Bttn_Hint.Size = New System.Drawing.Size(75, 23)
        Me.Bttn_Hint.TabIndex = 6
        Me.Bttn_Hint.Text = "Hint"
        Me.Bttn_Hint.UseVisualStyleBackColor = True
        '
        'Bttn_close8
        '
        Me.Bttn_close8.Location = New System.Drawing.Point(574, 12)
        Me.Bttn_close8.Name = "Bttn_close8"
        Me.Bttn_close8.Size = New System.Drawing.Size(31, 23)
        Me.Bttn_close8.TabIndex = 5
        Me.Bttn_close8.Text = "X"
        Me.Bttn_close8.UseVisualStyleBackColor = True
        '
        'Timer1_lapan
        '
        Me.Timer1_lapan.Interval = 1000
        '
        'lbl_jam
        '
        Me.lbl_jam.AutoSize = True
        Me.lbl_jam.Location = New System.Drawing.Point(445, 48)
        Me.lbl_jam.Name = "lbl_jam"
        Me.lbl_jam.Size = New System.Drawing.Size(39, 13)
        Me.lbl_jam.TabIndex = 17
        Me.lbl_jam.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(490, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = ":"
        '
        'lbl_menit
        '
        Me.lbl_menit.AutoSize = True
        Me.lbl_menit.Location = New System.Drawing.Point(506, 48)
        Me.lbl_menit.Name = "lbl_menit"
        Me.lbl_menit.Size = New System.Drawing.Size(39, 13)
        Me.lbl_menit.TabIndex = 15
        Me.lbl_menit.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(551, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = ":"
        '
        'lbl_detik
        '
        Me.lbl_detik.AutoSize = True
        Me.lbl_detik.Location = New System.Drawing.Point(567, 48)
        Me.lbl_detik.Name = "lbl_detik"
        Me.lbl_detik.Size = New System.Drawing.Size(39, 13)
        Me.lbl_detik.TabIndex = 13
        Me.lbl_detik.Text = "Label1"
        '
        'FORM3_DELAPAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 391)
        Me.Controls.Add(Me.lbl_jam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_menit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_detik)
        Me.Controls.Add(Me.Bttn_GiveUp)
        Me.Controls.Add(Me.Bttn_Hint)
        Me.Controls.Add(Me.Bttn_close8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FORM3_DELAPAN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "_3_DELAPAN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bttn_GiveUp As Button
    Friend WithEvents Bttn_Hint As Button
    Friend WithEvents Bttn_close8 As Button
    Friend WithEvents Timer1_lapan As Timer
    Friend WithEvents lbl_jam As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_menit As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_detik As Label
End Class
