Public Class frm_ABMnadadores

    Private Sub frm_AMBnadadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicio()
    End Sub
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
        cambiarBotones(False)
        cambiarEntradas(False)
        cargar_combos()
        Me.cmd_nuevo.Enabled = True
        Me.cmd_buscar.Enabled = True
        Me.cmd_salir.Enabled = True
    End Sub

    Private Sub limpiarCampos()
        txt_codNadador.Text = ""
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
        cmb_club.Text = ""
    End Sub

    Private Function validarCampos()
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

        'If msk_fechaNacimiento.Text <> "" Then
        'If (DateValue(msk_fechaNacimiento.Text) > DateValue(Date.Today)) Then
        'MsgBox("La fecha ingresada no es válida", MsgBoxStyle.Critical, "Importante")
        'End If

        ' If Not opt_femenino.Checked And Not opt_masculino.Checked Then
        'MsgBox("El sexo del nadador debe ser seleccionado", MsgBoxStyle.Critical, "Importante")
        'End If

        Return True
    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
        txt_codNadador.Enabled = x
        txt_calle.Enabled = x
        msk_fechaNacimiento.Enabled = x
        txt_email.Enabled = x
        txt_calle.Enabled = x
        txt_nroCalle.Enabled = x
        cmb_codPos.Enabled = x
        cmb_profesor.Enabled = x
        cmb_club.Enabled = x
        'opt_femenino.Enabled = x
        'opt_masculino.Enabled = x
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
        cmd_nuevoClub.Enabled = x
    End Sub

    Private Function leo_tabla(ByRef _tabla) As DataTable
        Dim consulta As String = ""
        consulta = "SELECT * FROM " & _tabla
        Return acceso.ejecutar(consulta)
    End Function

    Private Sub cargar_combo(ByRef combo As ComboBox, ByVal nombre_tabla As DataTable, ByVal pk As String, ByVal descrip As String)

        combo.DataSource = nombre_tabla
        combo.ValueMember = pk
        combo.DisplayMember = descrip
        combo.SelectedIndex = -1

    End Sub

    Private Sub cargar_combos()
        cargar_combo(cmb_codPos, leo_tabla("CodPostales"), "codPos", "codPos")
        cargar_combo(cmb_club, leo_tabla("Clubes"), "codClub", "nombre")
        cargar_combo(cmb_profesor, leo_tabla("Profesores"), "codProfe", "nombre")
        cargar_combo(cmb_tipoDoc, leo_tabla("TiposDoc"), "tipoDoc", "nombre")
    End Sub
    Private Sub cargar_grilla()

        Dim consulta As String = ""
        consulta = "SELECT Nadadores.codNad AS Codigo, Nadadores.apellido AS Apellido, Nadadores.nombre AS Nombre, "
        consulta &= "TiposDoc.nombre AS [Tipo Doc], Nadadores.nroDoc AS [Numero Doc], Nadadores.calle AS Calle, Nadadores.numero AS Numero, Nadadores.codPos AS [Cod Postal], "
        consulta &= "CodPostales.nombre AS Area, Profesores.nombre AS [Nombre Profe], Profesores.apellido AS [Apellido Profe], Clubes.nombre AS Club, "
        consulta &= "Nadadores.email AS Email "
        consulta &= "FROM Clubes INNER JOIN "
        consulta &= "CodPostales ON Clubes.codPos = CodPostales.codPos INNER JOIN "
        consulta &= "Nadadores ON Clubes.codClub = Nadadores.codClub INNER JOIN "
        consulta &= "Profesores ON Nadadores.codProfe = Profesores.codProfe INNER JOIN "
        consulta &= "TiposDoc ON Nadadores.tipoDoc = TiposDoc.tipoDoc "

        'consulta = "SELECT codNad AS Codigo, apellido AS Apellido, nombre AS Nombre, tipoDoc AS TipoDoc, nroDoc AS NumeroDoc, calle AS Calle, numero AS Numero, codPos AS CodPostal, codProfe AS CodProfe, codClub AS CodClub, email AS Email FROM Nadadores"
        grid_nadadores.DataSource = acceso.ejecutar(consulta)

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
    

    Private Function modificar() As termino

        Dim consulta As String = ""
        consulta = "UPDATE Nadadores SET nombre = '" & Me.txt_nombre.Text & "', "
        consulta &= "apellido = '" & Me.txt_apellido.Text & "', "
        consulta &= "tipoDoc = " & Me.cmb_tipoDoc.ValueMember & ", "
        consulta &= "nroDoc = " & Me.txt_nroDoc.Text & ", "
        consulta &= "calle = " & Me.txt_calle.Text & ", "
        consulta &= "numero = " & Me.txt_nroCalle.Text & ", "
        consulta &= "codPos = " & Me.cmb_codPos.SelectedValue & ", "
        consulta &= "codProfe = " & Me.cmb_profesor.ValueMember & ", "
        consulta &= "codClub = " & Me.cmb_club.ValueMember & ", "
        consulta &= "email = " & Me.txt_email.Text & " "
        consulta &= "WHERE codNad = " & Me.txt_codNadador.Text

        acceso.ejecutarNonConsulta(consulta)

        Return termino.aprobado
    End Function

    Private Function insertar() As termino

        Dim consulta As String = ""
        consulta = "INSERT into Nadadores (codNad, apellido, nombre, tipoDoc, nroDoc, calle, numero, codPos, codProfe, codClub, email) values (" & Me.txt_codNadador.Text & ", '" & Me.txt_apellido.Text & "', "
        consulta &= "'" & Me.txt_nombre.Text & "', " & Me.cmb_tipoDoc.SelectedValue & ", "
        consulta &= Me.txt_nroDoc.Text & ", '" & Me.txt_calle.Text & "', " & Me.txt_nroCalle.Text & ", "
        consulta &= Me.cmb_codPos.SelectedValue & ", " & Me.cmb_profesor.SelectedValue & ", " & Me.cmb_club.SelectedValue & ", '"
        consulta &= Me.txt_email.Text & "')"
        acceso.ejecutarNonConsulta(consulta)
        Return termino.aprobado
    End Function

    Private Function validar_existencia() As termino
        Dim consulta As String = ""
        Dim tabla As Data.DataTable
        consulta = "select * from Nadadores where codNad = " & Me.txt_codNadador.Text
        tabla = acceso.ejecutar(consulta)
        If tabla.Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Function delete() As termino
        Dim consulta As String = "DELETE FROM Nadadores WHERE codNad = " & Me.txt_codNadador.Text
        acceso.ejecutarNonConsulta(consulta)
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
                    If Me.insertar() = termino.aprobado Then
                        MessageBox.Show("Nadador cargado con éxito", "Operación completa")
                    End If
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
                If Me.delete() = termino.aprobado Then
                    MessageBox.Show("Club eliminado", "Operación completada")
                    Me.inicio()
                End If
            End If
        End If
    End Sub

    Private Sub cmd_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevo.Click
        cambiarBotones(False)
        cambiarEntradas(True)
        'txt_codNadador.Enabled = False
        cmd_nuevoCP.Enabled = True
        cmd_nuevoProfe.Enabled = True
        cmd_nuevoClub.Enabled = True

        Me.cmd_cancelar.Enabled = True
        Me.cmd_guardar.Enabled = True
        txt_codNadador.Focus()
        Me.accion = estado.insertar
    End Sub


    Private Sub cmd_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar.Click
        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_buscar.Enabled = True

        'If txt_apellido.Text = "" And txt_nombre.Text = "" And txt_nroDoc.Text = "" And txt_codNadador.Text = "" Then
        'MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
        'txt_codNadador.Focus()
        'Exit Sub
        'End If

        'Hay que agregar el codNadador como criterio!!
        Dim cont As Integer = 0

        If txt_apellido.Text <> "" Then cont = cont + 1
        If txt_nroDoc.Text <> "" Then cont = cont + 1
        If txt_nombre.Text <> "" Then cont = cont + 1
        If txt_codNadador.Text <> "" Then cont = cont + 1

        If cont = 0 Then
            MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
            txt_codNadador.Focus()
            Exit Sub
        End If

        If cont > 1 Then
            MsgBox("Ingrese sólo un criterio de búsqueda", MsgBoxStyle.Critical, "Importante")
            txt_codNadador.Focus()
            Exit Sub
        End If



        If txt_codNadador.Text = "" Then
            If txt_apellido.Text = "" Then
                If txt_nombre.Text = "" Then
                    If txt_nroDoc.Text = "" Then
                        MsgBox("Ingrese un dato para buscar", MsgBoxStyle.Critical, "Importante")
                        txt_codNadador.Focus()
                    Else
                        'busqueda por numero doc (tener en cuenta el tipo doc)
                        Dim consulta As String = ""
                        Dim dt As New Data.DataTable
                        consulta = "SELECT * FROM Nadadores WHERE nroDoc = " & Me.txt_nroDoc.Text
                        dt = acceso.ejecutar(consulta)
                        grid_nadadores.DataSource = dt
                    End If
                Else
                    'busqueda por nombre
                    Dim consulta As String = ""
                    Dim dt As New Data.DataTable
                    consulta = "SELECT * FROM Nadadores WHERE nombre LIKE '%" & Me.txt_nombre.Text & "%'"
                    dt = acceso.ejecutar(consulta)
                    grid_nadadores.DataSource = dt
                End If
            Else
                'busqueda por apellido
                Dim consulta As String = ""
                Dim dt As New Data.DataTable
                consulta = "SELECT * FROM Nadadores WHERE apellido LIKE '%" & Me.txt_apellido.Text & "%'"
                dt = acceso.ejecutar(consulta)
                grid_nadadores.DataSource = dt
            End If
        Else
            'busqueda por codigo de nadador
            Dim consulta As String = ""
            Dim dt As New Data.DataTable
            consulta = "SELECT * FROM Nadadores WHERE codNad = " & Me.txt_codNadador.Text
            dt = acceso.ejecutar(consulta)
            grid_nadadores.DataSource = dt
        End If
    End Sub

    Private Sub cmd_nuevoCP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevoCP.Click
        frm_ABMCodPos.ShowDialog()

        'Agregar funcionalidad para que al crearse el cp nuevo, se muestre en el cbo de cp
    End Sub

    Private Sub cmd_nuevoProfe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevoProfe.Click
        frm_ABMProfesores.ShowDialog()
        'Agregar funcionalidad para que al crearse el profe nuevo, se muestre en el cbo profesor
    End Sub

    Private Sub cmb_codPos_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_codPos.DropDown
        cargar_combo(cmb_codPos, leo_tabla("CodPostales"), "codPos", "codPos")
    End Sub

    Private Sub cmb_profesor_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_profesor.DropDown
        cargar_combo(cmb_profesor, leo_tabla("Profesores"), "codProfe", "nombre")
    End Sub

   


    Private Sub grid_nadadores_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grid_nadadores.CellMouseDoubleClick
        Dim codigoSeleccionado As String = Me.grid_nadadores.CurrentRow.Cells(0).Value

        Dim tabla As New Data.DataTable

        Dim consulta As String = ""
        consulta = "SELECT * FROM Nadadores WHERE codNad = " & codigoSeleccionado

        cambiarEntradas(True)
        tabla = acceso.ejecutar(consulta)

        Me.txt_codNadador.Text = tabla.Rows(0)("codNad")
        Me.txt_apellido.Text = tabla.Rows(0)("apellido")
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        'Me.msk_fechaNacimiento.Text = tabla.Rows(0)("fechaNac")
        Me.cmb_tipoDoc.SelectedValue = tabla.Rows(0)("tipoDoc")
        Me.txt_nroDoc.Text = tabla.Rows(0)("nroDoc")
        Me.txt_calle.Text = tabla.Rows(0)("calle")
        Me.txt_nroCalle.Text = tabla.Rows(0)("numero")
        Me.cmb_codPos.SelectedValue = tabla.Rows(0)("codPos")
        Me.cmb_profesor.SelectedValue = tabla.Rows(0)("codProfe")
        Me.cmb_club.SelectedValue = tabla.Rows(0)("codClub")
        Me.txt_email.Text = tabla.Rows(0)("email")


        cambiarBotones(False)
        Me.cmd_cancelar.Enabled = True
        Me.cmd_eliminar.Enabled = True
        Me.cmd_guardar.Enabled = True

        Me.txt_codNadador.Enabled = False
        txt_apellido.Focus()

        Me.accion = estado.modificar
    End Sub


    Private Sub frm_ABMnadadores_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            e.Cancel() = True
        End If
    End Sub

End Class
