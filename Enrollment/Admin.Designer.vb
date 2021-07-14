<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btn_about = New FontAwesome.Sharp.IconButton()
        Me.btn_archives = New FontAwesome.Sharp.IconButton()
        Me.btn_sec = New FontAwesome.Sharp.IconButton()
        Me.btn_update = New FontAwesome.Sharp.IconButton()
        Me.btn_log = New FontAwesome.Sharp.IconButton()
        Me.btn_reg = New FontAwesome.Sharp.IconButton()
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
        Me.PanelMenu.Controls.Add(Me.IconButton1)
        Me.PanelMenu.Controls.Add(Me.btn_about)
        Me.PanelMenu.Controls.Add(Me.btn_archives)
        Me.PanelMenu.Controls.Add(Me.btn_sec)
        Me.PanelMenu.Controls.Add(Me.btn_update)
        Me.PanelMenu.Controls.Add(Me.btn_log)
        Me.PanelMenu.Controls.Add(Me.btn_reg)
        Me.PanelMenu.Controls.Add(Me.btn_dash)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(217, 663)
        Me.PanelMenu.TabIndex = 0
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.Location = New System.Drawing.Point(0, 583)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(217, 60)
        Me.IconButton1.TabIndex = 19
        Me.IconButton1.Text = "Log-out"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
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
        Me.btn_about.Location = New System.Drawing.Point(0, 523)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_about.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_about.Rotation = 0R
        Me.btn_about.Size = New System.Drawing.Size(217, 60)
        Me.btn_about.TabIndex = 18
        Me.btn_about.Text = "About"
        Me.btn_about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_about.UseVisualStyleBackColor = False
        '
        'btn_archives
        '
        Me.btn_archives.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_archives.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_archives.FlatAppearance.BorderSize = 0
        Me.btn_archives.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_archives.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_archives.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_archives.ForeColor = System.Drawing.Color.White
        Me.btn_archives.IconChar = FontAwesome.Sharp.IconChar.UserTimes
        Me.btn_archives.IconColor = System.Drawing.Color.White
        Me.btn_archives.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_archives.IconSize = 40
        Me.btn_archives.Location = New System.Drawing.Point(0, 463)
        Me.btn_archives.Name = "btn_archives"
        Me.btn_archives.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_archives.Rotation = 0R
        Me.btn_archives.Size = New System.Drawing.Size(217, 60)
        Me.btn_archives.TabIndex = 17
        Me.btn_archives.Text = "Archives"
        Me.btn_archives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_archives.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_archives.UseVisualStyleBackColor = False
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
        Me.btn_sec.Location = New System.Drawing.Point(0, 403)
        Me.btn_sec.Name = "btn_sec"
        Me.btn_sec.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_sec.Rotation = 0R
        Me.btn_sec.Size = New System.Drawing.Size(217, 60)
        Me.btn_sec.TabIndex = 14
        Me.btn_sec.Text = "Accounts"
        Me.btn_sec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_sec.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_update.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.btn_update.IconColor = System.Drawing.Color.White
        Me.btn_update.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_update.IconSize = 40
        Me.btn_update.Location = New System.Drawing.Point(0, 343)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_update.Rotation = 0R
        Me.btn_update.Size = New System.Drawing.Size(217, 60)
        Me.btn_update.TabIndex = 8
        Me.btn_update.Text = "Update/Delete Account"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_log
        '
        Me.btn_log.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_log.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_log.FlatAppearance.BorderSize = 0
        Me.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_log.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_log.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_log.ForeColor = System.Drawing.Color.White
        Me.btn_log.IconChar = FontAwesome.Sharp.IconChar.History
        Me.btn_log.IconColor = System.Drawing.Color.White
        Me.btn_log.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_log.IconSize = 40
        Me.btn_log.Location = New System.Drawing.Point(0, 283)
        Me.btn_log.Name = "btn_log"
        Me.btn_log.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_log.Rotation = 0R
        Me.btn_log.Size = New System.Drawing.Size(217, 60)
        Me.btn_log.TabIndex = 6
        Me.btn_log.Text = "Activity Log"
        Me.btn_log.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_log.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_log.UseVisualStyleBackColor = False
        '
        'btn_reg
        '
        Me.btn_reg.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_reg.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_reg.FlatAppearance.BorderSize = 0
        Me.btn_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reg.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_reg.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reg.ForeColor = System.Drawing.Color.White
        Me.btn_reg.IconChar = FontAwesome.Sharp.IconChar.AddressCard
        Me.btn_reg.IconColor = System.Drawing.Color.White
        Me.btn_reg.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_reg.IconSize = 40
        Me.btn_reg.Location = New System.Drawing.Point(0, 228)
        Me.btn_reg.Name = "btn_reg"
        Me.btn_reg.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_reg.Rotation = 0R
        Me.btn_reg.Size = New System.Drawing.Size(217, 55)
        Me.btn_reg.TabIndex = 5
        Me.btn_reg.Text = "Registration"
        Me.btn_reg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_reg.UseVisualStyleBackColor = False
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
        Me.btn_dash.TabIndex = 3
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
        Me.PanelLogo.TabIndex = 1
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
        Me.PanelTitleBar.TabIndex = 3
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
        Me.PanelDesktop.TabIndex = 4
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
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1357, 663)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
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
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents ImageHome As PictureBox
    Friend WithEvents btn_dash As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_update As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_log As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_reg As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents lbl_Title As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_about As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_archives As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_sec As FontAwesome.Sharp.IconButton
End Class
