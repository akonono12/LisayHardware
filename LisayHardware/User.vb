Imports MySql.Data.MySqlClient
Public Class User
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr As MySqlDataAdapter
    Dim dtable As New DataTable
    Dim ds As New DataSet
#End Region
    Sub selectuser()
        Dim stgqry As String = "SELECT * FROM `user` ORDER BY `user`.`usid` DESC"
        Try

            adtr = New MySqlDataAdapter(stgqry, connt.openCon)
            dtable.Clear()
            adtr.Fill(dtable)
            Dim a As Integer = dtable(0)(0)
            connt.closeCon()
            Dim commd As MySqlCommand
            commd = connt.openCon.CreateCommand
            commd.CommandText = "INSERT INTO personal_info(user_id,Fname,Lname)values(@uid,@fn,@ln);"
            commd.Parameters.AddWithValue("@uid", a)
            commd.Parameters.AddWithValue("@fn", BunifuTextbox1.text)
            commd.Parameters.AddWithValue("@ln", BunifuTextbox2.text)
            commd.ExecuteNonQuery()
            MsgBox("Successfully Added")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub dgvload()
        Dim stgqry As String = "SELECT *,if(user.level = 1, 'Admin','Cashier') as lvl FROM `user` INNER join personal_info on user.usid=personal_info.user_id where user.level<>1"
        Try

            adtr = New MySqlDataAdapter(stgqry, connt.openCon)
            dtable.Clear()
            adtr.Fill(dtable)
            DataGridView1.DataSource = dtable
            DataGridView1.Columns("level").Visible = False
            DataGridView1.Columns("user_id").Visible = False
            DataGridView1.Columns("perIn_id").Visible = False
            DataGridView1.Columns("usid").HeaderText = "User ID"
            DataGridView1.Columns("username").HeaderText = "Username"
            DataGridView1.Columns("password").HeaderText = "Password"
            DataGridView1.Columns("Fname").HeaderText = "First Name"
            DataGridView1.Columns("Lname").HeaderText = "Last Name"
            DataGridView1.Columns("lvl").HeaderText = "Level"





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub


    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        MainPage.Enabled = True
        Me.Close()
    End Sub

    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.Click

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs)
        Panel1.Enabled = False
        formOption.Show()
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange

    End Sub
    Private Sub BunifuTextbox2_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox2.OnTextChange

    End Sub
    Private Sub BunifuTextbox3_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox3.OnTextChange

    End Sub
    Private Sub BunifuTextbox4_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox4.OnTextChange

    End Sub

    Private Sub BunifuTextbox1_Enter(sender As Object, e As EventArgs) Handles BunifuTextbox1.Enter
        If BunifuTextbox1.text = "First Name" Then
            BunifuTextbox1.text = ""
        End If
    End Sub
    Private Sub BunifuTextbox2_Enter(sender As Object, e As EventArgs) Handles BunifuTextbox2.Enter
        If BunifuTextbox2.text = "Last Name" Then
            BunifuTextbox2.text = ""
        End If
    End Sub
    Private Sub BunifuTextbox3_Enter(sender As Object, e As EventArgs) Handles BunifuTextbox3.Enter
        If BunifuTextbox3.text = "Username" Then
            BunifuTextbox3.text = ""
        End If
    End Sub
    Private Sub BunifuTextbox4_Enter(sender As Object, e As EventArgs) Handles BunifuTextbox4.Enter
        If BunifuTextbox4.text = "Password" Then
            BunifuTextbox4.text = ""
        End If
    End Sub

    Private Sub BunifuTextbox1_Load(sender As Object, e As EventArgs) Handles BunifuTextbox1.Load

    End Sub

    Private Sub BunifuTextbox1_Leave(sender As Object, e As EventArgs) Handles BunifuTextbox1.Leave
        If BunifuTextbox1.text = "" Then
            BunifuTextbox1.text = "First Name"
        End If
    End Sub
    Private Sub BunifuTextbox2_Leave(sender As Object, e As EventArgs) Handles BunifuTextbox2.Leave
        If BunifuTextbox2.text = "" Then
            BunifuTextbox2.text = "Last Name"
        End If
    End Sub
    Private Sub BunifuTextbox3_Leave(sender As Object, e As EventArgs) Handles BunifuTextbox3.Leave
        If BunifuTextbox3.text = "" Then
            BunifuTextbox3.text = "Username"
        End If
    End Sub
    Private Sub BunifuTextbox4_Leave(sender As Object, e As EventArgs) Handles BunifuTextbox4.Leave
        If BunifuTextbox4.text = "" Then
            BunifuTextbox4.text = "Password"
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If BunifuTextbox1.text = "" Or BunifuTextbox1.text = "First Name" Or BunifuTextbox2.text = "" Or BunifuTextbox2.text = "Last Name" Or BunifuTextbox3.text = "" Or BunifuTextbox3.text = "Username" Or BunifuTextbox4.text = "" Or BunifuTextbox4.text = "Password" Or BunifuDropdown1.selectedIndex = -1 Then
            MsgBox("Field(s) must not be empty")
        Else


            Dim x As String
            If BunifuDropdown1.selectedValue = "Admin" Then
                x = 1
            Else
                x = 2
            End If
            Dim comm As MySqlCommand
            Try
                comm = connt.openCon.CreateCommand
                comm.CommandText = "Insert into user(username,password,level)values(@user,@pass,@level); "
                comm.Parameters.AddWithValue("@user", BunifuTextbox3.text)
                comm.Parameters.AddWithValue("@pass", BunifuTextbox4.text)
                comm.Parameters.AddWithValue("@level", x)
                comm.ExecuteNonQuery()

            Catch ex As Exception

            End Try
            connt.closeCon()
            selectuser()
            dgvload()
        End If
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvload()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            BunifuTextbox9.text = row.Cells(0).Value.ToString
            BunifuTextbox8.text = row.Cells(6).Value.ToString
            BunifuTextbox7.text = row.Cells(7).Value.ToString
            BunifuTextbox6.text = row.Cells(1).Value.ToString
            BunifuTextbox5.text = row.Cells(2).Value.ToString
            If row.Cells(3).Value = 1 Then
                BunifuDropdown2.selectedIndex = 0
            Else
                BunifuDropdown2.selectedIndex = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        formOption.Show()
    End Sub
End Class