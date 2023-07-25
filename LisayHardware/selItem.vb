Imports MySql.Data.MySqlClient
Public Class selItem
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr As MySqlDataAdapter
    Dim dtable As New DataTable
    Dim quant As Integer
    Dim price As Double
#End Region
    Sub loaditems()
        Dim stgqry As String = "SELECT items.Item_code,items.Item_name,items.Description,category.category,unit.Units,items.price,stocks.Item_quantity
FROM `items` INNER join category on items.category=category.id inner join unit on items.unit_id=unit.unit_id inner join stocks on stocks.Item_code=items.Item_code"
        Try

            adtr = New MySqlDataAdapter(stgqry, connt.openCon)
            dtable.Clear()
            adtr.Fill(dtable)
            DataGridView1.DataSource = dtable
            DataGridView1.Columns("price").Visible = True
            If POS.Visible = True Then
                DataGridView1.Columns("Item_quantity").HeaderText = "Stocks"
            Else
                DataGridView1.Columns("Item_quantity").Visible = True
            End If

            DataGridView1.Columns("Item_code").HeaderText = "Item Code"
            DataGridView1.Columns("Item_name").HeaderText = "Item Name"
            DataGridView1.Columns("Description").HeaderText = "Item Description"
            DataGridView1.Columns("category").HeaderText = "Item Category"
            DataGridView1.Columns("Units").HeaderText = "Item Units"




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            If POS.Visible = True Then
                If row.Cells(6).Value <> 5 Then
                    POS.Label15.Text = row.Cells(0).Value.ToString
                    POS.Label13.Text = row.Cells(1).Value.ToString
                    POS.itmquant.Text = Convert.ToInt32(row.Cells(6).Value.ToString)
                    POS.price.Text = Convert.ToDecimal(row.Cells(5).Value.ToString)
                    POS.BunifuFlatButton2.Enabled = True
                Else
                    MsgBox("The stock of the selected item is critical or out of stock", MsgBoxStyle.Information, "Warning")
                    POS.Label15.Text = ""
                    POS.Label13.Text = ""
                    POS.itmquant.Text = 0
                    POS.price.Text = 0

                End If

            ElseIf Sales.Visible = True Then
                Sales.Label15.Text = row.Cells(0).Value.ToString
                Sales.Label13.Text = row.Cells(1).Value.ToString

                Sales.price.Text = Convert.ToDecimal(row.Cells(5).Value.ToString)
                Sales.BunifuFlatButton2.Enabled = True
            Else
                FrmSupDelv.Label15.Text = row.Cells(0).Value.ToString
                FrmSupDelv.Label13.Text = row.Cells(1).Value.ToString

            End If

            Me.Hide()




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Hide()
    End Sub

    Private Sub SelItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaditems()
    End Sub
    Private Sub BunifuTextbox1_Enter(sender As Object, e As EventArgs) Handles BunifuTextbox1.Enter
        If BunifuTextbox1.text = "Search by Name" Then
            BunifuTextbox1.text = ""
        End If
    End Sub
    Private Sub BunifuTextbox1_Leave(sender As Object, e As EventArgs) Handles BunifuTextbox1.Leave
        If BunifuTextbox1.text = "" Then
            BunifuTextbox1.text = "Search by Name"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stgqry As String = "SELECT items.Item_code,items.Item_name,items.Description,category.category,unit.Units
FROM `items` INNER join category on items.category=category.id inner join unit on items.unit_id=unit.unit_id where Item_name like '%" & BunifuTextbox1.text & "%'"
        Dim ds1 As New DataSet
        Try
            If BunifuTextbox1.text = "Search by Name" Or BunifuTextbox1.text = "" Then
                loaditems()
            Else
                adtr = New MySqlDataAdapter(stgqry, connt.openCon)
                ds1.Clear()
                If adtr.Fill(ds1) Then
                    Me.DataGridView1.DataSource = ds1.Tables(0)

                    DataGridView1.Columns("Item_code").HeaderText = "Item Code"
                    DataGridView1.Columns("Item_name").HeaderText = "Item Name"
                    DataGridView1.Columns("Description").HeaderText = "Item Description"
                    DataGridView1.Columns("category").HeaderText = "Item Category"
                    DataGridView1.Columns("Units").HeaderText = "Item Units"
                Else
                    MsgBox("No data found")
                    BunifuTextbox1.text = "Search by Name"
                End If

            End If





        Catch ex As Exception

        End Try
        connt.closeCon()
    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class