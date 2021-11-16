Imports System.IO

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
        Dim creds As New Credentials
        creds.ShowDialog()
        Dim proc As New Process With {
            .StartInfo = New ProcessStartInfo With {
                .FileName = "cmd.exe",
                .Arguments = "/c runas /user:" & creds.Username & " /netonly " & My.Application.Info.DirectoryPath & "\" & My.Application.Info.AssemblyName & ".exe",
                .UseShellExecute = False,
                .RedirectStandardInput = True
            }
        }
        'If creds.UseCurrentContext = False Then
        '    proc.StartInfo.UserName = creds.Username
        '    proc.StartInfo.Password = creds.Password
        'End If
        proc.Start()
        Dim procStreamWriter As StreamWriter = proc.StandardInput
        procStreamWriter.WriteLine(creds.MaskedTextBox_Password.Text)
        procStreamWriter.Close()
        proc.WaitForExit()
    End Sub

    Private Sub Button_CustomCommands_Click(sender As Object, e As EventArgs) Handles Button_CustomCommands.Click
        Process.Start("cmd.exe")
    End Sub

End Class
