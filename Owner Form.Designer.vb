<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_owner
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_owner))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_reports = New System.Windows.Forms.Button()
        Me.btn_user = New System.Windows.Forms.Button()
        Me.btn_costumer = New System.Windows.Forms.Button()
        Me.btn_tables = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -21)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(381, 150)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(707, 71)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(46, 22)
        Me.lbl_date.TabIndex = 13
        Me.lbl_date.Text = "Date"
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.BackColor = System.Drawing.Color.Transparent
        Me.lbl_time.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(707, 50)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(47, 22)
        Me.lbl_time.TabIndex = 12
        Me.lbl_time.Text = "Time"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(831, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 101)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.White
        Me.btn_logout.BackgroundImage = CType(resources.GetObject("btn_logout.BackgroundImage"), System.Drawing.Image)
        Me.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_logout.Location = New System.Drawing.Point(840, 528)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(85, 82)
        Me.btn_logout.TabIndex = 19
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_reports
        '
        Me.btn_reports.BackColor = System.Drawing.Color.White
        Me.btn_reports.BackgroundImage = CType(resources.GetObject("btn_reports.BackgroundImage"), System.Drawing.Image)
        Me.btn_reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_reports.ForeColor = System.Drawing.Color.Black
        Me.btn_reports.Location = New System.Drawing.Point(495, 366)
        Me.btn_reports.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_reports.Name = "btn_reports"
        Me.btn_reports.Size = New System.Drawing.Size(183, 175)
        Me.btn_reports.TabIndex = 18
        Me.btn_reports.UseVisualStyleBackColor = False
        '
        'btn_user
        '
        Me.btn_user.BackColor = System.Drawing.Color.White
        Me.btn_user.BackgroundImage = CType(resources.GetObject("btn_user.BackgroundImage"), System.Drawing.Image)
        Me.btn_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_user.ForeColor = System.Drawing.Color.Black
        Me.btn_user.Location = New System.Drawing.Point(280, 366)
        Me.btn_user.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(183, 175)
        Me.btn_user.TabIndex = 17
        Me.btn_user.UseVisualStyleBackColor = False
        '
        'btn_costumer
        '
        Me.btn_costumer.BackColor = System.Drawing.Color.White
        Me.btn_costumer.BackgroundImage = CType(resources.GetObject("btn_costumer.BackgroundImage"), System.Drawing.Image)
        Me.btn_costumer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_costumer.ForeColor = System.Drawing.Color.Black
        Me.btn_costumer.Location = New System.Drawing.Point(495, 172)
        Me.btn_costumer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_costumer.Name = "btn_costumer"
        Me.btn_costumer.Size = New System.Drawing.Size(183, 175)
        Me.btn_costumer.TabIndex = 16
        Me.btn_costumer.UseVisualStyleBackColor = False
        '
        'btn_tables
        '
        Me.btn_tables.BackColor = System.Drawing.Color.Transparent
        Me.btn_tables.BackgroundImage = CType(resources.GetObject("btn_tables.BackgroundImage"), System.Drawing.Image)
        Me.btn_tables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_tables.ForeColor = System.Drawing.Color.Black
        Me.btn_tables.Location = New System.Drawing.Point(280, 172)
        Me.btn_tables.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_tables.Name = "btn_tables"
        Me.btn_tables.Size = New System.Drawing.Size(183, 175)
        Me.btn_tables.TabIndex = 15
        Me.btn_tables.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Frm_owner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(935, 622)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_reports)
        Me.Controls.Add(Me.btn_user)
        Me.Controls.Add(Me.btn_costumer)
        Me.Controls.Add(Me.btn_tables)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.PictureBox2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frm_owner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurant Table Slot System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_reports As Button
    Friend WithEvents btn_user As Button
    Friend WithEvents btn_costumer As Button
    Friend WithEvents btn_tables As Button
    Friend WithEvents Timer1 As Timer
End Class
