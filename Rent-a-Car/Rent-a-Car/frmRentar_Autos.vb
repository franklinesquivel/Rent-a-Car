Imports MaterialSkin
Public Class frmRentar_Autos
    Dim listaReservas() As clsReservas
    Dim listaClientes() As clsClientes
    Dim listaCoches() As clsCoches
    Dim listaAgencias() As clsAgencias
    Private Sub frmRentar_Autos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reservas = New clsReservas
        If Reservas.listarReservas(listaReservas, dgvRentar_Autos) = 0 Then
            MsgBox("No existen Reservas activas")
            btnRentar_Autos.Enabled = False
        End If
    End Sub
    Private Sub txbCodigo_Reserva_KeyUp(sender As Object, e As KeyEventArgs) Handles txbCodigo_Reserva.KeyUp
        Dim t As String = txbCodigo_Reserva.Text.Trim
        If Not e.KeyCode = 8 And t.Length > 0 Then
            Reservas.BuscarReserva(txbCodigo_Reserva.Text.ToUpper, listaReservas, dgvRentar_Autos)
        ElseIf e.KeyCode = 8 Then
            Reservas.BuscarReserva(txbCodigo_Reserva.Text.ToUpper, listaReservas, dgvRentar_Autos, True)
        End If
    End Sub
    Private Sub dgvRentar_Autos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRentar_Autos.CellClick
        txbCodigo_Reserva.Text = dgvRentar_Autos.CurrentRow.Cells(0).Value
        End Sub
    Private Sub btnRentar_Autos_Click(sender As Object, e As EventArgs) Handles btnRentar_Autos.Click
        Dim Rentas As clsRentas
        Rentas = New clsRentas
        Dim indice As Integer = Reservas.BuscarIndice(txbCodigo_Reserva.Text, listaReservas)
        Dim user As Integer = Rentas.ChequearReserva(indice)
        Dim indiceCliente As Integer = Rentas.idCliente
        Dim indiceAgencia As Integer = Rentas.idAgencia
        Dim indiceCoche As Integer = Rentas.idCoche
        Dim indiceUsuario As Integer = Session.ObtenerIdUsuario
        Dim fechaR As Date = Rentas.getFechaRetiro
        Dim fechaD As Date = Rentas.getFechadevo
        If Rentas.registrarRenta(indiceCliente, indiceAgencia, indiceCoche, indiceUsuario, fechaR.ToString("yyyy-MM-dd"), fechaD.ToString("yyyy-MM-dd"), txbCodigo_Reserva.Text) Then
            Rentas.ReservaRealizada(listaReservas(indice))
            MsgBox("Renta Agregada con exito")
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Agentes.Show()
        Me.Close()
    End Sub

    Private Sub btnNoExiste_Click(sender As Object, e As EventArgs) Handles btnNoExiste.Click
        frmRenta_Directa.Show()
        Me.Hide()
    End Sub
End Class