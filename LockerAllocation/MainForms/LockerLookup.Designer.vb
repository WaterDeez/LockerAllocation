<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LockerLookup
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ActiveLock = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateAdded = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Combination3 = New System.Windows.Forms.TextBox()
        Me.Combination2 = New System.Windows.Forms.TextBox()
        Me.Combination1 = New System.Windows.Forms.TextBox()
        Me.LockReturned = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AllocatedLocks = New System.Windows.Forms.ComboBox()
        Me.MedicalExemption = New System.Windows.Forms.CheckBox()
        Me.CurrentStudent = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.House = New System.Windows.Forms.TextBox()
        Me.Gender = New System.Windows.Forms.TextBox()
        Me.Grade = New System.Windows.Forms.TextBox()
        Me.AllocationDate = New System.Windows.Forms.TextBox()
        Me.StudentID = New System.Windows.Forms.TextBox()
        Me.AllocatedStudents = New System.Windows.Forms.ComboBox()
        Me.lbLockers = New System.Windows.Forms.ListBox()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.FunctionalLock = New System.Windows.Forms.CheckBox()
        Me.AllocationID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(214, 253)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(78, 27)
        Me.Button5.TabIndex = 74
        Me.Button5.Text = "New Student"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(292, 331)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(78, 27)
        Me.Button4.TabIndex = 73
        Me.Button4.Text = "Main Menu"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(393, 210)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 27)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "New Lock"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(208, 331)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 27)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(393, 178)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 27)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Lock Return"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ActiveLock
        '
        Me.ActiveLock.AutoSize = True
        Me.ActiveLock.Enabled = False
        Me.ActiveLock.Location = New System.Drawing.Point(393, 136)
        Me.ActiveLock.Margin = New System.Windows.Forms.Padding(2)
        Me.ActiveLock.Name = "ActiveLock"
        Me.ActiveLock.Size = New System.Drawing.Size(127, 17)
        Me.ActiveLock.TabIndex = 69
        Me.ActiveLock.TabStop = False
        Me.ActiveLock.Text = "Currently Active Lock"
        Me.ActiveLock.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(393, 97)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Date Added"
        '
        'DateAdded
        '
        Me.DateAdded.Location = New System.Drawing.Point(393, 113)
        Me.DateAdded.Margin = New System.Windows.Forms.Padding(2)
        Me.DateAdded.Name = "DateAdded"
        Me.DateAdded.ReadOnly = True
        Me.DateAdded.Size = New System.Drawing.Size(156, 20)
        Me.DateAdded.TabIndex = 67
        Me.DateAdded.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(390, 59)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Lock Combination"
        '
        'Combination3
        '
        Me.Combination3.Location = New System.Drawing.Point(499, 74)
        Me.Combination3.Margin = New System.Windows.Forms.Padding(2)
        Me.Combination3.Name = "Combination3"
        Me.Combination3.ReadOnly = True
        Me.Combination3.Size = New System.Drawing.Size(50, 20)
        Me.Combination3.TabIndex = 64
        Me.Combination3.TabStop = False
        '
        'Combination2
        '
        Me.Combination2.Location = New System.Drawing.Point(446, 74)
        Me.Combination2.Margin = New System.Windows.Forms.Padding(2)
        Me.Combination2.Name = "Combination2"
        Me.Combination2.ReadOnly = True
        Me.Combination2.Size = New System.Drawing.Size(50, 20)
        Me.Combination2.TabIndex = 63
        Me.Combination2.TabStop = False
        '
        'Combination1
        '
        Me.Combination1.Location = New System.Drawing.Point(393, 74)
        Me.Combination1.Margin = New System.Windows.Forms.Padding(2)
        Me.Combination1.Name = "Combination1"
        Me.Combination1.ReadOnly = True
        Me.Combination1.Size = New System.Drawing.Size(50, 20)
        Me.Combination1.TabIndex = 62
        Me.Combination1.TabStop = False
        '
        'LockReturned
        '
        Me.LockReturned.AutoSize = True
        Me.LockReturned.Enabled = False
        Me.LockReturned.Location = New System.Drawing.Point(214, 231)
        Me.LockReturned.Margin = New System.Windows.Forms.Padding(2)
        Me.LockReturned.Name = "LockReturned"
        Me.LockReturned.Size = New System.Drawing.Size(97, 17)
        Me.LockReturned.TabIndex = 60
        Me.LockReturned.TabStop = False
        Me.LockReturned.Text = "Lock Returned"
        Me.LockReturned.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(390, 17)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Allocated Lock(s)"
        '
        'AllocatedLocks
        '
        Me.AllocatedLocks.FormattingEnabled = True
        Me.AllocatedLocks.Location = New System.Drawing.Point(393, 33)
        Me.AllocatedLocks.Margin = New System.Windows.Forms.Padding(2)
        Me.AllocatedLocks.Name = "AllocatedLocks"
        Me.AllocatedLocks.Size = New System.Drawing.Size(156, 21)
        Me.AllocatedLocks.TabIndex = 58
        '
        'MedicalExemption
        '
        Me.MedicalExemption.AutoSize = True
        Me.MedicalExemption.Enabled = False
        Me.MedicalExemption.Location = New System.Drawing.Point(214, 208)
        Me.MedicalExemption.Margin = New System.Windows.Forms.Padding(2)
        Me.MedicalExemption.Name = "MedicalExemption"
        Me.MedicalExemption.Size = New System.Drawing.Size(115, 17)
        Me.MedicalExemption.TabIndex = 57
        Me.MedicalExemption.TabStop = False
        Me.MedicalExemption.Text = "Medical Exemption"
        Me.MedicalExemption.UseVisualStyleBackColor = True
        '
        'CurrentStudent
        '
        Me.CurrentStudent.AutoSize = True
        Me.CurrentStudent.Enabled = False
        Me.CurrentStudent.Location = New System.Drawing.Point(214, 186)
        Me.CurrentStudent.Margin = New System.Windows.Forms.Padding(2)
        Me.CurrentStudent.Name = "CurrentStudent"
        Me.CurrentStudent.Size = New System.Drawing.Size(100, 17)
        Me.CurrentStudent.TabIndex = 56
        Me.CurrentStudent.TabStop = False
        Me.CurrentStudent.Text = "Current Student"
        Me.CurrentStudent.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(333, 141)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Grade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(214, 140)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "House"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(276, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Allocation Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Student ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Allocated Student(s)"
        '
        'House
        '
        Me.House.Location = New System.Drawing.Point(214, 156)
        Me.House.Margin = New System.Windows.Forms.Padding(2)
        Me.House.Name = "House"
        Me.House.ReadOnly = True
        Me.House.Size = New System.Drawing.Size(58, 20)
        Me.House.TabIndex = 49
        Me.House.TabStop = False
        '
        'Gender
        '
        Me.Gender.Location = New System.Drawing.Point(276, 156)
        Me.Gender.Margin = New System.Windows.Forms.Padding(2)
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        Me.Gender.Size = New System.Drawing.Size(53, 20)
        Me.Gender.TabIndex = 48
        Me.Gender.TabStop = False
        '
        'Grade
        '
        Me.Grade.Location = New System.Drawing.Point(333, 156)
        Me.Grade.Margin = New System.Windows.Forms.Padding(2)
        Me.Grade.Name = "Grade"
        Me.Grade.ReadOnly = True
        Me.Grade.Size = New System.Drawing.Size(39, 20)
        Me.Grade.TabIndex = 47
        Me.Grade.TabStop = False
        '
        'AllocationDate
        '
        Me.AllocationDate.Location = New System.Drawing.Point(214, 117)
        Me.AllocationDate.Margin = New System.Windows.Forms.Padding(2)
        Me.AllocationDate.Name = "AllocationDate"
        Me.AllocationDate.ReadOnly = True
        Me.AllocationDate.Size = New System.Drawing.Size(158, 20)
        Me.AllocationDate.TabIndex = 46
        Me.AllocationDate.TabStop = False
        '
        'StudentID
        '
        Me.StudentID.Location = New System.Drawing.Point(214, 74)
        Me.StudentID.Margin = New System.Windows.Forms.Padding(2)
        Me.StudentID.Name = "StudentID"
        Me.StudentID.ReadOnly = True
        Me.StudentID.Size = New System.Drawing.Size(76, 20)
        Me.StudentID.TabIndex = 45
        Me.StudentID.TabStop = False
        '
        'AllocatedStudents
        '
        Me.AllocatedStudents.FormattingEnabled = True
        Me.AllocatedStudents.Location = New System.Drawing.Point(214, 33)
        Me.AllocatedStudents.Margin = New System.Windows.Forms.Padding(2)
        Me.AllocatedStudents.Name = "AllocatedStudents"
        Me.AllocatedStudents.Size = New System.Drawing.Size(158, 21)
        Me.AllocatedStudents.TabIndex = 44
        '
        'lbLockers
        '
        Me.lbLockers.FormattingEnabled = True
        Me.lbLockers.Location = New System.Drawing.Point(12, 33)
        Me.lbLockers.Name = "lbLockers"
        Me.lbLockers.Size = New System.Drawing.Size(177, 329)
        Me.lbLockers.TabIndex = 43
        '
        'txtFilter
        '
        Me.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilter.Location = New System.Drawing.Point(12, 12)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(177, 20)
        Me.txtFilter.TabIndex = 42
        '
        'FunctionalLock
        '
        Me.FunctionalLock.AutoSize = True
        Me.FunctionalLock.Enabled = False
        Me.FunctionalLock.Location = New System.Drawing.Point(393, 157)
        Me.FunctionalLock.Margin = New System.Windows.Forms.Padding(2)
        Me.FunctionalLock.Name = "FunctionalLock"
        Me.FunctionalLock.Size = New System.Drawing.Size(102, 17)
        Me.FunctionalLock.TabIndex = 75
        Me.FunctionalLock.TabStop = False
        Me.FunctionalLock.Text = "Functional Lock"
        Me.FunctionalLock.UseVisualStyleBackColor = True
        '
        'AllocationID
        '
        Me.AllocationID.Location = New System.Drawing.Point(294, 74)
        Me.AllocationID.Margin = New System.Windows.Forms.Padding(2)
        Me.AllocationID.Name = "AllocationID"
        Me.AllocationID.ReadOnly = True
        Me.AllocationID.Size = New System.Drawing.Size(78, 20)
        Me.AllocationID.TabIndex = 76
        Me.AllocationID.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(291, 58)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Allocation ID"
        '
        'LockerLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 365)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.AllocationID)
        Me.Controls.Add(Me.FunctionalLock)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ActiveLock)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateAdded)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Combination3)
        Me.Controls.Add(Me.Combination2)
        Me.Controls.Add(Me.Combination1)
        Me.Controls.Add(Me.LockReturned)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AllocatedLocks)
        Me.Controls.Add(Me.MedicalExemption)
        Me.Controls.Add(Me.CurrentStudent)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.House)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Grade)
        Me.Controls.Add(Me.AllocationDate)
        Me.Controls.Add(Me.StudentID)
        Me.Controls.Add(Me.AllocatedStudents)
        Me.Controls.Add(Me.lbLockers)
        Me.Controls.Add(Me.txtFilter)
        Me.Name = "LockerLookup"
        Me.Text = "Lockerlookup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ActiveLock As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DateAdded As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Combination3 As TextBox
    Friend WithEvents Combination2 As TextBox
    Friend WithEvents Combination1 As TextBox
    Friend WithEvents LockReturned As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AllocatedLocks As ComboBox
    Friend WithEvents MedicalExemption As CheckBox
    Friend WithEvents CurrentStudent As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents House As TextBox
    Friend WithEvents Gender As TextBox
    Friend WithEvents Grade As TextBox
    Friend WithEvents AllocationDate As TextBox
    Friend WithEvents StudentID As TextBox
    Friend WithEvents AllocatedStudents As ComboBox
    Friend WithEvents lbLockers As ListBox
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents FunctionalLock As CheckBox
    Friend WithEvents AllocationID As TextBox
    Friend WithEvents Label11 As Label
End Class
