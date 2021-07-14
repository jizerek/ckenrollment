<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Forgot_Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forgot_Password))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pass1 = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.send = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.contact = New System.Windows.Forms.TextBox()
        Me.vc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vcode = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.empid = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtbox_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btn_back = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_confirm = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.pass1)
        Me.GroupBox1.Controls.Add(Me.pass)
        Me.GroupBox1.Controls.Add(Me.send)
        Me.GroupBox1.Controls.Add(Me.contact)
        Me.GroupBox1.Controls.Add(Me.vc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.username)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.vcode)
        Me.GroupBox1.Controls.Add(Me.empid)
        Me.GroupBox1.Controls.Add(Me.txtbox_name)
        Me.GroupBox1.Controls.Add(Me.btn_back)
        Me.GroupBox1.Controls.Add(Me.btn_confirm)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 478)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'pass1
        '
        Me.pass1.BackColor = System.Drawing.Color.DodgerBlue
        Me.pass1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass1.ForeColor = System.Drawing.SystemColors.Window
        Me.pass1.Location = New System.Drawing.Point(161, 280)
        Me.pass1.MaxLength = 16
        Me.pass1.Multiline = True
        Me.pass1.Name = "pass1"
        Me.pass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass1.Size = New System.Drawing.Size(266, 30)
        Me.pass1.TabIndex = 61
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.DodgerBlue
        Me.pass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.ForeColor = System.Drawing.SystemColors.Window
        Me.pass.Location = New System.Drawing.Point(161, 233)
        Me.pass.MaxLength = 16
        Me.pass.Multiline = True
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(266, 30)
        Me.pass.TabIndex = 60
        '
        'send
        '
        Me.send.ActiveBorderThickness = 1
        Me.send.ActiveCornerRadius = 20
        Me.send.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.send.ActiveForecolor = System.Drawing.Color.White
        Me.send.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.send.BackColor = System.Drawing.Color.DodgerBlue
        Me.send.BackgroundImage = CType(resources.GetObject("send.BackgroundImage"), System.Drawing.Image)
        Me.send.ButtonText = "Send Verification"
        Me.send.Cursor = System.Windows.Forms.Cursors.Hand
        Me.send.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.send.ForeColor = System.Drawing.Color.White
        Me.send.IdleBorderThickness = 3
        Me.send.IdleCornerRadius = 25
        Me.send.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.send.IdleForecolor = System.Drawing.Color.White
        Me.send.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.send.Location = New System.Drawing.Point(429, 84)
        Me.send.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.send.Name = "send"
        Me.send.Size = New System.Drawing.Size(114, 86)
        Me.send.TabIndex = 58
        Me.send.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'contact
        '
        Me.contact.Location = New System.Drawing.Point(130, 16)
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(100, 20)
        Me.contact.TabIndex = 57
        Me.contact.Visible = False
        '
        'vc
        '
        Me.vc.Location = New System.Drawing.Point(15, 19)
        Me.vc.Name = "vc"
        Me.vc.Size = New System.Drawing.Size(100, 20)
        Me.vc.TabIndex = 56
        Me.vc.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(36, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 19)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Username:"
        '
        'username
        '
        Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.Gray
        Me.username.HintForeColor = System.Drawing.Color.Empty
        Me.username.HintText = ""
        Me.username.isPassword = False
        Me.username.LineFocusedColor = System.Drawing.Color.Blue
        Me.username.LineIdleColor = System.Drawing.Color.White
        Me.username.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.username.LineThickness = 4
        Me.username.Location = New System.Drawing.Point(160, 43)
        Me.username.Margin = New System.Windows.Forms.Padding(4)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(267, 39)
        Me.username.TabIndex = 54
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 19)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Confirm Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 19)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "New Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 19)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Verification Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 19)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Employee ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Name:"
        '
        'vcode
        '
        Me.vcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.vcode.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vcode.ForeColor = System.Drawing.Color.Gray
        Me.vcode.HintForeColor = System.Drawing.Color.Empty
        Me.vcode.HintText = ""
        Me.vcode.isPassword = False
        Me.vcode.LineFocusedColor = System.Drawing.Color.Blue
        Me.vcode.LineIdleColor = System.Drawing.Color.White
        Me.vcode.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.vcode.LineThickness = 4
        Me.vcode.Location = New System.Drawing.Point(160, 179)
        Me.vcode.Margin = New System.Windows.Forms.Padding(4)
        Me.vcode.Name = "vcode"
        Me.vcode.Size = New System.Drawing.Size(267, 39)
        Me.vcode.TabIndex = 46
        Me.vcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'empid
        '
        Me.empid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.empid.Enabled = False
        Me.empid.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empid.ForeColor = System.Drawing.Color.Red
        Me.empid.HintForeColor = System.Drawing.Color.Empty
        Me.empid.HintText = ""
        Me.empid.isPassword = False
        Me.empid.LineFocusedColor = System.Drawing.Color.Blue
        Me.empid.LineIdleColor = System.Drawing.Color.White
        Me.empid.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.empid.LineThickness = 4
        Me.empid.Location = New System.Drawing.Point(160, 132)
        Me.empid.Margin = New System.Windows.Forms.Padding(4)
        Me.empid.Name = "empid"
        Me.empid.Size = New System.Drawing.Size(267, 39)
        Me.empid.TabIndex = 19
        Me.empid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtbox_name
        '
        Me.txtbox_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_name.Enabled = False
        Me.txtbox_name.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_name.ForeColor = System.Drawing.Color.Red
        Me.txtbox_name.HintForeColor = System.Drawing.Color.Empty
        Me.txtbox_name.HintText = ""
        Me.txtbox_name.isPassword = False
        Me.txtbox_name.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtbox_name.LineIdleColor = System.Drawing.Color.White
        Me.txtbox_name.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtbox_name.LineThickness = 4
        Me.txtbox_name.Location = New System.Drawing.Point(160, 84)
        Me.txtbox_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbox_name.Name = "txtbox_name"
        Me.txtbox_name.Size = New System.Drawing.Size(267, 39)
        Me.txtbox_name.TabIndex = 18
        Me.txtbox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_back
        '
        Me.btn_back.ActiveBorderThickness = 1
        Me.btn_back.ActiveCornerRadius = 20
        Me.btn_back.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.btn_back.ActiveForecolor = System.Drawing.Color.White
        Me.btn_back.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_back.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.ButtonText = "B A C K"
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.IdleBorderThickness = 3
        Me.btn_back.IdleCornerRadius = 25
        Me.btn_back.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_back.IdleForecolor = System.Drawing.Color.White
        Me.btn_back.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_back.Location = New System.Drawing.Point(75, 404)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(317, 54)
        Me.btn_back.TabIndex = 17
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_confirm
        '
        Me.btn_confirm.ActiveBorderThickness = 1
        Me.btn_confirm.ActiveCornerRadius = 20
        Me.btn_confirm.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.btn_confirm.ActiveForecolor = System.Drawing.Color.White
        Me.btn_confirm.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_confirm.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_confirm.BackgroundImage = CType(resources.GetObject("btn_confirm.BackgroundImage"), System.Drawing.Image)
        Me.btn_confirm.ButtonText = "C O N F I R M"
        Me.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirm.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.ForeColor = System.Drawing.Color.White
        Me.btn_confirm.IdleBorderThickness = 3
        Me.btn_confirm.IdleCornerRadius = 25
        Me.btn_confirm.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_confirm.IdleForecolor = System.Drawing.Color.White
        Me.btn_confirm.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btn_confirm.Location = New System.Drawing.Point(75, 350)
        Me.btn_confirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(317, 54)
        Me.btn_confirm.TabIndex = 1
        Me.btn_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Forgot_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(574, 535)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Forgot_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot_Password"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_confirm As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_back As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents vcode As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents empid As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtbox_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents vc As TextBox
    Friend WithEvents contact As TextBox
    Friend WithEvents send As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents pass1 As TextBox
    Friend WithEvents pass As TextBox
End Class
