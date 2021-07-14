Imports MySql.Data.MySqlClient
Public Class updatestudents
    Dim str As String = "server=localhost;username=root;password=;database=school db"
    Dim con As New MySqlConnection(str)
    Dim filepath As String
    Dim browseimage As New OpenFileDialog
    Sub gr6info()
        Try

            Dim query As String = " select * from gr6info"
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds, "gr6info")
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Sub gr5info()
        Try

            Dim query As String = " select * from gr5info"
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds, "gr5info")
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Sub gr4info()
        Try

            Dim query As String = " select * from gr4info"
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds, "gr4info")
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Sub gr3info()
        Try

            Dim query As String = " select * from gr3info"
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds, "gr3info")
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Sub gr2info()
        Try

            Dim query As String = " select * from gr2info"
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds, "gr2info")
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Sub gr1info()
        Try

            Dim query As String = " select * from gr1info"
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds, "gr1info")
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Sub students()
        Try

            Dim query As String = " select * from studentsdb"
            Dim adpt As New MySqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds, "studentsdb")
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Sub hanap()
        Dim command As New MySqlCommand("SELECT * FROM `studentsdb` WHERE `LRN` = @LRN", con)
        command.Parameters.Add("@LRN", MySqlDbType.Int64).Value = LRN.Text
        Dim reader As MySqlDataReader
        If (con.State = ConnectionState.Closed) Then
            con.Open()
            reader = command.ExecuteReader()
            If reader.Read() = True Then
                LRN.Text = reader(3)
                lbldaya.Text = reader(15)
                PictureBox2.ImageLocation = lbldaya.Text
                grade.Text = reader(0)
                txt_ln.Text = reader(4)
                txt_fn.Text = reader(5)
                txt_mn.Text = reader(6)
                txt_sf.Text = reader(7)
                pangalan.Text = reader(8)
                gender.Text = reader(9)
                birthday.Text = reader(10)
                txt_bp.Text = reader(11)
                age.Text = reader(12)
                address.Text = reader(13)
                studtype.Text = reader(1)
                txtsec.Text = reader(2)
                father.Text = reader(16)
                foccu.Text = reader(17)
                fcont.Text = reader(18)
                mother.Text = reader(19)
                moccu.Text = reader(20)
                mcont.Text = reader(21)
                guardian.Text = reader(22)
                gadd.Text = reader(23)
                gcont.Text = reader(24)
            ElseIf reader.Read() = False Then
                MsgBox("The LRN you have entered is Incorrect")
                clear()
            End If
        End If

        con.Close()
    End Sub
    Private Sub LRN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LRN.KeyPress
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
    Private Sub btn_import_Click(sender As Object, e As EventArgs) Handles btn_import.Click
        browseimage.Title = "SELECT IMAGES"
        browseimage.Filter = "Images File (*.BMP; *.JPG; *.PNG;*.GIF) | *.BMP; *.JPG; *.PNG;*.GIF"

        If browseimage.ShowDialog() = DialogResult.OK Then
            PictureBox2.ImageLocation = browseimage.FileName.ToString
            lbldaya.Text = browseimage.FileName.ToString
        End If
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If pangalan.Text = "" Then
            MsgBox("Invalid")
        Else
            upstud()
            clear()
        End If



    End Sub
    Private Sub clear()
        LRN.Clear()
        studtype.Clear()
        grade.Clear()
        txtsec.Items.Clear()
        txtsec.Items.Add("A")
        txtsec.Items.Add("B")
        txt_ln.Clear()
        txt_fn.Clear()
        txt_mn.Clear()
        txt_sf.Clear()
        gender.Items.Clear()
        gender.Items.Add("Male")
        gender.Items.Add("Female")
        birthday.Text = ""
        txt_bp.Clear()
        age.Clear()
        address.Clear()
        pangalan.Clear()
        father.Clear()
        foccu.Clear()
        fcont.Clear()
        mother.Clear()
        moccu.Clear()
        mcont.Clear()
        guardian.Clear()
        gcont.Clear()
        gadd.Clear()
        lbldaya.Text = ""
        PictureBox2.ImageLocation = lbldaya.Text
    End Sub
    Sub upstud()
        Try


            Dim cd As MySqlCommand
            con.Open()
            cd = con.CreateCommand()
            cd.CommandText = "update studentsdb set Grade_Level=@Grade_Level, Student_Type=@Student_Type, Section=@Section, Lastname=@Lastname, Firstname=@Firstname,
            Middlename=@Middlename, Suffix=@Suffix,Student_Name=@Student_Name, Gender=@Gender, Birthday=@Birthday,Birthplace=@Birthplace,Age=@Age, Address=@Address,
            Student_Picture=@Student_Picture, Father_Name=@Father_Name, Father_Occupation=@Father_Occupation,Father_Contact=@Father_Contact,
            Mother_Name=@Mother_Name,Mother_Occupation=@Mother_Occupation,Mother_Contact=@Mother_Contact,Guardian=@Guardian,Guardian_Address=@Guardian_Address,Guardian_Contact=@Guardian_Contact where LRN=@LRN"
            cd.Parameters.AddWithValue("@Grade_Level", grade.Text)
            cd.Parameters.AddWithValue("@Student_Type", studtype.Text)
            cd.Parameters.AddWithValue("@Section", txtsec.Text)
            cd.Parameters.AddWithValue("@LRN", LRN.Text)
            cd.Parameters.AddWithValue("@Lastname", txt_ln.Text)
            cd.Parameters.AddWithValue("@Firstname", txt_fn.Text)
            cd.Parameters.AddWithValue("@Middlename", txt_mn.Text)
            cd.Parameters.AddWithValue("@Suffix", txt_sf.Text)
            cd.Parameters.AddWithValue("@Student_Name", pangalan.Text)
            cd.Parameters.AddWithValue("@Gender", gender.Text)
            cd.Parameters.AddWithValue("@Birthday", birthday.Text)
            cd.Parameters.AddWithValue("@Birthplace", txt_bp.Text)
            cd.Parameters.AddWithValue("@Age", age.Text)
            cd.Parameters.AddWithValue("@Address", address.Text)
            cd.Parameters.AddWithValue("@Student_Picture", lbldaya.Text)
            cd.Parameters.AddWithValue("@Father_Name", father.Text)
            cd.Parameters.AddWithValue("@Father_Occupation", foccu.Text)
            cd.Parameters.AddWithValue("@Father_Contact", fcont.Text)
            cd.Parameters.AddWithValue("@Mother_Name", mother.Text)
            cd.Parameters.AddWithValue("Mother_Occupation", moccu.Text)
            cd.Parameters.AddWithValue("@Mother_Contact", mcont.Text)
            cd.Parameters.AddWithValue("@Guardian", guardian.Text)
            cd.Parameters.AddWithValue("@Guardian_Address", gadd.Text)
            cd.Parameters.AddWithValue("@Guardian_Contact", gcont.Text)
            cd.ExecuteNonQuery()
            MsgBox("Update Complete !")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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
            gender.Focus()
            pangalan.Clear()
            pangalan.Text = txt_ln.Text + "," & " " + txt_fn.Text + "," & " " + txt_mn.Text + " " + txt_sf.Text
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        clear()
    End Sub

    Private Sub birthday_ValueChanged(sender As Object, e As EventArgs) Handles birthday.ValueChanged
        Dim borrow As Int16 = birthday.Value.Year
        Dim DateNow As Int16 = Today.Year
        age.Text = DateNow - borrow
    End Sub

    Private Sub father_KeyPress(sender As Object, e As KeyPressEventArgs) Handles father.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            foccu.Focus()
        End If
    End Sub

    Private Sub foccu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles foccu.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            fcont.Focus()
        End If
    End Sub

    Private Sub mother_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mother.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            moccu.Focus()
        End If
    End Sub

    Private Sub moccu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles moccu.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            mcont.Focus()
        End If
    End Sub

    Private Sub guardian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles guardian.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            gcont.Focus()
        End If
    End Sub

    Private Sub fcont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fcont.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            e.Handled = False
        Else
            e.Handled = True

        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then

            If fcont.TextLength = 11 Then
                e.Handled = True
                mother.Focus()
            ElseIf fcont.TextLength <= 10 Then
                e.Handled = False
                MsgBox("Invalid Number #")
                fcont.Text = ""
                fcont.Focus()
            End If
        End If
    End Sub

    Private Sub mcont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mcont.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            e.Handled = False
        Else
            e.Handled = True

        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then

            If fcont.TextLength = 11 Then
                e.Handled = True
                guardian.Focus()
            ElseIf fcont.TextLength <= 10 Then
                e.Handled = False
                MsgBox("Invalid Number #")
                fcont.Text = ""
                fcont.Focus()
            End If
        End If
    End Sub
End Class