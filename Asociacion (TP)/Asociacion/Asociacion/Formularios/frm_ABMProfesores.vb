Public Class frm_ABMProfesores

    Private Sub frm_ABMProfesores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.inicio()

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
        txt_codProfesor.Text = ""
        txt_calle_profesor.Text = ""
        txt_nombre_profesor.Text = ""
        txt_nroCalle_profesor.Text = ""
        cmb_codPos_profesor.Text = ""
        txt_telefono_profesor.Text = ""
        txt_apellido_profesor.Text = ""
        cbo_tipoDoc_profesor.Text = ""
        txt_nroDoc_profesor.Text = ""
    End Sub

    Private Function validarCampos()

        If txt_codProfesor.Text = "" Then
            MsgBox("Código de Profesor no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_codProfesor.Focus()
            Return False
        End If

        If txt_apellido_profesor.Text = "" Then
            MsgBox("Apellido de Profesor no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_apellido_profesor.Focus()
            Return False
        End If

        If txt_nombre_profesor.Text = "" Then
            MsgBox("Nombre de Profesor no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_nombre_profesor.Focus()
            Return False
        End If

        If cbo_tipoDoc_profesor.Text = "" Then
            MsgBox("Tipo de Documento no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            cbo_tipoDoc_profesor.Focus()
            Return False
        End If

        If txt_nroDoc_profesor.Text = "" Then
            MsgBox("Número de Documento no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_nroDoc_profesor.Focus()
            Return False
        End If

        If txt_calle_profesor.Text = "" Then
            MsgBox("Calle del domicilio del Profesor no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_calle_profesor.Focus()
            Return False
        End If

        'If cmb_codPos.Text = "" Then
        'MsgBox("Codigo postal no puede estar vacío", MsgBoxStyle.Critical, "Importante")
        'txt_calle.Focus()
        'Return False
        'End If

        Return True
    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
        'txt_codClub.Enabled = x
        'txt_apellido_profesor.Enabled = x
        txt_calle_profesor.Enabled = x
        txt_nombre_profesor.Enabled = x
        txt_nroCalle_profesor.Enabled = x
        cmb_codPos_profesor.Enabled = x
        txt_telefono_profesor.Enabled = x
        cbo_tipoDoc_profesor.Enabled = x
        txt_nroDoc_profesor.Enabled = x
        opt_femenino_profesor.Enabled = x
        opt_masculino_profesor.Enabled = x

    End Sub

    Private Sub cambiarBotones(ByVal x As Boolean)
        cmd_guardar.Enabled = x
        cmd_buscar.Enabled = x
        cmd_eliminar.Enabled = x
        cmd_nuevo.Enabled = x
        cmd_salir.Enabled = x
        cmd_cancelar.Enabled = x
        cmd_nuevoCP.Enabled = x
    End Sub


    'Comandos

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If validarCampos() = True Then
            Me.inicio()
            MessageBox.Show("Profesor cargado con éxito", "Operación completa")
        End If
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.inicio()
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If txt_codProfesor.Text = "" Then
            MsgBox("No se ha seleccionado ningún Profesor", MsgBoxStyle.Critical, "Error")
        End If

        If MessageBox.Show("¿Está seguro que desea eliminar el Profesor " & txt_codProfesor.Text & "?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            'insertar codigo para borrar club de la base de datos
            MessageBox.Show("Profesor eliminado", "Operación completada")
            Me.inicio()
        End If

    End Sub

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        cambiarBotones(False)
        cambiarEntradas(True)
        cmd_nuevoCP.Enabled = True
        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        txt_codProfesor.Focus()
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        cambiarBotones(False)
        'cambiarEntradas(False)
        Me.cmd_cancelar.Enabled = True

        If txt_apellido_profesor.Text <> "" And txt_codProfesor.Text <> "" Then
            MsgBox("Ingrese sólo un criterio de búsqueda", MsgBoxStyle.Critical, "Importante")
            txt_codProfesor.Focus()
            cmd_buscar.Enabled = True
        End If

        If txt_codProfesor.Text = "" Then
            If txt_apellido_profesor.Text = "" Then
                MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
                txt_codProfesor.Focus()
                cmd_buscar.Enabled = True
            Else
                'busqueda por apellido

                cmd_buscar.Enabled = True

            End If
        Else
            'busqueda por codigo
            cmd_buscar.Enabled = True

        End If

    End Sub


    Private Sub cmd_nuevoCP_Click(sender As Object, e As EventArgs) Handles cmd_nuevoCP.Click
        frm_ABMCodPos.Show()

        'Agregar funcionalidad para que al crearse el cp nuevo, se muestre en el cbo de cp

    End Sub


    'Closing

    Private Sub frm_ABMProfesores_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            e.Cancel() = True
        End If
    End Sub






End Class