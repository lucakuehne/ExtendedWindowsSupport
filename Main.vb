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

    Private Sub ToolStripMenuItem_RunAsDifferentUser_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_RunAsDifferentUser.Click
        'Dim creds As New Credentials
        'creds.ShowDialog()
        'Dim proc As New Process With {
        '    .StartInfo = New ProcessStartInfo With {
        '        .FileName = "runas.exe",
        '        .Arguments = "/user:" & creds.Username & " /netonly " & ControlChars.Quote & My.Application.Info.DirectoryPath & "\" & My.Application.Info.AssemblyName & ".exe" & ControlChars.Quote,
        '        .UseShellExecute = False,
        '        .RedirectStandardInput = True
        '    }
        '}
        'proc.Start()
        'proc.StandardInput.WriteLine(creds.PasswordPlain)
        'proc.WaitForExit()
        'Me.Close()
    End Sub

    Private Sub Button_CustomCommands_Click(sender As Object, e As EventArgs) Handles Button_CustomCommands.Click
        Process.Start("cmd.exe")
    End Sub

End Class
