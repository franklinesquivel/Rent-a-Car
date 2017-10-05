Module mdlDeclaracionClases
    Public Usuarios As clsUsuarios 'Variable para el tipo de clase clsUsuarios
    Public Agencia As clsAgencias 'Variable para el tipo de clase clsAgencia
    Public Clientes As clsClientes 'Variable para el tipo de clase clsClientes
    Public Coches As clsCoches 'Variable para el tipo de clase clsCoches

    'Estructura creada con el fin de manejo de sesiones
    Public Session As EstructuraSession = New EstructuraSession(Nothing, Nothing)
    Structure EstructuraSession
        Private _tipoUsuario As String
        Private _idUsuario As String

        Public ReadOnly Property ObtenerTipoUsuario() As String
            Get
                Return _tipoUsuario
            End Get
        End Property

        Public WriteOnly Property EstablecerCodigoUsuario() As String
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
    End Structure
End Module
