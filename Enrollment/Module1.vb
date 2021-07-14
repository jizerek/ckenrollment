Module Module1
    '########################################################################################
    'iTexmo API for C --> go to www.itexmo.com/developers.php for API Documentation
    '########################################################################################
    Function itexmo(ByVal Number As String, ByVal Message As String, ByVal ApiCode As String, ByVal ApiPassword As String)
        Using client As New Net.WebClient
            Dim parameter As New Specialized.NameValueCollection
            Dim url As String = "https://www.itexmo.com/php_api/api.php"
            parameter.Add("1", Number)
            parameter.Add("2", Message)
            parameter.Add("3", ApiCode)
            parameter.Add("passwd", ApiPassword)
            Dim rpb = client.UploadValues(url, "POST", parameter)
            itexmo = (New System.Text.UTF8Encoding).GetString(rpb)
        End Using
    End Function
    '########################################################################################
    'API END     '###########################################################################
    '########################################################################################


End Module
