Imports System.Security.Principal

Public Class Credentials
    Public UseCurrentContext As Boolean = True
    Public Username As String
    Public Password As Security.SecureString

    Private Sub Credentials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_CurrentUser.Text = "(" & WindowsIdentity.GetCurrent().Name & ")"
    End Sub

    Private Sub RadioButton_DifferentUser_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_DifferentUser.CheckedChanged
        Label_Username.Enabled = Not Label_Username.Enabled
        Label_Password.Enabled = Not Label_Password.Enabled
        TextBox_Username.Enabled = Not TextBox_Username.Enabled
        MaskedTextBox_Password.Enabled = Not MaskedTextBox_Password.Enabled
        UseCurrentContext = False
    End Sub

    Private Sub Button_Submit_Click(sender As Object, e As EventArgs) Handles Button_Submit.Click
        Username = TextBox_Username.Text
        For Each c In MaskedTextBox_Password.Text
            Password.AppendChar(c)
        Next
        Me.Close()
    End Sub

End Class