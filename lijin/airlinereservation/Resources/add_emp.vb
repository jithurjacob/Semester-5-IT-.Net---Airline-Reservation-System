
Imports System.Data.SqlClient

Public Class add_emp
    
    Dim con As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True")


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empname.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        admin_main.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim valid As New valid

        If empname.Text.Equals("") Or empaddr.Text.Equals("") Or empconfirm.Text.Equals("") Or emppass.Text.Equals("") Or empphoneno.Text.Equals("") Then
            MsgBox("Fill fields...")
            Return
        End If

        If Not valid.is_name(empname.Text) Then
            MsgBox("Enter proper name...")
            Return
        End If
        If Not valid.is_mobile_number(empphoneno.Text) Then
            MsgBox("Enter proper phone number...")
            Return
        End If
        
        If Not valid.contains_space(empuname.Text) Then
            MsgBox("Enter proper user name...")
            Return
        End If

        Dim name As String = empname.Text
        Dim addr As String = empaddr.Text
        Dim phno As String = empphoneno.Text
        Dim invalid_input As Boolean = False

       
        If Not invalid_input Then
            con.Close()
            con.Open()

            Try
                Dim cmd1 As New SqlCommand("select * from employee where username =@usr", con)
                Dim reader As SqlDataReader
                cmd1.Parameters.Clear()
                cmd1.Parameters.AddWithValue("@usr", empuname.Text)
                reader = cmd1.ExecuteReader
                If reader.HasRows.Equals(True) Then
                    MsgBox("username has already been taken...")
                    Return
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            con.Close()

            con.Open()
            If (emppass.Text = empconfirm.Text) Then

                Try
                   
                    Dim cmd As New SqlCommand("insert into employee values(@emp_name,@emp_usrname,@emp_pwd,@emp_addr,@emp_phone)", con)

                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@emp_name", empname.Text)
                    cmd.Parameters.AddWithValue("@emp_usrname", empuname.Text)
                    cmd.Parameters.AddWithValue("@emp_addr", empaddr.Text)
                    cmd.Parameters.AddWithValue("@emp_pwd", emppass.Text)
                    cmd.Parameters.AddWithValue("@emp_phone", empphoneno.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("successfully entered ")

                    empname.Text = ""
                    empuname.Text = ""
                    empaddr.Text = ""
                    emppass.Text = ""
                    empphoneno.Text = ""
                    empconfirm.Text = ""

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("confirm password")
            End If
        End If
        con.Close()
    End Sub

    Private Sub empconfirm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empconfirm.TextChanged

    End Sub

    Private Sub add_emp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       
        

       
    End Sub

   
    Private Sub empid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
