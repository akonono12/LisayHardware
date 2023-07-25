Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class frmDelvRport
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Hide()
    End Sub

    Private Sub FrmDelvRport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'deliveryreport.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.deliveryreport.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adapter As deliveryreportTableAdapters.DataTable1TableAdapter = New deliveryreportTableAdapters.DataTable1TableAdapter()
        Dim table As deliveryreport.DataTable1DataTable = New deliveryreport.DataTable1DataTable()
        adapter.FillBySname(table, BunifuTextbox1.text)
        Dim mydsource As ReportDataSource = New ReportDataSource("ItemStocks", CType(table, DataTable))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(mydsource)
        Me.ReportViewer1.LocalReport.Refresh()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.DataTable1TableAdapter.Fill(Me.deliveryreport.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange

    End Sub
End Class