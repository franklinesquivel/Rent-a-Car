Imports MaterialSkin
Public Class frmReservas
    Dim listaClientes() As clsClientes
    Dim listaCoches() As clsCoches
    Private Sub frmReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Session.ControlarSession()
        IncializarFormulario() 'Se inicia el formulario
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Agentes.Show()
        Me.Hide()
    End Sub

    Private Sub btnReservar_Coche_Click(sender As Object, e As EventArgs) Handles btnReservar_Coche.Click
        Reservas = New clsReservas() 'Creación de objeto para la reserva
        Dim indiceCliente As Integer = Clientes.BuscarIndice(txbBuscar_Codigo.Text, listaClientes) 'Se obtiene el indice del arreglo según cliente seleccionado
        Dim indiceCoche As Integer = Coches.BuscarIndice(txbBuscar_Coche.Text, listaCoches) 'Se obtiene el indice del arreglo según coche seleccionado

        If indiceCliente > -1 Then 'Se verifica que el cliente sea valido
            If indiceCoche > -1 Then 'Se verifica que el coche sea valido
                If Reservas.Registrar(dtpFecha_Entrega.Value.ToString("yyyy-MM-dd"), dtpFecha_Devolucion.Value.ToString("yyyy-MM-dd"), listaClientes(indiceCliente), listaCoches(indiceCoche)) Then
                    IncializarFormulario()
                    MsgBox("Reserva exitosa")
                End If
            Else
                MsgBox("Error: Matrícula de coche no ha sido encontrada")
            End If
        Else
            MsgBox("Error: El nombre de usuario no se ha encontrado en la BDD")
        End If
    End Sub
    Private Sub txbBuscar_Codigo_KeyUp(sender As Object, e As KeyEventArgs) Handles txbBuscar_Codigo.KeyUp
        'Evento para buscar cliente en el dgv
        Dim t As String = txbBuscar_Codigo.Text.Trim
        If Not e.KeyCode = 8 And t.Length > 0 Then 'Se busca el cliente siempre que se haya agregado una letra
            Clientes.BuscarCliente(txbBuscar_Codigo.Text.ToUpper, listaClientes, dgvBuscar_Usuario)
        ElseIf e.KeyCode = 8 Then
            Clientes.BuscarCliente(txbBuscar_Codigo.Text.ToUpper, listaClientes, dgvBuscar_Usuario, True) 'Se busca el cliente cuando esta borrando
        End If
    End Sub

    Private Sub txbBuscar_Coche_KeyUp(sender As Object, e As KeyEventArgs) Handles txbBuscar_Coche.KeyUp
        'Evento para buscar coche en el dgv
        Dim t As String = txbBuscar_Coche.Text.Trim
        If Not e.KeyCode = 8 And t.Length > 0 Then
            Coches.BuscarCoche(txbBuscar_Coche.Text.ToUpper, listaCoches, dgvBuscar_Coche) 'Se busca el coche siempre que se haya agregado una letra
        ElseIf e.KeyCode = 8 Then
            Coches.BuscarCoche(txbBuscar_Coche.Text.ToUpper, listaCoches, dgvBuscar_Coche, True) 'Se busca coche cuando esta borrando
        End If
    End Sub

    Private Sub dgvBuscar_Usuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuscar_Usuario.CellClick
        'Seleccionar un cliente con el evento click en una celda del dgv
        If dgvBuscar_Usuario.CurrentCell.Value <> "" Then
            txbBuscar_Codigo.Text = dgvBuscar_Usuario.CurrentRow.Cells(3).Value
        End If
    End Sub

    Private Sub dgvBuscar_Coche_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuscar_Coche.CellClick
        'Seleccionar un coche con el evento click en una celda del dgv
        If dgvBuscar_Coche.CurrentCell.Value <> "" Then
            txbBuscar_Coche.Text = dgvBuscar_Coche.CurrentRow.Cells(0).Value
        End If
    End Sub

    Public Sub IncializarFormulario()
        'Se verifica el estado de los objetos participantes en el formulario
        Clientes = New clsClientes() 'Creación del objeto
        If Clientes.listarDatos(listaClientes, dgvBuscar_Usuario) = 0 Then 'Se agregan los usuarios al dgv
            btnReservar_Coche.Enabled = False
            MsgBox("Error: No hay clientes registrados")
        End If
        Coches = New clsCoches() 'Creación de objeto
        If Coches.listarCoches(listaCoches, dgvBuscar_Coche) = 0 Then 'Se agregan los coches al dgv
            btnReservar_Coche.Enabled = False
            MsgBox("Error: No hay coches registrados")
        End If
        'Se limpian los campos
        txbBuscar_Codigo.Text = ""
        txbBuscar_Coche.Text = ""
        dtpFecha_Devolucion.Value = Now
        dtpFecha_Entrega.Value = Now
    End Sub
End Class