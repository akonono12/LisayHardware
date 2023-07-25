Imports MySql.Data.MySqlClient
Public Class cheques
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3, adtr7 As MySqlDataAdapter
    Dim dtable, dtable1, dtable2, dtable3, dtable4, dtable7 As New DataTable
#End Region
    Sub loadch()
        Dim querystringg As String = "SELECT * FROM `checks`"
        Try

            adtr = New MySqlDataAdapter(querystringg, connt.openCon)
            dtable.Clear()
            If adtr.Fill(dtable) Then
                DataGridView1.DataSource = dtable

                DataGridView1.Columns("Checkno").HeaderText = "Cheque Number"
                DataGridView1.Columns("Amount").HeaderText = "Amount"
                DataGridView1.Columns("dateTime").HeaderText = "Date"
                DataGridView1.Columns("	trno").HeaderText = "TR No."

            Else

            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.Close()

    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click

    End Sub
End Class