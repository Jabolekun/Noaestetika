<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta_Nuevo_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta_Nuevo_frm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.volver_bt = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.hora_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.fecha_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.salir_bt = New System.Windows.Forms.Button
        Me.datos_gb = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.descripcion_txt = New System.Windows.Forms.TextBox
        Me.ProductosBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.EsteticaDataset = New Estetica.EsteticaDataset
        Me.cantidad_txt = New System.Windows.Forms.TextBox
        Me.añadir_bt = New System.Windows.Forms.Button
        Me.mas_bt = New System.Windows.Forms.Button
        Me.menos_bt = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.codigo_txt = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.precio_txt = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.articulo_txt = New System.Windows.Forms.TextBox
        Me.productos_dgv = New System.Windows.Forms.DataGridView
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.venta_bt = New System.Windows.Forms.Button
        Me.ProductosTA = New Estetica.EsteticaDatasetTableAdapters.productosTableAdapter
        Me.VentasBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTA = New Estetica.EsteticaDatasetTableAdapters.ventasTableAdapter
        Me.ProdventaBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdventaTA = New Estetica.EsteticaDatasetTableAdapters.prodventaTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.pago_cb = New System.Windows.Forms.ComboBox
        Me.sin_chk = New System.Windows.Forms.CheckBox
        Me.cliente_cb = New System.Windows.Forms.ComboBox
        Me.ClientesBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.codcliente_cb = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ClientesTA = New Estetica.EsteticaDatasetTableAdapters.clientesTableAdapter
        Me.tsHerramientas = New System.Windows.Forms.ToolStrip
        Me.dependienta1_bt = New System.Windows.Forms.ToolStripButton
        Me.sepa2_ts = New System.Windows.Forms.ToolStripSeparator
        Me.dependienta2_bt = New System.Windows.Forms.ToolStripButton
        Me.sepa3_ts = New System.Windows.Forms.ToolStripSeparator
        Me.dependienta3_bt = New System.Windows.Forms.ToolStripButton
        Me.tratamientos_bt = New System.Windows.Forms.Button
        Me.DependientasBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.DependientasTA = New Estetica.EsteticaDatasetTableAdapters.dependientasTableAdapter
        Me.TratventaBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.TratventaTA = New Estetica.EsteticaDatasetTableAdapters.tratventaTableAdapter
        Me.MenuStrip1.SuspendLayout()
        Me.datos_gb.SuspendLayout()
        CType(Me.ProductosBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.productos_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdventaBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClientesBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsHerramientas.SuspendLayout()
        CType(Me.DependientasBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TratventaBS, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.volver_bt.Location = New System.Drawing.Point(0, 263)
        Me.volver_bt.Name = "volver_bt"
        Me.volver_bt.Size = New System.Drawing.Size(150, 699)
        Me.volver_bt.TabIndex = 2
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
        Me.MenuStrip1.TabIndex = 1
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
        Me.salir_bt.Location = New System.Drawing.Point(1634, 263)
        Me.salir_bt.Name = "salir_bt"
        Me.salir_bt.Size = New System.Drawing.Size(150, 699)
        Me.salir_bt.TabIndex = 3
        Me.salir_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salir_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.salir_bt.UseVisualStyleBackColor = False
        '
        'datos_gb
        '
        Me.datos_gb.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.datos_gb.Controls.Add(Me.Label6)
        Me.datos_gb.Controls.Add(Me.descripcion_txt)
        Me.datos_gb.Controls.Add(Me.cantidad_txt)
        Me.datos_gb.Controls.Add(Me.añadir_bt)
        Me.datos_gb.Controls.Add(Me.mas_bt)
        Me.datos_gb.Controls.Add(Me.menos_bt)
        Me.datos_gb.Controls.Add(Me.Panel2)
        Me.datos_gb.Controls.Add(Me.precio_txt)
        Me.datos_gb.Controls.Add(Me.Label7)
        Me.datos_gb.Controls.Add(Me.Label5)
        Me.datos_gb.Controls.Add(Me.Label3)
        Me.datos_gb.Controls.Add(Me.articulo_txt)
        Me.datos_gb.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.datos_gb.Dock = System.Windows.Forms.DockStyle.Top
        Me.datos_gb.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.datos_gb.Location = New System.Drawing.Point(0, 75)
        Me.datos_gb.Name = "datos_gb"
        Me.datos_gb.Size = New System.Drawing.Size(1784, 103)
        Me.datos_gb.TabIndex = 0
        Me.datos_gb.TabStop = False
        Me.datos_gb.Text = "PRODUCTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(365, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 30)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "DESCRIPCIÓN:"
        '
        'descripcion_txt
        '
        Me.descripcion_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBS, "Descripcion", True))
        Me.descripcion_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.descripcion_txt.Location = New System.Drawing.Point(542, 65)
        Me.descripcion_txt.Name = "descripcion_txt"
        Me.descripcion_txt.ReadOnly = True
        Me.descripcion_txt.Size = New System.Drawing.Size(557, 33)
        Me.descripcion_txt.TabIndex = 11
        '
        'ProductosBS
        '
        Me.ProductosBS.DataMember = "productos"
        Me.ProductosBS.DataSource = Me.EsteticaDataset
        '
        'EsteticaDataset
        '
        Me.EsteticaDataset.DataSetName = "EsteticaDataset"
        Me.EsteticaDataset.EnforceConstraints = False
        Me.EsteticaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cantidad_txt
        '
        Me.cantidad_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.cantidad_txt.Location = New System.Drawing.Point(1560, 45)
        Me.cantidad_txt.Name = "cantidad_txt"
        Me.cantidad_txt.Size = New System.Drawing.Size(50, 33)
        Me.cantidad_txt.TabIndex = 10
        Me.cantidad_txt.Text = "1"
        '
        'añadir_bt
        '
        Me.añadir_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.añadir_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.agregar
        Me.añadir_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.añadir_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.añadir_bt.Location = New System.Drawing.Point(1697, 23)
        Me.añadir_bt.Name = "añadir_bt"
        Me.añadir_bt.Size = New System.Drawing.Size(75, 75)
        Me.añadir_bt.TabIndex = 9
        Me.añadir_bt.UseVisualStyleBackColor = False
        '
        'mas_bt
        '
        Me.mas_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.mas_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.plus
        Me.mas_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mas_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.mas_bt.Location = New System.Drawing.Point(1616, 23)
        Me.mas_bt.Name = "mas_bt"
        Me.mas_bt.Size = New System.Drawing.Size(75, 75)
        Me.mas_bt.TabIndex = 8
        Me.mas_bt.UseVisualStyleBackColor = False
        '
        'menos_bt
        '
        Me.menos_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.menos_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.minus
        Me.menos_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.menos_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.menos_bt.Location = New System.Drawing.Point(1479, 23)
        Me.menos_bt.Name = "menos_bt"
        Me.menos_bt.Size = New System.Drawing.Size(75, 75)
        Me.menos_bt.TabIndex = 7
        Me.menos_bt.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.codigo_txt)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(12, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(347, 57)
        Me.Panel2.TabIndex = 0
        '
        'codigo_txt
        '
        Me.codigo_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.codigo_txt.Location = New System.Drawing.Point(118, 10)
        Me.codigo_txt.Name = "codigo_txt"
        Me.codigo_txt.Size = New System.Drawing.Size(219, 33)
        Me.codigo_txt.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(3, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 30)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "CÓDIGO:"
        '
        'precio_txt
        '
        Me.precio_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBS, "PrecioPublico", True))
        Me.precio_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.precio_txt.Location = New System.Drawing.Point(1211, 45)
        Me.precio_txt.Name = "precio_txt"
        Me.precio_txt.ReadOnly = True
        Me.precio_txt.Size = New System.Drawing.Size(118, 33)
        Me.precio_txt.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(1105, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 30)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "PRECIO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(1335, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 30)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "CANTIDAD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(365, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ARTÍCULO:"
        '
        'articulo_txt
        '
        Me.articulo_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBS, "Articulo", True))
        Me.articulo_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.articulo_txt.Location = New System.Drawing.Point(504, 25)
        Me.articulo_txt.Name = "articulo_txt"
        Me.articulo_txt.ReadOnly = True
        Me.articulo_txt.Size = New System.Drawing.Size(595, 33)
        Me.articulo_txt.TabIndex = 2
        '
        'productos_dgv
        '
        Me.productos_dgv.AllowUserToAddRows = False
        Me.productos_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.productos_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.productos_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.productos_dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column4, Me.Column6})
        Me.productos_dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.productos_dgv.Location = New System.Drawing.Point(150, 413)
        Me.productos_dgv.Name = "productos_dgv"
        Me.productos_dgv.Size = New System.Drawing.Size(1484, 349)
        Me.productos_dgv.TabIndex = 135
        '
        'Column7
        '
        Me.Column7.HeaderText = "Tipo"
        Me.Column7.Name = "Column7"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Artículo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Descripción"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.Name = "Column4"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Importe"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'venta_bt
        '
        Me.venta_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.venta_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.venta128
        Me.venta_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.venta_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.venta_bt.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.venta_bt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.venta_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.venta_bt.Location = New System.Drawing.Point(150, 762)
        Me.venta_bt.Name = "venta_bt"
        Me.venta_bt.Size = New System.Drawing.Size(1484, 200)
        Me.venta_bt.TabIndex = 136
        Me.venta_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.venta_bt.UseVisualStyleBackColor = False
        '
        'ProductosTA
        '
        Me.ProductosTA.ClearBeforeFill = True
        '
        'VentasBS
        '
        Me.VentasBS.DataMember = "ventas"
        Me.VentasBS.DataSource = Me.EsteticaDataset
        '
        'VentasTA
        '
        Me.VentasTA.ClearBeforeFill = True
        '
        'ProdventaBS
        '
        Me.ProdventaBS.DataMember = "prodventa"
        Me.ProdventaBS.DataSource = Me.EsteticaDataset
        '
        'ProdventaTA
        '
        Me.ProdventaTA.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.pago_cb)
        Me.GroupBox1.Controls.Add(Me.sin_chk)
        Me.GroupBox1.Controls.Add(Me.cliente_cb)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.codcliente_cb)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1784, 85)
        Me.GroupBox1.TabIndex = 137
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CLIENTE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(1146, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "PAGO:"
        '
        'pago_cb
        '
        Me.pago_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pago_cb.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.pago_cb.FormattingEnabled = True
        Me.pago_cb.Items.AddRange(New Object() {"Metálico", "Tarjeta"})
        Me.pago_cb.Location = New System.Drawing.Point(1231, 40)
        Me.pago_cb.Name = "pago_cb"
        Me.pago_cb.Size = New System.Drawing.Size(151, 33)
        Me.pago_cb.TabIndex = 0
        '
        'sin_chk
        '
        Me.sin_chk.AutoSize = True
        Me.sin_chk.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sin_chk.Location = New System.Drawing.Point(744, 38)
        Me.sin_chk.Name = "sin_chk"
        Me.sin_chk.Size = New System.Drawing.Size(274, 34)
        Me.sin_chk.TabIndex = 7
        Me.sin_chk.Text = "SIN CÓDIGO CLIENTE"
        Me.sin_chk.UseVisualStyleBackColor = True
        '
        'cliente_cb
        '
        Me.cliente_cb.DataSource = Me.ClientesBS
        Me.cliente_cb.DisplayMember = "Cliente"
        Me.cliente_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cliente_cb.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.cliente_cb.FormattingEnabled = True
        Me.cliente_cb.Location = New System.Drawing.Point(374, 40)
        Me.cliente_cb.Name = "cliente_cb"
        Me.cliente_cb.Size = New System.Drawing.Size(364, 33)
        Me.cliente_cb.TabIndex = 6
        Me.cliente_cb.ValueMember = "CodCliente"
        '
        'ClientesBS
        '
        Me.ClientesBS.DataMember = "clientes"
        Me.ClientesBS.DataSource = Me.EsteticaDataset
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(254, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NOMBRE:"
        '
        'codcliente_cb
        '
        Me.codcliente_cb.DataSource = Me.ClientesBS
        Me.codcliente_cb.DisplayMember = "CodCliente"
        Me.codcliente_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.codcliente_cb.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.codcliente_cb.FormattingEnabled = True
        Me.codcliente_cb.Location = New System.Drawing.Point(127, 40)
        Me.codcliente_cb.Name = "codcliente_cb"
        Me.codcliente_cb.Size = New System.Drawing.Size(121, 33)
        Me.codcliente_cb.TabIndex = 3
        Me.codcliente_cb.ValueMember = "CodCliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CÓDIGO:"
        '
        'ClientesTA
        '
        Me.ClientesTA.ClearBeforeFill = True
        '
        'tsHerramientas
        '
        Me.tsHerramientas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tsHerramientas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsHerramientas.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dependienta1_bt, Me.sepa2_ts, Me.dependienta2_bt, Me.sepa3_ts, Me.dependienta3_bt})
        Me.tsHerramientas.Location = New System.Drawing.Point(0, 33)
        Me.tsHerramientas.Name = "tsHerramientas"
        Me.tsHerramientas.Padding = New System.Windows.Forms.Padding(7, 0, 1, 0)
        Me.tsHerramientas.Size = New System.Drawing.Size(1784, 42)
        Me.tsHerramientas.Stretch = True
        Me.tsHerramientas.TabIndex = 139
        '
        'dependienta1_bt
        '
        Me.dependienta1_bt.CheckOnClick = True
        Me.dependienta1_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.dependienta1_bt.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.dependienta1_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.dependienta1_bt.Name = "dependienta1_bt"
        Me.dependienta1_bt.Size = New System.Drawing.Size(214, 39)
        Me.dependienta1_bt.Text = "DEPENDIENTA1"
        '
        'sepa2_ts
        '
        Me.sepa2_ts.Name = "sepa2_ts"
        Me.sepa2_ts.Size = New System.Drawing.Size(6, 42)
        '
        'dependienta2_bt
        '
        Me.dependienta2_bt.CheckOnClick = True
        Me.dependienta2_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.dependienta2_bt.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.dependienta2_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.dependienta2_bt.Name = "dependienta2_bt"
        Me.dependienta2_bt.Size = New System.Drawing.Size(214, 39)
        Me.dependienta2_bt.Text = "DEPENDIENTA2"
        '
        'sepa3_ts
        '
        Me.sepa3_ts.Name = "sepa3_ts"
        Me.sepa3_ts.Size = New System.Drawing.Size(6, 42)
        '
        'dependienta3_bt
        '
        Me.dependienta3_bt.CheckOnClick = True
        Me.dependienta3_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.dependienta3_bt.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.dependienta3_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.dependienta3_bt.Name = "dependienta3_bt"
        Me.dependienta3_bt.Size = New System.Drawing.Size(214, 39)
        Me.dependienta3_bt.Text = "DEPENDIENTA3"
        '
        'tratamientos_bt
        '
        Me.tratamientos_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.tratamientos_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.tratamientos128
        Me.tratamientos_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tratamientos_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tratamientos_bt.Dock = System.Windows.Forms.DockStyle.Top
        Me.tratamientos_bt.Location = New System.Drawing.Point(150, 263)
        Me.tratamientos_bt.Name = "tratamientos_bt"
        Me.tratamientos_bt.Size = New System.Drawing.Size(1484, 150)
        Me.tratamientos_bt.TabIndex = 140
        Me.tratamientos_bt.UseVisualStyleBackColor = False
        '
        'DependientasBS
        '
        Me.DependientasBS.DataMember = "dependientas"
        Me.DependientasBS.DataSource = Me.EsteticaDataset
        '
        'DependientasTA
        '
        Me.DependientasTA.ClearBeforeFill = True
        '
        'TratventaBS
        '
        Me.TratventaBS.DataMember = "tratventa"
        Me.TratventaBS.DataSource = Me.EsteticaDataset
        '
        'TratventaTA
        '
        Me.TratventaTA.ClearBeforeFill = True
        '
        'Venta_Nuevo_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Estetica.My.MySettings.Default.Fondo
        Me.ClientSize = New System.Drawing.Size(1784, 962)
        Me.Controls.Add(Me.productos_dgv)
        Me.Controls.Add(Me.tratamientos_bt)
        Me.Controls.Add(Me.venta_bt)
        Me.Controls.Add(Me.salir_bt)
        Me.Controls.Add(Me.volver_bt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.datos_gb)
        Me.Controls.Add(Me.tsHerramientas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Fondo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Venta_Nuevo_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NUEVA VENTA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.datos_gb.ResumeLayout(False)
        Me.datos_gb.PerformLayout()
        CType(Me.ProductosBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.productos_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdventaBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClientesBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsHerramientas.ResumeLayout(False)
        Me.tsHerramientas.PerformLayout()
        CType(Me.DependientasBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TratventaBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents volver_bt As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents hora_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fecha_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents salir_bt As System.Windows.Forms.Button
    Friend WithEvents datos_gb As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents codigo_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents precio_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents articulo_txt As System.Windows.Forms.TextBox
    Friend WithEvents EsteticaDataset As Estetica.EsteticaDataset
    Friend WithEvents ProductosBS As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTA As Estetica.EsteticaDatasetTableAdapters.productosTableAdapter
    Friend WithEvents productos_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents venta_bt As System.Windows.Forms.Button
    Friend WithEvents VentasBS As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTA As Estetica.EsteticaDatasetTableAdapters.ventasTableAdapter
    Friend WithEvents ProdventaBS As System.Windows.Forms.BindingSource
    Friend WithEvents ProdventaTA As Estetica.EsteticaDatasetTableAdapters.prodventaTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents codcliente_cb As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClientesBS As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTA As Estetica.EsteticaDatasetTableAdapters.clientesTableAdapter
    Friend WithEvents sin_chk As System.Windows.Forms.CheckBox
    Friend WithEvents cliente_cb As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pago_cb As System.Windows.Forms.ComboBox
    Friend WithEvents tsHerramientas As System.Windows.Forms.ToolStrip
    Friend WithEvents dependienta1_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents sepa2_ts As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dependienta2_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents sepa3_ts As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dependienta3_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents menos_bt As System.Windows.Forms.Button
    Friend WithEvents añadir_bt As System.Windows.Forms.Button
    Friend WithEvents mas_bt As System.Windows.Forms.Button
    Friend WithEvents cantidad_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents descripcion_txt As System.Windows.Forms.TextBox
    Friend WithEvents tratamientos_bt As System.Windows.Forms.Button
    Friend WithEvents DependientasBS As System.Windows.Forms.BindingSource
    Friend WithEvents DependientasTA As Estetica.EsteticaDatasetTableAdapters.dependientasTableAdapter
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TratventaBS As System.Windows.Forms.BindingSource
    Friend WithEvents TratventaTA As Estetica.EsteticaDatasetTableAdapters.tratventaTableAdapter
End Class
