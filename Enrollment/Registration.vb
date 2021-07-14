Imports MySql.Data.MySqlClient
Public Class Registration
    Dim str As String = "server=localhost;username=root;password=;database=school db"
    Dim con As New MySqlConnection(str)
    Dim filepath As String
    Dim browseimage As New OpenFileDialog
    Sub clear()
        txt_ln.Text = ""
        txt_fn.Text = ""
        txt_mn.Text = ""
        txt_sf.Text = ""
        txt_add.Text = ""
        cmbo_gender.Items.Clear()
        cmbo_gender.Items.Add("Male")
        cmbo_gender.Items.Add("Female")
        position.Items.Clear()
        position.Items.Add("Registrar")
        position.Items.Add("Cashier")
        age.Text = ""
        txtbox_user.Text = ""
        password.Text = ""
        contact.Text = ""
        em_id.Text = ""
        daya.Text = ""
        pangalan.Text = ""
        birthday.Text = Date.Now
        daya.Text = ""
        PictureBox1.ImageLocation = daya.Text
    End Sub
    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbo_gender.Items.Add("Male")
        cmbo_gender.Items.Add("Female")
        position.Items.Add("Registrar")
        position.Items.Add("Cashier")
    End Sub

    Private Sub link_create_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Login.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub txtbox_fname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fn.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
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
            txt_mn.Focus()
            pangalan.Clear()
            pangalan.Text = txt_ln.Text + "," & " " + txt_fn.Text + "," & " " + txt_mn.Text + " " + txt_sf.Text
        End If
    End Sub

    Private Sub txt_lname_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            cmbo_gender.Focus()
        End If
    End Sub

    Private Sub cmbo_gender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbo_gender.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            position.Focus()
        End If
    End Sub

    Private Sub txtbox_phone_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then
            txtbox_user.Focus()
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtbox_user_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) >= 35 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            If txtbox_user.Text = "" Then
                MsgBox("Enter Username First")
            Else
                password.Focus()
            End If
        End If
    End Sub

    Private Sub txtbox_pass_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            btn_register.Focus()
        End If
    End Sub

    Private Sub btn_import_Click(sender As Object, e As EventArgs) Handles btn_import.Click
        browseimage.Title = "SELECT IMAGES"
        browseimage.Filter = "Images File (*.BMP; *.JPG; *.PNG;*.GIF) | *.BMP; *.JPG; *.PNG;*.GIF"

        If browseimage.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = browseimage.FileName.ToString
            daya.Text = browseimage.FileName.ToString
            generate()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles birthday.ValueChanged
        Dim borrow As Int16 = birthday.Value.Year
        Dim DateNow As Int16 = Today.Year

        Try
            age.Text = DateNow - borrow

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_ln_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ln.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
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
            txt_fn.Focus()
            pangalan.Clear()
            pangalan.Text = txt_ln.Text + "," & " " + txt_fn.Text + "," & " " + txt_mn.Text + " " + txt_sf.Text
        End If
    End Sub

    Private Sub txt_mn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mn.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
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
            txt_sf.Focus()
            pangalan.Clear()
            pangalan.Text = txt_ln.Text + "," & " " + txt_fn.Text + "," & " " + txt_mn.Text + " " + txt_sf.Text
        End If
    End Sub

    Private Sub txt_sf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sf.KeyPress
        If Asc(e.KeyChar) >= 35 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
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
            txt_add.Focus()
            pangalan.Clear()
            pangalan.Text = txt_ln.Text + "," & " " + txt_fn.Text + "," & " " + txt_mn.Text + " " + txt_sf.Text
        End If
    End Sub

    Private Sub txt_add_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_add.KeyPress
        If Asc(e.KeyChar) >= 30 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
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
            cmbo_gender.Focus()
        End If
    End Sub
    Sub hanap()
        con.Open()
        Dim logincmd As MySqlCommand
        logincmd = con.CreateCommand
        logincmd.CommandText = "Select * from accdb where Username = '" & txtbox_user.Text & "'"
        Dim loginreader As MySqlDataReader = logincmd.ExecuteReader
        If (loginreader.Read = True) Then
            MsgBox("Username Already Taken !")
            txtbox_user.Text = ""
        Else
            password.Focus()
        End If
        con.Close()
    End Sub
    Private Sub txtbox_user_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtbox_user.KeyPress
        If Asc(e.KeyChar) >= 30 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
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
            password.Focus()
            hanap()

        End If
    End Sub

    Private Sub contact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contact.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            e.Handled = False
        Else
            e.Handled = True

        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then

            If contact.TextLength = 11 Then
                e.Handled = True
                txtbox_user.Focus()
            ElseIf contact.TextLength <= 10 Then
                e.Handled = False
                MsgBox("Invalid Number #")
                contact.Text = ""
                contact.Focus()
            End If
        End If
    End Sub
    Private Sub generate()
        Try
            Dim a As String = "0123456789"
            Dim b As New Random
            Const c As Integer = 12
            Dim jize() As Char = New Char(c - 1) {}
            Dim charIndex As Integer

            For i As Integer = 0 To c - 1
                charIndex = b.Next(a.Length)
                jize(i) = a(charIndex)
            Next

            Dim password As New String(jize)
            em_id.Text = password
        Catch ex As Exception

        End Try
    End Sub
    Private Sub password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password.KeyPress
        If Asc(e.KeyChar) >= 30 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Then
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
            em_id.Focus()
            e.Handled = True
        End If
    End Sub
    Sub masterdb()
        Dim cd As MySqlCommand
        Try
            con.Open()
            cd = con.CreateCommand
            cd.CommandText = "insert into accdb(Employee_ID,Name,Lastname,Firstname,Middlename,Suffix,Address,Gender,Birthday,Age,Position,Contact_Number,Username,Password,Picture) 
            values(@Employee_ID,@Name,@Lastname,@Firstname,@Middlename,@Suffix,@Address,@Gender,@Birthday,@Age,@Position,@Contact_Number,@Username,@Password,@Picture);"
            cd.Parameters.AddWithValue("@Employee_ID", em_id.Text)
            cd.Parameters.AddWithValue("@Name", pangalan.Text)
            cd.Parameters.AddWithValue("@Lastname", txt_ln.Text)
            cd.Parameters.AddWithValue("@Firstname", txt_fn.Text)
            cd.Parameters.AddWithValue("@Middlename", txt_mn.Text)
            cd.Parameters.AddWithValue("@Suffix", txt_sf.Text)
            cd.Parameters.AddWithValue("@Address", txt_add.Text)
            cd.Parameters.AddWithValue("@Gender", cmbo_gender.Text)
            cd.Parameters.AddWithValue("@Birthday", birthday.Text)
            cd.Parameters.AddWithValue("@Age", age.Text)
            cd.Parameters.AddWithValue("@Position", position.Text)
            cd.Parameters.AddWithValue("@Contact_Number", contact.Text)
            cd.Parameters.AddWithValue("@Username", txtbox_user.Text)
            cd.Parameters.AddWithValue("@Password", password.Text)
            cd.Parameters.AddWithValue("@Picture", daya.Text)
            cd.ExecuteNonQuery()
            MsgBox("Added Account")
            cd.Parameters.Clear()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        empty()

    End Sub
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        clear()
    End Sub
    Sub empty()
        If txt_ln.Text = "" Then
            MsgBox("FILL UP LASTNAME !")
            txt_ln.Focus()
        ElseIf txt_fn.Text = "" Then
            MsgBox("FILL UP FIRSTNAME!")
            txt_fn.Focus()
        ElseIf txt_mn.Text = "" Then
            MsgBox("FILL UP MIDDLENAME!")
            txt_mn.Focus()
        ElseIf txt_add.Text = "" Then
            MsgBox("FILL UP ADDRESS!")
            txt_add.Focus()
        ElseIf cmbo_gender.Text = "" Then
            MsgBox("FILL UP GENDER!")
            cmbo_gender.Focus()
        ElseIf age.Text = "" Then
            MsgBox("FILL UP BIRTHDAY!")
        ElseIf position.Text = "" Then
            MsgBox("FILL UP POSITION!")
            position.Focus()
        ElseIf contact.Text = "" Then
            MsgBox("FILL UP CONTACT!")
            contact.Focus()
        ElseIf txtbox_user.Text = "" Then
            MsgBox("FILL UP USERNAME!")
            txtbox_user.Focus()
        ElseIf password.Text = "" Then
            MsgBox("FILL UP PASSWORD!")
        ElseIf daya.Text = "" Then
            msGbox("UPLOAD PICTURE!")
            btn_import.Focus()
        ElseIf em_id.Text = "" Then
        Else
            masterdb()
            clear()
        End If
    End Sub
End Class