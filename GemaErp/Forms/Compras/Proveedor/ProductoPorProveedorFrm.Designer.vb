<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductoPorProveedorFrm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductoPorProveedorFrm))
        Me.ListaProveedorGrv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ListaProductosGrd = New DevExpress.XtraGrid.GridControl()
        Me.ListaProductoGrv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProveedorGrv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.ProveedoresLke = New DevExpress.XtraEditors.LookUpEdit()
        Me.ProductoLke = New DevExpress.XtraEditors.LookUpEdit()
        Me.VincularBtn = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.Producto = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Proveedor = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMRUEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        CType(Me.ListaProveedorGrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaProductosGrd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaProductoGrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorGrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.ProveedoresLke.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoLke.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMRUEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaProveedorGrv
        '
        Me.ListaProveedorGrv.GridControl = Me.ListaProductosGrd
        Me.ListaProveedorGrv.Name = "ListaProveedorGrv"
        Me.ListaProveedorGrv.OptionsView.ShowGroupPanel = False
        Me.ListaProveedorGrv.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.ListaProveedorGrv.ViewCaption = "Lista Productos"
        '
        'ListaProductosGrd
        '
        GridLevelNode1.LevelTemplate = Me.ListaProveedorGrv
        GridLevelNode1.RelationName = "ListaProveedor"
        GridLevelNode2.LevelTemplate = Me.ListaProductoGrv
        GridLevelNode2.RelationName = "ListaProducto"
        Me.ListaProductosGrd.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.ListaProductosGrd.Location = New System.Drawing.Point(316, 12)
        Me.ListaProductosGrd.MainView = Me.ProveedorGrv
        Me.ListaProductosGrd.Name = "ListaProductosGrd"
        Me.ListaProductosGrd.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMRUEdit1, Me.RepositoryItemPictureEdit1, Me.RepositoryItemPictureEdit2})
        Me.ListaProductosGrd.Size = New System.Drawing.Size(720, 527)
        Me.ListaProductosGrd.TabIndex = 5
        Me.ListaProductosGrd.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaProductoGrv, Me.ProveedorGrv, Me.ListaProveedorGrv})
        '
        'ListaProductoGrv
        '
        Me.ListaProductoGrv.GridControl = Me.ListaProductosGrd
        Me.ListaProductoGrv.Name = "ListaProductoGrv"
        '
        'ProveedorGrv
        '
        Me.ProveedorGrv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.ProveedorGrv.GridControl = Me.ListaProductosGrd
        Me.ProveedorGrv.Name = "ProveedorGrv"
        Me.ProveedorGrv.OptionsView.ShowGroupPanel = False
        Me.ProveedorGrv.ViewCaption = "Lista Proveedores"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.ProveedoresLke)
        Me.DataLayoutControl1.Controls.Add(Me.ListaProductosGrd)
        Me.DataLayoutControl1.Controls.Add(Me.ProductoLke)
        Me.DataLayoutControl1.Controls.Add(Me.VincularBtn)
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(1048, 551)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'ProveedoresLke
        '
        Me.ProveedoresLke.Location = New System.Drawing.Point(82, 32)
        Me.ProveedoresLke.Name = "ProveedoresLke"
        Me.ProveedoresLke.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProveedoresLke.Size = New System.Drawing.Size(230, 22)
        Me.ProveedoresLke.StyleController = Me.DataLayoutControl1
        Me.ProveedoresLke.TabIndex = 6
        '
        'ProductoLke
        '
        Me.ProductoLke.Location = New System.Drawing.Point(82, 58)
        Me.ProductoLke.Name = "ProductoLke"
        Me.ProductoLke.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductoLke.Size = New System.Drawing.Size(230, 22)
        Me.ProductoLke.StyleController = Me.DataLayoutControl1
        Me.ProductoLke.TabIndex = 4
        '
        'VincularBtn
        '
        Me.VincularBtn.ImageOptions.Image = CType(resources.GetObject("VincularBtn.ImageOptions.Image"), System.Drawing.Image)
        Me.VincularBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.VincularBtn.Location = New System.Drawing.Point(12, 84)
        Me.VincularBtn.Name = "VincularBtn"
        Me.VincularBtn.Size = New System.Drawing.Size(300, 36)
        Me.VincularBtn.StyleController = Me.DataLayoutControl1
        Me.VincularBtn.TabIndex = 7
        Me.VincularBtn.Text = "Vincular"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.Producto, Me.LayoutControlItem2, Me.Proveedor, Me.LayoutControlItem1, Me.SimpleLabelItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1048, 551)
        Me.Root.TextVisible = False
        '
        'Producto
        '
        Me.Producto.Control = Me.ProductoLke
        Me.Producto.Location = New System.Drawing.Point(0, 46)
        Me.Producto.Name = "Producto"
        Me.Producto.Size = New System.Drawing.Size(304, 26)
        Me.Producto.TextSize = New System.Drawing.Size(58, 16)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ListaProductosGrd
        Me.LayoutControlItem2.Location = New System.Drawing.Point(304, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(724, 531)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'Proveedor
        '
        Me.Proveedor.Control = Me.ProveedoresLke
        Me.Proveedor.Location = New System.Drawing.Point(0, 20)
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.Size = New System.Drawing.Size(304, 26)
        Me.Proveedor.TextSize = New System.Drawing.Size(58, 16)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.VincularBtn
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(304, 459)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'SimpleLabelItem1
        '
        Me.SimpleLabelItem1.AllowHotTrack = False
        Me.SimpleLabelItem1.Location = New System.Drawing.Point(0, 0)
        Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
        Me.SimpleLabelItem1.Size = New System.Drawing.Size(304, 20)
        Me.SimpleLabelItem1.Text = " "
        Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(58, 16)
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemPictureEdit2
        Me.GridColumn1.MinWidth = 25
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 94
        '
        'RepositoryItemMRUEdit1
        '
        Me.RepositoryItemMRUEdit1.AutoHeight = False
        Me.RepositoryItemMRUEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMRUEdit1.Name = "RepositoryItemMRUEdit1"
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'RepositoryItemPictureEdit2
        '
        Me.RepositoryItemPictureEdit2.Name = "RepositoryItemPictureEdit2"
        '
        'ProductoPorProveedorFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 551)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Name = "ProductoPorProveedorFrm"
        Me.Text = "ProductoPorProveedorFrm"
        CType(Me.ListaProveedorGrv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaProductosGrd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaProductoGrv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorGrv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.ProveedoresLke.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoLke.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMRUEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents ProveedoresLke As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ListaProductosGrd As DevExpress.XtraGrid.GridControl
    Friend WithEvents ProveedorGrv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProductoLke As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents VincularBtn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Producto As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Proveedor As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents ListaProveedorGrv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ListaProductoGrv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents RepositoryItemMRUEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
End Class
