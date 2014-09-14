Public Class frm_ABMCodPos

    Private Sub frm_ABMCodPos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.inicio()
    End Sub


    'Subrutinas

    Private Sub inicio()
        cambiarBotones(False)
        cambiarEntradas(False)
        Me.cmd_nuevo.Enabled = True
        Me.cmd_buscar.Enabled = True
        Me.cmd_salir.Enabled = True
        txt_codPos.Focus()
    End Sub

    Private Sub limpiarCampos()
        txt_codPos.Text = ""
        txt_nombre.Text = ""
        
    End Sub

    Private Function validarCampos()

        If txt_codPos.Text = "" Then
            MsgBox("Código postal no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_codPos.Focus()
            Return False
        End If

        If txt_nombre.Text = "" Then
            MsgBox("Nombre del área no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_nombre.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
    End Sub

    Private Sub cambiarBotones(ByVal x As Boolean)
        cmd_guardar.Enabled = x
        cmd_buscar.Enabled = x
        cmd_eliminar.Enabled = x
        cmd_nuevo.Enabled = x
        cmd_salir.Enabled = x
        cmd_cancelar.Enabled = x
    End Sub


    'Comandos

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If validarCampos() = True Then
            Me.inicio()
            MessageBox.Show("Código postal cargado con éxito", "Operación completa")
        End If
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If txt_codPos.Text = "" Then
            MsgBox("No se ha seleccionado ningún código postal", MsgBoxStyle.Critical, "Error")
        End If

        If MessageBox.Show("¿Está seguro que desea eliminar el código postal " & txt_codPos.Text & " del área " & txt_nombre.Text & "?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            'insertar codigo para borrar el código postal de la base de datos
            MessageBox.Show("Código postal eliminado", "Operación completada")
            Me.inicio()
        End If
    End Sub

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        cambiarBotones(False)
        cambiarEntradas(True)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        txt_codPos.Focus()
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click

        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        cmd_buscar.Enabled = True


        If txt_nombre.Text <> "" And txt_codPos.Text <> "" Then
            MsgBox("Ingrese sólo un criterio de búsqueda", MsgBoxStyle.Critical, "Importante")
            txt_codPos.Focus()
            ' cmd_buscar.Enabled = True
        End If

        If txt_codPos.Text = "" Then
            If txt_nombre.Text = "" Then
                MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
                txt_codPos.Focus()
                ' cmd_buscar.Enabled = True
            Else
                'busqueda por nombre

                ' cmd_buscar.Enabled = True

            End If
        Else
            'busqueda por codigo
            'cmd_buscar.Enabled = True

        End If
    End Sub


    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.inicio()
    End Sub

End Class