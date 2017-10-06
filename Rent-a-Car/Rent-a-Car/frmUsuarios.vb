Imports MaterialSkin
Public Class frmUsuarios
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub btnAgregar_Usuario_Click(sender As Object, e As EventArgs) Handles btnAgregar_Usuario.Click

        If rdbAdministrador.Checked = True Then
            Administradores = New clsAdministradores
            'tipo = rdbAdministrador.Text
            If Administradores.Registrar(txbNombre.Text, txbApellido.Text) Then
                MsgBox("Registro Exitoso. Usuario:" & Administradores.ObtenerNombreUsuario & "Contraseña: " & Administradores.ObtenerContrasenna)
            End If
        ElseIf rdbAgente.Checked = True Then
            'tipo = rdbAgente.Text
            Gerente = New clsGerentes
            If Gerente.Registrar(txbNombre.Text, txbApellido.Text) Then
                MsgBox("Registro Exitoso. Usuario:" & Gerente.ObtenerNombreUsuario & "Contraseña: " & Gerente.ObtenerContrasenna)
            End If
        ElseIf rdbContador.Checked = True Then
            'tipo = rdbContador.Text
            Contador = New clsContadores
            If Contador.Registrar(txbNombre.Text, txbApellido.Text) Then
                MsgBox("Registro Exitoso. Usuario:" & Contador.ObtenerNombreUsuario & "Contraseña: " & Contador.ObtenerContrasenna)
            End If
        End If
    End Sub

    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        frmMenu_Admin.Show()
        Me.Close()
    End Sub
End Class