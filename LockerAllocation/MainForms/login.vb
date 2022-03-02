Imports EasyEncryption
Public Module UserVariables
    Public username As String
    Public adminAccount As Boolean
End Module
Public Class login
    Public SQLControl As New SQLControl()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not String.IsNullOrWhiteSpace(usernameTBox.Text) AndAlso Not String.IsNullOrWhiteSpace(passwordTBox.Text) Then
            SQLControl.ExecQuery("SELECT Count(UserName) As UserCount From Users Where UserName='" & usernameTBox.Text & "' AND Password='" & SHA.ComputeSHA256Hash(passwordTBox.Text) & "'")
            If SQLControl.DBDT.Rows(0).Item("UserCount") >= 1 Then
                username = usernameTBox.Text
                SQLControl.ExecQuery("SELECT Count(UserName) As UserCount From Users Where UserName='" & usernameTBox.Text & "' AND Password='" & SHA.ComputeSHA256Hash(passwordTBox.Text) & "' AND Admin='1'")
                If SQLControl.DBDT.Rows(0).Item("UserCount") >= 1 Then
                    adminAccount = True
                    MainMenu.Show()
                    MainMenu.AdminLbl.Visible = True
                Else
                    adminAccount = False
                    MainMenu.AdminLbl.Visible = False
                    MainMenu.Show()
                End If

                Me.Close()
            Else
                AlertLbl.Text = "Incorrect Login"
            End If
        Else
            AlertLbl.Text = "Insufficient information"
        End If
    End Sub

End Class
