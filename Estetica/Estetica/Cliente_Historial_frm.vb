Public Class Cliente_Historial_frm

    Dim codcliente As Integer

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                volver_bt.PerformClick()
        End Select
    End Sub

    Private Sub Menu_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dgestilo As New EstiloDataGrid(ventas_dgv)
        Dim dgestilo2 As New EstiloDataGrid(bonos_dgv)
        DisableCloseButton(Me.Handle)
        fecha_txt.Text = Today
        hora_txt.Text = TimeOfDay
        ClientesTA.Fill(EsteticaDataset.clientes)
        noeditar()
        Dim col As New AutoCompleteStringCollection
        NombresTA.Fill(EsteticaDataset.Nombres)
        For x = 0 To EsteticaDataset.Nombres.Rows.Count - 1
            col.Add(EsteticaDataset.Nombres(x).NombreCte)
        Next
        nombre_ts.AutoCompleteCustomSource = col
    End Sub

    'buscar por nombre
    Private Sub buscanombre_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscanombre_bt.Click
        If nombre_ts.Text = "" Then
            Exit Sub
        End If
        codcliente = ClientesTA.nombre(nombre_ts.Text)
        For x = 0 To EsteticaDataset.clientes.Rows.Count - 1
            If codcliente = EsteticaDataset.clientes(x).CodCliente Then
                ClientesBS.Position = x
            End If
        Next
        nombre_ts.Text = ""
    End Sub

    'borrar cliente
    Private Sub borrar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borrar_bt.Click
        If (MsgBox("Borrar cliente " & nombre_txt.Text & "?", MsgBoxStyle.OkCancel, "BORRAR") = MsgBoxResult.Ok) Then
            ClientesTA.borrar(codcliente)
            MsgBox("BORRADO OK", MsgBoxStyle.Information, "CLIENTE BORRADO")
            ClientesTA.Fill(EsteticaDataset.clientes)
            Dim col As New AutoCompleteStringCollection
            NombresTA.Fill(EsteticaDataset.Nombres)
            For x = 0 To EsteticaDataset.Nombres.Rows.Count - 1
                col.Add(EsteticaDataset.Nombres(x).NombreCte)
            Next
            nombre_ts.AutoCompleteCustomSource = col
        End If
    End Sub

    Private Sub editar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editar_bt.Click
        editar()
    End Sub

    Private Sub guardar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar_bt.Click
        If nombre_txt.Text = "" Or apellidos_txt.Text = "" Then
            MsgBox("Introduce el nombre y apellidos del cliente.", MsgBoxStyle.Exclamation, "FALTAN DATOS")
            Exit Sub
        End If
        If (MsgBox("Guardar datos del cliente?", MsgBoxStyle.OkCancel, "GUARDAR") = MsgBoxResult.Ok) Then
            ClientesTA.actualizar(nombre_txt.Text, apellidos_txt.Text, fijo_txt.Text, movil_txt.Text, fecha_dtp.Value.Date, email_txt.Text, observaciones_txt.Text, codcliente)
            MsgBox("GUARDADO OK", MsgBoxStyle.Information, "CLIENTE ACTUALIZADO")
        End If
        noeditar()
    End Sub

    Private Sub editar()
        For Each ctrl In datos_gb.Controls.OfType(Of TextBox)()
            ctrl.ReadOnly = False
        Next
        fecha_dtp.Enabled = True
        editar_bt.Enabled = False
        borrar_bt.Enabled = False
        guardar_bt.Enabled = True
    End Sub

    Private Sub noeditar()
        For Each ctrl In datos_gb.Controls.OfType(Of TextBox)()
            ctrl.ReadOnly = True
        Next
        fecha_dtp.Enabled = False
        editar_bt.Enabled = True
        borrar_bt.Enabled = True
        guardar_bt.Enabled = False
    End Sub

    Private Sub ClientesBS_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClientesBS.PositionChanged
        Try
            codcliente = EsteticaDataset.clientes(BindingNavigatorPositionItem.Text - 1).CodCliente
            VentasTA.cliente(EsteticaDataset.ventas, codcliente)
            BonosTA.cliente(EsteticaDataset.bonos, codcliente)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub volver_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volver_bt.Click
        Dim frm As New Menu_Clientes_frm
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