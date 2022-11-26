Public Class RegistrarProveedorFrm
    Private Sub RegistrarProveedorFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizaLista()
    End Sub

    Private Sub ListaProveedoresGrv_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles ListaProveedoresGrv.FocusedRowChanged
        ActualizaFormulario()
    End Sub

    Private Sub CancelarBtn_Click(sender As Object, e As EventArgs) Handles CancelarBtn.Click
        ActualizaFormulario()
    End Sub

    Private Sub ActualizaFormulario(Optional ProveedorObj As BusinessEntities.Proveedor = Nothing)
        Dim ProveedorSelected As BusinessEntities.Proveedor
        If ProveedorObj Is Nothing Then
            ProveedorSelected = BusinessProcess.ProveedoresBP.GetInfo(Convert.ToInt32(ListaProveedoresGrv.GetFocusedRowCellValue("ID")))
        Else
            ProveedorSelected = BusinessProcess.ProveedoresBP.GetInfo(ProveedorObj.ID)
        End If
        ID_TextArea.Text = ProveedorSelected.ID.ToString
        Nombre_TextArea.Text = ProveedorSelected.Nombre
        Direccion_TextArea.Text = ProveedorSelected.Direccion
        Telefono_TextArea.Text = ProveedorSelected.Telefono.ToString
    End Sub

    Private Sub NuevoBtn_Click(sender As Object, e As EventArgs) Handles NuevoBtn.Click
        ActualizaFormulario(New BusinessEntities.Proveedor With {.ID = BusinessProcess.ProveedoresBP.NewID})
    End Sub

    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        Utileria.ShowWait(Me)
        Dim NuevoProveedor As New BusinessEntities.Proveedor With {
                                            .ID = Convert.ToInt32(ID_TextArea.Text),
                                            .Nombre = Nombre_TextArea.Text,
                                            .Direccion = Direccion_TextArea.Text,
                                            .Telefono = Convert.ToInt64(Telefono_TextArea.Text)
        }
        BusinessProcess.ProveedoresBP.Save(NuevoProveedor)
        actualizaLista()
        ActualizaFormulario(NuevoProveedor)
        Utileria.HideWait()
    End Sub

    Private Sub actualizaLista()
        ListaProveedoresGrd.DataSource = BusinessProcess.ProveedoresBP.GetList
        ListaProveedoresGrv.BestFitColumns()
    End Sub

    Private Sub BorrarBtn_Click(sender As Object, e As EventArgs) Handles BorrarBtn.Click
        If MsgBox("¿Esta seguro de borrar este registro? Esta accion no puede ser revertida", MsgBoxStyle.YesNo, "Cuidado") = MsgBoxResult.Yes Then
            Utileria.ShowWait(Me)
            BusinessProcess.ProveedoresBP.Delete(New BusinessEntities.Proveedor With {.ID = Convert.ToInt32(ID_TextArea.Text)})
            actualizaLista()
            ActualizaFormulario()
            Utileria.HideWait()
        End If
    End Sub
End Class