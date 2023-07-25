Imports MySql.Data.MySqlClient
Public Class cat
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1 As MySqlDataAdapter
    Dim dtable, dtable1 As New DataTable
    Dim ds As New DataSet
#End Region
    Sub queue()
        Dim qryst As String = "SELECT * FROM `category` ORDER BY `category`.`id` DESC"
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
        Dim stgqryss1 As String = "SELECT `id`, `category` FROM `category`"
        Try

            adtr1 = New MySqlDataAdapter(stgqryss1, connt.openCon)
            dtable1.Clear()
            If adtr1.Fill(dtable1) Then

                If Not IsDBNull(dtable1) Then
                    DataGridView1.DataSource = dtable1
                    DataGridView1.Columns("id").HeaderText = "Category ID"
                    DataGridView1.Columns("category").HeaderText = "Category Name"
                    viewP.Visible = True
                    BunifuMaterialTextbox7.Text = dtable1(0)(0)
                    BunifuMaterialTextbox8.Text = dtable1(0)(1)
                    BunifuMaterialTextbox5.Text = dtable1(0)(0)
                    BunifuMaterialTextbox6.Text = dtable1(0)(1)
                    BunifuMaterialTextbox3.Text = dtable1(0)(0)
                    BunifuMaterialTextbox4.Text = dtable1(0)(1)
                Else


                End If


            Else

            End If







        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)

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
            comm.CommandText = "Insert into category (id,category)values(@id,@cat);"
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
            comm.CommandText = "Update category set category=@cat where id=@id;"
            comm.Parameters.AddWithValue("@id", BunifuMaterialTextbox3.Text)
            comm.Parameters.AddWithValue("@cat", BunifuMaterialTextbox4.Text)
            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()
                MsgBox("Catergory no. " & BunifuMaterialTextbox3.Text & " had successfully updated")
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
            comm.CommandText = "delete from category where id=@id;"
            comm.Parameters.AddWithValue("@id", BunifuMaterialTextbox3.Text)

            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()
                MsgBox("Catergory no. " & BunifuMaterialTextbox3.Text & " had successfully deleted")
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
End Class