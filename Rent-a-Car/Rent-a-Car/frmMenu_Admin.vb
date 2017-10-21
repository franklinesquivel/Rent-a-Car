Imports MaterialSkin
Public Class frmMenu_Admin
    Private Sub frmMenu_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Session.ControlarSession()
    End Sub

    Private Sub btnRegistrar_Agencias_Click(sender As Object, e As EventArgs) Handles btnRegistrar_Agencias.Click
        frmAgencias.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrar_Usuarios_Click(sender As Object, e As EventArgs) Handles btnRegistrar_Usuarios.Click
        frmUsuarios.Show()
        Me.Hide()
    End Sub
    Private Sub btnRegistrar_Clientes_Click(sender As Object, e As EventArgs) Handles btnRegistrar_Clientes.Click
        frmClientes.Show()
        Me.Hide()

    End Sub

    Private Sub btnInventario_Autos_Click(sender As Object, e As EventArgs) Handles btnInventario_Autos.Click
        frmInventario_Autos.Show()
        Me.Hide()
    End Sub

    Private Sub btnIngresar_Auto_Click(sender As Object, e As EventArgs) Handles btnIngresar_Auto.Click
        frmCoches.Show()
        Me.Hide()
    End Sub

    Private Sub btnModificar_Auto_Click(sender As Object, e As EventArgs) Handles btnModificar_Auto.Click
        frmModificar_Coche.Show()
        Me.Hide()
    End Sub

    Private Sub btnEstado_Autos_Click(sender As Object, e As EventArgs) Handles btnEstado_Autos.Click
        frmGestionar_Autos.Show()
        Me.Hide()
    End Sub

    Private Sub btnGestion_Reservas_Click(sender As Object, e As EventArgs) Handles btnGestion_Reservas.Click
        frmReservas.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancelar_Reservas_Click(sender As Object, e As EventArgs) Handles btnCancelar_Reservas.Click
        frmCancelar_Reservas.Show()
        Me.Hide()
    End Sub

    Private Sub btnDevolver_Autos_Click(sender As Object, e As EventArgs) Handles btnDevolver_Autos.Click
        frmDevolucion_Auto.Show()
        Me.Hide()
    End Sub

    Private Sub btnReportes_Rentas_Click(sender As Object, e As EventArgs) Handles btnReportes_Rentas.Click
        frmReportes_Rentas.Show()
        Me.Hide()
    End Sub

    Private Sub btnReportes_Coches_Click(sender As Object, e As EventArgs) Handles btnReportes_Coches.Click
        frmReportes_Coches.Show()
        Me.Hide()
    End Sub

    Private Sub btnCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles btnCerrar_Sesion.Click
        Session.CerrarSession()
    End Sub
End Class