<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGraficosRenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chtGraficoRentas = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblSeleccionar = New System.Windows.Forms.Label()
        Me.cmbAño = New System.Windows.Forms.ComboBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        CType(Me.chtGraficoRentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chtGraficoRentas
        '
        Me.chtGraficoRentas.Anchor = System.Windows.Forms.AnchorStyles.Left
        ChartArea2.Name = "ChartArea1"
        Me.chtGraficoRentas.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chtGraficoRentas.Legends.Add(Legend2)
        Me.chtGraficoRentas.Location = New System.Drawing.Point(12, 78)
        Me.chtGraficoRentas.Name = "chtGraficoRentas"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chtGraficoRentas.Series.Add(Series2)
        Me.chtGraficoRentas.Size = New System.Drawing.Size(467, 290)
        Me.chtGraficoRentas.TabIndex = 0
        Me.chtGraficoRentas.Text = "Grafico"
        '
        'lblSeleccionar
        '
        Me.lblSeleccionar.AutoSize = True
        Me.lblSeleccionar.Location = New System.Drawing.Point(40, 33)
        Me.lblSeleccionar.Name = "lblSeleccionar"
        Me.lblSeleccionar.Size = New System.Drawing.Size(144, 13)
        Me.lblSeleccionar.TabIndex = 1
        Me.lblSeleccionar.Text = "Seleccione el año a verificar:"
        '
        'cmbAño
        '
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(190, 33)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(121, 21)
        Me.cmbAño.TabIndex = 2
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(404, 386)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 3
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'frmGraficosRenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 421)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.cmbAño)
        Me.Controls.Add(Me.lblSeleccionar)
        Me.Controls.Add(Me.chtGraficoRentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmGraficosRenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rentas por Mes"
        CType(Me.chtGraficoRentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chtGraficoRentas As DataVisualization.Charting.Chart
    Friend WithEvents lblSeleccionar As Label
    Friend WithEvents cmbAño As ComboBox
    Friend WithEvents btnRegresar As Button
End Class
