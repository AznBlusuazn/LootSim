Public Class User
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
    End Sub

    Private Sub BuildUserPanel()

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
    Private Sub ExitUserWindow(sender As Object, e As EventArgs) Handles CloseButton.Click, CloseText.Click, ReturnButton.Click
        'Change for fancy box later
        Dim answer As Integer = MsgBox("Do you want return to the main menu?", vbYesNo)
        If answer = vbYes Then
            Me.Close()
            Me.Dispose()
        End If
    End Sub
End Class