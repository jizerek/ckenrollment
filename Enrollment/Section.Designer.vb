<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Section
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Section))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lsv_students = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbldaya = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gender = New System.Windows.Forms.TextBox()
        Me.txtgrade = New System.Windows.Forms.TextBox()
        Me.studtype = New System.Windows.Forms.TextBox()
        Me.txtsec = New System.Windows.Forms.TextBox()
        Me.birthday = New System.Windows.Forms.TextBox()
        Me.txt_bp = New System.Windows.Forms.TextBox()
        Me.txt_fn = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_ln = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_sf = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_mn = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grade = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LRN = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.TextBox()
        Me.age = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_cancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_enroll = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(33, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(161, 134)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(700, 44)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(227, 198)
        Me.GroupBox4.TabIndex = 46
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PROFILE"
        '
        'lsv_students
        '
        Me.lsv_students.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.lsv_students.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsv_students.Location = New System.Drawing.Point(12, 336)
        Me.lsv_students.Name = "lsv_students"
        Me.lsv_students.Size = New System.Drawing.Size(915, 239)
        Me.lsv_students.TabIndex = 54
        Me.lsv_students.UseCompatibleStateImageBehavior = False
        Me.lsv_students.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Grade"
        Me.ColumnHeader1.Width = 45
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "LRN"
        Me.ColumnHeader2.Width = 69
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Section"
        Me.ColumnHeader3.Width = 48
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Old/New Student"
        Me.ColumnHeader4.Width = 99
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Lastname"
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Firstname"
        Me.ColumnHeader6.Width = 94
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Middlename"
        Me.ColumnHeader7.Width = 76
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Suffix"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Gender"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Age"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Birthday"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Birthplace"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Address"
        Me.ColumnHeader13.Width = 93
        '
        'lbldaya
        '
        Me.lbldaya.AutoSize = True
        Me.lbldaya.Location = New System.Drawing.Point(640, 243)
        Me.lbldaya.Name = "lbldaya"
        Me.lbldaya.Size = New System.Drawing.Size(39, 13)
        Me.lbldaya.TabIndex = 57
        Me.lbldaya.Text = "Label1"
        Me.lbldaya.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gender)
        Me.GroupBox2.Controls.Add(Me.txtgrade)
        Me.GroupBox2.Controls.Add(Me.studtype)
        Me.GroupBox2.Controls.Add(Me.txtsec)
        Me.GroupBox2.Controls.Add(Me.birthday)
        Me.GroupBox2.Controls.Add(Me.txt_bp)
        Me.GroupBox2.Controls.Add(Me.txt_fn)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txt_ln)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.txt_sf)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_mn)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.grade)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.LRN)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.address)
        Me.GroupBox2.Controls.Add(Me.age)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(30, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(661, 299)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "STUDENT'S INFORMATION"
        '
        'gender
        '
        Me.gender.BackColor = System.Drawing.Color.DodgerBlue
        Me.gender.ForeColor = System.Drawing.Color.White
        Me.gender.Location = New System.Drawing.Point(118, 171)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(155, 27)
        Me.gender.TabIndex = 61
        '
        'txtgrade
        '
        Me.txtgrade.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtgrade.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgrade.ForeColor = System.Drawing.Color.White
        Me.txtgrade.Location = New System.Drawing.Point(118, 33)
        Me.txtgrade.MaxLength = 12
        Me.txtgrade.Name = "txtgrade"
        Me.txtgrade.Size = New System.Drawing.Size(154, 26)
        Me.txtgrade.TabIndex = 60
        Me.txtgrade.Visible = False
        '
        'studtype
        '
        Me.studtype.BackColor = System.Drawing.Color.DodgerBlue
        Me.studtype.ForeColor = System.Drawing.Color.White
        Me.studtype.Location = New System.Drawing.Point(486, 30)
        Me.studtype.Name = "studtype"
        Me.studtype.Size = New System.Drawing.Size(161, 27)
        Me.studtype.TabIndex = 59
        '
        'txtsec
        '
        Me.txtsec.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtsec.ForeColor = System.Drawing.Color.White
        Me.txtsec.Location = New System.Drawing.Point(486, 63)
        Me.txtsec.Name = "txtsec"
        Me.txtsec.Size = New System.Drawing.Size(161, 27)
        Me.txtsec.TabIndex = 58
        '
        'birthday
        '
        Me.birthday.BackColor = System.Drawing.Color.DodgerBlue
        Me.birthday.ForeColor = System.Drawing.Color.White
        Me.birthday.Location = New System.Drawing.Point(486, 166)
        Me.birthday.Name = "birthday"
        Me.birthday.Size = New System.Drawing.Size(161, 27)
        Me.birthday.TabIndex = 57
        '
        'txt_bp
        '
        Me.txt_bp.BackColor = System.Drawing.Color.DodgerBlue
        Me.txt_bp.ForeColor = System.Drawing.Color.White
        Me.txt_bp.Location = New System.Drawing.Point(117, 206)
        Me.txt_bp.Name = "txt_bp"
        Me.txt_bp.Size = New System.Drawing.Size(155, 27)
        Me.txt_bp.TabIndex = 55
        '
        'txt_fn
        '
        Me.txt_fn.BackColor = System.Drawing.Color.DodgerBlue
        Me.txt_fn.ForeColor = System.Drawing.Color.White
        Me.txt_fn.Location = New System.Drawing.Point(486, 99)
        Me.txt_fn.Name = "txt_fn"
        Me.txt_fn.Size = New System.Drawing.Size(161, 27)
        Me.txt_fn.TabIndex = 54
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(386, 106)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 18)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "Firstname:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 105)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 18)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "Lastname:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(385, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 18)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Section:"
        '
        'txt_ln
        '
        Me.txt_ln.BackColor = System.Drawing.Color.DodgerBlue
        Me.txt_ln.ForeColor = System.Drawing.Color.White
        Me.txt_ln.Location = New System.Drawing.Point(118, 96)
        Me.txt_ln.Name = "txt_ln"
        Me.txt_ln.Size = New System.Drawing.Size(154, 27)
        Me.txt_ln.TabIndex = 51
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(9, 210)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(89, 18)
        Me.Label28.TabIndex = 48
        Me.Label28.Text = "Birth Place:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(356, 136)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(116, 18)
        Me.Label27.TabIndex = 47
        Me.Label27.Text = "Suffix (JR III IV):"
        '
        'txt_sf
        '
        Me.txt_sf.BackColor = System.Drawing.Color.DodgerBlue
        Me.txt_sf.ForeColor = System.Drawing.Color.White
        Me.txt_sf.Location = New System.Drawing.Point(486, 132)
        Me.txt_sf.Name = "txt_sf"
        Me.txt_sf.Size = New System.Drawing.Size(161, 27)
        Me.txt_sf.TabIndex = 46
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 140)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(107, 18)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "Middlename:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Birthday:"
        '
        'txt_mn
        '
        Me.txt_mn.BackColor = System.Drawing.Color.DodgerBlue
        Me.txt_mn.ForeColor = System.Drawing.Color.White
        Me.txt_mn.Location = New System.Drawing.Point(117, 132)
        Me.txt_mn.Name = "txt_mn"
        Me.txt_mn.Size = New System.Drawing.Size(155, 27)
        Me.txt_mn.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(327, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 18)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "New / Old Student:"
        '
        'grade
        '
        Me.grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.grade.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grade.FormattingEnabled = True
        Me.grade.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.grade.Location = New System.Drawing.Point(118, 33)
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(152, 26)
        Me.grade.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Grade level:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 175)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 18)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Gender:"
        '
        'LRN
        '
        Me.LRN.BackColor = System.Drawing.Color.DodgerBlue
        Me.LRN.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRN.ForeColor = System.Drawing.Color.White
        Me.LRN.Location = New System.Drawing.Point(118, 65)
        Me.LRN.MaxLength = 12
        Me.LRN.Name = "LRN"
        Me.LRN.Size = New System.Drawing.Size(154, 26)
        Me.LRN.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "LRN:"
        '
        'address
        '
        Me.address.BackColor = System.Drawing.Color.DodgerBlue
        Me.address.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.ForeColor = System.Drawing.Color.White
        Me.address.Location = New System.Drawing.Point(116, 246)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(532, 26)
        Me.address.TabIndex = 13
        '
        'age
        '
        Me.age.BackColor = System.Drawing.Color.DodgerBlue
        Me.age.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.ForeColor = System.Drawing.Color.White
        Me.age.Location = New System.Drawing.Point(486, 201)
        Me.age.Name = "age"
        Me.age.ReadOnly = True
        Me.age.Size = New System.Drawing.Size(161, 26)
        Me.age.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 250)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 18)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Address:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(429, 204)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 18)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Age:"
        '
        'btn_cancel
        '
        Me.btn_cancel.ActiveBorderThickness = 1
        Me.btn_cancel.ActiveCornerRadius = 20
        Me.btn_cancel.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.btn_cancel.ActiveForecolor = System.Drawing.Color.White
        Me.btn_cancel.ActiveLineColor = System.Drawing.Color.White
        Me.btn_cancel.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_cancel.BackgroundImage = CType(resources.GetObject("btn_cancel.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancel.ButtonText = "Cancel"
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.IdleBorderThickness = 1
        Me.btn_cancel.IdleCornerRadius = 20
        Me.btn_cancel.IdleFillColor = System.Drawing.Color.White
        Me.btn_cancel.IdleForecolor = System.Drawing.Color.Black
        Me.btn_cancel.IdleLineColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(760, 583)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(167, 43)
        Me.btn_cancel.TabIndex = 60
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_enroll
        '
        Me.btn_enroll.ActiveBorderThickness = 1
        Me.btn_enroll.ActiveCornerRadius = 20
        Me.btn_enroll.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.btn_enroll.ActiveForecolor = System.Drawing.Color.White
        Me.btn_enroll.ActiveLineColor = System.Drawing.Color.White
        Me.btn_enroll.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_enroll.BackgroundImage = CType(resources.GetObject("btn_enroll.BackgroundImage"), System.Drawing.Image)
        Me.btn_enroll.ButtonText = "Search"
        Me.btn_enroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enroll.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enroll.ForeColor = System.Drawing.Color.Black
        Me.btn_enroll.IdleBorderThickness = 1
        Me.btn_enroll.IdleCornerRadius = 20
        Me.btn_enroll.IdleFillColor = System.Drawing.Color.White
        Me.btn_enroll.IdleForecolor = System.Drawing.Color.Black
        Me.btn_enroll.IdleLineColor = System.Drawing.Color.White
        Me.btn_enroll.Location = New System.Drawing.Point(585, 583)
        Me.btn_enroll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_enroll.Name = "btn_enroll"
        Me.btn_enroll.Size = New System.Drawing.Size(167, 43)
        Me.btn_enroll.TabIndex = 59
        Me.btn_enroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(939, 633)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_enroll)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbldaya)
        Me.Controls.Add(Me.lsv_students)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Section"
        Me.Text = "Section"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lsv_students As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents lbldaya As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_bp As TextBox
    Friend WithEvents txt_fn As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_ln As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txt_sf As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_mn As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents grade As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents LRN As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents age As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents birthday As TextBox
    Friend WithEvents studtype As TextBox
    Friend WithEvents txtsec As TextBox
    Friend WithEvents txtgrade As TextBox
    Friend WithEvents gender As TextBox
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents btn_cancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_enroll As Bunifu.Framework.UI.BunifuThinButton2
End Class
