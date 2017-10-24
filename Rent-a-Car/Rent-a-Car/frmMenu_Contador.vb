﻿Imports MaterialSkin
Public Class frmMenu_contador
    Private Sub frmMenu_contador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub btnEstado_Autos_Click(sender As Object, e As EventArgs) Handles btnEstado_Autos.Click
        frmGestionar_Autos.Show()
        Me.Hide()
    End Sub

    Private Sub btnIngresar_Auto_Click(sender As Object, e As EventArgs) Handles btnIngresar_Auto.Click
        frmCoches.Show()
        Me.Hide()
    End Sub

    Private Sub btnModificar_Auto_Click(sender As Object, e As EventArgs) Handles btnModificar_Auto.Click
        frmModificar_Coche.Show()
        Me.Hide()
    End Sub

    Private Sub btnReportes_Rentas_Click(sender As Object, e As EventArgs) Handles btnReportes_Rentas.Click
        frmReportes_Rentas.Show()
        Me.Hide()
    End Sub

    Private Sub btnReportes_Coches_Click(sender As Object, e As EventArgs) Handles btnReportes_Coches.Click
        frmReportes_Coches.Show()
        Me.Hide()
    End Sub

    Private Sub btnCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles btnCerrar_Sesion.Click
        frmInicio_Sesion.Show()
        Me.Close()
    End Sub

    Private Sub btnRentasMes_Click(sender As Object, e As EventArgs) Handles btnRentasMes.Click
        frmGraficosRenta.Show()
        Me.Hide()
    End Sub

    Private Sub btnRentasAgencias_Click(sender As Object, e As EventArgs) Handles btnRentasAgencias.Click
        frmGraficosAgencia.Show()
        Me.Hide()
    End Sub

    Private Sub lblGraficos_Click(sender As Object, e As EventArgs) Handles lblGraficos.Click

    End Sub

    Private Sub lblGestionar_Autos_Click(sender As Object, e As EventArgs) Handles lblGestionar_Autos.Click

    End Sub

    Private Sub lblReportes_Click(sender As Object, e As EventArgs) Handles lblReportes.Click

    End Sub
End Class