Imports MySql.Data.MySqlClient
Public Class tempsales
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr As MySqlDataAdapter
    Dim dtable As New DataTable
    Dim ds As New DataSet
#End Region
    Sub checkinvn()
        Dim stgqry1qq As String = "Select * from payment where `payment`.`trans_id`='" & BunifuTextbox2.text & "' "
        Try

            adtr = New MySqlDataAdapter(stgqry1qq, connt.openCon)
            dtable.Clear()
            If adtr.Fill(dtable) Then
                MsgBox("The Tr no." & BunifuTextbox2.text & " already had a duplicate", MsgBoxStyle.Information, "Info")
                BunifuTextbox2.text = ""
            Else

            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()

    End Sub
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        checkinvn()
        If BunifuTextbox2.text = "" Then
            MsgBox("Please insert a valid invoice number")
        Else
            Sales.Label5.Text = BunifuTextbox2.text
            BunifuTextbox2.text = ""
            MsgBox("Please select a customer")
            SelCustomer.flag.Text = 1
            SelCustomer.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        MainPage.Enabled = True
        Me.Hide()
    End Sub
End Class