<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sell
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TitleBarPanel = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Panel()
        Me.CloseText = New System.Windows.Forms.Label()
        Me.TitleBarLabel = New System.Windows.Forms.Label()
        Me.BackgroundPanel = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.QText = New System.Windows.Forms.TextBox()
        Me.QLabel = New System.Windows.Forms.Label()
        Me.SaleText = New System.Windows.Forms.TextBox()
        Me.SaleLabel = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.UnText = New System.Windows.Forms.Label()
        Me.SellLabel = New System.Windows.Forms.Label()
        Me.PriceText = New System.Windows.Forms.Label()
        Me.LootAvatar = New System.Windows.Forms.PictureBox()
        Me.CSellButton = New System.Windows.Forms.Button()
        Me.SaleButton = New System.Windows.Forms.Button()
        Me.OwnText = New System.Windows.Forms.Label()
        Me.OwnLabel = New System.Windows.Forms.Label()
        Me.StLabel = New System.Windows.Forms.Label()
        Me.EndLabel = New System.Windows.Forms.Label()
        Me.ExText = New System.Windows.Forms.Label()
        Me.FirstText = New System.Windows.Forms.Label()
        Me.DescText = New System.Windows.Forms.TextBox()
        Me.ItemText = New System.Windows.Forms.Label()
        Me.CrText = New System.Windows.Forms.TextBox()
        Me.CrLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.SPText = New System.Windows.Forms.TextBox()
        Me.SPLabel = New System.Windows.Forms.Label()
        Me.TitleBarPanel.SuspendLayout()
        Me.CloseButton.SuspendLayout()
        Me.BackgroundPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        CType(Me.LootAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleBarPanel
        '
        Me.TitleBarPanel.BackColor = System.Drawing.Color.DarkBlue
        Me.TitleBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TitleBarPanel.Controls.Add(Me.CloseButton)
        Me.TitleBarPanel.Controls.Add(Me.TitleBarLabel)
        Me.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBarPanel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TitleBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.TitleBarPanel.Name = "TitleBarPanel"
        Me.TitleBarPanel.Size = New System.Drawing.Size(698, 30)
        Me.TitleBarPanel.TabIndex = 11
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.WindowText
        Me.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CloseButton.Controls.Add(Me.CloseText)
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CloseButton.Location = New System.Drawing.Point(669, 4)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(20, 17)
        Me.CloseButton.TabIndex = 2
        '
        'CloseText
        '
        Me.CloseText.AutoSize = True
        Me.CloseText.BackColor = System.Drawing.Color.DarkBlue
        Me.CloseText.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CloseText.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.CloseText.ForeColor = System.Drawing.Color.Gainsboro
        Me.CloseText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CloseText.Location = New System.Drawing.Point(0, 0)
        Me.CloseText.Name = "CloseText"
        Me.CloseText.Size = New System.Drawing.Size(17, 15)
        Me.CloseText.TabIndex = 1
        Me.CloseText.Text = "X"
        '
        'TitleBarLabel
        '
        Me.TitleBarLabel.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TitleBarLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TitleBarLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TitleBarLabel.Location = New System.Drawing.Point(0, 3)
        Me.TitleBarLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.TitleBarLabel.Name = "TitleBarLabel"
        Me.TitleBarLabel.Size = New System.Drawing.Size(689, 20)
        Me.TitleBarLabel.TabIndex = 0
        Me.TitleBarLabel.Text = "LootSim Sell Panel"
        Me.TitleBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundPanel
        '
        Me.BackgroundPanel.BackColor = System.Drawing.Color.Black
        Me.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BackgroundPanel.Controls.Add(Me.MainPanel)
        Me.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackgroundPanel.Location = New System.Drawing.Point(0, 30)
        Me.BackgroundPanel.Name = "BackgroundPanel"
        Me.BackgroundPanel.Size = New System.Drawing.Size(698, 233)
        Me.BackgroundPanel.TabIndex = 12
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Navy
        Me.MainPanel.Controls.Add(Me.SPLabel)
        Me.MainPanel.Controls.Add(Me.SPText)
        Me.MainPanel.Controls.Add(Me.QText)
        Me.MainPanel.Controls.Add(Me.QLabel)
        Me.MainPanel.Controls.Add(Me.SaleText)
        Me.MainPanel.Controls.Add(Me.SaleLabel)
        Me.MainPanel.Controls.Add(Me.StatusLabel)
        Me.MainPanel.Controls.Add(Me.UnText)
        Me.MainPanel.Controls.Add(Me.SellLabel)
        Me.MainPanel.Controls.Add(Me.PriceText)
        Me.MainPanel.Controls.Add(Me.LootAvatar)
        Me.MainPanel.Controls.Add(Me.CSellButton)
        Me.MainPanel.Controls.Add(Me.SaleButton)
        Me.MainPanel.Controls.Add(Me.OwnText)
        Me.MainPanel.Controls.Add(Me.OwnLabel)
        Me.MainPanel.Controls.Add(Me.StLabel)
        Me.MainPanel.Controls.Add(Me.EndLabel)
        Me.MainPanel.Controls.Add(Me.ExText)
        Me.MainPanel.Controls.Add(Me.FirstText)
        Me.MainPanel.Controls.Add(Me.DescText)
        Me.MainPanel.Controls.Add(Me.ItemText)
        Me.MainPanel.Controls.Add(Me.CrText)
        Me.MainPanel.Controls.Add(Me.CrLabel)
        Me.MainPanel.Controls.Add(Me.PriceLabel)
        Me.MainPanel.Location = New System.Drawing.Point(5, 6)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(683, 218)
        Me.MainPanel.TabIndex = 1
        '
        'QText
        '
        Me.QText.BackColor = System.Drawing.Color.Navy
        Me.QText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.QText.Location = New System.Drawing.Point(558, 108)
        Me.QText.MaxLength = 64
        Me.QText.Name = "QText"
        Me.QText.Size = New System.Drawing.Size(119, 20)
        Me.QText.TabIndex = 43
        Me.QText.Text = "###"
        Me.QText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'QLabel
        '
        Me.QLabel.ForeColor = System.Drawing.Color.DarkOrchid
        Me.QLabel.Location = New System.Drawing.Point(455, 111)
        Me.QLabel.Name = "QLabel"
        Me.QLabel.Size = New System.Drawing.Size(97, 13)
        Me.QLabel.TabIndex = 42
        Me.QLabel.Text = "Quantity:"
        Me.QLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SaleText
        '
        Me.SaleText.BackColor = System.Drawing.Color.Navy
        Me.SaleText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SaleText.Location = New System.Drawing.Point(558, 82)
        Me.SaleText.MaxLength = 64
        Me.SaleText.Name = "SaleText"
        Me.SaleText.Size = New System.Drawing.Size(119, 20)
        Me.SaleText.TabIndex = 41
        Me.SaleText.Text = "###"
        Me.SaleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SaleLabel
        '
        Me.SaleLabel.ForeColor = System.Drawing.Color.DeepPink
        Me.SaleLabel.Location = New System.Drawing.Point(455, 85)
        Me.SaleLabel.Name = "SaleLabel"
        Me.SaleLabel.Size = New System.Drawing.Size(97, 13)
        Me.SaleLabel.TabIndex = 40
        Me.SaleLabel.Text = "Sell Price:"
        Me.SaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StatusLabel
        '
        Me.StatusLabel.Location = New System.Drawing.Point(341, 189)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(209, 13)
        Me.StatusLabel.TabIndex = 39
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UnText
        '
        Me.UnText.Location = New System.Drawing.Point(452, 7)
        Me.UnText.Name = "UnText"
        Me.UnText.Size = New System.Drawing.Size(225, 13)
        Me.UnText.TabIndex = 38
        Me.UnText.Text = "[username]"
        Me.UnText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SellLabel
        '
        Me.SellLabel.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellLabel.ForeColor = System.Drawing.Color.Lime
        Me.SellLabel.Location = New System.Drawing.Point(452, 62)
        Me.SellLabel.Name = "SellLabel"
        Me.SellLabel.Size = New System.Drawing.Size(225, 13)
        Me.SellLabel.TabIndex = 37
        Me.SellLabel.Text = "Sell on the Marketplace!"
        '
        'PriceText
        '
        Me.PriceText.Location = New System.Drawing.Point(288, 135)
        Me.PriceText.Name = "PriceText"
        Me.PriceText.Size = New System.Drawing.Size(138, 13)
        Me.PriceText.TabIndex = 36
        Me.PriceText.Text = "###"
        Me.PriceText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LootAvatar
        '
        Me.LootAvatar.BackColor = System.Drawing.Color.Black
        Me.LootAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LootAvatar.Location = New System.Drawing.Point(8, 7)
        Me.LootAvatar.Name = "LootAvatar"
        Me.LootAvatar.Size = New System.Drawing.Size(200, 200)
        Me.LootAvatar.TabIndex = 34
        Me.LootAvatar.TabStop = False
        '
        'CSellButton
        '
        Me.CSellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CSellButton.Location = New System.Drawing.Point(227, 184)
        Me.CSellButton.Name = "CSellButton"
        Me.CSellButton.Size = New System.Drawing.Size(107, 23)
        Me.CSellButton.TabIndex = 32
        Me.CSellButton.Text = "Cancel Sell"
        Me.CSellButton.UseVisualStyleBackColor = True
        '
        'SaleButton
        '
        Me.SaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaleButton.Location = New System.Drawing.Point(555, 184)
        Me.SaleButton.Name = "SaleButton"
        Me.SaleButton.Size = New System.Drawing.Size(122, 23)
        Me.SaleButton.TabIndex = 29
        Me.SaleButton.Text = "List For Sale"
        Me.SaleButton.UseVisualStyleBackColor = True
        '
        'OwnText
        '
        Me.OwnText.Location = New System.Drawing.Point(288, 155)
        Me.OwnText.Name = "OwnText"
        Me.OwnText.Size = New System.Drawing.Size(138, 13)
        Me.OwnText.TabIndex = 28
        Me.OwnText.Text = "###"
        Me.OwnText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OwnLabel
        '
        Me.OwnLabel.ForeColor = System.Drawing.Color.Aqua
        Me.OwnLabel.Location = New System.Drawing.Point(232, 155)
        Me.OwnLabel.Name = "OwnLabel"
        Me.OwnLabel.Size = New System.Drawing.Size(55, 13)
        Me.OwnLabel.TabIndex = 27
        Me.OwnLabel.Text = "Owned:"
        Me.OwnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StLabel
        '
        Me.StLabel.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.StLabel.Location = New System.Drawing.Point(227, 95)
        Me.StLabel.Name = "StLabel"
        Me.StLabel.Size = New System.Drawing.Size(61, 13)
        Me.StLabel.TabIndex = 26
        Me.StLabel.Text = "Start:"
        Me.StLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EndLabel
        '
        Me.EndLabel.ForeColor = System.Drawing.Color.LightCoral
        Me.EndLabel.Location = New System.Drawing.Point(224, 115)
        Me.EndLabel.Name = "EndLabel"
        Me.EndLabel.Size = New System.Drawing.Size(64, 13)
        Me.EndLabel.TabIndex = 25
        Me.EndLabel.Text = "End:"
        Me.EndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ExText
        '
        Me.ExText.Location = New System.Drawing.Point(286, 115)
        Me.ExText.Name = "ExText"
        Me.ExText.Size = New System.Drawing.Size(141, 13)
        Me.ExText.TabIndex = 24
        Me.ExText.Text = "[date]"
        Me.ExText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FirstText
        '
        Me.FirstText.Location = New System.Drawing.Point(286, 95)
        Me.FirstText.Name = "FirstText"
        Me.FirstText.Size = New System.Drawing.Size(141, 13)
        Me.FirstText.TabIndex = 23
        Me.FirstText.Text = "[date]"
        Me.FirstText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescText
        '
        Me.DescText.BackColor = System.Drawing.Color.Navy
        Me.DescText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DescText.Location = New System.Drawing.Point(227, 29)
        Me.DescText.MaxLength = 64
        Me.DescText.Multiline = True
        Me.DescText.Name = "DescText"
        Me.DescText.ReadOnly = True
        Me.DescText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescText.Size = New System.Drawing.Size(200, 55)
        Me.DescText.TabIndex = 22
        Me.DescText.Text = "description here"
        Me.DescText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ItemText
        '
        Me.ItemText.Location = New System.Drawing.Point(227, 7)
        Me.ItemText.Name = "ItemText"
        Me.ItemText.Size = New System.Drawing.Size(200, 13)
        Me.ItemText.TabIndex = 21
        Me.ItemText.Text = "[itemname]"
        Me.ItemText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CrText
        '
        Me.CrText.BackColor = System.Drawing.Color.Navy
        Me.CrText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CrText.Location = New System.Drawing.Point(558, 33)
        Me.CrText.MaxLength = 64
        Me.CrText.Name = "CrText"
        Me.CrText.ReadOnly = True
        Me.CrText.Size = New System.Drawing.Size(119, 20)
        Me.CrText.TabIndex = 14
        Me.CrText.Text = "###"
        Me.CrText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CrLabel
        '
        Me.CrLabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.CrLabel.Location = New System.Drawing.Point(455, 36)
        Me.CrLabel.Name = "CrLabel"
        Me.CrLabel.Size = New System.Drawing.Size(97, 13)
        Me.CrLabel.TabIndex = 13
        Me.CrLabel.Text = "Credits:"
        Me.CrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PriceLabel
        '
        Me.PriceLabel.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLabel.ForeColor = System.Drawing.Color.Lime
        Me.PriceLabel.Location = New System.Drawing.Point(198, 133)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(87, 13)
        Me.PriceLabel.TabIndex = 35
        Me.PriceLabel.Text = "Est. Value:"
        Me.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SPText
        '
        Me.SPText.BackColor = System.Drawing.Color.Navy
        Me.SPText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SPText.Location = New System.Drawing.Point(503, 132)
        Me.SPText.MaxLength = 40
        Me.SPText.Multiline = True
        Me.SPText.Name = "SPText"
        Me.SPText.ReadOnly = True
        Me.SPText.Size = New System.Drawing.Size(174, 46)
        Me.SPText.TabIndex = 44
        Me.SPText.Text = "I am selling this."
        '
        'SPLabel
        '
        Me.SPLabel.ForeColor = System.Drawing.Color.Yellow
        Me.SPLabel.Location = New System.Drawing.Point(432, 138)
        Me.SPLabel.Name = "SPLabel"
        Me.SPLabel.Size = New System.Drawing.Size(70, 30)
        Me.SPLabel.TabIndex = 45
        Me.SPLabel.Text = "Sales Pitch:"
        Me.SPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Sell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(698, 263)
        Me.Controls.Add(Me.BackgroundPanel)
        Me.Controls.Add(Me.TitleBarPanel)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Sell"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sell"
        Me.TitleBarPanel.ResumeLayout(False)
        Me.CloseButton.ResumeLayout(False)
        Me.CloseButton.PerformLayout()
        Me.BackgroundPanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.LootAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleBarPanel As Panel
    Friend WithEvents CloseButton As Panel
    Friend WithEvents CloseText As Label
    Friend WithEvents TitleBarLabel As Label
    Friend WithEvents BackgroundPanel As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents SellLabel As Label
    Friend WithEvents PriceText As Label
    Friend WithEvents LootAvatar As PictureBox
    Friend WithEvents SaleButton As Button
    Friend WithEvents OwnText As Label
    Friend WithEvents OwnLabel As Label
    Friend WithEvents StLabel As Label
    Friend WithEvents EndLabel As Label
    Friend WithEvents ExText As Label
    Friend WithEvents FirstText As Label
    Friend WithEvents DescText As TextBox
    Friend WithEvents ItemText As Label
    Friend WithEvents CrText As TextBox
    Friend WithEvents CrLabel As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents UnText As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents CSellButton As Button
    Friend WithEvents QText As TextBox
    Friend WithEvents QLabel As Label
    Friend WithEvents SaleText As TextBox
    Friend WithEvents SaleLabel As Label
    Friend WithEvents SPLabel As Label
    Friend WithEvents SPText As TextBox
End Class
