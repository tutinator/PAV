Public Class frm_ABMclubes

    Private Sub frm_ABMClubes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cambiarBotones(False)
        cambiarEntradas(False)

    End Sub


    Private Sub cambiarEntradas(ByVal x As Boolean)
        txt_codClub.Text = ""
        txt_nombre.Text = ""
        txt_calle.Text = ""
        txt_telefono.Text = ""
        txt_nroCalle.Text = ""
        txt_codClub.Enabled = x
        txt_calle.Enabled = x
        txt_nombre.Enabled = x
        txt_nroCalle.Enabled = x
        cmb_codPos.Enabled = x
        txt_telefono.Enabled = x
    End Sub

    Private Sub cambiarBotones(ByVal x As Boolean)
        cmd_guardar.Enabled = x
        cmd_buscar.Enabled = Not x
        cmd_eliminar.Enabled = x
        cmd_nuevo.Enabled = Not x
        cmd_salir.Enabled = Not x
    End Sub


    Private Sub frm_ABMclubes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Seguro...", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            e.Cancel() = True
        End If
    End Sub

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
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        cambiarBotones(False)
        cambiarEntradas(False)
        txt_nombre.Enabled = True
        txt_codClub.Enabled = True

    End Sub
End Class