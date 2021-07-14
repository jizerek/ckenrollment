Imports MySql.Data.MySqlClient

Public Class DashboardAdmin
    Dim str As String = "server=localhost;username=root;password=;database=school db"
    Dim con As New MySqlConnection(str)
    Private Sub DashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countstud()
        countacc()
        countarch()
    End Sub
    Sub countstud()
        Try

            Dim command As New MySqlCommand("SELECT COUNT(`LRN`) FROM `studentsdb`", con)
            con.Open()
            lbl_student.Text = command.ExecuteScalar().ToString()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub countacc()
        Try
            Dim command As New MySqlCommand("SELECT COUNT(`Employee_ID`) FROM `accdb`", con)
            con.Open()
            lbl_teacher.Text = command.ExecuteScalar().ToString()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub countarch()
        Try
            Dim command As New MySqlCommand("SELECT COUNT(`ID`) FROM `archives`", con)
            con.Open()
            Label1.Text = command.ExecuteScalar().ToString()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class