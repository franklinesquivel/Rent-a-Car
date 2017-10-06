Imports MySql.Data.MySqlClient
Public Class clsConexion
    Private _cmd As MySqlCommand
    Private _mysqlAdapter As MySqlDataAdapter
    Private _tabla As DataTable
    Private _aceptarConexion As Boolean
    Private Encriptacion As clsEncriptacion = New clsEncriptacion()
    Private _conn As MySqlConnection = New MySqlConnection("server = 127.0.0.1; database = rent_a_car; user = root; port = 3306; Convert Zero Datetime=True")
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

    Public Function modificarDatos(ByVal consulta As String) As String
        'Aqui se realizan operaciones como: UPDATE, DELETE, INSERT

        _conn.Close() 'Se cierra la conexión previa

        If _aceptarConexion Then
            _conn.Open() 'Se abre la conexión
            _cmd = New MySqlCommand(consulta, _conn) 'Se ejecuta la consulta

            Return _cmd.ExecuteNonQuery 'Se ejecuta la consulta en modo NonQuery
        End If

        Return False
    End Function

    Public Function seleccionarDatos(ByVal consulta As String, Optional ObtenerFilas As Boolean = False) As Boolean

        _conn.Close() 'Se cierra la conexión a la BDD
        _conn.Open() 'Se abre la conexion
        _cmd = New MySqlCommand(consulta, _conn) 'Se ejecuta la consulta
        Dim reader As MySqlDataReader = _cmd.ExecuteReader() 'Se ejecuta la consulta en modo lectura

        If reader.HasRows Then 'Si existen filas con dicha coincidencia

            If Not ObtenerFilas Then 'Si el proposito no es enlistar algo
                reader.Read()
            End If

            reader.Close()
            Return 1
        End If

        reader.Close()
        Return 0 'Si no existe filas
    End Function

    Public Function existenciaUsuario(ByVal consulta As String, ByVal contrasenna As String) As Boolean 'Función dirigida hacia el login
        _conn.Close() 'Se cierra la conexión a la BDD
        _conn.Open() 'Se abre la conexion
        _cmd = New MySqlCommand(consulta, _conn) 'Se ejecuta la consulta
        Dim reader As MySqlDataReader = _cmd.ExecuteReader() 'Se ejecuta la consulta en modo lectura

        If reader.HasRows Then
            If Encriptacion.DesarmarEncriptacion(reader(4)) = contrasenna Then
                Return 1 'Contraseñas coinciden
            Else
                Return 0 'Contraseñas no coinciden
            End If
        End If

        Return 0 'No hay usuario con dicho nombre de usuario
    End Function
End Class
