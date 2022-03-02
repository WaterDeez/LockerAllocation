Imports System.Data.SqlClient
Public Class SQLConnectionSettings
    Public SQLControl As New SQLControl()
    Private testConnection As New SqlConnection()
    Private Sub SQLConnectionSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddressTBox.Text = My.Settings.SQLServerLocation
        ServerNameTBox.Text = My.Settings.SQLServerName
        DBNameTBox.Text = My.Settings.SQLDatabaseName
        If My.Settings.SQLTrustedConnection = True Then
            TrustedConnectionCBox.Checked = True
            UsernameTBox.Enabled = False
            PasswordTBox.Enabled = False
        Else
            TrustedConnectionCBox.Checked = False
            UsernameTBox.Enabled = True
            PasswordTBox.Enabled = True
            UsernameTBox.Text = My.Settings.SQLConnectionUsername
            PasswordTBox.Text = My.Settings.SQLConnectionPassword
        End If

    End Sub
    Private Sub TrustedConnectionCBox_CheckedChanged(sender As Object, e As EventArgs) Handles TrustedConnectionCBox.CheckedChanged
        If TrustedConnectionCBox.Checked = True Then
            My.Settings.SQLTrustedConnection = True
            UsernameTBox.Enabled = False
            PasswordTBox.Enabled = False
        Else
            My.Settings.SQLTrustedConnection = False
            UsernameTBox.Enabled = True
            PasswordTBox.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ConnectionTry(False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConnectionTry(True)
    End Sub

    Private Sub ConnectionTry(Test As Boolean)
        Try
            If TrustedConnectionCBox.Checked = True Then
                testConnection = New SqlConnection("Server=" + AddressTBox.Text + "\" + ServerNameTBox.Text + ";Database=" + DBNameTBox.Text + ";Trusted_Connection=True;")
            Else
                testConnection = New SqlConnection("Server=" + AddressTBox.Text + "\" + ServerNameTBox.Text + ";Database=" + DBNameTBox.Text + ";User ID=" + UsernameTBox.Text + ";Password=" + PasswordTBox.Text + ";")
            End If
            testConnection.Open()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message)
        Finally
            If testConnection.State = ConnectionState.Open Then
                testConnection.Close()
                If Test = True Then
                    MsgBox("SQL Test Connection Success", MsgBoxStyle.Information, "SQL Connection")
                Else
                    My.Settings.SQLServerLocation = AddressTBox.Text
                    My.Settings.SQLServerName = ServerNameTBox.Text
                    My.Settings.SQLDatabaseName = DBNameTBox.Text
                    If TrustedConnectionCBox.Checked = True Then
                        My.Settings.SQLTrustedConnection = True
                    Else
                        My.Settings.SQLTrustedConnection = False
                        My.Settings.SQLConnectionUsername = UsernameTBox.Text
                        My.Settings.SQLConnectionPassword = PasswordTBox.Text
                    End If
                    Me.Close()
                End If
            End If
        End Try
    End Sub
End Class