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

Partial Public Class Empleados
    Public Property CUIT As String
    Public Property id_tipoEmpleado As Integer
    Public Property nombre As String
    Public Property apellido As String
    Public Property DNI As String
    Public Property direccion As String
    Public Property telefono As String
    Public Property pais As String
    Public Property provincia As String
    Public Property localidad As String
    Public Property email As String
    Public Property fechaIngreso As Date
    Public Property imagen As String

    Public Overridable Property TipoEmpleado As TipoEmpleado
    Public Overridable Property Usuarios As ICollection(Of Usuarios) = New HashSet(Of Usuarios)

End Class
