Public Class FORM3_DELAPAN

    Private Sub Form3_delapan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Timer1_lapan.Enabled = True

        For i = 0 To 7
            For y = 0 To 7
                delapan(i, y) = New Button
                delapan(i, y).Top = 30 + i * 40
                delapan(i, y).Left = 30 + y * 40
                delapan(i, y).Size = New Size(40, 40)
                delapan(i, y).Name = i & "_" & y

                If i < 2 And y > 3 Then
                    delapan(i, y).BackColor = Color.LavenderBlush
                ElseIf i < 2 And y >= 0 Then
                    delapan(i, y).BackColor = Color.Azure
                ElseIf i < 4 And y > 3 Then
                    delapan(i, y).BackColor = Color.Azure
                ElseIf i < 4 And y >= 0 Then
                    delapan(i, y).BackColor = Color.LavenderBlush
                ElseIf i < 6 And y > 3 Then
                    delapan(i, y).BackColor = Color.LavenderBlush
                ElseIf i < 6 And y >= 0 Then
                    delapan(i, y).BackColor = Color.Azure
                ElseIf i < 9 And y > 3 Then
                    delapan(i, y).BackColor = Color.Azure
                ElseIf i < 9 And y >= 0 Then
                    delapan(i, y).BackColor = Color.LavenderBlush
                End If

                Me.Controls.Add(delapan(i, y))
                AddHandler delapan(i, y).Click, AddressOf isiangka
                AddHandler delapan(i, y).Click, AddressOf checkcolumn8
                AddHandler delapan(i, y).Click, AddressOf checkrow8
                AddHandler delapan(i, y).Click, AddressOf checkotak8
                AddHandler delapan(i, y).Click, AddressOf hitungsalah
                AddHandler delapan(i, y).Click, AddressOf win8
                AddHandler delapan(i, y).Click, AddressOf autocheckdelapan1
                AddHandler delapan(i, y).Click, AddressOf autocheckdelapan2
                AddHandler delapan(i, y).Click, AddressOf autocheckdelapan3
                AddHandler delapan(i, y).Click, AddressOf changecolor8

            Next
        Next
        AddHandler Bttn_GiveUp.Click, AddressOf win8
        AddHandler Bttn_Hint.Click, AddressOf win8

        delapanQQ = Rnd() * 9 + 1
        If delapanQQ = 1 Then
            delapan(0, 0).Text = "4"
            delapan(0, 1).Text = "1"
            delapan(0, 2).Text = "5"
            delapan(0, 3).Text = "8"
            delapan(0, 4).Text = "3"
            delapan(0, 5).Text = "6"
            delapan(0, 6).Text = "7"
            delapan(0, 7).Text = "2"
            delapan(1, 0).Text = "3"
            delapan(1, 1).Text = "7"
            delapan(1, 2).Text = "2"
            delapan(1, 3).Text = "6"
            delapan(1, 4).Text = "4"
            delapan(1, 5).Text = "8"
            delapan(1, 6).Text = "1"
            delapan(1, 7).Text = "5"
            delapan(2, 0).Text = "1"
            delapan(2, 1).Text = "6"
            delapan(2, 2).Text = "4"
            delapan(2, 3).Text = "7"
            delapan(2, 4).Text = "5"
            delapan(2, 5).Text = "3"
            delapan(2, 6).Text = "2"
            delapan(2, 7).Text = "8"
            delapan(3, 0).Text = "5"
            delapan(3, 1).Text = "2"
            delapan(3, 2).Text = "8"
            delapan(3, 3).Text = "3"
            delapan(3, 4).Text = "7"
            delapan(3, 5).Text = "1"
            delapan(3, 6).Text = "4"
            delapan(3, 7).Text = "6"
            delapan(4, 0).Text = "7"
            delapan(4, 1).Text = "5"
            delapan(4, 2).Text = "6"
            delapan(4, 3).Text = "2"
            delapan(4, 4).Text = "1"
            delapan(4, 5).Text = "4"
            delapan(4, 6).Text = "8"
            delapan(4, 7).Text = "3"
            delapan(5, 0).Text = "8"
            delapan(5, 1).Text = "3"
            delapan(5, 2).Text = "1"
            delapan(5, 3).Text = "4"
            delapan(5, 4).Text = "2"
            delapan(5, 5).Text = "5"
            delapan(5, 6).Text = "6"
            delapan(5, 7).Text = "7"
            delapan(6, 0).Text = "6"
            delapan(6, 1).Text = "4"
            delapan(6, 2).Text = "7"
            delapan(6, 3).Text = "5"
            delapan(6, 4).Text = "8"
            delapan(6, 5).Text = "2"
            delapan(6, 6).Text = "3"
            delapan(6, 7).Text = "1"
            delapan(7, 0).Text = "2"
            delapan(7, 1).Text = "8"
            delapan(7, 2).Text = "3"
            delapan(7, 3).Text = "1"
            delapan(7, 4).Text = "6"
            delapan(7, 5).Text = "7"
            delapan(7, 6).Text = "5"
            delapan(7, 7).Text = "4"


        ElseIf delapanQQ = 2 Then
            delapan(0, 0).Text = "7"
            delapan(0, 1).Text = "4"
            delapan(0, 2).Text = "1"
            delapan(0, 3).Text = "6"
            delapan(0, 4).Text = "5"
            delapan(0, 5).Text = "3"
            delapan(0, 6).Text = "2"
            delapan(0, 7).Text = "8"
            delapan(1, 0).Text = "5"
            delapan(1, 1).Text = "2"
            delapan(1, 2).Text = "8"
            delapan(1, 3).Text = "3"
            delapan(1, 4).Text = "7"
            delapan(1, 5).Text = "1"
            delapan(1, 6).Text = "4"
            delapan(1, 7).Text = "6"
            delapan(2, 0).Text = "3"
            delapan(2, 1).Text = "5"
            delapan(2, 2).Text = "7"
            delapan(2, 3).Text = "4"
            delapan(2, 4).Text = "6"
            delapan(2, 5).Text = "8"
            delapan(2, 6).Text = "1"
            delapan(2, 7).Text = "2"
            delapan(3, 0).Text = "2"
            delapan(3, 1).Text = "1"
            delapan(3, 2).Text = "6"
            delapan(3, 3).Text = "8"
            delapan(3, 4).Text = "3"
            delapan(3, 5).Text = "7"
            delapan(3, 6).Text = "5"
            delapan(3, 7).Text = "4"
            delapan(4, 0).Text = "1"
            delapan(4, 1).Text = "7"
            delapan(4, 2).Text = "4"
            delapan(4, 3).Text = "5"
            delapan(4, 4).Text = "8"
            delapan(4, 5).Text = "2"
            delapan(4, 6).Text = "6"
            delapan(4, 7).Text = "3"
            delapan(5, 0).Text = "8"
            delapan(5, 1).Text = "6"
            delapan(5, 2).Text = "3"
            delapan(5, 3).Text = "2"
            delapan(5, 4).Text = "1"
            delapan(5, 5).Text = "4"
            delapan(5, 6).Text = "7"
            delapan(5, 7).Text = "5"
            delapan(6, 0).Text = "4"
            delapan(6, 1).Text = "8"
            delapan(6, 2).Text = "5"
            delapan(6, 3).Text = "1"
            delapan(6, 4).Text = "2"
            delapan(6, 5).Text = "6"
            delapan(6, 6).Text = "3"
            delapan(6, 7).Text = "7"
            delapan(7, 0).Text = "6"
            delapan(7, 1).Text = "3"
            delapan(7, 2).Text = "2"
            delapan(7, 3).Text = "7"
            delapan(7, 4).Text = "4"
            delapan(7, 5).Text = "5"
            delapan(7, 6).Text = "8"
            delapan(7, 7).Text = "1"

        ElseIf delapanQQ = 3 Then
            delapan(0, 0).Text = "5"
            delapan(0, 1).Text = "4"
            delapan(0, 2).Text = "7"
            delapan(0, 3).Text = "2"
            delapan(0, 4).Text = "8"
            delapan(0, 5).Text = "3"
            delapan(0, 6).Text = "1"
            delapan(0, 7).Text = "6"
            delapan(1, 0).Text = "1"
            delapan(1, 1).Text = "3"
            delapan(1, 2).Text = "6"
            delapan(1, 3).Text = "8"
            delapan(1, 4).Text = "2"
            delapan(1, 5).Text = "5"
            delapan(1, 6).Text = "7"
            delapan(1, 7).Text = "4"
            delapan(2, 0).Text = "3"
            delapan(2, 1).Text = "2"
            delapan(2, 2).Text = "5"
            delapan(2, 3).Text = "4"
            delapan(2, 4).Text = "7"
            delapan(2, 5).Text = "1"
            delapan(2, 6).Text = "6"
            delapan(2, 7).Text = "8"
            delapan(3, 0).Text = "7"
            delapan(3, 1).Text = "1"
            delapan(3, 2).Text = "8"
            delapan(3, 3).Text = "6"
            delapan(3, 4).Text = "5"
            delapan(3, 5).Text = "4"
            delapan(3, 6).Text = "3"
            delapan(3, 7).Text = "2"
            delapan(4, 0).Text = "4"
            delapan(4, 1).Text = "8"
            delapan(4, 2).Text = "3"
            delapan(4, 3).Text = "5"
            delapan(4, 4).Text = "6"
            delapan(4, 5).Text = "7"
            delapan(4, 6).Text = "2"
            delapan(4, 7).Text = "1"
            delapan(5, 0).Text = "6"
            delapan(5, 1).Text = "7"
            delapan(5, 2).Text = "2"
            delapan(5, 3).Text = "1"
            delapan(5, 4).Text = "3"
            delapan(5, 5).Text = "8"
            delapan(5, 6).Text = "4"
            delapan(5, 7).Text = "5"
            delapan(6, 0).Text = "2"
            delapan(6, 1).Text = "5"
            delapan(6, 2).Text = "1"
            delapan(6, 3).Text = "7"
            delapan(6, 4).Text = "4"
            delapan(6, 5).Text = "6"
            delapan(6, 6).Text = "8"
            delapan(6, 7).Text = "3"
            delapan(7, 0).Text = "8"
            delapan(7, 1).Text = "6"
            delapan(7, 2).Text = "4"
            delapan(7, 3).Text = "3"
            delapan(7, 4).Text = "1"
            delapan(7, 5).Text = "2"
            delapan(7, 6).Text = "5"
            delapan(7, 7).Text = "7"


        ElseIf delapanQQ = 4 Then
            delapan(0, 0).Text = "3"
            delapan(0, 1).Text = "4"
            delapan(0, 2).Text = "8"
            delapan(0, 3).Text = "1"
            delapan(0, 4).Text = "6"
            delapan(0, 5).Text = "2"
            delapan(0, 6).Text = "7"
            delapan(0, 7).Text = "5"
            delapan(1, 0).Text = "2"
            delapan(1, 1).Text = "6"
            delapan(1, 2).Text = "5"
            delapan(1, 3).Text = "7"
            delapan(1, 4).Text = "3"
            delapan(1, 5).Text = "1"
            delapan(1, 6).Text = "8"
            delapan(1, 7).Text = "4"
            delapan(2, 0).Text = "6"
            delapan(2, 1).Text = "5"
            delapan(2, 2).Text = "2"
            delapan(2, 3).Text = "8"
            delapan(2, 4).Text = "1"
            delapan(2, 5).Text = "4"
            delapan(2, 6).Text = "3"
            delapan(2, 7).Text = "7"
            delapan(3, 0).Text = "4"
            delapan(3, 1).Text = "1"
            delapan(3, 2).Text = "7"
            delapan(3, 3).Text = "3"
            delapan(3, 4).Text = "2"
            delapan(3, 5).Text = "8"
            delapan(3, 6).Text = "5"
            delapan(3, 7).Text = "6"
            delapan(4, 0).Text = "8"
            delapan(4, 1).Text = "3"
            delapan(4, 2).Text = "1"
            delapan(4, 3).Text = "6"
            delapan(4, 4).Text = "5"
            delapan(4, 5).Text = "7"
            delapan(4, 6).Text = "4"
            delapan(4, 7).Text = "2"
            delapan(5, 0).Text = "5"
            delapan(5, 1).Text = "7"
            delapan(5, 2).Text = "4"
            delapan(5, 3).Text = "2"
            delapan(5, 4).Text = "8"
            delapan(5, 5).Text = "3"
            delapan(5, 6).Text = "6"
            delapan(5, 7).Text = "1"
            delapan(6, 0).Text = "1"
            delapan(6, 1).Text = "8"
            delapan(6, 2).Text = "6"
            delapan(6, 3).Text = "4"
            delapan(6, 4).Text = "7"
            delapan(6, 5).Text = "5"
            delapan(6, 6).Text = "2"
            delapan(6, 7).Text = "3"
            delapan(7, 0).Text = "7"
            delapan(7, 1).Text = "2"
            delapan(7, 2).Text = "3"
            delapan(7, 3).Text = "5"
            delapan(7, 4).Text = "4"
            delapan(7, 5).Text = "6"
            delapan(7, 6).Text = "1"
            delapan(7, 7).Text = "8"


        ElseIf delapanQQ = 5 Then
            delapan(0, 0).Text = "8"
            delapan(0, 1).Text = "6"
            delapan(0, 2).Text = "3"
            delapan(0, 3).Text = "4"
            delapan(0, 4).Text = "5"
            delapan(0, 5).Text = "1"
            delapan(0, 6).Text = "2"
            delapan(0, 7).Text = "7"
            delapan(1, 0).Text = "7"
            delapan(1, 1).Text = "1"
            delapan(1, 2).Text = "2"
            delapan(1, 3).Text = "5"
            delapan(1, 4).Text = "8"
            delapan(1, 5).Text = "6"
            delapan(1, 6).Text = "3"
            delapan(1, 7).Text = "4"
            delapan(2, 0).Text = "4"
            delapan(2, 1).Text = "5"
            delapan(2, 2).Text = "6"
            delapan(2, 3).Text = "2"
            delapan(2, 4).Text = "3"
            delapan(2, 5).Text = "7"
            delapan(2, 6).Text = "1"
            delapan(2, 7).Text = "8"
            delapan(3, 0).Text = "3"
            delapan(3, 1).Text = "8"
            delapan(3, 2).Text = "1"
            delapan(3, 3).Text = "7"
            delapan(3, 4).Text = "4"
            delapan(3, 5).Text = "5"
            delapan(3, 6).Text = "6"
            delapan(3, 7).Text = "2"
            delapan(4, 0).Text = "1"
            delapan(4, 1).Text = "2"
            delapan(4, 2).Text = "5"
            delapan(4, 3).Text = "3"
            delapan(4, 4).Text = "7"
            delapan(4, 5).Text = "4"
            delapan(4, 6).Text = "8"
            delapan(4, 7).Text = "6"
            delapan(5, 0).Text = "6"
            delapan(5, 1).Text = "4"
            delapan(5, 2).Text = "7"
            delapan(5, 3).Text = "8"
            delapan(5, 4).Text = "2"
            delapan(5, 5).Text = "3"
            delapan(5, 6).Text = "5"
            delapan(5, 7).Text = "1"
            delapan(6, 0).Text = "5"
            delapan(6, 1).Text = "7"
            delapan(6, 2).Text = "8"
            delapan(6, 3).Text = "6"
            delapan(6, 4).Text = "1"
            delapan(6, 5).Text = "2"
            delapan(6, 6).Text = "4"
            delapan(6, 7).Text = "3"
            delapan(7, 0).Text = "2"
            delapan(7, 1).Text = "3"
            delapan(7, 2).Text = "4"
            delapan(7, 3).Text = "1"
            delapan(7, 4).Text = "6"
            delapan(7, 5).Text = "8"
            delapan(7, 6).Text = "7"
            delapan(7, 7).Text = "5"


        ElseIf delapanQQ = 6 Then
            delapan(0, 0).Text = "4"
            delapan(0, 1).Text = "2"
            delapan(0, 2).Text = "7"
            delapan(0, 3).Text = "1"
            delapan(0, 4).Text = "5"
            delapan(0, 5).Text = "3"
            delapan(0, 6).Text = "6"
            delapan(0, 7).Text = "8"
            delapan(1, 0).Text = "8"
            delapan(1, 1).Text = "5"
            delapan(1, 2).Text = "6"
            delapan(1, 3).Text = "3"
            delapan(1, 4).Text = "4"
            delapan(1, 5).Text = "2"
            delapan(1, 6).Text = "7"
            delapan(1, 7).Text = "1"
            delapan(2, 0).Text = "6"
            delapan(2, 1).Text = "3"
            delapan(2, 2).Text = "2"
            delapan(2, 3).Text = "8"
            delapan(2, 4).Text = "7"
            delapan(2, 5).Text = "4"
            delapan(2, 6).Text = "1"
            delapan(2, 7).Text = "5"
            delapan(3, 0).Text = "5"
            delapan(3, 1).Text = "1"
            delapan(3, 2).Text = "4"
            delapan(3, 3).Text = "7"
            delapan(3, 4).Text = "6"
            delapan(3, 5).Text = "8"
            delapan(3, 6).Text = "2"
            delapan(3, 7).Text = "3"
            delapan(4, 0).Text = "3"
            delapan(4, 1).Text = "6"
            delapan(4, 2).Text = "5"
            delapan(4, 3).Text = "4"
            delapan(4, 4).Text = "1"
            delapan(4, 5).Text = "7"
            delapan(4, 6).Text = "8"
            delapan(4, 7).Text = "2"
            delapan(5, 0).Text = "7"
            delapan(5, 1).Text = "8"
            delapan(5, 2).Text = "1"
            delapan(5, 3).Text = "2"
            delapan(5, 4).Text = "3"
            delapan(5, 5).Text = "5"
            delapan(5, 6).Text = "4"
            delapan(5, 7).Text = "6"
            delapan(6, 0).Text = "2"
            delapan(6, 1).Text = "4"
            delapan(6, 2).Text = "3"
            delapan(6, 3).Text = "6"
            delapan(6, 4).Text = "8"
            delapan(6, 5).Text = "1"
            delapan(6, 6).Text = "5"
            delapan(6, 7).Text = "7"
            delapan(7, 0).Text = "1"
            delapan(7, 1).Text = "7"
            delapan(7, 2).Text = "8"
            delapan(7, 3).Text = "5"
            delapan(7, 4).Text = "2"
            delapan(7, 5).Text = "6"
            delapan(7, 6).Text = "3"
            delapan(7, 7).Text = "4"




        ElseIf delapanQQ = 7 Then
            delapan(0, 0).Text = "7"
            delapan(0, 1).Text = "4"
            delapan(0, 2).Text = "6"
            delapan(0, 3).Text = "1"
            delapan(0, 4).Text = "8"
            delapan(0, 5).Text = "5"
            delapan(0, 6).Text = "3"
            delapan(0, 7).Text = "2"
            delapan(1, 0).Text = "5"
            delapan(1, 1).Text = "2"
            delapan(1, 2).Text = "3"
            delapan(1, 3).Text = "8"
            delapan(1, 4).Text = "6"
            delapan(1, 5).Text = "4"
            delapan(1, 6).Text = "7"
            delapan(1, 7).Text = "1"
            delapan(2, 0).Text = "4"
            delapan(2, 1).Text = "1"
            delapan(2, 2).Text = "2"
            delapan(2, 3).Text = "6"
            delapan(2, 4).Text = "7"
            delapan(2, 5).Text = "3"
            delapan(2, 6).Text = "8"
            delapan(2, 7).Text = "5"
            delapan(3, 0).Text = "8"
            delapan(3, 1).Text = "5"
            delapan(3, 2).Text = "7"
            delapan(3, 3).Text = "3"
            delapan(3, 4).Text = "2"
            delapan(3, 5).Text = "6"
            delapan(3, 6).Text = "1"
            delapan(3, 7).Text = "4"
            delapan(4, 0).Text = "1"
            delapan(4, 1).Text = "6"
            delapan(4, 2).Text = "4"
            delapan(4, 3).Text = "2"
            delapan(4, 4).Text = "3"
            delapan(4, 5).Text = "7"
            delapan(4, 6).Text = "5"
            delapan(4, 7).Text = "8"
            delapan(5, 0).Text = "3"
            delapan(5, 1).Text = "8"
            delapan(5, 2).Text = "5"
            delapan(5, 3).Text = "7"
            delapan(5, 4).Text = "1"
            delapan(5, 5).Text = "2"
            delapan(5, 6).Text = "4"
            delapan(5, 7).Text = "6"
            delapan(6, 0).Text = "6"
            delapan(6, 1).Text = "3"
            delapan(6, 2).Text = "8"
            delapan(6, 3).Text = "4"
            delapan(6, 4).Text = "5"
            delapan(6, 5).Text = "1"
            delapan(6, 6).Text = "2"
            delapan(6, 7).Text = "7"
            delapan(7, 0).Text = "2"
            delapan(7, 1).Text = "7"
            delapan(7, 2).Text = "1"
            delapan(7, 3).Text = "5"
            delapan(7, 4).Text = "4"
            delapan(7, 5).Text = "8"
            delapan(7, 6).Text = "6"
            delapan(7, 7).Text = "3"

        ElseIf delapanQQ = 8 Then
            delapan(0, 0).Text = "6"
            delapan(0, 1).Text = "7"
            delapan(0, 2).Text = "5"
            delapan(0, 3).Text = "3"
            delapan(0, 4).Text = "4"
            delapan(0, 5).Text = "2"
            delapan(0, 6).Text = "1"
            delapan(0, 7).Text = "8"
            delapan(1, 0).Text = "4"
            delapan(1, 1).Text = "8"
            delapan(1, 2).Text = "2"
            delapan(1, 3).Text = "1"
            delapan(1, 4).Text = "3"
            delapan(1, 5).Text = "6"
            delapan(1, 6).Text = "7"
            delapan(1, 7).Text = "5"
            delapan(2, 0).Text = "3"
            delapan(2, 1).Text = "4"
            delapan(2, 2).Text = "1"
            delapan(2, 3).Text = "6"
            delapan(2, 4).Text = "8"
            delapan(2, 5).Text = "5"
            delapan(2, 6).Text = "2"
            delapan(2, 7).Text = "7"
            delapan(3, 0).Text = "7"
            delapan(3, 1).Text = "5"
            delapan(3, 2).Text = "8"
            delapan(3, 3).Text = "2"
            delapan(3, 4).Text = "1"
            delapan(3, 5).Text = "4"
            delapan(3, 6).Text = "6"
            delapan(3, 7).Text = "3"
            delapan(4, 0).Text = "8"
            delapan(4, 1).Text = "6"
            delapan(4, 2).Text = "3"
            delapan(4, 3).Text = "5"
            delapan(4, 4).Text = "7"
            delapan(4, 5).Text = "1"
            delapan(4, 6).Text = "4"
            delapan(4, 7).Text = "2"
            delapan(5, 0).Text = "2"
            delapan(5, 1).Text = "1"
            delapan(5, 2).Text = "4"
            delapan(5, 3).Text = "7"
            delapan(5, 4).Text = "5"
            delapan(5, 5).Text = "8"
            delapan(5, 6).Text = "3"
            delapan(5, 7).Text = "6"
            delapan(6, 0).Text = "5"
            delapan(6, 1).Text = "2"
            delapan(6, 2).Text = "7"
            delapan(6, 3).Text = "4"
            delapan(6, 4).Text = "6"
            delapan(6, 5).Text = "3"
            delapan(6, 6).Text = "8"
            delapan(6, 7).Text = "1"
            delapan(7, 0).Text = "1"
            delapan(7, 1).Text = "3"
            delapan(7, 2).Text = "6"
            delapan(7, 3).Text = "8"
            delapan(7, 4).Text = "2"
            delapan(7, 5).Text = "7"
            delapan(7, 6).Text = "5"
            delapan(7, 7).Text = "4"

        ElseIf delapanQQ = 9 Then
            delapan(0, 0).Text = "1"
            delapan(0, 1).Text = "2"
            delapan(0, 2).Text = "3"
            delapan(0, 3).Text = "4"
            delapan(0, 4).Text = "5"
            delapan(0, 5).Text = "6"
            delapan(0, 6).Text = "7"
            delapan(0, 7).Text = "8"
            delapan(1, 0).Text = "5"
            delapan(1, 1).Text = "6"
            delapan(1, 2).Text = "7"
            delapan(1, 3).Text = "8"
            delapan(1, 4).Text = "1"
            delapan(1, 5).Text = "2"
            delapan(1, 6).Text = "3"
            delapan(1, 7).Text = "4"
            delapan(2, 0).Text = "3"
            delapan(2, 1).Text = "1"
            delapan(2, 2).Text = "6"
            delapan(2, 3).Text = "2"
            delapan(2, 4).Text = "7"
            delapan(2, 5).Text = "4"
            delapan(2, 6).Text = "8"
            delapan(2, 7).Text = "5"
            delapan(3, 0).Text = "7"
            delapan(3, 1).Text = "4"
            delapan(3, 2).Text = "8"
            delapan(3, 3).Text = "5"
            delapan(3, 4).Text = "3"
            delapan(3, 5).Text = "1"
            delapan(3, 6).Text = "6"
            delapan(3, 7).Text = "2"
            delapan(4, 0).Text = "2"
            delapan(4, 1).Text = "7"
            delapan(4, 2).Text = "1"
            delapan(4, 3).Text = "3"
            delapan(4, 4).Text = "4"
            delapan(4, 5).Text = "8"
            delapan(4, 6).Text = "5"
            delapan(4, 7).Text = "6"
            delapan(5, 0).Text = "4"
            delapan(5, 1).Text = "8"
            delapan(5, 2).Text = "5"
            delapan(5, 3).Text = "6"
            delapan(5, 4).Text = "2"
            delapan(5, 5).Text = "7"
            delapan(5, 6).Text = "1"
            delapan(5, 7).Text = "3"
            delapan(6, 0).Text = "6"
            delapan(6, 1).Text = "3"
            delapan(6, 2).Text = "2"
            delapan(6, 3).Text = "1"
            delapan(6, 4).Text = "8"
            delapan(6, 5).Text = "5"
            delapan(6, 6).Text = "4"
            delapan(6, 7).Text = "7"
            delapan(7, 0).Text = "8"
            delapan(7, 1).Text = "5"
            delapan(7, 2).Text = "4"
            delapan(7, 3).Text = "7"
            delapan(7, 4).Text = "6"
            delapan(7, 5).Text = "3"
            delapan(7, 6).Text = "2"
            delapan(7, 7).Text = "1"

        ElseIf delapanQQ = 10 Then
            delapan(0, 0).Text = "1"
            delapan(0, 1).Text = "2"
            delapan(0, 2).Text = "3"
            delapan(0, 3).Text = "4"
            delapan(0, 4).Text = "5"
            delapan(0, 5).Text = "6"
            delapan(0, 6).Text = "7"
            delapan(0, 7).Text = "8"
            delapan(1, 0).Text = "5"
            delapan(1, 1).Text = "8"
            delapan(1, 2).Text = "6"
            delapan(1, 3).Text = "7"
            delapan(1, 4).Text = "2"
            delapan(1, 5).Text = "1"
            delapan(1, 6).Text = "3"
            delapan(1, 7).Text = "4"
            delapan(2, 0).Text = "3"
            delapan(2, 1).Text = "1"
            delapan(2, 2).Text = "4"
            delapan(2, 3).Text = "6"
            delapan(2, 4).Text = "8"
            delapan(2, 5).Text = "2"
            delapan(2, 6).Text = "5"
            delapan(2, 7).Text = "7"
            delapan(3, 0).Text = "2"
            delapan(3, 1).Text = "7"
            delapan(3, 2).Text = "5"
            delapan(3, 3).Text = "8"
            delapan(3, 4).Text = "4"
            delapan(3, 5).Text = "3"
            delapan(3, 6).Text = "1"
            delapan(3, 7).Text = "6"
            delapan(4, 0).Text = "4"
            delapan(4, 1).Text = "6"
            delapan(4, 2).Text = "8"
            delapan(4, 3).Text = "3"
            delapan(4, 4).Text = "1"
            delapan(4, 5).Text = "7"
            delapan(4, 6).Text = "2"
            delapan(4, 7).Text = "5"
            delapan(5, 0).Text = "7"
            delapan(5, 1).Text = "5"
            delapan(5, 2).Text = "2"
            delapan(5, 3).Text = "1"
            delapan(5, 4).Text = "6"
            delapan(5, 5).Text = "4"
            delapan(5, 6).Text = "8"
            delapan(5, 7).Text = "3"
            delapan(6, 0).Text = "6"
            delapan(6, 1).Text = "3"
            delapan(6, 2).Text = "1"
            delapan(6, 3).Text = "5"
            delapan(6, 4).Text = "7"
            delapan(6, 5).Text = "8"
            delapan(6, 6).Text = "4"
            delapan(6, 7).Text = "2"
            delapan(7, 0).Text = "8"
            delapan(7, 1).Text = "4"
            delapan(7, 2).Text = "7"
            delapan(7, 3).Text = "2"
            delapan(7, 4).Text = "3"
            delapan(7, 5).Text = "5"
            delapan(7, 6).Text = "6"
            delapan(7, 7).Text = "1"

        ElseIf delapanQQ = 11 Then
            delapan(0, 0).Text = "6"
            delapan(0, 1).Text = "7"
            delapan(0, 2).Text = "2"
            delapan(0, 3).Text = "5"
            delapan(0, 4).Text = "1"
            delapan(0, 5).Text = "4"
            delapan(0, 6).Text = "3"
            delapan(0, 7).Text = "8"
            delapan(1, 0).Text = "4"
            delapan(1, 1).Text = "2"
            delapan(1, 2).Text = "6"
            delapan(1, 3).Text = "1"
            delapan(1, 4).Text = "8"
            delapan(1, 5).Text = "3"
            delapan(1, 6).Text = "7"
            delapan(1, 7).Text = "5"
            delapan(2, 0).Text = "1"
            delapan(2, 1).Text = "5"
            delapan(2, 2).Text = "8"
            delapan(2, 3).Text = "3"
            delapan(2, 4).Text = "7"
            delapan(2, 5).Text = "2"
            delapan(2, 6).Text = "6"
            delapan(2, 7).Text = "4"
            delapan(3, 0).Text = "3"
            delapan(3, 1).Text = "8"
            delapan(3, 2).Text = "4"
            delapan(3, 3).Text = "7"
            delapan(3, 4).Text = "6"
            delapan(3, 5).Text = "5"
            delapan(3, 6).Text = "2"
            delapan(3, 7).Text = "1"
            delapan(4, 0).Text = "5"
            delapan(4, 1).Text = "1"
            delapan(4, 2).Text = "3"
            delapan(4, 3).Text = "6"
            delapan(4, 4).Text = "4"
            delapan(4, 5).Text = "7"
            delapan(4, 6).Text = "8"
            delapan(4, 7).Text = "2"
            delapan(5, 0).Text = "2"
            delapan(5, 1).Text = "6"
            delapan(5, 2).Text = "7"
            delapan(5, 3).Text = "4"
            delapan(5, 4).Text = "5"
            delapan(5, 5).Text = "8"
            delapan(5, 6).Text = "1"
            delapan(5, 7).Text = "3"
            delapan(6, 0).Text = "7"
            delapan(6, 1).Text = "3"
            delapan(6, 2).Text = "5"
            delapan(6, 3).Text = "8"
            delapan(6, 4).Text = "2"
            delapan(6, 5).Text = "1"
            delapan(6, 6).Text = "4"
            delapan(6, 7).Text = "6"
            delapan(7, 0).Text = "8"
            delapan(7, 1).Text = "4"
            delapan(7, 2).Text = "1"
            delapan(7, 3).Text = "2"
            delapan(7, 4).Text = "3"
            delapan(7, 5).Text = "6"
            delapan(7, 6).Text = "5"
            delapan(7, 7).Text = "7"
        End If

        For i = 0 To 7
            For y = 0 To 7
                soaldelapan(i, y) = delapan(i, y).Text
            Next
        Next

        If level = 0 Then
            numbelow = 28
            numupper = 32
        ElseIf level = 1 Then
            numbelow = 25
            numupper = 29
        ElseIf level = 2 Then
            numbelow = 22
            numupper = 26
        End If

        counthilang = 0
        While counthilang <= numbelow
            For i = 0 To 7
                For y = 0 To 7
                    hilang = Rnd() * 1

                    If hilang = 0 Then
                        If delapan(i, y).Text <> "" Then
                            delapan(i, y).Text = ""
                        End If
                    Else
                        counthilang += 1
                    End If
                    If delapan(i, y).Text <> "" Then
                        delapan(i, y).Enabled = False
                    Else
                        delapan(i, y).Enabled = True
                    End If
                    If counthilang >= numupper Then
                        counthilang = 0
                        For j = 0 To 7
                            For k = 0 To 7
                                delapan(j, k).Text = soaldelapan(j, k)
                            Next
                        Next
                        i = 100
                        y = 100
                    End If
                Next
            Next
        End While

    End Sub

    Private Sub Bttn_close8_Click(sender As Object, e As EventArgs) Handles Bttn_close8.Click
        Timer1_lapan.Enabled = False
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

        awal = Rnd() * 7
        akhir = Rnd() * 7
        While delapan(awal, akhir).Text <> ""
            awal = Rnd() * 7
            akhir = Rnd() * 7
        End While
        delapan(awal, akhir).Text = soaldelapan(awal, akhir)
    End Sub

    Private Sub Bttn_GiveUp_Click(sender As Object, e As EventArgs) Handles Bttn_GiveUp.Click
        For i = 0 To 7
            For y = 0 To 7
                If delapan(i, y).Text = "" Then
                    delapan(i, y).ForeColor = Color.BlueViolet
                ElseIf delapan(i, y).Text <> "" Then
                    If delapan(i, y).Text <> soaldelapan(i, y) Then
                        delapan(i, y).ForeColor = Color.BlueViolet
                    End If
                ElseIf delapan(i, y).ForeColor = Color.Red Then
                    delapan(i, y).ForeColor = Color.BlueViolet
                End If
                delapan(i, y).Text = soaldelapan(i, y)
            Next
        Next

    End Sub

    Private Sub Timer1_lapan_Tick(sender As Object, e As EventArgs) Handles Timer1_lapan.Tick
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