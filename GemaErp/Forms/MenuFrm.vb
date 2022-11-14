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
        Wait.Show(Me)
        Dim ProductoRegistrarFrm As New ProductosRegistrarFrm With {.MdiParent = Me, .WindowState = FormWindowState.Maximized}
        ProductoRegistrarFrm.Show()
        Wait.Dispose()
    End Sub
End Class
