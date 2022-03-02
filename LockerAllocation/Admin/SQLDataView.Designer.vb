<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SQLDataView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbxItems = New System.Windows.Forms.ComboBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxItems
        '
        Me.cbxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxItems.FormattingEnabled = True
        Me.cbxItems.Location = New System.Drawing.Point(444, 12)
        Me.cbxItems.Name = "cbxItems"
        Me.cbxItems.Size = New System.Drawing.Size(144, 21)
        Me.cbxItems.TabIndex = 7
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(12, 43)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersWidth = 51
        Me.dgvData.Size = New System.Drawing.Size(576, 311)
        Me.dgvData.TabIndex = 6
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(11, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(165, 20)
        Me.txtSearch.TabIndex = 5
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(182, 13)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(66, 22)
        Me.cmdSearch.TabIndex = 4
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'SQLDataView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.cbxItems)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdSearch)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "SQLDataView"
        Me.Text = "SQLDataView"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxItems As ComboBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmdSearch As Button
End Class
