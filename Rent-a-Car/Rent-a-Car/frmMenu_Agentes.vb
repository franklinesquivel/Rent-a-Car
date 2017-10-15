Imports MaterialSkin
Public Class frmMenu_Agentes
    Private Sub frmMenu_Agentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub btnRegistrar_Clientes_Click(sender As Object, e As EventArgs) Handles btnRegistrar_Clientes.Click
        frmClientes.Show()
        Me.Hide()
    End Sub

    Private Sub btnInventario_Autos_Click(sender As Object, e As EventArgs) Handles btnInventario_Autos.Click
        frmInventario_Autos.Show()
        Me.Hide()
    End Sub

    Private Sub btnDevolver_Autos_Click(sender As Object, e As EventArgs) Handles btnDevolver_Autos.Click
        frmDevolucion_Auto.Show()
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

    Private Sub btnCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles btnCerrar_Sesion.Click
        frmInicio_Sesion.Show()
        Me.Close()
    End Sub

    Private Sub btnRentar_Auto_Click(sender As Object, e As EventArgs) Handles btnRentar_Auto.Click
        frmRentar_Autos.Show()
        Me.Hide()
    End Sub
End Class