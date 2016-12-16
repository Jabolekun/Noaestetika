Public Class Producto_Historial_frm

    Dim codproducto As String

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                volver_bt.PerformClick()
        End Select
    End Sub

    Private Sub Producto_Historial_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dgestilo As New EstiloDataGrid(ventas_dgv)
        Dim dgestilo2 As New EstiloDataGrid(compras_dgv)
        DisableCloseButton(Me.Handle)
        fecha_txt.Text = Today
        hora_txt.Text = TimeOfDay
        ProductosTA.Fill(EsteticaDataset.productos)
        noeditar()
        Dim col As New AutoCompleteStringCollection
        NombreProductoTA.Fill(EsteticaDataset.NombreProducto)
        For x = 0 To EsteticaDataset.NombreProducto.Rows.Count - 1
            col.Add(EsteticaDataset.NombreProducto(x).CodProducto)
        Next
        nombre_ts.AutoCompleteCustomSource = col
    End Sub

    'buscar por nombre
    Private Sub buscanombre_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscanombre_bt.Click
        If nombre_ts.Text = "" Then
            Exit Sub
        End If
        codproducto = nombre_ts.Text
        For x = 0 To EsteticaDataset.productos.Rows.Count - 1
            If codproducto = EsteticaDataset.productos(x).CodProducto Then
                ProductosBS.Position = x
            End If
        Next
        nombre_ts.Text = ""
    End Sub

    'borrar producto
    Private Sub borrar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borrar_bt.Click
        Try
            If (MsgBox("Borrar producto " & articulo_txt.Text & "?", MsgBoxStyle.OkCancel, "BORRAR") = MsgBoxResult.Ok) Then
                ProductosTA.borrar(codproducto)
                MsgBox("BORRADO OK", MsgBoxStyle.Information, "PRODUCTO BORRADO")
                ProductosTA.Fill(EsteticaDataset.productos)
                Dim col As New AutoCompleteStringCollection
                NombreProductoTA.Fill(EsteticaDataset.NombreProducto)
                For x = 0 To EsteticaDataset.NombreProducto.Rows.Count - 1
                    col.Add(EsteticaDataset.NombreProducto(x).CodProducto)
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
        If articulo_txt.Text = "" Or codigo_txt.Text = "" Then
            MsgBox("Introduce el producto.", MsgBoxStyle.Exclamation, "FALTAN DATOS")
            Exit Sub
        End If
        If (MsgBox("Guardar datos del producto?", MsgBoxStyle.OkCancel, "GUARDAR") = MsgBoxResult.Ok) Then
            ProductosTA.actualizar(categorias_cb.SelectedValue, proveedores_cb.SelectedValue, articulo_txt.Text, descripcion_txt.Text, profesional_txt.Text, _
                                                                                          publico_txt.Text, cantidad_txt.Text, stock_txt.Text, codproducto)
            MsgBox("GUARDADO OK", MsgBoxStyle.Information, "PRODUCTO ACTUALIZADO")
        End If
        noeditar()
    End Sub

    Private Sub editar()
        For Each ctrl In datos_gb.Controls.OfType(Of TextBox)()
            ctrl.ReadOnly = False
        Next
        categorias_cb.Visible = True
        categoria_txt.Visible = False
        proveedores_cb.Visible = True
        proveedor_txt.Visible = False
        editar_bt.Enabled = False
        borrar_bt.Enabled = False
        guardar_bt.Enabled = True
    End Sub

    Private Sub noeditar()
        For Each ctrl In datos_gb.Controls.OfType(Of TextBox)()
            ctrl.ReadOnly = True
        Next
        categorias_cb.Visible = False
        categoria_txt.Visible = True
        proveedores_cb.Visible = False
        proveedor_txt.Visible = True
        editar_bt.Enabled = True
        borrar_bt.Enabled = True
        guardar_bt.Enabled = False
    End Sub

    Private Sub ProductosBS_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProductosBS.PositionChanged
        Try
            codproducto = codigo_txt.Text
            ProdventaTA.producto(EsteticaDataset.prodventa, codproducto)
            ComprasTA.producto(EsteticaDataset.compras, codproducto)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub volver_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volver_bt.Click
        Dim frm As New Menu_Productos_frm
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