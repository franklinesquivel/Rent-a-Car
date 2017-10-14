Imports MaterialSkin
Public Class frmInventario_Autos
    Dim busquedaLista() As clsCoches

    Private Sub frmRenta_Agencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Coches = New clsCoches() 'Creación de objeto
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Close()
    End Sub

    Private Sub cmbBuscar_Autos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBuscar_Autos.SelectedIndexChanged
        Coches.opcionesBusquedaAutos(cmbBuscar_Autos, ComboBox1)
    End Sub
    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Coches.mostrarDisponibles(dgvInventario_Autos, ComboBox1, cmbBuscar_Autos, busquedaLista)
    End Sub
End Class