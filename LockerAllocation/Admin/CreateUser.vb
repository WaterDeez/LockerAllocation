Imports EasyEncryption
Public Class CreateUser
    Public SQL As New SQLControl
    Public isAdmin As String = "0"
    Public doEncrypt As Boolean = True
    Private Sub InsertUser()
        'Use EasyEncrption library to store password with SHA256bit encryption if required
        Dim password
        If doEncrypt = True Then
            password = SHA.ComputeSHA256Hash(txtPass.Text)
        Else
            password = txtPass.Text
        End If

        'Add parameters for insert to stop malicious injection
        SQL.AddParam("@user", txtUser.Text)
        SQL.AddParam("@password", password)
        SQL.AddParam("@admin", isAdmin)
        'Insert into SQL Table
        SQL.ExecQuery("INSERT INTO Users (UserName,Password,Admin,Created) VALUES (@user,@password,@admin,GETDATE());")
        'Report & Abort on SQL Errors
        If SQL.HasException(True) Then Exit Sub
        MsgBox("User created succesfully!")
        'Clear Signup Textbox Fields
        txtPass.Clear()
        txtPass2.Clear()
        txtUser.Clear()
        'Disable Enter Button Again
        Enterbtn.Enabled = False
    End Sub
    Private Function userInUse() As Boolean
        'Flush existing data to stop data collisions
        If SQL.DBDT IsNot Nothing Then
            SQL.DBDT.Clear()
        End If
        'Query Users table for a matching user and password
        SQL.ExecQuery("SELECT Count(UserName) As UserCount From Users Where UserName='" & txtUser.Text & "'")
        'Check if there is a matching user
        If SQL.DBDT.Rows(0).Item("UserCount") >= 1 Then
            SQL.DBDT.Clear()
            Return True 'Make boolean true
        End If
        SQL.DBDT.Clear() 'Flush data again 
        Return False 'Make boolean false
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Enterbtn.Click
        'make sure passwords are matching for data validity
        If txtPass.Text = txtPass2.Text Then
            'function to check whether the username is already used in the database
            If userInUse() = False Then
                'Function to add all of the entered user details into the database
                InsertUser()
            Else
                'Warning box explaining username is already in use
                MsgBox("Username is already in use")
            End If
        Else
            'Warning that passwords do not match
            MsgBox("Passwords do not match...")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub txtFields_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUser.TextChanged, txtPass.TextChanged, txtPass2.TextChanged
        'Check if all of the text fields are NOT blank
        If Not String.IsNullOrWhiteSpace(txtUser.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPass.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPass2.Text) Then
            'Enable the enter button
            Enterbtn.Enabled = True
        Else
            Enterbtn.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            isAdmin = "1"
        Else
            isAdmin = "0"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            doEncrypt = True
        Else
            doEncrypt = False
        End If
    End Sub

    Private Sub CreateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class