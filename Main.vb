Public Class Main
    Private Sub Button_RemoteAccess_Click(sender As Object, e As EventArgs) Handles Button_RemoteAccess.Click
        RemoteAccess.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem_Settings_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Settings.Click
        Settings.ShowDialog()
    End Sub

End Class
