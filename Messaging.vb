Imports System.Text.RegularExpressions

Public Class Messaging

    Private Sub Messaging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim AllComputers As List(Of Computer) = Computer.LoadComputers()
        TreeView_AvailableTargets.Nodes.Clear()
        For Each Computer As Computer In AllComputers
            If My.Computer.Network.Ping(Computer.Address, 300) Then
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
            Else
                Dim tmpNode As TreeNode = TreeView_AvailableTargets.Nodes.Add(Computer.Address, Computer.Name & " (Offline)")
                tmpNode.ForeColor = SystemColors.GrayText
            End If
        Next
        TreeView_AvailableTargets.ExpandAll()
        TreeView_SelectedTargets.ExpandAll()
    End Sub

    Private Sub TreeView_Computers_BeforeSelect(sender As Object, e As TreeViewCancelEventArgs) Handles TreeView_AvailableTargets.BeforeSelect
        If e.Node.ForeColor = SystemColors.GrayText Then
            e.Cancel = True
        End If
    End Sub

    Private Sub TreeView_AvailableTargets_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView_AvailableTargets.AfterSelect
        If e.Node.Level = 0 Then
            Button_AddTarget.Enabled = False
        Else
            Button_AddTarget.Enabled = True
        End If
    End Sub

    Private Sub TreeView_SelectedTargets_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView_SelectedTargets.AfterSelect
        If e.Node.Level = 0 Then
            Button_RemoveTarget.Enabled = False
        Else
            Button_RemoveTarget.Enabled = True
        End If
    End Sub

    Private Sub Button_AddTarget_Click(sender As Object, e As EventArgs) Handles Button_AddTarget.Click
        TreeView_SelectedTargets.Nodes.Add(TreeView_AvailableTargets.SelectedNode.Parent.Name, TreeView_AvailableTargets.SelectedNode.Parent.Text)
        TreeView_SelectedTargets.Nodes.Item(TreeView_AvailableTargets.SelectedNode.Parent.Name).Nodes.Add(TreeView_AvailableTargets.SelectedNode.Name, TreeView_AvailableTargets.SelectedNode.Text)
        TreeView_AvailableTargets.SelectedNode.Parent.Remove()
        Button_AddTarget.Enabled = False
        TreeView_SelectedTargets.ExpandAll()
        If TreeView_SelectedTargets.Nodes.Count > 0 Then
            Button_SendMessage.Enabled = True
        Else
            Button_SendMessage.Enabled = False
        End If
        TreeView_AvailableTargets.Sort()
        TreeView_SelectedTargets.Sort()
    End Sub

    Private Sub Button_RemoveTarget_Click(sender As Object, e As EventArgs) Handles Button_RemoveTarget.Click
        TreeView_AvailableTargets.Nodes.Add(TreeView_SelectedTargets.SelectedNode.Parent.Name, TreeView_SelectedTargets.SelectedNode.Parent.Text)
        TreeView_AvailableTargets.Nodes.Item(TreeView_SelectedTargets.SelectedNode.Parent.Name).Nodes.Add(TreeView_SelectedTargets.SelectedNode.Name, TreeView_SelectedTargets.SelectedNode.Text)
        TreeView_SelectedTargets.SelectedNode.Parent.Remove()
        Button_RemoveTarget.Enabled = False
        TreeView_AvailableTargets.ExpandAll()
        If TreeView_SelectedTargets.Nodes.Count > 0 Then
            Button_SendMessage.Enabled = True
        Else
            Button_SendMessage.Enabled = False
        End If
        TreeView_AvailableTargets.Sort()
        TreeView_SelectedTargets.Sort()
    End Sub

    Private Sub Button_SendMessage_Click(sender As Object, e As EventArgs) Handles Button_SendMessage.Click
        For Each computerNode As TreeNode In TreeView_SelectedTargets.Nodes
            For Each sessionNode As TreeNode In computerNode.Nodes
                Dim sessionColumns As String() = sessionNode.Text.Replace("(", "").Replace(")", "").Split(" ")
                MsgBox(sessionColumns(5))
                Dim messageQuery As New Process With {
                    .StartInfo = New ProcessStartInfo With {
                        .FileName = "cmd.exe",
                        .Arguments = "/c msg " & sessionColumns(5) & " /SERVER:" & computerNode.Name & " '" & RichTextBox_Message.Text & "'",
                        .CreateNoWindow = True,
                        .RedirectStandardOutput = True
                    }
                }
                messageQuery.Start()
            Next
        Next
        RichTextBox_Message.Text = ""
    End Sub

End Class