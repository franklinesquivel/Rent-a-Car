Imports MaterialSkin
Public Class frmInicio_Sesion
    Private Sub frmInicio_Sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Usuarios = New clsUsuarios
    End Sub

    Private Sub btnIniciar_sesion_Click(sender As Object, e As EventArgs) Handles btnIniciar_sesion.Click
        'Inicio de sesión
        If Usuarios.IniciarSesion(txbNombre_Usuario.Text, txbContraseña.Text) Then
            Me.Hide()
        End If
        txbNombre_Usuario.Text = ""
        txbContraseña.Text = ""
    End Sub

    Private Sub btnRecuperar_Contraseña_Click(sender As Object, e As EventArgs) Handles btnRecuperar_Contraseña.Click
        Dim correoElectronico As String = ""
        correoElectronico = InputBox("Ingrese su nombre de usuario")
        If Usuarios.recuperarContrasenna(correoElectronico) Then
            MsgBox("Contraseña enviada a su correo electrónico")
        End If
    End Sub
End Class