Imports MaterialSkin
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmCoches
    Dim Conexion As clsConexion = New clsConexion()
    Dim dataReader As MySqlDataReader

    Private Sub frmCoches_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        Conexion.llenarCombo(cmbAgenciaCoche, "SELECT * FROM agencias;", 0, 1)
    End Sub

    Private Sub btnAgregar_Coche_Click(sender As Object, e As EventArgs) Handles btnAgregar_Coche.Click
        Dim key As String = DirectCast(cmbAgenciaCoche.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim value As String = DirectCast(cmbAgenciaCoche.SelectedItem, KeyValuePair(Of String, String)).Value
        If key = "" Then
            MessageBox.Show("naila")
        Else
            MessageBox.Show(cmbAgenciaCoche.SelectedValue)
        End If

        'Dim tipo As String
        'FileSystem.FileCopy((Path.GetDirectoryName(ofdFoto.FileName) + "\" + ofdFoto.FileName), Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Coches\"))

        'Coches = New clsCoches
        'If rdbMicrobuses.Checked = True Then
        '    tipo = rdbMicrobuses.Text
        '    If Coches.registrarCoche(txbMatricula.Text, txbMarca.Text, txbModelo.Text, txbColor.Text, txbKilometraje.Text, txbNumero_Pasajeros.Text, txbPrecio_Alquiler.Text, btnFoto.Text, tipo, cmbAgenciaCoche.SelectedValue) Then
        '        MsgBox("Registro Exitoso")
        '    End If
        'ElseIf rdbPickups.Checked = True Then
        '    tipo = rdbPickups.Text
        '    If Coches.registrarCoche(txbMatricula.Text, txbMarca.Text, txbModelo.Text, txbColor.Text, txbKilometraje.Text, txbNumero_Pasajeros.Text, txbPrecio_Alquiler.Text, btnFoto.Text, tipo, cmbAgenciaCoche.SelectedValue) Then
        '        MsgBox("Registro Exitoso")
        '    End If
        'ElseIf rdbSedan.Checked = True Then
        '    tipo = rdbSedan.Text
        '    If Coches.registrarCoche(txbMatricula.Text, txbMarca.Text, txbModelo.Text, txbColor.Text, txbKilometraje.Text, txbNumero_Pasajeros.Text, txbPrecio_Alquiler.Text, btnFoto.Text, tipo, cmbAgenciaCoche.SelectedValue) Then
        '        MsgBox("Registro Exitoso")
        '    End If
        'End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Close()
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        ofdFoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        ofdFoto.Title = "Selecciona la imagen del coche"
        ofdFoto.Filter = "Image Files (*.png *.jpg *.jpeg *.bmp) |*.png; *.jpg; *.jpeg; *.bmp|All Files(*.*) |*.*"
        ofdFoto.ShowDialog()
    End Sub
End Class