<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente_Historial_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cliente_Historial_frm))
        Me.volver_bt = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.hora_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.fecha_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.salir_bt = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        Me.fecha_dtp = New System.Windows.Forms.DateTimePicker
        Me.ClientesBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.EsteticaDataset = New Estetica.EsteticaDataset
        Me.observaciones_txt = New System.Windows.Forms.TextBox
        Me.apellidos_txt = New System.Windows.Forms.TextBox
        Me.fijo_txt = New System.Windows.Forms.TextBox
        Me.nombre_txt = New System.Windows.Forms.TextBox
        Me.guardar_bt = New System.Windows.Forms.Button
        Me.editar_bt = New System.Windows.Forms.Button
        Me.borrar_bt = New System.Windows.Forms.Button
        Me.movil_txt = New System.Windows.Forms.TextBox
        Me.email_txt = New System.Windows.Forms.TextBox
        Me.datos_gb = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.clientes_tc = New System.Windows.Forms.TabControl
        Me.ventas_tp = New System.Windows.Forms.TabPage
        Me.ventas_dgv = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dependienta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.sesiones_tp = New System.Windows.Forms.TabPage
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton
        Me.bonos_tp = New System.Windows.Forms.TabPage
        Me.bonos_dgv = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BonosBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.bonos_bn = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.clientes_bn = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TableAdapterManager = New Estetica.EsteticaDatasetTableAdapters.TableAdapterManager
        Me.BonosTA = New Estetica.EsteticaDatasetTableAdapters.bonosTableAdapter
        Me.VentasTA = New Estetica.EsteticaDatasetTableAdapters.ventasTableAdapter
        Me.ClientesTA = New Estetica.EsteticaDatasetTableAdapters.clientesTableAdapter
        Me.NombresBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombresTA = New Estetica.EsteticaDatasetTableAdapters.NombresTableAdapter
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ClientesBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.datos_gb.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.clientes_tc.SuspendLayout()
        Me.ventas_tp.SuspendLayout()
        CType(Me.ventas_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ventas_bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ventas_bn.SuspendLayout()
        Me.sesiones_tp.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.bonos_tp.SuspendLayout()
        CType(Me.bonos_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BonosBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bonos_bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bonos_bn.SuspendLayout()
        CType(Me.clientes_bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.clientes_bn.SuspendLayout()
        CType(Me.NombresBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.volver_bt.Location = New System.Drawing.Point(0, 336)
        Me.volver_bt.Name = "volver_bt"
        Me.volver_bt.Size = New System.Drawing.Size(150, 626)
        Me.volver_bt.TabIndex = 98
        Me.volver_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttConsejo.SetToolTip(Me.volver_bt, "Volver")
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
        Me.MenuStrip1.TabIndex = 96
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
        Me.salir_bt.Location = New System.Drawing.Point(1634, 336)
        Me.salir_bt.Name = "salir_bt"
        Me.salir_bt.Size = New System.Drawing.Size(150, 626)
        Me.salir_bt.TabIndex = 97
        Me.salir_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salir_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ttConsejo.SetToolTip(Me.salir_bt, "Salir del programa")
        Me.salir_bt.UseVisualStyleBackColor = False
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
        'fecha_dtp
        '
        Me.fecha_dtp.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientesBS, "FechaNacimiento", True))
        Me.fecha_dtp.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.fecha_dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_dtp.Location = New System.Drawing.Point(964, 40)
        Me.fecha_dtp.Name = "fecha_dtp"
        Me.fecha_dtp.Size = New System.Drawing.Size(170, 33)
        Me.fecha_dtp.TabIndex = 2
        Me.ttConsejo.SetToolTip(Me.fecha_dtp, "Escoge la fecha de nacimiento")
        '
        'ClientesBS
        '
        Me.ClientesBS.DataMember = "clientes"
        Me.ClientesBS.DataSource = Me.EsteticaDataset
        '
        'EsteticaDataset
        '
        Me.EsteticaDataset.DataSetName = "EsteticaDataset"
        Me.EsteticaDataset.EnforceConstraints = False
        Me.EsteticaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'observaciones_txt
        '
        Me.observaciones_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBS, "Observaciones", True))
        Me.observaciones_txt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.observaciones_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.observaciones_txt.Location = New System.Drawing.Point(3, 173)
        Me.observaciones_txt.Multiline = True
        Me.observaciones_txt.Name = "observaciones_txt"
        Me.observaciones_txt.Size = New System.Drawing.Size(1778, 75)
        Me.observaciones_txt.TabIndex = 4
        Me.ttConsejo.SetToolTip(Me.observaciones_txt, "Introducir observaciones")
        '
        'apellidos_txt
        '
        Me.apellidos_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBS, "Apellidos", True))
        Me.apellidos_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.apellidos_txt.Location = New System.Drawing.Point(155, 90)
        Me.apellidos_txt.Name = "apellidos_txt"
        Me.apellidos_txt.Size = New System.Drawing.Size(511, 33)
        Me.apellidos_txt.TabIndex = 1
        Me.ttConsejo.SetToolTip(Me.apellidos_txt, "Introduce los apellidos")
        '
        'fijo_txt
        '
        Me.fijo_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBS, "Fijo", True))
        Me.fijo_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.fijo_txt.Location = New System.Drawing.Point(1223, 40)
        Me.fijo_txt.Name = "fijo_txt"
        Me.fijo_txt.Size = New System.Drawing.Size(130, 33)
        Me.fijo_txt.TabIndex = 3
        Me.ttConsejo.SetToolTip(Me.fijo_txt, "Introduce el número de teléfono")
        '
        'nombre_txt
        '
        Me.nombre_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBS, "Nombre", True))
        Me.nombre_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.nombre_txt.Location = New System.Drawing.Point(126, 40)
        Me.nombre_txt.Name = "nombre_txt"
        Me.nombre_txt.Size = New System.Drawing.Size(540, 33)
        Me.nombre_txt.TabIndex = 0
        Me.ttConsejo.SetToolTip(Me.nombre_txt, "Introduce el nombre")
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
        Me.ttConsejo.SetToolTip(Me.guardar_bt, "Guardar ficha cliente")
        Me.guardar_bt.UseVisualStyleBackColor = False
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
        Me.ttConsejo.SetToolTip(Me.editar_bt, "Editar ficha cliente")
        Me.editar_bt.UseVisualStyleBackColor = False
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
        Me.ttConsejo.SetToolTip(Me.borrar_bt, "Borrar ficha cliente")
        Me.borrar_bt.UseVisualStyleBackColor = False
        '
        'movil_txt
        '
        Me.movil_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBS, "Movil", True))
        Me.movil_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.movil_txt.Location = New System.Drawing.Point(773, 90)
        Me.movil_txt.Name = "movil_txt"
        Me.movil_txt.Size = New System.Drawing.Size(130, 33)
        Me.movil_txt.TabIndex = 118
        Me.ttConsejo.SetToolTip(Me.movil_txt, "Introduce el número de teléfono")
        '
        'email_txt
        '
        Me.email_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBS, "Email", True))
        Me.email_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.email_txt.Location = New System.Drawing.Point(1020, 90)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(333, 33)
        Me.email_txt.TabIndex = 120
        Me.ttConsejo.SetToolTip(Me.email_txt, "Introduce el número de teléfono")
        '
        'datos_gb
        '
        Me.datos_gb.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.datos_gb.Controls.Add(Me.Label7)
        Me.datos_gb.Controls.Add(Me.email_txt)
        Me.datos_gb.Controls.Add(Me.Label6)
        Me.datos_gb.Controls.Add(Me.movil_txt)
        Me.datos_gb.Controls.Add(Me.observaciones_txt)
        Me.datos_gb.Controls.Add(Me.fecha_dtp)
        Me.datos_gb.Controls.Add(Me.Panel1)
        Me.datos_gb.Controls.Add(Me.Label5)
        Me.datos_gb.Controls.Add(Me.apellidos_txt)
        Me.datos_gb.Controls.Add(Me.Label4)
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
        Me.datos_gb.Size = New System.Drawing.Size(1784, 251)
        Me.datos_gb.TabIndex = 99
        Me.datos_gb.TabStop = False
        Me.datos_gb.Text = "CLIENTES"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(909, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 30)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "E-MAIL:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(672, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 30)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "MÓVIL:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.borrar_bt)
        Me.Panel1.Controls.Add(Me.editar_bt)
        Me.Panel1.Controls.Add(Me.guardar_bt)
        Me.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel1.Location = New System.Drawing.Point(1450, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 100)
        Me.Panel1.TabIndex = 117
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(6, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 30)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "OBSERVACIONES:"
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
        Me.Label3.Location = New System.Drawing.Point(1140, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 30)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "FIJO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(672, 40)
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
        'clientes_tc
        '
        Me.clientes_tc.Controls.Add(Me.ventas_tp)
        Me.clientes_tc.Controls.Add(Me.sesiones_tp)
        Me.clientes_tc.Controls.Add(Me.bonos_tp)
        Me.clientes_tc.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Titulo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.clientes_tc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clientes_tc.Font = Global.Estetica.My.MySettings.Default.Titulo
        Me.clientes_tc.ImageList = Me.ImageList1
        Me.clientes_tc.Location = New System.Drawing.Point(150, 336)
        Me.clientes_tc.Name = "clientes_tc"
        Me.clientes_tc.SelectedIndex = 0
        Me.clientes_tc.Size = New System.Drawing.Size(1484, 626)
        Me.clientes_tc.TabIndex = 118
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
        Me.ventas_tp.Size = New System.Drawing.Size(1476, 555)
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
        Me.ventas_dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Dependienta, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.Precio, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ventas_dgv.DataSource = Me.VentasBS
        Me.ventas_dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ventas_dgv.Location = New System.Drawing.Point(3, 55)
        Me.ventas_dgv.Name = "ventas_dgv"
        Me.ventas_dgv.ReadOnly = True
        Me.ventas_dgv.Size = New System.Drawing.Size(1466, 493)
        Me.ventas_dgv.TabIndex = 102
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodVenta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodVenta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Dependienta
        '
        Me.Dependienta.DataPropertyName = "Dependienta"
        Me.Dependienta.HeaderText = "Dependienta"
        Me.Dependienta.Name = "Dependienta"
        Me.Dependienta.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Producto"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.DataPropertyName = "Precio"
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Pago"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Pago"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
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
        'sesiones_tp
        '
        Me.sesiones_tp.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.sesiones_tp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sesiones_tp.Controls.Add(Me.BindingNavigator1)
        Me.sesiones_tp.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.sesiones_tp.Font = New System.Drawing.Font("Verdana", 14.25!)
        Me.sesiones_tp.ImageIndex = 2
        Me.sesiones_tp.Location = New System.Drawing.Point(4, 67)
        Me.sesiones_tp.Name = "sesiones_tp"
        Me.sesiones_tp.Size = New System.Drawing.Size(1476, 555)
        Me.sesiones_tp.TabIndex = 2
        Me.sesiones_tp.Text = "SESIONES"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.BindingNavigator1.BindingSource = Me.VentasBS
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel3
        Me.BindingNavigator1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.BindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton10, Me.ToolStripButton11, Me.ToolStripSeparator2, Me.ToolStripLabel3, Me.ToolStripTextBox3, Me.ToolStripSeparator3, Me.ToolStripButton12, Me.ToolStripButton13})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton13
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton10
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton11
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton12
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox3
        Me.BindingNavigator1.Size = New System.Drawing.Size(1472, 52)
        Me.BindingNavigator1.Stretch = True
        Me.BindingNavigator1.TabIndex = 121
        Me.BindingNavigator1.Text = "BindingNavigator2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(84, 49)
        Me.ToolStripLabel3.Text = "de {0}"
        Me.ToolStripLabel3.ToolTipText = "Número total de elementos"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = Global.Estetica.My.Resources.Resources.ultimo
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(49, 49)
        Me.ToolStripButton10.Text = "Mover último"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = Global.Estetica.My.Resources.Resources.adelante
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton11.Size = New System.Drawing.Size(49, 49)
        Me.ToolStripButton11.Text = "Mover siguiente"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.AccessibleName = "Posición"
        Me.ToolStripTextBox3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox3.AutoSize = False
        Me.ToolStripTextBox3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(50, 33)
        Me.ToolStripTextBox3.Text = "0"
        Me.ToolStripTextBox3.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 52)
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = Global.Estetica.My.Resources.Resources.atras
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton12.Size = New System.Drawing.Size(49, 49)
        Me.ToolStripButton12.Text = "Mover anterior"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = Global.Estetica.My.Resources.Resources.primero
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton13.Size = New System.Drawing.Size(49, 49)
        Me.ToolStripButton13.Text = "Mover primero"
        '
        'bonos_tp
        '
        Me.bonos_tp.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.bonos_tp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bonos_tp.Controls.Add(Me.bonos_dgv)
        Me.bonos_tp.Controls.Add(Me.bonos_bn)
        Me.bonos_tp.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.bonos_tp.ImageIndex = 1
        Me.bonos_tp.Location = New System.Drawing.Point(4, 67)
        Me.bonos_tp.Name = "bonos_tp"
        Me.bonos_tp.Padding = New System.Windows.Forms.Padding(3)
        Me.bonos_tp.Size = New System.Drawing.Size(1476, 555)
        Me.bonos_tp.TabIndex = 1
        Me.bonos_tp.Text = "BONOS"
        '
        'bonos_dgv
        '
        Me.bonos_dgv.AllowUserToAddRows = False
        Me.bonos_dgv.AllowUserToDeleteRows = False
        Me.bonos_dgv.AutoGenerateColumns = False
        Me.bonos_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.bonos_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.bonos_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bonos_dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn11})
        Me.bonos_dgv.DataSource = Me.BonosBS
        Me.bonos_dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bonos_dgv.Location = New System.Drawing.Point(3, 55)
        Me.bonos_dgv.Name = "bonos_dgv"
        Me.bonos_dgv.ReadOnly = True
        Me.bonos_dgv.Size = New System.Drawing.Size(1466, 493)
        Me.bonos_dgv.TabIndex = 0
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CodBono"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CodBono"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Categoría"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Sesiones"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Sesiones"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'BonosBS
        '
        Me.BonosBS.DataMember = "bonos"
        Me.BonosBS.DataSource = Me.EsteticaDataset
        '
        'bonos_bn
        '
        Me.bonos_bn.AddNewItem = Nothing
        Me.bonos_bn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.bonos_bn.BindingSource = Me.BonosBS
        Me.bonos_bn.CountItem = Me.ToolStripLabel1
        Me.bonos_bn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.bonos_bn.DeleteItem = Nothing
        Me.bonos_bn.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.bonos_bn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.bonos_bn.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.bonos_bn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.ToolStripTextBox5, Me.ToolStripSeparator6, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.bonos_bn.Location = New System.Drawing.Point(3, 3)
        Me.bonos_bn.MoveFirstItem = Me.ToolStripButton4
        Me.bonos_bn.MoveLastItem = Me.ToolStripButton1
        Me.bonos_bn.MoveNextItem = Me.ToolStripButton2
        Me.bonos_bn.MovePreviousItem = Me.ToolStripButton3
        Me.bonos_bn.Name = "bonos_bn"
        Me.bonos_bn.PositionItem = Me.ToolStripTextBox5
        Me.bonos_bn.Size = New System.Drawing.Size(1466, 52)
        Me.bonos_bn.Stretch = True
        Me.bonos_bn.TabIndex = 120
        Me.bonos_bn.Text = "BindingNavigator3"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
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
        Me.ToolStripTextBox5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ImageList1.Images.SetKeyName(1, "bono.png")
        Me.ImageList1.Images.SetKeyName(2, "tratamientos128.png")
        '
        'clientes_bn
        '
        Me.clientes_bn.AddNewItem = Nothing
        Me.clientes_bn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.clientes_bn.BindingSource = Me.ClientesBS
        Me.clientes_bn.CountItem = Me.BindingNavigatorCountItem
        Me.clientes_bn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.clientes_bn.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.clientes_bn.DeleteItem = Nothing
        Me.clientes_bn.Font = Global.Estetica.My.MySettings.Default.Fuente
        Me.clientes_bn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.clientes_bn.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.clientes_bn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ultimo_bt, Me.adelante_bt, Me.BindingNavigatorSeparator2, Me.BindingNavigatorCountItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorSeparator3, Me.atras_bt, Me.primero_bt, Me.ToolStripTextBox1, Me.ToolStripSeparator1, Me.nombre_ts, Me.buscanombre_bt})
        Me.clientes_bn.Location = New System.Drawing.Point(0, 33)
        Me.clientes_bn.MoveFirstItem = Me.primero_bt
        Me.clientes_bn.MoveLastItem = Me.ultimo_bt
        Me.clientes_bn.MoveNextItem = Me.adelante_bt
        Me.clientes_bn.MovePreviousItem = Me.atras_bt
        Me.clientes_bn.Name = "clientes_bn"
        Me.clientes_bn.PositionItem = Me.BindingNavigatorPositionItem
        Me.clientes_bn.Size = New System.Drawing.Size(1784, 52)
        Me.clientes_bn.Stretch = True
        Me.clientes_bn.TabIndex = 119
        Me.clientes_bn.Text = "BindingNavigator1"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bonosTableAdapter = Nothing
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.comprasTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.contraseñaTableAdapter = Nothing
        Me.TableAdapterManager.dependientasTableAdapter = Nothing
        Me.TableAdapterManager.prodcategoriasTableAdapter = Nothing
        Me.TableAdapterManager.productos1TableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.prodventaTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.tratamientosTableAdapter = Nothing
        Me.TableAdapterManager.tratcategoriasTableAdapter = Nothing
        Me.TableAdapterManager.tratventaTableAdapter = Nothing
        Me.TableAdapterManager.turnosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Estetica.EsteticaDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'BonosTA
        '
        Me.BonosTA.ClearBeforeFill = True
        '
        'VentasTA
        '
        Me.VentasTA.ClearBeforeFill = True
        '
        'ClientesTA
        '
        Me.ClientesTA.ClearBeforeFill = True
        '
        'NombresBS
        '
        Me.NombresBS.DataMember = "Nombres"
        Me.NombresBS.DataSource = Me.EsteticaDataset
        '
        'NombresTA
        '
        Me.NombresTA.ClearBeforeFill = True
        '
        'Cliente_Historial_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Estetica.My.MySettings.Default.Fondo
        Me.ClientSize = New System.Drawing.Size(1784, 962)
        Me.Controls.Add(Me.clientes_tc)
        Me.Controls.Add(Me.salir_bt)
        Me.Controls.Add(Me.volver_bt)
        Me.Controls.Add(Me.datos_gb)
        Me.Controls.Add(Me.clientes_bn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Fondo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cliente_Historial_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HISTORIAL DE CLIENTES"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ClientesBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.datos_gb.ResumeLayout(False)
        Me.datos_gb.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.clientes_tc.ResumeLayout(False)
        Me.ventas_tp.ResumeLayout(False)
        Me.ventas_tp.PerformLayout()
        CType(Me.ventas_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ventas_bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ventas_bn.ResumeLayout(False)
        Me.ventas_bn.PerformLayout()
        Me.sesiones_tp.ResumeLayout(False)
        Me.sesiones_tp.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.bonos_tp.ResumeLayout(False)
        Me.bonos_tp.PerformLayout()
        CType(Me.bonos_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BonosBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bonos_bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bonos_bn.ResumeLayout(False)
        Me.bonos_bn.PerformLayout()
        CType(Me.clientes_bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.clientes_bn.ResumeLayout(False)
        Me.clientes_bn.PerformLayout()
        CType(Me.NombresBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents volver_bt As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents hora_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fecha_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents salir_bt As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip
    Friend WithEvents datos_gb As System.Windows.Forms.GroupBox
    Friend WithEvents fecha_dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents observaciones_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents apellidos_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fijo_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombre_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents guardar_bt As System.Windows.Forms.Button
    Friend WithEvents editar_bt As System.Windows.Forms.Button
    Friend WithEvents borrar_bt As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents clientes_tc As System.Windows.Forms.TabControl
    Friend WithEvents ventas_tp As System.Windows.Forms.TabPage
    Friend WithEvents bonos_tp As System.Windows.Forms.TabPage
    Friend WithEvents EsteticaDataset As Estetica.EsteticaDataset
    Friend WithEvents TableAdapterManager As Estetica.EsteticaDatasetTableAdapters.TableAdapterManager
    Friend WithEvents BonosBS As System.Windows.Forms.BindingSource
    Friend WithEvents BonosTA As Estetica.EsteticaDatasetTableAdapters.bonosTableAdapter
    Friend WithEvents bonos_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents VentasBS As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTA As Estetica.EsteticaDatasetTableAdapters.ventasTableAdapter
    Friend WithEvents ventas_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientesBS As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTA As Estetica.EsteticaDatasetTableAdapters.clientesTableAdapter
    Friend WithEvents clientes_bn As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents adelante_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents atras_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents primero_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents ultimo_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents nombre_ts As System.Windows.Forms.ToolStripTextBox
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
    Friend WithEvents bonos_bn As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents NombresBS As System.Windows.Forms.BindingSource
    Friend WithEvents NombresTA As Estetica.EsteticaDatasetTableAdapters.NombresTableAdapter
    Friend WithEvents buscanombre_bt As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dependienta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents movil_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents email_txt As System.Windows.Forms.TextBox
    Friend WithEvents sesiones_tp As System.Windows.Forms.TabPage
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
End Class
