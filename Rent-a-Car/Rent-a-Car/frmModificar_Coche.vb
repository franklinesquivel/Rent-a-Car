Imports MaterialSkin
Imports System.IO
Imports System.IO.Path
Imports MySql.Data.MySqlClient
Public Class frmModificar_Coche
    Dim busquedaLista() As clsCoches 'Arreglo que guarda objetos de tipo clsCoches
    Dim Conexion As clsConexion = New clsConexion() 'Clase que posee metodos que interactuan con la BDD
    Dim dataReader As MySqlDataReader 'Variable de tipo lectora

    Private Sub frmModificar_Coche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Session.ControlarSession()

        Coches = New clsCoches 'Se instancia la clase de coches
        Conexion.llenarCombo(ComboBox2, "SELECT placa FROM coches WHERE estado = 'A'", 0, 0) 'Se llena el combobox de las placas de los coches
        btnModificar_Coche.Enabled = False
        If Conexion.contarFilas("SELECT * FROM agencias;") > 0 Then 'Se verifica si existen agencias
            Conexion.llenarCombo(cmbAgenciaCoche, "SELECT * FROM agencias;", 0, 1) 'Se llena el combobox de las agencias disponibles en la BDD
        Else
            MsgBox("No hay agencias registradas en el sistema!", MsgBoxStyle.Critical, "Agencias")
            cmbAgenciaCoche.Enabled = False
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Close()
    End Sub

    Private Sub cmbBuscar_Autos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBuscar_Autos.SelectedIndexChanged
        Coches.opcionesBusquedaAutos(cmbBuscar_Autos, ComboBox1) 'Se esocge un tipo de busqueda
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Coches.modificarCochesDisponibles(dgvBuscar_Coche, ComboBox1, cmbBuscar_Autos, busquedaLista) 'Se realica una busqueda más especifica
    End Sub

    Private Sub btnModificar_Coche_Click(sender As Object, e As EventArgs) Handles btnModificar_Coche.Click
        Dim key As Integer = CInt(DirectCast(cmbAgenciaCoche.SelectedItem, KeyValuePair(Of String, String)).Key) 'Valor primario de las agencais
        Dim value As String = DirectCast(cmbAgenciaCoche.SelectedItem, KeyValuePair(Of String, String)).Value 'Texto del combobox agencias
        Dim tipo As String = ""

        Try 'Controlador de errores
            tipo = obtenerRadio().Text
        Catch ex As Exception
            tipo = ""
        End Try

        'Se lleva a cabo el proceso de modificar coches
        If Coches.ModificarCoches(txbMarca.Text, txbModelo.Text, txbColor.Text, txbKilometraje.Text, txbNumero_Pasajeros.Text, txbPrecio_Alquiler.Text, ofdFoto.FileName, tipo, cmbAgenciaCoche.SelectedValue) Then
            MsgBox("Auto modificado con exito", MsgBoxStyle.Information)
            'Se reestablece el formulario
            txbMarca.Text = ""
            txbModelo.Text = ""
            txbColor.Text = ""
            txbKilometraje.Text = ""
            txbNumero_Pasajeros.Text = ""
            txbPrecio_Alquiler.Text = ""
            ofdFoto.FileName = ""
            btnModificar_Coche.Enabled = False
            btnVerDatos.Enabled = True
            ComboBox1.SelectedValue = ""
            tipo = ""
            cmbAgenciaCoche.SelectedValue = 0
            btnFoto.Text = "+ Agregue una foto"
            picCoche.ImageLocation = Nothing
            obtenerRadio().Checked = False
        End If

    End Sub
    Private Function obtenerRadio() As MaterialSkin.Controls.MaterialRadioButton 'Obtener el valor de los radios
        Dim rButton As MaterialSkin.Controls.MaterialRadioButton = Me.Controls.OfType(Of RadioButton).Where(Function(r) r.Checked = True).FirstOrDefault()
        Return rButton
    End Function

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        'Proceso para verificar y agregar la foto
        ofdFoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        ofdFoto.Title = "Selecciona la imagen del coche"
        ofdFoto.Filter = "Image Files (*.png *.jpg *.jpeg *.bmp) |*.png; *.jpg; *.jpeg; *.bmp"
        If ofdFoto.ShowDialog() = DialogResult.OK Then
            btnFoto.Text = Path.GetFileName(ofdFoto.FileName)
            picCoche.ImageLocation = ofdFoto.FileName
        End If
    End Sub

    Private Sub btnVerDatos_Click(sender As Object, e As EventArgs) Handles btnVerDatos.Click
        'Proceso para mostrar la información del coche seleccionado a modificar
        Dim placa As String
        Dim marca As String
        Dim modelo As String
        Dim color As String
        Dim kilometraje As String
        Dim N_pasa As String
        Dim alquiler As String
        Dim agencia As String
        Dim tipo As String = ""

        'Se lleva a cabo la extracción de la información mediante variables por referencia
        placa = ComboBox2.SelectedValue
        If Coches.LlenarDatosModificar(placa, marca, modelo, color, kilometraje, N_pasa, alquiler, btnFoto, tipo, agencia, picCoche) Then
            btnModificar_Coche.Enabled = True
            txbMarca.Text = marca
            txbModelo.Text = modelo
            txbColor.Text = color
            txbKilometraje.Text = kilometraje
            txbNumero_Pasajeros.Text = N_pasa
            txbPrecio_Alquiler.Text = alquiler
            cmbAgenciaCoche.SelectedIndex = agencia
            btnVerDatos.Enabled = True
            If tipo = "Sedan" Then
                rdbSedan.Checked = True
            ElseIf tipo = "Pickups" Then
                rdbPickups.Checked = True
            ElseIf tipo = "Microbuses" Then
                rdbMicrobuses.Checked = True
            End If
        End If
    End Sub

    Private Sub mnsCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles mnsCerrar_Sesion.Click
        Session.CerrarSession() 'Cerrar sesión
    End Sub

    Private Sub rdbSedan_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSedan.CheckedChanged

    End Sub

    Private Sub rdbPickups_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPickups.CheckedChanged

    End Sub

    Private Sub rdbMicrobuses_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMicrobuses.CheckedChanged

    End Sub
End Class