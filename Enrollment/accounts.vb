Imports MySql.Data.MySqlClient
Public Class accounts
    Dim str As String = "server=localhost;username=root;password=;database=school db"
    Dim con As New MySqlConnection(str)
    Private Sub accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        position.Items.Add("Cashier")
        position.Items.Add("Registrar")
        loader()
    End Sub
    Sub hanap()
        Dim command As New MySqlCommand("SELECT * FROM `accdb` WHERE `Employee_ID` = @Employee_ID", con)
        command.Parameters.Add("@Employee_ID", MySqlDbType.Int64).Value = id.Text
        Dim reader As MySqlDataReader
        If (con.State = ConnectionState.Closed) Then
            con.Open()
            Try
                reader = command.ExecuteReader()

                If reader.Read() = True Then

                    gender.Text = reader(7)
                    PictureBox1.ImageLocation = reader(14)
                    bday.Text = reader(8)
                    age.Text = reader(9)
                    position.Text = reader(10)
                    contact.Text = reader(11)
                    user.Text = reader(12)
                    id.Text = reader(0)
                    pangalan.Text = reader(1)
                Else
                    MsgBox("Employee ID Does Not Exist")
                    lsv_students.Items.Clear()
                    loader()
                    position.Items.Clear()
                    position.Items.Add("Cashier")
                    position.Items.Add("Registrar")
                    pangalan.Clear()
                    age.Clear()
                    bday.Clear()
                    gender.Clear()
                    id.Clear()
                    contact.Clear()
                    user.Clear()
                    lbldaya.Text = ""
                    PictureBox1.ImageLocation = lbldaya.Text
                End If
            Catch ex As Exception
            End Try
        End If
        con.Close()
    End Sub
    Private Sub loader()
        If (con.State = ConnectionState.Closed) Then
            con.Open()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)

            Dim da As New MySqlDataAdapter("Select * from accdb", con)
            da.Fill(dt)

            Dim myRow As DataRow

            For Each myRow In dt.Rows
                lsv_students.Items.Add(myRow.Item(0))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(10))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(1))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(8))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(9))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(7))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(12))
                lsv_students.Items(lsv_students.Items.Count - 1).SubItems.Add(myRow.Item(11))



            Next
        End If
        con.Close()
    End Sub
    Sub searchgr()
        lsv_students.Items.Clear()
        If (con.State = ConnectionState.Closed) Then
            con.Open()
            Dim cmd As New MySqlCommand
            cmd = con.CreateCommand
            cmd.CommandText = "Select * from accdb where Position like '%" & position.Text & "%'"
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            Dim x As ListViewItem
            Do While dr.Read = True
                x = New ListViewItem(dr("Employee_ID").ToString)
                x.SubItems.Add(dr("Position"))
                x.SubItems.Add(dr("Name"))
                x.SubItems.Add(dr("Birthday"))
                x.SubItems.Add(dr("Age"))
                x.SubItems.Add(dr("Gender"))
                x.SubItems.Add(dr("Username"))
                x.SubItems.Add(dr("Contact_Number"))
                lsv_students.Items.Add(x)
            Loop
            con.Close()
        Else

        End If

    End Sub

    Private Sub position_SelectedIndexChanged(sender As Object, e As EventArgs) Handles position.SelectedIndexChanged
        searchgr()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        lsv_students.Items.Clear()
        loader()
        position.Items.Clear()
        position.Items.Add("Cashier")
        position.Items.Add("Registrar")
        pangalan.Clear()
        age.Clear()
        bday.Clear()
        gender.Clear()
        id.Clear()
        contact.Clear()
        user.Clear()
        lbldaya.Text = ""
        PictureBox1.ImageLocation = lbldaya.Text
    End Sub

    Private Sub id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles id.KeyPress
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
    Sub searchid()
        lsv_students.Items.Clear()
        If (con.State = ConnectionState.Closed) Then
            con.Open()
            Dim cmd As New MySqlCommand
            cmd = con.CreateCommand
            cmd.CommandText = "Select * from accdb where Employee_ID like '%" & id.Text & "%'"
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            Dim x As ListViewItem
            Do While dr.Read = True
                x = New ListViewItem(dr("Employee_ID").ToString)
                x.SubItems.Add(dr("Position"))
                x.SubItems.Add(dr("Name"))
                x.SubItems.Add(dr("Birthday"))
                x.SubItems.Add(dr("Age"))
                x.SubItems.Add(dr("Gender"))
                x.SubItems.Add(dr("Username"))
                x.SubItems.Add(dr("Contact_Number"))
                lsv_students.Items.Add(x)
            Loop
            con.Close()
        Else

        End If

    End Sub
    Private Sub id_TextChanged(sender As Object, e As EventArgs) Handles id.TextChanged
        searchid()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        hanap()
    End Sub
End Class