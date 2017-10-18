Imports MaterialSkin

Public Class frmReportes_Coches
    Private Sub frmReporte_renta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

        Coches = New clsCoches
        If Not Coches.Reporte("", dgvCodigo_Renta) Then
            MsgBox("Error: No hay datos por mostrar")
            txbCodigo_Renta.Enabled = False
        End If
    End Sub

    Private Sub btnRegrear_Click(sender As Object, e As EventArgs) Handles btnRegrear.Click
        frmMenu_Admin.Show()
        Me.Hide()
    End Sub

    Private Sub txbCodigo_Renta_KeyUp(sender As Object, e As KeyEventArgs) Handles txbCodigo_Renta.KeyUp
        Coches.Reporte(txbCodigo_Renta.Text.Trim, dgvCodigo_Renta)
    End Sub
End Class