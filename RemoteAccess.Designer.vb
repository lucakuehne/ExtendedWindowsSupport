﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteAccess
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
        Me.SuspendLayout()
        '
        'Label_AvailableTargets
        '
        Me.Label_AvailableTargets.AutoSize = True
        Me.Label_AvailableTargets.Location = New System.Drawing.Point(12, 13)
        Me.Label_AvailableTargets.Name = "Label_AvailableTargets"
        Me.Label_AvailableTargets.Size = New System.Drawing.Size(122, 20)
        Me.Label_AvailableTargets.TabIndex = 2
        Me.Label_AvailableTargets.Text = "Available Targets"
        '
        'Label_SelectedTargets
        '
        Me.Label_SelectedTargets.AutoSize = True
        Me.Label_SelectedTargets.Location = New System.Drawing.Point(510, 13)
        Me.Label_SelectedTargets.Name = "Label_SelectedTargets"
        Me.Label_SelectedTargets.Size = New System.Drawing.Size(117, 20)
        Me.Label_SelectedTargets.TabIndex = 5
        Me.Label_SelectedTargets.Text = "Selected Targets"
        '
        'Button_AddTarget
        '
        Me.Button_AddTarget.Enabled = False
        Me.Button_AddTarget.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button_AddTarget.Location = New System.Drawing.Point(440, 156)
        Me.Button_AddTarget.Name = "Button_AddTarget"
        Me.Button_AddTarget.Size = New System.Drawing.Size(64, 199)
        Me.Button_AddTarget.TabIndex = 6
        Me.Button_AddTarget.Text = ">"
        Me.Button_AddTarget.UseVisualStyleBackColor = True
        '
        'TreeView_AvailableTargets
        '
        Me.TreeView_AvailableTargets.Location = New System.Drawing.Point(12, 37)
        Me.TreeView_AvailableTargets.Name = "TreeView_AvailableTargets"
        Me.TreeView_AvailableTargets.Size = New System.Drawing.Size(422, 442)
        Me.TreeView_AvailableTargets.TabIndex = 7
        '
        'TreeView_SelectedTargets
        '
        Me.TreeView_SelectedTargets.Location = New System.Drawing.Point(510, 37)
        Me.TreeView_SelectedTargets.Name = "TreeView_SelectedTargets"
        Me.TreeView_SelectedTargets.Size = New System.Drawing.Size(422, 442)
        Me.TreeView_SelectedTargets.TabIndex = 8
        '
        'RemoteAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 491)
        Me.Controls.Add(Me.TreeView_SelectedTargets)
        Me.Controls.Add(Me.TreeView_AvailableTargets)
        Me.Controls.Add(Me.Button_AddTarget)
        Me.Controls.Add(Me.Label_SelectedTargets)
        Me.Controls.Add(Me.Label_AvailableTargets)
        Me.Name = "RemoteAccess"
        Me.Text = "RemoteAccess"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_AvailableTargets As Label
    Friend WithEvents Label_SelectedTargets As Label
    Friend WithEvents Button_AddTarget As Button
    Friend WithEvents TreeView_AvailableTargets As TreeView
    Friend WithEvents TreeView_SelectedTargets As TreeView
End Class
