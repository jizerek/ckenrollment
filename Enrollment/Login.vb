Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Login
    Dim str As String = "server=localhost;username=root;password=;database=school db"
    Dim con As New MySqlConnection(str)
    Dim checker = 0
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        txtbox_user.Text = ""
        txtbox_pass.Text = ""
    End Sub
    Sub log()
        Try
            con.Open()
            Dim logincmd As MySqlCommand
            logincmd = con.CreateCommand
            logincmd.CommandText = "Select * from accdb where Username = '" & txtbox_user.Text & "'and Password ='" & txtbox_pass.Text & "'"
            Dim loginreader As MySqlDataReader = logincmd.ExecuteReader
            If (loginreader.Read = True) Then
                If (loginreader.Item("Position") = "Cashier") Then
                    Dim cash As New Cashier
                    cash.ImageHome.ImageLocation = loginreader.Item("Picture")
                    cash.Show()
                    checker = 0
                    con.Close()
                    Me.Hide()
                    act()
                ElseIf (loginreader.Item("Position") = "Registrar") Then
                    act()
                    Dim reg As New Form1
                    reg.ImageHome.ImageLocation = loginreader.Item("Picture")
                    reg.Show()
                    checker = 0
                    con.Close()
                    Me.Hide()
                    act()
                ElseIf (loginreader.Item("Position") = "Admin") Then
                    Dim admin As New Admin

                    admin.ImageHome.ImageLocation = loginreader.Item("Picture")
                    admin.Show()
                    checker = 0
                    con.Close()
                    Me.Hide()
                    act()
                End If
            ElseIf (loginreader.Read = False) Then
                MsgBox("Login failed !" & " " & "Attempts:" & checker.ToString + 1)
                checker += 1
                txtbox_pass.Text = ""
                txtbox_user.Text = ""
                txtbox_user.Focus()
                pangalan.Clear()
                con.Close()
                If checker = 5 Then
                    MsgBox("Too Much Attempt !")
                    Me.Close()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        log()
    End Sub
    Private Sub txtbox_user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_user.KeyPress
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
            txtbox_pass.Focus()
            user()
        End If
    End Sub
    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        Dim a As New Forgot_Password
        Dim b As New Login
        a.Show()
        Me.Hide()
    End Sub
    Sub user()
        Try
            con.Open()
            Dim logincmd As MySqlCommand
            logincmd = con.CreateCommand
            logincmd.CommandText = "Select * from accdb where Username = '" & txtbox_user.Text & "'"
            Dim loginreader As MySqlDataReader = logincmd.ExecuteReader
            If (loginreader.Read = True) Then
                pangalan.Clear()
                position.Clear()
                pangalan.Text = loginreader(1)
                position.Text = loginreader(10)
                '   txtbox_pass.Focus()
            ElseIf (loginreader.Read = False) Then
                '  txtbox_pass.Focus()
            End If
            con.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        d.Text = Date.Now.ToString("MM-dd-yyyy ")
        t.Text = Date.Now.ToString("hh:mm:ss")
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Sub act()
        Dim cd As MySqlCommand
        Try
            con.Open()
            cd = con.CreateCommand
            cd.CommandText = "insert into logs(Name,Username,Position,Time,Date)values(@Name,@Username,@Position,@Time,@Date);"
            cd.Parameters.AddWithValue("@Name", pangalan.Text)
            cd.Parameters.AddWithValue("@Username", txtbox_user.Text)
            cd.Parameters.AddWithValue("@Position", position.Text)
            cd.Parameters.AddWithValue("@Time", t.Text)
            cd.Parameters.AddWithValue("@Date", d.Text)
            cd.ExecuteNonQuery()
            cd.Parameters.Clear()
            con.Close()
            txtbox_user.Text = ""
            txtbox_pass.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtbox_pass_OnValueChanged(sender As Object, e As EventArgs)
        txtbox_pass.Text = txtbox_pass.Text
    End Sub

    Private Sub txtbox_pass_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtbox_pass.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 95 Or Asc(e.KeyChar) = 64 Then

            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then
            log()
        End If
    End Sub

    Private Sub show_Click(sender As Object, e As EventArgs) Handles labas.Click
        If labas.Visible = True Then

            If txtbox_pass.UseSystemPasswordChar = False Then
                txtbox_pass.UseSystemPasswordChar = True
                labas.Visible = False
                tago.Visible = True
            End If
        End If

    End Sub

    Private Sub tago_Click(sender As Object, e As EventArgs) Handles tago.Click
        If tago.Visible = True Then
            If txtbox_pass.UseSystemPasswordChar = True Then
                txtbox_pass.UseSystemPasswordChar = False
                tago.Visible = False
                labas.Visible = True
            End If
        End If

    End Sub

    Private Sub txtbox_user_OnValueChanged(sender As Object, e As EventArgs) Handles txtbox_user.OnValueChanged
        pangalan.Clear()
        position.Clear()
        user()
    End Sub

End Class