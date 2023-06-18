Public Class frm_manager

    Private Sub frm_manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss")
        lbl_date.Text = Date.Now.ToString("MMM-d-yyyy")
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        Me.Hide()
        frm_cd_manager.Show()
    End Sub

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        Me.Hide()
        frm_user.Show()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Hide()
        frm_login.Show()
    End Sub

    Private Sub btn_tables_Click(sender As Object, e As EventArgs) Handles btn_tables.Click
        Me.Hide()
        frm_tablesvail_manager.Show()
    End Sub
End Class