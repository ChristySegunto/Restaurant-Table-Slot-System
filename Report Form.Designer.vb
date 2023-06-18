<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report_Form))
        Me.btn_reports = New System.Windows.Forms.Button()
        Me.btn_user = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_availability = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lvReports = New System.Windows.Forms.ListView()
        Me.Resernum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tablenum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_dor = New System.Windows.Forms.Label()
        Me.dtp_dor = New System.Windows.Forms.DateTimePicker()
        Me.lbl_total = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_reports
        '
        Me.btn_reports.BackgroundImage = CType(resources.GetObject("btn_reports.BackgroundImage"), System.Drawing.Image)
        Me.btn_reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_reports.Location = New System.Drawing.Point(474, 45)
        Me.btn_reports.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_reports.Name = "btn_reports"
        Me.btn_reports.Size = New System.Drawing.Size(149, 57)
        Me.btn_reports.TabIndex = 7
        Me.btn_reports.UseVisualStyleBackColor = True
        '
        'btn_user
        '
        Me.btn_user.BackgroundImage = CType(resources.GetObject("btn_user.BackgroundImage"), System.Drawing.Image)
        Me.btn_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_user.Location = New System.Drawing.Point(318, 45)
        Me.btn_user.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(149, 57)
        Me.btn_user.TabIndex = 6
        Me.btn_user.UseVisualStyleBackColor = True
        '
        'btn_customer
        '
        Me.btn_customer.BackgroundImage = CType(resources.GetObject("btn_customer.BackgroundImage"), System.Drawing.Image)
        Me.btn_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_customer.Location = New System.Drawing.Point(162, 45)
        Me.btn_customer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(149, 57)
        Me.btn_customer.TabIndex = 5
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'btn_availability
        '
        Me.btn_availability.BackgroundImage = CType(resources.GetObject("btn_availability.BackgroundImage"), System.Drawing.Image)
        Me.btn_availability.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_availability.Location = New System.Drawing.Point(6, 45)
        Me.btn_availability.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_availability.Name = "btn_availability"
        Me.btn_availability.Size = New System.Drawing.Size(149, 57)
        Me.btn_availability.TabIndex = 4
        Me.btn_availability.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(735, 24)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 88)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'lvReports
        '
        Me.lvReports.BackColor = System.Drawing.Color.White
        Me.lvReports.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Resernum, Me.tablenum, Me.tor})
        Me.lvReports.ForeColor = System.Drawing.Color.Black
        Me.lvReports.HideSelection = False
        Me.lvReports.Location = New System.Drawing.Point(151, 182)
        Me.lvReports.Name = "lvReports"
        Me.lvReports.Size = New System.Drawing.Size(545, 385)
        Me.lvReports.TabIndex = 13
        Me.lvReports.UseCompatibleStateImageBehavior = False
        Me.lvReports.View = System.Windows.Forms.View.Details
        '
        'Resernum
        '
        Me.Resernum.Text = "Reservation Number"
        Me.Resernum.Width = 180
        '
        'tor
        '
        Me.tor.DisplayIndex = 1
        Me.tor.Text = "Time of Reservation"
        Me.tor.Width = 180
        '
        'tablenum
        '
        Me.tablenum.DisplayIndex = 2
        Me.tablenum.Text = "Table Number"
        Me.tablenum.Width = 180
        '
        'lbl_dor
        '
        Me.lbl_dor.AutoSize = True
        Me.lbl_dor.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dor.Location = New System.Drawing.Point(154, 140)
        Me.lbl_dor.Name = "lbl_dor"
        Me.lbl_dor.Size = New System.Drawing.Size(157, 24)
        Me.lbl_dor.TabIndex = 14
        Me.lbl_dor.Text = "Reservation Date:"
        '
        'dtp_dor
        '
        Me.dtp_dor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_dor.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dor.Location = New System.Drawing.Point(322, 139)
        Me.dtp_dor.Name = "dtp_dor"
        Me.dtp_dor.Size = New System.Drawing.Size(144, 28)
        Me.dtp_dor.TabIndex = 15
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(158, 581)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(130, 24)
        Me.lbl_total.TabIndex = 16
        Me.lbl_total.Text = "Total Number:"
        '
        'Report_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(838, 654)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.dtp_dor)
        Me.Controls.Add(Me.lbl_dor)
        Me.Controls.Add(Me.lvReports)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_reports)
        Me.Controls.Add(Me.btn_user)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_availability)
        Me.DoubleBuffered = True
        Me.Name = "Report_Form"
        Me.Text = "Report_Form"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_reports As Button
    Friend WithEvents btn_user As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_availability As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lvReports As ListView
    Friend WithEvents Resernum As ColumnHeader
    Friend WithEvents tablenum As ColumnHeader
    Friend WithEvents tor As ColumnHeader
    Friend WithEvents lbl_dor As Label
    Friend WithEvents dtp_dor As DateTimePicker
    Friend WithEvents lbl_total As Label
End Class
