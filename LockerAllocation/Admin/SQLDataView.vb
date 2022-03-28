Public Class SQLDataView
    Public SQL As New SQLControl
    Private SelectedTable As String

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM Users;")
        Else
            SQL.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If SQL.HasException(True) Then Exit Sub

        dgvData.DataSource = SQL.DBDT
    End Sub

    Private Sub LoadCBX()
        ' REFRESH COMBOBOX
        cbxItems.Items.Clear()

        ' RUN QUERY
        SQL.ExecQuery("SELECT DISTINCT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'")

        If SQL.HasException(True) Then Exit Sub

        ' LOOP ROW & ADD TO COMBOBOX
        For Each r As DataRow In SQL.DBDT.Rows
            cbxItems.Items.Add(r("TABLE_NAME").ToString)
        Next
    End Sub

    Private Sub FindItem()
        Dim temp As Integer = 0
        For i As Integer = 0 To dgvData.RowCount - 1
            For j As Integer = 0 To dgvData.ColumnCount - 1
                If dgvData.Rows(i).Cells(j).Value.ToString.ToUpper() = txtSearch.Text.ToUpper() Then
                    dgvData.Rows(i).Cells(j).Selected = True
                    temp = 1
                End If
            Next
        Next
        If temp = 0 Then
            MsgBox("Item not found")
        End If
    End Sub

    Private Sub Inventory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadGrid()
        LoadCBX()
    End Sub

    Private Sub cmdSearch_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearch.Click
        FindItem()
    End Sub

    Private Sub cbxItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxItems.SelectedIndexChanged
        SelectedTable = cbxItems.SelectedItem.ToString
        LoadGrid("SELECT * From " + SelectedTable + ";")
    End Sub
End Class