Imports MaterialSkin
Public Class frmRentar_Autos
    Dim listaReservas() As clsReservas 'Arreglo que guarda objetos de tipo clsReserva
    Dim listaClientes() As clsClientes 'Arreglo que guarda objetos de tipo clsClientes
    Dim listaCoches() As clsCoches 'Arreglo que guarda objetos de tipo clsCoches
    Dim listaAgencias() As clsAgencias 'Arreglo que guarda objetos de tipo clsaAgencias
    Private Sub frmRentar_Autos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reservas = New clsReservas 'Se instancia el objeto de tipo clsReservas
        If Reservas.listarReservas(listaReservas, dgvRentar_Autos) = 0 Then 'Se verifica si hay reservas activas
            MsgBox("No existen Reservas activas")
            btnRentar_Autos.Enabled = False
        End If
    End Sub
    Private Sub txbCodigo_Reserva_KeyUp(sender As Object, e As KeyEventArgs) Handles txbCodigo_Reserva.KeyUp
        'Evento para buscar reservas en el dgv
        Dim t As String = txbCodigo_Reserva.Text.Trim
        If Not e.KeyCode = 8 And t.Length > 0 Then 'Se busca el reserva siempre que se haya agregado una letra
            Reservas.BuscarReserva(txbCodigo_Reserva.Text.ToUpper, listaReservas, dgvRentar_Autos)
        ElseIf e.KeyCode = 8 Then 'Se busca reserva cuando esta borrando
            Reservas.BuscarReserva(txbCodigo_Reserva.Text.ToUpper, listaReservas, dgvRentar_Autos, True)
        End If
    End Sub
    Private Sub dgvRentar_Autos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRentar_Autos.CellClick
        'Seleccionar una reseva con el evento click en una celda del dgv
        txbCodigo_Reserva.Text = dgvRentar_Autos.CurrentRow.Cells(0).Value
    End Sub
    Private Sub btnRentar_Autos_Click(sender As Object, e As EventArgs) Handles btnRentar_Autos.Click
        'Proceso para rentar
        Rentas = New clsRentas 'Se instancia el objeto de tipo clsRentas

        Dim indice As Integer = Reservas.BuscarIndice(txbCodigo_Reserva.Text, listaReservas) 'Se obtiene el indice de reserva selccionada

        If indice > -1 Then 'Se verifica que el indice exista
            Dim user As Integer = Rentas.ChequearReserva(listaReservas(indice).ObtenerCodigoReserva) 'Se verifica la reserva
            If user Then
                Dim indiceUsuario As Integer = Session.ObtenerIdUsuario 'iD del usuario que registrara la renta
                'Se lleva a cabo el proceso
                If Rentas.registrarRenta(listaReservas(indice).ObtenerIdCliente, listaReservas(indice).ObtenerIdAgencia, listaReservas(indice).ObtenerIdCoche, indiceUsuario, listaReservas(indice).ObtenerFechaInicio.ToString("yyyy-MM-dd"), listaReservas(indice).ObtenerFechaFin.ToString("yyyy-MM-dd"), txbCodigo_Reserva.Text) Then
                    Rentas.ReservaRealizada(listaReservas(indice)) 'Se cambio el estado de la reserva
                    MsgBox("Renta Agregada con exito")
                End If
            End If
        Else
            MsgBox("Error: Código de renta no encontrado")
        End If

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Agentes.Show()
        Me.Close()
    End Sub

    Private Sub btnNoExiste_Click(sender As Object, e As EventArgs) Handles btnNoExiste.Click
        frmRenta_Directa.Show()
        Me.Close()
    End Sub
End Class