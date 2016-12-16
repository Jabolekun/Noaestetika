Public Class Venta_Nuevo_frm

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Tab
                cantidad_txt.Text = 1
                cantidad_txt.Focus()
            Case Keys.OemMinus
                menos_bt.PerformClick()
            Case Keys.Add
                mas_bt.PerformClick()
            Case Keys.Enter
                añadir_bt.PerformClick()
            Case Keys.Escape
                volver_bt.PerformClick()
        End Select
    End Sub

    Private Sub Venta_Nuevo_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DisableCloseButton(Me.Handle)
            Dim dgestilo As New EstiloDataGrid(productos_dgv)
            ClientesTA.Fill(EsteticaDataset.clientes)
            'mostrar dependientas
            For Each ctrl In tsHerramientas.Items.OfType(Of ToolStripButton)()
                ctrl.Visible = False
            Next
            For Each ctrl In tsHerramientas.Items.OfType(Of ToolStripSeparator)()
                ctrl.Visible = False
            Next
            DependientasTA.Fill(EsteticaDataset.dependientas)
            For x = 1 To EsteticaDataset.dependientas.Rows.Count
                For Each ctrl In tsHerramientas.Items.OfType(Of ToolStripButton)()
                    If ctrl.Name.Contains(x) Then
                        ctrl.Visible = True
                        ctrl.Text = EsteticaDataset.dependientas(x - 1).Dependienta
                    End If
                Next
                For Each ctrl In tsHerramientas.Items.OfType(Of ToolStripSeparator)()
                    If ctrl.Name.Contains(x) Then
                        ctrl.Visible = True
                    End If
                Next
            Next
            If EsteticaDataset.dependientas.Rows.Count > 0 Then
                dependienta1_bt.Checked = True
                dependienta1_bt.ForeColor = Color.Red
                dependienta = DependientasTA.nombre(dependienta1_bt.Text)
            End If
            pago_cb.SelectedIndex = 0
            codigo_txt.Focus()
            columnaimagen()
            fecha_txt.Text = Today
            hora_txt.Text = TimeOfDay
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dependienta1_bt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dependienta1_bt.Click, dependienta2_bt.Click, dependienta3_bt.Click
        Dim boton = TryCast(sender, ToolStripButton)
        dependienta = DependientasTA.nombre(boton.Text)
        For Each ctrl In tsHerramientas.Items.OfType(Of ToolStripButton)()
            ctrl.Checked = False
            ctrl.ForeColor = Color.Black
        Next
        boton.Checked = True
        boton.ForeColor = Color.Red
    End Sub

    Public Sub columnaimagen()
        Dim colImagen As New DataGridViewImageColumn()
        With colImagen
            .Image = My.Resources.PQborrar
            .Name = "Borrar"
            .HeaderText = "Eliminar"
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            .Width = 150
            .Resizable = DataGridViewTriState.False
        End With
        productos_dgv.Columns.Insert(0, colImagen)
    End Sub

    Private Sub productos_dgv_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles productos_dgv.CellClick
        Select Case e.ColumnIndex
            Case 0
                productos_dgv.Rows.RemoveAt(productos_dgv.CurrentRow.Index)
        End Select
    End Sub

    Private Sub codigo_txt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles codigo_txt.TextChanged
        ProductosTA.producto(EsteticaDataset.productos, codigo_txt.Text)
    End Sub

    Private Sub menos_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menos_bt.Click
        cantidad_txt.Text -= 1
    End Sub

    Private Sub mas_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mas_bt.Click
        cantidad_txt.Text += 1
    End Sub

    Private Sub añadir_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles añadir_bt.Click
        If codigo_txt.Text = "" Then
            Exit Sub
        End If
        If cantidad_txt.Text = 0 Then
            Exit Sub
        End If
        productos_dgv.Rows.Add()
        productos_dgv.Rows(productos_dgv.Rows.Count - 1).Cells(1).Value = "Producto"
        productos_dgv.Rows(productos_dgv.Rows.Count - 1).Cells(2).Value = codigo_txt.Text
        productos_dgv.Rows(productos_dgv.Rows.Count - 1).Cells(3).Value = articulo_txt.Text
        productos_dgv.Rows(productos_dgv.Rows.Count - 1).Cells(4).Value = descripcion_txt.Text
        productos_dgv.Rows(productos_dgv.Rows.Count - 1).Cells(5).Value = precio_txt.Text
        productos_dgv.Rows(productos_dgv.Rows.Count - 1).Cells(6).Value = cantidad_txt.Text
        productos_dgv.Rows(productos_dgv.Rows.Count - 1).Cells(7).Value = CDbl(precio_txt.Text) * cantidad_txt.Text
        codigo_txt.Text = ""
        cantidad_txt.Text = 1
        codigo_txt.Focus()
    End Sub

    Private Sub venta_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles venta_bt.Click
        If productos_dgv.RowCount = 0 Then
            Exit Sub
        End If
        Dim total As Double
        If (MsgBox("Guardar venta del cliente?", MsgBoxStyle.OkCancel, "VENTA") = MsgBoxResult.Ok) Then
            total = 0
            For x = 0 To productos_dgv.RowCount - 1
                total += CDbl(productos_dgv.Rows(x).Cells(5).Value) * productos_dgv.Rows(x).Cells(6).Value
            Next
            If sin_chk.Checked = True Then
                VentasTA.añadirsin(dependienta, Today.Date, total, pago_cb.Text)
            Else
                VentasTA.añadircon(codcliente_cb.SelectedValue, dependienta, Today.Date, total, pago_cb.Text)
            End If
            codventa = VentasTA.ultimo
            For x = 0 To productos_dgv.RowCount - 1
                If productos_dgv.Rows(x).Cells(1).Value = "Producto" Then
                    ProdventaTA.añadir(codventa, productos_dgv.Rows(x).Cells(2).Value, productos_dgv.Rows(x).Cells(6).Value, productos_dgv.Rows(x).Cells(5).Value)
                Else
                    TratventaTA.añadir(codventa, productos_dgv.Rows(x).Cells(2).Value, "Sesion", productos_dgv.Rows(x).Cells(6).Value, productos_dgv.Rows(x).Cells(5).Value)
                End If
            Next
            If (MsgBox("Venta guardada, imprimir ticket?", MsgBoxStyle.OkCancel, "TICKET") = MsgBoxResult.Ok) Then
                Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                rptDoc = New Ticket
                rptDoc.SetParameterValue("Codventa", codventa)
                rptDoc.PrintToPrinter(1, False, 0, 0)
            End If
        End If
    End Sub

    Private Sub tratamientos_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tratamientos_bt.Click
        Dim frm As New Tratamiento_Añadir_frm
        frm.Venta_nuevo_frm = Me
        frm.ShowDialog()
    End Sub

    Private Sub volver_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volver_bt.Click
        Dim frm As New Menu_Ventas_frm
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