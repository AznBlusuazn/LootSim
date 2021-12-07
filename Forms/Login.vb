Public Class Login
    Private Sub LoginForm_OnLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        InfoLabel.Text = "Please Login."
        InfoLabel.ForeColor = Color.WhiteSmoke
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click, CloseText.Click, DeclineButton.Click
        Me.Close()
    End Sub
    Private Sub UserText_TextChanged(sender As Object, e As EventArgs) Handles UserText.KeyPress, PassText.KeyPress
        InfoLabel.Text = "Please Login."
        InfoLabel.ForeColor = Color.White
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
        Dim status As String = ClarkTribeGames.MySQLReader.Free(0, "SELECT status FROM userdb WHERE username = '" &
            Mem.UserName & "' and passcode = '" & Mem.Passcode & "'")
        If status = "1" Then
            InfoLabel.Text = "CTG Account Disabled.  Contact ClarkTribeGames Support!"
            InfoLabel.ForeColor = Color.DarkRed
            Mem.UserName = ""
            Mem.Passcode = ""
            PassLabel.Text = ""
            LoginCheck()
            Exit Sub
        End If
        If (ClarkTribeGames.MySQLReader.QueryUser("ch", {Mem.UserName, Mem.Passcode})) Then
            Mem.Passcode = ""
            LoginCheck()
            If Not (BuildProfile()) Then
            End If
            If InfoLabel.Text = "LOGIN SUCCESSFUL!" Then Me.Close()
        Else
            Mem.UserName = ""
            Mem.Passcode = ""
            InfoLabel.Text = "Invalid Username/Password Combination."
            InfoLabel.ForeColor = Color.Cyan
            LoginCheck()
        End If
    End Sub
    Public Sub LoginCheck()
        If Not Mem.UserName.Length > 0 Then
            UserText.Text = ""
            Mem.UserName = ""
            LoggedOut()
        Else
            If Not (BuildProfile()) Then
                InfoLabel.Text = "LootSim Profile Disabled.  Contact ClarkTribeGames Support!"
                InfoLabel.ForeColor = Color.Cyan
                LoggedOut()
            Else
                UserText.Text = ""
                MainMenu.UserLabel.Text = Mem.UserName
                ClarkTribeGames.MySQLReader.Free(1, "UPDATE userdb SET lastlogon = '" &
                DateTime.Now.ToString("yyyy`-`MM`-`dd HH`:`mm`:`ss") & "' WHERE uid = '" & Mem.UserStats(1) & "';")
                MainMenu.LoginLabel.Text = "Switch To Different CTG Account"
                MainMenu.CreditsLabel.Text = "CREDITS:  " & Mem.UserStats(2)
                InfoLabel.Text = "LOGIN SUCCESSFUL!"
                InfoLabel.ForeColor = Color.Green
            End If
        End If
        PassText.Text = ""
        Mem.Passcode = ""
    End Sub
    Private Function BuildProfile() As Boolean
        Dim uid As String = ClarkTribeGames.MySQLReader.Free(0, "SELECT uid FROM userdb WHERE username = '" & Mem.UserName & "';")
        If ClarkTribeGames.MySQLReader.Free(0, "SELECT uid FROM " & Mem.UserDB & " WHERE uid = '" & uid & "';").Length = 0 Then
            Dim timestamp As String = DateTime.Now.ToString("yyyy`-`MM`-`dd HH`:`mm`:`ss")
            ClarkTribeGames.MySQLReader.Free(1, "INSERT INTO " & Mem.UserDB &
                " (`uid`, `credits`, `firstlogon`, `lastlogon`, `lastrefresh`, `inventory`, `status`) VALUES ('" &
                uid & "','0','" & timestamp & "','" & timestamp & "','" & timestamp & "',' ','0');")
        End If
        If ClarkTribeGames.MySQLReader.Free(0, "SELECT status FROM " & Mem.UserDB & " WHERE uid = '" & uid & "';") = "1" Then Return False
        ClarkTribeGames.MySQLReader.Free(1, "UPDATE " & Mem.UserDB & " SET lastlogon = '" & DateTime.Now.ToString("yyyy`-`MM`-`dd HH`:`mm`:`ss") &
            "' WHERE uid = '" & uid & "';")
        Mem.UserStats = {Mem.UserName, uid, ClarkTribeGames.MySQLReader.Free(0, "SELECT credits FROM " & Mem.UserDB & " WHERE uid = '" & uid & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT firstlogon FROM " & Mem.UserDB & " WHERE uid = '" & uid & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT lastlogon FROM " & Mem.UserDB & " WHERE uid = '" & uid & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT lastrefresh FROM " & Mem.UserDB & " WHERE uid = '" & uid & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT inventory FROM " & Mem.UserDB & " WHERE uid = '" & uid & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT status FROM " & Mem.UserDB & " WHERE uid = '" & uid & "';")}
        Return True
    End Function
    Private Sub LoggedOut()
        MainMenu.UserLabel.Text = "[Not Logged In]"
        MainMenu.LoginLabel.Text = "Log In With CTG Account"
        MainMenu.CreditsLabel.Text = "[Log In To See Credits]"
        Mem.UserStats = {}
    End Sub

End Class