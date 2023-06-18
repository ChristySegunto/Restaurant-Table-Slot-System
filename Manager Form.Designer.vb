<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_manager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_manager))
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_user = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_tables = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.White
        Me.btn_logout.BackgroundImage = CType(resources.GetObject("btn_logout.BackgroundImage"), System.Drawing.Image)
        Me.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_logout.Location = New System.Drawing.Point(837, 510)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(85, 82)
        Me.btn_logout.TabIndex = 28
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_user
        '
        Me.btn_user.BackColor = System.Drawing.Color.White
        Me.btn_user.BackgroundImage = CType(resources.GetObject("btn_user.BackgroundImage"), System.Drawing.Image)
        Me.btn_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_user.ForeColor = System.Drawing.Color.Black
        Me.btn_user.Location = New System.Drawing.Point(373, 343)
        Me.btn_user.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_user.Name = "btn_user"
        Me.btn_user.Size = New System.Drawing.Size(184, 178)
        Me.btn_user.TabIndex = 26
        Me.btn_user.UseVisualStyleBackColor = False
        '
        'btn_customer
        '
        Me.btn_customer.BackColor = System.Drawing.Color.White
        Me.btn_customer.BackgroundImage = CType(resources.GetObject("btn_customer.BackgroundImage"), System.Drawing.Image)
        Me.btn_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_customer.ForeColor = System.Drawing.Color.Black
        Me.btn_customer.Location = New System.Drawing.Point(485, 146)
        Me.btn_customer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(184, 178)
        Me.btn_customer.TabIndex = 25
        Me.btn_customer.UseVisualStyleBackColor = False
        '
        'btn_tables
        '
        Me.btn_tables.BackColor = System.Drawing.Color.Transparent
        Me.btn_tables.BackgroundImage = CType(resources.GetObject("btn_tables.BackgroundImage"), System.Drawing.Image)
        Me.btn_tables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_tables.ForeColor = System.Drawing.Color.Black
        Me.btn_tables.Location = New System.Drawing.Point(265, 146)
        Me.btn_tables.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_tables.Name = "btn_tables"
        Me.btn_tables.Size = New System.Drawing.Size(184, 178)
        Me.btn_tables.TabIndex = 24
        Me.btn_tables.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(383, 148)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(708, 69)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(46, 22)
        Me.lbl_date.TabIndex = 22
        Me.lbl_date.Text = "Date"
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.BackColor = System.Drawing.Color.Transparent
        Me.lbl_time.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(707, 47)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(47, 22)
        Me.lbl_time.TabIndex = 21
        Me.lbl_time.Text = "Time"
        '
        'Timer1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(835, 7)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 101)
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'frm_manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(935, 601)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_user)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_tables)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_time)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_manager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurant Table Slot System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_user As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_tables As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
End Class
