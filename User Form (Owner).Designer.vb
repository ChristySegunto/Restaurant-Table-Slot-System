<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_user
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_user))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_reports = New System.Windows.Forms.Button()
        Me.btn_user = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_availability = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txtbox_UserID = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.txtbox_position = New System.Windows.Forms.TextBox()
        Me.btn_signup = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbox_pass = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_pass = New System.Windows.Forms.Label()
        Me.txtbox_uname = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lbl_un = New System.Windows.Forms.Label()
        Me.lvUL = New System.Windows.Forms.ListView()
        Me.userid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.un = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pw = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_home = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(884, 23)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 85)
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'btn_reports
        '
        Me.btn_reports.BackgroundImage = CType(resources.GetObject("btn_reports.BackgroundImage"), System.Drawing.Image)
        Me.btn_reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_reports.Location = New System.Drawing.Point(477, 43)
        Me.btn_reports.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_reports.Name = "btn_reports"
        Me.btn_reports.Size = New System.Drawing.Size(149, 57)
        Me.btn_reports.TabIndex = 34
        Me.btn_reports.UseVisualStyleBackColor = True
        '
        'btn_user
        '
        Me.btn_user.BackgroundImage = CType(resources.GetObject("btn_user.BackgroundImage"), System.Drawing.Image)
        Me.btn_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_user.Location = New System.Drawing.Point(321, 43)
        Me.btn_user.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(149, 57)
        Me.btn_user.TabIndex = 33
        Me.btn_user.UseVisualStyleBackColor = True
        '
        'btn_customer
        '
        Me.btn_customer.BackgroundImage = CType(resources.GetObject("btn_customer.BackgroundImage"), System.Drawing.Image)
        Me.btn_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_customer.Location = New System.Drawing.Point(165, 43)
        Me.btn_customer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(149, 57)
        Me.btn_customer.TabIndex = 32
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'btn_availability
        '
        Me.btn_availability.BackgroundImage = CType(resources.GetObject("btn_availability.BackgroundImage"), System.Drawing.Image)
        Me.btn_availability.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_availability.Location = New System.Drawing.Point(9, 43)
        Me.btn_availability.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_availability.Name = "btn_availability"
        Me.btn_availability.Size = New System.Drawing.Size(149, 57)
        Me.btn_availability.TabIndex = 31
        Me.btn_availability.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_edit.Location = New System.Drawing.Point(202, 492)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(109, 33)
        Me.btn_edit.TabIndex = 93
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_delete.Location = New System.Drawing.Point(53, 492)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(109, 33)
        Me.btn_delete.TabIndex = 92
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'txtbox_UserID
        '
        Me.txtbox_UserID.BackColor = System.Drawing.Color.White
        Me.txtbox_UserID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_UserID.Enabled = False
        Me.txtbox_UserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_UserID.Location = New System.Drawing.Point(143, 190)
        Me.txtbox_UserID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_UserID.Name = "txtbox_UserID"
        Me.txtbox_UserID.Size = New System.Drawing.Size(195, 25)
        Me.txtbox_UserID.TabIndex = 90
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(143, 201)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(195, 27)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 91
        Me.PictureBox5.TabStop = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.Transparent
        Me.lbl_id.Location = New System.Drawing.Point(19, 196)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(62, 18)
        Me.lbl_id.TabIndex = 89
        Me.lbl_id.Text = "User ID:"
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_clear.Location = New System.Drawing.Point(53, 440)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(109, 33)
        Me.btn_clear.TabIndex = 88
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'txtbox_position
        '
        Me.txtbox_position.BackColor = System.Drawing.Color.White
        Me.txtbox_position.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_position.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_position.Location = New System.Drawing.Point(143, 377)
        Me.txtbox_position.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_position.Name = "txtbox_position"
        Me.txtbox_position.Size = New System.Drawing.Size(195, 25)
        Me.txtbox_position.TabIndex = 87
        '
        'btn_signup
        '
        Me.btn_signup.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_signup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_signup.Location = New System.Drawing.Point(202, 440)
        Me.btn_signup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_signup.Name = "btn_signup"
        Me.btn_signup.Size = New System.Drawing.Size(109, 33)
        Me.btn_signup.TabIndex = 86
        Me.btn_signup.Text = "Sign-up"
        Me.btn_signup.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(143, 386)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(195, 27)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 85
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(19, 381)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Position:"
        '
        'txtbox_pass
        '
        Me.txtbox_pass.BackColor = System.Drawing.Color.White
        Me.txtbox_pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_pass.Location = New System.Drawing.Point(143, 315)
        Me.txtbox_pass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_pass.Name = "txtbox_pass"
        Me.txtbox_pass.Size = New System.Drawing.Size(195, 25)
        Me.txtbox_pass.TabIndex = 82
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(143, 326)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'Lbl_pass
        '
        Me.Lbl_pass.AutoSize = True
        Me.Lbl_pass.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Lbl_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_pass.ForeColor = System.Drawing.Color.Transparent
        Me.Lbl_pass.Location = New System.Drawing.Point(19, 321)
        Me.Lbl_pass.Name = "Lbl_pass"
        Me.Lbl_pass.Size = New System.Drawing.Size(79, 18)
        Me.Lbl_pass.TabIndex = 81
        Me.Lbl_pass.Text = "Password:"
        '
        'txtbox_uname
        '
        Me.txtbox_uname.BackColor = System.Drawing.Color.White
        Me.txtbox_uname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_uname.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_uname.Location = New System.Drawing.Point(143, 246)
        Me.txtbox_uname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_uname.Name = "txtbox_uname"
        Me.txtbox_uname.Size = New System.Drawing.Size(195, 25)
        Me.txtbox_uname.TabIndex = 79
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(143, 257)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(195, 27)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 80
        Me.PictureBox4.TabStop = False
        '
        'lbl_un
        '
        Me.lbl_un.AutoSize = True
        Me.lbl_un.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_un.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_un.ForeColor = System.Drawing.Color.Transparent
        Me.lbl_un.Location = New System.Drawing.Point(19, 252)
        Me.lbl_un.Name = "lbl_un"
        Me.lbl_un.Size = New System.Drawing.Size(81, 18)
        Me.lbl_un.TabIndex = 78
        Me.lbl_un.Text = "Username:"
        '
        'lvUL
        '
        Me.lvUL.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.userid, Me.un, Me.pw, Me.Position})
        Me.lvUL.HideSelection = False
        Me.lvUL.Location = New System.Drawing.Point(354, 136)
        Me.lvUL.Name = "lvUL"
        Me.lvUL.Size = New System.Drawing.Size(617, 475)
        Me.lvUL.TabIndex = 77
        Me.lvUL.UseCompatibleStateImageBehavior = False
        Me.lvUL.View = System.Windows.Forms.View.Details
        '
        'userid
        '
        Me.userid.Text = "User ID"
        Me.userid.Width = 160
        '
        'un
        '
        Me.un.Text = "Username"
        Me.un.Width = 160
        '
        'pw
        '
        Me.pw.Text = "Password"
        Me.pw.Width = 160
        '
        'Position
        '
        Me.Position.Text = "Position"
        Me.Position.Width = 160
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.Transparent
        Me.btn_home.BackgroundImage = CType(resources.GetObject("btn_home.BackgroundImage"), System.Drawing.Image)
        Me.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_home.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_home.Location = New System.Drawing.Point(134, 530)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(89, 81)
        Me.btn_home.TabIndex = 94
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'frm_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(987, 620)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.txtbox_UserID)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.txtbox_position)
        Me.Controls.Add(Me.btn_signup)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbox_pass)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Lbl_pass)
        Me.Controls.Add(Me.txtbox_uname)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lbl_un)
        Me.Controls.Add(Me.lvUL)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_reports)
        Me.Controls.Add(Me.btn_user)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_availability)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurant Table Slot System"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_reports As Button
    Friend WithEvents btn_user As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_availability As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents txtbox_UserID As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents btn_clear As Button
    Friend WithEvents txtbox_position As TextBox
    Friend WithEvents btn_signup As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbox_pass As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_pass As Label
    Friend WithEvents txtbox_uname As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lbl_un As Label
    Friend WithEvents lvUL As ListView
    Friend WithEvents userid As ColumnHeader
    Friend WithEvents un As ColumnHeader
    Friend WithEvents pw As ColumnHeader
    Friend WithEvents Position As ColumnHeader
    Friend WithEvents btn_home As Button
End Class
