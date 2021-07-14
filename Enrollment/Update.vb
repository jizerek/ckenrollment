Imports MySql.Data.MySqlClient
Public Class Update
    Dim str As String = "server=localhost;username=root;password=;database=school db"
    Dim con As New MySqlConnection(str)
    Dim filepath As String
    Dim browseimage As New OpenFileDialog
    Sub hanap()
        Dim command As New MySqlCommand("SELECT * FROM `accdb` WHERE `Employee_ID` = @Employee_ID", con)
        command.Parameters.Add("@Employee_ID", MySqlDbType.Int64).Value = em_id.Text
        Dim reader As MySqlDataReader
        If (con.State = ConnectionState.Closed) Then
            con.Open()
            Try
                reader = command.ExecuteReader()

                If reader.Read() = True Then
                    txt_ln.Text = reader(2)
                    txt_fn.Text = reader(3)
                    txt_mn.Text = reader(4)
                    txt_sf.Text = reader(5)
                    txt_add.Text = reader(6)
                    gender.Text = reader(7)
                    PictureBox1.ImageLocation = reader(14)
                    birthday.Text = reader(8)
                    age.Text = reader(9)
                    position.Text = reader(10)
                    contact.Text = reader(11)
                    txtbox_user.Text = reader(12)
                    password.Text = reader(13)
                    daya.Text = reader(14)
                    pangalan.Text = reader(1)
                Else
                    MsgBox("Employee ID Does Not Exist")
                End If
            Catch ex As Exception
            End Try
        End If
        con.Close()
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

    Private Sub em_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles em_id.KeyPress
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
    End Sub
    Sub clear()
        txt_ln.Text = ""
        txt_fn.Text = ""
        txt_mn.Text = ""
        txt_sf.Text = ""
        txt_add.Text = ""
        gender.Items.Clear()
        gender.Items.Add("Male")
        gender.Items.Add("Female")
        position.Items.Clear()
        position.Items.Add("Registrar")
        position.Items.Add("Cashier")
        age.Text = ""
        txtbox_user.Text = ""
        password.Text = ""
        contact.Text = ""
        em_id.Text = ""
        daya.Text = ""
        PictureBox1.ImageLocation = daya.Text
        pangalan.Text = ""
    End Sub
    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gender.Items.Add("Male")
        gender.Items.Add("Female")
        position.Items.Add("Registrar")
        position.Items.Add("Cashier")
        Timer1.Enabled = True
        students()
    End Sub

    Private Sub btn_import_Click(sender As Object, e As EventArgs) Handles btn_import.Click
        browseimage.Title = "SELECT IMAGES"
        browseimage.Filter = "Images File (*.BMP; *.JPG; *.PNG;*.GIF) | *.BMP; *.JPG; *.PNG;*.GIF"
        If browseimage.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = browseimage.FileName.ToString
            daya.Text = browseimage.FileName.ToString
        End If
    End Sub

    Private Sub txt_fn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fn.KeyPress
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
            gender.Focus()
        End If
    End Sub

    Private Sub birthday_ValueChanged(sender As Object, e As EventArgs) Handles birthday.ValueChanged
        Dim borrow As Int16 = birthday.Value.Year
        Dim DateNow As Int16 = Today.Year

        Try
            age.Text = DateNow - borrow
        Catch ex As Exception

        End Try
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

    Private Sub txtbox_user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_user.KeyPress
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
        End If
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
        ElseIf gender.Text = "" Then
            MsgBox("FILL UP GENDER!")
            gender.Focus()
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
            MsgBox("UPLOAD PICTURE!")
            btn_import.Focus()
        ElseIf em_id.Text = "" Then
        Else
            accup()
            clear()

        End If
    End Sub
    Sub students()
        Try

            Dim query As String = " select * from accdb"
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds, "accdb")
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Sub accup()
        Try
            Dim cd As MySqlCommand
            con.Open()
            cd = con.CreateCommand()
            cd.CommandText = "update accdb set Name=@Name,Lastname=@Lastname,Firstname=@Firstname,Middlename=@Middlename
        ,Suffix=@Suffix,Address=@Address,Gender=@Gender,Birthday=@Birthday,Age=@Age,Position=@Position,Contact_Number=@Contact_Number,Username=@Username,Password=@Password,Picture=@Picture where Employee_ID=@Employee_ID "
            cd.Parameters.AddWithValue("@Name", pangalan.Text)
            cd.Parameters.AddWithValue("@Lastname", txt_ln.Text)
            cd.Parameters.AddWithValue("@Firstname", txt_fn.Text)
            cd.Parameters.AddWithValue("@Middlename", txt_mn.Text)
            cd.Parameters.AddWithValue("@Suffix", txt_sf.Text)
            cd.Parameters.AddWithValue("@Address", txt_add.Text)
            cd.Parameters.AddWithValue("@Gender", gender.Text)
            cd.Parameters.AddWithValue("@Birthday", birthday.Text)
            cd.Parameters.AddWithValue("@Age", age.Text)
            cd.Parameters.AddWithValue("@Position", position.Text)
            cd.Parameters.AddWithValue("@Contact_Number", contact.Text)
            cd.Parameters.AddWithValue("@Username", txtbox_user.Text)
            cd.Parameters.AddWithValue("@Password", password.Text)
            cd.Parameters.AddWithValue("@Picture", daya.Text)
            cd.Parameters.AddWithValue("@Employee_ID", em_id.Text)
            cd.ExecuteNonQuery()
            MsgBox("Acc Update")
            con.Close()
            students()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        empty()


    End Sub
    Sub delete()
        Dim cd As MySqlCommand
        Try
            con.Open()
            cd = con.CreateCommand
            cd.CommandText = "delete from accdb where Employee_ID=@Employee_ID;"
            cd.Parameters.AddWithValue("@Employee_ID", em_id.Text)
            cd.ExecuteNonQuery()
            MsgBox("Deleted !")
        Catch ex As Exception
        End Try
        con.Close()
        clear()
    End Sub
    Sub archives()
        Dim cd As MySqlCommand
        Try
            con.Open()
            cd = con.CreateCommand
            cd.CommandText = "insert into archives(ID,Name,Date_Deleted,Time_Deleted,Contact,Gender,Position) values(@ID,@Name,@Date_Deleted,@Time_Deleted,@Contact,@Gender,@Position);"
            cd.Parameters.AddWithValue("@ID", em_id.Text)
            cd.Parameters.AddWithValue("@Name", pangalan.Text)
            cd.Parameters.AddWithValue("@Date_Deleted", etad.Text)
            cd.Parameters.AddWithValue("@Time_Deleted", time.Text)
            cd.Parameters.AddWithValue("@Contact", contact.Text)
            cd.Parameters.AddWithValue("@Gender", gender.Text)
            cd.Parameters.AddWithValue("@Position", position.Text)
            cd.ExecuteNonQuery()
            MsgBox("Archived!")
            cd.Parameters.Clear()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
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
        ElseIf gender.Text = "" Then
            MsgBox("FILL UP GENDER!")
            gender.Focus()
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
            MsgBox("UPLOAD PICTURE!")
            btn_import.Focus()
        ElseIf em_id.Text = "" Then

        Else
            archives()
            delete()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        etad.Text = Date.Now.ToString("MM-dd-yyyy ")
        time.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        clear()
    End Sub

End Class