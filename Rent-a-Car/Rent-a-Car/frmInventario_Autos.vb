Imports MaterialSkin
Imports System.IO.Path
Public Class frmInventario_Autos
    Dim busquedaLista() As clsCoches 'Arreglo que guarda objetos de clase coche

    Private Sub frmRenta_Agencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Session.ControlarSession()
        Coches = New clsCoches() 'Creación de objeto
        InicializarVista(False) 'Se esconden los labels
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Close()
    End Sub

    Private Sub cmbBuscar_Autos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBuscar_Autos.SelectedIndexChanged
        Coches.opcionesBusquedaAutos(cmbBuscar_Autos, ComboBox1) 'Se escoge porque tipo se quiere realizar la busqueda
    End Sub
    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Coches.mostrarDisponibles(dgvInventario_Autos, ComboBox1, cmbBuscar_Autos, busquedaLista) 'Se hace la busqueda más especifica
    End Sub

    Private Sub dgvInventario_Autos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventario_Autos.CellClick
        If dgvInventario_Autos.CurrentCell.Value <> "" Then 'Se agrega la información a los campos según coche seleccionado
            lblMatricula.Text = "Matricula: " & busquedaLista(dgvInventario_Autos.CurrentRow.Index).ObtenerMatricula
            lblMarca.Text = "Marca: " & busquedaLista(dgvInventario_Autos.CurrentRow.Index).ObtenerMarca
            lblModelo.Text = "Modelo: " & busquedaLista(dgvInventario_Autos.CurrentRow.Index).ObtenerModelo
            lblColor.Text = "Color: " & busquedaLista(dgvInventario_Autos.CurrentRow.Index).ObtenerColor
            lblKm.Text = "Kilometraje: " & busquedaLista(dgvInventario_Autos.CurrentRow.Index).ObtenerKilometraje
            lblNumPasajeros.Text = "Número de pasajeros: " & busquedaLista(dgvInventario_Autos.CurrentRow.Index).ObtenerNPasajeros
            lblPrecio.Text = "Precio: $" & busquedaLista(dgvInventario_Autos.CurrentRow.Index).ObtenerPrecioAlquiler
            lblTipo.Text = "Tipo: " & busquedaLista(dgvInventario_Autos.CurrentRow.Index).ObtenerTipo
            If busquedaLista(dgvInventario_Autos.CurrentRow.Index).ObtenerEstado = "A" Then
                lblEstado.Text = "Activo"
            Else
                lblEstado.Text = "En Reparación"
            End If
            'Se obtiene la foto
            Dim resourcesPath = Application.StartupPath & DirectorySeparatorChar & ".." & DirectorySeparatorChar & ".." & DirectorySeparatorChar & "Resources" & DirectorySeparatorChar & "Coches" & DirectorySeparatorChar
            pcbFoto.ImageLocation = resourcesPath + busquedaLista(0).ObtenerFotografia
            InicializarVista(True) 'Se hacen visible los labels
            tbcInventarios.SelectTab(1) 'Se cambia de tab
        Else
            tbcInventarios.SelectTab(0) 'Se cambia de tab
            InicializarVista(False) 'Se esconden los label
        End If
    End Sub

    Public Sub InicializarVista(ByVal valor As Boolean) 'Proceso para los labels de ver datos de coches
        lblMatricula.Visible = valor
        lblMarca.Visible = valor
        lblModelo.Visible = valor
        lblColor.Visible = valor
        lblKm.Visible = valor
        lblNumPasajeros.Visible = valor
        lblPrecio.Visible = valor
        lblTipo.Visible = valor
        lblEstado.Visible = valor
    End Sub

    Private Sub mnsCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles mnsCerrar_Sesion.Click
        Session.CerrarSession() 'Cerrar sesión
    End Sub
End Class