<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tablesavail_receptionist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tablesavail_receptionist))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.lvShortCD = New System.Windows.Forms.ListView()
        Me.ReservationNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rsrvee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Rsrvnum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tblnum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Rsrvtime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_Table12 = New System.Windows.Forms.ComboBox()
        Me.table12 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_Table11 = New System.Windows.Forms.ComboBox()
        Me.table11 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_Table10 = New System.Windows.Forms.ComboBox()
        Me.table10 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_Table9 = New System.Windows.Forms.ComboBox()
        Me.table9 = New System.Windows.Forms.PictureBox()
        Me.cmb_Table8 = New System.Windows.Forms.ComboBox()
        Me.table8 = New System.Windows.Forms.PictureBox()
        Me.cmb_Table7 = New System.Windows.Forms.ComboBox()
        Me.table7 = New System.Windows.Forms.PictureBox()
        Me.cmb_Table6 = New System.Windows.Forms.ComboBox()
        Me.table6 = New System.Windows.Forms.PictureBox()
        Me.cmb_Table5 = New System.Windows.Forms.ComboBox()
        Me.table5 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_Table4 = New System.Windows.Forms.ComboBox()
        Me.cmb_Table3 = New System.Windows.Forms.ComboBox()
        Me.cmb_Table2 = New System.Windows.Forms.ComboBox()
        Me.cmb_Table1 = New System.Windows.Forms.ComboBox()
        Me.table4 = New System.Windows.Forms.PictureBox()
        Me.table3 = New System.Windows.Forms.PictureBox()
        Me.table2 = New System.Windows.Forms.PictureBox()
        Me.table1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_availability = New System.Windows.Forms.Button()
        CType(Me.table12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(761, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(188, 25)
        Me.Label13.TabIndex = 166
        Me.Label13.Text = "Date of Reservation:"
        '
        'dtp_date
        '
        Me.dtp_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date.Location = New System.Drawing.Point(978, 159)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(165, 30)
        Me.dtp_date.TabIndex = 165
        '
        'lvShortCD
        '
        Me.lvShortCD.BackColor = System.Drawing.Color.Pink
        Me.lvShortCD.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ReservationNumber, Me.rsrvee, Me.Rsrvnum, Me.Tblnum, Me.Rsrvtime})
        Me.lvShortCD.HideSelection = False
        Me.lvShortCD.Location = New System.Drawing.Point(754, 201)
        Me.lvShortCD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lvShortCD.Name = "lvShortCD"
        Me.lvShortCD.Size = New System.Drawing.Size(539, 366)
        Me.lvShortCD.TabIndex = 164
        Me.lvShortCD.UseCompatibleStateImageBehavior = False
        Me.lvShortCD.View = System.Windows.Forms.View.Details
        '
        'ReservationNumber
        '
        Me.ReservationNumber.Text = "Reservation #"
        Me.ReservationNumber.Width = 120
        '
        'rsrvee
        '
        Me.rsrvee.Text = "Reservee"
        Me.rsrvee.Width = 130
        '
        'Rsrvnum
        '
        Me.Rsrvnum.Text = "# of People"
        Me.Rsrvnum.Width = 100
        '
        'Tblnum
        '
        Me.Tblnum.Text = "Table #"
        Me.Tblnum.Width = 80
        '
        'Rsrvtime
        '
        Me.Rsrvtime.Text = "Time"
        Me.Rsrvtime.Width = 100
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label12.Location = New System.Drawing.Point(614, 499)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 29)
        Me.Label12.TabIndex = 163
        Me.Label12.Text = "12"
        '
        'cmb_Table12
        '
        Me.cmb_Table12.BackColor = System.Drawing.Color.White
        Me.cmb_Table12.FormattingEnabled = True
        Me.cmb_Table12.Items.AddRange(New Object() {"Available", "Reserved", "Occupied"})
        Me.cmb_Table12.Location = New System.Drawing.Point(568, 562)
        Me.cmb_Table12.Name = "cmb_Table12"
        Me.cmb_Table12.Size = New System.Drawing.Size(128, 24)
        Me.cmb_Table12.TabIndex = 162
        Me.cmb_Table12.Text = "Available"
        '
        'table12
        '
        Me.table12.BackColor = System.Drawing.Color.Transparent
        Me.table12.Location = New System.Drawing.Point(568, 482)
        Me.table12.Name = "table12"
        Me.table12.Size = New System.Drawing.Size(134, 61)
        Me.table12.TabIndex = 161
        Me.table12.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.Location = New System.Drawing.Point(437, 499)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 29)
        Me.Label11.TabIndex = 160
        Me.Label11.Text = "11"
        '
        'cmb_Table11
        '
        Me.cmb_Table11.BackColor = System.Drawing.Color.White
        Me.cmb_Table11.FormattingEnabled = True
        Me.cmb_Table11.Items.AddRange(New Object() {"Available", "Reserved", "Occupied"})
        Me.cmb_Table11.Location = New System.Drawing.Point(390, 562)
        Me.cmb_Table11.Name = "cmb_Table11"
        Me.cmb_Table11.Size = New System.Drawing.Size(128, 24)
        Me.cmb_Table11.TabIndex = 159
        Me.cmb_Table11.Text = "Available"
        '
        'table11
        '
        Me.table11.BackColor = System.Drawing.Color.Transparent
        Me.table11.Location = New System.Drawing.Point(390, 482)
        Me.table11.Name = "table11"
        Me.table11.Size = New System.Drawing.Size(134, 61)
        Me.table11.TabIndex = 158
        Me.table11.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Location = New System.Drawing.Point(257, 499)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 29)
        Me.Label10.TabIndex = 157
        Me.Label10.Text = "10"
        '
        'cmb_Table10
        '
        Me.cmb_Table10.BackColor = System.Drawing.Color.White
        Me.cmb_Table10.FormattingEnabled = True
        Me.cmb_Table10.Items.AddRange(New Object() {"Available", "Reserved", "Occupied"})
        Me.cmb_Table10.Location = New System.Drawing.Point(209, 562)
        Me.cmb_Table10.Name = "cmb_Table10"
        Me.cmb_Table10.Size = New System.Drawing.Size(128, 24)
        Me.cmb_Table10.TabIndex = 156
        Me.cmb_Table10.Text = "Available"
        '
        'table10
        '
        Me.table10.BackColor = System.Drawing.Color.Transparent
        Me.table10.Location = New System.Drawing.Point(209, 482)
        Me.table10.Name = "table10"
        Me.table10.Size = New System.Drawing.Size(134, 61)
        Me.table10.TabIndex = 155
        Me.table10.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Location = New System.Drawing.Point(80, 499)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 29)
        Me.Label9.TabIndex = 154
        Me.Label9.Text = "9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Location = New System.Drawing.Point(623, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 29)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(445, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 29)
        Me.Label7.TabIndex = 152
        Me.Label7.Text = "7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(263, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 29)
        Me.Label6.TabIndex = 151
        Me.Label6.Text = "6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(80, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 29)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "5"
        '
        'cmb_Table9
        '
        Me.cmb_Table9.BackColor = System.Drawing.Color.White
        Me.cmb_Table9.FormattingEnabled = True
        Me.cmb_Table9.Items.AddRange(New Object() {"Available", "Reserved", "Occupied"})
        Me.cmb_Table9.Location = New System.Drawing.Point(28, 562)
        Me.cmb_Table9.Name = "cmb_Table9"
        Me.cmb_Table9.Size = New System.Drawing.Size(128, 24)
        Me.cmb_Table9.TabIndex = 149
        Me.cmb_Table9.Text = "Available"
        '
        'table9
        '
        Me.table9.BackColor = System.Drawing.Color.Transparent
        Me.table9.Location = New System.Drawing.Point(28, 482)
        Me.table9.Name = "table9"
        Me.table9.Size = New System.Drawing.Size(134, 61)
        Me.table9.TabIndex = 148
        Me.table9.TabStop = False
        '
        'cmb_Table8
        '
        Me.cmb_Table8.BackColor = System.Drawing.Color.White
        Me.cmb_Table8.FormattingEnabled = True
        Me.cmb_Table8.Items.AddRange(New Object() {"Available", "Reserved", "Occupied"})
        Me.cmb_Table8.Location = New System.Drawing.Point(568, 425)
        Me.cmb_Table8.Name = "cmb_Table8"
        Me.cmb_Table8.Size = New System.Drawing.Size(128, 24)
        Me.cmb_Table8.TabIndex = 147
        Me.cmb_Table8.Text = "Available"
        '
        'table8
        '
        Me.table8.BackColor = System.Drawing.Color.Transparent
        Me.table8.Location = New System.Drawing.Point(568, 290)
        Me.table8.Name = "table8"
        Me.table8.Size = New System.Drawing.Size(134, 112)
        Me.table8.TabIndex = 146
        Me.table8.TabStop = False
        '
        'cmb_Table7
        '
        Me.cmb_Table7.BackColor = System.Drawing.Color.White
        Me.cmb_Table7.FormattingEnabled = True
        Me.cmb_Table7.Items.AddRange(New Object() {"Available", "Reserved", "Occupied"})
        Me.cmb_Table7.Location = New System.Drawing.Point(390, 425)
        Me.cmb_Table7.Name = "cmb_Table7"
        Me.cmb_Table7.Size = New System.Drawing.Size(128, 24)
        Me.cmb_Table7.TabIndex = 145
        Me.cmb_Table7.Text = "Available"
        '
        'table7
        '
        Me.table7.BackColor = System.Drawing.Color.Transparent
        Me.table7.Location = New System.Drawing.Point(390, 290)
        Me.table7.Name = "table7"
        Me.table7.Size = New System.Drawing.Size(134, 112)
        Me.table7.TabIndex = 144
        Me.table7.TabStop = False
        '
        'cmb_Table6
        '
        Me.cmb_Table6.BackColor = System.Drawing.Color.White
        Me.cmb_Table6.FormattingEnabled = True
        Me.cmb_Table6.Items.AddRange(New Object() {"Available", "Reserved", "Occupied"})
        Me.cmb_Table6.Location = New System.Drawing.Point(209, 425)
        Me.cmb_Table6.Name = "cmb_Table6"
        Me.cmb_Table6.Size = New System.Drawing.Size(128, 24)
        Me.cmb_Table6.TabIndex = 143
        Me.cmb_Table6.Text = "Available"
        '
        'table6
        '
        Me.table6.BackColor = System.Drawing.Color.Transparent
        Me.table6.Location = New System.Drawing.Point(209, 290)
        Me.table6.Name = "table6"
        Me.table6.Size = New System.Drawing.Size(134, 112)
        Me.table6.TabIndex = 142
        Me.table6.TabStop = False
        '
        'cmb_Table5
        '
        Me.cmb_Table5.BackColor = System.Drawing.Color.White
        Me.cmb_Table5.FormattingEnabled = True
        Me.cmb_Table5.Items.AddRange(New Object() {"Available", "Reserved", "Occupied"})
        Me.cmb_Table5.Location = New System.Drawing.Point(28, 425)
        Me.cmb_Table5.Name = "cmb_Table5"
        Me.cmb_Table5.Size = New System.Drawing.Size(128, 24)
        Me.cmb_Table5.TabIndex = 141
        Me.cmb_Table5.Text = "Available"
        '
        'table5
        '
        Me.table5.BackColor = System.Drawing.Color.Transparent
        Me.table5.Location = New System.Drawing.Point(28, 290)
        Me.table5.Name = "table5"
        Me.table5.Size = New System.Drawing.Size(134, 112)
        Me.table5.TabIndex = 140
        Me.table5.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(623, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 29)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(445, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 29)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(263, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 29)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(80, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 29)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "1"
        '
        'cmb_Table4
        '
        Me.cmb_Table4.BackColor = System.Drawing.Color.White
        Me.cmb_Table4.FormattingEnabled = True
        Me.cmb_Table4.Items.AddRange(New Object() {"Available", "Reserved", "Occupied"})
        Me.cmb_Table4.Location = New System.Drawing.Point(568, 230)
        Me.cmb_Table4.Name = "cmb_Table4"
        Me.cmb_Table4.Size = New System.Drawing.Size(128, 24)
        Me.cmb_Table4.TabIndex = 135
        Me.cmb_Table4.Text = "Available"
        '
        'cmb_Table3
        '
        Me.cmb_Table3.BackColor = System.Drawing.Color.White
        Me.cmb_Table3.FormattingEnabled = True
        Me.cmb_Table3.Items.AddRange(New Object() {"Available", "Reserved", "Occupied"})
        Me.cmb_Table3.Location = New System.Drawing.Point(390, 230)
        Me.cmb_Table3.Name = "cmb_Table3"
        Me.cmb_Table3.Size = New System.Drawing.Size(128, 24)
        Me.cmb_Table3.TabIndex = 134
        Me.cmb_Table3.Text = "Available"
        '
        'cmb_Table2
        '
        Me.cmb_Table2.BackColor = System.Drawing.Color.White
        Me.cmb_Table2.FormattingEnabled = True
        Me.cmb_Table2.Items.AddRange(New Object() {"Available", "Reserved", "Occupied"})
        Me.cmb_Table2.Location = New System.Drawing.Point(209, 230)
        Me.cmb_Table2.Name = "cmb_Table2"
        Me.cmb_Table2.Size = New System.Drawing.Size(128, 24)
        Me.cmb_Table2.TabIndex = 133
        Me.cmb_Table2.Text = "Available"
        '
        'cmb_Table1
        '
        Me.cmb_Table1.BackColor = System.Drawing.Color.White
        Me.cmb_Table1.FormattingEnabled = True
        Me.cmb_Table1.Items.AddRange(New Object() {"Available", "Reserved", "Occupied"})
        Me.cmb_Table1.Location = New System.Drawing.Point(28, 230)
        Me.cmb_Table1.Name = "cmb_Table1"
        Me.cmb_Table1.Size = New System.Drawing.Size(128, 24)
        Me.cmb_Table1.TabIndex = 132
        Me.cmb_Table1.Text = "Available"
        '
        'table4
        '
        Me.table4.BackColor = System.Drawing.Color.Transparent
        Me.table4.Location = New System.Drawing.Point(568, 150)
        Me.table4.Name = "table4"
        Me.table4.Size = New System.Drawing.Size(134, 61)
        Me.table4.TabIndex = 131
        Me.table4.TabStop = False
        '
        'table3
        '
        Me.table3.BackColor = System.Drawing.Color.Transparent
        Me.table3.Location = New System.Drawing.Point(390, 150)
        Me.table3.Name = "table3"
        Me.table3.Size = New System.Drawing.Size(134, 61)
        Me.table3.TabIndex = 130
        Me.table3.TabStop = False
        '
        'table2
        '
        Me.table2.BackColor = System.Drawing.Color.Transparent
        Me.table2.Location = New System.Drawing.Point(209, 150)
        Me.table2.Name = "table2"
        Me.table2.Size = New System.Drawing.Size(134, 61)
        Me.table2.TabIndex = 129
        Me.table2.TabStop = False
        '
        'table1
        '
        Me.table1.BackColor = System.Drawing.Color.Transparent
        Me.table1.Location = New System.Drawing.Point(28, 150)
        Me.table1.Name = "table1"
        Me.table1.Size = New System.Drawing.Size(134, 61)
        Me.table1.TabIndex = 128
        Me.table1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(1206, 14)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 85)
        Me.PictureBox2.TabIndex = 127
        Me.PictureBox2.TabStop = False
        '
        'btn_customer
        '
        Me.btn_customer.BackgroundImage = CType(resources.GetObject("btn_customer.BackgroundImage"), System.Drawing.Image)
        Me.btn_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_customer.Location = New System.Drawing.Point(171, 42)
        Me.btn_customer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(149, 57)
        Me.btn_customer.TabIndex = 125
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'btn_availability
        '
        Me.btn_availability.BackgroundImage = CType(resources.GetObject("btn_availability.BackgroundImage"), System.Drawing.Image)
        Me.btn_availability.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_availability.Location = New System.Drawing.Point(15, 42)
        Me.btn_availability.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_availability.Name = "btn_availability"
        Me.btn_availability.Size = New System.Drawing.Size(149, 57)
        Me.btn_availability.TabIndex = 124
        Me.btn_availability.UseVisualStyleBackColor = True
        '
        'frm_tablesavail_receptionist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1314, 618)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.lvShortCD)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmb_Table12)
        Me.Controls.Add(Me.table12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmb_Table11)
        Me.Controls.Add(Me.table11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmb_Table10)
        Me.Controls.Add(Me.table10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_Table9)
        Me.Controls.Add(Me.table9)
        Me.Controls.Add(Me.cmb_Table8)
        Me.Controls.Add(Me.table8)
        Me.Controls.Add(Me.cmb_Table7)
        Me.Controls.Add(Me.table7)
        Me.Controls.Add(Me.cmb_Table6)
        Me.Controls.Add(Me.table6)
        Me.Controls.Add(Me.cmb_Table5)
        Me.Controls.Add(Me.table5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Table4)
        Me.Controls.Add(Me.cmb_Table3)
        Me.Controls.Add(Me.cmb_Table2)
        Me.Controls.Add(Me.cmb_Table1)
        Me.Controls.Add(Me.table4)
        Me.Controls.Add(Me.table3)
        Me.Controls.Add(Me.table2)
        Me.Controls.Add(Me.table1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_availability)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_tablesavail_receptionist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurant Table Slot System"
        CType(Me.table12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents dtp_date As DateTimePicker
    Friend WithEvents lvShortCD As ListView
    Friend WithEvents ReservationNumber As ColumnHeader
    Friend WithEvents rsrvee As ColumnHeader
    Friend WithEvents Rsrvnum As ColumnHeader
    Friend WithEvents Tblnum As ColumnHeader
    Friend WithEvents Rsrvtime As ColumnHeader
    Friend WithEvents Label12 As Label
    Friend WithEvents cmb_Table12 As ComboBox
    Friend WithEvents table12 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmb_Table11 As ComboBox
    Friend WithEvents table11 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmb_Table10 As ComboBox
    Friend WithEvents table10 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_Table9 As ComboBox
    Friend WithEvents table9 As PictureBox
    Friend WithEvents cmb_Table8 As ComboBox
    Friend WithEvents table8 As PictureBox
    Friend WithEvents cmb_Table7 As ComboBox
    Friend WithEvents table7 As PictureBox
    Friend WithEvents cmb_Table6 As ComboBox
    Friend WithEvents table6 As PictureBox
    Friend WithEvents cmb_Table5 As ComboBox
    Friend WithEvents table5 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_Table4 As ComboBox
    Friend WithEvents cmb_Table3 As ComboBox
    Friend WithEvents cmb_Table2 As ComboBox
    Friend WithEvents cmb_Table1 As ComboBox
    Friend WithEvents table4 As PictureBox
    Friend WithEvents table3 As PictureBox
    Friend WithEvents table2 As PictureBox
    Friend WithEvents table1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_availability As Button
End Class
