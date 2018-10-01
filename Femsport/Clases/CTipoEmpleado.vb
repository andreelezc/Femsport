Public Class CTipoEmpleado
    Private _idTipoEmpleado As Integer
    Private _descrip As String

    Property TipoEmpleado As Integer
        Get
            Return _idTipoEmpleado
        End Get
        Set(ByVal value As Integer)
            _idTipoEmpleado = value
        End Set
    End Property

    Property Descrip As String
        Get
            Return _descrip
        End Get
        Set(ByVal value As String)
            _descrip = value
        End Set
    End Property
End Class