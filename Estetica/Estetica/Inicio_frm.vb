Public Class Inicio_frm

    Private Sub Inicio_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        barra.Step = 1
        tiempo.Interval = 30
        tiempo.Enabled = True
        version_lb.Text = "Versión " & Application.ProductVersion
    End Sub

    Private Sub tiempo_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tiempo.Tick
        barra.PerformStep()
        porcentaje_txt.Text = barra.Value & "%"
    End Sub
End Class
