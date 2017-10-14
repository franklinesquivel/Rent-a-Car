Imports MaterialSkin
Imports System.IO
Imports System.IO.Path
Imports MySql.Data.MySqlClient
Public Class frmModificar_Coche
    Dim busquedaLista() As clsCoches
    Dim Conexion As clsConexion = New clsConexion()
    Dim dataReader As MySqlDataReader

    Private Sub frmModificar_Coche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Coches = New clsCoches
        Conexion.llenarCombo(ComboBox2, "SELECT placa FROM coches WHERE estado = 'A'", 0, 0)
        btnModificar_Coche.Enabled = False
        If Conexion.contarFilas("SELECT * FROM agencias;") > 0 Then
            Conexion.llenarCombo(cmbAgenciaCoche, "SELECT * FROM agencias;", 0, 1)
        Else
            MsgBox("No hay agencias registradas en el sistema!", MsgBoxStyle.Critical, "Agencias")
            cmbAgenciaCoche.Enabled = False
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Hide()
    End Sub

    Private Sub cmbBuscar_Autos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBuscar_Autos.SelectedIndexChanged
        Coches.opcionesBusquedaAutos(cmbBuscar_Autos, ComboBox1)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Coches.modificarCochesDisponibles(dgvBuscar_Coche, ComboBox1, cmbBuscar_Autos, busquedaLista)
    End Sub

    Private Sub btnModificar_Coche_Click(sender As Object, e As EventArgs) Handles btnModificar_Coche.Click
        Dim key As Integer = CInt(DirectCast(cmbAgenciaCoche.SelectedItem, KeyValuePair(Of String, String)).Key)
        Dim value As String = DirectCast(cmbAgenciaCoche.SelectedItem, KeyValuePair(Of String, String)).Value
        Dim tipo As String = ""
        Try
            tipo = obtenerRadio().text
        Catch ex As Exception
            tipo = ""
        End Try
        Coches = New clsCoches
        If Coches.ModificarCoches(txbMarca.Text, txbModelo.Text, txbColor.Text, txbKilometraje.Text, txbNumero_Pasajeros.Text, txbPrecio_Alquiler.Text, ofdFoto.FileName, tipo, cmbAgenciaCoche.SelectedValue) Then
            MsgBox("Auto modificado con exito", MsgBoxStyle.Information)
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
    Private Function obtenerRadio() As MaterialSkin.Controls.MaterialRadioButton
        Dim rButton As MaterialSkin.Controls.MaterialRadioButton = Me.Controls.OfType(Of RadioButton).Where(Function(r) r.Checked = True).FirstOrDefault()
        Return rButton
    End Function

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        ofdFoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        ofdFoto.Title = "Selecciona la imagen del coche"
        ofdFoto.Filter = "Image Files (*.png *.jpg *.jpeg *.bmp) |*.png; *.jpg; *.jpeg; *.bmp"
        If ofdFoto.ShowDialog() = DialogResult.OK Then
            btnFoto.Text = Path.GetFileName(ofdFoto.FileName)
            picCoche.ImageLocation = ofdFoto.FileName
        End If
    End Sub

    Private Sub btnVerDatos_Click(sender As Object, e As EventArgs) Handles btnVerDatos.Click
        Dim placa As String
        Dim marca As String
        Dim modelo As String
        Dim color As String
        Dim kilometraje As String
        Dim N_pasa As String
        Dim alquiler As String
        Dim agencia As String
        Dim tipo As String = ""

        placa = ComboBox2.SelectedValue
        If Coches.LlenarDatosModificar(placa, marca, modelo, color, kilometraje, N_pasa, alquiler, btnFoto, tipo, agencia) Then
            btnModificar_Coche.Enabled = True
            txbMarca.Text = marca
            txbModelo.Text = modelo
            txbColor.Text = color
            txbKilometraje.Text = kilometraje
            txbNumero_Pasajeros.Text = N_pasa
            txbPrecio_Alquiler.Text = alquiler
            cmbAgenciaCoche.SelectedIndex = agencia
            btnVerDatos.Enabled = True
        End If
    End Sub
End Class