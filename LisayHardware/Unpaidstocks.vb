Imports MySql.Data.MySqlClient
Public Class Unpaidstocks
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1 As MySqlDataAdapter
    Dim dtable, dtable1 As New DataTable
#End Region

    Sub searchsss()
        Dim sstt As String = ""


        sstt = "SELECT supplier.sup_id,supplier.Name,supplier.address,supplier.ConNo,sUM(devl_trans.remaining) as Remainingbal FROM `devl_trans` inner join supplier on devl_trans.supplier_id=supplier.sup_id where devl_trans.status<>1  and supplier.Name  like '%" & BunifuTextbox7.text & "%' group by supplier.sup_id"

        Try

            adtr = New MySqlDataAdapter(sstt, connt.openCon)
            dtable.Clear()
            If adtr.Fill(dtable) Then
                DataGridView1.DataSource = dtable

                DataGridView1.Columns("sup_id").Visible = False
                DataGridView1.Columns("Name").HeaderText = "Name"
                DataGridView1.Columns("address").HeaderText = "Address"
                DataGridView1.Columns("ConNo").HeaderText = "Contact Number"
                DataGridView1.Columns("Remainingbal").HeaderText = "Unpaid Debt"
            Else
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub loadupd()
        Dim stgqry1 As String = "SELECT supplier.sup_id,supplier.Name,supplier.address,supplier.ConNo,sUM(devl_trans.remaining) as Remainingbal FROM `devl_trans` inner join supplier on devl_trans.supplier_id=supplier.sup_id where devl_trans.status<>1 group by supplier.sup_id"
        Try

            adtr1 = New MySqlDataAdapter(stgqry1, connt.openCon)
            dtable1.Clear()
            If adtr1.Fill(dtable1) Then
                DataGridView1.DataSource = dtable1

                DataGridView1.Columns("sup_id").Visible = False
                DataGridView1.Columns("Name").HeaderText = "Name"
                DataGridView1.Columns("address").HeaderText = "Address"
                DataGridView1.Columns("ConNo").HeaderText = "Contact Number"
                DataGridView1.Columns("Remainingbal").HeaderText = "Unpaid Debt"
            Else
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        searchsss()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try


            Dim answer As MsgBoxResult = MsgBox("Pay Supplier.Supplier: " & row.Cells(1).Value.ToString & " ?", MsgBoxStyle.YesNo, "Info")
            If answer = MsgBoxResult.Yes Then
                updateDelivery.supid.Text = row.Cells(0).Value.ToString
                updateDelivery.Show()
            Else
                MsgBox("Please choose a customer")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        MainPage.Enabled = True
        Me.Close()

    End Sub

    Private Sub Unpaidstocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadupd()
    End Sub
End Class