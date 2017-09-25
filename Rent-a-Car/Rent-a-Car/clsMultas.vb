Public Class clsMultas
    'atributos
    Private _idMulta As String
    Private _idRenta As String
    Private _descripcion As String
    Private _monto As Decimal

    Public Sub cancelarReserva(ByVal objRenta As clsRentas, ByVal objReserva As clsReservas, ByVal reservaCodigo As String)
        Dim horas As String
        Dim dias As String
        Dim multaTotal As Decimal
        horas = DateDiff(DateInterval.Hour, objReserva.ObtenerFechaInicio, objRenta.getFechaRetiro)
        dias = DateDiff(DateInterval.Day, objReserva.ObtenerFechaInicio, objRenta.getFechaRetiro)

        reservaCodigo = reservaCodigo.Trim

        If objReserva.ObtenerCodigoReserva = reservaCodigo Then
            If CInt(horas) > 24 Then
                multaTotal = CInt(dias) * objReserva.ObtenerPrecioReserva
                MsgBox("Debido a su demora el Total a pagar es de : $" & multaTotal)
                objReserva.EstablecerEstado = "Cancelada"
            Else
                MsgBox("Total a Pagar : $" & objReserva.ObtenerPrecioReserva)
            End If
        Else
            MsgBox("Error: Revise el codigo de la reserva.")
        End If

    End Sub
End Class
