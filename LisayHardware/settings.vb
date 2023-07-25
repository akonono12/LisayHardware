Imports MySql.Data.MySqlClient
Imports System.IO

Public Class settings
#Region "Declares"
    Dim connt As New dbconn
    Dim adtr, adtrs, adtr1, dtadtr, adtr3, adtr4 As MySqlDataAdapter
    Dim dtable, dtables, dtable3, dtable4 As New DataTable
#End Region

    Sub refreshss()
        Dim stgqry1s As String = "SELECT * from backup where DATE(DateDeadline)<=CURDATE() and status=0 "
        Try

            adtr3 = New MySqlDataAdapter(stgqry1s, connt.openCon)
            dtable3.Clear()
            If adtr3.Fill(dtable3) Then
                statusDB.Text = "Not yet Backup"
                statusDB.ForeColor = Color.Red
                DBdate.Text = "Beyond the Deadline"
                DBdate.ForeColor = Color.Red

            Else
                statusDB.Text = "Already Backup"
                statusDB.ForeColor = Color.SeaGreen
                connt.closeCon()
                Dim stgqry1ss As String = "SELECT * from backup  "
                adtr4 = New MySqlDataAdapter(stgqry1ss, connt.openCon)
                dtable4.Clear()
                If adtr4.Fill(dtable4) Then
                    DBdate.Text = dtable4(0)(1)
                    DBdate.ForeColor = Color.Black
                End If
                connt.closeCon()
            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connt.closeCon()
    End Sub
    Sub backupdb()
        Dim dbstring As String
        Dim dbname As String = "tpshardware"

        Try
            SaveFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
            SaveFileDialog1.FileName = "LisayHardware DBase Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                connt.openCon()
                dbstring = SaveFileDialog1.FileName
                Dim BackupProccess As New Process
                BackupProccess.StartInfo.FileName = "cmd.exe"
                BackupProccess.StartInfo.UseShellExecute = False
                BackupProccess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"
                BackupProccess.StartInfo.RedirectStandardInput = True
                BackupProccess.StartInfo.RedirectStandardOutput = True
                BackupProccess.Start()

                Dim BackupStream As StreamWriter = BackupProccess.StandardInput
                Dim myStreamReader As StreamReader = BackupProccess.StandardOutput
                BackupStream.WriteLine("mysqldump --user=root --password= -h localhost " & dbname & ">""" + dbstring + """")

                BackupStream.Close()
                BackupProccess.WaitForExit()
                BackupProccess.Close()
                connt.closeCon()
                Dim newDate As DateTime = DateTime.Now.AddMonths(1)
                Dim dsdsd As String
                dsdsd = newDate.ToString("yyyy-MM-dd")
                Dim comm5 As MySqlCommand
                comm5 = connt.openCon.CreateCommand
                comm5.CommandText = "Update backup set DateDeadline=@date, status=1;"
                comm5.Parameters.AddWithValue("@date", newDate)
                comm5.ExecuteNonQuery()
                connt.closeCon()
                refreshss()
                MsgBox("Database Backup created successfully!", MsgBoxStyle.Information, "Database Backup")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub restoredb()
        Dim dbstring As String
        Dim dbname As String = "tpshardware"
        Try
            OpenFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"

            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                connt.openCon()
                dbstring = OpenFileDialog1.FileName
                Dim BackupProccess As New Process
                BackupProccess.StartInfo.FileName = "cmd.exe"
                BackupProccess.StartInfo.UseShellExecute = False
                BackupProccess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"
                BackupProccess.StartInfo.RedirectStandardInput = True
                BackupProccess.StartInfo.RedirectStandardOutput = True
                BackupProccess.Start()

                Dim BackupStream As StreamWriter = BackupProccess.StandardInput
                Dim myStreamReader As StreamReader = BackupProccess.StandardOutput
                BackupStream.WriteLine("mysql --user=root --password= -h localhost " & dbname & "<""" + dbstring + """")

                BackupStream.Close()
                BackupProccess.WaitForExit()
                BackupProccess.Close()
                connt.closeCon()
                refreshss()
                MsgBox("Database restored Successfully!", MsgBoxStyle.Information, "Database Restore")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuTextbox2._TextBox.PasswordChar = "*"
        refreshss()
    End Sub



    Private Sub BunifuTextbox1_Enter(sender As Object, e As EventArgs) Handles fname.Enter
        If fname.text = "New Full Name" Then
            fname.text = ""
            fname.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BunifuTextbox1_Leave(sender As Object, e As EventArgs) Handles fname.Leave
        If fname.text = "" Then
            fname.text = "New Full Name"
            fname.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim answer As MsgBoxResult = MsgBox("Do you really want to update your name?", MsgBoxStyle.YesNo, "Update")
        Dim comm As MySqlCommand
        If answer = MsgBoxResult.Yes Then
            comm = connt.openCon.CreateCommand
            comm.CommandText = "Update personal_info set Fname=@fn,Lname=@ln where perIn_id=@id;"
            comm.Parameters.AddWithValue("@fn", fname.text)
            comm.Parameters.AddWithValue("@ln", lname.text)
            comm.Parameters.AddWithValue("@id", MainPage.loginId.Text)
            comm.ExecuteNonQuery()
            connt.closeCon()
            MsgBox("Successfully Updated")
        Else
            fname.text = "New First Name"
            lname.text = "New Last Name"
        End If
    End Sub

    Private Sub BunifuTextbox2_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox2.OnTextChange

    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles fname.OnTextChange

    End Sub

    Private Sub BunifuTextbox2_Enter(sender As Object, e As EventArgs) Handles BunifuTextbox2.Enter
        If BunifuTextbox2.text = "New Password" Then
            BunifuTextbox2.text = ""
            BunifuTextbox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BunifuTextbox2_Leave(sender As Object, e As EventArgs) Handles BunifuTextbox2.Leave
        If BunifuTextbox2.text = "" Then
            BunifuTextbox2.text = "New Password"
            BunifuTextbox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk

    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        restoredb()
    End Sub

    Private Sub BunifuSeparator1_Load(sender As Object, e As EventArgs) Handles BunifuSeparator1.Load

    End Sub

    Private Sub BunifuTileButton4_Click(sender As Object, e As EventArgs) Handles BunifuTileButton4.Click
        backupdb()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            BunifuTextbox2._TextBox.PasswordChar = "*"
            CheckBox1.Text = "Show Password"
        Else
            BunifuTextbox2._TextBox.PasswordChar = ""
            CheckBox1.Text = "Hide Password"
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim answer As MsgBoxResult = MsgBox("Do you really want to update your password?", MsgBoxStyle.YesNo, "Update")
        Dim comm1 As MySqlCommand
        If answer = MsgBoxResult.Yes Then
            Try
                comm1 = connt.openCon.CreateCommand
                comm1.CommandText = "Update user set password=@pass where usid=@id;"
                comm1.Parameters.AddWithValue("@pass", BunifuTextbox2.text)
                comm1.Parameters.AddWithValue("@id", MainPage.loginId.Text)
                comm1.ExecuteNonQuery()
                connt.closeCon()
                MsgBox("Successfully Updated")
            Catch ex As Exception

            End Try
        Else
            BunifuTextbox2.text = ""
        End If
    End Sub
End Class
