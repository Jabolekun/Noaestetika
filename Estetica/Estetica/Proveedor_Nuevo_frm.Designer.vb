<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedor_Nuevo_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedor_Nuevo_frm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.hora_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.fecha_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.volver_bt = New System.Windows.Forms.Button
        Me.datos_gb = New System.Windows.Forms.GroupBox
        Me.tlfcomercial_txt = New System.Windows.Forms.TextBox
        Me.comercial_txt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.direccion_txt = New System.Windows.Forms.TextBox
        Me.telefono_txt = New System.Windows.Forms.TextBox
        Me.guardar_bt = New System.Windows.Forms.Button
        Me.correo_txt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.nombre_txt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        Me.salir_bt = New System.Windows.Forms.Button
        Me.EsteticaDataset = New Estetica.EsteticaDataset
        Me.ProveedoresBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTA = New Estetica.EsteticaDatasetTableAdapters.proveedoresTableAdapter
        Me.MenuStrip1.SuspendLayout()
        Me.datos_gb.SuspendLayout()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBS, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(981, 33)
        Me.MenuStrip1.TabIndex = 106
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
        Me.volver_bt.Size = New System.Drawing.Size(150, 377)
        Me.volver_bt.TabIndex = 105
        Me.volver_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttConsejo.SetToolTip(Me.volver_bt, "Volver")
        Me.volver_bt.UseVisualStyleBackColor = False
        '
        'datos_gb
        '
        Me.datos_gb.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.datos_gb.Controls.Add(Me.tlfcomercial_txt)
        Me.datos_gb.Controls.Add(Me.comercial_txt)
        Me.datos_gb.Controls.Add(Me.Label6)
        Me.datos_gb.Controls.Add(Me.Label5)
        Me.datos_gb.Controls.Add(Me.direccion_txt)
        Me.datos_gb.Controls.Add(Me.telefono_txt)
        Me.datos_gb.Controls.Add(Me.guardar_bt)
        Me.datos_gb.Controls.Add(Me.correo_txt)
        Me.datos_gb.Controls.Add(Me.Label4)
        Me.datos_gb.Controls.Add(Me.Label3)
        Me.datos_gb.Controls.Add(Me.Label2)
        Me.datos_gb.Controls.Add(Me.nombre_txt)
        Me.datos_gb.Controls.Add(Me.Label1)
        Me.datos_gb.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.datos_gb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datos_gb.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.datos_gb.Location = New System.Drawing.Point(150, 33)
        Me.datos_gb.Name = "datos_gb"
        Me.datos_gb.Size = New System.Drawing.Size(681, 377)
        Me.datos_gb.TabIndex = 103
        Me.datos_gb.TabStop = False
        Me.datos_gb.Text = "INTRODUCIR DATOS"
        '
        'tlfcomercial_txt
        '
        Me.tlfcomercial_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.tlfcomercial_txt.Location = New System.Drawing.Point(531, 190)
        Me.tlfcomercial_txt.Name = "tlfcomercial_txt"
        Me.tlfcomercial_txt.Size = New System.Drawing.Size(144, 33)
        Me.tlfcomercial_txt.TabIndex = 119
        Me.ttConsejo.SetToolTip(Me.tlfcomercial_txt, "Introduce el número de teléfono")
        '
        'comercial_txt
        '
        Me.comercial_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.comercial_txt.Location = New System.Drawing.Point(160, 190)
        Me.comercial_txt.Name = "comercial_txt"
        Me.comercial_txt.Size = New System.Drawing.Size(288, 33)
        Me.comercial_txt.TabIndex = 118
        Me.ttConsejo.SetToolTip(Me.comercial_txt, "Introduce el número de teléfono")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(454, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 30)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "TLF.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(6, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 30)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "COMERCIAL:"
        '
        'direccion_txt
        '
        Me.direccion_txt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.direccion_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.direccion_txt.Location = New System.Drawing.Point(3, 271)
        Me.direccion_txt.Multiline = True
        Me.direccion_txt.Name = "direccion_txt"
        Me.direccion_txt.Size = New System.Drawing.Size(675, 103)
        Me.direccion_txt.TabIndex = 115
        Me.ttConsejo.SetToolTip(Me.direccion_txt, "Introduce la dirección")
        '
        'telefono_txt
        '
        Me.telefono_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.telefono_txt.Location = New System.Drawing.Point(191, 140)
        Me.telefono_txt.Name = "telefono_txt"
        Me.telefono_txt.Size = New System.Drawing.Size(257, 33)
        Me.telefono_txt.TabIndex = 114
        Me.ttConsejo.SetToolTip(Me.telefono_txt, "Introduce el número de teléfono")
        '
        'guardar_bt
        '
        Me.guardar_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.guardar_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.guardar128
        Me.guardar_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.guardar_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.guardar_bt.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.guardar_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.guardar_bt.Location = New System.Drawing.Point(459, 25)
        Me.guardar_bt.Name = "guardar_bt"
        Me.guardar_bt.Size = New System.Drawing.Size(216, 146)
        Me.guardar_bt.TabIndex = 113
        Me.guardar_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttConsejo.SetToolTip(Me.guardar_bt, "Guardar ficha cliente")
        Me.guardar_bt.UseVisualStyleBackColor = False
        '
        'correo_txt
        '
        Me.correo_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.correo_txt.Location = New System.Drawing.Point(157, 90)
        Me.correo_txt.Name = "correo_txt"
        Me.correo_txt.Size = New System.Drawing.Size(291, 33)
        Me.correo_txt.TabIndex = 1
        Me.ttConsejo.SetToolTip(Me.correo_txt, "Introduce el correo")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 30)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "DIRECCIÓN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(6, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 30)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "E-MAIL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(6, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 30)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "TLF. EMPRESA:"
        '
        'nombre_txt
        '
        Me.nombre_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.nombre_txt.Location = New System.Drawing.Point(157, 40)
        Me.nombre_txt.Name = "nombre_txt"
        Me.nombre_txt.Size = New System.Drawing.Size(291, 33)
        Me.nombre_txt.TabIndex = 0
        Me.ttConsejo.SetToolTip(Me.nombre_txt, "Introduce el nombre")
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.salir_bt.Location = New System.Drawing.Point(831, 33)
        Me.salir_bt.Name = "salir_bt"
        Me.salir_bt.Size = New System.Drawing.Size(150, 377)
        Me.salir_bt.TabIndex = 104
        Me.salir_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salir_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ttConsejo.SetToolTip(Me.salir_bt, "Salir del programa")
        Me.salir_bt.UseVisualStyleBackColor = False
        '
        'EsteticaDataset
        '
        Me.EsteticaDataset.DataSetName = "EsteticaDataset"
        Me.EsteticaDataset.EnforceConstraints = False
        Me.EsteticaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresBS
        '
        Me.ProveedoresBS.DataMember = "proveedores"
        Me.ProveedoresBS.DataSource = Me.EsteticaDataset
        '
        'ProveedoresTA
        '
        Me.ProveedoresTA.ClearBeforeFill = True
        '
        'Proveedor_Nuevo_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Estetica.My.MySettings.Default.Fondo
        Me.ClientSize = New System.Drawing.Size(981, 410)
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
        Me.Name = "Proveedor_Nuevo_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NUEVO PROVEEDOR"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.datos_gb.ResumeLayout(False)
        Me.datos_gb.PerformLayout()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents hora_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fecha_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents volver_bt As System.Windows.Forms.Button
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip
    Friend WithEvents datos_gb As System.Windows.Forms.GroupBox
    Friend WithEvents guardar_bt As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nombre_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents salir_bt As System.Windows.Forms.Button
    Friend WithEvents telefono_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents direccion_txt As System.Windows.Forms.TextBox
    Friend WithEvents correo_txt As System.Windows.Forms.TextBox
    Friend WithEvents EsteticaDataset As Estetica.EsteticaDataset
    Friend WithEvents ProveedoresBS As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTA As Estetica.EsteticaDatasetTableAdapters.proveedoresTableAdapter
    Friend WithEvents tlfcomercial_txt As System.Windows.Forms.TextBox
    Friend WithEvents comercial_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
