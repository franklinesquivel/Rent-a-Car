<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReservas
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
        Me.lblFecha_Devolucion = New MaterialSkin.Controls.MaterialLabel()
        Me.lblFecha_Entrega = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpFecha_Entrega = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha_Devolucion = New System.Windows.Forms.DateTimePicker()
        Me.txbBuscar_Codigo = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblBuscar_Codigo = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvBuscar_Usuario = New System.Windows.Forms.DataGridView()
        Me.txbBuscar_Coche = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblBuscar_Coche = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvBuscar_Coche = New System.Windows.Forms.DataGridView()
        Me.btnReservar_Coche = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnsCerrar_Sesion = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvBuscar_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBuscar_Coche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFecha_Devolucion
        '
        Me.lblFecha_Devolucion.AutoSize = True
        Me.lblFecha_Devolucion.Depth = 0
        Me.lblFecha_Devolucion.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblFecha_Devolucion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFecha_Devolucion.Location = New System.Drawing.Point(27, 149)
        Me.lblFecha_Devolucion.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFecha_Devolucion.Name = "lblFecha_Devolucion"
        Me.lblFecha_Devolucion.Size = New System.Drawing.Size(230, 19)
        Me.lblFecha_Devolucion.TabIndex = 51
        Me.lblFecha_Devolucion.Text = "Fecha de devolución del vehículo"
        '
        'lblFecha_Entrega
        '
        Me.lblFecha_Entrega.AutoSize = True
        Me.lblFecha_Entrega.Depth = 0
        Me.lblFecha_Entrega.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblFecha_Entrega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFecha_Entrega.Location = New System.Drawing.Point(27, 111)
        Me.lblFecha_Entrega.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFecha_Entrega.Name = "lblFecha_Entrega"
        Me.lblFecha_Entrega.Size = New System.Drawing.Size(207, 19)
        Me.lblFecha_Entrega.TabIndex = 49
        Me.lblFecha_Entrega.Text = "Fecha de entrega del vehículo"
        '
        'dtpFecha_Entrega
        '
        Me.dtpFecha_Entrega.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha_Entrega.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.dtpFecha_Entrega.Location = New System.Drawing.Point(263, 111)
        Me.dtpFecha_Entrega.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha_Entrega.MinDate = New Date(2017, 9, 23, 0, 0, 0, 0)
        Me.dtpFecha_Entrega.Name = "dtpFecha_Entrega"
        Me.dtpFecha_Entrega.Size = New System.Drawing.Size(245, 23)
        Me.dtpFecha_Entrega.TabIndex = 52
        '
        'dtpFecha_Devolucion
        '
        Me.dtpFecha_Devolucion.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.dtpFecha_Devolucion.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.dtpFecha_Devolucion.Location = New System.Drawing.Point(263, 149)
        Me.dtpFecha_Devolucion.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha_Devolucion.MinDate = New Date(2017, 9, 23, 0, 0, 0, 0)
        Me.dtpFecha_Devolucion.Name = "dtpFecha_Devolucion"
        Me.dtpFecha_Devolucion.Size = New System.Drawing.Size(245, 23)
        Me.dtpFecha_Devolucion.TabIndex = 53
        '
        'txbBuscar_Codigo
        '
        Me.txbBuscar_Codigo.Depth = 0
        Me.txbBuscar_Codigo.Hint = ""
        Me.txbBuscar_Codigo.Location = New System.Drawing.Point(219, 190)
        Me.txbBuscar_Codigo.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbBuscar_Codigo.Name = "txbBuscar_Codigo"
        Me.txbBuscar_Codigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbBuscar_Codigo.SelectedText = ""
        Me.txbBuscar_Codigo.SelectionLength = 0
        Me.txbBuscar_Codigo.SelectionStart = 0
        Me.txbBuscar_Codigo.Size = New System.Drawing.Size(289, 23)
        Me.txbBuscar_Codigo.TabIndex = 62
        Me.txbBuscar_Codigo.UseSystemPasswordChar = False
        '
        'lblBuscar_Codigo
        '
        Me.lblBuscar_Codigo.AutoSize = True
        Me.lblBuscar_Codigo.Depth = 0
        Me.lblBuscar_Codigo.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblBuscar_Codigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBuscar_Codigo.Location = New System.Drawing.Point(28, 194)
        Me.lblBuscar_Codigo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBuscar_Codigo.Name = "lblBuscar_Codigo"
        Me.lblBuscar_Codigo.Size = New System.Drawing.Size(179, 19)
        Me.lblBuscar_Codigo.TabIndex = 61
        Me.lblBuscar_Codigo.Text = "Buscar código de usuario"
        '
        'dgvBuscar_Usuario
        '
        Me.dgvBuscar_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscar_Usuario.Location = New System.Drawing.Point(31, 219)
        Me.dgvBuscar_Usuario.Name = "dgvBuscar_Usuario"
        Me.dgvBuscar_Usuario.ReadOnly = True
        Me.dgvBuscar_Usuario.Size = New System.Drawing.Size(476, 154)
        Me.dgvBuscar_Usuario.TabIndex = 60
        '
        'txbBuscar_Coche
        '
        Me.txbBuscar_Coche.Depth = 0
        Me.txbBuscar_Coche.Hint = ""
        Me.txbBuscar_Coche.Location = New System.Drawing.Point(163, 394)
        Me.txbBuscar_Coche.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbBuscar_Coche.Name = "txbBuscar_Coche"
        Me.txbBuscar_Coche.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbBuscar_Coche.SelectedText = ""
        Me.txbBuscar_Coche.SelectionLength = 0
        Me.txbBuscar_Coche.SelectionStart = 0
        Me.txbBuscar_Coche.Size = New System.Drawing.Size(344, 23)
        Me.txbBuscar_Coche.TabIndex = 65
        Me.txbBuscar_Coche.UseSystemPasswordChar = False
        '
        'lblBuscar_Coche
        '
        Me.lblBuscar_Coche.AutoSize = True
        Me.lblBuscar_Coche.Depth = 0
        Me.lblBuscar_Coche.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblBuscar_Coche.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBuscar_Coche.Location = New System.Drawing.Point(28, 394)
        Me.lblBuscar_Coche.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBuscar_Coche.Name = "lblBuscar_Coche"
        Me.lblBuscar_Coche.Size = New System.Drawing.Size(100, 19)
        Me.lblBuscar_Coche.TabIndex = 64
        Me.lblBuscar_Coche.Text = "Buscar coche"
        '
        'dgvBuscar_Coche
        '
        Me.dgvBuscar_Coche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscar_Coche.Location = New System.Drawing.Point(32, 423)
        Me.dgvBuscar_Coche.Name = "dgvBuscar_Coche"
        Me.dgvBuscar_Coche.ReadOnly = True
        Me.dgvBuscar_Coche.Size = New System.Drawing.Size(476, 149)
        Me.dgvBuscar_Coche.TabIndex = 63
        '
        'btnReservar_Coche
        '
        Me.btnReservar_Coche.AutoSize = True
        Me.btnReservar_Coche.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnReservar_Coche.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReservar_Coche.Depth = 0
        Me.btnReservar_Coche.Location = New System.Drawing.Point(219, 581)
        Me.btnReservar_Coche.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnReservar_Coche.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnReservar_Coche.Name = "btnReservar_Coche"
        Me.btnReservar_Coche.Primary = False
        Me.btnReservar_Coche.Size = New System.Drawing.Size(128, 36)
        Me.btnReservar_Coche.TabIndex = 66
        Me.btnReservar_Coche.Text = "Reservar coche"
        Me.btnReservar_Coche.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(402, 593)
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
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(541, 24)
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
        'frmReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 632)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnReservar_Coche)
        Me.Controls.Add(Me.txbBuscar_Coche)
        Me.Controls.Add(Me.lblBuscar_Coche)
        Me.Controls.Add(Me.dgvBuscar_Coche)
        Me.Controls.Add(Me.txbBuscar_Codigo)
        Me.Controls.Add(Me.lblBuscar_Codigo)
        Me.Controls.Add(Me.dgvBuscar_Usuario)
        Me.Controls.Add(Me.dtpFecha_Devolucion)
        Me.Controls.Add(Me.dtpFecha_Entrega)
        Me.Controls.Add(Me.lblFecha_Devolucion)
        Me.Controls.Add(Me.lblFecha_Entrega)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmReservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservas de coches                                                               " &
    "       Rent-a-Car                            "
        CType(Me.dgvBuscar_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBuscar_Coche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFecha_Devolucion As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblFecha_Entrega As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpFecha_Entrega As DateTimePicker
    Friend WithEvents dtpFecha_Devolucion As DateTimePicker
    Friend WithEvents txbBuscar_Codigo As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblBuscar_Codigo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvBuscar_Usuario As DataGridView
    Friend WithEvents txbBuscar_Coche As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblBuscar_Coche As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvBuscar_Coche As DataGridView
    Friend WithEvents btnReservar_Coche As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents mnsCerrar_Sesion As ToolStripMenuItem
End Class
