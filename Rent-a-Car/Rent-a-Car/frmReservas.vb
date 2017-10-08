Imports MaterialSkin
Public Class frmReservas
    Dim listaClientes() As clsClientes
    Dim listaCoches() As clsCoches
    Private Sub frmReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        Clientes = New clsClientes() 'Creación del objeto
        Clientes.listarDatos(listaClientes, dgvBuscar_Usuario) 'Se agregan los usuarios al dgv

        Coches = New clsCoches() 'Creación de objeto
        Coches.listarCoches(listaCoches, dgvBuscar_Coche) 'Se agregan los coches al dgv
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Hide()
    End Sub

    Private Sub btnReservar_Coche_Click(sender As Object, e As EventArgs) Handles btnReservar_Coche.Click
        email = New clsEmail() 'Creación de objeto para enviar el email
        Reservas = New clsReservas() 'Creación de objeto para la reserva

        Dim indiceCliente As Integer = Clientes.BuscarIndice(txbBuscar_Codigo.Text, listaClientes)
        Dim indiceCoche As Integer = Coches.BuscarIndice(txbBuscar_Coche.Text, listaCoches)
        MsgBox(dtpFecha_Entrega.Value.ToString("yyyy-MM-dd"))

        If indiceCliente > -1 Then
            If indiceCoche > -1 Then
                If Reservas.Registrar(dtpFecha_Entrega.Value.ToString("yyyy-MM-dd"), dtpFecha_Devolucion.Value.ToString("yyyy-MM-dd"), listaClientes(indiceCliente).ObtenerIdCliente, listaCoches(indiceCoche).ObtenerIdCoche, txbAgencia.Text) Then
                    MsgBox("Reserva exitosa")
                    email.enviarCorreo(listaClientes(indiceCliente), listaCoches(indiceCoche))
                End If
            Else
                MsgBox("Error: Matrícula de coche no ha sido encontrada")
            End If
        Else
            MsgBox("Error: El nombre de usuario no se ha encontrado en la BDD")
        End If
    End Sub
End Class