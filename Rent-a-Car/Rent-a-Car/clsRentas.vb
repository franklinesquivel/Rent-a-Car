Imports MySql.Data.MySqlClient
Public Class clsRentas
    Private _idRenta As Integer
    Private _idCliente As Integer
    Private _idAgencia As Integer
    Private _idCoche As Integer
    Private _idUsuario As Integer
    Private _fechaRetiro As Date
    Private _fechaEntrega As Date
    Private _estado As Boolean
    Private Conexion As clsConexion = New clsConexion()

    Public Sub New(Optional ByVal id As Integer = Nothing)
        If id <> Nothing Then
            'Función para obtener datos guardados en la BDD
        Else
            _estado = True
        End If
    End Sub

    Public ReadOnly Property id
        Get
            Return _idRenta
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
    Public ReadOnly Property getFechaRetiro
        Get
            Return _fechaRetiro
        End Get
    End Property


    Public Function registrarRenta(ByVal idCliente As Integer, ByVal idAgencia As Integer, ByVal idCoche As Integer, ByVal idUsuario As Integer, ByVal fechaR As Date, ByVal fechaD As Date) As Boolean
        If Conexion.modificarDatos("INSERT INTO reservas VALUES('" & idCliente & ", " & idAgencia & ", " & idCoche & ", " & idUsuario & ", '" & fechaR & "', '" & fechaD & "', " & " ,'Activa')") Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub obtenerDatos(ByRef idCliente As Integer, ByRef idAgencia As Integer, ByRef idCoche As Integer, ByRef idUsuario As String, ByRef fechaRetiro As Date, ByRef fechaEntrega As Date)
        idCliente = _idCliente
        idAgencia = _idAgencia
        idCoche = _idCoche
        idUsuario = _idUsuario
        fechaRetiro = _fechaRetiro
        fechaEntrega = _fechaEntrega
    End Sub
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
