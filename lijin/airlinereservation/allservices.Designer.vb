<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class allservices
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrtiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiceDataSet2 = New WindowsApplication1.serviceDataSet2()
        Me.ServeTableAdapter = New WindowsApplication1.serviceDataSet2TableAdapters.serveTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FidDataGridViewTextBoxColumn, Me.SourceDataGridViewTextBoxColumn, Me.DestiDataGridViewTextBoxColumn, Me.DeptiDataGridViewTextBoxColumn, Me.ArrtiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ServeBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(687, 394)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FidDataGridViewTextBoxColumn
        '
        Me.FidDataGridViewTextBoxColumn.DataPropertyName = "f_id"
        Me.FidDataGridViewTextBoxColumn.HeaderText = "f_id"
        Me.FidDataGridViewTextBoxColumn.Name = "FidDataGridViewTextBoxColumn"
        Me.FidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SourceDataGridViewTextBoxColumn
        '
        Me.SourceDataGridViewTextBoxColumn.DataPropertyName = "source"
        Me.SourceDataGridViewTextBoxColumn.HeaderText = "source"
        Me.SourceDataGridViewTextBoxColumn.Name = "SourceDataGridViewTextBoxColumn"
        Me.SourceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DestiDataGridViewTextBoxColumn
        '
        Me.DestiDataGridViewTextBoxColumn.DataPropertyName = "desti"
        Me.DestiDataGridViewTextBoxColumn.HeaderText = "desti"
        Me.DestiDataGridViewTextBoxColumn.Name = "DestiDataGridViewTextBoxColumn"
        Me.DestiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeptiDataGridViewTextBoxColumn
        '
        Me.DeptiDataGridViewTextBoxColumn.DataPropertyName = "dep_ti"
        Me.DeptiDataGridViewTextBoxColumn.HeaderText = "dep_ti"
        Me.DeptiDataGridViewTextBoxColumn.Name = "DeptiDataGridViewTextBoxColumn"
        Me.DeptiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArrtiDataGridViewTextBoxColumn
        '
        Me.ArrtiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ArrtiDataGridViewTextBoxColumn.DataPropertyName = "arr_ti"
        Me.ArrtiDataGridViewTextBoxColumn.HeaderText = "arr_ti"
        Me.ArrtiDataGridViewTextBoxColumn.Name = "ArrtiDataGridViewTextBoxColumn"
        Me.ArrtiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServeBindingSource
        '
        Me.ServeBindingSource.DataMember = "serve"
        Me.ServeBindingSource.DataSource = Me.ServiceDataSet2
        '
        'ServiceDataSet2
        '
        Me.ServiceDataSet2.DataSetName = "serviceDataSet2"
        Me.ServiceDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServeTableAdapter
        '
        Me.ServeTableAdapter.ClearBeforeFill = True
        '
        'allservices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 394)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "allservices"
        Me.Text = "allservices"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiceDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ServiceDataSet2 As WindowsApplication1.serviceDataSet2
    Friend WithEvents ServeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServeTableAdapter As WindowsApplication1.serviceDataSet2TableAdapters.serveTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SourceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DestiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArrtiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
