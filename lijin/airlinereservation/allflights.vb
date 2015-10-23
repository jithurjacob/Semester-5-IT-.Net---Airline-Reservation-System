Public Class allflights

    Private Sub allflights_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FlightDataSet2.flight_inf' table. You can move, or remove it, as needed.
        Me.Flight_infTableAdapter.Fill(Me.FlightDataSet2.flight_inf)

    End Sub

    Private Sub FlightinfBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlightinfBindingSource.CurrentChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class