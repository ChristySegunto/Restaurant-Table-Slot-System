<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.picbox_pass = New System.Windows.Forms.PictureBox()
        Me.picbox_user = New System.Windows.Forms.PictureBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.picbox_rtss = New System.Windows.Forms.PictureBox()
        Me.lbl_login = New System.Windows.Forms.Label()
        CType(Me.picbox_pass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_rtss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picbox_pass
        '
        Me.picbox_pass.BackColor = System.Drawing.Color.Transparent
        Me.picbox_pass.Image = CType(resources.GetObject("picbox_pass.Image"), System.Drawing.Image)
        Me.picbox_pass.Location = New System.Drawing.Point(523, 303)
        Me.picbox_pass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picbox_pass.Name = "picbox_pass"
        Me.picbox_pass.Size = New System.Drawing.Size(49, 37)
        Me.picbox_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox_pass.TabIndex = 15
        Me.picbox_pass.TabStop = False
        '
        'picbox_user
        '
        Me.picbox_user.BackColor = System.Drawing.Color.Transparent
        Me.picbox_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picbox_user.Image = CType(resources.GetObject("picbox_user.Image"), System.Drawing.Image)
        Me.picbox_user.Location = New System.Drawing.Point(523, 238)
        Me.picbox_user.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picbox_user.Name = "picbox_user"
        Me.picbox_user.Size = New System.Drawing.Size(49, 39)
        Me.picbox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox_user.TabIndex = 14
        Me.picbox_user.TabStop = False
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_login.Location = New System.Drawing.Point(734, 370)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(109, 33)
        Me.btn_login.TabIndex = 13
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'txt_pass
        '
        Me.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_pass.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(579, 304)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(264, 31)
        Me.txt_pass.TabIndex = 12
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.Color.White
        Me.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_user.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(579, 239)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(264, 31)
        Me.txt_user.TabIndex = 11
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(579, 250)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(264, 27)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(579, 313)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(264, 27)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 17
        Me.PictureBox5.TabStop = False
        '
        'picbox_rtss
        '
        Me.picbox_rtss.BackColor = System.Drawing.Color.Transparent
        Me.picbox_rtss.BackgroundImage = CType(resources.GetObject("picbox_rtss.BackgroundImage"), System.Drawing.Image)
        Me.picbox_rtss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picbox_rtss.Location = New System.Drawing.Point(-4, 49)
        Me.picbox_rtss.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picbox_rtss.Name = "picbox_rtss"
        Me.picbox_rtss.Size = New System.Drawing.Size(492, 490)
        Me.picbox_rtss.TabIndex = 18
        Me.picbox_rtss.TabStop = False
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.BackColor = System.Drawing.Color.Transparent
        Me.lbl_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_login.Location = New System.Drawing.Point(515, 167)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(148, 46)
        Me.lbl_login.TabIndex = 19
        Me.lbl_login.Text = "LOGIN"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(903, 590)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.picbox_rtss)
        Me.Controls.Add(Me.picbox_pass)
        Me.Controls.Add(Me.picbox_user)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurant Table Slot System"
        CType(Me.picbox_pass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_rtss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picbox_pass As PictureBox
    Friend WithEvents picbox_user As PictureBox
    Friend WithEvents btn_login As Button
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents picbox_rtss As PictureBox
    Friend WithEvents lbl_login As Label
End Class
