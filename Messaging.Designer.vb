<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Messaging
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
        Me.Label_AvailableTargets = New System.Windows.Forms.Label()
        Me.Label_SelectedTargets = New System.Windows.Forms.Label()
        Me.Button_AddTarget = New System.Windows.Forms.Button()
        Me.TreeView_AvailableTargets = New System.Windows.Forms.TreeView()
        Me.TreeView_SelectedTargets = New System.Windows.Forms.TreeView()
        Me.Button_RemoveTarget = New System.Windows.Forms.Button()
        Me.Button_SendMessage = New System.Windows.Forms.Button()
        Me.RichTextBox_Message = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label_AvailableTargets
        '
        Me.Label_AvailableTargets.AutoSize = True
        Me.Label_AvailableTargets.Location = New System.Drawing.Point(10, 10)
        Me.Label_AvailableTargets.Name = "Label_AvailableTargets"
        Me.Label_AvailableTargets.Size = New System.Drawing.Size(95, 15)
        Me.Label_AvailableTargets.TabIndex = 2
        Me.Label_AvailableTargets.Text = "Available Targets"
        '
        'Label_SelectedTargets
        '
        Me.Label_SelectedTargets.AutoSize = True
        Me.Label_SelectedTargets.Location = New System.Drawing.Point(446, 10)
        Me.Label_SelectedTargets.Name = "Label_SelectedTargets"
        Me.Label_SelectedTargets.Size = New System.Drawing.Size(91, 15)
        Me.Label_SelectedTargets.TabIndex = 5
        Me.Label_SelectedTargets.Text = "Selected Targets"
        '
        'Button_AddTarget
        '
        Me.Button_AddTarget.Enabled = False
        Me.Button_AddTarget.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button_AddTarget.Location = New System.Drawing.Point(385, 33)
        Me.Button_AddTarget.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_AddTarget.Name = "Button_AddTarget"
        Me.Button_AddTarget.Size = New System.Drawing.Size(56, 129)
        Me.Button_AddTarget.TabIndex = 6
        Me.Button_AddTarget.Text = ">"
        Me.Button_AddTarget.UseVisualStyleBackColor = True
        '
        'TreeView_AvailableTargets
        '
        Me.TreeView_AvailableTargets.Location = New System.Drawing.Point(10, 29)
        Me.TreeView_AvailableTargets.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TreeView_AvailableTargets.Name = "TreeView_AvailableTargets"
        Me.TreeView_AvailableTargets.Size = New System.Drawing.Size(370, 350)
        Me.TreeView_AvailableTargets.TabIndex = 7
        '
        'TreeView_SelectedTargets
        '
        Me.TreeView_SelectedTargets.Location = New System.Drawing.Point(446, 29)
        Me.TreeView_SelectedTargets.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TreeView_SelectedTargets.Name = "TreeView_SelectedTargets"
        Me.TreeView_SelectedTargets.Size = New System.Drawing.Size(370, 280)
        Me.TreeView_SelectedTargets.TabIndex = 8
        '
        'Button_RemoveTarget
        '
        Me.Button_RemoveTarget.Enabled = False
        Me.Button_RemoveTarget.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button_RemoveTarget.Location = New System.Drawing.Point(384, 174)
        Me.Button_RemoveTarget.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_RemoveTarget.Name = "Button_RemoveTarget"
        Me.Button_RemoveTarget.Size = New System.Drawing.Size(56, 129)
        Me.Button_RemoveTarget.TabIndex = 9
        Me.Button_RemoveTarget.Text = "<"
        Me.Button_RemoveTarget.UseVisualStyleBackColor = True
        '
        'Button_SendMessage
        '
        Me.Button_SendMessage.Enabled = False
        Me.Button_SendMessage.Location = New System.Drawing.Point(737, 313)
        Me.Button_SendMessage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button_SendMessage.Name = "Button_SendMessage"
        Me.Button_SendMessage.Size = New System.Drawing.Size(79, 66)
        Me.Button_SendMessage.TabIndex = 10
        Me.Button_SendMessage.Text = "Send"
        Me.Button_SendMessage.UseVisualStyleBackColor = True
        '
        'RichTextBox_Message
        '
        Me.RichTextBox_Message.Location = New System.Drawing.Point(447, 313)
        Me.RichTextBox_Message.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichTextBox_Message.Name = "RichTextBox_Message"
        Me.RichTextBox_Message.Size = New System.Drawing.Size(285, 66)
        Me.RichTextBox_Message.TabIndex = 11
        Me.RichTextBox_Message.Text = ""
        '
        'Messaging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 388)
        Me.Controls.Add(Me.RichTextBox_Message)
        Me.Controls.Add(Me.Button_SendMessage)
        Me.Controls.Add(Me.Button_RemoveTarget)
        Me.Controls.Add(Me.TreeView_SelectedTargets)
        Me.Controls.Add(Me.TreeView_AvailableTargets)
        Me.Controls.Add(Me.Button_AddTarget)
        Me.Controls.Add(Me.Label_SelectedTargets)
        Me.Controls.Add(Me.Label_AvailableTargets)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Messaging"
        Me.Text = "Messaging"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_AvailableTargets As Label
    Friend WithEvents Label_SelectedTargets As Label
    Friend WithEvents Button_AddTarget As Button
    Friend WithEvents TreeView_AvailableTargets As TreeView
    Friend WithEvents TreeView_SelectedTargets As TreeView
    Friend WithEvents Button_RemoveTarget As Button
    Friend WithEvents Button_SendMessage As Button
    Friend WithEvents RichTextBox_Message As RichTextBox
End Class
