Public Class proc_inscripciones

    Private Sub proc_inscripciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicio()
    End Sub

    Dim seleccionado As Boolean = False
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
        cargar_grilla2()
        cambiarBotones(True)
        cambiarEntradas(True)
        cargar_combos()
        Me.txt_codNadador.Enabled = False
        seleccionado = False
        
        Me.cmd_salir.Enabled = True
    End Sub

    Private Sub limpiarCampos()
        Me.txt_año.Text = ""
        Me.txt_torneo.Text = ""
        Me.txt_especialidad.Text = ""

        Me.txt_codNadador.Text = ""
        'Me.txt_nombre.Text = ""
        Me.cmb_apellido.SelectedIndex = -1
    End Sub

    Private Function validarCampos()

        If txt_torneo.Text = "" Then
            MsgBox("Debe elegir una competencia", MsgBoxStyle.Critical, "Importante")
            Return False
        End If

        If txt_año.Text = "" Then
            MsgBox("Debe elegir una competencia", MsgBoxStyle.Critical, "Importante")

            Return False
        End If

        If cmb_apellido.Text = "" Then
            MsgBox("Debe elegir un nadador", MsgBoxStyle.Critical, "Importante")
            cmb_apellido.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
        Me.cmb_apellido.Enabled = x
    End Sub

    Private Sub cambiarBotones(ByVal x As Boolean)
        Me.cmd_inscribir.Enabled = x

        Me.cmd_eliminar.Enabled = x

        Me.cmd_salir.Enabled = x
        Me.cmd_cancelar.Enabled = x
    End Sub


    'BASE DE DATOS
    Private Function leo_tabla(ByRef _tabla) As DataTable
        Dim consulta As String = ""
        consulta = "SELECT * FROM " & _tabla
        Return acceso.ejecutar(consulta)
    End Function

    Private Sub cargar_combos()
        cargar_combo(cmb_apellido, leo_tabla("Nadadores"), "codNad", "apellido")
        '
        '    Dim tabla As Data.DataTable
        '    Dim consulta As String = ""
        '        consulta = "SELECT DISTINCT TorneosXAño.codTorneo, Torneos.descripcion FROM TorneosXAño INNER JOIN Torneos ON TorneosXAño.codTorneo = Torneos.codTorneo"
        '        tabla = acceso.ejecutar(consulta)
        '        cargar_combo(cmb_torneo, tabla, "codTorneo", "descripcion")
        '
    End Sub

    Private Sub cargar_grilla()

        Dim consulta As String = ""
        consulta = "SELECT Nadadores.apellido AS Apellido, Nadadores.nombre AS Nombre, Torneos.descripcion AS Torneo, Inscripciones.año, "
        consulta &= "Especialidades.descripcion AS Especialidad FROM Inscripciones INNER JOIN "
        consulta &= "Torneos ON Inscripciones.codTorneo = Torneos.codTorneo INNER JOIN "
        consulta &= "Especialidades ON Inscripciones.codEspe = Especialidades.codEspe INNER JOIN "
        consulta &= "Nadadores ON Inscripciones.codNad = Nadadores.codNad"
        grid_inscripciones.DataSource = acceso.ejecutar(consulta)



    End Sub

    Private Sub cargar_grilla2()

        Dim consulta As String = ""
        consulta = "SELECT Torneos.descripcion AS Torneo, Competencias.año AS Año, Especialidades.descripcion AS Especialidad, Competencias.fecha AS Fecha"
        consulta &= " FROM Competencias INNER JOIN"
        consulta &= " Torneos ON Competencias.codTorneo = Torneos.codTorneo INNER JOIN Especialidades ON Competencias.codEspe = Especialidades.codEspe"
        grid_competencias.DataSource = acceso.ejecutar(consulta)

    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        Me.inicio()
    End Sub

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub cargar_combo(ByRef combo As ComboBox, ByVal nombre_tabla As DataTable, ByVal pk As String, ByVal descrip As String)

        combo.DataSource = nombre_tabla
        combo.ValueMember = pk
        combo.DisplayMember = descrip
        combo.SelectedIndex = -1

    End Sub

    Private Function buscarCodTorneo() As Integer
        Dim consulta As String
        consulta = ""
        consulta = "SELECT * FROM Torneos WHERE descripcion LIKE ('" & txt_torneo.Text & "')"
        Dim tabla As New Data.DataTable
        tabla = acceso.ejecutar(consulta)

        Dim codigoSeleccionado As Integer

        codigoSeleccionado = tabla.Rows(0)("codTorneo")
        Return codigoSeleccionado
    End Function

    Private Function buscarCodEspe() As Integer
        Dim consulta As String
        consulta = ""
        consulta = "SELECT * FROM Especialidades WHERE descripcion LIKE ('" & txt_especialidad.Text & "')"
        Dim tabla As New Data.DataTable
        tabla = acceso.ejecutar(consulta)

        Dim codigoSeleccionado As Integer

        codigoSeleccionado = tabla.Rows(0)("codEspe")
        Return codigoSeleccionado
    End Function
    Private Function insertar() As termino


        Dim mostrar As String
        Dim nadador As String
        Dim consulta As String

        mostrar = ""
        mostrar &= "Torneo: " & txt_torneo.Text & vbCrLf
        mostrar &= "Año: " & txt_año.Text & vbCrLf
        mostrar &= "Especialidad: " & txt_especialidad.Text & vbCrLf

        nadador = Me.cmb_apellido.Text

        If MessageBox.Show("¿Esta seguro de continuar? Inscripcion:  " & vbCrLf & mostrar & vbCrLf & "Nadador: " & nadador, "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

            Dim codTorneo As Integer = buscarCodTorneo()
            Dim codEspe As Integer = buscarCodEspe()



            consulta = "INSERT INTO Inscripciones (codTorneo, año, codEspe, codNad) "
            consulta &= "VALUES(" & codTorneo & "," & Me.txt_año.Text & "," & codEspe & "," & txt_codNadador.Text & ")"
            acceso.ejecutarNonConsulta(consulta)

            Me.cargar_grilla()


            Me.inicio()
            Return termino.aprobado
        Else
            Exit Function
        End If

    End Function
    Private Function delete() As termino
        Dim codTorneo As Integer = buscarCodTorneo()
        Dim año As Integer = txt_año.Text
        Dim codEspe As Integer = buscarCodEspe()
        Dim codNad As Integer = txt_codNadador.Text


        Dim consulta As String = "DELETE FROM Inscripciones WHERE codTorneo = " & codTorneo
        consulta &= " AND año = " & año & " AND codEspe = " & codEspe & " AND codNad = " & codNad
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado
    End Function

    Private Sub cmd_inscribir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_inscribir.Click
        If validarCampos() = True Then

            If validar_existencia() = termino.aprobado Then
                Me.insertar()
                MessageBox.Show("Nueva inscripcion cargada con éxito", "Operación completa")

            Else : MessageBox.Show("Ese nadador ya se encuentra inscripto en esa competencia", "Error")



            End If


            Me.inicio()
        End If
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If seleccionado = True Then
            If MessageBox.Show("¿Está seguro que desea eliminar la inscripción seleccionada?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                If Me.delete() = termino.aprobado Then
                    MessageBox.Show("Inscripción eliminada", "Operación completada")
                    Me.inicio()
                End If
            End If
        Else
            MsgBox("Seleccione una inscripción para eliminar", MsgBoxStyle.Critical, "Error")
        End If

    End Sub



    'Private Sub cmb_torneo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ' Dim tabla As New DataTable
    ' Dim consulta As String = ""
    '     consulta = "SELECT * FROM TorneosXAño INNER JOIN Torneos ON TorneosXAño.codTorneo = Torneos.codTorneo WHERE Torneos.descripcion = '" & Me.cmb_torneo.Text & "'"
    '     tabla = acceso.ejecutar(consulta)
    '     cargar_combo(cmb_año, tabla, "año", "año")
    ' End Sub
    '
    '    Private Sub cmb_año_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ' Dim consulta As String = ""
    '    consulta = "SELECT Torneos.descripcion AS Torneo, Competencias.año AS Año, Especialidades.descripcion AS Especialidad, Competencias.fecha AS Fecha"
    '    consulta &= " FROM Competencias INNER JOIN"
    '    consulta &= " Torneos ON Competencias.codTorneo = Torneos.codTorneo INNER JOIN Especialidades ON Competencias.codEspe = Especialidades.codEspe"
    '    consulta &= " WHERE Torneos.codTorneo = '" & Me.cmb_torneo.ValueMember & "' AND Competencias.año = " & cmb_año.ValueMember
    '    grid_competencias.DataSource = acceso.ejecutar(consulta)
    'End Sub
    Private Function validar_existencia() As termino

        Dim codTorneo As Integer = buscarCodTorneo()
        Dim codEspe As Integer = buscarCodEspe()
        Dim consulta As String = ""
        Dim tabla As Data.DataTable
        consulta = "SELECT * FROM Inscripciones WHERE codTorneo = " & codTorneo & " AND año = " & txt_año.Text
        consulta &= " AND codEspe = " & codEspe & " AND codNad = " & txt_codNadador.Text
        tabla = acceso.ejecutar(consulta)
        If tabla.Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Sub grid_competencias_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grid_competencias.CellMouseDoubleClick

        Dim torneoSeleccionado As String = Me.grid_competencias.CurrentRow.Cells(0).Value
        Dim añoSeleccionado As Integer = Me.grid_competencias.CurrentRow.Cells(1).Value
        Dim espeSeleccionada As String = Me.grid_competencias.CurrentRow.Cells(2).Value

        Me.txt_torneo.Text = torneoSeleccionado
        Me.txt_año.Text = añoSeleccionado
        Me.txt_especialidad.Text = espeSeleccionada
    End Sub

    Private Sub grid_inscripciones_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grid_inscripciones.CellMouseDoubleClick
        Me.cmb_apellido.Text = Me.grid_inscripciones.CurrentRow.Cells(0).Value
        Me.txt_torneo.Text = Me.grid_inscripciones.CurrentRow.Cells(2).Value
        Me.txt_año.Text = Me.grid_inscripciones.CurrentRow.Cells(3).Value
        Me.txt_especialidad.Text = Me.grid_inscripciones.CurrentRow.Cells(4).Value
        seleccionado = True
    End Sub

    Private Sub cmb_apellido_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_apellido.SelectedValueChanged
        'Dim tabla As New DataTable
        'Dim consulta As String = ""
        'consulta = "SELECT * FROM Nadadores WHERE apellido LIKE ('" & cmb_apellido.SelectedText.ToString & "')"
        'tabla = acceso.ejecutar(consulta)
        'txt_codNadador = tabla.Rows(0)("codNad")
        'txt_nombre = tabla.Rows(0)("nombre")

        If cmb_apellido.SelectedIndex = -1 Then
            txt_codNadador.Text = ""
        Else
            txt_codNadador.Text = cmb_apellido.SelectedValue.ToString
        End If












    End Sub
End Class