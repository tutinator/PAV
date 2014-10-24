Public Class listado_insAcomp
    Dim acceso As New accesoBD

    Private Sub listado_insAcomp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar_combos()
    End Sub
    Private Sub consultar()
        Dim consulta As String
        Dim tabla As New Data.DataTable

        consulta = "SELECT       Nadadores.codNad, Nadadores.apellido, Nadadores.nombre, Profesores.apellido AS apellidoProfe, Profesores.nombre AS nombreProfe, "
        consulta &= "              Clubes.nombre AS club, Torneos.descripcion AS torneo, Inscripciones.año, Especialidades.descripcion AS espe"
        consulta &= " FROM            Torneos INNER JOIN"
        consulta &= "               Inscripciones ON Torneos.codTorneo = Inscripciones.codTorneo INNER JOIN"
        consulta &= "               Nadadores ON Inscripciones.codNad = Nadadores.codNad INNER JOIN"
        consulta &= "               Clubes ON Nadadores.codClub = Clubes.codClub INNER JOIN"
        consulta &= "               Profesores ON Nadadores.codProfe = Profesores.codProfe INNER JOIN"
        consulta &= "               Especialidades ON Inscripciones.codEspe = Especialidades.codEspe"
        consulta &= " WHERE Inscripciones.codTorneo = " & Me.cmb_torneo.SelectedValue & " AND Inscripciones.año = " & Me.cmb_año.SelectedValue & ""
        consulta &= " AND Inscripciones.codEspe = " & Me.cmb_espe.SelectedValue


        tabla = acceso.ejecutar(consulta)
        Me.InscriptosBindingSource.DataSource = tabla
        Me.rv_insAComp.RefreshReport()

    End Sub

    Private Sub cargar_combo(ByRef combo As ComboBox, ByVal nombre_tabla As DataTable, ByVal pk As String, ByVal descrip As String)

        combo.DataSource = nombre_tabla
        combo.ValueMember = pk
        combo.DisplayMember = descrip
        'combo.SelectedIndex = -1

    End Sub

    Private Function leo_tabla(ByRef _tabla) As DataTable
        Dim consulta As String = ""
        consulta = "SELECT * FROM " & _tabla
        Return acceso.ejecutar(consulta)
    End Function

    Private Sub cargar_combos()
        Dim tabla As Data.DataTable
        Dim consulta As String = ""
        consulta = "SELECT DISTINCT Torneos.codTorneo, Torneos.descripcion FROM Competencias INNER JOIN Torneos ON Competencias.codTorneo = Torneos.codTorneo"
        tabla = acceso.ejecutar(consulta)
        cargar_combo(cmb_torneo, tabla, "codTorneo", "descripcion")
    End Sub

    Private Sub cmb_torneo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_torneo.SelectedIndexChanged
        Dim tabla As New DataTable
        Dim consulta As String = ""
        consulta = "SELECT DISTINCT Competencias.año FROM Competencias INNER JOIN Torneos ON Competencias.codTorneo = Torneos.codTorneo"
        consulta &= " WHERE Torneos.descripcion = '" & Me.cmb_torneo.Text & "'"
        tabla = acceso.ejecutar(consulta)
        cargar_combo(cmb_año, tabla, "año", "año")
    End Sub

    Private Sub cmb_año_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_año.SelectedIndexChanged
        Dim tabla As New DataTable
        Dim consulta As String = ""
        consulta = "SELECT Especialidades.codEspe, Especialidades.descripcion FROM Competencias INNER JOIN Torneos ON Competencias.codTorneo = Torneos.codTorneo"
        consulta &= " INNER JOIN Especialidades ON Competencias.codEspe = Especialidades.codEspe WHERE Torneos.descripcion = '" & Me.cmb_torneo.Text & "' AND Competencias.año = " & Me.cmb_año.Text
        tabla = acceso.ejecutar(consulta)
        cargar_combo(cmb_espe, tabla, "codEspe", "descripcion")
    End Sub

    Private Sub cmd_generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_generar.Click
        consultar()
    End Sub
End Class