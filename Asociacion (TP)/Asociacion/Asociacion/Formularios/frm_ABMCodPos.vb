Public Class frm_ABMCodPos

    Private Sub frm_ABMCodPos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cambiarBotones(False)
        cambiarEntradas(False)

    End Sub

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
        txt_nombre.Enabled = x
        txt_codPos.Enabled = x
    End Sub

    Private Sub cambiarBotones(ByVal x As Boolean)
        cmd_guardar.Enabled = x
        cmd_buscar.Enabled = Not x
        cmd_eliminar.Enabled = x
        cmd_nuevo.Enabled = Not x
        cmd_salir.Enabled = Not x
    End Sub

    Private Sub limpiarCampos()

        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Text = ""
            End If
        Next

    End Sub

    'Comandos

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        cambiarBotones(False)
        cambiarEntradas(False)
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        cambiarBotones(False)
        cambiarEntradas(False)
    End Sub

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        cambiarBotones(True)
        cambiarEntradas(True)
        txt_codPos.Focus()
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        cambiarBotones(False)
        cambiarEntradas(False)
        txt_nombre.Enabled = True
        txt_codPos.Enabled = True

    End Sub


End Class