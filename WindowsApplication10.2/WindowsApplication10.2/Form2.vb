Public Class Clientes
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VendasDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VendasDataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.VendasDataSet.Cliente)

    End Sub

    Private Sub ClienteDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClienteDataGridView.CellContentClick

    End Sub
End Class