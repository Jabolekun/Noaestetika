Imports System.IO

Module Variables

    Public dependienta, codventa As Integer
    Public formulario As String

    'quitar x del formulario
    Public Const MF_BYPOSITION As Integer = &H400
    Public Const MF_REMOVE As Integer = &H1000
    Public Const MF_DISABLED As Integer = &H2
    Public Declare Function GetSystemMenu Lib "User32" (ByVal hWnd As Integer, ByVal bRevert As Boolean) As IntPtr
    Public Declare Function GetMenuItemCount Lib "User32" (ByVal hMenu As Integer) As IntPtr
    Public Declare Function RemoveMenu Lib "User32" (ByVal hMenu As Integer, ByVal nPosition As Integer, ByVal wFlags As Long) As IntPtr
    Public Declare Function DrawMenuBar Lib "User32" (ByVal hWnd As Integer) As IntPtr

    'quitar x del formulario
    Public Sub DisableCloseButton(ByVal hWnd As IntPtr)
        Try
            Dim menuItemCount As IntPtr
            Dim hMenu As IntPtr
            hMenu = GetSystemMenu(hWnd.ToInt32(), False)
            menuItemCount = GetMenuItemCount(hMenu.ToInt32())
            RemoveMenu(hMenu.ToInt32(), menuItemCount.ToInt32() - 1, MF_DISABLED Or MF_BYPOSITION)
            RemoveMenu(hMenu.ToInt32(), menuItemCount.ToInt32() - 2, MF_DISABLED Or MF_BYPOSITION)
            DrawMenuBar(hWnd.ToInt32())
        Catch pollo As Exception
            MessageBox.Show("Se ha producido la excepción: " + vbCrLf + pollo.Message, "Error del programa", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Sub volver(ByVal form As Form)
        Dim frm As New Menu_frm
        frm.Show()
        form.Hide()
    End Sub

    Public Sub salir(ByVal form As Form)
        Cierre_frm.Show()
        form.Hide()
    End Sub

    'Public Sub solonumeros(ByVal sender As Object,ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Char.IsNumber(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    'Public Sub sololetras(ByVal sender As Object,ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Char.IsLetter(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    'obtener el ultimo codigo
    'Private Function ultimo(ByVal codigo As String)
    '    Try
    '        Dim digito As String
    '        If Val(codigo.Chars(4)) = 9 Then
    '            digito = Val(codigo.Chars(3)) + 1 & 0
    '        Else
    '            digito = Val(codigo.Chars(3)) & Val(codigo.Chars(4)) + 1
    '        End If
    '        codigo = codigo.Remove(codigo.Length - 2, 2)
    '        codigo = String.Concat(codigo, digito)
    '        Return codigo
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Function

    Public Class EstiloDataGrid

        'Creamos un constructor por defecto:
        Public Sub New()
        End Sub
        'Creamos un constructo para ejecutar la funcion EstiloSimple:
        Public Sub New(ByVal dg As DataGridView)
            EstiloSimple(dg)
        End Sub

        'Creamos una función para generar un estilo del DataGrifView
        Public Function EstiloSimple(ByVal dg As DataGridView)
            ' Establecemos que se seleccione por fila
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            ' Con esta propiedad se maneja como se muestran las celdas en tamaño con respecto al contenido
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            ' Desahabilitamos que se seleccione varias filas, solo una a la vez
            dg.MultiSelect = False
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine
            ' Deshabilitamos la ultima fila añadida
            dg.AllowUserToAddRows = False
            '2.- Creación de Estilo general para todas las celdas:
            ' Definimos la clase DataGridViewCellStyle, para la aplicación del primer estilo a crear
            Dim styEstilo As New DataGridViewCellStyle
            With styEstilo
                ' Establecemos el color del fondo de todas las celdas
                .BackColor = Color.LightYellow
                ' Establecemos el color del texto de la celdas
                .ForeColor = Color.DimGray
                ' Establecemos el tipo de fuente.
                .Font = New Font("Verdana", 11, FontStyle.Regular)
                ' Indicamos la alineación general o por default de todas las celdas.
                .Alignment = DataGridViewContentAlignment.MiddleLeft
                ' Para valores nulos, no se mostra la palabra "NULL", sino la que indiquemos aca
                .NullValue = "--"
                ' Color de fondo cuando esta celda este seleccionada
                .SelectionBackColor = Color.Khaki
                ' Color del texto cuando esta celda este seleccionada
                .SelectionForeColor = Color.Black
                ' Para dividir el texto a mostrar
                .WrapMode = DataGridViewTriState.False
            End With
            'Aplicamos el estilo creado:
            dg.DefaultCellStyle = styEstilo

            '3.- Estilo a la cabecera
            Dim styEstiloHeader As New DataGridViewCellStyle
            With styEstiloHeader
                .BackColor = Color.DarkGoldenrod
                .ForeColor = Color.Black
                .Font = New Font("Comic Sans MS", 12, FontStyle.Bold)
                .Alignment = DataGridViewContentAlignment.BottomRight
            End With
            ' Aplicamos el estilo creado a la cabecera:
            dg.ColumnHeadersDefaultCellStyle = styEstiloHeader

            '4.- Definiendo formato por tipo de datos:
            ' Para tipo Texto: 
            Dim styleTexto As New DataGridViewCellStyle
            With styleTexto
                .Alignment = DataGridViewContentAlignment.MiddleLeft
                .WrapMode = DataGridViewTriState.False
            End With

            ' Para el tipo Fecha:
            Dim styleFEcha As New DataGridViewCellStyle
            With styleFEcha
                .Format = "dd/MM/yyyy"
                .NullValue = "Sin Fecha"
                .Alignment = DataGridViewContentAlignment.MiddleRight
            End With

            'Para tipo Numericos:
            Dim styleInt As New DataGridViewCellStyle
            With styleInt
                .NullValue = "0"
                .Alignment = DataGridViewContentAlignment.MiddleRight
            End With

            'Para tipo Decimales:
            Dim styleDec As New DataGridViewCellStyle
            With styleDec
                .Format = "#,#.#0"
                .Alignment = DataGridViewContentAlignment.MiddleRight
            End With

            ' Comenzaremos recorriendo todas las columnas
            For Each dgColumn As DataGridViewColumn In dg.Columns
                ' Por cada columna preguntamos si es del tipo string
                If dgColumn.ValueType Is GetType(String) Then
                    ' Aplicamos a esta columna el estilo texto
                    dgColumn.DefaultCellStyle = styleTexto
                End If
                ' Preguntamos si es del tipo Fecha
                If dgColumn.ValueType Is GetType(DateTime) Then
                    ' Aplicamos a esta columna el estilo Fecha
                    dgColumn.DefaultCellStyle = styleFEcha
                    dgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End If
                ' Preguntamos si es del tipo numerico
                If dgColumn.ValueType Is GetType(Integer) Then
                    ' Aplicamos a esta columna el estilo numerico
                    dgColumn.DefaultCellStyle = styleInt
                End If

                ' Preguntamos si es del tipo decimal
                If dgColumn.ValueType Is GetType(Decimal) Then
                    ' Aplicamos a esta columna el estilo decimal
                    dgColumn.DefaultCellStyle = styleDec
                End If
            Next
            ' Retornamos el datagridview con el estilo aplicado: 
            Return dg
        End Function
    End Class
End Module
