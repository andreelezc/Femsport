Public Class CUsuario
    Private _idUsuario As Integer
    Private _CUIT As String
    Private _usuario As String
    Private _contraseña As String

    Property Usuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As Integer)
            value = _idUsuario
        End Set
    End Property

    Property CUIT As String
        Get
            Return _CUIT
        End Get
        Set(ByVal value As String)
            value = _CUIT
        End Set
    End Property

    Property NombreUsuario As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            value = _usuario
        End Set
    End Property

    Property Contraseña As String
        Get
            Return _contraseña
        End Get
        Set(ByVal value As String)
            value = _contraseña
        End Set
    End Property

    Public Sub CargarCBO(ByVal combo As ComboBox)
        Dim ctx As FemsportDataBaseEntities = New FemsportDataBaseEntities

        Dim listaCargos = (From c In ctx.TipoEmpleado
                           Select c).ToList
        With combo
            .DataSource = listacargos
            .DisplayMember = "Descripcion"
            .ValueMember = "id_tipoEmpleado"
            .SelectedValue = -1
        End With
    End Sub
End Class
