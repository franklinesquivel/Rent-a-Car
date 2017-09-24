<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionar_Autos
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
        Me.txbBuscar_Coche = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblBuscar_Coche = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvBuscar_Coche = New System.Windows.Forms.DataGridView()
        Me.btnModificar_Datos = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtCosto_Renta = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblCosto_Renta = New MaterialSkin.Controls.MaterialLabel()
        Me.lblEstado = New MaterialSkin.Controls.MaterialLabel()
        Me.rdbReparacion = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdbActivo = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnsCerrar_Sesion = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvBuscar_Coche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'txbBuscar_Coche
        '
        Me.txbBuscar_Coche.Depth = 0
        Me.txbBuscar_Coche.Hint = ""
        Me.txbBuscar_Coche.Location = New System.Drawing.Point(161, 95)
        Me.txbBuscar_Coche.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbBuscar_Coche.Name = "txbBuscar_Coche"
        Me.txbBuscar_Coche.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbBuscar_Coche.SelectedText = ""
        Me.txbBuscar_Coche.SelectionLength = 0
        Me.txbBuscar_Coche.SelectionStart = 0
        Me.txbBuscar_Coche.Size = New System.Drawing.Size(344, 23)
        Me.txbBuscar_Coche.TabIndex = 68
        Me.txbBuscar_Coche.UseSystemPasswordChar = False
        '
        'lblBuscar_Coche
        '
        Me.lblBuscar_Coche.AutoSize = True
        Me.lblBuscar_Coche.Depth = 0
        Me.lblBuscar_Coche.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblBuscar_Coche.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBuscar_Coche.Location = New System.Drawing.Point(25, 95)
        Me.lblBuscar_Coche.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBuscar_Coche.Name = "lblBuscar_Coche"
        Me.lblBuscar_Coche.Size = New System.Drawing.Size(100, 19)
        Me.lblBuscar_Coche.TabIndex = 67
        Me.lblBuscar_Coche.Text = "Buscar coche"
        '
        'dgvBuscar_Coche
        '
        Me.dgvBuscar_Coche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscar_Coche.Location = New System.Drawing.Point(29, 128)
        Me.dgvBuscar_Coche.Name = "dgvBuscar_Coche"
        Me.dgvBuscar_Coche.Size = New System.Drawing.Size(476, 132)
        Me.dgvBuscar_Coche.TabIndex = 66
        '
        'btnModificar_Datos
        '
        Me.btnModificar_Datos.AutoSize = True
        Me.btnModificar_Datos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnModificar_Datos.Depth = 0
        Me.btnModificar_Datos.Location = New System.Drawing.Point(205, 395)
        Me.btnModificar_Datos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnModificar_Datos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnModificar_Datos.Name = "btnModificar_Datos"
        Me.btnModificar_Datos.Primary = False
        Me.btnModificar_Datos.Size = New System.Drawing.Size(132, 36)
        Me.btnModificar_Datos.TabIndex = 69
        Me.btnModificar_Datos.Text = "Modificar datos"
        Me.btnModificar_Datos.UseVisualStyleBackColor = True
        '
        'txtCosto_Renta
        '
        Me.txtCosto_Renta.Depth = 0
        Me.txtCosto_Renta.Hint = ""
        Me.txtCosto_Renta.Location = New System.Drawing.Point(162, 286)
        Me.txtCosto_Renta.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCosto_Renta.Name = "txtCosto_Renta"
        Me.txtCosto_Renta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCosto_Renta.SelectedText = ""
        Me.txtCosto_Renta.SelectionLength = 0
        Me.txtCosto_Renta.SelectionStart = 0
        Me.txtCosto_Renta.Size = New System.Drawing.Size(344, 23)
        Me.txtCosto_Renta.TabIndex = 71
        Me.txtCosto_Renta.UseSystemPasswordChar = False
        '
        'lblCosto_Renta
        '
        Me.lblCosto_Renta.AutoSize = True
        Me.lblCosto_Renta.Depth = 0
        Me.lblCosto_Renta.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblCosto_Renta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCosto_Renta.Location = New System.Drawing.Point(26, 286)
        Me.lblCosto_Renta.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCosto_Renta.Name = "lblCosto_Renta"
        Me.lblCosto_Renta.Size = New System.Drawing.Size(108, 19)
        Me.lblCosto_Renta.TabIndex = 70
        Me.lblCosto_Renta.Text = "Costo de renta"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Depth = 0
        Me.lblEstado.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblEstado.Location = New System.Drawing.Point(26, 342)
        Me.lblEstado.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(60, 19)
        Me.lblEstado.TabIndex = 73
        Me.lblEstado.Text = "Estado:"
        '
        'rdbReparacion
        '
        Me.rdbReparacion.AutoSize = True
        Me.rdbReparacion.Depth = 0
        Me.rdbReparacion.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbReparacion.Location = New System.Drawing.Point(152, 342)
        Me.rdbReparacion.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbReparacion.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbReparacion.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbReparacion.Name = "rdbReparacion"
        Me.rdbReparacion.Ripple = True
        Me.rdbReparacion.Size = New System.Drawing.Size(98, 30)
        Me.rdbReparacion.TabIndex = 74
        Me.rdbReparacion.TabStop = True
        Me.rdbReparacion.Text = "Reparación"
        Me.rdbReparacion.UseVisualStyleBackColor = True
        '
        'rdbActivo
        '
        Me.rdbActivo.AutoSize = True
        Me.rdbActivo.Depth = 0
        Me.rdbActivo.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbActivo.Location = New System.Drawing.Point(367, 342)
        Me.rdbActivo.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbActivo.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbActivo.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbActivo.Name = "rdbActivo"
        Me.rdbActivo.Ripple = True
        Me.rdbActivo.Size = New System.Drawing.Size(68, 30)
        Me.rdbActivo.TabIndex = 75
        Me.rdbActivo.TabStop = True
        Me.rdbActivo.Text = "Activo"
        Me.rdbActivo.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(400, 433)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(106, 27)
        Me.btnRegresar.TabIndex = 76
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsCerrar_Sesion})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(533, 27)
        Me.mnsMenu.TabIndex = 77
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'mnsCerrar_Sesion
        '
        Me.mnsCerrar_Sesion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mnsCerrar_Sesion.Name = "mnsCerrar_Sesion"
        Me.mnsCerrar_Sesion.Size = New System.Drawing.Size(102, 23)
        Me.mnsCerrar_Sesion.Text = "Cerrar Sesión"
        '
        'frmGestionar_Autos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 472)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.rdbActivo)
        Me.Controls.Add(Me.rdbReparacion)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.txtCosto_Renta)
        Me.Controls.Add(Me.lblCosto_Renta)
        Me.Controls.Add(Me.btnModificar_Datos)
        Me.Controls.Add(Me.txbBuscar_Coche)
        Me.Controls.Add(Me.lblBuscar_Coche)
        Me.Controls.Add(Me.dgvBuscar_Coche)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmGestionar_Autos"
        Me.Text = "Gestionar Autos                                                                  " &
    "        Rent-a-Car"
        CType(Me.dgvBuscar_Coche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbBuscar_Coche As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblBuscar_Coche As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvBuscar_Coche As DataGridView
    Friend WithEvents btnModificar_Datos As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtCosto_Renta As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblCosto_Renta As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblEstado As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents rdbReparacion As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdbActivo As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents mnsCerrar_Sesion As ToolStripMenuItem
End Class
