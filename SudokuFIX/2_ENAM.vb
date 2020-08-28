Public Class FORM2_ENAM
    Private Sub Form2_Play_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Timer_ENAM.Enabled = True

        For i = 0 To 5
            For y = 0 To 5
                enam(i, y) = New Button
                enam(i, y).Top = 50 + i * 40
                enam(i, y).Left = 50 + y * 40
                enam(i, y).Size = New Size(40, 40)
                enam(i, y).Name = i & "_" & y

                If i < 2 And y > 2 Then
                    enam(i, y).BackColor = Color.Cornsilk
                ElseIf i < 2 And y >= 0 Then
                    enam(i, y).BackColor = Color.FloralWhite
                ElseIf i < 4 And y > 2 Then
                    enam(i, y).BackColor = Color.FloralWhite
                ElseIf i < 4 And y >= 0 Then
                    enam(i, y).BackColor = Color.Cornsilk
                ElseIf i < 6 And y > 2 Then
                    enam(i, y).BackColor = Color.Cornsilk
                ElseIf i < 6 And y >= 0 Then
                    enam(i, y).BackColor = Color.FloralWhite
                End If

                Me.Controls.Add(enam(i, y))

                AddHandler enam(i, y).Click, AddressOf isiangka
                AddHandler enam(i, y).Click, AddressOf checkcolumn6
                AddHandler enam(i, y).Click, AddressOf checkrow6
                AddHandler enam(i, y).Click, AddressOf checkotak6
                AddHandler enam(i, y).Click, AddressOf hitungsalah
                AddHandler enam(i, y).Click, AddressOf win6
                AddHandler enam(i, y).Click, AddressOf autocheckenam1
                AddHandler enam(i, y).Click, AddressOf autocheckenam2
                AddHandler enam(i, y).Click, AddressOf autocheckenam3
                AddHandler enam(i, y).Click, AddressOf changecolor6
            Next
        Next

        AddHandler Bttn_GiveUp.Click, AddressOf win6
        AddHandler Bttn_Hint.Click, AddressOf win6

        enamQQ = Rnd() * 9 + 1

        If enamQQ = 1 Then
            enam(0, 0).Text = "2"
            enam(0, 1).Text = "3"
            enam(0, 2).Text = "5"
            enam(0, 3).Text = "6"
            enam(0, 4).Text = "1"
            enam(0, 5).Text = "4"
            enam(1, 0).Text = "1"
            enam(1, 1).Text = "4"
            enam(1, 2).Text = "6"
            enam(1, 3).Text = "5"
            enam(1, 4).Text = "2"
            enam(1, 5).Text = "3"
            enam(2, 0).Text = "6"
            enam(2, 1).Text = "1"
            enam(2, 2).Text = "2"
            enam(2, 3).Text = "4"
            enam(2, 4).Text = "3"
            enam(2, 5).Text = "5"
            enam(3, 0).Text = "3"
            enam(3, 1).Text = "5"
            enam(3, 2).Text = "4"
            enam(3, 3).Text = "2"
            enam(3, 4).Text = "6"
            enam(3, 5).Text = "1"
            enam(4, 0).Text = "5"
            enam(4, 1).Text = "2"
            enam(4, 2).Text = "3"
            enam(4, 3).Text = "1"
            enam(4, 4).Text = "4"
            enam(4, 5).Text = "6"
            enam(5, 0).Text = "4"
            enam(5, 1).Text = "6"
            enam(5, 2).Text = "1"
            enam(5, 3).Text = "3"
            enam(5, 4).Text = "5"
            enam(5, 5).Text = "2"

        ElseIf enamQQ = 2 Then
            enam(0, 0).Text = "4"
            enam(0, 1).Text = "2"
            enam(0, 2).Text = "1"
            enam(0, 3).Text = "6"
            enam(0, 4).Text = "5"
            enam(0, 5).Text = "3"
            enam(1, 0).Text = "6"
            enam(1, 1).Text = "3"
            enam(1, 2).Text = "5"
            enam(1, 3).Text = "1"
            enam(1, 4).Text = "4"
            enam(1, 5).Text = "2"
            enam(2, 0).Text = "1"
            enam(2, 1).Text = "6"
            enam(2, 2).Text = "4"
            enam(2, 3).Text = "3"
            enam(2, 4).Text = "2"
            enam(2, 5).Text = "5"
            enam(3, 0).Text = "3"
            enam(3, 1).Text = "5"
            enam(3, 2).Text = "2"
            enam(3, 3).Text = "4"
            enam(3, 4).Text = "6"
            enam(3, 5).Text = "1"
            enam(4, 0).Text = "5"
            enam(4, 1).Text = "4"
            enam(4, 2).Text = "3"
            enam(4, 3).Text = "2"
            enam(4, 4).Text = "1"
            enam(4, 5).Text = "6"
            enam(5, 0).Text = "2"
            enam(5, 1).Text = "1"
            enam(5, 2).Text = "6"
            enam(5, 3).Text = "5"
            enam(5, 4).Text = "3"
            enam(5, 5).Text = "4"


        ElseIf enamQQ = 3 Then
            enam(0, 0).Text = "6"
            enam(0, 1).Text = "1"
            enam(0, 2).Text = "5"
            enam(0, 3).Text = "4"
            enam(0, 4).Text = "2"
            enam(0, 5).Text = "3"
            enam(1, 0).Text = "2"
            enam(1, 1).Text = "3"
            enam(1, 2).Text = "4"
            enam(1, 3).Text = "1"
            enam(1, 4).Text = "6"
            enam(1, 5).Text = "5"
            enam(2, 0).Text = "1"
            enam(2, 1).Text = "2"
            enam(2, 2).Text = "3"
            enam(2, 3).Text = "6"
            enam(2, 4).Text = "5"
            enam(2, 5).Text = "4"
            enam(3, 0).Text = "4"
            enam(3, 1).Text = "5"
            enam(3, 2).Text = "6"
            enam(3, 3).Text = "3"
            enam(3, 4).Text = "1"
            enam(3, 5).Text = "2"
            enam(4, 0).Text = "5"
            enam(4, 1).Text = "4"
            enam(4, 2).Text = "1"
            enam(4, 3).Text = "2"
            enam(4, 4).Text = "3"
            enam(4, 5).Text = "6"
            enam(5, 0).Text = "3"
            enam(5, 1).Text = "6"
            enam(5, 2).Text = "2"
            enam(5, 3).Text = "5"
            enam(5, 4).Text = "4"
            enam(5, 5).Text = "1"

        ElseIf enamQQ = 4 Then
            enam(0, 0).Text = "6"
            enam(0, 1).Text = "1"
            enam(0, 2).Text = "2"
            enam(0, 3).Text = "5"
            enam(0, 4).Text = "4"
            enam(0, 5).Text = "3"
            enam(1, 0).Text = "5"
            enam(1, 1).Text = "3"
            enam(1, 2).Text = "4"
            enam(1, 3).Text = "2"
            enam(1, 4).Text = "6"
            enam(1, 5).Text = "1"
            enam(2, 0).Text = "2"
            enam(2, 1).Text = "5"
            enam(2, 2).Text = "6"
            enam(2, 3).Text = "3"
            enam(2, 4).Text = "1"
            enam(2, 5).Text = "4"
            enam(3, 0).Text = "3"
            enam(3, 1).Text = "4"
            enam(3, 2).Text = "1"
            enam(3, 3).Text = "6"
            enam(3, 4).Text = "2"
            enam(3, 5).Text = "5"
            enam(4, 0).Text = "4"
            enam(4, 1).Text = "6"
            enam(4, 2).Text = "5"
            enam(4, 3).Text = "1"
            enam(4, 4).Text = "3"
            enam(4, 5).Text = "2"
            enam(5, 0).Text = "1"
            enam(5, 1).Text = "2"
            enam(5, 2).Text = "3"
            enam(5, 3).Text = "4"
            enam(5, 4).Text = "5"
            enam(5, 5).Text = "6"

        ElseIf enamQQ = 5 Then
            enam(0, 0).Text = "6"
            enam(0, 1).Text = "5"
            enam(0, 2).Text = "1"
            enam(0, 3).Text = "3"
            enam(0, 4).Text = "4"
            enam(0, 5).Text = "2"
            enam(1, 0).Text = "2"
            enam(1, 1).Text = "4"
            enam(1, 2).Text = "3"
            enam(1, 3).Text = "6"
            enam(1, 4).Text = "1"
            enam(1, 5).Text = "5"
            enam(2, 0).Text = "1"
            enam(2, 1).Text = "6"
            enam(2, 2).Text = "5"
            enam(2, 3).Text = "2"
            enam(2, 4).Text = "3"
            enam(2, 5).Text = "4"
            enam(3, 0).Text = "3"
            enam(3, 1).Text = "2"
            enam(3, 2).Text = "4"
            enam(3, 3).Text = "1"
            enam(3, 4).Text = "5"
            enam(3, 5).Text = "6"
            enam(4, 0).Text = "5"
            enam(4, 1).Text = "1"
            enam(4, 2).Text = "6"
            enam(4, 3).Text = "4"
            enam(4, 4).Text = "2"
            enam(4, 5).Text = "3"
            enam(5, 0).Text = "4"
            enam(5, 1).Text = "3"
            enam(5, 2).Text = "2"
            enam(5, 3).Text = "5"
            enam(5, 4).Text = "6"
            enam(5, 5).Text = "1"

        ElseIf enamQQ = 6 Then
            enam(0, 0).Text = "4"
            enam(0, 1).Text = "5"
            enam(0, 2).Text = "1"
            enam(0, 3).Text = "6"
            enam(0, 4).Text = "3"
            enam(0, 5).Text = "2"
            enam(1, 0).Text = "6"
            enam(1, 1).Text = "2"
            enam(1, 2).Text = "3"
            enam(1, 3).Text = "1"
            enam(1, 4).Text = "4"
            enam(1, 5).Text = "5"
            enam(2, 0).Text = "3"
            enam(2, 1).Text = "6"
            enam(2, 2).Text = "2"
            enam(2, 3).Text = "4"
            enam(2, 4).Text = "5"
            enam(2, 5).Text = "1"
            enam(3, 0).Text = "1"
            enam(3, 1).Text = "4"
            enam(3, 2).Text = "5"
            enam(3, 3).Text = "3"
            enam(3, 4).Text = "2"
            enam(3, 5).Text = "6"
            enam(4, 0).Text = "2"
            enam(4, 1).Text = "3"
            enam(4, 2).Text = "6"
            enam(4, 3).Text = "5"
            enam(4, 4).Text = "1"
            enam(4, 5).Text = "4"
            enam(5, 0).Text = "5"
            enam(5, 1).Text = "1"
            enam(5, 2).Text = "4"
            enam(5, 3).Text = "2"
            enam(5, 4).Text = "6"
            enam(5, 5).Text = "3"

        ElseIf enamQQ = 7 Then
            enam(0, 0).Text = "3"
            enam(0, 1).Text = "2"
            enam(0, 2).Text = "4"
            enam(0, 3).Text = "1"
            enam(0, 4).Text = "5"
            enam(0, 5).Text = "6"
            enam(1, 0).Text = "6"
            enam(1, 1).Text = "5"
            enam(1, 2).Text = "1"
            enam(1, 3).Text = "2"
            enam(1, 4).Text = "4"
            enam(1, 5).Text = "3"
            enam(2, 0).Text = "2"
            enam(2, 1).Text = "1"
            enam(2, 2).Text = "5"
            enam(2, 3).Text = "3"
            enam(2, 4).Text = "6"
            enam(2, 5).Text = "4"
            enam(3, 0).Text = "4"
            enam(3, 1).Text = "3"
            enam(3, 2).Text = "6"
            enam(3, 3).Text = "5"
            enam(3, 4).Text = "2"
            enam(3, 5).Text = "1"
            enam(4, 0).Text = "1"
            enam(4, 1).Text = "4"
            enam(4, 2).Text = "2"
            enam(4, 3).Text = "6"
            enam(4, 4).Text = "3"
            enam(4, 5).Text = "5"
            enam(5, 0).Text = "5"
            enam(5, 1).Text = "6"
            enam(5, 2).Text = "3"
            enam(5, 3).Text = "4"
            enam(5, 4).Text = "1"
            enam(5, 5).Text = "2"


        ElseIf enamQQ = 8 Then
            enam(0, 0).Text = "6"
            enam(0, 1).Text = "3"
            enam(0, 2).Text = "5"
            enam(0, 3).Text = "1"
            enam(0, 4).Text = "2"
            enam(0, 5).Text = "4"
            enam(1, 0).Text = "1"
            enam(1, 1).Text = "4"
            enam(1, 2).Text = "2"
            enam(1, 3).Text = "5"
            enam(1, 4).Text = "3"
            enam(1, 5).Text = "6"
            enam(2, 0).Text = "5"
            enam(2, 1).Text = "1"
            enam(2, 2).Text = "4"
            enam(2, 3).Text = "3"
            enam(2, 4).Text = "6"
            enam(2, 5).Text = "2"
            enam(3, 0).Text = "3"
            enam(3, 1).Text = "2"
            enam(3, 2).Text = "6"
            enam(3, 3).Text = "4"
            enam(3, 4).Text = "1"
            enam(3, 5).Text = "5"
            enam(4, 0).Text = "2"
            enam(4, 1).Text = "5"
            enam(4, 2).Text = "3"
            enam(4, 3).Text = "6"
            enam(4, 4).Text = "4"
            enam(4, 5).Text = "1"
            enam(5, 0).Text = "4"
            enam(5, 1).Text = "6"
            enam(5, 2).Text = "1"
            enam(5, 3).Text = "2"
            enam(5, 4).Text = "5"
            enam(5, 5).Text = "3"


        ElseIf enamQQ = 9 Then
            enam(0, 0).Text = "6"
            enam(0, 1).Text = "4"
            enam(0, 2).Text = "5"
            enam(0, 3).Text = "2"
            enam(0, 4).Text = "3"
            enam(0, 5).Text = "1"
            enam(1, 0).Text = "2"
            enam(1, 1).Text = "1"
            enam(1, 2).Text = "3"
            enam(1, 3).Text = "5"
            enam(1, 4).Text = "4"
            enam(1, 5).Text = "6"
            enam(2, 0).Text = "4"
            enam(2, 1).Text = "3"
            enam(2, 2).Text = "6"
            enam(2, 3).Text = "1"
            enam(2, 4).Text = "5"
            enam(2, 5).Text = "2"
            enam(3, 0).Text = "5"
            enam(3, 1).Text = "2"
            enam(3, 2).Text = "1"
            enam(3, 3).Text = "3"
            enam(3, 4).Text = "6"
            enam(3, 5).Text = "4"
            enam(4, 0).Text = "1"
            enam(4, 1).Text = "5"
            enam(4, 2).Text = "4"
            enam(4, 3).Text = "6"
            enam(4, 4).Text = "2"
            enam(4, 5).Text = "3"
            enam(5, 0).Text = "3"
            enam(5, 1).Text = "6"
            enam(5, 2).Text = "2"
            enam(5, 3).Text = "4"
            enam(5, 4).Text = "1"
            enam(5, 5).Text = "5"


        ElseIf enamQQ = 10 Then
            enam(0, 0).Text = "6"
            enam(0, 1).Text = "3"
            enam(0, 2).Text = "4"
            enam(0, 3).Text = "1"
            enam(0, 4).Text = "5"
            enam(0, 5).Text = "2"
            enam(1, 0).Text = "2"
            enam(1, 1).Text = "1"
            enam(1, 2).Text = "5"
            enam(1, 3).Text = "4"
            enam(1, 4).Text = "6"
            enam(1, 5).Text = "3"
            enam(2, 0).Text = "1"
            enam(2, 1).Text = "5"
            enam(2, 2).Text = "3"
            enam(2, 3).Text = "6"
            enam(2, 4).Text = "2"
            enam(2, 5).Text = "4"
            enam(3, 0).Text = "4"
            enam(3, 1).Text = "6"
            enam(3, 2).Text = "2"
            enam(3, 3).Text = "3"
            enam(3, 4).Text = "1"
            enam(3, 5).Text = "5"
            enam(4, 0).Text = "5"
            enam(4, 1).Text = "4"
            enam(4, 2).Text = "1"
            enam(4, 3).Text = "2"
            enam(4, 4).Text = "3"
            enam(4, 5).Text = "6"
            enam(5, 0).Text = "3"
            enam(5, 1).Text = "2"
            enam(5, 2).Text = "6"
            enam(5, 3).Text = "5"
            enam(5, 4).Text = "4"
            enam(5, 5).Text = "1"

        End If

        For i = 0 To 5
            For y = 0 To 5
                soalenam(i, y) = enam(i, y).Text
            Next
        Next

        If level = 0 Then
            numbelow = 17
            numupper = 20
        ElseIf level = 1 Then
            numbelow = 15
            numupper = 18
        ElseIf level = 2 Then
            numbelow = 13
            numupper = 16
        End If

        counthilang = 0
        While counthilang <= numbelow
            For i = 0 To 5
                For y = 0 To 5
                    hilang = Rnd() * 1

                    If hilang = 0 Then
                        If enam(i, y).Text <> "" Then
                            enam(i, y).Text = ""
                        End If
                    Else
                        counthilang += 1
                    End If
                    If enam(i, y).Text <> "" Then
                        enam(i, y).Enabled = False
                    Else
                        enam(i, y).Enabled = True
                    End If
                    If counthilang >= numupper Then
                        counthilang = 0
                        For j = 0 To 5
                            For k = 0 To 5
                                enam(j, k).Text = soalenam(j, k)
                            Next
                        Next
                        i = 100
                        y = 100
                    End If
                Next
            Next
        End While

    End Sub
    Private Sub Bttn_close6_Click(sender As Object, e As EventArgs) Handles Bttn_close6.Click
        Timer_ENAM.Enabled = False
        Me.Close()
    End Sub

    Sub isiangka(sender As Object, e As EventArgs)
        If sender.text = "" Then
            value = ""
        Else
            value = sender.text
        End If
        FORM5_TOMBOL.ShowDialog()
        sender.text = value
    End Sub

    Private Sub Bttn_Hint_Click(sender As Object, e As EventArgs) Handles Bttn_Hint.Click
        hitunghint += 1

        awal = Rnd() * 5
        akhir = Rnd() * 5
        While enam(awal, akhir).Text <> ""
            awal = Rnd() * 5
            akhir = Rnd() * 5
        End While
        enam(awal, akhir).Text = soalenam(awal, akhir)
    End Sub

    Private Sub Bttn_GiveUp_Click(sender As Object, e As EventArgs) Handles Bttn_GiveUp.Click
        For i = 0 To 5
            For y = 0 To 5
                If enam(i, y).Text = "" Then
                    enam(i, y).ForeColor = Color.BlueViolet
                ElseIf enam(i, y).Text <> "" Then
                    If enam(i, y).Text <> soalenam(i, y) Then
                        enam(i, y).ForeColor = Color.BlueViolet
                    End If
                ElseIf enam(i, y).ForeColor = Color.Red Then
                    enam(i, y).ForeColor = Color.BlueViolet
                End If
                enam(i, y).Text = soalenam(i, y)
            Next
        Next
    End Sub

    Private Sub Timer_ENAM_Tick(sender As Object, e As EventArgs) Handles Timer_ENAM.Tick
        a += 1
        If b >= 60 Then
            b = 0
            c += 1
        End If
        If c < 10 Then
            lbl_jam.Text = "0" & c
        Else
            lbl_jam.Text = c
        End If

        If a >= 60 Then
            a = 0
            b += 1
        End If
        If b < 10 Then
            lbl_menit.Text = "0" & b
        Else
            lbl_menit.Text = b
        End If

        If a < 10 Then
            lbl_detik.Text = "0" & a
        Else
            lbl_detik.Text = a
        End If

        waktuu = lbl_jam.Text & " : " & lbl_menit.Text & " : " & lbl_detik.Text
    End Sub
End Class