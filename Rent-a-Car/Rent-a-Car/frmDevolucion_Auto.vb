Imports MaterialSkin
Public Class frmDevolucion_Auto
    Dim listaRentas() As clsRentas 'Arreglo que contiene instancias de clases
    Dim multa As Decimal
    Private Sub frmDevolucion_Auto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Session.ControlarSession() 'Se controla la sesión

        InicializarFormulario()

    End Sub
    Private Sub dgvDevolucion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDevolucion.CellClick
        If dgvDevolucion.CurrentCell.Value <> "" Then
            lblPlaca.Text = dgvDevolucion.CurrentRow.Cells(3).Value
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Close()
    End Sub

    Private Sub rdbChocado_CheckedChanged(sender As Object, e As EventArgs) Handles rdbChocado.CheckedChanged
        txbDescripcion_Problema.Enabled = True
        'btnConfirmar.Enabled = True
    End Sub

    Private Sub rdbBuen_Estado_CheckedChanged(sender As Object, e As EventArgs) Handles rdbBuen_Estado.CheckedChanged
        txbDescripcion_Problema.Enabled = False
        'btnConfirmar.Enabled = True
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        'Se lleva a cabo el proceso de devolución
        Dim indice As Integer = Rentas.BuscarIndice(dgvDevolucion.CurrentRow.Cells(0).Value, listaRentas) 'Se obtiene el id
        Dim fechaE As Date = dgvDevolucion.CurrentRow.Cells(5).Value
        Dim descripcion = txbDescripcion_Problema.Text

        Dim registro As Boolean = False
        Dim tipoDevolucion As Integer = 0

        'Se verifica el estado del coche
        If rdbBuen_Estado.Checked = True And (dtpFecha_Devolucion.Value.ToString("yyyy-MM-dd") <= fechaE) Then
            registro = True
            tipoDevolucion = 1
        ElseIf rdbChocado.Checked = True And (dtpFecha_Devolucion.Value.ToString("yyyy-MM-dd") <= fechaE) Then
            registro = True
            tipoDevolucion = 2
        Else
            MsgBox("Error: Seleccione estado del coche")
        End If

        If registro Then 'Si se selecciono uno de las dos opciones para el estado del coche
            If indice > -1 Then 'Se verifica que exista una renta correcta
                'Se verifica el tipo devolución a realizar
                If tipoDevolucion = 1 Then
                    If Rentas.DevolverCoche(listaRentas(indice).ObtenerCodigoRenta, tipoDevolucion, fechaE, dtpFecha_Devolucion.Value.ToString("yyyy-MM-dd")) Then
                        InicializarFormulario()
                        MsgBox("Devolucón exitosa")
                    End If
                ElseIf tipoDevolucion = 2 Then
                    If Rentas.DevolverCoche(listaRentas(indice).ObtenerCodigoRenta, tipoDevolucion, fechaE, dtpFecha_Devolucion.Value.ToString("yyyy-MM-dd"), txbDescripcion_Problema.Text) Then
                        InicializarFormulario()
                        MsgBox("Devolución exitosa")
                    End If
                End If
            Else
                MsgBox("Error: Favor seleccionar una renta")
            End If
        End If
    End Sub
    Private Sub dtpFecha_Devolucion_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha_Devolucion.ValueChanged
        'Dim fechaE As Date = dgvDevolucion.CurrentRow.Cells(5).Value
        'If rdbBuen_Estado.Checked And (dtpFecha_Devolucion.Value > fechaE) Then 'Se verifica la fecha
        'btnConfirmar.Enabled = False
        'End If
    End Sub

    Private Sub mnsCerrar_Sesion_Click(sender As Object, e As EventArgs) Handles mnsCerrar_Sesion.Click
        Session.CerrarSession() 'Se cierra la sesión
    End Sub

    Private Sub InicializarFormulario()
        Rentas = New clsRentas 'Se instancia objeto tipo clase renta
        If Rentas.listarRentas(listaRentas, dgvDevolucion) = 0 Then 'Verificamos si hay coches por devolver
            MsgBox("Error: No hay rentas por devolver")
            btnConfirmar.Enabled = False
        End If
        txbDescripcion_Problema.Enabled = False
    End Sub
End Class