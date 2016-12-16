<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio_frm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.version_lb = New System.Windows.Forms.Label
        Me.porcentaje_txt = New System.Windows.Forms.Label
        Me.barra = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(516, 530)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Iniciando el programa..."
        '
        'tiempo
        '
        Me.tiempo.Interval = 40
        '
        'version_lb
        '
        Me.version_lb.AutoSize = True
        Me.version_lb.BackColor = System.Drawing.Color.Transparent
        Me.version_lb.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version_lb.ForeColor = System.Drawing.Color.Red
        Me.version_lb.Location = New System.Drawing.Point(812, 557)
        Me.version_lb.Name = "version_lb"
        Me.version_lb.Size = New System.Drawing.Size(50, 16)
        Me.version_lb.TabIndex = 16
        Me.version_lb.Text = "Label2"
        '
        'porcentaje_txt
        '
        Me.porcentaje_txt.AutoSize = True
        Me.porcentaje_txt.BackColor = System.Drawing.Color.Transparent
        Me.porcentaje_txt.Location = New System.Drawing.Point(779, 557)
        Me.porcentaje_txt.Name = "porcentaje_txt"
        Me.porcentaje_txt.Size = New System.Drawing.Size(57, 13)
        Me.porcentaje_txt.TabIndex = 15
        Me.porcentaje_txt.Text = "porcentaje"
        '
        'barra
        '
        Me.barra.ForeColor = System.Drawing.Color.GreenYellow
        Me.barra.Location = New System.Drawing.Point(520, 557)
        Me.barra.Minimum = 1
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(253, 15)
        Me.barra.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.barra.TabIndex = 14
        Me.barra.Value = 1
        '
        'Inicio_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Estetica.My.Resources.Resources.LOGOFONDOGRIS
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.version_lb)
        Me.Controls.Add(Me.porcentaje_txt)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inicio_frm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tiempo As System.Windows.Forms.Timer
    Friend WithEvents version_lb As System.Windows.Forms.Label
    Friend WithEvents porcentaje_txt As System.Windows.Forms.Label
    Friend WithEvents barra As System.Windows.Forms.ProgressBar

End Class
