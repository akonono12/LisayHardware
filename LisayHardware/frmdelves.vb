Imports MySql.Data.MySqlClient
Public Class frmdelves
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3 As MySqlDataAdapter
    Dim dtable, dtable1, dtable2 As New DataTable
    Dim a, b As Integer

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            Label7.Text = row.Cells(5).Value.ToString
            b = Integer.Parse(row.Cells(3).Value.ToString)
            Label15.Text = row.Cells(1).Value.ToString
            Label13.Text = row.Cells(2).Value.ToString

            Dim answer As MsgBoxResult = MsgBox("Are you sure of this Item id: " & row.Cells(1).Value.ToString & " ?", MsgBoxStyle.YesNo, "Info")
            If answer = MsgBoxResult.Yes Then
                GroupBox2.Enabled = True
                DataGridView1.Enabled = False
            Else
                MsgBox("Please choose another item")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BunifuMaterialTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub Frmdelves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaditems()

    End Sub

    Private Sub Label1_RegionChanged(sender As Object, e As EventArgs) Handles Label1.RegionChanged
        Label10.Text = Label1.Text - Label19.Text
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim comm, comm1 As MySqlCommand
        comm1 = connt.openCon.CreateCommand
        comm1.CommandText = "update stocks,s_deliver set stocks.Item_quantity=stocks.Item_quantity+'" & BunifuMaterialTextbox2.Text & "',s_deliver.Item_quantity=s_deliver.Item_quantity-'" & BunifuMaterialTextbox2.Text & "' where stocks.Item_code=s_deliver.Item_Code and s_deliver.Item_Code='" & Label15.Text & "' and s_deliver.delivery_id='" & Label5.Text & "';"
        comm1.ExecuteNonQuery()
        connt.closeCon()
        comm = connt.openCon.CreateCommand
        comm.CommandText = "INSERT INTO `s_returned`( `Item_code`, `Item_quantity`, `Sup_id`, delivery_id) VALUES(@ic,@iq,@sup,@di);"
        comm.Parameters.AddWithValue("@ic", Label15.Text)
        comm.Parameters.AddWithValue("@iq", BunifuMaterialTextbox2.Text)
        comm.Parameters.AddWithValue("@sup", Label7.Text)
        comm.Parameters.AddWithValue("@di", Label5.Text)

        comm.ExecuteNonQuery()
        connt.closeCon()
        calculate()
        loaditems()
        loaddelivery()
        MsgBox("Successfully Updated")
        Dim answer As MsgBoxResult = MsgBox("Do want to continue?", MsgBoxStyle.YesNo, "Info")
        If answer = MsgBoxResult.Yes Then

            DataGridView1.Enabled = True
            GroupBox2.Enabled = False

        Else

            MainPage.Enabled = True
            MainPage.loadstocks1()
            DataGridView1.Enabled = True
            Me.Hide()
        End If
    End Sub

    Private Sub BunifuMaterialTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.OnValueChanged

        If BunifuMaterialTextbox2.Text = "" Then
            BunifuMaterialTextbox2.Text = 0
        End If
        If BunifuMaterialTextbox2.Text >= b Then
            BunifuFlatButton2.Enabled = False


        Else
            BunifuFlatButton2.Enabled = True
            BunifuFlatButton2.Text = "Return an Item"
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
#End Region
    Sub loaditems()
        Dim stgqry As String = "SELECT s_deliver.`Sd_id`, s_deliver.`Item_Code`,items.Item_name, s_deliver.`Item_quantity`, s_deliver.`S_price`, s_deliver.`Supplier_id`, s_deliver.`delivery_id`, s_deliver.`Delivered_Dt` FROM  s_deliver inner join items on s_deliver.Item_Code=items.Item_code where s_deliver.delivery_id='" & Label5.Text & "' and `s_deliver`.`Supplier_id`='" & Label11.Text & "'"
        Try

            adtr2 = New MySqlDataAdapter(stgqry, connt.openCon)
            dtable1.Clear()
            If adtr2.Fill(dtable1) Then
                DataGridView1.DataSource = dtable1

                DataGridView1.Columns("sd_id").Visible = False
                DataGridView1.Columns("Supplier_id").Visible = False
                DataGridView1.Columns("delivery_id").Visible = False
                DataGridView1.Columns("Item_code").HeaderText = "Item Code"
                DataGridView1.Columns("Item_name").HeaderText = "Item Name"
                DataGridView1.Columns("Item_quantity").HeaderText = "Delivered Quantity"
                DataGridView1.Columns("S_price").HeaderText = "Price per Item"
                DataGridView1.Columns("Delivered_Dt").HeaderText = "Date Delivered"

            Else

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Sub loaddelivery()
        Dim qryst2 As String = "SELECT devl_trans.trans_id,devl_trans.subtotal,devl_trans.Discount,devl_trans.nettotal,supplier.Name,devl_trans.datedevl,devl_trans.supplier_id FROM `devl_trans` INNER join supplier on devl_trans.supplier_id=supplier.sup_id where trans_id='" & Label5.Text & "'"
        Dim dt2 As New DataTable
        Try
            adtr1 = New MySqlDataAdapter(qryst2, connt.openCon)
            dt2.Clear()
            adtr1.Fill(dt2)
            Label1.Text = dt2(0)(1)
            Label19.Text = dt2(0)(2)
            Label10.Text = dt2(0)(3)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub calculate()
        Dim stgqrys As String = "SELECT *,sum(s_deliver.Item_quantity*s_deliver.S_price) as total FROM `s_deliver` where s_deliver.delivery_id='" & Label5.Text & "' and `s_deliver`.`Supplier_id`='" & Label11.Text & "'"
        Dim comm As MySqlCommand
        Try

            adtr3 = New MySqlDataAdapter(stgqrys, connt.openCon)
            dtable2.Clear()
            If adtr3.Fill(dtable2) Then
                Label12.Text = dtable2(0)(7)

            Else

            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
        comm = connt.openCon.CreateCommand
        comm.CommandText = "update devl_trans set devl_trans.subtotal='" & Label12.Text & "',devl_trans.nettotal=devl_trans.TrackingFee +'" & Label12.Text & "'- devl_trans.Discount  where devl_trans.trans_id='" & Label5.Text & "'"
        comm.ExecuteNonQuery()
        connt.closeCon()
    End Sub
    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        MainPage.Enabled = True
        MainPage.loadstocks1()
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class