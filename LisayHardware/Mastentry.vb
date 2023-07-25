Public Class Mastentry
    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        MainPage.Enabled = False
        cat.Show()

    End Sub

    Private Sub BunifuTileButton5_Click(sender As Object, e As EventArgs) Handles BunifuTileButton5.Click
        MainPage.Enabled = False
        User.Show()
    End Sub

    Private Sub BunifuTileButton4_Click(sender As Object, e As EventArgs) Handles BunifuTileButton4.Click
        MainPage.Enabled = False
        addcus.Show()
    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        MainPage.Enabled = False
        AddItem.BunifuFlatButton4.Visible = True
        AddItem.BunifuFlatButton2.Visible = False
        AddItem.BunifuFlatButton1.Visible = False
        AddItem.Show()
    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        MainPage.Enabled = False
        AddSupplier.Show()
    End Sub

    Private Sub BunifuTileButton6_Click(sender As Object, e As EventArgs) Handles BunifuTileButton6.Click
        MainPage.Enabled = False
        units.Show()
    End Sub

    Private Sub BunifuTileButton7_Click(sender As Object, e As EventArgs) Handles BunifuTileButton7.Click
        MainPage.Enabled = False
        MsgBox("Please Select a Supplier to pay")
        selectasupplier.Show()
    End Sub
End Class
