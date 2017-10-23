<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportes_Rentas
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
        Me.lblFecha_Limite = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpFecha_Limite = New System.Windows.Forms.DateTimePicker()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnsCerrar_Sesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvReportes = New System.Windows.Forms.DataGridView()
        Me.lblNumRentas = New MaterialSkin.Controls.MaterialLabel()
        Me.GroupRadio = New System.Windows.Forms.GroupBox()
        Me.rdbTipoAuto = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdbAgente = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdbAgencia = New MaterialSkin.Controls.MaterialRadioButton()
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
        Me.lblFecha_Limite.Location = New System.Drawing.Point(156, 167)
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
        Me.dtpFecha_Limite.Location = New System.Drawing.Point(220, 164)
        Me.dtpFecha_Limite.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha_Limite.MinDate = New Date(2016, 9, 23, 0, 0, 0, 0)
        Me.dtpFecha_Limite.Name = "dtpFecha_Limite"
        Me.dtpFecha_Limite.Size = New System.Drawing.Size(207, 23)
        Me.dtpFecha_Limite.TabIndex = 3
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(510, 414)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(106, 27)
        Me.btnRegresar.TabIndex = 4
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
        Me.dgvReportes.Location = New System.Drawing.Point(12, 209)
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
        Me.lblNumRentas.Location = New System.Drawing.Point(12, 409)
        Me.lblNumRentas.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNumRentas.Name = "lblNumRentas"
        Me.lblNumRentas.Size = New System.Drawing.Size(114, 19)
        Me.lblNumRentas.TabIndex = 83
        Me.lblNumRentas.Text = "Total de Rentas"
        '
        'GroupRadio
        '
        Me.GroupRadio.Controls.Add(Me.rdbTipoAuto)
        Me.GroupRadio.Controls.Add(Me.rdbAgente)
        Me.GroupRadio.Controls.Add(Me.rdbAgencia)
        Me.GroupRadio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupRadio.Location = New System.Drawing.Point(78, 73)
        Me.GroupRadio.Name = "GroupRadio"
        Me.GroupRadio.Size = New System.Drawing.Size(476, 85)
        Me.GroupRadio.TabIndex = 84
        Me.GroupRadio.TabStop = False
        Me.GroupRadio.Text = "Desglosar Por"
        '
        'rdbTipoAuto
        '
        Me.rdbTipoAuto.AutoSize = True
        Me.rdbTipoAuto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbTipoAuto.Depth = 0
        Me.rdbTipoAuto.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbTipoAuto.Location = New System.Drawing.Point(321, 30)
        Me.rdbTipoAuto.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbTipoAuto.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbTipoAuto.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbTipoAuto.Name = "rdbTipoAuto"
        Me.rdbTipoAuto.Ripple = True
        Me.rdbTipoAuto.Size = New System.Drawing.Size(89, 30)
        Me.rdbTipoAuto.TabIndex = 2
        Me.rdbTipoAuto.TabStop = True
        Me.rdbTipoAuto.Text = "Tipo Auto"
        Me.rdbTipoAuto.UseVisualStyleBackColor = True
        '
        'rdbAgente
        '
        Me.rdbAgente.AutoSize = True
        Me.rdbAgente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbAgente.Depth = 0
        Me.rdbAgente.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbAgente.Location = New System.Drawing.Point(205, 30)
        Me.rdbAgente.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbAgente.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbAgente.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbAgente.Name = "rdbAgente"
        Me.rdbAgente.Ripple = True
        Me.rdbAgente.Size = New System.Drawing.Size(73, 30)
        Me.rdbAgente.TabIndex = 1
        Me.rdbAgente.TabStop = True
        Me.rdbAgente.Text = "Agente"
        Me.rdbAgente.UseVisualStyleBackColor = True
        '
        'rdbAgencia
        '
        Me.rdbAgencia.AutoSize = True
        Me.rdbAgencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbAgencia.Depth = 0
        Me.rdbAgencia.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbAgencia.Location = New System.Drawing.Point(82, 30)
        Me.rdbAgencia.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbAgencia.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbAgencia.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbAgencia.Name = "rdbAgencia"
        Me.rdbAgencia.Ripple = True
        Me.rdbAgencia.Size = New System.Drawing.Size(79, 30)
        Me.rdbAgencia.TabIndex = 0
        Me.rdbAgencia.TabStop = True
        Me.rdbAgencia.Text = "Agencia"
        Me.rdbAgencia.UseVisualStyleBackColor = True
        '
        'frmReportes_Rentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 468)
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
        Me.Text = "Reporte de rentas por mes                                                        " &
    "                       Rent-a-Car"
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
    Friend WithEvents rdbTipoAuto As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdbAgente As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdbAgencia As MaterialSkin.Controls.MaterialRadioButton
End Class
