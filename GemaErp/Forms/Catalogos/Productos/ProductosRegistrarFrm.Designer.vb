<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductosRegistrarFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductosRegistrarFrm))
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.ItemsListGrid = New DevExpress.XtraGrid.GridControl()
        Me.ListaProductos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nombre_TextArea = New DevExpress.XtraEditors.TextEdit()
        Me.Precio_TextArea = New DevExpress.XtraEditors.TextEdit()
        Me.SKU_TextArea = New DevExpress.XtraEditors.TextEdit()
        Me.Nuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.Guardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Delete = New DevExpress.XtraEditors.SimpleButton()
        Me.Cancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.SimpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.SimpleSeparator2 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.SimpleSeparator3 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ID_TextArea = New DevExpress.XtraEditors.TextEdit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.ItemsListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nombre_TextArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Precio_TextArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SKU_TextArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID_TextArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.ItemsListGrid)
        Me.DataLayoutControl1.Controls.Add(Me.ID_TextArea)
        Me.DataLayoutControl1.Controls.Add(Me.Nombre_TextArea)
        Me.DataLayoutControl1.Controls.Add(Me.Precio_TextArea)
        Me.DataLayoutControl1.Controls.Add(Me.SKU_TextArea)
        Me.DataLayoutControl1.Controls.Add(Me.Nuevo)
        Me.DataLayoutControl1.Controls.Add(Me.Guardar)
        Me.DataLayoutControl1.Controls.Add(Me.Delete)
        Me.DataLayoutControl1.Controls.Add(Me.Cancelar)
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1108, 187, 812, 500)
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(1048, 513)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'ItemsListGrid
        '
        Me.ItemsListGrid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ItemsListGrid.Location = New System.Drawing.Point(12, 67)
        Me.ItemsListGrid.MainView = Me.ListaProductos
        Me.ItemsListGrid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ItemsListGrid.Name = "ItemsListGrid"
        Me.ItemsListGrid.Size = New System.Drawing.Size(183, 434)
        Me.ItemsListGrid.TabIndex = 4
        Me.ItemsListGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaProductos})
        '
        'ListaProductos
        '
        Me.ListaProductos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColID, Me.colNombre})
        Me.ListaProductos.DetailHeight = 431
        Me.ListaProductos.GridControl = Me.ItemsListGrid
        Me.ListaProductos.Name = "ListaProductos"
        Me.ListaProductos.OptionsFind.AlwaysVisible = True
        Me.ListaProductos.OptionsFind.FindDelay = 100
        Me.ListaProductos.OptionsView.ShowGroupPanel = False
        '
        'ColID
        '
        Me.ColID.Caption = "ID"
        Me.ColID.FieldName = "ID"
        Me.ColID.MinWidth = 23
        Me.ColID.Name = "ColID"
        Me.ColID.OptionsColumn.AllowEdit = False
        Me.ColID.Visible = True
        Me.ColID.VisibleIndex = 0
        Me.ColID.Width = 87
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.MinWidth = 23
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowEdit = False
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 87
        '
        'Nombre_TextArea
        '
        Me.Nombre_TextArea.Location = New System.Drawing.Point(211, 191)
        Me.Nombre_TextArea.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nombre_TextArea.Name = "Nombre_TextArea"
        Me.Nombre_TextArea.Size = New System.Drawing.Size(825, 22)
        Me.Nombre_TextArea.StyleController = Me.DataLayoutControl1
        Me.Nombre_TextArea.TabIndex = 6
        '
        'Precio_TextArea
        '
        Me.Precio_TextArea.Location = New System.Drawing.Point(211, 236)
        Me.Precio_TextArea.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Precio_TextArea.Name = "Precio_TextArea"
        Me.Precio_TextArea.Size = New System.Drawing.Size(825, 22)
        Me.Precio_TextArea.StyleController = Me.DataLayoutControl1
        Me.Precio_TextArea.TabIndex = 7
        '
        'SKU_TextArea
        '
        Me.SKU_TextArea.Location = New System.Drawing.Point(211, 281)
        Me.SKU_TextArea.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SKU_TextArea.Name = "SKU_TextArea"
        Me.SKU_TextArea.Size = New System.Drawing.Size(825, 22)
        Me.SKU_TextArea.StyleController = Me.DataLayoutControl1
        Me.SKU_TextArea.TabIndex = 8
        '
        'Nuevo
        '
        Me.Nuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nuevo.Appearance.Options.UseFont = True
        Me.Nuevo.ImageOptions.Image = CType(resources.GetObject("Nuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.Nuevo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.Nuevo.Location = New System.Drawing.Point(211, 67)
        Me.Nuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(181, 36)
        Me.Nuevo.StyleController = Me.DataLayoutControl1
        Me.Nuevo.TabIndex = 9
        Me.Nuevo.Text = "Nuevo"
        '
        'Guardar
        '
        Me.Guardar.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Appearance.Options.UseFont = True
        Me.Guardar.ImageOptions.Image = CType(resources.GetObject("Guardar.ImageOptions.Image"), System.Drawing.Image)
        Me.Guardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.Guardar.Location = New System.Drawing.Point(396, 67)
        Me.Guardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(180, 36)
        Me.Guardar.StyleController = Me.DataLayoutControl1
        Me.Guardar.TabIndex = 10
        Me.Guardar.Text = "Guardar"
        '
        'Delete
        '
        Me.Delete.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Appearance.Options.UseFont = True
        Me.Delete.ImageOptions.Image = CType(resources.GetObject("Delete.ImageOptions.Image"), System.Drawing.Image)
        Me.Delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.Delete.Location = New System.Drawing.Point(580, 67)
        Me.Delete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(180, 36)
        Me.Delete.StyleController = Me.DataLayoutControl1
        Me.Delete.TabIndex = 11
        Me.Delete.Text = "Borrar"
        '
        'Cancelar
        '
        Me.Cancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.Appearance.Options.UseFont = True
        Me.Cancelar.ImageOptions.Image = CType(resources.GetObject("Cancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.Cancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.Cancelar.Location = New System.Drawing.Point(764, 67)
        Me.Cancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(272, 36)
        Me.Cancelar.StyleController = Me.DataLayoutControl1
        Me.Cancelar.TabIndex = 12
        Me.Cancelar.Text = "Cancelar"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.SplitterItem1, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.SimpleLabelItem1, Me.SimpleLabelItem2, Me.SimpleSeparator2, Me.SimpleSeparator3, Me.SimpleSeparator1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1048, 513)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ItemsListGrid
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 55)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(187, 438)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Nombre_TextArea
        Me.LayoutControlItem3.Location = New System.Drawing.Point(199, 160)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(829, 45)
        Me.LayoutControlItem3.Text = "Nombre"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(448, 16)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Precio_TextArea
        Me.LayoutControlItem4.Location = New System.Drawing.Point(199, 205)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(829, 45)
        Me.LayoutControlItem4.Text = "Precio"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(448, 16)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SKU_TextArea
        Me.LayoutControlItem5.Location = New System.Drawing.Point(199, 250)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(829, 243)
        Me.LayoutControlItem5.Text = "SKU"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(448, 16)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Nuevo
        Me.LayoutControlItem6.Location = New System.Drawing.Point(199, 55)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(185, 60)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Guardar
        Me.LayoutControlItem7.Location = New System.Drawing.Point(384, 55)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(184, 60)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Delete
        Me.LayoutControlItem8.Location = New System.Drawing.Point(568, 55)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(184, 60)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Cancelar
        Me.LayoutControlItem9.Location = New System.Drawing.Point(752, 55)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(276, 40)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.Location = New System.Drawing.Point(187, 55)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(12, 438)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(752, 95)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(276, 10)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(752, 105)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(276, 10)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleLabelItem1
        '
        Me.SimpleLabelItem1.AllowHotTrack = False
        Me.SimpleLabelItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseFont = True
        Me.SimpleLabelItem1.Location = New System.Drawing.Point(0, 1)
        Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
        Me.SimpleLabelItem1.Size = New System.Drawing.Size(1028, 32)
        Me.SimpleLabelItem1.Text = "Registro de Productos"
        Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(448, 28)
        '
        'SimpleLabelItem2
        '
        Me.SimpleLabelItem2.AllowHotTrack = False
        Me.SimpleLabelItem2.Location = New System.Drawing.Point(0, 34)
        Me.SimpleLabelItem2.Name = "SimpleLabelItem2"
        Me.SimpleLabelItem2.Size = New System.Drawing.Size(1028, 20)
        Me.SimpleLabelItem2.Text = "En esta seccion usted podra registrar,Modificar y eliminar la lista de productos"
        Me.SimpleLabelItem2.TextSize = New System.Drawing.Size(448, 16)
        '
        'SimpleSeparator2
        '
        Me.SimpleSeparator2.AllowHotTrack = False
        Me.SimpleSeparator2.Location = New System.Drawing.Point(0, 54)
        Me.SimpleSeparator2.Name = "SimpleSeparator2"
        Me.SimpleSeparator2.Size = New System.Drawing.Size(1028, 1)
        '
        'SimpleSeparator3
        '
        Me.SimpleSeparator3.AllowHotTrack = False
        Me.SimpleSeparator3.Location = New System.Drawing.Point(0, 33)
        Me.SimpleSeparator3.Name = "SimpleSeparator3"
        Me.SimpleSeparator3.Size = New System.Drawing.Size(1028, 1)
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 0)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(1028, 1)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ID_TextArea
        Me.LayoutControlItem2.Location = New System.Drawing.Point(199, 115)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(829, 45)
        Me.LayoutControlItem2.Text = "ID"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(448, 16)
        '
        'ID_TextArea
        '
        Me.ID_TextArea.Location = New System.Drawing.Point(211, 146)
        Me.ID_TextArea.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ID_TextArea.Name = "ID_TextArea"
        Me.ID_TextArea.Size = New System.Drawing.Size(825, 22)
        Me.ID_TextArea.StyleController = Me.DataLayoutControl1
        Me.ID_TextArea.TabIndex = 5
        '
        'ProductosRegistrarFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 513)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ProductosRegistrarFrm"
        Me.Text = "Registrar Producto"
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.ItemsListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nombre_TextArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Precio_TextArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SKU_TextArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID_TextArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents ItemsListGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaProductos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Nombre_TextArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Precio_TextArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SKU_TextArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Nuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Guardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Cancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ColID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents SimpleLabelItem2 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents SimpleSeparator2 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents SimpleSeparator3 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents ID_TextArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
