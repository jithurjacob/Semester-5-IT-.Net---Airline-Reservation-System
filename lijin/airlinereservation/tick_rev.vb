Imports System.Data.SqlClient
Public Class tick_rev
    Dim cn As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True")

    Private Sub tick_rev_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ServiceDataSet2.serve' table. You can move, or remove it, as needed.
        Me.ServeTableAdapter.Fill(Me.ServiceDataSet2.serve)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startlocn_cb.SelectedIndexChanged
        Try
            Dim st As String = DateTimePicker1.Value.ToString.Substring(0, 10) + "%"
            Dim cmd As New SqlCommand("select * from serve where source=@s and dep_ti like @t;", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@s", startlocn_cb.Text)
            cmd.Parameters.AddWithValue("@t", st)
            ' MsgBox(st + ComboBox1.Text)
            cn.Close()
            cn.Open()
            Dim reader As SqlDataReader

            Dim dt = New DataTable()
            reader = cmd.ExecuteReader
            dt.Load(reader)
            ''  DataGridView1.AutoGenerateColumns = True
            'DataGridView1.DataSource = dt
            ' DataGridView1.Refresh()
            destnlocn_cb.AutoCompleteMode = AutoCompleteMode.None
            destnlocn_cb.DisplayMember = "desti"
            destnlocn_cb.DataSource = dt
            destnlocn_cb.Refresh()
            cn.Close()
            destnlocn_cb.Enabled = True
            startlocn_cb.Enabled = True
            Panel1.Visible = False
            Panel2.Visible = False

            flightname_cb.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles destnlocn_cb.SelectionChangeCommitted
        Try
            Dim st As String = DateTimePicker1.Value.ToString.Substring(0, 10) + "%"
            Dim cmd As New SqlCommand("select * from serve where source=@s and dep_ti like @t and desti=@d", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@s", startlocn_cb.Text)
            cmd.Parameters.AddWithValue("@t", st)
            cmd.Parameters.AddWithValue("@d", destnlocn_cb.Text)
            ' MsgBox(st + ComboBox1.Text)
            cn.Close()
            cn.Open()
            Dim reader As SqlDataReader

            Dim dt = New DataTable()
            reader = cmd.ExecuteReader
            dt.Load(reader)
            ''  DataGridView1.AutoGenerateColumns = True
            'DataGridView1.DataSource = dt
            ' DataGridView1.Refresh()
            flightname_cb.AutoCompleteMode = AutoCompleteMode.None
            flightname_cb.DisplayMember = "f_id"

            flightname_cb.DataSource = dt
            flightname_cb.Refresh()
            cn.Close()
            flightname_cb.Enabled = True
            startlocn_cb.Enabled = True
            Panel1.Visible = False
            Panel2.Visible = False
            destnlocn_cb.Enabled = True
            flightname_cb.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    
    Private Sub flightname_cb_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flightname_cb.SelectionChangeCommitted
        Try
            Dim total_bus As Integer = 0
            Dim total_eco As Integer = 0
            Dim total_luxu As Integer = 0
            Dim service_id As Integer = 0
            Dim count_bus As Integer = 0
            Dim count_eco As Integer = 0
            Dim count_luxu As Integer = 0
            Dim cost_bus As String = ""
            Dim cost_lux As String = ""
            Dim cost_eco As String = ""
            cn.Close()
            cn.Open()
            Dim flightid As String = flightname_cb.Text
            ' MsgBox(flightid)
            Dim cmd As New SqlCommand("select * from serve,flight_inf where f_id=@code and f_code=f_id and source=@s and desti=@d", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@code", flightid)
            cmd.Parameters.AddWithValue("@s", startlocn_cb.Text)
            cmd.Parameters.AddWithValue("@d", destnlocn_cb.Text)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            If reader.HasRows.Equals(False) Then
                MsgBox("Error... Flight not found...")
                Return
            End If
            While reader.Read
                dept_time_lbl.Text = "Departure Time  :   " + reader.Item("dep_ti").ToString
                arriv_time_lbl.Text = "Arrival Time    :   " + reader.Item("arr_ti").ToString
                serviceid_lbl.Text = reader.Item("id").ToString
                service_id = reader.Item("id")
                total_bus = reader.Item("no_business_seat")
                total_eco = reader.Item("no_economy_seat")
                total_luxu = reader.Item("no_luxury_seat")
                cost_bus = reader.Item("cost_business_seat")
                cost_eco = reader.Item("cost_economy_seat")
                cost_lux = reader.Item("cost_luxury_seat")
            End While
            cn.Close()
            'end of finding no timings
            'start of finding remaining seats
            cn.Close()
            cn.Open()
            Dim cmd1 As New SqlCommand("select * from booking where service_id=@code", cn)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@code", serviceid_lbl.Text)

            Dim reader1 As SqlDataReader = cmd1.ExecuteReader
            
            While reader1.Read
                count_bus += reader1.Item("no_business_seat")
                count_eco += reader1.Item("no_economy_seat")
                count_luxu += reader1.Item("no_luxury_seat")
            End While
            no_bus_lbl.Text = "BUSINESS: Total number of seats : " + total_bus.ToString + "     Remaining number of seats : " + (total_bus - count_bus).ToString + "    Cost per seat : " + cost_bus

            no_eco_lbl.Text = "ECONOMY: Total number of seats : " + total_eco.ToString + "     Remaining number of seats : " + (total_eco - count_eco).ToString + "    Cost per seat : " + cost_eco
            no_lux_lbl.Text = "LUXURY :Total number of seats : " + total_luxu.ToString + "     Remaining number of seats : " + (total_luxu - count_luxu).ToString + "    Cost per seat : " + cost_lux

            free_bus.Text = (total_bus - count_bus).ToString
            free_eco.Text = (total_eco - count_eco).ToString
            free_luxu.Text = (total_luxu - count_luxu).ToString
            cn.Close()
            Panel1.Visible = True
            Panel2.Visible = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

   
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Value.Date.ToString.CompareTo(Now.Date.ToString) < 0 Then
            MsgBox("Please select a valid date...")
            Return
        End If

        Try
            Dim st As String = DateTimePicker1.Value.ToString.Substring(0, 10) + "%"
            Dim cmd As New SqlCommand("select * from serve where  dep_ti like @t;", cn)
            cmd.Parameters.Clear()
            'cmd.Parameters.AddWithValue("@s", startlocn_cb.Text)
            cmd.Parameters.AddWithValue("@t", st)
            ' MsgBox(st + ComboBox1.Text)
            cn.Close()
            cn.Open()
            Dim reader As SqlDataReader

            Dim dt = New DataTable()
            reader = cmd.ExecuteReader
            dt.Load(reader)
            ''  DataGridView1.AutoGenerateColumns = True
            'DataGridView1.DataSource = dt
            ' DataGridView1.Refresh()
            startlocn_cb.AutoCompleteMode = AutoCompleteMode.None
            startlocn_cb.DisplayMember = "source"
            startlocn_cb.DataSource = dt
            startlocn_cb.Refresh()
            cn.Close()
            startlocn_cb.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        startlocn_cb.Enabled = True
        Panel1.Visible = False
        Panel2.Visible = False
        destnlocn_cb.Enabled = False
        flightname_cb.Enabled = False
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim valid As New valid
        If Not valid.is_postive_number_only(no_bus_txt.Text) Then
            MsgBox("enter a positive number..")
            Return
        End If
        If Not valid.is_postive_number_only(no_eco_txt.Text) Then
            MsgBox("enter a positive number..")
            Return
        End If
        If Not valid.is_postive_number_only(no_luxu_txt.Text) Then
            MsgBox("enter a positive number..")
            Return
        End If
        If Not valid.is_name(cust_name_txt.Text) Then
            MsgBox("enter a proper name..")
            Return
        End If
        
        If Not valid.is_postive_number_only(cust_age_txt.Text) Then
            MsgBox("enter a positive number..")
            Return
        End If      
        If valid.is_alphabet_only(cust_sex_txt.Text) Then
            If cust_sex_txt.Text = "Male" Or cust_sex_txt.Text = "Female" Then

            Else
                MsgBox("invalid gender..")
                Return
            End If
        Else
            MsgBox("invalid gender..")
            Return

        End If
        If Not valid.is_mobile_number(cust_phone_txt.Text) Then
            MsgBox("enter a mobile number..")
            Return
        End If

        Try
            If no_bus_txt.Text.Equals("") Or no_eco_txt.Text.Equals("") Or no_luxu_txt.Text.Equals("") Or cust_name_txt.Equals("") Or cust_addr_txt.Text.Equals("") Or cust_age_txt.Text.Equals("") Or cust_name_txt.Text.Equals("") Or cust_phone_txt.Text.Equals("") Or cust_sex_txt.Text.Equals("") Then
                MsgBox("Fill all the fields..")
                Return
            End If
            Dim no_bus, no_eco, no_lux As Integer
            no_bus = Integer.Parse(no_bus_txt.Text)
            no_eco = Integer.Parse(no_eco_txt.Text)
            no_lux = Integer.Parse(no_luxu_txt.Text)

            If (no_bus > Integer.Parse(free_bus.Text)) Or (no_eco > Integer.Parse(free_eco.Text)) Or (no_lux > Integer.Parse(free_luxu.Text)) Then
                MsgBox("Requested number of seats are not available...")
                Return
            End If
            cn.Open()
            Dim cmd As New SqlCommand("select * from flight_inf where f_code=@code", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@code", flightname_cb.Text)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            If reader.HasRows.Equals(False) Then
                MsgBox("Error.." + flightname_cb.Text)
                Return
            End If
            Dim amt As Integer = 0
            While reader.Read
                amt = (no_bus * Val(reader.Item("cost_business_seat"))) + (no_eco * Val(reader.Item("cost_economy_seat"))) + (no_lux * Val(reader.Item("cost_luxury_seat")))
                '   MsgBox(amt.ToString + Val(reader.Item("cost_business_seat")).ToString)
            End While

            MsgBox("Amount to be payed is " + amt.ToString)
            reader.Close()
            cn.Close()
            cn.Open()
            Dim cmd3 As New SqlCommand("insert into booking values(@i,@service_id,@nb,@ne,@nl,@amt,@cn,@cage,@caddr,@csex,@cph,@fcode)", cn)
            cmd3.Parameters.Clear()
            Dim id As String = idcalc()
            cmd3.Parameters.AddWithValue("@i", id)
            cmd3.Parameters.AddWithValue("@service_id", serviceid_lbl.Text)
            cmd3.Parameters.AddWithValue("@nb", no_bus_txt.Text)
            cmd3.Parameters.AddWithValue("@ne", no_eco_txt.Text)
            cmd3.Parameters.AddWithValue("@nl", no_luxu_txt.Text)
            cmd3.Parameters.AddWithValue("@amt", amt.ToString)
            cmd3.Parameters.AddWithValue("@cn", cust_name_txt.Text)
            cmd3.Parameters.AddWithValue("@cage", cust_age_txt.Text)
            cmd3.Parameters.AddWithValue("@caddr", cust_addr_txt.Text)
            cmd3.Parameters.AddWithValue("@csex", cust_sex_txt.Text)
            cmd3.Parameters.AddWithValue("@cph", cust_phone_txt.Text)
            cmd3.Parameters.AddWithValue("@fcode", flightname_cb.Text)
            cn.Close()
            cn.Open()
            cmd3.ExecuteNonQuery()
            MsgBox("Booked successfully...Your Reservation Code is " + id)
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Public Function idcalc() As String
        Try
            Dim cmd As New SqlCommand("select max(id)+1 as count from booking ;", cn)
            cn.Close()
            cn.Open()
            cmd.Parameters.Clear()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader
            If reader.HasRows.Equals(False) Then
                reader.Close()
                cn.Close()
                Return "0"
            End If
            Dim str As String
            While reader.Read

                If reader.Item("count").Equals("") Then
                    reader.Close()
                    cn.Close()
                    Return "0"
                End If
                str = reader.Item("count").ToString
            End While


            'Dim c As Int32 = Integer.Parse(ComboBox2.Text)
            ' c += 1
            ' ComboBox2.Text = c.ToString

            reader.Close()
            cn.Close()
            Return str
            ' flightname_txt.Text = ""
            'ComboBox1.Text = ""
            ' business_txt.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
    Private Sub flightname_cb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flightname_cb.SelectedIndexChanged

    End Sub

    Private Sub destnlocn_cb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles destnlocn_cb.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        emp_main.Show()

    End Sub
End Class