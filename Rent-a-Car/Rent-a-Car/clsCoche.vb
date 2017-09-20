Imports System.IO
Public MustInherit Class clsCoche
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

    Public ReadOnly Property id
        Get
            Return _idCoche
        End Get
    End Property

    Public Function registrarCoche(ByVal matricula As String, ByVal marca As String, ByVal modelo As String, ByVal color As String, ByVal kilometraje As Long, ByVal nPasajeros As Integer, ByVal alquiler As Decimal, ByVal fotografia As String, ByVal tipo As String, ByVal idAgencia As Integer) As Boolean
        Return True
    End Function
End Class
