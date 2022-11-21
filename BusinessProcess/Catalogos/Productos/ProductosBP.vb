Public Class ProductosBP
    Public Shared Function GetList() As BusinessEntities.ListaProductos
        Return DataAcess.ProductosDA.GetList
    End Function

    Public Shared Function GetInfo(ID As Integer) As BusinessEntities.Producto
        Dim listaProductos As BusinessEntities.ListaProductos = DataAcess.ProductosDA.GetList
        Dim result As BusinessEntities.Producto = Nothing
        For Each item As BusinessEntities.Producto In listaProductos
            If item.ID = ID Then
                result = item
            End If
        Next
        Return result
    End Function
End Class
