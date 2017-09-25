Imports MaterialSkin

Public Class frmCoches

    Private Sub frmCoches_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub btnAgregar_Coche_Click(sender As Object, e As EventArgs) Handles btnAgregar_Coche.Click
        Dim tipo As String
        Coches = New clsCoches
        If rdbMicrobuses.Checked = True Then
            tipo = rdbMicrobuses.Text
            If Coches.registrarCoche(txbMatricula.Text, txbMarca.Text, txbModelo.Text, txbColor.Text, txbKilometraje.Text, txbNumero_Pasajeros.Text, txbPrecio_Alquiler.Text, btnFoto.Text, tipo, txbAgencia_Coche.Text) Then
                MsgBox("Registro Exitoso")
            End If
        ElseIf rdbPickups.Checked = True Then
            tipo = rdbPickups.Text
            If Coches.registrarCoche(txbMatricula.Text, txbMarca.Text, txbModelo.Text, txbColor.Text, txbKilometraje.Text, txbNumero_Pasajeros.Text, txbPrecio_Alquiler.Text, btnFoto.Text, tipo, txbAgencia_Coche.Text) Then
                MsgBox("Registro Exitoso")
            End If
        ElseIf rdbSedan.Checked = True Then
            tipo = rdbSedan.Text
            If Coches.registrarCoche(txbMatricula.Text, txbMarca.Text, txbModelo.Text, txbColor.Text, txbKilometraje.Text, txbNumero_Pasajeros.Text, txbPrecio_Alquiler.Text, btnFoto.Text, tipo, txbAgencia_Coche.Text) Then
                MsgBox("Registro Exitoso")
            End If
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Close()
    End Sub
End Class