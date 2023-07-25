Public Class optnStocks
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        AddItem.BunifuTextbox1.text = MainPage.Stocks1.BunifuTextbox1.text
        AddItem.BunifuTextbox2.text = MainPage.Stocks1.BunifuTextbox2.text
        AddItem.TextBox1.Text = MainPage.Stocks1.BunifuTextbox3.text
        AddItem.ComboBox1.SelectedValue = MainPage.Stocks1.BunifuTextbox4.text
        AddItem.ComboBox2.SelectedValue = MainPage.Stocks1.BunifuTextbox5.text
        AddItem.BunifuMaterialTextbox1.Text = MainPage.Stocks1.BunifuTextbox6.text
        AddItem.BunifuFlatButton4.Visible = False
        AddItem.BunifuFlatButton2.Visible = False
        AddItem.BunifuFlatButton1.Visible = True
        AddItem.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        AddItem.BunifuTextbox1.text = MainPage.Stocks1.BunifuTextbox1.text
        AddItem.BunifuTextbox2.text = MainPage.Stocks1.BunifuTextbox2.text
        AddItem.TextBox1.Text = MainPage.Stocks1.BunifuTextbox3.text
        AddItem.ComboBox1.SelectedValue = MainPage.Stocks1.BunifuTextbox4.text
        AddItem.ComboBox2.SelectedValue = MainPage.Stocks1.BunifuTextbox5.text
        AddItem.BunifuMaterialTextbox1.Text = MainPage.Stocks1.BunifuTextbox6.text
        AddItem.BunifuFlatButton4.Visible = False
        AddItem.BunifuFlatButton2.Visible = True
        AddItem.BunifuFlatButton1.Visible = False
        AddItem.Show()
        Me.Hide()
    End Sub
End Class