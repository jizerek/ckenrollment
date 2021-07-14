Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form1
    Dim str As String = "server=localhost;username=root;password=;database=school db"
    Dim con As New MySqlConnection(str)
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentForm As Form


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(8, 60)
        PanelMenu.Controls.Add(leftBorderBtn)

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub ActivateButton(SenderBtn As Object, customColor As Color)
        If SenderBtn IsNot Nothing Then
            DisableButton()

            currentBtn = CType(SenderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(100, 149, 237)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(100, 149, 237)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenForm(OpenForm As Form)
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If
        currentForm = OpenForm
        OpenForm.TopLevel = False
        OpenForm.FormBorderStyle = FormBorderStyle.None
        OpenForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(OpenForm)
        PanelDesktop.Tag = OpenForm
        OpenForm.BringToFront()
        OpenForm.Show()
        lbl_Title.Text = OpenForm.Text
    End Sub

    Private Sub btn_dash_Click(sender As Object, e As EventArgs) Handles btn_dash.Click
        ActivateButton(sender, Color.LightBlue)
        Dim dash As New DashboardRegistrar
        OpenForm(New DashboardRegistrar)
    End Sub

    Private Sub btn_sec_Click(sender As Object, e As EventArgs) Handles btn_sec.Click
        ActivateButton(sender, Color.LightBlue)
        OpenForm(New Section)
    End Sub

    Private Sub btn_sched_Click(sender As Object, e As EventArgs) Handles btn_sched.Click
        ActivateButton(sender, Color.LightBlue)
        OpenForm(New updatestudents)
    End Sub

    Private Sub btn_enroll_Click(sender As Object, e As EventArgs) Handles btn_enroll.Click
        ActivateButton(sender, Color.LightBlue)
        OpenForm(New Enrollment)
    End Sub

    Private Sub btn_pay_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, Color.LightBlue)
        OpenForm(New Payment)
    End Sub

    Private Sub btn_bal_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, Color.LightBlue)
        OpenForm(New Balance)
    End Sub

    Private Sub btn_about_Click(sender As Object, e As EventArgs) Handles btn_about.Click
        ActivateButton(sender, Color.LightBlue)
        OpenForm(New About)
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        ActivateButton(sender, Color.Red)

        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to log-out?", "Log-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Dim l As New Login
            l.txtbox_user.Focus()
            l.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.White
        lbl_Title.Text = "Home"
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub ImageHome_Click(sender As Object, e As EventArgs) Handles ImageHome.Click
        If currentBtn IsNot Nothing Then
            currentForm.Close()
        End If
        Reset()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs)
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Minimized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
