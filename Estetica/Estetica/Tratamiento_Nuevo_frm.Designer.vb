<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tratamiento_Nuevo_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tratamiento_Nuevo_frm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.volver_bt = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.hora_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.fecha_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.salir_bt = New System.Windows.Forms.Button
        Me.datos_gb = New System.Windows.Forms.GroupBox
        Me.sesionbono_txt = New System.Windows.Forms.TextBox
        Me.bono_txt = New System.Windows.Forms.TextBox
        Me.añadir_bt = New System.Windows.Forms.Button
        Me.categorias_cb = New System.Windows.Forms.ComboBox
        Me.TratcategoriasBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.EsteticaDataset = New Estetica.EsteticaDataset
        Me.guardar_bt = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.nombre_txt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.sesion_txt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        Me.TratcategoriasTA = New Estetica.EsteticaDatasetTableAdapters.tratcategoriasTableAdapter
        Me.TratamientosBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.TratamientosTA = New Estetica.EsteticaDatasetTableAdapters.tratamientosTableAdapter
        Me.MenuStrip1.SuspendLayout()
        Me.datos_gb.SuspendLayout()
        CType(Me.TratcategoriasBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TratamientosBS, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.volver_bt.Size = New System.Drawing.Size(150, 278)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(976, 33)
        Me.MenuStrip1.TabIndex = 99
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'hora_txt
        '
        Me.hora_txt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.hora_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.hora_txt.Name = "hora_txt"
        Me.hora_txt.Size = New System.Drawing.Size(75, 29)
        Me.hora_txt.Text = "Hora"
        '
        'fecha_txt
        '
        Me.fecha_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
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
        Me.salir_bt.Location = New System.Drawing.Point(826, 33)
        Me.salir_bt.Name = "salir_bt"
        Me.salir_bt.Size = New System.Drawing.Size(150, 278)
        Me.salir_bt.TabIndex = 100
        Me.salir_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salir_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.salir_bt.UseVisualStyleBackColor = False
        '
        'datos_gb
        '
        Me.datos_gb.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.datos_gb.Controls.Add(Me.sesionbono_txt)
        Me.datos_gb.Controls.Add(Me.bono_txt)
        Me.datos_gb.Controls.Add(Me.añadir_bt)
        Me.datos_gb.Controls.Add(Me.categorias_cb)
        Me.datos_gb.Controls.Add(Me.guardar_bt)
        Me.datos_gb.Controls.Add(Me.Label5)
        Me.datos_gb.Controls.Add(Me.nombre_txt)
        Me.datos_gb.Controls.Add(Me.Label4)
        Me.datos_gb.Controls.Add(Me.Label3)
        Me.datos_gb.Controls.Add(Me.sesion_txt)
        Me.datos_gb.Controls.Add(Me.Label2)
        Me.datos_gb.Controls.Add(Me.Label1)
        Me.datos_gb.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.datos_gb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datos_gb.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.datos_gb.Location = New System.Drawing.Point(150, 33)
        Me.datos_gb.Name = "datos_gb"
        Me.datos_gb.Size = New System.Drawing.Size(826, 278)
        Me.datos_gb.TabIndex = 102
        Me.datos_gb.TabStop = False
        Me.datos_gb.Text = "INTRODUCIR DATOS"
        '
        'sesionbono_txt
        '
        Me.sesionbono_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.sesionbono_txt.Location = New System.Drawing.Point(273, 220)
        Me.sesionbono_txt.Name = "sesionbono_txt"
        Me.sesionbono_txt.Size = New System.Drawing.Size(175, 33)
        Me.sesionbono_txt.TabIndex = 117
        Me.ttConsejo.SetToolTip(Me.sesionbono_txt, "Introduce las sesiones por bono")
        '
        'bono_txt
        '
        Me.bono_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.bono_txt.Location = New System.Drawing.Point(340, 160)
        Me.bono_txt.Name = "bono_txt"
        Me.bono_txt.Size = New System.Drawing.Size(120, 33)
        Me.bono_txt.TabIndex = 116
        Me.ttConsejo.SetToolTip(Me.bono_txt, "Introduce importe bono")
        '
        'añadir_bt
        '
        Me.añadir_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.añadir_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.añadir_bt.Image = Global.Estetica.My.Resources.Resources.nuevo64
        Me.añadir_bt.Location = New System.Drawing.Point(596, 20)
        Me.añadir_bt.Name = "añadir_bt"
        Me.añadir_bt.Size = New System.Drawing.Size(70, 70)
        Me.añadir_bt.TabIndex = 115
        Me.ttConsejo.SetToolTip(Me.añadir_bt, "Añadir Categoría")
        Me.añadir_bt.UseVisualStyleBackColor = False
        '
        'categorias_cb
        '
        Me.categorias_cb.DataSource = Me.TratcategoriasBS
        Me.categorias_cb.DisplayMember = "Categoria"
        Me.categorias_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categorias_cb.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.categorias_cb.FormattingEnabled = True
        Me.categorias_cb.Location = New System.Drawing.Point(158, 40)
        Me.categorias_cb.Name = "categorias_cb"
        Me.categorias_cb.Size = New System.Drawing.Size(432, 33)
        Me.categorias_cb.TabIndex = 114
        Me.categorias_cb.ValueMember = "Categoria"
        '
        'TratcategoriasBS
        '
        Me.TratcategoriasBS.DataMember = "tratcategorias"
        Me.TratcategoriasBS.DataSource = Me.EsteticaDataset
        '
        'EsteticaDataset
        '
        Me.EsteticaDataset.DataSetName = "EsteticaDataset"
        Me.EsteticaDataset.EnforceConstraints = False
        Me.EsteticaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'guardar_bt
        '
        Me.guardar_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.guardar_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.guardar128
        Me.guardar_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.guardar_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.guardar_bt.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.guardar_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.guardar_bt.Location = New System.Drawing.Point(466, 137)
        Me.guardar_bt.Name = "guardar_bt"
        Me.guardar_bt.Size = New System.Drawing.Size(200, 135)
        Me.guardar_bt.TabIndex = 113
        Me.guardar_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttConsejo.SetToolTip(Me.guardar_bt, "Guardar ficha cliente")
        Me.guardar_bt.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(6, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(261, 30)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "SESIONES POR BONO:"
        '
        'nombre_txt
        '
        Me.nombre_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.nombre_txt.Location = New System.Drawing.Point(126, 100)
        Me.nombre_txt.Name = "nombre_txt"
        Me.nombre_txt.Size = New System.Drawing.Size(540, 33)
        Me.nombre_txt.TabIndex = 1
        Me.ttConsejo.SetToolTip(Me.nombre_txt, "Introduce el nombre")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 30)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "NOMBRE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(248, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 30)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "BONO:"
        '
        'sesion_txt
        '
        Me.sesion_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.sesion_txt.Location = New System.Drawing.Point(122, 160)
        Me.sesion_txt.Name = "sesion_txt"
        Me.sesion_txt.Size = New System.Drawing.Size(120, 33)
        Me.sesion_txt.TabIndex = 3
        Me.ttConsejo.SetToolTip(Me.sesion_txt, "Introduce importe sesión")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(6, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 30)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "SESIÓN:"
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
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'TratcategoriasTA
        '
        Me.TratcategoriasTA.ClearBeforeFill = True
        '
        'TratamientosBS
        '
        Me.TratamientosBS.DataMember = "tratamientos"
        Me.TratamientosBS.DataSource = Me.EsteticaDataset
        '
        'TratamientosTA
        '
        Me.TratamientosTA.ClearBeforeFill = True
        '
        'Tratamiento_Nuevo_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Estetica.My.MySettings.Default.Fondo
        Me.ClientSize = New System.Drawing.Size(976, 311)
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
        Me.Name = "Tratamiento_Nuevo_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NUEVO TRATAMIENTO"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.datos_gb.ResumeLayout(False)
        Me.datos_gb.PerformLayout()
        CType(Me.TratcategoriasBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TratamientosBS, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents guardar_bt As System.Windows.Forms.Button
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nombre_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sesion_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents añadir_bt As System.Windows.Forms.Button
    Friend WithEvents categorias_cb As System.Windows.Forms.ComboBox
    Friend WithEvents EsteticaDataset As Estetica.EsteticaDataset
    Friend WithEvents TratcategoriasBS As System.Windows.Forms.BindingSource
    Friend WithEvents TratcategoriasTA As Estetica.EsteticaDatasetTableAdapters.tratcategoriasTableAdapter
    Friend WithEvents bono_txt As System.Windows.Forms.TextBox
    Friend WithEvents sesionbono_txt As System.Windows.Forms.TextBox
    Friend WithEvents TratamientosBS As System.Windows.Forms.BindingSource
    Friend WithEvents TratamientosTA As Estetica.EsteticaDatasetTableAdapters.tratamientosTableAdapter
End Class
