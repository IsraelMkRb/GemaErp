Public Class ProductoPorProveedorBP
    Shared Function GetList() As BusinessEntities.ListaProductosProveedores
        Return DataAcess.ProductoPorProveedorDA.GetList
    End Function
End Class
