Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Module mdlValidaciones
    Dim Conexion As clsConexion = New clsConexion()
    Function _rutaDeArchivoValida(ByVal ruta As String) As Boolean
        If ruta Is Nothing Then
            Return False
        End If

        For Each badChar As Char In System.IO.Path.GetInvalidPathChars
            If InStr(ruta, badChar) > 0 Then
                Return False
            End If
        Next

        Return True
    End Function

    Function _esImagen(ByVal ruta As String) As Boolean
        Try
            Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(ruta)
        Catch generatedExceptionName As OutOfMemoryException
            Return False
        End Try
        Return True
    End Function

    Function _buscarRegistro(ByVal tabla As String, ByVal campo As String, ByVal valor As String) As Boolean
        Dim query As String = "SELECT * FROM " & tabla & " WHERE " & campo & " = '" & valor & "';"
        Dim dataReader As MySqlDataReader

        Conexion.obtenerDatos(query, dataReader)
        Return dataReader.HasRows
    End Function

    Function _noCoincide(ByVal pattern As String, ByVal value As String) As Boolean
        Return Not Regex.IsMatch(value, pattern)
    End Function
End Module
