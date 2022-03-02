<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UsernameLbl = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.AdminLbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(507, 17)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(155, 115)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 67)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Locker Rollover"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(310, 115)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 67)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Locker Lookup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(310, 196)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 67)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "New Lock"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(155, 196)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 67)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "New Student"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(310, 275)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(138, 67)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Admin Menu"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(155, 275)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(138, 67)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Additional Options"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 78)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Locker Allocater"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(31, 142)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 79)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 234)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Welcome back"
        '
        'UsernameLbl
        '
        Me.UsernameLbl.AutoSize = True
        Me.UsernameLbl.Location = New System.Drawing.Point(35, 250)
        Me.UsernameLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UsernameLbl.Name = "UsernameLbl"
        Me.UsernameLbl.Size = New System.Drawing.Size(0, 13)
        Me.UsernameLbl.TabIndex = 14
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(31, 275)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 25)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Logout"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'AdminLbl
        '
        Me.AdminLbl.AutoSize = True
        Me.AdminLbl.Location = New System.Drawing.Point(21, 309)
        Me.AdminLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AdminLbl.Name = "AdminLbl"
        Me.AdminLbl.Size = New System.Drawing.Size(94, 13)
        Me.AdminLbl.TabIndex = 26
        Me.AdminLbl.Text = "You are an Admin!"
        Me.AdminLbl.Visible = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.AdminLbl)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.UsernameLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UsernameLbl As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents AdminLbl As Label
End Class
