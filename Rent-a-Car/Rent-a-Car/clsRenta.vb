Public Class clsRenta
    Private _idRenta As Integer
    Private _idCliente As Integer
    Private _idAgencia As Integer
    Private _idCoche As Integer
    Private _idUsuario As Integer
    Private _fechaRetiro As Date
    Private _fechaEntrega As Date
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
            Return _idRenta
        End Get
    End Property

    Public Function registrarRenta(ByVal idCliente As Integer, ByVal idAgencia As Integer, ByVal idCoche As Integer, ByVal idUsuario As String, ByVal fechaRetiro As Date, ByVal fechaEntrega As Date) As Boolean
        If _buscarRegistro("clientes", "id_cliente", idCliente) Then
            _idCliente = idCliente
        Else
            MsgBox("Seleccione un cliente existiente!", MsgBoxStyle.Critical, "Registro de Renta de Coche")
            Return False
        End If

        If _buscarRegistro("agencias", "id_agencia", idAgencia) Then
            _idAgencia = idAgencia
        Else
            MsgBox("Seleccione una agencia existiente!", MsgBoxStyle.Critical, "Registro de Renta de Coche")
            Return False
        End If

        If _buscarRegistro("coches", "id_coche", idCoche) Then
            _idCoche = idCoche
        Else
            MsgBox("Seleccione un coche existiente!", MsgBoxStyle.Critical, "Registro de Renta de Coche")
            Return False
        End If

        If _buscarRegistro("usuarios", "id_usuario", idUsuario) Then
            _idUsuario = idUsuario
        Else
            MsgBox("Seleccione un usuario existiente!", MsgBoxStyle.Critical, "Registro de Renta de Coche")
            Return False
        End If

        'Validar!
        'If fechaRetiro Then

        'End If

        Dim query As String = "INSERT INTO coches VALUES(NULL, '" & _idCliente & "', '" & _idAgencia & "', '" & _idCoche & "', '" & _idUsuario & "', '" & _fechaRetiro.ToString("yyyy-MM-dd") & "', '" & _fechaEntrega.ToString("yyyy-MM-dd").ToString & "', '" & _estado & "', ';"
        'OBTENER ÍNDICE GUARDADO Y GUARDARLO EN _idRenta
        Return True
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
