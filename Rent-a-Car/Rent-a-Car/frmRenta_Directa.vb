﻿Imports MaterialSkin
Public Class frmRenta_Directa
    Dim listaClientes() As clsClientes
    Dim listaCoches() As clsCoches
    Private Sub frmReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        'SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        'Se verifica el estado de los objetos participantes en el formulario
        Clientes = New clsClientes() 'Creación del objeto
        If Clientes.listarDatos(listaClientes, dgvBuscar_Usuario) = 0 Then 'Se agregan los usuarios al dgv
            btnRentar_Coche.Enabled = False
            MsgBox("Error: No hay clientes registrados")
        End If
        Coches = New clsCoches() 'Creación de objeto
        If Coches.listarCoches(listaCoches, dgvBuscar_Coche) = 0 Then 'Se agregan los coches al dgv
            btnRentar_Coche.Enabled = False
            MsgBox("Error: No hay coches registrados")
        End If
        Agencia = New clsAgencias() 'Creacion del objeto
        If Agencia.listarAgencias(cmbAgencias) = 0 Then
            btnRentar_Coche.Enabled = False
            MsgBox("Error: No hay agencias registradas")
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Agentes.Show()
        Me.Hide()
    End Sub

    Private Sub btnReservar_Coche_Click(sender As Object, e As EventArgs) Handles btnRentar_Coche.Click
        'email = New clsEmail() 'Creación de objeto para enviar el email
        Rentas = New clsRentas() 'Creación de objeto para la reserva

        Dim key As Integer = CInt(DirectCast(cmbAgencias.SelectedItem, KeyValuePair(Of String, String)).Key)
        Dim value As String = DirectCast(cmbAgencias.SelectedItem, KeyValuePair(Of String, String)).Value
        Dim indiceCliente As Integer = Clientes.BuscarIndice(txbBuscar_Codigo.Text, listaClientes)
        Dim indiceCoche As Integer = Coches.BuscarIndice(txbBuscar_Coche.Text, listaCoches)
        MsgBox(cmbAgencias.SelectedValue)
        If indiceCliente > -1 Then
            If indiceCoche > -1 Then
                If Rentas.Registrar(dtpFecha_Entrega.Value.ToString("yyyy-MM-dd"), dtpFecha_Devolucion.Value.ToString("yyyy-MM-dd"), listaClientes(indiceCliente), listaCoches(indiceCoche), cmbAgencias.SelectedValue) Then
                    MsgBox("Renta exitosa")
                End If
            Else
                MsgBox("Error: Matrícula de coche no ha sido encontrada")
            End If
        Else
            MsgBox("Error: El nombre de usuario no se ha encontrado en la BDD")
        End If
    End Sub
    Private Sub txbBuscar_Codigo_KeyUp(sender As Object, e As KeyEventArgs) Handles txbBuscar_Codigo.KeyUp
        Dim t As String = txbBuscar_Codigo.Text.Trim
        If Not e.KeyCode = 8 And t.Length > 0 Then
            Clientes.BuscarCliente(txbBuscar_Codigo.Text.ToUpper, listaClientes, dgvBuscar_Usuario)
        ElseIf e.KeyCode = 8 Then
            Clientes.BuscarCliente(txbBuscar_Codigo.Text.ToUpper, listaClientes, dgvBuscar_Usuario, True)
        End If
    End Sub

    Private Sub txbBuscar_Coche_KeyUp(sender As Object, e As KeyEventArgs) Handles txbBuscar_Coche.KeyUp
        Dim t As String = txbBuscar_Coche.Text.Trim
        If Not e.KeyCode = 8 And t.Length > 0 Then
            Coches.BuscarCoche(txbBuscar_Coche.Text.ToUpper, listaCoches, dgvBuscar_Coche)
        ElseIf e.KeyCode = 8 Then
            Coches.BuscarCoche(txbBuscar_Coche.Text.ToUpper, listaCoches, dgvBuscar_Coche, True)
        End If
    End Sub

    Private Sub dgvBuscar_Usuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuscar_Usuario.CellClick
        If dgvBuscar_Usuario.CurrentCell.Value <> "" Then
            txbBuscar_Codigo.Text = dgvBuscar_Usuario.CurrentRow.Cells(3).Value
        End If
    End Sub

    Private Sub dgvBuscar_Coche_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuscar_Coche.CellClick
        If dgvBuscar_Coche.CurrentCell.Value <> "" Then
            txbBuscar_Coche.Text = dgvBuscar_Coche.CurrentRow.Cells(0).Value
        End If
    End Sub
End Class