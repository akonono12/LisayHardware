Imports MySql.Data.MySqlClient
Public Class Supplier
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1 As MySqlDataAdapter
    Dim dtable, dtable1 As New DataTable
#End Region
    Sub loadsupplier()
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

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.OnValueChanged

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        viewP.Enabled = True
        BunifuFlatButton1.Text = "Save"
        BunifuFlatButton4.Text = "Cancel"
        BunifuFlatButton2.Enabled = False
        BunifuFlatButton3.Enabled = False
        MainPage.BunifuFlatButton1.Enabled = False
        MainPage.BunifuFlatButton2.Enabled = False
        MainPage.BunifuFlatButton4.Enabled = False
        MainPage.BunifuFlatButton5.Enabled = False
        MainPage.BunifuFlatButton6.Enabled = False
        MainPage.BunifuFlatButton7.Enabled = False

    End Sub

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsupplier()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        BunifuFlatButton1.Text = ""
        BunifuFlatButton4.Text = ""
        viewP.Enabled = False
        BunifuFlatButton2.Enabled = True
        BunifuFlatButton3.Enabled = True
        MainPage.BunifuFlatButton1.Enabled = True
        MainPage.BunifuFlatButton2.Enabled = True
        MainPage.BunifuFlatButton4.Enabled = True
        MainPage.BunifuFlatButton5.Enabled = True
        MainPage.BunifuFlatButton6.Enabled = True
        MainPage.BunifuFlatButton7.Enabled = True
    End Sub

    Private Sub TpshardwareDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles TpshardwareDataSetBindingSource.CurrentChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            BunifuMaterialTextbox8.Text = row.Cells(0).Value.ToString
            BunifuMaterialTextbox7.Text = row.Cells(1).Value.ToString
            BunifuMaterialTextbox1.Text = row.Cells(2).Value.ToString
            BunifuMaterialTextbox2.Text = row.Cells(3).Value.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim comm As MySqlCommand
        Dim answer As MsgBoxResult = MsgBox("Do you really want to delete the data?", MsgBoxStyle.YesNo, "Delete")

        Try
            comm = connt.openCon.CreateCommand
            comm.CommandText = "delete from supplier where sup_id=@id;"
            comm.Parameters.AddWithValue("@id", BunifuMaterialTextbox8.Text)

            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()
                MsgBox("Supplier no. " & BunifuMaterialTextbox8.Text & " had successfully deleted")
                connt.closeCon()
                BunifuMaterialTextbox8.Text = ""
                BunifuMaterialTextbox7.Text = ""
                BunifuMaterialTextbox2.Text = ""
                BunifuMaterialTextbox1.Text = ""
                loadsupplier()

            Else
                connt.closeCon()
                loadsupplier()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim comm As MySqlCommand
        Dim answer As MsgBoxResult = MsgBox("Do you really want to update the data?", MsgBoxStyle.YesNo, "Update")

        Try
            comm = connt.openCon.CreateCommand
            comm.CommandText = "Update  supplier  set Name=@n,address=@add,ConNo=@con where sup_id=@id;"
            comm.Parameters.AddWithValue("@id", BunifuMaterialTextbox8.Text)
            comm.Parameters.AddWithValue("@n", BunifuMaterialTextbox7.Text)
            comm.Parameters.AddWithValue("@add", BunifuMaterialTextbox1.Text)
            comm.Parameters.AddWithValue("@con", BunifuMaterialTextbox2.Text)

            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()
                MsgBox("Supplier no. " & BunifuMaterialTextbox8.Text & " had successfully updated")
                connt.closeCon()
                BunifuMaterialTextbox8.Text = ""
                BunifuMaterialTextbox7.Text = ""
                BunifuMaterialTextbox2.Text = ""
                BunifuMaterialTextbox1.Text = ""
                loadsupplier()

            Else
                connt.closeCon()
                loadsupplier()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stgqry As String = "SELECT * from supplier where name like '%" & BunifuTextbox1.text & "%'"
        Dim ds As New DataSet
        Try
            If BunifuTextbox1.text = "Search by Name" Or BunifuTextbox1.text = "" Then
                loadsupplier()
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

    Private Sub BunifuTileButton5_Click(sender As Object, e As EventArgs) Handles BunifuTileButton5.Click
        MainPage.Enabled = False
        MsgBox("Please enter the Delivery TR no.")
        TRno.Show()
    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        PaidStocks.Show()
        MainPage.Enabled = False
    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        Unpaidstocks.Show()
        MainPage.Enabled = False

    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        MainPage.Enabled = False
        MsgBox("Please Select the Transaction No.")
        itemReturn.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
