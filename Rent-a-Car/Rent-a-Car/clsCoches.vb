Imports System.IO
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
    Private _estado As Boolean

    Public Sub New(Optional ByVal id As Integer = Nothing)
        If id <> Nothing Then
            'Función para obtener datos guardados en la BDD
        Else
            _estado = True
        End If
    End Sub

    Public ReadOnly Property id
        Get
            Return _idCoche
        End Get
    End Property

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
End Class
