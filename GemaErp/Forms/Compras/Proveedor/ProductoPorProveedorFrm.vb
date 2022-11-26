Public Class ProductoPorProveedorFrm
    Private Sub ProductoPorProveedorFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProveedoresLke.Properties.DataSource = BusinessProcess.ProveedoresBP.GetList
        ProveedoresLke.EditValue = ""
        ProveedoresLke.Properties.DisplayMember = "Nombre"
        ProveedoresLke.Properties.ValueMember = "ID"

        ProductoLke.Properties.DataSource = BusinessProcess.ProductosBP.GetList
        ProductoLke.EditValue = ""
        ProductoLke.Properties.DisplayMember = "Nombre"
        ProductoLke.Properties.ValueMember = "ID"

        ListaProductosGrd.DataSource = BusinessProcess.ProductoPorProveedorBP.GetList

    End Sub


End Class