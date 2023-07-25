Public Class optndd
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        delivered.BunifuFlatButton2.Visible = True
        delivered.BunifuFlatButton3.Visible = False
        delivered.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        delivered.BunifuFlatButton2.Visible = False
        delivered.BunifuFlatButton3.Visible = True
        delivered.Show()
        Me.Hide()
    End Sub
End Class