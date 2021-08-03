Imports System.Text.RegularExpressions

Public Class Messaging

    Private Sub Messaging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim AllComputers As List(Of Computer) = Computer.LoadComputers()
        TreeView_AvailableTargets.Nodes.Clear()
        For Each Computer As Computer In AllComputers
            Dim tmpNode As TreeNode = TreeView_AvailableTargets.Nodes.Add(Computer.Address, Computer.Name)
            Dim sessionQuery As New Process With {
                .StartInfo = New ProcessStartInfo With {
                    .FileName = "cmd.exe",
                    .Arguments = "/c query session /SERVER:" & Computer.Address,
                    .CreateNoWindow = True,
                    .RedirectStandardOutput = True
                }
            }
            sessionQuery.Start()
            Dim ActiveKeywords As String() = {"Active", "Aktiv"}
            Dim currentLine As Integer = 1
            While Not sessionQuery.StandardOutput.EndOfStream
                Dim sessionQueryLine As String = Trim(sessionQuery.StandardOutput.ReadLine())
                If currentLine > 1 And sessionQueryLine.StartsWith("rdp-tcp") = False And sessionQueryLine.StartsWith("services") = False Then
                    For Each activeKeyword In ActiveKeywords
                        If sessionQueryLine.EndsWith(activeKeyword) Then
                            Dim columns As String() = Regex.Split(sessionQueryLine, "\s+")
                            tmpNode.Nodes.Add(columns(2), columns(1) & " @ " & columns(0) & " (Session ID: " & columns(2) & ")" & " (" & columns(3) & ")")
                        End If
                    Next
                End If
                currentLine += 1
            End While
        Next
    End Sub

    Private Sub TreeView_AvailableTargets_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView_AvailableTargets.AfterSelect
        If e.Node.Level = 0 Then
            Button_AddTarget.Enabled = False
        Else
            Button_AddTarget.Enabled = True
        End If
    End Sub

End Class