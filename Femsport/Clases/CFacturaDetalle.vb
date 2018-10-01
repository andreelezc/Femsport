Public Class CFacturaDetalle
    Private _idCabeceraFactura As Integer
    Private _codigo As String
    Private _cantidad As Integer
    Private _precio As Decimal

    Property CabeceraFactura As Integer
        Get
            Return _idCabeceraFactura
        End Get
        Set(ByVal value As Integer)
            value = _idCabeceraFactura
        End Set
    End Property

    Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            value = _codigo
        End Set
    End Property

    Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            value = _cantidad
        End Set
    End Property

    Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(ByVal value As Decimal)
            value = _precio
        End Set
    End Property
End Class
