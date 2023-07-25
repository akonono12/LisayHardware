Imports MySql.Data.MySqlClient
Public Class UnpaidCust
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1 As MySqlDataAdapter
    Dim dtable, dtable1 As New DataTable
    Dim ivn As String

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        MainPage.Enabled = True
        Me.Close()
    End Sub
#End Region
    Sub searchres()
        Dim sstts As String = ""

        sstts = "SELECT customer.Cust_id,customer.Name,customer.Address,customer.Con_no,SUM(payment.remaining) as balance FROM customer INNER join payment ON customer.Cust_id=payment.customer_id WHERE payment.status<> 1 and customer.Name like '%" & BunifuTextbox7.text & "%' group by customer.Cust_id"

        Try

            adtr = New MySqlDataAdapter(sstts, connt.openCon)
            dtable.Clear()
            If adtr.Fill(dtable) Then
                DataGridView1.DataSource = dtable

                DataGridView1.Columns("Cust_id").Visible = False
                DataGridView1.Columns("Name").HeaderText = "Name"
                DataGridView1.Columns("Address").HeaderText = "Address"
                DataGridView1.Columns("Con_no").HeaderText = "Contact Number"
                DataGridView1.Columns("balance").HeaderText = "Balance"
            Else
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub UnpaidCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadpd()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        searchres()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try


            Dim answer As MsgBoxResult = MsgBox("Add Payment.Customer: " & row.Cells(1).Value.ToString & " ?", MsgBoxStyle.YesNo, "Info")
            If answer = MsgBoxResult.Yes Then
                addpaymentcust.custid.Text = row.Cells(0).Value.ToString
                addpaymentcust.Show()
            Else
                MsgBox("Please choose a customer")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Sub loadpd()
        Dim stgqry1 As String = "SELECT customer.Cust_id,customer.Name,customer.Address,customer.Con_no,SUM(payment.remaining) as balance FROM customer INNER join payment ON customer.Cust_id=payment.customer_id WHERE payment.status<> 1 group by customer.Cust_id"
        Try

            adtr1 = New MySqlDataAdapter(stgqry1, connt.openCon)
            dtable1.Clear()
            If adtr1.Fill(dtable1) Then
                DataGridView1.DataSource = dtable1
                DataGridView1.Columns("Cust_id").Visible = False
                DataGridView1.Columns("Name").HeaderText = "Name"
                DataGridView1.Columns("Address").HeaderText = "Address"
                DataGridView1.Columns("Con_no").HeaderText = "Contact Number"
                DataGridView1.Columns("balance").HeaderText = "Balance"

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