Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Forgot_Password
    Dim str As String = "server=localhost;username=root;password=;database=school db"
    Dim con As New MySqlConnection(str)
    Dim checker = 0
    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim a As New Login
        Me.Hide()
        a.Show()

    End Sub
    Sub user()
        Try
            con.Open()
            Dim logincmd As MySqlCommand
            logincmd = con.CreateCommand
            logincmd.CommandText = "Select * from accdb where Username = '" & username.Text & "'"
            Dim loginreader As MySqlDataReader = logincmd.ExecuteReader
            If (loginreader.Read = True) Then
                txtbox_name.Text = loginreader(1)
                empid.Text = loginreader(0)
                contact.Text = loginreader(11)
                vcode.Focus()
                send.Enabled = True
                send.Visible = True
            ElseIf (loginreader.Read = False) Then
                MsgBox("Username Does Not Exist")
                username.Text = ""
            End If
            con.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username.KeyPress
        If Asc(e.KeyChar) >= 46 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            generate()
            user()
        End If
    End Sub
    Private Sub generate()
        Try
            Dim a As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            Dim b As New Random
            Const c As Integer = 6
            Dim jize() As Char = New Char(c - 1) {}
            Dim charIndex As Integer
            For i As Integer = 0 To c - 1
                charIndex = b.Next(a.Length)
                jize(i) = a(charIndex)
            Next
            Dim password As New String(jize)
            vc.Text = password
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Forgot_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generate()
    End Sub

    Private Sub vcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles vcode.KeyPress
        If Asc(e.KeyChar) >= 46 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            If vcode.Text = vc.Text Then
                pass.Enabled = True
                pass.Focus()
                send.Enabled = False
                send.Visible = False
                checker = 0
            ElseIf vcode.Text IsNot vc.text Then
                MsgBox("Wrong Verification Code")
                checker += 1
                If checker = 5 Then
                    MsgBox("Try Again Later !")
                    Dim a As New Login
                    pass.Text = ""
                    pass1.Text = ""
                    username.Text = ""
                    vcode.Text = ""
                    txtbox_name.Text = ""
                    empid.Text = ""
                    send.Enabled = False
                    send.Visible = False
                    pass1.Enabled = False
                    pass.Enabled = False

                    Me.Hide()
                    a.Show()
                End If
            End If
        End If
    End Sub
    Sub sms()
        Dim result = itexmo(contact.Text, vc.Text, "TR-CKENR569704_8QB49", "rwl1&g4n@f")
        If result = 0 Then
            MsgBox("Message Sent!")
        ElseIf contact.Text = "" Then
            MsgBox("INVALID")

        End If

    End Sub

    Private Sub send_Click(sender As Object, e As EventArgs) Handles send.Click
        sms()
    End Sub
    Sub upacc()
        con.Open()
        Dim cd As MySqlCommand
        cd = con.CreateCommand()
        cd.CommandText = "update accdb set Password=@Password where Employee_ID=@Employee_ID"
        cd.Parameters.AddWithValue("@Employee_ID", empid.Text)
        cd.Parameters.AddWithValue("@Password", pass1.Text)
        cd.ExecuteNonQuery()
        MsgBox("Changed")
        con.Close()
        Dim a As New Login
        pass.Text = ""
        pass1.Text = ""
        username.Text = ""
        vcode.Text = ""
        txtbox_name.Text = ""
        empid.Text = ""
        send.Enabled = False
        send.Visible = False
        pass1.Enabled = False
        pass.Enabled = False
        Me.Hide()
        a.Show()
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        upacc()
    End Sub

    Private Sub pass_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles pass.KeyPress
        If Asc(e.KeyChar) >= 46 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            pass1.Enabled = True
            pass1.Focus()
        End If
    End Sub

    Private Sub pass1_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles pass1.KeyPress
        If Asc(e.KeyChar) >= 46 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            If pass1.Text = pass.Text Then
                upacc()
            Else
                MsgBox("Your Password Does Not Match")
                pass1.Text = ""
                pass1.Focus()

            End If
        End If
    End Sub

End Class