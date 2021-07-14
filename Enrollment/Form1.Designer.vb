<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btn_logout = New FontAwesome.Sharp.IconButton()
        Me.btn_about = New FontAwesome.Sharp.IconButton()
        Me.btn_enroll = New FontAwesome.Sharp.IconButton()
        Me.btn_sched = New FontAwesome.Sharp.IconButton()
        Me.btn_sec = New FontAwesome.Sharp.IconButton()
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
        Me.PanelMenu.Controls.Add(Me.btn_enroll)
        Me.PanelMenu.Controls.Add(Me.btn_sched)
        Me.PanelMenu.Controls.Add(Me.btn_sec)
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
        Me.btn_logout.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.btn_logout.IconColor = System.Drawing.Color.White
        Me.btn_logout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_logout.IconSize = 40
        Me.btn_logout.Location = New System.Drawing.Point(0, 468)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_logout.Rotation = 0R
        Me.btn_logout.Size = New System.Drawing.Size(217, 60)
        Me.btn_logout.TabIndex = 9
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
        Me.btn_about.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_about.ForeColor = System.Drawing.Color.White
        Me.btn_about.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.btn_about.IconColor = System.Drawing.Color.White
        Me.btn_about.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_about.IconSize = 40
        Me.btn_about.Location = New System.Drawing.Point(0, 408)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_about.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_about.Rotation = 0R
        Me.btn_about.Size = New System.Drawing.Size(217, 60)
        Me.btn_about.TabIndex = 8
        Me.btn_about.Text = "About"
        Me.btn_about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_about.UseVisualStyleBackColor = False
        '
        'btn_enroll
        '
        Me.btn_enroll.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_enroll.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_enroll.FlatAppearance.BorderSize = 0
        Me.btn_enroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enroll.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_enroll.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enroll.ForeColor = System.Drawing.Color.White
        Me.btn_enroll.IconChar = FontAwesome.Sharp.IconChar.Registered
        Me.btn_enroll.IconColor = System.Drawing.Color.White
        Me.btn_enroll.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_enroll.IconSize = 40
        Me.btn_enroll.Location = New System.Drawing.Point(0, 348)
        Me.btn_enroll.Name = "btn_enroll"
        Me.btn_enroll.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_enroll.Rotation = 0R
        Me.btn_enroll.Size = New System.Drawing.Size(217, 60)
        Me.btn_enroll.TabIndex = 5
        Me.btn_enroll.Text = "Enrollment"
        Me.btn_enroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_enroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_enroll.UseVisualStyleBackColor = False
        '
        'btn_sched
        '
        Me.btn_sched.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_sched.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_sched.FlatAppearance.BorderSize = 0
        Me.btn_sched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sched.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_sched.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sched.ForeColor = System.Drawing.Color.White
        Me.btn_sched.IconChar = FontAwesome.Sharp.IconChar.CalendarDay
        Me.btn_sched.IconColor = System.Drawing.Color.White
        Me.btn_sched.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_sched.IconSize = 40
        Me.btn_sched.Location = New System.Drawing.Point(0, 288)
        Me.btn_sched.Name = "btn_sched"
        Me.btn_sched.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_sched.Rotation = 0R
        Me.btn_sched.Size = New System.Drawing.Size(217, 60)
        Me.btn_sched.TabIndex = 4
        Me.btn_sched.Text = "Update Students"
        Me.btn_sched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sched.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_sched.UseVisualStyleBackColor = False
        '
        'btn_sec
        '
        Me.btn_sec.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_sec.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_sec.FlatAppearance.BorderSize = 0
        Me.btn_sec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sec.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_sec.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sec.ForeColor = System.Drawing.Color.White
        Me.btn_sec.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btn_sec.IconColor = System.Drawing.Color.White
        Me.btn_sec.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_sec.IconSize = 40
        Me.btn_sec.Location = New System.Drawing.Point(0, 228)
        Me.btn_sec.Name = "btn_sec"
        Me.btn_sec.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_sec.Rotation = 0R
        Me.btn_sec.Size = New System.Drawing.Size(217, 60)
        Me.btn_sec.TabIndex = 3
        Me.btn_sec.Text = "Students"
        Me.btn_sec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_sec.UseVisualStyleBackColor = False
        '
        'btn_dash
        '
        Me.btn_dash.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_dash.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_dash.FlatAppearance.BorderSize = 0
        Me.btn_dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dash.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_dash.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btn_dash.TabIndex = 2
        Me.btn_dash.Text = "Dashboard"
        Me.btn_dash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_dash.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelLogo.Controls.Add(Me.ImageHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(217, 168)
        Me.PanelLogo.TabIndex = 2
        '
        'ImageHome
        '
        Me.ImageHome.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ImageHome.Image = CType(resources.GetObject("ImageHome.Image"), System.Drawing.Image)
        Me.ImageHome.Location = New System.Drawing.Point(6, 5)
        Me.ImageHome.Name = "ImageHome"
        Me.ImageHome.Size = New System.Drawing.Size(207, 157)
        Me.ImageHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageHome.TabIndex = 0
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
        Me.PanelTitleBar.Size = New System.Drawing.Size(1140, 54)
        Me.PanelTitleBar.TabIndex = 1
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.White
        Me.lbl_Title.Location = New System.Drawing.Point(66, 16)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(56, 19)
        Me.lbl_Title.TabIndex = 1
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
        Me.IconCurrentForm.Location = New System.Drawing.Point(16, 5)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Padding = New System.Windows.Forms.Padding(3)
        Me.IconCurrentForm.Size = New System.Drawing.Size(49, 45)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.DodgerBlue
        Me.PanelDesktop.Controls.Add(Me.PictureBox2)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(217, 54)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1140, 609)
        Me.PanelDesktop.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(292, 98)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(568, 400)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1357, 663)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
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
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents btn_dash As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_logout As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_about As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_enroll As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_sched As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_sec As FontAwesome.Sharp.IconButton
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lbl_Title As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents ImageHome As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
