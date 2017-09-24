<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu_Admin
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
        Me.btnRegistrar_Agencias = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnRegistrar_Usuarios = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnEstado_Autos = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnModificar_Auto = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblGestionar_Autos = New MaterialSkin.Controls.MaterialLabel()
        Me.btnReportes_Coches = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblReportes = New MaterialSkin.Controls.MaterialLabel()
        Me.btnReportes_Rentas = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnIngresar_Auto = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblRegistrar = New MaterialSkin.Controls.MaterialLabel()
        Me.lblAutos = New MaterialSkin.Controls.MaterialLabel()
        Me.lblReservas = New MaterialSkin.Controls.MaterialLabel()
        Me.lblClientes = New MaterialSkin.Controls.MaterialLabel()
        Me.btnDevolver_Autos = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnRentar_Autos = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnInventario_Autos = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnCancelar_Reservas = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnGestion_Reservas = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnRegistrar_Clientes = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnCerrar_Sesion = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'btnRegistrar_Agencias
        '
        Me.btnRegistrar_Agencias.AutoSize = True
        Me.btnRegistrar_Agencias.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRegistrar_Agencias.Depth = 0
        Me.btnRegistrar_Agencias.Location = New System.Drawing.Point(48, 137)
        Me.btnRegistrar_Agencias.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRegistrar_Agencias.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegistrar_Agencias.Name = "btnRegistrar_Agencias"
        Me.btnRegistrar_Agencias.Primary = False
        Me.btnRegistrar_Agencias.Size = New System.Drawing.Size(158, 36)
        Me.btnRegistrar_Agencias.TabIndex = 0
        Me.btnRegistrar_Agencias.Text = " Registrar Agencias"
        Me.btnRegistrar_Agencias.UseVisualStyleBackColor = True
        '
        'btnRegistrar_Usuarios
        '
        Me.btnRegistrar_Usuarios.AutoSize = True
        Me.btnRegistrar_Usuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRegistrar_Usuarios.Depth = 0
        Me.btnRegistrar_Usuarios.Location = New System.Drawing.Point(240, 137)
        Me.btnRegistrar_Usuarios.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRegistrar_Usuarios.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegistrar_Usuarios.Name = "btnRegistrar_Usuarios"
        Me.btnRegistrar_Usuarios.Primary = False
        Me.btnRegistrar_Usuarios.Size = New System.Drawing.Size(153, 36)
        Me.btnRegistrar_Usuarios.TabIndex = 2
        Me.btnRegistrar_Usuarios.Text = "Registrar Usuarios"
        Me.btnRegistrar_Usuarios.UseVisualStyleBackColor = True
        '
        'btnEstado_Autos
        '
        Me.btnEstado_Autos.AutoSize = True
        Me.btnEstado_Autos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEstado_Autos.Depth = 0
        Me.btnEstado_Autos.Location = New System.Drawing.Point(446, 233)
        Me.btnEstado_Autos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEstado_Autos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEstado_Autos.Name = "btnEstado_Autos"
        Me.btnEstado_Autos.Primary = False
        Me.btnEstado_Autos.Size = New System.Drawing.Size(160, 36)
        Me.btnEstado_Autos.TabIndex = 23
        Me.btnEstado_Autos.Text = "Estado de los Autos"
        Me.btnEstado_Autos.UseVisualStyleBackColor = True
        '
        'btnModificar_Auto
        '
        Me.btnModificar_Auto.AutoSize = True
        Me.btnModificar_Auto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnModificar_Auto.Depth = 0
        Me.btnModificar_Auto.Location = New System.Drawing.Point(446, 185)
        Me.btnModificar_Auto.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnModificar_Auto.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnModificar_Auto.Name = "btnModificar_Auto"
        Me.btnModificar_Auto.Primary = False
        Me.btnModificar_Auto.Size = New System.Drawing.Size(124, 36)
        Me.btnModificar_Auto.TabIndex = 22
        Me.btnModificar_Auto.Text = "Modificar auto"
        Me.btnModificar_Auto.UseVisualStyleBackColor = True
        '
        'lblGestionar_Autos
        '
        Me.lblGestionar_Autos.AutoSize = True
        Me.lblGestionar_Autos.Depth = 0
        Me.lblGestionar_Autos.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblGestionar_Autos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGestionar_Autos.Location = New System.Drawing.Point(425, 101)
        Me.lblGestionar_Autos.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblGestionar_Autos.Name = "lblGestionar_Autos"
        Me.lblGestionar_Autos.Size = New System.Drawing.Size(116, 19)
        Me.lblGestionar_Autos.TabIndex = 21
        Me.lblGestionar_Autos.Text = "Gestionar autos"
        '
        'btnReportes_Coches
        '
        Me.btnReportes_Coches.AutoSize = True
        Me.btnReportes_Coches.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnReportes_Coches.Depth = 0
        Me.btnReportes_Coches.Location = New System.Drawing.Point(446, 382)
        Me.btnReportes_Coches.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnReportes_Coches.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnReportes_Coches.Name = "btnReportes_Coches"
        Me.btnReportes_Coches.Primary = False
        Me.btnReportes_Coches.Size = New System.Drawing.Size(222, 36)
        Me.btnReportes_Coches.TabIndex = 20
        Me.btnReportes_Coches.Text = "Reporte de coches rentados"
        Me.btnReportes_Coches.UseVisualStyleBackColor = True
        '
        'lblReportes
        '
        Me.lblReportes.AutoSize = True
        Me.lblReportes.Depth = 0
        Me.lblReportes.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblReportes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblReportes.Location = New System.Drawing.Point(425, 284)
        Me.lblReportes.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblReportes.Name = "lblReportes"
        Me.lblReportes.Size = New System.Drawing.Size(69, 19)
        Me.lblReportes.TabIndex = 19
        Me.lblReportes.Text = "Reportes"
        '
        'btnReportes_Rentas
        '
        Me.btnReportes_Rentas.AutoSize = True
        Me.btnReportes_Rentas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnReportes_Rentas.Depth = 0
        Me.btnReportes_Rentas.Location = New System.Drawing.Point(446, 322)
        Me.btnReportes_Rentas.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnReportes_Rentas.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnReportes_Rentas.Name = "btnReportes_Rentas"
        Me.btnReportes_Rentas.Primary = False
        Me.btnReportes_Rentas.Size = New System.Drawing.Size(208, 36)
        Me.btnReportes_Rentas.TabIndex = 18
        Me.btnReportes_Rentas.Text = "Reportes de renta por mes"
        Me.btnReportes_Rentas.UseVisualStyleBackColor = True
        '
        'btnIngresar_Auto
        '
        Me.btnIngresar_Auto.AutoSize = True
        Me.btnIngresar_Auto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnIngresar_Auto.Depth = 0
        Me.btnIngresar_Auto.Location = New System.Drawing.Point(446, 137)
        Me.btnIngresar_Auto.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnIngresar_Auto.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnIngresar_Auto.Name = "btnIngresar_Auto"
        Me.btnIngresar_Auto.Primary = False
        Me.btnIngresar_Auto.Size = New System.Drawing.Size(165, 36)
        Me.btnIngresar_Auto.TabIndex = 17
        Me.btnIngresar_Auto.Text = "Ingresar nuevo auto"
        Me.btnIngresar_Auto.UseVisualStyleBackColor = True
        '
        'lblRegistrar
        '
        Me.lblRegistrar.AutoSize = True
        Me.lblRegistrar.Depth = 0
        Me.lblRegistrar.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblRegistrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRegistrar.Location = New System.Drawing.Point(31, 101)
        Me.lblRegistrar.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblRegistrar.Name = "lblRegistrar"
        Me.lblRegistrar.Size = New System.Drawing.Size(69, 19)
        Me.lblRegistrar.TabIndex = 24
        Me.lblRegistrar.Text = "Registrar"
        '
        'lblAutos
        '
        Me.lblAutos.AutoSize = True
        Me.lblAutos.Depth = 0
        Me.lblAutos.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblAutos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAutos.Location = New System.Drawing.Point(218, 215)
        Me.lblAutos.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAutos.Name = "lblAutos"
        Me.lblAutos.Size = New System.Drawing.Size(49, 19)
        Me.lblAutos.TabIndex = 33
        Me.lblAutos.Text = "Autos"
        '
        'lblReservas
        '
        Me.lblReservas.AutoSize = True
        Me.lblReservas.Depth = 0
        Me.lblReservas.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblReservas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblReservas.Location = New System.Drawing.Point(21, 301)
        Me.lblReservas.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblReservas.Name = "lblReservas"
        Me.lblReservas.Size = New System.Drawing.Size(70, 19)
        Me.lblReservas.TabIndex = 32
        Me.lblReservas.Text = "Reservas"
        '
        'lblClientes
        '
        Me.lblClientes.AutoSize = True
        Me.lblClientes.Depth = 0
        Me.lblClientes.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblClientes.Location = New System.Drawing.Point(21, 215)
        Me.lblClientes.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(64, 19)
        Me.lblClientes.TabIndex = 31
        Me.lblClientes.Text = "Clientes"
        '
        'btnDevolver_Autos
        '
        Me.btnDevolver_Autos.AutoSize = True
        Me.btnDevolver_Autos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDevolver_Autos.Depth = 0
        Me.btnDevolver_Autos.Location = New System.Drawing.Point(234, 371)
        Me.btnDevolver_Autos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnDevolver_Autos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDevolver_Autos.Name = "btnDevolver_Autos"
        Me.btnDevolver_Autos.Primary = False
        Me.btnDevolver_Autos.Size = New System.Drawing.Size(119, 36)
        Me.btnDevolver_Autos.TabIndex = 30
        Me.btnDevolver_Autos.Text = "devolver auto"
        Me.btnDevolver_Autos.UseVisualStyleBackColor = True
        '
        'btnRentar_Autos
        '
        Me.btnRentar_Autos.AutoSize = True
        Me.btnRentar_Autos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRentar_Autos.Depth = 0
        Me.btnRentar_Autos.Location = New System.Drawing.Point(234, 313)
        Me.btnRentar_Autos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRentar_Autos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRentar_Autos.Name = "btnRentar_Autos"
        Me.btnRentar_Autos.Primary = False
        Me.btnRentar_Autos.Size = New System.Drawing.Size(103, 36)
        Me.btnRentar_Autos.TabIndex = 29
        Me.btnRentar_Autos.Text = "Rentar auto"
        Me.btnRentar_Autos.UseVisualStyleBackColor = True
        '
        'btnInventario_Autos
        '
        Me.btnInventario_Autos.AutoSize = True
        Me.btnInventario_Autos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInventario_Autos.Depth = 0
        Me.btnInventario_Autos.Location = New System.Drawing.Point(234, 250)
        Me.btnInventario_Autos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnInventario_Autos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnInventario_Autos.Name = "btnInventario_Autos"
        Me.btnInventario_Autos.Primary = False
        Me.btnInventario_Autos.Size = New System.Drawing.Size(159, 36)
        Me.btnInventario_Autos.TabIndex = 28
        Me.btnInventario_Autos.Text = "inventario de autos"
        Me.btnInventario_Autos.UseVisualStyleBackColor = True
        '
        'btnCancelar_Reservas
        '
        Me.btnCancelar_Reservas.AutoSize = True
        Me.btnCancelar_Reservas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancelar_Reservas.Depth = 0
        Me.btnCancelar_Reservas.Location = New System.Drawing.Point(30, 405)
        Me.btnCancelar_Reservas.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancelar_Reservas.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelar_Reservas.Name = "btnCancelar_Reservas"
        Me.btnCancelar_Reservas.Primary = False
        Me.btnCancelar_Reservas.Size = New System.Drawing.Size(152, 36)
        Me.btnCancelar_Reservas.TabIndex = 27
        Me.btnCancelar_Reservas.Text = "Cancelar reservas"
        Me.btnCancelar_Reservas.UseVisualStyleBackColor = True
        '
        'btnGestion_Reservas
        '
        Me.btnGestion_Reservas.AutoSize = True
        Me.btnGestion_Reservas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGestion_Reservas.Depth = 0
        Me.btnGestion_Reservas.Location = New System.Drawing.Point(30, 343)
        Me.btnGestion_Reservas.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnGestion_Reservas.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGestion_Reservas.Name = "btnGestion_Reservas"
        Me.btnGestion_Reservas.Primary = False
        Me.btnGestion_Reservas.Size = New System.Drawing.Size(160, 36)
        Me.btnGestion_Reservas.TabIndex = 26
        Me.btnGestion_Reservas.Text = "Gestión de reservas"
        Me.btnGestion_Reservas.UseVisualStyleBackColor = True
        '
        'btnRegistrar_Clientes
        '
        Me.btnRegistrar_Clientes.AutoSize = True
        Me.btnRegistrar_Clientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRegistrar_Clientes.Depth = 0
        Me.btnRegistrar_Clientes.Location = New System.Drawing.Point(40, 250)
        Me.btnRegistrar_Clientes.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRegistrar_Clientes.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegistrar_Clientes.Name = "btnRegistrar_Clientes"
        Me.btnRegistrar_Clientes.Primary = False
        Me.btnRegistrar_Clientes.Size = New System.Drawing.Size(150, 36)
        Me.btnRegistrar_Clientes.TabIndex = 25
        Me.btnRegistrar_Clientes.Text = "Registrar clientes"
        Me.btnRegistrar_Clientes.UseVisualStyleBackColor = True
        '
        'btnCerrar_Sesion
        '
        Me.btnCerrar_Sesion.Depth = 0
        Me.btnCerrar_Sesion.Location = New System.Drawing.Point(521, 444)
        Me.btnCerrar_Sesion.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCerrar_Sesion.Name = "btnCerrar_Sesion"
        Me.btnCerrar_Sesion.Primary = True
        Me.btnCerrar_Sesion.Size = New System.Drawing.Size(147, 36)
        Me.btnCerrar_Sesion.TabIndex = 73
        Me.btnCerrar_Sesion.Text = "Cerrar sesión"
        Me.btnCerrar_Sesion.UseVisualStyleBackColor = True
        '
        'frmMenu_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 492)
        Me.Controls.Add(Me.btnCerrar_Sesion)
        Me.Controls.Add(Me.lblAutos)
        Me.Controls.Add(Me.lblReservas)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.btnDevolver_Autos)
        Me.Controls.Add(Me.btnRentar_Autos)
        Me.Controls.Add(Me.btnInventario_Autos)
        Me.Controls.Add(Me.btnCancelar_Reservas)
        Me.Controls.Add(Me.btnGestion_Reservas)
        Me.Controls.Add(Me.btnRegistrar_Clientes)
        Me.Controls.Add(Me.lblRegistrar)
        Me.Controls.Add(Me.btnEstado_Autos)
        Me.Controls.Add(Me.btnModificar_Auto)
        Me.Controls.Add(Me.lblGestionar_Autos)
        Me.Controls.Add(Me.btnReportes_Coches)
        Me.Controls.Add(Me.lblReportes)
        Me.Controls.Add(Me.btnReportes_Rentas)
        Me.Controls.Add(Me.btnIngresar_Auto)
        Me.Controls.Add(Me.btnRegistrar_Usuarios)
        Me.Controls.Add(Me.btnRegistrar_Agencias)
        Me.Name = "frmMenu_Admin"
        Me.Text = "Menú Administrador                                                               " &
    "                                          Rent-a-Car"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegistrar_Agencias As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnRegistrar_Usuarios As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnEstado_Autos As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnModificar_Auto As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblGestionar_Autos As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnReportes_Coches As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblReportes As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnReportes_Rentas As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnIngresar_Auto As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblRegistrar As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblAutos As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblReservas As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblClientes As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnDevolver_Autos As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnRentar_Autos As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnInventario_Autos As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnCancelar_Reservas As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnGestion_Reservas As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnRegistrar_Clientes As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnCerrar_Sesion As MaterialSkin.Controls.MaterialRaisedButton
End Class
