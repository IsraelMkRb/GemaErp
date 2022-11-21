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

    Public Shared Sub Save(NuevoArticulo As BusinessEntities.Producto)
        Dim cmd As New SqlClient.SqlCommand With {
            .CommandText = "Productos_Guardar",
            .CommandType = CommandType.StoredProcedure
        }

        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = NuevoArticulo.ID
        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = NuevoArticulo.Nombre
        cmd.Parameters.Add("@SKU", SqlDbType.BigInt).Value = NuevoArticulo.SKU
        cmd.Parameters.Add("@Precio", SqlDbType.Money).Value = NuevoArticulo.Precio

        oData.Ejecutacmd(cmd).Close()

    End Sub

    Public Shared Sub Delete(Articulo As BusinessEntities.Producto)
        Dim cmd As New SqlClient.SqlCommand("Delete from Productos where ID = @ID")

        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Articulo.ID

        Ejecutacmd(cmd).Close()
    End Sub


End Class
