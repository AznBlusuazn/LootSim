<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.PassText = New System.Windows.Forms.TextBox()
        Me.UserText = New System.Windows.Forms.TextBox()
        Me.PassLabel = New System.Windows.Forms.Label()
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
        Me.TitleBarPanel.Size = New System.Drawing.Size(300, 30)
        Me.TitleBarPanel.TabIndex = 10
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.WindowText
        Me.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CloseButton.Controls.Add(Me.CloseText)
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.CloseButton.Location = New System.Drawing.Point(272, 4)
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
        Me.TitleBarLabel.Size = New System.Drawing.Size(296, 20)
        Me.TitleBarLabel.TabIndex = 0
        Me.TitleBarLabel.Text = "Login"
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
        Me.BackgroundPanel.Size = New System.Drawing.Size(300, 270)
        Me.BackgroundPanel.TabIndex = 11
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Navy
        Me.MainPanel.Controls.Add(Me.CancelButton)
        Me.MainPanel.Controls.Add(Me.LoginButton)
        Me.MainPanel.Controls.Add(Me.PassText)
        Me.MainPanel.Controls.Add(Me.UserText)
        Me.MainPanel.Controls.Add(Me.PassLabel)
        Me.MainPanel.Controls.Add(Me.UserLabel)
        Me.MainPanel.Location = New System.Drawing.Point(8, 6)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(280, 252)
        Me.MainPanel.TabIndex = 0
        '
        'CancelButton
        '
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Location = New System.Drawing.Point(142, 174)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(100, 23)
        Me.CancelButton.TabIndex = 16
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'LoginButton
        '
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Location = New System.Drawing.Point(36, 174)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(100, 23)
        Me.LoginButton.TabIndex = 15
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'PassText
        '
        Me.PassText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PassText.ForeColor = System.Drawing.Color.Black
        Me.PassText.Location = New System.Drawing.Point(105, 107)
        Me.PassText.MaxLength = 64
        Me.PassText.Name = "PassText"
        Me.PassText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassText.Size = New System.Drawing.Size(153, 20)
        Me.PassText.TabIndex = 3
        '
        'UserText
        '
        Me.UserText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UserText.ForeColor = System.Drawing.Color.Black
        Me.UserText.Location = New System.Drawing.Point(105, 72)
        Me.UserText.MaxLength = 64
        Me.UserText.Name = "UserText"
        Me.UserText.Size = New System.Drawing.Size(153, 20)
        Me.UserText.TabIndex = 2
        '
        'PassLabel
        '
        Me.PassLabel.Location = New System.Drawing.Point(11, 110)
        Me.PassLabel.Name = "PassLabel"
        Me.PassLabel.Size = New System.Drawing.Size(88, 13)
        Me.PassLabel.TabIndex = 1
        Me.PassLabel.Text = "Password:"
        Me.PassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UserLabel
        '
        Me.UserLabel.Location = New System.Drawing.Point(11, 75)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(88, 13)
        Me.UserLabel.TabIndex = 0
        Me.UserLabel.Text = "Username:"
        Me.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.BackgroundPanel)
        Me.Controls.Add(Me.TitleBarPanel)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
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
    Friend WithEvents PassText As TextBox
    Friend WithEvents UserText As TextBox
    Friend WithEvents PassLabel As Label
    Friend WithEvents UserLabel As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents LoginButton As Button
End Class
