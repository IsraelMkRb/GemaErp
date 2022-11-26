Public Class ProveedoresBP
    Shared Function GetList() As BusinessEntities.ListaProveedores
        Return DataAcess.ProveedoresDA.GetList
    End Function

    Shared Function GetInfo(ID As Integer) As BusinessEntities.Proveedor
        Dim listaproveedores As BusinessEntities.ListaProveedores = DataAcess.ProveedoresDA.GetList
        Dim Result As New BusinessEntities.Proveedor With {.ID = ID}

        For Each Proveedor As BusinessEntities.Proveedor In listaproveedores
            If Proveedor.ID = ID Then
                Result = Proveedor
            End If
        Next

        Return Result
    End Function

    Shared Function NewID() As Integer
        Dim listaproveedores As BusinessEntities.ListaProveedores = DataAcess.ProveedoresDA.GetList

        Dim ultimoregistro As BusinessEntities.Proveedor = listaproveedores.Last
        Return ultimoregistro.ID + 1
    End Function

    Shared Sub Save(Proveedor As BusinessEntities.Proveedor)
        DataAcess.ProveedoresDA.Save(Proveedor)
    End Sub

    Shared Sub Delete(Proveedor As BusinessEntities.Proveedor)
        DataAcess.ProveedoresDA.Delete(Proveedor)
    End Sub
End Class
