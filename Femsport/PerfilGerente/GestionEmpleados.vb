Public Class GestionEmpleados
    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click

    End Sub

    Private Sub BAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles BAgregarEmpleado.Click
        AltaEmpleado.Show()
    End Sub

    Private Sub BEditarEmpleado_Click(sender As Object, e As EventArgs) Handles BEditarEmpleado.Click
        EditarInfoEmpleado.Show()
    End Sub
End Class