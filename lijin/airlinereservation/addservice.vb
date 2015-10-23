Imports System.Data.SqlClient

Public Class addservice
    Dim con As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True")
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        admin_main.Visible = True
        Me.Dispose()
        ' MsgBox(dept_time.Value.ToString)
    End Sub

    Private Sub serv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FlightDataSet2.flight_inf' table. You can move, or remove it, as needed.
        Me.Flight_infTableAdapter2.Fill(Me.FlightDataSet2.flight_inf)
        'TODO: This line of code loads data into the 'Flight.flight_inf' table. You can move, or remove it, as needed.
        'Me.Flight_infTableAdapter1.Fill(Me.Flight.flight_inf)
        'TODO: This line of code loads data into the 'Servi.flight_inf' table. You can move, or remove it, as needed.
        ' Me.Flight_infTableAdapter.Fill(Me.Servi.flight_inf)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try

            Dim cmd As New SqlCommand("select * from flight_inf where f_code= '" & ComboBox1.Text & "'", con)
            con.Open()
            cmd.Parameters.Clear()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader
            While reader.Read
                fname_txt.Text = reader.Item("f_name").ToString
                'source_txt.Text = reader.Item("source").ToString
                'destination_txt.Text = reader.Item("desti").ToString



            End While
            reader.Close()
            con.Close()

        Catch ex As Exception


            MessageBox.Show("error while fetching record from table.." & ex.ToString)
        End Try
    End Sub
    Public Function idcalc() As String
        Try
            Dim cmd As New SqlCommand("select max(id)+1 as count from serve ;", con)
            con.Close()
            con.Open()
            cmd.Parameters.Clear()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader
            If reader.HasRows.Equals(False) Then
                reader.Close()
                con.Close()
                Return "0"
            End If
            Dim str As String
            While reader.Read

                If reader.Item("count").Equals("") Then
                    reader.Close()
                    con.Close()
                    Return "0"
                End If
                str = reader.Item("count").ToString
            End While


            'Dim c As Int32 = Integer.Parse(ComboBox2.Text)
            ' c += 1
            ' ComboBox2.Text = c.ToString

            reader.Close()
            con.Close()
            Return str
            ' flightname_txt.Text = ""
            'ComboBox1.Text = ""
            ' business_txt.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim valid As New valid

        If ComboBox1.Text.Equals("") Or source_txt.Text.Equals("") Or destination_txt.Text.Equals("") Or dept_time.Text.Equals("") Or arriv_time.Text.Equals("") Then
            MsgBox("Fill fields...")
            Return
        End If

        If Not valid.is_alphabet_only (source_txt.Text) Then
            MsgBox("Enter proper name...")
            Return
        End If
        If Not valid.is_alphabet_only(destination_txt.Text) Then
            MsgBox("Enter proper name...")
            Return
        End If

       
            Try

                Dim cmd As New SqlCommand("insert into serve  values(@id,@f_code,@source,@desti,@dep_it,@arr_it)", con)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@id", idcalc)
                cmd.Parameters.AddWithValue("@f_name", fname_txt.Text)
                cmd.Parameters.AddWithValue("@f_code", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@source", source_txt.Text)
                cmd.Parameters.AddWithValue("@desti", destination_txt.Text)
                cmd.Parameters.AddWithValue("@dep_it", dept_time.Value.ToString)
                cmd.Parameters.AddWithValue("@arr_it", arriv_time.Value.ToString)
                con.Close()
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("successfully added service.... ")




            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            con.Close()

    End Sub
End Class