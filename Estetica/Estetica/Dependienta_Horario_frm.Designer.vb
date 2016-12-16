<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dependienta_Horario_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dependienta_Horario_frm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.volver_bt = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.hora_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.fecha_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.salir_bt = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.guardar_bt = New System.Windows.Forms.Button
        Me.duracion_txt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.mañana_chk = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.mfin_dtp = New System.Windows.Forms.DateTimePicker
        Me.minicio_dtp = New System.Windows.Forms.DateTimePicker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.tarde_chk = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tfin_dtp = New System.Windows.Forms.DateTimePicker
        Me.tinicio_dtp = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dependienta_cb = New System.Windows.Forms.ComboBox
        Me.DependientasBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.EsteticaDataset = New Estetica.EsteticaDataset
        Me.TurnosBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.TurnosTA = New Estetica.EsteticaDatasetTableAdapters.turnosTableAdapter
        Me.DependientasTA = New Estetica.EsteticaDatasetTableAdapters.dependientasTableAdapter
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DependientasBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnosBS, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.volver_bt.Size = New System.Drawing.Size(150, 242)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1103, 33)
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
        Me.salir_bt.Location = New System.Drawing.Point(953, 33)
        Me.salir_bt.Name = "salir_bt"
        Me.salir_bt.Size = New System.Drawing.Size(150, 242)
        Me.salir_bt.TabIndex = 100
        Me.salir_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salir_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.salir_bt.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.GroupBox1.Controls.Add(Me.guardar_bt)
        Me.GroupBox1.Controls.Add(Me.duracion_txt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dependienta_cb)
        Me.GroupBox1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(150, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(803, 242)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ESCOGER HORARIO"
        '
        'guardar_bt
        '
        Me.guardar_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.guardar_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.guardar64
        Me.guardar_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.guardar_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.guardar_bt.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.guardar_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.guardar_bt.Location = New System.Drawing.Point(715, 26)
        Me.guardar_bt.Name = "guardar_bt"
        Me.guardar_bt.Size = New System.Drawing.Size(80, 80)
        Me.guardar_bt.TabIndex = 125
        Me.guardar_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttConsejo.SetToolTip(Me.guardar_bt, "Guardar horario")
        Me.guardar_bt.UseVisualStyleBackColor = False
        '
        'duracion_txt
        '
        Me.duracion_txt.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.duracion_txt.Location = New System.Drawing.Point(564, 72)
        Me.duracion_txt.Name = "duracion_txt"
        Me.duracion_txt.ReadOnly = True
        Me.duracion_txt.Size = New System.Drawing.Size(145, 33)
        Me.duracion_txt.TabIndex = 124
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(559, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 30)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "DURACIÓN:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.mañana_chk)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.mfin_dtp)
        Me.Panel2.Controls.Add(Me.minicio_dtp)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(797, 64)
        Me.Panel2.TabIndex = 122
        '
        'mañana_chk
        '
        Me.mañana_chk.AutoSize = True
        Me.mañana_chk.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.mañana_chk.Location = New System.Drawing.Point(9, 17)
        Me.mañana_chk.Name = "mañana_chk"
        Me.mañana_chk.Size = New System.Drawing.Size(130, 34)
        Me.mañana_chk.TabIndex = 127
        Me.mañana_chk.Text = "MAÑANA"
        Me.mañana_chk.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(499, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 30)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "FIN:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(155, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 30)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "INICIO:"
        '
        'mfin_dtp
        '
        Me.mfin_dtp.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.mfin_dtp.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.mfin_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mfin_dtp.Location = New System.Drawing.Point(565, 18)
        Me.mfin_dtp.Name = "mfin_dtp"
        Me.mfin_dtp.ShowUpDown = True
        Me.mfin_dtp.Size = New System.Drawing.Size(225, 33)
        Me.mfin_dtp.TabIndex = 124
        Me.ttConsejo.SetToolTip(Me.mfin_dtp, "Escoger fin")
        '
        'minicio_dtp
        '
        Me.minicio_dtp.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.minicio_dtp.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.minicio_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.minicio_dtp.Location = New System.Drawing.Point(263, 19)
        Me.minicio_dtp.Name = "minicio_dtp"
        Me.minicio_dtp.ShowUpDown = True
        Me.minicio_dtp.Size = New System.Drawing.Size(225, 33)
        Me.minicio_dtp.TabIndex = 123
        Me.ttConsejo.SetToolTip(Me.minicio_dtp, "Escoger inicio")
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.tarde_chk)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tfin_dtp)
        Me.Panel1.Controls.Add(Me.tinicio_dtp)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 175)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(797, 64)
        Me.Panel1.TabIndex = 121
        '
        'tarde_chk
        '
        Me.tarde_chk.AutoSize = True
        Me.tarde_chk.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.tarde_chk.Location = New System.Drawing.Point(9, 17)
        Me.tarde_chk.Name = "tarde_chk"
        Me.tarde_chk.Size = New System.Drawing.Size(103, 34)
        Me.tarde_chk.TabIndex = 127
        Me.tarde_chk.Text = "TARDE"
        Me.tarde_chk.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(499, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 30)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "FIN:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(155, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 30)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "INICIO:"
        '
        'tfin_dtp
        '
        Me.tfin_dtp.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.tfin_dtp.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.tfin_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tfin_dtp.Location = New System.Drawing.Point(568, 18)
        Me.tfin_dtp.Name = "tfin_dtp"
        Me.tfin_dtp.ShowUpDown = True
        Me.tfin_dtp.Size = New System.Drawing.Size(222, 33)
        Me.tfin_dtp.TabIndex = 124
        Me.ttConsejo.SetToolTip(Me.tfin_dtp, "Escoger fin")
        '
        'tinicio_dtp
        '
        Me.tinicio_dtp.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.tinicio_dtp.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.tinicio_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tinicio_dtp.Location = New System.Drawing.Point(263, 19)
        Me.tinicio_dtp.Name = "tinicio_dtp"
        Me.tinicio_dtp.ShowUpDown = True
        Me.tinicio_dtp.Size = New System.Drawing.Size(225, 33)
        Me.tinicio_dtp.TabIndex = 123
        Me.ttConsejo.SetToolTip(Me.tinicio_dtp, "Escoger inicio")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(9, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 30)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "DEPENDIENTA:"
        '
        'dependienta_cb
        '
        Me.dependienta_cb.DataSource = Me.DependientasBS
        Me.dependienta_cb.DisplayMember = "Dependienta"
        Me.dependienta_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dependienta_cb.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.dependienta_cb.FormattingEnabled = True
        Me.dependienta_cb.Location = New System.Drawing.Point(14, 73)
        Me.dependienta_cb.Name = "dependienta_cb"
        Me.dependienta_cb.Size = New System.Drawing.Size(479, 33)
        Me.dependienta_cb.TabIndex = 113
        Me.ttConsejo.SetToolTip(Me.dependienta_cb, "Escoger dependienta")
        Me.dependienta_cb.ValueMember = "CodDependienta"
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
        'TurnosBS
        '
        Me.TurnosBS.DataMember = "turnos"
        Me.TurnosBS.DataSource = Me.EsteticaDataset
        '
        'TurnosTA
        '
        Me.TurnosTA.ClearBeforeFill = True
        '
        'DependientasTA
        '
        Me.DependientasTA.ClearBeforeFill = True
        '
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'Dependienta_Horario_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Estetica.My.MySettings.Default.Fondo
        Me.ClientSize = New System.Drawing.Size(1103, 275)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.salir_bt)
        Me.Controls.Add(Me.volver_bt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Fondo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dependienta_Horario_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HORARIO DEPENDIENTAS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DependientasBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnosBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents volver_bt As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents hora_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fecha_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents salir_bt As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dependienta_cb As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents duracion_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents mañana_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mfin_dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents minicio_dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tarde_chk As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tfin_dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents tinicio_dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents EsteticaDataset As Estetica.EsteticaDataset
    Friend WithEvents TurnosBS As System.Windows.Forms.BindingSource
    Friend WithEvents TurnosTA As Estetica.EsteticaDatasetTableAdapters.turnosTableAdapter
    Friend WithEvents DependientasBS As System.Windows.Forms.BindingSource
    Friend WithEvents DependientasTA As Estetica.EsteticaDatasetTableAdapters.dependientasTableAdapter
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip
    Friend WithEvents guardar_bt As System.Windows.Forms.Button
End Class
