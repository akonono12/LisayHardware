Imports MySql.Data.MySqlClient
Public Class Expenses
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3, adtr4, adtr5 As MySqlDataAdapter

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        MainPage.Enabled = True
        Me.Hide()
    End Sub

    Dim dtable, dtable1, dtable2, dtable3, dtable4, dtable5 As New DataTable

#End Region
    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.OnValueChanged

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If BunifuMaterialTextbox1.Text = "" Or BunifuTextbox1.text = "" Then
            MsgBox("Please fill the empty field(S)")
        Else
            Dim comm2 As MySqlCommand
            comm2 = connt.openCon.CreateCommand
            comm2.CommandText = "INSERT INTO `expenses`( `Articles`, `amount` ) VALUES ('" & BunifuTextbox1.text & "','" & BunifuMaterialTextbox1.Text & "' );"
            comm2.ExecuteNonQuery()
            connt.closeCon()
            MsgBox("Successfully Added")
            BunifuMaterialTextbox1.Text = ""
            BunifuTextbox1.text = ""
            Dim answer As MsgBoxResult = MsgBox("Do you want to add another expenses?", MsgBoxStyle.YesNo, "Insert")
            If answer = MsgBoxResult.Yes Then
                connt.closeCon()

            Else
                connt.closeCon()
                MainPage.Enabled = True

                Me.Hide()

            End If
        End If
    End Sub
End Class