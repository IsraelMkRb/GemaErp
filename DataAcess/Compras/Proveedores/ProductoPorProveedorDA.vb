Public Class ProductoPorProveedorDA
    Shared Function GetList() As BusinessEntities.ListaProductosProveedores
        Dim cmd As New SqlClient.SqlCommand("select * from vw_ProductosPorProveedor")

        Dim result As IDataReader = Ejecutacmd(cmd)
        Dim listaProductoPorProveedor As New BusinessEntities.ListaProductosProveedores

        While result.Read
            Dim RelacionProductoProveedor As New BusinessEntities.RelacionProductoProveedor With {
                                        .IDProveedor = result.GetInt32(0),
                                        .NombreProveedor = result.GetString(1),
                                        .IDproducto = result.GetInt32(2),
                                        .NombreProducto = result.GetString(3)
            }

            listaProductoPorProveedor.Add(RelacionProductoProveedor)
        End While

        Return listaProductoPorProveedor
    End Function
End Class
