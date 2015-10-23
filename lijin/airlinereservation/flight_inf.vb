Imports System.Data.SqlClient

Public Class flight_inf

    Dim con As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True")
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AirlineDataSet2.flight_inf' table. You can move, or remove it, as needed.
        Me.Flight_infTableAdapter2.Fill(Me.AirlineDataSet2.flight_inf)
        'TODO: This line of code loads data into the 'AirlineDataSet1.flight_inf' table. You can move, or remove it, as needed.
        ' Me.Flight_infTableAdapter1.Fill(Me.AirlineDataSet1.flight_inf)
        'TODO: This line of code loads data into the 'Flight.flight_inf' table. You can move, or remove it, as needed.
        'Me.Flight_infTableAdapter.Fill(Me.Flight.flight_inf)
        'Dim cmd As New SqlCommand("select * from flight_inf ;", con)
        'con.Open()
        'cmd.Parameters.Clear()
        'Dim reader As SqlDataReader
        'reader = cmd.ExecuteReader

        'While reader.Read
        '    ComboBox2.Text = reader.Item("f_code")

        'End While


        ''Dim c As Int32 = Integer.Parse(ComboBox2.Text)
        '' c += 1
        '' ComboBox2.Text = c.ToString

        'reader.Close()
        'con.Close()
        ' flightname_txt.Text = ""
        'ComboBox1.Text = ""
        ' business_txt.Text = ""

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        admin_main.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim invalid_input As Boolean = False
        Dim name As String = flightname_txt.Text
        Dim no As String = business_txt.Text

        Dim valid As New validate
        If (valid.is_name(name)) Then
            '   MsgBox("ok name accepted")
        Else
            MsgBox("not flight name")
            invalid_input = True
            Return
        End If

        If (valid.is__number(no)) Then
            ' MsgBox("ok mobile no accepted")
        Else
            MsgBox("not an no")
            invalid_input = True
            Return
        End If
        If Not invalid_input Then
            If Not ConnectionState.Open Then
                con.Open()
            End If



            Try

                Dim cmd As New SqlCommand("insert into flight_inf  values(@f_name,@f_code,@class_name,@no_seats)", con)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@f_name", flightname_txt.Text)
                cmd.Parameters.AddWithValue("@f_code", ComboBox2.Text)
                ' cmd.Parameters.AddWithValue("@class_name", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@no_seats", business_txt.Text)

                cmd.ExecuteNonQuery()
                MsgBox("successfully entered ")




            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            con.Close()
            flightname_txt.Text = ""
            '  ComboBox1.Text = ""
            business_txt.Text = ""

        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged, ComboBox2.DropDownClosed
        '   MsgBox(ComboBox2.SelectedValue.ToString)
        Try
            Dim cmd As New SqlCommand("select * from flight_inf where f_code= '" & ComboBox2.SelectedValue.ToString & "'", con)

            con.Open()
            cmd.Parameters.Clear()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader
            While reader.Read
                flightname_txt.Text = reader.Item("f_name")
                'ComboBox2.Text = reader.Item("f_code")
                business_txt.Text = reader.Item("no_business_seat")
                economy_txt.Text = reader.Item("no_economy_seat")
                luxury_txt.Text = reader.Item("no_luxury_seat")

                TextBox3.Text = reader.Item("cost_business_seat")
                TextBox2.Text = reader.Item("cost_economy_seat")
                TextBox1.Text = reader.Item("cost_luxury_seat")
            End While
            con.Close()

        Catch ex As Exception


            MessageBox.Show("error retrieving data .." & ex.ToString)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim valid As New valid

        If flightname_txt.Text.Equals("") Or business_txt.Text.Equals("") Or economy_txt.Text.Equals("") Or luxury_txt.Text.Equals("") Or TextBox3.Text.Equals("") Or TextBox2.Text.Equals("") Or TextBox1.Text.Equals("") Then
            MsgBox("Fill fields...")
            Return
        End If

        If Not valid.is_name(flightname_txt.Text) Then
            MsgBox("Enter proper name...")
            Return
        End If
        If Not valid.number_only(business_txt.Text) Then
            MsgBox("Enter proper number...")
            Return
        End If
        If Not valid.number_only(economy_txt.Text) Then
            MsgBox("Enter proper number...")
            Return
        End If
        If Not valid.number_only(luxury_txt.Text) Then
            MsgBox("Enter proper number...")
            Return
        End If
        If Not valid.number_only(TextBox3.Text) Then
            MsgBox("Enter proper number...")
            Return
        End If
        If Not valid.number_only(TextBox2.Text) Then
            MsgBox("Enter proper number...")
            Return
        End If
        If Not valid.number_only(TextBox1.Text) Then
            MsgBox("Enter proper number...")
            Return
        End If
        Try
            Dim cmd As New SqlCommand("update flight_inf SET f_name = @f_name,f_code = @f_code,no_business_seat = @nb,no_economy_seat = @ne,no_luxury_seat=@nl,cost_business_seat = @cb,cost_economy_seat = @ce,cost_luxury_seat=@cl where f_code = @f_code", con)
            con.Open()
            cmd.Parameters.Clear()
            '  MsgBox(ComboBox2.SelectedText.ToString)
            cmd.Parameters.AddWithValue("@f_name", flightname_txt.Text)
            cmd.Parameters.AddWithValue("@f_code", ComboBox2.Text)
            cmd.Parameters.AddWithValue("@nb", business_txt.Text)
            cmd.Parameters.AddWithValue("@ne", economy_txt.Text)
            cmd.Parameters.AddWithValue("@nl", luxury_txt.Text)
            cmd.Parameters.AddWithValue("@cb", TextBox3.Text)
            cmd.Parameters.AddWithValue("@ce", TextBox2.Text)
            cmd.Parameters.AddWithValue("@cl", TextBox1.Text)
            cmd.ExecuteNonQuery()
            MsgBox("updated")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MessageBox.Show("error while updating record on table..")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flightname_txt.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class