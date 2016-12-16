Public Class Cambiar_Contraseña_frm

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                volver_bt.PerformClick()
        End Select
    End Sub

    Private Sub Menu_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisableCloseButton(Me.Handle)
        fecha_txt.Text = Today
        hora_txt.Text = TimeOfDay
    End Sub

    Private Sub guardar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar_bt.Click
        Dim contador As Integer
        If ContraseñaTA.pass(EsteticaDataset.contraseña, anterior_txt.Text) = Nothing Then
            MsgBox("Contraseña incorrecta, vuelve a intentarlo", MsgBoxStyle.Critical, "ERROR")
            anterior_txt.Text = ""
            contador += 1
            If contador = 3 Then
                MsgBox("Demasiados errores, cerrando aplicación...", MsgBoxStyle.Exclamation, "CERRANDO")
                salir(Me)
            End If
        Else
            If nueva_txt.Text = "" Then
                Exit Sub
            End If
            If nueva_txt.Text <> repetir_txt.Text Then
                MsgBox("La contraseña nueva no coincide, revísalo", MsgBoxStyle.Critical, "ERROR")
                nueva_txt.Text = ""
                repetir_txt.Text = ""
                Exit Sub
            End If
            ContraseñaTA.cambiar(nueva_txt.Text, anterior_txt.Text)
            MsgBox("Contraseña cambiada", MsgBoxStyle.Information, "OK")
            Menu_frm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub volver_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volver_bt.Click
        volver(Me)
    End Sub

    Private Sub salir_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir_bt.Click
        salir(Me)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        hora_txt.Text = TimeOfDay
    End Sub
End Class