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
        CType(Me.dgvCancelar_Reservas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'txbCodigo_Reserva
        '
        Me.txbCodigo_Reserva.Depth = 0
        Me.txbCodigo_Reserva.Hint = ""
        Me.txbCodigo_Reserva.Location = New System.Drawing.Point(206, 102)
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
        Me.lblCodigo_Reserva.Location = New System.Drawing.Point(15, 102)
        Me.lblCodigo_Reserva.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCodigo_Reserva.Name = "lblCodigo_Reserva"
        Me.lblCodigo_Reserva.Size = New System.Drawing.Size(178, 19)
        Me.lblCodigo_Reserva.TabIndex = 64
        Me.lblCodigo_Reserva.Text = "Buscar código de reserva"
        '
        'dgvCancelar_Reservas
        '
        Me.dgvCancelar_Reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCancelar_Reservas.Location = New System.Drawing.Point(19, 141)
        Me.dgvCancelar_Reservas.Name = "dgvCancelar_Reservas"
        Me.dgvCancelar_Reservas.Size = New System.Drawing.Size(476, 93)
        Me.dgvCancelar_Reservas.TabIndex = 63
        '
        'btnCancelar_Reservas
        '
        Me.btnCancelar_Reservas.AutoSize = True
        Me.btnCancelar_Reservas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancelar_Reservas.Depth = 0
        Me.btnCancelar_Reservas.Location = New System.Drawing.Point(195, 263)
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
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(389, 297)
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
        Me.mnsMenu.Size = New System.Drawing.Size(517, 27)
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
        'frmCancelar_Reservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 336)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnCancelar_Reservas)
        Me.Controls.Add(Me.txbCodigo_Reserva)
        Me.Controls.Add(Me.lblCodigo_Reserva)
        Me.Controls.Add(Me.dgvCancelar_Reservas)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmCancelar_Reservas"
        Me.Text = "Cancelar Reservas                                                                " &
    "   Rent-a-Car"
        CType(Me.dgvCancelar_Reservas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
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
End Class
