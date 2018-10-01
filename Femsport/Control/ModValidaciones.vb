Imports System.Text.RegularExpressions

Module ModValidaciones

    Public Sub esDNI(ByRef txt As TextBox)
        Dim entrada As New Regex("^[0-9]*$", RegexOptions.IgnoreCase)
        If (txt.TextLength <> 8) Or (Not entrada.IsMatch(txt.Text)) Then
            txt.ForeColor = Color.Navy
            MsgBox("El campo D.N.I debe ser númerico y contener 8 caracteres", MsgBoxStyle.Critical, "Error")
            txt.Clear()
            txt.ForeColor = Color.Black
        End If
    End Sub

    Public Sub esCUIT(ByRef txt As TextBox)
        Dim entrada As New Regex("^[0-9]*$", RegexOptions.IgnoreCase)
        If (txt.TextLength <> 11) Or (Not entrada.IsMatch(txt.Text)) Then
            txt.ForeColor = Color.Navy
            MsgBox("El campo CUIT debe ser númerico y contener 11 caracteres", MsgBoxStyle.Critical, "Error")
            txt.Clear()
            txt.ForeColor = Color.Black
        End If
    End Sub

    Public Sub esCodigo(ByRef txt As TextBox)
        Dim entrada As New Regex("^[0-9]*$", RegexOptions.IgnoreCase)
        If (txt.TextLength < 6) Or (Not entrada.IsMatch(txt.Text)) Then
            txt.ForeColor = Color.Navy
            MsgBox("El campo Codigo debe ser númerico y contener como mínimo 6 caracteres", MsgBoxStyle.Critical, "Error")
            txt.Clear()
            txt.ForeColor = Color.Black
        End If
    End Sub

    Public Sub esTelefono(ByRef txt As TextBox)
        Dim entrada As New Regex("^[0-9]*$", RegexOptions.IgnoreCase)
        If (txt.TextLength > 10 Or txt.TextLength < 7) Or (Not entrada.IsMatch(txt.Text)) Then
            txt.ForeColor = Color.Navy
            MsgBox("El campo TELEFONO debe ser númerico y contener 10 caracteres", MsgBoxStyle.Critical, "Error")
            txt.Clear()
            txt.ForeColor = Color.Black
        End If
    End Sub
    Public Sub esPalabra(ByRef txt As TextBox)
        Dim entrada As New Regex("^[ a-zA-Záéíóú]*$", RegexOptions.IgnoreCase)
        If (Not entrada.IsMatch(txt.Text)) Then
            txt.ForeColor = Color.Navy
            MsgBox("El campo debe contener solo letras", MsgBoxStyle.Critical, "Error")
            txt.Clear()
            txt.ForeColor = Color.Black
        End If
    End Sub
    Public Sub esOracion(ByRef txt As TextBox)
        Dim entrada As New Regex("^[ a-zA-Záéíóú,.0-9-_]*$", RegexOptions.IgnoreCase)
        If (Not entrada.IsMatch(txt.Text)) Then
            txt.ForeColor = Color.Navy
            MsgBox("La oración no puede tener caracteres especiales tales como @ o *", MsgBoxStyle.Critical, "Error")
            txt.Clear()
            txt.ForeColor = Color.Black
        End If
    End Sub
    Public Sub esDireccion(ByRef txt As TextBox)
        Dim entrada As New Regex("^[ a-zA-Záéíóú0-9,.]*$", RegexOptions.IgnoreCase)
        If (Not entrada.IsMatch(txt.Text)) Then
            txt.ForeColor = Color.Navy
            MsgBox("El campo Direccion no puede contener caracteres especiales que no sean '.'", MsgBoxStyle.Critical, "Error")
            txt.Clear()
            txt.ForeColor = Color.Black
        End If
    End Sub

    Public Sub esFecha(ByRef txt As DateTimePicker)
        Dim entrada As Date
        entrada = txt.MinDate
        If (entrada = txt.Value) Then
            MsgBox("Seleccione FECHA DE NACIMIENTO, no es valida una fecha con año menor al 2000", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Public Sub esEmail(ByRef txt As TextBox)
        Dim texto As New Regex("^[0-9a-zA-Z-_@.]*$", RegexOptions.IgnoreCase)
        Dim arobase As New Regex("[@]", RegexOptions.IgnoreCase)
        Dim punto As New Regex("[.]", RegexOptions.IgnoreCase)
        If (Not arobase.IsMatch(txt.Text)) Or (Not punto.IsMatch(txt.Text)) Or (Not texto.IsMatch(txt.Text)) Then
            txt.ForeColor = Color.Navy
            MsgBox("El correo electronico ingresado no es uno valido.
                        Ejemplo: prueba@hotmail.com", MsgBoxStyle.Critical, "Error")
            txt.Clear()
            txt.ForeColor = Color.Black
        End If
    End Sub

    Public Function validar_decimal(ByRef txtNumero) As Boolean
        Try
            Dim d As Decimal = Convert.ToDecimal(txtNumero.Text)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub validar_ComboBox(ByRef txtCargo)
        If (txtCargo.SelectedIndex.Equals(-1)) Then
            txtCargo.ForeColor = Color.Navy
            MsgBox("Seleccione un cargo", MsgBoxStyle.Critical, "Error")
            txtCargo.ForeColor = Color.Black
        End If
    End Sub

    Public Function NotNull(ByRef txtcampo) As Boolean
        If IsDBNull(txtcampo.Text) Then
            Return True
        Else
            Return False
        End If
    End Function

End Module
