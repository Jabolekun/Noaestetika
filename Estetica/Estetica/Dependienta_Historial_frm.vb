Public Class Dependienta_Historial_frm

    Dim coddependienta As Integer

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                volver_bt.PerformClick()
        End Select
    End Sub

    Private Sub Menu_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dgestilo As New EstiloDataGrid(ventas_dgv)
        Dim dgestilo2 As New EstiloDataGrid(horarios_dgv)
        DisableCloseButton(Me.Handle)
        fecha_txt.Text = Today
        hora_txt.Text = TimeOfDay
        DependientasTA.Fill(EsteticaDataset.dependientas)
        noeditar()
        Dim col As New AutoCompleteStringCollection
        NombreDtaTA.Fill(EsteticaDataset.nombreDta)
        For x = 0 To EsteticaDataset.nombreDta.Rows.Count - 1
            col.Add(EsteticaDataset.nombreDta(x).NombreDta)
        Next
        nombre_ts.AutoCompleteCustomSource = col
        CodTurnoDataGridViewTextBoxColumn.Visible = False
        FechaInicioDataGridViewTextBoxColumn.DefaultCellStyle.Format = "HH:mm--dd/MM/yyyy"
        FechaFinDataGridViewTextBoxColumn.DefaultCellStyle.Format = "HH:mm--dd/MM/yyyy"
    End Sub

    'buscar por nombre
    Private Sub buscanombre_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscanombre_bt.Click
        If nombre_ts.Text = "" Then
            Exit Sub
        End If
        coddependienta = DependientasTA.nombre(nombre_ts.Text)
        For x = 0 To EsteticaDataset.dependientas.Rows.Count - 1
            If coddependienta = EsteticaDataset.dependientas(x).CodDependienta Then
                DependientasBS.Position = x
            End If
        Next
        nombre_ts.Text = ""
    End Sub

    'borrar dependienta
    Private Sub borrar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borrar_bt.Click
        Try
            If (MsgBox("Borrar dependienta " & nombre_txt.Text & "?", MsgBoxStyle.OkCancel, "BORRAR") = MsgBoxResult.Ok) Then
                DependientasTA.borrar(coddependienta)
                MsgBox("BORRADO OK", MsgBoxStyle.Information, "DEPENDIENTA BORRADA")
                DependientasTA.Fill(EsteticaDataset.dependientas)
                Dim col As New AutoCompleteStringCollection
                NombreDtaTA.Fill(EsteticaDataset.nombreDta)
                For x = 0 To EsteticaDataset.nombreDta.Rows.Count - 1
                    col.Add(EsteticaDataset.nombreDta(x).NombreDta)
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
        If nombre_txt.Text = "" Or apellidos_txt.Text = "" Then
            MsgBox("Introduce el nombre y apellidos de la dependienta.", MsgBoxStyle.Exclamation, "FALTAN DATOS")
            Exit Sub
        End If
        If (MsgBox("Guardar datos de la dependienta?", MsgBoxStyle.OkCancel, "GUARDAR") = MsgBoxResult.Ok) Then
            DependientasTA.actualizar(nombre_txt.Text, apellidos_txt.Text, fijo_txt.Text, movil_txt.Text, fecha_dtp.Value.Date, coddependienta)
            MsgBox("GUARDADO OK", MsgBoxStyle.Information, "DEPENDIENTA ACTUALIZADA")
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

    Private Sub DependientasBS_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DependientasBS.PositionChanged
        Try
            coddependienta = EsteticaDataset.dependientas(BindingNavigatorPositionItem.Text - 1).CodDependienta
            VentasTA.dependienta(EsteticaDataset.ventas, coddependienta)
            TurnosTA.dependienta(EsteticaDataset.turnos, coddependienta)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub volver_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volver_bt.Click
        Dim frm As New Menu_Dependientas_frm
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