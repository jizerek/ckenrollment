Imports MySql.Data.MySqlClient
Public Class ActivityLog
    Dim str As String = "server=localhost;username=root;password=;database=school db"
    Dim con As New MySqlConnection(str)
    Private Sub loader()
        If (con.State = ConnectionState.Closed) Then
            con.Open()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Try


                Dim da As New MySqlDataAdapter("Select * from logs", con)
                da.Fill(dt)

                Dim myRow As DataRow

                For Each myRow In dt.Rows
                    ARCH.Items.Add(myRow.Item(0))
                    ARCH.Items(ARCH.Items.Count - 1).SubItems.Add(myRow.Item(1))
                    ARCH.Items(ARCH.Items.Count - 1).SubItems.Add(myRow.Item(2))
                    ARCH.Items(ARCH.Items.Count - 1).SubItems.Add(myRow.Item(3))
                    ARCH.Items(ARCH.Items.Count - 1).SubItems.Add(myRow.Item(4))

                Next
            Catch ex As Exception

            End Try
        End If
        con.Close()
    End Sub

    Private Sub ActivityLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub
    Sub searchgr()
        '  Try
        ARCH.Items.Clear()
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                Dim cmd As New MySqlCommand
                cmd = con.CreateCommand
            cmd.CommandText = "Select * from logs where Date Between '" & DateTimePicker1.Text & "'and'" & DateTimePicker2.Text & "'Group by Time "
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
                Dim x As ListViewItem
                Do While dr.Read = True
                    x = New ListViewItem(dr("Name").ToString)
                    x.SubItems.Add(dr("Username"))
                    x.SubItems.Add(dr("Position"))
                    x.SubItems.Add(dr("Time"))
                    x.SubItems.Add(dr("Date"))
                    ARCH.Items.Add(x)
                Loop
                con.Close()
            Else

            End If
            '  Catch ex As Exception
        '      MsgBox(ex.Message)
        '  End Try
    End Sub
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        searchgr()
    End Sub
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        ARCH.Items.Clear()
        loader()
        DateTimePicker1.Text = Date.Now
        DateTimePicker2.Text = Date.Now
    End Sub


End Class