Public Class ProductosRegistrarFrm
#Region "Eventos"
    Private Sub ProductosRegistrarFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaLista()
    End Sub
    Private Sub ListItemsView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles ListaProductos.FocusedRowChanged
        ActualizaFormulario()
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        Dim Nuevo_ID As Integer = BusinessProcess.ProductosBP.NewID

        ID_TextArea.Text = Nuevo_ID.ToString
        Nombre_TextArea.Text = ""
        Precio_TextArea.Text = ""
        SKU_TextArea.Text = ""
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        ActualizaFormulario()
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Utileria.ShowWait(Me)
        BusinessProcess.ProductosBP.Save(New BusinessEntities.Producto With {
                                         .ID = Convert.ToInt32(ID_TextArea.Text),
                                         .Nombre = Nombre_TextArea.Text,
                                         .Precio = Convert.ToDecimal(Precio_TextArea.Text),
                                         .SKU = Convert.ToInt64(SKU_TextArea.Text)
        })
        CargaLista()
        ActualizaFormulario(Integer.Parse(ID_TextArea.Text))
        Utileria.HideWait()
    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If MsgBox("¿Esta seguro que desea borrar permanentemente este articulo?", MsgBoxStyle.YesNo, "Cuidado") = MsgBoxResult.Yes Then
            Utileria.ShowWait(Me)
            BusinessProcess.ProductosBP.Delete(New BusinessEntities.Producto With {.ID = Integer.Parse(ID_TextArea.Text)})
            CargaLista()
            ActualizaFormulario()
            Utileria.HideWait()
        End If
    End Sub
#End Region
#Region "Funciones"

    Private Sub CargaLista()
        ItemsListGrid.DataSource = BusinessProcess.ProductosBP.GetList()
        ListaProductos.BestFitColumns()
    End Sub

    Private Sub ActualizaFormulario(Optional ID As Integer = 0)
        Dim Articulo As BusinessEntities.Producto
        If ID = 0 Then
            Articulo = BusinessProcess.ProductosBP.GetInfo(Convert.ToInt32(ListaProductos.GetFocusedRowCellValue("ID")))
        Else
            Articulo = BusinessProcess.ProductosBP.GetInfo(ID)
        End If

        ID_TextArea.Text = Articulo.ID.ToString
        Nombre_TextArea.Text = Articulo.Nombre
        Precio_TextArea.Text = Articulo.Precio.ToString
        SKU_TextArea.Text = Articulo.SKU.ToString
    End Sub
#End Region

End Class