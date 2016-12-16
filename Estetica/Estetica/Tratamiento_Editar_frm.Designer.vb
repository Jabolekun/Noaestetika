<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tratamiento_Editar_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tratamiento_Editar_frm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.volver_bt = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.hora_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.fecha_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.salir_bt = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.borrar_bt = New System.Windows.Forms.Button
        Me.editar_bt = New System.Windows.Forms.Button
        Me.guardar_bt = New System.Windows.Forms.Button
        Me.datos_gb = New System.Windows.Forms.GroupBox
        Me.sesionbono_txt = New System.Windows.Forms.TextBox
        Me.TratamientosBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.EsteticaDataset = New Estetica.EsteticaDataset
        Me.Label5 = New System.Windows.Forms.Label
        Me.bono_txt = New System.Windows.Forms.TextBox
        Me.nombre_txt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.sesion_txt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.categorias_cb = New System.Windows.Forms.ComboBox
        Me.TratcategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.categoria_txt = New System.Windows.Forms.TextBox
        Me.bonos_gb = New System.Windows.Forms.GroupBox
        Me.bonos_dgv = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.tratamientos_bn = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        Me.TratamientosTA = New Estetica.EsteticaDatasetTableAdapters.tratamientosTableAdapter
        Me.BonosTA = New Estetica.EsteticaDatasetTableAdapters.bonosTableAdapter
        Me.TableAdapterManager = New Estetica.EsteticaDatasetTableAdapters.TableAdapterManager
        Me.NombreTratamientoBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreTratamientoTA = New Estetica.EsteticaDatasetTableAdapters.NombreTratamientoTableAdapter
        Me.TratcategoriasTableAdapter = New Estetica.EsteticaDatasetTableAdapters.tratcategoriasTableAdapter
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.datos_gb.SuspendLayout()
        CType(Me.TratamientosBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TratcategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bonos_gb.SuspendLayout()
        CType(Me.bonos_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BonosBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bonos_bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bonos_bn.SuspendLayout()
        CType(Me.tratamientos_bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tratamientos_bn.SuspendLayout()
        CType(Me.NombreTratamientoBS, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.volver_bt.Location = New System.Drawing.Point(0, 225)
        Me.volver_bt.Name = "volver_bt"
        Me.volver_bt.Size = New System.Drawing.Size(150, 737)
        Me.volver_bt.TabIndex = 101
        Me.volver_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.volver_bt.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.MenuStrip1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MenuStrip1.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MenuStrip1.Font = Global.Estetica.My.MySettings.Default.Fuente
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
        Me.salir_bt.Location = New System.Drawing.Point(1634, 225)
        Me.salir_bt.Name = "salir_bt"
        Me.salir_bt.Size = New System.Drawing.Size(150, 737)
        Me.salir_bt.TabIndex = 100
        Me.salir_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salir_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.salir_bt.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.borrar_bt)
        Me.Panel1.Controls.Add(Me.editar_bt)
        Me.Panel1.Controls.Add(Me.guardar_bt)
        Me.Panel1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Panel1.Location = New System.Drawing.Point(1450, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 100)
        Me.Panel1.TabIndex = 131
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
        'datos_gb
        '
        Me.datos_gb.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.datos_gb.Controls.Add(Me.Panel1)
        Me.datos_gb.Controls.Add(Me.sesionbono_txt)
        Me.datos_gb.Controls.Add(Me.Label5)
        Me.datos_gb.Controls.Add(Me.bono_txt)
        Me.datos_gb.Controls.Add(Me.nombre_txt)
        Me.datos_gb.Controls.Add(Me.Label4)
        Me.datos_gb.Controls.Add(Me.Label3)
        Me.datos_gb.Controls.Add(Me.sesion_txt)
        Me.datos_gb.Controls.Add(Me.Label2)
        Me.datos_gb.Controls.Add(Me.Label1)
        Me.datos_gb.Controls.Add(Me.categoria_txt)
        Me.datos_gb.Controls.Add(Me.categorias_cb)
        Me.datos_gb.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.datos_gb.Dock = System.Windows.Forms.DockStyle.Top
        Me.datos_gb.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.datos_gb.Location = New System.Drawing.Point(0, 85)
        Me.datos_gb.Name = "datos_gb"
        Me.datos_gb.Size = New System.Drawing.Size(1784, 140)
        Me.datos_gb.TabIndex = 130
        Me.datos_gb.TabStop = False
        Me.datos_gb.Text = "TRATAMIENTOS"
        '
        'sesionbono_txt
        '
        Me.sesionbono_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TratamientosBS, "SesionesBono", True))
        Me.sesionbono_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.sesionbono_txt.Location = New System.Drawing.Point(1124, 93)
        Me.sesionbono_txt.Name = "sesionbono_txt"
        Me.sesionbono_txt.Size = New System.Drawing.Size(100, 33)
        Me.sesionbono_txt.TabIndex = 111
        Me.ttConsejo.SetToolTip(Me.sesionbono_txt, "Introducir sesiones por bono")
        '
        'TratamientosBS
        '
        Me.TratamientosBS.DataMember = "tratamientos"
        Me.TratamientosBS.DataSource = Me.EsteticaDataset
        '
        'EsteticaDataset
        '
        Me.EsteticaDataset.DataSetName = "EsteticaDataset"
        Me.EsteticaDataset.EnforceConstraints = False
        Me.EsteticaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(857, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(261, 30)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "SESIÓNES POR BONO:"
        '
        'bono_txt
        '
        Me.bono_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TratamientosBS, "Bono", True))
        Me.bono_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.bono_txt.Location = New System.Drawing.Point(1257, 40)
        Me.bono_txt.Name = "bono_txt"
        Me.bono_txt.Size = New System.Drawing.Size(125, 33)
        Me.bono_txt.TabIndex = 109
        Me.ttConsejo.SetToolTip(Me.bono_txt, "Introducir importe bono")
        '
        'nombre_txt
        '
        Me.nombre_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TratamientosBS, "Nombre", True))
        Me.nombre_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.nombre_txt.Location = New System.Drawing.Point(126, 93)
        Me.nombre_txt.Name = "nombre_txt"
        Me.nombre_txt.Size = New System.Drawing.Size(725, 33)
        Me.nombre_txt.TabIndex = 1
        Me.ttConsejo.SetToolTip(Me.nombre_txt, "Introducir nombre tratamiento")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 30)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "NOMBRE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(857, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 30)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "SESIÓN:"
        '
        'sesion_txt
        '
        Me.sesion_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TratamientosBS, "Sesion", True))
        Me.sesion_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.sesion_txt.Location = New System.Drawing.Point(973, 40)
        Me.sesion_txt.Name = "sesion_txt"
        Me.sesion_txt.Size = New System.Drawing.Size(125, 33)
        Me.sesion_txt.TabIndex = 3
        Me.ttConsejo.SetToolTip(Me.sesion_txt, "Introducir importe sesión")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(1165, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 30)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "BONO:"
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
        'categorias_cb
        '
        Me.categorias_cb.DataSource = Me.TratcategoriasBindingSource
        Me.categorias_cb.DisplayMember = "Categoria"
        Me.categorias_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categorias_cb.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.categorias_cb.FormattingEnabled = True
        Me.categorias_cb.Location = New System.Drawing.Point(160, 40)
        Me.categorias_cb.Name = "categorias_cb"
        Me.categorias_cb.Size = New System.Drawing.Size(691, 33)
        Me.categorias_cb.TabIndex = 112
        Me.ttConsejo.SetToolTip(Me.categorias_cb, "Escoge la categoría")
        Me.categorias_cb.ValueMember = "Categoria"
        '
        'TratcategoriasBindingSource
        '
        Me.TratcategoriasBindingSource.DataMember = "tratcategorias"
        Me.TratcategoriasBindingSource.DataSource = Me.EsteticaDataset
        '
        'categoria_txt
        '
        Me.categoria_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TratamientosBS, "Categoria", True))
        Me.categoria_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.categoria_txt.Location = New System.Drawing.Point(160, 40)
        Me.categoria_txt.Name = "categoria_txt"
        Me.categoria_txt.Size = New System.Drawing.Size(691, 33)
        Me.categoria_txt.TabIndex = 113
        '
        'bonos_gb
        '
        Me.bonos_gb.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.bonos_gb.Controls.Add(Me.bonos_dgv)
        Me.bonos_gb.Controls.Add(Me.bonos_bn)
        Me.bonos_gb.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.bonos_gb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bonos_gb.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.bonos_gb.Location = New System.Drawing.Point(150, 225)
        Me.bonos_gb.Name = "bonos_gb"
        Me.bonos_gb.Size = New System.Drawing.Size(1484, 737)
        Me.bonos_gb.TabIndex = 129
        Me.bonos_gb.TabStop = False
        Me.bonos_gb.Text = "BONOS"
        '
        'bonos_dgv
        '
        Me.bonos_dgv.AllowUserToAddRows = False
        Me.bonos_dgv.AllowUserToDeleteRows = False
        Me.bonos_dgv.AutoGenerateColumns = False
        Me.bonos_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.bonos_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.bonos_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bonos_dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4})
        Me.bonos_dgv.DataSource = Me.BonosBS
        Me.bonos_dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bonos_dgv.Location = New System.Drawing.Point(3, 89)
        Me.bonos_dgv.Name = "bonos_dgv"
        Me.bonos_dgv.ReadOnly = True
        Me.bonos_dgv.Size = New System.Drawing.Size(1478, 645)
        Me.bonos_dgv.TabIndex = 121
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodBono"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodBono"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CodCliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CodCliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CodTratamiento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CodTratamiento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Categoría"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Sesiones"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sesiones"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
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
        Me.bonos_bn.Location = New System.Drawing.Point(3, 37)
        Me.bonos_bn.MoveFirstItem = Me.ToolStripButton4
        Me.bonos_bn.MoveLastItem = Me.ToolStripButton1
        Me.bonos_bn.MoveNextItem = Me.ToolStripButton2
        Me.bonos_bn.MovePreviousItem = Me.ToolStripButton3
        Me.bonos_bn.Name = "bonos_bn"
        Me.bonos_bn.PositionItem = Me.ToolStripTextBox5
        Me.bonos_bn.Size = New System.Drawing.Size(1478, 52)
        Me.bonos_bn.Stretch = True
        Me.bonos_bn.TabIndex = 121
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
        'tratamientos_bn
        '
        Me.tratamientos_bn.AddNewItem = Nothing
        Me.tratamientos_bn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.tratamientos_bn.BindingSource = Me.TratamientosBS
        Me.tratamientos_bn.CountItem = Me.BindingNavigatorCountItem
        Me.tratamientos_bn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tratamientos_bn.DeleteItem = Nothing
        Me.tratamientos_bn.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.tratamientos_bn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tratamientos_bn.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.tratamientos_bn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ultimo_bt, Me.adelante_bt, Me.BindingNavigatorSeparator2, Me.BindingNavigatorCountItem, Me.BindingNavigatorPositionItem, Me.BindingNavigatorSeparator3, Me.atras_bt, Me.primero_bt, Me.ToolStripTextBox1, Me.ToolStripSeparator1, Me.nombre_ts, Me.buscanombre_bt})
        Me.tratamientos_bn.Location = New System.Drawing.Point(0, 33)
        Me.tratamientos_bn.MoveFirstItem = Me.primero_bt
        Me.tratamientos_bn.MoveLastItem = Me.ultimo_bt
        Me.tratamientos_bn.MoveNextItem = Me.adelante_bt
        Me.tratamientos_bn.MovePreviousItem = Me.atras_bt
        Me.tratamientos_bn.Name = "tratamientos_bn"
        Me.tratamientos_bn.PositionItem = Me.BindingNavigatorPositionItem
        Me.tratamientos_bn.Size = New System.Drawing.Size(1784, 52)
        Me.tratamientos_bn.Stretch = True
        Me.tratamientos_bn.TabIndex = 128
        Me.tratamientos_bn.Text = "BindingNavigator1"
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
        Me.nombre_ts.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'TratamientosTA
        '
        Me.TratamientosTA.ClearBeforeFill = True
        '
        'BonosTA
        '
        Me.BonosTA.ClearBeforeFill = True
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
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.prodventaTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.tratamientosTableAdapter = Me.TratamientosTA
        Me.TableAdapterManager.tratcategoriasTableAdapter = Nothing
        Me.TableAdapterManager.tratventaTableAdapter = Nothing
        Me.TableAdapterManager.turnosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Estetica.EsteticaDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'NombreTratamientoBS
        '
        Me.NombreTratamientoBS.DataMember = "NombreTratamiento"
        Me.NombreTratamientoBS.DataSource = Me.EsteticaDataset
        '
        'NombreTratamientoTA
        '
        Me.NombreTratamientoTA.ClearBeforeFill = True
        '
        'TratcategoriasTableAdapter
        '
        Me.TratcategoriasTableAdapter.ClearBeforeFill = True
        '
        'Tratamiento_Editar_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Estetica.My.MySettings.Default.Fondo
        Me.ClientSize = New System.Drawing.Size(1784, 962)
        Me.Controls.Add(Me.bonos_gb)
        Me.Controls.Add(Me.salir_bt)
        Me.Controls.Add(Me.volver_bt)
        Me.Controls.Add(Me.datos_gb)
        Me.Controls.Add(Me.tratamientos_bn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Fondo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tratamiento_Editar_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDITAR TRATAMIENTOS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.datos_gb.ResumeLayout(False)
        Me.datos_gb.PerformLayout()
        CType(Me.TratamientosBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TratcategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bonos_gb.ResumeLayout(False)
        Me.bonos_gb.PerformLayout()
        CType(Me.bonos_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BonosBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bonos_bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bonos_bn.ResumeLayout(False)
        Me.bonos_bn.PerformLayout()
        CType(Me.tratamientos_bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tratamientos_bn.ResumeLayout(False)
        Me.tratamientos_bn.PerformLayout()
        CType(Me.NombreTratamientoBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents volver_bt As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents hora_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fecha_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents salir_bt As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents borrar_bt As System.Windows.Forms.Button
    Friend WithEvents editar_bt As System.Windows.Forms.Button
    Friend WithEvents guardar_bt As System.Windows.Forms.Button
    Friend WithEvents datos_gb As System.Windows.Forms.GroupBox
    Friend WithEvents sesionbono_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bono_txt As System.Windows.Forms.TextBox
    Friend WithEvents nombre_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sesion_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bonos_gb As System.Windows.Forms.GroupBox
    Friend WithEvents bonos_bn As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tratamientos_bn As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents categorias_cb As System.Windows.Forms.ComboBox
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip
    Friend WithEvents categoria_txt As System.Windows.Forms.TextBox
    Friend WithEvents EsteticaDataset As Estetica.EsteticaDataset
    Friend WithEvents TratamientosBS As System.Windows.Forms.BindingSource
    Friend WithEvents TratamientosTA As Estetica.EsteticaDatasetTableAdapters.tratamientosTableAdapter
    Friend WithEvents BonosBS As System.Windows.Forms.BindingSource
    Friend WithEvents BonosTA As Estetica.EsteticaDatasetTableAdapters.bonosTableAdapter
    Friend WithEvents TableAdapterManager As Estetica.EsteticaDatasetTableAdapters.TableAdapterManager
    Friend WithEvents bonos_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreTratamientoBS As System.Windows.Forms.BindingSource
    Friend WithEvents NombreTratamientoTA As Estetica.EsteticaDatasetTableAdapters.NombreTratamientoTableAdapter
    Friend WithEvents TratcategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TratcategoriasTableAdapter As Estetica.EsteticaDatasetTableAdapters.tratcategoriasTableAdapter
End Class
