Public Class NewStudent
    Public SQL As New SQLControl
    Private Sub insertStudent()
        'Add parameters for insert to stop malicious injection
        SQL.AddParam("@StudentID", studentID.Text)
        SQL.AddParam("@Surname", Surname.Text)
        SQL.AddParam("@Name", PreferredName.Text)
        SQL.AddParam("@Year", Year.SelectedText)
        SQL.AddParam("@Gender", Gender.SelectedText)
        SQL.AddParam("@House", PreferredName.Text)
        If MedExemption.Checked = True Then
            SQL.AddParam("@Medical", "1")
        Else
            SQL.AddParam("@Medical", "0")
        End If
        'Insert into SQL Table
        SQL.ExecQuery("INSERT INTO StudentDetails (StudentID,Surname,PreferredNames,YearLvl,Gender,House,MedicalExemption,CurrentStudent) VALUES (@StudentID,@Surname,@Name,@Year,@Gender,@House,@Medical,1);")
        'Report & Abort on SQL Errors
        If SQL.HasException(True) Then Exit Sub
        MsgBox("Student added succesfully!")
        'Clear Fields
        ClearInputs()
        'Disable Enter Button Again
        Entr.Enabled = False
    End Sub
    Private Function studentIDInUse() As Boolean
        'Flush existing data to stop data collisions
        If SQL.DBDT IsNot Nothing Then
            SQL.DBDT.Clear()
        End If
        'Query Users table for a matching user and password
        SQL.ExecQuery("SELECT Count(StudentID) As IDCount From StudentDetails Where StudentID='" & studentID.Text & "'")
        'Check if there is a matching user
        If SQL.DBDT.Rows(0).Item("IDCount") >= 1 Then
            SQL.DBDT.Clear()
            Return True 'Make boolean true
        End If
        SQL.DBDT.Clear() 'Flush data again 
        Return False 'Make boolean false
    End Function
    Private Sub NewStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Entr_Click(sender As Object, e As EventArgs) Handles Entr.Click
        'function to check whether the studentID is already used in the database
        If studentIDInUse() = False Then
            'Function to add all of the entered user details into the database
            insertStudent()
        Else
            'Warning box explaining username is already in use
            MsgBox("StudentID is already in use")
        End If
    End Sub
    Private Sub ClearInputs()
        studentID.Text = ""
        PreferredName.Text = ""
        Surname.Text = ""
        Year.Text = String.Empty
        House.Text = String.Empty
        Gender.Text = String.Empty
        MedExemption.CheckState = CheckState.Unchecked
    End Sub
    Private Sub txtFields_TextChanged(sender As System.Object, e As System.EventArgs) Handles studentID.TextChanged, PreferredName.TextChanged, Surname.TextChanged
        'Check if all of the text fields are NOT blank
        If Not String.IsNullOrWhiteSpace(studentID.Text) AndAlso Not String.IsNullOrWhiteSpace(PreferredName.Text) AndAlso Not String.IsNullOrWhiteSpace(Surname.Text) Then
            'Enable the enter button
            Entr.Enabled = True
        Else
            Entr.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClearInputs()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class