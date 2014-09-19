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
        consulta = "SELECT Profesores.codProfe AS Codigo, Profesores.nombre AS Nombre, Profesores.apellido AS Apellido, Profesores.calle AS Calle, Profesores.numero AS Numero, Profesores.telefono AS Telefono, Profesores.nroDoc as Documento"
        consulta &= "CodPostales.codPos AS [Codigo Postal], CodPostales.nombre AS [Area] "
        consulta &= "TiposDoc.tipoDoc AS [Tipo], TiposDoc.nombre AS [Nombre] "
        consulta &= "FROM Profesores INNER JOIN CodPostales ON Clubes.codPos = CodPostales.codPos INNER JOIN TiposDoc ON Profesores.tipoDoc = TiposDoc.tipoDoc"

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
        cargar_combo(cmb_tipoDoc_profesor, leo_tabla("CodPostales"), "codPos", "codPos")

    End Sub

    Private Function modificar() As termino

        'REVISAR ESTOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

        Dim consulta As String = ""
        consulta = "UPDATE Profesores SET nombre = '" & Me.txt_nombre_profesor.Text & "', "
        consulta &= "calle = '" & Me.txt_calle_profesor.Text & "', "
        consulta &= "apellido = '" & Me.txt_apellido_profesor.Text & "', "
        consulta &= "numero = " & Me.txt_nroCalle_profesor.Text & ", "
        consulta &= "telefono = " & Me.txt_telefono_profesor.Text & ", "
        consulta &= "codPos = " & Me.cmb_codPos_profesor.SelectedValue.ToString & " "
        consulta &= "WHERE codClub = " & Me.txt_codProfesor.Text

        acceso.ejecutarNonConsulta(consulta)

        Return termino.aprobado

    End Function

    Private Function insertar() As termino

        'REVISAR ESTOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

        Dim consulta As String = ""
        consulta = "INSERT into Clubes "
        consulta &= "values ('" & Me.txt_codProfesor.Text & "', '" & Me.txt_nombre_profesor.Text & "', "
        consulta &= "'" & Me.txt_calle.Text & "', " & Me.txt_nroCalle.Text & ", "
        consulta &= Me.txt_telefono.Text & ", " & Me.cmb_codPos.SelectedValue & ")"

        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado

    End Function

    Private Function validar_existencia() As termino

        Dim consulta As String = ""
        Dim tabla As Data.DataTable

        consulta = "select * from Clubes where codClub = " & Me.txt_codClub.Text
        tabla = acceso.ejecutar(consulta)


        If tabla.Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Function delete() As termino
        Dim consulta As String = "DELETE FROM Clubes WHERE codClub = " & Me.txt_codClub.Text
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado
    End Function

    Private Sub cmb_codPos_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_codPos.DropDown
        cargar_combo(cmb_codPos, leo_tabla("CodPostales"), "codPos", "codPos")
    End Sub





    'Subrutinas

    Private Sub inicio()
        cargar_grilla()
        cargar_combos()
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
        'txt_codClub.Enabled = x
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

    Private Sub grid_clubes_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grid_clubes.CellMouseDoubleClick

        Dim codigoSeleccionado As String = Me.grid_clubes.CurrentRow.Cells(0).Value

        Dim tabla As New Data.DataTable

        Dim consulta As String = ""
        consulta = "SELECT * FROM Clubes WHERE codClub = " & codigoSeleccionado

        cambiarEntradas(True)
        tabla = acceso.ejecutar(consulta)

        Me.txt_codClub.Text = tabla.Rows(0)("codClub")
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_calle.Text = tabla.Rows(0)("calle")
        Me.txt_nroCalle.Text = tabla.Rows(0)("numero")
        Me.txt_telefono.Text = tabla.Rows(0)("telefono")
        Me.cmb_codPos.SelectedValue = tabla.Rows(0)("codPos")

        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_eliminar.Enabled = True
        Me.cmd_guardar.Enabled = True

        Me.txt_codClub.Enabled = False
        txt_nombre.Focus()

        Me.accion = estado.modificar

        'Closing

    Private Sub frm_ABMProfesores_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            e.Cancel() = True
        End If
    End Sub

End Class