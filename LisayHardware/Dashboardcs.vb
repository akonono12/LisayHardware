Imports MySql.Data.MySqlClient

Public Class Dashboardcs
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3, adtr4, adtr5 As MySqlDataAdapter
    Dim dtable, dtable1, dtable2, dtable3, dtable4, dtable5 As New DataTable

    Private Sub Dashboardcs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsupp()
        loadcustomer2()
        dsales()
        loadws()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        clabel.Text = "Weekly Sales"
        loadws()
    End Sub

    Private Sub Dsale_Click(sender As Object, e As EventArgs) Handles dsale.Click

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        clabel.Text = "Monthly Sales"
        loadms()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        clabel.Text = "Yearly Sales"
        loadys()
    End Sub
#End Region
    Sub loadws()
        Chart1.Series("Sales").Points.Clear()
        Dim mreader As MySqlDataReader
        Dim comm As MySqlCommand
        Dim stgqry1 As String = "SELECT 
    CONCAT('week ',WEEK(payment.transdate)) weeks,
    sum(payment.total) as total
    FROM payment 
    WHERE payment.transdate >    DATE_SUB(NOW(), INTERVAL 1 WEEK) and status<>1
    GROUP BY WEEK(payment.transdate)
    ORDER BY payment.transdate;"
        Try

            comm = New MySqlCommand(stgqry1, connt.openCon)
            mreader = comm.ExecuteReader
            While mreader.Read
                Chart1.Series("Sales").Points.AddXY(mreader.GetString("Weeks"), mreader.GetInt32("total"))
            End While





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub loadms()
        Chart1.Series("Sales").Points.Clear()
        Dim mreader1 As MySqlDataReader
        Dim comm1 As MySqlCommand
        Dim stgqry1s As String = "SELECT 
    CONCAT('month ',Month(payment.transdate)) Month,
    sum(payment.total) as total
    FROM payment 
    WHERE payment.transdate >    DATE_SUB(NOW(), INTERVAL 1  Month) and status<>1
    GROUP BY  Month(payment.transdate)
    ORDER BY payment.transdate;"
        Try

            comm1 = New MySqlCommand(stgqry1s, connt.openCon)
            mreader1 = comm1.ExecuteReader
            While mreader1.Read
                Chart1.Series("Sales").Points.AddXY(mreader1.GetString("Month"), mreader1.GetInt32("total"))
            End While





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub loadys()
        Chart1.Series("Sales").Points.Clear()
        Dim mreader2 As MySqlDataReader
        Dim comm2 As MySqlCommand
        Dim stgqry12 As String = "SELECT 
    CONCAT('Year',YEAR(payment.transdate)) YEAR ,
    sum(payment.total) as total
    FROM payment 
    WHERE payment.transdate >    DATE_SUB(NOW(), INTERVAL 1  YEAR) and status<>1
    GROUP BY  YEAR(payment.transdate)
    ORDER BY payment.transdate;"
        Try

            comm2 = New MySqlCommand(stgqry12, connt.openCon)
            mreader2 = comm2.ExecuteReader
            While mreader2.Read
                Chart1.Series("Sales").Points.AddXY(mreader2.GetString("YEAR"), mreader2.GetInt32("total"))
            End While





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub tsupp()
        Dim stgqry1 As String = "SELECT *,count(*) as tsup from supplier"
        Try

            adtr = New MySqlDataAdapter(stgqry1, connt.openCon)
            dtable.Clear()
            If adtr.Fill(dtable) Then
                suppttl.Text = dtable(0)(4)

            Else

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub loadcustomer2()
        Dim stgqrys As String = "SELECT *,count(*) as tcust from customer"
        Try

            adtr1 = New MySqlDataAdapter(stgqrys, connt.openCon)
            dtable1.Clear()
            If adtr1.Fill(dtable1) Then
                custtl.Text = dtable1(0)(5)

            Else

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub dsales()
        Dim stgqrys1 As String = "SELECT Sum(payment.total)as daily_sales FROM payment WHERE DATE(payment.transdate) = CURDATE() and payment.status = '1'"
        Try

            adtr2 = New MySqlDataAdapter(stgqrys1, connt.openCon)
            dtable2.Clear()
            If adtr2.Fill(dtable2) Then
                If Not IsDBNull(dtable2(0)(0)) Then
                    dsale.Text = dtable2(0)(0)

                Else

                End If
            Else
            End If






        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles suppttl.Click

    End Sub
End Class
