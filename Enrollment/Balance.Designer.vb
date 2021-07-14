<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Balance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Balance))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.section = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbldaya = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtbox_lrn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbo_grade = New System.Windows.Forms.ComboBox()
        Me.grade = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtbalance = New System.Windows.Forms.TextBox()
        Me.txttf = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_cancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lsv_students = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_Search = New Bunifu.Framework.UI.BunifuThinButton2()
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
        Me.GroupBox2.Controls.Add(Me.section)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lbldaya)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.txtbox_lrn)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtbox_name)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmbo_grade)
        Me.GroupBox2.Controls.Add(Me.grade)
        Me.GroupBox2.Location = New System.Drawing.Point(108, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(850, 167)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        '
        'section
        '
        Me.section.BackColor = System.Drawing.Color.DodgerBlue
        Me.section.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.section.ForeColor = System.Drawing.Color.White
        Me.section.Location = New System.Drawing.Point(468, 70)
        Me.section.Name = "section"
        Me.section.Size = New System.Drawing.Size(156, 26)
        Me.section.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(395, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Section:"
        '
        'lbldaya
        '
        Me.lbldaya.AutoSize = True
        Me.lbldaya.Location = New System.Drawing.Point(353, 138)
        Me.lbldaya.Name = "lbldaya"
        Me.lbldaya.Size = New System.Drawing.Size(39, 13)
        Me.lbldaya.TabIndex = 43
        Me.lbldaya.Text = "Label4"
        Me.lbldaya.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(644, 17)
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
        Me.txtbox_lrn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_lrn.ForeColor = System.Drawing.Color.White
        Me.txtbox_lrn.Location = New System.Drawing.Point(399, 28)
        Me.txtbox_lrn.Name = "txtbox_lrn"
        Me.txtbox_lrn.Size = New System.Drawing.Size(225, 26)
        Me.txtbox_lrn.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'txtbox_name
        '
        Me.txtbox_name.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtbox_name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_name.ForeColor = System.Drawing.Color.White
        Me.txtbox_name.Location = New System.Drawing.Point(95, 68)
        Me.txtbox_name.Name = "txtbox_name"
        Me.txtbox_name.Size = New System.Drawing.Size(291, 26)
        Me.txtbox_name.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(354, 31)
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
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Grade:"
        '
        'cmbo_grade
        '
        Me.cmbo_grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbo_grade.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbo_grade.FormattingEnabled = True
        Me.cmbo_grade.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbo_grade.Location = New System.Drawing.Point(95, 25)
        Me.cmbo_grade.Name = "cmbo_grade"
        Me.cmbo_grade.Size = New System.Drawing.Size(211, 28)
        Me.cmbo_grade.TabIndex = 6
        '
        'grade
        '
        Me.grade.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.grade.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grade.ForeColor = System.Drawing.Color.White
        Me.grade.Location = New System.Drawing.Point(95, 28)
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(212, 26)
        Me.grade.TabIndex = 44
        Me.grade.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.txtbalance)
        Me.GroupBox1.Controls.Add(Me.txttf)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(108, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(850, 122)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FEE'S"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 23)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "BALANCE:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(17, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 5)
        Me.Panel1.TabIndex = 22
        '
        'txtbalance
        '
        Me.txtbalance.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtbalance.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbalance.ForeColor = System.Drawing.Color.White
        Me.txtbalance.Location = New System.Drawing.Point(180, 70)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Size = New System.Drawing.Size(126, 31)
        Me.txtbalance.TabIndex = 21
        Me.txtbalance.Text = "0"
        Me.txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttf
        '
        Me.txttf.BackColor = System.Drawing.Color.DodgerBlue
        Me.txttf.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttf.ForeColor = System.Drawing.Color.White
        Me.txttf.Location = New System.Drawing.Point(182, 27)
        Me.txttf.Name = "txttf"
        Me.txttf.Size = New System.Drawing.Size(125, 26)
        Me.txttf.TabIndex = 11
        Me.txttf.Text = "0"
        Me.txttf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 18)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Total Fee:"
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
        Me.btn_cancel.ButtonText = "CANCEL"
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.IdleBorderThickness = 1
        Me.btn_cancel.IdleCornerRadius = 20
        Me.btn_cancel.IdleFillColor = System.Drawing.Color.White
        Me.btn_cancel.IdleForecolor = System.Drawing.Color.Black
        Me.btn_cancel.IdleLineColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(786, 611)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(100, 46)
        Me.btn_cancel.TabIndex = 52
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lsv_students
        '
        Me.lsv_students.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lsv_students.Location = New System.Drawing.Point(108, 327)
        Me.lsv_students.Name = "lsv_students"
        Me.lsv_students.Size = New System.Drawing.Size(850, 276)
        Me.lsv_students.TabIndex = 65
        Me.lsv_students.UseCompatibleStateImageBehavior = False
        Me.lsv_students.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Grade"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "LRN"
        Me.ColumnHeader8.Width = 167
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Section"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Name"
        Me.ColumnHeader10.Width = 232
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Total Fee"
        Me.ColumnHeader11.Width = 86
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Balance"
        Me.ColumnHeader12.Width = 92
        '
        'btn_Search
        '
        Me.btn_Search.ActiveBorderThickness = 1
        Me.btn_Search.ActiveCornerRadius = 20
        Me.btn_Search.ActiveFillColor = System.Drawing.Color.DodgerBlue
        Me.btn_Search.ActiveForecolor = System.Drawing.Color.White
        Me.btn_Search.ActiveLineColor = System.Drawing.Color.White
        Me.btn_Search.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Search.BackgroundImage = CType(resources.GetObject("btn_Search.BackgroundImage"), System.Drawing.Image)
        Me.btn_Search.ButtonText = "Search"
        Me.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Search.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.Color.Black
        Me.btn_Search.IdleBorderThickness = 1
        Me.btn_Search.IdleCornerRadius = 20
        Me.btn_Search.IdleFillColor = System.Drawing.Color.White
        Me.btn_Search.IdleForecolor = System.Drawing.Color.Black
        Me.btn_Search.IdleLineColor = System.Drawing.Color.White
        Me.btn_Search.Location = New System.Drawing.Point(894, 611)
        Me.btn_Search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(100, 46)
        Me.btn_Search.TabIndex = 66
        Me.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1140, 671)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.lsv_students)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Balance"
        Me.Text = "Balance"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtbox_lrn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbo_grade As ComboBox
    Friend WithEvents txtbox_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtbalance As TextBox
    Friend WithEvents txttf As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_cancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lsv_students As ListView
    Friend WithEvents btn_Search As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lbldaya As Label
    Friend WithEvents grade As TextBox
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents section As TextBox
    Friend WithEvents Label4 As Label
End Class
