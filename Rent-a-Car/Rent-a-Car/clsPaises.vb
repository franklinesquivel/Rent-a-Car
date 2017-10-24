Imports MySql.Data.MySqlClient
Public Class clsPaises
    Private Conexion As clsConexion = New clsConexion()
    Public Sub Listar(ByRef cmb As ComboBox) 'Pone en un combobox todos los países encontrados en la BD
        Dim reader As MySqlDataReader 'Variable de lectura
        Conexion.obtenerDatos("SELECT * FROM paises", reader)
        While reader.Read() 'Se recorre los objetos obtenidos
            cmb.Items.Add(reader(1)) 'Se agregan al combobox
        End While
        reader.Close() 'Se cierra la lectura
    End Sub
End Class
