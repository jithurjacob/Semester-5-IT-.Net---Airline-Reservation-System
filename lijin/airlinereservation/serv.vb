Imports System.Data.SqlClient

Public Class serv
    Dim con As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True")
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        admin_main.Visible = True
        Me.Visible = False
    End Sub

    Private Sub serv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AirlineDataSet4.flight_inf' table. You can move, or remove it, as needed.
        Me.Flight_infTableAdapter3.Fill(Me.AirlineDataSet4.flight_inf)
        'TODO: This line of code loads data into the 'ServiceDataSet2.serve' table. You can move, or remove it, as needed.
        Me.ServeTableAdapter.Fill(Me.ServiceDataSet2.serve)
        'TODO: This line of code loads data into the 'FlightDataSet2.flight_inf' table. You can move, or remove it, as needed.
        Me.Flight_infTableAdapter2.Fill(Me.FlightDataSet2.flight_inf)
        'TODO: This line of code loads data into the 'Flight.flight_inf' table. You can move, or remove it, as needed.
        'Me.Flight_infTableAdapter1.Fill(Me.Flight.flight_inf)
        'TODO: This line of code loads data into the 'Servi.flight_inf' table. You can move, or remove it, as needed.
        ' Me.Flight_infTableAdapter.Fill(Me.Servi.flight_inf)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try

            Dim cmd As New SqlCommand("select * from flight_inf,serve where f_code=f_id and id='" & ComboBox1.Text & "'", con)
            con.Close()
            con.Open()
            cmd.Parameters.Clear()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader
            While reader.Read
                fname_txt.Text = reader.Item("f_name").ToString
                source_txt.Text = reader.Item("source").ToString
                destination_txt.Text = reader.Item("desti").ToString
                dept_time.Value = reader.Item("dep_ti").ToString
                arriv_time.Value = reader.Item("arr_ti").ToString


            End While
            reader.Close()
            con.Close()

        Catch ex As Exception


            MessageBox.Show("error while updating record on table.." & ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim invalid_input As Boolean = False

        Dim valid As New validate
        Dim sou As String = source_txt.Text
        Dim des As String = destination_txt.Text
        If (valid.is_des(sou)) Then
            '   MsgBox("ok name accepted")
        Else
            MsgBox("arrival not char type")
            invalid_input = True
            Return
        End If

        If (valid.is_des(des)) Then
            '   MsgBox("ok name accepted")
        Else
            MsgBox("destination not char type")
            invalid_input = True
            Return
        End If
        If Not invalid_input Then
            If Not ConnectionState.Open Then
                con.Open()
            End If
            Try

                Dim cmd As New SqlCommand("update serve set f_id=@f_code,source=@source,desti=@desti,dep_ti=@dep_it,arr_ti=@arr_it where id=@id", con)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@id", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@f_name", fname_txt.Text)
                cmd.Parameters.AddWithValue("@f_code", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@source", source_txt.Text)
                cmd.Parameters.AddWithValue("@desti", destination_txt.Text)
                cmd.Parameters.AddWithValue("@dep_it", dept_time.Value.ToString)
                cmd.Parameters.AddWithValue("@arr_it", arriv_time.Value.ToString)
                con.Close()
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("successfully updated service.... ")



            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            con.Close()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted
        Try
            ' MsgBox(ComboBox2.Text.ToString)
            Dim cmd As New SqlCommand("select id from serve where f_id=@f;", con)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@f", ComboBox2.Text.ToString)
            ' MsgBox(st + ComboBox1.Text)
            con.Close()
            con.Open()
            Dim reader As SqlDataReader

            Dim dt = New DataTable()
            reader = cmd.ExecuteReader
            If reader.HasRows.Equals(False) Then
                MsgBox("There are no serices available for this flight...")
                Return
            End If
            dt.Load(reader)
            ''  DataGridView1.AutoGenerateColumns = True
            'DataGridView1.DataSource = dt
            ' DataGridView1.Refresh()
            ComboBox1.AutoCompleteMode = AutoCompleteMode.None
            ComboBox1.DisplayMember = "id"
            ComboBox1.DataSource = dt
            ComboBox1.Refresh()
            con.Close()
            ComboBox1.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class