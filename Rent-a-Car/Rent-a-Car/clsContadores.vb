Public Class clsContadores
    Inherits clsUsuarios 'Herencia
    'Constructor de la clase
    Public Sub New()
        MyBase.New()
        tipoUsuario = "Contador"
    End Sub
    'Metodos de la clase
    Public Overloads Function Registrar(ByVal _nombres As String, ByVal _apellidos As String, ByVal _correo As String)
        _nombres = _nombres.Trim
        _apellidos = _apellidos.Trim

        If _nombres.Length = 0 Then 'Se verifica que el nombre no este vacío
            MsgBox("Error: Ingrese nombres")
            Return False
        End If

        If _apellidos.Length = 0 Then 'Se verifica que el apellido no este vacío 
            MsgBox("Error: Ingrese apellidos")
            Return False
        End If

        If _noCoincide("^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$", _correo) Then 'Se valida el correo electrónico
            Return False
        End If

        Return MyBase.Registrar(_nombres, _apellidos, tipoUsuario, _correo)
    End Function
End Class
