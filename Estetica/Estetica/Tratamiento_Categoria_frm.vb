Public Class Tratamiento_Categoria_frm

    Friend Tratamiento_Nuevo_frm As New Tratamiento_Nuevo_frm

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                guardar_bt.PerformClick()
            Case Keys.Escape
                volver_bt.PerformClick()
        End Select
    End Sub

    Private Sub Categoria_Nuevo_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisableCloseButton(Me.Handle)
        fecha_txt.Text = Today
        hora_txt.Text = TimeOfDay
    End Sub

    Private Sub guardar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar_bt.Click
        If categoria_txt.Text = "" Then
            MsgBox("Introduce la categoría.", MsgBoxStyle.Exclamation, "FALTAN DATOS")
            Exit Sub
        End If
        If (MsgBox("Añadir nueva categoría?", MsgBoxStyle.OkCancel, "AÑADIR") = MsgBoxResult.Ok) Then
            TratcategoriasTA.Insert(categoria_txt.Text)
            MsgBox("GUARDADO OK", MsgBoxStyle.Information, "CATEGORÍA AÑADIDA")
            categoria_txt.Text = ""
        End If
    End Sub

    Private Sub volver_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volver_bt.Click
        Tratamiento_Nuevo_frm.recargar()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        hora_txt.Text = TimeOfDay
    End Sub
End Class