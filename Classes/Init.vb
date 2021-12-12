Public Class Init
    Public Shared Sub InitMainMenu()
        'TO DO: add version check here
        Dim gametitle As String = Application.ProductName & " v" & ClarkTribeGames.Converters.GetVersion(Application.ProductVersion)
        MainMenu.TitleBarLabel.Text = gametitle
        MainMenu.VersionLabel.Text = gametitle
        Dim Baelfire As String = Mem.AllMagic
        Dim TheDagger As New ClarkTribeGames.Coder(Application.CompanyName)
        Mem.AllMagic = TheDagger.DecryptData(Baelfire)
        InitSettings()
        Login.LoginCheck()
        MainMenu.CheckStartButton()
        '2 buttons are temporarily disabled
        Appearance.FlipButton(False, MainMenu.AboutButton)
        Appearance.FlipButton(False, MainMenu.OptionsButton)
    End Sub
    Private Shared Sub InitSettings()
        Dim Stones As New ClarkTribeGames.Coder(Mem.AllMagic)
        If Not System.IO.File.Exists(Mem.Settings) Then
            WriteSettings()
        End If
        Dim read As String, split As String()
        read = My.Computer.FileSystem.ReadAllText(Mem.Settings, System.Text.Encoding.UTF8)
        If Not read = "~" Then
            Try
                split = Stones.DecryptData(read).Split("|")
                Mem.UserName = split(0)
                Mem.Passcode = split(1)
            Catch ex As Exception
                Mem.UserName = ""
                Mem.Passcode = ""
            End Try
        End If
    End Sub

    Public Shared Sub WriteSettings()
        Dim Rocks As New ClarkTribeGames.Coder(Mem.AllMagic)
        Dim fs As System.IO.FileStream = System.IO.File.Create(Mem.Settings)
        Dim text As String
        If Mem.UserName.Length > 0 Then
            text = Rocks.EncryptData(Mem.UserName & "|" & Mem.Passcode)
        Else
            text = "~"
        End If
        Dim data As Byte() = New System.Text.UTF8Encoding(True).GetBytes(text)
        fs.Write(data, 0, data.Length)
        fs.Close()
        fs.Dispose()
    End Sub
End Class
