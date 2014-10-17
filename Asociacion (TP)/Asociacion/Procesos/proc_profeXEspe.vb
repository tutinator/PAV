Public Class proc_profeXEspe

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

    Private Sub ProfeXEspe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.inicio()
    End Sub

    'Subrutinas

    Private Sub inicio()

        cambiarEntradas(True)
        Me.txt_nombre.Enabled = True
        cambiarBotones(False)
        Me.cmd_buscar_id.Enabled = True
        Me.cmd_salir.Enabled = True
        Me.txt_id.Focus()

    End Sub

    Private Sub limpiarCampos()
        Me.txt_id.Text = ""
        Me.txt_apellido.Text = ""
        Me.txt_nombre.Text = ""
    End Sub

    Private Function validarCampos()

        If txt_id.Text = "" Then
            MsgBox("ID de profesor no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_id.Focus()
            Return False
        End If
        Return True

    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)

        limpiarCampos()
        Me.txt_id.Enabled = x
        Me.txt_apellido.Enabled = x
        '  Me.txt_nombre.Enabled = x

    End Sub

    Private Sub cambiarBotones(ByVal x As Boolean)
        Me.cmd_buscar_id.Enabled = x
        Me.cmd_agregar.Enabled = x
        Me.cmd_desagregar.Enabled = x
        Me.cmd_salir.Enabled = x
    End Sub

    'BASE DE DATOS
    Private Function leo_tabla(ByRef _tabla) As DataTable

        Dim consulta As String = ""
        consulta = "SELECT * FROM " & _tabla
        Return acceso.ejecutar(consulta)

    End Function

    Private Sub cargar_lista(ByRef lista As ListBox, ByVal nombre_tabla As DataTable, ByVal pk As String, ByVal descrip As String)

        lista.DataSource = nombre_tabla
        lista.ValueMember = pk
        lista.DisplayMember = descrip

    End Sub

    Private Sub cargar_combo(ByRef combo As ComboBox, ByVal nombre_tabla As DataTable, ByVal pk As String, ByVal descrip As String)

        combo.DataSource = nombre_tabla
        combo.ValueMember = pk
        combo.DisplayMember = descrip
        combo.SelectedIndex = -1

    End Sub


    Private Sub cargar_listas()

        Dim tabla As New Data.DataTable
        Dim consulta As String = ""
        consulta = "SELECT * FROM Especialidades INNER JOIN ProfeXEspe ON Especialidades.codEspe = ProfeXEspe.codEspe"
        consulta &= " WHERE codProfe = " & Me.txt_id.Text
        tabla = acceso.ejecutar(consulta)
        cargar_lista(lista_esp_profesor, tabla, "codEspe", "descripcion")
        consulta = "SELECT codEspe, descripcion FROM Especialidades WHERE codEspe NOT IN "
        consulta &= "(SELECT codEspe FROM ProfeXEspe WHERE codProfe = " & Me.txt_id.Text & ")"
        tabla = acceso.ejecutar(consulta)
        cargar_lista(lista_especialidades, tabla, "codEspe", "descripcion")

    End Sub


    'En caso d cambiar por un combo el id de nadador
    'Private Sub cargar_combos()
    '    cargar_combo(cmb_id, leo_tabla("Nadadores"), "codNad", "codNad")
    '    Dim tabla As Data.DataTable
    '    Dim consulta As String = ""
    '    consulta = "SELECT * FROM Nadadores "
    '    tabla = acceso.ejecutar(consulta)

    'End Sub



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



    '----FIN BD


    '-------------------------------------------------------------------------


    Private Function leo_tabla_Nad(ByVal pk) As DataTable

        Dim consulta As String = ""
        consulta = "SELECT * FROM Profesores WHERE Profesores.codProfe = " & pk
        Return acceso.ejecutar(consulta)

    End Function

    Private Function leo_tabla_Nad2(ByVal ape) As DataTable

        Dim consulta As String = ""
        consulta = "SELECT * FROM Profesores WHERE apellido LIKE '" & ape & "'"
        Return acceso.ejecutar(consulta)

    End Function



    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar_id.Click

        cambiarBotones(True)

        Dim cont As Integer = 0
        If txt_id.Text <> "" Then cont = cont + 1
        If txt_apellido.Text <> "" Then cont = cont + 1

        'If txt_apellido.Text <> "" Then cont = cont + 1

        If cont = 0 Then
            MsgBox("Ingrese un criterio para buscar", MsgBoxStyle.Critical, "Importante")
            txt_id.Focus()
            Exit Sub
        End If

        If cont > 1 Then
            MsgBox("Ingrese sólo un criterio de búsqueda", MsgBoxStyle.Critical, "Importante")
            Me.limpiarCampos()
            txt_id.Focus()
            Exit Sub
        End If


        If txt_id.Text <> "" Then

            Dim tabla As New Data.DataTable
            tabla = Me.leo_tabla_Nad(Me.txt_id.Text)

            If tabla.Rows.Count > 0 Then

                Me.txt_id.Text = tabla.Rows(0)("codProfe")
                Me.txt_apellido.Text = tabla.Rows(0)("apellido")
                Me.txt_nombre.Text = tabla.Rows(0)("nombre")
                Me.cargar_listas()

            Else
                MsgBox("No existe ese profesor", MsgBoxStyle.Critical, "Importante")
                Me.limpiarCampos()
            End If

        End If
    End Sub

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub


    Private Sub cmd_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_agregar.Click
        Dim consulta As String
        Dim tabla As New Data.DataTable

        consulta = "SELECT codEspe, descripcion FROM Especialidades WHERE codEspe NOT IN (SELECT CodEspe"
        consulta &= " FROM ProfeXEspe WHERE codProfe = " & Me.txt_id.Text & ")"
        tabla = acceso.ejecutar(consulta)

        If tabla.Rows.Count > 0 Then
            consulta = "INSERT INTO ProfeXEspe (codNad, codEspe) "
            consulta &= "VALUES (" & Me.txt_id.Text & ", " & Me.lista_especialidades.SelectedValue & ")"
            tabla = acceso.ejecutar(consulta)
            Me.cargar_listas()
        End If

    End Sub

    Private Sub cmd_desagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_desagregar.Click
        Dim consulta As String
        Dim tabla As New Data.DataTable

        consulta = "SELECT * FROM ProfeXEspe WHERE codProfe = " & Me.txt_id.Text
        tabla = acceso.ejecutar(consulta)

        If tabla.Rows.Count > 0 Then
            consulta = "DELETE FROM ProfeXEspe WHERE codEspe = " & Me.lista_esp_profesor.SelectedValue & " AND codProfe = " & Me.txt_id.Text & ""
            tabla = acceso.ejecutar(consulta)
            Me.cargar_listas()
        End If
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        limpiarCampos()
    End Sub


End Class