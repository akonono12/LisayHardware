Imports MySql.Data.MySqlClient
Public Class DelUser
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr As MySqlDataAdapter
    Dim dtable As New DataTable
    Dim ds As New DataSet
#End Region
    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Dim comm As MySqlCommand
        Dim answer As MsgBoxResult = MsgBox("Do you really want to delete the data?", MsgBoxStyle.YesNo, "Delete")

        Try
            comm = connt.openCon.CreateCommand
            comm.CommandText = "delete from user where usid=@id;"
            comm.Parameters.AddWithValue("@id", BunifuMaterialTextbox1.Text)

            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()
                MsgBox("User no. " & BunifuMaterialTextbox1.Text & " had successfully deleted")
                connt.closeCon()
                User.dgvload()
                Me.Hide()
            Else
                connt.closeCon()
                User.dgvload()
                Me.Hide()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
End Class