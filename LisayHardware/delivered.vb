Imports MySql.Data.MySqlClient
Public Class delivered
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3 As MySqlDataAdapter
    Dim dtable, dtable1, dtable2 As New DataTable
    Dim a, b As Double
#End Region
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim comm As MySqlCommand
        Dim answer As MsgBoxResult = MsgBox("Do you really want to update the data?", MsgBoxStyle.YesNo, "Delete")

        Try
            comm = connt.openCon.CreateCommand
            comm.CommandText = "UPDATE tempdelivery SET item_quantity=@quantity,supplier_price=@price WHERE Item_code=@code;"

            comm.Parameters.AddWithValue("@code", BunifuMaterialTextbox7.Text)
            comm.Parameters.AddWithValue("@quantity", BunifuMaterialTextbox1.Text)
            comm.Parameters.AddWithValue("@price", BunifuMaterialTextbox2.Text)

            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()
                MsgBox("Item no. " & BunifuMaterialTextbox7.Text & " had successfully updated")
                connt.closeCon()

                BunifuMaterialTextbox7.Text = ""
                BunifuMaterialTextbox2.Text = ""
                BunifuMaterialTextbox1.Text = ""
                FrmSupDelv.calculate()
                FrmSupDelv.loadcart()
                Me.Hide()

            Else
                connt.closeCon()
                FrmSupDelv.calculate()
                FrmSupDelv.loadcart()
                Me.Hide()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim comm As MySqlCommand
        Dim answer As MsgBoxResult = MsgBox("Do you really want to delete the data?", MsgBoxStyle.YesNo, "Delete")

        Try
            comm = connt.openCon.CreateCommand
            comm.CommandText = "delete from tempdelivery where Item_code=@id;"
            comm.Parameters.AddWithValue("@id", BunifuMaterialTextbox7.Text)

            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()
                MsgBox("item no. " & BunifuMaterialTextbox7.Text & " had successfully deleted")
                connt.closeCon()

                BunifuMaterialTextbox7.Text = ""
                BunifuMaterialTextbox1.Text = ""
                BunifuMaterialTextbox2.Text = ""
                FrmSupDelv.calculate()
                FrmSupDelv.loadcart()
                Me.Hide()

            Else
                connt.closeCon()
                FrmSupDelv.calculate()
                FrmSupDelv.loadcart()
                Me.Hide()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
End Class