Public Class Settings
    Public editingComputer As Boolean = False

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim computers As String
        If System.IO.File.Exists("computers.csv") = True Then
            computers = My.Computer.FileSystem.ReadAllText("computers.csv", System.Text.Encoding.UTF32)
        End If
        ' Split file contents into rows
        '
    End Sub

    Private Sub Settings_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        For Each computer As ListViewItem In ListView_Computers.Items
            MessageBox.Show(computer.Text)
        Next
    End Sub

End Class