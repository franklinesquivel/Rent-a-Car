Imports System.Text.RegularExpressions
Public Class clsReservas
    'Atributos
    Private FechaInicio As Date
    Private FechaFin As Date
    Private CodigoReserva As String
    Private PrecioReserva As Decimal
    Private Estado As String
    Private idAgencia As Integer
    Private idCliente As Integer
    Private idCoche As Integer

    Private Conexion As clsConexion = New clsConexion()
    Private clsCorreo As clsEmail = New clsEmail() 'Tipo de atributo para poder enviar el correo
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
        CodigoReserva = ""
        PrecioReserva = 0
        Estado = ""
        idAgencia = 0
        idCliente = 0
        idCoche = 0
    End Sub
    'Metodos
    Private Sub CrearCodigoReserva(ByVal idAgencia As String)
        Dim fecha As Date = Now
        Dim numFilas As Integer = Conexion.contarFilas("SELECT * FROM reservas WHERE id_reserva LIKE '" & fecha.Year & "%'")
        CodigoReserva = fecha.Year & idAgencia & Format(numFilas + 1, "#000000")
    End Sub
    Public Function ChequearReserva(ByVal Optional _cliente As String = Nothing) As Boolean
        If Conexion.contarFilas("SELECT * FROM reservas WHERE id_cliente = '" & _cliente & "' AND estado = 'Activa'") > 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function Registrar(ByVal _fechaInicio As String, ByVal _fechaFin As String, ByVal _cliente As String, ByVal _idCoche As String, ByVal _idAgencia As String)
        'Dim rgx_fecha = New Regex("^\d{2}\d{2}\d{4}$")
        'Dim rgx_usuario = New Regex("^C{1}\L{1}\d{5}")

        'If rgx_fecha.IsMatch(_fechaInicio) Or rgx_fecha.IsMatch(_fechaFin) Then
        '  MsgBox("Error: Ingrese un fecha válida")
        '   Return False
        'End If

        ' If _fechaInicio >= _fechaFin Then
        '  MsgBox("Error: La fecha de incio no puede ser mayor a la fecha final")
        '   Return False
        'End If

        ' If _fechaFin < Now Then
        '  MsgBox("Error: No puede ingresar una fecha de inicio menor a la actual")
        '   Return False
        'End If
        MyClass.CrearCodigoReserva(_cliente)
        If MyClass.ChequearReserva(_cliente) Then
            If Conexion.modificarDatos("INSERT INTO reservas VALUES('" & CodigoReserva & "', " & _cliente & ", " & _idAgencia & ", " & _idCoche & ", " & Session.ObtenerIdUsuario & ", '" & _fechaInicio & "', '" & _fechaFin & "', 'Activa')") Then
                Return True
            Else
                Return False
            End If
        Else
            MsgBox("Error: El usuario tiene una reserva activa")
            Return False
        End If
    End Function
    Public Function CancelarReserva(ByVal _cliente As String, ByVal _codigoReserva As String)
        Dim rgx_usuario = New Regex("^U{1}\d{5}")
        Dim rgx_codigoReserva = New Regex("^\d{11,}$")

        _cliente = _cliente.Trim
        _codigoReserva = _codigoReserva.Trim

        If _cliente.Length = 0 Or rgx_usuario.IsMatch(_cliente) Then
            MsgBox("Error: Ingrese un código de cliente válido")
            Return False
        End If

        If _codigoReserva.Length = 0 Or rgx_codigoReserva.IsMatch(_codigoReserva) Then
            MsgBox("Error: Ingrese un código de reserva válido")
            Return False
        End If

        'MyClass.EnviarCorreo()
        Return True
    End Function
    Public Sub verRegistros(ByRef dgv As DataGridView, ByVal _cliente As String)
        Dim rgx_usuario = New Regex("^U{1}\d{5}")
        _cliente = _cliente.Trim

        If _cliente.Length = 0 Or Not rgx_usuario.IsMatch(_cliente) Then
            MsgBox("Error: Ingrese un código de cliente válido")
            Exit Sub
        End If
    End Sub
End Class
