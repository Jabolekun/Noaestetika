<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_frm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cliente_pn = New System.Windows.Forms.Panel
        Me.cliente_bt = New System.Windows.Forms.Button
        Me.dependienta_pn = New System.Windows.Forms.Panel
        Me.dependienta_bt = New System.Windows.Forms.Button
        Me.producto_pn = New System.Windows.Forms.Panel
        Me.producto_bt = New System.Windows.Forms.Button
        Me.productos_pn = New System.Windows.Forms.Panel
        Me.proveedor_bt = New System.Windows.Forms.Button
        Me.tratamientos_pn = New System.Windows.Forms.Panel
        Me.tratamiento_bt = New System.Windows.Forms.Button
        Me.venta_pn = New System.Windows.Forms.Panel
        Me.venta_bt = New System.Windows.Forms.Button
        Me.salir_bt = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.hora_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.fecha_txt = New System.Windows.Forms.ToolStripMenuItem
        Me.cambiar_bt = New System.Windows.Forms.Button
        Me.cliente_pn.SuspendLayout()
        Me.dependienta_pn.SuspendLayout()
        Me.producto_pn.SuspendLayout()
        Me.productos_pn.SuspendLayout()
        Me.tratamientos_pn.SuspendLayout()
        Me.venta_pn.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'cliente_pn
        '
        Me.cliente_pn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.cliente_pn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cliente_pn.Controls.Add(Me.cliente_bt)
        Me.cliente_pn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cliente_pn.Location = New System.Drawing.Point(0, 34)
        Me.cliente_pn.Name = "cliente_pn"
        Me.cliente_pn.Size = New System.Drawing.Size(400, 200)
        Me.cliente_pn.TabIndex = 79
        '
        'cliente_bt
        '
        Me.cliente_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.cliente_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cliente_bt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cliente_bt.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.cliente_bt.Image = Global.Estetica.My.Resources.Resources.cliente128
        Me.cliente_bt.Location = New System.Drawing.Point(0, 0)
        Me.cliente_bt.Name = "cliente_bt"
        Me.cliente_bt.Size = New System.Drawing.Size(396, 196)
        Me.cliente_bt.TabIndex = 0
        Me.cliente_bt.Text = "CLIENTES"
        Me.cliente_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cliente_bt.UseVisualStyleBackColor = False
        '
        'dependienta_pn
        '
        Me.dependienta_pn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.dependienta_pn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dependienta_pn.Controls.Add(Me.dependienta_bt)
        Me.dependienta_pn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dependienta_pn.Location = New System.Drawing.Point(402, 34)
        Me.dependienta_pn.Name = "dependienta_pn"
        Me.dependienta_pn.Size = New System.Drawing.Size(400, 200)
        Me.dependienta_pn.TabIndex = 80
        '
        'dependienta_bt
        '
        Me.dependienta_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.dependienta_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dependienta_bt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dependienta_bt.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.dependienta_bt.Image = Global.Estetica.My.Resources.Resources.dependienta128
        Me.dependienta_bt.Location = New System.Drawing.Point(0, 0)
        Me.dependienta_bt.Name = "dependienta_bt"
        Me.dependienta_bt.Size = New System.Drawing.Size(396, 196)
        Me.dependienta_bt.TabIndex = 0
        Me.dependienta_bt.Text = "DEPENDIENTAS"
        Me.dependienta_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.dependienta_bt.UseVisualStyleBackColor = False
        '
        'producto_pn
        '
        Me.producto_pn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.producto_pn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.producto_pn.Controls.Add(Me.producto_bt)
        Me.producto_pn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.producto_pn.Location = New System.Drawing.Point(804, 34)
        Me.producto_pn.Name = "producto_pn"
        Me.producto_pn.Size = New System.Drawing.Size(400, 200)
        Me.producto_pn.TabIndex = 81
        '
        'producto_bt
        '
        Me.producto_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.producto_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.producto_bt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.producto_bt.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.producto_bt.Image = Global.Estetica.My.Resources.Resources.productos128
        Me.producto_bt.Location = New System.Drawing.Point(0, 0)
        Me.producto_bt.Name = "producto_bt"
        Me.producto_bt.Size = New System.Drawing.Size(396, 196)
        Me.producto_bt.TabIndex = 0
        Me.producto_bt.Text = "PRODUCTOS"
        Me.producto_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.producto_bt.UseVisualStyleBackColor = False
        '
        'productos_pn
        '
        Me.productos_pn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.productos_pn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.productos_pn.Controls.Add(Me.proveedor_bt)
        Me.productos_pn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.productos_pn.Location = New System.Drawing.Point(0, 233)
        Me.productos_pn.Name = "productos_pn"
        Me.productos_pn.Size = New System.Drawing.Size(400, 200)
        Me.productos_pn.TabIndex = 82
        '
        'proveedor_bt
        '
        Me.proveedor_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.proveedor_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.proveedor_bt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.proveedor_bt.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.proveedor_bt.Image = Global.Estetica.My.Resources.Resources.proveedor128
        Me.proveedor_bt.Location = New System.Drawing.Point(0, 0)
        Me.proveedor_bt.Name = "proveedor_bt"
        Me.proveedor_bt.Size = New System.Drawing.Size(396, 196)
        Me.proveedor_bt.TabIndex = 0
        Me.proveedor_bt.Text = "PROVEEDORES"
        Me.proveedor_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.proveedor_bt.UseVisualStyleBackColor = False
        '
        'tratamientos_pn
        '
        Me.tratamientos_pn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.tratamientos_pn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tratamientos_pn.Controls.Add(Me.tratamiento_bt)
        Me.tratamientos_pn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tratamientos_pn.Location = New System.Drawing.Point(402, 233)
        Me.tratamientos_pn.Name = "tratamientos_pn"
        Me.tratamientos_pn.Size = New System.Drawing.Size(400, 200)
        Me.tratamientos_pn.TabIndex = 83
        '
        'tratamiento_bt
        '
        Me.tratamiento_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.tratamiento_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tratamiento_bt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tratamiento_bt.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.tratamiento_bt.Image = Global.Estetica.My.Resources.Resources.tratamientos128
        Me.tratamiento_bt.Location = New System.Drawing.Point(0, 0)
        Me.tratamiento_bt.Name = "tratamiento_bt"
        Me.tratamiento_bt.Size = New System.Drawing.Size(396, 196)
        Me.tratamiento_bt.TabIndex = 0
        Me.tratamiento_bt.Text = "TRATAMIENTOS"
        Me.tratamiento_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tratamiento_bt.UseVisualStyleBackColor = False
        '
        'venta_pn
        '
        Me.venta_pn.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.venta_pn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.venta_pn.Controls.Add(Me.venta_bt)
        Me.venta_pn.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.venta_pn.Location = New System.Drawing.Point(804, 233)
        Me.venta_pn.Name = "venta_pn"
        Me.venta_pn.Size = New System.Drawing.Size(400, 200)
        Me.venta_pn.TabIndex = 84
        '
        'venta_bt
        '
        Me.venta_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.venta_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.venta_bt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.venta_bt.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.venta_bt.Image = Global.Estetica.My.Resources.Resources.venta128
        Me.venta_bt.Location = New System.Drawing.Point(0, 0)
        Me.venta_bt.Name = "venta_bt"
        Me.venta_bt.Size = New System.Drawing.Size(396, 196)
        Me.venta_bt.TabIndex = 0
        Me.venta_bt.Text = "VENTA"
        Me.venta_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.venta_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.venta_bt.UseVisualStyleBackColor = False
        '
        'salir_bt
        '
        Me.salir_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.salir_bt.BackgroundImage = Global.Estetica.My.Resources.Resources.salir128
        Me.salir_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.salir_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.salir_bt.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.salir_bt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.salir_bt.Font = Global.Estetica.My.MySettings.Default.Titulo2
        Me.salir_bt.Location = New System.Drawing.Point(0, 567)
        Me.salir_bt.Name = "salir_bt"
        Me.salir_bt.Size = New System.Drawing.Size(1205, 134)
        Me.salir_bt.TabIndex = 85
        Me.salir_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salir_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.salir_bt.UseVisualStyleBackColor = False
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1205, 33)
        Me.MenuStrip1.TabIndex = 87
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
        'cambiar_bt
        '
        Me.cambiar_bt.BackColor = Global.Estetica.My.MySettings.Default.Botones
        Me.cambiar_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cambiar_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Botones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cambiar_bt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cambiar_bt.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.cambiar_bt.Image = Global.Estetica.My.Resources.Resources.contraseña128
        Me.cambiar_bt.Location = New System.Drawing.Point(0, 433)
        Me.cambiar_bt.Name = "cambiar_bt"
        Me.cambiar_bt.Size = New System.Drawing.Size(1205, 134)
        Me.cambiar_bt.TabIndex = 88
        Me.cambiar_bt.Text = "CAMBIAR CONTRASEÑA"
        Me.cambiar_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cambiar_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cambiar_bt.UseVisualStyleBackColor = False
        '
        'Menu_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.Estetica.My.MySettings.Default.Fondo
        Me.ClientSize = New System.Drawing.Size(1205, 701)
        Me.Controls.Add(Me.venta_pn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.tratamientos_pn)
        Me.Controls.Add(Me.productos_pn)
        Me.Controls.Add(Me.producto_pn)
        Me.Controls.Add(Me.dependienta_pn)
        Me.Controls.Add(Me.cliente_pn)
        Me.Controls.Add(Me.cambiar_bt)
        Me.Controls.Add(Me.salir_bt)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Fondo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Verdana", 15.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Menu_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.cliente_pn.ResumeLayout(False)
        Me.dependienta_pn.ResumeLayout(False)
        Me.producto_pn.ResumeLayout(False)
        Me.productos_pn.ResumeLayout(False)
        Me.tratamientos_pn.ResumeLayout(False)
        Me.venta_pn.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cliente_pn As System.Windows.Forms.Panel
    Friend WithEvents cliente_bt As System.Windows.Forms.Button
    Friend WithEvents dependienta_pn As System.Windows.Forms.Panel
    Friend WithEvents dependienta_bt As System.Windows.Forms.Button
    Friend WithEvents producto_pn As System.Windows.Forms.Panel
    Friend WithEvents producto_bt As System.Windows.Forms.Button
    Friend WithEvents productos_pn As System.Windows.Forms.Panel
    Friend WithEvents proveedor_bt As System.Windows.Forms.Button
    Friend WithEvents tratamientos_pn As System.Windows.Forms.Panel
    Friend WithEvents tratamiento_bt As System.Windows.Forms.Button
    Friend WithEvents venta_pn As System.Windows.Forms.Panel
    Friend WithEvents venta_bt As System.Windows.Forms.Button
    Friend WithEvents salir_bt As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents hora_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fecha_txt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cambiar_bt As System.Windows.Forms.Button
End Class
