Imports MySql.Data.MySqlClient

Public Class Loginform

#Region "Declares"
    Dim connt As New dbconn
    Dim adtr As MySqlDataAdapter
    Dim dtable As New DataTable
    Dim ds As New DataSet
#End Region





    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuTextbox2._TextBox.PasswordChar = "*"


    End Sub

    Private Sub BunifuTextbox1_Leave(sender As Object, e As EventArgs) Handles BunifuTextbox1.Leave
        If BunifuTextbox1.text = "" Then
            BunifuTextbox1.text = "Username"
            BunifuTextbox1.ForeColor = Color.SeaGreen
        End If
    End Sub

    Private Sub BunifuTextbox2_Enter(sender As Object, e As EventArgs) Handles BunifuTextbox2.Enter
        If BunifuTextbox2.text = "Password" Then
            BunifuTextbox2.text = ""
            BunifuTextbox2.ForeColor = Color.SeaGreen
        End If
    End Sub

    Private Sub BunifuTextbox2_Leave(sender As Object, e As EventArgs) Handles BunifuTextbox2.Leave
        If BunifuTextbox2.text = "" Then
            BunifuTextbox2.text = "Password"
            BunifuTextbox2.ForeColor = Color.SeaGreen
        End If
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim answer As MsgBoxResult = MsgBox("Do you really want to close the program?", MsgBoxStyle.YesNo, "Exit")

        If answer = MsgBoxResult.Yes Then
            Me.Close()
            SplashScreen.Close()
        End If

    End Sub

    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuTextbox1_Enter(sender As Object, e As EventArgs) Handles BunifuTextbox1.Enter
        If BunifuTextbox1.text = "Username" Then
            BunifuTextbox1.text = ""
            BunifuTextbox1.ForeColor = Color.SeaGreen
        End If
    End Sub

    Private Sub BunifuCheckbox1_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox1.OnChange
        If BunifuCheckbox1.Checked = False Then
            BunifuTextbox2._TextBox.PasswordChar = "*"
            BunifuCustomLabel2.Text = "Show Password"
        Else
            BunifuTextbox2._TextBox.PasswordChar = ""
            BunifuCustomLabel2.Text = "Hide Password"
        End If
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Dim strquery As String = "SELECT * FROM `user` INNER join personal_info on user.usid=personal_info.user_id where username = '" & BunifuTextbox1.text & "' and password='" & BunifuTextbox2.text & "'"

        adtr = New MySqlDataAdapter(strquery, connt.openCon())
        dtable.Clear()

        adtr.Fill(dtable)


        If dtable.Rows.Count = Nothing Then
            MsgBox("Invalid Account.Please try again",, "Error")
        Else
            MsgBox("Welcome User: " & dtable(0)(6) & " " & dtable(0)(7))
            MainPage.LoginName.Text = dtable(0)(6) & " " & dtable(0)(7)
            MainPage.loginId.Text = dtable(0)(0)
            MainPage.Show()
            Me.Hide()
        End If
        connt.closeCon()
    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange

    End Sub

    Private Sub BunifuTextbox2_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox2.OnTextChange

    End Sub
End Class