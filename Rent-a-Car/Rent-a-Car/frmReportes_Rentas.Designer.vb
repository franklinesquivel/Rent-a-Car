<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes_Rentas
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chtGrafica_Renta = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblAño = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpAño = New System.Windows.Forms.DateTimePicker()
        Me.btnVer_Datos = New MaterialSkin.Controls.MaterialFlatButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblTipo_Renta = New MaterialSkin.Controls.MaterialLabel()
        Me.lblFecha_Limite = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpFecha_Limite = New System.Windows.Forms.DateTimePicker()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnsCerrar_Sesion = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.chtGrafica_Renta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'chtGrafica_Renta
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtGrafica_Renta.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtGrafica_Renta.Legends.Add(Legend1)
        Me.chtGrafica_Renta.Location = New System.Drawing.Point(72, 258)
        Me.chtGrafica_Renta.Name = "chtGrafica_Renta"
        Me.chtGrafica_Renta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtGrafica_Renta.Series.Add(Series1)
        Me.chtGrafica_Renta.Size = New System.Drawing.Size(300, 282)
        Me.chtGrafica_Renta.TabIndex = 61
        Me.chtGrafica_Renta.Text = "Rentas por mes"
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Depth = 0
        Me.lblAño.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblAño.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAño.Location = New System.Drawing.Point(38, 124)
        Me.lblAño.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(132, 19)
        Me.lblAño.TabIndex = 60
        Me.lblAño.Text = "Seleccione un año"
        '
        'dtpAño
        '
        Me.dtpAño.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAño.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.dtpAño.Location = New System.Drawing.Point(184, 124)
        Me.dtpAño.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpAño.MinDate = New Date(2016, 9, 23, 0, 0, 0, 0)
        Me.dtpAño.Name = "dtpAño"
        Me.dtpAño.Size = New System.Drawing.Size(234, 23)
        Me.dtpAño.TabIndex = 59
        '
        'btnVer_Datos
        '
        Me.btnVer_Datos.AutoSize = True
        Me.btnVer_Datos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVer_Datos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVer_Datos.Depth = 0
        Me.btnVer_Datos.Location = New System.Drawing.Point(160, 213)
        Me.btnVer_Datos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnVer_Datos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnVer_Datos.Name = "btnVer_Datos"
        Me.btnVer_Datos.Primary = False
        Me.btnVer_Datos.Size = New System.Drawing.Size(85, 36)
        Me.btnVer_Datos.TabIndex = 62
        Me.btnVer_Datos.Text = "Ver datos"
        Me.btnVer_Datos.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Agente", "Agencia", "Tipo de Auto"})
        Me.ComboBox1.Location = New System.Drawing.Point(231, 79)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 21)
        Me.ComboBox1.TabIndex = 63
        '
        'lblTipo_Renta
        '
        Me.lblTipo_Renta.AutoSize = True
        Me.lblTipo_Renta.Depth = 0
        Me.lblTipo_Renta.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblTipo_Renta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTipo_Renta.Location = New System.Drawing.Point(38, 78)
        Me.lblTipo_Renta.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTipo_Renta.Name = "lblTipo_Renta"
        Me.lblTipo_Renta.Size = New System.Drawing.Size(187, 19)
        Me.lblTipo_Renta.TabIndex = 64
        Me.lblTipo_Renta.Text = "Seleccione el tipo de renta"
        '
        'lblFecha_Limite
        '
        Me.lblFecha_Limite.AutoSize = True
        Me.lblFecha_Limite.Depth = 0
        Me.lblFecha_Limite.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblFecha_Limite.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFecha_Limite.Location = New System.Drawing.Point(38, 168)
        Me.lblFecha_Limite.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFecha_Limite.Name = "lblFecha_Limite"
        Me.lblFecha_Limite.Size = New System.Drawing.Size(91, 19)
        Me.lblFecha_Limite.TabIndex = 66
        Me.lblFecha_Limite.Text = "Fecha límite"
        '
        'dtpFecha_Limite
        '
        Me.dtpFecha_Limite.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha_Limite.Enabled = False
        Me.dtpFecha_Limite.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.dtpFecha_Limite.Location = New System.Drawing.Point(184, 168)
        Me.dtpFecha_Limite.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha_Limite.MinDate = New Date(2016, 9, 23, 0, 0, 0, 0)
        Me.dtpFecha_Limite.Name = "dtpFecha_Limite"
        Me.dtpFecha_Limite.Size = New System.Drawing.Size(234, 23)
        Me.dtpFecha_Limite.TabIndex = 65
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(312, 546)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(106, 27)
        Me.btnRegresar.TabIndex = 77
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsCerrar_Sesion})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(445, 27)
        Me.mnsMenu.TabIndex = 78
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'mnsCerrar_Sesion
        '
        Me.mnsCerrar_Sesion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mnsCerrar_Sesion.Name = "mnsCerrar_Sesion"
        Me.mnsCerrar_Sesion.Size = New System.Drawing.Size(102, 23)
        Me.mnsCerrar_Sesion.Text = "Cerrar Sesión"
        '
        'frmReportes_Rentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 585)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblFecha_Limite)
        Me.Controls.Add(Me.dtpFecha_Limite)
        Me.Controls.Add(Me.lblTipo_Renta)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnVer_Datos)
        Me.Controls.Add(Me.chtGrafica_Renta)
        Me.Controls.Add(Me.lblAño)
        Me.Controls.Add(Me.dtpAño)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmReportes_Rentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de rentas por mes                                  Rent-a-Car"
        CType(Me.chtGrafica_Renta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chtGrafica_Renta As DataVisualization.Charting.Chart
    Friend WithEvents lblAño As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpAño As DateTimePicker
    Friend WithEvents btnVer_Datos As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblTipo_Renta As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblFecha_Limite As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpFecha_Limite As DateTimePicker
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents mnsCerrar_Sesion As ToolStripMenuItem
End Class
