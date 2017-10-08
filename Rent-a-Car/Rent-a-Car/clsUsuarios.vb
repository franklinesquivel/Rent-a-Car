Imports System.Text.RegularExpressions
Public Class clsUsuarios
    'Atributos
    Friend Nombres As String
    Friend Apellidos As String
    Friend Contrasenna As String
    Friend tipoUsuario As String
    Friend NombreUsuario As String
    Private Conexion As clsConexion = New clsConexion() 'Tipo de atributo para la conexión a la BDD
    Private Encriptacion As clsEncriptacion = New clsEncriptacion() 'Tipo de atributo para encriptar
    Private alfabeto = New String(63) {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}

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
            Return Encriptacion.DesarmarEncriptacion(Contrasenna)
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

        NombreUsuario = _nombreUsuario
        Contrasenna = _contrasenna
        If Conexion.existenciaUsuario("SELECT * FROM usuarios WHERE nombre_usuario = '" & NombreUsuario & "'", Contrasenna) Then
            Session.IniciarSesion(NombreUsuario)
            Return True
        Else
            Return False
        End If
    End Function

    Friend Function Registrar(ByVal _nombres As String, ByVal _apellidos As String, ByVal _tipoUsuario As String)
        'Tipos de usuarios: Administrador(A00000), Gerente(G0000), Contador(C0000)
        MyClass.CrearCodigo(_tipoUsuario)
        MyClass.CrearContrasenna()
        Return Conexion.modificarDatos("INSERT INTO usuarios(nombre, apellido, nombre_usuario, contraseña, perfil) VALUES('" & _nombres & "', '" & _apellidos & "', '" & NombreUsuario & "', '" & Contrasenna & "' , '" & _tipoUsuario & "')")
    End Function
    Public Sub CrearCodigo(ByVal _tipousuario As String)
        Dim _nombreUsuario As String
        Dim rnd As New Random()
        Dim repetir As Boolean = True

        While repetir
            _nombreUsuario = ""
            If _tipousuario = "Administrador" Then 'Se guarda el carcater identificador
                _nombreUsuario += "A"
            ElseIf _tipousuario = "Contador" Then
                _nombreUsuario += "C"
            ElseIf _tipousuario = "Gerente" Then
                _nombreUsuario += "G"
            Else
                Exit Sub
            End If

            For i As Byte = 0 To 4 'Se crean los digitos aleatorios
                _nombreUsuario += CStr(rnd.Next(0, 9))
            Next

            If Not MyClass.VerificarCodigoUsuario(_nombreUsuario) Then
                NombreUsuario = _nombreUsuario 'Se guarda en el atributo
                repetir = False
            End If
        End While
    End Sub
    Public Sub CrearContrasenna()
        Dim rnd As New Random
        For i As Byte = 0 To 7
            Contrasenna += alfabeto(rnd.Next(0, 63))
        Next
        MyClass.ArmarEncriptacion()
    End Sub
    Public Sub ArmarEncriptacion()
        Contrasenna = Encriptacion.ArmarEncriptacion(Contrasenna)
    End Sub
    Public Function DesarmarEncriptacion(ByVal _contrasenna As String)
        Return Encriptacion.DesarmarEncriptacion(_contrasenna)
    End Function
    Public Sub VerRegistros(ByVal Optional _tipoUsuario As String = Nothing)

    End Sub
    Public Function VerificarCodigoUsuario(ByVal _nombreUsuario As String)
        Return Conexion.contarFilas("SELECT * FROM usuarios WHERE nombre_usuario = '" & _nombreUsuario & "'")
    End Function
End Class
