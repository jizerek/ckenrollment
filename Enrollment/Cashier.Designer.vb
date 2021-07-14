<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cashier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cashier))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btn_logout = New FontAwesome.Sharp.IconButton()
        Me.btn_about = New FontAwesome.Sharp.IconButton()
        Me.btn_bal = New FontAwesome.Sharp.IconButton()
        Me.btn_pay = New FontAwesome.Sharp.IconButton()
        Me.btn_dash = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.ImageHome = New System.Windows.Forms.PictureBox()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.ImageHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PanelMenu.Controls.Add(Me.btn_logout)
        Me.PanelMenu.Controls.Add(Me.btn_about)
        Me.PanelMenu.Controls.Add(Me.btn_bal)
        Me.PanelMenu.Controls.Add(Me.btn_pay)
        Me.PanelMenu.Controls.Add(Me.btn_dash)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(217, 663)
        Me.PanelMenu.TabIndex = 0
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_logout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.btn_logout.IconColor = System.Drawing.Color.White
        Me.btn_logout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_logout.IconSize = 40
        Me.btn_logout.Location = New System.Drawing.Point(0, 408)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_logout.Rotation = 0R
        Me.btn_logout.Size = New System.Drawing.Size(217, 60)
        Me.btn_logout.TabIndex = 11
        Me.btn_logout.Text = "Log-out"
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_about
        '
        Me.btn_about.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_about.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_about.FlatAppearance.BorderSize = 0
        Me.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_about.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_about.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_about.ForeColor = System.Drawing.Color.White
        Me.btn_about.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.btn_about.IconColor = System.Drawing.Color.White
        Me.btn_about.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_about.IconSize = 40
        Me.btn_about.Location = New System.Drawing.Point(0, 348)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_about.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_about.Rotation = 0R
        Me.btn_about.Size = New System.Drawing.Size(217, 60)
        Me.btn_about.TabIndex = 10
        Me.btn_about.Text = "About"
        Me.btn_about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_about.UseVisualStyleBackColor = False
        '
        'btn_bal
        '
        Me.btn_bal.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_bal.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_bal.FlatAppearance.BorderSize = 0
        Me.btn_bal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bal.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_bal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bal.ForeColor = System.Drawing.Color.White
        Me.btn_bal.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt
        Me.btn_bal.IconColor = System.Drawing.Color.White
        Me.btn_bal.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_bal.IconSize = 40
        Me.btn_bal.Location = New System.Drawing.Point(0, 288)
        Me.btn_bal.Name = "btn_bal"
        Me.btn_bal.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_bal.Rotation = 0R
        Me.btn_bal.Size = New System.Drawing.Size(217, 60)
        Me.btn_bal.TabIndex = 9
        Me.btn_bal.Text = "Balance"
        Me.btn_bal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_bal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_bal.UseVisualStyleBackColor = False
        '
        'btn_pay
        '
        Me.btn_pay.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_pay.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_pay.FlatAppearance.BorderSize = 0
        Me.btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pay.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_pay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pay.ForeColor = System.Drawing.Color.White
        Me.btn_pay.IconChar = FontAwesome.Sharp.IconChar.CashRegister
        Me.btn_pay.IconColor = System.Drawing.Color.White
        Me.btn_pay.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_pay.IconSize = 40
        Me.btn_pay.Location = New System.Drawing.Point(0, 228)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_pay.Rotation = 0R
        Me.btn_pay.Size = New System.Drawing.Size(217, 60)
        Me.btn_pay.TabIndex = 8
        Me.btn_pay.Text = "Payment"
        Me.btn_pay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_pay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_pay.UseVisualStyleBackColor = False
        '
        'btn_dash
        '
        Me.btn_dash.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_dash.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_dash.FlatAppearance.BorderSize = 0
        Me.btn_dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dash.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_dash.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dash.ForeColor = System.Drawing.Color.White
        Me.btn_dash.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.btn_dash.IconColor = System.Drawing.Color.White
        Me.btn_dash.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_dash.IconSize = 40
        Me.btn_dash.Location = New System.Drawing.Point(0, 168)
        Me.btn_dash.Name = "btn_dash"
        Me.btn_dash.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_dash.Rotation = 0R
        Me.btn_dash.Size = New System.Drawing.Size(217, 60)
        Me.btn_dash.TabIndex = 5
        Me.btn_dash.Text = "Dashboard"
        Me.btn_dash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_dash.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.ImageHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(217, 168)
        Me.PanelLogo.TabIndex = 4
        '
        'ImageHome
        '
        Me.ImageHome.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ImageHome.Image = CType(resources.GetObject("ImageHome.Image"), System.Drawing.Image)
        Me.ImageHome.Location = New System.Drawing.Point(5, 6)
        Me.ImageHome.Name = "ImageHome"
        Me.ImageHome.Size = New System.Drawing.Size(207, 157)
        Me.ImageHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageHome.TabIndex = 1
        Me.ImageHome.TabStop = False
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PanelTitleBar.Controls.Add(Me.lbl_Title)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(217, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1140, 50)
        Me.PanelTitleBar.TabIndex = 4
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.White
        Me.lbl_Title.Location = New System.Drawing.Point(60, 14)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(56, 19)
        Me.lbl_Title.TabIndex = 3
        Me.lbl_Title.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.CornflowerBlue
        Me.IconCurrentForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.White
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 45
        Me.IconCurrentForm.Location = New System.Drawing.Point(10, 3)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Padding = New System.Windows.Forms.Padding(3)
        Me.IconCurrentForm.Size = New System.Drawing.Size(49, 45)
        Me.IconCurrentForm.TabIndex = 2
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.DodgerBlue
        Me.PanelDesktop.Controls.Add(Me.PictureBox2)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(217, 50)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1140, 613)
        Me.PanelDesktop.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(286, 106)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(568, 400)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1357, 663)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cashier"
        Me.Text = "Cashier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.ImageHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents lbl_Title As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_dash As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents ImageHome As PictureBox
    Friend WithEvents btn_bal As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_pay As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_logout As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_about As FontAwesome.Sharp.IconButton
End Class
