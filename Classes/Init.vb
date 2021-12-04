Public Class Init
    Public Shared Sub InitMainMenu()
        Dim gametitle As String = Application.ProductName & " v" & ClarkTribeGames.Converters.GetVersion(Application.ProductVersion)
        MainMenu.TitleBarLabel.Text = gametitle
        MainMenu.VersionLabel.Text = gametitle
        Dim Baelfire As String = Mem.AllMagic
        Dim TheDagger As New ClarkTribeGames.Coder(Application.CompanyName)
        Mem.AllMagic = TheDagger.DecryptData(Baelfire)
        'add load from save data
        'add username/password check - if empty or wrong, no user logged in - if correct user loaded
        '3 buttons are temporarily disabled
        Appearance.FlipButton(False, MainMenu.StartButton)
        Appearance.FlipButton(False, MainMenu.AboutButton)
        Appearance.FlipButton(False, MainMenu.OptionsButton)
    End Sub
End Class
