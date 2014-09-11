Public Class frm_ABMnadadores



    Private Sub frm_AMBnadadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cambiarBotones(False)
    End Sub
    Private Sub cambiarBotones(ByVal x As Boolean)
        cmd_guardar.Enabled = x
        cmd_buscar.Enabled = Not x
        cmd_cancelar.Enabled = x
        cmd_nuevo.Enabled = Not x
        cmd_salir.Enabled = Not x
    End Sub
End Class
