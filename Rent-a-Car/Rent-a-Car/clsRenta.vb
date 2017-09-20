Public Class clsRenta
    Private _idRenta As Integer
    Private _idCliente As String
    Private _idAgencia As String
    Private _idUsuario As String
    Private _fechaRetiro As Date
    Private _fechaEntrega As Date
    Private _estado As Boolean

    Public ReadOnly Property id
        Get
            Return _idRenta
        End Get
    End Property
End Class
