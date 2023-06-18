<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_reports))
        Me.btn_reports = New System.Windows.Forms.Button()
        Me.btn_user = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_availability = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lvReports = New System.Windows.Forms.ListView()
        Me.ReserNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tablenum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_dor = New System.Windows.Forms.Label()
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txtbox_total = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_reports
        '
        Me.btn_reports.BackgroundImage = CType(resources.GetObject("btn_reports.BackgroundImage"), System.Drawing.Image)
        Me.btn_reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_reports.Location = New System.Drawing.Point(476, 43)
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
        Me.btn_user.Location = New System.Drawing.Point(320, 43)
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
        Me.btn_customer.Location = New System.Drawing.Point(164, 43)
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
        Me.btn_availability.Location = New System.Drawing.Point(8, 43)
        Me.btn_availability.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_availability.Name = "btn_availability"
        Me.btn_availability.Size = New System.Drawing.Size(149, 57)
        Me.btn_availability.TabIndex = 31
        Me.btn_availability.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(854, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 85)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'lvReports
        '
        Me.lvReports.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ReserNum, Me.tablenum, Me.tor})
        Me.lvReports.HideSelection = False
        Me.lvReports.Location = New System.Drawing.Point(148, 181)
        Me.lvReports.Name = "lvReports"
        Me.lvReports.Size = New System.Drawing.Size(607, 381)
        Me.lvReports.TabIndex = 37
        Me.lvReports.UseCompatibleStateImageBehavior = False
        Me.lvReports.View = System.Windows.Forms.View.Details
        '
        'ReserNum
        '
        Me.ReserNum.Text = "Reservation Number"
        Me.ReserNum.Width = 150
        '
        'tablenum
        '
        Me.tablenum.Text = "Table Number"
        Me.tablenum.Width = 150
        '
        'tor
        '
        Me.tor.Text = "Time of Reservation"
        Me.tor.Width = 150
        '
        'lbl_dor
        '
        Me.lbl_dor.AutoSize = True
        Me.lbl_dor.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dor.Location = New System.Drawing.Point(193, 138)
        Me.lbl_dor.Name = "lbl_dor"
        Me.lbl_dor.Size = New System.Drawing.Size(157, 24)
        Me.lbl_dor.TabIndex = 38
        Me.lbl_dor.Text = "Reservation Date:"
        '
        'dtp_date
        '
        Me.dtp_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date.Location = New System.Drawing.Point(369, 135)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(165, 28)
        Me.dtp_date.TabIndex = 39
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(267, 577)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(56, 24)
        Me.lbl_total.TabIndex = 40
        Me.lbl_total.Text = "Total:"
        '
        'txtbox_total
        '
        Me.txtbox_total.Enabled = False
        Me.txtbox_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_total.Location = New System.Drawing.Point(350, 574)
        Me.txtbox_total.Name = "txtbox_total"
        Me.txtbox_total.Size = New System.Drawing.Size(243, 30)
        Me.txtbox_total.TabIndex = 41
        '
        'Frm_reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(953, 634)
        Me.Controls.Add(Me.txtbox_total)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.lbl_dor)
        Me.Controls.Add(Me.lvReports)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_reports)
        Me.Controls.Add(Me.btn_user)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_availability)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurant Table Slot System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_reports As Button
    Friend WithEvents btn_user As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_availability As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lvReports As ListView
    Friend WithEvents ReserNum As ColumnHeader
    Friend WithEvents tablenum As ColumnHeader
    Friend WithEvents tor As ColumnHeader
    Friend WithEvents lbl_dor As Label
    Friend WithEvents dtp_date As DateTimePicker
    Friend WithEvents lbl_total As Label
    Friend WithEvents txtbox_total As TextBox
End Class
