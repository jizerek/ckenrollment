Imports MySql.Data.MySqlClient
Public Class Enrollment
    Dim str As String = "server=localhost;username=root;password=;database=school db"
    Dim con As New MySqlConnection(str)
    Dim filepath As String
    Dim browseimage As New OpenFileDialog

    Private Sub fees()
        Dim t, m, l, b, s, o, u, f, total As Double
        t = txttf.Text
        m = txtmf.Text
        l = txtlf.Text
        b = txtbooks.Text
        f = txtotherfees.Text
        total = t + m + l + b + s + o + u + f
        txttotal.Text = total
        balance.Text = total
        Label20.Visible = True
        txttotal.Visible = True
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
            Dim j = 223
            LRN.Text = j + password
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grade.SelectedIndexChanged
        If grade.Text = " " Then
            clear()
        ElseIf grade.Text = 1 Then
            txttf.Text = 23500
            txtmf.Text = 1500
            txtlf.Text = 1500
            txtbooks.Text = 1500
            txtotherfees.Text = 1000
            fees()
            generate()
            txttotal.Visible = True
            '  LRN.Enabled = False
            cmb_student.Text = "New"
        ElseIf grade.Text = 2 Then
            txttf.Text = 25000
            txtmf.Text = 1500
            txtlf.Text = 1500
            txtbooks.Text = 1500
            txtotherfees.Text = 1000
            txttotal.Text = 0
            txttotal.Visible = True
            LRN.Enabled = True
            LRN.Clear()
            cmb_student.Items.Clear()
            cmb_student.Items.Add("Old")
            cmb_student.Items.Add("New")
            fees()
        ElseIf grade.Text = 3 Then
            txttf.Text = 26000
            txtmf.Text = 2000
            txtlf.Text = 2000
            txtbooks.Text = 2300
            txtotherfees.Text = 1500
            txttotal.Text = 0
            txttotal.Visible = True
            fees()
            LRN.Enabled = True
            LRN.Clear()
        ElseIf grade.Text = 4 Then
            txttf.Text = 28000
            txtmf.Text = 2500
            txtlf.Text = 2500
            txtbooks.Text = 2800
            txtotherfees.Text = 2000
            txttotal.Text = 0
            txttotal.Visible = True
            fees()
            LRN.Enabled = True
            LRN.Clear()
            cmb_student.Items.Clear()
            cmb_student.Items.Add("Old")
            cmb_student.Items.Add("New")
        ElseIf grade.Text = 5 Then
            txttf.Text = 30000
            txtmf.Text = 3000
            txtlf.Text = 3000
            txtbooks.Text = 3500
            txtotherfees.Text = 2500
            txttotal.Text = 0
            txttotal.Visible = True
            fees()
            LRN.Enabled = True
            LRN.Clear()
            cmb_student.Items.Clear()
            cmb_student.Items.Add("Old")
            cmb_student.Items.Add("New")
        ElseIf grade.Text = 6 Then
            txttf.Text = 35000
            txtmf.Text = 3500
            txtlf.Text = 3500
            txtbooks.Text = 4200
            txtotherfees.Text = 3000
            txttotal.Text = 0
            txttotal.Visible = True
            fees()
            LRN.Enabled = True
            LRN.Clear()
            cmb_student.Items.Clear()
            cmb_student.Items.Add("Old")
            cmb_student.Items.Add("New")
        End If
    End Sub
    Private Sub grade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grade.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Section.Focus()
        End If
    End Sub

    Private Sub Section_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Section.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            pangalan.Focus()
        End If
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
    Private Sub gender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gender.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            address.Focus()
        End If
    End Sub
    Private Sub transferee_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            LRN.Focus()
        End If
    End Sub

    Private Sub LRN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LRN.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            e.Handled = False
        Else
            e.Handled = True

        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then

            If LRN.TextLength = 12 Then
                e.Handled = True
                hanaplrn()
                txt_ln.Focus()
            ElseIf LRN.TextLength <= 11 Then
                e.Handled = False
                MsgBox("Invalid LRN")
                LRN.Text = ""
                LRN.Focus()
            End If
        End If
    End Sub

    Private Sub txt_bp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bp.KeyPress
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
            address.Focus()
        End If
    End Sub
    Private Sub address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles address.KeyPress
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
            father.Focus()
        End If
    End Sub

    Private Sub father_KeyPress(sender As Object, e As KeyPressEventArgs) Handles father.KeyPress
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
            foccu.Focus()
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

    Private Sub mother_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mother.KeyPress
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
            moccu.Focus()
        End If
    End Sub

    Private Sub moccu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles moccu.KeyPress
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
            mcont.Focus()
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

            If mcont.TextLength = 11 Then
                e.Handled = True
                guardian.Focus()
            ElseIf mcont.TextLength <= 10 Then
                e.Handled = False
                MsgBox("Invalid Number #")
                mcont.Text = ""
                mcont.Focus()
            End If
        End If
    End Sub

    Private Sub gcont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gcont.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            e.Handled = False
        Else
            e.Handled = True

        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then

            If gcont.TextLength = 11 Then
                e.Handled = True
            ElseIf gcont.TextLength <= 10 Then
                e.Handled = False
                MsgBox("Invalid Number #")
                gcont.Text = ""
                gcont.Focus()
            End If
        End If
    End Sub

    Private Sub guardian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles guardian.KeyPress
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
            gadd.Focus()
        End If
    End Sub

    Private Sub gadd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gadd.KeyPress
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
            gcont.Focus()
        End If
    End Sub

    Private Sub foccu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles foccu.KeyPress
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
            fcont.Focus()
        End If
    End Sub

    Private Sub btn_import_Click(sender As Object, e As EventArgs) Handles btn_import.Click
        browseimage.Title = "SELECT IMAGES"
        browseimage.Filter = "Images File (*.BMP; *.JPG; *.PNG;*.GIF) | *.BMP; *.JPG; *.PNG;*.GIF"

        If browseimage.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = browseimage.FileName.ToString
            dayapic.Text = browseimage.FileName.ToString
        End If
    End Sub

    Private Sub btn_enroll_Click(sender As Object, e As EventArgs) Handles btn_enroll.Click
        If pangalan.Text = "" Then
            MsgBox("Invalid")
        Else
            master()
            clear()
        End If


    End Sub

    Sub master()

        Dim cd As MySqlCommand

        Try
            con.Open()
            cd = con.CreateCommand
            cd.CommandText = "insert into studentsdb(Grade_Level, Student_Type, Section, LRN, Lastname, Firstname, Middlename, Suffix, Student_Name, Gender,Birthday, Birthplace, Age, Address, Enrolled, Student_Picture, Father_Name, Father_Occupation, Father_Contact, Mother_Name, Mother_Occupation, Mother_Contact, Guardian, Guardian_Address, Guardian_Contact, TuitionFee, Balance, Date_Enrolled,Time_Enrolled)
             values(@Grade_Level, @Student_Type, @Section, @LRN, @Lastname, @Firstname, @Middlename, @Suffix, @Student_Name, @Gender, @Birthday, @Birthplace, @Age, @Address, @Enrolled, @Student_Picture, @Father_Name, @Father_Occupation, @Father_Contact, @Mother_Name, @Mother_Occupation, @Mother_Contact, @Guardian, @Guardian_Address, @Guardian_Contact, @TuitionFee, @Balance, @Date_Enrolled,@Time_Enrolled);"
            cd.Parameters.AddWithValue("@Grade_Level", grade.Text)
            cd.Parameters.AddWithValue("@Student_Type", cmb_student.Text)
            cd.Parameters.AddWithValue("@Section", Section.Text)
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
            cd.Parameters.AddWithValue("@Enrolled", unofficial.Text)
            cd.Parameters.AddWithValue("@Student_Picture", dayapic.Text)
            cd.Parameters.AddWithValue("@Father_Name", father.Text)
            cd.Parameters.AddWithValue("@Father_Occupation", foccu.Text)
            cd.Parameters.AddWithValue("@Father_Contact", fcont.Text)
            cd.Parameters.AddWithValue("@Mother_Name", mother.Text)
            cd.Parameters.AddWithValue("Mother_Occupation", moccu.Text)
            cd.Parameters.AddWithValue("@Mother_Contact", mcont.Text)
            cd.Parameters.AddWithValue("@Guardian", guardian.Text)
            cd.Parameters.AddWithValue("@Guardian_Address", gadd.Text)
            cd.Parameters.AddWithValue("@Guardian_Contact", gcont.Text)
            cd.Parameters.AddWithValue("@TuitionFee", txttotal.Text)
            cd.Parameters.AddWithValue("@Balance", balance.Text)
            cd.Parameters.AddWithValue("@Date_Enrolled", lbldate.Text)
            cd.Parameters.AddWithValue("@Time_Enrolled", lbltime.Text)
            cd.ExecuteNonQuery()
            MsgBox("Registered !")
            cd.Parameters.Clear()
            'students()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Sub students()
    '    Try
    '        con.Open()

    '        Dim query As String = " select * from studentsdb"
    '        Dim adpt As New MySqlDataAdapter(query, con)
    '        Dim ds As New DataSet()
    '        adpt.Fill(ds, "studentsdb")
    '        con.Close()
    '    Catch ex As Exception
    '    End Try

    'End Sub
    Private Sub Enrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        '    students()
        con.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Date.Now.ToString("MM-dd-yyyy ")
        lbltime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles birthday.ValueChanged
        Dim borrow As Int16 = birthday.Value.Year
        Dim DateNow As Int16 = Today.Year
        age.Text = DateNow - borrow

    End Sub
    Sub hanaplrn()
        Try


            Dim command As New MySqlCommand("SELECT * FROM `studentsdb` WHERE `LRN` = @LRN", con)
            command.Parameters.Add("@LRN", MySqlDbType.Int64).Value = LRN.Text
            Dim reader As MySqlDataReader
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                reader = command.ExecuteReader()

                If reader.Read() = True Then
                    MsgBox("The LRN You Have Entered Belongs To:" & " " & (reader(8)))
                    LRN.Clear()
                    LRN.Focus()
                ElseIf reader.Read() = False Then
                    txt_ln.Focus()
                End If
                con.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub clear()
        Try


            LRN.Clear()
            cmb_student.Items.Clear()
            cmb_student.Items.Add("Old")
            cmb_student.Items.Add("New")
            grade.Items.Clear()
            grade.Items.Add("1")
            grade.Items.Add("2")
            grade.Items.Add("3")
            grade.Items.Add("4")
            grade.Items.Add("5")
            grade.Items.Add("6")
            Section.Items.Clear()
            Section.Items.Add("A")
            Section.Items.Add("B")
            txt_ln.Clear()
            txt_fn.Clear()
            txt_mn.Clear()
            txt_sf.Clear()
            gender.Items.Clear()
            gender.Items.Add("Male")
            gender.Items.Add("Female")
            txt_bp.Clear()
            age.Clear()
            address.Clear()
            pangalan.Clear()
            father.Clear()
            foccu.Clear()
            fcont.Clear()
            mother.Clear()
            moccu.Clear()
            txtotherfees.Text = ""
            txttotal.Clear()
            mcont.Clear()
            guardian.Clear()
            gcont.Clear()
            gadd.Clear()
            dayapic.Text = ""
            PictureBox1.ImageLocation = dayapic.Text
            txttf.Clear()
            txtmf.Clear()
            txtlf.Clear()
            txtbooks.Clear()
            balance.Clear()
            birthday.Text = Date.Now
            txttotal.Clear()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
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
        ElseIf txt_sf.Text = "" Then
            MsgBox("FILL UP SUFFIX!")
            txt_sf.Focus()
        ElseIf address.Text = "" Then
            MsgBox("FILL UP ADDRESS!")
            address.Focus()
        ElseIf grade.Text = "" Then
            MsgBox("FILL UP GRADE!")
        ElseIf Section.Text = "" Then
            MsgBox("FILL UP SECTION!")
        ElseIf cmb_student.Text = "" Then
            MsgBox("FILL UP STUDENT!")
        ElseIf gender.Text = "" Then
            MsgBox("FILL UP GENDER!")
            gender.Focus()
        ElseIf age.Text = "" Then
            MsgBox("FILL UP AGE!")
            age.Focus()
        ElseIf txt_bp.Text = "" Then
            MsgBox("FILL UP BIRTHPLACE!")
            txt_bp.Focus()
        ElseIf father.Text = "" Then
            MsgBox("FILL UP FATHER'S NAME!")
            father.Focus()
        ElseIf foccu.Text = "" Then
            MsgBox("FILL UP FATHER'S OCCUPATION!")
            foccu.Focus()
        ElseIf fcont.Text = "" Then
            MsgBox("FILL UP FATHER'S CONTACT!")
            fcont.Focus()
        ElseIf mother.Text = "" Then
            MsgBox("FILL UP MOTHER'S NAME!")
            mother.Focus()
        ElseIf moccu.Text = "" Then
            MsgBox("FILL UP MOTHER'S OCCUPATION!")
            moccu.Focus()
        ElseIf mcont.Text = "" Then
            MsgBox("FILL UP MOTHER'S CONTACT!")
            mcont.Focus()
        ElseIf guardian.Text = "" Then
            MsgBox("FILL UP GUARDIAN'S NAME!")
            guardian.Focus()
        ElseIf gadd.Text = "" Then
            MsgBox("FILL UP GUARDIAN'S ADDRESS!")
            gadd.Focus()
        ElseIf gcont.Text = "" Then
            MsgBox("FILL UP GUARDIAN'S CONTACT!")
            gcont.Focus()
        ElseIf dayapic.Text = "" Then
            MsgBox("UPLOAD PICTURE!")
            btn_import.Focus()
        Else
            ''masterdb()
        End If
    End Sub
End Class