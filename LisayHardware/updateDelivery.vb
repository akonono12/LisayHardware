Imports MySql.Data.MySqlClient
Public Class updateDelivery
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr As MySqlDataAdapter
    Dim dtable As New DataTable
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
        Me.Close()
    End Sub

    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
   AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        checkcheckno()


        If BunifuTextbox1.text = "" Or BunifuMaterialTextbox1.Text = "" Then
            MsgBox("Please fill the empty fields")

        Else
            If BunifuMaterialTextbox1.Text <= 0 Then
                MsgBox("Must not be less than 1 ")
            Else
                Label1.Text = Format(Me.BunifuDatepicker1.Value.Date, "yyyy-MM-dd")
                Dim eamount As Decimal = BunifuMaterialTextbox1.Text
                Dim comm1, commup, commup2, comm2 As MySqlCommand
                Dim dbconn, dbconn1 As New MySqlConnection
                Dim mreader1 As MySqlDataReader
                comm2 = connt.openCon.CreateCommand
                comm2.CommandText = "INSERT INTO `checks`( `Checkno`, `Amount`, `dateTime`, `supid`)  VALUES ('" & BunifuTextbox1.text & "','" & BunifuMaterialTextbox1.Text & "','" & Label1.Text & "','" & supid.Text & "' );"
                comm2.ExecuteNonQuery()
                connt.closeCon()
                dbconn = New MySqlConnection("server=localhost;user id=root;persistsecurityinfo=False;database=tpshardware")
                dbconn1 = New MySqlConnection("server=localhost;user id=root;persistsecurityinfo=False;database=tpshardware")
                Try
                    dbconn.Open()
                    dbconn1.Open()
                    Dim stgqry1s As String = "SELECT * FROM `devl_trans` inner join supplier on devl_trans.supplier_id=supplier.sup_id where devl_trans.supplier_id='" & supid.Text & "'and devl_trans.remaining <> 0 order by devl_trans.devl_id"
                    comm1 = New MySqlCommand(stgqry1s, dbconn)
                    mreader1 = comm1.ExecuteReader
                    While mreader1.Read()
                        Dim trno As Integer = mreader1.GetInt32("trans_id")
                        Dim bal As Decimal = mreader1.GetDecimal("remaining")
                        Dim total As Decimal = mreader1.GetDecimal("nettotal")
                        If (eamount >= bal) Then
                            Dim query1 As String = "UPDATE `devl_trans` SET `remaining`='0',`status`='1' WHERE devl_trans.trans_id='" & trno & "';"

                            commup = New MySqlCommand(query1, dbconn1)
                            commup.ExecuteNonQuery()
                            eamount = eamount - total
                        ElseIf (eamount <= 0) Then
                        Else
                            Dim rembal As Decimal = bal - eamount

                            Dim query2 As String = " Update `devl_trans` Set `remaining`='" & rembal & "',`status`='0' WHERE devl_trans.trans_id='" & trno & "';"
                            commup2 = New MySqlCommand(query2, dbconn1)
                            commup2.ExecuteNonQuery()

                            eamount = eamount - total
                        End If
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                mreader1.Close()
                dbconn.Close()
                dbconn1.Close()

                MsgBox("Payment was successful", MsgBoxStyle.Information, "Info")
                Unpaidstocks.loadupd()
                supid.Text = ""
                BunifuMaterialTextbox1.Text = ""
                BunifuTextbox1.text = ""
                Me.Hide()
            End If

        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuDatepicker1_onValueChanged(sender As Object, e As EventArgs) Handles BunifuDatepicker1.onValueChanged

    End Sub
End Class