Imports MySql.Data.MySqlClient
Public Class FrmSupDelv
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3 As MySqlDataAdapter
    Dim dtable, dtable1, dtable2 As New DataTable
    Dim a, b, c As Double
#End Region
    Sub check()
        Dim stgqry1 As String = "SELECT * FROM `tempdelivery`"

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
    Sub Queueid()
        Dim qryst2 As String = "SELECT * FROM `devl_trans` ORDER BY `devl_trans`.`trans_id` DESC"
        Dim dt2 As New DataTable
        Try
            adtr1 = New MySqlDataAdapter(qryst2, connt.openCon)
            dt2.Clear()
            adtr1.Fill(dt2)
            If dt2.Rows.Count = Nothing Then
                Label5.Text = "1"
            Else
                Label5.Text = dt2(0)(0) + 1
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub loadcart()
        Dim stgqry As String = "SELECT * FROM `tempdelivery`"
        Try

            adtr2 = New MySqlDataAdapter(stgqry, connt.openCon)
            dtable1.Clear()
            If adtr2.Fill(dtable1) Then
                DataGridView1.DataSource = dtable1

                DataGridView1.Columns("temp_cart").Visible = False
                DataGridView1.Columns("Item_code").HeaderText = "Item Code"
                DataGridView1.Columns("item_quantity").HeaderText = "Quantity"
                DataGridView1.Columns("supplier_price").HeaderText = "Supplier Price"

            Else

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()

    End Sub
    Sub calculate()
        Dim stgqrys As String = "SELECT *,sum(tempdelivery.item_quantity*tempdelivery.supplier_price) as itemsales FROM `tempdelivery`"

        Try

            adtr3 = New MySqlDataAdapter(stgqrys, connt.openCon)
            dtable2.Clear()
            If adtr3.Fill(dtable2) Then
                Label1.Text = dtable2(0)(4)
            Else

            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles discount.OnValueChanged

        If discount.Text = "" Then
            b = 0
        Else
            b = discount.Text
        End If
        Label10.Text = a + c - b
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        selItem.Show()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        MainPage.Enabled = True
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click

        check()
        If Label15.Text = "" Or Label15.Text = "0" Or BunifuMaterialTextbox2.Text = "" Or BunifuMaterialTextbox2.Text = "0" Or BunifuMaterialTextbox3.Text = "" Or BunifuMaterialTextbox3.Text = "0" Then
            MsgBox("Field(s) must not be empty")
        Else

            Dim comm As MySqlCommand

            Try

                comm = connt.openCon.CreateCommand
                comm.CommandText = "INSERT INTO `tempdelivery`(`Item_code`,  `item_quantity`, `supplier_price`) values (@ic,@iquan,@sp);"

                comm.Parameters.AddWithValue("@ic", Label15.Text)

                comm.Parameters.AddWithValue("@iquan", BunifuMaterialTextbox2.Text)
                comm.Parameters.AddWithValue("@sp", BunifuMaterialTextbox3.Text)

                comm.ExecuteNonQuery()
                connt.closeCon()
                Label15.Text = ""
                Label13.Text = ""

                BunifuMaterialTextbox2.Text = ""
                BunifuMaterialTextbox3.Text = ""
                MsgBox("Successfully Added")



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            connt.closeCon()

            calculate()
            loadcart()

        End If
    End Sub

    Private Sub FrmSupDelv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadcart()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label10_Enter(sender As Object, e As EventArgs) Handles Label10.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

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

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Dim comm, comm1, comm2, comm3 As MySqlCommand

        comm = connt.openCon.CreateCommand
        comm.CommandText = "INSERT INTO `devl_trans`(`trans_id`, `supplier_id`, `subtotal`, `Discount`, `nettotal`,TrackingFee,remaining,datedevl) VALUES(@transid,@supid,@sut,@dis,@net,@tfee,@rem,NOW());"
        comm.Parameters.AddWithValue("@transid", Label5.Text)
        comm.Parameters.AddWithValue("@supid", Label7.Text)
        comm.Parameters.AddWithValue("@sut", Label1.Text)
        comm.Parameters.AddWithValue("@dis", discount.Text)
        comm.Parameters.AddWithValue("@net", Label10.Text)
        comm.Parameters.AddWithValue("@tfee", trkfee.Text)
        comm.Parameters.AddWithValue("@rem", Label10.Text)
        comm.ExecuteNonQuery()
        connt.closeCon()
        comm1 = connt.openCon.CreateCommand
        comm1.CommandText = "UPDATE stocks, tempdelivery SET stocks.Item_quantity=stocks.Item_quantity + tempdelivery.item_quantity where stocks.Item_code=tempdelivery.Item_code;"
        comm1.ExecuteNonQuery()
        connt.closeCon()


        comm2 = connt.openCon.CreateCommand
        comm2.CommandText = "INSERT INTO `s_deliver`( `Item_Code`, `Item_quantity`, `S_price`, `Supplier_id`, `delivery_id`) select tempdelivery.Item_code, tempdelivery.item_quantity,tempdelivery.supplier_price," & Label7.Text & "," & Label5.Text & " from tempdelivery;"
        comm2.ExecuteNonQuery()
        connt.closeCon()

        comm3 = connt.openCon.CreateCommand
        comm3.CommandText = "DELETE FROM `tempdelivery`"
        comm3.ExecuteNonQuery()
        connt.closeCon()
        MsgBox("Successfully Added")
        Dim answer As MsgBoxResult = MsgBox("Do you want to add another deliver from a supplier?", MsgBoxStyle.YesNo, "Info")
        discount.Text = 0
        Label10.Text = 0
        Label1.Text = 0


        If answer = MsgBoxResult.Yes Then
            Dsupplier.loadsup()
            MainPage.loadstocks1()
            selItem.loaditems()
            TRno.Show()
            Me.Close()
        Else
            Dsupplier.loadsup()
            MainPage.loadstocks1()
            selItem.loaditems()
            MainPage.Enabled = True
            Me.Close()
        End If

    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub BunifuMaterialTextbox4_OnValueChanged(sender As Object, e As EventArgs) Handles trkfee.OnValueChanged
        If trkfee.Text = "" Then
            c = 0
        Else
            c = trkfee.Text
        End If
        Label10.Text = a + c - b
    End Sub

    Private Sub BunifuMaterialTextbox3_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox3.OnValueChanged

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

    Private Sub BunifuMaterialTextbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox3.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            delivered.BunifuMaterialTextbox7.Text = row.Cells(1).Value.ToString
            delivered.BunifuMaterialTextbox1.Text = row.Cells(2).Value.ToString
            delivered.BunifuMaterialTextbox2.Text = row.Cells(3).Value.ToString
            optndd.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        a = Label1.Text
        Label10.Text = a
        If a = 0 Then

            BunifuFlatButton4.Enabled = False
        Else
            BunifuFlatButton4.Enabled = True
        End If
    End Sub
End Class