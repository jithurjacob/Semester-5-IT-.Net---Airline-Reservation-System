<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class allflights
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
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NobusinessseatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoeconomyseatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoluxuryseatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost_business_seat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost_economy_seat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost_luxury_seat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlightinfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlightDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlightDataSet2 = New WindowsApplication1.flightDataSet2()
        Me.Flight_infTableAdapter = New WindowsApplication1.flightDataSet2TableAdapters.flight_infTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightinfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FnameDataGridViewTextBoxColumn, Me.FcodeDataGridViewTextBoxColumn, Me.NobusinessseatDataGridViewTextBoxColumn, Me.NoeconomyseatDataGridViewTextBoxColumn, Me.NoluxuryseatDataGridViewTextBoxColumn, Me.cost_business_seat, Me.cost_economy_seat, Me.cost_luxury_seat})
        Me.DataGridView1.DataSource = Me.FlightinfBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(836, 481)
        Me.DataGridView1.TabIndex = 0
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "f_name"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "f_name"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        Me.FnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FcodeDataGridViewTextBoxColumn
        '
        Me.FcodeDataGridViewTextBoxColumn.DataPropertyName = "f_code"
        Me.FcodeDataGridViewTextBoxColumn.HeaderText = "f_code"
        Me.FcodeDataGridViewTextBoxColumn.Name = "FcodeDataGridViewTextBoxColumn"
        Me.FcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NobusinessseatDataGridViewTextBoxColumn
        '
        Me.NobusinessseatDataGridViewTextBoxColumn.DataPropertyName = "no_business_seat"
        Me.NobusinessseatDataGridViewTextBoxColumn.HeaderText = "no_business_seat"
        Me.NobusinessseatDataGridViewTextBoxColumn.Name = "NobusinessseatDataGridViewTextBoxColumn"
        Me.NobusinessseatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoeconomyseatDataGridViewTextBoxColumn
        '
        Me.NoeconomyseatDataGridViewTextBoxColumn.DataPropertyName = "no_economy_seat"
        Me.NoeconomyseatDataGridViewTextBoxColumn.HeaderText = "no_economy_seat"
        Me.NoeconomyseatDataGridViewTextBoxColumn.Name = "NoeconomyseatDataGridViewTextBoxColumn"
        Me.NoeconomyseatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoluxuryseatDataGridViewTextBoxColumn
        '
        Me.NoluxuryseatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NoluxuryseatDataGridViewTextBoxColumn.DataPropertyName = "no_luxury_seat"
        Me.NoluxuryseatDataGridViewTextBoxColumn.HeaderText = "no_luxury_seat"
        Me.NoluxuryseatDataGridViewTextBoxColumn.Name = "NoluxuryseatDataGridViewTextBoxColumn"
        Me.NoluxuryseatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'cost_business_seat
        '
        Me.cost_business_seat.DataPropertyName = "cost_business_seat"
        Me.cost_business_seat.HeaderText = "cost_business_seat"
        Me.cost_business_seat.Name = "cost_business_seat"
        Me.cost_business_seat.ReadOnly = True
        '
        'cost_economy_seat
        '
        Me.cost_economy_seat.DataPropertyName = "cost_economy_seat"
        Me.cost_economy_seat.HeaderText = "cost_economy_seat"
        Me.cost_economy_seat.Name = "cost_economy_seat"
        Me.cost_economy_seat.ReadOnly = True
        '
        'cost_luxury_seat
        '
        Me.cost_luxury_seat.DataPropertyName = "cost_luxury_seat"
        Me.cost_luxury_seat.HeaderText = "cost_luxury_seat"
        Me.cost_luxury_seat.Name = "cost_luxury_seat"
        Me.cost_luxury_seat.ReadOnly = True
        '
        'FlightinfBindingSource
        '
        Me.FlightinfBindingSource.DataMember = "flight_inf"
        Me.FlightinfBindingSource.DataSource = Me.FlightDataSet2BindingSource
        '
        'FlightDataSet2BindingSource
        '
        Me.FlightDataSet2BindingSource.DataSource = Me.FlightDataSet2
        Me.FlightDataSet2BindingSource.Position = 0
        '
        'FlightDataSet2
        '
        Me.FlightDataSet2.DataSetName = "flightDataSet2"
        Me.FlightDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Flight_infTableAdapter
        '
        Me.Flight_infTableAdapter.ClearBeforeFill = True
        '
        'allflights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 481)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "allflights"
        Me.Text = "allflights"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightinfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FlightDataSet2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FlightDataSet2 As WindowsApplication1.flightDataSet2
    Friend WithEvents FlightinfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Flight_infTableAdapter As WindowsApplication1.flightDataSet2TableAdapters.flight_infTableAdapter
    Friend WithEvents FnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NobusinessseatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoeconomyseatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoluxuryseatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cost_business_seat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cost_economy_seat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cost_luxury_seat As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
