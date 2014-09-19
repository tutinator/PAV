Public Class frm_ABMTorneo

    Private Sub frm_ABMTorneo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.inicio()
    End Sub

    Dim string_conexion As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\Agus\GitHub\PAV\Asociacion (TP)\Asociacion\Asociacion\Otros\BD\natacion.mdf"";Integrated Security=True;Connect Timeout=30;User Instance=True"
    Dim acceso As New accesoBD
    '"Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\Users\Franco\Documents\FACU\2014\Economia\PAV\PAV\Asociacion (TP)\Asociacion\Asociacion\Otros\BD\natacion.mdf"";Integrated Security=True;Connect Timeout=30;User Instance=True"
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
        cambiarBotones(False)
        cambiarEntradas(False)
        Me.cmd_nuevo.Enabled = True
        Me.cmd_buscar.Enabled = True
        Me.cmd_salir.Enabled = True
        txt_codTorneo.Focus()
    End Sub

    Private Sub limpiarCampos()
        txt_codTorneo.Text = ""
        txt_nombre.Text = ""
    End Sub

    Private Function validarCampos()

        If txt_codTorneo.Text = "" Then
            MsgBox("Código de Torneo no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_codTorneo.Focus()
            Return False
        End If

        If txt_nombre.Text = "" Then
            MsgBox("Nombre del Torneo no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_nombre.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
        Me.txt_codTorneo.Enabled = True

    End Sub

    Private Sub cambiarBotones(ByVal x As Boolean)
        cmd_guardar.Enabled = x
        cmd_buscar.Enabled = x
        cmd_eliminar.Enabled = x
        cmd_nuevo.Enabled = x
        cmd_salir.Enabled = x
        cmd_cancelar.Enabled = x
    End Sub


    Private Sub cargar_grilla()
        Dim consulta As String = ""
        consulta = "SELECT codTorneo AS Codigo, descripcion AS Nombre "
        consulta &= "FROM Torneos"

        grid_codTorneo.DataSource = acceso.ejecutar(consulta)
    End Sub

    Private Function modificar() As termino

       Dim consulta As String = ""
        consulta = "UPDATE Torneos SET descripcion = '" & Me.txt_nombre.Text & "' WHERE codTorneo = " & txt_codTorneo.Text
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado

    End Function

    Private Function insertar() As termino
        ' Dim conexion As New Data.SqlClient.SqlConnection
        'conexion.ConnectionString = string_conexion
        ' conexion.Open()
        ' Dim cmd As New Data.SqlClient.SqlCommand
        ' cmd.Connection = conexion
        'cmd.CommandType = CommandType.Text
        'cmd.CommandText = consulta
        ' cmd.ExecuteNonQuery()
        'conexion.Close()





        'CAMBIAR ESTA CONSULTAR POR LA QUE CORRESPONDE A TORNEO (NO ME FUNCA LA BD A MI)

        Dim consulta As String = ""
        consulta = "INSERT into Torneos (codTorneo, descripcion) values ('" & Me.txt_codTorneo.Text & "'"
        consulta &= ",'" & Me.txt_nombre.Text & "')"
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado

    End Function

    Private Function validar_existencia() As termino
        Dim consulta As String = ""
        Dim tabla As Data.DataTable
        consulta = "select * from Torneos where codTorneo = " & Me.txt_codTorneo.Text
        tabla = acceso.ejecutar(consulta)
        If tabla.Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Function delete() As termino
        Dim consulta As String = "DELETE FROM Torneos WHERE codTorneo = " & Me.txt_codTorneo.Text
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado
    End Function

    'Comandos

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        If validarCampos() = True Then
            If Me.accion = estado.insertar Then
                If validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("Torneo cargado con éxito", "Operación completa")

                Else : MessageBox.Show("El Torneo que intenta guardar ya está registrado", "Error")



                End If
            Else : Me.modificar()
                MessageBox.Show("Torneo modificado con éxito", "Operación completa")
            End If

            Me.inicio()
        End If


    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If txt_codTorneo.Text = "" Then
            MsgBox("No se ha seleccionado ningún Torneo", MsgBoxStyle.Critical, "Error")
        Else
            If MessageBox.Show("¿Está seguro que desea eliminar el Torneo " & txt_codTorneo.Text & " llamado " & txt_nombre.Text & "?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                Me.delete()
                MessageBox.Show("Torneo eliminado", "Operación completada")
                Me.inicio()
            End If
        End If
    End Sub

    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        cambiarBotones(False)
        cambiarEntradas(True)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        txt_codTorneo.Focus()
        Me.accion = estado.insertar
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click

        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        cmd_buscar.Enabled = True


        If txt_nombre.Text <> "" And txt_codTorneo.Text <> "" Then
            MsgBox("Ingrese sólo un criterio de búsqueda", MsgBoxStyle.Critical, "Importante")
            txt_codTorneo.Focus()
        Else

            If txt_codTorneo.Text = "" Then
                If txt_nombre.Text = "" Then
                    MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
                    txt_codTorneo.Focus()
                Else
                    Dim consulta As String = ""
                    Dim dt As New Data.DataTable
                    consulta = "SELECT * FROM Torneos WHERE descripcion LIKE '%" & Me.txt_nombre.Text & "%'"
                    dt = acceso.ejecutar(consulta)
                    grid_codTorneo.DataSource = dt

                End If
            Else
                Dim consulta As String = ""
                Dim dt As New Data.DataTable
                consulta = "SELECT * FROM Torneos WHERE codTorneo = '" & Me.txt_codTorneo.Text & "'"
                dt = acceso.ejecutar(consulta)
                grid_codTorneo.DataSource = dt


            End If

        End If

    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_cancelar.Click
        Me.inicio()
    End Sub

    Private Sub grid_codTorneo_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grid_codTorneo.CellMouseDoubleClick


        Dim codigoSeleccionado As String = Me.grid_codTorneo.CurrentRow.Cells(0).Value

        Dim tabla As New Data.DataTable

        Dim consulta As String = ""
        consulta = "SELECT * FROM Torneos WHERE codTorneo = " & codigoSeleccionado


        tabla = acceso.ejecutar(consulta)

        Me.txt_codTorneo.Text = tabla.Rows(0)("codTorneo")
        Me.txt_nombre.Text = tabla.Rows(0)("descripcion")

        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_eliminar.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.txt_codTorneo.Enabled = False
        txt_nombre.Focus()

        Me.accion = estado.modificar
    End Sub


End Class