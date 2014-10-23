Public Class frm_ABMProfesores

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

    Private Sub frm_ABMProfesores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.inicio()

    End Sub

    'Conexion con la base

    Private Function leo_tabla(ByRef _tabla) As DataTable
        Dim consulta As String = ""
        consulta = "SELECT * FROM " & _tabla
        Return acceso.ejecutar(consulta)
    End Function

    Private Sub cargar_grilla()

        'REVISAR ESTOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

        Dim consulta As String = ""
        consulta = "SELECT Profesores.codProfe AS Codigo, Profesores.nombre AS Nombre, Profesores.apellido AS Apellido, Profesores.calle AS Calle, Profesores.numero AS Numero, Profesores.telefono AS Telefono, Profesores.nroDoc as Documento, "
        consulta &= "Profesores.codPos AS [Codigo Postal], "
        consulta &= "TiposDoc.tipoDoc AS [Tipo], TiposDoc.nombre AS [Nombre] "
        consulta &= "FROM Profesores  INNER JOIN TiposDoc ON Profesores.tipoDoc = TiposDoc.tipoDoc"

        grid_profesores.DataSource = acceso.ejecutar(consulta)

    End Sub

    Private Sub cargar_combo(ByRef combo As ComboBox, ByVal nombre_tabla As DataTable, ByVal pk As String, ByVal descrip As String)

        combo.DataSource = nombre_tabla
        combo.ValueMember = pk
        combo.DisplayMember = descrip
        combo.SelectedIndex = -1

    End Sub

    Private Sub cargar_combos()

        'REVISAR ESTOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

        cargar_combo(cmb_codPos_profesor, leo_tabla("CodPostales"), "codPos", "codPos")
        cargar_combo(cmb_tipoDoc_profesor, leo_tabla("TiposDoc"), "tipoDoc", "nombre")

    End Sub

    Private Function modificar() As termino

        Dim consulta As String = ""
        consulta = "UPDATE Profesores SET nombre = '" & Me.txt_nombre_profesor.Text & "', "
        consulta &= "apellido = '" & Me.txt_apellido_profesor.Text & "', "
        consulta &= "calle = '" & Me.txt_calle_profesor.Text & "', "
        consulta &= "numero = " & Me.txt_nroCalle_profesor.Text & ", "
        consulta &= "codPos = " & Me.cmb_codPos_profesor.SelectedValue & ", "
        consulta &= "tipoDoc = " & Me.cmb_tipoDoc_profesor.SelectedValue & ", "
        consulta &= "telefono = " & Me.txt_telefono_profesor.Text & ", "
        consulta &= "nroDoc = " & Me.txt_nroDoc_profesor.Text & " "
        consulta &= "WHERE codProfe = " & Me.txt_codProfesor.Text

        acceso.ejecutarNonConsulta(consulta)

        Return termino.aprobado

    End Function

    Private Function insertar() As termino

        'REVISAR ESTOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

        Dim consulta As String = ""
        consulta = "INSERT into Profesores "
        consulta &= "values ('" & Me.txt_codProfesor.Text & "', '" & Me.txt_nombre_profesor.Text & "', '" & Me.txt_apellido_profesor.Text & "', "
        consulta &= "'" & Me.txt_calle_profesor.Text & "', " & Me.txt_nroCalle_profesor.Text & ", "
        consulta &= Me.cmb_codPos_profesor.SelectedValue & "," & Me.cmb_tipoDoc_profesor.SelectedValue & ", " & Me.txt_telefono_profesor.Text & ", " & Me.txt_nroDoc_profesor.Text & ")"

        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado

    End Function

    Private Function validar_existencia() As termino

        Dim consulta As String = ""
        Dim tabla As Data.DataTable

        consulta = "select * from Profesores where codProfe = " & Me.txt_codProfesor.Text
        tabla = acceso.ejecutar(consulta)


        If tabla.Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Function delete() As termino
        'Dim consulta As String = "DELETE FROM Profesores WHERE codProfe = " & Me.txt_codProfesor.Text
        'acceso.ejecutarNonConsulta(consulta)
        'Return termino.aprobado


        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim consulta As String = ""

        conexion.ConnectionString = Me.acceso._StringConexion
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        conexion.Open()

        consulta = "DELETE FROM Profesores WHERE codProfe = " & Me.txt_codProfesor.Text

        cmd.CommandText = consulta

        Try
            cmd.ExecuteNonQuery()
            Me.accion = estado.insertar
            Return termino.aprobado
        Catch ex As Exception
            MessageBox.Show("No se puede eliminar este Profesor ya que está siendo referenciado en otra tabla.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return termino.rechazado
        End Try
    End Function

    Private Sub cmb_codPos_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_codPos_profesor.DropDown
        cargar_combo(cmb_codPos_profesor, leo_tabla("CodPostales"), "codPos", "codPos")
    End Sub



    'Subrutinas

    Private Sub inicio()
        cargar_grilla()
        cargar_combos()
        cambiarBotones(False)
        cambiarEntradas(False)
        txt_apellido_profesor.Enabled = True
        txt_codProfesor.Enabled = True

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
        cmb_tipoDoc_profesor.Text = ""
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

        If cmb_tipoDoc_profesor.Text = "" Then
            MsgBox("Tipo de Documento no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            cmb_tipoDoc_profesor.Focus()
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
        txt_codProfesor.Enabled = x
        'txt_apellido_profesor.Enabled = x
        txt_calle_profesor.Enabled = x
        txt_nombre_profesor.Enabled = x
        txt_nroCalle_profesor.Enabled = x
        cmb_codPos_profesor.Enabled = x
        txt_telefono_profesor.Enabled = x
        cmb_tipoDoc_profesor.Enabled = x
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
            If Me.accion = estado.insertar Then
                If validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("Nuevo Profesor cargado con éxito", "Operación completa")

                Else : MessageBox.Show("El Profesor que intenta guardar ya está registrado", "Error")

                End If
            Else : Me.modificar()
                MessageBox.Show("Profesor modificado con éxito", "Operación completa")
            End If

            Me.inicio()
        End If

    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.inicio()
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If txt_codProfesor.Text = "" Then
            MsgBox("No se ha seleccionado ningún Profesor", MsgBoxStyle.Critical, "Error")
        Else

            If MessageBox.Show("¿Está seguro que desea eliminar el Profesor " & txt_codProfesor.Text & "?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                If Me.delete() = termino.aprobado Then
                    MessageBox.Show("Profesor eliminado", "Operación completada")
                    Me.inicio()
                End If
            End If
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
        Me.accion = estado.insertar
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        cambiarBotones(False)
        Me.cmd_buscar.Enabled = True
        Me.cmd_cancelar.Enabled = True

        If txt_apellido_profesor.Text <> "" And txt_codProfesor.Text <> "" Then
            MsgBox("Ingrese sólo un criterio de búsqueda", MsgBoxStyle.Critical, "Importante")
            txt_codProfesor.Focus()

        Else

            If txt_codProfesor.Text = "" Then
                If txt_apellido_profesor.Text = "" Then
                    MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
                    txt_codProfesor.Focus()

                Else
                    Dim consulta As String = ""
                    Dim dt As New Data.DataTable
                    consulta = "SELECT * FROM Profesores WHERE apellido LIKE '%" & Me.txt_apellido_profesor.Text & "%'"
                    dt = acceso.ejecutar(consulta)
                    grid_profesores.DataSource = dt
                End If
            Else
                Dim consulta As String = ""
                Dim dt As New Data.DataTable
                consulta = "SELECT * FROM Profesores WHERE codProfe = '" & Me.txt_codProfesor.Text & "'"
                dt = acceso.ejecutar(consulta)
                grid_profesores.DataSource = dt

            End If
        End If

    End Sub


    Private Sub cmd_nuevoCP_Click(sender As Object, e As EventArgs) Handles cmd_nuevoCP.Click
        frm_ABMCodPos.ShowDialog()

    End Sub

    Private Sub grid_profesores_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grid_profesores.CellMouseDoubleClick

        Dim codigoSeleccionado As String = Me.grid_profesores.CurrentRow.Cells(0).Value

        Dim tabla As New Data.DataTable

        Dim consulta As String = ""
        consulta = "SELECT * FROM Profesores WHERE codProfe = " & codigoSeleccionado

        cambiarEntradas(True)
        tabla = acceso.ejecutar(consulta)

        Me.txt_codProfesor.Text = tabla.Rows(0)("codProfe")
        Me.txt_nombre_profesor.Text = tabla.Rows(0)("nombre")
        Me.txt_apellido_profesor.Text = tabla.Rows(0)("apellido")
        Me.txt_calle_profesor.Text = tabla.Rows(0)("calle")
        Me.txt_nroCalle_profesor.Text = tabla.Rows(0)("numero")
        Me.cmb_codPos_profesor.SelectedValue = tabla.Rows(0)("codPos")
        Me.cmb_tipoDoc_profesor.SelectedValue = tabla.Rows(0)("tipoDoc")
        Me.txt_telefono_profesor.Text = tabla.Rows(0)("telefono")
        Me.txt_nroDoc_profesor.Text = tabla.Rows(0)("nroDoc")

        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_eliminar.Enabled = True
        Me.cmd_guardar.Enabled = True

        Me.txt_codProfesor.Enabled = False
        txt_nombre_profesor.Focus()

        Me.accion = estado.modificar
    End Sub

    'Closing

    Private Sub frm_ABMProfesores_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            e.Cancel() = True
        End If
    End Sub

   
End Class