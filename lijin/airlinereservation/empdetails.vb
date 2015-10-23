Public Class empdetails

    Private Sub empdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AirlineDataSet5.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.AirlineDataSet5.employee)

    End Sub
End Class