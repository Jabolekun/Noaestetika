Public Class Cierre_frm

    Dim contador As Integer

    Private Sub Cierre_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        contador = 1
    End Sub

    Private Sub tiempo_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tiempo.Tick
        Select Case contador
            Case 1
                PictureBox1.Image = Estetica.My.Resources.LOGOSINFONDO
            Case 2
                PictureBox1.Image = Estetica.My.Resources.LOGOFONDOGRIS
        End Select
        contador += 1
    End Sub

    Private Sub tiempo1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tiempo1.Tick
        Application.Exit()
    End Sub
End Class