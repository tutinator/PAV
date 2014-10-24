Public Class accesoBD
        Enum BaseDatos
            Oledb
            OledbOracle
            OledbSqlServer
            SqlServer
            Oracle
        End Enum
    Dim CadenaConexion As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\Users\Franco\Downloads\BD Natacion v2.0\natacion.mdf"";Integrated Security=True;Connect Timeout=30;User Instance=True"
        Dim conexion As Object
        Dim cmd As Object
        Dim tipoBaseDatos As BaseDatos

        Public WriteOnly Property _cadenaConexion As String
            Set(ByVal value As String)
                CadenaConexion = value
            End Set
        End Property

        Public Property _tipoBaseDatos As BaseDatos
            Get
                Return tipoBaseDatos
            End Get
            Set(ByVal value As BaseDatos)
                tipoBaseDatos = value
            End Set
        End Property

    Public ReadOnly Property _StringConexion As String
        Get
            Return Me.CadenaConexion
        End Get
    End Property




    Public Sub New()
        Me.conexion = New Data.SqlClient.SqlConnection()
        Me.cmd = New Data.SqlClient.SqlCommand()
    End Sub

    Private Sub conectar()
        ' Dim conexion As New Data.SqlClient.SqlConnection
        ' Dim cmd As New Data.SqlClient.SqlCommand
        conexion.ConnectionString = Me.CadenaConexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
    End Sub

    Public Function ejecutar(ByVal sql As String) As Data.DataTable
        Me.conectar()
        Dim tabla As New Data.DataTable
        Me.cmd.CommandText = sql
        tabla.Load(Me.cmd.ExecuteReader())
        conexion.Close()
        Return tabla
    End Function

    Public Sub ejecutarNonConsulta(ByVal sql As String)
        Me.conectar()
        '   Me.cmd.CommandType = CommandType.Text
        Me.cmd.CommandText = sql
        '    cmd.Connection = conexion
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub
End Class
