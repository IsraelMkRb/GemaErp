Public Class Proveedor
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Direccion As String
    Public Property Telefono As Long
End Class

Public Class ListaProveedores
    Inherits List(Of Proveedor)
End Class
