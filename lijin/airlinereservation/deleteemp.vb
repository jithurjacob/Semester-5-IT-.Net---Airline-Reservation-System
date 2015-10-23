Imports System.Data.SqlClient
Public Class deleteemp

    Dim cn As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True")

    Private Sub deleteemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AirlineDataSet3.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.AirlineDataSet3.employee)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cn.Close()
            cn.Open()
            '   MsgBox(ComboBox1.Text.ToString)

            Dim cmd As New SqlCommand("delete from employee where username=@u", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@u", ComboBox1.Text.ToString)
            cmd.ExecuteNonQuery()
            Me.EmployeeTableAdapter.Fill(Me.AirlineDataSet3.employee)

            MsgBox("Employee deleted successfully...")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        admin_main.Show()
    End Sub
End Class