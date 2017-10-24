<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGraficosRenta
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chtGraficoRentas = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cmbAño = New System.Windows.Forms.ComboBox()
        Me.lblSeleccionar = New MaterialSkin.Controls.MaterialLabel()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.chtGraficoRentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'chtGraficoRentas
        '
        Me.chtGraficoRentas.Anchor = System.Windows.Forms.AnchorStyles.Left
        ChartArea1.Name = "ChartArea1"
        Me.chtGraficoRentas.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtGraficoRentas.Legends.Add(Legend1)
        Me.chtGraficoRentas.Location = New System.Drawing.Point(12, 127)
        Me.chtGraficoRentas.Name = "chtGraficoRentas"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtGraficoRentas.Series.Add(Series1)
        Me.chtGraficoRentas.Size = New System.Drawing.Size(467, 290)
        Me.chtGraficoRentas.TabIndex = 1
        Me.chtGraficoRentas.Text = "Grafico"
        '
        'cmbAño
        '
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(247, 89)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(121, 21)
        Me.cmbAño.TabIndex = 0
        '
        'lblSeleccionar
        '
        Me.lblSeleccionar.AutoSize = True
        Me.lblSeleccionar.Depth = 0
        Me.lblSeleccionar.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSeleccionar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSeleccionar.Location = New System.Drawing.Point(39, 88)
        Me.lblSeleccionar.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSeleccionar.Name = "lblSeleccionar"
        Me.lblSeleccionar.Size = New System.Drawing.Size(202, 19)
        Me.lblSeleccionar.TabIndex = 54
        Me.lblSeleccionar.Text = "Seleccione el año a verificar:"
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(373, 428)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(106, 27)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(491, 27)
        Me.mnsMenu.TabIndex = 61
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(102, 23)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'frmGraficosRenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 467)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblSeleccionar)
        Me.Controls.Add(Me.cmbAño)
        Me.Controls.Add(Me.chtGraficoRentas)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmGraficosRenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rentas por Mes                                                                  R" &
    "ent-a-Car"
        CType(Me.chtGraficoRentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chtGraficoRentas As DataVisualization.Charting.Chart
    Friend WithEvents cmbAño As ComboBox
    Friend WithEvents lblSeleccionar As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
End Class
