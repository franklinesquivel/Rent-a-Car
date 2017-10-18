Imports MaterialSkin
Public Class frmAgencias
    Private Sub frmAgencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub btnAgregar_Agencia_Click(sender As Object, e As EventArgs) Handles btnAgregar_Agencia.Click
        Agencia = New clsAgencias
        If Agencia.registrarAgencia(txbNombre_Agencia.Text, txbDireccion.Text, txbTelefono.Text) Then
            MsgBox("Registro Exitoso")
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Close()
    End Sub

    Private Sub mnsCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles mnsCerrar_Sesion.Click
        Session.CerrarSession()
    End Sub
End Class