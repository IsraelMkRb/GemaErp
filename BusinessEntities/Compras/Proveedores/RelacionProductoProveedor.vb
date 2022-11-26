Public Class RelacionProductoProveedor
    Public Property IDProveedor As Integer
    Public Property NombreProveedor As String
    Public IDproducto As Integer
    Public Property NombreProducto As String
End Class

Public Class ListaProductosProveedores
    Inherits List(Of RelacionProductoProveedor)
End Class
