Public Class NewLock
    Private SQL As New SQLControl
    Private Sub LoadStudents()
        ' REFRESH COMBOBOX
        ComboBox4.Items.Clear()

        ' RUN QUERY
        SQL.ExecQuery("SELECT DISTINCT *, (Surname + ', ' + PreferredNames) AS StudentName FROM StudentDetails ORDER BY Surname")

        If Sql.HasException(True) Then Exit Sub

        ComboBox4.DataSource = SQL.DBDT
        ComboBox4.DisplayMember = "StudentName"
        ComboBox4.ValueMember = "StudentID"
    End Sub
    Private Sub InsertLock()
        Dim combination As String = ComboBox1.Text + "." + ComboBox2.Text + "." + ComboBox3.Text
        If CheckBox1.Checked = True Then
            SQL.ExecQuery("INSERT INTO Locks VALUES ('" + TextBox1.Text + "','" + ComboBox1.Text + "." + ComboBox2.Text + "." + ComboBox3.Text + "',1,'" + ComboBox4.SelectedValue.ToString + "',GETDATE());")
        Else
            SQL.ExecQuery("INSERT INTO Locks (SerialNumber,Combination,Active,DateAdded) VALUES ('" + TextBox1.Text + "','" + ComboBox1.Text + "." + ComboBox2.Text + "." + ComboBox3.Text + "',0,GETDATE());")
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
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter a serial number")
        Else
            If ComboBox1.SelectedIndex = 0 AndAlso ComboBox2.SelectedIndex = 0 AndAlso ComboBox3.SelectedIndex = 0 Then
                MsgBox("Enter a valid combination")
            Else
                InsertLock()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearDetails()
    End Sub

    Private Sub NewLock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearDetails()
        LoadStudents()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            ComboBox4.Enabled = True
        Else
            ComboBox4.Enabled = False
        End If
    End Sub
End Class