Public Class proc_realizacionTorneo

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
        Me.cargar_combos()
        cambiarEntradas(False)
        cambiarBotones(False)
        Me.cmd_nuevo.Enabled = True
        Me.cmd_buscar.Enabled = True
        Me.cmd_salir.Enabled = True
        Me.cmd_nuevoTorneo.Enabled = True
        Me.cmd_nuevoClub.Enabled = True
        Me.cmb_torneo.Enabled = True
        Me.txt_año.Enabled = True
        Me.cmb_clubSede.Enabled = True
        Me.cmb_torneo.Focus()

    End Sub

    Private Sub limpiarCampos()
        Me.txt_año.Text = ""
        Me.cmb_torneo.Text = ""
        Me.cmb_clubSede.Text = ""
    End Sub

    Private Function validarCampos()

        If cmb_torneo.Text = "" Then
            MsgBox("Torneo no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            cmb_torneo.Focus()
            Return False
        End If

        If txt_año.Text = "" Then
            MsgBox("Año de torneo no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_año.Focus()
            Return False
        End If

        Return True
    End Function

    Function validarSoloNumeros(ByVal KeyAscii As Integer) As Integer
        KeyAscii = Asc(UCase(Chr(KeyAscii))) 'Transformar letras minusculas a Mayúsculas
        If InStr("1234567890", Chr(KeyAscii)) = 0 Then
            validarSoloNumeros = 0
        Else
            validarSoloNumeros = KeyAscii
        End If
    End Function

    Private Sub txt_año_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_año.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(validarSoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
        Me.txt_año.Enabled = x
        Me.cmb_torneo.Enabled = x
        Me.cmb_clubSede.Enabled = x
    End Sub

    Private Sub cambiarBotones(ByVal x As Boolean)
        Me.cmd_guardar.Enabled = x
        Me.cmd_buscar.Enabled = x
        Me.cmd_eliminar.Enabled = x
        Me.cmd_nuevo.Enabled = x
        Me.cmd_salir.Enabled = x
        Me.cmd_cancelar.Enabled = x
        Me.cmd_nuevoClub.Enabled = x
        Me.cmd_nuevoTorneo.Enabled = x
    End Sub

    'BASE DE DATOS
    Private Function leo_tabla(ByRef _tabla) As DataTable
        Dim consulta As String = ""
        consulta = "SELECT * FROM " & _tabla
        Return acceso.ejecutar(consulta)
    End Function

    Private Sub cargar_grilla()

        Dim consulta As String = ""
        consulta = "SELECT Torneos.descripcion AS Torneo, TorneosXAño.año AS Año, Clubes.nombre AS Sede"
        consulta &= " FROM TorneosXAño INNER JOIN Torneos ON TorneosXAño.codTorneo = Torneos.codTorneo INNER JOIN"
        consulta &= " Clubes ON TorneosXAño.codClub = Clubes.codClub"

        grid_realizaciones.DataSource = acceso.ejecutar(consulta)

    End Sub

    Private Sub cargar_combo(ByRef combo As ComboBox, ByVal nombre_tabla As DataTable, ByVal pk As String, ByVal descrip As String)

        combo.DataSource = nombre_tabla
        combo.ValueMember = pk
        combo.DisplayMember = descrip
        combo.SelectedIndex = -1

    End Sub

    Private Sub cargar_combos()
        cargar_combo(cmb_torneo, leo_tabla("Torneos"), "codTorneo", "descripcion")
        cargar_combo(cmb_clubSede, leo_tabla("Clubes"), "codClub", "nombre")
    End Sub

    Private Function modificar() As termino

        Dim consulta As String = ""
        consulta = "UPDATE TorneosXAño SET codClub = " & Me.cmb_clubSede.SelectedValue
        consulta &= " WHERE codTorneo = " & Me.cmb_torneo.SelectedValue & " AND año = " & Me.txt_año.Text
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado

    End Function

    Private Function insertar() As termino

        Dim consulta As String = ""
        consulta = "INSERT INTO TorneosXAño (codTorneo, año, codClub)"
        consulta &= "VALUES (" & Me.cmb_torneo.SelectedValue & ", " & Me.txt_año.Text & ", " & Me.cmb_clubSede.SelectedValue & ")"
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado

    End Function

    Private Function validar_existencia() As termino

        Dim consulta As String = ""
        Dim tabla As Data.DataTable
        consulta = "SELECT * FROM TorneosXAño WHERE codTorneo = " & Me.cmb_torneo.SelectedValue & " AND año = " & Me.txt_año.Text
        tabla = acceso.ejecutar(consulta)
        If tabla.Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Function delete() As termino
        'Dim consulta As String = "DELETE FROM TorneosXAño WHERE codTorneo = " & Me.cmb_torneo.SelectedValue
        'consulta &= " AND año = " & Me.txt_año.Text
        'acceso.ejecutarNonConsulta(consulta)
        'Return termino.aprobado


        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand


        conexion.ConnectionString = Me.acceso._StringConexion
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        conexion.Open()

        Dim consulta As String = "DELETE FROM TorneosXAño WHERE codTorneo = " & Me.cmb_torneo.SelectedValue
        consulta &= " AND año = " & Me.txt_año.Text

        cmd.CommandText = consulta

        Try
            cmd.ExecuteNonQuery()
            Return termino.aprobado
        Catch ex As Exception
            MessageBox.Show("No se puede eliminar este Torneo ya que está siendo referenciado en otra tabla.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return termino.rechazado
        End Try
    End Function

    '----FIN BD

    Private Sub grid_realizaciones_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grid_realizaciones.CellMouseDoubleClick
        ' ME DEVUELVE EL NOMBRE DEL TORNEO
        Dim torneoSeleccionado As String = Me.grid_realizaciones.CurrentRow.Cells(0).Value
        Dim añoSeleccionado As Integer = Me.grid_realizaciones.CurrentRow.Cells(1).Value

        Dim tabla As New Data.DataTable

        Dim consulta As String = ""
        'TENGO QUE SACAR LA TABLA CON LOS NOMBRES DE TORNEO PARA BUSCAR EL "torneoSeleccionado"
        consulta = "SELECT * FROM TorneosXAño INNER JOIN Torneos ON TorneosXAño.codTorneo = Torneos.codTorneo"
        consulta &= " WHERE descripcion = '" & torneoSeleccionado & "' AND año = " & añoSeleccionado

        cambiarEntradas(True)
        tabla = acceso.ejecutar(consulta)

        Me.cmb_torneo.SelectedValue = tabla.Rows(0)("codTorneo")
        Me.txt_año.Text = tabla.Rows(0)("año")
        Me.cmb_clubSede.SelectedValue = tabla.Rows(0)("codClub")

        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_eliminar.Enabled = True
        Me.cmd_guardar.Enabled = True


        cmb_torneo.Focus()

        Me.accion = estado.modificar
    End Sub

    Private Sub proc_realizacionTorneo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.inicio()
    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        cambiarBotones(False)
        cambiarEntradas(True)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.cmd_nuevoClub.Enabled = True
        Me.cmd_nuevoTorneo.Enabled = True
        cmb_torneo.Focus()
        Me.accion = estado.insertar
    End Sub

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub


    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_buscar.Enabled = True

        Dim cont As Integer = 0
        If cmb_clubSede.Text <> "" Then cont = cont + 1
        If cmb_torneo.Text <> "" Then cont = cont + 1
        If txt_año.Text <> "" Then cont = cont + 1

        If cont = 0 Then
            MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
            cmb_torneo.Focus()
            Exit Sub
        End If

        If cont > 1 Then
            MsgBox("Ingrese sólo un criterio de búsqueda", MsgBoxStyle.Critical, "Importante")
            cmb_torneo.Focus()
            Exit Sub
        End If

        If cmb_clubSede.Text = "" Then
            If txt_año.Text = "" Then
                If cmb_torneo.Text = "" Then
                    MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
                    cmb_torneo.Focus()
                Else
                    Dim consulta As String = ""
                    Dim dt As New Data.DataTable
                    consulta = "SELECT Torneos.descripcion AS Torneo, TorneosXAño.año AS Año, Clubes.nombre AS Sede"
                    consulta &= " FROM TorneosXAño INNER JOIN Torneos ON TorneosXAño.codTorneo = Torneos.codTorneo INNER JOIN"
                    consulta &= " Clubes ON TorneosXAño.codClub = Clubes.codClub WHERE Torneos.descripcion = '" & Me.cmb_torneo.Text & "'"
                    dt = acceso.ejecutar(consulta)
                    grid_realizaciones.DataSource = dt
                End If
            Else
                Dim consulta As String = ""
                Dim dt As New Data.DataTable
                consulta = "SELECT Torneos.descripcion AS Torneo, TorneosXAño.año AS Año, Clubes.nombre AS Sede"
                consulta &= " FROM TorneosXAño INNER JOIN Torneos ON TorneosXAño.codTorneo = Torneos.codTorneo INNER JOIN"
                consulta &= " Clubes ON TorneosXAño.codClub = Clubes.codClub WHERE año = " & Me.txt_año.Text
                dt = acceso.ejecutar(consulta)
                grid_realizaciones.DataSource = dt
            End If
        Else
            Dim consulta As String = ""
            Dim dt As New Data.DataTable
            consulta = "SELECT Torneos.descripcion AS Torneo, TorneosXAño.año AS Año, Clubes.nombre AS Sede"
            consulta &= " FROM TorneosXAño INNER JOIN Torneos ON TorneosXAño.codTorneo = Torneos.codTorneo INNER JOIN"
            consulta &= " Clubes ON TorneosXAño.codClub = Clubes.codClub WHERE Clubes.nombre = '" & Me.cmb_clubSede.Text & "'"

            dt = acceso.ejecutar(consulta)
            grid_realizaciones.DataSource = dt

        End If

    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        Me.inicio()
    End Sub

 
    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If cmb_torneo.Text = "" Then
            MsgBox("No se ha seleccionado ningún torneo", MsgBoxStyle.Critical, "Error")
        Else
            If MessageBox.Show("¿Está seguro que desea eliminar la realización del torneo " & cmb_torneo.Text & " del año " & txt_año.Text & "?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                If Me.delete() = termino.aprobado Then
                    MessageBox.Show("Realización del torneo eliminada", "Operación completada")
                    Me.inicio()
                End If
            End If
        End If
    End Sub

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If validarCampos() = True Then
            If Me.accion = estado.insertar Then
                If validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("Nueva realización de torneo cargada con éxito", "Operación completa")

                Else : MessageBox.Show("La realización de torneo que intenta guardar ya está registrada", "Error")



                End If
            Else
                Me.modificar()
                MessageBox.Show("Realización de torneo modificada con éxito", "Operación completa")
            End If

            Me.inicio()
        End If
    End Sub


    Private Sub cmd_nuevoTorneo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevoTorneo.Click
        frm_ABMTorneo.Show()
    End Sub

    Private Sub cmd_nuevoClub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevoClub.Click
        frm_ABMTorneo.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class