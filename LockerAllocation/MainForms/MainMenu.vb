Public Class MainMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles UsernameLbl.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If adminAccount = True Then
            admin.Show()
            admin.StartPosition = FormStartPosition.CenterParent
            Me.Close()
        Else
            MsgBox("You are not an administrator!")
        End If

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        adminAccount = False
        username = ""
        login.Show()
        Me.Close()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameLbl.Text = username
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NewLock.Show()
    End Sub
End Class