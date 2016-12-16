<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto_Stock_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producto_Stock_frm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.volver_bt = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.hora_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.fecha_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.salir_bt = New System.Windows.Forms.Button
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
        Me.EsteticaDataset = New Estetica.EsteticaDataset
        Me.NombreProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreProductoTableAdapter = New Estetica.EsteticaDatasetTableAdapters.NombreProductoTableAdapter
        Me.MenuStrip1.SuspendLayout()
        CType(Me.productos_bn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.productos_bn.SuspendLayout()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.volver_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.volver_bt.Location = New System.Drawing.Point(21, 950)
        Me.volver_bt.Name = "volver_bt"
        Me.volver_bt.Size = New System.Drawing.Size(333, 100)
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
        Me.salir_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.salir_bt.Location = New System.Drawing.Point(1439, 950)
        Me.salir_bt.Name = "salir_bt"
        Me.salir_bt.Size = New System.Drawing.Size(333, 100)
        Me.salir_bt.TabIndex = 100
        Me.salir_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salir_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.salir_bt.UseVisualStyleBackColor = False
        '
        'productos_bn
        '
        Me.productos_bn.AddNewItem = Nothing
        Me.productos_bn.BackColor = Global.Estetica.My.MySettings.Default.Botones
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
        Me.productos_bn.TabIndex = 133
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
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
        'EsteticaDataset
        '
        Me.EsteticaDataset.DataSetName = "EsteticaDataset"
        Me.EsteticaDataset.EnforceConstraints = False
        Me.EsteticaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreProductoBindingSource
        '
        Me.NombreProductoBindingSource.DataMember = "NombreProducto"
        Me.NombreProductoBindingSource.DataSource = Me.EsteticaDataset
        '
        'NombreProductoTableAdapter
        '
        Me.NombreProductoTableAdapter.ClearBeforeFill = True
        '
        'Producto_Stock_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Estetica.My.MySettings.Default.Fondo
        Me.ClientSize = New System.Drawing.Size(1784, 962)
        Me.Controls.Add(Me.productos_bn)
        Me.Controls.Add(Me.volver_bt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.salir_bt)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Fondo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Producto_Stock_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCK DE LOS PRODUCTOS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.productos_bn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.productos_bn.ResumeLayout(False)
        Me.productos_bn.PerformLayout()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents volver_bt As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents hora_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fecha_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents salir_bt As System.Windows.Forms.Button
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
    Friend WithEvents EsteticaDataset As Estetica.EsteticaDataset
    Friend WithEvents NombreProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NombreProductoTableAdapter As Estetica.EsteticaDatasetTableAdapters.NombreProductoTableAdapter
End Class
