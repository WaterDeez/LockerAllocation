Public Class DatabaseChecks
    Public SQLControl As New SQLControl()
    Public Function LockCheck(Optional Report As Boolean = False) As Boolean
        SQLControl.ExecQuery("SELECT * FROM Locks WHERE StudentID IS NULL AND ACTIVE=1;")
        If SQLControl.DBDT.Rows(0).Item("SerialNumber") >= 1 Then
            Return False
            MsgBox("There is a discrepency with the lock database!")
        Else
            Return True
        End If
    End Function
End Class
