Imports MySql.Data.MySqlClient

Public Class DashboardRegistrar
    Dim str As String = "server=localhost;username=root;password=;database=school db"
    Dim con As New MySqlConnection(str)
    Private Sub DashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        count()
    End Sub
    Sub count()
        Try

            Dim command As New MySqlCommand("SELECT COUNT(`LRN`) FROM `studentsdb`", con)
            con.Open()
            lbl_student.Text = command.ExecuteScalar().ToString()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class