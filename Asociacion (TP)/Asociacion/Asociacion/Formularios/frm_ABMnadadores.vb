Public Class frm_ABMnadadores
    Dim string_conexion As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\Users\Franco\Documents\FACU\2014\Economia\PAV\PAV\Asociacion (TP)\Asociacion\Asociacion\Otros\BD\natacion.mdf"";Integrated Security=True;Connect Timeout=30;User Instance=True"
    Private Sub frm_AMBnadadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicio()
    End Sub

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
    End Sub

    Private Sub limpiarCampos()
        txt_apellido.Text = ""
        txt_nombre.Text = ""
        msk_fechaNacimiento.Clear()
        cmb_tipoDoc.Text = ""
        txt_nroDoc.Text = ""
        txt_email.Text = ""
        txt_calle.Text = ""
        txt_nroCalle.Text = ""
        cmb_codPos.Text = ""
        cmb_profesor.Text = ""
    End Sub

    Private Function validarCampos()
        'FALTA VALIDAR FECHA!!! - que no sea despues del día de hoy, ni taan vieja
        If txt_apellido.Text = "" Then
            MsgBox("Apellido no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_apellido.Focus()
            Return False
        End If

        If txt_nombre.Text = "" Then
            MsgBox("Nombre del nadador no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_nombre.Focus()
            Return False
        End If

        If cmb_tipoDoc.Text = "" Then
            MsgBox("Tipo de documento del nadador no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            cmb_tipoDoc.Focus()
            Return False
        End If

        If txt_nroDoc.Text = "" Then
            MsgBox("Número de documento del nadador no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_nroDoc.Focus()
            Return False
        End If

        If Not opt_femenino.Checked And Not opt_masculino.Checked Then
            MsgBox("El sexo del nadador debe ser seleccionado", MsgBoxStyle.Critical, "Importante")
        End If

        Return True
    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
        txt_calle.Enabled = x
        msk_fechaNacimiento.Enabled = x
        txt_email.Enabled = x
        txt_calle.Enabled = x
        txt_nroCalle.Enabled = x
        cmb_codPos.Enabled = x
        cmb_profesor.Enabled = x
        opt_femenino.Enabled = x
        opt_masculino.Enabled = x
    End Sub

    Private Sub cambiarBotones(ByVal x As Boolean)
        cmd_guardar.Enabled = x
        cmd_buscar.Enabled = x
        cmd_eliminar.Enabled = x
        cmd_nuevo.Enabled = x
        cmd_salir.Enabled = x
        cmd_cancelar.Enabled = x
        cmd_nuevoCP.Enabled = x
        cmd_nuevoProfe.Enabled = x
    End Sub

    'Valida que solo ingresen letras
    Function validarSoloLetras(ByVal KeyAscii As Integer) As Integer
        KeyAscii = Asc(UCase(Chr(KeyAscii))) 'Transformar letras minusculas a Mayúsculas
        If InStr("ABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚÂÊÎÔÛÜ", Chr(KeyAscii)) = 0 Then
            validarSoloLetras = 0
        Else
            validarSoloLetras = KeyAscii
        End If
        ' teclas adicionales permitidas
        If KeyAscii = 8 Then validarSoloLetras = KeyAscii ' Backspace
        If KeyAscii = 13 Then validarSoloLetras = KeyAscii ' Enter
        If KeyAscii = 32 Then validarSoloLetras = KeyAscii ' Espacio
    End Function

    Private Sub txt_apellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_apellido.KeyPress, txt_nombre.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(validarSoloLetras(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'CODIGO ACCESO A BD
    Private Function ejecuto_sql(ByVal consulta_sql As String) As Data.DataTable
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable

        conexion.ConnectionString = Me.string_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta_sql

        tabla.Load(cmd.ExecuteReader())

        conexion.Close()

        Return tabla

    End Function

    Private Sub cargar_grilla()

        Dim conexion As New Data.SqlClient.SqlConnection
        conexion.ConnectionString = string_conexion
        conexion.Open()
        Dim tabla As New Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = conexion
        Dim consulta As String = ""
        consulta = "SELECT codNad AS Codigo, apellido AS Apellido, nombre AS Nombre, numero AS Documento FROM Nadadores"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())

        grid_nadadores.DataSource = tabla
        conexion.Close()
    End Sub

    Private Function modificar() As termino

        Dim consulta As String = ""
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim conexion As New Data.SqlClient.SqlConnection

        conexion.ConnectionString = string_conexion
        conexion.Open()
        cmd.Connection = conexion

        'consulta = "UPDATE Nadadores SET nombre = '" & Me.txt_nombre.Text & "' WHERE codPos = " & txt_codPos.Text
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.ExecuteNonQuery()
        conexion.Close()

        Return termino.aprobado

    End Function

    Private Function insertar() As termino
        'GENERAR UN CODIGO PARA EL NADADOR
        Dim conexion As New Data.SqlClient.SqlConnection
        conexion.ConnectionString = string_conexion
        conexion.Open()

        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = conexion
        Dim consulta As String = ""

        'HAY QUE ARREGLAR LA BASE DE DATOS
        'consulta = "INSERT into Nadadores (codNad,apellido,nombre,fechaNacimiento,) values ('" & Me.txt_codNadador.Text & "'"
        'consulta &= ",'" & Me.txt_nombre.Text & "')"

        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.ExecuteNonQuery()
        conexion.Close()

        Return termino.aprobado
    End Function

    Private Function validar_existencia() As termino
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim consulta As String = ""
        Dim dt As New Data.DataTable
        conexion.ConnectionString = Me.string_conexion
        conexion.Open()
        consulta = "SELECT * FROM Nadadores where codNad = " & Me.txt_codNadador.Text
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion
        cmd.ExecuteReader()
        dt.Load(cmd.ExecuteReader())
        conexion.Close()
        If dt.Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Function delete() As termino

        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        'Dim Variable As Integer = grid_cod_post.Item(0, grid_cod_post.CurrentRow.Index).Value
        conexion.ConnectionString = Me.string_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "DELETE FROM Nadadores WHERE codNad = " & Me.txt_codNadador.Text
        cmd.ExecuteNonQuery()
        conexion.Close()

        Return termino.aprobado
    End Function

    'Comandos
    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub


    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click

        If validarCampos() = True Then
            If Me.accion = estado.insertar Then
                If validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("Nadador cargado con éxito", "Operación completa")

                Else : MessageBox.Show("El Nadador que intenta guardar ya está registrado", "Error")



                End If
            Else : Me.modificar()
                MessageBox.Show("Nadador modificado con éxito", "Operación completa")
            End If

            Me.inicio()
        End If

    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        Me.inicio()
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If txt_codNadador.Text = "" Then
            MsgBox("No se ha seleccionado ningún nadador", MsgBoxStyle.Critical, "Error")
        Else
            If MessageBox.Show("¿Está seguro que desea eliminar el nadador " & txt_apellido.Text & ", " & _
                               txt_nombre.Text & "?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                Me.delete()
                MessageBox.Show("Nadador eliminado", "Operación completada")
                Me.inicio()
            End If
        End If
    End Sub


    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        cambiarBotones(False)
        cambiarEntradas(True)
        txt_codNadador.Enabled = False
        cmd_nuevoCP.Enabled = True
        cmd_nuevoProfe.Enabled = True
        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        txt_apellido.Focus()
        Me.accion = estado.insertar
    End Sub


    'FALTA ARREGLAR ESTE BOTON
    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_buscar.Enabled = True


        'Hay que agregar el codNadador como criterio!!
        If txt_apellido.Text <> "" And txt_nroDoc.Text <> "" Or txt_nombre.Text <> "" Then
            MsgBox("Ingrese sólo un criterio de búsqueda", MsgBoxStyle.Critical, "Importante")
            txt_apellido.Focus()
            cmd_buscar.Enabled = True
        End If

        If txt_apellido.Text = "" And txt_nombre.Text = "" And txt_nroDoc.Text = "" Then
            MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
            txt_apellido.Focus()
        End If

        'If txt_codClub.Text = "" Then
        '    If txt_nombre.Text = "" Then
        '        MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
        '        txt_codClub.Focus()
        '        cmd_buscar.Enabled = True
        '    Else
        '        'busqueda por nombre

        '        cmd_buscar.Enabled = True

        '    End If
        'Else
        '    'busqueda por codigo
        '    cmd_buscar.Enabled = True

        'End If
    End Sub

    Private Sub cmd_nuevoCP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevoCP.Click
        frm_ABMCodPos.ShowDialog()

        'Agregar funcionalidad para que al crearse el cp nuevo, se muestre en el cbo de cp
    End Sub
    Private Sub cmd_nuevoProfe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevoProfe.Click
        'frm_ABMprofesores.ShowDialog()
        'Agregar funcionalidad para que al crearse el profe nuevo, se muestre en el cbo profesor
    End Sub

    Private Sub frm_ABMnadadores_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            e.Cancel() = True
        End If
    End Sub

    

    Private Sub grid_nadadores_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grid_nadadores.CellMouseDoubleClick
        'Dim codigoSeleccionado As String = grid_codPos.SelectedRows.Item(0).ToString()
        Dim codigoSeleccionado As String = Me.grid_nadadores.CurrentRow.Cells(0).Value
        Dim conexion As New Data.SqlClient.SqlConnection
        conexion.ConnectionString = string_conexion
        conexion.Open()
        Dim tabla As New Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = conexion
        Dim consulta As String = ""
        consulta = "SELECT * FROM Nadadores WHERE codPos = " & codigoSeleccionado
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        tabla.Load(cmd.ExecuteReader())

        Me.txt_codNadador.Text = tabla.Rows(0)("codNad")
        Me.txt_apellido.Text = tabla.Rows(0)("apellido")
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")

        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_eliminar.Enabled = True
        Me.cmd_guardar.Enabled = True
        Me.txt_codNadador.Enabled = False
        txt_nombre.Focus()

        Me.accion = estado.modificar
        conexion.Close()
    End Sub
End Class
