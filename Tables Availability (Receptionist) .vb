Public Class frm_tablesavail_receptionist


    Private Sub cmb_Table1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Table1.SelectedIndexChanged

        If cmb_Table1.Text = "Reserved" Then
                table1.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\1.png")
                table1.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table1.Text = "Available" Then
                table1.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\2.png")
                table1.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table1.Text = "Occupied" Then
                table1.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\3.png")
                table1.SizeMode = PictureBoxSizeMode.StretchImage

            End If

        End Sub

        Private Sub cmb_Table2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Table2.SelectedIndexChanged
            If cmb_Table2.Text = "Reserved" Then
                table2.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\1.png")
                table2.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table2.Text = "Available" Then
                table2.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\2.png")
                table2.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table2.Text = "Occupied" Then
                table2.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\3.png")
                table2.SizeMode = PictureBoxSizeMode.StretchImage

            End If
        End Sub

        Private Sub cmb_Table3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Table3.SelectedIndexChanged
            If cmb_Table3.Text = "Reserved" Then
                table3.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\1.png")
                table3.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table3.Text = "Available" Then
                table3.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\2.png")
                table3.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table3.Text = "Occupied" Then
                table3.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\3.png")
                table3.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Sub

        Private Sub cmb_Table4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Table4.SelectedIndexChanged
            If cmb_Table4.Text = "Reserved" Then
                table4.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\1.png")
                table4.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table4.Text = "Available" Then
                table4.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\2.png")
                table4.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table4.Text = "Occupied" Then
                table4.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\3.png")
                table4.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Sub


        Private Sub cmb_Table5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Table5.SelectedIndexChanged
            If cmb_Table5.Text = "Reserved" Then
                table5.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 4 and 6\Reserved (6).png")
                table5.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table5.Text = "Available" Then
                table5.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 4 and 6\Available (6).png")
                table5.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table5.Text = "Occupied" Then
                table5.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 4 and 6\Occupied (6).png")
                table5.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Sub

        Private Sub cmb_Table6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Table6.SelectedIndexChanged
            If cmb_Table6.Text = "Reserved" Then
                table6.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 4 and 6\Reserved (4).png")
                table6.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table6.Text = "Available" Then
                table6.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 4 and 6\Available (4).png")
                table6.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table6.Text = "Occupied" Then
                table6.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 4 and 6\Occupied (4).png")
                table6.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Sub

        Private Sub cmb_Table7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Table7.SelectedIndexChanged
            If cmb_Table7.Text = "Reserved" Then
                table7.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 4 and 6\Reserved (6).png")
                table7.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table7.Text = "Available" Then
                table7.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 4 and 6\Available (6).png")
                table7.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table7.Text = "Occupied" Then
                table7.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 4 and 6\Occupied (6).png")
                table7.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Sub

        Private Sub cmb_Table8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Table8.SelectedIndexChanged
            If cmb_Table8.Text = "Reserved" Then
                table8.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 4 and 6\Reserved (4).png")
                table8.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table8.Text = "Available" Then
                table8.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 4 and 6\Available (4).png")
                table8.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table8.Text = "Occupied" Then
                table8.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 4 and 6\Occupied (4).png")
                table8.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Sub

        Private Sub cmb_Table9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Table9.SelectedIndexChanged
            If cmb_Table9.Text = "Reserved" Then
                table9.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\1.png")
                table9.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table9.Text = "Available" Then
                table9.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\2.png")
                table9.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table9.Text = "Occupied" Then
                table9.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\3.png")
                table9.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Sub

        Private Sub cmb_Table10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Table10.SelectedIndexChanged
            If cmb_Table10.Text = "Reserved" Then
                table10.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\1.png")
                table10.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table10.Text = "Available" Then
                table10.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\2.png")
                table10.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table10.Text = "Occupied" Then
                table10.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\3.png")
                table10.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Sub

        Private Sub cmb_Table11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Table11.SelectedIndexChanged
            If cmb_Table11.Text = "Reserved" Then
                table11.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\1.png")
                table11.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table11.Text = "Available" Then
                table11.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\2.png")
                table11.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table11.Text = "Occupied" Then
                table11.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\3.png")
                table11.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Sub

        Private Sub cmb_Table12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Table12.SelectedIndexChanged
            If cmb_Table12.Text = "Reserved" Then
                table12.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\1.png")
                table12.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table12.Text = "Available" Then
                table12.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\2.png")
                table12.SizeMode = PictureBoxSizeMode.StretchImage
            ElseIf cmb_Table12.Text = "Occupied" Then
                table12.Image = Image.FromFile("C:\Users\chris\Pictures\RTSS\Pictures\Table for 2 (1)\3.png")
                table12.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Sub


        Private Sub dtp_date_ValueChanged(sender As Object, e As EventArgs) Handles dtp_date.ValueChanged
            Try
                Dim dt As New DataTable
                dt = ExecuteQuery("SELECT * FROM Reservation WHERE [DOR] LIKE '" & dtp_date.Text & "%'")
                lvShortCD.Items.Clear()
                If dt.Rows.Count > 0 Then
                    For ctr = 0 To dt.Rows.Count - 1
                        Dim item As New ListViewItem
                        item.Text = dt.Rows(ctr)("ReservationNumber")
                        item.SubItems.Add(dt.Rows(ctr)("Reservee"))
                        item.SubItems.Add(dt.Rows(ctr)("NOP"))
                        item.SubItems.Add(dt.Rows(ctr)("TableNum"))
                        item.SubItems.Add(Format(dt.Rows(ctr)("TOR"), "Medium Time"))
                        lvShortCD.Items.Add(item)

                    Next
                End If

                'Dim rowcount As Integer = 0
                'For Each item As ListViewItem In lvShortCD.Items
                '    rowcount = lvReports.Items.Count
                '    txtbox_total.Text = rowcount

                'Next

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

    Private Sub frm_tablesavail_receptionist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class