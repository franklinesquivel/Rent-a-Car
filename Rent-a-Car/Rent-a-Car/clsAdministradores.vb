Public Class clsAdministradores
    Inherits clsUsuarios

    'Constructor
    Public Sub New()
        MyBase.New()
        tipoUsuario = "Administrador"
    End Sub
    'Metodos
    Public Overloads Function Registrar(ByVal _nombres As String, ByVal _apellidos As String, ByVal _correo As String)
        _nombres = _nombres.Trim
        _apellidos = _apellidos.Trim

        If _nombres.Length = 0 Then
            MsgBox("Error: Ingrese nombres")
            Return False
        End If

        If _apellidos.Length = 0 Then
            MsgBox("Error: Ingrese apellidos")
            Return False
        End If

        Return MyBase.Registrar(_nombres, _apellidos, tipoUsuario, _correo)
    End Function
End Class
