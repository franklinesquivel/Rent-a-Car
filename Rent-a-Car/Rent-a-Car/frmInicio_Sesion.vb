Imports MaterialSkin
Public Class frmInicio_Sesion
    Private Sub frmInicio_Sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub btnIniciar_sesion_Click(sender As Object, e As EventArgs) Handles btnIniciar_sesion.Click
        'Inicio de sesión
        Usuarios = New clsUsuarios
        If Usuarios.IniciarSesion(txbNombre_Usuario.Text, txbContraseña.Text) Then
            Me.Hide()
        End If
        txbNombre_Usuario.Text = ""
        txbContraseña.Text = ""
    End Sub
End Class