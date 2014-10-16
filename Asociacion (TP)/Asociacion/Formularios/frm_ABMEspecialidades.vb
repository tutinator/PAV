Public Class frm_ABMEspecialidades

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

    Private Sub frm_ABMEspecialidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.inicio()
    End Sub

    'Subrutinas

    Private Sub inicio()
        cargar_grilla()
        cambiarEntradas(False)
        cambiarBotones(False)
        Me.cmd_nuevo.Enabled = True
        Me.cmd_buscar.Enabled = True
        Me.cmd_salir.Enabled = True
        Me.txt_codEspe.Enabled = True
        Me.txt_nombre.Enabled = True
        Me.txt_tiempoRecord.Enabled = False
        Me.txt_codEspe.Focus()

    End Sub

    Private Sub limpiarCampos()
        Me.txt_codEspe.Text = ""
        Me.txt_nombre.Text = ""
        Me.txt_tiempoRecord.Text = ""
    End Sub

    Private Function validarCampos()

        If txt_codEspe.Text = "" Then
            MsgBox("Código de Especialidad no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_codEspe.Focus()
            Return False
        End If

        If txt_nombre.Text = "" Then
            MsgBox("Nombre de Especialidad no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_nombre.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
        Me.txt_codEspe.Enabled = x
        Me.txt_nombre.Enabled = x
        Me.txt_tiempoRecord.Enabled = x
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
        consulta = "SELECT Especialidades.codEspe AS Codigo, Especialidades.descripcion AS Nombre, tiempoRecord AS [Tiempo Record] "
        consulta &= "FROM Especialidades"

        grid_especialidades.DataSource = acceso.ejecutar(consulta)

    End Sub

    Private Function modificar() As termino

        Dim consulta As String = ""
        consulta = "UPDATE Especialidades SET descripcion = '" & Me.txt_nombre.Text & "', tiempoRecord = "

        If txt_tiempoRecord.Text = "  :  :" Then
            consulta &= "NULL"
        Else
            consulta &= "'" & txt_tiempoRecord.Text & "'"
        End If
        consulta &= " WHERE codEspe = " & Me.txt_codEspe.Text
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado

    End Function

    Private Function insertar() As termino

        Dim consulta As String = ""
        consulta = "INSERT into Especialidades (codEspe, descripcion, tiempoRecord)"
        consulta &= "values ('" & Me.txt_codEspe.Text & "', '" & Me.txt_nombre.Text & "' "

        If txt_tiempoRecord.Text = "  :  :" Then
            consulta &= ", NULL)"
        Else
            consulta &= ",'"
            consulta &= txt_tiempoRecord.Text & "')"
        End If


        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado

    End Function

    Private Function validar_existencia() As termino

        Dim consulta As String = ""
        Dim tabla As Data.DataTable
        consulta = "SELECT * FROM Especialidades where codEspe = " & Me.txt_codEspe.Text
        tabla = acceso.ejecutar(consulta)
        If tabla.Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Function delete() As termino
        Dim consulta As String = "DELETE FROM Especialidades WHERE codEspe = " & Me.txt_codEspe.Text
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado
    End Function
    '----FIN BD


    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        cambiarBotones(False)
        cambiarEntradas(True)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        txt_codEspe.Focus()
        Me.accion = estado.insertar

    End Sub

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If validarCampos() = True Then
            If Me.accion = estado.insertar Then
                If validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("Nueva Especialidad cargada con éxito", "Operación completa")

                Else : MessageBox.Show("La Especialidad que intenta guardar ya está registrada", "Error")



                End If
            Else : Me.modificar()
                MessageBox.Show("Especialidad modificada con éxito", "Operación completa")
            End If

            Me.inicio()
        End If
    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        Me.inicio()
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If txt_codEspe.Text = "" Then
            MsgBox("No se ha seleccionado ninguna especialidad", MsgBoxStyle.Critical, "Error")
        Else
            If MessageBox.Show("¿Está seguro que desea eliminar la Especialidad " & txt_nombre.Text & "?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                If Me.delete() = termino.aprobado Then
                    MessageBox.Show("Especialidad eliminada", "Operación completada")
                    Me.inicio()
                End If
            End If
        End If
    End Sub

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub


    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click

        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_buscar.Enabled = True

        If txt_nombre.Text <> "" And txt_codEspe.Text <> "" Then
            MsgBox("Ingrese sólo un criterio de búsqueda", MsgBoxStyle.Critical, "Importante")
            txt_codEspe.Focus()

        Else

            If txt_codEspe.Text = "" Then
                If txt_nombre.Text = "" Then
                    MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
                    txt_codEspe.Focus()

                Else
                    Dim consulta As String = ""
                    Dim dt As New Data.DataTable
                    consulta = "SELECT * FROM Especialidades WHERE descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                    dt = acceso.ejecutar(consulta)

                    grid_especialidades.DataSource = dt
                End If
            Else
                Dim consulta As String = ""
                Dim dt As New Data.DataTable
                consulta = "SELECT * FROM Especialidades WHERE codEspe = '" & Me.txt_codEspe.Text & "'"
                dt = acceso.ejecutar(consulta)
                grid_especialidades.DataSource = dt

            End If
        End If
    End Sub

    
   
    
    Private Sub grid_especialidades_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grid_especialidades.CellMouseDoubleClick

        Dim codigoSeleccionado As String = Me.grid_especialidades.CurrentRow.Cells(0).Value

        Dim tabla As New Data.DataTable

        Dim consulta As String = ""
        consulta = "SELECT * FROM Especialidades WHERE codEspe = " & codigoSeleccionado

        cambiarEntradas(True)
        tabla = acceso.ejecutar(consulta)

        Me.txt_codEspe.Text = tabla.Rows(0)("codEspe")
        Me.txt_nombre.Text = tabla.Rows(0)("descripcion")

        If IsDBNull(tabla.Rows(0)("tiempoRecord")) Then
            Me.txt_tiempoRecord.Text = "  :  :"
        Else
            Me.txt_tiempoRecord.Text = tabla.Rows(0)("tiempoRecord")
        End If

        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_eliminar.Enabled = True
        Me.cmd_guardar.Enabled = True

        Me.txt_codEspe.Enabled = False
        txt_nombre.Focus()

        Me.accion = estado.modificar

    End Sub
End Class