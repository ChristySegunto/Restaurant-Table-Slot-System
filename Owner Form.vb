Public Class Frm_owner
    Private Sub Frm_owner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss")
        lbl_date.Text = Date.Now.ToString("MMM-d-yyyy")
    End Sub

    Private Sub btn_costumer_Click(sender As Object, e As EventArgs) Handles btn_costumer.Click
        Me.Hide()
        frm_cd.Show()
    End Sub

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        Me.Hide()
        frm_user.Show()
    End Sub

    Private Sub btn_reports_Click(sender As Object, e As EventArgs) Handles btn_reports.Click
        Me.Hide()
        Frm_reports.Show()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Hide()
        frm_login.Show()
    End Sub

    Private Sub btn_tables_Click(sender As Object, e As EventArgs) Handles btn_tables.Click
        Me.Hide()
        frm_tablesavailability.Show()
    End Sub

    'Private Sub btn_tables_Click(sender As Object, e As EventArgs) Handles btn_tables.Click
    '    Me.Hide()
    '    Tables_Availability.Show()
    'End Sub

    '    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
    '        Me.Hide()
    '        frm_user.Show()
    '    End Sub
End Class