<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto_Historial_frm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producto_Historial_frm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.volver_bt = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.hora_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.fecha_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.salir_bt = New System.Windows.Forms.Button
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        Me.borrar_bt = New System.Windows.Forms.Button
        Me.editar_bt = New System.Windows.Forms.Button
        Me.guardar_bt = New System.Windows.Forms.Button
        Me.categorias_cb = New System.Windows.Forms.ComboBox
        Me.ProdcategoriasBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.EsteticaDataset = New Estetica.EsteticaDataset
        Me.cantidad_txt = New System.Windows.Forms.TextBox
        Me.ProductosBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.stock_txt = New System.Windows.Forms.TextBox
        Me.articulo_txt = New System.Windows.Forms.TextBox
        Me.proveedores_cb = New System.Windows.Forms.ComboBox
        Me.ProveedoresBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.profesional_txt = New System.Windows.Forms.TextBox
        Me.publico_txt = New System.Windows.Forms.TextBox
        Me.codigo_txt = New System.Windows.Forms.TextBox
        Me.descripcion_txt = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.datos_gb = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.proveedor_txt = New System.Windows.Forms.TextBox
        Me.categoria_txt = New System.Windows.Forms.TextBox
        Me.productos_bn = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.ultimo_bt = New System.Windows.Forms.ToolStripButton
        Me.adelante_bt = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.atras_bt = New System.Windows.Forms.ToolStripButton
        Me.primero_bt = New System.Windows.Forms.ToolStripButton
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.nombre_ts = New System.Windows.Forms.ToolStripTextBox
        Me.buscanombre_bt = New System.Windows.Forms.ToolStripButton
        Me.productos_tc = New System.Windows.Forms.TabControl
        Me.ventas_tp = New System.Windows.Forms.TabPage
        Me.ventas_dgv = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProdventaBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.ventas_bn = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton
        Me.compras_tp = New System.Windows.Forms.TabPage
        Me.compras_dgv = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComprasBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.compras_bn = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ProdcategoriasTA = New Estetica.EsteticaDatasetTableAdapters.prodcategoriasTableAdapter
        Me.ProveedoresTA = New Estetica.EsteticaDatasetTableAdapters.proveedoresTableAdapter
        Me.ProductosTA = New Estetica.EsteticaDatasetTableAdapters.productosTableAdapter
        Me.ProdventaTA = New Estetica.EsteticaDatasetTableAdapters.prodventaTableAdapter
        Me.TableAdapterManager = New Estetica.EsteticaDatasetTableAdapters.TableAdapterManager
        Me.ComprasTA = New Estetica.EsteticaDatasetTableAdapters.comprasTableAdapter
        Me.NombreProductoBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreProductoTA = New Estetica.EsteticaDatasetTableAdapters.NombreProductoTableAdapter
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ProdcategoriasBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.datos_gb.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.productos_bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.productos_bn.SuspendLayout()
        Me.productos_tc.SuspendLayout()
        Me.ventas_tp.SuspendLayout()
        CType(Me.ventas_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdventaBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ventas_bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ventas_bn.SuspendLayout()
        Me.compras_tp.SuspendLayout()
        CType(Me.compras_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compras_bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.compras_bn.SuspendLayout()
        CType(Me.NombreProductoBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'volver_bt
        '
        Me.volver_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.volver_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.Fondo
        Me.volver_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.volver_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.volver_bt.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.volver_bt.Dock = System.Windows.Forms.DockStyle.Left
        Me.volver_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.volver_bt.Image = Global.Estetica.My.Resources.Resources.volver128
        Me.volver_bt.Location = New System.Drawing.Point(0, 254)
        Me.volver_bt.Name = "volver_bt"
        Me.volver_bt.Size = New System.Drawing.Size(150, 708)
        Me.volver_bt.TabIndex = 101
        Me.volver_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.volver_bt.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.MenuStrip1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MenuStrip1.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.hora_txt, Me.fecha_txt})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(1784, 33)
        Me.MenuStrip1.TabIndex = 99
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'hora_txt
        '
        Me.hora_txt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.hora_txt.Name = "hora_txt"
        Me.hora_txt.Size = New System.Drawing.Size(75, 29)
        Me.hora_txt.Text = "Hora"
        '
        'fecha_txt
        '
        Me.fecha_txt.Name = "fecha_txt"
        Me.fecha_txt.Size = New System.Drawing.Size(86, 29)
        Me.fecha_txt.Text = "Fecha"
        '
        'salir_bt
        '
        Me.salir_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.salir_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.Fondo
        Me.salir_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.salir_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.salir_bt.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.salir_bt.Dock = System.Windows.Forms.DockStyle.Right
        Me.salir_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.salir_bt.Image = Global.Estetica.My.Resources.Resources.salir128
        Me.salir_bt.Location = New System.Drawing.Point(1634, 254)
        Me.salir_bt.Name = "salir_bt"
        Me.salir_bt.Size = New System.Drawing.Size(150, 708)
        Me.salir_bt.TabIndex = 100
        Me.salir_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salir_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.salir_bt.UseVisualStyleBackColor = False
        '
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'borrar_bt
        '
        Me.borrar_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.borrar_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.borrar64
        Me.borrar_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.borrar_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.borrar_bt.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.borrar_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.borrar_bt.Location = New System.Drawing.Point(3, 3)
        Me.borrar_bt.Name = "borrar_bt"
        Me.borrar_bt.Size = New System.Drawing.Size(100, 90)
        Me.borrar_bt.TabIndex = 116
        Me.borrar_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttConsejo.SetToolTip(Me.borrar_bt, "Borrar ficha tratamiento")
        Me.borrar_bt.UseVisualStyleBackColor = False
        '
        'editar_bt
        '
        Me.editar_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.editar_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.editar64
        Me.editar_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.editar_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.editar_bt.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.editar_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.editar_bt.Location = New System.Drawing.Point(109, 3)
        Me.editar_bt.Name = "editar_bt"
        Me.editar_bt.Size = New System.Drawing.Size(100, 90)
        Me.editar_bt.TabIndex = 115
        Me.editar_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttConsejo.SetToolTip(Me.editar_bt, "Editar ficha tratamiento")
        Me.editar_bt.UseVisualStyleBackColor = False
        '
        'guardar_bt
        '
        Me.guardar_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.guardar_bt.BackgroundImage = CType(resources.GetObject("guardar_bt.BackgroundImage"), System.Drawing.Image)
        Me.guardar_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.guardar_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.guardar_bt.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.guardar_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.guardar_bt.Location = New System.Drawing.Point(215, 3)
        Me.guardar_bt.Name = "guardar_bt"
        Me.guardar_bt.Size = New System.Drawing.Size(100, 90)
        Me.guardar_bt.TabIndex = 114
        Me.guardar_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttConsejo.SetToolTip(Me.guardar_bt, "Guardar ficha tratamiento")
        Me.guardar_bt.UseVisualStyleBackColor = False
        '
        'categorias_cb
        '
        Me.categorias_cb.DataSource = Me.ProdcategoriasBS
        Me.categorias_cb.DisplayMember = "Categoria"
        Me.categorias_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categorias_cb.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.categorias_cb.FormattingEnabled = True
        Me.categorias_cb.Location = New System.Drawing.Point(160, 40)
        Me.categorias_cb.Name = "categorias_cb"
        Me.categorias_cb.Size = New System.Drawing.Size(373, 33)
        Me.categorias_cb.TabIndex = 112
        Me.ttConsejo.SetToolTip(Me.categorias_cb, "Escoge la categoría")
        Me.categorias_cb.ValueMember = "Categoria"
        '
        'ProdcategoriasBS
        '
        Me.ProdcategoriasBS.DataMember = "prodcategorias"
        Me.ProdcategoriasBS.DataSource = Me.EsteticaDataset
        '
        'EsteticaDataset
        '
        Me.EsteticaDataset.DataSetName = "EsteticaDataset"
        Me.EsteticaDataset.EnforceConstraints = False
        Me.EsteticaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cantidad_txt
        '
        Me.cantidad_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBS, "Cantidad", True))
        Me.cantidad_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.cantidad_txt.Location = New System.Drawing.Point(748, 125)
        Me.cantidad_txt.Name = "cantidad_txt"
        Me.cantidad_txt.Size = New System.Drawing.Size(55, 33)
        Me.cantidad_txt.TabIndex = 111
        Me.ttConsejo.SetToolTip(Me.cantidad_txt, "Introducir cantidad")
        '
        'ProductosBS
        '
        Me.ProductosBS.DataMember = "productos"
        Me.ProductosBS.DataSource = Me.EsteticaDataset
        '
        'stock_txt
        '
        Me.stock_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBS, "StockMinimo", True))
        Me.stock_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.stock_txt.Location = New System.Drawing.Point(543, 125)
        Me.stock_txt.Name = "stock_txt"
        Me.stock_txt.Size = New System.Drawing.Size(55, 33)
        Me.stock_txt.TabIndex = 109
        Me.ttConsejo.SetToolTip(Me.stock_txt, "Introducir stock mínimo")
        '
        'articulo_txt
        '
        Me.articulo_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBS, "Articulo", True))
        Me.articulo_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.articulo_txt.Location = New System.Drawing.Point(678, 40)
        Me.articulo_txt.Name = "articulo_txt"
        Me.articulo_txt.Size = New System.Drawing.Size(772, 33)
        Me.articulo_txt.TabIndex = 3
        Me.ttConsejo.SetToolTip(Me.articulo_txt, "Introducir nombre producto")
        '
        'proveedores_cb
        '
        Me.proveedores_cb.DataSource = Me.ProveedoresBS
        Me.proveedores_cb.DisplayMember = "Nombre"
        Me.proveedores_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.proveedores_cb.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.proveedores_cb.FormattingEnabled = True
        Me.proveedores_cb.Location = New System.Drawing.Point(160, 80)
        Me.proveedores_cb.Name = "proveedores_cb"
        Me.proveedores_cb.Size = New System.Drawing.Size(373, 33)
        Me.proveedores_cb.TabIndex = 114
        Me.ttConsejo.SetToolTip(Me.proveedores_cb, "Escoger proveedor")
        Me.proveedores_cb.ValueMember = "CodProveedor"
        '
        'ProveedoresBS
        '
        Me.ProveedoresBS.DataMember = "proveedores"
        Me.ProveedoresBS.DataSource = Me.EsteticaDataset
        '
        'profesional_txt
        '
        Me.profesional_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBS, "PrecioProfesional", True))
        Me.profesional_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.profesional_txt.Location = New System.Drawing.Point(987, 125)
        Me.profesional_txt.Name = "profesional_txt"
        Me.profesional_txt.Size = New System.Drawing.Size(90, 33)
        Me.profesional_txt.TabIndex = 116
        Me.ttConsejo.SetToolTip(Me.profesional_txt, "Introducir precio profesional")
        '
        'publico_txt
        '
        Me.publico_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBS, "PrecioPublico", True))
        Me.publico_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.publico_txt.Location = New System.Drawing.Point(1290, 125)
        Me.publico_txt.Name = "publico_txt"
        Me.publico_txt.Size = New System.Drawing.Size(90, 33)
        Me.publico_txt.TabIndex = 118
        Me.ttConsejo.SetToolTip(Me.publico_txt, "Introducir precio público")
        '
        'codigo_txt
        '
        Me.codigo_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBS, "CodProducto", True))
        Me.codigo_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.codigo_txt.Location = New System.Drawing.Point(118, 5)
        Me.codigo_txt.Name = "codigo_txt"
        Me.codigo_txt.ReadOnly = True
        Me.codigo_txt.Size = New System.Drawing.Size(204, 33)
        Me.codigo_txt.TabIndex = 117
        Me.ttConsejo.SetToolTip(Me.codigo_txt, "Introducir código")
        '
        'descripcion_txt
        '
        Me.descripcion_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBS, "Descripcion", True))
        Me.descripcion_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.descripcion_txt.Location = New System.Drawing.Point(716, 80)
        Me.descripcion_txt.Name = "descripcion_txt"
        Me.descripcion_txt.Size = New System.Drawing.Size(734, 33)
        Me.descripcion_txt.TabIndex = 135
        Me.ttConsejo.SetToolTip(Me.descripcion_txt, "Introducir nombre producto")
        '
        'Panel1
        '
        Me.Panel1.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.borrar_bt)
        Me.Panel1.Controls.Add(Me.editar_bt)
        Me.Panel1.Controls.Add(Me.guardar_bt)
        Me.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel1.Location = New System.Drawing.Point(1456, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 100)
        Me.Panel1.TabIndex = 134
        '
        'datos_gb
        '
        Me.datos_gb.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.datos_gb.Controls.Add(Me.Label9)
        Me.datos_gb.Controls.Add(Me.descripcion_txt)
        Me.datos_gb.Controls.Add(Me.Panel2)
        Me.datos_gb.Controls.Add(Me.Panel1)
        Me.datos_gb.Controls.Add(Me.publico_txt)
        Me.datos_gb.Controls.Add(Me.Label7)
        Me.datos_gb.Controls.Add(Me.profesional_txt)
        Me.datos_gb.Controls.Add(Me.Label6)
        Me.datos_gb.Controls.Add(Me.cantidad_txt)
        Me.datos_gb.Controls.Add(Me.Label5)
        Me.datos_gb.Controls.Add(Me.stock_txt)
        Me.datos_gb.Controls.Add(Me.Label4)
        Me.datos_gb.Controls.Add(Me.Label3)
        Me.datos_gb.Controls.Add(Me.articulo_txt)
        Me.datos_gb.Controls.Add(Me.Label2)
        Me.datos_gb.Controls.Add(Me.Label1)
        Me.datos_gb.Controls.Add(Me.proveedor_txt)
        Me.datos_gb.Controls.Add(Me.categoria_txt)
        Me.datos_gb.Controls.Add(Me.categorias_cb)
        Me.datos_gb.Controls.Add(Me.proveedores_cb)
        Me.datos_gb.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.datos_gb.Dock = System.Windows.Forms.DockStyle.Top
        Me.datos_gb.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.datos_gb.Location = New System.Drawing.Point(0, 85)
        Me.datos_gb.Name = "datos_gb"
        Me.datos_gb.Size = New System.Drawing.Size(1784, 169)
        Me.datos_gb.TabIndex = 133
        Me.datos_gb.TabStop = False
        Me.datos_gb.Text = "PRODUCTOS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(539, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 30)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "DESCRIPCIÓN:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.codigo_txt)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(4, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(329, 42)
        Me.Panel2.TabIndex = 120
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(3, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 30)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "CÓDIGO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(1083, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 30)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "PRECIO PÚBLICO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(809, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 30)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "PRECIO PROF.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(604, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 30)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "CANTIDAD:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 30)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "PROVEEDOR:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(539, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 30)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "ARTÍCULO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(339, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 30)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "STOCK MÍNIMO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 30)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "CATEGORÍA:"
        '
        'proveedor_txt
        '
        Me.proveedor_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBS, "Proveedor", True))
        Me.proveedor_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.proveedor_txt.Location = New System.Drawing.Point(160, 80)
        Me.proveedor_txt.Name = "proveedor_txt"
        Me.proveedor_txt.Size = New System.Drawing.Size(373, 33)
        Me.proveedor_txt.TabIndex = 119
        '
        'categoria_txt
        '
        Me.categoria_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBS, "Categoria", True))
        Me.categoria_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.categoria_txt.Location = New System.Drawing.Point(160, 40)
        Me.categoria_txt.Name = "categoria_txt"
        Me.categoria_txt.Size = New System.Drawing.Size(373, 33)
        Me.categoria_txt.TabIndex = 113
        '
        'productos_bn
        '
        Me.productos_bn.AddNewItem = Nothing
        Me.productos_bn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.productos_bn.BindingSource = Me.ProductosBS
        Me.productos_bn.CountItem = Me.BindingNavigatorCountItem
        Me.productos_bn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.productos_bn.DeleteItem = Nothing
        Me.productos_bn.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.productos_bn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.productos_bn.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.productos_bn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ultimo_bt, Me.adelante_bt, Me.BindingNavigatorSeparator2, Me.BindingNavigatorCountItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorSeparator3, Me.atras_bt, Me.primero_bt, Me.ToolStripTextBox1, Me.ToolStripSeparator1, Me.nombre_ts, Me.buscanombre_bt})
        Me.productos_bn.Location = New System.Drawing.Point(0, 33)
        Me.productos_bn.MoveFirstItem = Me.primero_bt
        Me.productos_bn.MoveLastItem = Me.ultimo_bt
        Me.productos_bn.MoveNextItem = Me.adelante_bt
        Me.productos_bn.MovePreviousItem = Me.atras_bt
        Me.productos_bn.Name = "productos_bn"
        Me.productos_bn.PositionItem = Me.BindingNavigatorPositionItem
        Me.productos_bn.Size = New System.Drawing.Size(1784, 52)
        Me.productos_bn.Stretch = True
        Me.productos_bn.TabIndex = 132
        Me.productos_bn.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(84, 49)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'ultimo_bt
        '
        Me.ultimo_bt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ultimo_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ultimo_bt.Image = Global.Estetica.My.Resources.Resources.ultimo
        Me.ultimo_bt.Name = "ultimo_bt"
        Me.ultimo_bt.RightToLeftAutoMirrorImage = True
        Me.ultimo_bt.Size = New System.Drawing.Size(49, 49)
        Me.ultimo_bt.Text = "Mover último"
        '
        'adelante_bt
        '
        Me.adelante_bt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.adelante_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.adelante_bt.Image = Global.Estetica.My.Resources.Resources.adelante
        Me.adelante_bt.Name = "adelante_bt"
        Me.adelante_bt.RightToLeftAutoMirrorImage = True
        Me.adelante_bt.Size = New System.Drawing.Size(49, 49)
        Me.adelante_bt.Text = "Mover siguiente"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 33)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 52)
        '
        'atras_bt
        '
        Me.atras_bt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.atras_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.atras_bt.Image = Global.Estetica.My.Resources.Resources.atras
        Me.atras_bt.Name = "atras_bt"
        Me.atras_bt.RightToLeftAutoMirrorImage = True
        Me.atras_bt.Size = New System.Drawing.Size(49, 49)
        Me.atras_bt.Text = "Mover anterior"
        '
        'primero_bt
        '
        Me.primero_bt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.primero_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.primero_bt.Image = Global.Estetica.My.Resources.Resources.primero
        Me.primero_bt.Name = "primero_bt"
        Me.primero_bt.RightToLeftAutoMirrorImage = True
        Me.primero_bt.Size = New System.Drawing.Size(49, 49)
        Me.primero_bt.Text = "Mover primero"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.ReadOnly = True
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(110, 52)
        Me.ToolStripTextBox1.Text = "CÓDIGO:"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'nombre_ts
        '
        Me.nombre_ts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.nombre_ts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.nombre_ts.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.nombre_ts.Name = "nombre_ts"
        Me.nombre_ts.Size = New System.Drawing.Size(400, 52)
        Me.nombre_ts.ToolTipText = "Buscar por nombre"
        '
        'buscanombre_bt
        '
        Me.buscanombre_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buscanombre_bt.Image = Global.Estetica.My.Resources.Resources.buscar128
        Me.buscanombre_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buscanombre_bt.Name = "buscanombre_bt"
        Me.buscanombre_bt.Size = New System.Drawing.Size(49, 49)
        Me.buscanombre_bt.Text = "Buscar por nombre"
        '
        'productos_tc
        '
        Me.productos_tc.Controls.Add(Me.ventas_tp)
        Me.productos_tc.Controls.Add(Me.compras_tp)
        Me.productos_tc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.productos_tc.ImageList = Me.ImageList1
        Me.productos_tc.Location = New System.Drawing.Point(150, 254)
        Me.productos_tc.Name = "productos_tc"
        Me.productos_tc.SelectedIndex = 0
        Me.productos_tc.Size = New System.Drawing.Size(1484, 708)
        Me.productos_tc.TabIndex = 135
        '
        'ventas_tp
        '
        Me.ventas_tp.AutoScroll = True
        Me.ventas_tp.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.ventas_tp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ventas_tp.Controls.Add(Me.ventas_dgv)
        Me.ventas_tp.Controls.Add(Me.ventas_bn)
        Me.ventas_tp.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ventas_tp.ImageIndex = 0
        Me.ventas_tp.Location = New System.Drawing.Point(4, 67)
        Me.ventas_tp.Name = "ventas_tp"
        Me.ventas_tp.Padding = New System.Windows.Forms.Padding(3)
        Me.ventas_tp.Size = New System.Drawing.Size(1476, 637)
        Me.ventas_tp.TabIndex = 0
        Me.ventas_tp.Text = "VENTAS"
        '
        'ventas_dgv
        '
        Me.ventas_dgv.AllowUserToAddRows = False
        Me.ventas_dgv.AllowUserToDeleteRows = False
        Me.ventas_dgv.AutoGenerateColumns = False
        Me.ventas_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ventas_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ventas_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ventas_dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.ventas_dgv.DataSource = Me.ProdventaBS
        Me.ventas_dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ventas_dgv.Location = New System.Drawing.Point(3, 55)
        Me.ventas_dgv.Name = "ventas_dgv"
        Me.ventas_dgv.ReadOnly = True
        Me.ventas_dgv.Size = New System.Drawing.Size(1466, 575)
        Me.ventas_dgv.TabIndex = 120
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodProdVenta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodProdVenta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CodVenta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CodVenta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CodProducto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CodProducto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Dependienta"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Dependienta"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Cliente"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Pago"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Pago"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'ProdventaBS
        '
        Me.ProdventaBS.DataMember = "prodventa"
        Me.ProdventaBS.DataSource = Me.EsteticaDataset
        '
        'ventas_bn
        '
        Me.ventas_bn.AddNewItem = Nothing
        Me.ventas_bn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.ventas_bn.CountItem = Me.ToolStripLabel2
        Me.ventas_bn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ventas_bn.DeleteItem = Nothing
        Me.ventas_bn.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.ventas_bn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ventas_bn.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.ventas_bn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator7, Me.ToolStripLabel2, Me.ToolStripTextBox2, Me.ToolStripSeparator8, Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripButton9})
        Me.ventas_bn.Location = New System.Drawing.Point(3, 3)
        Me.ventas_bn.MoveFirstItem = Me.ToolStripButton8
        Me.ventas_bn.MoveLastItem = Me.ToolStripButton5
        Me.ventas_bn.MoveNextItem = Me.ToolStripButton6
        Me.ventas_bn.MovePreviousItem = Me.ToolStripButton7
        Me.ventas_bn.Name = "ventas_bn"
        Me.ventas_bn.PositionItem = Me.ToolStripTextBox2
        Me.ventas_bn.Size = New System.Drawing.Size(1466, 52)
        Me.ventas_bn.Stretch = True
        Me.ventas_bn.TabIndex = 120
        Me.ventas_bn.Text = "BindingNavigator2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(84, 49)
        Me.ToolStripLabel2.Text = "de {0}"
        Me.ToolStripLabel2.ToolTipText = "Número total de elementos"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.Estetica.My.Resources.Resources.ultimo
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(49, 49)
        Me.ToolStripButton5.Text = "Mover último"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = Global.Estetica.My.Resources.Resources.adelante
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(49, 49)
        Me.ToolStripButton6.Text = "Mover siguiente"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 52)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Posición"
        Me.ToolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 33)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 52)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = Global.Estetica.My.Resources.Resources.atras
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton7.Size = New System.Drawing.Size(49, 49)
        Me.ToolStripButton7.Text = "Mover anterior"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.Estetica.My.Resources.Resources.primero
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton8.Size = New System.Drawing.Size(49, 49)
        Me.ToolStripButton8.Text = "Mover primero"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = Global.Estetica.My.Resources.Resources.informe64
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(49, 49)
        Me.ToolStripButton9.Text = "ToolStripButton9"
        '
        'compras_tp
        '
        Me.compras_tp.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.compras_tp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.compras_tp.Controls.Add(Me.compras_dgv)
        Me.compras_tp.Controls.Add(Me.compras_bn)
        Me.compras_tp.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.compras_tp.ImageIndex = 1
        Me.compras_tp.Location = New System.Drawing.Point(4, 67)
        Me.compras_tp.Name = "compras_tp"
        Me.compras_tp.Padding = New System.Windows.Forms.Padding(3)
        Me.compras_tp.Size = New System.Drawing.Size(1476, 637)
        Me.compras_tp.TabIndex = 1
        Me.compras_tp.Text = "COMPRAS"
        '
        'compras_dgv
        '
        Me.compras_dgv.AllowUserToAddRows = False
        Me.compras_dgv.AllowUserToDeleteRows = False
        Me.compras_dgv.AutoGenerateColumns = False
        Me.compras_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.compras_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.compras_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.compras_dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.compras_dgv.DataSource = Me.ComprasBS
        Me.compras_dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.compras_dgv.Location = New System.Drawing.Point(3, 50)
        Me.compras_dgv.Name = "compras_dgv"
        Me.compras_dgv.ReadOnly = True
        Me.compras_dgv.Size = New System.Drawing.Size(1466, 580)
        Me.compras_dgv.TabIndex = 120
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CodCompra"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CodCompra"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CodProducto"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CodProducto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Descuento"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Descuento"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'ComprasBS
        '
        Me.ComprasBS.DataMember = "compras"
        Me.ComprasBS.DataSource = Me.EsteticaDataset
        '
        'compras_bn
        '
        Me.compras_bn.AddNewItem = Nothing
        Me.compras_bn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.compras_bn.CountItem = Me.ToolStripLabel1
        Me.compras_bn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.compras_bn.DeleteItem = Nothing
        Me.compras_bn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.compras_bn.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.compras_bn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.ToolStripTextBox5, Me.ToolStripSeparator6, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.compras_bn.Location = New System.Drawing.Point(3, 3)
        Me.compras_bn.MoveFirstItem = Me.ToolStripButton4
        Me.compras_bn.MoveLastItem = Me.ToolStripButton1
        Me.compras_bn.MoveNextItem = Me.ToolStripButton2
        Me.compras_bn.MovePreviousItem = Me.ToolStripButton3
        Me.compras_bn.Name = "compras_bn"
        Me.compras_bn.PositionItem = Me.ToolStripTextBox5
        Me.compras_bn.Size = New System.Drawing.Size(1466, 47)
        Me.compras_bn.Stretch = True
        Me.compras_bn.TabIndex = 120
        Me.compras_bn.Text = "BindingNavigator3"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(37, 44)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Número total de elementos"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Estetica.My.Resources.Resources.ultimo
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(44, 44)
        Me.ToolStripButton1.Text = "Mover último"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Estetica.My.Resources.Resources.adelante
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(44, 44)
        Me.ToolStripButton2.Text = "Mover siguiente"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 47)
        '
        'ToolStripTextBox5
        '
        Me.ToolStripTextBox5.AccessibleName = "Posición"
        Me.ToolStripTextBox5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox5.AutoSize = False
        Me.ToolStripTextBox5.Name = "ToolStripTextBox5"
        Me.ToolStripTextBox5.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox5.Text = "0"
        Me.ToolStripTextBox5.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 47)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.Estetica.My.Resources.Resources.atras
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(44, 44)
        Me.ToolStripButton3.Text = "Mover anterior"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.Estetica.My.Resources.Resources.primero
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(44, 44)
        Me.ToolStripButton4.Text = "Mover primero"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "venta128.png")
        Me.ImageList1.Images.SetKeyName(1, "compra128.png")
        '
        'ProdcategoriasTA
        '
        Me.ProdcategoriasTA.ClearBeforeFill = True
        '
        'ProveedoresTA
        '
        Me.ProveedoresTA.ClearBeforeFill = True
        '
        'ProductosTA
        '
        Me.ProductosTA.ClearBeforeFill = True
        '
        'ProdventaTA
        '
        Me.ProdventaTA.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bonosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Me.ComprasTA
        Me.TableAdapterManager.contraseñaTableAdapter = Nothing
        Me.TableAdapterManager.dependientasTableAdapter = Nothing
        Me.TableAdapterManager.prodcategoriasTableAdapter = Me.ProdcategoriasTA
        Me.TableAdapterManager.productos1TableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Me.ProductosTA
        Me.TableAdapterManager.prodventaTableAdapter = Me.ProdventaTA
        Me.TableAdapterManager.proveedoresTableAdapter = Me.ProveedoresTA
        Me.TableAdapterManager.tratamientosTableAdapter = Nothing
        Me.TableAdapterManager.tratcategoriasTableAdapter = Nothing
        Me.TableAdapterManager.tratventaTableAdapter = Nothing
        Me.TableAdapterManager.turnosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Estetica.EsteticaDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'ComprasTA
        '
        Me.ComprasTA.ClearBeforeFill = True
        '
        'NombreProductoBS
        '
        Me.NombreProductoBS.DataMember = "NombreProducto"
        Me.NombreProductoBS.DataSource = Me.EsteticaDataset
        '
        'NombreProductoTA
        '
        Me.NombreProductoTA.ClearBeforeFill = True
        '
        'Producto_Historial_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Estetica.My.MySettings.Default.Fondo
        Me.ClientSize = New System.Drawing.Size(1784, 962)
        Me.Controls.Add(Me.productos_tc)
        Me.Controls.Add(Me.salir_bt)
        Me.Controls.Add(Me.volver_bt)
        Me.Controls.Add(Me.datos_gb)
        Me.Controls.Add(Me.productos_bn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Fondo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Producto_Historial_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HISTORIAL DE LOS PRODUCTOS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ProdcategoriasBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.datos_gb.ResumeLayout(False)
        Me.datos_gb.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.productos_bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.productos_bn.ResumeLayout(False)
        Me.productos_bn.PerformLayout()
        Me.productos_tc.ResumeLayout(False)
        Me.ventas_tp.ResumeLayout(False)
        Me.ventas_tp.PerformLayout()
        CType(Me.ventas_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdventaBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ventas_bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ventas_bn.ResumeLayout(False)
        Me.ventas_bn.PerformLayout()
        Me.compras_tp.ResumeLayout(False)
        Me.compras_tp.PerformLayout()
        CType(Me.compras_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compras_bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.compras_bn.ResumeLayout(False)
        Me.compras_bn.PerformLayout()
        CType(Me.NombreProductoBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents volver_bt As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents hora_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fecha_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents salir_bt As System.Windows.Forms.Button
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents borrar_bt As System.Windows.Forms.Button
    Friend WithEvents editar_bt As System.Windows.Forms.Button
    Friend WithEvents guardar_bt As System.Windows.Forms.Button
    Friend WithEvents datos_gb As System.Windows.Forms.GroupBox
    Friend WithEvents categorias_cb As System.Windows.Forms.ComboBox
    Friend WithEvents cantidad_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents stock_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents articulo_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents categoria_txt As System.Windows.Forms.TextBox
    Friend WithEvents productos_bn As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ultimo_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents adelante_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents atras_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents primero_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents nombre_ts As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents buscanombre_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents productos_tc As System.Windows.Forms.TabControl
    Friend WithEvents ventas_tp As System.Windows.Forms.TabPage
    Friend WithEvents ventas_bn As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents compras_tp As System.Windows.Forms.TabPage
    Friend WithEvents compras_bn As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents proveedores_cb As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents profesional_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents publico_txt As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents EsteticaDataset As Estetica.EsteticaDataset
    Friend WithEvents ProdcategoriasBS As System.Windows.Forms.BindingSource
    Friend WithEvents ProdcategoriasTA As Estetica.EsteticaDatasetTableAdapters.prodcategoriasTableAdapter
    Friend WithEvents ProveedoresBS As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTA As Estetica.EsteticaDatasetTableAdapters.proveedoresTableAdapter
    Friend WithEvents proveedor_txt As System.Windows.Forms.TextBox
    Friend WithEvents ProductosBS As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTA As Estetica.EsteticaDatasetTableAdapters.productosTableAdapter
    Friend WithEvents ProdventaBS As System.Windows.Forms.BindingSource
    Friend WithEvents ProdventaTA As Estetica.EsteticaDatasetTableAdapters.prodventaTableAdapter
    Friend WithEvents TableAdapterManager As Estetica.EsteticaDatasetTableAdapters.TableAdapterManager
    Friend WithEvents ComprasTA As Estetica.EsteticaDatasetTableAdapters.comprasTableAdapter
    Friend WithEvents ComprasBS As System.Windows.Forms.BindingSource
    Friend WithEvents compras_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents codigo_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ventas_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreProductoBS As System.Windows.Forms.BindingSource
    Friend WithEvents NombreProductoTA As Estetica.EsteticaDatasetTableAdapters.NombreProductoTableAdapter
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents descripcion_txt As System.Windows.Forms.TextBox
End Class
