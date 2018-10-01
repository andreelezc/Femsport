Public Class CEmpleados
    Private _cuit As String
    Private _idTipoEmpleado As Integer
    Private _nombre As String
    Private _apellido As String
    Private _dni As String
    Private _direccion As String
    Private _telefono As String
    Private _pais As String
    Private _provincia As String
    Private _localidad As String
    Private _email As String
    Private _fechaIngreso As Date
    Private _fechaNacimiento As Date
    Private _imagen As String

    Property Cuit As String
        Get
            Return _cuit
        End Get
        Set(ByVal value As String)
            _cuit = value
        End Set
    End Property

    Property IdTipoEmpleado As Integer
        Get
            Return _idTipoEmpleado
        End Get
        Set(ByVal value As Integer)
            _idTipoEmpleado = value
        End Set
    End Property

    Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    Property Dni As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

    Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Property Pais As String
        Get
            Return _pais
        End Get
        Set(ByVal value As String)
            _pais = value
        End Set
    End Property

    Property Provincia As String
        Get
            Return _provincia
        End Get
        Set(ByVal value As String)
            _provincia = value
        End Set
    End Property

    Property Localidad As String
        Get
            Return _localidad
        End Get
        Set(ByVal value As String)
            _localidad = value
        End Set
    End Property

    Property Email As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Property FechaIngreso As Date
        Get
            Return _fechaIngreso
        End Get
        Set(ByVal value As Date)
            _fechaIngreso = value
        End Set
    End Property

    Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Property Imagen As String
        Get
            Return _imagen
        End Get
        Set(ByVal value As String)
            _imagen = value
        End Set
    End Property

    Public Sub CargarCBO(ByVal combo As ComboBox)
        Dim ctx As FemsportDataBaseEntities = New FemsportDataBaseEntities

        Dim listaCargos = (From c In ctx.TipoEmpleado
                           Select c).ToList
        With combo
            .DataSource = listaCargos
            .DisplayMember = "Descripcion"
            .ValueMember = "id_tipoEmpleado"
            .SelectedValue = -1
        End With
    End Sub
End Class
