Public Class frm_cd_manager
    Public Sub Fill_Details()
        Dim dt As New DataTable

        dt = ExecuteQuery("SELECT * FROM Reservation")

        Try
            If dt.Rows.Count > 0 Then
                For ctr = 0 To dt.Rows.Count - 1
                    Dim item As New ListViewItem
                    item.Text = dt.Rows(ctr)("ReservationNumber")
                    item.SubItems.Add(dt.Rows(ctr)("Reservee"))
                    item.SubItems.Add(dt.Rows(ctr)("ContactNum"))
                    item.SubItems.Add(dt.Rows(ctr)("NOP"))
                    item.SubItems.Add(dt.Rows(ctr)("TableNum"))
                    item.SubItems.Add(Format(dt.Rows(ctr)("DOR"), "Short Date"))
                    item.SubItems.Add(Format(dt.Rows(ctr)("TOR"), "Medium Time"))
                    lvPL.Items.Add(item)
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub ViewSelectedlvDetails(ByVal ReservationNumber As String)
        Dim dt As New DataTable
        Dim ctr As Integer

        dt = ExecuteQuery("SELECT * FROM Reservation WHERE ReservationNumber = '" & ReservationNumber & "'")
        If dt.Rows.Count > 0 Then

            txtbox_reservationnum.Text = dt.Rows(ctr)("ReservationNumber")
            txtbox_reservee.Text = dt.Rows(ctr)("Reservee")
            txtbox_contact.Text = dt.Rows(ctr)("ContactNum")
            txtbox_nop.Text = dt.Rows(ctr)("NOP")
            txtbox_tablenum.Text = dt.Rows(ctr)("TableNum")
            dtp_reservationdate.Text = dt.Rows(ctr)("DOR").ToString
            dtp_reservationtime.Text = dt.Rows(ctr)("TOR").ToString

        End If
    End Sub

    Public Sub Add()
        Dim dt As DataTable
        Try
            If txtbox_reservationnum.Text = Nothing Or txtbox_reservee.Text = Nothing Or txtbox_contact.Text = Nothing Or txtbox_nop.Text = Nothing Or txtbox_tablenum.Text = Nothing Or dtp_reservationdate.Value = Nothing Then
                MessageBox.Show("Please fill all the fields.")
            Else
                dt = ExecuteQuery("INSERT INTO Reservation VALUES ('" & txtbox_reservationnum.Text.Trim & "','" & txtbox_reservee.Text.Trim & "','" & txtbox_contact.Text.Trim & "', 
                                    '" & txtbox_nop.Text.Trim & "', 
                                    '" & txtbox_tablenum.Text.Trim & "', 
                                    '" & dtp_reservationdate.Text.Trim & "',
                                    '" & dtp_reservationtime.Text.Trim & "')")

                lvPL.Items.Clear()
                Call Fill_Details()


            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Edit()
        Try
            Dim dt As New DataTable
            dt = ExecuteQuery("UPDATE [Reservation] SET [Reservee] = '" & txtbox_reservee.Text.Trim & "',
                                [ContactNum] = '" & txtbox_contact.Text.Trim & "',
                                [NOP] = '" & txtbox_nop.Text.Trim & "',
                                [TableNum]= '" & txtbox_tablenum.Text.Trim & "',
                                [DOR] = '" & dtp_reservationdate.Text.Trim & "',
                                [TOR] = '" & dtp_reservationtime.Text.Trim & "'  WHERE [ReservationNumber] = '" & txtbox_reservationnum.Text & "'")

            lvPL.Items.Clear()
            Call Fill_Details()

            MessageBox.Show("Customer Details Updated")


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Public Sub Delete()
        Dim dt As New DataTable
        dt = ExecuteQuery("DELETE FROM Reservation WHERE ReservationNumber = '" & txtbox_reservationnum.Text.Trim & "' ")


        'txtbox_reservationnum.Clear()
        txtbox_reservee.Clear()
        txtbox_contact.Clear()
        txtbox_nop.Clear()
        txtbox_tablenum.Clear()


    End Sub

    Private Sub frm_cd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Fill_Details()

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Call Add()

        Dim dt As New DataTable
        dt = ExecuteQuery("SELECT * FROM Reservation WHERE ReservationNumber = '" & txtbox_reservationnum.Text & "'")


        'txtbox_reservationnum.Clear()
        txtbox_reservee.Clear()
        txtbox_contact.Clear()
        txtbox_nop.Clear()
        txtbox_tablenum.Clear()

    End Sub

    Private Sub btn_edit_Click(Sender As Object, e As EventArgs) Handles btn_edit.Click
        Call Edit()
        txtbox_reservationnum.Clear()
        txtbox_reservee.Clear()
        txtbox_contact.Clear()
        txtbox_nop.Clear()
        txtbox_tablenum.Clear()

    End Sub

    Private Sub btn_delete_Click(Sender As Object, e As EventArgs) Handles btn_delete.Click
        Call Delete()

        lvPL.Items.Clear()
        Call Fill_Details()
    End Sub

    Private Sub lvPL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPL.SelectedIndexChanged
        Dim dt As New DataTable

        Try
            For Each item As ListViewItem In lvPL.SelectedItems
                Dim first, last As Integer
                Dim str As String = item.SubItems(0).ToString
                first = str.IndexOf("{")
                last = str.LastIndexOf("}")
                str = item.SubItems(0).ToString.Substring(first + 1, last - first - 1)


                'MessageBox.Show(str)
                Call ViewSelectedlvDetails(str)
                txtbox_reservationnum.Text = str

            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbox_reservationnum_TextChanged(sender As Object, e As EventArgs) Handles txtbox_reservationnum.TextChanged

    End Sub

    Private Sub txtbox_reservee_TextChanged(sender As Object, e As EventArgs) Handles txtbox_reservee.TextChanged

        If txtbox_reservee.Text.Count <= 0 Then
            Dim dt As DataTable
            dt = ExecuteQuery("SELECT * FROM Reservation")
            txtbox_reservationnum.Text = dt.Rows.Count + 1000

        End If


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtbox_search_TextChanged(sender As Object, e As EventArgs) Handles txtbox_search.TextChanged
        Dim search As String = Nothing
        If cmb_filter.Text = "Reservation Number" Then
            search = "ReservationNumber"
        ElseIf cmb_filter.Text = "Reservee" Then
            search = "Reservee"
        ElseIf cmb_filter.Text = "Contact Number" Then
            search = "ContactNum"
        ElseIf cmb_filter.Text = "No. of Reservation" Then
            search = "NOP"
        ElseIf cmb_filter.Text = "Table Number" Then
            search = "TableNum"
        ElseIf cmb_filter.Text = "Date of Reservation" Then
            search = "DOR"
        ElseIf cmb_filter.Text = "Time of Reservation" Then
            search = "TOR"
        End If

        Try
            Dim dt As New DataTable
            dt = ExecuteQuery("SELECT * FROM Reservation WHERE " & search & " LIKE '" & txtbox_search.Text & "%'")
            lvPL.Items.Clear()
            If dt.Rows.Count > 0 Then
                For ctr = 0 To dt.Rows.Count - 1
                    Dim item As New ListViewItem
                    item.Text = dt.Rows(ctr)("ReservationNumber")
                    item.SubItems.Add(dt.Rows(ctr)("Reservee"))
                    item.SubItems.Add(dt.Rows(ctr)("ContactNum"))
                    item.SubItems.Add(dt.Rows(ctr)("NOP"))
                    item.SubItems.Add(dt.Rows(ctr)("TableNum"))
                    item.SubItems.Add(Format(dt.Rows(ctr)("DOR"), "Short Date"))
                    item.SubItems.Add(Format(dt.Rows(ctr)("TOR"), "Medium Time"))
                    lvPL.Items.Add(item)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        Me.Hide()
        frm_user_manager.Show()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        MsgBox("You are already in Customers Details")
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Hide()
        frm_manager.Show()
    End Sub
End Class