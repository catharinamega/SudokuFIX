Public Class Form0_START
    Private Sub Timer1_start_Tick(sender As Object, e As EventArgs) Handles Timer1_start.Tick
        PB_start.Increment(1)
        If PB_start.Value = 100 Then
            Timer1_start.Enabled = False
            FORM1_LEVEL.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub Form0_START_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
