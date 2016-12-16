<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedor_Historial_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedor_Historial_frm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.hora_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.fecha_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        Me.volver_bt = New System.Windows.Forms.Button
        Me.salir_bt = New System.Windows.Forms.Button
        Me.borrar_bt = New System.Windows.Forms.Button
        Me.editar_bt = New System.Windows.Forms.Button
        Me.guardar_bt = New System.Windows.Forms.Button
        Me.direccion_txt = New System.Windows.Forms.TextBox
        Me.ProveedoresBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.EsteticaDataset = New Estetica.EsteticaDataset
        Me.telefono_txt = New System.Windows.Forms.TextBox
        Me.nombre_txt = New System.Windows.Forms.TextBox
        Me.correo_txt = New System.Windows.Forms.TextBox
        Me.comercial_txt = New System.Windows.Forms.TextBox
        Me.tlfcomercial_txt = New System.Windows.Forms.TextBox
        Me.proveedores_bn = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.productos_gb = New System.Windows.Forms.GroupBox
        Me.productos_dgv = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductosBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.productos_bn = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.proveedor_bt = New System.Windows.Forms.ToolStripButton
        Me.stock_bt = New System.Windows.Forms.ToolStripButton
        Me.ProductosTA = New Estetica.EsteticaDatasetTableAdapters.productosTableAdapter
        Me.TableAdapterManager = New Estetica.EsteticaDatasetTableAdapters.TableAdapterManager
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.datos_gb = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProveedoresTA = New Estetica.EsteticaDatasetTableAdapters.proveedoresTableAdapter
        Me.NombreProveBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreProveTA = New Estetica.EsteticaDatasetTableAdapters.NombreProveTableAdapter
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ProveedoresBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.proveedores_bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.proveedores_bn.SuspendLayout()
        Me.productos_gb.SuspendLayout()
        CType(Me.productos_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productos_bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.productos_bn.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.datos_gb.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NombreProveBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MenuStrip1.TabIndex = 97
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.volver_bt.Location = New System.Drawing.Point(0, 212)
        Me.volver_bt.Name = "volver_bt"
        Me.volver_bt.Size = New System.Drawing.Size(150, 750)
        Me.volver_bt.TabIndex = 121
        Me.volver_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttConsejo.SetToolTip(Me.volver_bt, "Volver")
        Me.volver_bt.UseVisualStyleBackColor = False
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
        Me.salir_bt.Location = New System.Drawing.Point(1634, 212)
        Me.salir_bt.Name = "salir_bt"
        Me.salir_bt.Size = New System.Drawing.Size(150, 750)
        Me.salir_bt.TabIndex = 120
        Me.salir_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salir_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ttConsejo.SetToolTip(Me.salir_bt, "Salir del programa")
        Me.salir_bt.UseVisualStyleBackColor = False
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
        Me.ttConsejo.SetToolTip(Me.borrar_bt, "Borrar ficha proveedor")
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
        Me.ttConsejo.SetToolTip(Me.editar_bt, "Editar ficha proveedor")
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
        Me.ttConsejo.SetToolTip(Me.guardar_bt, "Guardar ficha proveedor")
        Me.guardar_bt.UseVisualStyleBackColor = False
        '
        'direccion_txt
        '
        Me.direccion_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBS, "Direccion", True))
        Me.direccion_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.direccion_txt.Location = New System.Drawing.Point(157, 90)
        Me.direccion_txt.Name = "direccion_txt"
        Me.direccion_txt.Size = New System.Drawing.Size(581, 33)
        Me.direccion_txt.TabIndex = 1
        Me.ttConsejo.SetToolTip(Me.direccion_txt, "Introduce la dirección")
        '
        'ProveedoresBS
        '
        Me.ProveedoresBS.DataMember = "proveedores"
        Me.ProveedoresBS.DataSource = Me.EsteticaDataset
        '
        'EsteticaDataset
        '
        Me.EsteticaDataset.DataSetName = "EsteticaDataset"
        Me.EsteticaDataset.EnforceConstraints = False
        Me.EsteticaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'telefono_txt
        '
        Me.telefono_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBS, "TlfEmpresa", True))
        Me.telefono_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.telefono_txt.Location = New System.Drawing.Point(889, 90)
        Me.telefono_txt.Name = "telefono_txt"
        Me.telefono_txt.Size = New System.Drawing.Size(138, 33)
        Me.telefono_txt.TabIndex = 3
        Me.ttConsejo.SetToolTip(Me.telefono_txt, "Introduce el número de teléfono")
        '
        'nombre_txt
        '
        Me.nombre_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBS, "Nombre", True))
        Me.nombre_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.nombre_txt.Location = New System.Drawing.Point(126, 40)
        Me.nombre_txt.Name = "nombre_txt"
        Me.nombre_txt.Size = New System.Drawing.Size(501, 33)
        Me.nombre_txt.TabIndex = 0
        Me.ttConsejo.SetToolTip(Me.nombre_txt, "Introduce el nombre")
        '
        'correo_txt
        '
        Me.correo_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBS, "Email", True))
        Me.correo_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.correo_txt.Location = New System.Drawing.Point(744, 40)
        Me.correo_txt.Name = "correo_txt"
        Me.correo_txt.Size = New System.Drawing.Size(283, 33)
        Me.correo_txt.TabIndex = 109
        Me.ttConsejo.SetToolTip(Me.correo_txt, "Introduce el correo")
        '
        'comercial_txt
        '
        Me.comercial_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBS, "NombreComercial", True))
        Me.comercial_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.comercial_txt.Location = New System.Drawing.Point(157, 12)
        Me.comercial_txt.Name = "comercial_txt"
        Me.comercial_txt.Size = New System.Drawing.Size(243, 33)
        Me.comercial_txt.TabIndex = 128
        Me.ttConsejo.SetToolTip(Me.comercial_txt, "Introduce el número de teléfono")
        '
        'tlfcomercial_txt
        '
        Me.tlfcomercial_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBS, "TlfComercial", True))
        Me.tlfcomercial_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.tlfcomercial_txt.Location = New System.Drawing.Point(157, 60)
        Me.tlfcomercial_txt.Name = "tlfcomercial_txt"
        Me.tlfcomercial_txt.Size = New System.Drawing.Size(243, 33)
        Me.tlfcomercial_txt.TabIndex = 130
        Me.ttConsejo.SetToolTip(Me.tlfcomercial_txt, "Introduce el número de teléfono")
        '
        'proveedores_bn
        '
        Me.proveedores_bn.AddNewItem = Nothing
        Me.proveedores_bn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.proveedores_bn.BindingSource = Me.ProveedoresBS
        Me.proveedores_bn.CountItem = Me.BindingNavigatorCountItem
        Me.proveedores_bn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.proveedores_bn.DeleteItem = Nothing
        Me.proveedores_bn.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.proveedores_bn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.proveedores_bn.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.proveedores_bn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ultimo_bt, Me.adelante_bt, Me.BindingNavigatorSeparator2, Me.BindingNavigatorCountItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorSeparator3, Me.atras_bt, Me.primero_bt, Me.ToolStripTextBox1, Me.ToolStripSeparator1, Me.nombre_ts, Me.buscanombre_bt})
        Me.proveedores_bn.Location = New System.Drawing.Point(0, 33)
        Me.proveedores_bn.MoveFirstItem = Me.primero_bt
        Me.proveedores_bn.MoveLastItem = Me.ultimo_bt
        Me.proveedores_bn.MoveNextItem = Me.adelante_bt
        Me.proveedores_bn.MovePreviousItem = Me.atras_bt
        Me.proveedores_bn.Name = "proveedores_bn"
        Me.proveedores_bn.PositionItem = Me.BindingNavigatorPositionItem
        Me.proveedores_bn.Size = New System.Drawing.Size(1784, 52)
        Me.proveedores_bn.Stretch = True
        Me.proveedores_bn.TabIndex = 124
        Me.proveedores_bn.Text = "BindingNavigator1"
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
        Me.ToolStripTextBox1.Text = "NOMBRE:"
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
        Me.nombre_ts.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'productos_gb
        '
        Me.productos_gb.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.productos_gb.Controls.Add(Me.productos_dgv)
        Me.productos_gb.Controls.Add(Me.productos_bn)
        Me.productos_gb.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.productos_gb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.productos_gb.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.productos_gb.Location = New System.Drawing.Point(150, 212)
        Me.productos_gb.Name = "productos_gb"
        Me.productos_gb.Size = New System.Drawing.Size(1484, 750)
        Me.productos_gb.TabIndex = 125
        Me.productos_gb.TabStop = False
        Me.productos_gb.Text = "PRODUCTOS"
        '
        'productos_dgv
        '
        Me.productos_dgv.AllowUserToAddRows = False
        Me.productos_dgv.AllowUserToDeleteRows = False
        Me.productos_dgv.AutoGenerateColumns = False
        Me.productos_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.productos_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.productos_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.productos_dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.productos_dgv.DataSource = Me.ProductosBS
        Me.productos_dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.productos_dgv.Location = New System.Drawing.Point(3, 89)
        Me.productos_dgv.Name = "productos_dgv"
        Me.productos_dgv.ReadOnly = True
        Me.productos_dgv.Size = New System.Drawing.Size(1478, 658)
        Me.productos_dgv.TabIndex = 121
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodProducto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodProducto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Categoría"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PrecioProfesional"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio Profesional"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PrecioPublico"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Precio Público"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "StockMinimo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Stock Mínimo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'ProductosBS
        '
        Me.ProductosBS.DataMember = "productos"
        Me.ProductosBS.DataSource = Me.EsteticaDataset
        '
        'productos_bn
        '
        Me.productos_bn.AddNewItem = Nothing
        Me.productos_bn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.productos_bn.BindingSource = Me.ProductosBS
        Me.productos_bn.CountItem = Me.ToolStripLabel1
        Me.productos_bn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.productos_bn.DeleteItem = Nothing
        Me.productos_bn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.productos_bn.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.productos_bn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.ToolStripTextBox5, Me.ToolStripSeparator6, Me.ToolStripButton3, Me.ToolStripButton4, Me.proveedor_bt, Me.stock_bt})
        Me.productos_bn.Location = New System.Drawing.Point(3, 37)
        Me.productos_bn.MoveFirstItem = Me.ToolStripButton4
        Me.productos_bn.MoveLastItem = Me.ToolStripButton1
        Me.productos_bn.MoveNextItem = Me.ToolStripButton2
        Me.productos_bn.MovePreviousItem = Me.ToolStripButton3
        Me.productos_bn.Name = "productos_bn"
        Me.productos_bn.PositionItem = Me.ToolStripTextBox5
        Me.productos_bn.Size = New System.Drawing.Size(1478, 52)
        Me.productos_bn.Stretch = True
        Me.productos_bn.TabIndex = 121
        Me.productos_bn.Text = "BindingNavigator3"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(84, 49)
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
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 49)
        Me.ToolStripButton1.Text = "Mover último"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Estetica.My.Resources.Resources.adelante
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(49, 49)
        Me.ToolStripButton2.Text = "Mover siguiente"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 52)
        '
        'ToolStripTextBox5
        '
        Me.ToolStripTextBox5.AccessibleName = "Posición"
        Me.ToolStripTextBox5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox5.AutoSize = False
        Me.ToolStripTextBox5.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.ToolStripTextBox5.Name = "ToolStripTextBox5"
        Me.ToolStripTextBox5.Size = New System.Drawing.Size(50, 33)
        Me.ToolStripTextBox5.Text = "0"
        Me.ToolStripTextBox5.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 52)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.Estetica.My.Resources.Resources.atras
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(49, 49)
        Me.ToolStripButton3.Text = "Mover anterior"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.Estetica.My.Resources.Resources.primero
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(49, 49)
        Me.ToolStripButton4.Text = "Mover primero"
        '
        'proveedor_bt
        '
        Me.proveedor_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.proveedor_bt.Image = Global.Estetica.My.Resources.Resources.informe64
        Me.proveedor_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.proveedor_bt.Name = "proveedor_bt"
        Me.proveedor_bt.Size = New System.Drawing.Size(49, 49)
        Me.proveedor_bt.Text = "Informe Stock por Proveedor"
        Me.proveedor_bt.ToolTipText = "Informe Stock del Proveedor"
        '
        'stock_bt
        '
        Me.stock_bt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.stock_bt.Image = Global.Estetica.My.Resources.Resources.stock128
        Me.stock_bt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stock_bt.Name = "stock_bt"
        Me.stock_bt.Size = New System.Drawing.Size(49, 49)
        Me.stock_bt.Text = "Informe Stock Total"
        '
        'ProductosTA
        '
        Me.ProductosTA.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bonosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.contraseñaTableAdapter = Nothing
        Me.TableAdapterManager.dependientasTableAdapter = Nothing
        Me.TableAdapterManager.prodcategoriasTableAdapter = Nothing
        Me.TableAdapterManager.productos1TableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Me.ProductosTA
        Me.TableAdapterManager.prodventaTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.tratamientosTableAdapter = Nothing
        Me.TableAdapterManager.tratcategoriasTableAdapter = Nothing
        Me.TableAdapterManager.tratventaTableAdapter = Nothing
        Me.TableAdapterManager.turnosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Estetica.EsteticaDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.borrar_bt)
        Me.Panel1.Controls.Add(Me.editar_bt)
        Me.Panel1.Controls.Add(Me.guardar_bt)
        Me.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel1.Location = New System.Drawing.Point(1456, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 100)
        Me.Panel1.TabIndex = 127
        '
        'datos_gb
        '
        Me.datos_gb.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.datos_gb.Controls.Add(Me.Panel2)
        Me.datos_gb.Controls.Add(Me.Panel1)
        Me.datos_gb.Controls.Add(Me.correo_txt)
        Me.datos_gb.Controls.Add(Me.direccion_txt)
        Me.datos_gb.Controls.Add(Me.Label4)
        Me.datos_gb.Controls.Add(Me.Label3)
        Me.datos_gb.Controls.Add(Me.telefono_txt)
        Me.datos_gb.Controls.Add(Me.Label2)
        Me.datos_gb.Controls.Add(Me.nombre_txt)
        Me.datos_gb.Controls.Add(Me.Label1)
        Me.datos_gb.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.datos_gb.Dock = System.Windows.Forms.DockStyle.Top
        Me.datos_gb.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.datos_gb.Location = New System.Drawing.Point(0, 85)
        Me.datos_gb.Name = "datos_gb"
        Me.datos_gb.Size = New System.Drawing.Size(1784, 127)
        Me.datos_gb.TabIndex = 126
        Me.datos_gb.TabStop = False
        Me.datos_gb.Text = "PROVEEDORES"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.tlfcomercial_txt)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.comercial_txt)
        Me.Panel2.Location = New System.Drawing.Point(1033, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(417, 100)
        Me.Panel2.TabIndex = 132
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(3, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 30)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "TELÉFONO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(3, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 30)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "COMERCIAL:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 30)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "DIRECCIÓN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(744, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 30)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "TELÉFONO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(633, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 30)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "E-MAIL:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 30)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "NOMBRE:"
        '
        'ProveedoresTA
        '
        Me.ProveedoresTA.ClearBeforeFill = True
        '
        'NombreProveBS
        '
        Me.NombreProveBS.DataMember = "NombreProve"
        Me.NombreProveBS.DataSource = Me.EsteticaDataset
        '
        'NombreProveTA
        '
        Me.NombreProveTA.ClearBeforeFill = True
        '
        'Proveedor_Historial_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Estetica.My.MySettings.Default.Fondo
        Me.ClientSize = New System.Drawing.Size(1784, 962)
        Me.Controls.Add(Me.productos_gb)
        Me.Controls.Add(Me.salir_bt)
        Me.Controls.Add(Me.volver_bt)
        Me.Controls.Add(Me.datos_gb)
        Me.Controls.Add(Me.proveedores_bn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Fondo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Proveedor_Historial_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HISTORIAL DE PROVEEDORES"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ProveedoresBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.proveedores_bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.proveedores_bn.ResumeLayout(False)
        Me.proveedores_bn.PerformLayout()
        Me.productos_gb.ResumeLayout(False)
        Me.productos_gb.PerformLayout()
        CType(Me.productos_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productos_bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.productos_bn.ResumeLayout(False)
        Me.productos_bn.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.datos_gb.ResumeLayout(False)
        Me.datos_gb.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NombreProveBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents hora_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fecha_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip
    Friend WithEvents proveedores_bn As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents volver_bt As System.Windows.Forms.Button
    Friend WithEvents salir_bt As System.Windows.Forms.Button
    Friend WithEvents productos_gb As System.Windows.Forms.GroupBox
    Friend WithEvents productos_bn As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents EsteticaDataset As Estetica.EsteticaDataset
    Friend WithEvents ProductosBS As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTA As Estetica.EsteticaDatasetTableAdapters.productosTableAdapter
    Friend WithEvents TableAdapterManager As Estetica.EsteticaDatasetTableAdapters.TableAdapterManager
    Friend WithEvents productos_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents borrar_bt As System.Windows.Forms.Button
    Friend WithEvents editar_bt As System.Windows.Forms.Button
    Friend WithEvents guardar_bt As System.Windows.Forms.Button
    Friend WithEvents datos_gb As System.Windows.Forms.GroupBox
    Friend WithEvents direccion_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents telefono_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombre_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents correo_txt As System.Windows.Forms.TextBox
    Friend WithEvents ProveedoresBS As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTA As Estetica.EsteticaDatasetTableAdapters.proveedoresTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreProveBS As System.Windows.Forms.BindingSource
    Friend WithEvents NombreProveTA As Estetica.EsteticaDatasetTableAdapters.NombreProveTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tlfcomercial_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents comercial_txt As System.Windows.Forms.TextBox
    Friend WithEvents proveedor_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents stock_bt As System.Windows.Forms.ToolStripButton
End Class
