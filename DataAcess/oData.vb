Module oData
    Private dbcontext As New SqlClient.SqlConnection With {.ConnectionString = My.Settings.ConnectionString}
    ''' <summary>
    ''' Ejecuta El comando Sql-Trans
    ''' </summary>
    ''' <param name="cmd">Objeto SqlCommand a ejecutar</param>
    ''' <returns>objeto IdataReader para su tratamiento</returns>
    Public Function Ejecutacmd(ByRef cmd As SqlClient.SqlCommand) As IDataReader
        Try
            If dbcontext.State <> ConnectionState.Open Then
                dbcontext.Open()
            End If
            cmd.Connection = dbcontext
            Dim transaction As SqlClient.SqlTransaction = dbcontext.BeginTransaction
            cmd.Transaction = transaction
            Return cmd.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As Exception

            Throw ex
        End Try
    End Function
End Module
