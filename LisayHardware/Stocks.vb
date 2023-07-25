Imports MySql.Data.MySqlClient
Public Class Stocks
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr As MySqlDataAdapter
    Dim dtable As New DataTable
#End Region

    Sub loadstocks()
        Dim stgqry As String = "SELECT items.Item_code,items.Item_name,items.Description,category.category,unit.Units,stocks.Item_quantity,items.price,category.id,unit.unit_id, CASE
    WHEN stocks.Item_quantity > 30 THEN 'On Stock'
    WHEN stocks.Item_quantity BETWEEN 1 and 20  THEN 'Critical'
    ELSE 'Out of Stock'
END   as Status  FROM `items`inner join stocks on items.Item_code=stocks.Item_code INNER join category on items.category=category.id inner join unit on items.unit_id=unit.unit_id"
        Try

            adtr = New MySqlDataAdapter(stgqry, connt.openCon)
            dtable.Clear()
            adtr.Fill(dtable)
            DataGridView1.DataSource = dtable
            DataGridView1.Columns("id").Visible = False
            DataGridView1.Columns("unit_id").Visible = False
            DataGridView1.Columns("Item_code").HeaderText = "Item Code"
            DataGridView1.Columns("Item_name").HeaderText = "Item Name"
            DataGridView1.Columns("Description").HeaderText = "Item Description"
            DataGridView1.Columns("category").HeaderText = "Item Category"
            DataGridView1.Columns("Units").HeaderText = "Item Unit"
            DataGridView1.Columns("Item_quantity").HeaderText = "Availability"
            DataGridView1.Columns("price").HeaderText = "Item Price"
            connt.closeCon()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Sub dgvdesign()
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
        DataGridView1.BackgroundColor = Color.White

        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub
    Sub search()
        Dim stringquerySS As String = ""

        If ComboBox1.SelectedIndex = 0 Then
            stringquerySS = "SELECT items.Item_code,items.Item_name,items.Description,category.category,unit.Units,stocks.Item_quantity,items.price,category.id,unit.unit_id, CASE
    WHEN stocks.Item_quantity > 30 THEN 'On Stock'
    WHEN stocks.Item_quantity BETWEEN 1 and 20  THEN 'Critical'
    ELSE 'Out of Stock'
END   as Status  FROM `items`inner join stocks on items.Item_code=stocks.Item_code INNER join category on items.category=category.id inner join unit on items.unit_id=unit.unit_id where items.Item_code like '%" & BunifuTextbox7.text & "%'"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            stringquerySS = "SELECT items.Item_code,items.Item_name,items.Description,category.category,unit.Units,stocks.Item_quantity,items.price,category.id,unit.unit_id, CASE
    WHEN stocks.Item_quantity > 30 THEN 'On Stock'
    WHEN stocks.Item_quantity BETWEEN 1 and 20  THEN 'Critical'
    ELSE 'Out of Stock'
END   as Status  FROM `items`inner join stocks on items.Item_code=stocks.Item_code INNER join category on items.category=category.id inner join unit on items.unit_id=unit.unit_id where items.Item_name like '%" & BunifuTextbox7.text & "%'"

        ElseIf ComboBox1.SelectedIndex = 2 Then
            stringquerySS = "SELECT items.Item_code,items.Item_name,items.Description,category.category,unit.Units,stocks.Item_quantity,items.price,category.id,unit.unit_id, CASE
    WHEN stocks.Item_quantity > 30 THEN 'On Stock'
    WHEN stocks.Item_quantity BETWEEN 1 and 20  THEN 'Critical'
    ELSE 'Out of Stock'
END   as Status  FROM `items`inner join stocks on items.Item_code=stocks.Item_code INNER join category on items.category=category.id inner join unit on items.unit_id=unit.unit_id where category.category like '%" & BunifuTextbox7.text & "%'"

        ElseIf ComboBox1.SelectedIndex = 3 Then
            stringquerySS = "SELECT items.Item_code,items.Item_name,items.Description,category.category,unit.Units,stocks.Item_quantity,items.price,category.id,unit.unit_id, CASE
    WHEN stocks.Item_quantity > 30 THEN 'On Stock'
    WHEN stocks.Item_quantity BETWEEN 1 and 20  THEN 'Critical'
    ELSE 'Out of Stock'
END   as Status  FROM `items`inner join stocks on items.Item_code=stocks.Item_code INNER join category on items.category=category.id inner join unit on items.unit_id=unit.unit_id where unit.Units like '%" & BunifuTextbox7.text & "%'"

        End If

        Dim ds As New DataSet
        Try
            If BunifuTextbox7.text = "" Then
                loadstocks()
            Else
                adtr = New MySqlDataAdapter(stringquerySS, connt.openCon)
                ds.Clear()
                If adtr.Fill(ds) Then
                    DataGridView1.DataSource = ds.Tables(0)
                    DataGridView1.Columns("id").Visible = False
                    DataGridView1.Columns("unit_id").Visible = False
                    DataGridView1.Columns("Item_code").HeaderText = "Item Code"
                    DataGridView1.Columns("Item_name").HeaderText = "Item Name"
                    DataGridView1.Columns("Description").HeaderText = "Item Description"
                    DataGridView1.Columns("category").HeaderText = "Item Category"
                    DataGridView1.Columns("Units").HeaderText = "Item Unit"
                    DataGridView1.Columns("Item_quantity").HeaderText = "Availability"
                    DataGridView1.Columns("price").HeaderText = "Item Price"

                Else
                    MsgBox("No data found")
                    BunifuTextbox7.text = ""

                End If


            End If





        Catch ex As Exception

        End Try
        connt.closeCon()
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadstocks()
        dgvdesign()
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BunifuTextbox6_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox6.OnTextChange

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            BunifuTextbox1.text = row.Cells(0).Value.ToString
            BunifuTextbox2.text = row.Cells(1).Value.ToString
            BunifuTextbox3.text = row.Cells(2).Value.ToString
            BunifuTextbox4.text = row.Cells(7).Value.ToString
            BunifuTextbox5.text = row.Cells(8).Value.ToString

            BunifuTextbox6.text = row.Cells(6).Value.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        optnStocks.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim stgqry As String = "SELECT items.Item_code,items.Item_name,items.Description,category.category,unit.Units,stocks.Item_quantity,items.price,category.id,unit.unit_id, CASE
    WHEN stocks.Item_quantity > 10 THEN 'On Stock'
    WHEN stocks.Item_quantity BETWEEN 1 and 10  THEN 'Critical'
    ELSE 'Out of Stock'
END   as Status  FROM `items`inner join stocks on items.Item_code=stocks.Item_code INNER join category on items.category=category.id inner join unit on items.unit_id=unit.unit_id where stocks.Item_quantity > 50 "
        Try

            adtr = New MySqlDataAdapter(stgqry, connt.openCon)
            dtable.Clear()
            adtr.Fill(dtable)
            DataGridView1.DataSource = dtable
                DataGridView1.Columns("id").Visible = False
                DataGridView1.Columns("unit_id").Visible = False
                DataGridView1.Columns("Item_code").HeaderText = "Item Code"
                DataGridView1.Columns("Item_name").HeaderText = "Item Name"
                DataGridView1.Columns("Description").HeaderText = "Item Description"
                DataGridView1.Columns("category").HeaderText = "Item Category"
                DataGridView1.Columns("Units").HeaderText = "Item Unit"
                DataGridView1.Columns("Item_quantity").HeaderText = "Availability"
                DataGridView1.Columns("price").HeaderText = "Item Price"








        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim stgqry As String = "SELECT items.Item_code,items.Item_name,items.Description,category.category,unit.Units,stocks.Item_quantity,items.price,category.id,unit.unit_id, CASE
    WHEN stocks.Item_quantity > 10 THEN 'On Stock'
    WHEN stocks.Item_quantity BETWEEN 1 and 10  THEN 'Critical'
    ELSE 'Out of Stock'
END   as Status  FROM `items`inner join stocks on items.Item_code=stocks.Item_code INNER join category on items.category=category.id inner join unit on items.unit_id=unit.unit_id where stocks.Item_quantity BETWEEN 1 and 10  "
        Try

            adtr = New MySqlDataAdapter(stgqry, connt.openCon)
            dtable.Clear()
            adtr.Fill(dtable)
            DataGridView1.DataSource = dtable
                DataGridView1.Columns("id").Visible = False
                DataGridView1.Columns("unit_id").Visible = False
                DataGridView1.Columns("Item_code").HeaderText = "Item Code"
                DataGridView1.Columns("Item_name").HeaderText = "Item Name"
                DataGridView1.Columns("Description").HeaderText = "Item Description"
                DataGridView1.Columns("category").HeaderText = "Item Category"
                DataGridView1.Columns("Units").HeaderText = "Item Unit"
                DataGridView1.Columns("Item_quantity").HeaderText = "Availability"
                DataGridView1.Columns("price").HeaderText = "Item Price"








        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Dim stgqry As String = "SELECT items.Item_code,items.Item_name,items.Description,category.category,unit.Units,stocks.Item_quantity,items.price,category.id,unit.unit_id, CASE
    WHEN stocks.Item_quantity > 10 THEN 'On Stock'
    WHEN stocks.Item_quantity BETWEEN 1 and 10  THEN 'Critical'
    ELSE 'Out of Stock'
END   as Status  FROM `items`inner join stocks on items.Item_code=stocks.Item_code INNER join category on items.category=category.id inner join unit on items.unit_id=unit.unit_id where stocks.Item_quantity = 0  "
        Try

            adtr = New MySqlDataAdapter(stgqry, connt.openCon)
            dtable.Clear()
            adtr.Fill(dtable)
            DataGridView1.DataSource = dtable
                DataGridView1.Columns("id").Visible = False
                DataGridView1.Columns("unit_id").Visible = False
                DataGridView1.Columns("Item_code").HeaderText = "Item Code"
                DataGridView1.Columns("Item_name").HeaderText = "Item Name"
                DataGridView1.Columns("Description").HeaderText = "Item Description"
                DataGridView1.Columns("category").HeaderText = "Item Category"
                DataGridView1.Columns("Units").HeaderText = "Item Unit"
                DataGridView1.Columns("Item_quantity").HeaderText = "Availability"
                DataGridView1.Columns("price").HeaderText = "Item Price"




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs)
        loadstocks()

    End Sub

    Private Sub BunifuTextbox7_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox7.OnTextChange


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        loadstocks()
    End Sub

    Private Sub RadioButton3_Enter(sender As Object, e As EventArgs) Handles RadioButton3.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        search()
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        MainPage.Enabled = False
        tempsales.Show()
    End Sub
End Class
