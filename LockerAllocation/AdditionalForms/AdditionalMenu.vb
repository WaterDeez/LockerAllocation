Public Class AdditionalMenu
    Public Selections As New Selections()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LockReturn.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub AdditionalMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Selections.DrawAvatar(pbDBAvatar)
    End Sub
End Class