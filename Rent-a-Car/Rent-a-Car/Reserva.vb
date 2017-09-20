Public Class Reserva
    'Atributos
    Private FechaInicio As Date
    Private FechaFin As Date
    Private CodigoReserva As String
    Private PrecioReserva As Decimal
    Private Estado As String
    Private idAgencia As Integer
    Private idCliente As Integer
    Private idCohe As Integer
    'Propiedades
    Public ReadOnly Property ObtenerFechaInicio() As Date
        Get
            Return FechaInicio
        End Get
    End Property
    Public ReadOnly Property ObtenerFechaFin() As Date
        Get
            Return FechaFin
        End Get
    End Property
    Public ReadOnly Property ObtenerCodigoReserva() As String
        Get
            Return CodigoReserva
        End Get
    End Property
    Public ReadOnly Property ObtenerPrecioReserva() As Decimal
        Get
            Return PrecioReserva
        End Get
    End Property
    Private WriteOnly Property EstablecerCodigoReserva() As String
        Set(ByVal value As String)
            CodigoReserva = value
        End Set
    End Property
    Public ReadOnly Property ObtenerEstado() As String
        Get
            Return Estado
        End Get
    End Property
    Public WriteOnly Property EstablecerEstado() As String
        Set(ByVal value As String)
            Estado = value
        End Set
    End Property
    'Constructor
    Public Sub New()
        FechaInicio = ""
        FechaFin = ""
        CodigoReserva = ""
        PrecioReserva = 0
        Estado = 0
        idAgencia = 0
        idCliente = 0
        idCohe = 0
    End Sub
    'Metodos
    Private Sub CrearCodigoReserva()

    End Sub
    Public Function ChequearReserva(ByVal _cliente As String) As Boolean

    End Function
    'FALTA TIPO DE AUTO
    Public Function Registrar(ByVal _fechaInicio As String, ByVal _fechaFin As String, ByVal _cliente As String)

    End Function
    Public Function CancelarReserva(ByVal _cliente As String, ByVal _codigoReserva As String)

    End Function
End Class
