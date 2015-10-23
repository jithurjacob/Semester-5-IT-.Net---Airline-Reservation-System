Public Class allservices

    Private Sub allservices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ServiceDataSet2.serve' table. You can move, or remove it, as needed.
        Me.ServeTableAdapter.Fill(Me.ServiceDataSet2.serve)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class