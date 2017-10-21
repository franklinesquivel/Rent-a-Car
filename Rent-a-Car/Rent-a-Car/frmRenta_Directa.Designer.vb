<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRenta_Directa
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
        Me.cmbAgencias = New System.Windows.Forms.ComboBox()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnRentar_Coche = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txbBuscar_Coche = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblBuscar_Coche = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvBuscar_Coche = New System.Windows.Forms.DataGridView()
        Me.txbBuscar_Codigo = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblBuscar_Codigo = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvBuscar_Usuario = New System.Windows.Forms.DataGridView()
        Me.lblAgencia = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpFecha_Devolucion = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha_Entrega = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha_Devolucion = New MaterialSkin.Controls.MaterialLabel()
        Me.lblFecha_Entrega = New MaterialSkin.Controls.MaterialLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgvBuscar_Coche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBuscar_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbAgencias
        '
        Me.cmbAgencias.FormattingEnabled = True
        Me.cmbAgencias.Location = New System.Drawing.Point(97, 117)
        Me.cmbAgencias.Name = "cmbAgencias"
        Me.cmbAgencias.Size = New System.Drawing.Size(411, 21)
        Me.cmbAgencias.TabIndex = 93
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(402, 519)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(106, 27)
        Me.btnRegresar.TabIndex = 92
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnRentar_Coche
        '
        Me.btnRentar_Coche.AutoSize = True
        Me.btnRentar_Coche.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRentar_Coche.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRentar_Coche.Depth = 0
        Me.btnRentar_Coche.Location = New System.Drawing.Point(208, 510)
        Me.btnRentar_Coche.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRentar_Coche.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRentar_Coche.Name = "btnRentar_Coche"
        Me.btnRentar_Coche.Primary = False
        Me.btnRentar_Coche.Size = New System.Drawing.Size(112, 36)
        Me.btnRentar_Coche.TabIndex = 91
        Me.btnRentar_Coche.Text = "Rentar coche"
        Me.btnRentar_Coche.UseVisualStyleBackColor = True
        '
        'txbBuscar_Coche
        '
        Me.txbBuscar_Coche.Depth = 0
        Me.txbBuscar_Coche.Hint = ""
        Me.txbBuscar_Coche.Location = New System.Drawing.Point(164, 337)
        Me.txbBuscar_Coche.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbBuscar_Coche.Name = "txbBuscar_Coche"
        Me.txbBuscar_Coche.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbBuscar_Coche.SelectedText = ""
        Me.txbBuscar_Coche.SelectionLength = 0
        Me.txbBuscar_Coche.SelectionStart = 0
        Me.txbBuscar_Coche.Size = New System.Drawing.Size(344, 23)
        Me.txbBuscar_Coche.TabIndex = 90
        Me.txbBuscar_Coche.UseSystemPasswordChar = False
        '
        'lblBuscar_Coche
        '
        Me.lblBuscar_Coche.AutoSize = True
        Me.lblBuscar_Coche.Depth = 0
        Me.lblBuscar_Coche.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblBuscar_Coche.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBuscar_Coche.Location = New System.Drawing.Point(28, 337)
        Me.lblBuscar_Coche.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBuscar_Coche.Name = "lblBuscar_Coche"
        Me.lblBuscar_Coche.Size = New System.Drawing.Size(100, 19)
        Me.lblBuscar_Coche.TabIndex = 89
        Me.lblBuscar_Coche.Text = "Buscar coche"
        '
        'dgvBuscar_Coche
        '
        Me.dgvBuscar_Coche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscar_Coche.Location = New System.Drawing.Point(32, 366)
        Me.dgvBuscar_Coche.Name = "dgvBuscar_Coche"
        Me.dgvBuscar_Coche.ReadOnly = True
        Me.dgvBuscar_Coche.Size = New System.Drawing.Size(476, 132)
        Me.dgvBuscar_Coche.TabIndex = 88
        '
        'txbBuscar_Codigo
        '
        Me.txbBuscar_Codigo.Depth = 0
        Me.txbBuscar_Codigo.Hint = ""
        Me.txbBuscar_Codigo.Location = New System.Drawing.Point(219, 157)
        Me.txbBuscar_Codigo.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbBuscar_Codigo.Name = "txbBuscar_Codigo"
        Me.txbBuscar_Codigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbBuscar_Codigo.SelectedText = ""
        Me.txbBuscar_Codigo.SelectionLength = 0
        Me.txbBuscar_Codigo.SelectionStart = 0
        Me.txbBuscar_Codigo.Size = New System.Drawing.Size(289, 23)
        Me.txbBuscar_Codigo.TabIndex = 87
        Me.txbBuscar_Codigo.UseSystemPasswordChar = False
        '
        'lblBuscar_Codigo
        '
        Me.lblBuscar_Codigo.AutoSize = True
        Me.lblBuscar_Codigo.Depth = 0
        Me.lblBuscar_Codigo.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblBuscar_Codigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBuscar_Codigo.Location = New System.Drawing.Point(28, 157)
        Me.lblBuscar_Codigo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBuscar_Codigo.Name = "lblBuscar_Codigo"
        Me.lblBuscar_Codigo.Size = New System.Drawing.Size(179, 19)
        Me.lblBuscar_Codigo.TabIndex = 86
        Me.lblBuscar_Codigo.Text = "Buscar código de usuario"
        '
        'dgvBuscar_Usuario
        '
        Me.dgvBuscar_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscar_Usuario.Location = New System.Drawing.Point(32, 196)
        Me.dgvBuscar_Usuario.Name = "dgvBuscar_Usuario"
        Me.dgvBuscar_Usuario.ReadOnly = True
        Me.dgvBuscar_Usuario.Size = New System.Drawing.Size(476, 135)
        Me.dgvBuscar_Usuario.TabIndex = 85
        '
        'lblAgencia
        '
        Me.lblAgencia.AutoSize = True
        Me.lblAgencia.Depth = 0
        Me.lblAgencia.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblAgencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAgencia.Location = New System.Drawing.Point(28, 116)
        Me.lblAgencia.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAgencia.Name = "lblAgencia"
        Me.lblAgencia.Size = New System.Drawing.Size(63, 19)
        Me.lblAgencia.TabIndex = 84
        Me.lblAgencia.Text = "Agencia"
        '
        'dtpFecha_Devolucion
        '
        Me.dtpFecha_Devolucion.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.dtpFecha_Devolucion.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.dtpFecha_Devolucion.Location = New System.Drawing.Point(263, 75)
        Me.dtpFecha_Devolucion.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha_Devolucion.MinDate = New Date(2017, 9, 23, 0, 0, 0, 0)
        Me.dtpFecha_Devolucion.Name = "dtpFecha_Devolucion"
        Me.dtpFecha_Devolucion.Size = New System.Drawing.Size(245, 23)
        Me.dtpFecha_Devolucion.TabIndex = 83
        '
        'dtpFecha_Entrega
        '
        Me.dtpFecha_Entrega.CalendarFont = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha_Entrega.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.dtpFecha_Entrega.Location = New System.Drawing.Point(263, 37)
        Me.dtpFecha_Entrega.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha_Entrega.MinDate = New Date(2017, 9, 23, 0, 0, 0, 0)
        Me.dtpFecha_Entrega.Name = "dtpFecha_Entrega"
        Me.dtpFecha_Entrega.Size = New System.Drawing.Size(245, 23)
        Me.dtpFecha_Entrega.TabIndex = 82
        '
        'lblFecha_Devolucion
        '
        Me.lblFecha_Devolucion.AutoSize = True
        Me.lblFecha_Devolucion.Depth = 0
        Me.lblFecha_Devolucion.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblFecha_Devolucion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFecha_Devolucion.Location = New System.Drawing.Point(27, 75)
        Me.lblFecha_Devolucion.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFecha_Devolucion.Name = "lblFecha_Devolucion"
        Me.lblFecha_Devolucion.Size = New System.Drawing.Size(230, 19)
        Me.lblFecha_Devolucion.TabIndex = 81
        Me.lblFecha_Devolucion.Text = "Fecha de devolución del vehículo"
        '
        'lblFecha_Entrega
        '
        Me.lblFecha_Entrega.AutoSize = True
        Me.lblFecha_Entrega.Depth = 0
        Me.lblFecha_Entrega.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblFecha_Entrega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFecha_Entrega.Location = New System.Drawing.Point(27, 37)
        Me.lblFecha_Entrega.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFecha_Entrega.Name = "lblFecha_Entrega"
        Me.lblFecha_Entrega.Size = New System.Drawing.Size(207, 19)
        Me.lblFecha_Entrega.TabIndex = 80
        Me.lblFecha_Entrega.Text = "Fecha de entrega del vehículo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmRenta_Directa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 582)
        Me.Controls.Add(Me.cmbAgencias)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnRentar_Coche)
        Me.Controls.Add(Me.txbBuscar_Coche)
        Me.Controls.Add(Me.lblBuscar_Coche)
        Me.Controls.Add(Me.dgvBuscar_Coche)
        Me.Controls.Add(Me.txbBuscar_Codigo)
        Me.Controls.Add(Me.lblBuscar_Codigo)
        Me.Controls.Add(Me.dgvBuscar_Usuario)
        Me.Controls.Add(Me.lblAgencia)
        Me.Controls.Add(Me.dtpFecha_Devolucion)
        Me.Controls.Add(Me.dtpFecha_Entrega)
        Me.Controls.Add(Me.lblFecha_Devolucion)
        Me.Controls.Add(Me.lblFecha_Entrega)
        Me.Name = "frmRenta_Directa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRenta_Directa"
        CType(Me.dgvBuscar_Coche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBuscar_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbAgencias As ComboBox
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnRentar_Coche As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txbBuscar_Coche As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblBuscar_Coche As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvBuscar_Coche As DataGridView
    Friend WithEvents txbBuscar_Codigo As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblBuscar_Codigo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvBuscar_Usuario As DataGridView
    Friend WithEvents lblAgencia As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpFecha_Devolucion As DateTimePicker
    Friend WithEvents dtpFecha_Entrega As DateTimePicker
    Friend WithEvents lblFecha_Devolucion As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblFecha_Entrega As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
