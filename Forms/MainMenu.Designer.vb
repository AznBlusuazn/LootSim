<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.OptionsButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.CTGLabel = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.CreditsLabel = New System.Windows.Forms.Label()
        Me.UserLabel = New System.Windows.Forms.Label()
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
        Me.TitleBarPanel.Size = New System.Drawing.Size(780, 30)
        Me.TitleBarPanel.TabIndex = 9
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.WindowText
        Me.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CloseButton.Controls.Add(Me.CloseText)
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CloseButton.Location = New System.Drawing.Point(752, 4)
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
        Me.TitleBarLabel.Size = New System.Drawing.Size(753, 20)
        Me.TitleBarLabel.TabIndex = 0
        Me.TitleBarLabel.Text = "LootSim"
        Me.TitleBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundPanel
        '
        Me.BackgroundPanel.BackColor = System.Drawing.Color.Black
        Me.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BackgroundPanel.Controls.Add(Me.MainPanel)
        Me.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackgroundPanel.Location = New System.Drawing.Point(0, 0)
        Me.BackgroundPanel.Name = "BackgroundPanel"
        Me.BackgroundPanel.Size = New System.Drawing.Size(780, 557)
        Me.BackgroundPanel.TabIndex = 10
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Navy
        Me.MainPanel.Controls.Add(Me.ExitButton)
        Me.MainPanel.Controls.Add(Me.AboutButton)
        Me.MainPanel.Controls.Add(Me.OptionsButton)
        Me.MainPanel.Controls.Add(Me.StartButton)
        Me.MainPanel.Controls.Add(Me.CTGLabel)
        Me.MainPanel.Controls.Add(Me.VersionLabel)
        Me.MainPanel.Controls.Add(Me.TitleLabel)
        Me.MainPanel.Controls.Add(Me.CreditsLabel)
        Me.MainPanel.Controls.Add(Me.UserLabel)
        Me.MainPanel.Location = New System.Drawing.Point(5, 35)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(766, 510)
        Me.MainPanel.TabIndex = 0
        '
        'ExitButton
        '
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Location = New System.Drawing.Point(334, 406)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(100, 23)
        Me.ExitButton.TabIndex = 17
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AboutButton
        '
        Me.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutButton.Location = New System.Drawing.Point(334, 331)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(100, 23)
        Me.AboutButton.TabIndex = 16
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'OptionsButton
        '
        Me.OptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptionsButton.Location = New System.Drawing.Point(334, 256)
        Me.OptionsButton.Name = "OptionsButton"
        Me.OptionsButton.Size = New System.Drawing.Size(100, 23)
        Me.OptionsButton.TabIndex = 15
        Me.OptionsButton.Text = "Options"
        Me.OptionsButton.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Location = New System.Drawing.Point(334, 181)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(100, 23)
        Me.StartButton.TabIndex = 14
        Me.StartButton.Text = "Loot!"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'CTGLabel
        '
        Me.CTGLabel.ForeColor = System.Drawing.Color.Orange
        Me.CTGLabel.Location = New System.Drawing.Point(2, 491)
        Me.CTGLabel.Name = "CTGLabel"
        Me.CTGLabel.Size = New System.Drawing.Size(380, 13)
        Me.CTGLabel.TabIndex = 13
        Me.CTGLabel.Text = "Created by ClarkTribeGames, LLC"
        Me.CTGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VersionLabel
        '
        Me.VersionLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.VersionLabel.Location = New System.Drawing.Point(2, 471)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(380, 13)
        Me.VersionLabel.TabIndex = 12
        Me.VersionLabel.Text = "LootSim v#.#.###.####"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TitleLabel
        '
        Me.TitleLabel.BackColor = System.Drawing.Color.Black
        Me.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TitleLabel.Location = New System.Drawing.Point(264, 6)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(240, 120)
        Me.TitleLabel.TabIndex = 11
        Me.TitleLabel.Text = "LootSimGraphicHere"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CreditsLabel
        '
        Me.CreditsLabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.CreditsLabel.Location = New System.Drawing.Point(384, 491)
        Me.CreditsLabel.Name = "CreditsLabel"
        Me.CreditsLabel.Size = New System.Drawing.Size(380, 13)
        Me.CreditsLabel.TabIndex = 10
        Me.CreditsLabel.Text = "Log In With CTG Account"
        Me.CreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UserLabel
        '
        Me.UserLabel.Location = New System.Drawing.Point(384, 471)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(380, 13)
        Me.UserLabel.TabIndex = 9
        Me.UserLabel.Text = "[Not Logged In]"
        Me.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MainMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(780, 557)
        Me.Controls.Add(Me.TitleBarPanel)
        Me.Controls.Add(Me.BackgroundPanel)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fixed3D"
        Me.TitleBarPanel.ResumeLayout(False)
        Me.CloseButton.ResumeLayout(False)
        Me.CloseButton.PerformLayout()
        Me.BackgroundPanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleBarPanel As Panel
    Friend WithEvents CloseButton As Panel
    Friend WithEvents CloseText As Label
    Friend WithEvents TitleBarLabel As Label
    Friend WithEvents BackgroundPanel As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents ExitButton As Button
    Friend WithEvents AboutButton As Button
    Friend WithEvents OptionsButton As Button
    Friend WithEvents StartButton As Button
    Friend WithEvents CTGLabel As Label
    Friend WithEvents VersionLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents CreditsLabel As Label
    Friend WithEvents UserLabel As Label
End Class
