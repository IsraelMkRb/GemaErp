Public Class ProductosDA
    Public Shared Function GetList() As BusinessEntities.ListaProductos
        Dim cmd As New SqlClient.SqlCommand With {
            .CommandText = "Select * from Productos order by [ID]"
        }

        Dim listaProductos As New BusinessEntities.ListaProductos
        Dim Result As IDataReader = oData.Ejecutacmd(cmd)

        While Result.Read
            listaProductos.Add(New BusinessEntities.Producto With {
                               .ID = Result.GetInt32(0),
                               .Nombre = Result.GetString(1),
                               .Precio = Result.GetDecimal(3),
                               .SKU = Result.GetInt64(2)})
        End While
        Result.Close()
        Return listaProductos
    End Function
End Class
