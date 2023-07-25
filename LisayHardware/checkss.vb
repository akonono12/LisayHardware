Imports MySql.Data.MySqlClient
Public Class checkss
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3, adtr7, adtr8 As MySqlDataAdapter

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Dim dtable, dtable1, dtable2, dtable3, dtable4, dtable7, dtable8 As New DataTable
#End Region
    Sub loadcheck()
        Dim stgqry1 As String = "SELECT checks.Checkno,checks.Amount,DateInputted,supplier.Name as Supplier FROM `checks` inner join supplier on checks.supid=supplier.sup_id WHERE date(checks.dateTime)=curdate()"
        Try

            adtr = New MySqlDataAdapter(stgqry1, connt.openCon)
            dtable.Clear()
            If adtr.Fill(dtable) Then

                DataGridView1.DataSource = dtable

                DataGridView1.Columns("Checkno").HeaderText = "Check No."
                DataGridView1.Columns("Amount").HeaderText = "Check Amount"
                DataGridView1.Columns("DateInputted").HeaderText = "Date Inputted"
                DataGridView1.Columns("Supplier").HeaderText = "Supplier"
            Else

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()

    End Sub
    Sub checksums()
        Dim stgqry3 As String = "SELECT sum(checks.Amount) as tamount FROM `checks` WHERE date(checks.dateTime)=curdate()"
        Try

            adtr1 = New MySqlDataAdapter(stgqry3, connt.openCon)
            dtable1.Clear()
            If adtr1.Fill(dtable1) Then
                tamnt.Text = "Php " & dtable1(0)(0)


            Else

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()

    End Sub

    Private Sub Checkss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcheck()
        checksums()
    End Sub
End Class