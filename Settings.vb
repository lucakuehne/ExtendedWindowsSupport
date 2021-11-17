Public Class Settings

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView_Computers.Items.Clear()
        For Each computer As Computer In Computer.LoadComputers
            ListView_Computers.Items.Add(computer.Name).SubItems.Add(computer.Address)
        Next
    End Sub

    Private Sub Settings_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Dim computers As String = ""
        For Each computer As ListViewItem In ListView_Computers.Items
            computers += computer.Text & vbTab & computer.SubItems.Item(1).Text & vbCrLf
        Next
        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\computers.csv", computers, False)
    End Sub

    Private Sub Button_AddComputer_Click(sender As Object, e As EventArgs) Handles Button_AddComputer.Click
        If Button_AddComputer.Text = "Add Computer" Then
            ListView_Computers.Items.Add(TextBox_DisplayName.Text).SubItems.Add(TextBox_Address.Text)
        Else
            ListView_Computers.SelectedItems.Item(0).Text = TextBox_DisplayName.Text
            ListView_Computers.SelectedItems.Item(0).SubItems.Item(1).Text = TextBox_Address.Text
            Button_AddComputer.Text = "Add Computer"
            Button_RemoveComputer.Enabled = False
        End If
    End Sub

    Private Sub ListView_Computers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_Computers.SelectedIndexChanged
        If ListView_Computers.SelectedItems.Count > 0 Then
            Button_AddComputer.Text = "Save Computer"
            Button_RemoveComputer.Enabled = True
            TextBox_DisplayName.Text = ListView_Computers.FocusedItem.Text
            TextBox_Address.Text = ListView_Computers.FocusedItem.SubItems.Item(1).Text
        Else
            Button_AddComputer.Text = "Add Computer"
            Button_RemoveComputer.Enabled = False
            TextBox_DisplayName.Text = ""
            TextBox_Address.Text = ""
        End If
    End Sub

    Private Sub Button_RemoveComputer_Click(sender As Object, e As EventArgs) Handles Button_RemoveComputer.Click
        ListView_Computers.FocusedItem.Remove()
        Button_RemoveComputer.Enabled = False
    End Sub

End Class