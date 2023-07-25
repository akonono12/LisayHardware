Imports MySql.Data.MySqlClient
Public Class epndds
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3 As MySqlDataAdapter
    Dim dtable, dtable1, dtable2, dtable3 As New DataTable

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form2.Show()

    End Sub

    Private Sub Epndds_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If paidtrans.Visible = True Then
            loadsales()
        Else
            loaditems()
        End If
    End Sub

    Dim a, b As Double
#End Region
    Sub loadsaless()
        Dim stgqrysss As String = "SELECT items.Item_code,items.Item_name,items.Description,temp_purchases.Item_quantity,temp_purchases.purchaseDt from payment inner join temp_purchases on payment.trans_id=temp_purchases.Transaction_id inner join items on temp_purchases.Item_code=items.Item_code where temp_purchases.Transaction_id='" & Label1.Text & "'"
        Try

            adtr = New MySqlDataAdapter(stgqrysss, connt.openCon)
            dtable.Clear()
            If adtr.Fill(dtable) Then
                DataGridView1.DataSource = dtable

                DataGridView1.Columns("Item_code").HeaderText = "Item Code"
                DataGridView1.Columns("Item_name").HeaderText = "Item Name"
                DataGridView1.Columns("Description").HeaderText = "Description"
                DataGridView1.Columns("Item_quantity").HeaderText = "Purchased Quantity"
                DataGridView1.Columns("purchaseDt").HeaderText = "Transaction Date"


            Else



            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub loadsales()
        Dim stgqryss As String = "SELECT items.Item_code,items.Item_name,items.Description,purchasesale.Item_quantity,purchasesale.purchaseDt from payment inner join purchasesale on payment.trans_id=purchasesale.Transaction_id inner join items on purchasesale.Item_code=items.Item_code where purchasesale.Transaction_id='" & Label1.Text & "'"
        Try

            adtr3 = New MySqlDataAdapter(stgqryss, connt.openCon)
            dtable3.Clear()
            If adtr3.Fill(dtable3) Then
                DataGridView1.DataSource = dtable3

                DataGridView1.Columns("Item_code").HeaderText = "Item Code"
                DataGridView1.Columns("Item_name").HeaderText = "Item Name"
                DataGridView1.Columns("Description").HeaderText = "Description"
                DataGridView1.Columns("Item_quantity").HeaderText = "Purchased Quantity"
                DataGridView1.Columns("purchaseDt").HeaderText = "Transaction Date"
                connt.closeCon()

            Else
                loadsaless()


            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub loaditems()
        Dim stgqry As String = "SELECT s_deliver.`Sd_id`, s_deliver.`Item_Code`,items.Item_name, s_deliver.`Item_quantity`, s_deliver.`S_price`, s_deliver.`Supplier_id`, s_deliver.`delivery_id`, s_deliver.`Delivered_Dt` FROM  s_deliver inner join items on s_deliver.Item_Code=items.Item_code where s_deliver.delivery_id='" & Label1.Text & "'"
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
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub
End Class