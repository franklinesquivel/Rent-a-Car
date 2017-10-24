Imports MaterialSkin
Public Class frmMenu_Admin
    Private Sub frmMenu_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Session.ControlarSession()
        If Session.ObtenerTipoUsuario = "A" Then
            GroupBox1.Visible = True
            GroupBox2.Visible = False
            GroupBox3.Visible = False
        ElseIf Session.ObtenerTipoUsuario = "G" Then
            GroupBox1.Visible = False
            GroupBox2.Visible = True
            GroupBox3.Visible = False
        ElseIf Session.ObtenerTipoUsuario = "C" Then
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = True
        End If
    End Sub

    Private Sub btnRegistrar_Agencias_Click(sender As Object, e As EventArgs) Handles btnRegistrar_Agencias.Click
        frmAgencias.Show()
        Me.Close()
    End Sub

    Private Sub btnRegistrar_Usuarios_Click(sender As Object, e As EventArgs) Handles btnRegistrar_Usuarios.Click
        frmUsuarios.Show()
        Me.Close()
    End Sub
    Private Sub btnRegistrar_Clientes_Click(sender As Object, e As EventArgs) Handles btnRegistrar_Clientes.Click
        frmClientes.Show()
        Me.Close()

    End Sub

    Private Sub btnInventario_Autos_Click(sender As Object, e As EventArgs) Handles btnInventario_Autos.Click
        frmInventario_Autos.Show()
        Me.Close()
    End Sub

    Private Sub btnIngresar_Auto_Click(sender As Object, e As EventArgs) Handles btnIngresar_Auto.Click
        frmCoches.Show()
        Me.Close()
    End Sub

    Private Sub btnModificar_Auto_Click(sender As Object, e As EventArgs) Handles btnModificar_Auto.Click
        frmModificar_Coche.Show()
        Me.Close()
    End Sub

    Private Sub btnEstado_Autos_Click(sender As Object, e As EventArgs) Handles btnEstado_Autos.Click
        frmGestionar_Autos.Show()
        Me.Close()
    End Sub

    Private Sub btnGestion_Reservas_Click(sender As Object, e As EventArgs) Handles btnGestion_Reservas.Click
        frmReservas.Show()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Reservas_Click(sender As Object, e As EventArgs) Handles btnCancelar_Reservas.Click
        frmCancelar_Reservas.Show()
        Me.Close()
    End Sub

    Private Sub btnDevolver_Autos_Click(sender As Object, e As EventArgs) Handles btnDevolver_Autos.Click
        frmDevolucion_Auto.Show()
        Me.Close()
    End Sub

    Private Sub btnReportes_Rentas_Click(sender As Object, e As EventArgs) Handles btnReportes_Rentas.Click
        frmReportes_Rentas.Show()
        Me.Close()
    End Sub

    Private Sub btnReportes_Coches_Click(sender As Object, e As EventArgs) Handles btnReportes_Coches.Click
        frmReportes_Coches.Show()
        Me.Close()
    End Sub

    Private Sub btnCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles btnCerrar_Sesion.Click
        Session.CerrarSession()
        Me.Close()
    End Sub

    '________________________________
    '|         Menú Agentes         |
    '|______________________________|


    Private Sub btnRentar_Auto_Click(sender As Object, e As EventArgs) Handles btnRentar_Auto.Click
        frmRentar_Autos.Show()
        Me.Close()
    End Sub

    Private Sub btnRegClientesAgente_Click(sender As Object, e As EventArgs) Handles btnRegClientesAgente.Click
        frmClientes.Show()
        Me.Close()
    End Sub

    Private Sub btnInventarioAutosAgente_Click(sender As Object, e As EventArgs) Handles btnInventarioAutosAgente.Click
        frmInventario_Autos.Show()
        Me.Close()
    End Sub

    Private Sub btnGestionReservasAgente_Click(sender As Object, e As EventArgs) Handles btnGestionReservasAgente.Click
        frmReservas.Show()
        Me.Close()
    End Sub

    Private Sub btnCancelarReservaAgente_Click(sender As Object, e As EventArgs) Handles btnCancelarReservaAgente.Click
        frmCancelar_Reservas.Show()
        Me.Close()
    End Sub

    Private Sub btnDevolverAutoAgente_Click(sender As Object, e As EventArgs) Handles btnDevolverAutoAgente.Click
        frmDevolucion_Auto.Show()
        Me.Close()
    End Sub






    Private Sub btnEstadoAutoContador_Click(sender As Object, e As EventArgs) Handles btnEstadoAutoContador.Click
        frmGestionar_Autos.Show()
        Me.Close()
    End Sub

    Private Sub btnIngresarAutoContador_Click(sender As Object, e As EventArgs) Handles btnIngresarAutoContador.Click
        frmCoches.Show()
        Me.Close()
    End Sub

    Private Sub btnModificarAutoContador_Click(sender As Object, e As EventArgs) Handles btnModificarAutoContador.Click
        frmModificar_Coche.Show()
        Me.Close()
    End Sub

    Private Sub btnReportesRentaContador_Click(sender As Object, e As EventArgs) Handles btnReportesRentaContador.Click
        frmReportes_Rentas.Show()
        Me.Close()
    End Sub

    Private Sub btnReporteCochesContador_Click(sender As Object, e As EventArgs) Handles btnReporteCochesContador.Click
        frmReportes_Coches.Show()
        Me.Close()
    End Sub

    Private Sub btnGraficoMesContador_Click(sender As Object, e As EventArgs) Handles btnGraficoMesContador.Click
        frmGraficosRenta.Show()
        Me.Close()
    End Sub

    Private Sub btnRentasAgenciasContador_Click(sender As Object, e As EventArgs) Handles btnRentasAgenciasContador.Click
        frmGraficosAgencia.Show()
        Me.Close()
    End Sub
End Class