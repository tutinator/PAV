Imports System.Windows.Forms

Public Class frm_ABMclubes

    Private Sub frm_ABMClubes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        txt_codClub.Text = ""
        txt_calle.Text = ""
        txt_nombre.Text = ""
        txt_nroCalle.Text = ""
        cmb_codPos.Text = ""
        txt_telefono.Text = ""
    End Sub

    Private Function validarCampos()

        If txt_codClub.Text = "" Then
            MsgBox("Código de Club no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_codClub.Focus()
            Return False
        End If

        If txt_nombre.Text = "" Then
            MsgBox("Nombre de Club no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_nombre.Focus()
            Return False
        End If

        If txt_calle.Text = "" Then
            MsgBox("Calle del Club no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_calle.Focus()
            Return False
        End If

        'If cmb_codPos.Text = "" Then
        'MsgBox("Calle del Club no puede estar vacío", MsgBoxStyle.Critical, "Importante")
        'txt_calle.Focus()
        'Return False
        'End If

        Return True
    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
        'txt_codClub.Enabled = x
        txt_calle.Enabled = x
        'txt_nombre.Enabled = x
        txt_nroCalle.Enabled = x
        cmb_codPos.Enabled = x
        txt_telefono.Enabled = x
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
            MessageBox.Show("Club cargado con éxito", "Operación completa")
        End If
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.inicio()
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If txt_codClub.Text = "" Then
            MsgBox("No se ha seleccionado ningún club", MsgBoxStyle.Critical, "Error")
        End If

        If MessageBox.Show("¿Está seguro que desea eliminar el Club " & txt_codClub.Text & "?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            'insertar codigo para borrar club de la base de datos
            MessageBox.Show("Club eliminado", "Operación completada")
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
        txt_codClub.Focus()
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        cambiarBotones(False)
        'cambiarEntradas(False)
        Me.cmd_cancelar.Enabled = True

        If txt_nombre.Text <> "" And txt_codClub.Text <> "" Then
            MsgBox("Ingrese sólo un criterio de búsqueda", MsgBoxStyle.Critical, "Importante")
            txt_codClub.Focus()
            cmd_buscar.Enabled = True
        End If

        If txt_codClub.Text = "" Then
            If txt_nombre.Text = "" Then
                MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
                txt_codClub.Focus()
                cmd_buscar.Enabled = True
            Else
                'busqueda por nombre

                cmd_buscar.Enabled = True

            End If
        Else
            'busqueda por codigo
            cmd_buscar.Enabled = True

        End If

    End Sub




    'Closing

    Private Sub frm_ABMclubes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            e.Cancel() = True
        End If
    End Sub


    Private Sub cmd_nuevoCP_Click(sender As Object, e As EventArgs) Handles cmd_nuevoCP.Click
        frm_ABMCodPos.Show()
    End Sub


End Class