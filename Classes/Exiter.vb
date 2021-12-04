Public Class Exiter
    Public Shared Sub ExitTheGame()
        Dim answer As Integer
        answer = MsgBox("Are you sure you want to Exit?", vbYesNo + vbExclamation)
        If answer = vbYes Then ExitGame()
    End Sub
    Private Shared Sub ExitGame()
        GC.Collect()
        MainMenu.Dispose()
        MainMenu.Close()
    End Sub

End Class
