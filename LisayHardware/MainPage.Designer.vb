<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.drawer = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton8 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LoginName = New System.Windows.Forms.Label()
        Me.loginId = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton7 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.activeTab = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.body = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Reports1 = New LisayHardware.Reports()
        Me.Supplier1 = New LisayHardware.Supplier()
        Me.Stocks1 = New LisayHardware.Stocks()
        Me.Customer1 = New LisayHardware.Customer()
        Me.Mastentry1 = New LisayHardware.Mastentry()
        Me.Settings1 = New LisayHardware.settings()
        Me.Dashboardcs1 = New LisayHardware.Dashboardcs()
        Me.toppanel = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.burger = New Bunifu.Framework.UI.BunifuImageButton()
        Me.paneltrans = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuFormFadeTransition1 = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl3 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.drawer.SuspendLayout()
        Me.body.SuspendLayout()
        Me.toppanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.burger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'drawer
        '
        Me.drawer.BackColor = System.Drawing.Color.DarkCyan
        Me.drawer.Controls.Add(Me.BunifuFlatButton8)
        Me.drawer.Controls.Add(Me.LoginName)
        Me.drawer.Controls.Add(Me.loginId)
        Me.drawer.Controls.Add(Me.Panel3)
        Me.drawer.Controls.Add(Me.BunifuFlatButton7)
        Me.drawer.Controls.Add(Me.activeTab)
        Me.drawer.Controls.Add(Me.BunifuFlatButton6)
        Me.drawer.Controls.Add(Me.BunifuFlatButton5)
        Me.drawer.Controls.Add(Me.BunifuFlatButton4)
        Me.drawer.Controls.Add(Me.BunifuFlatButton3)
        Me.drawer.Controls.Add(Me.BunifuFlatButton2)
        Me.drawer.Controls.Add(Me.BunifuFlatButton1)
        Me.drawer.Controls.Add(Me.Panel2)
        Me.paneltrans.SetDecoration(Me.drawer, BunifuAnimatorNS.DecorationType.None)
        Me.drawer.Dock = System.Windows.Forms.DockStyle.Left
        Me.drawer.Location = New System.Drawing.Point(0, 0)
        Me.drawer.Margin = New System.Windows.Forms.Padding(4)
        Me.drawer.Name = "drawer"
        Me.drawer.Size = New System.Drawing.Size(289, 807)
        Me.drawer.TabIndex = 0
        Me.drawer.Visible = False
        '
        'BunifuFlatButton8
        '
        Me.BunifuFlatButton8.Activecolor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuFlatButton8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton8.BorderRadius = 0
        Me.BunifuFlatButton8.ButtonText = "Reports"
        Me.BunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paneltrans.SetDecoration(Me.BunifuFlatButton8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton8.DisabledColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.Iconimage = CType(resources.GetObject("BunifuFlatButton8.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton8.Iconimage_right = Nothing
        Me.BunifuFlatButton8.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton8.Iconimage_Selected = Nothing
        Me.BunifuFlatButton8.IconMarginLeft = 15
        Me.BunifuFlatButton8.IconMarginRight = 0
        Me.BunifuFlatButton8.IconRightVisible = True
        Me.BunifuFlatButton8.IconRightZoom = 0R
        Me.BunifuFlatButton8.IconVisible = True
        Me.BunifuFlatButton8.IconZoom = 85.0R
        Me.BunifuFlatButton8.IsTab = True
        Me.BunifuFlatButton8.Location = New System.Drawing.Point(0, 592)
        Me.BunifuFlatButton8.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton8.Name = "BunifuFlatButton8"
        Me.BunifuFlatButton8.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.OnHovercolor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton8.selected = False
        Me.BunifuFlatButton8.Size = New System.Drawing.Size(289, 66)
        Me.BunifuFlatButton8.TabIndex = 11
        Me.BunifuFlatButton8.Text = "Reports"
        Me.BunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton8.Textcolor = System.Drawing.Color.LightYellow
        Me.BunifuFlatButton8.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LoginName
        '
        Me.LoginName.AutoSize = True
        Me.paneltrans.SetDecoration(Me.LoginName, BunifuAnimatorNS.DecorationType.None)
        Me.LoginName.Location = New System.Drawing.Point(85, 749)
        Me.LoginName.Name = "LoginName"
        Me.LoginName.Size = New System.Drawing.Size(51, 17)
        Me.LoginName.TabIndex = 10
        Me.LoginName.Text = "Label2"
        Me.LoginName.Visible = False
        '
        'loginId
        '
        Me.loginId.AutoSize = True
        Me.paneltrans.SetDecoration(Me.loginId, BunifuAnimatorNS.DecorationType.None)
        Me.loginId.Location = New System.Drawing.Point(28, 749)
        Me.loginId.Name = "loginId"
        Me.loginId.Size = New System.Drawing.Size(51, 17)
        Me.loginId.TabIndex = 9
        Me.loginId.Text = "Label1"
        Me.loginId.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.paneltrans.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Location = New System.Drawing.Point(0, 658)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(17, 58)
        Me.Panel3.TabIndex = 8
        Me.Panel3.Visible = False
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuFlatButton7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 0
        Me.BunifuFlatButton7.ButtonText = "Exit"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paneltrans.SetDecoration(Me.BunifuFlatButton7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = CType(resources.GetObject("BunifuFlatButton7.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 15
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = True
        Me.BunifuFlatButton7.IconRightZoom = 0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 85.0R
        Me.BunifuFlatButton7.IsTab = True
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(0, 658)
        Me.BunifuFlatButton7.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton7.selected = False
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(289, 62)
        Me.BunifuFlatButton7.TabIndex = 7
        Me.BunifuFlatButton7.Text = "Exit"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.LightYellow
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'activeTab
        '
        Me.activeTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.paneltrans.SetDecoration(Me.activeTab, BunifuAnimatorNS.DecorationType.None)
        Me.activeTab.Location = New System.Drawing.Point(0, 244)
        Me.activeTab.Name = "activeTab"
        Me.activeTab.Size = New System.Drawing.Size(17, 58)
        Me.activeTab.TabIndex = 1
        Me.activeTab.Visible = False
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuFlatButton6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.ButtonText = "Settings"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paneltrans.SetDecoration(Me.BunifuFlatButton6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = CType(resources.GetObject("BunifuFlatButton6.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 15
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = True
        Me.BunifuFlatButton6.IconRightZoom = 0R
        Me.BunifuFlatButton6.IconVisible = True
        Me.BunifuFlatButton6.IconZoom = 85.0R
        Me.BunifuFlatButton6.IsTab = True
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(0, 534)
        Me.BunifuFlatButton6.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(289, 58)
        Me.BunifuFlatButton6.TabIndex = 6
        Me.BunifuFlatButton6.Text = "Settings"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.LightYellow
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "Customer"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paneltrans.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = CType(resources.GetObject("BunifuFlatButton5.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 15
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 85.0R
        Me.BunifuFlatButton5.IsTab = True
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(0, 476)
        Me.BunifuFlatButton5.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(289, 58)
        Me.BunifuFlatButton5.TabIndex = 5
        Me.BunifuFlatButton5.Text = "Customer"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.LightYellow
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "Stocks"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paneltrans.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 15
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 85.0R
        Me.BunifuFlatButton4.IsTab = True
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(0, 418)
        Me.BunifuFlatButton4.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(289, 58)
        Me.BunifuFlatButton4.TabIndex = 4
        Me.BunifuFlatButton4.Text = "Stocks"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.LightYellow
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Supplier"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paneltrans.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 15
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 85.0R
        Me.BunifuFlatButton3.IsTab = True
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(0, 360)
        Me.BunifuFlatButton3.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(289, 58)
        Me.BunifuFlatButton3.TabIndex = 3
        Me.BunifuFlatButton3.Text = "Supplier"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.LightYellow
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Master Entry"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paneltrans.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 15
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 85.0R
        Me.BunifuFlatButton2.IsTab = True
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(0, 302)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(289, 58)
        Me.BunifuFlatButton2.TabIndex = 2
        Me.BunifuFlatButton2.Text = "Master Entry"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.LightYellow
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Dashboard"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paneltrans.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 15
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 85.0R
        Me.BunifuFlatButton1.IsTab = True
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 244)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.GhostWhite
        Me.BunifuFlatButton1.selected = True
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(289, 58)
        Me.BunifuFlatButton1.TabIndex = 1
        Me.BunifuFlatButton1.Text = "Dashboard"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.LightYellow
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.paneltrans.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(289, 244)
        Me.Panel2.TabIndex = 0
        '
        'body
        '
        Me.body.BackgroundImage = CType(resources.GetObject("body.BackgroundImage"), System.Drawing.Image)
        Me.body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.body.Controls.Add(Me.Reports1)
        Me.body.Controls.Add(Me.Supplier1)
        Me.body.Controls.Add(Me.Stocks1)
        Me.body.Controls.Add(Me.Customer1)
        Me.body.Controls.Add(Me.Mastentry1)
        Me.body.Controls.Add(Me.Settings1)
        Me.body.Controls.Add(Me.Dashboardcs1)
        Me.body.Controls.Add(Me.toppanel)
        Me.paneltrans.SetDecoration(Me.body, BunifuAnimatorNS.DecorationType.None)
        Me.body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.body.GradientBottomLeft = System.Drawing.Color.WhiteSmoke
        Me.body.GradientBottomRight = System.Drawing.Color.MistyRose
        Me.body.GradientTopLeft = System.Drawing.Color.Transparent
        Me.body.GradientTopRight = System.Drawing.Color.Gainsboro
        Me.body.Location = New System.Drawing.Point(289, 0)
        Me.body.Margin = New System.Windows.Forms.Padding(4)
        Me.body.Name = "body"
        Me.body.Quality = 10
        Me.body.Size = New System.Drawing.Size(1203, 807)
        Me.body.TabIndex = 1
        '
        'Reports1
        '
        Me.paneltrans.SetDecoration(Me.Reports1, BunifuAnimatorNS.DecorationType.None)
        Me.Reports1.Location = New System.Drawing.Point(0, 79)
        Me.Reports1.Name = "Reports1"
        Me.Reports1.Size = New System.Drawing.Size(1203, 728)
        Me.Reports1.TabIndex = 7
        '
        'Supplier1
        '
        Me.paneltrans.SetDecoration(Me.Supplier1, BunifuAnimatorNS.DecorationType.None)
        Me.Supplier1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Supplier1.Location = New System.Drawing.Point(0, 79)
        Me.Supplier1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Supplier1.Name = "Supplier1"
        Me.Supplier1.Size = New System.Drawing.Size(1203, 728)
        Me.Supplier1.TabIndex = 6
        '
        'Stocks1
        '
        Me.paneltrans.SetDecoration(Me.Stocks1, BunifuAnimatorNS.DecorationType.None)
        Me.Stocks1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Stocks1.Location = New System.Drawing.Point(0, 79)
        Me.Stocks1.Name = "Stocks1"
        Me.Stocks1.Size = New System.Drawing.Size(1203, 728)
        Me.Stocks1.TabIndex = 5
        '
        'Customer1
        '
        Me.paneltrans.SetDecoration(Me.Customer1, BunifuAnimatorNS.DecorationType.None)
        Me.Customer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Customer1.Location = New System.Drawing.Point(0, 79)
        Me.Customer1.Name = "Customer1"
        Me.Customer1.Size = New System.Drawing.Size(1203, 728)
        Me.Customer1.TabIndex = 4
        '
        'Mastentry1
        '
        Me.paneltrans.SetDecoration(Me.Mastentry1, BunifuAnimatorNS.DecorationType.None)
        Me.Mastentry1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mastentry1.Location = New System.Drawing.Point(0, 79)
        Me.Mastentry1.Name = "Mastentry1"
        Me.Mastentry1.Size = New System.Drawing.Size(1203, 728)
        Me.Mastentry1.TabIndex = 3
        '
        'Settings1
        '
        Me.paneltrans.SetDecoration(Me.Settings1, BunifuAnimatorNS.DecorationType.None)
        Me.Settings1.Location = New System.Drawing.Point(0, 79)
        Me.Settings1.Name = "Settings1"
        Me.Settings1.Size = New System.Drawing.Size(1203, 728)
        Me.Settings1.TabIndex = 2
        '
        'Dashboardcs1
        '
        Me.paneltrans.SetDecoration(Me.Dashboardcs1, BunifuAnimatorNS.DecorationType.None)
        Me.Dashboardcs1.Location = New System.Drawing.Point(0, 79)
        Me.Dashboardcs1.Name = "Dashboardcs1"
        Me.Dashboardcs1.Size = New System.Drawing.Size(1229, 1023)
        Me.Dashboardcs1.TabIndex = 1
        '
        'toppanel
        '
        Me.toppanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.toppanel.Controls.Add(Me.BunifuCustomLabel4)
        Me.toppanel.Controls.Add(Me.BunifuCustomLabel2)
        Me.toppanel.Controls.Add(Me.BunifuCustomLabel3)
        Me.toppanel.Controls.Add(Me.Panel1)
        Me.paneltrans.SetDecoration(Me.toppanel, BunifuAnimatorNS.DecorationType.None)
        Me.toppanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.toppanel.Location = New System.Drawing.Point(0, 0)
        Me.toppanel.Margin = New System.Windows.Forms.Padding(4)
        Me.toppanel.Name = "toppanel"
        Me.toppanel.Size = New System.Drawing.Size(1203, 79)
        Me.toppanel.TabIndex = 0
        '
        'BunifuCustomLabel4
        '
        Me.paneltrans.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(63, 47)
        Me.BunifuCustomLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(1071, 32)
        Me.BunifuCustomLabel4.TabIndex = 5
        Me.BunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.paneltrans.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(1134, 47)
        Me.BunifuCustomLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(69, 29)
        Me.BunifuCustomLabel2.TabIndex = 4
        Me.BunifuCustomLabel2.Text = "Time"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.paneltrans.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(0, 47)
        Me.BunifuCustomLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(63, 29)
        Me.BunifuCustomLabel3.TabIndex = 3
        Me.BunifuCustomLabel3.Text = "Date"
        Me.BunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.BunifuImageButton2)
        Me.Panel1.Controls.Add(Me.burger)
        Me.paneltrans.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1203, 47)
        Me.Panel1.TabIndex = 1
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.paneltrans.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(51, 9)
        Me.BunifuCustomLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(570, 29)
        Me.BunifuCustomLabel1.TabIndex = 1
        Me.BunifuCustomLabel1.Text = "Lisay's Hardware - Sales and Invetory Manangement"
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.SaddleBrown
        Me.BunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paneltrans.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1163, 0)
        Me.BunifuImageButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(40, 47)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 1
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'burger
        '
        Me.burger.BackColor = System.Drawing.Color.SaddleBrown
        Me.burger.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paneltrans.SetDecoration(Me.burger, BunifuAnimatorNS.DecorationType.None)
        Me.burger.Image = CType(resources.GetObject("burger.Image"), System.Drawing.Image)
        Me.burger.ImageActive = Nothing
        Me.burger.Location = New System.Drawing.Point(5, 2)
        Me.burger.Margin = New System.Windows.Forms.Padding(4)
        Me.burger.Name = "burger"
        Me.burger.Size = New System.Drawing.Size(40, 41)
        Me.burger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.burger.TabIndex = 0
        Me.burger.TabStop = False
        Me.burger.Zoom = 10
        '
        'paneltrans
        '
        Me.paneltrans.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.paneltrans.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.paneltrans.DefaultAnimation = Animation1
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.toppanel
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.Panel1
        Me.BunifuDragControl2.Vertical = True
        '
        'BunifuFormFadeTransition1
        '
        Me.BunifuFormFadeTransition1.Delay = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 12
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl3
        '
        Me.BunifuDragControl3.Fixed = True
        Me.BunifuDragControl3.Horizontal = True
        Me.BunifuDragControl3.TargetControl = Me.BunifuCustomLabel1
        Me.BunifuDragControl3.Vertical = True
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1492, 807)
        Me.Controls.Add(Me.body)
        Me.Controls.Add(Me.drawer)
        Me.paneltrans.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.drawer.ResumeLayout(False)
        Me.drawer.PerformLayout()
        Me.body.ResumeLayout(False)
        Me.toppanel.ResumeLayout(False)
        Me.toppanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.burger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents drawer As Panel
    Friend WithEvents body As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents toppanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents burger As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents paneltrans As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuFormFadeTransition1 As Bunifu.Framework.UI.BunifuFormFadeTransition
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents activeTab As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Dashboardcs1 As Dashboardcs
    Friend WithEvents Settings1 As settings
    Friend WithEvents BunifuFlatButton7 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Mastentry1 As Mastentry
    Friend WithEvents Customer1 As Customer
    Friend WithEvents Stocks1 As Stocks
    Friend WithEvents Supplier1 As Supplier
    Friend WithEvents BunifuDragControl3 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents LoginName As Label
    Friend WithEvents loginId As Label
    Friend WithEvents BunifuFlatButton8 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Reports1 As Reports
End Class
