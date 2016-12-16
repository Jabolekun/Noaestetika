Public Class Menu_frm

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                salir_bt.PerformClick()
        End Select
    End Sub

    Private Sub Menu_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisableCloseButton(Me.Handle)
        fecha_txt.Text = Today
        hora_txt.Text = TimeOfDay
    End Sub

    Private Sub cliente_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cliente_bt.Click
        Dim frm As New Menu_Clientes_frm
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub dependienta_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dependienta_bt.Click
        Dim frm As New Menu_Dependientas_frm
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub producto_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles producto_bt.Click
        Dim frm As New Menu_Productos_frm
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub proveedor_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proveedor_bt.Click
        Dim frm As New Menu_proveedores_frm
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub tratamiento_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tratamiento_bt.Click
        Dim frm As New Menu_Tratamientos_frm
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub venta_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles venta_bt.Click
        Dim frm As New Menu_Ventas_frm
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub cambiar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cambiar_bt.Click
        Dim frm As New Cambiar_Contraseña_frm
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