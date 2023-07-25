Imports MySql.Data.MySqlClient

Public Class itemReturn
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3 As MySqlDataAdapter
    Dim dtable, dtable1, dtable2 As New DataTable
    Dim a, b As Double

    Private Sub ItemReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDelivery()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            frmdelves.Label5.Text = row.Cells(0).Value.ToString

            frmdelves.Label1.Text = row.Cells(1).Value.ToString
            frmdelves.Label19.Text = row.Cells(2).Value.ToString
            frmdelves.Label10.Text = row.Cells(3).Value.ToString
            frmdelves.Label11.Text = row.Cells(6).Value.ToString
            Dim answer As MsgBoxResult = MsgBox("Are you sure of this Tr no: " & row.Cells(0).Value.ToString & " ?", MsgBoxStyle.YesNo, "Info")
            If answer = MsgBoxResult.Yes Then
                frmdelves.Show()
                Me.Hide()
            Else
                MsgBox("Please choose another Tr no.")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim qryst2s As String = "SELECT devl_trans.trans_id,devl_trans.subtotal,devl_trans.Discount,devl_trans.nettotal,supplier.Name,devl_trans.datedevl,devl_trans.supplier_id FROM `devl_trans` INNER join supplier on devl_trans.supplier_id=supplier.sup_id where devl_trans.trans_id like '%" & BunifuTextbox1.text & "%' ORDER BY `devl_trans`.`trans_id` ASC"
        Dim dt2s As New DataTable
        Try
            adtr = New MySqlDataAdapter(qryst2s, connt.openCon)
            dt2s.Clear()
            If adtr.Fill(dt2s) Then
                DataGridView1.DataSource = dt2s
                DataGridView1.Columns("supplier_id").Visible = False
                DataGridView1.Columns("trans_id").HeaderText = "Delivery ID"
                DataGridView1.Columns("subtotal").HeaderText = "Sub Total"
                DataGridView1.Columns("Discount").HeaderText = "Discount"
                DataGridView1.Columns("nettotal").HeaderText = "Net Total"
                DataGridView1.Columns("Name").HeaderText = "Supplier Name"
                DataGridView1.Columns("datedevl").HeaderText = "Date Delivered"
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.Click

    End Sub
#End Region
    Sub loadDelivery()
        Dim qryst2 As String = "SELECT devl_trans.trans_id,devl_trans.subtotal,devl_trans.Discount,devl_trans.nettotal,supplier.Name,devl_trans.datedevl,devl_trans.supplier_id FROM `devl_trans` INNER join supplier on devl_trans.supplier_id=supplier.sup_id ORDER BY `devl_trans`.`trans_id` ASC"
        Dim dt2 As New DataTable
        Try
            adtr1 = New MySqlDataAdapter(qryst2, connt.openCon)
            dt2.Clear()
            If adtr1.Fill(dt2) Then
                DataGridView1.DataSource = dt2
                DataGridView1.Columns("supplier_id").Visible = False
                DataGridView1.Columns("trans_id").HeaderText = "Transaction Number"
                DataGridView1.Columns("subtotal").HeaderText = "Sub Total"
                DataGridView1.Columns("Discount").HeaderText = "Discount"
                DataGridView1.Columns("nettotal").HeaderText = "Net Total"
                DataGridView1.Columns("Name").HeaderText = "Supplier Name"
                DataGridView1.Columns("datedevl").HeaderText = "Date Delivered"
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        MainPage.Enabled = True
        Me.Hide()

    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange

    End Sub
    Private Sub BunifuTextbox1_Enter(sender As Object, e As EventArgs) Handles BunifuTextbox1.Enter
        If BunifuTextbox1.text = "TR Number" Then
            BunifuTextbox1.text = ""
        End If
    End Sub
    Private Sub BunifuTextbox1_Leave(sender As Object, e As EventArgs) Handles BunifuTextbox1.Leave
        If BunifuTextbox1.text = "" Then
            BunifuTextbox1.text = "TR Number"
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class