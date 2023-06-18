
Public Class frm_login
    Dim tries As Integer = 0
    Dim Attempts As Integer = 5
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        If txt_user.Text = Nothing Or txt_pass.Text = Nothing Then
            'condition sya na kapag wala yung nakalagay sa text box, mag shoshow ung message box
            MessageBox.Show("Please enter your correct credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Try
            TSS(txt_user.Text.Trim, txt_pass.Text.Trim)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Public Sub TSS(ByVal Username As String, ByVal Password As String)


        Try
            Dim dt As New DataTable
            Dim Posi As String


            dt = ExecuteQuery("SELECT * FROM [User] WHERE Username = '" & txt_user.Text.Trim & "'")
            ' run the function na nag seselect ng item sa database user
            ' makakapagselect lang sa table na user kapag ung ininsert natin sa txt_user is equal sa username.


            If tries >= 0 And tries <> 4 Then
                If dt.Rows.Count > 0 Then
                    Posi = dt.Rows(0)("Position")
                    If dt.Rows(0)("Username") = Username Then
                        If dt.Rows(0)("Password") = Password Then
                            If Posi = "Owner" Then
                                MessageBox.Show("Log In Successful As Owner", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Hide()
                                Frm_owner.Show()
                                txt_user.Clear()
                                txt_pass.Clear()

                            ElseIf Posi = "Receptionist" Then
                                MessageBox.Show("Log In Successful As Receptionist", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Hide()
                                frm_receptionist.Show()
                                txt_user.Clear()
                                txt_pass.Clear()

                            ElseIf Posi = "Manager" Then
                                MessageBox.Show("Log In Successful As Manager", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Hide()
                                frm_manager.Show()
                                txt_user.Clear()
                                txt_pass.Clear()

                            End If
                        Else
                            MessageBox.Show("Invalid Username/Password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            tries = tries + 1
                            Attempts = Attempts - 1
                            MsgBox("You only have " + Attempts.ToString + " attempts left")
                        End If

                    End If
                Else
                    MessageBox.Show("Invalid Username/Password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tries = tries + 1
                    Attempts = Attempts - 1
                    MsgBox("You only have " + Attempts.ToString + " attempts left")
                End If

            Else
                MsgBox("No more attemps left. The system will now close")
                txt_user.Clear()
                txt_pass.Clear()
                Close()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class



