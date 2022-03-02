<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SQLConnectionSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AddressTBox = New System.Windows.Forms.TextBox()
        Me.DBNameTBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TrustedConnectionCBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ServerNameTBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UsernameTBox = New System.Windows.Forms.TextBox()
        Me.PasswordTBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddressTBox
        '
        Me.AddressTBox.Location = New System.Drawing.Point(12, 29)
        Me.AddressTBox.Name = "AddressTBox"
        Me.AddressTBox.Size = New System.Drawing.Size(168, 20)
        Me.AddressTBox.TabIndex = 2
        '
        'DBNameTBox
        '
        Me.DBNameTBox.Location = New System.Drawing.Point(12, 110)
        Me.DBNameTBox.Name = "DBNameTBox"
        Me.DBNameTBox.Size = New System.Drawing.Size(168, 20)
        Me.DBNameTBox.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(96, 248)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TrustedConnectionCBox
        '
        Me.TrustedConnectionCBox.AutoSize = True
        Me.TrustedConnectionCBox.Location = New System.Drawing.Point(12, 136)
        Me.TrustedConnectionCBox.Name = "TrustedConnectionCBox"
        Me.TrustedConnectionCBox.Size = New System.Drawing.Size(119, 17)
        Me.TrustedConnectionCBox.TabIndex = 5
        Me.TrustedConnectionCBox.Text = "Trusted Connection"
        Me.TrustedConnectionCBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Server Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Database Name"
        '
        'ServerNameTBox
        '
        Me.ServerNameTBox.Location = New System.Drawing.Point(12, 71)
        Me.ServerNameTBox.Name = "ServerNameTBox"
        Me.ServerNameTBox.Size = New System.Drawing.Size(168, 20)
        Me.ServerNameTBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Server Name"
        '
        'UsernameTBox
        '
        Me.UsernameTBox.Location = New System.Drawing.Point(12, 172)
        Me.UsernameTBox.Name = "UsernameTBox"
        Me.UsernameTBox.Size = New System.Drawing.Size(168, 20)
        Me.UsernameTBox.TabIndex = 10
        '
        'PasswordTBox
        '
        Me.PasswordTBox.Location = New System.Drawing.Point(12, 211)
        Me.PasswordTBox.Name = "PasswordTBox"
        Me.PasswordTBox.Size = New System.Drawing.Size(168, 20)
        Me.PasswordTBox.TabIndex = 11
        Me.PasswordTBox.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Password"
        '
        'SQLConnectionSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(196, 286)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PasswordTBox)
        Me.Controls.Add(Me.UsernameTBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ServerNameTBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrustedConnectionCBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DBNameTBox)
        Me.Controls.Add(Me.AddressTBox)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SQLConnectionSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SQL Settings"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents AddressTBox As TextBox
    Friend WithEvents DBNameTBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TrustedConnectionCBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ServerNameTBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UsernameTBox As TextBox
    Friend WithEvents PasswordTBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
