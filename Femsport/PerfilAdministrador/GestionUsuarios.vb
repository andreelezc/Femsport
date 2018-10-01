Public Class GestionUsuarios
    Private Sub BAgregarUsuario_Click(sender As Object, e As EventArgs) Handles BAgregarUsuario.Click
        AltaUsuario.Show()
    End Sub

    Private Sub BEditarUsuario_Click(sender As Object, e As EventArgs) Handles BEditarUsuario.Click
        EditarInfoUsuario.Show()
    End Sub
End Class