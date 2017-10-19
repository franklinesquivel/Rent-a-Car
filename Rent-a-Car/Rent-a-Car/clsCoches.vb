Imports MySql.Data.MySqlClient
Imports System.IO.Path
Imports System.Text.RegularExpressions
Public Class clsCoches
    '____________________________
    '|   Atributos de la clase   |
    '|___________________________|
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
    '______________________________
    '|   Constructor de la clase   |
    '|_____________________________|
    Public Sub New(Optional ByVal id As Integer = Nothing)
        If id <> Nothing Then
            'Función para obtener datos guardados en la BDD
            Dim dataReader As MySqlDataReader
            Conexion.obtenerDatos("SELECT * FROM coches WHERE id_coche = " & id & ";", dataReader)
            If dataReader.HasRows Then
                dataReader.Read()
                _idCoche = dataReader.GetInt32(0)
                _matricula = dataReader.GetString(1)
                _marca = dataReader.GetString(2)
                _modelo = dataReader.GetString(3)
                _color = dataReader.GetString(4)
                _kilometraje = CLng(dataReader.GetInt32(5))
                _nPasajeros = dataReader.GetInt32(6)
                _alquiler = CDbl(dataReader.GetInt32(7))
                _fotografia = dataReader.GetString(8)
                _tipo = dataReader.GetString(9)
                _estado = dataReader.GetString(10)
                _idAgencia = dataReader.GetInt32(11)
            End If
        Else
            _estado = "A"
        End If
    End Sub
    '_________________________________________
    '|   Propiedades de lectura de la clase   |
    '|________________________________________|
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
    '___________________________________________
    '|   Propiedades de escritura de la clase   |
    '|__________________________________________|
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
    '___________________________________
    '|   Metodos generales de la clase  |
    '|__________________________________|
    Public Sub LlenarDatosModificar(ByRef placa As String, ByRef marca As String, ByRef modelo As String, ByRef color As String, ByRef kilometraje As String, ByRef nPasajeros As String, ByRef alquiler As String, ByVal fotografia As Button, ByRef tipo As String, ByRef idAgencia As String, ByRef picFoto As PictureBox)
        'Función que nos sirve para obtener los datos del coche, con la finalidad de mostrarlo
        Dim reader As MySqlDataReader
        Dim resourcesPath = Application.StartupPath & DirectorySeparatorChar & ".." & DirectorySeparatorChar & ".." & DirectorySeparatorChar & "Resources" & DirectorySeparatorChar & "Coches" & DirectorySeparatorChar
        Dim auxId As Integer = 1
        placa = placa.Trim
        Conexion.obtenerDatos("SELECT marca,modelo,color,kilometraje,num_pasajeros,precio_alquiler,fotografia,tipo,id_agencia FROM coches WHERE placa = '" & placa & "'", reader)
        While reader.Read() 'Se abre la lectura
            marca = reader(0)
            modelo = reader(1)
            color = reader(2)
            kilometraje = reader(3)
            nPasajeros = reader(4)
            alquiler = reader(5)
            fotografia.Text = reader(6)
            tipo = reader(7)
            idAgencia = reader(8)
            picFoto.ImageLocation = resourcesPath + reader(6)
        End While
        reader.Close() 'Se cierra la lectura
    End Sub
    Public Function ModificarRenta(ByVal matricula As String, ByVal alquiler As Decimal, ByVal tipo As String) As Boolean
        matricula = matricula.Trim
        tipo = tipo.Trim

        If matricula.Length = 0 Then
            MsgBox("Ingrese una matrícula!", MsgBoxStyle.Critical, "Modificar Renta Coche")
            Return False
        ElseIf _noCoincide("^((O|CD|CC|MI|N|PNC|E|P|A|C|V|PR|T|RE|AB|MB|F|M|D)\d{3})((\s\d{3})|\d{3})$", matricula.ToUpper) Then
            MsgBox("Ingrese una matrícula válida!", MsgBoxStyle.Critical, "Modificar Renta Coche")
            Return False
        Else
            _matricula = matricula.ToUpper
        End If

        If alquiler <= 0 Then
            MsgBox("Ingrese un monto de alquiler válido!", MsgBoxStyle.Critical, "Modificar Renta Coche")
            Return False
        Else
            _alquiler = CDbl(Format(alquiler, "0.00"))
        End If
        If tipo.Length = 0 Then
            MsgBox("Ingrese un tipo de de coche!", MsgBoxStyle.Critical, "Modificar Renta Coche")
            Return False
        Else
            If tipo = "Activo" Then
                tipo = "A"
            ElseIf tipo = "Reparación" Then
                tipo = "R"
            End If
            _tipo = tipo
        End If
        'Se modifica el coche al pasar las validaciones
        Dim reader As MySqlDataReader
        Dim auxId As Integer = 1
        Dim coch As String
        Conexion.obtenerDatos("SELECT id_coche FROM coches WHERE placa = '" & _matricula & "'", reader)
        While reader.Read()
            coch = reader(0)
        End While
        reader.Close()
        Dim queryU As String = "UPDATE coches SET precio_alquiler = '" & _alquiler.ToString & "', estado = '" & _tipo & "' WHERE id_coche = '" & coch & "';"
        If Conexion.modificarDatos(queryU, auxId) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ModificarCoches(ByVal marca As String, ByVal modelo As String, ByVal color As String, ByVal kilometraje As Long, ByVal nPasajeros As Integer, ByVal alquiler As Decimal, ByVal fotografia As String, ByVal tipo As String, ByVal idAgencia As Integer) As Boolean
        Dim resourcesPath = Application.StartupPath & DirectorySeparatorChar & ".." & DirectorySeparatorChar & ".." & DirectorySeparatorChar & "Resources" & DirectorySeparatorChar & "Coches" & DirectorySeparatorChar

        marca = marca.Trim
        modelo = modelo.Trim
        color = color.Trim
        fotografia = fotografia.Trim
        tipo = tipo.Trim

        If marca.Length = 0 Then
            MsgBox("Ingrese una marca de coche!", MsgBoxStyle.Critical, "Modificar Coche")
            Return False
        Else
            _marca = marca
        End If

        If kilometraje < 0 Then
            MsgBox("Ingrese un kilometraje válido!", MsgBoxStyle.Critical, "Modificar Coche")
            Return False
        Else
            _kilometraje = kilometraje
        End If

        If nPasajeros <= 0 Then
            MsgBox("Ingrese una cantidad de pasajeros válida!", MsgBoxStyle.Critical, "Modificar Coche")
            Return False
        Else
            _nPasajeros = nPasajeros
        End If

        If alquiler <= 0 Then
            MsgBox("Ingrese un monto de alquiler válido!", MsgBoxStyle.Critical, "Modificar Coche")
            Return False
        Else
            _alquiler = CDbl(Format(alquiler, "0.00"))
        End If
        If tipo.Length = 0 Then
            MsgBox("Ingrese un tipo de de coche!", MsgBoxStyle.Critical, "Modificar Coche")
            Return False
        Else
            _tipo = tipo
        End If

        If modelo.Length = 0 Then
            MsgBox("Ingrese un modelo de coche!", MsgBoxStyle.Critical, "Modificar Coche")
            Return False
        Else
            _modelo = modelo
        End If

        If color.Length = 0 Then
            MsgBox("Ingrese un color de de coche!", MsgBoxStyle.Critical, "Modificar Coche")
            Return False
        Else
            _color = color
        End If

        If fotografia.Length = 0 Then
            MsgBox("Ingrese una fotografía!", MsgBoxStyle.Critical, "Modificar Coche")
            Return False
        ElseIf Not _rutaDeArchivoValida(fotografia) Then
            MsgBox("Ingrese una fotografía válida!", MsgBoxStyle.Critical, "Modificar Coche")
            Return False
        ElseIf Not _esImagen(fotografia) Then
            MsgBox("Ingrese archivo que sea una fotografía!", MsgBoxStyle.Critical, "Modificar Coche")
            Return False
        Else
            Dim auxfoto As String = Split(fotografia, DirectorySeparatorChar)(Split(fotografia, DirectorySeparatorChar).Length - 1)
            _fotografia = auxfoto
        End If

        If _buscarRegistro("agencias", "id_agencia", idAgencia.ToString) Then
            _idAgencia = idAgencia
        Else
            MsgBox("Seleccione una agencia que exista!", MsgBoxStyle.Critical, "Modificar Coche")
            Return False
        End If

        'Se modifica el coche al pasar las validaciones
        Dim reader As MySqlDataReader
        Dim auxId As Integer = 1
        Dim coch As String
        Conexion.obtenerDatos("SELECT id_coche FROM coches WHERE placa = '" & _matricula & "'", reader)
        While reader.Read()
            coch = reader(0)
        End While
        reader.Close()
        Dim queryU As String = "UPDATE coches SET marca = '" & _marca & "', modelo = '" & _modelo & "', color = '" & _color & "', kilometraje = '" & _kilometraje.ToString & "', num_pasajeros = '" & _nPasajeros.ToString & "', precio_alquiler = '" & _alquiler.ToString & "', fotografia = '" & _fotografia & "', tipo = '" & _tipo & "', estado = 'A', id_agencia = '" & _idAgencia & "' WHERE id_coche = '" & coch & "';"
        If Conexion.modificarDatos(queryU, auxId) Then
            'OBTENER ÍNDICE GUARDADO Y GUARDARLO EN _idCoche
            _idCoche = auxId
            Dim extension As String = Split(_fotografia, ".")(Split(_fotografia, ".").Length - 1)
            FileSystem.FileCopy(fotografia, Combine(resourcesPath, (_idCoche & "." & extension)))
            Conexion.modificarDatos("UPDATE coches SET fotografia = '" & (_idCoche & "." & extension) & "' WHERE id_coche = " & _idCoche)
            Return True
        Else
            Return False
        End If
    End Function
    Public Function registrarCoche(ByVal matricula As String, ByVal marca As String, ByVal modelo As String, ByVal color As String, ByVal kilometraje As Long, ByVal nPasajeros As Integer, ByVal alquiler As Decimal, ByVal fotografia As String, ByVal tipo As String, ByVal idAgencia As Integer) As Boolean
        Dim resourcesPath = Application.StartupPath & DirectorySeparatorChar & ".." & DirectorySeparatorChar & ".." & DirectorySeparatorChar & "Resources" & DirectorySeparatorChar & "Coches" & DirectorySeparatorChar

        matricula = matricula.Trim
        marca = marca.Trim
        modelo = modelo.Trim
        color = color.Trim
        fotografia = fotografia.Trim
        tipo = tipo.Trim

        If matricula.Length = 0 Then
            MsgBox("Ingrese una matrícula!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        ElseIf _noCoincide("^((O|CD|CC|MI|N|PNC|E|P|A|C|V|PR|T|RE|AB|MB|F|M|D)\d{3})((\s\d{3})|\d{3})$", matricula.ToUpper) Then
            MsgBox("Ingrese una matrícula válida!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        Else
            _matricula = matricula.ToUpper
        End If

        If marca.Length = 0 Then
            MsgBox("Ingrese una marca de coche!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        Else
            _marca = marca
        End If

        If kilometraje < 0 Then
            MsgBox("Ingrese un kilometraje válido!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        Else
            _kilometraje = kilometraje
        End If

        If nPasajeros <= 0 Then
            MsgBox("Ingrese una cantidad de pasajeros válida!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        Else
            _nPasajeros = nPasajeros
        End If

        If alquiler <= 0 Then
            MsgBox("Ingrese un monto de alquiler válido!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        Else
            _alquiler = CDbl(Format(alquiler, "0.00"))
        End If
        If tipo.Length = 0 Then
            MsgBox("Ingrese un tipo de de coche!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        Else
            _tipo = tipo
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
            Dim auxfoto As String = Split(fotografia, DirectorySeparatorChar)(Split(fotografia, DirectorySeparatorChar).Length - 1)
            _fotografia = auxfoto
        End If

        If _buscarRegistro("agencias", "id_agencia", idAgencia.ToString) Then
            _idAgencia = idAgencia
        Else
            MsgBox("Seleccione una agencia que exista!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        End If


        Dim consultaMatricula As String = "SELECT * FROM coches WHERE placa = '" & _matricula & "';"
        If Conexion.contarFilas(consultaMatricula) > 0 Then
            MsgBox("La matrícula del coche que deseas registrar ya existe!", MsgBoxStyle.Critical, "Registro de Coche")
            Return False
        End If

        'Insertar el coche en la BDD
        Dim query As String = "INSERT INTO coches VALUES(NULL, '" & _matricula & "', '" & _marca & "', '" & _modelo & "', '" & _color & "', '" & _kilometraje.ToString & "', '" & _nPasajeros.ToString & "', '" & _alquiler.ToString & "', '" & _fotografia & "', '" & _tipo & "', '" & _estado & "', '" & _idAgencia & "'); SELECT LAST_INSERT_ID()"
        Dim auxId As Integer = 1
        If Conexion.modificarDatos(query, auxId) Then
            'OBTENER ÍNDICE GUARDADO Y GUARDARLO EN _idCoche
            _idCoche = auxId
            Dim extension As String = Split(_fotografia, ".")(Split(_fotografia, ".").Length - 1)
            FileSystem.FileCopy(fotografia, Combine(resourcesPath, (_idCoche & "." & extension)))
            Conexion.modificarDatos("UPDATE coches SET fotografia = '" & (_idCoche & "." & extension) & "' WHERE id_coche = " & _idCoche)
            Return True
        Else
            Return False
        End If
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

    Public Function listarCoches(ByRef listaCoches() As clsCoches, ByRef dgv As DataGridView) As Boolean
        If Conexion.contarFilas("SELECT * FROM coches WHERE estado = 'A'") = 0 Then
            Return 0
        Else
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
                'i += 1
            End While
            reader.Close()
            Return 1
        End If
    End Function
    Public Function BuscarIndice(ByVal matriculaCoche As String, ByRef listaCoches() As clsCoches) As Integer 'Busca el indice de un array de tipo clsCoches
        'Verificamos el patrón
        If Not _noCoincide("^((O|CD|CC|MI|N|PNC|E|P|A|C|V|PR|T|RE|AB|MB|F|M|D)\d{3})((\s\d{3})|\d{3})$", matriculaCoche.ToUpper) Then
            For i As Integer = 0 To UBound(listaCoches, 1)
                If listaCoches(i).ObtenerMatricula = matriculaCoche.ToUpper Then
                    Return i
                End If
            Next
        End If
        Return -1 'No cumple la condición
    End Function
    Public Sub BuscarCoche(ByVal matriculaCoche As String, ByVal listaCoches() As clsCoches, ByRef dgv As DataGridView, ByVal Optional teclaBorrar As Boolean = False)
        Dim rgx_coche = New Regex("^" + matriculaCoche + "+")

        For i As Integer = 0 To UBound(listaCoches, 1)
            If Not rgx_coche.IsMatch(listaCoches(i).ObtenerMatricula) And Not teclaBorrar Then
                Dim r As Integer = 0
                For Each row As DataGridViewRow In dgv.Rows 'Filas
                    For Each cell As DataGridViewCell In row.Cells 'Columnas
                        If CStr(cell.Value) = listaCoches(i).ObtenerMatricula Then
                            dgv.Rows.RemoveAt(dgv.Rows(r).Index) 'Se remueven las filas
                        End If
                    Next 'Fin columnas
                    r += 1
                Next 'Fin filas
            Else
                dgv.ColumnCount = 5 'Se agrega las columnas al dgv
                dgv.Columns(0).Name = "Placa"
                dgv.Columns(1).Name = "Marca y Modelo"
                dgv.Columns(2).Name = "N° Pasajeros"
                dgv.Columns(3).Name = "Precio Alquiler ($)"
                dgv.Columns(4).Name = "Kilometraje"
                dgv.RowCount = 1
                For x As Integer = 0 To UBound(listaCoches, 1)
                    If rgx_coche.IsMatch(listaCoches(x).ObtenerMatricula) Then
                        With dgv 'Se agregan en el dgv los datos
                            Dim j As Integer = .RowCount
                            .Rows.Add()
                            .Rows(j - 1).Cells(0).Value = listaCoches(x).ObtenerMatricula
                            .Rows(j - 1).Cells(1).Value = listaCoches(x).ObtenerMarca & " - " & listaCoches(j - 1).ObtenerModelo
                            .Rows(j - 1).Cells(2).Value = listaCoches(x).ObtenerNPasajeros
                            .Rows(j - 1).Cells(3).Value = listaCoches(x).ObtenerPrecioAlquiler
                            .Rows(j - 1).Cells(4).Value = listaCoches(x).ObtenerKilometraje
                        End With
                    End If
                Next
            End If
        Next
    End Sub

    Public Sub opcionesBusquedaAutos(ByVal combo1 As ComboBox, ByVal combo2 As ComboBox)
        If combo1.SelectedItem.ToString = "Marca" Then
            If Conexion.contarFilas("SELECT marca FROM coches WHERE estado = 'A'") = 0 Then
                MsgBox("Error: No hay marcas registradas.")
            Else
                Conexion.llenarCombo(combo2, "SELECT id_coche, marca FROM coches WHERE estado = 'A'", 0, 1)
            End If
        ElseIf combo1.SelectedItem.ToString = "Modelo" Then
            If Conexion.contarFilas("SELECT modelo FROM coches WHERE estado = 'A'") = 0 Then
                MsgBox("Error: No hay marcas registradas.")
            Else
                Conexion.llenarCombo(combo2, "SELECT id_coche, modelo FROM coches WHERE estado = 'A'", 0, 1)

            End If
        ElseIf combo1.SelectedItem.ToString = "Num de pasajeros" Then
            If Conexion.contarFilas("SELECT num_pasajeros FROM coches WHERE estado = 'A'") = 0 Then
                MsgBox("Error: No hay marcas registradas.")
            Else
                Conexion.llenarCombo(combo2, "SELECT id_coche, num_pasajeros FROM coches WHERE estado = 'A'", 0, 1)

            End If
        ElseIf combo1.SelectedItem.ToString = "Costo de alquiler" Then
            If Conexion.contarFilas("SELECT precio_alquiler FROM coches WHERE estado = 'A'") = 0 Then
                MsgBox("Error: No hay marcas registradas.")
            Else
                Conexion.llenarCombo(combo2, "SELECT id_coche, precio_alquiler FROM coches WHERE estado = 'A'", 0, 1)
            End If
        ElseIf combo1.SelectedItem.ToString = "Tipo de auto" Then
            If Conexion.contarFilas("SELECT tipo FROM coches WHERE estado = 'A'") = 0 Then
                MsgBox("Error: No hay marcas registradas.")
            Else
                Conexion.llenarCombo(combo2, "SELECT id_coche, tipo FROM coches WHERE estado = 'A'", 0, 1)

            End If
        End If
    End Sub

    Public Sub modificarCochesDisponibles(ByRef dgv As DataGridView, ByVal cmb As ComboBox, ByVal cmb2 As ComboBox, ByRef listabusqueda() As clsCoches)
        Dim i As Integer = 0
        Dim reader As MySqlDataReader

        If cmb2.SelectedItem.ToString = "Marca" Then

            Conexion.obtenerDatos("SELECT * FROM coches WHERE estado = 'A' AND marca = '" & cortar(cmb.SelectedItem.ToString) & "'", reader)

            'Se agrega las columnas al dgv
            dgv.ColumnCount = 8
            dgv.Columns(0).Name = "Placa"
            dgv.Columns(1).Name = "Marca - Modelo"
            dgv.Columns(2).Name = "N° Pasajeros"
            dgv.Columns(3).Name = "Precio Alquiler ($)"
            dgv.Columns(4).Name = "Color"
            dgv.Columns(5).Name = "Agencia del coche"
            dgv.Columns(6).Name = "Kilometraje"
            dgv.Columns(7).Name = "Tipo de coche"
            dgv.RowCount = 1

            While reader.Read()

                ReDim Preserve listabusqueda(i)
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

                listabusqueda(i) = Coches 'Se guarda la instancia de la clase en el array

                With dgv 'Se agregan en el dgv los datos
                    i = .RowCount
                    .Rows.Add()
                    .Rows(i - 1).Cells(0).Value = listabusqueda(i - 1).ObtenerMatricula
                    .Rows(i - 1).Cells(1).Value = listabusqueda(i - 1).ObtenerMarca & " - " & listabusqueda(i - 1).ObtenerModelo
                    .Rows(i - 1).Cells(2).Value = listabusqueda(i - 1).ObtenerNPasajeros
                    .Rows(i - 1).Cells(3).Value = listabusqueda(i - 1).ObtenerPrecioAlquiler
                    .Rows(i - 1).Cells(4).Value = listabusqueda(i - 1).ObtenerColor
                    .Rows(i - 1).Cells(5).Value = listabusqueda(i - 1).ObtenerIdAgencia
                    .Rows(i - 1).Cells(6).Value = listabusqueda(i - 1).ObtenerKilometraje
                    .Rows(i - 1).Cells(7).Value = listabusqueda(i - 1).ObtenerTipo
                End With
                'i += 1
            End While
            reader.Close()

        ElseIf cmb2.SelectedItem.ToString = "Modelo" Then

            Conexion.obtenerDatos("SELECT * FROM coches WHERE estado = 'A' AND modelo = '" & cortar(cmb.SelectedItem.ToString) & "'", reader)

            'Se agrega las columnas al dgv
            dgv.ColumnCount = 8
            dgv.Columns(0).Name = "Placa"
            dgv.Columns(1).Name = "Marca - Modelo"
            dgv.Columns(2).Name = "N° Pasajeros"
            dgv.Columns(3).Name = "Precio Alquiler ($)"
            dgv.Columns(4).Name = "Color"
            dgv.Columns(5).Name = "Agencia del coche"
            dgv.Columns(6).Name = "Kilometraje"
            dgv.Columns(7).Name = "Tipo de coche"
            dgv.RowCount = 1

            While reader.Read()

                ReDim Preserve listabusqueda(i)
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

                listabusqueda(i) = Coches 'Se guarda la instancia de la clase en el array

                With dgv 'Se agregan en el dgv los datos
                    i = .RowCount
                    .Rows.Add()
                    .Rows(i - 1).Cells(0).Value = listabusqueda(i - 1).ObtenerMatricula
                    .Rows(i - 1).Cells(1).Value = listabusqueda(i - 1).ObtenerMarca & " - " & listabusqueda(i - 1).ObtenerModelo
                    .Rows(i - 1).Cells(2).Value = listabusqueda(i - 1).ObtenerNPasajeros
                    .Rows(i - 1).Cells(3).Value = listabusqueda(i - 1).ObtenerPrecioAlquiler
                    .Rows(i - 1).Cells(4).Value = listabusqueda(i - 1).ObtenerColor
                    .Rows(i - 1).Cells(5).Value = listabusqueda(i - 1).ObtenerIdAgencia
                    .Rows(i - 1).Cells(6).Value = listabusqueda(i - 1).ObtenerKilometraje
                    .Rows(i - 1).Cells(7).Value = listabusqueda(i - 1).ObtenerTipo
                End With
                'i += 1
            End While
            reader.Close()

        ElseIf cmb2.SelectedItem.ToString = "Num de pasajeros" Then

            Conexion.obtenerDatos("SELECT * FROM coches WHERE estado = 'A' AND num_pasajeros = '" & cortar(cmb.SelectedItem.ToString) & "'", reader)

            'Se agrega las columnas al dgv
            dgv.ColumnCount = 8
            dgv.Columns(0).Name = "Placa"
            dgv.Columns(1).Name = "Marca - Modelo"
            dgv.Columns(2).Name = "N° Pasajeros"
            dgv.Columns(3).Name = "Precio Alquiler ($)"
            dgv.Columns(4).Name = "Color"
            dgv.Columns(5).Name = "Agencia del coche"
            dgv.Columns(6).Name = "Kilometraje"
            dgv.Columns(7).Name = "Tipo de coche"
            dgv.RowCount = 1

            While reader.Read()

                ReDim Preserve listabusqueda(i)
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

                listabusqueda(i) = Coches 'Se guarda la instancia de la clase en el array

                With dgv 'Se agregan en el dgv los datos
                    i = .RowCount
                    .Rows.Add()
                    .Rows(i - 1).Cells(0).Value = listabusqueda(i - 1).ObtenerMatricula
                    .Rows(i - 1).Cells(1).Value = listabusqueda(i - 1).ObtenerMarca & " - " & listabusqueda(i - 1).ObtenerModelo
                    .Rows(i - 1).Cells(2).Value = listabusqueda(i - 1).ObtenerNPasajeros
                    .Rows(i - 1).Cells(3).Value = listabusqueda(i - 1).ObtenerPrecioAlquiler
                    .Rows(i - 1).Cells(4).Value = listabusqueda(i - 1).ObtenerColor
                    .Rows(i - 1).Cells(5).Value = listabusqueda(i - 1).ObtenerIdAgencia
                    .Rows(i - 1).Cells(6).Value = listabusqueda(i - 1).ObtenerKilometraje
                    .Rows(i - 1).Cells(7).Value = listabusqueda(i - 1).ObtenerTipo
                End With
                'i += 1
            End While
            reader.Close()

        ElseIf cmb2.SelectedItem.ToString = "Costo de alquiler" Then
            Conexion.obtenerDatos("SELECT * FROM coches WHERE estado = 'A' AND precio_alquiler = '" & cortar(cmb.SelectedItem.ToString) & "'", reader)

            'Se agrega las columnas al dgv
            dgv.ColumnCount = 8
            dgv.Columns(0).Name = "Placa"
            dgv.Columns(1).Name = "Marca - Modelo"
            dgv.Columns(2).Name = "N° Pasajeros"
            dgv.Columns(3).Name = "Precio Alquiler ($)"
            dgv.Columns(4).Name = "Color"
            dgv.Columns(5).Name = "Agencia del coche"
            dgv.Columns(6).Name = "Kilometraje"
            dgv.Columns(7).Name = "Tipo de coche"
            dgv.RowCount = 1

            While reader.Read()

                ReDim Preserve listabusqueda(i)
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

                listabusqueda(i) = Coches 'Se guarda la instancia de la clase en el array

                With dgv 'Se agregan en el dgv los datos
                    i = .RowCount
                    .Rows.Add()
                    .Rows(i - 1).Cells(0).Value = listabusqueda(i - 1).ObtenerMatricula
                    .Rows(i - 1).Cells(1).Value = listabusqueda(i - 1).ObtenerMarca & " - " & listabusqueda(i - 1).ObtenerModelo
                    .Rows(i - 1).Cells(2).Value = listabusqueda(i - 1).ObtenerNPasajeros
                    .Rows(i - 1).Cells(3).Value = listabusqueda(i - 1).ObtenerPrecioAlquiler
                    .Rows(i - 1).Cells(4).Value = listabusqueda(i - 1).ObtenerColor
                    .Rows(i - 1).Cells(5).Value = listabusqueda(i - 1).ObtenerIdAgencia
                    .Rows(i - 1).Cells(6).Value = listabusqueda(i - 1).ObtenerKilometraje
                    .Rows(i - 1).Cells(7).Value = listabusqueda(i - 1).ObtenerTipo
                End With
                'i += 1
            End While
            reader.Close()


        ElseIf cmb2.SelectedItem.ToString = "Tipo de auto" Then

            Conexion.obtenerDatos("SELECT * FROM coches WHERE estado = 'A' AND tipo = '" & cortar(cmb.SelectedItem.ToString) & "'", reader)

            'Se agrega las columnas al dgv
            dgv.ColumnCount = 8
            dgv.Columns(0).Name = "Placa"
            dgv.Columns(1).Name = "Marca - Modelo"
            dgv.Columns(2).Name = "N° Pasajeros"
            dgv.Columns(3).Name = "Precio Alquiler ($)"
            dgv.Columns(4).Name = "Color"
            dgv.Columns(5).Name = "Agencia del coche"
            dgv.Columns(6).Name = "Kilometraje"
            dgv.Columns(7).Name = "Tipo de coche"
            dgv.RowCount = 1

            While reader.Read()

                ReDim Preserve listabusqueda(i)
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

                listabusqueda(i) = Coches 'Se guarda la instancia de la clase en el array

                With dgv 'Se agregan en el dgv los datos
                    i = .RowCount
                    .Rows.Add()
                    .Rows(i - 1).Cells(0).Value = listabusqueda(i - 1).ObtenerMatricula
                    .Rows(i - 1).Cells(1).Value = listabusqueda(i - 1).ObtenerMarca & " - " & listabusqueda(i - 1).ObtenerModelo
                    .Rows(i - 1).Cells(2).Value = listabusqueda(i - 1).ObtenerNPasajeros
                    .Rows(i - 1).Cells(3).Value = listabusqueda(i - 1).ObtenerPrecioAlquiler
                    .Rows(i - 1).Cells(4).Value = listabusqueda(i - 1).ObtenerColor
                    .Rows(i - 1).Cells(5).Value = listabusqueda(i - 1).ObtenerIdAgencia
                    .Rows(i - 1).Cells(6).Value = listabusqueda(i - 1).ObtenerKilometraje
                    .Rows(i - 1).Cells(7).Value = listabusqueda(i - 1).ObtenerTipo
                End With
                'i += 1
            End While
            reader.Close()
        End If
    End Sub
    Public Sub mostrarDisponibles(ByRef dgv As DataGridView, ByVal cmb As ComboBox, ByVal cmb2 As ComboBox, ByRef listabusqueda() As clsCoches)
        Dim i As Integer = 0
        Dim reader As MySqlDataReader

        If cmb2.SelectedItem.ToString = "Marca" Then

            Conexion.obtenerDatos("SELECT * FROM coches WHERE estado = 'A' AND marca = '" & cortar(cmb.SelectedItem.ToString) & "'", reader)

            'Se agrega las columnas al dgv
            dgv.ColumnCount = 5
            dgv.Columns(0).Name = "Placa"
            dgv.Columns(1).Name = "Marca - Modelo"
            dgv.Columns(2).Name = "N° Pasajeros"
            dgv.Columns(3).Name = "Precio Alquiler ($)"
            dgv.Columns(4).Name = "Kilometraje"
            dgv.RowCount = 1

            While reader.Read()

                ReDim Preserve listabusqueda(i)
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

                listabusqueda(i) = Coches 'Se guarda la instancia de la clase en el array

                With dgv 'Se agregan en el dgv los datos
                    i = .RowCount
                    .Rows.Add()
                    .Rows(i - 1).Cells(0).Value = listabusqueda(i - 1).ObtenerMatricula
                    .Rows(i - 1).Cells(1).Value = listabusqueda(i - 1).ObtenerMarca & " - " & listabusqueda(i - 1).ObtenerModelo
                    .Rows(i - 1).Cells(2).Value = listabusqueda(i - 1).ObtenerNPasajeros
                    .Rows(i - 1).Cells(3).Value = listabusqueda(i - 1).ObtenerPrecioAlquiler
                    .Rows(i - 1).Cells(4).Value = listabusqueda(i - 1).ObtenerKilometraje
                End With
                'i += 1
            End While
            reader.Close()

        ElseIf cmb2.SelectedItem.ToString = "Modelo" Then

            Conexion.obtenerDatos("SELECT * FROM coches WHERE estado = 'A' AND modelo = '" & cortar(cmb.SelectedItem.ToString) & "'", reader)

            'Se agrega las columnas al dgv
            dgv.ColumnCount = 5
            dgv.Columns(0).Name = "Placa"
            dgv.Columns(1).Name = "Marca - Modelo"
            dgv.Columns(2).Name = "N° Pasajeros"
            dgv.Columns(3).Name = "Precio Alquiler ($)"
            dgv.Columns(4).Name = "Kilometraje"
            dgv.RowCount = 1

            While reader.Read()

                ReDim Preserve listabusqueda(i)
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

                listabusqueda(i) = Coches 'Se guarda la instancia de la clase en el array

                With dgv 'Se agregan en el dgv los datos
                    i = .RowCount
                    .Rows.Add()
                    .Rows(i - 1).Cells(0).Value = listabusqueda(i - 1).ObtenerMatricula
                    .Rows(i - 1).Cells(1).Value = listabusqueda(i - 1).ObtenerMarca & " - " & listabusqueda(i - 1).ObtenerModelo
                    .Rows(i - 1).Cells(2).Value = listabusqueda(i - 1).ObtenerNPasajeros
                    .Rows(i - 1).Cells(3).Value = listabusqueda(i - 1).ObtenerPrecioAlquiler
                    .Rows(i - 1).Cells(4).Value = listabusqueda(i - 1).ObtenerKilometraje
                End With
                'i += 1
            End While
            reader.Close()

        ElseIf cmb2.SelectedItem.ToString = "Num de pasajeros" Then

            Conexion.obtenerDatos("SELECT * FROM coches WHERE estado = 'A' AND num_pasajeros = '" & cortar(cmb.SelectedItem.ToString) & "'", reader)

            'Se agrega las columnas al dgv
            dgv.ColumnCount = 5
            dgv.Columns(0).Name = "Placa"
            dgv.Columns(1).Name = "Marca - Modelo"
            dgv.Columns(2).Name = "N° Pasajeros"
            dgv.Columns(3).Name = "Precio Alquiler ($)"
            dgv.Columns(4).Name = "Kilometraje"
            dgv.RowCount = 1

            While reader.Read()

                ReDim Preserve listabusqueda(i)
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

                listabusqueda(i) = Coches 'Se guarda la instancia de la clase en el array

                With dgv 'Se agregan en el dgv los datos
                    i = .RowCount
                    .Rows.Add()
                    .Rows(i - 1).Cells(0).Value = listabusqueda(i - 1).ObtenerMatricula
                    .Rows(i - 1).Cells(1).Value = listabusqueda(i - 1).ObtenerMarca & " - " & listabusqueda(i - 1).ObtenerModelo
                    .Rows(i - 1).Cells(2).Value = listabusqueda(i - 1).ObtenerNPasajeros
                    .Rows(i - 1).Cells(3).Value = listabusqueda(i - 1).ObtenerPrecioAlquiler
                    .Rows(i - 1).Cells(4).Value = listabusqueda(i - 1).ObtenerKilometraje
                End With
                'i += 1
            End While
            reader.Close()

        ElseIf cmb2.SelectedItem.ToString = "Costo de alquiler" Then
            Conexion.obtenerDatos("SELECT * FROM coches WHERE estado = 'A' AND precio_alquiler = '" & cortar(cmb.SelectedItem.ToString) & "'", reader)

            'Se agrega las columnas al dgv
            dgv.ColumnCount = 5
            dgv.Columns(0).Name = "Placa"
            dgv.Columns(1).Name = "Marca - Modelo"
            dgv.Columns(2).Name = "N° Pasajeros"
            dgv.Columns(3).Name = "Precio Alquiler ($)"
            dgv.Columns(4).Name = "Kilometraje"
            dgv.RowCount = 1

            While reader.Read()

                ReDim Preserve listabusqueda(i)
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

                listabusqueda(i) = Coches 'Se guarda la instancia de la clase en el array

                With dgv 'Se agregan en el dgv los datos
                    i = .RowCount
                    .Rows.Add()
                    .Rows(i - 1).Cells(0).Value = listabusqueda(i - 1).ObtenerMatricula
                    .Rows(i - 1).Cells(1).Value = listabusqueda(i - 1).ObtenerMarca & " - " & listabusqueda(i - 1).ObtenerModelo
                    .Rows(i - 1).Cells(2).Value = listabusqueda(i - 1).ObtenerNPasajeros
                    .Rows(i - 1).Cells(3).Value = listabusqueda(i - 1).ObtenerPrecioAlquiler
                    .Rows(i - 1).Cells(4).Value = listabusqueda(i - 1).ObtenerKilometraje
                End With
                'i += 1
            End While
            reader.Close()


        ElseIf cmb2.SelectedItem.ToString = "Tipo de auto" Then

            Conexion.obtenerDatos("SELECT * FROM coches WHERE estado = 'A' AND tipo = '" & cortar(cmb.SelectedItem.ToString) & "'", reader)

            'Se agrega las columnas al dgv
            dgv.ColumnCount = 5
            dgv.Columns(0).Name = "Placa"
            dgv.Columns(1).Name = "Marca - Modelo"
            dgv.Columns(2).Name = "N° Pasajeros"
            dgv.Columns(3).Name = "Precio Alquiler ($)"
            dgv.Columns(4).Name = "Kilometraje"
            dgv.RowCount = 1

            While reader.Read()

                ReDim Preserve listabusqueda(i)
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

                listabusqueda(i) = Coches 'Se guarda la instancia de la clase en el array

                With dgv 'Se agregan en el dgv los datos
                    i = .RowCount
                    .Rows.Add()
                    .Rows(i - 1).Cells(0).Value = listabusqueda(i - 1).ObtenerMatricula
                    .Rows(i - 1).Cells(1).Value = listabusqueda(i - 1).ObtenerMarca & " - " & listabusqueda(i - 1).ObtenerModelo
                    .Rows(i - 1).Cells(2).Value = listabusqueda(i - 1).ObtenerNPasajeros
                    .Rows(i - 1).Cells(3).Value = listabusqueda(i - 1).ObtenerPrecioAlquiler
                    .Rows(i - 1).Cells(4).Value = listabusqueda(i - 1).ObtenerKilometraje
                End With
                'i += 1
            End While
            reader.Close()

        End If
    End Sub

    Public Function cortar(ByVal con As String)
        Dim i As Integer = 0
        For Each x As String In con
            i += 1
            If (x = ",") Then
                con = con.Substring(i + 1, con.Length - i - 2)
            End If
        Next
        Return con
    End Function

    Public Function Reporte(ByVal matriculaCoche As String, ByRef dgv As DataGridView) As Boolean 'Reporte de coches rentados
        If Conexion.contarFilas("SELECT * FROM rentas") = 0 Then
            Return 0
        Else
            Dim reader As MySqlDataReader
            Dim i As Integer = 0
            Conexion.obtenerDatos("SELECT GROUP_CONCAT(r.id_renta SEPARATOR ', '), CONCAT_WS(', ', cl.apellido, cl.nombre), c.placa, c.marca, c.modelo FROM `rentas` r INNER JOIN clientes cl ON cl.id_cliente = r.id_cliente INNER JOIN coches c ON c.id_coche = r.id_coche WHERE c.placa LIKE '" & matriculaCoche & "%' GROUP BY c.placa ORDER BY c.placa", reader)
            dgv.ColumnCount = 5
            dgv.Columns(0).Name = "id´s renta"
            dgv.Columns(1).Name = "Nombre Cliente"
            dgv.Columns(2).Name = "Matricula de Coche"
            dgv.Columns(3).Name = "Marca"
            dgv.Columns(4).Name = "Modelo"
            dgv.RowCount = 1
            While reader.Read()
                With dgv
                    i = .RowCount
                    .Rows.Add()
                    .Rows(i - 1).Cells(0).Value = reader(0)
                    .Rows(i - 1).Cells(1).Value = reader(1)
                    .Rows(i - 1).Cells(2).Value = reader(2)
                    .Rows(i - 1).Cells(3).Value = reader(3)
                    .Rows(i - 1).Cells(4).Value = reader(4)
                End With
            End While
            Return 1
        End If
    End Function
End Class
