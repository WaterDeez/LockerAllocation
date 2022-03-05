Public Class NewLock
    Private SQL As New SQLControl
    Private Sub LoadStudents()
        ' REFRESH COMBOBOX
        ComboBox4.Items.Clear()

        ' RUN QUERY
        SQL.ExecQuery("SELECT DISTINCT * FROM StudentDetails ORDER BY Surname")

        If Sql.HasException(True) Then Exit Sub

        ' LOOP ROW & ADD TO COMBOBOX
        For Each r As DataRow In Sql.DBDT.Rows
            ComboBox4.Items.Add(r("Surname").ToString & ", " & r("PreferredNames").ToString)
        Next
    End Sub
    Private Sub InsertLock()
        Dim combination As String = ComboBox1.Text + "." + ComboBox2.Text + "." + ComboBox3.Text
        SQL.AddParam("@combination", combination)
        SQL.AddParam("@serialnunber", TextBox1.Text)
        If CheckBox1.Checked = True Then
            SQL.ExecQuery("INSERT INTO Locks (SerialNumber,Combination,Active,StudentID,DateAdded) VALUES (@serialnumber,@combination,1," + ComboBox4.Text + ",GETDATE());")
        Else
            SQL.ExecQuery("INSERT INTO Locks (SerialNumber,Combination,Active,DateAdded) VALUES (@serialnumber,@combination,0,GETDATE());")
        End If
        'Report & Abort on SQL Errors
        If SQL.HasException(True) Then Exit Sub
        MsgBox("Lock added succesfully!")
        ClearDetails()
    End Sub
    Private Sub ClearDetails()
        TextBox1.Text = Nothing
        ComboBox1.SelectedIndex = "0"
        ComboBox2.SelectedIndex = "0"
        ComboBox3.SelectedIndex = "0"
        ComboBox4.SelectedItem = Nothing
        LoadStudents()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InsertLock()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearDetails()
    End Sub

    Private Sub NewLock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearDetails()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            ComboBox4.Enabled = True
        Else
            ComboBox4.Enabled = False
        End If
    End Sub
End Class