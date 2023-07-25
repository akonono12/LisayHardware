Imports MySql.Data.MySqlClient
Public Class MainPage

#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtr1, adtr2, adtr3, adtr7, adtr8 As MySqlDataAdapter
    Dim dtable, dtable1, dtable2, dtable3, dtable4, dtable7, dtable8 As New DataTable
#End Region
    Sub loadcheck()
        Dim stgqrys1 As String = "SELECT * FROM `checks` WHERE date(checks.dateTime)=curdate()"
        Try

            adtr8 = New MySqlDataAdapter(stgqrys1, connt.openCon)
            dtable8.Clear()
            If adtr8.Fill(dtable8) Then

                MsgBox("There been a check(s) for today")
                checkss.Show()


            Else

            End If






        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub loaddailysales()
        Dim stgqrys1 As String = "SELECT Sum(payment.total)as daily_sales FROM payment WHERE DATE(payment.transdate) = CURDATE() and payment.status = '1'"
        Try

            adtr7 = New MySqlDataAdapter(stgqrys1, connt.openCon)
            dtable7.Clear()
            If adtr7.Fill(dtable7) Then
                If Not IsDBNull(dtable7(0)(0)) Then
                    Dashboardcs1.dsale.Text = dtable7(0)(0)

                Else

                End If
            Else
            End If






        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub checkdb()
        Dim stgqry1s As String = "SELECT * from backup where DATE(DateDeadline)<=CURDATE() "
        Try

            adtr3 = New MySqlDataAdapter(stgqry1s, connt.openCon)
            dtable3.Clear()
            If adtr3.Fill(dtable3) Then
                connt.closeCon()
                Dim comm5 As MySqlCommand
                comm5 = connt.openCon.CreateCommand
                comm5.CommandText = "Update backup set  status=0;"
                comm5.ExecuteNonQuery()
                connt.closeCon()
                MsgBox("Please Backup your Database", MsgBoxStyle.Information, "Reminder")
            Else

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub

    Sub loadsupplier1()
        Dim stgqry1 As String = "SELECT * as tsup from supplier"
        Try

            adtr = New MySqlDataAdapter(stgqry1, connt.openCon)
            dtable.Clear()
            If adtr.Fill(dtable) Then
                Dashboardcs1.suppttl.Text = dtable(0)(0)
                Supplier1.DataGridView1.DataSource = dtable

                Supplier1.DataGridView1.Columns("sup_id").HeaderText = "Supplier ID"
                Supplier1.DataGridView1.Columns("Name").HeaderText = "Name"
                Supplier1.DataGridView1.Columns("address").HeaderText = "Address"
                Supplier1.DataGridView1.Columns("ConNo").HeaderText = "Contact No."
            Else

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub loadcustomer2()
        Dim stgqrys As String = "SELECT *  from customer"
        Try

            adtr1 = New MySqlDataAdapter(stgqrys, connt.openCon)
            dtable1.Clear()
            If adtr1.Fill(dtable1) Then
                Dashboardcs1.custtl.Text = dtable1(0)(0)
                Customer1.DataGridView1.DataSource = dtable1
                Customer1.DataGridView1.Columns("Payment_Balance").Visible = False
                Customer1.DataGridView1.Columns("Cust_id").HeaderText = "Customer ID"
                Customer1.DataGridView1.Columns("Name").HeaderText = "Name"
                Customer1.DataGridView1.Columns("Address").HeaderText = "Address"
                Customer1.DataGridView1.Columns("Con_no").HeaderText = "Contact No."
            Else

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub loadstocks1()
        Dim stgqryqs As String = "SELECT items.Item_code,items.Item_name,items.Description,category.category,unit.Units,stocks.Item_quantity,items.price,category.id,unit.unit_id, CASE
    WHEN stocks.Item_quantity > 30 THEN 'On Stock'
    WHEN stocks.Item_quantity BETWEEN 1 and 20  THEN 'Critical'
    ELSE 'Out of Stock'
END   as Status  FROM `items`inner join stocks on items.Item_code=stocks.Item_code INNER join category on items.category=category.id inner join unit on items.unit_id=unit.unit_id"
        Try

            adtr2 = New MySqlDataAdapter(stgqryqs, connt.openCon)
            dtable2.Clear()
            If adtr2.Fill(dtable2) Then
                Stocks1.DataGridView1.DataSource = dtable2
                Stocks1.DataGridView1.Columns("id").Visible = False
                Stocks1.DataGridView1.Columns("unit_id").Visible = False
                Stocks1.DataGridView1.Columns("Item_code").HeaderText = "Item Code"
                Stocks1.DataGridView1.Columns("Item_name").HeaderText = "Item Name"
                Stocks1.DataGridView1.Columns("Description").HeaderText = "Item Description"
                Stocks1.DataGridView1.Columns("category").HeaderText = "Item Category"
                Stocks1.DataGridView1.Columns("Units").HeaderText = "Item Unit"
                Stocks1.DataGridView1.Columns("Item_quantity").HeaderText = "Availability"
                Stocks1.DataGridView1.Columns("price").HeaderText = "Item Price"

            Else

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Burger_Click(sender As Object, e As EventArgs) Handles burger.Click
        If drawer.Visible = True Then
            paneltrans.HideSync(drawer)
        Else
            paneltrans.ShowSync(drawer)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuCustomLabel3.Text = Date.Now.ToString("ddd, MMM dd, yyyy")
        BunifuCustomLabel2.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        BunifuCustomLabel4.Text = "Dashboard"
        activeTab.Height = BunifuFlatButton1.Height
        activeTab.Top = BunifuFlatButton1.Top
        BunifuFlatButton1.selected = True
        Dashboardcs1.BringToFront()
        Panel3.Visible = False
        activeTab.Visible = True
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        BunifuCustomLabel4.Text = "Master Entry"
        activeTab.Height = BunifuFlatButton2.Height
        activeTab.Top = BunifuFlatButton2.Top
        Mastentry1.BringToFront()
        Panel3.Visible = False
        activeTab.Visible = True
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        BunifuCustomLabel4.Text = "Supplier"
        activeTab.Height = BunifuFlatButton3.Height
        activeTab.Top = BunifuFlatButton3.Top
        Supplier1.BringToFront()
        Panel3.Visible = False
        activeTab.Visible = True
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        BunifuCustomLabel4.Text = "Stocks"
        activeTab.Height = BunifuFlatButton4.Height
        activeTab.Top = BunifuFlatButton4.Top
        Stocks1.BringToFront()
        Panel3.Visible = False
        activeTab.Visible = True
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        BunifuCustomLabel4.Text = "Customer"
        activeTab.Height = BunifuFlatButton5.Height
        activeTab.Top = BunifuFlatButton5.Top
        Customer1.BringToFront()
        Panel3.Visible = False
        activeTab.Visible = True
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        BunifuCustomLabel4.Text = "Reports"
        Panel3.Height = BunifuFlatButton8.Height
        Panel3.Top = BunifuFlatButton8.Top
        Reports1.BringToFront()
        Panel3.Visible = True
        activeTab.Visible = False
    End Sub

    Private Sub Reports1_Load(sender As Object, e As EventArgs) Handles Reports1.Load

    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        BunifuCustomLabel4.Text = "Setting"
        activeTab.Height = BunifuFlatButton6.Height
        activeTab.Top = BunifuFlatButton6.Top
        Settings1.BringToFront()
        Panel3.Visible = False
        activeTab.Visible = True
    End Sub

    Private Sub Body_Paint(sender As Object, e As PaintEventArgs) Handles body.Paint

    End Sub

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activeTab.Height = BunifuFlatButton1.Height
        activeTab.Top = BunifuFlatButton1.Top
        BunifuCustomLabel4.Text = "Dashboard"
        activeTab.Visible = True
        checkdb()
        loadcheck()
        Dashboardcs1.BringToFront()
    End Sub

    Private Sub Dashboardcs1_Load(sender As Object, e As EventArgs) Handles Dashboardcs1.Load
        Dashboardcs1.Width = body.Width
        Dashboardcs1.Height = body.Height
    End Sub

    Private Sub Settings1_Load(sender As Object, e As EventArgs) Handles Settings1.Load

        Settings1.Width = body.Width
        Settings1.Height = body.Height
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        Panel3.Height = BunifuFlatButton7.Height
        Panel3.Top = BunifuFlatButton7.Top
        Panel3.Visible = True
        activeTab.Visible = False
        Dim answer As MsgBoxResult = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo, "Log Out")

        If answer = MsgBoxResult.Yes Then
            Application.Exit()


        End If
    End Sub

    Private Sub Supplier1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Customer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Supplier1_Load_1(sender As Object, e As EventArgs) Handles Supplier1.Load

    End Sub
End Class