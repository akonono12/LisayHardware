Imports MySql.Data.MySqlClient
Public Class PaidStocks
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1 As MySqlDataAdapter
    Dim dtable, dtable1 As New DataTable

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        MainPage.Enabled = True
        Me.Close()
    End Sub
#End Region
    Sub searchss()
        Dim sstt As String = ""
        If ComboBox1.SelectedIndex = 0 Then
            sstt = "SELECT devl_trans.trans_id,devl_trans.subtotal,devl_trans.Discount,devl_trans.nettotal,supplier.sup_id,supplier.Name,IF(`devl_trans`.`status`= 1, 'Paid', 'Unpaid') as status FROM `devl_trans` INNER join supplier on devl_trans.supplier_id=supplier.sup_id where  devl_trans.trans_id like '%" & BunifuTextbox7.text & "%'"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            sstt = "SELECT devl_trans.trans_id,devl_trans.subtotal,devl_trans.Discount,devl_trans.nettotal,supplier.sup_id,supplier.Name,IF(`devl_trans`.`status`= 1, 'Paid', 'Unpaid') as status FROM `devl_trans` INNER join supplier on devl_trans.supplier_id=supplier.sup_id where  supplier.Name  like '%" & BunifuTextbox7.text & "%'"
        End If
        Try

            adtr = New MySqlDataAdapter(sstt, connt.openCon)
            dtable.Clear()
            If adtr.Fill(dtable) Then
                DataGridView1.DataSource = dtable

                DataGridView1.Columns("trans_id").HeaderText = "TR Number"
                DataGridView1.Columns("subtotal").HeaderText = "Sub Total"
                DataGridView1.Columns("Discount").HeaderText = "Discount"
                DataGridView1.Columns("nettotal").HeaderText = "Net Total"
                DataGridView1.Columns("status").HeaderText = "Status"
                DataGridView1.Columns("sup_id").Visible = False
                DataGridView1.Columns("Name").HeaderText = "Supplier"
            Else
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        searchss()
    End Sub

    Private Sub PaidStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadpd()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            epndds.Label1.Text = row.Cells(0).Value


            Dim answer As MsgBoxResult = MsgBox("Do you want to expand this TR no: " & row.Cells(0).Value.ToString & " ?", MsgBoxStyle.YesNo, "Info")
            If answer = MsgBoxResult.Yes Then
                epndds.Show()

            Else
                MsgBox("Please choose another TR no. to expand")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        loadpd()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim stgqry1 As String = "SELECT devl_trans.trans_id,devl_trans.subtotal,devl_trans.Discount,devl_trans.nettotal,supplier.sup_id,supplier.Name,IF(`devl_trans`.`status`= 1, 'Paid', 'Unpaid') as status FROM `devl_trans` INNER join supplier on devl_trans.supplier_id=supplier.sup_id where `devl_trans`.`status`= 1 "
        Try

            adtr1 = New MySqlDataAdapter(stgqry1, connt.openCon)
            dtable1.Clear()
            If adtr1.Fill(dtable1) Then
                DataGridView1.DataSource = dtable1

                DataGridView1.Columns("trans_id").HeaderText = "TR Number"
                DataGridView1.Columns("subtotal").HeaderText = "Sub Total"
                DataGridView1.Columns("Discount").HeaderText = "Discount"
                DataGridView1.Columns("nettotal").HeaderText = "Net Total"
                DataGridView1.Columns("status").HeaderText = "Status"
                DataGridView1.Columns("sup_id").Visible = False
                DataGridView1.Columns("Name").HeaderText = "Supplier"
            Else
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim stgqry1 As String = "SELECT devl_trans.trans_id,devl_trans.subtotal,devl_trans.Discount,devl_trans.nettotal,supplier.sup_id,supplier.Name,IF(`devl_trans`.`status`= 1, 'Paid', 'Unpaid') as status FROM `devl_trans` INNER join supplier on devl_trans.supplier_id=supplier.sup_id where `devl_trans`.`status`= 0 "
        Try

            adtr1 = New MySqlDataAdapter(stgqry1, connt.openCon)
            dtable1.Clear()
            If adtr1.Fill(dtable1) Then
                DataGridView1.DataSource = dtable1

                DataGridView1.Columns("trans_id").HeaderText = "TR Number"
                DataGridView1.Columns("subtotal").HeaderText = "Sub Total"
                DataGridView1.Columns("Discount").HeaderText = "Discount"
                DataGridView1.Columns("nettotal").HeaderText = "Net Total"
                DataGridView1.Columns("status").HeaderText = "Status"
                DataGridView1.Columns("sup_id").Visible = False
                DataGridView1.Columns("Name").HeaderText = "Supplier"
            Else
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Sub loadpd()
        Dim stgqry1 As String = "SELECT devl_trans.trans_id,devl_trans.subtotal,devl_trans.Discount,devl_trans.nettotal,supplier.sup_id,supplier.Name,IF(`devl_trans`.`status`= 1, 'Paid', 'Unpaid') as status FROM `devl_trans` INNER join supplier on devl_trans.supplier_id=supplier.sup_id "
        Try

            adtr1 = New MySqlDataAdapter(stgqry1, connt.openCon)
            dtable1.Clear()
            If adtr1.Fill(dtable1) Then
                DataGridView1.DataSource = dtable1

                DataGridView1.Columns("trans_id").HeaderText = "TR Number"
                DataGridView1.Columns("subtotal").HeaderText = "Sub Total"
                DataGridView1.Columns("Discount").HeaderText = "Discount"
                DataGridView1.Columns("nettotal").HeaderText = "Net Total"
                DataGridView1.Columns("status").HeaderText = "Status"
                DataGridView1.Columns("sup_id").Visible = False
                DataGridView1.Columns("Name").HeaderText = "Supplier"
            Else
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class