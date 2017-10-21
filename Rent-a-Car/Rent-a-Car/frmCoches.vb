Imports MaterialSkin
Imports System.IO
Imports System.IO.Path
Imports MySql.Data.MySqlClient

Public Class frmCoches
    Dim Conexion As clsConexion = New clsConexion()
    Dim dataReader As MySqlDataReader

    Private Function obtenerRadio() As MaterialSkin.Controls.MaterialRadioButton
        Dim rButton As MaterialSkin.Controls.MaterialRadioButton = Me.Controls.OfType(Of RadioButton).Where(Function(r) r.Checked = True).FirstOrDefault()
        Return rButton
    End Function

    Private Sub frmCoches_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Session.ControlarSession() 'Se controla la sesión
        If Conexion.contarFilas("SELECT * FROM agencias;") > 0 Then 'Se verifica la existencia de agencias
            Conexion.llenarCombo(cmbAgenciaCoche, "SELECT * FROM agencias;", 0, 1) 'Se seleccionan las agencias y se listan
        Else
            MsgBox("No hay agencias registradas en el sistema!", MsgBoxStyle.Critical, "Agencias")
            cmbAgenciaCoche.Enabled = False
        End If
    End Sub

    Private Sub btnAgregar_Coche_Click(sender As Object, e As EventArgs) Handles btnAgregar_Coche.Click
        Dim key As Integer = CInt(DirectCast(cmbAgenciaCoche.SelectedItem, KeyValuePair(Of String, String)).Key) 'Valor primario de las agencias
        Dim value As String = DirectCast(cmbAgenciaCoche.SelectedItem, KeyValuePair(Of String, String)).Value 'Valor que se muestra en los combobox de las agencias
        Dim tipo As String = ""

        Try 'Controlador de errores
            tipo = obtenerRadio().Text
        Catch ex As Exception
            tipo = ""
        End Try

        Coches = New clsCoches 'Se instacia el objeto de tipo clase Coche
        'Se lleva a cabo el registro
        If Coches.registrarCoche(txbMatricula.Text, txbMarca.Text, txbModelo.Text, txbColor.Text, txbKilometraje.Text, txbNumero_Pasajeros.Text, txbPrecio_Alquiler.Text, ofdFoto.FileName, tipo, cmbAgenciaCoche.SelectedValue) Then
            'Se reestablecen los campos
            MsgBox("Registro de Coche Éxitoso", MsgBoxStyle.Information, "Registro de Coche")
            txbMatricula.Text = ""
            txbMarca.Text = ""
            txbModelo.Text = ""
            txbColor.Text = ""
            txbKilometraje.Text = "0"
            txbNumero_Pasajeros.Text = "0"
            txbPrecio_Alquiler.Text = "0.00"
            ofdFoto.FileName = ""
            tipo = ""
            cmbAgenciaCoche.SelectedValue = 0
            btnFoto.Text = "+Agregue una foto"
            picCoche.ImageLocation = Nothing
            obtenerRadio().Checked = False
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Close()
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        'Agregar y verificar la foto del coche
        ofdFoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        ofdFoto.Title = "Selecciona la imagen del coche"
        ofdFoto.Filter = "Image Files (*.png *.jpg *.jpeg *.bmp) |*.png; *.jpg; *.jpeg; *.bmp"
        If ofdFoto.ShowDialog() = DialogResult.OK Then
            btnFoto.Text = Path.GetFileName(ofdFoto.FileName)
            picCoche.ImageLocation = ofdFoto.FileName
        End If
    End Sub

    Private Sub mnsCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles mnsCerrar_Sesion.Click
        Session.CerrarSession() 'Cerrar Sesión
    End Sub
End Class