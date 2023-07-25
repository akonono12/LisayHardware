Imports MySql.Data.MySqlClient
Public Class returnItem
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
                BunifuFlatButton2.Enabled = False
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

    Private Sub BunifuMaterialTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.OnValueChanged
        If BunifuMaterialTextbox2.Text = "" Then
            BunifuMaterialTextbox2.Text = 0
        End If
        If BunifuMaterialTextbox2.Text = 0 Then
            BunifuFlatButton2.Enabled = False
        End If

        If BunifuMaterialTextbox2.Text >= b Then
            BunifuFlatButton2.Enabled = False


        Else
            BunifuFlatButton2.Enabled = True
            BunifuFlatButton2.Text = "Return an Item"
        End If
    End Sub

    Private Sub ReturnItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaditems()

    End Sub
#End Region
    Sub calculate()
        Dim stgqrys As String = "SELECT sum(purchasesale.tax+purchasesale.cost*purchasesale.Item_quantity) as total FROM purchasesale where purchasesale.Transaction_id='" & Label5.Text & "' and purchasesale.cusid='" & Label11.Text & "'"
        Dim comm As MySqlCommand
        Try

            adtr3 = New MySqlDataAdapter(stgqrys, connt.openCon)
            dtable2.Clear()
            If adtr3.Fill(dtable2) Then
                Label12.Text = dtable2(0)(0)

            Else

            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
        comm = connt.openCon.CreateCommand
        comm.CommandText = "UPDATE `payment` SET `total`=payment.deliveryfee +'" & Label12.Text & "'- payment.discount,`subtotal`='" & Label12.Text & "' WHERE payment.`trans_id`='" & Label5.Text & "'"
        comm.ExecuteNonQuery()
        connt.closeCon()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim comm, comm1 As MySqlCommand
        comm1 = connt.openCon.CreateCommand
        comm1.CommandText = "UPDATE stocks,purchasesale set stocks.Item_quantity=stocks.Item_quantity +'" & BunifuMaterialTextbox2.Text & "',purchasesale.Item_quantity=purchasesale.Item_quantity -'" & BunifuMaterialTextbox2.Text & "' where stocks.Item_code=purchasesale.Item_code and purchasesale.Item_code ='" & Label15.Text & "' and purchasesale.Transaction_id='" & Label5.Text & "';"
        comm1.ExecuteNonQuery()
        connt.closeCon()
        comm = connt.openCon.CreateCommand
        comm.CommandText = "INSERT INTO `custreturnitem`(`Item_code`, `Item_quantity`,`cust_id`, `delivery_id`)  VALUES(@ic,@iq,@sup,@di);"
        comm.Parameters.AddWithValue("@ic", Label15.Text)
        comm.Parameters.AddWithValue("@iq", BunifuMaterialTextbox2.Text)
        comm.Parameters.AddWithValue("@sup", Label7.Text)
        comm.Parameters.AddWithValue("@di", Label5.Text)

        comm.ExecuteNonQuery()
        connt.closeCon()
        calculate()
        loaditems()
        loadtrans()
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

    Sub loadtrans()
        Dim qryst2 As String = "select payment.total from payment where payment.trans_id='" & Label5.Text & "'"
        Dim dt2 As New DataTable
        Try
            adtr1 = New MySqlDataAdapter(qryst2, connt.openCon)
            dt2.Clear()
            adtr1.Fill(dt2)

            Label10.Text = dt2(0)(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub loaditems()
        Dim stgqry As String = "select purchasesale.Pos_id,purchasesale.Item_code,items.Item_name,purchasesale.Item_quantity,items.price,purchasesale.cusid,purchasesale.Transaction_id,purchasesale.purchaseDt from purchasesale INNER join items on purchasesale.Item_code=items.Item_code where purchasesale.Transaction_id='" & Label5.Text & "' and purchasesale.cusid='" & Label11.Text & "'"
        Try

            adtr2 = New MySqlDataAdapter(stgqry, connt.openCon)
            dtable1.Clear()
            If adtr2.Fill(dtable1) Then
                DataGridView1.DataSource = dtable1

                DataGridView1.Columns("Pos_id").Visible = False
                DataGridView1.Columns("cusid").Visible = False
                DataGridView1.Columns("Transaction_id").Visible = False
                DataGridView1.Columns("Item_code").HeaderText = "Item Code"
                DataGridView1.Columns("Item_name").HeaderText = "Item Name"
                DataGridView1.Columns("Item_quantity").HeaderText = "Purchased Quantity"
                DataGridView1.Columns("price").HeaderText = "Price per Item"
                DataGridView1.Columns("purchaseDt").HeaderText = "Date Purchased"

            Else

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        MainPage.Enabled = True
        MainPage.loadstocks1()
        Me.Close()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class