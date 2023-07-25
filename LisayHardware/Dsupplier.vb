Imports MySql.Data.MySqlClient
Public Class Dsupplier
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr As MySqlDataAdapter
    Dim dtable As New DataTable
#End Region
    Sub loadsup()
        Dim stgqry As String = "SELECT * from supplier"
        Try

            adtr = New MySqlDataAdapter(stgqry, connt.openCon)
            dtable.Clear()
            adtr.Fill(dtable)
            ComboBox1.DataSource = dtable
            ComboBox1.ValueMember = "sup_id"
            ComboBox1.DisplayMember = "Name"
            ComboBox1.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        MainPage.Enabled = True
        Me.Hide()
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Please select a supplier")
        Else
            Dim stgqry As String = "SELECT * from supplier where sup_id='" & ComboBox1.SelectedValue & "'"
            Try

                adtr = New MySqlDataAdapter(stgqry, connt.openCon)
                dtable.Clear()
                adtr.Fill(dtable)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            connt.closeCon()
            viewP.Enabled = True
            BunifuFlatButton1.Text = "Select"
            BunifuMaterialTextbox7.Text = dtable(0)(0)
            BunifuMaterialTextbox1.Text = dtable(0)(2)
            BunifuMaterialTextbox2.Text = dtable(0)(3)
            BunifuMaterialTextbox3.Text = dtable(0)(1)
        End If

    End Sub

    Private Sub Dsupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsup()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        FrmSupDelv.Label7.Text = BunifuMaterialTextbox7.Text
        FrmSupDelv.Label11.Text = BunifuMaterialTextbox3.Text
        FrmSupDelv.Show()
        Me.Hide()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class