﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevolucion_Auto
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
        Me.btnConfirmar = New MaterialSkin.Controls.MaterialFlatButton()
        Me.rdbBuen_Estado = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdbChocado = New MaterialSkin.Controls.MaterialRadioButton()
        Me.lblEstado_Coche = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpFecha_Devolucion = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha_Devolucion = New MaterialSkin.Controls.MaterialLabel()
        Me.txbDescripcion_Problema = New System.Windows.Forms.TextBox()
        Me.lblDescripcion_Problema = New MaterialSkin.Controls.MaterialLabel()
        Me.lblMonto_Cancelar = New MaterialSkin.Controls.MaterialLabel()
        Me.txbMonto_Cancelar = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnsCerrar_Sesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfirmar
        '
        Me.btnConfirmar.AutoSize = True
        Me.btnConfirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmar.Depth = 0
        Me.btnConfirmar.Location = New System.Drawing.Point(237, 432)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Primary = False
        Me.btnConfirmar.Size = New System.Drawing.Size(90, 36)
        Me.btnConfirmar.TabIndex = 0
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'rdbBuen_Estado
        '
        Me.rdbBuen_Estado.AutoSize = True
        Me.rdbBuen_Estado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbBuen_Estado.Depth = 0
        Me.rdbBuen_Estado.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbBuen_Estado.Location = New System.Drawing.Point(43, 125)
        Me.rdbBuen_Estado.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbBuen_Estado.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbBuen_Estado.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbBuen_Estado.Name = "rdbBuen_Estado"
        Me.rdbBuen_Estado.Ripple = True
        Me.rdbBuen_Estado.Size = New System.Drawing.Size(124, 30)
        Me.rdbBuen_Estado.TabIndex = 1
        Me.rdbBuen_Estado.TabStop = True
        Me.rdbBuen_Estado.Text = "En buen estado"
        Me.rdbBuen_Estado.UseVisualStyleBackColor = True
        '
        'rdbChocado
        '
        Me.rdbChocado.AutoSize = True
        Me.rdbChocado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbChocado.Depth = 0
        Me.rdbChocado.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbChocado.Location = New System.Drawing.Point(212, 125)
        Me.rdbChocado.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbChocado.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbChocado.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbChocado.Name = "rdbChocado"
        Me.rdbChocado.Ripple = True
        Me.rdbChocado.Size = New System.Drawing.Size(84, 30)
        Me.rdbChocado.TabIndex = 2
        Me.rdbChocado.TabStop = True
        Me.rdbChocado.Text = "Chocado"
        Me.rdbChocado.UseVisualStyleBackColor = True
        '
        'lblEstado_Coche
        '
        Me.lblEstado_Coche.AutoSize = True
        Me.lblEstado_Coche.Depth = 0
        Me.lblEstado_Coche.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblEstado_Coche.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblEstado_Coche.Location = New System.Drawing.Point(39, 87)
        Me.lblEstado_Coche.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblEstado_Coche.Name = "lblEstado_Coche"
        Me.lblEstado_Coche.Size = New System.Drawing.Size(125, 19)
        Me.lblEstado_Coche.TabIndex = 3
        Me.lblEstado_Coche.Text = "Estado del coche"
        '
        'dtpFecha_Devolucion
        '
        Me.dtpFecha_Devolucion.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha_Devolucion.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.dtpFecha_Devolucion.Location = New System.Drawing.Point(275, 177)
        Me.dtpFecha_Devolucion.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha_Devolucion.MinDate = New Date(2017, 9, 23, 0, 0, 0, 0)
        Me.dtpFecha_Devolucion.Name = "dtpFecha_Devolucion"
        Me.dtpFecha_Devolucion.Size = New System.Drawing.Size(245, 23)
        Me.dtpFecha_Devolucion.TabIndex = 54
        '
        'lblFecha_Devolucion
        '
        Me.lblFecha_Devolucion.AutoSize = True
        Me.lblFecha_Devolucion.Depth = 0
        Me.lblFecha_Devolucion.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblFecha_Devolucion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFecha_Devolucion.Location = New System.Drawing.Point(39, 181)
        Me.lblFecha_Devolucion.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFecha_Devolucion.Name = "lblFecha_Devolucion"
        Me.lblFecha_Devolucion.Size = New System.Drawing.Size(215, 19)
        Me.lblFecha_Devolucion.TabIndex = 53
        Me.lblFecha_Devolucion.Text = "Fecha de devolución del coche"
        '
        'txbDescripcion_Problema
        '
        Me.txbDescripcion_Problema.BackColor = System.Drawing.SystemColors.Control
        Me.txbDescripcion_Problema.Location = New System.Drawing.Point(43, 245)
        Me.txbDescripcion_Problema.Multiline = True
        Me.txbDescripcion_Problema.Name = "txbDescripcion_Problema"
        Me.txbDescripcion_Problema.Size = New System.Drawing.Size(477, 99)
        Me.txbDescripcion_Problema.TabIndex = 55
        '
        'lblDescripcion_Problema
        '
        Me.lblDescripcion_Problema.AutoSize = True
        Me.lblDescripcion_Problema.Depth = 0
        Me.lblDescripcion_Problema.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblDescripcion_Problema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDescripcion_Problema.Location = New System.Drawing.Point(39, 214)
        Me.lblDescripcion_Problema.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblDescripcion_Problema.Name = "lblDescripcion_Problema"
        Me.lblDescripcion_Problema.Size = New System.Drawing.Size(180, 19)
        Me.lblDescripcion_Problema.TabIndex = 56
        Me.lblDescripcion_Problema.Text = "Descripción del problema"
        '
        'lblMonto_Cancelar
        '
        Me.lblMonto_Cancelar.AutoSize = True
        Me.lblMonto_Cancelar.Depth = 0
        Me.lblMonto_Cancelar.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblMonto_Cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMonto_Cancelar.Location = New System.Drawing.Point(42, 361)
        Me.lblMonto_Cancelar.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblMonto_Cancelar.Name = "lblMonto_Cancelar"
        Me.lblMonto_Cancelar.Size = New System.Drawing.Size(217, 19)
        Me.lblMonto_Cancelar.TabIndex = 57
        Me.lblMonto_Cancelar.Text = "Monto a cancelar por el cliente"
        '
        'txbMonto_Cancelar
        '
        Me.txbMonto_Cancelar.Depth = 0
        Me.txbMonto_Cancelar.Hint = ""
        Me.txbMonto_Cancelar.Location = New System.Drawing.Point(46, 394)
        Me.txbMonto_Cancelar.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbMonto_Cancelar.Name = "txbMonto_Cancelar"
        Me.txbMonto_Cancelar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbMonto_Cancelar.SelectedText = ""
        Me.txbMonto_Cancelar.SelectionLength = 0
        Me.txbMonto_Cancelar.SelectionStart = 0
        Me.txbMonto_Cancelar.Size = New System.Drawing.Size(474, 23)
        Me.txbMonto_Cancelar.TabIndex = 58
        Me.txbMonto_Cancelar.UseSystemPasswordChar = False
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(414, 467)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(106, 27)
        Me.btnRegresar.TabIndex = 59
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsCerrar_Sesion})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(562, 27)
        Me.mnsMenu.TabIndex = 60
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'mnsCerrar_Sesion
        '
        Me.mnsCerrar_Sesion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mnsCerrar_Sesion.Name = "mnsCerrar_Sesion"
        Me.mnsCerrar_Sesion.Size = New System.Drawing.Size(102, 23)
        Me.mnsCerrar_Sesion.Text = "Cerrar Sesión"
        '
        'frmDevolucion_Auto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 506)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.txbMonto_Cancelar)
        Me.Controls.Add(Me.lblMonto_Cancelar)
        Me.Controls.Add(Me.lblDescripcion_Problema)
        Me.Controls.Add(Me.txbDescripcion_Problema)
        Me.Controls.Add(Me.dtpFecha_Devolucion)
        Me.Controls.Add(Me.lblFecha_Devolucion)
        Me.Controls.Add(Me.lblEstado_Coche)
        Me.Controls.Add(Me.rdbChocado)
        Me.Controls.Add(Me.rdbBuen_Estado)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmDevolucion_Auto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devolución de coches                                                             " &
    "          Rent-a-Car"
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfirmar As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents rdbBuen_Estado As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdbChocado As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents lblEstado_Coche As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpFecha_Devolucion As DateTimePicker
    Friend WithEvents lblFecha_Devolucion As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbDescripcion_Problema As TextBox
    Friend WithEvents lblDescripcion_Problema As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblMonto_Cancelar As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbMonto_Cancelar As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents mnsCerrar_Sesion As ToolStripMenuItem
End Class
