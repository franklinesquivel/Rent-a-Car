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
        Me.btnModificar_Datos = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtCosto_Renta = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblCosto_Renta = New MaterialSkin.Controls.MaterialLabel()
        Me.lblEstado = New MaterialSkin.Controls.MaterialLabel()
        Me.rdbReparacion = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdbActivo = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnsCerrar_Sesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmbBuscar_Autos = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvBuscarCoche = New System.Windows.Forms.DataGridView()
        Me.lblMatricula = New MaterialSkin.Controls.MaterialLabel()
        Me.mnsMenu.SuspendLayout()
        CType(Me.dgvBuscarCoche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModificar_Datos
        '
        Me.btnModificar_Datos.AutoSize = True
        Me.btnModificar_Datos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnModificar_Datos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar_Datos.Depth = 0
        Me.btnModificar_Datos.Location = New System.Drawing.Point(205, 395)
        Me.btnModificar_Datos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnModificar_Datos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnModificar_Datos.Name = "btnModificar_Datos"
        Me.btnModificar_Datos.Primary = False
        Me.btnModificar_Datos.Size = New System.Drawing.Size(132, 36)
        Me.btnModificar_Datos.TabIndex = 6
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
        Me.txtCosto_Renta.Size = New System.Drawing.Size(359, 23)
        Me.txtCosto_Renta.TabIndex = 3
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
        Me.rdbReparacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbReparacion.Depth = 0
        Me.rdbReparacion.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbReparacion.Location = New System.Drawing.Point(152, 342)
        Me.rdbReparacion.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbReparacion.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbReparacion.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbReparacion.Name = "rdbReparacion"
        Me.rdbReparacion.Ripple = True
        Me.rdbReparacion.Size = New System.Drawing.Size(98, 30)
        Me.rdbReparacion.TabIndex = 4
        Me.rdbReparacion.TabStop = True
        Me.rdbReparacion.Text = "Reparación"
        Me.rdbReparacion.UseVisualStyleBackColor = True
        '
        'rdbActivo
        '
        Me.rdbActivo.AutoSize = True
        Me.rdbActivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbActivo.Depth = 0
        Me.rdbActivo.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbActivo.Location = New System.Drawing.Point(367, 342)
        Me.rdbActivo.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbActivo.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbActivo.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbActivo.Name = "rdbActivo"
        Me.rdbActivo.Ripple = True
        Me.rdbActivo.Size = New System.Drawing.Size(68, 30)
        Me.rdbActivo.TabIndex = 5
        Me.rdbActivo.TabStop = True
        Me.rdbActivo.Text = "Activo"
        Me.rdbActivo.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(400, 433)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(106, 27)
        Me.btnRegresar.TabIndex = 7
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
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(12, 238)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(157, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 154)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(157, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'cmbBuscar_Autos
        '
        Me.cmbBuscar_Autos.FormattingEnabled = True
        Me.cmbBuscar_Autos.Items.AddRange(New Object() {"Marca", "Modelo", "Num de pasajeros", "Costo de alquiler", "Tipo de auto"})
        Me.cmbBuscar_Autos.Location = New System.Drawing.Point(12, 116)
        Me.cmbBuscar_Autos.Name = "cmbBuscar_Autos"
        Me.cmbBuscar_Autos.Size = New System.Drawing.Size(157, 21)
        Me.cmbBuscar_Autos.TabIndex = 0
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 81)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(126, 19)
        Me.MaterialLabel1.TabIndex = 92
        Me.MaterialLabel1.Text = "Buscar coche por"
        '
        'dgvBuscarCoche
        '
        Me.dgvBuscarCoche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscarCoche.Location = New System.Drawing.Point(187, 90)
        Me.dgvBuscarCoche.Name = "dgvBuscarCoche"
        Me.dgvBuscarCoche.Size = New System.Drawing.Size(334, 159)
        Me.dgvBuscarCoche.TabIndex = 91
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Depth = 0
        Me.lblMatricula.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblMatricula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMatricula.Location = New System.Drawing.Point(12, 199)
        Me.lblMatricula.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(151, 19)
        Me.lblMatricula.TabIndex = 90
        Me.lblMatricula.Text = "Seleccione una placa"
        '
        'frmGestionar_Autos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 472)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cmbBuscar_Autos)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.dgvBuscarCoche)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.rdbActivo)
        Me.Controls.Add(Me.rdbReparacion)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.txtCosto_Renta)
        Me.Controls.Add(Me.lblCosto_Renta)
        Me.Controls.Add(Me.btnModificar_Datos)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmGestionar_Autos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionar Autos                                                                  " &
    "        Rent-a-Car"
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        CType(Me.dgvBuscarCoche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModificar_Datos As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtCosto_Renta As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblCosto_Renta As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblEstado As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents rdbReparacion As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdbActivo As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents mnsCerrar_Sesion As ToolStripMenuItem
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cmbBuscar_Autos As ComboBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvBuscarCoche As DataGridView
    Friend WithEvents lblMatricula As MaterialSkin.Controls.MaterialLabel
End Class
