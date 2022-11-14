Module oData
    Private dbcontext As New SqlClient.SqlConnection With {.ConnectionString = My.Settings.ConnectionString}
    ''' <summary>
    ''' Ejecuta El comando Sql-Trans
    ''' </summary>
    ''' <param name="cmd">Objeto SqlCommand a ejecutar</param>
    ''' <param name="Type">tipo de instruccion: 1 = Select; 2 = Update; 3 = Delete</param>
    ''' <returns></returns>
    Public Function Ejecutacmd(ByRef cmd As SqlClient.SqlCommand, ByRef Type As Integer) As DataTable
        Try
            If dbcontext.State <> ConnectionState.Open Then
                dbcontext.Open()
            End If
            cmd.Connection = dbcontext
            Dim reader As SqlClient.SqlDataAdapter
            Select Case Type
                Case 1
                    reader = New SqlClient.SqlDataAdapter With {.SelectCommand = cmd}
                Case 2
                    reader = New SqlClient.SqlDataAdapter With {.UpdateCommand = cmd}
                Case 3
                    reader = New SqlClient.SqlDataAdapter With {.DeleteCommand = cmd}
                Case Else
                    Throw New Exception("Solo son valido valores dentro del rango 1-3")
            End Select
            Dim table As New DataTable

                    reader.Fill(table)
            dbcontext.Close()
            Return table
        Catch ex As Exception
            Throw
        End Try
    End Function
End Module
