<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.position = New System.Windows.Forms.TextBox()
        Me.d = New System.Windows.Forms.Label()
        Me.t = New System.Windows.Forms.Label()
        Me.pangalan = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtbox_user = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btn_login = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_cancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.labas = New System.Windows.Forms.PictureBox()
        Me.txtbox_pass = New System.Windows.Forms.TextBox()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.tago = New System.Windows.Forms.PictureBox()
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.labas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.position)
        Me.GunaGradientPanel1.Controls.Add(Me.d)
        Me.GunaGradientPanel1.Controls.Add(Me.t)
        Me.GunaGradientPanel1.Controls.Add(Me.pangalan)
        Me.GunaGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.GunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaGradientPanel1.GradiantColor1 = System.Drawing.Color.CornflowerBlue
        Me.GunaGradientPanel1.GradiantColor2 = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GunaGradientPanel1.GradiantColor3 = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GunaGradientPanel1.GradiantColor4 = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(325, 379)
        Me.GunaGradientPanel1.TabIndex = 0
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'position
        '
        Me.position.Location = New System.Drawing.Point(12, 339)
        Me.position.Name = "position"
        Me.position.Size = New System.Drawing.Size(274, 20)
        Me.position.TabIndex = 4
        Me.position.Visible = False
        '
        'd
        '
        Me.d.AutoSize = True
        Me.d.Location = New System.Drawing.Point(164, 12)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(39, 13)
        Me.d.TabIndex = 3
        Me.d.Text = "Label2"
        Me.d.Visible = False
        '
        't
        '
        Me.t.AutoSize = True
        Me.t.Location = New System.Drawing.Point(91, 8)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(39, 13)
        Me.t.TabIndex = 2
        Me.t.Text = "Label1"
        Me.t.Visible = False
        '
        'pangalan
        '
        Me.pangalan.Location = New System.Drawing.Point(12, 28)
        Me.pangalan.Name = "pangalan"
        Me.pangalan.Size = New System.Drawing.Size(274, 20)
        Me.pangalan.TabIndex = 1
        Me.pangalan.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(325, 261)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtbox_user
        '
        Me.txtbox_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_user.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtbox_user.ForeColor = System.Drawing.Color.White
        Me.txtbox_user.HintForeColor = System.Drawing.Color.White
        Me.txtbox_user.HintText = "Username"
        Me.txtbox_user.isPassword = False
        Me.txtbox_user.LineFocusedColor = System.Drawing.Color.Red
        Me.txtbox_user.LineIdleColor = System.Drawing.Color.White
        Me.txtbox_user.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtbox_user.LineThickness = 2
        Me.txtbox_user.Location = New System.Drawing.Point(69, 44)
        Me.txtbox_user.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbox_user.Name = "txtbox_user"
        Me.txtbox_user.Size = New System.Drawing.Size(218, 33)
        Me.txtbox_user.TabIndex = 6
        Me.txtbox_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_login
        '
        Me.btn_login.ActiveBorderThickness = 1
        Me.btn_login.ActiveCornerRadius = 20
        Me.btn_login.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.btn_login.ActiveForecolor = System.Drawing.Color.White
        Me.btn_login.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_login.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_login.BackgroundImage = CType(resources.GetObject("btn_login.BackgroundImage"), System.Drawing.Image)
        Me.btn_login.ButtonText = "L O G - I N"
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.IdleBorderThickness = 3
        Me.btn_login.IdleCornerRadius = 25
        Me.btn_login.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_login.IdleForecolor = System.Drawing.Color.White
        Me.btn_login.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_login.Location = New System.Drawing.Point(31, 188)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(256, 54)
        Me.btn_login.TabIndex = 1
        Me.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cancel
        '
        Me.btn_cancel.ActiveBorderThickness = 1
        Me.btn_cancel.ActiveCornerRadius = 20
        Me.btn_cancel.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.btn_cancel.ActiveForecolor = System.Drawing.Color.White
        Me.btn_cancel.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_cancel.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_cancel.BackgroundImage = CType(resources.GetObject("btn_cancel.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancel.ButtonText = "C A N C E L"
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.IdleBorderThickness = 3
        Me.btn_cancel.IdleCornerRadius = 25
        Me.btn_cancel.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_cancel.IdleForecolor = System.Drawing.Color.White
        Me.btn_cancel.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_cancel.Location = New System.Drawing.Point(31, 242)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(256, 54)
        Me.btn_cancel.TabIndex = 5
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLinkLabel1
        '
        Me.GunaLinkLabel1.AutoSize = True
        Me.GunaLinkLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLinkLabel1.LinkColor = System.Drawing.Color.White
        Me.GunaLinkLabel1.Location = New System.Drawing.Point(165, 153)
        Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
        Me.GunaLinkLabel1.Size = New System.Drawing.Size(122, 16)
        Me.GunaLinkLabel1.TabIndex = 4
        Me.GunaLinkLabel1.TabStop = True
        Me.GunaLinkLabel1.Text = "Forgot Password?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.labas)
        Me.GroupBox1.Controls.Add(Me.txtbox_pass)
        Me.GroupBox1.Controls.Add(Me.IconButton2)
        Me.GroupBox1.Controls.Add(Me.IconButton1)
        Me.GroupBox1.Controls.Add(Me.txtbox_user)
        Me.GroupBox1.Controls.Add(Me.btn_login)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.GunaLinkLabel1)
        Me.GroupBox1.Controls.Add(Me.tago)
        Me.GroupBox1.Location = New System.Drawing.Point(334, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 331)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'labas
        '
        Me.labas.BackgroundImage = CType(resources.GetObject("labas.BackgroundImage"), System.Drawing.Image)
        Me.labas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.labas.Location = New System.Drawing.Point(257, 93)
        Me.labas.Name = "labas"
        Me.labas.Size = New System.Drawing.Size(30, 30)
        Me.labas.TabIndex = 16
        Me.labas.TabStop = False
        '
        'txtbox_pass
        '
        Me.txtbox_pass.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtbox_pass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_pass.ForeColor = System.Drawing.SystemColors.Window
        Me.txtbox_pass.Location = New System.Drawing.Point(69, 93)
        Me.txtbox_pass.MaxLength = 16
        Me.txtbox_pass.Multiline = True
        Me.txtbox_pass.Name = "txtbox_pass"
        Me.txtbox_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_pass.Size = New System.Drawing.Size(189, 30)
        Me.txtbox_pass.TabIndex = 15
        '
        'IconButton2
        '
        Me.IconButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton2.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Key
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 40
        Me.IconButton2.Location = New System.Drawing.Point(22, 93)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(45, 34)
        Me.IconButton2.TabIndex = 14
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Envelope
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 50
        Me.IconButton1.Location = New System.Drawing.Point(22, 46)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(45, 34)
        Me.IconButton1.TabIndex = 12
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'tago
        '
        Me.tago.BackgroundImage = CType(resources.GetObject("tago.BackgroundImage"), System.Drawing.Image)
        Me.tago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tago.Location = New System.Drawing.Point(257, 93)
        Me.tago.Name = "tago"
        Me.tago.Size = New System.Drawing.Size(30, 30)
        Me.tago.TabIndex = 17
        Me.tago.TabStop = False
        Me.tago.Visible = False
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.White
        Me.btn_exit.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btn_exit.IconColor = System.Drawing.Color.White
        Me.btn_exit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_exit.IconSize = 18
        Me.btn_exit.Location = New System.Drawing.Point(626, 2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Rotation = 0R
        Me.btn_exit.Size = New System.Drawing.Size(20, 20)
        Me.btn_exit.TabIndex = 11
        Me.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(650, 379)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.labas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtbox_user As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btn_login As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_cancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents pangalan As TextBox
    Friend WithEvents d As Label
    Friend WithEvents t As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents position As TextBox
    Friend WithEvents txtbox_pass As TextBox
    Friend WithEvents labas As PictureBox
    Friend WithEvents tago As PictureBox
End Class
