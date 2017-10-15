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
        Dim indice = Reservas.BuscarIndice(txbCodigo_Reserva.Text, listaReservas)
        Dim indiceCliente As Integer = Clientes.BuscarIndice(dgvRentar_Autos.CurrentRow.Cells(1).Value, listaClientes)
        Dim indiceAgencia As Integer
        Dim indiceCoche As Integer = Coches.BuscarIndice(dgvRentar_Autos.CurrentRow.Cells(3).Value, listaCoches)
        Dim indiceUsuario As Integer = Session.ObtenerIdUsuario
        Dim fechaR As Date = dgvRentar_Autos.CurrentRow.Cells(5).Value
        Dim fechaD As Date = dgvRentar_Autos.CurrentRow.Cells(6).Value
        If indiceCliente > -1 Then
            If indiceAgencia Then
                If Rentas.registrarRenta(indiceCliente, indiceAgencia, indiceCoche, indiceUsuario, fechaR, fechaD) Then
                    MsgBox("Renta Agregada con exito")
                Else
                    MsgBox("Error: Problemas de ejecución")
                End If
            End If
        Else
            MsgBox("Error: El código de reserva no esta registrado")
        End If
    End Sub
End Class