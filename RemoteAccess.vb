Imports System.Text.RegularExpressions

Public Class RemoteAccess

    Private Sub RemoteAccess_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim AllComputers As List(Of Computer) = Computer.LoadComputers()
        TreeView_Computers.Nodes.Clear()
        For Each Computer As Computer In AllComputers
            GetSessions(Computer)
        Next
        ComboBox_SessionConnectionMode.SelectedIndex = 0
    End Sub

    Private Sub GetSessions(Computer As Computer)
        Dim tmpNode As TreeNode = TreeView_Computers.Nodes.Add(Computer.Address, Computer.Name)
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
    End Sub

    Private Sub TreeView_Computers_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView_Computers.AfterSelect
        If e.Node.Level = 0 Then
            Button_ConnectSession.Enabled = False
            ComboBox_SessionConnectionMode.Enabled = False
        Else
            Button_ConnectSession.Enabled = True
            ComboBox_SessionConnectionMode.Enabled = True
        End If
    End Sub

    Private Sub Button_ConnectSession_Click(sender As Object, e As EventArgs) Handles Button_ConnectSession.Click
        Dim connectionCommand As String = "/V:" & TreeView_Computers.SelectedNode.Parent.Name & " /shadow:" & TreeView_Computers.SelectedNode.Name
        If ComboBox_SessionConnectionMode.SelectedIndex = 0 Then
            connectionCommand = connectionCommand & " /control"
        ElseIf ComboBox_SessionConnectionMode.SelectedIndex = 2 Then
            connectionCommand = connectionCommand & " /control /noconsentprompt"
        ElseIf ComboBox_SessionConnectionMode.SelectedIndex = 3 Then
            connectionCommand = connectionCommand & " /noconsentprompt"
        End If
        ' HIER NOCH ABFRAGE BZGL. DES USERS
        Dim creds As New Credentials
        creds.ShowDialog()
        Dim sessionQuery As New Process With {
            .StartInfo = New ProcessStartInfo With {
                .FileName = "mstsc.exe",
                .Arguments = connectionCommand,
                .CreateNoWindow = True,
                .RedirectStandardOutput = True
            }
        }
        If creds.UseCurrentContext = False Then
            sessionQuery.StartInfo.UserName = creds.Username
            sessionQuery.StartInfo.Password = creds.Password
        End If
        sessionQuery.Start()
    End Sub

    Private Sub Button_ConnectComputer_Click(sender As Object, e As EventArgs) Handles Button_ConnectComputer.Click
        ' HIER NOCH ABFRAGE BZGL. DES USERS
        Dim creds As New Credentials
        creds.ShowDialog()
        Dim sessionQuery As New Process With {
            .StartInfo = New ProcessStartInfo With {
                .FileName = "mstsc.exe",
                .Arguments = "/V:" & TreeView_Computers.SelectedNode.Name,
                .CreateNoWindow = True,
                .RedirectStandardOutput = True
            }
        }
        If creds.UseCurrentContext = False Then
            sessionQuery.StartInfo.UserName = creds.Username
            sessionQuery.StartInfo.Password = creds.Password
        End If
        sessionQuery.Start()
    End Sub

End Class