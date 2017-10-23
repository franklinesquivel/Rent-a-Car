Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.IO.Path
Public Class clsReservas
    'Atributos de la clase
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
    '_____________________________________________________
    '|      Propiedades de lectura de la clase           |
    '|___________________________________________________|
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
    Public ReadOnly Property ObtenerEstado() As String
        Get
            Return Estado
        End Get
    End Property
    Public ReadOnly Property ObtenerIdCliente() As Integer
        Get
            Return idCliente
        End Get
    End Property
    Public ReadOnly Property ObtenerIdCoche() As Integer
        Get
            Return idCoche
        End Get
    End Property
    Public ReadOnly Property ObtenerIdAgencia() As Integer
        Get
            Return idAgencia
        End Get
    End Property

    '_____________________________________________________
    '|      Propiedades de escritura de la clase         |
    '|___________________________________________________|
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
    Public WriteOnly Property EstablecerEstado() As String
        Set(ByVal value As String)
            Estado = value
        End Set
    End Property
    Public WriteOnly Property EstablecerIdAgencia() As Integer
        Set(ByVal value As Integer)
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
    '_____________________________________________________
    '|             Constructor de la clase               |
    '|___________________________________________________|
    Public Sub New()
        CodigoReserva = ""
        PrecioReserva = 0
        Estado = ""
        idAgencia = 0
        idCliente = 0
        idCoche = 0
    End Sub
    '_____________________________________________________
    '|               Metodos de la clase                 |
    '|___________________________________________________|
    Private Sub CrearCodigoReserva(ByVal _idAgencia As String)
        'Se crea el código de reserva
        Dim fecha As Date = Now
        Dim numFilas As Integer = Conexion.contarFilas("SELECT * FROM reservas WHERE id_reserva LIKE '" & fecha.Year & "%'")
        CodigoReserva = fecha.Year & _idAgencia & Format(numFilas + 1, "#000000")
    End Sub
    Private Overloads Function ChequearReserva(ByVal Optional _cliente As String = Nothing) As Boolean
        'Se verifica que no exista una reserva del usuario no este activa
        If Conexion.contarFilas("SELECT * FROM reservas WHERE id_cliente = '" & _cliente & "' AND estado = 'Activa'") > 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Function ChequearReservaFecha(ByVal _fechaIncio As Date, ByVal _fechaFin As Date, ByVal _idCoche As Integer) As Boolean
        'Se verifica que no exista una reserva en las fechas ingresadas
        If Conexion.contarFilas("SELECT * FROM `reservas` WHERE id_coche = " & _idCoche & " AND (('" & _fechaIncio.ToString("yyyy-MM-dd") & "' BETWEEN fecha_retiro AND fecha_devolucion) OR ('" & _fechaFin.ToString("yyyy-MM-dd") & "' BETWEEN fecha_retiro AND fecha_devolucion)) AND estado = 'Activa'") > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function ChequearRenta(ByVal _idCoche As Integer, ByVal _fechaInicio As Date, _fechaFin As Date) As Boolean
        'Se verifica que que el coche elegido no tenga una renta activa
        If Conexion.contarFilas("SELECT * FROM rentas WHERE id_coche = " & _idCoche & " AND estado = 'Activa' AND (('" & _fechaInicio.ToString("yyyy-MM-dd") & "' BETWEEN fecha_retiro AND fecha_devolucion) OR ('" & _fechaFin.ToString("yyyy-MM-dd") & "' BETWEEN fecha_retiro AND fecha_devolucion)) AND estado = 'Activa'") > 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function Registrar(ByVal _fechaInicio As String, ByVal _fechaFin As String, ByVal cliente As clsClientes, ByVal coche As clsCoches) As Boolean
        Dim rgx_fecha = New Regex("^\d{2}\d{2}\d{4}$") 'Patrón de fecha
        'Dim rgx_usuario = New Regex("^C{1}\L{1}\d{5}") 'Patrón del código de usuario

        If rgx_fecha.IsMatch(_fechaInicio) Or rgx_fecha.IsMatch(_fechaFin) Then 'Se verifica el patron de las fechas
            MsgBox("Error: Ingrese un fecha válida")
            Return False
        End If

        If CDate(_fechaInicio) > CDate(_fechaFin) Then 'Se verifica si la fecha una es mayor que la otra
            MsgBox("Error: La fecha de incio no puede ser mayor a la fecha final")
            Return False
        End If

        If CDate(_fechaInicio) < CDate(Date.Now.ToString("yyyy-MM-dd")) Then 'Se verifica que la fecha no sea mayor a la actual
            MsgBox("Error: No puede ingresar una fecha de inicio menor a la actual")
            Return False
        End If

        MyClass.CrearCodigoReserva(CStr(coche.ObtenerIdAgencia)) 'Se crea el código de reserva
        If MyClass.ChequearReserva(cliente.ObtenerIdCliente) Then 'Se verifica que el usuario no tenga una reserva activa
            If MyClass.ChequearReservaFecha(CDate(_fechaInicio), CDate(_fechaFin), coche.ObtenerIdCoche) Then 'Se verifica si existe una reserva activa con el coche elegido
                If MyClass.ChequearRenta(coche.ObtenerIdCoche, CDate(_fechaInicio), CDate(_fechaFin)) Then 'Se verifica si el coche no esta rentado
                    'Se establecen los datos en los atributos  de la clase
                    MyClass.EstablecerFechaInicio = CDate(_fechaInicio)
                    MyClass.EstablecerFechaFin = CDate(_fechaFin)
                    MyClass.EstablecerIdAgencia = coche.ObtenerIdAgencia
                    MyClass.EstablecerIdCoche = coche.ObtenerIdCoche
                    MyClass.EstablecerIdCliente = CInt(cliente.ObtenerIdCliente)
                    MyClass.EstablecerIdUsuario = CInt(Session.ObtenerIdUsuario)
                    MyClass.EstablecerPrecioReserva = coche.ObtenerPrecioAlquiler * DateDiff(DateInterval.Day, MyClass.ObtenerFechaInicio, MyClass.ObtenerFechaFin)
                    Estado = "Activo"

                    'Se insertan los datos
                    If Conexion.modificarDatos("INSERT INTO reservas VALUES('" & CodigoReserva & "', " & idCliente & ", " & idAgencia & ", " & idCoche & ", " & Session.ObtenerIdUsuario & ", '" & _fechaInicio & "', '" & _fechaFin & "', " & Format(PrecioReserva, "0.00") & " ,'Activa')") Then
                        clsCorreo.enviarCorreo(cliente, coche, CDec(Format(CDec(PrecioReserva), "0.00")))
                        Return True
                    End If
                Else
                    MsgBox("Error: El coche seleccionado esta en renta en las fechas limitadas")
                End If
            Else
                MsgBox("Error: Se ha encontrado una reserva del mismo coche en las fechas limitadas")
            End If
        Else
            MsgBox("Error: El usuario tiene una reserva activa")
        End If
        Return False
    End Function
    Public Function listarReservas(ByRef listaReservas() As clsReservas, ByRef dgv As DataGridView) As Boolean
        If Conexion.contarFilas("SELECT * FROM reservas WHERE estado = 'Activa'") = 0 Then 'Se verifica si existen reserva
            Return False
        Else
            Dim i As Integer = 0
            Dim reader As MySqlDataReader
            Conexion.obtenerDatos("SELECT r.id_reserva, r.id_cliente, r.id_agencia, r.id_coche, r.id_usuario, r.fecha_retiro, r.fecha_devolucion, r.precio_pagar, r.estado, cl.nombre, cl.apellido, cl.nombre_usuario , c.placa FROM reservas r INNER JOIN clientes cl ON r.id_cliente = cl.id_cliente INNER JOIN coches c ON r.id_coche = c.id_coche WHERE r.estado = 'Activa'", reader)

            'Se agregan las columnas con sus nombre
            dgv.ColumnCount = 7
            dgv.Columns(0).Name = "Id"
            dgv.Columns(1).Name = "Cliente"
            dgv.Columns(2).Name = "Código Cliente"
            dgv.Columns(3).Name = "Matrícula Coche"
            dgv.Columns(4).Name = "Fecha Retiro"
            dgv.Columns(5).Name = "Fecha Devolución"
            dgv.Columns(6).Name = "Precio ($)"
            dgv.RowCount = 1

            While reader.Read() 'Se abre y recorre la variable de lectura
                ReDim Preserve listaReservas(i) 'Se ridemenciona el array de clase
                Reservas = New clsReservas 'Nuevo objeto de la clase

                'Se guardan los campos en los atributos
                Reservas.EstablecerCodigoReserva = CStr(reader(0))
                Reservas.EstablecerIdCliente = CInt(reader(1))
                Reservas.EstablecerIdAgencia = CInt(reader(2))
                Reservas.EstablecerIdCoche = CInt(reader(3))
                Reservas.EstablecerIdUsuario = CInt(reader(4))
                Reservas.EstablecerFechaInicio = CDate(reader(5))
                Reservas.EstablecerFechaFin = CDate(reader(6))
                Reservas.EstablecerPrecioReserva = CDec(reader(7))
                Reservas.EstablecerEstado = CStr(reader(8))

                listaReservas(i) = Reservas 'Se guarda el objeto en el array

                With dgv
                    i = .RowCount 'Se obtiene el número de fila
                    .Rows.Add() 'Se agrega una fila a dgv

                    'Se agregan los valores a la fila y columna con su valor respectivo
                    .Rows(i - 1).Cells(0).Value = listaReservas(i - 1).ObtenerCodigoReserva
                    .Rows(i - 1).Cells(1).Value = CStr(reader(10)) & ", " & CStr(reader(9))
                    .Rows(i - 1).Cells(2).Value = reader(11)
                    .Rows(i - 1).Cells(3).Value = reader(12)
                    .Rows(i - 1).Cells(4).Value = listaReservas(i - 1).ObtenerFechaInicio.ToString("yyyy-MM-dd")
                    .Rows(i - 1).Cells(5).Value = listaReservas(i - 1).ObtenerFechaFin.ToString("yyyy-MM-dd")
                    .Rows(i - 1).Cells(6).Value = listaReservas(i - 1).ObtenerPrecioReserva
                End With
            End While
            reader.Close() 'Se cierra la lectura
            Return True
        End If
    End Function
    Public Function CancelarReserva(ByVal reserva As clsReservas) As Boolean 'Función para cancelar Reserva
        If Conexion.modificarDatos("UPDATE reservas SET estado = 'Cancelada' WHERE id_reserva = '" & reserva.ObtenerCodigoReserva & "'") Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function BuscarIndice(ByVal idReserva As String, ByVal listaReservas() As clsReservas) As Integer
        Dim rgx_reserva = New Regex("^\d{11}$") 'Patrón del código de Reserva
        If rgx_reserva.IsMatch(idReserva) Then 'Se verifica el patrón
            For i As Integer = 0 To UBound(listaReservas, 1) 'Se recorre la lista de objetos de tipo Reserva
                If listaReservas(i).ObtenerCodigoReserva = idReserva.ToUpper Then 'Se verifica si el valor iterado es igual al parametro
                    Return i 'Se regresa el indice de la lista del array
                End If
            Next
        End If
        Return -1
    End Function
    Public Sub BuscarReserva(ByVal idReserva As String, ByVal listaReservas() As clsReservas, ByRef dgv As DataGridView, ByVal Optional teclaBorrar As Boolean = False)
        Dim rgx_reserva = New Regex("^" + idReserva + "+") 'Patrón de busqueda
        Dim reader As MySqlDataReader 'Variable lectora de la BDD (Se pasa como referencia)

        For i As Integer = 0 To UBound(listaReservas, 1) 'Se recorre la lista de objetos de tipo reserva
            If Not rgx_reserva.IsMatch(listaReservas(i).ObtenerCodigoReserva) And Not teclaBorrar Then 'Se verifica el patrón de busqeueda
                Dim r As Integer = 0
                For Each row As DataGridViewRow In dgv.Rows 'Se recorre el dgv (Filas)
                    For Each cell As DataGridViewCell In row.Cells 'Se recorre el dgv (Columnas)
                        If CStr(cell.Value) = listaReservas(i).ObtenerCodigoReserva Then 'Se compara el valor de la celda con el de la lista
                            dgv.Rows.RemoveAt(dgv.Rows(r).Index) 'Se remueven las filas
                        End If
                    Next 'Fin columnas
                    r += 1
                Next 'Fin filas
            Else
                'Se agregan las columnas
                dgv.ColumnCount = 7
                dgv.Columns(0).Name = "Id"
                dgv.Columns(1).Name = "Cliente"
                dgv.Columns(2).Name = "Código Cliente"
                dgv.Columns(3).Name = "Matrícula Coche"
                dgv.Columns(4).Name = "Fecha Retiro"
                dgv.Columns(5).Name = "Fecha Devolución"
                dgv.Columns(6).Name = "Precio ($)"
                dgv.RowCount = 1
                For x As Integer = 0 To UBound(listaReservas, 1) 'Se recorre la lista de objetos de tipo reserva
                    If rgx_reserva.IsMatch(listaReservas(x).ObtenerCodigoReserva) Then 'Se compara el patrón
                        Conexion.obtenerDatos("SELECT r.id_reserva, r.id_cliente, r.id_agencia, r.id_coche, r.id_usuario, r.fecha_retiro, r.fecha_devolucion, r.precio_pagar, r.estado, cl.nombre, cl.apellido, cl.nombre_usuario , c.placa FROM reservas r INNER JOIN clientes cl ON r.id_cliente = cl.id_cliente INNER JOIN coches c ON r.id_coche = c.id_coche WHERE r.id_reserva = '" & listaReservas(x).ObtenerCodigoReserva & "'", reader)
                        reader.Read() 'Se abre la variable de lectura
                        With dgv 'Se agregan en el dgv los datos
                            Dim j As Integer = .RowCount 'Se obtiene el número de filas
                            .Rows.Add() 'Se agrega una columna

                            'Se agregan los valores según fila y columna apropiada
                            .Rows(j - 1).Cells(0).Value = listaReservas(x).ObtenerCodigoReserva
                            .Rows(j - 1).Cells(1).Value = CStr(reader(10)) & ", " & CStr(reader(9))
                            .Rows(j - 1).Cells(2).Value = reader(11)
                            .Rows(j - 1).Cells(3).Value = reader(12)
                            .Rows(j - 1).Cells(4).Value = listaReservas(x).ObtenerFechaInicio.ToString("yyyy-MM-dd")
                            .Rows(j - 1).Cells(5).Value = listaReservas(x).ObtenerFechaFin.ToString("yyyy-MM-dd")
                            .Rows(j - 1).Cells(6).Value = listaReservas(x).ObtenerPrecioReserva
                        End With
                        reader.Close() 'Se cierra la variable de lectura
                    End If
                Next
            End If
        Next
    End Sub

    Public Sub VerDatos(ByVal id_reserva As String, ByRef _matricula As String, ByRef _especificaciones As String, ByRef _pic As PictureBox, ByRef _nombreCliente As String, ByRef _nombreUsuario As String, ByRef _correo As String) 'metodo para ver los datos de una reserva en especifico
        Dim reader As MySqlDataReader
        Dim resourcesPath = Application.StartupPath & DirectorySeparatorChar & ".." & DirectorySeparatorChar & ".." & DirectorySeparatorChar & "Resources" & DirectorySeparatorChar & "Coches" & DirectorySeparatorChar 'Obtener Carpeta donde estan guardadas las imagenes
        Conexion.obtenerDatos("SELECT c.placa, CONCAT_WS(' - ', c.modelo, c.marca), c.fotografia,  CONCAT_WS(', ', CL.apellido, cl.nombre), cl.nombre_usuario, cl.correo_electronico FROM `reservas` r INNER JOIN coches c ON c.id_coche = r.id_coche INNER JOIN clientes cl ON cl.id_cliente = r.id_cliente WHERE r.id_reserva = '" & id_reserva & "'", reader)
        reader.Read() 'Se abre la lectura
        _matricula = CStr(reader(0))
        _especificaciones = CStr(reader(1))
        _pic.ImageLocation = resourcesPath + CStr(reader(2))
        _nombreCliente = CStr(reader(3))
        _nombreUsuario = CStr(reader(4))
        _correo = CStr(reader(5))
        reader.Close() 'Se cierra la lectura
    End Sub
End Class
