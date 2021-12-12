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
    Public Shared ReadOnly InvDB As String = "lootsiminv"
    Public Shared ReadOnly AIDB As String = "lootsimai"
    Public Shared ReadOnly Settings As String = "settings.cfg"
    Public Shared ReadOnly AURL As String =
        "ydgvh+IkMC1I4dpl5D17DVl/LcfXN5WLgpFFcbsraL05Cxn3yTEehH0rUhzUsZXrrHEzjaHU6KRJkdQ5Up4ZwDAKLveokRhrrIzHh7boqjV855JOdyXjog=="
    Public Shared ReadOnly LURL As String =
        "ydgvh+IkMC1I4dpl5D17DVl/LcfXN5WLgpFFcbsraL05Cxn3yTEehH0rUhzUsZXrrHEzjaHU6KRJkdQ5Up4ZwH7Uh3w2ZC7ktGXwVAmAkUbFbWuYV0M4EJCY3R9eYBSo"
    Public Shared ReadOnly IExt As String = ".png"

    'UserInfo
    Public Shared UserName As String = ""
    Public Shared Passcode As String = ""
    'un, uid, credits, first, last, refresh, inv, checks, status
    Public Shared UserStats As String()

    'SellInfo
    Public Shared ItemToSell As String = ""

End Class
