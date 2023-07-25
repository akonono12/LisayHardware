Imports MySql.Data.MySqlClient
Public Class selectasupplier
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1 As MySqlDataAdapter
    Dim dtable, dtable1 As New DataTable

    Private Sub Selectasupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsuppliers()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stgqry As String = "SELECT * from supplier where name like '%" & BunifuTextbox1.text & "%'"
        Dim ds As New DataSet
        Try
            If BunifuTextbox1.text = "Search by Name" Or BunifuTextbox1.text = "" Then
                loadsuppliers()
            Else
                adtr = New MySqlDataAdapter(stgqry, connt.openCon)
                ds.Clear()
                If adtr.Fill(ds) Then
                    DataGridView1.DataSource = ds.Tables(0)
                    DataGridView1.Columns("sup_id").HeaderText = "Supplier ID"
                    DataGridView1.Columns("Name").HeaderText = "Name"
                    DataGridView1.Columns("address").HeaderText = "Address"
                    DataGridView1.Columns("ConNo").HeaderText = "Contact No."

                Else
                    MsgBox("No data found")
                    BunifuTextbox1.text = "Search by Name"

                End If


            End If





        Catch ex As Exception

        End Try
        connt.closeCon()
    End Sub
#End Region


    Sub loadsuppliers()
        Dim stgqry1 As String = "SELECT * from supplier"
        Try

            adtr1 = New MySqlDataAdapter(stgqry1, connt.openCon)
            dtable1.Clear()
            If adtr1.Fill(dtable1) Then
                DataGridView1.DataSource = dtable1

                DataGridView1.Columns("sup_id").HeaderText = "Supplier ID"
                DataGridView1.Columns("Name").HeaderText = "Name"
                DataGridView1.Columns("address").HeaderText = "Address"
                DataGridView1.Columns("ConNo").HeaderText = "Contact No."

            Else
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        MainPage.Enabled = True
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            checkstemp.supid.Text = row.Cells(0).Value.ToString
            checkstemp.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
End Class