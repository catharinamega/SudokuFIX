Public Class FORM1_LEVEL
    Private Sub Form1_Level_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RBttn_enam.Checked = True
        RBttn_Easy.Checked = True
    End Sub

    Private Sub Bttn_Challenge_Click(sender As Object, e As EventArgs) Handles Bttn_Challenge.Click
        hitunghint = 0
        a = 0
        b = 0
        c = 0

        If RBttn_enam.Checked = True Then
            uk = 6
            If RBttn_Easy.Checked = True Then
                level = 0
            ElseIf RBttn_Medium.Checked = True Then
                level = 1
            ElseIf RBttn_Hard.Checked = True Then
                level = 2
            End If
            f6 = New FORM2_ENAM
            f6.ShowDialog()

        ElseIf RBttn_delapan.Checked = True Then
            uk = 8
            If RBttn_Easy.Checked = True Then
                level = 0
            ElseIf RBttn_Medium.Checked = True Then
                level = 1
            ElseIf RBttn_Hard.Checked = True Then
                level = 2
            End If
            f8 = New FORM3_DELAPAN
            f8.ShowDialog()

        ElseIf RBttn_sembilan.Checked = True Then
            uk = 9
            If RBttn_Easy.Checked = True Then
                level = 0
            ElseIf RBttn_Medium.Checked = True Then
                level = 1
            ElseIf RBttn_Hard.Checked = True Then
                level = 2
            End If
            f9 = New FORM4_SEMBILAN
            f9.ShowDialog()
        End If
    End Sub
    Private Sub Bttn_close_Click(sender As Object, e As EventArgs) Handles Bttn_close.Click
        Me.Close()
    End Sub

End Class