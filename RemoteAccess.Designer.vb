<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RemoteAccess
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TreeView_Computers = New System.Windows.Forms.TreeView()
        Me.Button_ConnectSession = New System.Windows.Forms.Button()
        Me.Button_ConnectComputer = New System.Windows.Forms.Button()
        Me.ComboBox_SessionConnectionMode = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TreeView_Computers
        '
        Me.TreeView_Computers.Location = New System.Drawing.Point(15, 16)
        Me.TreeView_Computers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TreeView_Computers.Name = "TreeView_Computers"
        Me.TreeView_Computers.Size = New System.Drawing.Size(394, 551)
        Me.TreeView_Computers.TabIndex = 0
        '
        'Button_ConnectSession
        '
        Me.Button_ConnectSession.Enabled = False
        Me.Button_ConnectSession.Location = New System.Drawing.Point(214, 576)
        Me.Button_ConnectSession.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button_ConnectSession.Name = "Button_ConnectSession"
        Me.Button_ConnectSession.Size = New System.Drawing.Size(195, 32)
        Me.Button_ConnectSession.TabIndex = 1
        Me.Button_ConnectSession.Text = "Connect to Session"
        Me.Button_ConnectSession.UseVisualStyleBackColor = True
        '
        'Button_ConnectComputer
        '
        Me.Button_ConnectComputer.Location = New System.Drawing.Point(15, 576)
        Me.Button_ConnectComputer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button_ConnectComputer.Name = "Button_ConnectComputer"
        Me.Button_ConnectComputer.Size = New System.Drawing.Size(195, 32)
        Me.Button_ConnectComputer.TabIndex = 2
        Me.Button_ConnectComputer.Text = "Connect to Computer"
        Me.Button_ConnectComputer.UseVisualStyleBackColor = True
        '
        'ComboBox_SessionConnectionMode
        '
        Me.ComboBox_SessionConnectionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_SessionConnectionMode.DropDownWidth = 250
        Me.ComboBox_SessionConnectionMode.Enabled = False
        Me.ComboBox_SessionConnectionMode.FormattingEnabled = True
        Me.ComboBox_SessionConnectionMode.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ComboBox_SessionConnectionMode.Items.AddRange(New Object() {"✔ Control | ✔ User-Consent (Recommended)", "✖ Control | ✔ User-Consent", "✔ Control | ✖ User-Consent", "✖ Control | ✖ User-Consent"})
        Me.ComboBox_SessionConnectionMode.Location = New System.Drawing.Point(215, 612)
        Me.ComboBox_SessionConnectionMode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox_SessionConnectionMode.Name = "ComboBox_SessionConnectionMode"
        Me.ComboBox_SessionConnectionMode.Size = New System.Drawing.Size(193, 27)
        Me.ComboBox_SessionConnectionMode.TabIndex = 4
        '
        'RemoteAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 661)
        Me.Controls.Add(Me.ComboBox_SessionConnectionMode)
        Me.Controls.Add(Me.Button_ConnectComputer)
        Me.Controls.Add(Me.Button_ConnectSession)
        Me.Controls.Add(Me.TreeView_Computers)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "RemoteAccess"
        Me.Text = "RemoteAccess"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView_Computers As TreeView
    Friend WithEvents Button_ConnectSession As Button
    Friend WithEvents Button_ConnectComputer As Button
    Friend WithEvents ComboBox_SessionConnectionMode As ComboBox
End Class
