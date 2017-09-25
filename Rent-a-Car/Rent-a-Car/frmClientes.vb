Imports MaterialSkin
Public Class frmClientes
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub btnAgregar_Cliente_Click(sender As Object, e As EventArgs) Handles btnAgregar_Cliente.Click
        Clientes = New clsClientes
        If Clientes.registrarDatos(txbDui.Text, txbPasaporte.Text, txbNombre.Text, txbApellido.Text, txbDireccion.Text, txbCiudad.Text, txbEmail.Text, txbEmail.Text) Then
            MsgBox("Registro Exitoso")
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Hide()

    End Sub
End Class