Module AA_SUB

    'CEK 6X6
    Sub checkcolumn6(sender As Object, e As EventArgs)
            simpan = sender.name.split("_")
            salah = 0
            hitung = 0

            For i = 0 To 5
                If enam(i, simpan(1)).Text <> sender.text Then
                    hitung += 1
                End If
            Next
            If hitung <> 5 Then
                salah += 1
            End If
        End Sub
        Sub checkrow6(sender As Object, e As EventArgs)
            hitung = 0

            For i = 0 To 5
                If enam(simpan(0), i).Text <> sender.text Then
                    hitung += 1
                End If
            Next
            If hitung <> 5 Then
                salah += 1
            End If
        End Sub
        Sub checkotak6(sender As Object, e As EventArgs)
            hitung = 0

            If simpan(0) \ 2 = 0 And simpan(1) \ 3 = 0 Then
                For i = 0 To 1
                    For y = 0 To 2
                        If enam(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 2 = 0 And simpan(1) \ 3 = 1 Then
                For i = 0 To 1
                    For y = 3 To 5
                        If enam(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 2 = 1 And simpan(1) \ 3 = 0 Then
                For i = 2 To 3
                    For y = 0 To 2
                        If enam(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 2 = 1 And simpan(1) \ 3 = 1 Then
                For i = 2 To 3
                    For y = 3 To 5
                        If enam(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 2 = 2 And simpan(1) \ 3 = 0 Then
                For i = 4 To 5
                    For y = 0 To 2
                        If enam(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 2 = 2 And simpan(1) \ 3 = 1 Then
                For i = 4 To 5
                    For y = 3 To 5
                        If enam(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            End If
            If hitung <> 5 Then
                salah += 1
            End If
        End Sub
    Sub win6(sender As Object, e As EventArgs)
        countwin = 0
        For i = 0 To 5
            For y = 0 To 5
                If enam(i, y).Text = soalenam(i, y) Then
                    countwin += 1
                End If
            Next
        Next
        If countwin = 36 Then
            For i = 0 To 5
                For y = 0 To 5
                    enam(i, y).Enabled = False
                Next
            Next
            f6.Timer_ENAM.Stop()
            f6.Bttn_GiveUp.Enabled = False
            f6.Bttn_Hint.Enabled = False
            FORM6_WIN.ShowDialog()
        End If
    End Sub
    Sub autocheckenam1(sender As Object, e As EventArgs)
            wrong = 0
            For i = 0 To 5
                For y = 0 To 5
                    If i <> y Then
                        If enam(simpan(0), i).Text <> "" And enam(simpan(0), y).Text <> "" Then
                            If enam(simpan(0), i).Text = enam(simpan(0), y).Text Then
                            wrong += 1
                            enam(i, y).ForeColor = Color.Red
                        End If
                        End If
                    End If
                Next
            Next
        End Sub
        Sub autocheckenam2(sender As Object, e As EventArgs)
            For i = 0 To 5
                For y = 0 To 5
                    If i <> y Then
                        If enam(i, simpan(1)).Text <> "" And enam(y, simpan(1)).Text <> "" Then
                        If enam(i, simpan(1)).Text = enam(y, simpan(1)).Text Then
                            wrong += 1
                        End If
                    End If
                    End If
                Next
            Next
        End Sub
        Sub autocheckenam3(sender As Object, e As EventArgs)
            If simpan(0) \ 2 = 0 And simpan(1) \ 3 = 0 Then
                For i = 0 To 1
                    For y = 0 To 2
                        For j = 0 To 1
                            For k = 0 To 2
                                If i <> j And y <> k Then
                                    If enam(i, y).Text <> "" And enam(j, k).Text <> "" Then
                                    If enam(i, y).Text = enam(j, k).Text Then
                                        wrong += 1
                                    End If
                                End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 2 = 0 And simpan(1) \ 3 = 1 Then
                For i = 0 To 1
                    For y = 3 To 5
                        For j = 0 To 1
                            For k = 3 To 5
                                If i <> j And y <> k Then
                                    If enam(i, y).Text <> "" And enam(j, k).Text <> "" Then
                                    If enam(i, y).Text = enam(j, k).Text Then
                                        wrong += 1
                                    End If
                                End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 2 = 1 And simpan(1) \ 3 = 0 Then
                For i = 2 To 3
                    For y = 0 To 2
                        For j = 2 To 3
                            For k = 0 To 2
                                If i <> j And y <> k Then
                                    If enam(i, y).Text <> "" And enam(j, k).Text <> "" Then
                                    If enam(i, y).Text = enam(j, k).Text Then
                                        wrong += 1
                                    End If
                                End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 2 = 1 And simpan(1) \ 3 = 1 Then
                For i = 2 To 3
                    For y = 3 To 5
                        For j = 2 To 3
                            For k = 3 To 5
                                If i <> j And y <> k Then
                                    If enam(i, y).Text <> "" And enam(j, k).Text <> "" Then
                                    If enam(i, y).Text = enam(j, k).Text Then
                                        wrong += 1
                                    End If
                                End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 2 = 2 And simpan(1) \ 3 = 0 Then
                For i = 4 To 5
                    For y = 0 To 2
                        For j = 4 To 5
                            For k = 0 To 2
                                If i <> j And y <> k Then
                                    If enam(i, y).Text <> "" And enam(j, k).Text <> "" Then
                                    If enam(i, y).Text = enam(j, k).Text Then
                                        wrong += 1
                                    End If
                                End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 2 = 2 And simpan(1) \ 3 = 1 Then
                For i = 4 To 5
                    For y = 3 To 5
                        For j = 4 To 5
                            For k = 3 To 5
                                If i <> j And y <> k Then
                                    If enam(i, y).Text <> "" And enam(j, k).Text <> "" Then
                                    If enam(i, y).Text = enam(j, k).Text Then
                                        wrong += 1
                                    End If
                                End If
                                End If
                            Next
                        Next
                    Next
                Next
            End If
        End Sub
        Sub changecolor6(sender As Object, e As EventArgs)
        If wrong = 0 Then
            For i = 0 To 5
                enam(simpan(0), i).ForeColor = Color.Black
                enam(i, simpan(0)).ForeColor = Color.Black
            Next
            If simpan(0) \ 2 = 0 And simpan(1) \ 3 = 0 Then
                For i = 0 To 1
                    For y = 0 To 2
                        enam(i, y).ForeColor = Color.Black
                    Next
                Next
            ElseIf simpan(0) \ 2 = 0 And simpan(1) \ 3 = 1 Then
                For i = 0 To 1
                    For y = 3 To 5
                        enam(i, y).ForeColor = Color.Black
                    Next
                Next
            ElseIf simpan(0) \ 2 = 1 And simpan(1) \ 3 = 0 Then
                For i = 2 To 3
                    For y = 0 To 2
                        enam(i, y).ForeColor = Color.Black
                    Next
                Next
            ElseIf simpan(0) \ 2 = 1 And simpan(1) \ 3 = 1 Then
                For i = 2 To 3
                    For y = 3 To 5
                        enam(i, y).ForeColor = Color.Black
                    Next
                Next
            ElseIf simpan(0) \ 2 = 2 And simpan(1) \ 3 = 0 Then
                For i = 4 To 5
                    For y = 0 To 2
                        enam(i, y).ForeColor = Color.Black
                    Next
                Next
            ElseIf simpan(0) \ 2 = 2 And simpan(1) \ 3 = 1 Then
                For i = 4 To 5
                    For y = 3 To 5
                        enam(i, y).ForeColor = Color.Black
                    Next
                Next
            End If
        End If
    End Sub



        'CEK 8X8
        Sub checkcolumn8(sender As Object, e As EventArgs)
            simpan = sender.name.split("_")
            salah = 0
            hitung = 0

            For i = 0 To 7
                If delapan(i, simpan(1)).Text <> sender.text Then
                    hitung += 1
                End If
            Next
            If hitung <> 7 Then
                salah += 1
            End If
        End Sub
        Sub checkrow8(sender As Object, e As EventArgs)
            hitung = 0

            For i = 0 To 7
                If delapan(simpan(0), i).Text <> sender.text Then
                    hitung += 1
                End If
            Next
            If hitung <> 7 Then
                salah += 1
            End If
        End Sub
        Sub checkotak8(sender As Object, e As EventArgs)
            hitung = 0

            If simpan(0) \ 2 = 0 And simpan(1) \ 4 = 0 Then
                For i = 0 To 1
                    For y = 0 To 3
                        If delapan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 2 = 0 And simpan(1) \ 4 = 1 Then
                For i = 0 To 1
                    For y = 4 To 7
                        If delapan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 2 = 1 And simpan(1) \ 4 = 0 Then
                For i = 2 To 3
                    For y = 0 To 3
                        If delapan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 2 = 1 And simpan(1) \ 4 = 1 Then
                For i = 2 To 3
                    For y = 4 To 7
                        If delapan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 2 = 2 And simpan(1) \ 4 = 0 Then
                For i = 4 To 5
                    For y = 0 To 3
                        If delapan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 2 = 2 And simpan(1) \ 4 = 1 Then
                For i = 4 To 5
                    For y = 4 To 7
                        If delapan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 2 = 3 And simpan(1) \ 4 = 0 Then
                For i = 6 To 7
                    For y = 0 To 3
                        If delapan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 2 = 3 And simpan(1) \ 4 = 1 Then
                For i = 6 To 7
                    For y = 4 To 7
                        If delapan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            End If
            If hitung <> 7 Then
                salah += 1
            End If
        End Sub
        Sub win8(sender As Object, e As EventArgs)
            countwin = 0

            For i = 0 To 7
                For y = 0 To 7
                    If delapan(i, y).Text = soaldelapan(i, y) Then
                        countwin += 1
                    End If
                Next
            Next
        If countwin = 64 Then
            For i = 0 To 7
                For y = 0 To 7
                    delapan(i, y).Enabled = False
                Next
            Next
            f8.Timer1_lapan.Stop()
            f8.Bttn_GiveUp.Enabled = False
            f8.Bttn_Hint.Enabled = False
            FORM6_WIN.ShowDialog()
        End If
    End Sub
        Sub autocheckdelapan1(sender As Object, e As EventArgs)
            wrong = 0
            For i = 0 To 7
                For y = 0 To 7
                    If i <> y Then
                        If delapan(simpan(0), i).Text <> "" And delapan(simpan(0), y).Text <> "" Then
                            If delapan(simpan(0), i).Text = delapan(simpan(0), y).Text Then
                                wrong += 1
                            End If
                        End If
                    End If
                Next
            Next
        End Sub
        Sub autocheckdelapan2(sender As Object, e As EventArgs)
            For i = 0 To 7
                For y = 0 To 7
                    If i <> y Then
                        If delapan(i, simpan(1)).Text <> "" And delapan(y, simpan(1)).Text <> "" Then
                            If delapan(i, simpan(1)).Text = delapan(y, simpan(1)).Text Then
                                wrong += 1
                            End If
                        End If
                    End If
                Next
            Next
        End Sub
        Sub autocheckdelapan3(sender As Object, e As EventArgs)
            If simpan(0) \ 2 = 0 And simpan(1) \ 4 = 0 Then
                For i = 0 To 1
                    For y = 0 To 3
                        For j = 0 To 1
                            For k = 0 To 3
                                If i <> j And y <> k Then
                                    If delapan(i, y).Text <> "" And delapan(j, k).Text <> "" Then
                                        If delapan(i, y).Text = delapan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 2 = 0 And simpan(1) \ 4 = 1 Then
                For i = 0 To 1
                    For y = 4 To 7
                        For j = 0 To 1
                            For k = 4 To 7
                                If i <> j And y <> k Then
                                    If delapan(i, y).Text <> "" And delapan(j, k).Text <> "" Then
                                        If delapan(i, y).Text = delapan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 2 = 1 And simpan(1) \ 4 = 0 Then
                For i = 2 To 3
                    For y = 0 To 3
                        For j = 2 To 3
                            For k = 0 To 3
                                If i <> j And y <> k Then
                                    If delapan(i, y).Text <> "" And delapan(j, k).Text <> "" Then
                                        If delapan(i, y).Text = delapan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 2 = 1 And simpan(1) \ 4 = 1 Then
                For i = 2 To 3
                    For y = 4 To 7
                        For j = 2 To 3
                            For k = 4 To 7
                                If i <> j And y <> k Then
                                    If delapan(i, y).Text <> "" And delapan(j, k).Text <> "" Then
                                        If delapan(i, y).Text = delapan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 2 = 2 And simpan(1) \ 4 = 0 Then
                For i = 4 To 5
                    For y = 0 To 3
                        For j = 4 To 5
                            For k = 0 To 3
                                If i <> j And y <> k Then
                                    If delapan(i, y).Text <> "" And delapan(j, k).Text <> "" Then
                                        If delapan(i, y).Text = delapan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 2 = 2 And simpan(1) \ 4 = 1 Then
                For i = 4 To 5
                    For y = 4 To 7
                        For j = 4 To 5
                            For k = 4 To 7
                                If i <> j And y <> k Then
                                    If delapan(i, y).Text <> "" And delapan(j, k).Text <> "" Then
                                        If delapan(i, y).Text = delapan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 2 = 3 And simpan(1) \ 4 = 0 Then
                For i = 6 To 7
                    For y = 0 To 3
                        For j = 6 To 7
                            For k = 0 To 3
                                If i <> j And y <> k Then
                                    If delapan(i, y).Text <> "" And delapan(j, k).Text <> "" Then
                                        If delapan(i, y).Text = delapan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 2 = 3 And simpan(1) \ 4 = 1 Then
                For i = 6 To 7
                    For y = 4 To 7
                        For j = 6 To 7
                            For k = 4 To 7
                                If i <> j And y <> k Then
                                    If delapan(i, y).Text <> "" And delapan(j, k).Text <> "" Then
                                        If delapan(i, y).Text = delapan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            End If
        End Sub
        Sub changecolor8(sender As Object, e As EventArgs)
            If wrong = 0 Then
                For i = 0 To 7
                    delapan(simpan(0), i).ForeColor = Color.Black
                    delapan(i, simpan(0)).ForeColor = Color.Black
                Next
                If simpan(0) \ 2 = 0 And simpan(1) \ 4 = 0 Then
                    For i = 0 To 1
                        For y = 0 To 3
                            delapan(i, y).ForeColor = Color.Black
                        Next
                    Next
                ElseIf simpan(0) \ 2 = 0 And simpan(1) \ 4 = 1 Then
                    For i = 0 To 1
                        For y = 4 To 7
                            delapan(i, y).ForeColor = Color.Black
                        Next
                    Next
                ElseIf simpan(0) \ 2 = 1 And simpan(1) \ 4 = 0 Then
                    For i = 2 To 3
                        For y = 0 To 3
                            delapan(i, y).ForeColor = Color.Black
                        Next
                    Next
                ElseIf simpan(0) \ 2 = 1 And simpan(1) \ 4 = 1 Then
                    For i = 2 To 3
                        For y = 4 To 7
                            delapan(i, y).ForeColor = Color.Black
                        Next
                    Next
                ElseIf simpan(0) \ 2 = 2 And simpan(1) \ 3 = 0 Then
                    For i = 4 To 5
                        For y = 0 To 3
                            delapan(i, y).ForeColor = Color.Black
                        Next
                    Next
                ElseIf simpan(0) \ 2 = 3 And simpan(1) \ 4 = 0 Then
                    For i = 6 To 7
                        For y = 0 To 3
                            delapan(i, y).ForeColor = Color.Black
                        Next
                    Next
                ElseIf simpan(0) \ 2 = 2 And simpan(1) \ 3 = 1 Then
                    For i = 6 To 7
                        For y = 4 To 7
                            delapan(i, y).ForeColor = Color.Black
                        Next
                    Next
                End If
            End If
        End Sub


        'CEK 9X9
        Sub checkcolumn9(sender As Object, e As EventArgs)
            simpan = sender.name.split("_")
            salah = 0
            hitung = 0

            For i = 0 To 8
                If sembilan(i, simpan(1)).Text <> sender.text Then
                    hitung += 1
                End If
            Next
            If hitung <> 8 Then
                salah += 1
            End If
        End Sub
        Sub checkrow9(sender As Object, e As EventArgs)
            hitung = 0

            For i = 0 To 8
                If sembilan(simpan(0), i).Text <> sender.text Then
                    hitung += 1
                End If
            Next
            If hitung <> 8 Then
                salah += 1
            End If
        End Sub
        Sub checkotak9(sender As Object, e As EventArgs)
            hitung = 0

            If simpan(0) \ 3 = 0 And simpan(1) \ 3 = 0 Then
                For i = 0 To 2
                    For y = 0 To 2
                        If sembilan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 3 = 0 And simpan(1) \ 3 = 1 Then
                For i = 0 To 2
                    For y = 3 To 5
                        If sembilan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 3 = 0 And simpan(1) \ 3 = 2 Then
                For i = 0 To 2
                    For y = 6 To 8
                        If sembilan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 3 = 1 And simpan(1) \ 3 = 0 Then
                For i = 3 To 5
                    For y = 0 To 2
                        If sembilan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 3 = 1 And simpan(1) \ 3 = 1 Then
                For i = 3 To 5
                    For y = 3 To 5
                        If sembilan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 3 = 1 And simpan(1) \ 3 = 2 Then
                For i = 3 To 5
                    For y = 6 To 8
                        If sembilan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 3 = 2 And simpan(1) \ 3 = 0 Then
                For i = 6 To 8
                    For y = 0 To 2
                        If sembilan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 3 = 2 And simpan(1) \ 3 = 1 Then
                For i = 6 To 8
                    For y = 3 To 5
                        If sembilan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            ElseIf simpan(0) \ 3 = 2 And simpan(1) \ 3 = 2 Then
                For i = 6 To 8
                    For y = 6 To 8
                        If sembilan(i, y).Text <> sender.text Then
                            hitung += 1
                        End If
                    Next
                Next
            End If
            If hitung <> 8 Then
                salah += 1
            End If
        End Sub
    Sub win9(sender As Object, e As EventArgs)
        countwin = 0
        For i = 0 To 8
            For y = 0 To 8
                If sembilan(i, y).Text = soalsembilan(i, y) Then
                    countwin += 1
                End If
            Next
        Next
        If countwin = 81 Then
            For i = 0 To 8
                For y = 0 To 8
                    sembilan(i, y).Enabled = False
                Next
            Next
            f9.Timer1_sembilan.Stop()
            f9.Bttn_GiveUp.Enabled = False
            f9.Bttn_Hint.Enabled = False
            FORM6_WIN.ShowDialog()
        End If
    End Sub
    Sub autochecksembilan1(sender As Object, e As EventArgs)
            wrong = 0
            For i = 0 To 8
                For y = 0 To 8
                    If i <> y Then
                        If sembilan(simpan(0), i).Text <> "" And sembilan(simpan(0), y).Text <> "" Then
                            If sembilan(simpan(0), i).Text = sembilan(simpan(0), y).Text Then
                                wrong += 1
                            End If
                        End If
                    End If
                Next
            Next
        End Sub
        Sub autochecksembilan2(sender As Object, e As EventArgs)
            For i = 0 To 8
                For y = 0 To 8
                    If i <> y Then
                        If sembilan(i, simpan(1)).Text <> "" And sembilan(y, simpan(1)).Text <> "" Then
                            If sembilan(i, simpan(1)).Text = sembilan(y, simpan(1)).Text Then
                                wrong += 1
                            End If
                        End If
                    End If
                Next
            Next
        End Sub
        Sub autochecksembilan3(sender As Object, e As EventArgs)
            If simpan(0) \ 3 = 0 And simpan(1) \ 3 = 0 Then
                For i = 0 To 2
                    For y = 0 To 2
                        For j = 0 To 2
                            For k = 0 To 2
                                If i <> j And y <> k Then
                                    If sembilan(i, y).Text <> "" And sembilan(j, k).Text <> "" Then
                                        If sembilan(i, y).Text = sembilan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 3 = 0 And simpan(1) \ 3 = 1 Then
                For i = 0 To 2
                    For y = 3 To 5
                        For j = 0 To 2
                            For k = 3 To 5
                                If i <> j And y <> k Then
                                    If sembilan(i, y).Text <> "" And sembilan(j, k).Text <> "" Then
                                        If sembilan(i, y).Text = sembilan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 3 = 0 And simpan(1) \ 3 = 2 Then
                For i = 0 To 2
                    For y = 6 To 8
                        For j = 0 To 2
                            For k = 6 To 8
                                If i <> j And y <> k Then
                                    If sembilan(i, y).Text <> "" And sembilan(j, k).Text <> "" Then
                                        If sembilan(i, y).Text = sembilan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 3 = 1 And simpan(1) \ 3 = 0 Then
                For i = 3 To 5
                    For y = 0 To 2
                        For j = 3 To 5
                            For k = 0 To 2
                                If i <> j And y <> k Then
                                    If sembilan(i, y).Text <> "" And sembilan(j, k).Text <> "" Then
                                        If sembilan(i, y).Text = sembilan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 3 = 1 And simpan(1) \ 3 = 1 Then
                For i = 3 To 5
                    For y = 3 To 5
                        For j = 3 To 5
                            For k = 3 To 5
                                If i <> j And y <> k Then
                                    If sembilan(i, y).Text <> "" And sembilan(j, k).Text <> "" Then
                                        If sembilan(i, y).Text = sembilan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 3 = 1 And simpan(1) \ 3 = 2 Then
                For i = 3 To 5
                    For y = 6 To 8
                        For j = 3 To 5
                            For k = 6 To 8
                                If i <> j And y <> k Then
                                    If sembilan(i, y).Text <> "" And sembilan(j, k).Text <> "" Then
                                        If sembilan(i, y).Text = sembilan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 3 = 2 And simpan(1) \ 3 = 0 Then
                For i = 6 To 8
                    For y = 0 To 2
                        For j = 6 To 8
                            For k = 0 To 2
                                If i <> j And y <> k Then
                                    If sembilan(i, y).Text <> "" And sembilan(j, k).Text <> "" Then
                                        If sembilan(i, y).Text = sembilan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 3 = 2 And simpan(1) \ 3 = 1 Then
                For i = 6 To 8
                    For y = 3 To 5
                        For j = 6 To 8
                            For k = 3 To 5
                                If i <> j And y <> k Then
                                    If sembilan(i, y).Text <> "" And sembilan(j, k).Text <> "" Then
                                        If sembilan(i, y).Text = sembilan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            ElseIf simpan(0) \ 3 = 2 And simpan(1) \ 3 = 2 Then
                For i = 6 To 8
                    For y = 6 To 8
                        For j = 6 To 8
                            For k = 6 To 8
                                If i <> j And y <> k Then
                                    If sembilan(i, y).Text <> "" And sembilan(j, k).Text <> "" Then
                                        If sembilan(i, y).Text = sembilan(j, k).Text Then
                                            wrong += 1
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    Next
                Next
            End If
        End Sub
        Sub changecolor9(sender As Object, e As EventArgs)
            If wrong = 0 Then
                For i = 0 To 8
                    sembilan(simpan(0), i).ForeColor = Color.Black
                    sembilan(i, simpan(0)).ForeColor = Color.Black
                Next
                If simpan(0) \ 3 = 0 And simpan(1) \ 3 = 0 Then
                    For i = 0 To 2
                        For y = 0 To 2
                            sembilan(i, y).ForeColor = Color.Black
                        Next
                    Next
                ElseIf simpan(0) \ 3 = 0 And simpan(1) \ 3 = 1 Then
                    For i = 0 To 2
                        For y = 3 To 5
                            sembilan(i, y).ForeColor = Color.Black
                        Next
                    Next
                ElseIf simpan(0) \ 3 = 0 And simpan(1) \ 3 = 2 Then
                    For i = 0 To 2
                        For y = 6 To 8
                            sembilan(i, y).ForeColor = Color.Black
                        Next
                    Next
                ElseIf simpan(0) \ 3 = 1 And simpan(1) \ 3 = 0 Then
                    For i = 3 To 5
                        For y = 0 To 2
                            sembilan(i, y).ForeColor = Color.Black
                        Next
                    Next
                ElseIf simpan(0) \ 3 = 1 And simpan(1) \ 3 = 1 Then
                    For i = 3 To 5
                        For y = 3 To 5
                            sembilan(i, y).ForeColor = Color.Black
                        Next
                    Next
                ElseIf simpan(0) \ 3 = 1 And simpan(1) \ 3 = 2 Then
                    For i = 3 To 5
                        For y = 6 To 8
                            sembilan(i, y).ForeColor = Color.Black
                        Next
                    Next
                End If
            ElseIf simpan(0) \ 3 = 2 And simpan(1) \ 3 = 0 Then
                For i = 6 To 8
                    For y = 0 To 2
                        sembilan(i, y).ForeColor = Color.Black
                    Next
                Next
            ElseIf simpan(0) \ 3 = 2 And simpan(1) \ 3 = 1 Then
                For i = 6 To 8
                    For y = 3 To 5
                        sembilan(i, y).ForeColor = Color.Black
                    Next
                Next
            ElseIf simpan(0) \ 3 = 2 And simpan(1) \ 3 = 2 Then
                For i = 6 To 8
                    For y = 6 To 8
                        sembilan(i, y).ForeColor = Color.Black
                    Next
                Next
            End If
        End Sub

        Sub hitungsalah(sender As Object, e As EventArgs)
            If salah > 0 Then
                sender.forecolor = Color.Red
            Else
                sender.forecolor = Color.Black
            End If
        End Sub

    End Module

