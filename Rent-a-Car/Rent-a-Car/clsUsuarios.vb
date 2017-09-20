Public Class clsUsuarios
    'Atributos
    Friend Nombres As String
    Friend Apellidos As String
    Friend Contrasenna As String
    Friend tipoUsuario As String
    Friend NombreUsuario As String

    'Propiedades Generales
    Public ReadOnly Property ObtenerNombre() As String
        Get
            Return Nombres
        End Get
    End Property
    Public ReadOnly Property ObtenerApellidos() As String
        Get
            Return Apellidos
        End Get
    End Property
    Public ReadOnly Property ObtenerContrasenna() As String
        Get
            Return Contrasenna
        End Get
    End Property
    Public ReadOnly Property ObtenerTipoUsuario() As String
        Get
            Return tipoUsuario
        End Get
    End Property
    Public ReadOnly Property ObtenerNombreUsuario() As String
        Get
            Return NombreUsuario
        End Get
    End Property
    'Constructor
    Public Sub New()
        Nombres = ""
        Apellidos = ""
        Contrasenna = ""
        NombreUsuario = ""
    End Sub
    'Metodos Generales
    Public Function IniciarSesion(ByVal _nombreUsuario As String, ByVal _contrasenna As String) As Boolean
        _nombreUsuario = _nombreUsuario.Trim

        If _nombreUsuario.Length > 0 Then 'Falta Regex
            MsgBox("Error: Ingrese un nombre de usuario válido")
            Return False
        End If

        _contrasenna = _contrasenna.Trim
        If _contrasenna.Length > 0 Then 'Falta Regex 
            MsgBox("Error: Ingrese una contraseña")
            Return False
        End If

        Return True
    End Function

    Public Function Registrar(ByVal _nombres As String, ByVal _apellidos As String, ByVal _tipoUsuario As String)

    End Function
End Class
