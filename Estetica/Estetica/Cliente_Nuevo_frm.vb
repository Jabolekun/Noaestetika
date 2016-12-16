Public Class Cliente_Nuevo_frm

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                volver_bt.PerformClick()
        End Select
    End Sub

    Private Sub Cliente_Nuevo_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisableCloseButton(Me.Handle)
        fecha_txt.Text = Today
        hora_txt.Text = TimeOfDay
    End Sub

    Private Sub guardar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar_bt.Click
        If nombre_txt.Text = "" Or apellidos_txt.Text = "" Then
            MsgBox("Introduce el nombre y apellidos del cliente.", MsgBoxStyle.Exclamation, "FALTAN DATOS")
            Exit Sub
        End If
        If fijo_txt.Text = "" Then
            fijo_txt.Text = 0
        End If
        If movil_txt.Text = "" Then
            movil_txt.Text = 0
        End If
        If (MsgBox("Añadir nuevo cliente?", MsgBoxStyle.OkCancel, "AÑADIR") = MsgBoxResult.Ok) Then
            ClientesTA.Insert(nombre_txt.Text, apellidos_txt.Text, fijo_txt.Text, fecha_dtp.Value.Date, observaciones_txt.Text, movil_txt.Text, correo_txt.Text)
            MsgBox("GUARDADO OK", MsgBoxStyle.Information, "CLIENTE AÑADIDO")
            For Each ctrl In datos_gb.Controls.OfType(Of TextBox)()
                ctrl.Text = ""
            Next
            fecha_dtp.Value = Today.Date
        End If
    End Sub

    Private Sub telefono_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fijo_txt.KeyPress, movil_txt.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub nombre_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nombre_txt.KeyPress, apellidos_txt.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
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