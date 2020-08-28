<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form0_START
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form0_START))
		Me.Timer1_start = New System.Windows.Forms.Timer(Me.components)
		Me.PB_start = New System.Windows.Forms.ProgressBar()
		Me.SuspendLayout()
		'
		'Timer1_start
		'
		Me.Timer1_start.Enabled = True
		Me.Timer1_start.Interval = 30
		'
		'PB_start
		'
		Me.PB_start.Location = New System.Drawing.Point(18, 526)
		Me.PB_start.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.PB_start.Name = "PB_start"
		Me.PB_start.Size = New System.Drawing.Size(660, 15)
		Me.PB_start.TabIndex = 0
		'
		'Form0_START
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(696, 560)
		Me.Controls.Add(Me.PB_start)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Name = "Form0_START"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Timer1_start As Timer
    Friend WithEvents PB_start As ProgressBar
End Class
