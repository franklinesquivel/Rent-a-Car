Imports MaterialSkin
Public Class frmDevolucion_Auto
    Dim listaRentas() As clsRentas
    Dim multa As Decimal
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
        txbDescripcion_Problema.Enabled = False
        btnCalcular.Enabled = False
    End Sub
    Private Sub dgvDevolucion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDevolucion.CellClick
        If dgvDevolucion.CurrentCell.Value <> "" Then
            lblPlaca.Text = dgvDevolucion.CurrentRow.Cells(3).Value
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Agentes.Show()
        Me.Close()
    End Sub

    Private Sub rdbChocado_CheckedChanged(sender As Object, e As EventArgs) Handles rdbChocado.CheckedChanged
        txbDescripcion_Problema.Enabled = True
        txbMonto_Cancelar.Enabled = True
        btnConfirmar.Enabled = False
        btnCalcular.Enabled = True
    End Sub

    Private Sub rdbBuen_Estado_CheckedChanged(sender As Object, e As EventArgs) Handles rdbBuen_Estado.CheckedChanged
        txbDescripcion_Problema.Enabled = False
        txbMonto_Cancelar.Enabled = False
        btnConfirmar.Enabled = True
        btnCalcular.Enabled = False
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim indice As Integer = dgvDevolucion.CurrentRow.Cells(0).Value
        Dim fechaE As Date = dgvDevolucion.CurrentRow.Cells(5).Value
        Dim descripcion = txbDescripcion_Problema.Text
        If rdbBuen_Estado.Checked And (dtpFecha_Devolucion.Value <= fechaE) Then
            txbMonto_Cancelar.Enabled = False
            btnCalcular.Enabled = False
            If indice > -1 Then
                If Rentas.Devolucion(indice) Then
                    MsgBox("Auto Devuelto con exito")
                Else
                    MsgBox("Error: Problemas de ejecución")
                End If
            End If
        ElseIf rdbBuen_Estado.Checked And (dtpFecha_Devolucion.Value > fechaE) And Val(txbMonto_Cancelar.Text) = Rentas.Total Then
            Rentas.DevolucionDespues(indice, descripcion)
            MsgBox("Auto Devuelto Con Exito")
        ElseIf rdbChocado.Checked And (dtpFecha_Devolucion.Value <= fechaE) Then
            Rentas.CocheChocado(indice, descripcion, multa)
        Else
            MsgBox("Selecciona el estado del Coche y Fecha de Devolucion")
        End If
    End Sub

    Public Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If rdbBuen_Estado.Checked Then
            Dim fechaE As Date = dgvDevolucion.CurrentRow.Cells(5).Value
            Rentas.Calcular(dtpFecha_Devolucion.Value, fechaE)
            btnConfirmar.Enabled = True
        Else
            multa = InputBox("Ingrese la Multa por el coche chocado")
            btnConfirmar.Enabled = True
        End If
    End Sub

    Private Sub dtpFecha_Devolucion_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha_Devolucion.ValueChanged
        Dim fechaE As Date = dgvDevolucion.CurrentRow.Cells(5).Value
        If rdbBuen_Estado.Checked And (dtpFecha_Devolucion.Value > fechaE) Then
            btnCalcular.Enabled = True
            btnConfirmar.Enabled = False
        End If
    End Sub
End Class