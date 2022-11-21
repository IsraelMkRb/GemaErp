Imports System.ComponentModel
Imports System.Text


Partial Public Class MenuFrm
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub RegistrarOCButton_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles RegistrarOCButton.ItemClick
        Dim ComprasRegistrarfrm As New ComprasRegistroFrm With {.MdiParent = Me, .WindowState = FormWindowState.Maximized}
        ComprasRegistrarfrm.Show()
    End Sub

    Private Sub ProductoRegistrarBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ProductoRegistrarBtn.ItemClick
        Utileria.ShowWait(Me)
        Dim ProductoRegistrarFrm As New ProductosRegistrarFrm With {.MdiParent = Me, .WindowState = FormWindowState.Maximized}
        ProductoRegistrarFrm.Show()
        Utileria.HideWait()
    End Sub

    Private Sub RegistrarProveedorBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles RegistrarProveedorBtn.ItemClick
        Utileria.ShowWait(Me)
        Dim ProveedorRegistrarFrm As New RegistrarProveedorFrm With {.MdiParent = Me, .WindowState = FormWindowState.Maximized}
        ProveedorRegistrarFrm.Show()
        Utileria.HideWait()
    End Sub
End Class
