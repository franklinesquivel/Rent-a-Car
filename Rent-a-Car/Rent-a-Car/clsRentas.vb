Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class clsRentas
    '____________________________
    '|   Atributos de la clase   |
    '|___________________________|
    Private _idRenta As Integer
    Private _idCliente As Integer
    Private _idAgencia As Integer
    Private _idCoche As Integer
    Private _idUsuario As Integer
    Private _fechaRetiro As Date
    Private _fechaEntrega As Date
    Private _estado As String
    Private _precio As Decimal
    Private _dias As Integer
    Private _tasaMulta As Integer = 3
    Private _total As Decimal = 0
    Private Conexion As clsConexion = New clsConexion()
    Private clsArchivo As clsFactura = New clsFactura()
    '______________________________
    '|   Constructor de la clase   |
    '|_____________________________|
    Public Sub New(Optional ByVal id As Integer = Nothing)
        If id <> Nothing Then
            'Función para obtener datos guardados en la BDD
        Else
            _estado = True
        End If
    End Sub
    '_________________________________________
    '|   Propiedades de lectura de la clase   |
    '|________________________________________|
    Public ReadOnly Property idCliente
        Get
            Return _idCliente
        End Get
    End Property
    Public ReadOnly Property Total
        Get
            Return _total
        End Get
    End Property
    Public ReadOnly Property idAgencia
        Get
            Return _idAgencia
        End Get
    End Property
    Public ReadOnly Property idCoche
        Get
            Return _idCoche
        End Get
    End Property

    Public ReadOnly Property estado
        Get
            Return _estado
        End Get
    End Property
    'obtener fecha retiro
    Public ReadOnly Property getFechaRetiro() As Date
        Get
            Return _fechaRetiro
        End Get
    End Property
    Public ReadOnly Property getFechadevo() As Date
        Get
            Return _fechaEntrega
        End Get
    End Property
    Public ReadOnly Property ObtenerCodigoRenta() As String
        Get
            Return _idRenta
        End Get
    End Property
    Public ReadOnly Property ObtenerEstado() As String
        Get
            Return _estado
        End Get
    End Property
    Public ReadOnly Property ObtenerIdUsuario() As Integer
        Get
            Return _idUsuario
        End Get
    End Property
    Public ReadOnly Property ObtenerDias() As Integer
        Get
            Return _dias
        End Get
    End Property
    Public ReadOnly Property ObtenerPrecio() As Decimal
        Get
            Return _precio
        End Get
    End Property
    '___________________________________________
    '|   Propiedades de escritura de la clase   |
    '|__________________________________________|
    Public WriteOnly Property cambiarEstado() As Boolean
        Set(ByVal value As Boolean)
            _estado = value
        End Set
    End Property
    Private WriteOnly Property EstablecerCodigoRenta() As String
        Set(ByVal value As String)
            _idRenta = value
        End Set
    End Property
    Public WriteOnly Property EstablecerIdAgencia() As String
        Set(ByVal value As String)
            _idAgencia = value
        End Set
    End Property
    Public WriteOnly Property EstablecerIdCoche() As Integer
        Set(ByVal value As Integer)
            _idCoche = value
        End Set
    End Property
    Public WriteOnly Property EstablecerIdCliente() As Integer
        Set(ByVal value As Integer)
            _idCliente = value
        End Set
    End Property
    Public WriteOnly Property EstablecerFechaInicio() As Date
        Set(ByVal value As Date)
            _fechaRetiro = value
        End Set
    End Property
    Public WriteOnly Property EstablecerFechaFin() As Date
        Set(ByVal value As Date)
            _fechaEntrega = value
        End Set
    End Property
    Public WriteOnly Property EstablecerIdUsuario() As Integer
        Set(ByVal value As Integer)
            _idUsuario = value
        End Set
    End Property
    Public WriteOnly Property EstablecerPrecio() As Decimal
        Set(ByVal value As Decimal)
            _precio = value
        End Set
    End Property
    Public WriteOnly Property EstablecerEstado() As String
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property
    '___________________________________
    '|   Metodos generales de la clase  |
    '|__________________________________|
    Public Function Registrar(ByVal _fechaInicio As String, ByVal _fechaFin As String, ByVal cliente As clsClientes, ByVal coche As clsCoches, ByVal _idAgencia As String)
        'Función que sirve para rentar no basandose en una reserva

        Dim rgx_fecha = New Regex("^\d{2}\d{2}\d{4}$") 'Patrón de la fecha
        'Dim rgx_usuario = New Regex("^C{1}\L{1}\d{5}") 'Patron de cpodigo de Usuario

        If rgx_fecha.IsMatch(_fechaInicio) Or rgx_fecha.IsMatch(_fechaFin) Then 'Se verifican las fechas
            MsgBox("Error: Ingrese un fecha válida")
            Return False
        End If

        If CDate(_fechaInicio) >= CDate(_fechaFin) Then 'Se verifica que una fecha sea mayor a la otra
            MsgBox("Error: La fecha de incio no puede ser mayor a la fecha final")
            Return False
        End If

        If CDate(_fechaFin) < Date.Now Or CDate(_fechaInicio) < Date.Now Then 'Se verifica que una fecha no sea mayor a la actual
            MsgBox("Error: No puede ingresar una fecha de inicio menor a la actual")
            Return False
        End If

        If MyClass.ChequearReserva(cliente.ObtenerIdCliente) Then 'Chequea si el cliente posee reserva activa
            If MyClass.ChequearReservaFecha(CDate(_fechaInicio), CDate(_fechaFin), coche.ObtenerIdCoche) Then 'Verifica si hay una reserva en los tiempos elegidos y si es de ese coche
                'Establece la información en los atributos
                MyClass.EstablecerFechaInicio = CDate(_fechaInicio)
                MyClass.EstablecerFechaFin = CDate(_fechaFin)
                MyClass.EstablecerIdAgencia = _idAgencia
                MyClass.EstablecerIdCoche = coche.ObtenerIdCoche
                MyClass.EstablecerIdCliente = cliente.ObtenerIdCliente
                MyClass.EstablecerIdUsuario = Session.ObtenerIdUsuario
                MyClass.EstablecerPrecio = coche.ObtenerPrecioAlquiler * DateDiff(DateInterval.Day, CDate(_fechaInicio), CDate(_fechaFin))
                'Ingresa los datos a la BD
                If Conexion.modificarDatos("INSERT INTO rentas VALUES(" & "NULL" & ", " & idCliente & ", " & idAgencia & ", " & idCoche & ", " & Session.ObtenerIdUsuario & ", '" & _fechaInicio & "', '" & _fechaFin & "' ,'Activa',  " & _precio & ") ") Then
                    clsArchivo.GenerarPDF(cliente, coche, _precio) 'Genera factura
                    Return True
                End If
            Else
                MsgBox("Error: Se ha encontrado una reserva activa con dicho coche")
            End If
        Else
            MsgBox("Error: El usuario tiene una reserva activa")
        End If
        Return False
    End Function

    Public Function registrarRenta(ByVal idCliente As Integer, ByVal idAgencia As Integer, ByVal idCoche As Integer, ByVal idUsuario As Integer, ByVal fechaR As String, ByVal fechaD As String, ByVal codigoReserva As String) As Boolean
        'Metodo que registra una renta basandose en una reserva
        If Conexion.contarFilas("SELECT * FROM reservas WHERE id_reserva = '" & codigoReserva & "'") = 0 Then 'Se verifica si el codigo de reserva existe en la BDD
            MsgBox("Error: El código de reserva no existe")
        Else
            Dim reader As MySqlDataReader 'Variable de lectura
            MsgBox(codigoReserva)
            Conexion.obtenerDatos("SELECT precio_pagar FROM reservas WHERE id_reserva = '" & codigoReserva & "'", reader) 'Obtnemos los datos de la reserva
            reader.Read()
            Dim totalPagar = reader(0)
            If Conexion.modificarDatos("INSERT INTO rentas VALUES(" & "NULL" & ", " & idCliente & ", " & idAgencia & ", " & idCoche & ", " & idUsuario & ", '" & fechaR & "', '" & fechaD & "' ,'Activa', " & totalPagar & ")") Then
                clsArchivo.GenerarPDFDatosReserva(codigoReserva, totalPagar) 'Mandamos información al pdf
                reader.Close() 'Se cierra la lectira
                Return True
            End If
        End If
        Return False
    End Function
    Public Function ReservaRealizada(ByVal reserva As clsReservas) As Boolean 'Si la renta fue exitosa y si en base a reserva, se cambia el estado de la reserva
        If Conexion.modificarDatos("UPDATE reservas SET estado = 'Realizada' WHERE id_reserva = '" & reserva.ObtenerCodigoReserva & "'") Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Function ChequearReserva(ByVal Optional indice As String = Nothing) As Boolean
        If Conexion.contarFilas("SELECT * FROM reservas WHERE id_cliente = " & indice & " AND estado = 'Activa'") > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function listarRentas(ByRef listaRentas() As clsRentas, ByRef dgv As DataGridView) As Boolean 'Se listan todas las rentas
        If Conexion.contarFilas("SELECT * FROM rentas WHERE estado = 'Activa'") = 0 Then
            Return 0
        Else
            Dim i As Integer = 0
            Dim reader As MySqlDataReader
            Conexion.obtenerDatos("SELECT r.id_renta, r.id_cliente, r.id_agencia, r.id_coche, r.id_usuario, r.fecha_retiro, r.fecha_devolucion, r.estado, cl.nombre, cl.apellido, cl.nombre_usuario , c.placa FROM rentas r INNER JOIN clientes cl ON r.id_cliente = cl.id_cliente INNER JOIN coches c ON r.id_coche = c.id_coche WHERE r.estado = 'Activa'", reader)

            dgv.ColumnCount = 6
            dgv.Columns(0).Name = "ID"
            dgv.Columns(1).Name = "Cliente"
            dgv.Columns(2).Name = "Código Cliente"
            dgv.Columns(3).Name = "Matrícula Coche"
            dgv.Columns(4).Name = "Fecha Retiro"
            dgv.Columns(5).Name = "Fecha Devolución"
            dgv.RowCount = 1

            While reader.Read()
                ReDim Preserve listaRentas(i) 'Se ridemenciona el array de clase
                Rentas = New clsRentas 'Nuevo objeto de la clase

                'Se guardan los campos en los atributos
                Rentas.EstablecerCodigoRenta = reader(0)
                Rentas.EstablecerIdCliente = reader(1)
                Rentas.EstablecerIdAgencia = reader(2)
                Rentas.EstablecerIdCoche = reader(3)
                Rentas.EstablecerIdUsuario = reader(4)
                Rentas.EstablecerFechaInicio = CDate(reader(5))
                Rentas.EstablecerFechaFin = CDate(reader(6))

                Rentas.EstablecerEstado = reader(7)

                listaRentas(i) = Rentas 'Se guarda el objeto en el array
                With dgv
                    i = .RowCount
                    .Rows.Add()
                    .Rows(i - 1).Cells(0).Value = reader(0).ToString
                    .Rows(i - 1).Cells(1).Value = reader(9) & ", " & reader(8)
                    .Rows(i - 1).Cells(2).Value = reader(10)
                    .Rows(i - 1).Cells(3).Value = reader(11)
                    .Rows(i - 1).Cells(4).Value = listaRentas(i - 1).getFechaRetiro.ToString("yyyy-MM-dd")
                    .Rows(i - 1).Cells(5).Value = listaRentas(i - 1).getFechadevo.ToString("yyyy-MM-dd")
                End With
            End While
            reader.Close()
            Return 1
        End If
    End Function

    Public Function DevolverCoche(ByVal id As Integer, ByVal tipoDevolucion As Integer, ByVal Fecha1 As String, ByVal Fecha2 As String, Optional ByVal descripcion As String = Nothing) As Boolean
        If tipoDevolucion = 1 Then 'Condicional cuando todo va bien

            If MyClass.Calcular(Fecha1, Fecha2) Then 'Registra la multa
                Conexion.modificarDatos("INSERT INTO multas VALUES(" & "NULL" & ", " & id & ", '" & descripcion & "', " & Total & ")")
                MsgBox("Total a pagar de multas por tardía $" & Total)
            End If

            'Registro cuando todo va bien
            If Conexion.modificarDatos("UPDATE rentas SET estado = 'Devuelto' WHERE id_renta = '" & id & "'") Then
                Return 1
            End If


        ElseIf tipoDevolucion = 2 Then 'Daños al auto
            Dim multa As Decimal = 0
            While multa <= 0 'Se registra la multa
                multa = InputBox("Ingrese la Multa por el coche chocado")
            End While

            If MyClass.Calcular(Fecha1, Fecha2) Then 'Registra la multa por tardía
                MsgBox("Total a pagar de multas por tardía $" & Total)
            End If

            'Registro multa por choque
            If Conexion.modificarDatos("INSERT INTO multas VALUES(" & "NULL" & ", " & id & ", '" & descripcion & "', " & (multa + Total) & ")") Then
                If Conexion.modificarDatos("UPDATE rentas SET estado = 'Devuelto' WHERE id_renta = '" & id & "'") Then

                    Dim reader As MySqlDataReader 'Se obtiene el id del coche
                    Conexion.obtenerDatos("SELECT c.id_coche FROM rentas r INNER JOIN coches c ON c.id_coche = r.id_coche WHERE r.id_renta = '" & id & "'", reader)

                    'Modifica el estado del coche
                    reader.Read()
                    If Conexion.modificarDatos("UPDATE coches SET estado = 'R' WHERE id_coche = '" & reader(0) & "'") Then
                        reader.Close()
                        Return 1
                    End If
                End If
            End If
        End If
        Return 0
    End Function
    Public Function Calcular(ByVal fecha1 As Date, fecha2 As Date) As Boolean 'Calculamos la multa si en caso regresa el carro despues de la fecha registrada
        _dias = (fecha2 - fecha1).TotalDays
        If _dias > 0 Then
            _total = _dias * _tasaMulta
            If Total > 0 Then
                Return 1
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function
    Public Function ChequearRenta(ByVal coche As clsCoches) As Boolean 'Chequeamos si hay una renta con el coche elegido
        If Conexion.contarFilas("SELECT * FROM rentas WHERE id_coche = '" & coche.ObtenerIdCoche & "' AND estado = 'Activa'") > 0 Then
            MsgBox("Error: Existe una Renta Activa de este coche")
            Return False
        Else
            Return True
        End If
    End Function
    Public Function ChequearReservaFecha(ByVal _fechaInicio As Date, ByVal _fechaFin As Date, ByVal _idCoche As Integer) As Boolean 'Verificamos si hay una reserva en las fechas elegidas para la renta
        If Conexion.contarFilas("SELECT * FROM `reservas` WHERE id_coche = " & _idCoche & " AND (" & _fechaInicio & " BETWEEN fecha_retiro AND fecha_devolucion) or (" & _fechaFin & " BETWEEN fecha_retiro AND fecha_devolucion) AND estado = 'Activa'") = 0 Then
            MsgBox("Error: Existe una reserva en dicho período de tiempo")
            Return False
        Else
            Return True
        End If
    End Function
    Public Function Reportes(ByVal tipo As String, ByRef dgv As DataGridView, Optional ByVal Fecha As Date = Nothing) 'Reportes de renta por mes
        If Conexion.contarFilas("SELECT * FROM rentas") = 0 Then
            Return False
        End If
        Dim consulta As String
        Dim reader As MySqlDataReader
        Dim j As Integer = 0
        Dim columnas() As String
        'Condicionales para elegir la consulta a realizar
        If tipo = "Agencia" Then
            If Fecha <> Nothing Then
                consulta = "SELECT a.nombre, a.direccion, a.telefono, COUNT(DISTINCT r.id_renta) AS num_rent FROM `rentas` r INNER JOIN agencias a ON r.id_agencia = a.id_agencia WHERE date_format(r.fecha_retiro, '%m-%Y') = '" & Fecha.ToString("MM-yyyy") & "'"
            Else
                consulta = "SELECT a.nombre, a.direccion, a.telefono, COUNT(DISTINCT r.id_renta) AS num_rent FROM `rentas` r INNER JOIN agencias a ON r.id_agencia = a.id_agencia"
            End If
            ReDim columnas(3)
            columnas(0) = "Nombre"
            columnas(1) = "Dirección"
            columnas(2) = "Telefono"
            columnas(3) = "N° Rentas"
        ElseIf tipo = "Agente" Then
            If Fecha <> Nothing Then
                consulta = "SELECT CONCAT_WS(', ', u.apellido, u.nombre), u.nombre_usuario, COUNT(DISTINCT r.id_renta) AS num_rent FROM rentas r INNER JOIN usuarios u ON r.id_usuario = u.id_usuario WHERE u.perfil = 'Gerente' AND date_format(r.fecha_retiro, '%m-%Y') = '" & Fecha.ToString("MM-yyyy") & "'"
            Else
                consulta = "SELECT CONCAT_WS(', ', u.apellido, u.nombre), u.nombre_usuario, COUNT(DISTINCT r.id_renta) AS num_rent FROM rentas r INNER JOIN usuarios u ON r.id_usuario = u.id_usuario WHERE u.perfil = 'Gerente'"
            End If
            ReDim columnas(2)
            columnas(0) = "Nombre"
            columnas(1) = "Nombre Usuaurio"
            columnas(2) = "N° Rentas"
        ElseIf tipo = "Auto" Then
            If Fecha <> Nothing Then
                consulta = "SELECT c.placa, c.tipo, COUNT(DISTINCT r.id_renta) AS num_rent FROM rentas r INNER JOIN coches c ON r.id_coche = c.id_coche WHERE date_format(r.fecha_retiro, '%m-%Y') = '" & Fecha.ToString("MM-yyyy") & "'"
            Else
                consulta = "SELECT c.placa, c.tipo, COUNT(DISTINCT r.id_renta) AS num_rent FROM rentas r INNER JOIN coches c ON r.id_coche = c.id_coche"
            End If
            ReDim columnas(2)
            columnas(0) = "Matrícula"
            columnas(1) = "Tipo"
            columnas(2) = "N° Rentas"
        End If

        If Conexion.contarFilas(consulta) > 0 Then 'Contamos la fila para ver si existen registros con los datos seleccionados
            Conexion.obtenerDatos(consulta, reader) 'Se extraen los datos
            dgv.ColumnCount = UBound(columnas, 1) + 1

            For i As Integer = 0 To (UBound(columnas, 1)) 'Se agregan las columnas
                dgv.Columns(i).Name = columnas(i)
            Next i
            dgv.RowCount = 1

            While reader.Read() 'Se recorren los resultados obtenidos
                With dgv
                    j = .RowCount
                    .Rows.Add()
                    For i As Integer = 0 To (UBound(columnas, 1))
                        .Rows(j - 1).Cells(i).Value = reader(i)
                    Next i
                End With
            End While
            reader.Close()
            Return True
        Else
            Return False
        End If
    End Function
    Public Function BuscarIndice(ByVal idReserva As String, ByVal listaRentas() As clsRentas) As Integer
        For i As Integer = 0 To UBound(listaRentas, 1) 'Se recorre la lista de objetos de tipo Reserva
            If listaRentas(i).ObtenerCodigoRenta() = idReserva.ToUpper Then 'Se verifica si el valor iterado es igual al parametro
                Return i 'Se regresa el indice de la lista del array
            End If
        Next
        Return -1
    End Function
End Class
