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
    Public Shared Sub SetAvatar(uid As String, box As PictureBox)
        Dim Wand As New ClarkTribeGames.Coder(Mem.AllMagic), url As String
        If box.Name = "UserAvatar" Then
            url = Wand.DecryptData(Mem.AURL) & uid & Mem.IExt
        Else
            url = Wand.DecryptData(Mem.LURL) & uid & Mem.IExt
        End If
        If url.Length > 0 Then
            Try
                With box
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    Dim img As Image = ClarkTribeGames.Converters.GetImageFromURL(url)
                    If img IsNot Nothing Then .Image = img
                End With
            Catch ex As Exception
                box.Image.Dispose()
                box.BackColor = Color.Black
            End Try
        Else
            box.Image.Dispose()
            box.BackColor = Color.Black
        End If
    End Sub
End Class
