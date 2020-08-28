Public Class FORM6_WIN

    Private Sub FORM6_WIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_waktu.Text = waktuu
        lbl_hint.Text = hitunghint
        If level = 0 Then
            lbl_lvl.Text = "Easy"
        ElseIf level = 1 Then
            lbl_lvl.Text = "Medium"
        Else
            lbl_lvl.Text = "Hard"
        End If
    End Sub
    Private Sub Bttn_X_Click(sender As Object, e As EventArgs) Handles Bttn_X.Click
        Me.Close()
    End Sub


End Class