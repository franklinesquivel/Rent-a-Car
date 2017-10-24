Public Class clsGerentes
    Inherits clsUsuarios 'Se hacce la herencia

    'Constructor de la clase
    Public Sub New()
        MyBase.New()
        tipoUsuario = "Gerente"
    End Sub
    'Metodos de la clase
    Public Overloads Function Registrar(ByVal _nombres As String, ByVal _apellidos As String, ByVal _correo As String) As Boolean
        _nombres = _nombres.Trim
        _apellidos = _apellidos.Trim

        If _nombres.Length = 0 Then 'Se valida que el nombre no este vacío
            MsgBox("Error: Ingrese nombres", MsgBoxStyle.Critical)
            Return False
        End If

        If _apellidos.Length = 0 Then 'Se valida que el nombre no este vacío
            MsgBox("Error: Ingrese apellidos", MsgBoxStyle.Critical)
            Return False
        End If

        If _noCoincide("^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$", _correo) Then 'Se valida el correo electrónico
            MsgBox("Error: Ingrese un correo válido", MsgBoxStyle.Critical)
            Return False
        End If

        Return MyBase.Registrar(_nombres, _apellidos, tipoUsuario, _correo)
    End Function
End Class
