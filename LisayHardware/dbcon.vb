Imports MySql.Data.MySqlClient

Public Class dbconn
    Dim stringcon As String = "server=localhost;user id=root;persistsecurityinfo=False;database=tpshardware"
    Dim conn As New MySqlConnection(stringcon)
    Public Function openCon() As MySqlConnection
        Try
            conn.Open()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return conn
    End Function
    Public Function closeCon() As MySqlConnection
        Try
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return conn
    End Function
End Class
