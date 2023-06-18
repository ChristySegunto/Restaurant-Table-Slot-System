<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cd_manager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cd_manager))
        Me.txtbox_search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_filter = New System.Windows.Forms.Label()
        Me.cmb_filter = New System.Windows.Forms.ComboBox()
        Me.dtp_reservationtime = New System.Windows.Forms.DateTimePicker()
        Me.lbl_reservationtime = New System.Windows.Forms.Label()
        Me.txtbox_reservationnum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lvPL = New System.Windows.Forms.ListView()
        Me.ReservationNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rsrvee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cntctnum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Rsrvnum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tblnum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Rsrvdate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Rsrvtime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txtbox_tablenum = New System.Windows.Forms.TextBox()
        Me.dtp_reservationdate = New System.Windows.Forms.DateTimePicker()
        Me.txtbox_nop = New System.Windows.Forms.TextBox()
        Me.txtbox_contact = New System.Windows.Forms.TextBox()
        Me.txtbox_reservee = New System.Windows.Forms.TextBox()
        Me.lbl_tablenumber = New System.Windows.Forms.Label()
        Me.lbl_reservationdate = New System.Windows.Forms.Label()
        Me.lbl_nor = New System.Windows.Forms.Label()
        Me.lbl_contactno = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.btn_user = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_availability = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbox_search
        '
        Me.txtbox_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtbox_search.Location = New System.Drawing.Point(622, 130)
        Me.txtbox_search.Name = "txtbox_search"
        Me.txtbox_search.Size = New System.Drawing.Size(193, 27)
        Me.txtbox_search.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(547, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Search:"
        '
        'lbl_filter
        '
        Me.lbl_filter.AutoSize = True
        Me.lbl_filter.BackColor = System.Drawing.Color.Transparent
        Me.lbl_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_filter.Location = New System.Drawing.Point(292, 134)
        Me.lbl_filter.Name = "lbl_filter"
        Me.lbl_filter.Size = New System.Drawing.Size(52, 20)
        Me.lbl_filter.TabIndex = 62
        Me.lbl_filter.Text = "Filter:"
        '
        'cmb_filter
        '
        Me.cmb_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.cmb_filter.FormattingEnabled = True
        Me.cmb_filter.Items.AddRange(New Object() {"Reservation Number", "Reservee", "Contact Number", "No. of Reservation", "Table Number", "Date of Reservation", "Time of Reservation"})
        Me.cmb_filter.Location = New System.Drawing.Point(353, 130)
        Me.cmb_filter.Name = "cmb_filter"
        Me.cmb_filter.Size = New System.Drawing.Size(172, 28)
        Me.cmb_filter.TabIndex = 61
        '
        'dtp_reservationtime
        '
        Me.dtp_reservationtime.CustomFormat = "hh:mm tt"
        Me.dtp_reservationtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_reservationtime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_reservationtime.Location = New System.Drawing.Point(179, 424)
        Me.dtp_reservationtime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp_reservationtime.Name = "dtp_reservationtime"
        Me.dtp_reservationtime.ShowUpDown = True
        Me.dtp_reservationtime.Size = New System.Drawing.Size(111, 27)
        Me.dtp_reservationtime.TabIndex = 60
        Me.dtp_reservationtime.Value = New Date(2021, 2, 9, 0, 0, 0, 0)
        '
        'lbl_reservationtime
        '
        Me.lbl_reservationtime.AutoSize = True
        Me.lbl_reservationtime.BackColor = System.Drawing.Color.Transparent
        Me.lbl_reservationtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reservationtime.Location = New System.Drawing.Point(3, 424)
        Me.lbl_reservationtime.Name = "lbl_reservationtime"
        Me.lbl_reservationtime.Size = New System.Drawing.Size(164, 20)
        Me.lbl_reservationtime.TabIndex = 59
        Me.lbl_reservationtime.Text = "Time of Reservation:"
        '
        'txtbox_reservationnum
        '
        Me.txtbox_reservationnum.Enabled = False
        Me.txtbox_reservationnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_reservationnum.Location = New System.Drawing.Point(176, 191)
        Me.txtbox_reservationnum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_reservationnum.Name = "txtbox_reservationnum"
        Me.txtbox_reservationnum.Size = New System.Drawing.Size(111, 27)
        Me.txtbox_reservationnum.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 20)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Reservation Number:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(1002, 29)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 85)
        Me.PictureBox2.TabIndex = 56
        Me.PictureBox2.TabStop = False
        '
        'lvPL
        '
        Me.lvPL.BackColor = System.Drawing.Color.Pink
        Me.lvPL.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ReservationNumber, Me.rsrvee, Me.Cntctnum, Me.Rsrvnum, Me.Tblnum, Me.Rsrvdate, Me.Rsrvtime})
        Me.lvPL.HideSelection = False
        Me.lvPL.Location = New System.Drawing.Point(296, 168)
        Me.lvPL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lvPL.Name = "lvPL"
        Me.lvPL.Size = New System.Drawing.Size(793, 489)
        Me.lvPL.TabIndex = 55
        Me.lvPL.UseCompatibleStateImageBehavior = False
        Me.lvPL.View = System.Windows.Forms.View.Details
        '
        'ReservationNumber
        '
        Me.ReservationNumber.Text = "Reservation Number"
        Me.ReservationNumber.Width = 120
        '
        'rsrvee
        '
        Me.rsrvee.Text = "Reservee"
        Me.rsrvee.Width = 160
        '
        'Cntctnum
        '
        Me.Cntctnum.Text = "Contact Number"
        Me.Cntctnum.Width = 140
        '
        'Rsrvnum
        '
        Me.Rsrvnum.Text = "No. of Person"
        Me.Rsrvnum.Width = 130
        '
        'Tblnum
        '
        Me.Tblnum.Text = "Table Number"
        Me.Tblnum.Width = 100
        '
        'Rsrvdate
        '
        Me.Rsrvdate.Text = "Date of Reservation"
        Me.Rsrvdate.Width = 150
        '
        'Rsrvtime
        '
        Me.Rsrvtime.Text = "Time of Reservation"
        Me.Rsrvtime.Width = 100
        '
        'btn_delete
        '
        Me.btn_delete.BackgroundImage = CType(resources.GetObject("btn_delete.BackgroundImage"), System.Drawing.Image)
        Me.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_delete.Location = New System.Drawing.Point(85, 521)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(104, 38)
        Me.btn_delete.TabIndex = 54
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.BackgroundImage = CType(resources.GetObject("btn_edit.BackgroundImage"), System.Drawing.Image)
        Me.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_edit.Location = New System.Drawing.Point(168, 479)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(104, 38)
        Me.btn_edit.TabIndex = 53
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.BackgroundImage = CType(resources.GetObject("btn_add.BackgroundImage"), System.Drawing.Image)
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.Location = New System.Drawing.Point(12, 479)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(104, 38)
        Me.btn_add.TabIndex = 52
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'txtbox_tablenum
        '
        Me.txtbox_tablenum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_tablenum.Location = New System.Drawing.Point(141, 345)
        Me.txtbox_tablenum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_tablenum.Name = "txtbox_tablenum"
        Me.txtbox_tablenum.Size = New System.Drawing.Size(149, 27)
        Me.txtbox_tablenum.TabIndex = 51
        '
        'dtp_reservationdate
        '
        Me.dtp_reservationdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_reservationdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_reservationdate.Location = New System.Drawing.Point(179, 382)
        Me.dtp_reservationdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp_reservationdate.Name = "dtp_reservationdate"
        Me.dtp_reservationdate.Size = New System.Drawing.Size(111, 27)
        Me.dtp_reservationdate.TabIndex = 50
        Me.dtp_reservationdate.Value = New Date(2021, 2, 9, 11, 27, 0, 0)
        '
        'txtbox_nop
        '
        Me.txtbox_nop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_nop.Location = New System.Drawing.Point(159, 304)
        Me.txtbox_nop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_nop.Name = "txtbox_nop"
        Me.txtbox_nop.Size = New System.Drawing.Size(131, 27)
        Me.txtbox_nop.TabIndex = 49
        '
        'txtbox_contact
        '
        Me.txtbox_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_contact.Location = New System.Drawing.Point(107, 269)
        Me.txtbox_contact.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_contact.Name = "txtbox_contact"
        Me.txtbox_contact.Size = New System.Drawing.Size(183, 27)
        Me.txtbox_contact.TabIndex = 48
        '
        'txtbox_reservee
        '
        Me.txtbox_reservee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_reservee.Location = New System.Drawing.Point(107, 231)
        Me.txtbox_reservee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbox_reservee.Name = "txtbox_reservee"
        Me.txtbox_reservee.Size = New System.Drawing.Size(183, 27)
        Me.txtbox_reservee.TabIndex = 47
        '
        'lbl_tablenumber
        '
        Me.lbl_tablenumber.AutoSize = True
        Me.lbl_tablenumber.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tablenumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tablenumber.Location = New System.Drawing.Point(3, 348)
        Me.lbl_tablenumber.Name = "lbl_tablenumber"
        Me.lbl_tablenumber.Size = New System.Drawing.Size(119, 20)
        Me.lbl_tablenumber.TabIndex = 46
        Me.lbl_tablenumber.Text = "Table Number:"
        '
        'lbl_reservationdate
        '
        Me.lbl_reservationdate.AutoSize = True
        Me.lbl_reservationdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_reservationdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reservationdate.Location = New System.Drawing.Point(3, 387)
        Me.lbl_reservationdate.Name = "lbl_reservationdate"
        Me.lbl_reservationdate.Size = New System.Drawing.Size(163, 20)
        Me.lbl_reservationdate.TabIndex = 45
        Me.lbl_reservationdate.Text = "Date of Reservation:"
        '
        'lbl_nor
        '
        Me.lbl_nor.AutoSize = True
        Me.lbl_nor.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nor.Location = New System.Drawing.Point(3, 311)
        Me.lbl_nor.Name = "lbl_nor"
        Me.lbl_nor.Size = New System.Drawing.Size(150, 20)
        Me.lbl_nor.TabIndex = 44
        Me.lbl_nor.Text = "Number of Person:"
        '
        'lbl_contactno
        '
        Me.lbl_contactno.AutoSize = True
        Me.lbl_contactno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contactno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contactno.Location = New System.Drawing.Point(3, 272)
        Me.lbl_contactno.Name = "lbl_contactno"
        Me.lbl_contactno.Size = New System.Drawing.Size(86, 20)
        Me.lbl_contactno.TabIndex = 43
        Me.lbl_contactno.Text = "Contact #:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(3, 238)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(85, 20)
        Me.lbl_name.TabIndex = 42
        Me.lbl_name.Text = "Reservee:"
        '
        'btn_user
        '
        Me.btn_user.BackgroundImage = CType(resources.GetObject("btn_user.BackgroundImage"), System.Drawing.Image)
        Me.btn_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_user.Location = New System.Drawing.Point(324, 48)
        Me.btn_user.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(149, 57)
        Me.btn_user.TabIndex = 41
        Me.btn_user.UseVisualStyleBackColor = True
        '
        'btn_customer
        '
        Me.btn_customer.BackgroundImage = CType(resources.GetObject("btn_customer.BackgroundImage"), System.Drawing.Image)
        Me.btn_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_customer.Location = New System.Drawing.Point(168, 48)
        Me.btn_customer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(149, 57)
        Me.btn_customer.TabIndex = 40
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'btn_availability
        '
        Me.btn_availability.BackgroundImage = CType(resources.GetObject("btn_availability.BackgroundImage"), System.Drawing.Image)
        Me.btn_availability.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_availability.Location = New System.Drawing.Point(12, 48)
        Me.btn_availability.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_availability.Name = "btn_availability"
        Me.btn_availability.Size = New System.Drawing.Size(149, 57)
        Me.btn_availability.TabIndex = 39
        Me.btn_availability.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.Transparent
        Me.btn_home.BackgroundImage = CType(resources.GetObject("btn_home.BackgroundImage"), System.Drawing.Image)
        Me.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_home.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_home.Location = New System.Drawing.Point(94, 576)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(89, 81)
        Me.btn_home.TabIndex = 65
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'frm_cd_manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1101, 673)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.txtbox_search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_filter)
        Me.Controls.Add(Me.cmb_filter)
        Me.Controls.Add(Me.dtp_reservationtime)
        Me.Controls.Add(Me.lbl_reservationtime)
        Me.Controls.Add(Me.txtbox_reservationnum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lvPL)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txtbox_tablenum)
        Me.Controls.Add(Me.dtp_reservationdate)
        Me.Controls.Add(Me.txtbox_nop)
        Me.Controls.Add(Me.txtbox_contact)
        Me.Controls.Add(Me.txtbox_reservee)
        Me.Controls.Add(Me.lbl_tablenumber)
        Me.Controls.Add(Me.lbl_reservationdate)
        Me.Controls.Add(Me.lbl_nor)
        Me.Controls.Add(Me.lbl_contactno)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.btn_user)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_availability)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cd_manager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurant Table Slot System"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbox_search As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_filter As Label
    Friend WithEvents cmb_filter As ComboBox
    Friend WithEvents dtp_reservationtime As DateTimePicker
    Friend WithEvents lbl_reservationtime As Label
    Friend WithEvents txtbox_reservationnum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lvPL As ListView
    Friend WithEvents ReservationNumber As ColumnHeader
    Friend WithEvents rsrvee As ColumnHeader
    Friend WithEvents Cntctnum As ColumnHeader
    Friend WithEvents Rsrvnum As ColumnHeader
    Friend WithEvents Tblnum As ColumnHeader
    Friend WithEvents Rsrvdate As ColumnHeader
    Friend WithEvents Rsrvtime As ColumnHeader
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents txtbox_tablenum As TextBox
    Friend WithEvents dtp_reservationdate As DateTimePicker
    Friend WithEvents txtbox_nop As TextBox
    Friend WithEvents txtbox_contact As TextBox
    Friend WithEvents txtbox_reservee As TextBox
    Friend WithEvents lbl_tablenumber As Label
    Friend WithEvents lbl_reservationdate As Label
    Friend WithEvents lbl_nor As Label
    Friend WithEvents lbl_contactno As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents btn_user As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_availability As Button
    Friend WithEvents btn_home As Button
End Class
