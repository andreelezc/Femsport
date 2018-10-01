Imports System.ComponentModel

Public Class AltaProducto
    Dim objMarca As CMarca = New CMarca

    Private Sub TNombre_Validating(sender As Object, e As CancelEventArgs) Handles TNombre.Validating
        esPalabra(TNombre)
    End Sub

    Private Sub TCodigo_Validating(sender As Object, e As CancelEventArgs) Handles TCodigo.Validating
        esCodigo(TCodigo)
    End Sub

    Private Sub TTipoArticulo_Validating(sender As Object, e As CancelEventArgs) Handles TTipoArticulo.Validating
        esPalabra(TTipoArticulo)
    End Sub

    Private Sub ComboBoxMarca_Validating(sender As Object, e As CancelEventArgs) Handles ComboBoxMarca.Validating
        validar_ComboBox(ComboBoxMarca)
    End Sub

    Private Sub TModelo_Validating(sender As Object, e As CancelEventArgs) Handles TModelo.Validating
        esPalabra(TModelo)
    End Sub

    Private Sub TColor_Validating(sender As Object, e As CancelEventArgs) Handles TColor.Validating
        esPalabra(TModelo)
    End Sub

    Private Sub TPrecio_Validating(sender As Object, e As CancelEventArgs) Handles TPrecio.Validating
        validar_decimal(TPrecio)
    End Sub

    Private Sub DateFechaAltaProd_Validating(sender As Object, e As CancelEventArgs) Handles DateFechaAltaProd.Validating
        esFecha(DateFechaAltaProd)
    End Sub

    Private Sub BConfirmar_Click(sender As Object, e As EventArgs) Handles BConfirmar.Click
        If (TNombre.Text) <> ""(TCodigo.Text) <> "" And (TCodigo.Text) <> "" And (ComboBoxMarca.SelectedValue) <> -1 And (TModelo.Text) <> "" And (TTalle.Text) <> "" And (TColor.Text) <> "" And (TPrecio.Text) <> "" And (DateFechaAltaProd.Value) <> "" And (TStock.Text) <> "" And (TStockMin.Text) <> "" And (TStock.Text > TStockMin.Text) Then
            MsgBox("Producto agregado correctamente", MsgBoxStyle.Information, "Operación exitosa")
        End If
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub

    Sub CargarCBO()
        objMarca.CargarCBO(ComboBoxMarca)
    End Sub

    Private Sub AltaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objMarca.CargarCBO(ComboBoxMarca)
    End Sub
End Class