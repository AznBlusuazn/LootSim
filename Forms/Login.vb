Public Class Login
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click, CloseText.Click, CancelButton.Click
        Me.Close()
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

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Mem.UserName = UserText.Text
        Dim Wrapper As New ClarkTribeGames.Coder(Mem.AllMagic)
        Mem.Passcode = Wrapper.EncryptData(PassText.Text)
        If (ClarkTribeGames.MySQLReader.QueryUser("ch", Mem.UserName, Mem.Passcode)) Then
            'Successful login
            MsgBox("YES")
        Else
            'Login failed
            MsgBox("NO")
        End If

    End Sub
End Class