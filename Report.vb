Public Class Frm_reports
    Private Sub dtp_date_ValueChanged(sender As Object, e As EventArgs) Handles dtp_date.ValueChanged
        Try
            Dim dt As New DataTable
            dt = ExecuteQuery("SELECT * FROM Reservation WHERE [DOR] LIKE '" & dtp_date.Text & "%'")
            lvReports.Items.Clear()
            If dt.Rows.Count > 0 Then
                For ctr = 0 To dt.Rows.Count - 1
                    Dim item As New ListViewItem
                    item.Text = dt.Rows(ctr)("ReservationNumber")
                    item.SubItems.Add(dt.Rows(ctr)("TableNum"))
                    item.SubItems.Add(Format(dt.Rows(ctr)("TOR"), "Medium Time"))
                    lvReports.Items.Add(item)

                Next
            End If

            Dim rowcount As Integer = 0
            For Each item As ListViewItem In lvReports.Items
                rowcount = lvReports.Items.Count
                txtbox_total.Text = rowcount

            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        Me.Hide()
        frm_cd.Show()
    End Sub

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        Me.Hide()
        frm_user.Show()
    End Sub

    Private Sub btn_reports_Click(sender As Object, e As EventArgs) Handles btn_reports.Click
        MsgBox("You are already in Reports")
    End Sub

    Private Sub Frm_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lvReports_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvReports.SelectedIndexChanged

        Try
            For Each item As ListViewItem In lvReports.SelectedItems
                Dim first, last As Integer
                Dim str As String = item.SubItems(0).ToString
                first = str.IndexOf("{")
                last = str.LastIndexOf("}")
                str = item.SubItems(0).ToString.Substring(first + 1, last - first - 1)

                'MessageBox.Show(str + " Reservee: " + reservee.ToString + "Contact Details: " + contactnum.ToString)


            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbox_total.TextChanged
    '    Dim dt As DataTable
    '    dt = ExecuteQuery("SELECT * FROM Reservation")
    '    If txtbox_total.Text >= 0 Then
    '        txtbox_total.Text = dt.Rows.Count

    '    End If
    'End Sub
End Class