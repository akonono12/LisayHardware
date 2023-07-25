Imports MySql.Data.MySqlClient
Public Class TRno
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr As MySqlDataAdapter
    Dim dtable As New DataTable
    Dim ds As New DataSet
#End Region
    Sub checktr()
        Dim stgqry1qq As String = "Select * from devl_trans where devl_trans.trans_id='" & BunifuTextbox1.text & "' "
        Try

            adtr = New MySqlDataAdapter(stgqry1qq, connt.openCon)
            dtable.Clear()
            If adtr.Fill(dtable) Then
                MsgBox("The Tr no." & BunifuTextbox1.text & " already had a duplicate", MsgBoxStyle.Information, "Info")
                BunifuTextbox1.text = ""
            Else

            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()

    End Sub
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        MainPage.Enabled = True
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        checktr()

        If BunifuTextbox1.text = "" Then
            MsgBox("Please fill the empty fields")
        Else
            FrmSupDelv.Label5.Text = BunifuTextbox1.text
            BunifuTextbox1.text = ""
            MsgBox("Please Select a supplier")
            Dsupplier.Show()
            Me.Hide()
        End If

    End Sub
End Class