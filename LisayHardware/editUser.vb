Imports MySql.Data.MySqlClient
Public Class editUser
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr As MySqlDataAdapter
    Dim dtable As New DataTable
    Dim ds As New DataSet
#End Region

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Dim comm As MySqlCommand
        Dim answer As MsgBoxResult = MsgBox("Do you really want to update the data?", MsgBoxStyle.YesNo, "Update")

        Try
            comm = connt.openCon.CreateCommand
            comm.CommandText = "Update personal_info,user set personal_info.Fname=@fname,personal_info.Lname=@lname,user.Username=@user,user.Password=@pass where personal_info.user_id=user.usid and user.usid=@id ;"
            comm.Parameters.AddWithValue("@fname", BunifuMaterialTextbox2.Text)
            comm.Parameters.AddWithValue("@lname", BunifuMaterialTextbox3.Text)
            comm.Parameters.AddWithValue("@user", BunifuMaterialTextbox4.Text)
            comm.Parameters.AddWithValue("@pass", BunifuMaterialTextbox5.Text)
            comm.Parameters.AddWithValue("@id", BunifuMaterialTextbox1.Text)

            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()
                MsgBox("User No: " & BunifuMaterialTextbox1.Text & " had successfully updated")
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
        User.dgvload()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.Hide()

    End Sub

    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class