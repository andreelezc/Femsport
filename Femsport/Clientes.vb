'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Clientes
    Public Property DNI As String
    Public Property nombre As String
    Public Property apellido As String
    Public Property fechaNacimiento As Date
    Public Property email As String
    Public Property pais As String
    Public Property provincia As String
    Public Property localidad As String
    Public Property direccion As String
    Public Property telefono As String

    Public Overridable Property FacturaCabecera As ICollection(Of FacturaCabecera) = New HashSet(Of FacturaCabecera)

End Class