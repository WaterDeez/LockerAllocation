Imports System.IO
Public Class MainMenu
    Public Selections As New Selections()


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
        Selections.DrawAvatar(pbDBAvatar)

        UsernameLbl.Text = username
        If adminAccount = True Then
            AdminLbl.Visible = True
        Else
            AdminLbl.Visible = False
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NewLock.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AdditionalMenu.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        LockerLookup.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        NewStudent.Show()
    End Sub
End Class