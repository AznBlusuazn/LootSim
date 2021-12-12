Public Class Share
    Public Shared Function GetNumberOwned(itemuid As String) As String
        For Each item In Mem.UserStats(6).Split(",")
            If item.Split("x")(0) = itemuid Then Return item.Split("x")(1)
        Next
        Return "0"
    End Function
End Class
