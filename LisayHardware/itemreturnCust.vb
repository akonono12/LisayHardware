Imports MySql.Data.MySqlClient
Public Class itemreturnCust
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3 As MySqlDataAdapter
    Dim dtable, dtable1, dtable2 As New DataTable

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        MainPage.Enabled = True
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            returnItem.Label5.Text = row.Cells(1).Value.ToString



            returnItem.Label10.Text = row.Cells(3).Value.ToString
            returnItem.Label11.Text = row.Cells(0).Value.ToString
            Dim answer As MsgBoxResult = MsgBox("Are you sure of this Invoice number: " & row.Cells(1).Value.ToString & " ?", MsgBoxStyle.YesNo, "Info")
            If answer = MsgBoxResult.Yes Then
                returnItem.Show()
                Me.Hide()
            Else
                MsgBox("Please choose another invoice no.")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim qryst2ss As String = "SELECT customer.Cust_id,payment.trans_id,payment.subtotal,payment.total,customer.Name,payment.transdate FROM `payment` INNER join customer on payment.customer_id=customer.Cust_id where payment.trans_id like '%" & BunifuTextbox1.text & "%' order by payment.Payment_id asc"
        Dim dt3 As New DataTable
        Try
            adtr = New MySqlDataAdapter(qryst2ss, connt.openCon)
            dt3.Clear()
            If adtr.Fill(dt3) Then
                DataGridView1.DataSource = dt3
                DataGridView1.Columns("Cust_id").Visible = False

                DataGridView1.Columns("trans_id").HeaderText = "Invoice Number"
                DataGridView1.Columns("subtotal").HeaderText = "Sub Total"

                DataGridView1.Columns("total").HeaderText = "Net Total"
                DataGridView1.Columns("Name").HeaderText = "Customer Name"
                DataGridView1.Columns("transdate").HeaderText = "Date Delivered"
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub ItemreturnCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSales()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Dim a, b As Double
#End Region
    Sub loadSales()
        Dim qryst2 As String = "SELECT customer.Cust_id,payment.trans_id,payment.subtotal,payment.total,customer.Name,payment.transdate FROM `payment` INNER join customer on payment.customer_id=customer.Cust_id order by payment.Payment_id asc"
        Dim dt2 As New DataTable
        Try
            adtr1 = New MySqlDataAdapter(qryst2, connt.openCon)
            dt2.Clear()
            If adtr1.Fill(dt2) Then
                DataGridView1.DataSource = dt2
                DataGridView1.Columns("Cust_id").Visible = False
                DataGridView1.Columns("trans_id").HeaderText = "Invoice Number"
                DataGridView1.Columns("subtotal").HeaderText = "Sub Total"

                DataGridView1.Columns("total").HeaderText = "Net Total"
                DataGridView1.Columns("Name").HeaderText = "Customer Name"
                DataGridView1.Columns("transdate").HeaderText = "Date Delivered"
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.Click

    End Sub
    Private Sub BunifuTextbox1_Enter(sender As Object, e As EventArgs) Handles BunifuTextbox1.Enter
        If BunifuTextbox1.text = "Invoice Number" Then
            BunifuTextbox1.text = ""
        End If
    End Sub
    Private Sub BunifuTextbox1_Leave(sender As Object, e As EventArgs) Handles BunifuTextbox1.Leave
        If BunifuTextbox1.text = "" Then
            BunifuTextbox1.text = "Invoice Number"
        End If
    End Sub
End Class