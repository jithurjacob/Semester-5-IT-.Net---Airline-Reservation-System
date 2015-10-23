<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tick_rev
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.startlocn_cb = New System.Windows.Forms.ComboBox()
        Me.ServeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiceDataSet2 = New WindowsApplication1.serviceDataSet2()
        Me.ServeTableAdapter = New WindowsApplication1.serviceDataSet2TableAdapters.serveTableAdapter()
        Me.destnlocn_cb = New System.Windows.Forms.ComboBox()
        Me.ServeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.flightname_cb = New System.Windows.Forms.ComboBox()
        Me.no_bus_lbl = New System.Windows.Forms.Label()
        Me.no_eco_lbl = New System.Windows.Forms.Label()
        Me.no_lux_lbl = New System.Windows.Forms.Label()
        Me.dept_time_lbl = New System.Windows.Forms.Label()
        Me.arriv_time_lbl = New System.Windows.Forms.Label()
        Me.serviceid_lbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.no_bus_txt = New System.Windows.Forms.TextBox()
        Me.no_eco_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.no_luxu_txt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cust_name_txt = New System.Windows.Forms.TextBox()
        Me.cust_addr_txt = New System.Windows.Forms.TextBox()
        Me.cust_phone_txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.free_bus = New System.Windows.Forms.Label()
        Me.free_eco = New System.Windows.Forms.Label()
        Me.free_luxu = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cust_age_txt = New System.Windows.Forms.TextBox()
        Me.cust_sex_txt = New System.Windows.Forms.ComboBox()
        CType(Me.ServeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiceDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(274, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TICKET RESERVATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Starting Location : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Destination   :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Flight Id  :"
        '
        'startlocn_cb
        '
        Me.startlocn_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.startlocn_cb.Enabled = False
        Me.startlocn_cb.FormattingEnabled = True
        Me.startlocn_cb.Location = New System.Drawing.Point(394, 75)
        Me.startlocn_cb.Name = "startlocn_cb"
        Me.startlocn_cb.Size = New System.Drawing.Size(121, 21)
        Me.startlocn_cb.TabIndex = 4
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
        'destnlocn_cb
        '
        Me.destnlocn_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.destnlocn_cb.Enabled = False
        Me.destnlocn_cb.FormattingEnabled = True
        Me.destnlocn_cb.Location = New System.Drawing.Point(394, 102)
        Me.destnlocn_cb.Name = "destnlocn_cb"
        Me.destnlocn_cb.Size = New System.Drawing.Size(121, 21)
        Me.destnlocn_cb.TabIndex = 5
        '
        'ServeBindingSource1
        '
        Me.ServeBindingSource1.DataMember = "serve"
        Me.ServeBindingSource1.DataSource = Me.ServiceDataSet2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(260, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(394, 49)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'flightname_cb
        '
        Me.flightname_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.flightname_cb.Enabled = False
        Me.flightname_cb.FormattingEnabled = True
        Me.flightname_cb.Location = New System.Drawing.Point(394, 129)
        Me.flightname_cb.Name = "flightname_cb"
        Me.flightname_cb.Size = New System.Drawing.Size(121, 21)
        Me.flightname_cb.TabIndex = 8
        '
        'no_bus_lbl
        '
        Me.no_bus_lbl.AutoSize = True
        Me.no_bus_lbl.Location = New System.Drawing.Point(40, 12)
        Me.no_bus_lbl.Name = "no_bus_lbl"
        Me.no_bus_lbl.Size = New System.Drawing.Size(0, 13)
        Me.no_bus_lbl.TabIndex = 9
        '
        'no_eco_lbl
        '
        Me.no_eco_lbl.AutoSize = True
        Me.no_eco_lbl.Location = New System.Drawing.Point(40, 41)
        Me.no_eco_lbl.Name = "no_eco_lbl"
        Me.no_eco_lbl.Size = New System.Drawing.Size(0, 13)
        Me.no_eco_lbl.TabIndex = 10
        '
        'no_lux_lbl
        '
        Me.no_lux_lbl.AutoSize = True
        Me.no_lux_lbl.Location = New System.Drawing.Point(40, 71)
        Me.no_lux_lbl.Name = "no_lux_lbl"
        Me.no_lux_lbl.Size = New System.Drawing.Size(0, 13)
        Me.no_lux_lbl.TabIndex = 11
        '
        'dept_time_lbl
        '
        Me.dept_time_lbl.AutoSize = True
        Me.dept_time_lbl.Location = New System.Drawing.Point(40, 125)
        Me.dept_time_lbl.Name = "dept_time_lbl"
        Me.dept_time_lbl.Size = New System.Drawing.Size(0, 13)
        Me.dept_time_lbl.TabIndex = 12
        '
        'arriv_time_lbl
        '
        Me.arriv_time_lbl.AutoSize = True
        Me.arriv_time_lbl.Location = New System.Drawing.Point(40, 103)
        Me.arriv_time_lbl.Name = "arriv_time_lbl"
        Me.arriv_time_lbl.Size = New System.Drawing.Size(0, 13)
        Me.arriv_time_lbl.TabIndex = 13
        '
        'serviceid_lbl
        '
        Me.serviceid_lbl.AutoSize = True
        Me.serviceid_lbl.Location = New System.Drawing.Point(656, 36)
        Me.serviceid_lbl.Name = "serviceid_lbl"
        Me.serviceid_lbl.Size = New System.Drawing.Size(0, 13)
        Me.serviceid_lbl.TabIndex = 14
        Me.serviceid_lbl.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Number of business seats : "
        '
        'no_bus_txt
        '
        Me.no_bus_txt.Location = New System.Drawing.Point(228, 12)
        Me.no_bus_txt.Name = "no_bus_txt"
        Me.no_bus_txt.Size = New System.Drawing.Size(138, 20)
        Me.no_bus_txt.TabIndex = 16
        '
        'no_eco_txt
        '
        Me.no_eco_txt.Location = New System.Drawing.Point(228, 38)
        Me.no_eco_txt.Name = "no_eco_txt"
        Me.no_eco_txt.Size = New System.Drawing.Size(138, 20)
        Me.no_eco_txt.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Number of economy seats : "
        '
        'no_luxu_txt
        '
        Me.no_luxu_txt.Location = New System.Drawing.Point(228, 64)
        Me.no_luxu_txt.Name = "no_luxu_txt"
        Me.no_luxu_txt.Size = New System.Drawing.Size(138, 20)
        Me.no_luxu_txt.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Number of luxury seats : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Customer Name  :  "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Customer Address  :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Customer age  :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Customer gender : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 246)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Customer phone number :"
        '
        'cust_name_txt
        '
        Me.cust_name_txt.Location = New System.Drawing.Point(228, 99)
        Me.cust_name_txt.Name = "cust_name_txt"
        Me.cust_name_txt.Size = New System.Drawing.Size(138, 20)
        Me.cust_name_txt.TabIndex = 26
        '
        'cust_addr_txt
        '
        Me.cust_addr_txt.Location = New System.Drawing.Point(228, 126)
        Me.cust_addr_txt.Multiline = True
        Me.cust_addr_txt.Name = "cust_addr_txt"
        Me.cust_addr_txt.Size = New System.Drawing.Size(147, 60)
        Me.cust_addr_txt.TabIndex = 27
        '
        'cust_phone_txt
        '
        Me.cust_phone_txt.Location = New System.Drawing.Point(228, 239)
        Me.cust_phone_txt.Name = "cust_phone_txt"
        Me.cust_phone_txt.Size = New System.Drawing.Size(147, 20)
        Me.cust_phone_txt.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(394, 589)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Book"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'free_bus
        '
        Me.free_bus.AutoSize = True
        Me.free_bus.Location = New System.Drawing.Point(717, 153)
        Me.free_bus.Name = "free_bus"
        Me.free_bus.Size = New System.Drawing.Size(0, 13)
        Me.free_bus.TabIndex = 32
        Me.free_bus.Visible = False
        '
        'free_eco
        '
        Me.free_eco.AutoSize = True
        Me.free_eco.Location = New System.Drawing.Point(780, 227)
        Me.free_eco.Name = "free_eco"
        Me.free_eco.Size = New System.Drawing.Size(0, 13)
        Me.free_eco.TabIndex = 33
        Me.free_eco.Visible = False
        '
        'free_luxu
        '
        Me.free_luxu.AutoSize = True
        Me.free_luxu.Location = New System.Drawing.Point(729, 226)
        Me.free_luxu.Name = "free_luxu"
        Me.free_luxu.Size = New System.Drawing.Size(0, 13)
        Me.free_luxu.TabIndex = 34
        Me.free_luxu.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.cust_sex_txt)
        Me.Panel1.Controls.Add(Me.cust_addr_txt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.no_bus_txt)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cust_phone_txt)
        Me.Panel1.Controls.Add(Me.no_eco_txt)
        Me.Panel1.Controls.Add(Me.no_luxu_txt)
        Me.Panel1.Controls.Add(Me.cust_age_txt)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cust_name_txt)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(195, 310)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(461, 273)
        Me.Panel1.TabIndex = 35
        Me.Panel1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.no_eco_lbl)
        Me.Panel2.Controls.Add(Me.no_bus_lbl)
        Me.Panel2.Controls.Add(Me.no_lux_lbl)
        Me.Panel2.Controls.Add(Me.arriv_time_lbl)
        Me.Panel2.Controls.Add(Me.dept_time_lbl)
        Me.Panel2.Location = New System.Drawing.Point(136, 153)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(612, 151)
        Me.Panel2.TabIndex = 36
        Me.Panel2.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(486, 589)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cust_age_txt
        '
        Me.cust_age_txt.Location = New System.Drawing.Point(228, 189)
        Me.cust_age_txt.Name = "cust_age_txt"
        Me.cust_age_txt.Size = New System.Drawing.Size(147, 20)
        Me.cust_age_txt.TabIndex = 28
        '
        'cust_sex_txt
        '
        Me.cust_sex_txt.FormattingEnabled = True
        Me.cust_sex_txt.Items.AddRange(New Object() {"Male", "Female"})
        Me.cust_sex_txt.Location = New System.Drawing.Point(228, 215)
        Me.cust_sex_txt.Name = "cust_sex_txt"
        Me.cust_sex_txt.Size = New System.Drawing.Size(147, 21)
        Me.cust_sex_txt.TabIndex = 31
        '
        'tick_rev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(829, 619)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.free_luxu)
        Me.Controls.Add(Me.free_eco)
        Me.Controls.Add(Me.free_bus)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.serviceid_lbl)
        Me.Controls.Add(Me.flightname_cb)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.destnlocn_cb)
        Me.Controls.Add(Me.startlocn_cb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "tick_rev"
        Me.Text = "Form3"
        CType(Me.ServeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiceDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents startlocn_cb As System.Windows.Forms.ComboBox
    Friend WithEvents ServiceDataSet2 As WindowsApplication1.serviceDataSet2
    Friend WithEvents ServeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServeTableAdapter As WindowsApplication1.serviceDataSet2TableAdapters.serveTableAdapter
    Friend WithEvents destnlocn_cb As System.Windows.Forms.ComboBox
    Friend WithEvents ServeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents flightname_cb As System.Windows.Forms.ComboBox
    Friend WithEvents no_bus_lbl As System.Windows.Forms.Label
    Friend WithEvents no_eco_lbl As System.Windows.Forms.Label
    Friend WithEvents no_lux_lbl As System.Windows.Forms.Label
    Friend WithEvents dept_time_lbl As System.Windows.Forms.Label
    Friend WithEvents arriv_time_lbl As System.Windows.Forms.Label
    Friend WithEvents serviceid_lbl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents no_bus_txt As System.Windows.Forms.TextBox
    Friend WithEvents no_eco_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents no_luxu_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cust_name_txt As System.Windows.Forms.TextBox
    Friend WithEvents cust_addr_txt As System.Windows.Forms.TextBox
    Friend WithEvents cust_phone_txt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents free_bus As System.Windows.Forms.Label
    Friend WithEvents free_eco As System.Windows.Forms.Label
    Friend WithEvents free_luxu As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cust_sex_txt As System.Windows.Forms.ComboBox
    Friend WithEvents cust_age_txt As System.Windows.Forms.TextBox
End Class
