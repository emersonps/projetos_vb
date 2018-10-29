Public Class Itens
    Private Sub ItemPedidoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ItemPedidoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ItemPedidoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VendasDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VendasDataSet.ItemPedido' table. You can move, or remove it, as needed.
        Me.ItemPedidoTableAdapter.Fill(Me.VendasDataSet.ItemPedido)

    End Sub
End Class