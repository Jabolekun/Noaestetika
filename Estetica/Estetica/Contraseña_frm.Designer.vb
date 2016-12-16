<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contraseña_frm
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
        Me.contraseña_txt = New System.Windows.Forms.TextBox
        Me.Entrar_bt = New System.Windows.Forms.Button
        Me.EsteticaDataset = New Estetica.EsteticaDataset
        Me.ContraseñaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContraseñaTableAdapter = New Estetica.EsteticaDatasetTableAdapters.contraseñaTableAdapter
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContraseñaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(594, 493)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Introduce la contraseña"
        '
        'contraseña_txt
        '
        Me.contraseña_txt.Location = New System.Drawing.Point(863, 493)
        Me.contraseña_txt.Name = "contraseña_txt"
        Me.contraseña_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contraseña_txt.Size = New System.Drawing.Size(100, 33)
        Me.contraseña_txt.TabIndex = 0
        '
        'Entrar_bt
        '
        Me.Entrar_bt.BackColor = Global.Estetica.My.MySettings.Default.Resalto
        Me.Entrar_bt.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Estetica.My.MySettings.Default, "Resalto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Entrar_bt.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Entrar_bt.Location = New System.Drawing.Point(782, 530)
        Me.Entrar_bt.Name = "Entrar_bt"
        Me.Entrar_bt.Size = New System.Drawing.Size(142, 52)
        Me.Entrar_bt.TabIndex = 2
        Me.Entrar_bt.Text = "ENTRAR"
        Me.Entrar_bt.UseVisualStyleBackColor = False
        '
        'EsteticaDataset
        '
        Me.EsteticaDataset.DataSetName = "EsteticaDataset"
        Me.EsteticaDataset.EnforceConstraints = False
        Me.EsteticaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContraseñaBindingSource
        '
        Me.ContraseñaBindingSource.DataMember = "contraseña"
        Me.ContraseñaBindingSource.DataSource = Me.EsteticaDataset
        '
        'ContraseñaTableAdapter
        '
        Me.ContraseñaTableAdapter.ClearBeforeFill = True
        '
        'Contraseña_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Estetica.My.Resources.Resources.LOGOFONDOGRIS
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(994, 594)
        Me.ControlBox = False
        Me.Controls.Add(Me.Entrar_bt)
        Me.Controls.Add(Me.contraseña_txt)
        Me.Controls.Add(Me.Label1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.Estetica.My.MySettings.Default, "Fuente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = Global.Estetica.My.MySettings.Default.Fuente
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Contraseña_frm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.EsteticaDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContraseñaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents contraseña_txt As System.Windows.Forms.TextBox
    Friend WithEvents Entrar_bt As System.Windows.Forms.Button
    Friend WithEvents EsteticaDataset As Estetica.EsteticaDataset
    Friend WithEvents ContraseñaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContraseñaTableAdapter As Estetica.EsteticaDatasetTableAdapters.contraseñaTableAdapter
End Class
