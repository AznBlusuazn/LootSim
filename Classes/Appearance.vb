Public Class Appearance

    Public Shared Sub FlipButton(mode As Boolean, button As Button)
        Select Case mode
            Case True
                button.Enabled = True
                button.BackColor = Mem.MainBackColor
            Case False
                button.Enabled = False
                button.BackColor = Mem.DisabledBack
        End Select
    End Sub
End Class
