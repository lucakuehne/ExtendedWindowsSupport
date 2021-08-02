Public Class Main

    Private Sub ToolStripMenuItem_Settings_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Settings.Click
        Settings.ShowDialog()
    End Sub

    Private Sub Button_Messages_Click(sender As Object, e As EventArgs) Handles Button_Messages.Click
        Messaging.ShowDialog()
    End Sub

    Private Sub Button_RemoteAccess_Click(sender As Object, e As EventArgs) Handles Button_RemoteAccess.Click
        RemoteAccess.ShowDialog()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
