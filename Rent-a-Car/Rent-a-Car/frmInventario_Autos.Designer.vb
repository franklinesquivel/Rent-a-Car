<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventario_Autos
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
        Me.lblBuscar_Autos = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvInventario_Autos = New System.Windows.Forms.DataGridView()
        Me.cmbBuscar_Autos = New System.Windows.Forms.ComboBox()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnsCerrar_Sesion = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvInventario_Autos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBuscar_Autos
        '
        Me.lblBuscar_Autos.AutoSize = True
        Me.lblBuscar_Autos.Depth = 0
        Me.lblBuscar_Autos.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblBuscar_Autos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBuscar_Autos.Location = New System.Drawing.Point(24, 102)
        Me.lblBuscar_Autos.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBuscar_Autos.Name = "lblBuscar_Autos"
        Me.lblBuscar_Autos.Size = New System.Drawing.Size(127, 19)
        Me.lblBuscar_Autos.TabIndex = 68
        Me.lblBuscar_Autos.Text = "Buscar autos por:"
        '
        'dgvInventario_Autos
        '
        Me.dgvInventario_Autos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventario_Autos.Location = New System.Drawing.Point(18, 141)
        Me.dgvInventario_Autos.Name = "dgvInventario_Autos"
        Me.dgvInventario_Autos.Size = New System.Drawing.Size(439, 236)
        Me.dgvInventario_Autos.TabIndex = 67
        '
        'cmbBuscar_Autos
        '
        Me.cmbBuscar_Autos.FormattingEnabled = True
        Me.cmbBuscar_Autos.Items.AddRange(New Object() {"Marca", "Modelo", "Número de pasajeros", "Costo de alquiler", "Tipo de auto"})
        Me.cmbBuscar_Autos.Location = New System.Drawing.Point(198, 103)
        Me.cmbBuscar_Autos.Name = "cmbBuscar_Autos"
        Me.cmbBuscar_Autos.Size = New System.Drawing.Size(236, 21)
        Me.cmbBuscar_Autos.TabIndex = 71
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(310, 397)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(147, 36)
        Me.btnRegresar.TabIndex = 72
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsCerrar_Sesion})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(479, 27)
        Me.mnsMenu.TabIndex = 73
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'mnsCerrar_Sesion
        '
        Me.mnsCerrar_Sesion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mnsCerrar_Sesion.Name = "mnsCerrar_Sesion"
        Me.mnsCerrar_Sesion.Size = New System.Drawing.Size(102, 23)
        Me.mnsCerrar_Sesion.Text = "Cerrar Sesión"
        '
        'frmInventario_Autos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 445)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.cmbBuscar_Autos)
        Me.Controls.Add(Me.lblBuscar_Autos)
        Me.Controls.Add(Me.dgvInventario_Autos)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmInventario_Autos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario de autos                                                       Rent-a-" &
    "Car"
        CType(Me.dgvInventario_Autos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBuscar_Autos As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvInventario_Autos As DataGridView
    Friend WithEvents cmbBuscar_Autos As ComboBox
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents mnsCerrar_Sesion As ToolStripMenuItem
End Class
