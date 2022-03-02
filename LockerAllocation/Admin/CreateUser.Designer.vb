<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateUser
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Enterbtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(16, 34)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(207, 22)
        Me.txtUser.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(16, 87)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(207, 22)
        Me.txtPass.TabIndex = 1
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtPass2
        '
        Me.txtPass2.Location = New System.Drawing.Point(16, 140)
        Me.txtPass2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.Size = New System.Drawing.Size(207, 22)
        Me.txtPass2.TabIndex = 2
        Me.txtPass2.UseSystemPasswordChar = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(16, 172)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(113, 21)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Administrator"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Enterbtn
        '
        Me.Enterbtn.Enabled = False
        Me.Enterbtn.Location = New System.Drawing.Point(124, 201)
        Me.Enterbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Enterbtn.Name = "Enterbtn"
        Me.Enterbtn.Size = New System.Drawing.Size(100, 28)
        Me.Enterbtn.TabIndex = 4
        Me.Enterbtn.Text = "Create User"
        Me.Enterbtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 201)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password Confirmation"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(141, 172)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(78, 21)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Encrypt"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CreateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 246)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Enterbtn)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtPass2)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateUser"
        Me.ShowIcon = False
        Me.Text = "CreateUser"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtPass2 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Enterbtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox2 As CheckBox
End Class
