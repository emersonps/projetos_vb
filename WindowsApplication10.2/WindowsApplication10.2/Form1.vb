Public Class Form1
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim ClientesForm As New Clientes
        ClientesForm.Show()
    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        Dim PedidosForm As New Pedidos
        PedidosForm.Show()
    End Sub
    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        Dim SobreDlg As New Sobre
        SobreDlg.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ItensDePedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItensDePedidoToolStripMenuItem.Click
        Dim ItemForm As New Itens
        ItemForm.Show()
    End Sub
End Class
