<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRentar_Autos
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
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnRentar_Autos = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txbCodigo_Reserva = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblCodigo_Reserva = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvRentar_Autos = New System.Windows.Forms.DataGridView()
        Me.btnNoExiste = New MaterialSkin.Controls.MaterialFlatButton()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvRentar_Autos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(408, 313)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(106, 27)
        Me.btnRegresar.TabIndex = 3
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnRentar_Autos
        '
        Me.btnRentar_Autos.AutoSize = True
        Me.btnRentar_Autos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRentar_Autos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRentar_Autos.Depth = 0
        Me.btnRentar_Autos.Location = New System.Drawing.Point(383, 243)
        Me.btnRentar_Autos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRentar_Autos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRentar_Autos.Name = "btnRentar_Autos"
        Me.btnRentar_Autos.Primary = False
        Me.btnRentar_Autos.Size = New System.Drawing.Size(131, 36)
        Me.btnRentar_Autos.TabIndex = 2
        Me.btnRentar_Autos.Text = "Registrar Renta"
        Me.btnRentar_Autos.UseVisualStyleBackColor = True
        '
        'txbCodigo_Reserva
        '
        Me.txbCodigo_Reserva.Depth = 0
        Me.txbCodigo_Reserva.Hint = ""
        Me.txbCodigo_Reserva.Location = New System.Drawing.Point(225, 89)
        Me.txbCodigo_Reserva.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbCodigo_Reserva.Name = "txbCodigo_Reserva"
        Me.txbCodigo_Reserva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbCodigo_Reserva.SelectedText = ""
        Me.txbCodigo_Reserva.SelectionLength = 0
        Me.txbCodigo_Reserva.SelectionStart = 0
        Me.txbCodigo_Reserva.Size = New System.Drawing.Size(289, 23)
        Me.txbCodigo_Reserva.TabIndex = 0
        Me.txbCodigo_Reserva.UseSystemPasswordChar = False
        '
        'lblCodigo_Reserva
        '
        Me.lblCodigo_Reserva.AutoSize = True
        Me.lblCodigo_Reserva.Depth = 0
        Me.lblCodigo_Reserva.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblCodigo_Reserva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCodigo_Reserva.Location = New System.Drawing.Point(34, 89)
        Me.lblCodigo_Reserva.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCodigo_Reserva.Name = "lblCodigo_Reserva"
        Me.lblCodigo_Reserva.Size = New System.Drawing.Size(178, 19)
        Me.lblCodigo_Reserva.TabIndex = 69
        Me.lblCodigo_Reserva.Text = "Buscar código de reserva"
        '
        'dgvRentar_Autos
        '
        Me.dgvRentar_Autos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRentar_Autos.Location = New System.Drawing.Point(38, 128)
        Me.dgvRentar_Autos.Name = "dgvRentar_Autos"
        Me.dgvRentar_Autos.ReadOnly = True
        Me.dgvRentar_Autos.Size = New System.Drawing.Size(476, 93)
        Me.dgvRentar_Autos.TabIndex = 68
        '
        'btnNoExiste
        '
        Me.btnNoExiste.AutoSize = True
        Me.btnNoExiste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNoExiste.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNoExiste.Depth = 0
        Me.btnNoExiste.Location = New System.Drawing.Point(38, 243)
        Me.btnNoExiste.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNoExiste.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNoExiste.Name = "btnNoExiste"
        Me.btnNoExiste.Primary = False
        Me.btnNoExiste.Size = New System.Drawing.Size(143, 36)
        Me.btnNoExiste.TabIndex = 1
        Me.btnNoExiste.Text = "renta sin reserva"
        Me.btnNoExiste.UseVisualStyleBackColor = True
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(549, 27)
        Me.mnsMenu.TabIndex = 74
        Me.mnsMenu.Text = "mnsMenu"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(102, 23)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'frmRentar_Autos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 362)
        Me.Controls.Add(Me.btnNoExiste)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnRentar_Autos)
        Me.Controls.Add(Me.txbCodigo_Reserva)
        Me.Controls.Add(Me.lblCodigo_Reserva)
        Me.Controls.Add(Me.dgvRentar_Autos)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmRentar_Autos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rentar Autos                                                                     " &
    "              Rent-a-Car"
        CType(Me.dgvRentar_Autos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnRentar_Autos As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txbCodigo_Reserva As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblCodigo_Reserva As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvRentar_Autos As DataGridView
    Friend WithEvents btnNoExiste As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
End Class
