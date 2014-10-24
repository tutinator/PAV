Public Class listado_clubes
    Dim acceso As New accesoBD
    Private Sub listado_clubes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.consultar()
        Me.rv_listadoClubes.RefreshReport()
    End Sub

    Private Sub consultar()
        Dim consulta As String
        Dim tabla As New Data.DataTable

        consulta = "SELECT Clubes.codClub, Clubes.nombre, Clubes.calle, Clubes.numero, "
        consulta &= " Clubes.telefono, Clubes.codPos, CodPostales.nombre AS area"
        consulta &= " FROM Clubes INNER JOIN"
        consulta &= " CodPostales ON Clubes.codPos = CodPostales.codPos"

        tabla = acceso.ejecutar(consulta)

        Me.bs_listadoClubes.DataSource = tabla
        Me.rv_listadoClubes.RefreshReport()

    End Sub
End Class