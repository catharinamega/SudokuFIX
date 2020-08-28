<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM1_LEVEL
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
        Me.Gbox_Level = New System.Windows.Forms.GroupBox()
        Me.RBttn_Medium = New System.Windows.Forms.RadioButton()
        Me.RBttn_Easy = New System.Windows.Forms.RadioButton()
        Me.RBttn_Hard = New System.Windows.Forms.RadioButton()
        Me.GBox_Size = New System.Windows.Forms.GroupBox()
        Me.RBttn_delapan = New System.Windows.Forms.RadioButton()
        Me.RBttn_enam = New System.Windows.Forms.RadioButton()
        Me.RBttn_sembilan = New System.Windows.Forms.RadioButton()
        Me.Bttn_Challenge = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bttn_close = New System.Windows.Forms.Button()
        Me.Gbox_Level.SuspendLayout()
        Me.GBox_Size.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbox_Level
        '
        Me.Gbox_Level.Controls.Add(Me.RBttn_Medium)
        Me.Gbox_Level.Controls.Add(Me.RBttn_Easy)
        Me.Gbox_Level.Controls.Add(Me.RBttn_Hard)
        Me.Gbox_Level.Location = New System.Drawing.Point(240, 100)
        Me.Gbox_Level.Name = "Gbox_Level"
        Me.Gbox_Level.Size = New System.Drawing.Size(147, 111)
        Me.Gbox_Level.TabIndex = 7
        Me.Gbox_Level.TabStop = False
        Me.Gbox_Level.Text = "Level"
        '
        'RBttn_Medium
        '
        Me.RBttn_Medium.AutoSize = True
        Me.RBttn_Medium.Location = New System.Drawing.Point(33, 44)
        Me.RBttn_Medium.Name = "RBttn_Medium"
        Me.RBttn_Medium.Size = New System.Drawing.Size(62, 17)
        Me.RBttn_Medium.TabIndex = 6
        Me.RBttn_Medium.TabStop = True
        Me.RBttn_Medium.Text = "Medium"
        Me.RBttn_Medium.UseVisualStyleBackColor = True
        '
        'RBttn_Easy
        '
        Me.RBttn_Easy.AutoSize = True
        Me.RBttn_Easy.Location = New System.Drawing.Point(33, 21)
        Me.RBttn_Easy.Name = "RBttn_Easy"
        Me.RBttn_Easy.Size = New System.Drawing.Size(48, 17)
        Me.RBttn_Easy.TabIndex = 5
        Me.RBttn_Easy.TabStop = True
        Me.RBttn_Easy.Text = "Easy"
        Me.RBttn_Easy.UseVisualStyleBackColor = True
        '
        'RBttn_Hard
        '
        Me.RBttn_Hard.AutoSize = True
        Me.RBttn_Hard.Location = New System.Drawing.Point(33, 67)
        Me.RBttn_Hard.Name = "RBttn_Hard"
        Me.RBttn_Hard.Size = New System.Drawing.Size(48, 17)
        Me.RBttn_Hard.TabIndex = 7
        Me.RBttn_Hard.TabStop = True
        Me.RBttn_Hard.Text = "Hard"
        Me.RBttn_Hard.UseVisualStyleBackColor = True
        '
        'GBox_Size
        '
        Me.GBox_Size.Controls.Add(Me.RBttn_delapan)
        Me.GBox_Size.Controls.Add(Me.RBttn_enam)
        Me.GBox_Size.Controls.Add(Me.RBttn_sembilan)
        Me.GBox_Size.Location = New System.Drawing.Point(61, 100)
        Me.GBox_Size.Name = "GBox_Size"
        Me.GBox_Size.Size = New System.Drawing.Size(118, 111)
        Me.GBox_Size.TabIndex = 6
        Me.GBox_Size.TabStop = False
        Me.GBox_Size.Text = "Size"
        '
        'RBttn_delapan
        '
        Me.RBttn_delapan.AutoSize = True
        Me.RBttn_delapan.Location = New System.Drawing.Point(33, 44)
        Me.RBttn_delapan.Name = "RBttn_delapan"
        Me.RBttn_delapan.Size = New System.Drawing.Size(48, 17)
        Me.RBttn_delapan.TabIndex = 1
        Me.RBttn_delapan.TabStop = True
        Me.RBttn_delapan.Text = "8 x 8"
        Me.RBttn_delapan.UseVisualStyleBackColor = True
        '
        'RBttn_enam
        '
        Me.RBttn_enam.AutoSize = True
        Me.RBttn_enam.Location = New System.Drawing.Point(33, 21)
        Me.RBttn_enam.Name = "RBttn_enam"
        Me.RBttn_enam.Size = New System.Drawing.Size(48, 17)
        Me.RBttn_enam.TabIndex = 0
        Me.RBttn_enam.TabStop = True
        Me.RBttn_enam.Text = "6 x 6"
        Me.RBttn_enam.UseVisualStyleBackColor = True
        '
        'RBttn_sembilan
        '
        Me.RBttn_sembilan.AutoSize = True
        Me.RBttn_sembilan.Location = New System.Drawing.Point(33, 67)
        Me.RBttn_sembilan.Name = "RBttn_sembilan"
        Me.RBttn_sembilan.Size = New System.Drawing.Size(48, 17)
        Me.RBttn_sembilan.TabIndex = 2
        Me.RBttn_sembilan.TabStop = True
        Me.RBttn_sembilan.Text = "9 x 9"
        Me.RBttn_sembilan.UseVisualStyleBackColor = True
        '
        'Bttn_Challenge
        '
        Me.Bttn_Challenge.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_Challenge.Location = New System.Drawing.Point(160, 233)
        Me.Bttn_Challenge.Name = "Bttn_Challenge"
        Me.Bttn_Challenge.Size = New System.Drawing.Size(101, 48)
        Me.Bttn_Challenge.TabIndex = 8
        Me.Bttn_Challenge.Text = "Challenge"
        Me.Bttn_Challenge.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PICK YOUR LEVEL"
        '
        'Bttn_close
        '
        Me.Bttn_close.Location = New System.Drawing.Point(395, 2)
        Me.Bttn_close.Name = "Bttn_close"
        Me.Bttn_close.Size = New System.Drawing.Size(49, 32)
        Me.Bttn_close.TabIndex = 9
        Me.Bttn_close.Text = "X"
        Me.Bttn_close.UseVisualStyleBackColor = True
        '
        'FORM1_LEVEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 356)
        Me.Controls.Add(Me.Bttn_close)
        Me.Controls.Add(Me.Gbox_Level)
        Me.Controls.Add(Me.GBox_Size)
        Me.Controls.Add(Me.Bttn_Challenge)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FORM1_LEVEL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PICK YOUR LEVEL"
        Me.Gbox_Level.ResumeLayout(False)
        Me.Gbox_Level.PerformLayout()
        Me.GBox_Size.ResumeLayout(False)
        Me.GBox_Size.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Gbox_Level As GroupBox
    Friend WithEvents RBttn_Medium As RadioButton
    Friend WithEvents RBttn_Easy As RadioButton
    Friend WithEvents RBttn_Hard As RadioButton
    Friend WithEvents GBox_Size As GroupBox
    Friend WithEvents RBttn_delapan As RadioButton
    Friend WithEvents RBttn_enam As RadioButton
    Friend WithEvents RBttn_sembilan As RadioButton
    Friend WithEvents Bttn_Challenge As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Bttn_close As Button
End Class
