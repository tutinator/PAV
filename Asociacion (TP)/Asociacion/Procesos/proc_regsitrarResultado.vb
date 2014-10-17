Public Class proc_regsitrarResultado
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

    Private Sub proc_regsitrarResultado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.inicio()
    End Sub

    Private Sub inicio()
        Me.cmb_cod_nad.Visible = True
        Me.txt_cod_nad.Visible = False
        Me.cargar_combos()
        Me.cargar_grilla_competencias()
        Me.cargar_grilla_inscripciones()
        'cambiarEntradas(False)
        Me.cmb_torneo.Enabled = True
        Me.cmb_año.Enabled = True
        Me.cmb_especialidad.Enabled = True
        Me.cmb_torneo.Focus()

    End Sub

    Private Sub limpiarCampos_competencia()
        Me.cmb_año.Text = ""
        Me.cmb_torneo.Text = ""
        Me.cmb_especialidad.Text = ""
        Me.cmb_torneo.SelectedIndex = -1
        Me.cmb_especialidad.SelectedIndex = -1
        Me.cmb_año.SelectedIndex = -1
    End Sub

    Private Function validarCampos()

        If cmb_torneo.Text = "" Then
            MsgBox("Torneo no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            cmb_torneo.Focus()
            Return False
        End If

        If cmb_año.Text = "" Then
            MsgBox("Año de torneo no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            cmb_año.Focus()
            Return False
        End If

        If cmb_especialidad.Text = "" Then
            MsgBox("La especialidad no puede estar vacía", MsgBoxStyle.Critical, "Importante")
            cmb_año.Focus()
            Return False
        End If

        If cmb_cod_nad.Text = "" Then
            MsgBox("El código del nadador no puede estar vacío", MsgBoxStyle.Critical, "Importante")

            Return False
        End If

        Return True
    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)
        Me.cmb_año.Enabled = x
        Me.cmb_torneo.Enabled = x
        Me.cmb_especialidad.Enabled = x
        'Me.txt_fecha.Enabled = x
    End Sub

    Private Function leo_tabla(ByRef _tabla) As DataTable
        Dim consulta As String = ""
        consulta = "SELECT * FROM " & _tabla
        Return acceso.ejecutar(consulta)
    End Function

    Private Sub cargar_grilla_competencias()

        Dim consulta As String = ""
        consulta = "SELECT Torneos.descripcion AS Torneo, Competencias.año AS Año, Especialidades.descripcion AS Especialidad, Competencias.fecha AS Fecha"
        consulta &= " FROM Competencias INNER JOIN Especialidades ON Competencias.codEspe = Especialidades.codEspe INNER JOIN"
        consulta &= " TorneosXAño ON Competencias.codTorneo = TorneosXAño.codTorneo AND Competencias.año = TorneosXAño.año INNER JOIN Torneos ON Competencias.codTorneo = Torneos.codTorneo"
        grid_competencias.DataSource = acceso.ejecutar(consulta)
    End Sub

    Private Sub cargar_grilla_inscripciones()
        Dim consulta2 As String = ""
        consulta2 = "SELECT Nadadores.apellido AS Apellido, Nadadores.nombre AS Nombre, Torneos.descripcion AS Torneo, Inscripciones.año, "
        consulta2 &= "Especialidades.descripcion AS Especialidad, Inscripciones.tiempo as Tiempo FROM Inscripciones INNER JOIN "
        consulta2 &= "Torneos ON Inscripciones.codTorneo = Torneos.codTorneo INNER JOIN "
        consulta2 &= "Especialidades ON Inscripciones.codEspe = Especialidades.codEspe INNER JOIN "
        consulta2 &= "Nadadores ON Inscripciones.codNad = Nadadores.codNad"
        grid_inscripciones.DataSource = acceso.ejecutar(consulta2)
    End Sub

    Private Sub cargar_combo(ByRef combo As ComboBox, ByVal nombre_tabla As DataTable, ByVal pk As String, ByVal descrip As String)

        combo.DataSource = nombre_tabla
        combo.ValueMember = pk
        combo.DisplayMember = descrip
        combo.SelectedIndex = -1

    End Sub

    Private Sub cargar_combos()
        Dim tabla As Data.DataTable
        Dim consulta As String = ""
        consulta = "SELECT Torneos.codTorneo, Torneos.descripcion FROM Competencias INNER JOIN Torneos ON Competencias.codTorneo = Torneos.codTorneo"
        tabla = acceso.ejecutar(consulta)
        cargar_combo(cmb_torneo, tabla, "codTorneo", "descripcion")
    End Sub

    Private Function modificar() As termino

        Dim consulta As String = ""
        consulta = "UPDATE Inscripciones SET tiempo = "
        If txt_tiempo.Text = "  :  :" Then
            consulta &= "NULL"
        Else
            consulta &= "'" & txt_tiempo.Text & "'"
        End If
        consulta &= " WHERE codTorneo = " & Me.cmb_torneo.SelectedValue & " AND año = " & Me.cmb_año.SelectedValue & ""
        consulta &= " AND codEspe = " & Me.cmb_especialidad.SelectedValue & " AND codNad = " & Me.cmb_cod_nad.Text

        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado

    End Function

    'Private Function insertar() As termino

    '    Dim consulta As String = ""
    '    consulta = "INSERT INTO Competencias (codTorneo, año, codEspe, fecha)"
    '    consulta &= "VALUES (" & Me.cmb_torneo.SelectedValue & ", " & Me.cmb_año.SelectedValue & ", "
    '    'consulta &= Me.cmb_especialidad.SelectedValue & ", '" & Me.dtp_fecha.Value & "')"
    '    acceso.ejecutarNonConsulta(consulta)
    '    Return termino.aprobado

    'End Function

    'Private Function validar_existencia() As termino

    '    Dim consulta As String = ""
    '    Dim tabla As Data.DataTable
    '    consulta = "SELECT * FROM Competencias WHERE codTorneo = " & Me.cmb_torneo.SelectedValue & " AND año = " & Me.cmb_año.SelectedValue
    '    consulta &= " AND codEspe = " & Me.cmb_especialidad.SelectedValue
    '    tabla = acceso.ejecutar(consulta)
    '    If tabla.Rows.Count() = 1 Then
    '        Return termino.rechazado
    '    Else
    '        Return termino.aprobado
    '    End If
    'End Function

    'Private Function delete() As termino
    '    Dim consulta As String = "DELETE FROM Competencias WHERE codTorneo = " & Me.cmb_torneo.SelectedValue
    '    consulta &= " AND año = " & Me.cmb_año.SelectedValue & " AND codEspe = " & Me.cmb_especialidad.SelectedValue
    '    acceso.ejecutarNonConsulta(consulta)
    '    Return termino.aprobado
    'End Function

    '----FIN BD

    '--PARTE COMPETENCIA
    Private Sub cmb_torneo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_torneo.SelectedValueChanged
        Dim tabla As New DataTable
        Dim consulta As String = ""
        consulta = "SELECT Competencias.año, Especialidades.codEspe, Especialidades.descripcion FROM Competencias INNER JOIN Torneos ON Competencias.codTorneo = Torneos.codTorneo"
        consulta &= " INNER JOIN Especialidades ON Competencias.codEspe = Especialidades.codEspe WHERE Torneos.descripcion = '" & Me.cmb_torneo.Text & "'"
        tabla = acceso.ejecutar(consulta)
        cargar_combo(cmb_año, tabla, "año", "año")
        cargar_combo(cmb_especialidad, tabla, "codEspe", "descripcion")
    End Sub



    Private Sub cmb_cod_nad_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_cod_nad.SelectionChangeCommitted
        Dim tabla As New DataTable
        Dim consulta As String = ""
        consulta = "SELECT * FROM Nadadores WHERE codNad = " & Me.cmb_cod_nad.Text
        tabla = acceso.ejecutar(consulta)
        Me.txt_apellido_nad.Text = tabla.Rows(0)("apellido")
        Me.txt_nombre_nad.Text = tabla.Rows(0)("nombre")
    End Sub



    Private Sub cmd_buscarCompetencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscarCompetencia.Click
        Dim cont As Integer = 0
        If cmb_año.Text <> "" Then cont = cont + 1
        If cmb_torneo.Text <> "" Then cont = cont + 1
        If cmb_especialidad.Text <> "" Then cont = cont + 1

        If cont = 0 Then
            MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
            cmb_torneo.Focus()
            Exit Sub
        End If
        If cmb_torneo.Text <> "" And cmb_año.Text <> "" Then
            Dim consulta As String = ""
            Dim dt As New Data.DataTable
            consulta = "SELECT Torneos.descripcion AS Torneo, Competencias.año AS Año, Especialidades.descripcion AS Especialidad, Competencias.fecha AS Fecha"
            consulta &= " FROM Competencias INNER JOIN Especialidades ON Competencias.codEspe = Especialidades.codEspe INNER JOIN"
            consulta &= " TorneosXAño ON Competencias.codTorneo = TorneosXAño.codTorneo INNER JOIN Torneos ON TorneosXAño.codTorneo = Torneos.codTorneo"
            consulta &= " WHERE Torneos.descripcion = '" & Me.cmb_torneo.Text & "' AND  Competencias.año = " & Me.cmb_año.Text
            dt = acceso.ejecutar(consulta)
            grid_competencias.DataSource = dt
        ElseIf cmb_especialidad.Text <> "" Then
            Dim consulta As String = ""
            Dim dt As New Data.DataTable
            consulta = "SELECT Torneos.descripcion AS Torneo, Competencias.año AS Año, Especialidades.descripcion AS Especialidad, Competencias.fecha AS Fecha"
            consulta &= " FROM Competencias INNER JOIN Especialidades ON Competencias.codEspe = Especialidades.codEspe INNER JOIN"
            consulta &= " TorneosXAño ON Competencias.codTorneo = TorneosXAño.codTorneo INNER JOIN Torneos ON TorneosXAño.codTorneo = Torneos.codTorneo"
            consulta &= " WHERE Especialidades.descripcion = '" & Me.cmb_especialidad.Text & "'"
            dt = acceso.ejecutar(consulta)
            grid_competencias.DataSource = dt
        End If
    End Sub

    Private Sub grid_competencias_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grid_competencias.CellMouseDoubleClick
        Dim torneoSeleccionado As String = Me.grid_competencias.CurrentRow.Cells(0).Value
        Dim añoSeleccionado As Integer = Me.grid_competencias.CurrentRow.Cells(1).Value
        Dim espeSeleccionada As String = Me.grid_competencias.CurrentRow.Cells(2).Value
        Dim tabla As New Data.DataTable
        Dim consulta As String = ""
        consulta = "SELECT * FROM Competencias INNER JOIN Torneos ON Competencias.codTorneo = Torneos.codTorneo"
        consulta &= " INNER JOIN Especialidades ON Competencias.codEspe = Especialidades.codEspe"
        consulta &= " WHERE Torneos.descripcion = '" & torneoSeleccionado & "' AND Competencias.año = " & añoSeleccionado
        consulta &= " AND Especialidades.descripcion = '" & espeSeleccionada & "'"
        tabla = acceso.ejecutar(consulta)
        Me.cmb_torneo.SelectedValue = tabla.Rows(0)("codTorneo")
        Me.cmb_año.SelectedValue = tabla.Rows(0)("año")
        Me.cmb_especialidad.SelectedValue = tabla.Rows(0)("codEspe")
        cmb_torneo.Focus()
        Me.accion = estado.modificar

        consulta = "SELECT DISTINCT Inscripciones.codNad FROM Inscripciones INNER JOIN Torneos ON Inscripciones.codTorneo = Torneos.codTorneo"
        consulta &= " INNER JOIN Especialidades ON Inscripciones.codEspe = Especialidades.codEspe"
        consulta &= " WHERE Torneos.descripcion = '" & torneoSeleccionado & "' AND Inscripciones.año = " & añoSeleccionado
        consulta &= " AND Especialidades.descripcion = '" & espeSeleccionada & "'"
        Dim tabla2 As Data.DataTable
        tabla2 = acceso.ejecutar(consulta)
        cargar_combo(cmb_cod_nad, tabla2, "codNad", "codNad")
    End Sub


    Private Sub cmd_cancelar_competencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar_competencia.Click
        Me.cargar_combos()
        Me.cargar_grilla_competencias()
        Me.limpiarCampos_competencia()
    End Sub
    '------FIN PARTE COMPETENCIA

    '------PARTE NADADOR

    Private Sub cmd_buscar_nad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Me.txt_cod_nad.Text <> "" Then
            Dim consulta As String = ""
            Dim dt As New Data.DataTable
            consulta = "SELECT Nadadores.codNad, Nadadores.nombre, Nadadores.apellido, Inscripciones.codEspe, Inscripciones.año, Inscripciones.codTorneo"
            consulta &= " FROM Inscripciones INNER JOIN Nadadores ON Inscripciones.codNad = Nadadores.codNad"
            consulta &= " WHERE codTorneo = " & Me.cmb_torneo.SelectedValue & " AND codEspe = " & Me.cmb_especialidad.SelectedValue
            consulta &= " AND año = " & Me.cmb_año.SelectedValue & " AND Nadadores.codNad = " & Me.txt_cod_nad.Text
            dt = acceso.ejecutar(consulta)

            If dt.Rows.Count = 0 Then
                MsgBox("No hay nadadores registrado a esa competencia", MsgBoxStyle.Critical, "Importante")
            ElseIf dt.Rows.Count = 1 Then
                cambiarEntradas(True)
                Me.txt_cod_nad.Text = dt.Rows(0)("codNad")
                Me.txt_nombre_nad.Text = dt.Rows(0)("nombre")
                Me.txt_apellido_nad.Text = dt.Rows(0)("apellido")
            End If
            Return
        End If

        If txt_apellido_nad.Text <> "" Then
            Dim consulta As String = ""
            Dim dt As New Data.DataTable
            consulta = "SELECT Nadadores.nombre, Nadadores.apellido, Nadadores.codNad, Inscripciones.codEspe, Inscripciones.año, Inscripciones.codTorneo"
            consulta &= " Inscripciones INNER JOIN Nadadores ON Inscripciones.codNad = Nadadores.codNad"
            consulta &= " WHERE codTorneo = " & Me.cmb_torneo.SelectedValue & "AND codEspe = " & Me.cmb_especialidad.SelectedValue
            consulta &= " AND año = " & Me.cmb_año.SelectedValue & " AND apellido LIKE '" & Me.txt_apellido_nad.Text & "'"
            dt = acceso.ejecutar(consulta)
            If dt.Rows.Count = 0 Then
                MsgBox("No hay nadadores registrado a esa competencia con ese apellido", MsgBoxStyle.Critical, "Importante")
                Me.txt_cod_nad.Focus()
            ElseIf dt.Rows.Count = 1 Then
                Me.txt_cod_nad.Text = dt.Rows(0)("codNad")
                Me.txt_nombre_nad.Text = dt.Rows(0)("nombre")
                Me.txt_apellido_nad.Text = dt.Rows(0)("apellido")
            Else
                Me.txt_cod_nad.Visible = False
                Me.cmb_cod_nad.Visible = True
                cargar_combo(cmb_cod_nad, dt, "codNad", "codNad")
            End If
        End If

        'If Me.txt_codProfe.Text <> "" And Me.txt_apellido.Text <> "" And Me.txt_nombre_profe.Text <> "" Then
        '    cargar_listas()
        'End If
    End Sub

    Private Sub cmd_guardar_resultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar_resultado.Click
        If validarCampos() = True Then
            Me.modificar()
            MessageBox.Show("Tiempo registrado con éxito", "Operación completa")
        End If
        Me.inicio()
    End Sub


    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub
End Class