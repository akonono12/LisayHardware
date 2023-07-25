Imports MySql.Data.MySqlClient
Public Class AddItem
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr As MySqlDataAdapter
    Dim dtable As New DataTable
    Dim ds As New DataSet
#End Region
    Sub queuecode()
        Dim qryst As String = "SELECT * FROM `items` where Item_code='" & BunifuTextbox1.text & "'"
        Dim dt2 As New DataTable
        Try
            adtr = New MySqlDataAdapter(qryst, connt.openCon)
            dt2.Clear()
            adtr.Fill(dt2)
            If dt2.Rows.Count = Nothing Then


            Else
                MsgBox("Already had in the database")

                BunifuTextbox1.text = ""
                connt.closeCon()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub loadcategory()
        Dim qryst As String = "SELECT * FROM `category`"
        Dim dt2 As New DataTable
        Try
            adtr = New MySqlDataAdapter(qryst, connt.openCon)
            dt2.Clear()
            adtr.Fill(dt2)
            ComboBox1.DataSource = dt2
            ComboBox1.ValueMember = "id"
            ComboBox1.DisplayMember = "category"
            If BunifuFlatButton4.Visible = True Then
                ComboBox1.SelectedIndex = -1
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Sub loadunit()
        Dim qryst As String = "SELECT * FROM `unit`"
        Dim dt2 As New DataTable
        Try
            adtr = New MySqlDataAdapter(qryst, connt.openCon)
            dt2.Clear()
            adtr.Fill(dt2)
            ComboBox2.DataSource = dt2
            ComboBox2.ValueMember = "unit_id"
            ComboBox2.DisplayMember = "Units"

            If BunifuFlatButton4.Visible = True Then
                ComboBox2.SelectedIndex = -1
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

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub AddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If BunifuFlatButton4.Visible = True Then

        End If

        loadcategory()
        loadunit()

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        queuecode()

        If BunifuTextbox1.text = "" Or BunifuTextbox2.text = "" Or TextBox1.Text = "" Or BunifuMaterialTextbox1.Text = "" Or BunifuMaterialTextbox1.Text = 0 Or ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Then
            MsgBox("Field(s) must not be empty")
        Else
            Dim comm, comm1 As MySqlCommand

            Try
                comm = connt.openCon.CreateCommand
                comm.CommandText = "Insert into items(Item_code,Item_name,Description,category,unit_id,price)values(@ic,@in,@desc,@cat,@unit,@price);"

                comm.Parameters.AddWithValue("@ic", BunifuTextbox1.text)
                comm.Parameters.AddWithValue("@in", BunifuTextbox2.text)
                comm.Parameters.AddWithValue("@desc", TextBox1.Text)
                comm.Parameters.AddWithValue("@price", BunifuMaterialTextbox1.Text)
                comm.Parameters.AddWithValue("@cat", ComboBox1.SelectedValue)
                comm.Parameters.AddWithValue("@unit", ComboBox2.SelectedValue)
                comm.ExecuteNonQuery()
                connt.closeCon()
                comm1 = connt.openCon.CreateCommand
                comm1.CommandText = "INSERT INTO stocks(Item_code)values(@ic);"
                comm1.Parameters.AddWithValue("@ic", BunifuTextbox1.text)
                comm1.ExecuteNonQuery()
                MsgBox("Successfully Added")
                connt.closeCon()

                BunifuTextbox2.text = ""
                BunifuMaterialTextbox1.Text = ""
                TextBox1.Text = ""
                ComboBox1.SelectedIndex = -1
                ComboBox2.SelectedIndex = -1
                Dim answer As MsgBoxResult = MsgBox("Do you want to add another data?", MsgBoxStyle.YesNo, "Insert")
                If answer = MsgBoxResult.Yes Then
                    connt.closeCon()
                    MainPage.loadstocks1()
                Else
                    connt.closeCon()
                    MainPage.Enabled = True
                    MainPage.loadstocks1()
                    Me.Hide()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub BunifuTextbox4_OnTextChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim comm As MySqlCommand
        Dim answer As MsgBoxResult = MsgBox("Do you really want to update the data?", MsgBoxStyle.YesNo, "Delete")

        Try
            comm = connt.openCon.CreateCommand
            comm.CommandText = "update items set Item_name=@in,Description=@desc,category=@cat,unit_id=@unit,price=@price where Item_code=@ic;"
            comm.Parameters.AddWithValue("@ic", BunifuTextbox1.text)
            comm.Parameters.AddWithValue("@in", BunifuTextbox2.text)
            comm.Parameters.AddWithValue("@desc", TextBox1.Text)
            comm.Parameters.AddWithValue("@price", BunifuMaterialTextbox1.Text)
            comm.Parameters.AddWithValue("@cat", ComboBox1.SelectedValue)
            comm.Parameters.AddWithValue("@unit", ComboBox2.SelectedValue)
            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()
                MsgBox("Item no. " & BunifuTextbox1.text & " had successfully updated")
                connt.closeCon()

                BunifuTextbox2.text = ""
                BunifuMaterialTextbox1.Text = ""
                TextBox1.Text = ""
                ComboBox1.SelectedIndex = -1
                ComboBox2.SelectedIndex = -1
                MainPage.Stocks1.loadstocks()
                Me.Hide()
            Else
                connt.closeCon()
                MainPage.Stocks1.loadstocks()
                Me.Hide()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim comm As MySqlCommand
        Dim answer As MsgBoxResult = MsgBox("Do you really want to delete the data?", MsgBoxStyle.YesNo, "Delete")

        Try
            comm = connt.openCon.CreateCommand
            comm.CommandText = "delete items,stocks from items INNER join stocks on items.Item_code=stocks.Item_code where items.Item_code=@id;"
            comm.Parameters.AddWithValue("@id", BunifuTextbox1.text)

            If answer = MsgBoxResult.Yes Then
                comm.ExecuteNonQuery()
                MsgBox("Item no. " & BunifuTextbox1.text & " had successfully deleted")
                connt.closeCon()

                BunifuTextbox2.text = ""
                BunifuMaterialTextbox1.Text = ""
                TextBox1.Text = ""
                ComboBox1.SelectedIndex = -1
                ComboBox2.SelectedIndex = -1
                MainPage.Stocks1.loadstocks()
                Me.Hide()
            Else
                connt.closeCon()
                MainPage.Stocks1.loadstocks()
                Me.Hide()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Private Sub BunifuTextbox4_OnTextChange_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuTextbox4_KeyPress(sender As Object, e As EventArgs)

    End Sub



    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.OnValueChanged

    End Sub

    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
     AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange

    End Sub
End Class