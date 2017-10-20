Imports MaterialSkin
Imports System.IO
Imports System.IO.Path
Imports MySql.Data.MySqlClient
Public Class frmGestionar_Autos
    Dim busquedaLista() As clsCoches
    Dim Conexion As clsConexion = New clsConexion()
    Dim dataReader As MySqlDataReader

    Private Sub frmGestionar_Autos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Session.ControlarSession()
        Coches = New clsCoches
        Conexion.llenarCombo(ComboBox2, "SELECT placa FROM coches WHERE estado = 'A'", 0, 0)
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Hide()
    End Sub
    Private Function obtenerRadio() As MaterialSkin.Controls.MaterialRadioButton
        Dim rButton As MaterialSkin.Controls.MaterialRadioButton = Me.Controls.OfType(Of RadioButton).Where(Function(r) r.Checked = True).FirstOrDefault()
        Return rButton
    End Function
    Private Sub cmbBuscar_Autos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBuscar_Autos.SelectedIndexChanged
        Coches.opcionesBusquedaAutos(cmbBuscar_Autos, ComboBox1)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Coches.modificarCochesDisponibles(dgvBuscarCoche, ComboBox1, cmbBuscar_Autos, busquedaLista)
    End Sub

    Private Sub btnModificar_Datos_Click(sender As Object, e As EventArgs) Handles btnModificar_Datos.Click
        Dim tipo As String = ""
        Try
            tipo = obtenerRadio().Text
        Catch ex As Exception
            tipo = ""
        End Try
        Coches = New clsCoches
        If Coches.ModificarRenta(ComboBox2.SelectedValue, txtCosto_Renta.Text, tipo) Then
            MsgBox("Auto modificado con exito", MsgBoxStyle.Information)
            txtCosto_Renta.Text = ""
            tipo = ""
            ComboBox2.SelectedValue = 0
            obtenerRadio().Checked = False
        End If
    End Sub

    Private Sub mnsCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles mnsCerrar_Sesion.Click
        Session.CerrarSession()
    End Sub
End Class