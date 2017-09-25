<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgencias
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
        Me.lblTelefono = New MaterialSkin.Controls.MaterialLabel()
        Me.lblNombre_Agencia = New MaterialSkin.Controls.MaterialLabel()
        Me.txbCodigo = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnAgregar_Agencia = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblDireccion = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCodigo = New MaterialSkin.Controls.MaterialLabel()
        Me.txbNombre_Agencia = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txbDireccion = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txbTelefono = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnsCerrar_Sesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Depth = 0
        Me.lblTelefono.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTelefono.Location = New System.Drawing.Point(26, 230)
        Me.lblTelefono.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(69, 19)
        Me.lblTelefono.TabIndex = 48
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblNombre_Agencia
        '
        Me.lblNombre_Agencia.AutoSize = True
        Me.lblNombre_Agencia.Depth = 0
        Me.lblNombre_Agencia.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblNombre_Agencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNombre_Agencia.Location = New System.Drawing.Point(26, 141)
        Me.lblNombre_Agencia.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNombre_Agencia.Name = "lblNombre_Agencia"
        Me.lblNombre_Agencia.Size = New System.Drawing.Size(155, 19)
        Me.lblNombre_Agencia.TabIndex = 47
        Me.lblNombre_Agencia.Text = "Nombre de la agencia"
        '
        'txbCodigo
        '
        Me.txbCodigo.Depth = 0
        Me.txbCodigo.Enabled = False
        Me.txbCodigo.Hint = ""
        Me.txbCodigo.Location = New System.Drawing.Point(114, 97)
        Me.txbCodigo.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbCodigo.Name = "txbCodigo"
        Me.txbCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbCodigo.SelectedText = ""
        Me.txbCodigo.SelectionLength = 0
        Me.txbCodigo.SelectionStart = 0
        Me.txbCodigo.Size = New System.Drawing.Size(289, 23)
        Me.txbCodigo.TabIndex = 46
        Me.txbCodigo.UseSystemPasswordChar = False
        '
        'btnAgregar_Agencia
        '
        Me.btnAgregar_Agencia.AutoSize = True
        Me.btnAgregar_Agencia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAgregar_Agencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar_Agencia.Depth = 0
        Me.btnAgregar_Agencia.Location = New System.Drawing.Point(138, 282)
        Me.btnAgregar_Agencia.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAgregar_Agencia.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAgregar_Agencia.Name = "btnAgregar_Agencia"
        Me.btnAgregar_Agencia.Primary = False
        Me.btnAgregar_Agencia.Size = New System.Drawing.Size(146, 36)
        Me.btnAgregar_Agencia.TabIndex = 45
        Me.btnAgregar_Agencia.Text = "+ Agregar agencia"
        Me.btnAgregar_Agencia.UseVisualStyleBackColor = True
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Depth = 0
        Me.lblDireccion.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDireccion.Location = New System.Drawing.Point(26, 184)
        Me.lblDireccion.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(73, 19)
        Me.lblDireccion.TabIndex = 44
        Me.lblDireccion.Text = "Dirección"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Depth = 0
        Me.lblCodigo.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCodigo.Location = New System.Drawing.Point(26, 101)
        Me.lblCodigo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(57, 19)
        Me.lblCodigo.TabIndex = 43
        Me.lblCodigo.Text = "Código"
        '
        'txbNombre_Agencia
        '
        Me.txbNombre_Agencia.Depth = 0
        Me.txbNombre_Agencia.Hint = ""
        Me.txbNombre_Agencia.Location = New System.Drawing.Point(209, 137)
        Me.txbNombre_Agencia.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbNombre_Agencia.Name = "txbNombre_Agencia"
        Me.txbNombre_Agencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbNombre_Agencia.SelectedText = ""
        Me.txbNombre_Agencia.SelectionLength = 0
        Me.txbNombre_Agencia.SelectionStart = 0
        Me.txbNombre_Agencia.Size = New System.Drawing.Size(194, 23)
        Me.txbNombre_Agencia.TabIndex = 42
        Me.txbNombre_Agencia.UseSystemPasswordChar = False
        '
        'txbDireccion
        '
        Me.txbDireccion.Depth = 0
        Me.txbDireccion.Hint = ""
        Me.txbDireccion.Location = New System.Drawing.Point(114, 184)
        Me.txbDireccion.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbDireccion.Name = "txbDireccion"
        Me.txbDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbDireccion.SelectedText = ""
        Me.txbDireccion.SelectionLength = 0
        Me.txbDireccion.SelectionStart = 0
        Me.txbDireccion.Size = New System.Drawing.Size(289, 23)
        Me.txbDireccion.TabIndex = 41
        Me.txbDireccion.UseSystemPasswordChar = False
        '
        'txbTelefono
        '
        Me.txbTelefono.Depth = 0
        Me.txbTelefono.Hint = ""
        Me.txbTelefono.Location = New System.Drawing.Point(114, 230)
        Me.txbTelefono.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbTelefono.SelectedText = ""
        Me.txbTelefono.SelectionLength = 0
        Me.txbTelefono.SelectionStart = 0
        Me.txbTelefono.Size = New System.Drawing.Size(215, 23)
        Me.txbTelefono.TabIndex = 49
        Me.txbTelefono.UseSystemPasswordChar = False
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(307, 318)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(106, 27)
        Me.btnRegresar.TabIndex = 51
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsCerrar_Sesion})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(425, 27)
        Me.mnsMenu.TabIndex = 52
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'mnsCerrar_Sesion
        '
        Me.mnsCerrar_Sesion.BackColor = System.Drawing.Color.Transparent
        Me.mnsCerrar_Sesion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mnsCerrar_Sesion.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.mnsCerrar_Sesion.Name = "mnsCerrar_Sesion"
        Me.mnsCerrar_Sesion.Size = New System.Drawing.Size(102, 23)
        Me.mnsCerrar_Sesion.Text = "Cerrar Sesión"
        '
        'frmAgencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 357)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.txbTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblNombre_Agencia)
        Me.Controls.Add(Me.txbCodigo)
        Me.Controls.Add(Me.btnAgregar_Agencia)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txbNombre_Agencia)
        Me.Controls.Add(Me.txbDireccion)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmAgencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de agencia                                         Rent-a-Car"
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTelefono As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblNombre_Agencia As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbCodigo As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnAgregar_Agencia As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblDireccion As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCodigo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbNombre_Agencia As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txbDireccion As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txbTelefono As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents mnsCerrar_Sesion As ToolStripMenuItem
End Class
