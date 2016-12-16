Public Class Proveedor_Nuevo_frm

    Friend Producto_Nuevo_frm As New Producto_Nuevo_frm

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                volver_bt.PerformClick()
        End Select
    End Sub

    Private Sub Proveedor_Nuevo_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisableCloseButton(Me.Handle)
        fecha_txt.Text = Today
        hora_txt.Text = TimeOfDay
    End Sub

    Private Sub guardar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar_bt.Click
        If nombre_txt.Text = "" Then
            MsgBox("Introduce el nombre del proveedor.", MsgBoxStyle.Exclamation, "FALTAN DATOS")
            Exit Sub
        End If
        If telefono_txt.Text = "" Then
            telefono_txt.Text = 0
        End If
        If comercial_txt.Text = "" Then
            comercial_txt.Text = 0
        End If
        If (MsgBox("Añadir nuevo proveedor?", MsgBoxStyle.OkCancel, "AÑADIR") = MsgBoxResult.Ok) Then
            ProveedoresTA.Insert(nombre_txt.Text, direccion_txt.Text, telefono_txt.Text, correo_txt.Text, comercial_txt.Text, tlfcomercial_txt.Text)
            MsgBox("GUARDADO OK", MsgBoxStyle.Information, "PROVEEDOR AÑADIDO")
            For Each ctrl In datos_gb.Controls.OfType(Of TextBox)()
                ctrl.Text = ""
            Next
        End If
    End Sub

    Private Sub telefono_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles telefono_txt.KeyPress, tlfcomercial_txt.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub volver_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volver_bt.Click
        If formulario = "Producto" Then
            Producto_Nuevo_frm.recargar()
            Me.Close()
        Else
            Dim frm As New Menu_proveedores_frm
            frm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub salir_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir_bt.Click
        salir(Me)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        hora_txt.Text = TimeOfDay
    End Sub
End Class