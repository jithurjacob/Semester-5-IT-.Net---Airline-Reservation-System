Imports System.Data.SqlClient

Public Class addflight

    Dim con As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True")
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AirlineDataSet1.flight_inf' table. You can move, or remove it, as needed.
        ' Me.Flight_infTableAdapter1.Fill(Me.AirlineDataSet1.flight_inf)
        'TODO: This line of code loads data into the 'Flight.flight_inf' table. You can move, or remove it, as needed.
        'Me.Flight_infTableAdapter.Fill(Me.Flight.flight_inf)
        idcalc()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        admin_main.Visible = True
        Me.Dispose()
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim valid As New valid

    '    If flightname_txt.Text.Equals("") Or business_txt.Text.Equals("") Or economy_txt.Text.Equals("") Or luxury_txt.Text.Equals("") Or TextBox3.Text.Equals("") Or TextBox2.Text Or TextBox1.Text Then
    '        MsgBox("Fill fields...")
    '        Return
    '    End If

    '    If Not valid.is_name(flightname_txt.Text) Then
    '        MsgBox("Enter proper name...")
    '        Return
    '    End If
    '    If Not valid.number_only(business_txt.Text) Then
    '        MsgBox("Enter proper number...")
    '        Return
    '    End If
    '    If Not valid.number_only(economy_txt.Text) Then
    '        MsgBox("Enter proper number...")
    '        Return
    '    End If
    '    If Not valid.number_only(luxury_txt.Text) Then
    '        MsgBox("Enter proper number...")
    '        Return
    '    End If
    '    If Not valid.number_only(TextBox3.Text) Then
    '        MsgBox("Enter proper number...")
    '        Return
    '    End If
    '    If Not valid.number_only(TextBox2.Text) Then
    '        MsgBox("Enter proper number...")
    '        Return
    '    End If
    '    If Not valid.number_only(TextBox1.Text) Then
    '        MsgBox("Enter proper number...")
    '        Return
    '    End If

    '        con.Close()
    '        con.Open()


    '        Try

    '            Dim cmd As New SqlCommand("insert into flight_inf  values(@f_name,@f_code,@class_name,@no_seats)", con)

    '            cmd.Parameters.Clear()
    '            cmd.Parameters.AddWithValue("@f_name", flightname_txt.Text)
    '            ' cmd.Parameters.AddWithValue("@f_code", ComboBox2.Text)
    '            ' cmd.Parameters.AddWithValue("@class_name", ComboBox1.Text)
    '            cmd.Parameters.AddWithValue("@no_seats", business_txt.Text)

    '            cmd.ExecuteNonQuery()
    '            MsgBox("successfully entered ")




    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        End Try
    '        con.Close()
    '        flightname_txt.Text = ""
    '        '  ComboBox1.Text = ""
    '        business_txt.Text = ""


    'End Sub
    Public Sub idcalc()
        Try
            Dim cmd As New SqlCommand("select max(f_code)+1 as count from flight_inf ;", con)
            con.Close()
            con.Open()
            cmd.Parameters.Clear()
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader
            If reader.HasRows.Equals(False) Then
                code_txt.Text = "0"
            End If
            While reader.Read
                code_txt.Text = reader.Item("count").ToString
                If reader.Item("count").Equals("") Then
                    code_txt.Text = "0"
                End If
            End While


            'Dim c As Int32 = Integer.Parse(ComboBox2.Text)
            ' c += 1
            ' ComboBox2.Text = c.ToString

            reader.Close()
            con.Close()
            ' flightname_txt.Text = ""
            'ComboBox1.Text = ""
            ' business_txt.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
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
            Dim cmd As New SqlCommand("insert into flight_inf values(@f_name,@f_code,@nb, @ne,@nl,@cb,@ce,@cl);", con)
            con.Close()
            con.Open()
            cmd.Parameters.Clear()
            '  MsgBox(ComboBox2.SelectedText.ToString)
            cmd.Parameters.AddWithValue("@f_name", flightname_txt.Text)
            cmd.Parameters.AddWithValue("@f_code", code_txt.Text)
            cmd.Parameters.AddWithValue("@nb", business_txt.Text)
            cmd.Parameters.AddWithValue("@ne", economy_txt.Text)
            cmd.Parameters.AddWithValue("@nl", luxury_txt.Text)
            cmd.Parameters.AddWithValue("@cb", TextBox3.Text)
            cmd.Parameters.AddWithValue("@ce", TextBox2.Text)
            cmd.Parameters.AddWithValue("@cl", TextBox1.Text)
            cmd.ExecuteNonQuery()
            MsgBox("flight added....")
            business_txt.Text = ""
            economy_txt.Text = ""
            luxury_txt.Text = ""
            flightname_txt.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            idcalc()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MessageBox.Show("error while adding record to table..")
        End Try
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim valid As New valid

    '    If flightname_txt.Text.Equals("") Or business_txt.Text.Equals("") Or economy_txt.Text.Equals("") Or luxury_txt.Text.Equals("") Or TextBox3.Text.Equals("") Or TextBox2.Text Or TextBox1.Text Then
    '        MsgBox("Fill fields...")
    '        Return
    '    End If

    '    If Not valid.is_name(flightname_txt.Text) Then
    '        MsgBox("Enter proper name...")
    '        Return
    '    End If
    '    If Not valid.number_only(business_txt.Text) Then
    '        MsgBox("Enter proper number...")
    '        Return
    '    End If
    '    If Not valid.number_only(economy_txt.Text) Then
    '        MsgBox("Enter proper number...")
    '        Return
    '    End If
    '    If Not valid.number_only(luxury_txt.Text) Then
    '        MsgBox("Enter proper number...")
    '        Return
    '    End If
    '    If Not valid.number_only(TextBox3.Text) Then
    '        MsgBox("Enter proper number...")
    '        Return
    '    End If
    '    If Not valid.number_only(TextBox2.Text) Then
    '        MsgBox("Enter proper number...")
    '        Return
    '    End If
    '    If Not valid.number_only(TextBox1.Text) Then
    '        MsgBox("Enter proper number...")
    '        Return
    '    End If
    '    Try
    '        Dim cmd As New SqlCommand("insert into flight_inf values(@f_name,@f_code,@nb, @ne,@nl,@cb,@ce,@cl);", con)
    '        con.Close()
    '        con.Open()
    '        cmd.Parameters.Clear()
    '        '  MsgBox(ComboBox2.SelectedText.ToString)
    '        cmd.Parameters.AddWithValue("@f_name", flightname_txt.Text)
    '        cmd.Parameters.AddWithValue("@f_code", code_txt.Text)
    '        cmd.Parameters.AddWithValue("@nb", business_txt.Text)
    '        cmd.Parameters.AddWithValue("@ne", economy_txt.Text)
    '        cmd.Parameters.AddWithValue("@nl", luxury_txt.Text)
    '        cmd.Parameters.AddWithValue("@cb", TextBox3.Text)
    '        cmd.Parameters.AddWithValue("@ce", TextBox2.Text)
    '        cmd.Parameters.AddWithValue("@cl", TextBox1.Text)
    '        cmd.ExecuteNonQuery()
    '        MsgBox("flight added....")
    '        business_txt.Text = ""
    '        economy_txt.Text = ""
    '        luxury_txt.Text = ""
    '        flightname_txt.Text = ""
    '        idcalc()
    '        con.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '        MessageBox.Show("error while adding record to table..")
    '    End Try
    'End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flightname_txt.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub business_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles business_txt.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub economy_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles economy_txt.TextChanged

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub luxury_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luxury_txt.TextChanged

    End Sub

    Private Sub code_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles code_txt.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class