Public Class ProveedoresBP
    Shared Function GetList() As BusinessEntities.ListaProveedores
        Return DataAcess.ProveedoresDA.GetList
    End Function

    Shared Function GetInfo(ID As Integer) As BusinessEntities.Proveedor
        Dim listaproveedores As BusinessEntities.ListaProveedores = DataAcess.ProveedoresDA.GetList
        Dim Result As New BusinessEntities.Proveedor

        For Each Proveedor As BusinessEntities.Proveedor In listaproveedores
            If Proveedor.ID = ID Then
                Result = Proveedor
            End If
        Next

        Return Result
    End Function
End Class
