﻿Public Class Tratamiento_Editar_frm

    Dim codtratamiento As Integer

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                volver_bt.PerformClick()
        End Select
    End Sub

    Private Sub Tratamiento_Editar_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dgestilo As New EstiloDataGrid(bonos_dgv)
        DisableCloseButton(Me.Handle)
        fecha_txt.Text = Today
        hora_txt.Text = TimeOfDay
        TratcategoriasTableAdapter.Fill(EsteticaDataset.tratcategorias)
        TratamientosTA.Fill(EsteticaDataset.tratamientos)
        noeditar()
        Dim col As New AutoCompleteStringCollection
        NombreTratamientoTA.Fill(EsteticaDataset.NombreTratamiento)
        For x = 0 To EsteticaDataset.NombreTratamiento.Rows.Count - 1
            col.Add(EsteticaDataset.NombreTratamiento(x).Nombre)
        Next
        nombre_ts.AutoCompleteCustomSource = col
    End Sub

    'buscar por nombre
    Private Sub buscanombre_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscanombre_bt.Click
        If nombre_ts.Text = "" Then
            Exit Sub
        End If
        codtratamiento = TratamientosTA.nombre(nombre_ts.Text)
        For x = 0 To EsteticaDataset.proveedores.Rows.Count - 1
            If codtratamiento = EsteticaDataset.proveedores(x).CodProveedor Then
                TratamientosBS.Position = x
            End If
        Next
        nombre_ts.Text = ""
    End Sub

    'borrar proveedor
    Private Sub borrar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borrar_bt.Click
        Try
            If (MsgBox("Borrar tratamiento " & nombre_txt.Text & "?", MsgBoxStyle.OkCancel, "BORRAR") = MsgBoxResult.Ok) Then
                TratamientosTA.borrar(codtratamiento)
                MsgBox("BORRADO OK", MsgBoxStyle.Information, "TRATAMIENTO BORRADO")
                TratamientosTA.Fill(EsteticaDataset.tratamientos)
                Dim col As New AutoCompleteStringCollection
                NombreTratamientoTA.Fill(EsteticaDataset.NombreTratamiento)
                For x = 0 To EsteticaDataset.NombreTratamiento.Rows.Count - 1
                    col.Add(EsteticaDataset.NombreTratamiento(x).Nombre)
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
            MsgBox("Introduce el nombre del tratamiento.", MsgBoxStyle.Exclamation, "FALTAN DATOS")
            Exit Sub
        End If
        If (MsgBox("Guardar datos del tratamiento?", MsgBoxStyle.OkCancel, "GUARDAR") = MsgBoxResult.Ok) Then
            TratamientosTA.actualizar(categorias_cb.SelectedValue, nombre_txt.Text, sesion_txt.Text, bono_txt.Text, sesionbono_txt.Text, codtratamiento)
            MsgBox("GUARDADO OK", MsgBoxStyle.Information, "TRATAMIENTO ACTUALIZADO")
        End If
        noeditar()
    End Sub

    Private Sub editar()
        For Each ctrl In datos_gb.Controls.OfType(Of TextBox)()
            ctrl.ReadOnly = False
        Next
        categorias_cb.Visible = True
        categoria_txt.Visible = False
        editar_bt.Enabled = False
        guardar_bt.Enabled = True
    End Sub

    Private Sub noeditar()
        For Each ctrl In datos_gb.Controls.OfType(Of TextBox)()
            ctrl.ReadOnly = True
        Next
        categorias_cb.Visible = False
        categoria_txt.Visible = True
        editar_bt.Enabled = True
        guardar_bt.Enabled = False
    End Sub

    Private Sub TratamientosBS_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TratamientosBS.PositionChanged
        Try
            codtratamiento = EsteticaDataset.tratamientos(BindingNavigatorPositionItem.Text - 1).CodTratamiento
            BonosTA.tratamiento(EsteticaDataset.bonos, codtratamiento)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub volver_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volver_bt.Click
        Dim frm As New Menu_Tratamientos_frm
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