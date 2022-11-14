Public Class ProductosRegistrarFrm
    Private Sub ProductosRegistrarFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ItemsListGrid.DataSource = BusinessProcess.Productos.GetList()
        ListItemsView.BestFitColumns()
    End Sub
    Private Sub ListItemsView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles ListItemsView.FocusedRowChanged

    End Sub
End Class