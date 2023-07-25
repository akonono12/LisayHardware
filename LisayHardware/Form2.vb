Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class Form2
    Dim connt As New dbconn
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'tpshardwareDataSet1.category' table. You can move, or remove it, as needed.
        Me.categoryTableAdapter.Fill(Me.tpshardwareDataSet1.category)

        Me.ReportViewer1.RefreshReport()
        Me.TextBox1.Text = epndds.Label1.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim adapter As tpshardwareDataSet1TableAdapters.categoryTableAdapter = New tpshardwareDataSet1TableAdapters.categoryTableAdapter()
        Dim table As tpshardwareDataSet1.categoryDataTable = New tpshardwareDataSet1.categoryDataTable()
        adapter.FillBy(table, TextBox1.Text)
        Dim mydsource As ReportDataSource = New ReportDataSource("Reciept_Dataset", CType(table, DataTable))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(mydsource)
        Me.ReportViewer1.LocalReport.Refresh()
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        'Dim comm3, comm4 As MySqlCommand
        'comm3 = connt.openCon.CreateCommand
        'comm3.CommandText = "DELETE FROM `tempcart`"
        'comm3.ExecuteNonQuery()
        'connt.closeCon()
        'POS.loadcart()
        'Dim answer1 As MsgBoxResult = MsgBox("Already Paid?", MsgBoxStyle.YesNo, "Info")
        'If answer1 = MsgBoxResult.Yes Then
        '    comm4 = connt.openCon.CreateCommand
        '    comm4.CommandText = "UPDATE `payment` SET `status`= '1' WHERE trans_id='" & TextBox1.Text & "'"
        '    comm4.ExecuteNonQuery()
        '    connt.closeCon()
        'Else

        'End If
        'Dim answer As MsgBoxResult = MsgBox("Do you want to continue?", MsgBoxStyle.YesNo, "Info")
        'POS.dfee.Text = 0
        'POS.discount.Text = 0
        'POS.Label10.Text = 0
        'POS.Label1.Text = 0


        'If answer = MsgBoxResult.Yes Then
        '    SelCustomer.loadcustomer()
        '    MainPage.loadstocks1()
        '    Form1.Show()
        '    Me.Close()
        'Else
        '    SelCustomer.loadcustomer()
        '    MainPage.loadstocks1()
        '    MainPage.Enabled = True
        '    Me.Close()
        'End If
        Me.Close()


    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class