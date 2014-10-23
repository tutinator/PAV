Imports System.Windows.Forms

Public Class frm_ABMclubes

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

    Private Sub frm_ABMClubes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.inicio()
    End Sub

    'Subrutinas

    Private Sub inicio()
        cargar_grilla()
        cambiarEntradas(False)
        cambiarBotones(False)
        cargar_combos()
        Me.cmd_nuevo.Enabled = True
        Me.cmd_buscar.Enabled = True
        Me.cmd_salir.Enabled = True
        Me.txt_codClub.Enabled = True
        Me.txt_nombre.Enabled = True
        Me.txt_codClub.Focus()

    End Sub

    Private Sub limpiarCampos()
        txt_codClub.Text = ""
        txt_calle.Text = ""
        txt_nombre.Text = ""
        txt_nroCalle.Text = ""
        cmb_codPos.Text = ""
        txt_telefono.Text = ""
    End Sub

    Private Function validarCampos()

        If txt_codClub.Text = "" Then
            MsgBox("Código de Club no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_codClub.Focus()
            Return False
        End If

        If txt_nombre.Text = "" Then
            MsgBox("Nombre de Club no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_nombre.Focus()
            Return False
        End If

        If txt_calle.Text = "" Then
            MsgBox("Calle del Club no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            txt_calle.Focus()
            Return False
        End If

        'If cmb_codPos.Text = "" Then
        'MsgBox("Calle del Club no puede estar vacío", MsgBoxStyle.Critical, "Importante")
        'txt_calle.Focus()
        'Return False
        'End If

        Return True
    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
        txt_codClub.Enabled = x
        txt_calle.Enabled = x
        txt_nombre.Enabled = x
        txt_nroCalle.Enabled = x
        cmb_codPos.Enabled = x
        txt_telefono.Enabled = x
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

    Private Function leo_tabla(ByRef _tabla) As DataTable
        Dim consulta As String = ""
        consulta = "SELECT * FROM " & _tabla
        Return acceso.ejecutar(consulta)
    End Function

    Private Sub cargar_grilla()

        Dim consulta As String = ""
        consulta = "SELECT Clubes.codClub AS Codigo, Clubes.nombre AS Nombre, Clubes.calle AS Calle, Clubes.numero AS Numero, Clubes.telefono AS Telefono, "
        consulta &= "CodPostales.codPos AS [Codigo Postal], CodPostales.nombre AS [Area] "
        consulta &= "FROM Clubes INNER JOIN CodPostales ON Clubes.codPos = CodPostales.codPos"

        grid_clubes.DataSource = acceso.ejecutar(consulta)

    End Sub

    Private Sub cargar_combo(ByRef combo As ComboBox, ByVal nombre_tabla As DataTable, ByVal pk As String, ByVal descrip As String)

        combo.DataSource = nombre_tabla
        combo.ValueMember = pk
        combo.DisplayMember = descrip
        combo.SelectedIndex = -1

    End Sub

    Private Sub cargar_combos()
        cargar_combo(cmb_codPos, leo_tabla("CodPostales"), "codPos", "codPos")
    End Sub

    Private Function modificar() As termino

        Dim consulta As String = ""
        consulta = "UPDATE Clubes SET nombre = '" & Me.txt_nombre.Text & "', "
        consulta &= "calle = '" & Me.txt_calle.Text & "', "
        consulta &= "numero = " & Me.txt_nroCalle.Text & ", "
        consulta &= "telefono = " & Me.txt_telefono.Text & ", "
        consulta &= "codPos = " & Me.cmb_codPos.SelectedValue.ToString & " "
        consulta &= "WHERE codClub = " & Me.txt_codClub.Text

        acceso.ejecutarNonConsulta(consulta)

        Return termino.aprobado

    End Function

    Private Function insertar() As termino

        Dim consulta As String = ""
        consulta = "INSERT into Clubes "
        consulta &= "values ('" & Me.txt_codClub.Text & "', '" & Me.txt_nombre.Text & "', "
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
        'Dim consulta As String = "DELETE FROM Clubes WHERE codClub = " & Me.txt_codClub.Text
        'acceso.ejecutarNonConsulta(consulta)
        'Return termino.aprobado

        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim consulta As String = ""

        conexion.ConnectionString = Me.acceso._StringConexion
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        conexion.Open()

        consulta = "DELETE FROM Clubes WHERE codClub = " & Me.txt_codClub.Text

        cmd.CommandText = consulta

        Try
            cmd.ExecuteNonQuery()
            Me.accion = estado.insertar
            Return termino.aprobado
        Catch ex As Exception
            MessageBox.Show("No se puede eliminar este Club ya que está siendo utilizado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return termino.rechazado
        End Try
    End Function

    Private Sub cmb_codPos_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_codPos.DropDown
        cargar_combo(cmb_codPos, leo_tabla("CodPostales"), "codPos", "codPos")
    End Sub

    'Comandos

    Private Sub cmd_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_guardar.Click
        
        If validarCampos() = True Then
            If Me.accion = estado.insertar Then
                If validar_existencia() = termino.aprobado Then
                    Me.insertar()
                    MessageBox.Show("Nuevo Club cargado con éxito", "Operación completa")

                Else : MessageBox.Show("El Club que intenta guardar ya está registrado", "Error")



                End If
            Else : Me.modificar()
                MessageBox.Show("Club modificado con éxito", "Operación completa")
            End If

            Me.inicio()
        End If
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.inicio()
    End Sub

    Private Sub cmd_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar.Click
        If txt_codClub.Text = "" Then
            MsgBox("No se ha seleccionado ningún club", MsgBoxStyle.Critical, "Error")
        Else
            If MessageBox.Show("¿Está seguro que desea eliminar el Club " & txt_nombre.Text & "?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                If Me.delete() = termino.aprobado Then
                    MessageBox.Show("Club eliminado", "Operación completada")
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
        txt_codClub.Focus()
        Me.accion = estado.insertar
    End Sub

    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_buscar.Enabled = True

        If txt_nombre.Text <> "" And txt_codClub.Text <> "" Then
            MsgBox("Ingrese sólo un criterio de búsqueda", MsgBoxStyle.Critical, "Importante")
            txt_codClub.Focus()

        Else

            If txt_codClub.Text = "" Then
                If txt_nombre.Text = "" Then
                    MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
                    txt_codClub.Focus()

                Else
                    Dim consulta As String = ""
                    Dim dt As New Data.DataTable
                    consulta = "SELECT * FROM Clubes WHERE nombre LIKE '%" & Me.txt_nombre.Text & "%'"
                    dt = acceso.ejecutar(consulta)
                    grid_clubes.DataSource = dt
                End If
            Else
                Dim consulta As String = ""
                Dim dt As New Data.DataTable
                consulta = "SELECT * FROM Clubes WHERE codClub = '" & Me.txt_codClub.Text & "'"
                dt = acceso.ejecutar(consulta)
                grid_clubes.DataSource = dt

            End If
        End If

    End Sub

    Private Sub cmd_nuevoCP_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_nuevoCP.Click
        frm_ABMCodPos.ShowDialog()

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

    End Sub


    'Closing

    Private Sub frm_ABMclubes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            e.Cancel() = True
        End If
    End Sub

    
End Class