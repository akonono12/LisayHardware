Imports MySql.Data.MySqlClient
Public Class units
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr As MySqlDataAdapter
    Dim dtable As New DataTable
    Dim ds As New DataSet
#End Region
    Sub queue()
        Dim qryst As String = "SELECT * FROM `unit` ORDER BY `unit`.`unit_id` DESC"
        Dim dt2 As New DataTable
        Try
            adtr = New MySqlDataAdapter(qryst, connt.openCon)
            dt2.Clear()
            adtr.Fill(dt2)
            If dt2.Rows.Count = Nothing Then
                BunifuMaterialTextbox1.Text = "1"
            Else
                BunifuMaterialTextbox1.Text = dt2(0)(0) + 1
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub dgvload()
        Dim stgqry As String = "Select * from unit"
        Try

            adtr = New MySqlDataAdapter(stgqry, connt.openCon)
            dtable.Clear()
            If adtr.Fill(dtable) Then
                DataGridView1.DataSource = dtable
                DataGridView1.Columns("unit_id").HeaderText = "Unit ID"
                DataGridView1.Columns("Units").HeaderText = "Unit Name"
                viewP.Visible = True
                BunifuMaterialTextbox7.Text = dtable(0)(0)
                BunifuMaterialTextbox8.Text = dtable(0)(1)
                BunifuMaterialTextbox5.Text = dtable(0)(0)
                BunifuMaterialTextbox6.Text = dtable(0)(1)
                BunifuMaterialTextbox3.Text = dtable(0)(0)
                BunifuMaterialTextbox4.Text = dtable(0)(1)

            Else

            End If







        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        MainPage.Enabled = True
        Me.Close()

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Padd.Visible = True
        viewP.Visible = False
        pUpd.Visible = False
        pdel.Visible = False

    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub



    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Padd.Visible = False
        viewP.Visible = False
        pUpd.Visible = True
        pdel.Visible = False

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Padd.Visible = False
        viewP.Visible = False
        pUpd.Visible = False
        pdel.Visible = True
        pdel.BringToFront()
    End Sub

    Private Sub Cat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        queue()
        dgvload()


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            BunifuMaterialTextbox7.Text = row.Cells(0).Value.ToString
            BunifuMaterialTextbox8.Text = row.Cells(1).Value.ToString
            BunifuMaterialTextbox5.Text = row.Cells(0).Value.ToString
            BunifuMaterialTextbox6.Text = row.Cells(1).Value.ToString
            BunifuMaterialTextbox3.Text = row.Cells(0).Value.ToString
            BunifuMaterialTextbox4.Text = row.Cells(1).Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        Dim comm As MySqlCommand
        Dim answer As MsgBoxResult = MsgBox("Do you really want to add a data?", MsgBoxStyle.YesNo, "Insert")



        Try
            comm = connt.openCon.CreateCommand
            comm.CommandText = "Insert into unit (unit_id,Units)values(@id,@cat);"
            comm.Parameters.AddWithValue("@id", BunifuMaterialTextbox1.Text)
            comm.Parameters.AddWithValue("@cat", BunifuMaterialTextbox2.Text)
            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()

                BunifuMaterialTextbox2.Text = ""
                MsgBox("Successfully Added")
            Else
                connt.closeCon()
                dgvload()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
        queue()
        dgvload()
    End Sub

    Private Sub UpdBtn_Click(sender As Object, e As EventArgs) Handles UpdBtn.Click
        Dim comm As MySqlCommand
        Dim answer As MsgBoxResult = MsgBox("Do you really want to update the data?", MsgBoxStyle.YesNo, "Update")

        Try
            comm = connt.openCon.CreateCommand
            comm.CommandText = "Update unit set Units=@cat where unit_id=@id;"
            comm.Parameters.AddWithValue("@id", BunifuMaterialTextbox3.Text)
            comm.Parameters.AddWithValue("@cat", BunifuMaterialTextbox4.Text)
            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()
                MsgBox("Unit no. " & BunifuMaterialTextbox3.Text & " had successfully updated")
                BunifuMaterialTextbox3.Text = ""
                BunifuMaterialTextbox4.Text = ""
            Else
                connt.closeCon()
                dgvload()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()

        dgvload()
    End Sub

    Private Sub Delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        Dim comm As MySqlCommand
        Dim answer As MsgBoxResult = MsgBox("Do you really want to delete the data?", MsgBoxStyle.YesNo, "Delete")

        Try
            comm = connt.openCon.CreateCommand
            comm.CommandText = "delete from unit where unit_id=@id;"
            comm.Parameters.AddWithValue("@id", BunifuMaterialTextbox3.Text)

            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()
                MsgBox("Unit no. " & BunifuMaterialTextbox3.Text & " had successfully deleted")
                BunifuMaterialTextbox3.Text = ""
                BunifuMaterialTextbox4.Text = ""
            Else
                connt.closeCon()
                dgvload()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()

        dgvload()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BunifuMaterialTextbox7_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox7.OnValueChanged

    End Sub
End Class