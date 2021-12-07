Public Class Mem

    'Environmental
    Public Shared WindowDrag As Boolean
    Public Shared WindowMouseX, WindowMouseY As Integer
    Public Shared MainBackColor As Color = Color.Navy
    Public Shared MainForeColor As Color = Color.WhiteSmoke
    Public Shared DisabledBack As Color = Color.DimGray
    Public Shared AllMagic As String = "fIBSr7Y4qsLLTsrN18y3c6mFJwX7udEgB3FAL7VtianboGt/uc+PDHE4pNVhvm/r"
    Public Shared ReadOnly UserDB As String = "lootsimuser"
    Public Shared ReadOnly StoreDB As String = "lootsimmarket"

    'UserInfo
    Public Shared UserName As String = ""
    Public Shared Passcode As String = ""
    'un, uid, credits, first, last, refresh, inv, status
    Public Shared UserStats As String()
End Class
