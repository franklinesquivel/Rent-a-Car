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
End Class