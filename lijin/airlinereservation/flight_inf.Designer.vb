<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class flight_inf
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.flightname_txt = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.FlightinfBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AirlineDataSet2 = New WindowsApplication1.airlineDataSet2()
        Me.FlightinfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AirlineDataSet1 = New WindowsApplication1.airlineDataSet1()
        Me.Flight = New WindowsApplication1.flight()
        Me.business_txt = New System.Windows.Forms.TextBox()
        Me.Flight_infTableAdapter = New WindowsApplication1.flightTableAdapters.flight_infTableAdapter()
        Me.Flight_infTableAdapter1 = New WindowsApplication1.airlineDataSet1TableAdapters.flight_infTableAdapter()
        Me.economy_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.luxury_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FlightBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlightinfBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Flight_infTableAdapter2 = New WindowsApplication1.airlineDataSet2TableAdapters.flight_infTableAdapter()
        CType(Me.FlightinfBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirlineDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightinfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirlineDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlightinfBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(241, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FLIGHT INFORMATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FLIGHT NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FLIGHT CODE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "NUMBER OF BUSINESS SEATS"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(246, 421)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(369, 421)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "CANCEL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'flightname_txt
        '
        Me.flightname_txt.Location = New System.Drawing.Point(200, 122)
        Me.flightname_txt.Name = "flightname_txt"
        Me.flightname_txt.Size = New System.Drawing.Size(121, 20)
        Me.flightname_txt.TabIndex = 9
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.FlightinfBindingSource2
        Me.ComboBox2.DisplayMember = "f_code"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(200, 59)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 12
        Me.ComboBox2.ValueMember = "f_code"
        '
        'FlightinfBindingSource2
        '
        Me.FlightinfBindingSource2.DataMember = "flight_inf"
        Me.FlightinfBindingSource2.DataSource = Me.AirlineDataSet2
        '
        'AirlineDataSet2
        '
        Me.AirlineDataSet2.DataSetName = "airlineDataSet2"
        Me.AirlineDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlightinfBindingSource
        '
        Me.FlightinfBindingSource.DataMember = "flight_inf"
        Me.FlightinfBindingSource.DataSource = Me.AirlineDataSet1
        '
        'AirlineDataSet1
        '
        Me.AirlineDataSet1.DataSetName = "airlineDataSet1"
        Me.AirlineDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Flight
        '
        Me.Flight.DataSetName = "flight"
        Me.Flight.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'business_txt
        '
        Me.business_txt.Location = New System.Drawing.Point(200, 158)
        Me.business_txt.Name = "business_txt"
        Me.business_txt.Size = New System.Drawing.Size(121, 20)
        Me.business_txt.TabIndex = 13
        '
        'Flight_infTableAdapter
        '
        Me.Flight_infTableAdapter.ClearBeforeFill = True
        '
        'Flight_infTableAdapter1
        '
        Me.Flight_infTableAdapter1.ClearBeforeFill = True
        '
        'economy_txt
        '
        Me.economy_txt.Location = New System.Drawing.Point(200, 194)
        Me.economy_txt.Name = "economy_txt"
        Me.economy_txt.Size = New System.Drawing.Size(121, 20)
        Me.economy_txt.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "NUMBER OF ECONOMY  SEATS"
        '
        'luxury_txt
        '
        Me.luxury_txt.Location = New System.Drawing.Point(200, 231)
        Me.luxury_txt.Name = "luxury_txt"
        Me.luxury_txt.Size = New System.Drawing.Size(121, 20)
        Me.luxury_txt.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "NUMBER OF LUXURY SEATS"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(200, 350)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "COST OF LUXURY SEATS"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(200, 313)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "COST OF ECONOMY  SEATS"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(200, 277)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(121, 20)
        Me.TextBox3.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "COST OF BUSINESS SEATS"
        '
        'FlightBindingSource
        '
        Me.FlightBindingSource.DataSource = Me.Flight
        Me.FlightBindingSource.Position = 0
        '
        'FlightinfBindingSource1
        '
        Me.FlightinfBindingSource1.DataMember = "flight_inf"
        Me.FlightinfBindingSource1.DataSource = Me.FlightBindingSource
        '
        'Flight_infTableAdapter2
        '
        Me.Flight_infTableAdapter2.ClearBeforeFill = True
        '
        'flight_inf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 513)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.luxury_txt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.economy_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.business_txt)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.flightname_txt)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "flight_inf"
        Me.Text = "Form2"
        CType(Me.FlightinfBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirlineDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightinfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirlineDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlightinfBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents flightname_txt As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents business_txt As System.Windows.Forms.TextBox
    Friend WithEvents Flight As WindowsApplication1.flight
    Friend WithEvents FlightinfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Flight_infTableAdapter As WindowsApplication1.flightTableAdapters.flight_infTableAdapter
    Friend WithEvents AirlineDataSet1 As WindowsApplication1.airlineDataSet1
    Friend WithEvents Flight_infTableAdapter1 As WindowsApplication1.airlineDataSet1TableAdapters.flight_infTableAdapter
    Friend WithEvents economy_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents luxury_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FlightinfBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents FlightBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AirlineDataSet2 As WindowsApplication1.airlineDataSet2
    Friend WithEvents FlightinfBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Flight_infTableAdapter2 As WindowsApplication1.airlineDataSet2TableAdapters.flight_infTableAdapter
End Class
