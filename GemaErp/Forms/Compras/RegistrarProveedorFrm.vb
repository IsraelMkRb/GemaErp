Public Class RegistrarProveedorFrm
    Private Sub RegistrarProveedorFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaProveedoresGrd.DataSource = BusinessProcess.ProveedoresBP.GetList
        ListaProveedoresGrv.BestFitColumns()
    End Sub

    Private Sub ListaProveedoresGrv_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles ListaProveedoresGrv.FocusedRowChanged
        Dim ProveedorSelected As BusinessEntities.Proveedor = BusinessProcess.ProveedoresBP.GetInfo(Convert.ToInt32(ListaProveedoresGrv.GetFocusedRowCellValue("ID")))
        ID_TextArea.Text = ProveedorSelected.ID.ToString
        Nombre_TextArea.Text = ProveedorSelected.Nombre
        Direccion_TextArea.Text = ProveedorSelected.Direccion
        Telefono_TextArea.Text = ProveedorSelected.Telefono.ToString
    End Sub
End Class