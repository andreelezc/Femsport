Imports System.ComponentModel

Public Class EditarInfoAdministrador
    Private Sub TNombre_Validating(sender As Object, e As CancelEventArgs) Handles TNombre.Validating
        esPalabra(TNombre)
    End Sub

    Private Sub TApellido_Validating(sender As Object, e As CancelEventArgs) Handles TApellido.Validating
        esPalabra(TApellido)
    End Sub

    Private Sub TCUIT_Validating(sender As Object, e As CancelEventArgs) Handles TCUIT.Validating
        esCUIT(TCUIT)
    End Sub

    Private Sub TDNI_Validating(sender As Object, e As CancelEventArgs) Handles TDNI.Validating
        esDNI(TDNI)
    End Sub

    Private Sub DateFechaNac_Validating(sender As Object, e As CancelEventArgs) Handles DateFechaNac.Validating
        esFecha(DateFechaNac)
    End Sub

    Private Sub TEmail_Validating(sender As Object, e As CancelEventArgs) Handles TEmail.Validating
        esEmail(TEmail)
    End Sub

    Private Sub TPais_Validating(sender As Object, e As CancelEventArgs) Handles TPais.Validating
        esPalabra(TPais)
    End Sub

    Private Sub TProvincia_Validating(sender As Object, e As CancelEventArgs) Handles TProvincia.Validating
        esPalabra(TProvincia)
    End Sub

    Private Sub TLocalidad_Validating(sender As Object, e As CancelEventArgs) Handles TLocalidad.Validating
        esPalabra(TLocalidad)
    End Sub

    Private Sub TDireccion_Validating(sender As Object, e As CancelEventArgs) Handles TDireccion.Validating
        esDireccion(TDireccion)
    End Sub

    Private Sub TTelefono_Validating(sender As Object, e As CancelEventArgs) Handles TTelefono.Validating
        esTelefono(TTelefono)
    End Sub

    Private Sub DateFechaIngreso_Validating(sender As Object, e As CancelEventArgs) Handles DateFechaIngreso.Validating
        esFecha(DateFechaIngreso)
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If (TNombre.Text <> "") And (TApellido.Text <> "") And (TDNI.Text <> "") And (TCUIT.Text) <> "" And (TPais.Text) <> "" And (TProvincia.Text) <> "" And (TLocalidad.Text) <> "" And (DateFechaNac.Value < DateFechaIngreso.Value) Then
            MsgBox("Datos actualizados correctamente", MsgBoxStyle.Information, "Operación exitosa")
        End If
    End Sub

    Private Sub EditarInfoAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class