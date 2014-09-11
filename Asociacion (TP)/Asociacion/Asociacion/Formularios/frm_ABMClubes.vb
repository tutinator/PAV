Public Class frm_ABMclubes

    Private Sub frm_ABMClubes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cambiarBotones(False)
        cambiarEntradas(False)

    End Sub


    Private Sub limpiarCampos()

        For Each objeto As System.Windows.Forms.Control In Me.Controls
            If TypeOf objeto Is TextBox Then
                objeto.Text = ""
            End If
        Next

    End Sub



    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
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
        txt_nombre.Focus()
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        cambiarBotones(False)
        cambiarEntradas(False)
        txt_nombre.Enabled = True
        txt_codClub.Enabled = True

    End Sub


    'Validaciones

    Private Sub txt_nroCalle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nroCalle.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 13, 9, 15, 14
                Exit Sub
        End Select
        If IsNumeric(e.KeyChar) = False Then
            MsgBox("Ingrese un número", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txt_telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telefono.KeyPress
        Select Case Asc(e.KeyChar)
            Case 4, 24, 4, 19, 127, 13, 9, 15, 14
                Exit Sub
        End Select
        If IsNumeric(e.KeyChar) = False Then
            MsgBox("Ingrese un número", vbCritical, "Importante")
            e.KeyChar = ""
        End If
    End Sub



    'Closing

    Private Sub frm_ABMclubes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            e.Cancel() = True
        End If
    End Sub
End Class