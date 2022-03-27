<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewStudent
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Entr = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MedExemption = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.House = New System.Windows.Forms.ComboBox()
        Me.Year = New System.Windows.Forms.ComboBox()
        Me.Surname = New System.Windows.Forms.TextBox()
        Me.PreferredName = New System.Windows.Forms.TextBox()
        Me.studentID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(72, 147)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 19)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(11, 147)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 19)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Entr
        '
        Me.Entr.Location = New System.Drawing.Point(145, 147)
        Me.Entr.Margin = New System.Windows.Forms.Padding(2)
        Me.Entr.Name = "Entr"
        Me.Entr.Size = New System.Drawing.Size(56, 19)
        Me.Entr.TabIndex = 31
        Me.Entr.Text = "Submit"
        Me.Entr.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(109, 86)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 46)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "House"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Year Level"
        '
        'MedExemption
        '
        Me.MedExemption.AutoSize = True
        Me.MedExemption.Location = New System.Drawing.Point(11, 126)
        Me.MedExemption.Margin = New System.Windows.Forms.Padding(2)
        Me.MedExemption.Name = "MedExemption"
        Me.MedExemption.Size = New System.Drawing.Size(115, 17)
        Me.MedExemption.TabIndex = 26
        Me.MedExemption.Text = "Medical Exemption"
        Me.MedExemption.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Preferred Name(s)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Student ID"
        '
        'Gender
        '
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.Gender.Location = New System.Drawing.Point(111, 101)
        Me.Gender.Margin = New System.Windows.Forms.Padding(2)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(92, 21)
        Me.Gender.TabIndex = 22
        '
        'House
        '
        Me.House.FormattingEnabled = True
        Me.House.Items.AddRange(New Object() {"SMITH", "MORRIS", "LANE", "GIBBS"})
        Me.House.Location = New System.Drawing.Point(111, 61)
        Me.House.Margin = New System.Windows.Forms.Padding(2)
        Me.House.Name = "House"
        Me.House.Size = New System.Drawing.Size(92, 21)
        Me.House.TabIndex = 21
        '
        'Year
        '
        Me.Year.FormattingEnabled = True
        Me.Year.Items.AddRange(New Object() {"10", "11", "12"})
        Me.Year.Location = New System.Drawing.Point(111, 21)
        Me.Year.Margin = New System.Windows.Forms.Padding(2)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(92, 21)
        Me.Year.TabIndex = 20
        '
        'Surname
        '
        Me.Surname.Location = New System.Drawing.Point(11, 102)
        Me.Surname.Margin = New System.Windows.Forms.Padding(2)
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(96, 20)
        Me.Surname.TabIndex = 19
        '
        'PreferredName
        '
        Me.PreferredName.Location = New System.Drawing.Point(11, 63)
        Me.PreferredName.Margin = New System.Windows.Forms.Padding(2)
        Me.PreferredName.Name = "PreferredName"
        Me.PreferredName.Size = New System.Drawing.Size(96, 20)
        Me.PreferredName.TabIndex = 18
        '
        'studentID
        '
        Me.studentID.Location = New System.Drawing.Point(11, 23)
        Me.studentID.Margin = New System.Windows.Forms.Padding(2)
        Me.studentID.Name = "studentID"
        Me.studentID.Size = New System.Drawing.Size(96, 20)
        Me.studentID.TabIndex = 17
        '
        'NewStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 171)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Entr)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MedExemption)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.House)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.Surname)
        Me.Controls.Add(Me.PreferredName)
        Me.Controls.Add(Me.studentID)
        Me.Name = "NewStudent"
        Me.Text = "NewStudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Entr As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MedExemption As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Gender As ComboBox
    Friend WithEvents House As ComboBox
    Friend WithEvents Year As ComboBox
    Friend WithEvents Surname As TextBox
    Friend WithEvents PreferredName As TextBox
    Friend WithEvents studentID As TextBox
End Class
