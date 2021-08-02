Public Class Messaging
    Public Computers As Array

    Private Sub RemoteAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each Computer As String In Computers
            CheckIfOnline(Computer)
        Next
    End Sub

    Private Sub CheckIfOnline(Computer As String)

    End Sub

End Class