<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dependienta_Historial_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dependienta_Historial_frm))
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
        Me.fecha_dtp = New System.Windows.Forms.DateTimePicker
        Me.DependientasBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.EsteticaDataset = New Estetica.EsteticaDataset
        Me.apellidos_txt = New System.Windows.Forms.TextBox
        Me.fijo_txt = New System.Windows.Forms.TextBox
        Me.nombre_txt = New System.Windows.Forms.TextBox
        Me.movil_txt = New System.Windows.Forms.TextBox
        Me.dependientas_bn = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.datos_gb = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dependientas_tc = New System.Windows.Forms.TabControl
        Me.ventas_tp = New System.Windows.Forms.TabPage
        Me.ventas_dgv = New System.Windows.Forms.DataGridView
        Me.CodVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VentasBS = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.horarios_tp = New System.Windows.Forms.TabPage
        Me.horarios_dgv = New System.Windows.Forms.DataGridView
        Me.CodTurnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaFinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DuracionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TurnosBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.horarios_bn = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.VentasTA = New Estetica.EsteticaDatasetTableAdapters.ventasTableAdapter
        Me.TurnosTA = New Estetica.EsteticaDatasetTableAdapters.turnosTableAdapter
        Me.DependientasTA = New Estetica.EsteticaDatasetTableAdapters.dependientasTableAdapter
        Me.NombreDtaBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreDtaTA = New Estetica.EsteticaDatasetTableAdapters.nombreDtaTableAdapter
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DependientasBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dependientas_bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dependientas_bn.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.datos_gb.SuspendLayout()
        Me.dependientas_tc.SuspendLayout()
        Me.ventas_tp.SuspendLayout()
        CType(Me.ventas_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ventas_bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ventas_bn.SuspendLayout()
        Me.horarios_tp.SuspendLayout()
        CType(Me.horarios_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnosBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horarios_bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.horarios_bn.SuspendLayout()
        CType(Me.NombreDtaBS, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.volver_bt.Location = New System.Drawing.Point(0, 212)
        Me.volver_bt.Name = "volver_bt"
        Me.volver_bt.Size = New System.Drawing.Size(150, 750)
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
        Me.salir_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.salir128
        Me.salir_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.salir_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.salir_bt.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.salir_bt.Dock = System.Windows.Forms.DockStyle.Right
        Me.salir_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.salir_bt.Location = New System.Drawing.Point(1634, 212)
        Me.salir_bt.Name = "salir_bt"
        Me.salir_bt.Size = New System.Drawing.Size(150, 750)
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
        Me.ttConsejo.SetToolTip(Me.borrar_bt, "Borrar ficha dependienta")
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
        Me.ttConsejo.SetToolTip(Me.editar_bt, "Editar ficha dependienta")
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
        Me.ttConsejo.SetToolTip(Me.guardar_bt, "Guardar ficha dependienta")
        Me.guardar_bt.UseVisualStyleBackColor = False
        '
        'fecha_dtp
        '
        Me.fecha_dtp.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DependientasBS, "FechaNacimiento", True))
        Me.fecha_dtp.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.fecha_dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_dtp.Location = New System.Drawing.Point(1102, 40)
        Me.fecha_dtp.Name = "fecha_dtp"
        Me.fecha_dtp.Size = New System.Drawing.Size(162, 33)
        Me.fecha_dtp.TabIndex = 2
        Me.ttConsejo.SetToolTip(Me.fecha_dtp, "Escoge la fecha de nacimiento")
        '
        'DependientasBS
        '
        Me.DependientasBS.DataMember = "dependientas"
        Me.DependientasBS.DataSource = Me.EsteticaDataset
        '
        'EsteticaDataset
        '
        Me.EsteticaDataset.DataSetName = "EsteticaDataset"
        Me.EsteticaDataset.EnforceConstraints = False
        Me.EsteticaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'apellidos_txt
        '
        Me.apellidos_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DependientasBS, "Apellidos", True))
        Me.apellidos_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.apellidos_txt.Location = New System.Drawing.Point(155, 90)
        Me.apellidos_txt.Name = "apellidos_txt"
        Me.apellidos_txt.Size = New System.Drawing.Size(578, 33)
        Me.apellidos_txt.TabIndex = 1
        Me.ttConsejo.SetToolTip(Me.apellidos_txt, "Introduce los apellidos")
        '
        'fijo_txt
        '
        Me.fijo_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DependientasBS, "Fijo", True))
        Me.fijo_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.fijo_txt.Location = New System.Drawing.Point(892, 90)
        Me.fijo_txt.Name = "fijo_txt"
        Me.fijo_txt.Size = New System.Drawing.Size(111, 33)
        Me.fijo_txt.TabIndex = 3
        Me.ttConsejo.SetToolTip(Me.fijo_txt, "Introduce el número de teléfono")
        '
        'nombre_txt
        '
        Me.nombre_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DependientasBS, "Nombre", True))
        Me.nombre_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.nombre_txt.Location = New System.Drawing.Point(126, 40)
        Me.nombre_txt.Name = "nombre_txt"
        Me.nombre_txt.Size = New System.Drawing.Size(607, 33)
        Me.nombre_txt.TabIndex = 0
        Me.ttConsejo.SetToolTip(Me.nombre_txt, "Introduce el nombre")
        '
        'movil_txt
        '
        Me.movil_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DependientasBS, "Movil", True))
        Me.movil_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.movil_txt.Location = New System.Drawing.Point(1301, 90)
        Me.movil_txt.Name = "movil_txt"
        Me.movil_txt.Size = New System.Drawing.Size(111, 33)
        Me.movil_txt.TabIndex = 122
        Me.ttConsejo.SetToolTip(Me.movil_txt, "Introduce el número de teléfono")
        '
        'dependientas_bn
        '
        Me.dependientas_bn.AddNewItem = Nothing
        Me.dependientas_bn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.dependientas_bn.BindingSource = Me.DependientasBS
        Me.dependientas_bn.CountItem = Me.BindingNavigatorCountItem
        Me.dependientas_bn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dependientas_bn.DeleteItem = Nothing
        Me.dependientas_bn.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.dependientas_bn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.dependientas_bn.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.dependientas_bn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ultimo_bt, Me.adelante_bt, Me.BindingNavigatorSeparator2, Me.BindingNavigatorCountItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorSeparator3, Me.atras_bt, Me.primero_bt, Me.ToolStripTextBox1, Me.ToolStripSeparator1, Me.nombre_ts, Me.buscanombre_bt})
        Me.dependientas_bn.Location = New System.Drawing.Point(0, 33)
        Me.dependientas_bn.MoveFirstItem = Me.primero_bt
        Me.dependientas_bn.MoveLastItem = Me.ultimo_bt
        Me.dependientas_bn.MoveNextItem = Me.adelante_bt
        Me.dependientas_bn.MovePreviousItem = Me.atras_bt
        Me.dependientas_bn.Name = "dependientas_bn"
        Me.dependientas_bn.PositionItem = Me.BindingNavigatorPositionItem
        Me.dependientas_bn.Size = New System.Drawing.Size(1784, 52)
        Me.dependientas_bn.Stretch = True
        Me.dependientas_bn.TabIndex = 122
        Me.dependientas_bn.Text = "BindingNavigator1"
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
        'Panel1
        '
        Me.Panel1.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.borrar_bt)
        Me.Panel1.Controls.Add(Me.editar_bt)
        Me.Panel1.Controls.Add(Me.guardar_bt)
        Me.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel1.Location = New System.Drawing.Point(1450, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 100)
        Me.Panel1.TabIndex = 121
        '
        'datos_gb
        '
        Me.datos_gb.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.datos_gb.Controls.Add(Me.Label5)
        Me.datos_gb.Controls.Add(Me.movil_txt)
        Me.datos_gb.Controls.Add(Me.fecha_dtp)
        Me.datos_gb.Controls.Add(Me.apellidos_txt)
        Me.datos_gb.Controls.Add(Me.Label4)
        Me.datos_gb.Controls.Add(Me.Panel1)
        Me.datos_gb.Controls.Add(Me.Label3)
        Me.datos_gb.Controls.Add(Me.fijo_txt)
        Me.datos_gb.Controls.Add(Me.Label2)
        Me.datos_gb.Controls.Add(Me.nombre_txt)
        Me.datos_gb.Controls.Add(Me.Label1)
        Me.datos_gb.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.datos_gb.Dock = System.Windows.Forms.DockStyle.Top
        Me.datos_gb.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.datos_gb.Location = New System.Drawing.Point(0, 85)
        Me.datos_gb.Name = "datos_gb"
        Me.datos_gb.Size = New System.Drawing.Size(1784, 127)
        Me.datos_gb.TabIndex = 120
        Me.datos_gb.TabStop = False
        Me.datos_gb.Text = "DEPENDIENTAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(1200, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 30)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "MÓVIL:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 30)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "APELLIDOS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(810, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 30)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "FIJO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(810, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 30)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "FECHA DE NACIMIENTO:"
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
        'dependientas_tc
        '
        Me.dependientas_tc.Controls.Add(Me.ventas_tp)
        Me.dependientas_tc.Controls.Add(Me.horarios_tp)
        Me.dependientas_tc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dependientas_tc.ImageList = Me.ImageList1
        Me.dependientas_tc.Location = New System.Drawing.Point(150, 212)
        Me.dependientas_tc.Name = "dependientas_tc"
        Me.dependientas_tc.SelectedIndex = 0
        Me.dependientas_tc.Size = New System.Drawing.Size(1484, 750)
        Me.dependientas_tc.TabIndex = 123
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
        Me.ventas_tp.Size = New System.Drawing.Size(1476, 679)
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
        Me.ventas_dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodVentaDataGridViewTextBoxColumn, Me.Cliente, Me.FechaDataGridViewTextBoxColumn, Me.ProductoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.PagoDataGridViewTextBoxColumn})
        Me.ventas_dgv.DataSource = Me.VentasBS
        Me.ventas_dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ventas_dgv.Location = New System.Drawing.Point(3, 55)
        Me.ventas_dgv.Name = "ventas_dgv"
        Me.ventas_dgv.ReadOnly = True
        Me.ventas_dgv.Size = New System.Drawing.Size(1466, 617)
        Me.ventas_dgv.TabIndex = 102
        '
        'CodVentaDataGridViewTextBoxColumn
        '
        Me.CodVentaDataGridViewTextBoxColumn.DataPropertyName = "CodVenta"
        Me.CodVentaDataGridViewTextBoxColumn.HeaderText = "CodVenta"
        Me.CodVentaDataGridViewTextBoxColumn.Name = "CodVentaDataGridViewTextBoxColumn"
        Me.CodVentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodVentaDataGridViewTextBoxColumn.Visible = False
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PagoDataGridViewTextBoxColumn
        '
        Me.PagoDataGridViewTextBoxColumn.DataPropertyName = "Pago"
        Me.PagoDataGridViewTextBoxColumn.HeaderText = "Pago"
        Me.PagoDataGridViewTextBoxColumn.Name = "PagoDataGridViewTextBoxColumn"
        Me.PagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VentasBS
        '
        Me.VentasBS.DataMember = "ventas"
        Me.VentasBS.DataSource = Me.EsteticaDataset
        '
        'ventas_bn
        '
        Me.ventas_bn.AddNewItem = Nothing
        Me.ventas_bn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.ventas_bn.BindingSource = Me.VentasBS
        Me.ventas_bn.CountItem = Me.ToolStripLabel2
        Me.ventas_bn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ventas_bn.DeleteItem = Nothing
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
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Verdana", 15.75!)
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
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Verdana", 15.75!)
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
        'horarios_tp
        '
        Me.horarios_tp.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.horarios_tp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.horarios_tp.Controls.Add(Me.horarios_dgv)
        Me.horarios_tp.Controls.Add(Me.horarios_bn)
        Me.horarios_tp.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.horarios_tp.ImageIndex = 1
        Me.horarios_tp.Location = New System.Drawing.Point(4, 67)
        Me.horarios_tp.Name = "horarios_tp"
        Me.horarios_tp.Padding = New System.Windows.Forms.Padding(3)
        Me.horarios_tp.Size = New System.Drawing.Size(1476, 679)
        Me.horarios_tp.TabIndex = 1
        Me.horarios_tp.Text = "HORARIOS"
        '
        'horarios_dgv
        '
        Me.horarios_dgv.AllowUserToAddRows = False
        Me.horarios_dgv.AllowUserToDeleteRows = False
        Me.horarios_dgv.AutoGenerateColumns = False
        Me.horarios_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.horarios_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.horarios_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.horarios_dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodTurnoDataGridViewTextBoxColumn, Me.FechaInicioDataGridViewTextBoxColumn, Me.FechaFinDataGridViewTextBoxColumn, Me.DuracionDataGridViewTextBoxColumn})
        Me.horarios_dgv.DataSource = Me.TurnosBS
        Me.horarios_dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.horarios_dgv.Location = New System.Drawing.Point(3, 55)
        Me.horarios_dgv.Name = "horarios_dgv"
        Me.horarios_dgv.ReadOnly = True
        Me.horarios_dgv.Size = New System.Drawing.Size(1466, 617)
        Me.horarios_dgv.TabIndex = 0
        '
        'CodTurnoDataGridViewTextBoxColumn
        '
        Me.CodTurnoDataGridViewTextBoxColumn.DataPropertyName = "CodTurno"
        Me.CodTurnoDataGridViewTextBoxColumn.HeaderText = "CodTurno"
        Me.CodTurnoDataGridViewTextBoxColumn.Name = "CodTurnoDataGridViewTextBoxColumn"
        Me.CodTurnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodTurnoDataGridViewTextBoxColumn.Visible = False
        '
        'FechaInicioDataGridViewTextBoxColumn
        '
        Me.FechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio"
        Me.FechaInicioDataGridViewTextBoxColumn.HeaderText = "Inicio"
        Me.FechaInicioDataGridViewTextBoxColumn.Name = "FechaInicioDataGridViewTextBoxColumn"
        Me.FechaInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaFinDataGridViewTextBoxColumn
        '
        Me.FechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin"
        Me.FechaFinDataGridViewTextBoxColumn.HeaderText = "Fin"
        Me.FechaFinDataGridViewTextBoxColumn.Name = "FechaFinDataGridViewTextBoxColumn"
        Me.FechaFinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DuracionDataGridViewTextBoxColumn
        '
        Me.DuracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion"
        Me.DuracionDataGridViewTextBoxColumn.HeaderText = "Duración"
        Me.DuracionDataGridViewTextBoxColumn.Name = "DuracionDataGridViewTextBoxColumn"
        Me.DuracionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TurnosBS
        '
        Me.TurnosBS.DataMember = "turnos"
        Me.TurnosBS.DataSource = Me.EsteticaDataset
        '
        'horarios_bn
        '
        Me.horarios_bn.AddNewItem = Nothing
        Me.horarios_bn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.horarios_bn.BindingSource = Me.TurnosBS
        Me.horarios_bn.CountItem = Me.ToolStripLabel1
        Me.horarios_bn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.horarios_bn.DeleteItem = Nothing
        Me.horarios_bn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.horarios_bn.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.horarios_bn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.ToolStripTextBox5, Me.ToolStripSeparator6, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.horarios_bn.Location = New System.Drawing.Point(3, 3)
        Me.horarios_bn.MoveFirstItem = Me.ToolStripButton4
        Me.horarios_bn.MoveLastItem = Me.ToolStripButton1
        Me.horarios_bn.MoveNextItem = Me.ToolStripButton2
        Me.horarios_bn.MovePreviousItem = Me.ToolStripButton3
        Me.horarios_bn.Name = "horarios_bn"
        Me.horarios_bn.PositionItem = Me.ToolStripTextBox5
        Me.horarios_bn.Size = New System.Drawing.Size(1466, 52)
        Me.horarios_bn.Stretch = True
        Me.horarios_bn.TabIndex = 120
        Me.horarios_bn.Text = "BindingNavigator3"
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
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "venta128.png")
        Me.ImageList1.Images.SetKeyName(1, "turno.png")
        '
        'VentasTA
        '
        Me.VentasTA.ClearBeforeFill = True
        '
        'TurnosTA
        '
        Me.TurnosTA.ClearBeforeFill = True
        '
        'DependientasTA
        '
        Me.DependientasTA.ClearBeforeFill = True
        '
        'NombreDtaBS
        '
        Me.NombreDtaBS.DataMember = "nombreDta"
        Me.NombreDtaBS.DataSource = Me.EsteticaDataset
        '
        'NombreDtaTA
        '
        Me.NombreDtaTA.ClearBeforeFill = True
        '
        'Dependienta_Historial_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Estetica.My.MySettings.Default.Fondo
        Me.ClientSize = New System.Drawing.Size(1784, 962)
        Me.Controls.Add(Me.dependientas_tc)
        Me.Controls.Add(Me.salir_bt)
        Me.Controls.Add(Me.volver_bt)
        Me.Controls.Add(Me.datos_gb)
        Me.Controls.Add(Me.dependientas_bn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Fondo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dependienta_Historial_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HISTORIAL DE LAS DEPENDIENTAS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DependientasBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dependientas_bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dependientas_bn.ResumeLayout(False)
        Me.dependientas_bn.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.datos_gb.ResumeLayout(False)
        Me.datos_gb.PerformLayout()
        Me.dependientas_tc.ResumeLayout(False)
        Me.ventas_tp.ResumeLayout(False)
        Me.ventas_tp.PerformLayout()
        CType(Me.ventas_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ventas_bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ventas_bn.ResumeLayout(False)
        Me.ventas_bn.PerformLayout()
        Me.horarios_tp.ResumeLayout(False)
        Me.horarios_tp.PerformLayout()
        CType(Me.horarios_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnosBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horarios_bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.horarios_bn.ResumeLayout(False)
        Me.horarios_bn.PerformLayout()
        CType(Me.NombreDtaBS, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dependientas_bn As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents borrar_bt As System.Windows.Forms.Button
    Friend WithEvents editar_bt As System.Windows.Forms.Button
    Friend WithEvents guardar_bt As System.Windows.Forms.Button
    Friend WithEvents datos_gb As System.Windows.Forms.GroupBox
    Friend WithEvents fecha_dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents apellidos_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fijo_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombre_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dependientas_tc As System.Windows.Forms.TabControl
    Friend WithEvents ventas_tp As System.Windows.Forms.TabPage
    Friend WithEvents ventas_dgv As System.Windows.Forms.DataGridView
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
    Friend WithEvents horarios_tp As System.Windows.Forms.TabPage
    Friend WithEvents horarios_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents horarios_bn As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents EsteticaDataset As Estetica.EsteticaDataset
    Friend WithEvents VentasBS As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTA As Estetica.EsteticaDatasetTableAdapters.ventasTableAdapter
    Friend WithEvents TurnosBS As System.Windows.Forms.BindingSource
    Friend WithEvents TurnosTA As Estetica.EsteticaDatasetTableAdapters.turnosTableAdapter
    Friend WithEvents DependientasBS As System.Windows.Forms.BindingSource
    Friend WithEvents DependientasTA As Estetica.EsteticaDatasetTableAdapters.dependientasTableAdapter
    Friend WithEvents CodVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDtaBS As System.Windows.Forms.BindingSource
    Friend WithEvents NombreDtaTA As Estetica.EsteticaDatasetTableAdapters.nombreDtaTableAdapter
    Friend WithEvents CodTurnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DuracionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents movil_txt As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
