<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User
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
        Me.TitleBarPanel = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Panel()
        Me.CloseText = New System.Windows.Forms.Label()
        Me.TitleBarLabel = New System.Windows.Forms.Label()
        Me.BackgroundPanel = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.StLabel = New System.Windows.Forms.Label()
        Me.EndLabel = New System.Windows.Forms.Label()
        Me.ExText = New System.Windows.Forms.Label()
        Me.FirstText = New System.Windows.Forms.Label()
        Me.DescText = New System.Windows.Forms.TextBox()
        Me.ItemText = New System.Windows.Forms.Label()
        Me.ItemAvatar = New System.Windows.Forms.Label()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.InvList = New System.Windows.Forms.ListBox()
        Me.CheckButton = New System.Windows.Forms.Button()
        Me.ChText = New System.Windows.Forms.Label()
        Me.ChLabel = New System.Windows.Forms.Label()
        Me.CrText = New System.Windows.Forms.TextBox()
        Me.CrLabel = New System.Windows.Forms.Label()
        Me.UnText = New System.Windows.Forms.Label()
        Me.UserAvatar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SeButton = New System.Windows.Forms.Button()
        Me.TrButton = New System.Windows.Forms.Button()
        Me.MarketButton = New System.Windows.Forms.Button()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.TitleBarPanel.SuspendLayout()
        Me.CloseButton.SuspendLayout()
        Me.BackgroundPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
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
        Me.TitleBarPanel.Size = New System.Drawing.Size(747, 30)
        Me.TitleBarPanel.TabIndex = 10
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.WindowText
        Me.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CloseButton.Controls.Add(Me.CloseText)
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CloseButton.Location = New System.Drawing.Point(722, 4)
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
        Me.TitleBarLabel.Size = New System.Drawing.Size(743, 20)
        Me.TitleBarLabel.TabIndex = 0
        Me.TitleBarLabel.Text = "LootSim User Panel"
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
        Me.BackgroundPanel.Size = New System.Drawing.Size(747, 438)
        Me.BackgroundPanel.TabIndex = 11
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Navy
        Me.MainPanel.Controls.Add(Me.ReturnButton)
        Me.MainPanel.Controls.Add(Me.MarketButton)
        Me.MainPanel.Controls.Add(Me.TrButton)
        Me.MainPanel.Controls.Add(Me.SeButton)
        Me.MainPanel.Controls.Add(Me.Label2)
        Me.MainPanel.Controls.Add(Me.Label1)
        Me.MainPanel.Controls.Add(Me.StLabel)
        Me.MainPanel.Controls.Add(Me.EndLabel)
        Me.MainPanel.Controls.Add(Me.ExText)
        Me.MainPanel.Controls.Add(Me.FirstText)
        Me.MainPanel.Controls.Add(Me.DescText)
        Me.MainPanel.Controls.Add(Me.ItemText)
        Me.MainPanel.Controls.Add(Me.ItemAvatar)
        Me.MainPanel.Controls.Add(Me.GoButton)
        Me.MainPanel.Controls.Add(Me.InvList)
        Me.MainPanel.Controls.Add(Me.CheckButton)
        Me.MainPanel.Controls.Add(Me.ChText)
        Me.MainPanel.Controls.Add(Me.ChLabel)
        Me.MainPanel.Controls.Add(Me.CrText)
        Me.MainPanel.Controls.Add(Me.CrLabel)
        Me.MainPanel.Controls.Add(Me.UnText)
        Me.MainPanel.Controls.Add(Me.UserAvatar)
        Me.MainPanel.Location = New System.Drawing.Point(5, 6)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(730, 421)
        Me.MainPanel.TabIndex = 1
        '
        'StLabel
        '
        Me.StLabel.ForeColor = System.Drawing.Color.PaleGreen
        Me.StLabel.Location = New System.Drawing.Point(520, 320)
        Me.StLabel.Name = "StLabel"
        Me.StLabel.Size = New System.Drawing.Size(61, 13)
        Me.StLabel.TabIndex = 26
        Me.StLabel.Text = "Start:"
        Me.StLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EndLabel
        '
        Me.EndLabel.ForeColor = System.Drawing.Color.LightCoral
        Me.EndLabel.Location = New System.Drawing.Point(517, 345)
        Me.EndLabel.Name = "EndLabel"
        Me.EndLabel.Size = New System.Drawing.Size(64, 13)
        Me.EndLabel.TabIndex = 25
        Me.EndLabel.Text = "End:"
        Me.EndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ExText
        '
        Me.ExText.Location = New System.Drawing.Point(576, 345)
        Me.ExText.Name = "ExText"
        Me.ExText.Size = New System.Drawing.Size(144, 13)
        Me.ExText.TabIndex = 24
        Me.ExText.Text = "[date]"
        Me.ExText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FirstText
        '
        Me.FirstText.Location = New System.Drawing.Point(576, 320)
        Me.FirstText.Name = "FirstText"
        Me.FirstText.Size = New System.Drawing.Size(144, 13)
        Me.FirstText.TabIndex = 23
        Me.FirstText.Text = "[date]"
        Me.FirstText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescText
        '
        Me.DescText.BackColor = System.Drawing.Color.Navy
        Me.DescText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DescText.Location = New System.Drawing.Point(520, 237)
        Me.DescText.MaxLength = 64
        Me.DescText.Multiline = True
        Me.DescText.Name = "DescText"
        Me.DescText.ReadOnly = True
        Me.DescText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescText.Size = New System.Drawing.Size(200, 71)
        Me.DescText.TabIndex = 22
        Me.DescText.Text = "description here"
        Me.DescText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ItemText
        '
        Me.ItemText.Location = New System.Drawing.Point(520, 215)
        Me.ItemText.Name = "ItemText"
        Me.ItemText.Size = New System.Drawing.Size(200, 13)
        Me.ItemText.TabIndex = 21
        Me.ItemText.Text = "[itemname]"
        Me.ItemText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ItemAvatar
        '
        Me.ItemAvatar.BackColor = System.Drawing.Color.Black
        Me.ItemAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemAvatar.Location = New System.Drawing.Point(520, 7)
        Me.ItemAvatar.Name = "ItemAvatar"
        Me.ItemAvatar.Size = New System.Drawing.Size(200, 200)
        Me.ItemAvatar.TabIndex = 20
        Me.ItemAvatar.Text = "ItemAvatar"
        Me.ItemAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GoButton
        '
        Me.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoButton.Location = New System.Drawing.Point(8, 315)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(197, 23)
        Me.GoButton.TabIndex = 19
        Me.GoButton.Text = "Loot!"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'InvList
        '
        Me.InvList.BackColor = System.Drawing.Color.DarkBlue
        Me.InvList.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.InvList.FormattingEnabled = True
        Me.InvList.Location = New System.Drawing.Point(235, 7)
        Me.InvList.Name = "InvList"
        Me.InvList.Size = New System.Drawing.Size(250, 407)
        Me.InvList.TabIndex = 18
        '
        'CheckButton
        '
        Me.CheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckButton.Location = New System.Drawing.Point(8, 285)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(197, 23)
        Me.CheckButton.TabIndex = 17
        Me.CheckButton.Text = "Get Loot Checks"
        Me.CheckButton.UseVisualStyleBackColor = True
        '
        'ChText
        '
        Me.ChText.Location = New System.Drawing.Point(145, 265)
        Me.ChText.Name = "ChText"
        Me.ChText.Size = New System.Drawing.Size(60, 13)
        Me.ChText.TabIndex = 16
        Me.ChText.Text = "###"
        Me.ChText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChLabel
        '
        Me.ChLabel.ForeColor = System.Drawing.Color.DarkSalmon
        Me.ChLabel.Location = New System.Drawing.Point(5, 265)
        Me.ChLabel.Name = "ChLabel"
        Me.ChLabel.Size = New System.Drawing.Size(145, 13)
        Me.ChLabel.TabIndex = 15
        Me.ChLabel.Text = "Checks Available:"
        Me.ChLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CrText
        '
        Me.CrText.BackColor = System.Drawing.Color.Navy
        Me.CrText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CrText.Location = New System.Drawing.Point(86, 237)
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
        Me.CrLabel.Location = New System.Drawing.Point(5, 240)
        Me.CrLabel.Name = "CrLabel"
        Me.CrLabel.Size = New System.Drawing.Size(75, 13)
        Me.CrLabel.TabIndex = 13
        Me.CrLabel.Text = "Credits:"
        Me.CrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UnText
        '
        Me.UnText.Location = New System.Drawing.Point(5, 215)
        Me.UnText.Name = "UnText"
        Me.UnText.Size = New System.Drawing.Size(200, 13)
        Me.UnText.TabIndex = 12
        Me.UnText.Text = "[username]"
        Me.UnText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserAvatar
        '
        Me.UserAvatar.BackColor = System.Drawing.Color.Black
        Me.UserAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserAvatar.Location = New System.Drawing.Point(5, 5)
        Me.UserAvatar.Name = "UserAvatar"
        Me.UserAvatar.Size = New System.Drawing.Size(200, 200)
        Me.UserAvatar.TabIndex = 11
        Me.UserAvatar.Text = "UserAvatar"
        Me.UserAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(517, 370)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Owned:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(576, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "###"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SeButton
        '
        Me.SeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SeButton.Location = New System.Drawing.Point(520, 391)
        Me.SeButton.Name = "SeButton"
        Me.SeButton.Size = New System.Drawing.Size(97, 23)
        Me.SeButton.TabIndex = 29
        Me.SeButton.Text = "Sell"
        Me.SeButton.UseVisualStyleBackColor = True
        '
        'TrButton
        '
        Me.TrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TrButton.Location = New System.Drawing.Point(623, 391)
        Me.TrButton.Name = "TrButton"
        Me.TrButton.Size = New System.Drawing.Size(97, 23)
        Me.TrButton.TabIndex = 30
        Me.TrButton.Text = "Trade"
        Me.TrButton.UseVisualStyleBackColor = True
        '
        'MarketButton
        '
        Me.MarketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MarketButton.Location = New System.Drawing.Point(8, 345)
        Me.MarketButton.Name = "MarketButton"
        Me.MarketButton.Size = New System.Drawing.Size(197, 23)
        Me.MarketButton.TabIndex = 31
        Me.MarketButton.Text = "Visit Marketplace"
        Me.MarketButton.UseVisualStyleBackColor = True
        '
        'ReturnButton
        '
        Me.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReturnButton.Location = New System.Drawing.Point(8, 391)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(197, 23)
        Me.ReturnButton.TabIndex = 32
        Me.ReturnButton.Text = "Back To Main Menu"
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'User
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(747, 468)
        Me.Controls.Add(Me.BackgroundPanel)
        Me.Controls.Add(Me.TitleBarPanel)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User"
        Me.TitleBarPanel.ResumeLayout(False)
        Me.CloseButton.ResumeLayout(False)
        Me.CloseButton.PerformLayout()
        Me.BackgroundPanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleBarPanel As Panel
    Friend WithEvents CloseButton As Panel
    Friend WithEvents CloseText As Label
    Friend WithEvents TitleBarLabel As Label
    Friend WithEvents BackgroundPanel As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents CrLabel As Label
    Friend WithEvents UnText As Label
    Friend WithEvents UserAvatar As Label
    Friend WithEvents ChText As Label
    Friend WithEvents ChLabel As Label
    Friend WithEvents CrText As TextBox
    Friend WithEvents GoButton As Button
    Friend WithEvents InvList As ListBox
    Friend WithEvents CheckButton As Button
    Friend WithEvents ItemAvatar As Label
    Friend WithEvents StLabel As Label
    Friend WithEvents EndLabel As Label
    Friend WithEvents ExText As Label
    Friend WithEvents FirstText As Label
    Friend WithEvents DescText As TextBox
    Friend WithEvents ItemText As Label
    Friend WithEvents ReturnButton As Button
    Friend WithEvents MarketButton As Button
    Friend WithEvents TrButton As Button
    Friend WithEvents SeButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
