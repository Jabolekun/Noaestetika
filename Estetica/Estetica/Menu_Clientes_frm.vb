Public Class Menu_Clientes_frm

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

    Private Sub nuevo_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo_bt.Click
        Dim frm As New Cliente_Nuevo_frm
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub historial_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles historial_bt.Click
        Dim frm As New Cliente_Historial_frm
        frm.Show()
        Me.Hide()
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