﻿Public Class clsGerente
    Inherits clsUsuarios
    'Constructor
    Public Sub New()
        tipoUsuario = "Gerente"
    End Sub
    'Metodos
    Public Overloads Sub Registrar(ByVal _nombres As String, ByVal _appellidos As String)
        MyBase.Registrar(_nombres, _appellidos, tipoUsuario)
    End Sub
End Class
