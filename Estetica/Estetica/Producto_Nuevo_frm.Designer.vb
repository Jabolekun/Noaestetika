<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto_Nuevo_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producto_Nuevo_frm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.volver_bt = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.hora_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.fecha_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.salir_bt = New System.Windows.Forms.Button
        Me.EsteticaDataset = New Estetica.EsteticaDataset
        Me.ProdcategoriasBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdcategoriasTA = New Estetica.EsteticaDatasetTableAdapters.prodcategoriasTableAdapter
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        Me.profesional_txt = New System.Windows.Forms.TextBox
        Me.categoria_cb = New System.Windows.Forms.ComboBox
        Me.categoria_bt = New System.Windows.Forms.Button
        Me.publico_txt = New System.Windows.Forms.TextBox
        Me.cantidad_txt = New System.Windows.Forms.TextBox
        Me.stock_txt = New System.Windows.Forms.TextBox
        Me.proveedor_bt = New System.Windows.Forms.Button
        Me.proveedor_cb = New System.Windows.Forms.ComboBox
        Me.ProveedoresBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.articulo_txt = New System.Windows.Forms.TextBox
        Me.codigo_txt = New System.Windows.Forms.TextBox
        Me.descripcion_txt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.guardar_bt = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.datos_gb = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.ProveedoresTA = New Estetica.EsteticaDatasetTableAdapters.proveedoresTableAdapter
        Me.ProductosBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTA = New Estetica.EsteticaDatasetTableAdapters.productosTableAdapter
        Me.MenuStrip1.SuspendLayout()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdcategoriasBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.datos_gb.SuspendLayout()
        CType(Me.ProductosBS, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.volver_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.volver128
        Me.volver_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.volver_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.volver_bt.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.volver_bt.Dock = System.Windows.Forms.DockStyle.Left
        Me.volver_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.volver_bt.Location = New System.Drawing.Point(0, 33)
        Me.volver_bt.Name = "volver_bt"
        Me.volver_bt.Size = New System.Drawing.Size(150, 288)
        Me.volver_bt.TabIndex = 1
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1424, 33)
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
        Me.salir_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.salir128
        Me.salir_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.salir_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.salir_bt.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.salir_bt.Dock = System.Windows.Forms.DockStyle.Right
        Me.salir_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.salir_bt.Location = New System.Drawing.Point(1274, 33)
        Me.salir_bt.Name = "salir_bt"
        Me.salir_bt.Size = New System.Drawing.Size(150, 288)
        Me.salir_bt.TabIndex = 2
        Me.salir_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salir_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.salir_bt.UseVisualStyleBackColor = False
        '
        'EsteticaDataset
        '
        Me.EsteticaDataset.DataSetName = "EsteticaDataset"
        Me.EsteticaDataset.EnforceConstraints = False
        Me.EsteticaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdcategoriasBS
        '
        Me.ProdcategoriasBS.DataMember = "prodcategorias"
        Me.ProdcategoriasBS.DataSource = Me.EsteticaDataset
        '
        'ProdcategoriasTA
        '
        Me.ProdcategoriasTA.ClearBeforeFill = True
        '
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'profesional_txt
        '
        Me.profesional_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.profesional_txt.Location = New System.Drawing.Point(275, 190)
        Me.profesional_txt.Name = "profesional_txt"
        Me.profesional_txt.Size = New System.Drawing.Size(150, 33)
        Me.profesional_txt.TabIndex = 3
        Me.profesional_txt.Text = "0"
        Me.ttConsejo.SetToolTip(Me.profesional_txt, "Introducir precio profesional")
        '
        'categoria_cb
        '
        Me.categoria_cb.DataSource = Me.ProdcategoriasBS
        Me.categoria_cb.DisplayMember = "Categoria"
        Me.categoria_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categoria_cb.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.categoria_cb.FormattingEnabled = True
        Me.categoria_cb.Location = New System.Drawing.Point(160, 40)
        Me.categoria_cb.Name = "categoria_cb"
        Me.categoria_cb.Size = New System.Drawing.Size(300, 33)
        Me.categoria_cb.TabIndex = 7
        Me.ttConsejo.SetToolTip(Me.categoria_cb, "Escoger Categoría")
        Me.categoria_cb.ValueMember = "Categoria"
        '
        'categoria_bt
        '
        Me.categoria_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.categoria_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.categoria_bt.Image = Global.Estetica.My.Resources.Resources.nuevo64
        Me.categoria_bt.Location = New System.Drawing.Point(466, 20)
        Me.categoria_bt.Name = "categoria_bt"
        Me.categoria_bt.Size = New System.Drawing.Size(70, 70)
        Me.categoria_bt.TabIndex = 10
        Me.ttConsejo.SetToolTip(Me.categoria_bt, "Añadir nueva categoría")
        Me.categoria_bt.UseVisualStyleBackColor = False
        '
        'publico_txt
        '
        Me.publico_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.publico_txt.Location = New System.Drawing.Point(749, 190)
        Me.publico_txt.Name = "publico_txt"
        Me.publico_txt.Size = New System.Drawing.Size(150, 33)
        Me.publico_txt.TabIndex = 4
        Me.publico_txt.Text = "0"
        Me.ttConsejo.SetToolTip(Me.publico_txt, "Introducir precio público")
        '
        'cantidad_txt
        '
        Me.cantidad_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.cantidad_txt.Location = New System.Drawing.Point(275, 240)
        Me.cantidad_txt.Name = "cantidad_txt"
        Me.cantidad_txt.Size = New System.Drawing.Size(150, 33)
        Me.cantidad_txt.TabIndex = 5
        Me.cantidad_txt.Text = "0"
        Me.ttConsejo.SetToolTip(Me.cantidad_txt, "Introduce la cantidad")
        '
        'stock_txt
        '
        Me.stock_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.stock_txt.Location = New System.Drawing.Point(749, 240)
        Me.stock_txt.Name = "stock_txt"
        Me.stock_txt.Size = New System.Drawing.Size(150, 33)
        Me.stock_txt.TabIndex = 6
        Me.stock_txt.Text = "0"
        Me.ttConsejo.SetToolTip(Me.stock_txt, "Introduce el stock mínimo")
        '
        'proveedor_bt
        '
        Me.proveedor_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.proveedor_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.proveedor_bt.Image = Global.Estetica.My.Resources.Resources.nuevo64
        Me.proveedor_bt.Location = New System.Drawing.Point(1044, 20)
        Me.proveedor_bt.Name = "proveedor_bt"
        Me.proveedor_bt.Size = New System.Drawing.Size(70, 70)
        Me.proveedor_bt.TabIndex = 11
        Me.ttConsejo.SetToolTip(Me.proveedor_bt, "Añadir nuevo proveedor")
        Me.proveedor_bt.UseVisualStyleBackColor = False
        '
        'proveedor_cb
        '
        Me.proveedor_cb.DataSource = Me.ProveedoresBS
        Me.proveedor_cb.DisplayMember = "Nombre"
        Me.proveedor_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.proveedor_cb.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.proveedor_cb.FormattingEnabled = True
        Me.proveedor_cb.Location = New System.Drawing.Point(687, 40)
        Me.proveedor_cb.Name = "proveedor_cb"
        Me.proveedor_cb.Size = New System.Drawing.Size(351, 33)
        Me.proveedor_cb.TabIndex = 8
        Me.ttConsejo.SetToolTip(Me.proveedor_cb, "Escoger proveedor")
        Me.proveedor_cb.ValueMember = "CodProveedor"
        '
        'ProveedoresBS
        '
        Me.ProveedoresBS.DataMember = "proveedores"
        Me.ProveedoresBS.DataSource = Me.EsteticaDataset
        '
        'articulo_txt
        '
        Me.articulo_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.articulo_txt.Location = New System.Drawing.Point(485, 90)
        Me.articulo_txt.Name = "articulo_txt"
        Me.articulo_txt.Size = New System.Drawing.Size(629, 33)
        Me.articulo_txt.TabIndex = 1
        Me.ttConsejo.SetToolTip(Me.articulo_txt, "Introducir el artículo")
        '
        'codigo_txt
        '
        Me.codigo_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.codigo_txt.Location = New System.Drawing.Point(121, 90)
        Me.codigo_txt.Name = "codigo_txt"
        Me.codigo_txt.Size = New System.Drawing.Size(219, 33)
        Me.codigo_txt.TabIndex = 0
        Me.ttConsejo.SetToolTip(Me.codigo_txt, "Introducir el código")
        '
        'descripcion_txt
        '
        Me.descripcion_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.descripcion_txt.Location = New System.Drawing.Point(183, 140)
        Me.descripcion_txt.Name = "descripcion_txt"
        Me.descripcion_txt.Size = New System.Drawing.Size(716, 33)
        Me.descripcion_txt.TabIndex = 2
        Me.ttConsejo.SetToolTip(Me.descripcion_txt, "Introducir la descripción")
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(346, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 30)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "ARTÍCULO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(6, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 30)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "PRECIO PROFESIONAL:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(542, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 30)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "PROVEEDOR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(6, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 30)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "CANTIDAD:"
        '
        'guardar_bt
        '
        Me.guardar_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.guardar_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.guardar128
        Me.guardar_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.guardar_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.guardar_bt.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.guardar_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.guardar_bt.Location = New System.Drawing.Point(905, 127)
        Me.guardar_bt.Name = "guardar_bt"
        Me.guardar_bt.Size = New System.Drawing.Size(209, 151)
        Me.guardar_bt.TabIndex = 9
        Me.guardar_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardar_bt.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(542, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 30)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "STOCK MÍNIMO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(542, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 30)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "PRECIO PÚBLICO:"
        '
        'datos_gb
        '
        Me.datos_gb.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.datos_gb.Controls.Add(Me.descripcion_txt)
        Me.datos_gb.Controls.Add(Me.Label9)
        Me.datos_gb.Controls.Add(Me.codigo_txt)
        Me.datos_gb.Controls.Add(Me.Label8)
        Me.datos_gb.Controls.Add(Me.proveedor_bt)
        Me.datos_gb.Controls.Add(Me.stock_txt)
        Me.datos_gb.Controls.Add(Me.cantidad_txt)
        Me.datos_gb.Controls.Add(Me.publico_txt)
        Me.datos_gb.Controls.Add(Me.categoria_bt)
        Me.datos_gb.Controls.Add(Me.articulo_txt)
        Me.datos_gb.Controls.Add(Me.Label7)
        Me.datos_gb.Controls.Add(Me.Label6)
        Me.datos_gb.Controls.Add(Me.guardar_bt)
        Me.datos_gb.Controls.Add(Me.Label5)
        Me.datos_gb.Controls.Add(Me.Label4)
        Me.datos_gb.Controls.Add(Me.Label3)
        Me.datos_gb.Controls.Add(Me.profesional_txt)
        Me.datos_gb.Controls.Add(Me.Label2)
        Me.datos_gb.Controls.Add(Me.Label1)
        Me.datos_gb.Controls.Add(Me.proveedor_cb)
        Me.datos_gb.Controls.Add(Me.categoria_cb)
        Me.datos_gb.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.datos_gb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datos_gb.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.datos_gb.Location = New System.Drawing.Point(150, 33)
        Me.datos_gb.Name = "datos_gb"
        Me.datos_gb.Size = New System.Drawing.Size(1274, 288)
        Me.datos_gb.TabIndex = 0
        Me.datos_gb.TabStop = False
        Me.datos_gb.Text = "INTRODUCIR DATOS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(6, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 30)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "DESCRIPCIÓN:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(6, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 30)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "CÓDIGO:"
        '
        'ProveedoresTA
        '
        Me.ProveedoresTA.ClearBeforeFill = True
        '
        'ProductosBS
        '
        Me.ProductosBS.DataMember = "productos"
        Me.ProductosBS.DataSource = Me.EsteticaDataset
        '
        'ProductosTA
        '
        Me.ProductosTA.ClearBeforeFill = True
        '
        'Producto_Nuevo_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Estetica.My.MySettings.Default.Fondo
        Me.ClientSize = New System.Drawing.Size(1424, 321)
        Me.Controls.Add(Me.salir_bt)
        Me.Controls.Add(Me.datos_gb)
        Me.Controls.Add(Me.volver_bt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Fondo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Producto_Nuevo_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NUEVO PRODUCTO"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdcategoriasBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.datos_gb.ResumeLayout(False)
        Me.datos_gb.PerformLayout()
        CType(Me.ProductosBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents volver_bt As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents hora_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fecha_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents salir_bt As System.Windows.Forms.Button
    Friend WithEvents EsteticaDataset As Estetica.EsteticaDataset
    Friend WithEvents ProdcategoriasBS As System.Windows.Forms.BindingSource
    Friend WithEvents ProdcategoriasTA As Estetica.EsteticaDatasetTableAdapters.prodcategoriasTableAdapter
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents profesional_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents guardar_bt As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents articulo_txt As System.Windows.Forms.TextBox
    Friend WithEvents categoria_cb As System.Windows.Forms.ComboBox
    Friend WithEvents categoria_bt As System.Windows.Forms.Button
    Friend WithEvents publico_txt As System.Windows.Forms.TextBox
    Friend WithEvents cantidad_txt As System.Windows.Forms.TextBox
    Friend WithEvents stock_txt As System.Windows.Forms.TextBox
    Friend WithEvents proveedor_bt As System.Windows.Forms.Button
    Friend WithEvents datos_gb As System.Windows.Forms.GroupBox
    Friend WithEvents proveedor_cb As System.Windows.Forms.ComboBox
    Friend WithEvents ProveedoresBS As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTA As Estetica.EsteticaDatasetTableAdapters.proveedoresTableAdapter
    Friend WithEvents ProductosBS As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTA As Estetica.EsteticaDatasetTableAdapters.productosTableAdapter
    Friend WithEvents codigo_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents descripcion_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
