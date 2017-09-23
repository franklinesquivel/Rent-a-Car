Public Class clsMulta
    'atributos
    Private _idMulta As String
    Private _idRenta As String
    Private _descripcion As String
    Private _monto As String


    Public Sub verificarEstado(ByVal coche As clsRenta)
        If coche.estado Then

        Else
            coche.cambiarEstado = False
        End If
    End Sub
End Class
