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

    Public Shared Function NewID() As Integer
        Dim listaArticulos As BusinessEntities.ListaProductos = DataAcess.ProductosDA.GetList

        Dim lastID As Integer = listaArticulos.Last.ID
        Return lastID + 1
    End Function

    Public Shared Sub Save(NuevoArticulo As BusinessEntities.Producto)
        DataAcess.ProductosDA.Save(NuevoArticulo)
    End Sub

    Public Shared Sub Delete(Articulo As BusinessEntities.Producto)
        DataAcess.ProductosDA.Delete(Articulo)
    End Sub
End Class
