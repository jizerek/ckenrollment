Imports MySql.Data.MySqlClient
Public Class Balance
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
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(8))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(25))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(26))

            Next
        End If
        con.Close()
    End Sub

    Private Sub Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
        students()
    End Sub
    Sub searchgr()
        lsv_students.Items.Clear()
        If (con.State = ConnectionState.Closed) Then
            con.Open()
            Dim cmd As New MySqlCommand
            cmd = con.CreateCommand
            cmd.CommandText = "Select * from studentsdb where Grade_Level like '%" & cmbo_grade.Text & "%'"
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            Dim x As ListViewItem
            Do While dr.Read = True
                x = New ListViewItem(dr("Grade_Level").ToString)
                x.SubItems.Add(dr("LRN"))
                x.SubItems.Add(dr("Section"))
                x.SubItems.Add(dr("Student_Name"))
                x.SubItems.Add(dr("TuitionFee"))
                x.SubItems.Add(dr("Balance"))
                lsv_students.Items.Add(x)
            Loop
            con.Close()
        Else

        End If

    End Sub
    Private Sub cmbo_grade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbo_grade.SelectedIndexChanged
        searchgr()
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        lsv_students.Items.Clear()
        loader()
        clear()
    End Sub
    Sub clear()
        cmbo_grade.Visible = True
        cmbo_grade.Items.Clear()
        cmbo_grade.Items.Add(1)
        cmbo_grade.Items.Add(2)
        cmbo_grade.Items.Add(3)
        cmbo_grade.Items.Add(4)
        cmbo_grade.Items.Add(5)
        cmbo_grade.Items.Add(6)
        section.Clear()
        txtbox_name.Clear()
        txttf.Clear()
        txtbalance.Clear()
        section.Enabled = True
        txtbox_lrn.Clear()
        lbldaya.Text = ""
        txtbox_lrn.Enabled = True
        PictureBox1.ImageLocation = lbldaya.Text
    End Sub
    Sub searchlrn()
        lsv_students.Items.Clear()
        If (con.State = ConnectionState.Closed) Then
            con.Open()
            Dim cmd As New MySqlCommand
            cmd = con.CreateCommand
            cmd.CommandText = "Select * from studentsdb where LRN like '%" & txtbox_lrn.Text & "%'"
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            Dim x As ListViewItem
            Do While dr.Read = True
                x = New ListViewItem(dr("Grade_Level").ToString)
                x.SubItems.Add(dr("LRN"))
                x.SubItems.Add(dr("Section"))
                x.SubItems.Add(dr("Student_Name"))
                x.SubItems.Add(dr("TuitionFee"))
                x.SubItems.Add(dr("Balance"))
                lsv_students.Items.Add(x)
            Loop
            con.Close()
        Else

        End If

    End Sub
    Sub hanap()

        Try

            Dim command As New MySqlCommand("SELECT * FROM `studentsdb` WHERE `LRN` = @LRN", con)
        command.Parameters.Add("@LRN", MySqlDbType.Int64).Value = txtbox_lrn.Text
        Dim reader As MySqlDataReader
        If (con.State = ConnectionState.Closed) Then
            con.Open()
            reader = command.ExecuteReader()
            If reader.Read() = True Then
                grade.Visible = True
                cmbo_grade.Visible = False
                grade.Text = reader(0)
                txtbox_lrn.Text = reader(3)
                section.Text = reader(2)
                txttf.Text = reader(25)
                txtbalance.Text = reader(26)
                txtbox_name.Text = reader(8)
                '     lbldaya.Text = reader(18)
                PictureBox1.ImageLocation = reader(15)
                '   txtbox_lrn.Enabled = False
            ElseIf reader.Read() = False Then
                MsgBox("The LRN you have entered is Incorrect")
                txtbox_lrn.Clear()

            End If
        End If
            con.Close()

        Catch ex As Exception

        End Try
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
                searchlrn()
                section.Enabled = True
                If grade.Visible = True And grade.Visible = False Then
                    searchgr()
                ElseIf grade.Visible = False And grade.Visible = True Then
                    searchlrn()
                    section.Enabled = True
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtbox_lrn_TextChanged(sender As Object, e As EventArgs) Handles txtbox_lrn.TextChanged
        searchlrn()
    End Sub
    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        hanap()
        If grade.Visible = True And grade.Visible = False Then
            searchgr()
        ElseIf grade.Visible = False And grade.Visible = True Then
            searchlrn()
            section.Enabled = False
        End If
    End Sub

End Class