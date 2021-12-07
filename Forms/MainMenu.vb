Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init.InitMainMenu()
    End Sub
    Private Sub CTGLabel_Click(sender As Object, e As EventArgs) Handles CTGLabel.Click
        ClarkTribeGames.Web.CTG()
    End Sub
    Private Sub CreditsLabel_Click(sender As Object, e As EventArgs) Handles LoginLabel.Click
        Login.ShowDialog()
    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

    End Sub
    Private Sub OptionsButton_Click(sender As Object, e As EventArgs) Handles OptionsButton.Click

    End Sub
    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click

    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, CloseButton.Click, CloseText.Click
        Exiter.ExitTheGame()
    End Sub
    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseMove, TitleBarLabel.MouseMove
        If Mem.WindowDrag Then
            Me.Left = Cursor.Position.X - Mem.WindowMouseX
            Me.Top = Cursor.Position.Y - Mem.WindowMouseY
        End If
    End Sub
    Private Sub TitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseDown, TitleBarLabel.MouseDown
        Mem.WindowDrag = True
        Mem.WindowMouseX = Cursor.Position.X - Me.Left
        Mem.WindowMouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub TitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseUp, TitleBarLabel.MouseUp
        Mem.WindowDrag = False
    End Sub

End Class
