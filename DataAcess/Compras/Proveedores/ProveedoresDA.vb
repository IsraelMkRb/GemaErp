Public Class ProveedoresDA
    Shared Function GetList() As BusinessEntities.ListaProveedores
        Dim cmd As New SqlClient.SqlCommand("Select * from Proveedores")

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


End Class
