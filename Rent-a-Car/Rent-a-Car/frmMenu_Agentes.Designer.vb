<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu_Agentes
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
        Me.btnRegistrar_Clientes = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnGestion_Reservas = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnCancelar_Reservas = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnInventario_Autos = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnDevolver_Autos = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblClientes = New MaterialSkin.Controls.MaterialLabel()
        Me.lblReservas = New MaterialSkin.Controls.MaterialLabel()
        Me.lblAutos = New MaterialSkin.Controls.MaterialLabel()
        Me.btnCerrar_Sesion = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'btnRegistrar_Clientes
        '
        Me.btnRegistrar_Clientes.AutoSize = True
        Me.btnRegistrar_Clientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRegistrar_Clientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar_Clientes.Depth = 0
        Me.btnRegistrar_Clientes.Location = New System.Drawing.Point(60, 124)
        Me.btnRegistrar_Clientes.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRegistrar_Clientes.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegistrar_Clientes.Name = "btnRegistrar_Clientes"
        Me.btnRegistrar_Clientes.Primary = False
        Me.btnRegistrar_Clientes.Size = New System.Drawing.Size(150, 36)
        Me.btnRegistrar_Clientes.TabIndex = 0
        Me.btnRegistrar_Clientes.Text = "Registrar clientes"
        Me.btnRegistrar_Clientes.UseVisualStyleBackColor = True
        '
        'btnGestion_Reservas
        '
        Me.btnGestion_Reservas.AutoSize = True
        Me.btnGestion_Reservas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGestion_Reservas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGestion_Reservas.Depth = 0
        Me.btnGestion_Reservas.Location = New System.Drawing.Point(50, 219)
        Me.btnGestion_Reservas.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnGestion_Reservas.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGestion_Reservas.Name = "btnGestion_Reservas"
        Me.btnGestion_Reservas.Primary = False
        Me.btnGestion_Reservas.Size = New System.Drawing.Size(160, 36)
        Me.btnGestion_Reservas.TabIndex = 1
        Me.btnGestion_Reservas.Text = "Gestión de reservas"
        Me.btnGestion_Reservas.UseVisualStyleBackColor = True
        '
        'btnCancelar_Reservas
        '
        Me.btnCancelar_Reservas.AutoSize = True
        Me.btnCancelar_Reservas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancelar_Reservas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar_Reservas.Depth = 0
        Me.btnCancelar_Reservas.Location = New System.Drawing.Point(50, 278)
        Me.btnCancelar_Reservas.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancelar_Reservas.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelar_Reservas.Name = "btnCancelar_Reservas"
        Me.btnCancelar_Reservas.Primary = False
        Me.btnCancelar_Reservas.Size = New System.Drawing.Size(152, 36)
        Me.btnCancelar_Reservas.TabIndex = 2
        Me.btnCancelar_Reservas.Text = "Cancelar reservas"
        Me.btnCancelar_Reservas.UseVisualStyleBackColor = True
        '
        'btnInventario_Autos
        '
        Me.btnInventario_Autos.AutoSize = True
        Me.btnInventario_Autos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInventario_Autos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventario_Autos.Depth = 0
        Me.btnInventario_Autos.Location = New System.Drawing.Point(329, 124)
        Me.btnInventario_Autos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnInventario_Autos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnInventario_Autos.Name = "btnInventario_Autos"
        Me.btnInventario_Autos.Primary = False
        Me.btnInventario_Autos.Size = New System.Drawing.Size(159, 36)
        Me.btnInventario_Autos.TabIndex = 3
        Me.btnInventario_Autos.Text = "inventario de autos"
        Me.btnInventario_Autos.UseVisualStyleBackColor = True
        '
        'btnDevolver_Autos
        '
        Me.btnDevolver_Autos.AutoSize = True
        Me.btnDevolver_Autos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDevolver_Autos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDevolver_Autos.Depth = 0
        Me.btnDevolver_Autos.Location = New System.Drawing.Point(329, 179)
        Me.btnDevolver_Autos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnDevolver_Autos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDevolver_Autos.Name = "btnDevolver_Autos"
        Me.btnDevolver_Autos.Primary = False
        Me.btnDevolver_Autos.Size = New System.Drawing.Size(119, 36)
        Me.btnDevolver_Autos.TabIndex = 5
        Me.btnDevolver_Autos.Text = "devolver auto"
        Me.btnDevolver_Autos.UseVisualStyleBackColor = True
        '
        'lblClientes
        '
        Me.lblClientes.AutoSize = True
        Me.lblClientes.Depth = 0
        Me.lblClientes.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblClientes.Location = New System.Drawing.Point(41, 89)
        Me.lblClientes.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(64, 19)
        Me.lblClientes.TabIndex = 6
        Me.lblClientes.Text = "Clientes"
        '
        'lblReservas
        '
        Me.lblReservas.AutoSize = True
        Me.lblReservas.Depth = 0
        Me.lblReservas.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblReservas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblReservas.Location = New System.Drawing.Point(41, 183)
        Me.lblReservas.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblReservas.Name = "lblReservas"
        Me.lblReservas.Size = New System.Drawing.Size(70, 19)
        Me.lblReservas.TabIndex = 7
        Me.lblReservas.Text = "Reservas"
        '
        'lblAutos
        '
        Me.lblAutos.AutoSize = True
        Me.lblAutos.Depth = 0
        Me.lblAutos.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblAutos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAutos.Location = New System.Drawing.Point(316, 89)
        Me.lblAutos.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAutos.Name = "lblAutos"
        Me.lblAutos.Size = New System.Drawing.Size(49, 19)
        Me.lblAutos.TabIndex = 8
        Me.lblAutos.Text = "Autos"
        '
        'btnCerrar_Sesion
        '
        Me.btnCerrar_Sesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar_Sesion.Depth = 0
        Me.btnCerrar_Sesion.Location = New System.Drawing.Point(367, 315)
        Me.btnCerrar_Sesion.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCerrar_Sesion.Name = "btnCerrar_Sesion"
        Me.btnCerrar_Sesion.Primary = True
        Me.btnCerrar_Sesion.Size = New System.Drawing.Size(147, 36)
        Me.btnCerrar_Sesion.TabIndex = 75
        Me.btnCerrar_Sesion.Text = "Cerrar sesión"
        Me.btnCerrar_Sesion.UseVisualStyleBackColor = True
        '
        'frmMenu_Agentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 378)
        Me.Controls.Add(Me.btnCerrar_Sesion)
        Me.Controls.Add(Me.lblAutos)
        Me.Controls.Add(Me.lblReservas)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.btnDevolver_Autos)
        Me.Controls.Add(Me.btnInventario_Autos)
        Me.Controls.Add(Me.btnCancelar_Reservas)
        Me.Controls.Add(Me.btnGestion_Reservas)
        Me.Controls.Add(Me.btnRegistrar_Clientes)
        Me.Name = "frmMenu_Agentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú agentes                                                                     " &
    "           Rent-a-Car"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegistrar_Clientes As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnGestion_Reservas As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnCancelar_Reservas As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnInventario_Autos As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnDevolver_Autos As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblClientes As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblReservas As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblAutos As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnCerrar_Sesion As MaterialSkin.Controls.MaterialRaisedButton
End Class
