Imports System.Text.RegularExpressions
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
        Dim rgx_usuarios = New Regex("^(A{1}|G{1}|C{1})\d{5}$") 'Regex de validacion

        If _nombreUsuario.Length = 0 Or Not rgx_usuarios.IsMatch(_nombreUsuario) Then 'Falta Regex
            MsgBox("Error: Ingrese un nombre de usuario válido")
            Return False
        End If

        _contrasenna = _contrasenna.Trim
        If _contrasenna.Length < 8 Then
            MsgBox("Error: Ingrese una contraseña")
            Return False
        End If

        'Inicio de Sesión estático
        'Administrador
        If _nombreUsuario = "A17987" And _contrasenna = "1234567aa" Then
            frmMenu_Admin.Show()
            'Gerente
        ElseIf _nombreUsuario = "G17977" And _contrasenna = "1234567bb" Then
            frmMenu_Agentes.Show()
            'Contador
        ElseIf _nombreUsuario = "C17887" And _contrasenna = "12345yuo" Then
            frmMenu_contador.Show()
        Else
            MsgBox("Error: Usuario no encontrado")
            Return False
        End If
        Return True
    End Function

    Public Function Registrar(ByVal _nombres As String, ByVal _apellidos As String, ByVal _tipoUsuario As String)
        'Tpos de usuarios: Administrador(A00000), Gerente(G0000), Contador(C0000)
        Return True
    End Function
    Public Sub CrearCodigo(ByVal _tipousuario As String)

    End Sub
    Public Sub CrearContrasenna()

    End Sub
    Public Function ArmarEncriptacion(ByVal _contrasenna As String)

    End Function
    Public Function DesarmarEncriptacion(ByVal _contrasenna As String)

    End Function
    Public Sub VerRegistros(ByVal Optional _tipoUsuario As String = Nothing)

    End Sub
    Public Sub VerificarCodigoUsuario(ByVal _tipoUsuario As String)

    End Sub
End Class
