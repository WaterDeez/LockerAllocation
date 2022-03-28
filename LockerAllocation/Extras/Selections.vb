Public Class Selections
    Public SQL As New SQLControl()

    Public Sub LoadStudents(ByRef cmbox As ComboBox)
        cmbox.Items.Clear()

        ' RUN QUERY
        SQL.ExecQuery("SELECT DISTINCT *, (Surname + ', ' + PreferredNames) AS StudentName FROM StudentDetails ORDER BY Surname;")

        If SQL.HasException(True) Then Exit Sub

        cmbox.DataSource = SQL.DBDT
        cmbox.DisplayMember = "StudentName"
        cmbox.ValueMember = "StudentID"
    End Sub
End Class