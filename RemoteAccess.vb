Public Class RemoteAccess
    Public Computers As Array = {"LS1.softcash.ch", "LS2.softcash.ch"}

    Private Sub RemoteAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each Computer As String In Computers
            CheckIfOnline(Computer)
        Next
    End Sub

    Private Sub CheckIfOnline(Computer As String)

    End Sub

End Class