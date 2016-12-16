Public Class Tratamiento_Nuevo_frm

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                volver_bt.PerformClick()
        End Select
    End Sub

    Private Sub Tratamiento_Nuevo_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisableCloseButton(Me.Handle)
        fecha_txt.Text = Today
        hora_txt.Text = TimeOfDay
        TratcategoriasTA.Fill(EsteticaDataset.tratcategorias)
    End Sub

    'añadir categoria
    Private Sub añadir_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles añadir_bt.Click
        Dim frm As New Tratamiento_Categoria_frm
        frm.Tratamiento_Nuevo_frm = Me
        frm.ShowDialog()
    End Sub

    Private Sub guardar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar_bt.Click
        If nombre_txt.Text = "" Then
            MsgBox("Introduce el nombre del tratamiento.", MsgBoxStyle.Exclamation, "FALTAN DATOS")
            Exit Sub
        End If
        If (MsgBox("Añadir nuevo tratamiento?", MsgBoxStyle.OkCancel, "AÑADIR") = MsgBoxResult.Ok) Then
            TratamientosTA.Insert(categorias_cb.SelectedValue, nombre_txt.Text, sesion_txt.Text, bono_txt.Text, sesionbono_txt.Text)
            MsgBox("GUARDADO OK", MsgBoxStyle.Information, "TRATAMIENTO AÑADIDO")
            For Each ctrl In datos_gb.Controls.OfType(Of TextBox)()
                ctrl.Text = ""
            Next
            recargar()
        End If
    End Sub

    Private Sub sesion_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sesion_txt.KeyPress, bono_txt.KeyPress, _
    sesionbono_txt.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub recargar()
        TratcategoriasTA.Fill(EsteticaDataset.tratcategorias)
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