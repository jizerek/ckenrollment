Friend Class MySqlConnection
    Private str As String

    Public Sub New(str As String)
        Me.str = str
    End Sub

    Friend Sub Open()
        Throw New NotImplementedException()
    End Sub
End Class
