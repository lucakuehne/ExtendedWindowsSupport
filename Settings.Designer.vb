<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.TabControl_Settings = New System.Windows.Forms.TabControl()
        Me.TabPage_Computers = New System.Windows.Forms.TabPage()
        Me.Label_Address = New System.Windows.Forms.Label()
        Me.Label_DisplayName = New System.Windows.Forms.Label()
        Me.TextBox_Address = New System.Windows.Forms.TextBox()
        Me.TextBox_DisplayName = New System.Windows.Forms.TextBox()
        Me.Button_AddComputer = New System.Windows.Forms.Button()
        Me.ListView_Computers = New System.Windows.Forms.ListView()
        Me.ColumnHeader_DisplayName = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader_Address = New System.Windows.Forms.ColumnHeader()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl_Settings.SuspendLayout()
        Me.TabPage_Computers.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl_Settings
        '
        Me.TabControl_Settings.Controls.Add(Me.TabPage_Computers)
        Me.TabControl_Settings.Controls.Add(Me.TabPage2)
        Me.TabControl_Settings.Location = New System.Drawing.Point(14, 15)
        Me.TabControl_Settings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl_Settings.Name = "TabControl_Settings"
        Me.TabControl_Settings.SelectedIndex = 0
        Me.TabControl_Settings.Size = New System.Drawing.Size(891, 537)
        Me.TabControl_Settings.TabIndex = 0
        '
        'TabPage_Computers
        '
        Me.TabPage_Computers.Controls.Add(Me.Label_Address)
        Me.TabPage_Computers.Controls.Add(Me.Label_DisplayName)
        Me.TabPage_Computers.Controls.Add(Me.TextBox_Address)
        Me.TabPage_Computers.Controls.Add(Me.TextBox_DisplayName)
        Me.TabPage_Computers.Controls.Add(Me.Button_AddComputer)
        Me.TabPage_Computers.Controls.Add(Me.ListView_Computers)
        Me.TabPage_Computers.Location = New System.Drawing.Point(4, 28)
        Me.TabPage_Computers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage_Computers.Name = "TabPage_Computers"
        Me.TabPage_Computers.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage_Computers.Size = New System.Drawing.Size(883, 505)
        Me.TabPage_Computers.TabIndex = 0
        Me.TabPage_Computers.Text = "Computers"
        Me.TabPage_Computers.UseVisualStyleBackColor = True
        '
        'Label_Address
        '
        Me.Label_Address.AutoSize = True
        Me.Label_Address.Location = New System.Drawing.Point(345, 442)
        Me.Label_Address.Name = "Label_Address"
        Me.Label_Address.Size = New System.Drawing.Size(65, 20)
        Me.Label_Address.TabIndex = 5
        Me.Label_Address.Text = "Address:"
        '
        'Label_DisplayName
        '
        Me.Label_DisplayName.AutoSize = True
        Me.Label_DisplayName.Location = New System.Drawing.Point(8, 442)
        Me.Label_DisplayName.Name = "Label_DisplayName"
        Me.Label_DisplayName.Size = New System.Drawing.Size(105, 20)
        Me.Label_DisplayName.TabIndex = 4
        Me.Label_DisplayName.Text = "Display Name:"
        '
        'TextBox_Address
        '
        Me.TextBox_Address.Location = New System.Drawing.Point(345, 465)
        Me.TextBox_Address.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox_Address.Name = "TextBox_Address"
        Me.TextBox_Address.Size = New System.Drawing.Size(330, 26)
        Me.TextBox_Address.TabIndex = 3
        '
        'TextBox_DisplayName
        '
        Me.TextBox_DisplayName.Location = New System.Drawing.Point(8, 465)
        Me.TextBox_DisplayName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox_DisplayName.Name = "TextBox_DisplayName"
        Me.TextBox_DisplayName.Size = New System.Drawing.Size(330, 26)
        Me.TextBox_DisplayName.TabIndex = 2
        '
        'Button_AddComputer
        '
        Me.Button_AddComputer.Location = New System.Drawing.Point(682, 442)
        Me.Button_AddComputer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button_AddComputer.Name = "Button_AddComputer"
        Me.Button_AddComputer.Size = New System.Drawing.Size(193, 52)
        Me.Button_AddComputer.TabIndex = 1
        Me.Button_AddComputer.Text = "Add Computer"
        Me.Button_AddComputer.UseVisualStyleBackColor = True
        '
        'ListView_Computers
        '
        Me.ListView_Computers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_Computers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_DisplayName, Me.ColumnHeader_Address})
        Me.ListView_Computers.FullRowSelect = True
        Me.ListView_Computers.GridLines = True
        Me.ListView_Computers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView_Computers.HideSelection = False
        Me.ListView_Computers.Location = New System.Drawing.Point(8, 9)
        Me.ListView_Computers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListView_Computers.Name = "ListView_Computers"
        Me.ListView_Computers.Size = New System.Drawing.Size(870, 425)
        Me.ListView_Computers.TabIndex = 0
        Me.ListView_Computers.UseCompatibleStateImageBehavior = False
        Me.ListView_Computers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader_DisplayName
        '
        Me.ColumnHeader_DisplayName.Text = "Display Name"
        Me.ColumnHeader_DisplayName.Width = 150
        '
        'ColumnHeader_Address
        '
        Me.ColumnHeader_Address.Text = "Address"
        Me.ColumnHeader_Address.Width = 150
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(883, 505)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 567)
        Me.Controls.Add(Me.TabControl_Settings)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.TabControl_Settings.ResumeLayout(False)
        Me.TabPage_Computers.ResumeLayout(False)
        Me.TabPage_Computers.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl_Settings As TabControl
    Friend WithEvents TabPage_Computers As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox_Address As TextBox
    Friend WithEvents TextBox_DisplayName As TextBox
    Friend WithEvents Button_AddComputer As Button
    Friend WithEvents ListView_Computers As ListView
    Friend WithEvents Label_Address As Label
    Friend WithEvents Label_DisplayName As Label
    Friend WithEvents ColumnHeader_DisplayName As ColumnHeader
    Friend WithEvents ColumnHeader_Address As ColumnHeader
End Class
