Public Class FORM5_TOMBOL
    Private Sub Form6_Tombol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(150, 200)

        If uk = 6 Then
            Bttn_1_6.Visible = True
            Bttn_2_6.Visible = True
            Bttn_3_6.Visible = True
            Bttn_4_6.Visible = True
            Bttn_5_6.Visible = True
            Bttn_6_6.Visible = True
            Bttn_Eraser.Visible = True

            Bttn_1_8.Visible = False
            Bttn_2_8.Visible = False
            Bttn_3_8.Visible = False
            Bttn_4_8.Visible = False
            Bttn_5_8.Visible = False
            Bttn_6_8.Visible = False
            Bttn_7_8.Visible = False
            Bttn_8_8.Visible = False
            Bttn_eraser8.Visible = False

            Bttn_1_9.Visible = False
            Bttn_2_9.Visible = False
            Bttn_3_9.Visible = False
            Bttn_4_9.Visible = False
            Bttn_5_9.Visible = False
            Bttn_6_9.Visible = False
            Bttn_7_9.Visible = False
            Bttn_8_9.Visible = False
            Bttn_9_9.Visible = False

        ElseIf uk = 8 Then
            Bttn_1_8.Visible = True
            Bttn_2_8.Visible = True
            Bttn_3_8.Visible = True
            Bttn_4_8.Visible = True
            Bttn_5_8.Visible = True
            Bttn_6_8.Visible = True
            Bttn_7_8.Visible = True
            Bttn_8_8.Visible = True
            Bttn_eraser8.Visible = True

            Bttn_1_6.Visible = False
            Bttn_2_6.Visible = False
            Bttn_3_6.Visible = False
            Bttn_4_6.Visible = False
            Bttn_5_6.Visible = False
            Bttn_6_6.Visible = False
            Bttn_Eraser.Visible = False

            Bttn_1_9.Visible = False
            Bttn_2_9.Visible = False
            Bttn_3_9.Visible = False
            Bttn_4_9.Visible = False
            Bttn_5_9.Visible = False
            Bttn_6_9.Visible = False
            Bttn_7_9.Visible = False
            Bttn_8_9.Visible = False
            Bttn_9_9.Visible = False

        ElseIf uk = 9 Then
            Bttn_1_9.Visible = True
            Bttn_2_9.Visible = True
            Bttn_3_9.Visible = True
            Bttn_4_9.Visible = True
            Bttn_5_9.Visible = True
            Bttn_6_9.Visible = True
            Bttn_7_9.Visible = True
            Bttn_8_9.Visible = True
            Bttn_9_9.Visible = True
            Bttn_Eraser.Visible = True

            Bttn_1_6.Visible = False
            Bttn_2_6.Visible = False
            Bttn_3_6.Visible = False
            Bttn_4_6.Visible = False
            Bttn_5_6.Visible = False
            Bttn_6_6.Visible = False

            Bttn_1_8.Visible = False
            Bttn_2_8.Visible = False
            Bttn_3_8.Visible = False
            Bttn_4_8.Visible = False
            Bttn_5_8.Visible = False
            Bttn_6_8.Visible = False
            Bttn_7_8.Visible = False
            Bttn_8_8.Visible = False
            Bttn_eraser8.Visible = False

        End If
    End Sub

    Private Sub Bttn_X_Click(sender As Object, e As EventArgs) Handles Bttn_X.Click
            Me.Close()
        End Sub

        Private Sub Bttn_1_6_Click(sender As Object, e As EventArgs) Handles Bttn_1_6.Click
            value = "1"
            Me.Close()
        End Sub

        Private Sub Bttn_2_6_Click(sender As Object, e As EventArgs) Handles Bttn_2_6.Click
            value = "2"
            Me.Close()
        End Sub

        Private Sub Bttn_3_6_Click(sender As Object, e As EventArgs) Handles Bttn_3_6.Click
            value = "3"
            Me.Close()
        End Sub

        Private Sub Bttn_4_6_Click(sender As Object, e As EventArgs) Handles Bttn_4_6.Click
            value = "4"
            Me.Close()
        End Sub

        Private Sub Bttn_5_6_Click(sender As Object, e As EventArgs) Handles Bttn_5_6.Click
            value = "5"
            Me.Close()
        End Sub

        Private Sub Bttn_6_6_Click(sender As Object, e As EventArgs) Handles Bttn_6_6.Click
            value = "6"
            Me.Close()
        End Sub

        Private Sub Bttn_Eraser_Click(sender As Object, e As EventArgs) Handles Bttn_Eraser.Click
            value = ""
            Me.Close()
        End Sub

        Private Sub Bttn_1_8_Click(sender As Object, e As EventArgs) Handles Bttn_1_8.Click
            value = "1"
            Me.Close()
        End Sub

        Private Sub Bttn_2_8_Click(sender As Object, e As EventArgs) Handles Bttn_2_8.Click
            value = "2"
            Me.Close()
        End Sub

        Private Sub Bttn_3_8_Click(sender As Object, e As EventArgs) Handles Bttn_3_8.Click
            value = "3"
            Me.Close()
        End Sub

        Private Sub Bttn_4_8_Click(sender As Object, e As EventArgs) Handles Bttn_4_8.Click
            value = "4"
            Me.Close()
        End Sub

        Private Sub Bttn_5_8_Click(sender As Object, e As EventArgs) Handles Bttn_5_8.Click
            value = "5"
            Me.Close()
        End Sub

        Private Sub Bttn_6_8_Click(sender As Object, e As EventArgs) Handles Bttn_6_8.Click
            value = "6"
            Me.Close()
        End Sub

        Private Sub Bttn_7_8_Click(sender As Object, e As EventArgs) Handles Bttn_7_8.Click
            value = "7"
            Me.Close()
        End Sub

        Private Sub Bttn_8_8_Click(sender As Object, e As EventArgs) Handles Bttn_8_8.Click
            value = "8"
            Me.Close()
        End Sub

        Private Sub Bttn_eraser8_Click(sender As Object, e As EventArgs) Handles Bttn_eraser8.Click
            value = ""
            Me.Close()
        End Sub

        Private Sub Bttn_1_9_Click(sender As Object, e As EventArgs) Handles Bttn_1_9.Click
            value = "1"
            Me.Close()
        End Sub

        Private Sub Bttn_2_9_Click(sender As Object, e As EventArgs) Handles Bttn_2_9.Click
            value = "2"
            Me.Close()
        End Sub

        Private Sub Bttn_3_9_Click(sender As Object, e As EventArgs) Handles Bttn_3_9.Click
            value = "3"
            Me.Close()
        End Sub

        Private Sub Bttn_4_9_Click(sender As Object, e As EventArgs) Handles Bttn_4_9.Click
            value = "4"
            Me.Close()
        End Sub

        Private Sub Bttn_5_9_Click(sender As Object, e As EventArgs) Handles Bttn_5_9.Click
            value = "5"
            Me.Close()
        End Sub

        Private Sub Bttn_6_9_Click(sender As Object, e As EventArgs) Handles Bttn_6_9.Click
            value = "6"
            Me.Close()
        End Sub

        Private Sub Bttn_7_9_Click(sender As Object, e As EventArgs) Handles Bttn_7_9.Click
            value = "7"
            Me.Close()
        End Sub

        Private Sub Bttn_8_9_Click(sender As Object, e As EventArgs) Handles Bttn_8_9.Click
            value = "8"
            Me.Close()
        End Sub

        Private Sub Bttn_9_9_Click(sender As Object, e As EventArgs) Handles Bttn_9_9.Click
            value = "9"
            Me.Close()
        End Sub
    End Class