Public Class ProductosRegistrarFrm
    Private Sub ProductosRegistrarFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ItemsListGrid.DataSource = BusinessProcess.ProductosBP.GetList()
        ListaProductos.BestFitColumns()
    End Sub
    Private Sub ListItemsView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles ListaProductos.FocusedRowChanged
        Dim Articulo As BusinessEntities.Producto = BusinessProcess.ProductosBP.GetInfo(Convert.ToInt32(ListaProductos.GetFocusedRowCellValue("ID")))
        ID_TextArea.Text = Articulo.ID.ToString
        Nombre_TextArea.Text = Articulo.Nombre
        Precio_TextArea.Text = Articulo.Precio.ToString
        SKU_TextArea.Text = Articulo.SKU.ToString
    End Sub
End Class