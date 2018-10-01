Public Class CFacturaCabecera
    Private _idCabeceraFactura As Integer
    Private _DNI As String
    Private _idUsuario As Integer
    Private _fechaVenta As Date
    Private _formaPago As String

    Property CabeceraFactura As Integer
        Get
            Return _idCabeceraFactura
        End Get
        Set(ByVal value As Integer)
            value = _idCabeceraFactura
        End Set
    End Property

    Property DNI As String
        Get
            Return _DNI
        End Get
        Set(ByVal value As String)
            value = _DNI
        End Set
    End Property

    Property Usuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As Integer)
            value = _idUsuario
        End Set
    End Property

    Property FechaVenta As Date
        Get
            Return _fechaVenta
        End Get
        Set(ByVal value As Date)
            value = _fechaVenta
        End Set
    End Property

    Property FormaPago As String
        Get
            Return _formaPago
        End Get
        Set(ByVal value As String)
            value = _formaPago
        End Set
    End Property
End Class
