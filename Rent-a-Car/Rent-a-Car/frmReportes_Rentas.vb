Imports MaterialSkin
Public Class frmReportes_Rentas
    Private Sub frmRenta_Auto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Session.ControlarSession() 'Controlador de sesion
        Rentas = New clsRentas 'Se instancia la clase
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Close()
    End Sub

    Private Sub dtpFecha_Limite_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha_Limite.ValueChanged
        Dim tipo As String
        'Se lista los reportes por el mes seleccionado y el tipo de reporte seleccionado
        If rdbAgencia.Checked = True Then
            tipo = "Agencia"
        ElseIf rdbAgente.Checked = True Then
            tipo = "Agente"

        ElseIf rdbTipoAuto.Checked = True Then
            tipo = "Auto"
        Else
            MsgBox("Error: Debe elegir porque tipo desea desglosar")
            Exit Sub
        End If
        If Not Rentas.Reportes(tipo, dgvReportes, dtpFecha_Limite.Value.ToString("yyyy-MM-dd")) Then 'Se procesa la petición
            MsgBox("Error: No hay datos por mostrar")
        End If
    End Sub

    Private Sub rdbAgencia_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdbAgencia.CheckedChanged
        'Se ejecuta la busqueda al cambiar de estado el rdb
        If rdbAgencia.Checked = True Then
            If Not Rentas.Reportes("Agencia", dgvReportes) Then
                MsgBox("Error: No hay datos por mostrar")
            End If
        End If
    End Sub

    Private Sub rdbAgente_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdbAgente.CheckedChanged
        'Se ejecuta la busqueda al cambiar de estado el rdb
        If rdbAgente.Checked = True Then
            If Not Rentas.Reportes("Agente", dgvReportes) Then
                MsgBox("Error: No hay datos por mostrar")
            End If
        End If
    End Sub

    Private Sub rdbTipoAuto_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdbTipoAuto.CheckedChanged
        'Se ejecuta la busqueda al cambiar de estado el rdb
        If rdbTipoAuto.Checked = True Then
            If Not Rentas.Reportes("Auto", dgvReportes) Then
                MsgBox("Error: No hay datos por mostrar")
            End If
        End If
    End Sub

    Private Sub mnsCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles mnsCerrar_Sesion.Click
        Session.CerrarSession() 'Cerrar Sesión
    End Sub
End Class