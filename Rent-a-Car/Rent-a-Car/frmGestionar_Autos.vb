Imports MaterialSkin
Imports System.IO
Imports System.IO.Path
Imports MySql.Data.MySqlClient
Public Class frmGestionar_Autos
    Dim busquedaLista() As clsCoches 'Arreglo que guarda instancias de la clase coche
    Dim Conexion As clsConexion = New clsConexion() 'Clase con métodos que intertactuan con la BDD
    Dim dataReader As MySqlDataReader 'Variable lectora

    Private Sub frmGestionar_Autos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Session.ControlarSession() 'Controlador de sesión
        Coches = New clsCoches 'Objeto de la clas coche
        Conexion.llenarCombo(ComboBox2, "SELECT placa FROM coches WHERE estado = 'A'", 0, 0) 'Se llenan el combo de las placas de coches
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Close()
    End Sub
    Private Function obtenerRadio() As MaterialSkin.Controls.MaterialRadioButton 'Obtener los valores del radio
        Dim rButton As MaterialSkin.Controls.MaterialRadioButton = Me.Controls.OfType(Of RadioButton).Where(Function(r) r.Checked = True).FirstOrDefault()
        Return rButton
    End Function
    Private Sub cmbBuscar_Autos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBuscar_Autos.SelectedIndexChanged
        Coches.opcionesBusquedaAutos(cmbBuscar_Autos, ComboBox1) 'Buscador según alguna caracteristica
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Coches.modificarCochesDisponibles(dgvBuscarCoche, ComboBox1, cmbBuscar_Autos, busquedaLista) 'Busqueda más especifica
    End Sub

    Private Sub btnModificar_Datos_Click(sender As Object, e As EventArgs) Handles btnModificar_Datos.Click
        Dim tipo As String = ""
        Try 'Controlador de error por el tipo el estado nuevo del auto
            tipo = obtenerRadio().Text
        Catch ex As Exception
            tipo = ""
        End Try

        If Coches.ModificarRenta(ComboBox2.SelectedValue, txtCosto_Renta.Text, tipo) Then 'Proceso para modificar o gestionar auto
            MsgBox("Auto modificado con exito", MsgBoxStyle.Information)
            'Se reestablece el formulario
            txtCosto_Renta.Text = ""
            tipo = ""
            ComboBox2.SelectedValue = 0
            obtenerRadio().Checked = False
        End If
    End Sub

    Private Sub mnsCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles mnsCerrar_Sesion.Click
        Session.CerrarSession() 'Cerrar sesión
        Me.Close()
    End Sub
End Class