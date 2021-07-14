<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.picture = New System.Windows.Forms.Label()
        Me.enrolled = New System.Windows.Forms.Label()
        Me.grade = New System.Windows.Forms.TextBox()
        Me.section = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtbox_lrn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox_name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ammount = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.balance = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pay = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cash = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.change = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.balancetago = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.picture)
        Me.GroupBox2.Controls.Add(Me.enrolled)
        Me.GroupBox2.Controls.Add(Me.grade)
        Me.GroupBox2.Controls.Add(Me.section)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.txtbox_lrn)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtbox_name)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(62, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(900, 167)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        '
        'picture
        '
        Me.picture.AutoSize = True
        Me.picture.Location = New System.Drawing.Point(485, 109)
        Me.picture.Name = "picture"
        Me.picture.Size = New System.Drawing.Size(39, 13)
        Me.picture.TabIndex = 50
        Me.picture.Text = "Label8"
        Me.picture.Visible = False
        '
        'enrolled
        '
        Me.enrolled.AutoSize = True
        Me.enrolled.Location = New System.Drawing.Point(482, 138)
        Me.enrolled.Name = "enrolled"
        Me.enrolled.Size = New System.Drawing.Size(45, 13)
        Me.enrolled.TabIndex = 49
        Me.enrolled.Text = "Enrolled"
        Me.enrolled.Visible = False
        '
        'grade
        '
        Me.grade.BackColor = System.Drawing.Color.DodgerBlue
        Me.grade.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grade.ForeColor = System.Drawing.Color.White
        Me.grade.Location = New System.Drawing.Point(428, 20)
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(211, 27)
        Me.grade.TabIndex = 48
        '
        'section
        '
        Me.section.BackColor = System.Drawing.Color.DodgerBlue
        Me.section.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.section.ForeColor = System.Drawing.Color.White
        Me.section.Location = New System.Drawing.Point(428, 52)
        Me.section.Name = "section"
        Me.section.Size = New System.Drawing.Size(211, 27)
        Me.section.TabIndex = 47
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(686, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(176, 135)
        Me.GroupBox4.TabIndex = 42
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PROFILE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(27, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'txtbox_lrn
        '
        Me.txtbox_lrn.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtbox_lrn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_lrn.ForeColor = System.Drawing.Color.White
        Me.txtbox_lrn.Location = New System.Drawing.Point(96, 17)
        Me.txtbox_lrn.Name = "txtbox_lrn"
        Me.txtbox_lrn.Size = New System.Drawing.Size(211, 27)
        Me.txtbox_lrn.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'txtbox_name
        '
        Me.txtbox_name.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtbox_name.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_name.ForeColor = System.Drawing.Color.White
        Me.txtbox_name.Location = New System.Drawing.Point(96, 49)
        Me.txtbox_name.Name = "txtbox_name"
        Me.txtbox_name.Size = New System.Drawing.Size(211, 27)
        Me.txtbox_name.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(339, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Section:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LRN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(339, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Grade:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(458, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 23)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "CASH:"
        '
        'ammount
        '
        Me.ammount.BackColor = System.Drawing.Color.DodgerBlue
        Me.ammount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ammount.ForeColor = System.Drawing.Color.White
        Me.ammount.Location = New System.Drawing.Point(552, 39)
        Me.ammount.MaxLength = 5
        Me.ammount.Name = "ammount"
        Me.ammount.Size = New System.Drawing.Size(126, 27)
        Me.ammount.TabIndex = 24
        Me.ammount.Text = "0"
        Me.ammount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(16, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 5)
        Me.Panel1.TabIndex = 22
        '
        'balance
        '
        Me.balance.BackColor = System.Drawing.Color.DodgerBlue
        Me.balance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balance.ForeColor = System.Drawing.Color.White
        Me.balance.Location = New System.Drawing.Point(181, 75)
        Me.balance.Name = "balance"
        Me.balance.Size = New System.Drawing.Size(126, 27)
        Me.balance.TabIndex = 21
        Me.balance.Text = "0"
        Me.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.Color.DodgerBlue
        Me.txttotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.White
        Me.txttotal.Location = New System.Drawing.Point(181, 36)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(126, 27)
        Me.txttotal.TabIndex = 20
        Me.txttotal.Text = "0"
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(23, 39)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 23)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "TOTAL:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BunifuThinButton21)
        Me.GroupBox1.Controls.Add(Me.pay)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cash)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.change)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ammount)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.balance)
        Me.GroupBox1.Controls.Add(Me.txttotal)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(62, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(900, 222)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FEE'S"
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Cancel"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.White
        Me.BunifuThinButton21.Location = New System.Drawing.Point(470, 156)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(100, 46)
        Me.BunifuThinButton21.TabIndex = 68
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pay
        '
        Me.pay.ActiveBorderThickness = 1
        Me.pay.ActiveCornerRadius = 20
        Me.pay.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.pay.ActiveForecolor = System.Drawing.Color.White
        Me.pay.ActiveLineColor = System.Drawing.Color.White
        Me.pay.BackColor = System.Drawing.Color.DodgerBlue
        Me.pay.BackgroundImage = CType(resources.GetObject("pay.BackgroundImage"), System.Drawing.Image)
        Me.pay.ButtonText = "Pay"
        Me.pay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay.ForeColor = System.Drawing.Color.Black
        Me.pay.IdleBorderThickness = 1
        Me.pay.IdleCornerRadius = 20
        Me.pay.IdleFillColor = System.Drawing.Color.White
        Me.pay.IdleForecolor = System.Drawing.Color.Black
        Me.pay.IdleLineColor = System.Drawing.Color.White
        Me.pay.Location = New System.Drawing.Point(578, 156)
        Me.pay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pay.Name = "pay"
        Me.pay.Size = New System.Drawing.Size(100, 46)
        Me.pay.TabIndex = 67
        Me.pay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(432, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 23)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "AMMOUNT:"
        '
        'cash
        '
        Me.cash.BackColor = System.Drawing.Color.DodgerBlue
        Me.cash.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cash.ForeColor = System.Drawing.Color.White
        Me.cash.Location = New System.Drawing.Point(552, 80)
        Me.cash.MaxLength = 5
        Me.cash.Name = "cash"
        Me.cash.Size = New System.Drawing.Size(126, 27)
        Me.cash.TabIndex = 30
        Me.cash.Text = "0"
        Me.cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(453, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 23)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "CHANGE:"
        '
        'change
        '
        Me.change.BackColor = System.Drawing.Color.DodgerBlue
        Me.change.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change.ForeColor = System.Drawing.Color.White
        Me.change.Location = New System.Drawing.Point(552, 117)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(126, 27)
        Me.change.TabIndex = 27
        Me.change.Text = "0"
        Me.change.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 23)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "BALANCE:"
        '
        'balancetago
        '
        Me.balancetago.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.balancetago.Enabled = False
        Me.balancetago.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balancetago.ForeColor = System.Drawing.Color.White
        Me.balancetago.Location = New System.Drawing.Point(72, 470)
        Me.balancetago.Name = "balancetago"
        Me.balancetago.Size = New System.Drawing.Size(126, 31)
        Me.balancetago.TabIndex = 29
        Me.balancetago.Text = "0"
        Me.balancetago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.balancetago.Visible = False
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(987, 614)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.balancetago)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Payment"
        Me.Text = "Payment"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtbox_lrn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ammount As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents balance As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents section As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents change As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents grade As TextBox
    Friend WithEvents balancetago As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cash As TextBox
    Friend WithEvents pay As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents enrolled As Label
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents picture As Label
End Class
