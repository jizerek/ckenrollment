<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class updatestudents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(updatestudents))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtsec = New System.Windows.Forms.ComboBox()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.birthday = New System.Windows.Forms.DateTimePicker()
        Me.grade = New System.Windows.Forms.TextBox()
        Me.studtype = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_bp = New System.Windows.Forms.TextBox()
        Me.pangalan = New System.Windows.Forms.TextBox()
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
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LRN = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.TextBox()
        Me.age = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbldaya = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
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
        Me.btn_import = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnupdate = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btncancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtsec)
        Me.GroupBox2.Controls.Add(Me.gender)
        Me.GroupBox2.Controls.Add(Me.birthday)
        Me.GroupBox2.Controls.Add(Me.grade)
        Me.GroupBox2.Controls.Add(Me.studtype)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_bp)
        Me.GroupBox2.Controls.Add(Me.pangalan)
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
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.LRN)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.address)
        Me.GroupBox2.Controls.Add(Me.age)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(31, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(661, 332)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "STUDENT'S INFORMATION"
        '
        'txtsec
        '
        Me.txtsec.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.txtsec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtsec.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsec.ForeColor = System.Drawing.Color.White
        Me.txtsec.FormattingEnabled = True
        Me.txtsec.Items.AddRange(New Object() {"A", "B"})
        Me.txtsec.Location = New System.Drawing.Point(486, 67)
        Me.txtsec.Name = "txtsec"
        Me.txtsec.Size = New System.Drawing.Size(161, 26)
        Me.txtsec.TabIndex = 75
        '
        'gender
        '
        Me.gender.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.ForeColor = System.Drawing.Color.White
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.gender.Location = New System.Drawing.Point(120, 171)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(152, 26)
        Me.gender.TabIndex = 74
        '
        'birthday
        '
        Me.birthday.CustomFormat = "MM/DD/YYYY"
        Me.birthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.birthday.Location = New System.Drawing.Point(486, 166)
        Me.birthday.Name = "birthday"
        Me.birthday.Size = New System.Drawing.Size(161, 27)
        Me.birthday.TabIndex = 73
        '
        'grade
        '
        Me.grade.BackColor = System.Drawing.Color.DodgerBlue
        Me.grade.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grade.ForeColor = System.Drawing.Color.White
        Me.grade.Location = New System.Drawing.Point(116, 62)
        Me.grade.MaxLength = 12
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(154, 27)
        Me.grade.TabIndex = 60
        '
        'studtype
        '
        Me.studtype.BackColor = System.Drawing.Color.DodgerBlue
        Me.studtype.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studtype.ForeColor = System.Drawing.Color.White
        Me.studtype.Location = New System.Drawing.Point(486, 30)
        Me.studtype.Name = "studtype"
        Me.studtype.Size = New System.Drawing.Size(161, 27)
        Me.studtype.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Grade level:"
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
        'pangalan
        '
        Me.pangalan.BackColor = System.Drawing.Color.DodgerBlue
        Me.pangalan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pangalan.ForeColor = System.Drawing.Color.White
        Me.pangalan.Location = New System.Drawing.Point(404, 290)
        Me.pangalan.Name = "pangalan"
        Me.pangalan.Size = New System.Drawing.Size(248, 27)
        Me.pangalan.TabIndex = 65
        Me.pangalan.Visible = False
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
        Me.LRN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRN.ForeColor = System.Drawing.Color.White
        Me.LRN.Location = New System.Drawing.Point(116, 30)
        Me.LRN.MaxLength = 12
        Me.LRN.Name = "LRN"
        Me.LRN.Size = New System.Drawing.Size(154, 27)
        Me.LRN.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 33)
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
        'lbldaya
        '
        Me.lbldaya.AutoSize = True
        Me.lbldaya.Location = New System.Drawing.Point(640, 248)
        Me.lbldaya.Name = "lbldaya"
        Me.lbldaya.Size = New System.Drawing.Size(39, 13)
        Me.lbldaya.TabIndex = 63
        Me.lbldaya.Text = "Label1"
        Me.lbldaya.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(741, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(227, 198)
        Me.GroupBox4.TabIndex = 59
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PROFILE"
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
        Me.GroupBox3.Location = New System.Drawing.Point(31, 350)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(960, 204)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PARENT'S INFORMATION"
        '
        'gcont
        '
        Me.gcont.BackColor = System.Drawing.Color.DodgerBlue
        Me.gcont.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcont.ForeColor = System.Drawing.Color.White
        Me.gcont.Location = New System.Drawing.Point(520, 116)
        Me.gcont.MaxLength = 11
        Me.gcont.Name = "gcont"
        Me.gcont.Size = New System.Drawing.Size(157, 27)
        Me.gcont.TabIndex = 47
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(413, 124)
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
        Me.gadd.Location = New System.Drawing.Point(150, 160)
        Me.gadd.Name = "gadd"
        Me.gadd.Size = New System.Drawing.Size(446, 27)
        Me.gadd.TabIndex = 45
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 124)
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
        Me.mcont.Location = New System.Drawing.Point(791, 79)
        Me.mcont.MaxLength = 11
        Me.mcont.Name = "mcont"
        Me.mcont.Size = New System.Drawing.Size(137, 27)
        Me.mcont.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(701, 85)
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
        Me.moccu.Location = New System.Drawing.Point(520, 77)
        Me.moccu.Name = "moccu"
        Me.moccu.Size = New System.Drawing.Size(157, 27)
        Me.moccu.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(413, 82)
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
        Me.fcont.Location = New System.Drawing.Point(791, 37)
        Me.fcont.MaxLength = 11
        Me.fcont.Name = "fcont"
        Me.fcont.Size = New System.Drawing.Size(137, 27)
        Me.fcont.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(701, 40)
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
        Me.father.Size = New System.Drawing.Size(255, 27)
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
        Me.guardian.Location = New System.Drawing.Point(150, 120)
        Me.guardian.Name = "guardian"
        Me.guardian.Size = New System.Drawing.Size(256, 27)
        Me.guardian.TabIndex = 13
        '
        'foccu
        '
        Me.foccu.BackColor = System.Drawing.Color.DodgerBlue
        Me.foccu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foccu.ForeColor = System.Drawing.Color.White
        Me.foccu.Location = New System.Drawing.Point(520, 35)
        Me.foccu.Name = "foccu"
        Me.foccu.Size = New System.Drawing.Size(157, 27)
        Me.foccu.TabIndex = 12
        '
        'mother
        '
        Me.mother.BackColor = System.Drawing.Color.DodgerBlue
        Me.mother.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mother.ForeColor = System.Drawing.Color.White
        Me.mother.Location = New System.Drawing.Point(151, 77)
        Me.mother.Name = "mother"
        Me.mother.Size = New System.Drawing.Size(255, 27)
        Me.mother.TabIndex = 11
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(20, 165)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 18)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Address:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(413, 39)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(101, 18)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Occupation:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 85)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(119, 18)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Mothers Name:"
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
        Me.btn_import.Location = New System.Drawing.Point(826, 238)
        Me.btn_import.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(135, 52)
        Me.btn_import.TabIndex = 66
        Me.btn_import.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(729, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 329)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'btnupdate
        '
        Me.btnupdate.ActiveBorderThickness = 1
        Me.btnupdate.ActiveCornerRadius = 20
        Me.btnupdate.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.btnupdate.ActiveForecolor = System.Drawing.Color.White
        Me.btnupdate.ActiveLineColor = System.Drawing.Color.White
        Me.btnupdate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnupdate.BackgroundImage = CType(resources.GetObject("btnupdate.BackgroundImage"), System.Drawing.Image)
        Me.btnupdate.ButtonText = "UPDATE"
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.Black
        Me.btnupdate.IdleBorderThickness = 1
        Me.btnupdate.IdleCornerRadius = 20
        Me.btnupdate.IdleFillColor = System.Drawing.Color.White
        Me.btnupdate.IdleForecolor = System.Drawing.Color.Black
        Me.btnupdate.IdleLineColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(826, 562)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(135, 52)
        Me.btnupdate.TabIndex = 67
        Me.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncancel
        '
        Me.btncancel.ActiveBorderThickness = 1
        Me.btncancel.ActiveCornerRadius = 20
        Me.btncancel.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.btncancel.ActiveForecolor = System.Drawing.Color.White
        Me.btncancel.ActiveLineColor = System.Drawing.Color.White
        Me.btncancel.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancel.BackgroundImage = CType(resources.GetObject("btncancel.BackgroundImage"), System.Drawing.Image)
        Me.btncancel.ButtonText = "CANCEL"
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.IdleBorderThickness = 1
        Me.btncancel.IdleCornerRadius = 20
        Me.btncancel.IdleFillColor = System.Drawing.Color.White
        Me.btncancel.IdleForecolor = System.Drawing.Color.Black
        Me.btncancel.IdleLineColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(681, 562)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(135, 52)
        Me.btncancel.TabIndex = 68
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updatestudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1003, 636)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btn_import)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbldaya)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "updatestudents"
        Me.Text = "Update Students"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grade As TextBox
    Friend WithEvents studtype As TextBox
    Friend WithEvents txt_bp As TextBox
    Friend WithEvents txt_fn As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_ln As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txt_sf As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_mn As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents LRN As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents age As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lbldaya As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pangalan As TextBox
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
    Friend WithEvents btn_import As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnupdate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents birthday As DateTimePicker
    Friend WithEvents gender As ComboBox
    Friend WithEvents btncancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtsec As ComboBox
End Class
