﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Credentials
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RadioButton_CurrentUser = New System.Windows.Forms.RadioButton()
        Me.Label_CurrentUser = New System.Windows.Forms.Label()
        Me.RadioButton_DifferentUser = New System.Windows.Forms.RadioButton()
        Me.TextBox_Username = New System.Windows.Forms.TextBox()
        Me.Label_Username = New System.Windows.Forms.Label()
        Me.MaskedTextBox_Password = New System.Windows.Forms.MaskedTextBox()
        Me.Label_Password = New System.Windows.Forms.Label()
        Me.Button_Submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RadioButton_CurrentUser
        '
        Me.RadioButton_CurrentUser.AutoSize = True
        Me.RadioButton_CurrentUser.Checked = True
        Me.RadioButton_CurrentUser.Location = New System.Drawing.Point(12, 12)
        Me.RadioButton_CurrentUser.Name = "RadioButton_CurrentUser"
        Me.RadioButton_CurrentUser.Size = New System.Drawing.Size(110, 19)
        Me.RadioButton_CurrentUser.TabIndex = 1
        Me.RadioButton_CurrentUser.TabStop = True
        Me.RadioButton_CurrentUser.Text = "Use current user"
        Me.RadioButton_CurrentUser.UseVisualStyleBackColor = True
        '
        'Label_CurrentUser
        '
        Me.Label_CurrentUser.AutoSize = True
        Me.Label_CurrentUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label_CurrentUser.Location = New System.Drawing.Point(128, 14)
        Me.Label_CurrentUser.Name = "Label_CurrentUser"
        Me.Label_CurrentUser.Size = New System.Drawing.Size(121, 15)
        Me.Label_CurrentUser.TabIndex = 2
        Me.Label_CurrentUser.Text = "(1234@contoso.local)"
        '
        'RadioButton_DifferentUser
        '
        Me.RadioButton_DifferentUser.AutoSize = True
        Me.RadioButton_DifferentUser.Location = New System.Drawing.Point(12, 37)
        Me.RadioButton_DifferentUser.Name = "RadioButton_DifferentUser"
        Me.RadioButton_DifferentUser.Size = New System.Drawing.Size(142, 19)
        Me.RadioButton_DifferentUser.TabIndex = 3
        Me.RadioButton_DifferentUser.Text = "Use the following user"
        Me.RadioButton_DifferentUser.UseVisualStyleBackColor = True
        '
        'TextBox_Username
        '
        Me.TextBox_Username.Enabled = False
        Me.TextBox_Username.Location = New System.Drawing.Point(99, 62)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.Size = New System.Drawing.Size(210, 23)
        Me.TextBox_Username.TabIndex = 4
        '
        'Label_Username
        '
        Me.Label_Username.AutoSize = True
        Me.Label_Username.Enabled = False
        Me.Label_Username.Location = New System.Drawing.Point(30, 65)
        Me.Label_Username.Name = "Label_Username"
        Me.Label_Username.Size = New System.Drawing.Size(33, 15)
        Me.Label_Username.TabIndex = 5
        Me.Label_Username.Text = "User:"
        '
        'MaskedTextBox_Password
        '
        Me.MaskedTextBox_Password.Enabled = False
        Me.MaskedTextBox_Password.Location = New System.Drawing.Point(99, 91)
        Me.MaskedTextBox_Password.Name = "MaskedTextBox_Password"
        Me.MaskedTextBox_Password.Size = New System.Drawing.Size(210, 23)
        Me.MaskedTextBox_Password.TabIndex = 6
        '
        'Label_Password
        '
        Me.Label_Password.AutoSize = True
        Me.Label_Password.Enabled = False
        Me.Label_Password.Location = New System.Drawing.Point(30, 94)
        Me.Label_Password.Name = "Label_Password"
        Me.Label_Password.Size = New System.Drawing.Size(60, 15)
        Me.Label_Password.TabIndex = 7
        Me.Label_Password.Text = "Password:"
        '
        'Button_Submit
        '
        Me.Button_Submit.Location = New System.Drawing.Point(234, 122)
        Me.Button_Submit.Name = "Button_Submit"
        Me.Button_Submit.Size = New System.Drawing.Size(75, 29)
        Me.Button_Submit.TabIndex = 8
        Me.Button_Submit.Text = "Submit"
        Me.Button_Submit.UseVisualStyleBackColor = True
        '
        'Credentials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 163)
        Me.Controls.Add(Me.Button_Submit)
        Me.Controls.Add(Me.Label_Password)
        Me.Controls.Add(Me.MaskedTextBox_Password)
        Me.Controls.Add(Me.Label_Username)
        Me.Controls.Add(Me.TextBox_Username)
        Me.Controls.Add(Me.RadioButton_DifferentUser)
        Me.Controls.Add(Me.Label_CurrentUser)
        Me.Controls.Add(Me.RadioButton_CurrentUser)
        Me.Name = "Credentials"
        Me.Text = "Credentials"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioButton_CurrentUser As RadioButton
    Friend WithEvents Label_CurrentUser As Label
    Friend WithEvents RadioButton_DifferentUser As RadioButton
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents Label_Username As Label
    Friend WithEvents MaskedTextBox_Password As MaskedTextBox
    Friend WithEvents Label_Password As Label
    Friend WithEvents Button_Submit As Button
End Class
