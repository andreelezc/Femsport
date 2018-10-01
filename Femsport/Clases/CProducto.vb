Public Class CProducto
    Private _cod As String
    Private _idMarca As Integer
    Private _idTipoProducto As Integer
    Private _prec As Decimal
    Private _stockDisponible As Integer
    Private _stockMin As Integer
    Private _descrip As String
    Private _talla As Char

    Property Codigo As String
        Get
            Return _cod
        End Get
        Set(ByVal value As String)
            value = _cod
        End Set
    End Property

    Property Marca As Integer
        Get
            Return _idMarca
        End Get
        Set(ByVal value As Integer)
            value = _idMarca
        End Set
    End Property

    Property TipoProducto As Integer
        Get
            Return _idTipoProducto
        End Get
        Set(ByVal value As Integer)
            value = _idTipoProducto
        End Set
    End Property

    Property Precio As Decimal
        Get
            Return _prec
        End Get
        Set(ByVal value As Decimal)
            value = _prec
        End Set
    End Property

    Property Stock As Integer
        Get
            Return _stockDisponible
        End Get
        Set(ByVal value As Integer)
            value = _stockDisponible
        End Set
    End Property

    Property StockMinimo As Integer
        Get
            Return _stockMin
        End Get
        Set(ByVal value As Integer)
            value = _stockMin
        End Set
    End Property

    Property Descripcion As String
        Get
            Return _descrip
        End Get
        Set(ByVal value As String)
            value = _descrip
        End Set
    End Property

    Property Talle As Char
        Get
            Return _talla
        End Get
        Set(value As Char)
            value = _talla
        End Set
    End Property
End Class
