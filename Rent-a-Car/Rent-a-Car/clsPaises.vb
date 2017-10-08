Imports MySql.Data.MySqlClient
Public Class clsPaises
    Private Conexion As clsConexion = New clsConexion()
    Public Sub Listar(ByRef cmb As ComboBox)
        Dim reader As MySqlDataReader
        Conexion.obtenerDatos("SELECT * FROM paises", reader)
        While reader.Read()
            cmb.Items.Add(reader(1))
        End While
        reader.Close()
    End Sub
End Class
