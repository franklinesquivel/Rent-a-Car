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
        Me.lblFecha_Limite = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpFecha_Limite = New System.Windows.Forms.DateTimePicker()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnsCerrar_Sesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvReportes = New System.Windows.Forms.DataGridView()
        Me.lblNumRentas = New MaterialSkin.Controls.MaterialLabel()
        Me.GroupRadio = New System.Windows.Forms.GroupBox()
        Me.rdbTipoAuto = New System.Windows.Forms.RadioButton()
        Me.rdbAgencia = New System.Windows.Forms.RadioButton()
        Me.rdbAgente = New System.Windows.Forms.RadioButton()
        Me.mnsMenu.SuspendLayout()
        CType(Me.dgvReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupRadio.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFecha_Limite
        '
        Me.lblFecha_Limite.AutoSize = True
        Me.lblFecha_Limite.Depth = 0
        Me.lblFecha_Limite.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblFecha_Limite.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFecha_Limite.Location = New System.Drawing.Point(156, 137)
        Me.lblFecha_Limite.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFecha_Limite.Name = "lblFecha_Limite"
        Me.lblFecha_Limite.Size = New System.Drawing.Size(49, 19)
        Me.lblFecha_Limite.TabIndex = 66
        Me.lblFecha_Limite.Text = "Fecha"
        '
        'dtpFecha_Limite
        '
        Me.dtpFecha_Limite.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha_Limite.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.dtpFecha_Limite.Location = New System.Drawing.Point(220, 134)
        Me.dtpFecha_Limite.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha_Limite.MinDate = New Date(2016, 9, 23, 0, 0, 0, 0)
        Me.dtpFecha_Limite.Name = "dtpFecha_Limite"
        Me.dtpFecha_Limite.Size = New System.Drawing.Size(207, 23)
        Me.dtpFecha_Limite.TabIndex = 65
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(510, 384)
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
        Me.mnsMenu.Size = New System.Drawing.Size(628, 27)
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
        'dgvReportes
        '
        Me.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReportes.Location = New System.Drawing.Point(12, 179)
        Me.dgvReportes.Name = "dgvReportes"
        Me.dgvReportes.Size = New System.Drawing.Size(604, 184)
        Me.dgvReportes.TabIndex = 82
        '
        'lblNumRentas
        '
        Me.lblNumRentas.AutoSize = True
        Me.lblNumRentas.Depth = 0
        Me.lblNumRentas.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblNumRentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNumRentas.Location = New System.Drawing.Point(12, 379)
        Me.lblNumRentas.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNumRentas.Name = "lblNumRentas"
        Me.lblNumRentas.Size = New System.Drawing.Size(114, 19)
        Me.lblNumRentas.TabIndex = 83
        Me.lblNumRentas.Text = "Total de Rentas"
        '
        'GroupRadio
        '
        Me.GroupRadio.Controls.Add(Me.rdbTipoAuto)
        Me.GroupRadio.Controls.Add(Me.rdbAgencia)
        Me.GroupRadio.Controls.Add(Me.rdbAgente)
        Me.GroupRadio.Location = New System.Drawing.Point(146, 73)
        Me.GroupRadio.Name = "GroupRadio"
        Me.GroupRadio.Size = New System.Drawing.Size(367, 55)
        Me.GroupRadio.TabIndex = 84
        Me.GroupRadio.TabStop = False
        Me.GroupRadio.Text = "Desglosar Por"
        '
        'rdbTipoAuto
        '
        Me.rdbTipoAuto.AutoSize = True
        Me.rdbTipoAuto.Location = New System.Drawing.Point(271, 25)
        Me.rdbTipoAuto.Name = "rdbTipoAuto"
        Me.rdbTipoAuto.Size = New System.Drawing.Size(71, 17)
        Me.rdbTipoAuto.TabIndex = 85
        Me.rdbTipoAuto.TabStop = True
        Me.rdbTipoAuto.Text = "Tipo Auto"
        Me.rdbTipoAuto.UseVisualStyleBackColor = True
        '
        'rdbAgencia
        '
        Me.rdbAgencia.AutoSize = True
        Me.rdbAgencia.Location = New System.Drawing.Point(14, 25)
        Me.rdbAgencia.Name = "rdbAgencia"
        Me.rdbAgencia.Size = New System.Drawing.Size(64, 17)
        Me.rdbAgencia.TabIndex = 85
        Me.rdbAgencia.TabStop = True
        Me.rdbAgencia.Text = "Agencia"
        Me.rdbAgencia.UseVisualStyleBackColor = True
        '
        'rdbAgente
        '
        Me.rdbAgente.AutoSize = True
        Me.rdbAgente.Location = New System.Drawing.Point(150, 25)
        Me.rdbAgente.Name = "rdbAgente"
        Me.rdbAgente.Size = New System.Drawing.Size(59, 17)
        Me.rdbAgente.TabIndex = 86
        Me.rdbAgente.TabStop = True
        Me.rdbAgente.Text = "Agente"
        Me.rdbAgente.UseVisualStyleBackColor = True
        '
        'frmReportes_Rentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 432)
        Me.Controls.Add(Me.GroupRadio)
        Me.Controls.Add(Me.lblNumRentas)
        Me.Controls.Add(Me.dgvReportes)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblFecha_Limite)
        Me.Controls.Add(Me.dtpFecha_Limite)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmReportes_Rentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de rentas por mes                                  Rent-a-Car"
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        CType(Me.dgvReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupRadio.ResumeLayout(False)
        Me.GroupRadio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFecha_Limite As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpFecha_Limite As DateTimePicker
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents mnsCerrar_Sesion As ToolStripMenuItem
    Friend WithEvents dgvReportes As DataGridView
    Friend WithEvents lblNumRentas As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents GroupRadio As GroupBox
    Friend WithEvents rdbAgencia As RadioButton
    Friend WithEvents rdbTipoAuto As RadioButton
    Friend WithEvents rdbAgente As RadioButton
End Class
