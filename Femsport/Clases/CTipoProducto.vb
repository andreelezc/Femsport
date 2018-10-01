Public Class CTipoProducto
    Private _idTipoProducto As Integer
    Private _descrip As String

    Property TipoProducto As Integer
        Get
            Return _idTipoProducto
        End Get
        Set(ByVal value As Integer)
            value = _idTipoProducto
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
End Class
