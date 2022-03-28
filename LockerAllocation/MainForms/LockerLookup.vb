Public Class LockerLookup
    Private SQL As New SQLControl
    Public selection As New Selections()
    Public sewin As Boolean = False

    Private Sub LockDetails()
        SQL.ExecQuery("SELECT * FROM Locks WHERE SerialNumber='" + AllocatedLocks.SelectedValue + "' AND StudentID='" + AllocatedStudents.SelectedValue + "';")
        DateAdded.Text = SQL.DBDT.Rows(0).Item("DateAdded")

        If SQL.DBDT.Rows(0).Item("Active") = "1" Then
            ActiveLock.CheckState = CheckState.Checked
        Else
            ActiveLock.CheckState = CheckState.Unchecked
        End If

        If SQL.DBDT.Rows(0).Item("Functional") = "1" Then
            FunctionalLock.CheckState = CheckState.Checked
        Else
            FunctionalLock.CheckState = CheckState.Unchecked
        End If

        Dim comb As String = SQL.DBDT.Rows(0).Item("Combination")
        Dim combination As String() = comb.Split(New Char() {"."c})
        Combination1.Text = combination(0)
        Combination2.Text = combination(1)
        Combination3.Text = combination(2)
    End Sub

    Private Sub StudentDetails()
        SQL.ExecQuery("SELECT DISTINCT * FROM StudentDetails FULL JOIN AllocatedLockers ON StudentDetails.StudentID=AllocatedLockers.StudentID WHERE StudentDetails.StudentID='" + AllocatedStudents.SelectedValue + "' ORDER BY AllocatedLockers.AllocationDate ASC;")
        StudentID.Text = SQL.DBDT.Rows(0).Item("StudentID")
        AllocationID.Text = SQL.DBDT.Rows(0).Item("AllocationID")
        AllocationDate.Text = SQL.DBDT.Rows(0).Item("AllocationDate")
        House.Text = SQL.DBDT.Rows(0).Item("House")
        Gender.Text = SQL.DBDT.Rows(0).Item("Gender")
        Grade.Text = SQL.DBDT.Rows(0).Item("YearLvl")

        If SQL.DBDT.Rows(0).Item("CurrentStudent") = "1" Then
            CurrentStudent.CheckState = CheckState.Checked
        Else
            CurrentStudent.CheckState = CheckState.Unchecked
        End If

        If SQL.DBDT.Rows(0).Item("MedicalExemption") = "1" Then
            MedicalExemption.CheckState = CheckState.Checked
        Else
            MedicalExemption.CheckState = CheckState.Unchecked
        End If

        If SQL.DBDT.Rows(0).Item("Returned") = "1" Then
            LockReturned.CheckState = CheckState.Checked
        Else
            LockReturned.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub FetchLocks()
        SQL.ExecQuery("SELECT DISTINCT * FROM Locks WHERE StudentID='" + AllocatedStudents.SelectedValue + "' ORDER BY DateAdded ASC;")
        AllocatedLocks.DataSource = SQL.DBDT
        AllocatedLocks.DisplayMember = "SerialNumber"
        AllocatedLocks.ValueMember = "SerialNumber"
    End Sub

    Private Sub FetchStudents()
        If sewin = False Then
            Exit Sub
        End If
        SQL.ExecQuery("SELECT DISTINCT *, (StudentDetails.Surname + ', '+ StudentDetails.PreferredNames) AS StudentName " &
                      "FROM StudentDetails RIGHT JOIN AllocatedLockers ON " &
                      "AllocatedLockers.StudentID = StudentDetails.StudentID AND AllocatedLockers.LockerID='" + lbLockers.SelectedValue + "' " &
                      "ORDER BY AllocationDate ASC;")
        AllocatedStudents.DataSource = SQL.DBDT
        AllocatedStudents.DisplayMember = "StudentName"
        AllocatedStudents.ValueMember = "StudentID"
    End Sub
    Private Sub FetchLockers()
        ' REFRESH locker LIST
        lbLockers.Items.Clear()

        ' ADD PARAMS & RUN QUERY
        SQL.AddParam("@lockers", "%" & txtFilter.Text & "%")
        SQL.ExecQuery("SELECT DISTINCT *, (LockerDetails.LockerID + ', '+ LockerLocations.LocationName) AS LockerInfo " &
                      "FROM LockerDetails LEFT JOIN LockerLocations ON LockerDetails.LocationID = LockerLocations.LocationID " &
                      "AND LockerDetails.LockerID LIKE @lockers " &
                      "ORDER BY LockerDetails.LockerID ASC;")

        ' REPORT & ABORT ON ERRORS
        If Sql.HasException(True) Then Exit Sub

        ' LOOP ROWS & RETURN USERS TO LIST
        lbLockers.DataSource = SQL.DBDT
        lbLockers.DisplayMember = "LockerInfo"
        lbLockers.ValueMember = "LockerID"
        'For Each r As DataRow In Sql.DBDT.Rows
        '    lbLockers.Items.Add(r("LockerInfo"))
        'Next
        sewin = True
    End Sub
    Private Sub txtFilter_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            FetchLockers()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub ClearForm()
        AllocatedStudents.Text = String.Empty
        AllocatedLocks.Text = String.Empty
        StudentID.Text = ""
        Gender.Text = ""
        AllocationDate.Text = ""
        House.Text = ""
        Grade.Text = ""
        AllocationID.Text = ""
        Combination1.Text = ""
        Combination2.Text = ""
        Combination3.Text = ""
        DateAdded.Text = ""
        CurrentStudent.CheckState = CheckState.Unchecked
        MedicalExemption.CheckState = CheckState.Unchecked
        LockReturned.CheckState = CheckState.Unchecked
        ActiveLock.CheckState = CheckState.Unchecked
        FunctionalLock.CheckState = CheckState.Unchecked
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LockReturn.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        NewStudent.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NewLock.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearForm()
    End Sub

    Private Sub LockerLookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearForm()
        FetchLockers()
    End Sub

    Private Sub AllocatedLocks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AllocatedLocks.SelectionChangeCommitted
        LockDetails()
    End Sub
    Private Sub lbLockers_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lbLockers.SelectedValueChanged
        FetchStudents()
    End Sub

    Private Sub AllocatedStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AllocatedStudents.SelectionChangeCommitted
        StudentDetails()
        FetchLocks()
    End Sub
End Class