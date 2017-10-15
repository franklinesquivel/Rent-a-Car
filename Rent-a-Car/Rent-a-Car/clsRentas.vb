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
End Class
