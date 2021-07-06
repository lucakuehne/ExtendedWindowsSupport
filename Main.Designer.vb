<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button_CustomCommands = New System.Windows.Forms.Button()
        Me.Button_Messages = New System.Windows.Forms.Button()
        Me.Button_RemoteAccess = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem_Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_CustomCommands
        '
        Me.Button_CustomCommands.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_CustomCommands.Location = New System.Drawing.Point(12, 327)
        Me.Button_CustomCommands.Name = "Button_CustomCommands"
        Me.Button_CustomCommands.Size = New System.Drawing.Size(503, 137)
        Me.Button_CustomCommands.TabIndex = 2
        Me.Button_CustomCommands.Text = "Custom commands"
        Me.Button_CustomCommands.UseVisualStyleBackColor = True
        '
        'Button_Messages
        '
        Me.Button_Messages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Messages.Location = New System.Drawing.Point(12, 184)
        Me.Button_Messages.Name = "Button_Messages"
        Me.Button_Messages.Size = New System.Drawing.Size(503, 137)
        Me.Button_Messages.TabIndex = 3
        Me.Button_Messages.Text = "Post messages"
        Me.Button_Messages.UseVisualStyleBackColor = True
        '
        'Button_RemoteAccess
        '
        Me.Button_RemoteAccess.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_RemoteAccess.Location = New System.Drawing.Point(12, 40)
        Me.Button_RemoteAccess.Name = "Button_RemoteAccess"
        Me.Button_RemoteAccess.Size = New System.Drawing.Size(503, 137)
        Me.Button_RemoteAccess.TabIndex = 4
        Me.Button_RemoteAccess.Text = "Remote access"
        Me.Button_RemoteAccess.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Settings})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(528, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem_Settings
        '
        Me.ToolStripMenuItem_Settings.Name = "ToolStripMenuItem_Settings"
        Me.ToolStripMenuItem_Settings.Size = New System.Drawing.Size(76, 24)
        Me.ToolStripMenuItem_Settings.Text = "Settings"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 476)
        Me.Controls.Add(Me.Button_RemoteAccess)
        Me.Controls.Add(Me.Button_Messages)
        Me.Controls.Add(Me.Button_CustomCommands)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_CustomCommands As Button
    Friend WithEvents Button_Messages As Button
    Friend WithEvents Button_RemoteAccess As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem_Settings As ToolStripMenuItem
End Class
