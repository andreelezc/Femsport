Public Class Facturacion
    Private Sub FormularioFact_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GestionClientes_V_.Show()
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub

    Private Sub BCargarProducto_Click(sender As Object, e As EventArgs) Handles BCargarProducto.Click
        ListaProductos.Show()
    End Sub

    Private Sub BConfirmar_Click(sender As Object, e As EventArgs) Handles BConfirmar.Click
        If (TNroFactura.Text) <> "" And (TTipoFactura.Text) And (LabelNombre.Text) <> "" And (LabelDNI.Text) <> "" And (LabelNyA.Text <> "") Then
            MsgBox("Venta registrada", MsgBoxStyle.Information, "Operación exitosa")
        End If
    End Sub
End Class
