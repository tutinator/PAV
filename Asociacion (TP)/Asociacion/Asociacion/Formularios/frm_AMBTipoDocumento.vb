Public Class frm_ABMTipoDocumento

    Dim acceso As New accesoBD
    Dim accion As estado = estado.insertar

    Enum estado
        insertar
        modificar
    End Enum

    Enum termino
        aprobado
        rechazado
    End Enum

    'Subrutinas

    Private Sub inicio()
        cargar_grilla()
        cambiarEntradas(False)
        cambiarBotones(False)
        Me.cmd_nuevo.Enabled = True
        Me.cmd_buscar.Enabled = True
        Me.cmd_salir.Enabled = True
        Me.txt_codTipoDoc.Enabled = True
        Me.txt_nombre.Enabled = True
        Me.txt_codTipoDoc.Focus()

    End Sub

    Private Sub limpiarCampos()
        Me.txt_codTipoDoc.Text = ""
        Me.txt_nombre.Text = ""
    End Sub

    Private Function validarCampos()

        If txt_codTipoDoc.Text = "" Then
            MsgBox("Código de Tipo de documento no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_codTipoDoc.Focus()
            Return False
        End If

        If txt_nombre.Text = "" Then
            MsgBox("Nombre de tipo de documento no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_nombre.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
        Me.txt_codTipoDoc.Enabled = x
        Me.txt_nombre.Enabled = x
        'Me.txt_tiempoRecord.Enabled = x
    End Sub

    Private Sub cambiarBotones(ByVal x As Boolean)
        Me.cmd_guardar.Enabled = x
        Me.cmd_buscar.Enabled = x
        Me.cmd_eliminar.Enabled = x
        Me.cmd_nuevo.Enabled = x
        Me.cmd_salir.Enabled = x
        Me.cmd_cancelar.Enabled = x
    End Sub

    'BASE DE DATOS
    Private Function leo_tabla(ByRef _tabla) As DataTable
        Dim consulta As String = ""
        consulta = "SELECT * FROM " & _tabla
        Return acceso.ejecutar(consulta)
    End Function

    Private Sub cargar_grilla()

        Dim consulta As String = ""
        consulta = "SELECT TiposDoc.tipoDoc AS Codigo, TiposDoc.nombre AS Nombre "
        consulta &= "FROM TiposDoc"

        grid_tipoDoc.DataSource = acceso.ejecutar(consulta)

    End Sub

    Private Function modificar() As termino

        Dim consulta As String = ""
        consulta = "UPDATE TiposDoc SET nombre = '" & Me.txt_nombre.Text & "' "
        consulta &= "WHERE codEspe = " & Me.txt_codTipoDoc.Text
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado

    End Function

    Private Function insertar() As termino

        Dim consulta As String = ""
        consulta = "INSERT into TiposDoc "
        consulta &= "values ('" & Me.txt_codTipoDoc.Text & "', '" & Me.txt_nombre.Text & "')"
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado

    End Function

    Private Function validar_existencia() As termino

        Dim consulta As String = ""
        Dim tabla As Data.DataTable
        consulta = "SELECT * FROM TiposDoc where tipoDoc = " & Me.txt_codTipoDoc.Text
        tabla = acceso.ejecutar(consulta)
        If tabla.Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Function delete() As termino
        Dim consulta As String = "DELETE FROM TiposDoc WHERE tipoDoc = " & Me.txt_codTipoDoc.Text
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado
    End Function
    '----FIN BD



    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        cambiarBotones(False)
        cambiarEntradas(True)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        txt_codTipoDoc.Focus()
        Me.accion = estado.insertar
    End Sub

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If validarCampos() = True Then
            If Me.accion = estado.insertar Then
                If validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("Nuevo tipo de documento cargado con éxito", "Operación completa")

                Else : MessageBox.Show("El tipo de documento que intenta guardar ya está registrado", "Error")



                End If
            Else : Me.modificar()
                MessageBox.Show("Tipo de documento modificado con éxito", "Operación completa")
            End If

            Me.inicio()
        End If
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If txt_codTipoDoc.Text = "" Then
            MsgBox("No se ha seleccionado ningún tipo de documento", MsgBoxStyle.Critical, "Error")
        Else
            If MessageBox.Show("¿Está seguro que desea eliminar el tipo de documento " & txt_nombre.Text & "?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                If Me.delete() = termino.aprobado Then
                    MessageBox.Show("Tipo de documento eliminado", "Operación completada")
                    Me.inicio()
                End If
            End If
        End If
    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        Me.inicio()
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_buscar.Enabled = True

        If txt_nombre.Text <> "" And txt_codTipoDoc.Text <> "" Then
            MsgBox("Ingrese sólo un criterio de búsqueda", MsgBoxStyle.Critical, "Importante")
            txt_codTipoDoc.Focus()

        Else

            If txt_codTipoDoc.Text = "" Then
                If txt_nombre.Text = "" Then
                    MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
                    txt_codTipoDoc.Focus()

                Else
                    Dim consulta As String = ""
                    Dim dt As New Data.DataTable
                    consulta = "SELECT * FROM TiposDoc WHERE nombre LIKE '%" & Me.txt_nombre.Text & "%'"
                    dt = acceso.ejecutar(consulta)

                    grid_tipoDoc.DataSource = dt
                End If
            Else
                Dim consulta As String = ""
                Dim dt As New Data.DataTable
                consulta = "SELECT * FROM TiposDoc WHERE tipoDoc = '" & Me.txt_codTipoDoc.Text & "'"
                dt = acceso.ejecutar(consulta)
                grid_tipoDoc.DataSource = dt

            End If
        End If
    End Sub

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub frm_ABMTipoDocumento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.inicio()
    End Sub
End Class