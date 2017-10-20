<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelar_Reservas
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
        Me.txbCodigo_Reserva = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblCodigo_Reserva = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvCancelar_Reservas = New System.Windows.Forms.DataGridView()
        Me.btnCancelar_Reservas = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnsCerrar_Sesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbcReserva = New System.Windows.Forms.TabControl()
        Me.tpBuscador = New System.Windows.Forms.TabPage()
        Me.tpResultados = New System.Windows.Forms.TabPage()
        Me.btnVerDatos = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblNumReserva = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.lblPagar = New System.Windows.Forms.Label()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.lblEspecidicaciones = New System.Windows.Forms.Label()
        Me.picCoche = New System.Windows.Forms.PictureBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblCodigoUsuario = New System.Windows.Forms.Label()
        Me.lblCorreoUsuario = New System.Windows.Forms.Label()
        CType(Me.dgvCancelar_Reservas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsMenu.SuspendLayout()
        Me.tbcReserva.SuspendLayout()
        Me.tpBuscador.SuspendLayout()
        Me.tpResultados.SuspendLayout()
        CType(Me.picCoche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbCodigo_Reserva
        '
        Me.txbCodigo_Reserva.Depth = 0
        Me.txbCodigo_Reserva.Hint = ""
        Me.txbCodigo_Reserva.Location = New System.Drawing.Point(190, 16)
        Me.txbCodigo_Reserva.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbCodigo_Reserva.Name = "txbCodigo_Reserva"
        Me.txbCodigo_Reserva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbCodigo_Reserva.SelectedText = ""
        Me.txbCodigo_Reserva.SelectionLength = 0
        Me.txbCodigo_Reserva.SelectionStart = 0
        Me.txbCodigo_Reserva.Size = New System.Drawing.Size(289, 23)
        Me.txbCodigo_Reserva.TabIndex = 65
        Me.txbCodigo_Reserva.UseSystemPasswordChar = False
        '
        'lblCodigo_Reserva
        '
        Me.lblCodigo_Reserva.AutoSize = True
        Me.lblCodigo_Reserva.Depth = 0
        Me.lblCodigo_Reserva.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblCodigo_Reserva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCodigo_Reserva.Location = New System.Drawing.Point(6, 16)
        Me.lblCodigo_Reserva.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCodigo_Reserva.Name = "lblCodigo_Reserva"
        Me.lblCodigo_Reserva.Size = New System.Drawing.Size(178, 19)
        Me.lblCodigo_Reserva.TabIndex = 64
        Me.lblCodigo_Reserva.Text = "Buscar código de reserva"
        '
        'dgvCancelar_Reservas
        '
        Me.dgvCancelar_Reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCancelar_Reservas.Location = New System.Drawing.Point(6, 59)
        Me.dgvCancelar_Reservas.Name = "dgvCancelar_Reservas"
        Me.dgvCancelar_Reservas.ReadOnly = True
        Me.dgvCancelar_Reservas.Size = New System.Drawing.Size(473, 183)
        Me.dgvCancelar_Reservas.TabIndex = 63
        '
        'btnCancelar_Reservas
        '
        Me.btnCancelar_Reservas.AutoSize = True
        Me.btnCancelar_Reservas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancelar_Reservas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar_Reservas.Depth = 0
        Me.btnCancelar_Reservas.Location = New System.Drawing.Point(122, 372)
        Me.btnCancelar_Reservas.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancelar_Reservas.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelar_Reservas.Name = "btnCancelar_Reservas"
        Me.btnCancelar_Reservas.Primary = False
        Me.btnCancelar_Reservas.Size = New System.Drawing.Size(144, 36)
        Me.btnCancelar_Reservas.TabIndex = 66
        Me.btnCancelar_Reservas.Text = "Cancelar Reserva"
        Me.btnCancelar_Reservas.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(399, 402)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(106, 27)
        Me.btnRegresar.TabIndex = 67
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsCerrar_Sesion})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(523, 27)
        Me.mnsMenu.TabIndex = 68
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'mnsCerrar_Sesion
        '
        Me.mnsCerrar_Sesion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mnsCerrar_Sesion.Name = "mnsCerrar_Sesion"
        Me.mnsCerrar_Sesion.Size = New System.Drawing.Size(102, 23)
        Me.mnsCerrar_Sesion.Text = "Cerrar Sesión"
        '
        'tbcReserva
        '
        Me.tbcReserva.Controls.Add(Me.tpBuscador)
        Me.tbcReserva.Controls.Add(Me.tpResultados)
        Me.tbcReserva.Location = New System.Drawing.Point(12, 74)
        Me.tbcReserva.Name = "tbcReserva"
        Me.tbcReserva.SelectedIndex = 0
        Me.tbcReserva.Size = New System.Drawing.Size(499, 289)
        Me.tbcReserva.TabIndex = 69
        '
        'tpBuscador
        '
        Me.tpBuscador.Controls.Add(Me.txbCodigo_Reserva)
        Me.tpBuscador.Controls.Add(Me.lblCodigo_Reserva)
        Me.tpBuscador.Controls.Add(Me.dgvCancelar_Reservas)
        Me.tpBuscador.ForeColor = System.Drawing.Color.Black
        Me.tpBuscador.Location = New System.Drawing.Point(4, 22)
        Me.tpBuscador.Name = "tpBuscador"
        Me.tpBuscador.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBuscador.Size = New System.Drawing.Size(491, 263)
        Me.tpBuscador.TabIndex = 0
        Me.tpBuscador.Text = "TabPage1"
        Me.tpBuscador.UseVisualStyleBackColor = True
        '
        'tpResultados
        '
        Me.tpResultados.Controls.Add(Me.lblCorreoUsuario)
        Me.tpResultados.Controls.Add(Me.lblCodigoUsuario)
        Me.tpResultados.Controls.Add(Me.lblNombreUsuario)
        Me.tpResultados.Controls.Add(Me.picCoche)
        Me.tpResultados.Controls.Add(Me.lblEspecidicaciones)
        Me.tpResultados.Controls.Add(Me.lblMatricula)
        Me.tpResultados.Controls.Add(Me.lblPagar)
        Me.tpResultados.Controls.Add(Me.lblFechaFinal)
        Me.tpResultados.Controls.Add(Me.lblFechaInicio)
        Me.tpResultados.Controls.Add(Me.lblNumReserva)
        Me.tpResultados.Location = New System.Drawing.Point(4, 22)
        Me.tpResultados.Name = "tpResultados"
        Me.tpResultados.Padding = New System.Windows.Forms.Padding(3)
        Me.tpResultados.Size = New System.Drawing.Size(491, 263)
        Me.tpResultados.TabIndex = 1
        Me.tpResultados.Text = "TabPage2"
        Me.tpResultados.UseVisualStyleBackColor = True
        '
        'btnVerDatos
        '
        Me.btnVerDatos.AutoSize = True
        Me.btnVerDatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVerDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerDatos.Depth = 0
        Me.btnVerDatos.Location = New System.Drawing.Point(274, 372)
        Me.btnVerDatos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnVerDatos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnVerDatos.Name = "btnVerDatos"
        Me.btnVerDatos.Primary = False
        Me.btnVerDatos.Size = New System.Drawing.Size(85, 36)
        Me.btnVerDatos.TabIndex = 67
        Me.btnVerDatos.Text = "Ver Datos"
        Me.btnVerDatos.UseVisualStyleBackColor = True
        '
        'lblNumReserva
        '
        Me.lblNumReserva.AutoSize = True
        Me.lblNumReserva.Location = New System.Drawing.Point(6, 6)
        Me.lblNumReserva.Name = "lblNumReserva"
        Me.lblNumReserva.Size = New System.Drawing.Size(39, 13)
        Me.lblNumReserva.TabIndex = 0
        Me.lblNumReserva.Text = "Label1"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(6, 31)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(39, 13)
        Me.lblFechaInicio.TabIndex = 1
        Me.lblFechaInicio.Text = "Label1"
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.AutoSize = True
        Me.lblFechaFinal.Location = New System.Drawing.Point(6, 60)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(39, 13)
        Me.lblFechaFinal.TabIndex = 2
        Me.lblFechaFinal.Text = "Label1"
        '
        'lblPagar
        '
        Me.lblPagar.AutoSize = True
        Me.lblPagar.Location = New System.Drawing.Point(6, 83)
        Me.lblPagar.Name = "lblPagar"
        Me.lblPagar.Size = New System.Drawing.Size(39, 13)
        Me.lblPagar.TabIndex = 3
        Me.lblPagar.Text = "Label1"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(6, 107)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(39, 13)
        Me.lblMatricula.TabIndex = 4
        Me.lblMatricula.Text = "Label1"
        '
        'lblEspecidicaciones
        '
        Me.lblEspecidicaciones.AutoSize = True
        Me.lblEspecidicaciones.Location = New System.Drawing.Point(6, 138)
        Me.lblEspecidicaciones.Name = "lblEspecidicaciones"
        Me.lblEspecidicaciones.Size = New System.Drawing.Size(39, 13)
        Me.lblEspecidicaciones.TabIndex = 5
        Me.lblEspecidicaciones.Text = "Label1"
        '
        'picCoche
        '
        Me.picCoche.Location = New System.Drawing.Point(322, 6)
        Me.picCoche.Name = "picCoche"
        Me.picCoche.Size = New System.Drawing.Size(163, 145)
        Me.picCoche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCoche.TabIndex = 6
        Me.picCoche.TabStop = False
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(6, 169)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(39, 13)
        Me.lblNombreUsuario.TabIndex = 7
        Me.lblNombreUsuario.Text = "Label1"
        '
        'lblCodigoUsuario
        '
        Me.lblCodigoUsuario.AutoSize = True
        Me.lblCodigoUsuario.Location = New System.Drawing.Point(6, 196)
        Me.lblCodigoUsuario.Name = "lblCodigoUsuario"
        Me.lblCodigoUsuario.Size = New System.Drawing.Size(39, 13)
        Me.lblCodigoUsuario.TabIndex = 8
        Me.lblCodigoUsuario.Text = "Label1"
        '
        'lblCorreoUsuario
        '
        Me.lblCorreoUsuario.AutoSize = True
        Me.lblCorreoUsuario.Location = New System.Drawing.Point(6, 226)
        Me.lblCorreoUsuario.Name = "lblCorreoUsuario"
        Me.lblCorreoUsuario.Size = New System.Drawing.Size(39, 13)
        Me.lblCorreoUsuario.TabIndex = 9
        Me.lblCorreoUsuario.Text = "Label1"
        '
        'frmCancelar_Reservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 441)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.mnsMenu)
        Me.Controls.Add(Me.tbcReserva)
        Me.Controls.Add(Me.btnVerDatos)
        Me.Controls.Add(Me.btnCancelar_Reservas)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmCancelar_Reservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelar Reservas                                                                " &
    "   Rent-a-Car"
        CType(Me.dgvCancelar_Reservas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.tbcReserva.ResumeLayout(False)
        Me.tpBuscador.ResumeLayout(False)
        Me.tpBuscador.PerformLayout()
        Me.tpResultados.ResumeLayout(False)
        Me.tpResultados.PerformLayout()
        CType(Me.picCoche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbCodigo_Reserva As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblCodigo_Reserva As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvCancelar_Reservas As DataGridView
    Friend WithEvents btnCancelar_Reservas As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents mnsCerrar_Sesion As ToolStripMenuItem
    Friend WithEvents tbcReserva As TabControl
    Friend WithEvents tpBuscador As TabPage
    Friend WithEvents tpResultados As TabPage
    Friend WithEvents btnVerDatos As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblCorreoUsuario As Label
    Friend WithEvents lblCodigoUsuario As Label
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents picCoche As PictureBox
    Friend WithEvents lblEspecidicaciones As Label
    Friend WithEvents lblMatricula As Label
    Friend WithEvents lblPagar As Label
    Friend WithEvents lblFechaFinal As Label
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents lblNumReserva As Label
End Class
