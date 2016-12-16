Public Class Contraseña_frm

    Dim contador As Integer

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                salir(Me)
        End Select
    End Sub

    'si presiona enter salta a la funcion entrar
    Private Sub contraseña_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles contraseña_txt.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            entrar()
        End If
    End Sub

    Private Sub Entrar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Entrar_bt.Click
        Menu_frm.Show()
        Me.Hide()
        'entrar()
    End Sub

    'comprobacion de contraseña
    Private Sub entrar()
        If ContraseñaTableAdapter.pass(EsteticaDataset.contraseña, contraseña_txt.Text) = Nothing Then
            MsgBox("Contraseña incorrecta, vuelve a intentarlo", MsgBoxStyle.Critical, "ERROR")
            contraseña_txt.Text = ""
            contador += 1
            If contador = 3 Then
                MsgBox("Demasiados errores, cerrando aplicación...", MsgBoxStyle.Exclamation, "CERRANDO")
                salir(Me)
            End If
        Else
            MsgBox("Contraseña correcta", MsgBoxStyle.Information, "OK")
            Menu_frm.Show()
            Me.Hide()
        End If
    End Sub
End Class