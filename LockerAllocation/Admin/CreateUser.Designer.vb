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
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.pbPreview = New System.Windows.Forms.PictureBox()
        Me.txtImagePath = New System.Windows.Forms.TextBox()
        Me.OFDBrowse = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(12, 28)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(156, 20)
        Me.txtUser.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(12, 71)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(156, 20)
        Me.txtPass.TabIndex = 1
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtPass2
        '
        Me.txtPass2.Location = New System.Drawing.Point(12, 114)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.Size = New System.Drawing.Size(156, 20)
        Me.txtPass2.TabIndex = 2
        Me.txtPass2.UseSystemPasswordChar = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 140)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(86, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Administrator"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Enterbtn
        '
        Me.Enterbtn.Enabled = False
        Me.Enterbtn.Location = New System.Drawing.Point(93, 163)
        Me.Enterbtn.Name = "Enterbtn"
        Me.Enterbtn.Size = New System.Drawing.Size(75, 23)
        Me.Enterbtn.TabIndex = 4
        Me.Enterbtn.Text = "Create User"
        Me.Enterbtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password Confirmation"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(106, 140)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Encrypt"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(174, 97)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(88, 21)
        Me.cmdBrowse.TabIndex = 15
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'pbPreview
        '
        Me.pbPreview.BackColor = System.Drawing.Color.LightGray
        Me.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPreview.Location = New System.Drawing.Point(174, 6)
        Me.pbPreview.Name = "pbPreview"
        Me.pbPreview.Size = New System.Drawing.Size(75, 75)
        Me.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPreview.TabIndex = 14
        Me.pbPreview.TabStop = False
        '
        'txtImagePath
        '
        Me.txtImagePath.Location = New System.Drawing.Point(190, 140)
        Me.txtImagePath.MaxLength = 30
        Me.txtImagePath.Name = "txtImagePath"
        Me.txtImagePath.ReadOnly = True
        Me.txtImagePath.Size = New System.Drawing.Size(349, 20)
        Me.txtImagePath.TabIndex = 13
        '
        'OFDBrowse
        '
        Me.OFDBrowse.FileName = "*.PNG"
        Me.OFDBrowse.Filter = "All Files| *.*|PNG|*.PNG"
        Me.OFDBrowse.InitialDirectory = "%appdata%"
        '
        'CreateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 194)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.pbPreview)
        Me.Controls.Add(Me.txtImagePath)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateUser"
        Me.ShowIcon = False
        Me.Text = "CreateUser"
        Me.TopMost = True
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents pbPreview As PictureBox
    Friend WithEvents txtImagePath As TextBox
    Friend WithEvents OFDBrowse As OpenFileDialog
End Class
