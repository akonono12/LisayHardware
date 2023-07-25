Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        With BunifuProgressBar1
            If .Value < 100 Then
                .Value = .Value + 1

                BunifuCustomLabel3.Text = "Loading: " & .Value & "%"
            Else
                Timer1.Enabled = False
                Me.Visible = False
                Loginform.Show()


            End If
        End With
        If BunifuCustomLabel1.ForeColor = Color.White Then
            BunifuCustomLabel1.ForeColor = Color.WhiteSmoke
            BunifuCustomLabel2.ForeColor = Color.Linen
        ElseIf BunifuCustomLabel1.ForeColor = Color.WhiteSmoke Then
            BunifuCustomLabel1.ForeColor = Color.Snow
            BunifuCustomLabel2.ForeColor = Color.White
        ElseIf BunifuCustomLabel1.ForeColor = Color.Snow Then
            BunifuCustomLabel1.ForeColor = Color.White
            BunifuCustomLabel2.ForeColor = Color.WhiteSmoke
        End If


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.Click

    End Sub
End Class
