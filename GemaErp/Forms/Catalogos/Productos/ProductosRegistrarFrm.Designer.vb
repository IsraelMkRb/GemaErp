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
        Me.ID_TextArea = New DevExpress.XtraEditors.TextEdit()
        Me.Nombre_TextArea = New DevExpress.XtraEditors.TextEdit()
        Me.Precio_TextArea = New DevExpress.XtraEditors.TextEdit()
        Me.SKU_TextArea = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
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
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.ItemsListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID_TextArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nombre_TextArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Precio_TextArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SKU_TextArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuspendLayout()
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.ItemsListGrid)
        Me.DataLayoutControl1.Controls.Add(Me.ID_TextArea)
        Me.DataLayoutControl1.Controls.Add(Me.Nombre_TextArea)
        Me.DataLayoutControl1.Controls.Add(Me.Precio_TextArea)
        Me.DataLayoutControl1.Controls.Add(Me.SKU_TextArea)
        Me.DataLayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.DataLayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.DataLayoutControl1.Controls.Add(Me.SimpleButton3)
        Me.DataLayoutControl1.Controls.Add(Me.SimpleButton4)
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(898, 417)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'ItemsListGrid
        '
        Me.ItemsListGrid.Location = New System.Drawing.Point(12, 12)
        Me.ItemsListGrid.MainView = Me.ListaProductos
        Me.ItemsListGrid.Name = "ItemsListGrid"
        Me.ItemsListGrid.Size = New System.Drawing.Size(196, 393)
        Me.ItemsListGrid.TabIndex = 4
        Me.ItemsListGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaProductos})
        '
        'ListaProductos
        '
        Me.ListaProductos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColID, Me.colNombre})
        Me.ListaProductos.GridControl = Me.ItemsListGrid
        Me.ListaProductos.Name = "ListaProductos"
        Me.ListaProductos.OptionsView.ShowGroupPanel = False
        '
        'ColID
        '
        Me.ColID.Caption = "ID"
        Me.ColID.FieldName = "ID"
        Me.ColID.Name = "ColID"
        Me.ColID.Visible = True
        Me.ColID.VisibleIndex = 0
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        '
        'ID_TextArea
        '
        Me.ID_TextArea.Location = New System.Drawing.Point(271, 72)
        Me.ID_TextArea.Name = "ID_TextArea"
        Me.ID_TextArea.Size = New System.Drawing.Size(615, 20)
        Me.ID_TextArea.StyleController = Me.DataLayoutControl1
        Me.ID_TextArea.TabIndex = 5
        '
        'Nombre_TextArea
        '
        Me.Nombre_TextArea.Location = New System.Drawing.Point(271, 96)
        Me.Nombre_TextArea.Name = "Nombre_TextArea"
        Me.Nombre_TextArea.Size = New System.Drawing.Size(615, 20)
        Me.Nombre_TextArea.StyleController = Me.DataLayoutControl1
        Me.Nombre_TextArea.TabIndex = 6
        '
        'Precio_TextArea
        '
        Me.Precio_TextArea.Location = New System.Drawing.Point(271, 120)
        Me.Precio_TextArea.Name = "Precio_TextArea"
        Me.Precio_TextArea.Size = New System.Drawing.Size(615, 20)
        Me.Precio_TextArea.StyleController = Me.DataLayoutControl1
        Me.Precio_TextArea.TabIndex = 7
        '
        'SKU_TextArea
        '
        Me.SKU_TextArea.Location = New System.Drawing.Point(271, 144)
        Me.SKU_TextArea.Name = "SKU_TextArea"
        Me.SKU_TextArea.Size = New System.Drawing.Size(615, 20)
        Me.SKU_TextArea.StyleController = Me.DataLayoutControl1
        Me.SKU_TextArea.TabIndex = 8
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(222, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(156, 36)
        Me.SimpleButton1.StyleController = Me.DataLayoutControl1
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "Nuevo"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(382, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(164, 36)
        Me.SimpleButton2.StyleController = Me.DataLayoutControl1
        Me.SimpleButton2.TabIndex = 10
        Me.SimpleButton2.Text = "Guardar"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(550, 12)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(167, 36)
        Me.SimpleButton3.StyleController = Me.DataLayoutControl1
        Me.SimpleButton3.TabIndex = 11
        Me.SimpleButton3.Text = "Borrar"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(721, 12)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(165, 36)
        Me.SimpleButton4.StyleController = Me.DataLayoutControl1
        Me.SimpleButton4.TabIndex = 12
        Me.SimpleButton4.Text = "Cancelar"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.SplitterItem1, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(898, 417)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ItemsListGrid
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(200, 397)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ID_TextArea
        Me.LayoutControlItem2.Location = New System.Drawing.Point(210, 60)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(668, 24)
        Me.LayoutControlItem2.Text = "ID"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(37, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Nombre_TextArea
        Me.LayoutControlItem3.Location = New System.Drawing.Point(210, 84)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(668, 24)
        Me.LayoutControlItem3.Text = "Nombre"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(37, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Precio_TextArea
        Me.LayoutControlItem4.Location = New System.Drawing.Point(210, 108)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(668, 24)
        Me.LayoutControlItem4.Text = "Precio"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(37, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SKU_TextArea
        Me.LayoutControlItem5.Location = New System.Drawing.Point(210, 132)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(668, 265)
        Me.LayoutControlItem5.Text = "SKU"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(37, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SimpleButton1
        Me.LayoutControlItem6.Location = New System.Drawing.Point(210, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(160, 60)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton2
        Me.LayoutControlItem7.Location = New System.Drawing.Point(370, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(168, 60)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SimpleButton3
        Me.LayoutControlItem8.Location = New System.Drawing.Point(538, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(171, 60)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SimpleButton4
        Me.LayoutControlItem9.Location = New System.Drawing.Point(709, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(169, 40)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.Location = New System.Drawing.Point(200, 0)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(10, 397)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(709, 40)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(169, 10)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(709, 50)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(169, 10)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'ProductosRegistrarFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 417)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Name = "ProductosRegistrarFrm"
        Me.Text = "Registrar"
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.ItemsListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID_TextArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nombre_TextArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Precio_TextArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SKU_TextArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents ItemsListGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaProductos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ID_TextArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Nombre_TextArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Precio_TextArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SKU_TextArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ColID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
End Class
