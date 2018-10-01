Public Class GestionClientes_G_
    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click

    End Sub
    Private Sub BAgregarCliente_Click(sender As Object, e As EventArgs) Handles BAgregarCliente.Click
        AltaCliente_G_.Show()
    End Sub

    Private Sub BEditarCliente_Click(sender As Object, e As EventArgs) Handles BEditarCliente.Click
        EditarInfoCliente_G_.Show()
    End Sub
End Class