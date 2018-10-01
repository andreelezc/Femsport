Public Class CMarca
    Private _idMarca As Integer
    Private descrip As String

    Property Marca As Integer
        Get
            Return _idMarca
        End Get
        Set(ByVal value As Integer)
            value = _idMarca
        End Set
    End Property

    Property Descripcion As String
        Get
            Return descrip
        End Get
        Set(ByVal value As String)
            value = descrip
        End Set
    End Property

    Public Sub CargarCBO(ByVal combo As ComboBox)
        Dim ctx As FemsportDataBaseEntities = New FemsportDataBaseEntities

        Dim listaMarcas = (From m In ctx.Marcas
                           Select m).ToList
        With combo
                .DataSource = listaMarcas
                .DisplayMember = "Descripcion"
                .ValueMember = "ID_Marca"
                .SelectedValue = -1
            End With
    End Sub
End Class
