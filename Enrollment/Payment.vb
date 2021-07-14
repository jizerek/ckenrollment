Imports MySql.Data.MySqlClient
Public Class Payment
    Dim str As String = "server=localhost;username=root;password=;database=school db"
    Dim con As New MySqlConnection(str)
    Dim filepath As String
    Dim browseimage As New OpenFileDialog
    Sub students()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim da As New MySqlDataAdapter("Select * from studentsdb", con)
        Dim dt As New DataTable
        da.Fill(dt)
        con.Close()
    End Sub
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        students()
    End Sub
    Sub hanap()
        Dim command As New MySqlCommand("SELECT * FROM `studentsdb` WHERE `LRN` = @LRN", con)
        command.Parameters.Add("@LRN", MySqlDbType.Int64).Value = txtbox_lrn.Text
        Dim reader As MySqlDataReader
        If (con.State = ConnectionState.Closed) Then
            con.Open()
            reader = command.ExecuteReader()
            If reader.Read() = True Then
                section.Text = reader(2)
                txtbox_lrn.Text = reader(3)
                picture.Text = reader(15)
                PictureBox1.ImageLocation = picture.Text
                grade.Text = reader(0)
                txtbox_name.Text = reader(8)
                txttotal.Text = reader(25)
                balance.Text = reader(26)
            ElseIf reader.Read() = False Then
                MsgBox("The LRN you have entered is Incorrect")
            End If
        End If

        con.Close()
    End Sub
    Private Sub txtbox_lrn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_lrn.KeyPress
        Try


            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
            End If

            If Asc(e.KeyChar) = 13 Then
                e.Handled = True
                hanap()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtbox_cash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ammount.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If

        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Dim a, b As Double
            a = ammount.Text
            b = balance.Text
            balancetago.Text = b - a
            If a > b Then
                MsgBox("Invalid")
                ammount.Text = 0
                ammount.Focus()

            End If
        End If
    End Sub
    Private Sub cash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cash.KeyPress
        Try


            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
            End If

            If Asc(e.KeyChar) = 13 Then
                e.Handled = True
                Dim b, c As Double
                b = CDbl(ammount.Text)
                c = CDbl(cash.Text)

                If c >= b Then
                    change.Text = c - b
                Else
                    MsgBox("Invalid Money")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub upstud()
        con.Open()
        Dim cd As MySqlCommand
        cd = con.CreateCommand()
        cd.CommandText = "update studentsdb set Enrolled=@Enrolled, TuitionFee=@TuitionFee, Balance=@Balance where LRN=@LRN"
        cd.Parameters.AddWithValue("@LRN", txtbox_lrn.Text)
        cd.Parameters.AddWithValue("@Enrolled", enrolled.Text)
        cd.Parameters.AddWithValue("@TuitionFee", txttotal.Text)
        cd.Parameters.AddWithValue("@Balance", balancetago.Text)
        cd.ExecuteNonQuery()
        MsgBox("Paid")
        con.Close()
    End Sub
    Sub clear()
        txtbox_lrn.Clear()
        grade.Clear()
        txtbox_name.Clear()
        balance.Text = 0
        balancetago.Text = 0
        section.Clear()
        txttotal.Text = 0
        cash.Text = 0
        ammount.Text = 0
        change.Text = 0
        picture.Text = ""
        PictureBox1.ImageLocation = picture.Text
    End Sub
    Private Sub pay_Click(sender As Object, e As EventArgs) Handles pay.Click
        If cash.Text = 0 Then
            MsgBox("Pay First")
        Else
            upstud()
            clear()
        End If

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        clear()
    End Sub
End Class