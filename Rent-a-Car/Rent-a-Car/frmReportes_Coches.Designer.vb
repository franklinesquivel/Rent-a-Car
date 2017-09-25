<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportes_Coches
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
        Me.txbCodigo_Renta = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblCodigo_Renta = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvCodigo_Renta = New System.Windows.Forms.DataGridView()
        Me.btnRegrear = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnsCerrar_Sesion = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvCodigo_Renta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'txbCodigo_Renta
        '
        Me.txbCodigo_Renta.Depth = 0
        Me.txbCodigo_Renta.Hint = ""
        Me.txbCodigo_Renta.Location = New System.Drawing.Point(206, 87)
        Me.txbCodigo_Renta.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbCodigo_Renta.Name = "txbCodigo_Renta"
        Me.txbCodigo_Renta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbCodigo_Renta.SelectedText = ""
        Me.txbCodigo_Renta.SelectionLength = 0
        Me.txbCodigo_Renta.SelectionStart = 0
        Me.txbCodigo_Renta.Size = New System.Drawing.Size(400, 23)
        Me.txbCodigo_Renta.TabIndex = 71
        Me.txbCodigo_Renta.UseSystemPasswordChar = False
        '
        'lblCodigo_Renta
        '
        Me.lblCodigo_Renta.AutoSize = True
        Me.lblCodigo_Renta.Depth = 0
        Me.lblCodigo_Renta.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblCodigo_Renta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCodigo_Renta.Location = New System.Drawing.Point(28, 91)
        Me.lblCodigo_Renta.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCodigo_Renta.Name = "lblCodigo_Renta"
        Me.lblCodigo_Renta.Size = New System.Drawing.Size(163, 19)
        Me.lblCodigo_Renta.TabIndex = 70
        Me.lblCodigo_Renta.Text = "Buscar código de renta"
        '
        'dgvCodigo_Renta
        '
        Me.dgvCodigo_Renta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCodigo_Renta.Location = New System.Drawing.Point(32, 135)
        Me.dgvCodigo_Renta.Name = "dgvCodigo_Renta"
        Me.dgvCodigo_Renta.Size = New System.Drawing.Size(574, 145)
        Me.dgvCodigo_Renta.TabIndex = 69
        '
        'btnRegrear
        '
        Me.btnRegrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegrear.Depth = 0
        Me.btnRegrear.Location = New System.Drawing.Point(499, 303)
        Me.btnRegrear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegrear.Name = "btnRegrear"
        Me.btnRegrear.Primary = True
        Me.btnRegrear.Size = New System.Drawing.Size(107, 37)
        Me.btnRegrear.TabIndex = 72
        Me.btnRegrear.Text = "Regresar"
        Me.btnRegrear.UseVisualStyleBackColor = True
        '
        'mnsMenu
        '
        Me.mnsMenu.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsCerrar_Sesion})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(629, 27)
        Me.mnsMenu.TabIndex = 73
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'mnsCerrar_Sesion
        '
        Me.mnsCerrar_Sesion.Name = "mnsCerrar_Sesion"
        Me.mnsCerrar_Sesion.Size = New System.Drawing.Size(102, 23)
        Me.mnsCerrar_Sesion.Text = "Cerrar Sesión"
        '
        'frmReportes_Coches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 359)
        Me.Controls.Add(Me.btnRegrear)
        Me.Controls.Add(Me.txbCodigo_Renta)
        Me.Controls.Add(Me.lblCodigo_Renta)
        Me.Controls.Add(Me.dgvCodigo_Renta)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmReportes_Coches"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de coches rentados                                                       " &
    "                     Rent-a-Car"
        CType(Me.dgvCodigo_Renta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbCodigo_Renta As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblCodigo_Renta As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvCodigo_Renta As DataGridView
    Friend WithEvents btnRegrear As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents mnsCerrar_Sesion As ToolStripMenuItem
End Class
