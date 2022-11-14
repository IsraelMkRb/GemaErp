Public Class Productos
    Public Shared Function GetList() As DataTable
        Return DataAcess.Productos.GetList
    End Function
End Class
