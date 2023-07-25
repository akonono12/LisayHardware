Imports MySql.Data.MySqlClient
Public Class Sales
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3 As MySqlDataAdapter
    Dim dtable, dtable1, dtable2 As New DataTable
    Dim a, b, pricss, c, la, df As Double

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        selItem.Show()
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

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        MainPage.Enabled = True
        Me.Close()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Dim comm, comm1, comm2, comm3 As MySqlCommand

        comm = connt.openCon.CreateCommand
        comm.CommandText = "INSERT INTO `payment`( `trans_id`, `customer_id`,   `subtotal`, `discount`,  `total`, `deliveryfee`,remaining,transdate) VALUES(@transid,@supid,@sut,@dis,@net,@defee,@rem,@time);"
        comm.Parameters.AddWithValue("@transid", Label5.Text)
        comm.Parameters.AddWithValue("@supid", Label7.Text)
        comm.Parameters.AddWithValue("@sut", Label1.Text)
        comm.Parameters.AddWithValue("@dis", discount.Text)
        comm.Parameters.AddWithValue("@defee", dfee.Text)
        comm.Parameters.AddWithValue("@net", Label10.Text)
        comm.Parameters.AddWithValue("@rem", Label10.Text)
        comm.Parameters.AddWithValue("@time", DateTimePicker1.Value)
        comm.ExecuteNonQuery()
        connt.closeCon()



        comm2 = connt.openCon.CreateCommand
        comm2.CommandText = "INSERT INTO temp_purchases( `Item_code`, `Item_quantity`, `cost`, `Transaction_id`, `cusid`, `purchaseDt`) select tempcart.Item_code, tempcart.item_quantity,tempcart.price," & Label5.Text & "," & Label7.Text & ",@time from tempcart;"
        comm2.Parameters.AddWithValue("@time", DateTimePicker1.Value)
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
            tempsales.Show()
            Me.Close()
        Else
            SelCustomer.loadcustomer()
            MainPage.loadstocks1()
            selItem.loaditems()
            MainPage.Enabled = True
            Me.Close()
        End If

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

    Private Sub Discount_OnValueChanged(sender As Object, e As EventArgs) Handles discount.OnValueChanged
        If discount.Text = "" Then
            c = 0
        Else
            c = discount.Text
        End If
        Label10.Text = la + df - c
    End Sub

    Private Sub Dfee_OnValueChanged(sender As Object, e As EventArgs) Handles dfee.OnValueChanged
        If dfee.Text = "" Then
            df = 0
        Else
            df = dfee.Text
        End If
        Label10.Text = la + df - c
    End Sub

    Dim iq As Integer
#End Region
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
    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

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
End Class