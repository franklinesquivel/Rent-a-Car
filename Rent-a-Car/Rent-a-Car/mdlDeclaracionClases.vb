Module mdlDeclaracionClases
    Public Usuarios As clsUsuarios 'Variable para el tipo de clase clsUsuarios
    Public Administradores As clsAdministradores 'Variable para el tipo de clase clsAdministradores
    Public Gerente As clsGerentes 'Variable para el tipo de clase clsGerente
    Public Contador As clsContadores 'Variable para el tipo de clase clsContadores
    Public Agencia As clsAgencias 'Variable para el tipo de clase clsAgencia
    Public Clientes As clsClientes 'Variable para el tipo de clase clsClientes
    Public Coches As clsCoches 'Variable para el tipo de clase clsCoches
    'Public Encriptar As clsEncriptacion 'Variable para el tipo de clase clsEncriptar
    'Public Conexion As clsConexion 'Variable para el tipo de clase clsConexion

    Public Session As EstructuraSession = New EstructuraSession(Nothing, Nothing) 'Estructura creada con el fin de manejo de sesiones
    Structure EstructuraSession
        Private _tipoUsuario As String
        Private _idUsuario As String

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

            For Each f As Form In My.Application.OpenForms 'Se cierran los forms abiertos
                f.Hide()
            Next
        End Sub

        Public Sub Enrutador(ByRef formActual As Form)
            If _tipoUsuario <> Nothing And _idUsuario <> Nothing Then
                If _tipoUsuario = "A" Then 'Administrador
                    frmMenu_Admin.Show()
                ElseIf _tipoUsuario = "G" Then 'Gerente
                    frmMenu_Agentes.Show()
                ElseIf _tipoUsuario = "C" Then 'Contador
                    frmMenu_contador.Show()
                End If
                formActual.Hide()
            End If
        End Sub

        Public Sub IniciarSesion(ByVal idUsuario As String)
            EstablecerIdUsuario = idUsuario
            If ObtenerIdUsuario.Substring(0, 1).ToUpper = "A" Then
                EstablecerTipoUsuario = "A"
                frmMenu_Admin.Show()
            ElseIf ObtenerIdUsuario.Substring(0, 1).ToUpper = "G" Then
                EstablecerTipoUsuario = "G"
                frmMenu_Agentes.Show()
            ElseIf ObtenerIdUsuario.Substring(0, 1).ToUpper = "C" Then
                EstablecerTipoUsuario = "C"
                frmMenu_contador.Show()
            End If
        End Sub
    End Structure
End Module
