<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update))
        Me.contact = New System.Windows.Forms.TextBox()
        Me.cancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtbox_user = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pangalan = New System.Windows.Forms.TextBox()
        Me.txt_mn = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.etad = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Label()
        Me.btn_delete = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.em_id = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ln = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.age = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_fn = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.birthday = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.position = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_add = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_sf = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_import = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_update = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.daya = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'contact
        '
        Me.contact.BackColor = System.Drawing.Color.DodgerBlue
        Me.contact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.contact.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.contact.ForeColor = System.Drawing.Color.White
        Me.contact.Location = New System.Drawing.Point(155, 396)
        Me.contact.MaxLength = 11
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(192, 16)
        Me.contact.TabIndex = 63
        '
        'cancel
        '
        Me.cancel.ActiveBorderThickness = 1
        Me.cancel.ActiveCornerRadius = 20
        Me.cancel.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.cancel.ActiveForecolor = System.Drawing.Color.White
        Me.cancel.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.cancel.BackColor = System.Drawing.Color.DodgerBlue
        Me.cancel.BackgroundImage = CType(resources.GetObject("cancel.BackgroundImage"), System.Drawing.Image)
        Me.cancel.ButtonText = "C A N C E L"
        Me.cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.ForeColor = System.Drawing.Color.White
        Me.cancel.IdleBorderThickness = 3
        Me.cancel.IdleCornerRadius = 25
        Me.cancel.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.cancel.IdleForecolor = System.Drawing.Color.White
        Me.cancel.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.cancel.Location = New System.Drawing.Point(706, 361)
        Me.cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(167, 50)
        Me.cancel.TabIndex = 65
        Me.cancel.Tag = ""
        Me.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'password
        '
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.password.ForeColor = System.Drawing.Color.White
        Me.password.HintForeColor = System.Drawing.Color.White
        Me.password.HintText = ""
        Me.password.isPassword = False
        Me.password.LineFocusedColor = System.Drawing.Color.Red
        Me.password.LineIdleColor = System.Drawing.Color.White
        Me.password.LineMouseHoverColor = System.Drawing.Color.White
        Me.password.LineThickness = 2
        Me.password.Location = New System.Drawing.Point(473, 433)
        Me.password.Margin = New System.Windows.Forms.Padding(4)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(189, 33)
        Me.password.TabIndex = 64
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtbox_user
        '
        Me.txtbox_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_user.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtbox_user.ForeColor = System.Drawing.Color.White
        Me.txtbox_user.HintForeColor = System.Drawing.Color.White
        Me.txtbox_user.HintText = ""
        Me.txtbox_user.isPassword = False
        Me.txtbox_user.LineFocusedColor = System.Drawing.Color.Red
        Me.txtbox_user.LineIdleColor = System.Drawing.Color.White
        Me.txtbox_user.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtbox_user.LineThickness = 2
        Me.txtbox_user.Location = New System.Drawing.Point(141, 433)
        Me.txtbox_user.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbox_user.Name = "txtbox_user"
        Me.txtbox_user.Size = New System.Drawing.Size(189, 33)
        Me.txtbox_user.TabIndex = 60
        Me.txtbox_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(33, 447)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 19)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Username:"
        '
        'pangalan
        '
        Me.pangalan.Location = New System.Drawing.Point(72, 522)
        Me.pangalan.Name = "pangalan"
        Me.pangalan.Size = New System.Drawing.Size(270, 20)
        Me.pangalan.TabIndex = 58
        Me.pangalan.Visible = False
        '
        'txt_mn
        '
        Me.txt_mn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_mn.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_mn.ForeColor = System.Drawing.Color.White
        Me.txt_mn.HintForeColor = System.Drawing.Color.White
        Me.txt_mn.HintText = ""
        Me.txt_mn.isPassword = False
        Me.txt_mn.LineFocusedColor = System.Drawing.Color.Red
        Me.txt_mn.LineIdleColor = System.Drawing.Color.White
        Me.txt_mn.LineMouseHoverColor = System.Drawing.Color.White
        Me.txt_mn.LineThickness = 2
        Me.txt_mn.Location = New System.Drawing.Point(137, 168)
        Me.txt_mn.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_mn.Name = "txt_mn"
        Me.txt_mn.Size = New System.Drawing.Size(189, 33)
        Me.txt_mn.TabIndex = 57
        Me.txt_mn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(369, 447)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 19)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Password:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(23, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 19)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Middlename:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox2.Controls.Add(Me.etad)
        Me.GroupBox2.Controls.Add(Me.time)
        Me.GroupBox2.Controls.Add(Me.btn_delete)
        Me.GroupBox2.Controls.Add(Me.txt_mn)
        Me.GroupBox2.Controls.Add(Me.gender)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.em_id)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.contact)
        Me.GroupBox2.Controls.Add(Me.cancel)
        Me.GroupBox2.Controls.Add(Me.password)
        Me.GroupBox2.Controls.Add(Me.txtbox_user)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_ln)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.age)
        Me.GroupBox2.Controls.Add(Me.txt_fn)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.birthday)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.position)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_add)
        Me.GroupBox2.Controls.Add(Me.txt_sf)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btn_import)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.btn_update)
        Me.GroupBox2.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(888, 504)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        '
        'etad
        '
        Me.etad.AutoSize = True
        Me.etad.Location = New System.Drawing.Point(520, 47)
        Me.etad.Name = "etad"
        Me.etad.Size = New System.Drawing.Size(42, 18)
        Me.etad.TabIndex = 73
        Me.etad.Text = "date"
        Me.etad.Visible = False
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.Location = New System.Drawing.Point(520, 22)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(40, 18)
        Me.time.TabIndex = 72
        Me.time.Text = "time"
        Me.time.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.ActiveBorderThickness = 1
        Me.btn_delete.ActiveCornerRadius = 20
        Me.btn_delete.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.btn_delete.ActiveForecolor = System.Drawing.Color.White
        Me.btn_delete.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_delete.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_delete.BackgroundImage = CType(resources.GetObject("btn_delete.BackgroundImage"), System.Drawing.Image)
        Me.btn_delete.ButtonText = "D E L E T E"
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.IdleBorderThickness = 3
        Me.btn_delete.IdleCornerRadius = 25
        Me.btn_delete.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btn_delete.IdleForecolor = System.Drawing.Color.White
        Me.btn_delete.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_delete.Location = New System.Drawing.Point(706, 315)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(167, 50)
        Me.btn_delete.TabIndex = 71
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gender
        '
        Me.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.FormattingEnabled = True
        Me.gender.Location = New System.Drawing.Point(145, 284)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(189, 28)
        Me.gender.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(34, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 19)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Gender:"
        '
        'em_id
        '
        Me.em_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.em_id.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.em_id.ForeColor = System.Drawing.Color.White
        Me.em_id.HintForeColor = System.Drawing.Color.White
        Me.em_id.HintText = ""
        Me.em_id.isPassword = False
        Me.em_id.LineFocusedColor = System.Drawing.Color.Red
        Me.em_id.LineIdleColor = System.Drawing.Color.White
        Me.em_id.LineMouseHoverColor = System.Drawing.Color.White
        Me.em_id.LineThickness = 2
        Me.em_id.Location = New System.Drawing.Point(135, 47)
        Me.em_id.Margin = New System.Windows.Forms.Padding(4)
        Me.em_id.Name = "em_id"
        Me.em_id.Size = New System.Drawing.Size(189, 33)
        Me.em_id.TabIndex = 68
        Me.em_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Employee #:"
        '
        'txt_ln
        '
        Me.txt_ln.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ln.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_ln.ForeColor = System.Drawing.Color.White
        Me.txt_ln.HintForeColor = System.Drawing.Color.White
        Me.txt_ln.HintText = ""
        Me.txt_ln.isPassword = False
        Me.txt_ln.LineFocusedColor = System.Drawing.Color.Red
        Me.txt_ln.LineIdleColor = System.Drawing.Color.White
        Me.txt_ln.LineMouseHoverColor = System.Drawing.Color.White
        Me.txt_ln.LineThickness = 2
        Me.txt_ln.Location = New System.Drawing.Point(136, 99)
        Me.txt_ln.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ln.Name = "txt_ln"
        Me.txt_ln.Size = New System.Drawing.Size(189, 33)
        Me.txt_ln.TabIndex = 53
        Me.txt_ln.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(25, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 19)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Lastname:"
        '
        'age
        '
        Me.age.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.age.Enabled = False
        Me.age.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.ForeColor = System.Drawing.Color.White
        Me.age.HintForeColor = System.Drawing.Color.White
        Me.age.HintText = ""
        Me.age.isPassword = False
        Me.age.LineFocusedColor = System.Drawing.Color.Red
        Me.age.LineIdleColor = System.Drawing.Color.White
        Me.age.LineMouseHoverColor = System.Drawing.Color.White
        Me.age.LineThickness = 3
        Me.age.Location = New System.Drawing.Point(477, 329)
        Me.age.Margin = New System.Windows.Forms.Padding(4)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(189, 33)
        Me.age.TabIndex = 50
        Me.age.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_fn
        '
        Me.txt_fn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_fn.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_fn.ForeColor = System.Drawing.Color.White
        Me.txt_fn.HintForeColor = System.Drawing.Color.White
        Me.txt_fn.HintText = ""
        Me.txt_fn.isPassword = False
        Me.txt_fn.LineFocusedColor = System.Drawing.Color.Red
        Me.txt_fn.LineIdleColor = System.Drawing.Color.White
        Me.txt_fn.LineMouseHoverColor = System.Drawing.Color.White
        Me.txt_fn.LineThickness = 2
        Me.txt_fn.Location = New System.Drawing.Point(477, 100)
        Me.txt_fn.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fn.Name = "txt_fn"
        Me.txt_fn.Size = New System.Drawing.Size(189, 33)
        Me.txt_fn.TabIndex = 36
        Me.txt_fn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(371, 345)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 19)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Age:"
        '
        'birthday
        '
        Me.birthday.CalendarFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthday.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.birthday.Location = New System.Drawing.Point(145, 338)
        Me.birthday.Name = "birthday"
        Me.birthday.Size = New System.Drawing.Size(189, 26)
        Me.birthday.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(366, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Firstname:"
        '
        'position
        '
        Me.position.AutoCompleteCustomSource.AddRange(New String() {"Cashier ", "Registrar"})
        Me.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.position.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.position.FormattingEnabled = True
        Me.position.Location = New System.Drawing.Point(477, 284)
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(189, 28)
        Me.position.TabIndex = 45
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(368, 293)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 19)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Position:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(37, 343)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 19)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Birthday:"
        '
        'txt_add
        '
        Me.txt_add.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_add.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_add.ForeColor = System.Drawing.Color.White
        Me.txt_add.HintForeColor = System.Drawing.Color.White
        Me.txt_add.HintText = ""
        Me.txt_add.isPassword = False
        Me.txt_add.LineFocusedColor = System.Drawing.Color.Red
        Me.txt_add.LineIdleColor = System.Drawing.Color.White
        Me.txt_add.LineMouseHoverColor = System.Drawing.Color.White
        Me.txt_add.LineThickness = 2
        Me.txt_add.Location = New System.Drawing.Point(136, 221)
        Me.txt_add.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_add.Name = "txt_add"
        Me.txt_add.Size = New System.Drawing.Size(531, 33)
        Me.txt_add.TabIndex = 45
        Me.txt_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_sf
        '
        Me.txt_sf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_sf.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_sf.ForeColor = System.Drawing.Color.White
        Me.txt_sf.HintForeColor = System.Drawing.Color.White
        Me.txt_sf.HintText = ""
        Me.txt_sf.isPassword = False
        Me.txt_sf.LineFocusedColor = System.Drawing.Color.Red
        Me.txt_sf.LineIdleColor = System.Drawing.Color.White
        Me.txt_sf.LineMouseHoverColor = System.Drawing.Color.White
        Me.txt_sf.LineThickness = 2
        Me.txt_sf.Location = New System.Drawing.Point(478, 167)
        Me.txt_sf.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_sf.Name = "txt_sf"
        Me.txt_sf.Size = New System.Drawing.Size(189, 33)
        Me.txt_sf.TabIndex = 45
        Me.txt_sf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(25, 231)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 19)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Address:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(350, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 19)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Suffix (JR III IV):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(35, 393)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 19)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Contact No.:"
        '
        'btn_import
        '
        Me.btn_import.ActiveBorderThickness = 1
        Me.btn_import.ActiveCornerRadius = 20
        Me.btn_import.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.btn_import.ActiveForecolor = System.Drawing.Color.White
        Me.btn_import.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_import.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_import.BackgroundImage = CType(resources.GetObject("btn_import.BackgroundImage"), System.Drawing.Image)
        Me.btn_import.ButtonText = "I M P O R T"
        Me.btn_import.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_import.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_import.ForeColor = System.Drawing.Color.White
        Me.btn_import.IdleBorderThickness = 3
        Me.btn_import.IdleCornerRadius = 25
        Me.btn_import.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btn_import.IdleForecolor = System.Drawing.Color.White
        Me.btn_import.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_import.Location = New System.Drawing.Point(706, 204)
        Me.btn_import.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(167, 50)
        Me.btn_import.TabIndex = 45
        Me.btn_import.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(698, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 145)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profile"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(19, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'btn_update
        '
        Me.btn_update.ActiveBorderThickness = 1
        Me.btn_update.ActiveCornerRadius = 20
        Me.btn_update.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.btn_update.ActiveForecolor = System.Drawing.Color.White
        Me.btn_update.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_update.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_update.BackgroundImage = CType(resources.GetObject("btn_update.BackgroundImage"), System.Drawing.Image)
        Me.btn_update.ButtonText = "U P D A T E"
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.IdleBorderThickness = 3
        Me.btn_update.IdleCornerRadius = 25
        Me.btn_update.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btn_update.IdleForecolor = System.Drawing.Color.White
        Me.btn_update.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_update.Location = New System.Drawing.Point(706, 262)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(167, 50)
        Me.btn_update.TabIndex = 35
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Enabled = False
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.White
        Me.BunifuMaterialTextbox1.HintText = ""
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Red
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.White
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.White
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(146, 383)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(189, 33)
        Me.BunifuMaterialTextbox1.TabIndex = 74
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'daya
        '
        Me.daya.AutoSize = True
        Me.daya.Location = New System.Drawing.Point(243, 498)
        Me.daya.Name = "daya"
        Me.daya.Size = New System.Drawing.Size(36, 13)
        Me.daya.TabIndex = 51
        Me.daya.Text = "DAYA"
        Me.daya.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(17, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 19)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Gender:"
        '
        'Timer1
        '
        '
        'Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(913, 547)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pangalan)
        Me.Controls.Add(Me.daya)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Update"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents contact As TextBox
    Friend WithEvents cancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtbox_user As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents pangalan As TextBox
    Friend WithEvents txt_mn As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_ln As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents daya As Label
    Friend WithEvents age As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_fn As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label14 As Label
    Friend WithEvents birthday As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents position As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_add As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_sf As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_import As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_update As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label5 As Label
    Friend WithEvents em_id As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents gender As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_delete As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents etad As Label
    Friend WithEvents time As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
