Imports MySql.Data.MySqlClient
Public Class itemedit
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3 As MySqlDataAdapter
    Dim dtable, dtable1, dtable2 As New DataTable
    Dim a, b As Double

    Private Sub Itmqua_KeyPress(sender As Object, e As KeyPressEventArgs) Handles itmqua.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
        AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.OnValueChanged

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim comm As MySqlCommand
        Dim answer As MsgBoxResult = MsgBox("Do you really want to delete the data?", MsgBoxStyle.YesNo, "Delete")

        Try
            comm = connt.openCon.CreateCommand
            comm.CommandText = "delete from tempcart where Item_code=@id;"
            comm.Parameters.AddWithValue("@id", BunifuMaterialTextbox7.Text)

            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()
                MsgBox("item no. " & BunifuMaterialTextbox7.Text & " had successfully deleted")
                connt.closeCon()

                BunifuMaterialTextbox7.Text = ""
                BunifuMaterialTextbox1.Text = ""
                BunifuMaterialTextbox2.Text = ""
                POS.calculate()
                POS.loadcart()
                Me.Hide()

            Else
                connt.closeCon()
                POS.calculate()
                POS.loadcart()
                Me.Hide()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub Itemedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region
    Dim dsdsd, ddd As Integer

    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.OnValueChanged



    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim comm As MySqlCommand
        Dim answer As MsgBoxResult = MsgBox("Do you really want to update the data?", MsgBoxStyle.YesNo, "Delete")

        Try
            comm = connt.openCon.CreateCommand
            comm.CommandText = "UPDATE tempcart SET item_quantity=@quantity,price=@price WHERE Item_code=@code;"

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
                POS.calculate()
                POS.loadcart()
                Me.Hide()

            Else
                connt.closeCon()
                POS.calculate()
                POS.loadcart()
                Me.Hide()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
End Class