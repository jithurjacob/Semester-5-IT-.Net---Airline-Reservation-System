Imports System.Data.SqlClient

Public Class start
    Dim con As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True")

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        Dim usrna As String = txtluser.Text()
        Dim pwd1 As String = txtlpass.Text
        If Not (usrna.Equals("") Or pwd1.Equals("")) Then
            If (usrna.Equals("admin")) Then
                Try
                    MsgBox("ok")
                    Dim cmd As New SqlCommand("SELECT ad_pwd FROM admin WHERE ad_name='admin'", con)
                    cmd.Connection = con
                    If con.State = ConnectionState.Closed Then con.Open()
                    Dim pwd As String = ""

                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@admin", usrna)
                    Dim reader As SqlDataReader
                    reader = cmd.ExecuteReader
                    While reader.Read

                        pwd = reader.Item("ad_pwd")
                    End While
                    If pwd.Equals(pwd1) Then
                        MessageBox.Show("Login Successful...")
                        Me.Hide()
                        admin_main.Show()
                    Else
                        MessageBox.Show("Login Failed..." + pwd + pwd1)
                    End If

                    reader.Close()
                    If con.State = ConnectionState.Open Then con.Close()
                Catch ex As Exception
                    MessageBox.Show("Error Occured..." & ex.Message)
                End Try
            Else
                Try
                    Dim cmd As New SqlCommand("SELECT * FROM employee where username=@u", con)
                    cmd.Parameters.AddWithValue("@u", txtluser.Text)
                    con.Open()

                    Dim reader As SqlDataReader

                    Dim name As String = ""
                    Dim pwd As String = ""
                    reader = cmd.ExecuteReader
                    While reader.Read
                        name = reader.Item("username")

                        pwd = reader.Item("password")
                    End While
                    If (name.Equals(txtluser.Text) And pwd.Equals(txtlpass.Text)) Then

                        MessageBox.Show("Login Successful...")
                        emp_main.Visible = True
                        Me.Hide()


                    Else

                        MessageBox.Show("Login Failed...")

                    End If
                    reader.Close()
                    If con.State = ConnectionState.Open Then con.Close()
                Catch ex As Exception
                    MessageBox.Show("Error Occured..." & ex.ToString)
                End Try
            End If
        Else
            MessageBox.Show("USERNAME AND PASSWORD CANNOT BE EMPTY...")
        End If


    End Sub

 

    Private Sub txtluser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtluser.TextChanged

    End Sub
End Class