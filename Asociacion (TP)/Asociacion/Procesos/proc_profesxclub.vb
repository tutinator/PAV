Public Class proc_profesxclub

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
        
        'cargar_listas()
        cambiarEntradas(False)
        cambiarBotones(False)
        Me.cmd_buscarProf.Enabled = True
        Me.cmd_salir.Enabled = True
        Me.txt_codProfe.Enabled = True
        'Me.cmb_apellido_profe.Enabled = True
        Me.txt_apellido.Enabled = True
        Me.txt_codProfe.Visible = True
        Me.txt_codProfe.Enabled = True
        Me.txt_nombre_profe.Enabled = True
        Me.cmb_codProfe.Visible = False
        Me.txt_codProfe.Focus()
        Me.cmd_nuevoprof.Enabled = True

    End Sub

    Private Sub limpiarCampos()
        Me.txt_codProfe.Text = ""
        Me.txt_apellido.Text = ""
        Me.txt_nombre_profe.Text = ""
        Me.txt_codProfe.Text = ""
    End Sub

    Private Sub txt_codProfe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(validarSoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Function validarSoloNumeros(ByVal KeyAscii As Integer) As Integer
        KeyAscii = Asc(UCase(Chr(KeyAscii))) 'Transformar letras minusculas a Mayúsculas
        If InStr("1234567890", Chr(KeyAscii)) = 0 Then
            validarSoloNumeros = 0
        Else
            validarSoloNumeros = KeyAscii
        End If
        If KeyAscii = 8 Then validarSoloNumeros = KeyAscii ' Backspace
    End Function

    Private Sub cargar_lista(ByRef lista As ListBox, ByVal nombre_tabla As DataTable, ByVal pk As String, ByVal descrip As String)
        lista.DataSource = nombre_tabla
        lista.ValueMember = pk
        lista.DisplayMember = descrip

    End Sub

    'Private Sub cargar_listas()
    '    cargar_lista(lst_clubes, leo_tabla("Clubes"), "codClub", "nombre")

    '    cargar_lista(lst_clubes, leo_tabla("Clubes"), "codClub", "nombre")
    'End Sub

    Private Sub cargar_combo(ByRef combo As ComboBox, ByVal nombre_tabla As DataTable, ByVal pk As String, ByVal descrip As String)

        combo.DataSource = nombre_tabla
        combo.ValueMember = pk
        combo.DisplayMember = descrip
        combo.SelectedIndex = -1

    End Sub

    Private Sub cargar_combos()
        'cargar_combo(cmb_apellido_profe, leo_tabla("Profesores"), "codProfe", "apellido")

    End Sub

    Private Sub cargar_listas()

        Dim tabla As New Data.DataTable
        Dim consulta As String = ""
        consulta = "SELECT * FROM Clubes INNER JOIN ProfeXClub ON Clubes.codClub = ProfeXClub.codClub"
        consulta &= " WHERE codProfe = " & Me.txt_codProfe.Text
        tabla = acceso.ejecutar(consulta)
        cargar_lista(lst_clubesTrabajo, tabla, "codClub", "nombre")
        consulta = "SELECT codClub, nombre FROM Clubes WHERE codClub NOT IN "
        consulta &= "(SELECT codClub FROM ProfeXClub WHERE codProfe = " & Me.txt_codProfe.Text & ")"
        tabla = acceso.ejecutar(consulta)
        cargar_lista(lst_clubes, tabla, "codClub", "nombre")

    End Sub

    Private Function validarCampos()

        If txt_codProfe.Text = "" Then
            MsgBox("Código de profesor no puede estar vacío", MsgBoxStyle.Critical, "Importante")
            Me.txt_codProfe.Focus()
            Return False
        End If

        'If cmb_club.SelectedText = "" Then
        '    MsgBox("Debe seleccionar un club", MsgBoxStyle.Critical, "Importante")
        '    Me.cmb_club.Focus()
        '    Return False
        'End If

        Return True
    End Function

    Private Sub cambiarEntradas(ByVal x As Boolean)
        limpiarCampos()
        Me.txt_codProfe.Enabled = x
        Me.txt_nombre_profe.Enabled = x
        Me.txt_apellido.Enabled = x
        'Me.cmb_club.Enabled = x
    End Sub

    Private Sub cambiarBotones(ByVal x As Boolean)
        'Me.cmd_guardar.Enabled = x
        ' Me.cmd_eliminar.Enabled = x
        ' Me.cmd_nuevo.Enabled = x
        Me.cmd_salir.Enabled = x
        'Me.cmd_cancelar.Enabled = x
        Me.cmd_buscarProf.Enabled = x
        'Me.cmd_nuevoClub.Enabled = x
        Me.cmd_nuevoprof.Enabled = x
    End Sub

    ''BASE DE DATOS
    Private Function leo_tabla(ByRef _tabla) As DataTable
        Dim consulta As String = ""
        consulta = "SELECT * FROM " & _tabla
        Return acceso.ejecutar(consulta)
    End Function


    Private Sub cmd_buscarProf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscarProf.Click

        If Me.txt_codProfe.Text <> "" Then
            Dim consulta As String = ""
            Dim dt As New Data.DataTable
            consulta = "SELECT * FROM Profesores WHERE codProfe = " & Me.txt_codProfe.Text
            dt = acceso.ejecutar(consulta)

            If dt.Rows.Count = 0 Then
                MsgBox("No existe ningún profesor con ese código", MsgBoxStyle.Critical, "Importante")
                Me.limpiarCampos()
                txt_codProfe.Focus()
            ElseIf dt.Rows.Count = 1 Then
                cambiarEntradas(True)
                Me.txt_codProfe.Text = dt.Rows(0)("codProfe")
                Me.txt_nombre_profe.Text = dt.Rows(0)("nombre")
                Me.txt_apellido.Text = dt.Rows(0)("apellido")
                cargar_listas()
            End If
            Return
        End If

        If txt_apellido.Text <> "" Then
            Dim consulta As String = ""
            Dim dt As New Data.DataTable
            consulta = "SELECT * FROM Profesores WHERE apellido LIKE '" & Me.txt_apellido.Text & "'"
            dt = acceso.ejecutar(consulta)

            If dt.Rows.Count = 0 Then
                MsgBox("No existe ningún profesor con ese apellido", MsgBoxStyle.Critical, "Importante")
                Me.limpiarCampos()
                txt_codProfe.Focus()
            ElseIf dt.Rows.Count = 1 Then
                cambiarEntradas(True)
                Me.txt_codProfe.Text = dt.Rows(0)("codProfe")
                Me.txt_nombre_profe.Text = dt.Rows(0)("nombre")
                Me.txt_apellido.Text = dt.Rows(0)("apellido")
            Else
                Me.txt_codProfe.Visible = False
                Me.cmb_codProfe.Visible = True
                cargar_combo(cmb_codProfe, dt, "codProfe", "codProfe")
            End If
        End If

        If Me.txt_codProfe.Text <> "" And Me.txt_apellido.Text <> "" And Me.txt_nombre_profe.Text <> "" Then
            cargar_listas()
        End If
    End Sub



    Private Sub cmd_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub frm_ABMTipoDocumento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.inicio()
    End Sub

    Private Sub cmb_codProfe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_codProfe.SelectionChangeCommitted
        Dim consulta As String = ""
        Dim dt As New Data.DataTable
        consulta = "SELECT * FROM Profesores WHERE codProfe = " & Me.cmb_codProfe.SelectedValue
        dt = acceso.ejecutar(consulta)
        Me.txt_apellido.Text = dt.Rows(0)("apellido")
        Me.txt_nombre_profe.Text = dt.Rows(0)("nombre")
        Me.txt_codProfe.Text = cmb_codProfe.Text
        cargar_listas()
    End Sub

    Private Sub cmd_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_agregar.Click
        Dim consulta As String
        Dim tabla As New Data.DataTable

        consulta = "SELECT codClub, nombre FROM Clubes WHERE codClub NOT IN (SELECT codClub"
        consulta &= " FROM ProfeXClub WHERE codProfe = " & Me.txt_codProfe.Text & ")"
        tabla = acceso.ejecutar(consulta)
        If tabla.Rows.Count > 0 Then
            consulta = "INSERT INTO ProfeXClub (codProfe, codClub) "
            consulta &= "VALUES (" & Me.txt_codProfe.Text & ", " & Me.lst_clubes.SelectedValue & ")"
            tabla = acceso.ejecutar(consulta)
            Me.cargar_listas()
        End If



    End Sub

    Private Sub cmd_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_quitar.Click
        Dim consulta As String
        Dim tabla As New Data.DataTable
        consulta = "SELECT * FROM ProfeXClub WHERE codProfe = " & Me.txt_codProfe.Text
        tabla = acceso.ejecutar(consulta)
        If tabla.Rows.Count > 0 Then
            consulta = "DELETE FROM ProfeXClub WHERE codClub = " & Me.lst_clubesTrabajo.SelectedValue & " AND codProfe = " & Me.txt_codProfe.Text & ""
            tabla = acceso.ejecutar(consulta)
            Me.cargar_listas()
        End If
    End Sub

    Private Sub cmd_nuevoprof_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_nuevoprof.Click
        frm_ABMProfesores.Show()
    End Sub

    Private Sub cmd_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancelar.Click
        Me.inicio()
    End Sub

End Class