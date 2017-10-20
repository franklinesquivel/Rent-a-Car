Imports MaterialSkin
Public Class frmCancelar_Reservas
    Dim listaReservas() As clsReservas
    Private Sub frmCancelar_Reservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Session.ControlarSession()
        Reservas = New clsReservas
        InicializarVista(False)
        If Reservas.listarReservas(listaReservas, dgvCancelar_Reservas) = 0 Then
            MsgBox("Error: No hay reservas por cancelar")
            btnCancelar_Reservas.Enabled = False
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Agentes.Show()
        Me.Close()
    End Sub
    Private Sub dgvCancelar_Reservas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCancelar_Reservas.CellClick
        If dgvCancelar_Reservas.CurrentCell.Value <> "" Then
            txbCodigo_Reserva.Text = dgvCancelar_Reservas.CurrentRow.Cells(0).Value
        End If
    End Sub

    Private Sub txbCodigo_Reserva_KeyUp(sender As Object, e As KeyEventArgs) Handles txbCodigo_Reserva.KeyUp
        Dim t As String = txbCodigo_Reserva.Text.Trim
        If Not e.KeyCode = 8 And t.Length > 0 Then
            Reservas.BuscarReserva(txbCodigo_Reserva.Text.ToUpper, listaReservas, dgvCancelar_Reservas)
        ElseIf e.KeyCode = 8 Then
            Reservas.BuscarReserva(txbCodigo_Reserva.Text.ToUpper, listaReservas, dgvCancelar_Reservas, True)
        End If
    End Sub

    Private Sub btnCancelar_Reservas_Click(sender As Object, e As EventArgs) Handles btnCancelar_Reservas.Click
        Dim indice = Reservas.BuscarIndice(txbCodigo_Reserva.Text, listaReservas)
        If indice > -1 Then
            If Reservas.CancelarReserva(listaReservas(indice)) Then
                MsgBox("Reserva cancelada con exito")
            Else
                MsgBox("Error: Problemas de ejecución")
            End If
        Else
            MsgBox("Error: El código de reserva no esta registrado")
        End If
    End Sub

    Private Sub dgvCancelar_Reservas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCancelar_Reservas.CellContentClick

    End Sub

    Private Sub mnsCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles mnsCerrar_Sesion.Click
        Session.CerrarSession()
    End Sub

    Private Sub btnVerDatos_Click(sender As Object, e As EventArgs) Handles btnVerDatos.Click
        Dim indice = Reservas.BuscarIndice(txbCodigo_Reserva.Text, listaReservas)
        Dim matricula = "", especificaciones = "", nombreUsuario = "", codigoUsuario = "", correoUsuario As String = ""
        If indice > -1 Then
            Reservas.VerDatos(listaReservas(indice).ObtenerCodigoReserva, matricula, especificaciones, picCoche, nombreUsuario, codigoUsuario, correoUsuario)
            lblNumReserva.Text = "Código de Reserva: " & listaReservas(indice).ObtenerCodigoReserva
            lblFechaInicio.Text = "Fecha Retiro: " & listaReservas(indice).ObtenerFechaInicio
            lblFechaFinal.Text = "Fecha Devolución: " & listaReservas(indice).ObtenerFechaFin
            lblPagar.Text = "Total a pagar: $" & listaReservas(indice).ObtenerPrecioReserva
            lblMatricula.Text = "Matrícula de coche: " & matricula
            lblEspecidicaciones.Text = "Marca y modelo: " & especificaciones
            lblNombreUsuario.Text = "Nombre de Cliente: " & nombreUsuario
            lblCodigoUsuario.Text = "Código de Cliente: " & codigoUsuario
            lblCorreoUsuario.Text = "Correo de Cliente: " & correoUsuario
            InicializarVista(True)
            tbcReserva.SelectTab(1)
        Else
            tbcReserva.SelectTab(0)
            InicializarVista(False)
            MsgBox("Error: El código de reserva no esta registrado")
        End If
    End Sub

    Public Sub InicializarVista(ByVal valor As Boolean)
        lblNumReserva.Visible = valor
        lblCodigoUsuario.Visible = valor
        lblFechaFinal.Visible = valor
        lblFechaInicio.Visible = valor
        lblPagar.Visible = valor
        lblMatricula.Visible = valor
        lblEspecidicaciones.Visible = valor
        lblNombreUsuario.Visible = valor
        lblCorreoUsuario.Visible = valor
        picCoche.Visible = valor
    End Sub
End Class