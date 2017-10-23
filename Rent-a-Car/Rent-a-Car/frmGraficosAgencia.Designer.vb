<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraficosAgencia
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.cmbAño = New System.Windows.Forms.ComboBox()
        Me.chtGraficoAgencias = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblSeleccionar = New MaterialSkin.Controls.MaterialLabel()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.chtGraficoAgencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbAño
        '
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(239, 87)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(121, 21)
        Me.cmbAño.TabIndex = 6
        '
        'chtGraficoAgencias
        '
        Me.chtGraficoAgencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea5.Name = "ChartArea1"
        Me.chtGraficoAgencias.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.chtGraficoAgencias.Legends.Add(Legend5)
        Me.chtGraficoAgencias.Location = New System.Drawing.Point(15, 114)
        Me.chtGraficoAgencias.Name = "chtGraficoAgencias"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.chtGraficoAgencias.Series.Add(Series5)
        Me.chtGraficoAgencias.Size = New System.Drawing.Size(442, 313)
        Me.chtGraficoAgencias.TabIndex = 4
        Me.chtGraficoAgencias.Text = "Grafico"
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(351, 430)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(106, 27)
        Me.btnRegresar.TabIndex = 60
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'lblSeleccionar
        '
        Me.lblSeleccionar.AutoSize = True
        Me.lblSeleccionar.Depth = 0
        Me.lblSeleccionar.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSeleccionar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSeleccionar.Location = New System.Drawing.Point(31, 86)
        Me.lblSeleccionar.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSeleccionar.Name = "lblSeleccionar"
        Me.lblSeleccionar.Size = New System.Drawing.Size(202, 19)
        Me.lblSeleccionar.TabIndex = 61
        Me.lblSeleccionar.Text = "Seleccione el año a verificar:"
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(478, 27)
        Me.mnsMenu.TabIndex = 62
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(102, 23)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'frmGraficosAgencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 469)
        Me.Controls.Add(Me.lblSeleccionar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.cmbAño)
        Me.Controls.Add(Me.chtGraficoAgencias)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmGraficosAgencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rentas por Agencia                                                      Rent-a-Ca" &
    "r"
        CType(Me.chtGraficoAgencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbAño As ComboBox
    Friend WithEvents chtGraficoAgencias As DataVisualization.Charting.Chart
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblSeleccionar As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
End Class
