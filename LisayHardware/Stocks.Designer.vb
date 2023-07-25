<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stocks
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stocks))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BunifuTextbox7 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuTextbox5 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuTextbox6 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuTextbox3 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuTextbox4 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuTextbox2 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuTextbox1 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.BunifuTextbox7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.BunifuTileButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1203, 728)
        Me.Panel1.TabIndex = 0
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton1.color = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton1.Image = CType(resources.GetObject("BunifuTileButton1.Image"), System.Drawing.Image)
        Me.BunifuTileButton1.ImagePosition = 20
        Me.BunifuTileButton1.ImageZoom = 50
        Me.BunifuTileButton1.LabelPosition = 41
        Me.BunifuTileButton1.LabelText = "Add Sales"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(590, 41)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(232, 183)
        Me.BunifuTileButton1.TabIndex = 36
        Me.BunifuTileButton1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1072, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 31)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(428, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 31)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Item Code", "Item Name", "Category", "Unit"})
        Me.ComboBox1.Location = New System.Drawing.Point(690, 97)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(145, 37)
        Me.ComboBox1.TabIndex = 33
        '
        'BunifuTextbox7
        '
        Me.BunifuTextbox7.BackColor = System.Drawing.Color.Silver
        Me.BunifuTextbox7.BackgroundImage = CType(resources.GetObject("BunifuTextbox7.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox7.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuTextbox7.Icon = CType(resources.GetObject("BunifuTextbox7.Icon"), System.Drawing.Image)
        Me.BunifuTextbox7.Location = New System.Drawing.Point(842, 97)
        Me.BunifuTextbox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuTextbox7.Name = "BunifuTextbox7"
        Me.BunifuTextbox7.Size = New System.Drawing.Size(223, 38)
        Me.BunifuTextbox7.TabIndex = 32
        Me.BunifuTextbox7.text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Brown
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(558, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 29)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Search by:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 61)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Availability"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(226, 21)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(147, 32)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Out of Stock"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(127, 21)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(93, 32)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Critical"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(6, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(115, 32)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "On Stock"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 140)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1158, 523)
        Me.DataGridView1.TabIndex = 13
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Brown
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft YaHei", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(20, 91)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(1158, 505)
        Me.BunifuCustomLabel2.TabIndex = 14
        Me.BunifuCustomLabel2.Text = "Stocks"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BunifuTextbox5)
        Me.Panel2.Controls.Add(Me.BunifuTextbox6)
        Me.Panel2.Controls.Add(Me.BunifuTextbox3)
        Me.Panel2.Controls.Add(Me.BunifuTextbox4)
        Me.Panel2.Controls.Add(Me.BunifuTextbox2)
        Me.Panel2.Controls.Add(Me.BunifuTextbox1)
        Me.Panel2.Location = New System.Drawing.Point(185, 392)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(519, 333)
        Me.Panel2.TabIndex = 15
        '
        'BunifuTextbox5
        '
        Me.BunifuTextbox5.BackColor = System.Drawing.Color.Silver
        Me.BunifuTextbox5.BackgroundImage = CType(resources.GetObject("BunifuTextbox5.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox5.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuTextbox5.Icon = CType(resources.GetObject("BunifuTextbox5.Icon"), System.Drawing.Image)
        Me.BunifuTextbox5.Location = New System.Drawing.Point(81, 226)
        Me.BunifuTextbox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuTextbox5.Name = "BunifuTextbox5"
        Me.BunifuTextbox5.Size = New System.Drawing.Size(205, 36)
        Me.BunifuTextbox5.TabIndex = 6
        Me.BunifuTextbox5.text = "Bunifu TextBox"
        '
        'BunifuTextbox6
        '
        Me.BunifuTextbox6.BackColor = System.Drawing.Color.Silver
        Me.BunifuTextbox6.BackgroundImage = CType(resources.GetObject("BunifuTextbox6.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox6.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuTextbox6.Icon = CType(resources.GetObject("BunifuTextbox6.Icon"), System.Drawing.Image)
        Me.BunifuTextbox6.Location = New System.Drawing.Point(310, 226)
        Me.BunifuTextbox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuTextbox6.Name = "BunifuTextbox6"
        Me.BunifuTextbox6.Size = New System.Drawing.Size(205, 36)
        Me.BunifuTextbox6.TabIndex = 5
        Me.BunifuTextbox6.text = "Bunifu TextBox"
        '
        'BunifuTextbox3
        '
        Me.BunifuTextbox3.BackColor = System.Drawing.Color.Silver
        Me.BunifuTextbox3.BackgroundImage = CType(resources.GetObject("BunifuTextbox3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox3.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuTextbox3.Icon = CType(resources.GetObject("BunifuTextbox3.Icon"), System.Drawing.Image)
        Me.BunifuTextbox3.Location = New System.Drawing.Point(81, 135)
        Me.BunifuTextbox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuTextbox3.Name = "BunifuTextbox3"
        Me.BunifuTextbox3.Size = New System.Drawing.Size(205, 36)
        Me.BunifuTextbox3.TabIndex = 4
        Me.BunifuTextbox3.text = "Bunifu TextBox"
        '
        'BunifuTextbox4
        '
        Me.BunifuTextbox4.BackColor = System.Drawing.Color.Silver
        Me.BunifuTextbox4.BackgroundImage = CType(resources.GetObject("BunifuTextbox4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox4.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuTextbox4.Icon = CType(resources.GetObject("BunifuTextbox4.Icon"), System.Drawing.Image)
        Me.BunifuTextbox4.Location = New System.Drawing.Point(81, 182)
        Me.BunifuTextbox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuTextbox4.Name = "BunifuTextbox4"
        Me.BunifuTextbox4.Size = New System.Drawing.Size(205, 36)
        Me.BunifuTextbox4.TabIndex = 3
        Me.BunifuTextbox4.text = "Bunifu TextBox"
        '
        'BunifuTextbox2
        '
        Me.BunifuTextbox2.BackColor = System.Drawing.Color.Silver
        Me.BunifuTextbox2.BackgroundImage = CType(resources.GetObject("BunifuTextbox2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox2.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuTextbox2.Icon = CType(resources.GetObject("BunifuTextbox2.Icon"), System.Drawing.Image)
        Me.BunifuTextbox2.Location = New System.Drawing.Point(81, 91)
        Me.BunifuTextbox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuTextbox2.Name = "BunifuTextbox2"
        Me.BunifuTextbox2.Size = New System.Drawing.Size(205, 36)
        Me.BunifuTextbox2.TabIndex = 2
        Me.BunifuTextbox2.text = "Bunifu TextBox"
        '
        'BunifuTextbox1
        '
        Me.BunifuTextbox1.BackColor = System.Drawing.Color.Silver
        Me.BunifuTextbox1.BackgroundImage = CType(resources.GetObject("BunifuTextbox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuTextbox1.Icon = CType(resources.GetObject("BunifuTextbox1.Icon"), System.Drawing.Image)
        Me.BunifuTextbox1.Location = New System.Drawing.Point(81, 47)
        Me.BunifuTextbox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuTextbox1.Name = "BunifuTextbox1"
        Me.BunifuTextbox1.Size = New System.Drawing.Size(205, 36)
        Me.BunifuTextbox1.TabIndex = 0
        Me.BunifuTextbox1.text = "Bunifu TextBox"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 18
        Me.BunifuElipse1.TargetControl = Me.BunifuCustomLabel2
        '
        'Stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Stocks"
        Me.Size = New System.Drawing.Size(1203, 728)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuTextbox3 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuTextbox4 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuTextbox2 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuTextbox1 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuTextbox5 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuTextbox6 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BunifuTextbox7 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
End Class
