Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class clsRentas
    Private _idRenta As Integer
    Private _idCliente As Integer
    Private _idAgencia As Integer
    Private _idCoche As Integer
    Private _idUsuario As Integer
    Private _fechaRetiro As Date
    Private _fechaEntrega As Date
    Private _estado As String
    Private _precio As Decimal
    Private Conexion As clsConexion = New clsConexion()
    Private clsArchivo As clsFactura = New clsFactura()

    Public Sub New(Optional ByVal id As Integer = Nothing)
        If id <> Nothing Then
            'Función para obtener datos guardados en la BDD
        Else
            _estado = True
        End If
    End Sub

    Public ReadOnly Property idCliente
        Get
            Return _idCliente
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

    Public WriteOnly Property cambiarEstado() As Boolean
        Set(ByVal value As Boolean)
            _estado = value
        End Set
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
    Public ReadOnly Property ObtenerEstado() As String
        Get
            Return _estado
        End Get
    End Property
    Public WriteOnly Property EstablecerEstado() As String
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property
    Public ReadOnly Property ObtenerIdUsuario() As Integer
        Get
            Return _idUsuario
        End Get
    End Property
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

        If MyClass.ChequearReserva(cliente.ObtenerIdCliente) Then
            MyClass.EstablecerFechaInicio = CDate(_fechaInicio)
            MyClass.EstablecerFechaFin = CDate(_fechaFin)
            MyClass.EstablecerIdAgencia = _idAgencia
            MyClass.EstablecerIdCoche = coche.ObtenerIdCoche
            MyClass.EstablecerIdCliente = cliente.ObtenerIdCliente
            MyClass.EstablecerIdUsuario = Session.ObtenerIdUsuario

            If Conexion.modificarDatos("INSERT INTO rentas VALUES(" & "NULL" & ", " & idCliente & ", " & idAgencia & ", " & idCoche & ", " & Session.ObtenerIdUsuario & ", '" & _fechaInicio & "', '" & _fechaFin & "' ,'Activa')") Then
                clsArchivo.GenerarPDF(cliente, coche, _precio)
                Return True
            Else
                Return False
            End If
        Else
            MsgBox("Error: El usuario tiene una reserva activa")
            Return False
        End If
    End Function

    Public Function registrarRenta(ByVal idCliente As Integer, ByVal idAgencia As Integer, ByVal idCoche As Integer, ByVal idUsuario As Integer, ByVal fechaR As String, ByVal fechaD As String) As Boolean
        If Conexion.modificarDatos("INSERT INTO rentas VALUES(" & "NULL" & ", " & idCliente & ", " & idAgencia & ", " & idCoche & ", " & idUsuario & ", '" & fechaR & "', '" & fechaD & "' ,'Activa')") Then
            'clsArchivo.GenerarPDF()
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ReservaRealizada(ByVal reserva As clsReservas) As Boolean
        If Conexion.modificarDatos("UPDATE reservas SET estado = 'Realizada' WHERE id_reserva = '" & reserva.ObtenerCodigoReserva & "'") Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Function ChequearReserva(ByVal Optional indice As String = Nothing) As Boolean
        Dim i As Integer = 0
        Dim reader As MySqlDataReader
        Conexion.obtenerDatos("SELECT r.id_reserva, r.id_cliente, r.id_agencia, r.id_coche, r.id_usuario, r.fecha_retiro, r.fecha_devolucion, r.precio_pagar, r.estado, cl.nombre, cl.apellido, cl.nombre_usuario , c.placa FROM reservas r INNER JOIN clientes cl ON r.id_cliente = cl.id_cliente INNER JOIN coches c ON r.id_coche = c.id_coche WHERE r.estado = 'Activa'", reader)
        While reader.Read()
            MyClass.EstablecerIdCliente = reader(1)
            MyClass.EstablecerIdAgencia = reader(2)
            MyClass.EstablecerIdCoche = reader(3)
            MyClass.EstablecerFechaInicio = CDate(reader(5))
            MyClass.EstablecerFechaFin = CDate(reader(6))
            MyClass.EstablecerPrecio = reader(7)
        End While
        reader.Close()
        Return True
    End Function
    Public Function listarRentas(ByRef listaRentas() As clsRentas, ByRef dgv As DataGridView) As Boolean
        If Conexion.contarFilas("SELECT * FROM rentas WHERE estado = 'Activa'") = 0 Then
            Return 0
        Else
            Dim i As Integer = 0
            Dim reader As MySqlDataReader
            Conexion.obtenerDatos("SELECT r.id_renta, r.id_cliente, r.id_agencia, r.id_coche, r.id_usuario, r.fecha_retiro, r.fecha_devolucion, r.estado, cl.nombre, cl.apellido, cl.nombre_usuario , c.placa FROM rentas r INNER JOIN clientes cl ON r.id_cliente = cl.id_cliente INNER JOIN coches c ON r.id_coche = c.id_coche WHERE r.estado = 'Activa'", reader)

            dgv.ColumnCount = 5
            dgv.Columns(0).Name = "Cliente"
            dgv.Columns(1).Name = "Código Cliente"
            dgv.Columns(2).Name = "Matrícula Coche"
            dgv.Columns(3).Name = "Fecha Retiro"
            dgv.Columns(4).Name = "Fecha Devolución"
            dgv.RowCount = 1

            While reader.Read()
                ReDim Preserve listaRentas(i) 'Se ridemenciona el array de clase
                Rentas = New clsRentas 'Nuevo objeto de la clase

                'Se guardan los campos en los atributos
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
                    .Rows(i - 1).Cells(0).Value = reader(9) & ", " & reader(8)
                    .Rows(i - 1).Cells(1).Value = reader(10)
                    .Rows(i - 1).Cells(2).Value = reader(11)
                    .Rows(i - 1).Cells(3).Value = listaRentas(i - 1).getFechaRetiro.ToString("yyyy-MM-dd")
                    .Rows(i - 1).Cells(4).Value = listaRentas(i - 1).getFechadevo.ToString("yyyy-MM-dd")
                End With
            End While
            reader.Close()
            Return 1
        End If
    End Function

    Public Function Reportes(ByVal tipo As String, ByRef dgv As DataGridView, Optional ByVal Fecha As Date = Nothing)
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
                consulta = "SELECT a.nombre, a.direccion, a.telefono, COUNT(DISTINCT r.id_agencia) AS num_rent FROM `rentas` r INNER JOIN agencias a ON r.id_agencia = a.id_agencia WHERE date_format(r.fecha_retiro, '%m-%Y') = '" & Fecha.ToString("MM - yyyy") & "' AND a.nombre != NULL"
            Else
                consulta = "SELECT a.nombre, a.direccion, a.telefono, COUNT(DISTINCT r.id_agencia) AS num_rent FROM `rentas` r INNER JOIN agencias a ON r.id_agencia = a.id_agencia WHERE a.nombre != NULL"
            End If
            ReDim columnas(3)
            columnas(0) = "Nombre"
            columnas(1) = "Dirección"
            columnas(2) = "Telefono"
            columnas(3) = "N° Rentas"
        ElseIf tipo = "Agente" Then
            If Fecha <> Nothing Then
                consulta = "SELECT u.nombre, u.apellido, u.nombre_usuario, COUNT(DISTINCT r.id_agencia) AS num_rent FROM rentas r INNER JOIN usuarios u ON r.id_usuario = u.id_usuario WHERE u.perfil = 'Gerente' AND date_format(r.fecha_retiro, '%m-%Y') = '" & Fecha.ToString("MM - yyyy") & "' AND u.nombre != NULL"
            Else
                consulta = "SELECT u.nombre, u.apellido, u.nombre_usuario, COUNT(DISTINCT r.id_agencia) AS num_rent FROM rentas r INNER JOIN usuarios u ON r.id_usuario = u.id_usuario WHERE u.perfil = 'Gerente' WHERE u.nombre != NULL"
            End If
            ReDim columnas(2)
            columnas(0) = "Nombre"
            columnas(1) = "Nombre Usuaurio"
            columnas(2) = "N° Rentas"
        ElseIf tipo = "Auto" Then
            If Fecha <> Nothing Then
                consulta = "SELECT c.placa, c.tipo, COUNT(DISTINCT r.id_agencia) AS num_rent FROM rentas r INNER JOIN coches c ON r.id_coches = c.id_coche WHERE date_format(r.fecha_retiro, '%m-%Y') = '" & Fecha.ToString("MM - yyyy") & "' AND c.placa != NULL"
            Else
                consulta = "SELECT c.placa, c.tipo, COUNT(DISTINCT r.id_agencia) AS num_rent FROM rentas r INNER JOIN coches c ON r.id_coches = c.id_coche WHERE c.placa != NULL"
            End If
            ReDim columnas(2)
            columnas(0) = "Matrícula"
            columnas(1) = "Tipo"
            columnas(3) = "N° Rentas"
        End If

        If Conexion.contarFilas(consulta) > 0 Then 'Contamos la fila para ver si existen registros con los datos seleccionados
            Conexion.obtenerDatos(consulta, reader) 'Se extraen los datos
            dgv.ColumnCount = UBound(columnas, 1)

            For i As Integer = 0 To (UBound(columnas, 1) - 1) 'Se agregan las columnas
                dgv.Columns(i).Name = columnas(i)
            Next i
            dgv.RowCount = 1

            While reader.Read() 'Se recorren los resultados obtenidos
                j = dgv.RowCount
                For i As Integer = 0 To (UBound(columnas, 1) - 1)
                    dgv.Rows(j).Cells(i).Value = reader(i)
                Next i
                dgv.Rows.Add()
            End While
            reader.Close()
            Return True
        Else
            Return False
        End If
    End Function
End Class
