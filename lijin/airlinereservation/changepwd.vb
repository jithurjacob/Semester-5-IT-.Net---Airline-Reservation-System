Imports System.Data.SqlClient
Public Class changepwd
    Dim cn As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True")

    Private Sub Label5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try

            If pwd_txt.Text.Equals("") Or npwd_txt.Text.Equals("") Or repwd_txt.Text.Equals("") Then
                MsgBox("Fill all fields...")
                Return
            End If

            Dim cmd As New SqlCommand("select password from employee where username=@em;", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@em", start.txtluser.Text)
            Dim reader As SqlDataReader
            cn.Close()
            cn.Open()

            reader = cmd.ExecuteReader
            Dim pwd As String = ""
            If reader.HasRows.Equals(False) Then
                MsgBox("Error...")
                Return
            End If
            While reader.Read
                pwd = reader.Item("password").ToString

            End While
            If pwd.Equals(pwd_txt.Text).Equals(False) Then
                MsgBox("Incorrect password...")
                Return
            End If
            reader.Close()
            cn.Close()
            If npwd_txt.Text.Equals(repwd_txt.Text).Equals(False) Then
                MsgBox("New Password and and retyped passwords donot match..")
                Return
            End If
            Dim cmd1 As New SqlCommand("update employee set password=@p where username=@em;", cn)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@em", start.txtluser.Text)
            cmd1.Parameters.AddWithValue("@p", npwd_txt.Text)
            cn.Open()
            cmd1.ExecuteNonQuery()
            cn.Close()
            MsgBox("Password changed successfully...")
            pwd_txt.Text = ""
            repwd_txt.Text = ""
            npwd_txt.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        emp_main.Show()
    End Sub

    Private Sub changepwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class