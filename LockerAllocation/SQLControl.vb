Imports System.Data.SqlClient
Public Class SQLControl
    Private DBTrustedConnection As New SqlConnection("Server=" + My.Settings.SQLServerLocation + "\" + My.Settings.SQLServerName + ";Database=" + My.Settings.SQLDatabaseName + ";Trusted_Connection=True;")
    Private DBConnection As New SqlConnection("Server=" + My.Settings.SQLServerLocation + "\" + My.Settings.SQLServerName + ";Database=" + My.Settings.SQLDatabaseName + ";User ID=" + My.Settings.SQLConnectionUsername + ";Password=" + My.Settings.SQLConnectionPassword + ";")
    Private DBCmd As SqlCommand
    Private DBCon As New SqlConnection()
    'Database Data
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable
    'Public DBDS As DataSet

    'Query Data
    Public Params As New List(Of SqlParameter)
    Public RecordCount As Integer
    Public Exception As String

    ' EXECUTE QUERY SUB
    Public Sub ExecQuery(Query As String)
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""
        If My.Settings.SQLTrustedConnection = True Then
            DBCon = DBTrustedConnection
        Else
            DBCon = DBConnection
        End If
        Try
            DBCon.Open()

            ' CREATE DB COMMAND
            DBCmd = New SqlCommand(Query, DBCon)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' CLEAR PARAM LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATASET
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            'DBDS = New DataSet
            DBDA.Fill(DBDT)
            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub

    ' ADD PARAMS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    ' ERROR CHECKING
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True
    End Function

End Class
