Public Class AdditionalMenu
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LockReturn.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MainMenu.Show()
        Me.Close()
    End Sub
End Class