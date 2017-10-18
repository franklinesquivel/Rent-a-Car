Imports MySql.Data.MySqlClient
Module mdlDeclaracionClases
    Public Usuarios As clsUsuarios 'Variable para el tipo de clase clsUsuarios
    Public Administradores As clsAdministradores 'Variable para el tipo de clase clsAdministradores
    Public Gerente As clsGerentes 'Variable para el tipo de clase clsGerente
    Public Contador As clsContadores 'Variable para el tipo de clase clsContadores
    Public Agencia As clsAgencias 'Variable para el tipo de clase clsAgencia
    Public Clientes As clsClientes 'Variable para el tipo de clase clsClientes
    Public Coches As clsCoches 'Variable para el tipo de clase clsCoches
    Public Reservas As clsReservas 'Varuable para el tipo de clase clsReservas
    Public Rentas As clsRentas
    'Public Encriptar As clsEncriptacion 'Variable para el tipo de clase clsEncriptar
    'Public Conexion As clsConexion 'Variable para el tipo de clase clsConexion
    Public paises As clsPaises
    Public email As clsEmail
    Public Session As EstructuraSession = New EstructuraSession(Nothing, Nothing) 'Estructura creada con el fin de manejo de sesiones
    Structure EstructuraSession
        Private _tipoUsuario As String
        Private _idUsuario As String
        Private _codigoUsuario As String

        Public ReadOnly Property ObtenerTipoUsuario() As String
            Get
                Return _tipoUsuario
            End Get
        End Property

        Public WriteOnly Property EstablecerTipoUsuario() As String
            Set(ByVal value As String)
                _tipoUsuario = value
            End Set
        End Property
        Private WriteOnly Property EstablecerNombreUsuario() As String
            Set(ByVal value As String)
                _codigoUsuario = value
            End Set
        End Property
        Private ReadOnly Property ObtenerNombreUsuario() As String
            Get
                Return _codigoUsuario
            End Get
        End Property
        Public ReadOnly Property ObtenerIdUsuario() As String
            Get
                Return _idUsuario
            End Get
        End Property

        Public WriteOnly Property EstablecerIdUsuario() As String
            Set(ByVal value As String)
                _idUsuario = value
            End Set
        End Property

        Public Sub New(ByVal _tipo As String, ByVal _id As String)
            _tipoUsuario = _tipo
            _idUsuario = _id
        End Sub

        Public Sub CerrarSession()
            _tipoUsuario = Nothing
            _idUsuario = Nothing
            Dim formTitles As New Collection
            frmInicio_Sesion.Show()

            For Each f As Form In Application.OpenForms 'Se cierran los forms abiertos
                f.Hide()
            Next
            frmInicio_Sesion.Show()
        End Sub

        Public Sub ControlarSession(ByRef formActual As Form)
            If _tipoUsuario = Nothing And _idUsuario = Nothing Then
                For Each f As Form In Application.OpenForms 'Se cierran los forms abiertos
                    f.Hide()
                Next
                frmInicio_Sesion.Show()
            End If
        End Sub

        Public Sub IniciarSesion(ByVal idUsuario As String)
            EstablecerNombreUsuario = idUsuario.ToUpper
            Dim reader As MySqlDataReader
            Dim Conexion As New clsConexion()

            If ObtenerNombreUsuario.Substring(0, 1).ToUpper = "A" Then
                EstablecerTipoUsuario = "A"
                Conexion.obtenerDatos("SELECT * FROM usuarios WHERE nombre_usuario = '" & ObtenerNombreUsuario & "'", reader)
                reader.Read()
                EstablecerIdUsuario = reader(0)
                reader.Close()
                frmMenu_Admin.Show()
            ElseIf ObtenerNombreUsuario.Substring(0, 1).ToUpper = "G" Then
                EstablecerTipoUsuario = "G"
                Conexion.obtenerDatos("SELECT * FROM usuarios WHERE nombre_usuario = '" & ObtenerNombreUsuario & "'", reader)
                reader.Read()
                EstablecerIdUsuario = reader(0)
                reader.Close()
                frmMenu_Agentes.Show()
            ElseIf ObtenerNombreUsuario.Substring(0, 1).ToUpper = "C" Then
                EstablecerTipoUsuario = "C"
                reader.Read()
                EstablecerIdUsuario = reader(0)
                reader.Close()
                frmMenu_contador.Show()
            End If

        End Sub
    End Structure
End Module
