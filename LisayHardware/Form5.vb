Imports MySql.Data.MySqlClient
Public Class Form5
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3, adtr4, adtr5 As MySqlDataAdapter
    Dim dtable, dtable1, dtable2, dtable3, dtable4, dtable5 As New DataTable

#End Region
    Sub dailyreports()
        Dim qryst2 As String = "SELECT supplier.Name, devl_trans.trans_id, devl_trans.nettotal, SUM(devl_trans.nettotal) AS total,IF(`devl_trans`.`status`= 1, 'Paid', 'Unpaid') as Status, devl_trans.datedevl
FROM     devl_trans INNER JOIN
                  supplier ON devl_trans.supplier_id = supplier.sup_id
                  where date(devl_trans.datedevl)=CURDATE()
GROUP BY devl_trans.datedevl"
        Dim dt2 As New DataTable
        Try
            adtr1 = New MySqlDataAdapter(qryst2, connt.openCon)
            dt2.Clear()
            If adtr1.Fill(dt2) Then
                DataGridView1.DataSource = dt2
                DataGridView1.Columns("total").Visible = False
                DataGridView1.Columns("trans_id").HeaderText = "TR Number"
                DataGridView1.Columns("nettotal").HeaderText = "Total"

                DataGridView1.Columns("datedevl").HeaderText = "Date Delivered"
                DataGridView1.Columns("Name").HeaderText = "Supplier Name"

            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dailyreports()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class