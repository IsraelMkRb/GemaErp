Public Class Producto
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property SKU As Long
    Public Property Precio As Decimal
End Class

Public Class ListaProductos
    Inherits List(Of Producto)
End Class