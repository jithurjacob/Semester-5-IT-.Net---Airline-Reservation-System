Imports System.Data.SqlClient
Public Class Tick_canc
    Dim cn As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True")

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cn.Close()
            cn.Open()
            Dim cmd As New SqlCommand("select * from booking where id=@id", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", TextBox1.Text)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            If reader.HasRows.Equals(False) Then
                MsgBox("No data found for this rservation id...")
                Return
            End If
            While reader.Read
                no_bus_txt.Text = reader.Item("no_business_seat").ToString
                no_eco_txt.Text = reader.Item("no_economy_seat").ToString
                no_luxu_txt.Text = reader.Item("no_luxury_seat").ToString
                serv_id_lbl.Text = reader.Item("service_id").ToString
                f_id_lbl.Text = reader.Item("f_code").ToString
                amt_lbl.Text = reader.Item("amount").ToString
            End While
            cn.Close()
            Panel1.Visible = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

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
        If Not valid.is_postive_number_only(TextBox2.Text) Then
            MsgBox("enter a positive number..")
            Return
        End If
        If Not valid.is_postive_number_only(TextBox3.Text) Then
            MsgBox("enter a positive number..")
            Return
        End If
        If Not valid.is_postive_number_only(TextBox4.Text) Then
            MsgBox("enter a positive number..")
            Return
        End If
        Try
            If TextBox2.Text.Equals("") Then
                TextBox2.Text = "0"
            End If
            If TextBox3.Text.Equals("") Then
                TextBox3.Text = "0"
            End If
            If TextBox4.Text.Equals("") Then
                TextBox4.Text = "0"
            End If
            If Val(TextBox2.Text) > Val(no_bus_txt.Text) Or Val(TextBox3.Text) > Val(no_eco_txt.Text) Or Val(TextBox4.Text) > Val(no_luxu_txt.Text) Then
                MsgBox("Number of seats to be cancelled is greater than reserved...")
                Return
            End If

            cn.Close()
            cn.Open()
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
            Dim flightid As String = f_id_lbl.Text
            ' MsgBox(flightid)
            Dim cmd As New SqlCommand("select * from flight_inf where f_code=@code ", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@code", flightid)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            If reader.HasRows.Equals(False) Then
                MsgBox("Error... Flight not found...")
                Return
            End If
            While reader.Read

                total_bus = reader.Item("no_business_seat")
                total_eco = reader.Item("no_economy_seat")
                total_luxu = reader.Item("no_luxury_seat")
                cost_bus = reader.Item("cost_business_seat")
                cost_eco = reader.Item("cost_economy_seat")
                cost_lux = reader.Item("cost_luxury_seat")
            End While
            Dim amt As Integer = 0
            Dim newamt As Integer = 0
            Dim canc_bus As Integer = 0
            Dim can_eco As Integer = 0
            Dim canc_luxu As Integer = 0
            canc_bus = Val(TextBox2.Text)
            can_eco = Val(TextBox3.Text)
            canc_luxu = Val(TextBox4.Text)
            amt = Val(amt_lbl.Text)
            newamt = amt - (can_eco * cost_eco + canc_bus * cost_bus + canc_luxu * cost_lux)
            MsgBox("The amount you would recieve back is " + (amt - newamt).ToString)


            cn.Close()
            cn.Open()
            Dim cmd3 As New SqlCommand("update booking set no_business_seat=@nb,no_economy_seat=@ne,no_luxury_seat=@nl,amount=@amt where id=@i", cn)
            cmd3.Parameters.Clear()
            cmd3.Parameters.AddWithValue("@i", TextBox1.Text)
            cmd3.Parameters.AddWithValue("@nb", Val(no_bus_txt.Text) - canc_bus)
            cmd3.Parameters.AddWithValue("@ne", Val(no_eco_txt.Text) - can_eco)
            cmd3.Parameters.AddWithValue("@nl", Val(no_luxu_txt.Text) - canc_bus)
            cmd3.Parameters.AddWithValue("@amt", newamt.ToString)
            cmd3.ExecuteNonQuery()
            MsgBox("Reservation changed succesfully..")
            Button1.PerformClick()
            TextBox2.Text = "0"
            TextBox3.Text = "0"
            TextBox4.Text = "0"
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        emp_main.Show()

    End Sub

    Private Sub Tick_canc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class