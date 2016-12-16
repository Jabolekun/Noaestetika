<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente_Nuevo_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cliente_Nuevo_frm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.volver_bt = New System.Windows.Forms.Button
        Me.salir_bt = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.nombre_txt = New System.Windows.Forms.TextBox
        Me.fijo_txt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.apellidos_txt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.observaciones_txt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.datos_gb = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.correo_txt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.movil_txt = New System.Windows.Forms.TextBox
        Me.guardar_bt = New System.Windows.Forms.Button
        Me.fecha_dtp = New System.Windows.Forms.DateTimePicker
        Me.EsteticaDataset = New Estetica.EsteticaDataset
        Me.ClientesBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTA = New Estetica.EsteticaDatasetTableAdapters.clientesTableAdapter
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.hora_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.fecha_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.datos_gb.SuspendLayout()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
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
        Me.volver_bt.Size = New System.Drawing.Size(150, 515)
        Me.volver_bt.TabIndex = 1
        Me.volver_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttConsejo.SetToolTip(Me.volver_bt, "Volver")
        Me.volver_bt.UseVisualStyleBackColor = False
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
        Me.salir_bt.Location = New System.Drawing.Point(838, 33)
        Me.salir_bt.Name = "salir_bt"
        Me.salir_bt.Size = New System.Drawing.Size(150, 515)
        Me.salir_bt.TabIndex = 2
        Me.salir_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salir_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ttConsejo.SetToolTip(Me.salir_bt, "Salir del programa")
        Me.salir_bt.UseVisualStyleBackColor = False
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
        'nombre_txt
        '
        Me.nombre_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.nombre_txt.Location = New System.Drawing.Point(126, 40)
        Me.nombre_txt.Name = "nombre_txt"
        Me.nombre_txt.Size = New System.Drawing.Size(556, 33)
        Me.nombre_txt.TabIndex = 0
        Me.ttConsejo.SetToolTip(Me.nombre_txt, "Introduce el nombre")
        '
        'fijo_txt
        '
        Me.fijo_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.fijo_txt.Location = New System.Drawing.Point(117, 189)
        Me.fijo_txt.Name = "fijo_txt"
        Me.fijo_txt.Size = New System.Drawing.Size(166, 33)
        Me.fijo_txt.TabIndex = 3
        Me.ttConsejo.SetToolTip(Me.fijo_txt, "Introduce el número de teléfono")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(6, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 30)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "FECHA DE NACIMIENTO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(6, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 30)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "FIJO:"
        '
        'apellidos_txt
        '
        Me.apellidos_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.apellidos_txt.Location = New System.Drawing.Point(155, 90)
        Me.apellidos_txt.Name = "apellidos_txt"
        Me.apellidos_txt.Size = New System.Drawing.Size(527, 33)
        Me.apellidos_txt.TabIndex = 1
        Me.ttConsejo.SetToolTip(Me.apellidos_txt, "Introduce los apellidos")
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
        'observaciones_txt
        '
        Me.observaciones_txt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.observaciones_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.observaciones_txt.Location = New System.Drawing.Point(3, 371)
        Me.observaciones_txt.Multiline = True
        Me.observaciones_txt.Name = "observaciones_txt"
        Me.observaciones_txt.Size = New System.Drawing.Size(682, 141)
        Me.observaciones_txt.TabIndex = 5
        Me.ttConsejo.SetToolTip(Me.observaciones_txt, "Introducir observaciones")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(242, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 30)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "OBSERVACIONES:"
        '
        'datos_gb
        '
        Me.datos_gb.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.datos_gb.Controls.Add(Me.Label7)
        Me.datos_gb.Controls.Add(Me.correo_txt)
        Me.datos_gb.Controls.Add(Me.Label6)
        Me.datos_gb.Controls.Add(Me.movil_txt)
        Me.datos_gb.Controls.Add(Me.guardar_bt)
        Me.datos_gb.Controls.Add(Me.fecha_dtp)
        Me.datos_gb.Controls.Add(Me.observaciones_txt)
        Me.datos_gb.Controls.Add(Me.Label5)
        Me.datos_gb.Controls.Add(Me.apellidos_txt)
        Me.datos_gb.Controls.Add(Me.Label4)
        Me.datos_gb.Controls.Add(Me.Label3)
        Me.datos_gb.Controls.Add(Me.fijo_txt)
        Me.datos_gb.Controls.Add(Me.Label2)
        Me.datos_gb.Controls.Add(Me.nombre_txt)
        Me.datos_gb.Controls.Add(Me.Label1)
        Me.datos_gb.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.datos_gb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datos_gb.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.datos_gb.Location = New System.Drawing.Point(150, 33)
        Me.datos_gb.Name = "datos_gb"
        Me.datos_gb.Size = New System.Drawing.Size(688, 515)
        Me.datos_gb.TabIndex = 0
        Me.datos_gb.TabStop = False
        Me.datos_gb.Text = "INTRODUCIR DATOS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(6, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 30)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "E-MAIL:"
        '
        'correo_txt
        '
        Me.correo_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.correo_txt.Location = New System.Drawing.Point(117, 286)
        Me.correo_txt.Name = "correo_txt"
        Me.correo_txt.Size = New System.Drawing.Size(347, 33)
        Me.correo_txt.TabIndex = 116
        Me.ttConsejo.SetToolTip(Me.correo_txt, "Introduce el correo electrónico")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(6, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 30)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "MÓVIL:"
        '
        'movil_txt
        '
        Me.movil_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.movil_txt.Location = New System.Drawing.Point(117, 239)
        Me.movil_txt.Name = "movil_txt"
        Me.movil_txt.Size = New System.Drawing.Size(166, 33)
        Me.movil_txt.TabIndex = 4
        Me.ttConsejo.SetToolTip(Me.movil_txt, "Introduce el número de teléfono")
        '
        'guardar_bt
        '
        Me.guardar_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.guardar_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.guardar128
        Me.guardar_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.guardar_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.guardar_bt.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.guardar_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.guardar_bt.Location = New System.Drawing.Point(470, 140)
        Me.guardar_bt.Name = "guardar_bt"
        Me.guardar_bt.Size = New System.Drawing.Size(212, 180)
        Me.guardar_bt.TabIndex = 6
        Me.guardar_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttConsejo.SetToolTip(Me.guardar_bt, "Guardar ficha cliente")
        Me.guardar_bt.UseVisualStyleBackColor = False
        '
        'fecha_dtp
        '
        Me.fecha_dtp.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.fecha_dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_dtp.Location = New System.Drawing.Point(298, 140)
        Me.fecha_dtp.Name = "fecha_dtp"
        Me.fecha_dtp.Size = New System.Drawing.Size(166, 33)
        Me.fecha_dtp.TabIndex = 2
        Me.ttConsejo.SetToolTip(Me.fecha_dtp, "Escoge la fecha de nacimiento")
        '
        'EsteticaDataset
        '
        Me.EsteticaDataset.DataSetName = "EsteticaDataset"
        Me.EsteticaDataset.EnforceConstraints = False
        Me.EsteticaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBS
        '
        Me.ClientesBS.DataMember = "clientes"
        Me.ClientesBS.DataSource = Me.EsteticaDataset
        '
        'ClientesTA
        '
        Me.ClientesTA.ClearBeforeFill = True
        '
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.MenuStrip1.Size = New System.Drawing.Size(988, 33)
        Me.MenuStrip1.TabIndex = 102
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
        'Cliente_Nuevo_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Estetica.My.MySettings.Default.Fondo
        Me.ClientSize = New System.Drawing.Size(988, 548)
        Me.Controls.Add(Me.datos_gb)
        Me.Controls.Add(Me.salir_bt)
        Me.Controls.Add(Me.volver_bt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Fondo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cliente_Nuevo_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NUEVO CLIENTE"
        Me.datos_gb.ResumeLayout(False)
        Me.datos_gb.PerformLayout()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents volver_bt As System.Windows.Forms.Button
    Friend WithEvents salir_bt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nombre_txt As System.Windows.Forms.TextBox
    Friend WithEvents fijo_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents apellidos_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents observaciones_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents datos_gb As System.Windows.Forms.GroupBox
    Friend WithEvents guardar_bt As System.Windows.Forms.Button
    Friend WithEvents fecha_dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents EsteticaDataset As Estetica.EsteticaDataset
    Friend WithEvents ClientesBS As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTA As Estetica.EsteticaDatasetTableAdapters.clientesTableAdapter
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents hora_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fecha_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents movil_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents correo_txt As System.Windows.Forms.TextBox
End Class
