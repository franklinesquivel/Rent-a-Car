<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraficosAgencia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.cmbAño = New System.Windows.Forms.ComboBox()
        Me.lblSeleccionar = New System.Windows.Forms.Label()
        Me.chtGraficoAgencias = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chtGraficoAgencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(405, 380)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 7
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'cmbAño
        '
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(191, 27)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(121, 21)
        Me.cmbAño.TabIndex = 6
        '
        'lblSeleccionar
        '
        Me.lblSeleccionar.AutoSize = True
        Me.lblSeleccionar.Location = New System.Drawing.Point(41, 27)
        Me.lblSeleccionar.Name = "lblSeleccionar"
        Me.lblSeleccionar.Size = New System.Drawing.Size(144, 13)
        Me.lblSeleccionar.TabIndex = 5
        Me.lblSeleccionar.Text = "Seleccione el año a verificar:"
        '
        'chtGraficoAgencias
        '
        Me.chtGraficoAgencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea3.Name = "ChartArea1"
        Me.chtGraficoAgencias.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chtGraficoAgencias.Legends.Add(Legend3)
        Me.chtGraficoAgencias.Location = New System.Drawing.Point(13, 72)
        Me.chtGraficoAgencias.Name = "chtGraficoAgencias"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.chtGraficoAgencias.Series.Add(Series3)
        Me.chtGraficoAgencias.Size = New System.Drawing.Size(467, 302)
        Me.chtGraficoAgencias.TabIndex = 4
        Me.chtGraficoAgencias.Text = "Grafico"
        '
        'frmGraficosAgencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 410)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.cmbAño)
        Me.Controls.Add(Me.lblSeleccionar)
        Me.Controls.Add(Me.chtGraficoAgencias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmGraficosAgencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rentas por Agencia"
        CType(Me.chtGraficoAgencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegresar As Button
    Friend WithEvents cmbAño As ComboBox
    Friend WithEvents lblSeleccionar As Label
    Friend WithEvents chtGraficoAgencias As DataVisualization.Charting.Chart
End Class
