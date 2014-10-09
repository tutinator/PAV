Public Class proc_profesxclub

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
        Me.cmd_buscarProf.Enabled = True
        Me.cmd_nuevo.Enabled = True
        Me.cmd_salir.Enabled = True
        Me.txt_codProfesor.Enabled = True
        Me.cmb_club.Enabled = True
        Me.txt_codProfesor.Focus()

    End Sub

    Private Sub limpiarCampos()
        Me.txt_codProfesor.Text = ""
        Me.txt_apellido_profesor.Text = ""
        Me.txt_nombre_profesor.Text = ""
        Me.cmb_club.SelectedIndex = -1
    End Sub

    Private Function validarCampos()

        If txt_codProfesor.Text = "" Then
            MsgBox("Código de profesor no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            Me.txt_codProfesor.Focus()
            Return False
        End If

        If cmb_club.SelectedText = "" Then
            MsgBox("Debe seleccionar un club", MsgBoxStyle.Critical, "Importante")
            Me.cmb_club.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
        Me.txt_apellido_profesor.Enabled = x
        Me.txt_nombre_profesor.Enabled = x
        Me.txt_codProfesor.Enabled = x
        Me.cmb_club.Enabled = x
    End Sub

    Private Sub cambiarBotones(ByVal x As Boolean)
        Me.cmd_guardar.Enabled = x
        Me.cmd_eliminar.Enabled = x
        Me.cmd_nuevo.Enabled = x
        Me.cmd_salir.Enabled = x
        Me.cmd_cancelar.Enabled = x
        Me.cmd_buscarProf.Enabled = x
        Me.cmd_nuevoClub.Enabled = x
        Me.cmd_nuevoprof.Enabled = x
    End Sub

    'BASE DE DATOS
    Private Function leo_tabla(ByRef _tabla) As DataTable
        Dim consulta As String = ""
        consulta = "SELECT * FROM " & _tabla
        Return acceso.ejecutar(consulta)
    End Function

    Private Sub cargar_grilla()

        'REVISAR ESTA CONSULTA, SE DEBE HACER UN JOIN ENTRE VARIOS ASI SE MUESTRA EN LA GRILLA 
        'JOIN ENTRE PROFESOR Y CLUB

        'Dim consulta As String = ""
        'consulta = "SELECT TiposDoc.tipoDoc AS Codigo, TiposDoc.nombre AS Nombre "
        'consulta &= "FROM ProfeXClub"

        'grid_profxclub.DataSource = acceso.ejecutar(consulta)

    End Sub

    Private Function modificar() As termino

        'REVISAR ESTA CONSULTA SQL TAMBIENNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN

        Dim consulta As String = ""
        ' consulta = "UPDATE TiposDoc SET nombre = '" & Me.txt_nombre.Text & "' "
        'consulta &= "WHERE codEspe = " & Me.txt_codTipoDoc.Text
        'acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado

    End Function

    Private Function insertar() As termino

        'REVISAR ESTA CONSULTA SQL TAMBIENNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN

        '        Dim consulta As String = ""
        '       consulta = "INSERT into TiposDoc "
        '      consulta &= "values ('" & Me.txt_codTipoDoc.Text & "', '" & Me.txt_nombre.Text & "')"
        '     acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado

    End Function

    Private Function validar_existencia() As termino

        'REVISAR ESTA CONSULTA SQL TAMBIENNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN

        Dim consulta As String = ""
        Dim tabla As Data.DataTable
        ' consulta = "SELECT * FROM TiposDoc where tipoDoc = " & Me.txt_codTipoDoc.Text
        tabla = acceso.ejecutar(consulta)
        If tabla.Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Function delete() As termino

        'REVISAR ESTA CONSULTA SQL TAMBIENNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN

        '   Dim consulta As String = "DELETE FROM TiposDoc WHERE tipoDoc = " & Me.txt_codTipoDoc.Text
        'acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado
    End Function
    '----FIN BD



    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        cambiarBotones(False)
        cambiarEntradas(True)
        cmd_buscarProf.Enabled = True
        cmd_nuevoClub.Enabled = True
        cmd_nuevoprof.Enabled = True
        cmd_guardar.Enabled = True

    End Sub

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If validarCampos() = True Then
            If Me.accion = estado.insertar Then
                If validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("Asignacion de profesor a club realizada con éxito", "Operación completa")

                Else : MessageBox.Show("El profesor ya se encuentra asignado al club seleccionado", "Error")



                End If
            Else : Me.modificar()
                MessageBox.Show("Asignación de profesor a club realizada con éxito", "Operación completa")
            End If

            Me.inicio()
        End If
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click

        'REVISAR ELIMINACION POR EL TEMA DE TRABAJAR CON VARIAS TABLAS

        If txt_codProfesor.Text = "" Then
            MsgBox("No se ha seleccionado ningún profesor", MsgBoxStyle.Critical, "Error")
        Else
            If MessageBox.Show("¿Está seguro que desea eliminar el profesor " & txt_apellido_profesor.Text & ", " _
                               & txt_nombre_profesor.Text & "?", "Atención", MessageBoxButtons.OKCancel, _
                               MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                If Me.delete() = termino.aprobado Then
                    MessageBox.Show("Profesor asignado a club eliminado", "Operación completada")
                    Me.inicio()
                End If
            End If
        End If
    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        Me.inicio()
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscarProf.Click

        Me.cmd_cancelar.Enabled = True

        If txt_codProfesor.Text = "" Then
            MsgBox("Ingrese un código de profesor", MsgBoxStyle.Critical, "Importante")
            txt_codProfesor.Focus()

        Else

            Dim consulta As String = ""
            Dim dt As New Data.DataTable
            consulta = "SELECT * FROM Profesores WHERE codProfe = " & Me.txt_codProfesor.Text
            dt = acceso.ejecutar(consulta)

            If dt.Rows.Count = 0 Then
                MsgBox("No existe ningún profesor con ese código", MsgBoxStyle.Critical, "Importante")
                Me.limpiarCampos()
                txt_codProfesor.Focus()
            Else
                cambiarEntradas(True)
                Me.txt_codProfesor.Text = dt.Rows(0)("codProfe")
                Me.txt_nombre_profesor.Text = dt.Rows(0)("nombre")
                Me.txt_apellido_profesor.Text = dt.Rows(0)("apellido")

            End If
        End If
    End Sub

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub frm_ABMTipoDocumento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.inicio()
    End Sub

    Private Sub grid_tipoDoc_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grid_profxclub.CellMouseDoubleClick

        'Dim codigoSeleccionado As String = Me.grid_tipoDoc.CurrentRow.Cells(0).Value

        'Dim tabla As New Data.DataTable

        'Dim consulta As String = ""
        'consulta = "SELECT * FROM TiposDoc WHERE tipoDoc = " & codigoSeleccionado

        'cambiarEntradas(True)
        'tabla = acceso.ejecutar(consulta)

        'Me.txt_codTipoDoc.Text = tabla.Rows(0)("tipoDoc")
        'Me.txt_nombre.Text = tabla.Rows(0)("nombre")

        'cambiarBotones(False)
        'Me.cmd_cancelar.Enabled = True
        'Me.cmd_eliminar.Enabled = True
        'Me.cmd_guardar.Enabled = True

        'Me.txt_codTipoDoc.Enabled = False
        'txt_nombre.Focus()
        ' 

        'Me.accion = estado.modificar
    End Sub

End Class