Public Class Productos
    Public Shared Function GetList() As DataTable
        Dim cmd As New SqlClient.SqlCommand

        cmd.CommandText = "Select [Id],[Nombre] from Productos order by [ID]"

        Return oData.Ejecutacmd(cmd, 1)
    End Function
End Class
