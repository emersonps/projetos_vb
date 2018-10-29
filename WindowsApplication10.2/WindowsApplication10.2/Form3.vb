Public Class Pedidos
    Private Sub PedidoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PedidoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PedidoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VendasDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VendasDataSet.Pedido' table. You can move, or remove it, as needed.
        Me.PedidoTableAdapter.Fill(Me.VendasDataSet.Pedido)

    End Sub
End Class