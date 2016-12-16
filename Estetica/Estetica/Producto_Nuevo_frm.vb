Public Class Producto_Nuevo_frm

    Sub procesarPulsaciones(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                volver_bt.PerformClick()
        End Select
    End Sub

    Private Sub Producto_Nuevo_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisableCloseButton(Me.Handle)
        fecha_txt.Text = Today
        hora_txt.Text = TimeOfDay
        ProveedoresTA.Fill(EsteticaDataset.proveedores)
        ProdcategoriasTA.Fill(EsteticaDataset.prodcategorias)
        codigo_txt.Focus()
    End Sub

    'añadir categoria
    Private Sub categoria_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles categoria_bt.Click
        Dim frm As New Producto_Categoria_frm
        frm.Producto_Nuevo_frm = Me
        frm.ShowDialog()
    End Sub

    'añadir proveedor
    Private Sub proveedor_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proveedor_bt.Click
        formulario = "Producto"
        Dim frm As New Proveedor_Nuevo_frm
        frm.Producto_Nuevo_frm = Me
        frm.ShowDialog()
    End Sub

    Private Sub guardar_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar_bt.Click
        If articulo_txt.Text = "" Or codigo_txt.Text = "" Then
            MsgBox("Introduce el nombre del producto.", MsgBoxStyle.Exclamation, "FALTAN DATOS")
            Exit Sub
        End If
        If (MsgBox("Añadir nuevo producto?", MsgBoxStyle.OkCancel, "AÑADIR") = MsgBoxResult.Ok) Then
            ProductosTA.añadir(codigo_txt.Text, categoria_cb.SelectedValue, proveedor_cb.SelectedValue, articulo_txt.Text, descripcion_txt.Text, profesional_txt.Text, _
                                                                                                                 publico_txt.Text, cantidad_txt.Text, stock_txt.Text)
            MsgBox("GUARDADO OK", MsgBoxStyle.Information, "TRATAMIENTO AÑADIDO")
            For Each ctrl In datos_gb.Controls.OfType(Of TextBox)()
                ctrl.Text = ""
            Next
            recargar()
        End If
    End Sub

    Private Sub profesional_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles profesional_txt.KeyPress, publico_txt.KeyPress
        If e.KeyChar = "."c Then
            e.Handled = True
            SendKeys.Send(",")
        ElseIf e.KeyChar = ","c Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cantidad_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cantidad_txt.KeyPress, stock_txt.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub recargar()
        ProveedoresTA.Fill(EsteticaDataset.proveedores)
        ProdcategoriasTA.Fill(EsteticaDataset.prodcategorias)
    End Sub

    Private Sub volver_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volver_bt.Click
        Dim frm As New Menu_Productos_frm
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