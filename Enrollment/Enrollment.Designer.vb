<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Enrollment
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Enrollment))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_student = New System.Windows.Forms.ComboBox()
        Me.txt_bp = New System.Windows.Forms.TextBox()
        Me.txt_fn = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_ln = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_sf = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.birthday = New System.Windows.Forms.DateTimePicker()
        Me.txt_mn = New System.Windows.Forms.TextBox()
        Me.unofficial = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grade = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Section = New System.Windows.Forms.ComboBox()
        Me.LRN = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.TextBox()
        Me.age = New System.Windows.Forms.TextBox()
        Me.pangalan = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dayapic = New System.Windows.Forms.Label()
        Me.btn_import = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.gcont = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.gadd = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mcont = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.moccu = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.fcont = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.father = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.guardian = New System.Windows.Forms.TextBox()
        Me.foccu = New System.Windows.Forms.TextBox()
        Me.mother = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.balance = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtotherfees = New System.Windows.Forms.TextBox()
        Me.txtbooks = New System.Windows.Forms.TextBox()
        Me.txtlf = New System.Windows.Forms.TextBox()
        Me.txtmf = New System.Windows.Forms.TextBox()
        Me.txttf = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_enroll = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_cancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmb_student)
        Me.GroupBox2.Controls.Add(Me.txt_bp)
        Me.GroupBox2.Controls.Add(Me.txt_fn)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txt_ln)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.txt_sf)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.birthday)
        Me.GroupBox2.Controls.Add(Me.txt_mn)
        Me.GroupBox2.Controls.Add(Me.unofficial)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.grade)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.gender)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Section)
        Me.GroupBox2.Controls.Add(Me.LRN)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.address)
        Me.GroupBox2.Controls.Add(Me.age)
        Me.GroupBox2.Controls.Add(Me.pangalan)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(59, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(661, 332)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "STUDENT'S INFORMATION"
        '
        'cmb_student
        '
        Me.cmb_student.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.cmb_student.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_student.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_student.ForeColor = System.Drawing.Color.White
        Me.cmb_student.FormattingEnabled = True
        Me.cmb_student.Items.AddRange(New Object() {"New", "Old"})
        Me.cmb_student.Location = New System.Drawing.Point(486, 33)
        Me.cmb_student.Name = "cmb_student"
        Me.cmb_student.Size = New System.Drawing.Size(161, 27)
        Me.cmb_student.TabIndex = 56
        '
        'txt_bp
        '
        Me.txt_bp.BackColor = System.Drawing.Color.DodgerBlue
        Me.txt_bp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bp.ForeColor = System.Drawing.Color.White
        Me.txt_bp.Location = New System.Drawing.Point(117, 206)
        Me.txt_bp.Name = "txt_bp"
        Me.txt_bp.Size = New System.Drawing.Size(155, 27)
        Me.txt_bp.TabIndex = 55
        '
        'txt_fn
        '
        Me.txt_fn.BackColor = System.Drawing.Color.DodgerBlue
        Me.txt_fn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'txt_ln
        '
        Me.txt_ln.BackColor = System.Drawing.Color.DodgerBlue
        Me.txt_ln.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txt_sf.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'birthday
        '
        Me.birthday.CustomFormat = "MM/DD/YYYY"
        Me.birthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.birthday.Location = New System.Drawing.Point(486, 169)
        Me.birthday.MaxDate = New Date(2021, 12, 31, 0, 0, 0, 0)
        Me.birthday.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.birthday.Name = "birthday"
        Me.birthday.Size = New System.Drawing.Size(161, 27)
        Me.birthday.TabIndex = 42
        '
        'txt_mn
        '
        Me.txt_mn.BackColor = System.Drawing.Color.DodgerBlue
        Me.txt_mn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mn.ForeColor = System.Drawing.Color.White
        Me.txt_mn.Location = New System.Drawing.Point(117, 132)
        Me.txt_mn.Name = "txt_mn"
        Me.txt_mn.Size = New System.Drawing.Size(155, 27)
        Me.txt_mn.TabIndex = 41
        '
        'unofficial
        '
        Me.unofficial.AutoSize = True
        Me.unofficial.Location = New System.Drawing.Point(343, 307)
        Me.unofficial.Name = "unofficial"
        Me.unofficial.Size = New System.Drawing.Size(80, 19)
        Me.unofficial.TabIndex = 39
        Me.unofficial.Text = "Unofficial"
        Me.unofficial.Visible = False
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
        Me.grade.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.grade.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grade.ForeColor = System.Drawing.Color.White
        Me.grade.FormattingEnabled = True
        Me.grade.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.grade.Location = New System.Drawing.Point(118, 33)
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(152, 27)
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
        'gender
        '
        Me.gender.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.ForeColor = System.Drawing.Color.White
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.gender.Location = New System.Drawing.Point(117, 168)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(152, 27)
        Me.gender.TabIndex = 20
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
        'Section
        '
        Me.Section.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Section.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Section.ForeColor = System.Drawing.Color.White
        Me.Section.FormattingEnabled = True
        Me.Section.Items.AddRange(New Object() {"A", "B"})
        Me.Section.Location = New System.Drawing.Point(118, 64)
        Me.Section.Name = "Section"
        Me.Section.Size = New System.Drawing.Size(152, 27)
        Me.Section.TabIndex = 5
        '
        'LRN
        '
        Me.LRN.BackColor = System.Drawing.Color.DodgerBlue
        Me.LRN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRN.ForeColor = System.Drawing.Color.White
        Me.LRN.Location = New System.Drawing.Point(486, 65)
        Me.LRN.MaxLength = 12
        Me.LRN.Name = "LRN"
        Me.LRN.Size = New System.Drawing.Size(161, 27)
        Me.LRN.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(433, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "LRN:"
        '
        'address
        '
        Me.address.BackColor = System.Drawing.Color.DodgerBlue
        Me.address.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.ForeColor = System.Drawing.Color.White
        Me.address.Location = New System.Drawing.Point(116, 246)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(532, 27)
        Me.address.TabIndex = 13
        '
        'age
        '
        Me.age.BackColor = System.Drawing.Color.DodgerBlue
        Me.age.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.ForeColor = System.Drawing.Color.White
        Me.age.Location = New System.Drawing.Point(486, 201)
        Me.age.Name = "age"
        Me.age.ReadOnly = True
        Me.age.Size = New System.Drawing.Size(161, 27)
        Me.age.TabIndex = 12
        '
        'pangalan
        '
        Me.pangalan.BackColor = System.Drawing.Color.DodgerBlue
        Me.pangalan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pangalan.ForeColor = System.Drawing.Color.White
        Me.pangalan.Location = New System.Drawing.Point(397, 278)
        Me.pangalan.Name = "pangalan"
        Me.pangalan.Size = New System.Drawing.Size(248, 27)
        Me.pangalan.TabIndex = 11
        Me.pangalan.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 71)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 18)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Section:"
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dayapic)
        Me.GroupBox4.Controls.Add(Me.btn_import)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(727, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(233, 332)
        Me.GroupBox4.TabIndex = 42
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PROFILE"
        '
        'dayapic
        '
        Me.dayapic.AutoSize = True
        Me.dayapic.Location = New System.Drawing.Point(182, 185)
        Me.dayapic.Name = "dayapic"
        Me.dayapic.Size = New System.Drawing.Size(17, 19)
        Me.dayapic.TabIndex = 44
        Me.dayapic.Text = "  "
        Me.dayapic.Visible = False
        '
        'btn_import
        '
        Me.btn_import.ActiveBorderThickness = 1
        Me.btn_import.ActiveCornerRadius = 20
        Me.btn_import.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.btn_import.ActiveForecolor = System.Drawing.Color.White
        Me.btn_import.ActiveLineColor = System.Drawing.Color.White
        Me.btn_import.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_import.BackgroundImage = CType(resources.GetObject("btn_import.BackgroundImage"), System.Drawing.Image)
        Me.btn_import.ButtonText = "IMPORT"
        Me.btn_import.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_import.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_import.ForeColor = System.Drawing.Color.Black
        Me.btn_import.IdleBorderThickness = 1
        Me.btn_import.IdleCornerRadius = 20
        Me.btn_import.IdleFillColor = System.Drawing.Color.White
        Me.btn_import.IdleForecolor = System.Drawing.Color.Black
        Me.btn_import.IdleLineColor = System.Drawing.Color.White
        Me.btn_import.Location = New System.Drawing.Point(50, 201)
        Me.btn_import.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(135, 52)
        Me.btn_import.TabIndex = 43
        Me.btn_import.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(24, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.gcont)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.gadd)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.mcont)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.moccu)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.fcont)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.father)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.guardian)
        Me.GroupBox3.Controls.Add(Me.foccu)
        Me.GroupBox3.Controls.Add(Me.mother)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(59, 356)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(570, 277)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PARENT'S INFORMATION"
        '
        'gcont
        '
        Me.gcont.BackColor = System.Drawing.Color.DodgerBlue
        Me.gcont.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcont.ForeColor = System.Drawing.Color.White
        Me.gcont.Location = New System.Drawing.Point(151, 236)
        Me.gcont.MaxLength = 11
        Me.gcont.Name = "gcont"
        Me.gcont.Size = New System.Drawing.Size(157, 27)
        Me.gcont.TabIndex = 47
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(12, 244)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(84, 18)
        Me.Label26.TabIndex = 46
        Me.Label26.Text = "Contact #:"
        '
        'gadd
        '
        Me.gadd.BackColor = System.Drawing.Color.DodgerBlue
        Me.gadd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gadd.ForeColor = System.Drawing.Color.White
        Me.gadd.Location = New System.Drawing.Point(151, 201)
        Me.gadd.Name = "gadd"
        Me.gadd.Size = New System.Drawing.Size(398, 27)
        Me.gadd.TabIndex = 45
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 18)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Guardian:"
        '
        'mcont
        '
        Me.mcont.BackColor = System.Drawing.Color.DodgerBlue
        Me.mcont.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcont.ForeColor = System.Drawing.Color.White
        Me.mcont.Location = New System.Drawing.Point(412, 135)
        Me.mcont.MaxLength = 11
        Me.mcont.Name = "mcont"
        Me.mcont.Size = New System.Drawing.Size(137, 27)
        Me.mcont.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(322, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 18)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Contact #:"
        '
        'moccu
        '
        Me.moccu.BackColor = System.Drawing.Color.DodgerBlue
        Me.moccu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moccu.ForeColor = System.Drawing.Color.White
        Me.moccu.Location = New System.Drawing.Point(151, 135)
        Me.moccu.Name = "moccu"
        Me.moccu.Size = New System.Drawing.Size(157, 27)
        Me.moccu.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 18)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Occupation:"
        '
        'fcont
        '
        Me.fcont.BackColor = System.Drawing.Color.DodgerBlue
        Me.fcont.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fcont.ForeColor = System.Drawing.Color.White
        Me.fcont.Location = New System.Drawing.Point(412, 67)
        Me.fcont.MaxLength = 11
        Me.fcont.Name = "fcont"
        Me.fcont.Size = New System.Drawing.Size(137, 27)
        Me.fcont.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(322, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 18)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Contact #:"
        '
        'father
        '
        Me.father.BackColor = System.Drawing.Color.DodgerBlue
        Me.father.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.father.ForeColor = System.Drawing.Color.White
        Me.father.Location = New System.Drawing.Point(151, 33)
        Me.father.Name = "father"
        Me.father.Size = New System.Drawing.Size(398, 27)
        Me.father.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 18)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Fathers Name:"
        '
        'guardian
        '
        Me.guardian.BackColor = System.Drawing.Color.DodgerBlue
        Me.guardian.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardian.ForeColor = System.Drawing.Color.White
        Me.guardian.Location = New System.Drawing.Point(151, 169)
        Me.guardian.Name = "guardian"
        Me.guardian.Size = New System.Drawing.Size(398, 27)
        Me.guardian.TabIndex = 13
        '
        'foccu
        '
        Me.foccu.BackColor = System.Drawing.Color.DodgerBlue
        Me.foccu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foccu.ForeColor = System.Drawing.Color.White
        Me.foccu.Location = New System.Drawing.Point(151, 65)
        Me.foccu.Name = "foccu"
        Me.foccu.Size = New System.Drawing.Size(157, 27)
        Me.foccu.TabIndex = 12
        '
        'mother
        '
        Me.mother.BackColor = System.Drawing.Color.DodgerBlue
        Me.mother.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mother.ForeColor = System.Drawing.Color.White
        Me.mother.Location = New System.Drawing.Point(151, 100)
        Me.mother.Name = "mother"
        Me.mother.Size = New System.Drawing.Size(398, 27)
        Me.mother.TabIndex = 11
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(16, 213)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 18)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Address:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 73)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(101, 18)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Occupation:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 108)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(119, 18)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Mothers Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.balance)
        Me.GroupBox1.Controls.Add(Me.txttotal)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtotherfees)
        Me.GroupBox1.Controls.Add(Me.txtbooks)
        Me.GroupBox1.Controls.Add(Me.txtlf)
        Me.GroupBox1.Controls.Add(Me.txtmf)
        Me.GroupBox1.Controls.Add(Me.txttf)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(647, 356)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 278)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FEE'S"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(13, 197)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 5)
        Me.Panel1.TabIndex = 22
        '
        'balance
        '
        Me.balance.BackColor = System.Drawing.Color.DodgerBlue
        Me.balance.Enabled = False
        Me.balance.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balance.Location = New System.Drawing.Point(172, 247)
        Me.balance.MaxLength = 15
        Me.balance.Name = "balance"
        Me.balance.Size = New System.Drawing.Size(136, 26)
        Me.balance.TabIndex = 21
        Me.balance.Visible = False
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.Color.DodgerBlue
        Me.txttotal.Enabled = False
        Me.txttotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.White
        Me.txttotal.Location = New System.Drawing.Point(172, 209)
        Me.txttotal.MaxLength = 15
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(136, 27)
        Me.txttotal.TabIndex = 20
        Me.txttotal.Text = "0"
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(14, 216)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 23)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "TOTAL:"
        '
        'txtotherfees
        '
        Me.txtotherfees.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtotherfees.Enabled = False
        Me.txtotherfees.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtotherfees.ForeColor = System.Drawing.Color.White
        Me.txtotherfees.Location = New System.Drawing.Point(173, 162)
        Me.txtotherfees.MaxLength = 10
        Me.txtotherfees.Name = "txtotherfees"
        Me.txtotherfees.Size = New System.Drawing.Size(136, 27)
        Me.txtotherfees.TabIndex = 18
        Me.txtotherfees.Text = "0"
        Me.txtotherfees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbooks
        '
        Me.txtbooks.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtbooks.Enabled = False
        Me.txtbooks.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbooks.ForeColor = System.Drawing.Color.White
        Me.txtbooks.Location = New System.Drawing.Point(173, 130)
        Me.txtbooks.MaxLength = 10
        Me.txtbooks.Name = "txtbooks"
        Me.txtbooks.Size = New System.Drawing.Size(136, 27)
        Me.txtbooks.TabIndex = 14
        Me.txtbooks.Text = "0"
        Me.txtbooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtlf
        '
        Me.txtlf.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtlf.Enabled = False
        Me.txtlf.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlf.ForeColor = System.Drawing.Color.White
        Me.txtlf.Location = New System.Drawing.Point(173, 98)
        Me.txtlf.MaxLength = 10
        Me.txtlf.Name = "txtlf"
        Me.txtlf.Size = New System.Drawing.Size(136, 27)
        Me.txtlf.TabIndex = 13
        Me.txtlf.Text = "0"
        Me.txtlf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtmf
        '
        Me.txtmf.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtmf.Enabled = False
        Me.txtmf.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmf.ForeColor = System.Drawing.Color.White
        Me.txtmf.Location = New System.Drawing.Point(173, 66)
        Me.txtmf.MaxLength = 10
        Me.txtmf.Name = "txtmf"
        Me.txtmf.Size = New System.Drawing.Size(136, 27)
        Me.txtmf.TabIndex = 12
        Me.txtmf.Text = "0"
        Me.txtmf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttf
        '
        Me.txttf.BackColor = System.Drawing.Color.DodgerBlue
        Me.txttf.Enabled = False
        Me.txttf.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttf.ForeColor = System.Drawing.Color.White
        Me.txttf.Location = New System.Drawing.Point(173, 34)
        Me.txttf.MaxLength = 10
        Me.txttf.Name = "txttf"
        Me.txttf.Size = New System.Drawing.Size(136, 27)
        Me.txttf.TabIndex = 11
        Me.txttf.Text = "0"
        Me.txttf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 18)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Other Fees:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Books:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Laboratory Fee:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Miscellaneous Fee:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tuition Fee:"
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
        Me.btn_enroll.ButtonText = "E N R O L L"
        Me.btn_enroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enroll.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enroll.ForeColor = System.Drawing.Color.Black
        Me.btn_enroll.IdleBorderThickness = 1
        Me.btn_enroll.IdleCornerRadius = 20
        Me.btn_enroll.IdleFillColor = System.Drawing.Color.White
        Me.btn_enroll.IdleForecolor = System.Drawing.Color.Black
        Me.btn_enroll.IdleLineColor = System.Drawing.Color.White
        Me.btn_enroll.Location = New System.Drawing.Point(563, 641)
        Me.btn_enroll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_enroll.Name = "btn_enroll"
        Me.btn_enroll.Size = New System.Drawing.Size(186, 51)
        Me.btn_enroll.TabIndex = 44
        Me.btn_enroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_cancel.ButtonText = "C A N C E L"
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.IdleBorderThickness = 1
        Me.btn_cancel.IdleCornerRadius = 20
        Me.btn_cancel.IdleFillColor = System.Drawing.Color.White
        Me.btn_cancel.IdleForecolor = System.Drawing.Color.Black
        Me.btn_cancel.IdleLineColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(774, 641)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(186, 51)
        Me.btn_cancel.TabIndex = 45
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(61, 654)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(52, 13)
        Me.lbldate.TabIndex = 46
        Me.lbldate.Text = "        date"
        Me.lbldate.Visible = False
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Location = New System.Drawing.Point(67, 641)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(56, 13)
        Me.lbltime.TabIndex = 47
        Me.lbltime.Text = "         time "
        Me.lbltime.Visible = False
        '
        'Timer1
        '
        '
        'Enrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1140, 698)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_enroll)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Enrollment"
        Me.Text = " Enrollment"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents grade As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gender As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Section As ComboBox
    Friend WithEvents LRN As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents age As TextBox
    Friend WithEvents pangalan As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_import As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents gcont As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents gadd As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents mcont As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents moccu As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents fcont As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents father As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents guardian As TextBox
    Friend WithEvents foccu As TextBox
    Friend WithEvents mother As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents balance As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtotherfees As TextBox
    Friend WithEvents txtbooks As TextBox
    Friend WithEvents txtlf As TextBox
    Friend WithEvents txtmf As TextBox
    Friend WithEvents txttf As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_enroll As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_cancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents dayapic As Label
    Friend WithEvents unofficial As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents birthday As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_mn As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txt_sf As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txt_fn As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_ln As TextBox
    Friend WithEvents txt_bp As TextBox
    Friend WithEvents cmb_student As ComboBox
End Class
