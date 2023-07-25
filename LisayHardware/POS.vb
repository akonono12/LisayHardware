Imports MySql.Data.MySqlClient
Public Class POS
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3 As MySqlDataAdapter
    Dim dtable, dtable1, dtable2 As New DataTable
    Dim a, b, pricss, c, la, df As Double
    Dim iq As Integer
#End Region
    Sub check()
        Dim stgqry1 As String = "SELECT * FROM `tempcart`"

        Try

            adtr = New MySqlDataAdapter(stgqry1, connt.openCon)
            dtable.Clear()
            adtr.Fill(dtable)
            If dtable.Rows.Count = Nothing Then
            Else
                If dtable(0)(1) = Label15.Text Then
                    MsgBox("Please update your previous entry.Item Code: " & dtable(0)(1))
                    Label15.Text = ""
                    Label13.Text = ""
                Else
                End If
            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub calculate()
        Dim stgqrys As String = "SELECT *,sum(tempcart.Item_quantity * tempcart.price) as sub FROM `tempcart`"

        Try

            adtr3 = New MySqlDataAdapter(stgqrys, connt.openCon)
            dtable2.Clear()
            If adtr3.Fill(dtable2) Then
                Label1.Text = dtable2(0)(6)
            Else

            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub Queuetid()
        Dim qryst2 As String = "SELECT * FROM `payment` ORDER BY `payment`.`trans_id` DESC"
        Dim dt2 As New DataTable
        Try
            adtr1 = New MySqlDataAdapter(qryst2, connt.openCon)
            dt2.Clear()
            adtr1.Fill(dt2)
            If dt2.Rows.Count = Nothing Then
                Label5.Text = "1"
            Else
                Label5.Text = dt2(0)(1) + 1
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub loadcart()
        Dim stgqry As String = "SELECT * FROM `tempcart`"
        Try

            adtr2 = New MySqlDataAdapter(stgqry, connt.openCon)
            dtable1.Clear()
            If adtr2.Fill(dtable1) Then
                DataGridView1.DataSource = dtable1


                DataGridView1.Columns("Item_code").HeaderText = "Item Code"
                DataGridView1.Columns("Item_quantity").HeaderText = "Quantity"
                DataGridView1.Columns("price").HeaderText = "Item Price"
                DataGridView1.Columns("tax").HeaderText = "Tax"
                DataGridView1.Columns("itemstocks").Visible = False
                DataGridView1.Columns("tempcart_id").Visible = False
            Else

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()

    End Sub

    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadcart()


    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        selItem.Show()
    End Sub

    Private Sub BunifuMaterialTextbox4_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BunifuMaterialTextbox3_OnValueChanged(sender As Object, e As EventArgs) Handles tax.OnValueChanged
        If tax.Text = "" Then
            tax.Text = 0
        End If
        a = tax.Text / 100
        pricss = Convert.ToDouble(price.Text)
        b = pricss * a
        netPrice.Text = pricss + b
    End Sub

    Private Sub NetPrice_Click(sender As Object, e As EventArgs) Handles netPrice.Click

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        check()

        If BunifuMaterialTextbox2.Text = "" Then
            MsgBox("Field(s) must not be empty")
            Me.BunifuFlatButton2.Enabled = False
        Else

            Dim comm As MySqlCommand

            Try

                comm = connt.openCon.CreateCommand
                comm.CommandText = "INSERT INTO `tempcart`( `Item_code`, `Item_quantity`, `itemstocks`, `price` ) VALUES (@ic,@iq,@iis,@price);"

                comm.Parameters.AddWithValue("@ic", Label15.Text)
                comm.Parameters.AddWithValue("@iq", BunifuMaterialTextbox2.Text)
                comm.Parameters.AddWithValue("@iis", itmquant.Text)
                comm.Parameters.AddWithValue("@price", price.Text)




                comm.ExecuteNonQuery()
                connt.closeCon()
                Label15.Text = 0
                Label13.Text = ""



                price.Text = ""
                Me.BunifuFlatButton2.Enabled = False
                MsgBox("Successfully Added")



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            connt.closeCon()

            calculate()
            loadcart()
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            itemedit.BunifuMaterialTextbox7.Text = row.Cells(1).Value.ToString
            itemedit.BunifuMaterialTextbox1.Text = row.Cells(2).Value
            itemedit.BunifuMaterialTextbox2.Text = row.Cells(4).Value.ToString
            itemedit.itmqua.Text = row.Cells(3).Value
            optionpos.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Dim comm, comm1, comm2, comm3 As MySqlCommand

        comm = connt.openCon.CreateCommand
        comm.CommandText = "INSERT INTO `payment`( `trans_id`, `customer_id`,   `subtotal`, `discount`,  `total`, `deliveryfee`,remaining,transdate) VALUES(@transid,@supid,@sut,@dis,@net,@defee,@rem,NOW());"
        comm.Parameters.AddWithValue("@transid", Label5.Text)
        comm.Parameters.AddWithValue("@supid", Label7.Text)
        comm.Parameters.AddWithValue("@sut", Label1.Text)
        comm.Parameters.AddWithValue("@dis", discount.Text)
        comm.Parameters.AddWithValue("@defee", dfee.Text)
        comm.Parameters.AddWithValue("@net", Label10.Text)
        comm.Parameters.AddWithValue("@rem", Label10.Text)
        comm.ExecuteNonQuery()
        connt.closeCon()
        comm1 = connt.openCon.CreateCommand
        comm1.CommandText = "UPDATE stocks, tempcart SET stocks.Item_quantity=stocks.Item_quantity - tempcart.item_quantity where stocks.Item_code=tempcart.Item_code;"
        comm1.ExecuteNonQuery()
        connt.closeCon()


        comm2 = connt.openCon.CreateCommand
        comm2.CommandText = "INSERT INTO `purchasesale`( `Item_code`, `Item_quantity`, `cost`, `tax`, `Transaction_id`, `cusid`) select tempcart.Item_code, tempcart.item_quantity,tempcart.price,tempcart.tax," & Label5.Text & "," & Label7.Text & " from tempcart;"
        comm2.ExecuteNonQuery()
        connt.closeCon()
        comm3 = connt.openCon.CreateCommand
        comm3.CommandText = "DELETE FROM `tempcart`"
        comm3.ExecuteNonQuery()
        connt.closeCon()
        loadcart()

        MsgBox("Successfully Added")
        Dim answer As MsgBoxResult = MsgBox("Do you want to continue?", MsgBoxStyle.YesNo, "Info")
        dfee.Text = 0
        discount.Text = 0
        Label10.Text = 0
        Label1.Text = 0


        If answer = MsgBoxResult.Yes Then
            SelCustomer.loadcustomer()
            selItem.loaditems()
            MainPage.loadstocks1()
            Form1.Show()
            Me.Close()
        Else
            SelCustomer.loadcustomer()
            MainPage.loadstocks1()
            selItem.loaditems()
            MainPage.Enabled = True
            Me.Close()
        End If

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label10_TextChanged(sender As Object, e As EventArgs) Handles Label10.TextChanged
        If Label10.Text < 0 Then
            Label10.Text = 0
            MsgBox("The net total is in negative.Please adjust the discount")
            BunifuFlatButton4.Enabled = False
        Else
            BunifuFlatButton4.Enabled = True
        End If
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub Dfee_OnValueChanged(sender As Object, e As EventArgs) Handles dfee.OnValueChanged
        If dfee.Text = "" Then
            df = 0
        Else
            df = dfee.Text
        End If
        Label10.Text = la + df - c
    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        la = Label1.Text
        Label10.Text = la
        If la = 0 Then

            BunifuFlatButton4.Enabled = False
        Else
            BunifuFlatButton4.Enabled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles discount.OnValueChanged
        If discount.Text = "" Then
            c = 0
        Else
            c = discount.Text
        End If
        Label10.Text = la + df - c
    End Sub

    Private Sub BunifuMaterialTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.OnValueChanged

        If BunifuMaterialTextbox2.Text = "" Then
            BunifuMaterialTextbox2.Text = 0
        End If
        If Label15.Text = 0 Or Label15.Text = "" Then
        Else
            iq = Convert.ToInt32(itmquant.Text)
            If BunifuMaterialTextbox2.Text >= iq Then
                BunifuFlatButton2.Enabled = False
                MsgBox("The available stocks of the item: " & itmquant.Text)
            Else
                BunifuFlatButton2.Enabled = True
            End If
        End If


    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        MainPage.Enabled = True
        Me.Hide()
    End Sub

    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles discount.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub



    Private Sub BunifuMaterialTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tax.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
End Class