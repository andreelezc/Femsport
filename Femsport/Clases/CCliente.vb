Public Class CCliente
    Private _DNI As String
    Private _nombre As String
    Private _apellido As String
    Private _fechaNacimiento As Date
    Private _email As String
    Private _pais As String
    Private _provincia As String
    Private _localidad As String
    Private _direccion As String
    Private _telefono As String

    Property DNI As String
        Get
            Return _DNI
        End Get
        Set(ByVal value As String)
            value = _DNI
        End Set
    End Property

    Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            value = _nombre
        End Set
    End Property

    Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            value = _apellido

        End Set
    End Property

    Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As Date)
            value = _fechaNacimiento
        End Set
    End Property

    Property Email As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            value = _email
        End Set
    End Property

    Property Pais As String
        Get
            Return _pais
        End Get
        Set(ByVal value As String)
            value = _pais
        End Set
    End Property

    Property Provincia As String
        Get
            Return _provincia
        End Get
        Set(ByVal value As String)
            value = _provincia
        End Set
    End Property

    Property Localidad As String
        Get
            Return _localidad
        End Get
        Set(ByVal value As String)
            value = _localidad
        End Set
    End Property

    Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            value = _direccion
        End Set
    End Property

    Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            value = _telefono
        End Set
    End Property
End Class

