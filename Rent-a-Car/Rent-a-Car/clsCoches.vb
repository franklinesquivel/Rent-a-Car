Imports MySql.Data.MySqlClient
Public Class clsCoches
    Private _idCoche As Integer
    Private _matricula As String
    Private _marca As String
    Private _modelo As String
    Private _color As String
    Private _kilometraje As Long
    Private _nPasajeros As Integer
    Private _alquiler As Decimal
    Private _fotografia As String
    Private _tipo As String
    Private _idAgencia As Integer
    Private _estado As String

    Private Conexion As clsConexion = New clsConexion()
    Public Sub New(Optional ByVal id As Integer = Nothing)
        If id <> Nothing Then
            'Función para obtener datos guardados en la BDD
        Else
            _estado = "A"
        End If
    End Sub
    'Getters
    Public ReadOnly Property ObtenerIdCoche() As String
        Get
            Return _idCoche
        End Get
    End Property
    Public ReadOnly Property id
        Get
            Return _idCoche
        End Get
    End Property

    Public ReadOnly Property ObtenerMatricula() As String
        Get
            Return _matricula
        End Get
    End Property
    Public ReadOnly Property ObtenerMarca() As String
        Get
            Return _marca
        End Get
    End Property
    Public ReadOnly Property ObtenerModelo() As String
        Get
            Return _modelo
        End Get
    End Property
    Public ReadOnly Property ObtenerColor() As String
        Get
            Return _color
        End Get
    End Property
    Public ReadOnly Property ObtenerKilometraje() As String
        Get
            Return _kilometraje
        End Get
    End Property
    Public ReadOnly Property ObtenerNPasajeros() As String
        Get
            Return _nPasajeros
        End Get
    End Property
    Public ReadOnly Property ObtenerPrecioAlquiler() As String
        Get
            Return _alquiler
        End Get
    End Property
    Public ReadOnly Property ObtenerFotografia() As String
        Get
            Return _fotografia
        End Get
    End Property
    Public ReadOnly Property ObtenerTipo() As String
        Get
            Return _tipo
        End Get
    End Property
    Public ReadOnly Property ObtenerEstado() As String
        Get
            Return _estado
        End Get
    End Property
    Public ReadOnly Property ObtenerIdAgencia() As String
        Get
            Return _idAgencia
        End Get
    End Property
    'Setters
    Public WriteOnly Property EstablecerMatricula() As String
        Set(ByVal value As String)
            _matricula = value
        End Set
    End Property
    Public WriteOnly Property EstablecerMarca() As String
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property
    Public WriteOnly Property EstablecerColor() As String
        Set(ByVal value As String)
            _color = value
        End Set
    End Property
    Public WriteOnly Property EstablecerModelo() As String
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property
    Public WriteOnly Property EstablecerKilometraje() As String
        Set(ByVal value As String)
            _kilometraje = value
        End Set
    End Property
    Public WriteOnly Property EstablecerNPasajeros() As String
        Set(ByVal value As String)
            _nPasajeros = value
        End Set
    End Property
    Public WriteOnly Property EstablecerPrecioAlquiler() As String
        Set(ByVal value As String)
            _alquiler = value
        End Set
    End Property
    Public WriteOnly Property EstablecerFotografia() As String
        Set(ByVal value As String)
            _fotografia = value
        End Set
    End Property
    Public WriteOnly Property EstablecerTipo() As String
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property
    Public WriteOnly Property EstablecerEstado() As String
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property
    Public WriteOnly Property EstablecerIdAgencia() As String
        Set(ByVal value As String)
            _idAgencia = value
        End Set
    End Property
    Public WriteOnly Property EstablecerIdCoche() As String
        Set(ByVal value As String)
            _idCoche = value
        End Set
    End Property
    'Métodos
    Public Function registrarCoche(ByVal matricula As String, ByVal marca As String, ByVal modelo As String, ByVal color As String, ByVal kilometraje As Long, ByVal nPasajeros As Integer, ByVal alquiler As Decimal, ByVal fotografia As String, ByVal tipo As String, ByVal idAgencia As Integer) As Boolean
        matricula = matricula.Trim
        marca = marca.Trim
        modelo = modelo.Trim
        color = color.Trim
        fotografia = fotografia.Trim
        tipo = tipo.Trim

        If matricula.Length = 0 Then
            MsgBox("Ingrese una matrícula!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        Else
            _matricula = matricula
        End If

        If marca.Length = 0 Then
            MsgBox("Ingrese una marca de coche!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        Else
            _marca = marca
        End If

        If modelo.Length = 0 Then
            MsgBox("Ingrese un modelo de coche!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        Else
            _modelo = modelo
        End If

        If color.Length = 0 Then
            MsgBox("Ingrese un color de de coche!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        Else
            _color = color
        End If

        If fotografia.Length = 0 Then
            MsgBox("Ingrese una fotografía!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        ElseIf Not _rutaDeArchivoValida(fotografia) Then
            MsgBox("Ingrese una fotografía válida!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        ElseIf Not _esImagen(fotografia) Then
            MsgBox("Ingrese archivo que sea una fotografía!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        Else
            _fotografia = fotografia
        End If

        If tipo.Length = 0 Then
            MsgBox("Ingrese un tipo de de coche!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        Else
            _tipo = tipo
        End If

        If kilometraje < 0 Then
            MsgBox("Ingrese un kilometraje válido!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        Else
            _kilometraje = kilometraje
        End If

        If alquiler <= 0 Then
            MsgBox("Ingrese un monto de alquiler válido!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        Else
            _alquiler = CDbl(Format(alquiler, "0.00"))
        End If

        If nPasajeros <= 0 Then
            MsgBox("Ingrese una cantidad de pasajeros válida!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        Else
            _nPasajeros = nPasajeros
        End If

        If _buscarRegistro("agencias", "id_agencia", idAgencia.ToString) Then
            _idAgencia = idAgencia
        Else
            MsgBox("Seleccione una agencia que exista!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        End If
        Return True
        'Insertar el coche en la BDD
        'Dim query As String = "INSERT INTO coches VALUES(NULL, '" & _matricula & "', '" & _marca & "', '" & _modelo & "', '" & _color & "', '" & _kilometraje.ToString & "', '" & _nPasajeros.ToString & "', '" & _alquiler.ToString & "', '" & _fotografia & "', '" & _tipo & "', '" & _idAgencia & "', '" & _estado & "');"

        'OBTENER ÍNDICE GUARDADO Y GUARDARLO EN _idCoche

    End Function

    Public Sub obtenerDatos(ByRef matricula As String, ByRef marca As String, ByRef modelo As String, ByRef color As String, ByRef kilometraje As Long, ByRef nPasajeros As Integer, ByRef alquiler As Decimal, ByRef fotografia As String, ByRef tipo As String, ByRef idAgencia As Integer)
        matricula = _matricula
        marca = _marca
        modelo = _modelo
        color = _color
        kilometraje = _kilometraje
        nPasajeros = _nPasajeros
        alquiler = _alquiler
        fotografia = _fotografia
        tipo = _tipo
        idAgencia = _idAgencia
    End Sub

    Public Sub listarCoches(ByRef listaCoches() As clsCoches, ByRef dgv As DataGridView)
        Dim i As Integer = 0
        Dim reader As MySqlDataReader
        Conexion.obtenerDatos("SELECT * FROM coches WHERE estado = 'A'", reader)

        'Se agrega las columnas al dgv
        dgv.ColumnCount = 5
        dgv.Columns(0).Name = "Placa"
        dgv.Columns(1).Name = "Marca y Modelo"
        dgv.Columns(2).Name = "N° Pasajeros"
        dgv.Columns(3).Name = "Precio Alquiler ($)"
        dgv.Columns(4).Name = "Kilometraje"
        dgv.RowCount = 1

        While reader.Read()
            ReDim Preserve listaCoches(i)
            Coches = New clsCoches 'Se crea una instancia de la clase para despues guardarla en  un array

            'Se guardan los atributos
            Coches.EstablecerIdCoche = reader(0)
            Coches.EstablecerMatricula = reader(1)
            Coches.EstablecerMarca = reader(2)
            Coches.EstablecerModelo = reader(3)
            Coches.EstablecerColor = reader(4)
            Coches.EstablecerKilometraje = reader(5)
            Coches.EstablecerNPasajeros = reader(6)
            Coches.EstablecerPrecioAlquiler = reader(7)
            Coches.EstablecerFotografia = reader(8)
            Coches.EstablecerTipo = reader(9)
            Coches.EstablecerEstado = reader(10)
            Coches.EstablecerIdAgencia = reader(11)

            listaCoches(i) = Coches 'Se guarda la instancia de la clase en el array

            With dgv 'Se agregan en el dgv los datos
                i = .RowCount
                .Rows.Add()
                .Rows(i - 1).Cells(0).Value = listaCoches(i - 1).ObtenerMatricula
                .Rows(i - 1).Cells(1).Value = listaCoches(i - 1).ObtenerMarca & " - " & listaCoches(i - 1).ObtenerModelo
                .Rows(i - 1).Cells(2).Value = listaCoches(i - 1).ObtenerNPasajeros
                .Rows(i - 1).Cells(3).Value = listaCoches(i - 1).ObtenerPrecioAlquiler
                .Rows(i - 1).Cells(4).Value = listaCoches(i - 1).ObtenerKilometraje
            End With
            i += 1
        End While
        reader.Close()
    End Sub
    Public Function BuscarIndice(ByVal matriculaCoche As String, ByRef listaClientes() As clsCoches)
        For i As Integer = 0 To UBound(listaClientes, 1)
            If listaClientes(i).ObtenerMatricula = matriculaCoche.ToUpper Then
                Return i
            End If
        Next
        Return -1
    End Function
End Class
