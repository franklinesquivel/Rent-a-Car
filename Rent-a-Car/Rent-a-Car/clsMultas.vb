Public Class clsMultas
    'atributos
    Private _idMulta As String
    Private _idRenta As String
    Private _descripcion As String
    Private _monto As String


    Public Sub verificarEstado(ByVal coche As clsRentas)
        If coche.estado Then

        Else
            coche.cambiarEstado = False
        End If
    End Sub
End Class
