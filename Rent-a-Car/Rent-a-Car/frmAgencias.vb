Imports MaterialSkin
Public Class frmAgencias
    Private Sub frmAgencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Session.ControlarSession() 'Se invoca el método por si alguien quiere acceder al formulario antes de iniciar sesión
    End Sub

    Private Sub btnAgregar_Agencia_Click(sender As Object, e As EventArgs) Handles btnAgregar_Agencia.Click
        Agencia = New clsAgencias 'Objeto de clsAgencias
        If Agencia.registrarAgencia(txbNombre_Agencia.Text, txbDireccion.Text, txbTelefono.Text) Then 'Invocamos el registro
            InicializarFormulario() 'Se reestablecen los campos
            MsgBox("Registro Exitoso", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Close()
    End Sub

    Private Sub mnsCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles mnsCerrar_Sesion.Click
        Session.CerrarSession()
        Me.Close()
    End Sub

    Public Sub InicializarFormulario() 'Limpia los campos
        txbDireccion.Text = ""
        txbNombre_Agencia.Text = ""
        txbTelefono.Text = ""
    End Sub
End Class