Public Class proc_nadadoresXEspe


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


    Private Sub proc_nadadoresXEspe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.inicio()

    End Sub


    'Subrutinas

    Private Sub inicio()

        cargar_grilla()
        Me.cargar_combos()
        cambiarEntradas(True)
        Me.txt_nombre.Enabled = False
        cambiarBotones(False)
        Me.cmd_buscar_id.Enabled = True
        Me.cmd_buscar_apellido.Enabled = True
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
            MsgBox("Legajo de nadador no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_id.Focus()
            Return False
        End If
        Return True

    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)

        limpiarCampos()
        Me.txt_id.Enabled = x
        Me.txt_apellido.Enabled = x
        Me.txt_nombre.Enabled = x

    End Sub

    Private Sub cambiarBotones(ByVal x As Boolean)
        Me.cmd_buscar_id.Enabled = x
        Me.cmd_buscar_apellido.Enabled = x
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

    'En caso d cambiar por un combo el id de nadador
    'Private Sub cargar_combos()
    '    cargar_combo(cmb_id, leo_tabla("Nadadores"), "codNad", "codNad")
    '    Dim tabla As Data.DataTable
    '    Dim consulta As String = ""
    '    consulta = "SELECT * FROM Nadadores "
    '    tabla = acceso.ejecutar(consulta)

    'End Sub

    Private Function modificar() As termino

        Dim consulta As String = ""
        consulta = "UPDATE Competencias SET fecha = '" & Me.dtp_fecha.Value & "'"
        consulta &= " WHERE codTorneo = " & Me.cmb_torneo.SelectedValue & " AND año = " & Me.cmb_año.SelectedValue & ""
        consulta &= " AND codEspe = " & Me.cmb_especialidad.SelectedValue
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado

    End Function

    Private Function insertar() As termino

        Dim consulta As String = ""
        consulta = "INSERT INTO Competencias (codTorneo, año, codEspe, fecha)"
        consulta &= "VALUES (" & Me.cmb_torneo.SelectedValue & ", " & Me.cmb_año.SelectedValue & ", "
        consulta &= Me.cmb_especialidad.SelectedValue & ", '" & Me.dtp_fecha.Value & "')"
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado

    End Function

    Private Function validar_existencia() As termino

        Dim consulta As String = ""
        Dim tabla As Data.DataTable
        consulta = "SELECT * FROM Competencias WHERE codTorneo = " & Me.cmb_torneo.SelectedValue & " AND año = " & Me.cmb_año.SelectedValue
        consulta &= " AND codEspe = " & Me.cmb_especialidad.SelectedValue
        tabla = acceso.ejecutar(consulta)
        If tabla.Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Function delete() As termino
        Dim consulta As String = "DELETE FROM Competencias WHERE codTorneo = " & Me.cmb_torneo.SelectedValue
        consulta &= " AND año = " & Me.cmb_año.SelectedValue & " AND codEspe = " & Me.cmb_especialidad.SelectedValue
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado
    End Function

    '----FIN BD


    '-------------------------------------------------------------------------


    Private Function leo_tabla_Nad(ByRef _tabla, ByVal pk) As DataTable

        Dim consulta As String = ""
        consulta = "SELECT * FROM Nadadores WHERE Nadadores.codNad = " & pk
        Return acceso.ejecutar(consulta)


    End Function




    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar_apellido.Click, cmd_buscar_id.Click

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


            'Continuar aca

            tabla = Me.leo_tabla("Nadadores")

            If tabla.Rows.Count > 0 Then
                Me.txt_id.Text = tabla.Rows(0)("codNad")
                Me._txt_precio.Text = tabla.Rows(0)("precio")
            Else
                MsgBox("No existe ese código de articulos", MsgBoxStyle.Critical, "Importante")
            End If








            'ElseIf cmb_especialidad.Text <> "" Then
            '    Dim consulta As String = ""
            '    Dim dt As New Data.DataTable
            '    consulta = "SELECT Torneos.descripcion AS Torneo, Competencias.año AS Año, Especialidades.descripcion AS Especialidad, Competencias.fecha AS Fecha"
            '    consulta &= " FROM Competencias INNER JOIN Especialidades ON Competencias.codEspe = Especialidades.codEspe INNER JOIN"
            '    consulta &= " TorneosXAño ON Competencias.codTorneo = TorneosXAño.codTorneo INNER JOIN Torneos ON TorneosXAño.codTorneo = Torneos.codTorneo"
            '    consulta &= " WHERE Especialidades.descripcion = '" & Me.cmb_especialidad.Text & "'"
            '    dt = acceso.ejecutar(consulta)
            '    grid_competencias.DataSource = dt
        End If

    End Sub








    Private Sub _cmd_buscar_articulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cmd_buscar_articulo.Click


        If Me._txt_id_articulo.Text = "" Then
            MsgBox("El Código del articulo esta vacio", MsgBoxStyle.Critical, "Importante")
            Exit Sub
        End If

        Dim tabla As New Data.DataTable
        Me._acceso._tabla = "t_articulos"
        tabla = Me._acceso.leo_tabla("id_articulo = " & Me._txt_id_articulo.Text.Trim())

        If tabla.Rows.Count > 0 Then
            Me._txt_articulo.Text = tabla.Rows(0)("n_articulo")
            Me._txt_precio.Text = tabla.Rows(0)("precio")
        Else
            MsgBox("No existe ese código de articulos", MsgBoxStyle.Critical, "Importante")
        End If

    End Sub











    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub cmb_torneo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_torneo.SelectedValueChanged
        Dim tabla As New DataTable
        Dim consulta As String = ""
        consulta = "SELECT * FROM TorneosXAño INNER JOIN Torneos ON TorneosXAño.codTorneo = Torneos.codTorneo WHERE Torneos.descripcion = '" & Me.cmb_torneo.Text & "'"
        tabla = acceso.ejecutar(consulta)
        cargar_combo(cmb_año, tabla, "año", "año")
    End Sub


    Private Sub cmb_año_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_año.SelectionChangeCommitted
        'Dim año = cmb_año.Text.Cast(Of Int32)()
        'cmb_año.Text.Cast(Of Int32
        'año = cmb_año.Text
        'año.Cast(Of Int32)()
        'If (cmb_año.Text <> "") Then
        dtp_fecha.MaxDate = "31/12/3000"
        dtp_fecha.MinDate = "1/1/1754"
        Dim fechaMin As Date = "01/01/" & cmb_año.Text
        Dim fechaMax As Date = "31/12/" & cmb_año.Text
        dtp_fecha.MinDate = fechaMin
        dtp_fecha.MaxDate = fechaMax

        ' Else : dtp_fecha.MaxDate = ""
        '    dtp_fecha.MinDate = ""
        ' End If

    End Sub


End Class