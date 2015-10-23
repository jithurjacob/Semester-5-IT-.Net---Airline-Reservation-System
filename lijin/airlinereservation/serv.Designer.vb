<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class serv
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.source_txt = New System.Windows.Forms.TextBox()
        Me.destination_txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ServeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiceDataSet2 = New WindowsApplication1.serviceDataSet2()
        Me.FlightinfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Servi = New WindowsApplication1.servi()
        Me.Flight_infTableAdapter = New WindowsApplication1.serviTableAdapters.flight_infTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fname_txt = New System.Windows.Forms.TextBox()
        Me.Flight = New WindowsApplication1.flight()
        Me.FlightinfBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Flight_infTableAdapter1 = New WindowsApplication1.flightTableAdapters.flight_infTableAdapter()
        Me.FlightDataSet2 = New WindowsApplication1.flightDataSet2()
        Me.FlightinfBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Flight_infTableAdapter2 = New WindowsApplication1.flightDataSet2TableAdapters.flight_infTableAdapter()
        Me.dept_time = New System.Windows.Forms.DateTimePicker()
        Me.arriv_time = New System.Windows.Forms.DateTimePicker()
        Me.ServeTableAdapter = New WindowsApplication1.serviceDataSet2TableAdapters.serveTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.FlightinfBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AirlineDataSet4 = New WindowsApplication1.airlineDataSet4()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Flight_infTableAdapter3 = New WindowsApplication1.airlineDataSet4TableAdapters.flight_infTableAdapter()
        CType(Me.ServeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightinfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Servi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightinfBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightinfBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightinfBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirlineDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SERVICE DETAILS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Service code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Source"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Destination"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(363, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Departure Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(363, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Arrival Time"
        '
        'source_txt
        '
        Me.source_txt.Location = New System.Drawing.Point(125, 185)
        Me.source_txt.Name = "source_txt"
        Me.source_txt.Size = New System.Drawing.Size(121, 20)
        Me.source_txt.TabIndex = 9
        '
        'destination_txt
        '
        Me.destination_txt.Location = New System.Drawing.Point(125, 221)
        Me.destination_txt.Name = "destination_txt"
        Me.destination_txt.Size = New System.Drawing.Size(121, 20)
        Me.destination_txt.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(234, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(366, 336)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(322, 91)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 15
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
        'FlightinfBindingSource
        '
        Me.FlightinfBindingSource.DataMember = "flight_inf"
        Me.FlightinfBindingSource.DataSource = Me.Servi
        '
        'Servi
        '
        Me.Servi.DataSetName = "servi"
        Me.Servi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Flight_infTableAdapter
        '
        Me.Flight_infTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Flight Name"
        '
        'fname_txt
        '
        Me.fname_txt.Enabled = False
        Me.fname_txt.Location = New System.Drawing.Point(322, 131)
        Me.fname_txt.Name = "fname_txt"
        Me.fname_txt.Size = New System.Drawing.Size(121, 20)
        Me.fname_txt.TabIndex = 8
        '
        'Flight
        '
        Me.Flight.DataSetName = "flight"
        Me.Flight.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlightinfBindingSource1
        '
        Me.FlightinfBindingSource1.DataMember = "flight_inf"
        Me.FlightinfBindingSource1.DataSource = Me.Flight
        '
        'Flight_infTableAdapter1
        '
        Me.Flight_infTableAdapter1.ClearBeforeFill = True
        '
        'FlightDataSet2
        '
        Me.FlightDataSet2.DataSetName = "flightDataSet2"
        Me.FlightDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlightinfBindingSource2
        '
        Me.FlightinfBindingSource2.DataMember = "flight_inf"
        Me.FlightinfBindingSource2.DataSource = Me.FlightDataSet2
        '
        'Flight_infTableAdapter2
        '
        Me.Flight_infTableAdapter2.ClearBeforeFill = True
        '
        'dept_time
        '
        Me.dept_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dept_time.Location = New System.Drawing.Point(468, 185)
        Me.dept_time.Name = "dept_time"
        Me.dept_time.Size = New System.Drawing.Size(200, 20)
        Me.dept_time.TabIndex = 16
        '
        'arriv_time
        '
        Me.arriv_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.arriv_time.Location = New System.Drawing.Point(468, 213)
        Me.arriv_time.Name = "arriv_time"
        Me.arriv_time.Size = New System.Drawing.Size(200, 20)
        Me.arriv_time.TabIndex = 17
        '
        'ServeTableAdapter
        '
        Me.ServeTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.FlightinfBindingSource3
        Me.ComboBox2.DisplayMember = "f_code"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(322, 53)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 19
        Me.ComboBox2.ValueMember = "f_code"
        '
        'FlightinfBindingSource3
        '
        Me.FlightinfBindingSource3.DataMember = "flight_inf"
        Me.FlightinfBindingSource3.DataSource = Me.AirlineDataSet4
        '
        'AirlineDataSet4
        '
        Me.AirlineDataSet4.DataSetName = "airlineDataSet4"
        Me.AirlineDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(238, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Flight code"
        '
        'Flight_infTableAdapter3
        '
        Me.Flight_infTableAdapter3.ClearBeforeFill = True
        '
        'serv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(697, 513)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.arriv_time)
        Me.Controls.Add(Me.dept_time)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.destination_txt)
        Me.Controls.Add(Me.source_txt)
        Me.Controls.Add(Me.fname_txt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "serv"
        Me.Text = "Form9"
        CType(Me.ServeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiceDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightinfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Servi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightinfBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightinfBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightinfBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirlineDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents source_txt As System.Windows.Forms.TextBox
    Friend WithEvents destination_txt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Servi As WindowsApplication1.servi
    Friend WithEvents FlightinfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Flight_infTableAdapter As WindowsApplication1.serviTableAdapters.flight_infTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fname_txt As System.Windows.Forms.TextBox
    Friend WithEvents Flight As WindowsApplication1.flight
    Friend WithEvents FlightinfBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Flight_infTableAdapter1 As WindowsApplication1.flightTableAdapters.flight_infTableAdapter
    Friend WithEvents FlightDataSet2 As WindowsApplication1.flightDataSet2
    Friend WithEvents FlightinfBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Flight_infTableAdapter2 As WindowsApplication1.flightDataSet2TableAdapters.flight_infTableAdapter
    Friend WithEvents dept_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents arriv_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents ServiceDataSet2 As WindowsApplication1.serviceDataSet2
    Friend WithEvents ServeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServeTableAdapter As WindowsApplication1.serviceDataSet2TableAdapters.serveTableAdapter
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AirlineDataSet4 As WindowsApplication1.airlineDataSet4
    Friend WithEvents FlightinfBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents Flight_infTableAdapter3 As WindowsApplication1.airlineDataSet4TableAdapters.flight_infTableAdapter
End Class
