Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports MaterialSkin
Public Class frmGraficosAgencia
    Private Conexion As clsConexion = New clsConexion()
    Private Sub frmGraficosAgencia_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbAño.DataSource = Enumerable.Range(2017, 10).ToList
        cmbAño.SelectedItem = Nothing
        chtGraficoAgencias.Series.Clear()
        chtGraficoAgencias.Titles.Clear()
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Session.ControlarSession() 'Se controla la sesión
        'Agregar el titulo de la grafica
        chtGraficoAgencias.Titles.Add("Rentas por Agencias")

        'Cambiar el tipo de letra para la grafica
        chtGraficoAgencias.Titles(0).Font = New Font("Tahoma", 15, FontStyle.Bold)

    End Sub
    Private Sub cmbAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAño.SelectedIndexChanged
        chtGraficoAgencias.Series.Clear()
        chtGraficoAgencias.Titles.Clear()

        'Agregar el titulo de la grafica
        chtGraficoAgencias.Titles.Add("Rentas por Agencias")

        'Cambiar el tipo de letra para la grafica
        chtGraficoAgencias.Titles(0).Font = New Font("Tahoma", 15, FontStyle.Bold)
        Dim año As Integer = cmbAño.SelectedItem
        Dim reader As MySqlDataReader
        Dim consulta = "Select count(*) As 'Num_inspecciones', agencias.nombre As 'Agencia' FROM rentas INNER JOIN agencias On rentas.id_agencia = agencias.id_agencia WHERE YEAR(fecha_retiro) = '" & año & "'GROUP BY YEAR(fecha_retiro), agencias.nombre"
        If Conexion.contarFilas(consulta) > 0 Then 'Contamos la fila para ver si existen registros con los datos seleccionados
            Conexion.obtenerDatos(consulta, reader) 'Se extraen los datos
            While reader.Read()
                chtGraficoAgencias.Series.Add(reader(1))
                chtGraficoAgencias.Series(reader(1)).ChartType = SeriesChartType.Column
                chtGraficoAgencias.Series(reader(1)).Points.AddY(reader(0))
                chtGraficoAgencias.Series(reader(1)).IsValueShownAsLabel = True
            End While
            reader.Close()
        End If

    End Sub
    Private Sub btnRegresar_Click_1(sender As Object, e As EventArgs) Handles btnRegresar.Click
        frmMenu_Admin.Show()
        Me.Close()
    End Sub
    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Session.CerrarSession() 'Se cierra la sesión
        Me.Close()
    End Sub
End Class