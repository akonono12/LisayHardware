Imports MySql.Data.MySqlClient
Public Class SelCustomer
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr As MySqlDataAdapter
    Dim dtable As New DataTable
#End Region
    Sub loadcustomer()
        Dim stgqry As String = "SELECT * from customer"
        Try

            adtr = New MySqlDataAdapter(stgqry, connt.openCon)
            dtable.Clear()
            adtr.Fill(dtable)
            ComboBox1.DataSource = dtable
            ComboBox1.ValueMember = "Cust_id"
            ComboBox1.DisplayMember = "Name"
            ComboBox1.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Private Sub BunifuMaterialTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.OnValueChanged

    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        MainPage.Enabled = True
        loadcustomer()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Please select a customer")
        Else
            Dim stgqry As String = "SELECT * from customer where Cust_id='" & ComboBox1.SelectedValue & "'"
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
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If flag.Text = 1 Then
            Sales.Label7.Text = BunifuMaterialTextbox7.Text
            Sales.Label11.Text = BunifuMaterialTextbox3.Text
            loadcustomer()
            Sales.Show()
            Me.Hide()
        Else
            POS.Label7.Text = BunifuMaterialTextbox7.Text
            POS.Label11.Text = BunifuMaterialTextbox3.Text
            loadcustomer()
            POS.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub SelCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcustomer()
    End Sub
End Class