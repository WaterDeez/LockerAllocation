<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.usernameTBox = New System.Windows.Forms.TextBox()
        Me.passwordTBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AlertLbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 47)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(685, 47)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 95)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(559, 97)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Locker Allocater"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 325)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 57)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'usernameTBox
        '
        Me.usernameTBox.Location = New System.Drawing.Point(295, 167)
        Me.usernameTBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.usernameTBox.Name = "usernameTBox"
        Me.usernameTBox.Size = New System.Drawing.Size(209, 22)
        Me.usernameTBox.TabIndex = 5
        '
        'passwordTBox
        '
        Me.passwordTBox.Location = New System.Drawing.Point(295, 254)
        Me.passwordTBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.passwordTBox.Name = "passwordTBox"
        Me.passwordTBox.Size = New System.Drawing.Size(209, 22)
        Me.passwordTBox.TabIndex = 6
        Me.passwordTBox.UseSystemPasswordChar = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(419, 325)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 57)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Login"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(295, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Password"
        '
        'AlertLbl
        '
        Me.AlertLbl.AutoSize = True
        Me.AlertLbl.Location = New System.Drawing.Point(419, 303)
        Me.AlertLbl.Name = "AlertLbl"
        Me.AlertLbl.Size = New System.Drawing.Size(0, 17)
        Me.AlertLbl.TabIndex = 10
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AlertLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.passwordTBox)
        Me.Controls.Add(Me.usernameTBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "login"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents usernameTBox As TextBox
    Friend WithEvents passwordTBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AlertLbl As Label
End Class
