Imports MySql.Data.MySqlClient
Public Class AddSupplier
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr As MySqlDataAdapter
    Dim dtable As New DataTable
    Dim ds As New DataSet
#End Region
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuImageButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        MainPage.Enabled = True
        MainPage.loadsupplier1()
        Dsupplier.loadsup()
        Me.Close()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Dim comm As MySqlCommand

        If BunifuTextbox1.text = "Name" Or BunifuTextbox3.text = "Address" Or BunifuTextbox4.text = "Contact No." Or BunifuTextbox1.text = "" Or BunifuTextbox3.text = "" Or BunifuTextbox4.text = "" Then
            MsgBox("Field(s) must not be empty")
        Else

            Try
                comm = connt.openCon.CreateCommand
                comm.CommandText = "Insert into supplier (Name,address,ConNo)values(@n,@add,@cono);"
                comm.Parameters.AddWithValue("@n", BunifuTextbox1.text)
                comm.Parameters.AddWithValue("@add", BunifuTextbox3.text)
                comm.Parameters.AddWithValue("@cono", BunifuTextbox4.text)
                comm.ExecuteNonQuery()
                MsgBox("Successfully Added")
                BunifuTextbox1.text = "Name"
                BunifuTextbox3.text = "Address"
                BunifuTextbox4.text = "Contact No."
                Dim answer As MsgBoxResult = MsgBox("Do you want to add another data?", MsgBoxStyle.YesNo, "Insert")
                If answer = MsgBoxResult.Yes Then
                    MainPage.Enabled = True
                    MainPage.loadsupplier1()
                    Dsupplier.loadsup()
                    MainPage.Enabled = False
                Else
                    connt.closeCon()
                    MainPage.Enabled = True
                    MainPage.loadsupplier1()
                    Dsupplier.loadsup()
                    Me.Hide()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            connt.closeCon()
        End If
    End Sub
    Private Sub BunifuTextbox1_Enter(sender As Object, e As EventArgs) Handles BunifuTextbox1.Enter
        If BunifuTextbox1.text = "Name" Then
            BunifuTextbox1.text = ""

        End If
    End Sub
    Private Sub BunifuTextbox3_Enter(sender As Object, e As EventArgs) Handles BunifuTextbox3.Enter
        If BunifuTextbox3.text = "Address" Then
            BunifuTextbox3.text = ""

        End If
    End Sub
    Private Sub BunifuTextbox4_Enter(sender As Object, e As EventArgs) Handles BunifuTextbox4.Enter
        If BunifuTextbox4.text = "Contact No." Then
            BunifuTextbox4.text = ""

        End If
    End Sub
    Private Sub BunifuTextbox3_Leave(sender As Object, e As EventArgs) Handles BunifuTextbox3.Leave
        If BunifuTextbox3.text = "" Then
            BunifuTextbox3.text = "Address"

        End If
    End Sub
    Private Sub BunifuTextbox1_Leave(sender As Object, e As EventArgs) Handles BunifuTextbox1.Leave
        If BunifuTextbox1.text = "" Then
            BunifuTextbox1.text = "Name"

        End If
    End Sub
    Private Sub BunifuTextbox4_Leave(sender As Object, e As EventArgs) Handles BunifuTextbox4.Leave
        If BunifuTextbox4.text = "" Then
            BunifuTextbox4.text = "Contact No."

        End If
    End Sub

    Private Sub BunifuTextbox4_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox4.OnTextChange

    End Sub

    Private Sub BunifuTextbox4_KeyPress(sender As Object, e As EventArgs) Handles BunifuTextbox4.KeyPress

    End Sub
End Class