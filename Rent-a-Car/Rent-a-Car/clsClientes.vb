﻿Imports MySql.Data.MySqlClient
Public Class clsClientes
    'Atributos
    Private _IdCliente As String
    Private _Dui As String
    Private _Pasaporte As String
    Private _Nombre As String
    Private _Apellido As String
    Private _Direccion As String
    Private _Ciudad As String
    Private _Email As String
    Private _Pais As String
    Private _NombreUsuario As String
    Private _Telefono As String

    Private Conexion As clsConexion = New clsConexion() 'Tipo de atributo para la conexión a la BDD

    'Bandera
    Private _ReservaEstado As Boolean
    Public ReadOnly Property ObtenerIdCliente() As String
        Get
            Return _IdCliente
        End Get
    End Property
    Public ReadOnly Property ObtenerNombreCompleto() As String
        Get
            Return _Apellido & ", " & _Nombre
        End Get
    End Property
    Public ReadOnly Property ObtenerDui() As String
        Get
            Return _Dui
        End Get
    End Property
    Public ReadOnly Property ObtenerPasaporte() As String
        Get
            Return _Pasaporte
        End Get
    End Property
    Public ReadOnly Property ObtenerNombreDeUsuari() As String
        Get
            Return _NombreUsuario
        End Get
    End Property

    Public ReadOnly Property ObtenerTelefono() As String
        Get
            Return _Telefono
        End Get
    End Property
    Public ReadOnly Property ObetenerCorreoElectronico() As String
        Get
            Return _Email
        End Get
    End Property
    Public ReadOnly Property ObtenerDireccion() As String
        Get
            Return _Direccion
        End Get
    End Property
    Public ReadOnly Property ObtenerPais() As String
        Get
            Return _Pais
        End Get
    End Property
    Public ReadOnly Property ObtenerCiudad() As String
        Get
            Return _Ciudad
        End Get
    End Property
    Public WriteOnly Property EstablecerNombre() As String
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Public WriteOnly Property EstablecerApellido() As String
        Set(ByVal value As String)
            _Apellido = value
        End Set
    End Property
    Public WriteOnly Property EstablecerDui() As String
        Set(ByVal value As String)
            _Dui = value
        End Set
    End Property
    Public WriteOnly Property EstablecerPasaporte() As String
        Set(ByVal value As String)
            _Pasaporte = value
        End Set
    End Property
    Public WriteOnly Property EstablecerNombreUsuario() As String
        Set(ByVal value As String)
            _NombreUsuario = value
        End Set
    End Property
    Public WriteOnly Property EstablecerDireccion() As String
        Set(ByVal value As String)
            _Direccion = value
        End Set
    End Property
    Public WriteOnly Property EstablecerPais() As String
        Set(ByVal value As String)
            _Pais = value
        End Set
    End Property
    Public WriteOnly Property EstablecerCorreoElectronico() As String
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property
    Public WriteOnly Property EstablecerTelefono() As String
        Set(ByVal value As String)
            _Telefono = value
        End Set
    End Property
    Public WriteOnly Property EstablecerCiudad() As String
        Set(ByVal value As String)
            _Ciudad = value
        End Set
    End Property
    Public WriteOnly Property EstablecerIdCliente() As String
        Set(ByVal value As String)
            _IdCliente = value
        End Set
    End Property
    Public Function registrarDatos(ByVal dui As String, ByVal pasaporte As String, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal ciudad As String, ByVal email As String, ByVal pais As String, ByVal telefono As String) As Boolean
        _Telefono = telefono
        dui = dui.Trim
        pasaporte = pasaporte.Trim
        nombre = nombre.Trim
        apellido = apellido.Trim
        direccion = direccion.Trim
        ciudad = ciudad.Trim
        email = email.Trim
        pais = pais.Trim

        If dui.Length = 0 Then
            MsgBox("Ingrese su DUI!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Dui = dui
        End If

        If pasaporte.Length = 0 Then
            MsgBox("Ingrese su Pasaporte!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Pasaporte = pasaporte
        End If

        If nombre.Length = 0 Then
            MsgBox("Ingrese su Nombre!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Nombre = nombre
        End If

        If apellido.Length = 0 Then
            MsgBox("Ingrese su Apellido!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Apellido = apellido
        End If

        If direccion.Length = 0 Then
            MsgBox("Ingrese su Dirección!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Direccion = direccion
        End If

        If ciudad.Length = 0 Then
            MsgBox("Ingrese su Ciudad!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Ciudad = ciudad
        End If

        If email.Length = 0 Then
            MsgBox("Ingrese su Email!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Email = email
        End If

        If pais.Length = 0 Then
            MsgBox("Ingrese su País!", MsgBoxStyle.Critical, "Registro de Cliente")
            Return False
        Else
            _Pais = pais
        End If

        If MyClass.CrearCodigo() Then
            Return Conexion.modificarDatos("INSERT INTO clientes(nombre, apellido, dui, nombre_usuario, pasaporte, direccion, id_pais, correo_electronico, telefono, ciudad) VALUES('" & _Nombre & "', '" & _Apellido & "', '" & _Dui & "', '" & _NombreUsuario & "', '" & _Pasaporte & "', '" & _Direccion & "', '" & _Pais & "', '" & _Email & "', '" & _Telefono & "', '" & _Ciudad & "')")
        Else
            Return False
        End If
    End Function

    Private Function VerificarCodigoUsuario(ByVal _codigoUsuario As String) As Boolean
        Return Conexion.contarFilas("SELECT * FROM clientes WHERE nombre_usuario = '" & _codigoUsuario & "'")
    End Function
    Private Function CrearCodigo()
        Dim nombreUsuario As String = "CL"
        Dim rnd As New Random()
        Dim repetir As Boolean = True

        While repetir
            For i As Byte = 0 To 4 'Se crean los digitos aleatorios
                nombreUsuario += CStr(rnd.Next(0, 9))
            Next

            If Not MyClass.VerificarCodigoUsuario(nombreUsuario) Then
                _NombreUsuario = nombreUsuario 'Se guarda en el atributo
                repetir = False
                Return True
            End If
        End While
        Return 0
    End Function

    Public Sub listarDatos(ByRef listaClientes() As clsClientes, ByRef dgv As DataGridView)

        Dim i As Integer = 0
        Dim reader As MySqlDataReader
        Conexion.obtenerDatos("SELECT * FROM clientes", reader)

        'Se agrega las columnas al dgv
        dgv.ColumnCount = 5
        dgv.Columns(0).Name = "Nombre"
        dgv.Columns(1).Name = "Dui"
        dgv.Columns(2).Name = "Pasaporte"
        dgv.Columns(3).Name = "Nombre Usuario"
        dgv.Columns(4).Name = "Correo Electrónico"
        dgv.RowCount = 1

        While reader.Read()
            ReDim Preserve listaClientes(i)
            Clientes = New clsClientes 'Se crea una instancia de la clase para despues guardarla en  un array

            'Se guardan los atributos
            Clientes.EstablecerIdCliente = reader(0)
            Clientes.EstablecerNombre = reader(1)
            Clientes.EstablecerApellido = reader(2)
            Clientes.EstablecerDui = reader(3)
            Clientes.EstablecerNombreUsuario = reader(4)
            Clientes.EstablecerPasaporte = reader(5)
            Clientes.EstablecerDireccion = reader(6)
            Clientes.EstablecerPais = reader(7)
            Clientes.EstablecerCorreoElectronico = reader(8)
            Clientes.EstablecerTelefono = reader(9)
            Clientes.EstablecerCiudad = reader(10)

            listaClientes(i) = Clientes 'Se guarda la instancia de la clase en el array

            With dgv 'Se agregan en el dgv los datos
                i = .RowCount
                .Rows.Add()
                .Rows(i - 1).Cells(0).Value = listaClientes(i - 1).ObtenerNombreCompleto
                .Rows(i - 1).Cells(1).Value = listaClientes(i - 1).ObtenerDui
                .Rows(i - 1).Cells(2).Value = listaClientes(i - 1).ObtenerPasaporte
                .Rows(i - 1).Cells(3).Value = listaClientes(i - 1).ObtenerNombreDeUsuari
                .Rows(i - 1).Cells(4).Value = listaClientes(i - 1).ObetenerCorreoElectronico
            End With
            i += 1
        End While
        reader.Close()
    End Sub

    Public Function BuscarIndice(ByVal _codigoUsuario As String, ByRef listaClientes() As clsClientes)
        For i As Integer = 0 To UBound(listaClientes, 1)
            If listaClientes(i).ObtenerNombreDeUsuari = _codigoUsuario.ToUpper Then
                Return i
            End If
        Next
        Return -1
    End Function
End Class
