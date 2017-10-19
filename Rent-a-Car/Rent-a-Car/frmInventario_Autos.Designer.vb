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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tbcInventarios = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.pcbFoto = New System.Windows.Forms.PictureBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblNumPasajeros = New System.Windows.Forms.Label()
        Me.lblKm = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblMatricula = New System.Windows.Forms.Label()
        CType(Me.dgvInventario_Autos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsMenu.SuspendLayout()
        Me.tbcInventarios.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.pcbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscar_Autos
        '
        Me.lblBuscar_Autos.AutoSize = True
        Me.lblBuscar_Autos.Depth = 0
        Me.lblBuscar_Autos.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblBuscar_Autos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBuscar_Autos.Location = New System.Drawing.Point(121, 23)
        Me.lblBuscar_Autos.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBuscar_Autos.Name = "lblBuscar_Autos"
        Me.lblBuscar_Autos.Size = New System.Drawing.Size(127, 19)
        Me.lblBuscar_Autos.TabIndex = 68
        Me.lblBuscar_Autos.Text = "Buscar autos por:"
        '
        'dgvInventario_Autos
        '
        Me.dgvInventario_Autos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventario_Autos.Location = New System.Drawing.Point(6, 95)
        Me.dgvInventario_Autos.Name = "dgvInventario_Autos"
        Me.dgvInventario_Autos.Size = New System.Drawing.Size(690, 236)
        Me.dgvInventario_Autos.TabIndex = 67
        '
        'cmbBuscar_Autos
        '
        Me.cmbBuscar_Autos.FormattingEnabled = True
        Me.cmbBuscar_Autos.Items.AddRange(New Object() {"Marca", "Modelo", "Num de pasajeros", "Costo de alquiler", "Tipo de auto"})
        Me.cmbBuscar_Autos.Location = New System.Drawing.Point(254, 21)
        Me.cmbBuscar_Autos.Name = "cmbBuscar_Autos"
        Me.cmbBuscar_Autos.Size = New System.Drawing.Size(236, 21)
        Me.cmbBuscar_Autos.TabIndex = 71
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(575, 473)
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
        Me.mnsMenu.Size = New System.Drawing.Size(734, 27)
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(254, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox1.TabIndex = 74
        '
        'tbcInventarios
        '
        Me.tbcInventarios.Controls.Add(Me.TabPage1)
        Me.tbcInventarios.Controls.Add(Me.TabPage2)
        Me.tbcInventarios.Location = New System.Drawing.Point(12, 86)
        Me.tbcInventarios.Name = "tbcInventarios"
        Me.tbcInventarios.SelectedIndex = 0
        Me.tbcInventarios.Size = New System.Drawing.Size(710, 372)
        Me.tbcInventarios.TabIndex = 75
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblBuscar_Autos)
        Me.TabPage1.Controls.Add(Me.cmbBuscar_Autos)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.dgvInventario_Autos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(702, 346)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Buscador"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.pcbFoto)
        Me.TabPage2.Controls.Add(Me.lblTipo)
        Me.TabPage2.Controls.Add(Me.lblEstado)
        Me.TabPage2.Controls.Add(Me.lblPrecio)
        Me.TabPage2.Controls.Add(Me.lblNumPasajeros)
        Me.TabPage2.Controls.Add(Me.lblKm)
        Me.TabPage2.Controls.Add(Me.lblColor)
        Me.TabPage2.Controls.Add(Me.lblModelo)
        Me.TabPage2.Controls.Add(Me.lblMarca)
        Me.TabPage2.Controls.Add(Me.lblMatricula)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(702, 346)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resultados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'pcbFoto
        '
        Me.pcbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbFoto.Location = New System.Drawing.Point(425, 84)
        Me.pcbFoto.Name = "pcbFoto"
        Me.pcbFoto.Size = New System.Drawing.Size(271, 171)
        Me.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbFoto.TabIndex = 9
        Me.pcbFoto.TabStop = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(48, 276)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(39, 13)
        Me.lblTipo.TabIndex = 8
        Me.lblTipo.Text = "Label1"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(48, 310)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(39, 13)
        Me.lblEstado.TabIndex = 7
        Me.lblEstado.Text = "Label1"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(48, 242)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(39, 13)
        Me.lblPrecio.TabIndex = 6
        Me.lblPrecio.Text = "Label1"
        '
        'lblNumPasajeros
        '
        Me.lblNumPasajeros.AutoSize = True
        Me.lblNumPasajeros.Location = New System.Drawing.Point(48, 203)
        Me.lblNumPasajeros.Name = "lblNumPasajeros"
        Me.lblNumPasajeros.Size = New System.Drawing.Size(39, 13)
        Me.lblNumPasajeros.TabIndex = 5
        Me.lblNumPasajeros.Text = "Label1"
        '
        'lblKm
        '
        Me.lblKm.AutoSize = True
        Me.lblKm.Location = New System.Drawing.Point(48, 165)
        Me.lblKm.Name = "lblKm"
        Me.lblKm.Size = New System.Drawing.Size(39, 13)
        Me.lblKm.TabIndex = 4
        Me.lblKm.Text = "Label1"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(48, 132)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(39, 13)
        Me.lblColor.TabIndex = 3
        Me.lblColor.Text = "Label1"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(48, 94)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(39, 13)
        Me.lblModelo.TabIndex = 2
        Me.lblModelo.Text = "Label1"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(48, 59)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(39, 13)
        Me.lblMarca.TabIndex = 1
        Me.lblMarca.Text = "Label1"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(48, 25)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(39, 13)
        Me.lblMatricula.TabIndex = 0
        Me.lblMatricula.Text = "Label1"
        '
        'frmInventario_Autos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 521)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.tbcInventarios)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmInventario_Autos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario de autos                                                       Rent-a-" &
    "Car"
        CType(Me.dgvInventario_Autos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.tbcInventarios.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.pcbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBuscar_Autos As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvInventario_Autos As DataGridView
    Friend WithEvents cmbBuscar_Autos As ComboBox
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents mnsCerrar_Sesion As ToolStripMenuItem
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents tbcInventarios As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblNumPasajeros As Label
    Friend WithEvents lblKm As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblModelo As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblMatricula As Label
    Friend WithEvents pcbFoto As PictureBox
End Class
