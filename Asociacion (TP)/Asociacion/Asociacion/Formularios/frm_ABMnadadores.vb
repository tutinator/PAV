Public Class frm_ABMnadadores



    Private Sub frm_AMBnadadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicio()
    End Sub
    'Subrutinas

    Private Sub inicio()
        cambiarBotones(False)
        cambiarEntradas(False)
        Me.cmd_nuevo.Enabled = True
        Me.cmd_buscar.Enabled = True
        Me.cmd_salir.Enabled = True
    End Sub

    Private Sub limpiarCampos()
        txt_apellido.Text = ""
        txt_nombre.Text = ""
        msk_fechaNacimiento.Clear()
        cmb_tipoDoc.Text = ""
        txt_nroDoc.Text = ""
        txt_email.Text = ""
        txt_calle.Text = ""
        txt_nroCalle.Text = ""
        cmb_codPos.Text = ""
        cmb_profesor.Text = ""
    End Sub

    Private Function validarCampos()

        If txt_apellido.Text = "" Then
            MsgBox("Apellido no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_apellido.Focus()
            Return False

        End If

        If txt_nombre.Text = "" Then
            MsgBox("Nombre del nadador no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_nombre.Focus()
            Return False
        End If

        If cmb_tipoDoc.Text = "" Then
            MsgBox("Tipo de documento del nadador no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            cmb_tipoDoc.Focus()
            Return False
        End If

        If txt_nroDoc.Text = "" Then
            MsgBox("Número de documento del nadador no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_nroDoc.Focus()
            Return False
        End If

        If Not opt_femenino.Checked And Not opt_masculino.Checked Then
            MsgBox("El sexo del nadador debe ser seleccionado", MsgBoxStyle.Critical, "Importante")
        End If

        Return True
    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
        txt_apellido.Enabled = x
        txt_nombre.Enabled = x
        txt_calle.Enabled = x
        msk_fechaNacimiento.Enabled = x
        cmb_tipoDoc.Enabled = x
        txt_nroDoc.Enabled = x
        txt_email.Enabled = x
        txt_calle.Enabled = x
        txt_nroCalle.Enabled = x
        cmb_codPos.Enabled = x
        cmb_profesor.Enabled = x
        opt_femenino.Enabled = x
        opt_masculino.Enabled = x
    End Sub


    Private Sub cambiarBotones(ByVal x As Boolean)
        cmd_guardar.Enabled = x
        cmd_buscar.Enabled = x
        cmd_eliminar.Enabled = x
        cmd_nuevo.Enabled = x
        cmd_salir.Enabled = x
        cmd_cancelar.Enabled = x
        cmd_nuevoCP.Enabled = x
        cmd_nuevoProfe.Enabled = x
    End Sub


    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click

    End Sub


    Private Sub txt_apellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_apellido.KeyPress

    End Sub


End Class
