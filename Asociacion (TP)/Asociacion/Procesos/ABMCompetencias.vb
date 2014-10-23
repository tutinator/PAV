Public Class ABMCompetencias
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


    Private Sub ABMcompetencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.inicio()
    End Sub

    'Subrutinas

    Private Sub inicio()
        cargar_grilla()
        Me.cargar_combos()
        cambiarEntradas(False)
        cambiarBotones(False)
        Me.cmd_nuevo.Enabled = True
        Me.cmd_buscar.Enabled = True
        Me.cmd_salir.Enabled = True
        Me.cmd_cancelar.Enabled = True
        Me.cmb_torneo.Enabled = True
        Me.cmb_año.Enabled = True
        Me.cmb_especialidad.Enabled = True
        'Me.txt_fecha.Enabled = True
        Me.cmb_torneo.Focus()
        'Me.dtp_fecha.Value = Date.Today
    End Sub

    Private Sub limpiarCampos()
        Me.cmb_año.Text = ""
        Me.cmb_torneo.Text = ""
        Me.cmb_especialidad.Text = ""
        ' Me.txt_fecha.Text = ""
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
            cmb_especialidad.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
        Me.cmb_año.Enabled = x
        Me.cmb_torneo.Enabled = x
        Me.cmb_especialidad.Enabled = x
        'Me.txt_fecha.Enabled = x
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
        consulta = "SELECT Torneos.descripcion AS Torneo, Competencias.año AS Año, Especialidades.descripcion AS Especialidad, Competencias.fecha AS Fecha"
        consulta &= " FROM Competencias INNER JOIN Especialidades ON Competencias.codEspe = Especialidades.codEspe INNER JOIN"
        consulta &= " TorneosXAño ON Competencias.codTorneo = TorneosXAño.codTorneo AND Competencias.año = TorneosXAño.año INNER JOIN Torneos ON Competencias.codTorneo = Torneos.codTorneo"
        grid_competencias.DataSource = acceso.ejecutar(consulta)

    End Sub

    Private Sub cargar_combo(ByRef combo As ComboBox, ByVal nombre_tabla As DataTable, ByVal pk As String, ByVal descrip As String)

        combo.DataSource = nombre_tabla
        combo.ValueMember = pk
        combo.DisplayMember = descrip
        combo.SelectedIndex = -1

    End Sub

    Private Sub cargar_combos()
        cargar_combo(cmb_especialidad, leo_tabla("Especialidades"), "codEspe", "descripcion")
        Dim tabla As Data.DataTable
        Dim consulta As String = ""
        consulta = "SELECT DISTINCT TorneosXAño.codTorneo, Torneos.descripcion FROM TorneosXAño INNER JOIN Torneos ON TorneosXAño.codTorneo = Torneos.codTorneo"
        tabla = acceso.ejecutar(consulta)
        cargar_combo(cmb_torneo, tabla, "codTorneo", "descripcion")

    End Sub

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
        'Dim consulta As String = "DELETE FROM Competencias WHERE codTorneo = " & Me.cmb_torneo.SelectedValue
        'consulta &= " AND año = " & Me.cmb_año.SelectedValue & " AND codEspe = " & Me.cmb_especialidad.SelectedValue
        'acceso.ejecutarNonConsulta(consulta)
        'Return termino.aprobado


        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim consulta As String = ""

        conexion.ConnectionString = Me.acceso._StringConexion
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        conexion.Open()

        consulta = "DELETE FROM Competencias WHERE codTorneo = " & Me.cmb_torneo.SelectedValue
        consulta &= " AND año = " & Me.cmb_año.SelectedValue & " AND codEspe = " & Me.cmb_especialidad.SelectedValue
        cmd.CommandText = consulta

        Try
            cmd.ExecuteNonQuery()
            Return termino.aprobado
        Catch ex As Exception
            MessageBox.Show("No se puede eliminar esta Competencia ya que está siendo referenciada en otra tabla.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return termino.rechazado
        End Try
    End Function

    '----FIN BD


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

        cambiarEntradas(True)
        tabla = acceso.ejecutar(consulta)

        Me.cmb_torneo.SelectedValue = tabla.Rows(0)("codTorneo")
        Me.cmb_año.SelectedValue = tabla.Rows(0)("año")
        Me.cmb_especialidad.SelectedValue = tabla.Rows(0)("codEspe")
        Me.dtp_fecha.Value = tabla.Rows(0)("fecha")

        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_eliminar.Enabled = True
        Me.cmd_guardar.Enabled = True


        cmb_torneo.Focus()

        Me.accion = estado.modificar
    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        cambiarBotones(False)
        cambiarEntradas(True)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        cmb_torneo.Focus()
        Me.accion = estado.insertar
    End Sub


    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If validarCampos() = True Then
            If Me.accion = estado.insertar Then
                If validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("Nueva competencia cargada con éxito", "Operación completa")

                Else : MessageBox.Show("La competencia que intenta guardar ya está registrada", "Error")



                End If
            Else
                Me.modificar()
                MessageBox.Show("Competencia modificada con éxito", "Operación completa")
            End If

            Me.inicio()
        End If
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If cmb_torneo.Text = "" Or cmb_especialidad.Text = "" Or cmb_año.Text = "" Then
            MsgBox("No se ha seleccionado una competencia válida", MsgBoxStyle.Critical, "Error")
        Else
            If MessageBox.Show("¿Está seguro que desea eliminar la competencia seleccionada?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                If Me.delete() = termino.aprobado Then
                    MessageBox.Show("Compentencia eliminada", "Operación completada")
                    Me.inicio()
                End If
            End If
        End If
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_buscar.Enabled = True

        Dim cont As Integer = 0
        If cmb_año.Text <> "" Then cont = cont + 1
        If cmb_torneo.Text <> "" Then cont = cont + 1
        If cmb_especialidad.Text <> "" Then cont = cont + 1

        If cont = 0 Then
            MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
            cmb_torneo.Focus()
            Exit Sub
        End If

        'If cont > 1 Then
        'MsgBox("Ingrese sólo un criterio de búsqueda", MsgBoxStyle.Critical, "Importante")
        'cmb_torneo.Focus()
        'Exit Sub
        'End If
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

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        Me.inicio()
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