<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Dependientas_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Dependientas_frm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.hora_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.fecha_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.volver_bt = New System.Windows.Forms.Button
        Me.salir_bt = New System.Windows.Forms.Button
        Me.historial_pn = New System.Windows.Forms.Panel
        Me.historial_bt = New System.Windows.Forms.Button
        Me.nuevo_pn = New System.Windows.Forms.Panel
        Me.nuevo_bt = New System.Windows.Forms.Button
        Me.turnos_pn = New System.Windows.Forms.Panel
        Me.turnos_bt = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.historial_pn.SuspendLayout()
        Me.nuevo_pn.SuspendLayout()
        Me.turnos_pn.SuspendLayout()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1305, 33)
        Me.MenuStrip1.TabIndex = 89
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
        Me.volver_bt.Size = New System.Drawing.Size(150, 162)
        Me.volver_bt.TabIndex = 94
        Me.volver_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.salir_bt.Location = New System.Drawing.Point(1155, 33)
        Me.salir_bt.Name = "salir_bt"
        Me.salir_bt.Size = New System.Drawing.Size(150, 162)
        Me.salir_bt.TabIndex = 93
        Me.salir_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salir_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.salir_bt.UseVisualStyleBackColor = False
        '
        'historial_pn
        '
        Me.historial_pn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.historial_pn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.historial_pn.Controls.Add(Me.historial_bt)
        Me.historial_pn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.historial_pn.Dock = System.Windows.Forms.DockStyle.Left
        Me.historial_pn.Location = New System.Drawing.Point(485, 33)
        Me.historial_pn.Name = "historial_pn"
        Me.historial_pn.Size = New System.Drawing.Size(335, 162)
        Me.historial_pn.TabIndex = 92
        '
        'historial_bt
        '
        Me.historial_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.historial_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.historial_bt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.historial_bt.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.historial_bt.Image = Global.Estetica.My.Resources.Resources.historial
        Me.historial_bt.Location = New System.Drawing.Point(0, 0)
        Me.historial_bt.Name = "historial_bt"
        Me.historial_bt.Size = New System.Drawing.Size(331, 158)
        Me.historial_bt.TabIndex = 0
        Me.historial_bt.Text = "HISTORIAL"
        Me.historial_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.historial_bt.UseVisualStyleBackColor = False
        '
        'nuevo_pn
        '
        Me.nuevo_pn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.nuevo_pn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nuevo_pn.Controls.Add(Me.nuevo_bt)
        Me.nuevo_pn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nuevo_pn.Dock = System.Windows.Forms.DockStyle.Left
        Me.nuevo_pn.Location = New System.Drawing.Point(150, 33)
        Me.nuevo_pn.Name = "nuevo_pn"
        Me.nuevo_pn.Size = New System.Drawing.Size(335, 162)
        Me.nuevo_pn.TabIndex = 91
        '
        'nuevo_bt
        '
        Me.nuevo_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.nuevo_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nuevo_bt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nuevo_bt.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.nuevo_bt.Image = Global.Estetica.My.Resources.Resources.nuevo128
        Me.nuevo_bt.Location = New System.Drawing.Point(0, 0)
        Me.nuevo_bt.Name = "nuevo_bt"
        Me.nuevo_bt.Size = New System.Drawing.Size(331, 158)
        Me.nuevo_bt.TabIndex = 0
        Me.nuevo_bt.Text = "NUEVA DEPENDIENTA"
        Me.nuevo_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.nuevo_bt.UseVisualStyleBackColor = False
        '
        'turnos_pn
        '
        Me.turnos_pn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.turnos_pn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.turnos_pn.Controls.Add(Me.turnos_bt)
        Me.turnos_pn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.turnos_pn.Dock = System.Windows.Forms.DockStyle.Right
        Me.turnos_pn.Location = New System.Drawing.Point(820, 33)
        Me.turnos_pn.Name = "turnos_pn"
        Me.turnos_pn.Size = New System.Drawing.Size(335, 162)
        Me.turnos_pn.TabIndex = 95
        '
        'turnos_bt
        '
        Me.turnos_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.turnos_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.turnos_bt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.turnos_bt.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.turnos_bt.Image = Global.Estetica.My.Resources.Resources.turno
        Me.turnos_bt.Location = New System.Drawing.Point(0, 0)
        Me.turnos_bt.Name = "turnos_bt"
        Me.turnos_bt.Size = New System.Drawing.Size(331, 158)
        Me.turnos_bt.TabIndex = 0
        Me.turnos_bt.Text = "HORARIOS"
        Me.turnos_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.turnos_bt.UseVisualStyleBackColor = False
        '
        'Menu_Dependientas_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Estetica.My.MySettings.Default.Fondo
        Me.ClientSize = New System.Drawing.Size(1305, 195)
        Me.Controls.Add(Me.turnos_pn)
        Me.Controls.Add(Me.historial_pn)
        Me.Controls.Add(Me.nuevo_pn)
        Me.Controls.Add(Me.volver_bt)
        Me.Controls.Add(Me.salir_bt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Fondo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Menu_Dependientas_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DEPENDIENTAS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.historial_pn.ResumeLayout(False)
        Me.nuevo_pn.ResumeLayout(False)
        Me.turnos_pn.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents hora_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fecha_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents volver_bt As System.Windows.Forms.Button
    Friend WithEvents salir_bt As System.Windows.Forms.Button
    Friend WithEvents historial_pn As System.Windows.Forms.Panel
    Friend WithEvents historial_bt As System.Windows.Forms.Button
    Friend WithEvents nuevo_pn As System.Windows.Forms.Panel
    Friend WithEvents nuevo_bt As System.Windows.Forms.Button
    Friend WithEvents turnos_pn As System.Windows.Forms.Panel
    Friend WithEvents turnos_bt As System.Windows.Forms.Button
End Class
