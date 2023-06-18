Public Class frm_user_manager
    Public Sub Fill_User()
        Dim dt As New DataTable

        dt = ExecuteQuery("SELECT * FROM [User]")

        Try
            If dt.Rows.Count > 0 Then
                For ctr = 0 To dt.Rows.Count - 1
                    Dim item As New ListViewItem
                    item.Text = dt.Rows(ctr)("ID")
                    item.SubItems.Add(dt.Rows(ctr)("Username"))
                    item.SubItems.Add(dt.Rows(ctr)("Password"))
                    item.SubItems.Add(dt.Rows(ctr)("Position"))
                    lvUL.Items.Add(item)
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub ViewSelectedlvDetails(ByVal Username As String)
        Dim dt As New DataTable
        Dim ctr As Integer

        dt = ExecuteQuery("SELECT * FROM [User] WHERE [Username] = '" & Username & "'")
        If dt.Rows.Count > 0 Then

            txtbox_UserID.Text = dt.Rows(ctr)("ID")
            txtbox_uname.Text = dt.Rows(ctr)("Username")
            txtbox_pass.Text = dt.Rows(ctr)("Password")
            txtbox_position.Text = dt.Rows(ctr)("Position")

        End If

    End Sub


    Public Sub SignUp()
        Dim dt As DataTable
        Try
            If txtbox_UserID.Text = Nothing Or txtbox_uname.Text = Nothing Or txtbox_pass.Text = Nothing Or txtbox_position.Text = Nothing Then
                MessageBox.Show("Please fill all the fields.")
            Else
                dt = ExecuteQuery("INSERT INTO User VALUES ('" & txtbox_UserID.Text.Trim & "','" & txtbox_uname.Text.Trim & "','" & txtbox_pass.Text.Trim & "', 
                                    '" & txtbox_position.Text.Trim & "')")

                lvUL.Items.Clear()
                Call Fill_User()


            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Edit()
        Try
            Dim dt As New DataTable
            dt = ExecuteQuery("UPDATE [User]  SET
                                Username = '" & txtbox_uname.Text.Trim & "',
                                Password = '" & txtbox_pass.Text.Trim & "',
                                Position = '" & txtbox_position.Text.Trim & "' WHERE ID = ' " & txtbox_UserID.Text.Trim & "',")


            lvUL.Items.Clear()
            Call Fill_User()

            MessageBox.Show("Details Updated")


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Delete()
        Dim dt As New DataTable
        dt = ExecuteQuery("DELETE FROM User WHERE ID = '" & txtbox_UserID.Text.Trim & "' ")

        txtbox_uname.Clear()
        txtbox_pass.Clear()
        txtbox_position.Clear()


    End Sub




    Private Sub frm_cd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Fill_User()

    End Sub

    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        Call SignUp()
        txtbox_uname.Clear()
        txtbox_pass.Clear()
        txtbox_position.Clear()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txtbox_UserID.Clear()
        txtbox_uname.Clear()
        txtbox_pass.Clear()
        txtbox_position.Clear()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Call Edit()
        txtbox_UserID.Clear()
        txtbox_uname.Clear()
        txtbox_pass.Clear()
        txtbox_position.Clear()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Call Delete()

        lvUL.Items.Clear()
        Call Fill_User()
    End Sub
    Private Sub lvUL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvUL.SelectedIndexChanged
        Dim dt As New DataTable

        Try
            For Each item As ListViewItem In lvUL.SelectedItems
                Dim first, last As Integer
                Dim str As String = item.SubItems(0).ToString
                first = str.IndexOf("{")
                last = str.LastIndexOf("}")
                str = item.SubItems(0).ToString.Substring(first + 1, last - first - 1)


                'MessageBox.Show(str)
                Call ViewSelectedlvDetails(str)
                txtbox_UserID.Text = str

            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbox_uname_TextChanged(sender As Object, e As EventArgs) Handles txtbox_uname.TextChanged
        If txtbox_uname.Text.Count <= 0 Then
            Dim dt As DataTable
            dt = ExecuteQuery("SELECT * FROM User")

            txtbox_UserID.Text = dt.Rows.Count + 1
        End If
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        Me.Hide()
        frm_cd_manager.Show()
    End Sub

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        MsgBox("You are already in User")
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Hide()
        frm_manager.Show()
    End Sub
End Class