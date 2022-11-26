Public Class ProveedoresDA
    Shared Function GetList() As BusinessEntities.ListaProveedores
        Dim cmd As New SqlClient.SqlCommand("Select * from Proveedores order by ID")

        Dim result As IDataReader = Ejecutacmd(cmd)

        Dim listaproveedores As New BusinessEntities.ListaProveedores

        While result.Read
            listaproveedores.Add(New BusinessEntities.Proveedor With {
                .ID = result.GetInt32(0),
                .Nombre = result.GetString(1),
                .Direccion = result.GetString(2),
                .Telefono = result.GetInt64(3)
            })
        End While
        result.Close()
        Return listaproveedores
    End Function

    Shared Sub Save(Proveedor As BusinessEntities.Proveedor)
        Dim cmd As New SqlClient.SqlCommand("Proveedor_Guardar") With {.CommandType = CommandType.StoredProcedure}

        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Proveedor.ID
        cmd.Parameters.Add("@Nombre", SqlDbType.NText).Value = Proveedor.Nombre
        cmd.Parameters.Add("@Direccion", SqlDbType.NText).Value = Proveedor.Direccion
        cmd.Parameters.Add("@Telefono", SqlDbType.BigInt).Value = Proveedor.Telefono

        Ejecutacmd(cmd).Close()
    End Sub

    Shared Sub Delete(Proveedor As BusinessEntities.Proveedor)
        Dim cmd As New SqlClient.SqlCommand("delete from Proveedores where ID = @ID")

        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Proveedor.ID

        Ejecutacmd(cmd).Close()
    End Sub
End Class
