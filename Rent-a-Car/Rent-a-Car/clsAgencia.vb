Public Class clsAgencia
    Private _idAgencia As Integer
    Private _nombre As String
    Private _direccion As String
    Private _telefono As String

    Public ReadOnly Property id
        Get
            Return _idAgencia
        End Get
    End Property
End Class
