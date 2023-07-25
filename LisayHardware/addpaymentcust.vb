Imports MySql.Data.MySqlClient
Public Class addpaymentcust
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3, adtr4, adtr5 As MySqlDataAdapter
    Dim dtable, dtable1, dtable2, dtable3, dtable4, dtable5 As New DataTable

#End Region
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.Close()
    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click

    End Sub

    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
        AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        If BunifuMaterialTextbox1.Text = "" Then
            MsgBox("Please enter an amount")
        Else
            If BunifuMaterialTextbox1.Text <= 0 Then
                MsgBox("Must not be less than 1 ")
            Else

                Dim eamount As Decimal = BunifuMaterialTextbox1.Text
                Dim comm1, commup, commup2, comm2 As MySqlCommand
                Dim dbconn, dbconn1 As New MySqlConnection
                Dim mreader1 As MySqlDataReader
                comm2 = connt.openCon.CreateCommand
                comm2.CommandText = "INSERT INTO `payment_logs`( `cus_id`, `PaidAmount`) VALUES ('" & custid.Text & "','" & BunifuMaterialTextbox1.Text & "' );"
                comm2.ExecuteNonQuery()
                connt.closeCon()
                dbconn = New MySqlConnection("server=localhost;user id=root;persistsecurityinfo=False;database=tpshardware")
                dbconn1 = New MySqlConnection("server=localhost;user id=root;persistsecurityinfo=False;database=tpshardware")
                Try
                    dbconn.Open()
                    dbconn1.Open()
                    Dim stgqry1s As String = "SELECT * from payment inner join customer on payment.customer_id=customer.Cust_id where customer.Cust_id='" & custid.Text & "' and payment.remaining <> 0 ORDER by payment.Payment_id"
                    comm1 = New MySqlCommand(stgqry1s, dbconn)
                    mreader1 = comm1.ExecuteReader
                    While mreader1.Read()
                        Dim invn As Integer = mreader1.GetInt32("trans_id")
                        Dim bal As Decimal = mreader1.GetDecimal("remaining")
                        Dim total As Decimal = mreader1.GetDecimal("total")
                        If (eamount >= bal) Then
                            Dim query1 As String = "UPDATE `payment` SET `status`='1',`remaining`='0' WHERE payment.`trans_id`='" & invn & "';"

                            commup = New MySqlCommand(query1, dbconn1)
                            commup.ExecuteNonQuery()
                            eamount = eamount - total
                        ElseIf (eamount <= 0) Then
                        Else
                            Dim rembal As Decimal = bal - eamount
                            Dim query2 As String = "UPDATE `payment` SET `status`='0',`remaining`='" & rembal & "' WHERE payment.`trans_id`='" & invn & "';"
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
                UnpaidCust.loadpd()
                custid.Text = ""
                BunifuMaterialTextbox1.Text = ""
                Me.Hide()
            End If

        End If
    End Sub
End Class