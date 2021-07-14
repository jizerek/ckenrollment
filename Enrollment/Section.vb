Imports MySql.Data.MySqlClient

Public Class Section
    Dim str As String = "server=localhost;username=root;password=;database=school db"
    Dim con As New MySqlConnection(str)
    Dim filepath As String
    Dim browseimage As New OpenFileDialog
    Private Sub Section_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
        students()
    End Sub
    Sub students()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim da As New MySqlDataAdapter("Select * from studentsdb", con)
        Dim dt As New DataTable
        da.Fill(dt)
        ' DataGridView1.DataSource = dt
        con.Close()

    End Sub
    Private Sub loader()
        If (con.State = ConnectionState.Closed) Then
            con.Open()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)

            Dim da As New MySqlDataAdapter("Select * from studentsdb", con)
            da.Fill(dt)

            Dim myRow As DataRow

            For Each myRow In dt.Rows
                lsv_students.Items.Add(myRow.Item(0))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(3))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(2))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(1))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(4))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(5))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(6))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(7))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(9))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(12))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(10))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(11))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(13))
            Next
        End If
        con.Close()
    End Sub
    Sub searchlrn()
        lsv_students.Items.Clear()
        If (con.State = ConnectionState.Closed) Then
            con.Open()
            Dim cmd As New MySqlCommand
            cmd = con.CreateCommand
            cmd.CommandText = "Select * from studentsdb where LRN like '%" & LRN.Text & "%'"
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            Dim x As ListViewItem
            Do While dr.Read = True
                x = New ListViewItem(dr("Grade_Level").ToString)
                x.SubItems.Add(dr("LRN"))
                x.SubItems.Add(dr("Section"))
                x.SubItems.Add(dr("Student_Type"))
                x.SubItems.Add(dr("Lastname"))
                x.SubItems.Add(dr("Firstname"))
                x.SubItems.Add(dr("Middlename"))
                x.SubItems.Add(dr("Suffix"))
                x.SubItems.Add(dr("Gender"))
                x.SubItems.Add(dr("Age"))
                x.SubItems.Add(dr("Birthday"))
                x.SubItems.Add(dr("Birthplace"))
                x.SubItems.Add(dr("Address"))
                lsv_students.Items.Add(x)
            Loop
            con.Close()
        Else

        End If

    End Sub
    Sub searchgr()
        lsv_students.Items.Clear()
        If (con.State = ConnectionState.Closed) Then
            con.Open()
            Dim cmd As New MySqlCommand
            cmd = con.CreateCommand
            cmd.CommandText = "Select * from studentsdb where Grade_Level like '%" & grade.Text & "%'"
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            Dim x As ListViewItem
            Do While dr.Read = True
                x = New ListViewItem(dr("Grade_Level").ToString)
                x.SubItems.Add(dr("LRN"))
                x.SubItems.Add(dr("Section"))
                x.SubItems.Add(dr("Student_Type"))
                x.SubItems.Add(dr("Lastname"))
                x.SubItems.Add(dr("Firstname"))
                x.SubItems.Add(dr("Middlename"))
                x.SubItems.Add(dr("Suffix"))
                x.SubItems.Add(dr("Gender"))
                x.SubItems.Add(dr("Age"))
                x.SubItems.Add(dr("Birthday"))
                x.SubItems.Add(dr("Birthplace"))
                x.SubItems.Add(dr("Address"))
                lsv_students.Items.Add(x)
                LRN.Enabled = True
            Loop
            con.Close()
        Else

        End If

    End Sub
    Sub hanap()
        Try
            Dim command As New MySqlCommand("SELECT * FROM `studentsdb` WHERE `LRN` = @LRN", con)
            command.Parameters.Add("@LRN", MySqlDbType.Int64).Value = LRN.Text
            Dim reader As MySqlDataReader
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                reader = command.ExecuteReader()
                If reader.Read() = True Then
                    LRN.Text = reader(3)
                    PictureBox2.ImageLocation = reader(15)
                    txtgrade.Text = reader(0)
                    txt_ln.Text = reader(4)
                    txt_fn.Text = reader(5)
                    txt_mn.Text = reader(6)
                    txt_sf.Text = reader(7)
                    gender.Text = reader(9)
                    birthday.Text = reader(10)
                    txt_bp.Text = reader(11)
                    age.Text = reader(12)
                    address.Text = reader(13)
                    studtype.Text = reader(1)
                    txtsec.Text = reader(2)
                    txtgrade.Visible = True
                    grade.Visible = False
                ElseIf reader.Read() = False Then
                    MsgBox("The LRN you have entered is Incorrect")
                    clear()
                    txtgrade.Visible = False
                    grade.Visible = True

                End If
            End If
            con.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub grade_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles grade.SelectedIndexChanged
        searchgr()
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
                If grade.Visible = True And txtgrade.Visible = False Then
                    searchgr()
                ElseIf grade.Visible = False And txtgrade.Visible = True Then
                    searchlrn()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtsec_TextChanged(sender As Object, e As EventArgs) Handles txtsec.TextChanged
        If grade.Text = "1" Then
            gr1()
        ElseIf grade.Text = "2" Then
            gr2
        ElseIf grade.Text = "3" Then
            gr3()
        ElseIf grade.Text = "4" Then
            gr4()
        ElseIf grade.Text = "5" Then
            gr5()
        ElseIf grade.Text = "6" Then
            gr6()
        Else
            gra()
        End If
    End Sub
    Sub gr1()
        Try
            lsv_students.Items.Clear()
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                Dim cmd As New MySqlCommand
                cmd = con.CreateCommand
                cmd.CommandText = "Select * from gr1info where Section like '%" & txtsec.Text & "%'"
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                Dim x As ListViewItem
                Do While dr.Read = True
                    x = New ListViewItem(dr("Grade_Level").ToString)
                    x.SubItems.Add(dr("LRN"))
                    x.SubItems.Add(dr("Section"))
                    x.SubItems.Add(dr("Student_Type"))
                    x.SubItems.Add(dr("Lastname"))
                    x.SubItems.Add(dr("Firstname"))
                    x.SubItems.Add(dr("Middlename"))
                    x.SubItems.Add(dr("Suffix"))
                    x.SubItems.Add(dr("Gender"))
                    x.SubItems.Add(dr("Age"))
                    x.SubItems.Add(dr("Birthday"))
                    x.SubItems.Add(dr("Birthplace"))
                    x.SubItems.Add(dr("Address"))
                    lsv_students.Items.Add(x)
                Loop
                con.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub gr2()
        Try
            lsv_students.Items.Clear()
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                Dim cmd As New MySqlCommand
                cmd = con.CreateCommand
                cmd.CommandText = "Select * from gr2info where Section like '%" & txtsec.Text & "%'"
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                Dim x As ListViewItem
                Do While dr.Read = True
                    x = New ListViewItem(dr("Grade_Level").ToString)
                    x.SubItems.Add(dr("LRN"))
                    x.SubItems.Add(dr("Section"))
                    x.SubItems.Add(dr("Student_Type"))
                    x.SubItems.Add(dr("Lastname"))
                    x.SubItems.Add(dr("Firstname"))
                    x.SubItems.Add(dr("Middlename"))
                    x.SubItems.Add(dr("Suffix"))
                    x.SubItems.Add(dr("Gender"))
                    x.SubItems.Add(dr("Age"))
                    x.SubItems.Add(dr("Birthday"))
                    x.SubItems.Add(dr("Birthplace"))
                    x.SubItems.Add(dr("Address"))
                    lsv_students.Items.Add(x)
                Loop
                con.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub gr3()
        Try
            lsv_students.Items.Clear()
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                Dim cmd As New MySqlCommand
                cmd = con.CreateCommand
                cmd.CommandText = "Select * from gr3info where Section like '%" & txtsec.Text & "%'"
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                Dim x As ListViewItem
                Do While dr.Read = True
                    x = New ListViewItem(dr("Grade_Level").ToString)
                    x.SubItems.Add(dr("LRN"))
                    x.SubItems.Add(dr("Section"))
                    x.SubItems.Add(dr("Student_Type"))
                    x.SubItems.Add(dr("Lastname"))
                    x.SubItems.Add(dr("Firstname"))
                    x.SubItems.Add(dr("Middlename"))
                    x.SubItems.Add(dr("Suffix"))
                    x.SubItems.Add(dr("Gender"))
                    x.SubItems.Add(dr("Age"))
                    x.SubItems.Add(dr("Birthday"))
                    x.SubItems.Add(dr("Birthplace"))
                    x.SubItems.Add(dr("Address"))
                    lsv_students.Items.Add(x)
                Loop
                con.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub gr4()
        Try
            lsv_students.Items.Clear()
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                Dim cmd As New MySqlCommand
                cmd = con.CreateCommand
                cmd.CommandText = "Select * from gr4info where Section like '%" & txtsec.Text & "%'"
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                Dim x As ListViewItem
                Do While dr.Read = True
                    x = New ListViewItem(dr("Grade_Level").ToString)
                    x.SubItems.Add(dr("LRN"))
                    x.SubItems.Add(dr("Section"))
                    x.SubItems.Add(dr("Student_Type"))
                    x.SubItems.Add(dr("Lastname"))
                    x.SubItems.Add(dr("Firstname"))
                    x.SubItems.Add(dr("Middlename"))
                    x.SubItems.Add(dr("Suffix"))
                    x.SubItems.Add(dr("Gender"))
                    x.SubItems.Add(dr("Age"))
                    x.SubItems.Add(dr("Birthday"))
                    x.SubItems.Add(dr("Birthplace"))
                    x.SubItems.Add(dr("Address"))
                    lsv_students.Items.Add(x)
                Loop
                con.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub gr5()
        Try
            lsv_students.Items.Clear()
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                Dim cmd As New MySqlCommand
                cmd = con.CreateCommand
                cmd.CommandText = "Select * from gr5info where Section like '%" & txtsec.Text & "%'"
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                Dim x As ListViewItem
                Do While dr.Read = True
                    x = New ListViewItem(dr("Grade_Level").ToString)
                    x.SubItems.Add(dr("LRN"))
                    x.SubItems.Add(dr("Section"))
                    x.SubItems.Add(dr("Student_Type"))
                    x.SubItems.Add(dr("Lastname"))
                    x.SubItems.Add(dr("Firstname"))
                    x.SubItems.Add(dr("Middlename"))
                    x.SubItems.Add(dr("Suffix"))
                    x.SubItems.Add(dr("Gender"))
                    x.SubItems.Add(dr("Age"))
                    x.SubItems.Add(dr("Birthday"))
                    x.SubItems.Add(dr("Birthplace"))
                    x.SubItems.Add(dr("Address"))
                    lsv_students.Items.Add(x)
                Loop
                con.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub gr6()
        Try
            lsv_students.Items.Clear()
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                Dim cmd As New MySqlCommand
                cmd = con.CreateCommand
                cmd.CommandText = "Select * from gr6pinfo where Section like '%" & txtsec.Text & "%'"
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                Dim x As ListViewItem
                Do While dr.Read = True
                    x = New ListViewItem(dr("Grade_Level").ToString)
                    x.SubItems.Add(dr("LRN"))
                    x.SubItems.Add(dr("Section"))
                    x.SubItems.Add(dr("Student_Type"))
                    x.SubItems.Add(dr("Lastname"))
                    x.SubItems.Add(dr("Firstname"))
                    x.SubItems.Add(dr("Middlename"))
                    x.SubItems.Add(dr("Suffix"))
                    x.SubItems.Add(dr("Gender"))
                    x.SubItems.Add(dr("Age"))
                    x.SubItems.Add(dr("Birthday"))
                    x.SubItems.Add(dr("Birthplace"))
                    x.SubItems.Add(dr("Address"))
                    lsv_students.Items.Add(x)
                Loop
                con.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub gra()
        Try
            lsv_students.Items.Clear()
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                Dim cmd As New MySqlCommand
                cmd = con.CreateCommand
                cmd.CommandText = "Select * from studentsdb where Section like '%" & txtsec.Text & "%'"
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                Dim x As ListViewItem
                Do While dr.Read = True
                    x = New ListViewItem(dr("Grade_Level").ToString)
                    x.SubItems.Add(dr("LRN"))
                    x.SubItems.Add(dr("Section"))
                    x.SubItems.Add(dr("Student_Type"))
                    x.SubItems.Add(dr("Lastname"))
                    x.SubItems.Add(dr("Firstname"))
                    x.SubItems.Add(dr("Middlename"))
                    x.SubItems.Add(dr("Suffix"))
                    x.SubItems.Add(dr("Gender"))
                    x.SubItems.Add(dr("Age"))
                    x.SubItems.Add(dr("Birthday"))
                    x.SubItems.Add(dr("Birthplace"))
                    x.SubItems.Add(dr("Address"))
                    lsv_students.Items.Add(x)
                Loop
                con.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clear()
        gender.Clear()
        LRN.Clear()
        studtype.Clear()
        txt_fn.Clear()
        txt_ln.Clear()
        txt_mn.Clear()
        txt_sf.Clear()
        txt_bp.Clear()
        birthday.Clear()
        address.Clear()
        age.Clear()
        gender.Clear()
        lbldaya.Text = ""
        PictureBox2.ImageLocation = lbldaya.Text

    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        lsv_students.Items.Clear()
        loader()
        grade.Show()
        txtgrade.Hide()
        grade.Items.Clear()
        grade.Items.Add(1)
        grade.Items.Add(2)
        grade.Items.Add(3)
        grade.Items.Add(4)
        grade.Items.Add(5)
        grade.Items.Add(6)
        LRN.Enabled = True
        txtsec.Enabled = True
        txtsec.Clear()
        clear()
    End Sub
    Private Sub btn_enroll_Click(sender As Object, e As EventArgs) Handles btn_enroll.Click
        hanap()

        If grade.Visible = True And txtgrade.Visible = False Then
            searchgr()
        ElseIf grade.Visible = False And txtgrade.Visible = True Then
            searchlrn()
        End If
    End Sub
    Private Sub LRN_TextChanged(sender As Object, e As EventArgs) Handles LRN.TextChanged
        searchlrn()
    End Sub
End Class