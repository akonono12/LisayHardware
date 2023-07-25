Public Class optionpos
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        itemedit.BunifuFlatButton2.Visible = True
        itemedit.BunifuFlatButton3.Visible = False
        itemedit.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        itemedit.BunifuFlatButton2.Visible = False
        itemedit.BunifuFlatButton3.Visible = True
        itemedit.Show()
        Me.Hide()
    End Sub
End Class