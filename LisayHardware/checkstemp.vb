Imports MySql.Data.MySqlClient
Public Class checkstemp
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2 As MySqlDataAdapter
    Dim dtable, dtable1, dtable2 As New DataTable

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        checkcheckno()


        If BunifuTextbox1.text = "" Or BunifuMaterialTextbox1.Text = "" Then
            MsgBox("Please fill the empty fields")

        Else
            If BunifuMaterialTextbox1.Text <= 0 Then
                MsgBox("Must not be less than 1 ")
            Else
                Label1.Text = Format(Me.BunifuDatepicker1.Value.Date, "yyyy-MM-dd")

                Dim comm1, commup, commup2, comm2 As MySqlCommand
                Dim dbconn, dbconn1 As New MySqlConnection

                comm2 = connt.openCon.CreateCommand
                comm2.CommandText = "INSERT INTO `checks`( `Checkno`, `Amount`, `dateTime`, `supid`)  VALUES ('" & BunifuTextbox1.text & "','" & BunifuMaterialTextbox1.Text & "','" & Label1.Text & "','" & supid.Text & "' );"
                comm2.ExecuteNonQuery()
                connt.closeCon()
                MsgBox("Saved Successfully.You will be prompted on the date you entered")
                selectasupplier.loadsuppliers()

                MainPage.Enabled = True
                Me.Hide()
            End If
        End If

    End Sub

    Dim ds As New DataSet
#End Region
    Sub checkcheckno()
        Dim stgqry1qq As String = "SELECT * FROM `checks` WHERE checks.Checkno='" & BunifuTextbox1.text & "' "
        Try

            adtr = New MySqlDataAdapter(stgqry1qq, connt.openCon)
            dtable.Clear()
            If adtr.Fill(dtable) Then
                MsgBox("The cheque no." & BunifuTextbox1.text & "already had a duplicate", MsgBoxStyle.Information, "Info")
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
        Me.Close()
    End Sub
End Class