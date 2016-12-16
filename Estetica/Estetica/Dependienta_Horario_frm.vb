Public Class Dependienta_Horario_frm

    Dim fecha As Date

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                guardar_bt.PerformClick()
            Case Keys.Escape
                volver_bt.PerformClick()
        End Select
    End Sub

    Private Sub Dependienta_Horario_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DependientasTA.Fill(EsteticaDataset.dependientas)
        DisableCloseButton(Me.Handle)
        fecha_txt.Text = Today
        hora_txt.Text = TimeOfDay
    End Sub

    Private Sub guardar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar_bt.Click
        If mañana_chk.Checked = False And tarde_chk.Checked = False Then
            Exit Sub
        End If
        If (MsgBox("Guardar horario dependienta?", MsgBoxStyle.OkCancel, "GUARDAR") = MsgBoxResult.Ok) Then
            If mañana_chk.Checked = True Then
                TurnosTA.Insert(dependienta_cb.SelectedValue, fecha, minicio_dtp.Value, mfin_dtp.Value, DateDiff(DateInterval.Minute, minicio_dtp.Value, mfin_dtp.Value))
            End If
            If tarde_chk.Checked = True Then
                TurnosTA.Insert(dependienta_cb.SelectedValue, fecha, tinicio_dtp.Value, tfin_dtp.Value, DateDiff(DateInterval.Minute, tinicio_dtp.Value, tfin_dtp.Value))
            End If
            MsgBox("GUARDADO OK", MsgBoxStyle.Information, "HORARIO AÑADIDO")
            DependientasTA.Fill(EsteticaDataset.dependientas)
            minicio_dtp.Value = Now
            mfin_dtp.Value = Now
            tinicio_dtp.Value = Now
            tfin_dtp.Value = Now
            mañana_chk.Checked = False
            tarde_chk.Checked = False
        End If
    End Sub

    'calcular parada
    Private Sub minicio_dtp_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles minicio_dtp.ValueChanged, mfin_dtp.ValueChanged, _
                                                                                                        tinicio_dtp.ValueChanged, tfin_dtp.ValueChanged
        calcularparada()
    End Sub

    Private Sub mañana_chk_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mañana_chk.CheckedChanged, tarde_chk.CheckedChanged
        calcularparada()
    End Sub

    Private Sub calcularparada()
        If mañana_chk.Checked = True And tarde_chk.Checked = False Then
            duracion_txt.Text = DateDiff(DateInterval.Minute, minicio_dtp.Value, mfin_dtp.Value)
            fecha = minicio_dtp.Value.Date
        ElseIf mañana_chk.Checked = False And tarde_chk.Checked = True Then
            duracion_txt.Text = DateDiff(DateInterval.Minute, tinicio_dtp.Value, tfin_dtp.Value)
            fecha = tinicio_dtp.Value.Date
        ElseIf mañana_chk.Checked = True And tarde_chk.Checked = True Then
            duracion_txt.Text = DateDiff(DateInterval.Minute, minicio_dtp.Value, mfin_dtp.Value) + DateDiff(DateInterval.Minute, tinicio_dtp.Value, tfin_dtp.Value)
            fecha = minicio_dtp.Value.Date
        Else
            duracion_txt.Text = 0
        End If
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