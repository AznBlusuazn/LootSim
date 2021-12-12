Public Class Sell
    Private Sub Sell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildSellPanel()
    End Sub
    Private Sub BuildSellPanel()
        UnText.Text = Mem.UserStats(0)
        CrText.Text = Mem.UserStats(2)
        StatusLabel.Text = ""
        StatusLabel.ForeColor = Color.WhiteSmoke
        Dim iteminfo As String() = {Mem.ItemToSell,
            ClarkTribeGames.MySQLReader.Free(0, "SELECT itemname FROM " & Mem.InvDB & " WHERE uid = '" & Mem.ItemToSell & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT itemdesc FROM " & Mem.InvDB & " WHERE uid = '" & Mem.ItemToSell & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT minq FROM " & Mem.InvDB & " WHERE uid = '" & Mem.ItemToSell & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT maxq FROM " & Mem.InvDB & " WHERE uid = '" & Mem.ItemToSell & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT startdate FROM " & Mem.InvDB & " WHERE uid = '" & Mem.ItemToSell & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT enddate FROM " & Mem.InvDB & " WHERE uid = '" & Mem.ItemToSell & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT rare FROM " & Mem.InvDB & " WHERE uid = '" & Mem.ItemToSell & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT price FROM " & Mem.InvDB & " WHERE uid = '" & Mem.ItemToSell & "';"),
            ClarkTribeGames.MySQLReader.Free(0, "SELECT status FROM " & Mem.InvDB & " WHERE uid = '" & Mem.ItemToSell & "';")}
        ItemText.Text = iteminfo(1)
        DescText.Text = iteminfo(2)
        FirstText.Text = iteminfo(5)
        PriceText.Text = CStr(CInt(iteminfo(7)) * CInt(iteminfo(8)))
        If iteminfo(6) = "" Then
            ExText.Text = "No End Date"
        Else
            ExText.Text = iteminfo(6)
        End If
        OwnText.Text = Share.GetNumberOwned(iteminfo(0))
        Appearance.SetAvatar(iteminfo(0), LootAvatar)
        SaleText.Text = CStr(Math.Ceiling(CDec(CInt(PriceText.Text) * 1.1)))
        QText.Text = OwnText.Text
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
    Private Sub ExitUserWindow(sender As Object, e As EventArgs) Handles CloseButton.Click, CloseText.Click, CSellButton.Click
        'Change for fancy box later
        Dim answer As Integer = MsgBox("Are you sure you want to cancel this sell?", vbYesNo)
        If answer = vbYes Then
            CloseOut()
        End If
    End Sub
    Private Sub SaleButton_Click(sender As Object, e As EventArgs) Handles SaleButton.Click
        'Change for fancy box later
        Dim answer As Integer = MsgBox("Are you sure you want to proceed with this sell?", vbYesNo)
        If answer = vbYes Then
            PostSale()
            CloseOut()
        End If
    End Sub

    Private Sub PostSale()
        Try
            Dim uid As Integer
            Try
                uid = CInt(ClarkTribeGames.MySQLReader.Free(0, "SELECT uid FROM lootsimmarket ORDER by uid desc limit 1;")) + 1
            Catch
                uid = "0"
            End Try
            Dim saleinfo As String() = {uid, Mem.UserStats(1), Mem.ItemToSell, QText.Text, SaleText.Text, "s", "", "0", SPText.Text}
            ClarkTribeGames.MySQLReader.Free(1, "INSERT INTO " & Mem.StoreDB &
                " (`uid`, `userid`, `invid`, `invq`, `price`, `type`, `pending`, `status`,`desc`) VALUES ('" &
                saleinfo(0) & "','" & saleinfo(1) & "','" & saleinfo(2) & "','" & saleinfo(3) & "','" &
                saleinfo(4) & "','" & saleinfo(5) & "','" & saleinfo(6) & "','" & saleinfo(7) & "','" &
                saleinfo(8) & "');")
        Catch
            MsgBox("Something went wrong with posting the sale.  Contact Support.")
        End Try
    End Sub

    Private Sub CloseOut()
        Mem.ItemToSell = ""
        Me.Close()
        Me.Dispose()
    End Sub
End Class