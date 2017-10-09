Public Class clsAgencias
    Private _idAgencia As Integer
    Private _nombre As String
    Private _direccion As String
    Private _telefono As String
    Private Conexion As clsConexion = New clsConexion()

    Public Sub New(Optional ByVal id As Integer = Nothing)
        If id <> Nothing Then
            'Función para obtener datos guardados en la BDD
        End If
    End Sub

    Public ReadOnly Property id
        Get
            Return _idAgencia
        End Get
    End Property

    Public Function registrarAgencia(ByRef nombre As String, ByVal direccion As String, ByVal telefono As String) As Boolean
        nombre = nombre.Trim
        direccion = direccion.Trim
        telefono = telefono.Trim

        If nombre.Length = 0 Then
            MsgBox("Ingrese un nombre válido!", MsgBoxStyle.Critical, "Registro de Agencia")
            Return False
        Else
            _nombre = nombre
        End If

        If direccion.Length = 0 Then
            MsgBox("Ingrese una dirección válido!", MsgBoxStyle.Critical, "Registro de Agencia")
            Return False
        Else
            _direccion = direccion
        End If

        If _noCoincide("^(2|7|6)\d{3}-?\d{4}$", telefono) Then
            MsgBox("Ingrese número telefónico válido!", MsgBoxStyle.Critical, "Registro de Agencia")
            Return False
        Else
            _telefono = telefono
        End If

        'Insertar la agencia en la BDD
        Return Conexion.modificarDatos("INSERT INTO agencias VALUES(NULL, '" & _nombre & "', '" & _direccion & "', '" & _telefono & "')")
    End Function

    Public Sub obtenerDatos(ByRef nombre As String, ByRef direccion As String, ByRef telefono As String)
        nombre = _nombre
        direccion = _direccion
        telefono = _telefono
    End Sub

    Public Function listarAgencias(ByRef cmb As ComboBox) As Boolean
        If Conexion.contarFilas("SELECT * FROM agencias") = 0 Then
            Return 0
        Else
            Conexion.llenarCombo(cmb, "SELECT * FROM agencias", 0, 1)
            Return 1
        End If
    End Function
End Class
