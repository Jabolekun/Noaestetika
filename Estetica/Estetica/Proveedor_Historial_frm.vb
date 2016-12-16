Public Class Proveedor_Historial_frm

    Dim codproveedor As Integer

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                volver_bt.PerformClick()
        End Select
    End Sub

    Private Sub Proveedor_Historial_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dgestilo As New EstiloDataGrid(productos_dgv)
        DisableCloseButton(Me.Handle)
        fecha_txt.Text = Today
        hora_txt.Text = TimeOfDay
        ProveedoresTA.Fill(EsteticaDataset.proveedores)
        noeditar()
        Dim col As New AutoCompleteStringCollection
        NombreProveTA.Fill(EsteticaDataset.NombreProve)
        For x = 0 To EsteticaDataset.NombreProve.Rows.Count - 1
            col.Add(EsteticaDataset.NombreProve(x).Nombre)
        Next
        nombre_ts.AutoCompleteCustomSource = col
    End Sub

    'buscar por nombre
    Private Sub buscanombre_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscanombre_bt.Click
        If nombre_ts.Text = "" Then
            Exit Sub
        End If
        codproveedor = ProveedoresTA.nombre(nombre_ts.Text)
        For x = 0 To EsteticaDataset.proveedores.Rows.Count - 1
            If codproveedor = EsteticaDataset.proveedores(x).CodProveedor Then
                ProveedoresBS.Position = x
            End If
        Next
        nombre_ts.Text = ""
    End Sub

    'borrar proveedor
    Private Sub borrar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borrar_bt.Click
        Try
            If (MsgBox("Borrar proveedor " & nombre_txt.Text & "?", MsgBoxStyle.OkCancel, "BORRAR") = MsgBoxResult.Ok) Then
                ProveedoresTA.borrar(codproveedor)
                MsgBox("BORRADO OK", MsgBoxStyle.Information, "PROVEEDOR BORRADO")
                ProveedoresTA.Fill(EsteticaDataset.proveedores)
                Dim col As New AutoCompleteStringCollection
                NombreProveTA.Fill(EsteticaDataset.NombreProve)
                For x = 0 To EsteticaDataset.NombreProve.Rows.Count - 1
                    col.Add(EsteticaDataset.NombreProve(x).Nombre)
                Next
                nombre_ts.AutoCompleteCustomSource = col
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub editar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editar_bt.Click
        editar()
    End Sub

    Private Sub guardar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar_bt.Click
        If nombre_txt.Text = "" Then
            MsgBox("Introduce el nombre del proveedor.", MsgBoxStyle.Exclamation, "FALTAN DATOS")
            Exit Sub
        End If
        If (MsgBox("Guardar datos del proveedor?", MsgBoxStyle.OkCancel, "GUARDAR") = MsgBoxResult.Ok) Then
            ProveedoresTA.actualizar(nombre_txt.Text, direccion_txt.Text, telefono_txt.Text, comercial_txt.Text, tlfcomercial_txt.Text, correo_txt.Text, codproveedor)
            MsgBox("GUARDADO OK", MsgBoxStyle.Information, "PROVEEDOR ACTUALIZADO")
        End If
        noeditar()
    End Sub

    Private Sub editar()
        For Each ctrl In datos_gb.Controls.OfType(Of TextBox)()
            ctrl.ReadOnly = False
        Next
        For Each ctrl In Panel2.Controls.OfType(Of TextBox)()
            ctrl.ReadOnly = False
        Next
        editar_bt.Enabled = False
        borrar_bt.Enabled = False
        guardar_bt.Enabled = True
    End Sub

    Private Sub noeditar()
        For Each ctrl In datos_gb.Controls.OfType(Of TextBox)()
            ctrl.ReadOnly = True
        Next
        For Each ctrl In Panel2.Controls.OfType(Of TextBox)()
            ctrl.ReadOnly = True
        Next
        editar_bt.Enabled = True
        borrar_bt.Enabled = True
        guardar_bt.Enabled = False
    End Sub

    Private Sub ProveedoresBS_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProveedoresBS.PositionChanged
        Try
            codproveedor = EsteticaDataset.proveedores(BindingNavigatorPositionItem.Text - 1).CodProveedor
            ProductosTA.proveedor(EsteticaDataset.productos, codproveedor)
            colorear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub productos_dgv_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles productos_dgv.CellClick
        colorear()
    End Sub

    'cambiar color a fila
    Private Sub colorear()
        For x = 0 To productos_dgv.Rows.Count - 1
            If productos_dgv.Rows(x).Cells(5).Value > productos_dgv.Rows(x).Cells(4).Value Then
                productos_dgv.Rows(x).DefaultCellStyle.BackColor = Color.Red
                productos_dgv.Rows(x).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    'stock del proveedor
    Private Sub proveedor_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proveedor_bt.Click

    End Sub

    'stock total
    Private Sub stock_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stock_bt.Click

    End Sub

    Private Sub volver_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volver_bt.Click
        Dim frm As New Menu_proveedores_frm
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub salir_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir_bt.Click
        salir(Me)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        hora_txt.Text = TimeOfDay
    End Sub
End Class