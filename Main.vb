Public Class Main
    Private Sub ToolStripMenuItem_Settings_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Settings.Click
        Settings.ShowDialog()
    End Sub

    Private Sub Button_Messages_Click(sender As Object, e As EventArgs) Handles Button_Messages.Click
        Messaging.ShowDialog()
    End Sub
End Class
