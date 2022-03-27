Public Class LockReturn
    Public selection As New Selections()
    Public sql As New SQLControl()
    Private loading As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub LockReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selection.LoadStudents(ComboBox1)
        loading = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        If ComboBox1.Text = Nothing Then Exit Sub
        sql.ExecQuery("SELECT * FROM Locks WHERE StudentID='" + ComboBox1.SelectedValue + "';")
        If sql.HasException(True) Then Exit Sub
        If sql.DBDT Is DBNull.Value Then
            MsgBox("no lock assigned")
            Exit Sub
        ElseIf sql.DBDT.Rows(0).Item("StudentID") >= 2 Then
            MsgBox("More than one lock has been allocated to this student!")
        ElseIf sql.DBDT.Rows(0).Item("StudentID") = 1 Then
            TextBox1.Text = sql.DBDT.Rows(0).Item("SerialNumber")
        Else
            MsgBox("Error!")
        End If

    End Sub

End Class