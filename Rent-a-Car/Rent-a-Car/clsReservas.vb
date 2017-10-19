Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
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
    Private idUsuario As Integer

    Private Conexion As clsConexion = New clsConexion()
    Private clsCorreo As clsEmail = New clsEmail() 'Tipo de atributo para poder enviar el correo
    'Propiedades
    Public WriteOnly Property EstablecerFechaInicio() As Date
        Set(ByVal value As Date)
            FechaInicio = value
        End Set
    End Property
    Public WriteOnly Property EstablecerFechaFin() As Date
        Set(ByVal value As Date)
            FechaFin = value
        End Set
    End Property
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
    Public ReadOnly Property ObtenerIdUsuario() As Integer
        Get
            Return idUsuario
        End Get
    End Property
    Public ReadOnly Property ObtenerPrecioReserva() As Decimal
        Get
            Return PrecioReserva
        End Get
    End Property
    Public WriteOnly Property EstablecerIdUsuario() As Integer
        Set(ByVal value As Integer)
            idUsuario = value
        End Set
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
    Public WriteOnly Property EstablecerIdAgencia() As String
        Set(ByVal value As String)
            idAgencia = value
        End Set
    End Property
    Public WriteOnly Property EstablecerIdCoche() As Integer
        Set(ByVal value As Integer)
            idCoche = value
        End Set
    End Property
    Public WriteOnly Property EstablecerIdCliente() As Integer
        Set(ByVal value As Integer)
            idCliente = value
        End Set
    End Property
    Public WriteOnly Property EstablecerPrecioReserva() As Decimal
        Set(ByVal value As Decimal)
            PrecioReserva = value
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
    Private Sub CrearCodigoReserva(ByVal _idAgencia As String)
        Dim fecha As Date = Now
        Dim numFilas As Integer = Conexion.contarFilas("SELECT * FROM reservas WHERE id_reserva LIKE '" & fecha.Year & "%'")
        CodigoReserva = fecha.Year & _idAgencia & Format(numFilas + 1, "#000000")
    End Sub
    Public Overloads Function ChequearReserva(ByVal Optional _cliente As String = Nothing) As Boolean
        If Conexion.contarFilas("SELECT * FROM reservas WHERE id_cliente = '" & _cliente & "' AND estado = 'Activa'") > 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function ChequearReservaFecha(ByVal _fechaIncio As Date, ByVal _fechaFin As Date, ByVal _idCoche As Integer) As Boolean
        If Conexion.contarFilas("SELECT * FROM `reservas` WHERE id_coche = " & _idCoche & " AND (" & _fechaIncio & " BETWEEN fecha_retiro AND fecha_devolucion) or (" & _fechaFin & " BETWEEN fecha_retiro AND fecha_devolucion) AND estado = 'Activa'") > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function ChequearRenta(ByVal _idCoche As Integer) As Boolean
        If Conexion.contarFilas("SELECT * FROM rentas WHERE id_coche = " & _idCoche & " AND estado = 'Activa'") > 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function Registrar(ByVal _fechaInicio As String, ByVal _fechaFin As String, ByVal cliente As clsClientes, ByVal coche As clsCoches, ByVal _idAgencia As String)
        Dim rgx_fecha = New Regex("^\d{2}\d{2}\d{4}$")

        'Dim rgx_usuario = New Regex("^C{1}\L{1}\d{5}")

        If rgx_fecha.IsMatch(_fechaInicio) Or rgx_fecha.IsMatch(_fechaFin) Then
            MsgBox("Error: Ingrese un fecha válida")
            Return False
        End If

        If CDate(_fechaInicio) >= CDate(_fechaFin) Then
            MsgBox("Error: La fecha de incio no puede ser mayor a la fecha final")
            Return False
        End If

        If CDate(_fechaFin) < Date.Now Or CDate(_fechaInicio) < Date.Now Then
            MsgBox("Error: No puede ingresar una fecha de inicio menor a la actual")
            Return False
        End If

        MyClass.CrearCodigoReserva(_idAgencia)
        If MyClass.ChequearReserva(cliente.ObtenerIdCliente) Then
            If MyClass.ChequearReservaFecha(CDate(_fechaInicio), CDate(_fechaFin), coche.ObtenerIdCoche) Then
                If MyClass.ChequearRenta(coche.ObtenerIdCoche) Then
                    MyClass.EstablecerFechaInicio = CDate(_fechaInicio)
                    MyClass.EstablecerFechaFin = CDate(_fechaFin)
                    MyClass.EstablecerIdAgencia = _idAgencia
                    MyClass.EstablecerIdCoche = coche.ObtenerIdCoche
                    MyClass.EstablecerIdCliente = cliente.ObtenerIdCliente
                    MyClass.EstablecerIdUsuario = Session.ObtenerIdUsuario
                    MyClass.EstablecerPrecioReserva = coche.ObtenerPrecioAlquiler * DateDiff(DateInterval.Day, MyClass.ObtenerFechaInicio, MyClass.ObtenerFechaFin)
                    Estado = "Activo"

                    If Conexion.modificarDatos("INSERT INTO reservas VALUES('" & CodigoReserva & "', " & idCliente & ", " & idAgencia & ", " & idCoche & ", " & Session.ObtenerIdUsuario & ", '" & _fechaInicio & "', '" & _fechaFin & "', " & PrecioReserva & " ,'Activa')") Then
                        clsCorreo.enviarCorreo(cliente, coche, PrecioReserva)
                        Return True
                    Else
                        Return False
                    End If
                End If
            Else
                MsgBox("Error: Se ha encontrado una reserva en las fechas limitadas")
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
    Public Function listarReservas(ByRef listaReservas() As clsReservas, ByRef dgv As DataGridView) As Boolean
        If Conexion.contarFilas("SELECT * FROM reservas WHERE estado = 'Activa'") = 0 Then
            Return 0
        Else
            Dim i As Integer = 0
            Dim reader As MySqlDataReader
            Conexion.obtenerDatos("SELECT r.id_reserva, r.id_cliente, r.id_agencia, r.id_coche, r.id_usuario, r.fecha_retiro, r.fecha_devolucion, r.precio_pagar, r.estado, cl.nombre, cl.apellido, cl.nombre_usuario , c.placa FROM reservas r INNER JOIN clientes cl ON r.id_cliente = cl.id_cliente INNER JOIN coches c ON r.id_coche = c.id_coche WHERE r.estado = 'Activa'", reader)

            dgv.ColumnCount = 7
            dgv.Columns(0).Name = "Id"
            dgv.Columns(1).Name = "Cliente"
            dgv.Columns(2).Name = "Código Cliente"
            dgv.Columns(3).Name = "Matrícula Coche"
            dgv.Columns(4).Name = "Fecha Retiro"
            dgv.Columns(5).Name = "Fecha Devolución"
            dgv.Columns(6).Name = "Precio ($)"
            dgv.RowCount = 1

            While reader.Read()
                ReDim Preserve listaReservas(i) 'Se ridemenciona el array de clase
                Reservas = New clsReservas 'Nuevo objeto de la clase

                'Se guardan los campos en los atributos
                Reservas.EstablecerCodigoReserva = reader(0)
                Reservas.EstablecerIdCliente = reader(1)
                Reservas.EstablecerIdAgencia = reader(2)
                Reservas.EstablecerIdCoche = reader(3)
                Reservas.EstablecerIdUsuario = reader(4)
                Reservas.EstablecerFechaInicio = reader(5)
                Reservas.EstablecerFechaFin = reader(6)
                Reservas.EstablecerPrecioReserva = reader(7)
                Reservas.EstablecerEstado = reader(8)

                listaReservas(i) = Reservas 'Se guarda el objeto en el array

                With dgv
                    i = .RowCount
                    .Rows.Add()
                    .Rows(i - 1).Cells(0).Value = listaReservas(i - 1).ObtenerCodigoReserva
                    .Rows(i - 1).Cells(1).Value = reader(10) & ", " & reader(9)
                    .Rows(i - 1).Cells(2).Value = reader(11)
                    .Rows(i - 1).Cells(3).Value = reader(12)
                    .Rows(i - 1).Cells(4).Value = listaReservas(i - 1).ObtenerFechaInicio.ToString("yyyy-MM-dd")
                    .Rows(i - 1).Cells(5).Value = listaReservas(i - 1).ObtenerFechaFin.ToString("yyyy-MM-dd")
                    .Rows(i - 1).Cells(6).Value = listaReservas(i - 1).ObtenerPrecioReserva
                End With
            End While
            reader.Close()
            Return 1
        End If
    End Function
    Public Function CancelarReserva(ByVal reserva As clsReservas) As Boolean
        If Conexion.modificarDatos("UPDATE reservas SET estado = 'Cancelada' WHERE id_reserva = '" & reserva.ObtenerCodigoReserva & "'") Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Public Function BuscarIndice(ByVal idReserva As String, ByVal listaReservas() As clsReservas) As Integer
        For i As Integer = 0 To UBound(listaReservas, 1)
            If listaReservas(i).ObtenerCodigoReserva = idReserva.ToUpper Then
                Return i
            End If
        Next
        Return -1
    End Function
    Public Sub BuscarReserva(ByVal idReserva As String, ByVal listaReservas() As clsReservas, ByRef dgv As DataGridView, ByVal Optional teclaBorrar As Boolean = False)
        Dim rgx_reserva = New Regex("^" + idReserva + "+")
        Dim reader As MySqlDataReader

        For i As Integer = 0 To UBound(listaReservas, 1)
            If Not rgx_reserva.IsMatch(listaReservas(i).ObtenerCodigoReserva) And Not teclaBorrar Then
                Dim r As Integer = 0
                For Each row As DataGridViewRow In dgv.Rows 'Filas
                    For Each cell As DataGridViewCell In row.Cells 'Columnas
                        If CStr(cell.Value) = listaReservas(i).ObtenerCodigoReserva Then
                            dgv.Rows.RemoveAt(dgv.Rows(r).Index) 'Se remueven las filas
                        End If
                    Next 'Fin columnas
                    r += 1
                Next 'Fin filas
            Else
                dgv.ColumnCount = 7
                dgv.Columns(0).Name = "Id"
                dgv.Columns(1).Name = "Cliente"
                dgv.Columns(2).Name = "Código Cliente"
                dgv.Columns(3).Name = "Matrícula Coche"
                dgv.Columns(4).Name = "Fecha Retiro"
                dgv.Columns(5).Name = "Fecha Devolución"
                dgv.Columns(6).Name = "Precio ($)"
                dgv.RowCount = 1
                For x As Integer = 0 To UBound(listaReservas, 1)
                    If rgx_reserva.IsMatch(listaReservas(x).ObtenerCodigoReserva) Then
                        Conexion.obtenerDatos("SELECT r.id_reserva, r.id_cliente, r.id_agencia, r.id_coche, r.id_usuario, r.fecha_retiro, r.fecha_devolucion, r.precio_pagar, r.estado, cl.nombre, cl.apellido, cl.nombre_usuario , c.placa FROM reservas r INNER JOIN clientes cl ON r.id_cliente = cl.id_cliente INNER JOIN coches c ON r.id_coche = c.id_coche WHERE r.id_reserva = '" & listaReservas(x).ObtenerCodigoReserva & "'", reader)
                        reader.Read()
                        With dgv 'Se agregan en el dgv los datos
                            Dim j As Integer = .RowCount
                            .Rows.Add()
                            .Rows(j - 1).Cells(0).Value = listaReservas(x).ObtenerCodigoReserva
                            .Rows(j - 1).Cells(1).Value = reader(10) & ", " & reader(9)
                            .Rows(j - 1).Cells(2).Value = reader(11)
                            .Rows(j - 1).Cells(3).Value = reader(12)
                            .Rows(j - 1).Cells(4).Value = listaReservas(x).ObtenerFechaInicio.ToString("yyyy-MM-dd")
                            .Rows(j - 1).Cells(5).Value = listaReservas(x).ObtenerFechaFin.ToString("yyyy-MM-dd")
                            .Rows(j - 1).Cells(6).Value = listaReservas(x).ObtenerPrecioReserva
                        End With
                        reader.Close()
                    End If
                Next
            End If
        Next
    End Sub
End Class
