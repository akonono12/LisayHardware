Public Class formOption
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        User.Panel1.Enabled = True
        Me.Close()

    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click


        editUser.BunifuMaterialTextbox1.Text = User.BunifuTextbox9.text
        editUser.BunifuMaterialTextbox2.Text = User.BunifuTextbox8.text
        editUser.BunifuMaterialTextbox3.Text = User.BunifuTextbox7.text
        editUser.BunifuMaterialTextbox4.Text = User.BunifuTextbox6.text
        editUser.BunifuMaterialTextbox5.Text = User.BunifuTextbox5.text
        If User.BunifuDropdown2.selectedIndex = 1 Then
            editUser.BunifuMaterialTextbox6.Text = "Cashier"
        Else
            editUser.BunifuMaterialTextbox6.Text = "Admin"
        End If

        editUser.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        DelUser.BunifuMaterialTextbox1.Text = User.BunifuTextbox9.text
        DelUser.BunifuMaterialTextbox2.Text = User.BunifuTextbox8.text
        DelUser.BunifuMaterialTextbox3.Text = User.BunifuTextbox7.text
        DelUser.BunifuMaterialTextbox4.Text = User.BunifuTextbox6.text
        DelUser.BunifuMaterialTextbox5.Text = User.BunifuTextbox5.text
        If User.BunifuDropdown2.selectedIndex = 1 Then
            DelUser.BunifuMaterialTextbox6.Text = "Cashier"
        Else
            DelUser.BunifuMaterialTextbox6.Text = "Admin"
        End If

        DelUser.Show()
        Me.Hide()
    End Sub
End Class