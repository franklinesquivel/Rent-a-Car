Imports MySql.Data.MySqlClient
Public Class clsConexion
    Private _cmd As MySqlCommand
    Private _mysqlAdaoter As MySqlDataAdapter
    Private _tabla As DataTable
    Private _aceptarConexion As Boolean
    Private _conn As MySqlConnection = New MySqlConnection("server = 127.0.0.1; database = ezic; user = root; port = 3306; Convert Zero Datetime=True")
    Public Sub New()
        Try
            _conn.Open()
            _aceptarConexion = True
            _conn.Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error en la conexión")
            _aceptarConexion = False
        End Try
    End Sub

    Public Function EjecutarTransaccion(ByVal consulta As String)
        'Aqui se realizan operaciones como: UPDATE, DELETE, INSERT
        If _aceptarConexion Then
            _conn.Open()
            _cmd = New MySqlCommand(consulta, _conn)
            _conn.Close()
            Return _cmd.ExecuteNonQuery
        End If
    End Function

    Public Sub ObtenerDatos(ByVal consulta As String)
        'Aqui se realizan operaciones como: SELECT
        If _aceptarConexion Then
            _conn.Open()
            _cmd = New MySqlCommand(consulta, _conn)
            _mysqlAdaoter = New MySqlDataAdapter(_cmd)
            _tabla = New DataTable()
            _mysqlAdaoter.Fill(_tabla)

            Dim row As DataRow = _tabla.Rows(0)
            MsgBox(CStr(row("idStudent")))

            _conn.Close()
        End If
    End Sub
End Class
