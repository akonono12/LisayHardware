Imports MySql.Data.MySqlClient

Public Class Customer
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtrs As MySqlDataAdapter
    Dim dtable, dtables As New DataTable
#End Region
    Sub loadcustomer()
        Dim stgqryss As String = "SELECT * from customer"
        Try

            adtrs = New MySqlDataAdapter(stgqryss, connt.openCon)
            dtables.Clear()
            If adtrs.Fill(dtables) Then
                DataGridView1.DataSource = dtables
                DataGridView1.Columns("Payment_Balance").Visible = False
                DataGridView1.Columns("Cust_id").HeaderText = "Customer ID"
                DataGridView1.Columns("Name").HeaderText = "Name"
                DataGridView1.Columns("Address").HeaderText = "Address"
                DataGridView1.Columns("Con_no").HeaderText = "Contact No."


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

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        viewP.Enabled = True
        BunifuFlatButton1.Text = "Save"
        BunifuFlatButton4.Text = "Cancel"
        BunifuFlatButton2.Enabled = False
        BunifuFlatButton3.Enabled = False
        MainPage.BunifuFlatButton1.Enabled = False
        MainPage.BunifuFlatButton2.Enabled = False
        MainPage.BunifuFlatButton4.Enabled = False
        MainPage.BunifuFlatButton3.Enabled = False
        MainPage.BunifuFlatButton6.Enabled = False
        MainPage.BunifuFlatButton7.Enabled = False

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
        MainPage.BunifuFlatButton3.Enabled = True
        MainPage.BunifuFlatButton6.Enabled = True
        MainPage.BunifuFlatButton7.Enabled = True
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcustomer()
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
            comm.CommandText = "delete from customer where Cust_id=@id;"
            comm.Parameters.AddWithValue("@id", BunifuMaterialTextbox8.Text)

            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()
                MsgBox("Customer no. " & BunifuMaterialTextbox8.Text & " had successfully deleted")
                connt.closeCon()
                BunifuMaterialTextbox8.Text = ""
                BunifuMaterialTextbox7.Text = ""
                BunifuMaterialTextbox1.Text = ""
                BunifuMaterialTextbox2.Text = ""
                loadcustomer()

            Else
                connt.closeCon()
                loadcustomer()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim comm As MySqlCommand
        Dim answer As MsgBoxResult = MsgBox("Do you really want to update the data?", MsgBoxStyle.YesNo, "Delete")

        Try
            comm = connt.openCon.CreateCommand
            comm.CommandText = "Update  customer  set Name=@n,Address=@add,Con_no=@con where Cust_id=@id;"
            comm.Parameters.AddWithValue("@id", BunifuMaterialTextbox8.Text)
            comm.Parameters.AddWithValue("@n", BunifuMaterialTextbox7.Text)
            comm.Parameters.AddWithValue("@add", BunifuMaterialTextbox1.Text)
            comm.Parameters.AddWithValue("@con", BunifuMaterialTextbox2.Text)

            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()
                MsgBox("Customer no. " & BunifuMaterialTextbox8.Text & " had successfully updated")
                connt.closeCon()
                BunifuMaterialTextbox8.Text = ""
                BunifuMaterialTextbox7.Text = ""
                BunifuMaterialTextbox2.Text = ""
                BunifuMaterialTextbox1.Text = ""
                loadcustomer()

            Else
                connt.closeCon()
                loadcustomer()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuTextbox1_OnTextChange_1(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stgqry As String = "SELECT * from customer where Name like '%" & BunifuTextbox1.text & "%'"
        Dim ds1 As New DataSet
        Try
            If BunifuTextbox1.text = "Search by Name" Or BunifuTextbox1.text = "" Then
                loadcustomer()
            Else
                adtr = New MySqlDataAdapter(stgqry, connt.openCon)
                ds1.Clear()
                If adtr.Fill(ds1) Then
                    Me.DataGridView1.DataSource = ds1.Tables(0)

                    Me.DataGridView1.Columns("Cust_id").HeaderText = "Customer ID"
                    Me.DataGridView1.Columns("Name").HeaderText = "Name"
                    Me.DataGridView1.Columns("Address").HeaderText = "Address"
                    Me.DataGridView1.Columns("Con_no").HeaderText = "Contact No."
                Else
                    MsgBox("No data found")
                    BunifuTextbox1.text = "Search by Name"
                End If

            End If





        Catch ex As Exception

        End Try
        connt.closeCon()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        paidtrans.Show()
        MainPage.Enabled = True
    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        UnpaidCust.Show()
        MainPage.Enabled = False
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        MainPage.Enabled = False
        MsgBox("Please Select the Invoice No.")

        itemreturnCust.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BunifuTileButton5_Click(sender As Object, e As EventArgs) Handles BunifuTileButton5.Click
        POS.GroupBox3.Text = "Welcome User ID: " & MainPage.loginId.Text
        POS.Label20.Text = MainPage.LoginName.Text
        POS.Label21.Text = MainPage.loginId.Text
        MainPage.Enabled = False
        MsgBox("Please Enter your Name")
        Form1.Show()
    End Sub
End Class
