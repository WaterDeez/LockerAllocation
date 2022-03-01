Public Class AdminSQLQuery
    Private SQL As SQLControl
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        admin.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) Then
            SQL.ExecQuery(TextBox1.Text)
            If SQL.HasException(True) Then
                Label1.Text = "SQL Error"
            Else
                Label1.Text = "Success"
                DataGridView1.DataSource = SQL.DBDT
            End If
        Else
            Label1.Text = "No Query"
        End If
    End Sub
End Class