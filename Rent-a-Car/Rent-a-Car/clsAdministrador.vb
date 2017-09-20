Public Class clsAdministrador
    Inherits clsUsuarios

    'Constructor
    Public Sub New()
        tipoUsuario = "Administrador"
    End Sub
    'Metodos
    Public Overloads Sub Registrar(ByVal _nombres As String, ByVal _appellidos As String)
        MyBase.Registrar(_nombres, _appellidos, tipoUsuario)
    End Sub
End Class
