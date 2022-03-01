Public Class SwitchUser
    Private SQL As New SQLControl
    Private userAdmin As Integer
    Private currentUsername As String
    Private Sub FetchUsers()
        ' REFRESH USER LIST
        lbUsers.Items.Clear()

        ' ADD PARAMS & RUN QUERY
        SQL.AddParam("@users", "%" & txtFilter.Text & "%")
        SQL.ExecQuery("SELECT UserName " &
                      "FROM Users " &
                      "WHERE UserName LIKE @users " &
                      "ORDER BY UserName ASC;")

        ' REPORT & ABORT ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        ' LOOP ROWS & RETURN USERS TO LIST
        For Each r As DataRow In SQL.DBDT.Rows
            lbUsers.Items.Add(r("UserName"))
        Next
    End Sub

    Private Sub ChangeUser(Username As String)
        SQL.AddParam("@user", Username)
        SQL.ExecQuery("SELECT TOP 1 * " &
                      "FROM Users " &
                      "WHERE UserName = @user;")

        If SQL.RecordCount < 1 Then Exit Sub

        For Each r As DataRow In SQL.DBDT.Rows
            Username = r("UserName")
            userAdmin = r("Admin")
        Next
    End Sub

    Private Sub EditUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        currentUsername = username
        FetchUsers()
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            FetchUsers()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub lbUsers_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lbUsers.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChangeUser(lbUsers.Text)
        If userAdmin = 0 Then
            MainMenu.Show()
            adminAccount = False
            MainMenu.AdminLbl.Visible = False
        Else
            MainMenu.Show()
            adminAccount = True
            MainMenu.AdminLbl.Visible = True
        End If
        MainMenu.UsernameLbl.Text = username
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        adminAccount = True
        username = currentUsername
        admin.Show()
        Me.Close()
    End Sub
End Class