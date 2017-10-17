Imports MaterialSkin
Public Class frmDevolucion_Auto
    Dim listaRentas() As clsRentas
    Private Sub frmDevolucion_Auto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Rentas = New clsRentas
        If Rentas.listarRentas(listaRentas, dgvDevolucion) = 0 Then
            MsgBox("Error: No hay rentas por devolver")
            btnConfirmar.Enabled = False
        End If

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Agentes.Show()
        Me.Hide()
    End Sub

    Private Sub rdbChocado_CheckedChanged(sender As Object, e As EventArgs) Handles rdbChocado.CheckedChanged
        txbDescripcion_Problema.Enabled = True
        txbMonto_Cancelar.Enabled = True
    End Sub
End Class