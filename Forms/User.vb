Public Class User

    Dim ItemUID As String
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildUserPanel()
    End Sub
    Private Sub BuildUserPanel()
        InvList.Items.Clear()
        ItemUID = ""
        'These 3 are temporary
        Appearance.FlipButton(False, CheckButton)
        Appearance.FlipButton(False, GoButton)
        Appearance.FlipButton(False, MarketButton)
        'The 3 above are temp
        UnText.Text = Mem.UserStats(0)
        CrText.Text = Mem.UserStats(2)
        ChText.Text = Mem.UserStats(7)
        Appearance.SetAvatar(Mem.UserStats(1), UserAvatar)
        For Each item In Mem.UserStats(6).Split(",")
            InvList.Items.Add(ClarkTribeGames.MySQLReader.Free(0, "SELECT itemname FROM " & Mem.InvDB & " WHERE uid = '" & item.Split("x")(0) & "' AND status = '0';"))
        Next
        If InvList.Items.Count() = 0 Then
            InvList.Items.Add("<No Items Available>")
            InvList.Enabled = False
        Else
            InvList.Enabled = True
        End If
        FlipInvDetails(False)
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

    Private Sub FlipInvDetails(status As Boolean)
        If status = False Then
            ItemText.Text = ""
            DescText.Text = ""
            FirstText.Text = ""
            ExText.Text = ""
            OwnText.Text = ""
            PriceText.Text = ""
        End If
        ItemText.Visible = status
        DescText.Visible = status
        StLabel.Visible = status
        FirstText.Visible = status
        EndLabel.Visible = status
        ExText.Visible = status
        OwnLabel.Visible = status
        OwnText.Visible = status
        PriceLabel.Visible = status
        PriceText.Visible = status
        Appearance.FlipButton(status, SeButton)
        Appearance.FlipButton(status, TrButton)
    End Sub
    Private Sub InvList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InvList.SelectedIndexChanged
        InvListChange(InvList)
    End Sub

    Private Sub InvListChange(list As ListBox)
        If list.SelectedIndex < 0 Then
            FlipInvDetails(False)
        Else
            Dim itemname As String = list.SelectedItem.ToString
            'uid, itemname, desc, minq, maxq, startdate, enddate, rare, image, status
            Dim iteminfo As String() = {ClarkTribeGames.MySQLReader.Free(0, "SELECT uid FROM " & Mem.InvDB & " WHERE itemname = '" & itemname & "';"),
            itemname, ClarkTribeGames.MySQLReader.Free(0, "SELECT itemdesc FROM " & Mem.InvDB & " WHERE itemname = '" & itemname & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT minq FROM " & Mem.InvDB & " WHERE itemname = '" & itemname & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT maxq FROM " & Mem.InvDB & " WHERE itemname = '" & itemname & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT startdate FROM " & Mem.InvDB & " WHERE itemname = '" & itemname & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT enddate FROM " & Mem.InvDB & " WHERE itemname = '" & itemname & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT rare FROM " & Mem.InvDB & " WHERE itemname = '" & itemname & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT price FROM " & Mem.InvDB & " WHERE itemname = '" & itemname & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT status FROM " & Mem.InvDB & " WHERE itemname = '" & itemname & "';")}
            FlipInvDetails(True)
            ItemText.Text = iteminfo(1)
            DescText.Text = iteminfo(2)
            FirstText.Text = iteminfo(5)
            PriceText.Text = CStr(CInt(iteminfo(7)) * (CInt(iteminfo(8))))
            If iteminfo(6) = "" Then
                ExText.Text = "No End Date"
            Else
                ExText.Text = iteminfo(6)
            End If
            OwnText.Text = Share.GetNumberOwned(iteminfo(0))
            ItemUID = iteminfo(0)
            Appearance.SetAvatar(iteminfo(0), LootAvatar)
        End If
    End Sub
    Private Sub SeButton_Click(sender As Object, e As EventArgs) Handles SeButton.Click
        Mem.ItemToSell = ItemUID
        If Not Mem.ItemToSell = "" Then Sell.ShowDialog() Else MsgBox("Something went wrong.  Contact Support.")
    End Sub
End Class