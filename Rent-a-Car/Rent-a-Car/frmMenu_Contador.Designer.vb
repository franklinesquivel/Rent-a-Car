﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu_contador
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
        Me.btnReportes_Rentas = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnIngresar_Auto = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblReportes = New MaterialSkin.Controls.MaterialLabel()
        Me.btnReportes_Coches = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblGestionar_Autos = New MaterialSkin.Controls.MaterialLabel()
        Me.btnModificar_Auto = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnEstado_Autos = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnCerrar_Sesion = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'btnReportes_Rentas
        '
        Me.btnReportes_Rentas.AutoSize = True
        Me.btnReportes_Rentas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnReportes_Rentas.Depth = 0
        Me.btnReportes_Rentas.Location = New System.Drawing.Point(320, 122)
        Me.btnReportes_Rentas.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnReportes_Rentas.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnReportes_Rentas.Name = "btnReportes_Rentas"
        Me.btnReportes_Rentas.Primary = False
        Me.btnReportes_Rentas.Size = New System.Drawing.Size(208, 36)
        Me.btnReportes_Rentas.TabIndex = 11
        Me.btnReportes_Rentas.Text = "Reportes de renta por mes"
        Me.btnReportes_Rentas.UseVisualStyleBackColor = True
        '
        'btnIngresar_Auto
        '
        Me.btnIngresar_Auto.AutoSize = True
        Me.btnIngresar_Auto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnIngresar_Auto.Depth = 0
        Me.btnIngresar_Auto.Location = New System.Drawing.Point(50, 179)
        Me.btnIngresar_Auto.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnIngresar_Auto.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnIngresar_Auto.Name = "btnIngresar_Auto"
        Me.btnIngresar_Auto.Primary = False
        Me.btnIngresar_Auto.Size = New System.Drawing.Size(165, 36)
        Me.btnIngresar_Auto.TabIndex = 10
        Me.btnIngresar_Auto.Text = "Ingresar nuevo auto"
        Me.btnIngresar_Auto.UseVisualStyleBackColor = True
        '
        'lblReportes
        '
        Me.lblReportes.AutoSize = True
        Me.lblReportes.Depth = 0
        Me.lblReportes.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblReportes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblReportes.Location = New System.Drawing.Point(295, 84)
        Me.lblReportes.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblReportes.Name = "lblReportes"
        Me.lblReportes.Size = New System.Drawing.Size(69, 19)
        Me.lblReportes.TabIndex = 12
        Me.lblReportes.Text = "Reportes"
        '
        'btnReportes_Coches
        '
        Me.btnReportes_Coches.AutoSize = True
        Me.btnReportes_Coches.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnReportes_Coches.Depth = 0
        Me.btnReportes_Coches.Location = New System.Drawing.Point(320, 179)
        Me.btnReportes_Coches.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnReportes_Coches.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnReportes_Coches.Name = "btnReportes_Coches"
        Me.btnReportes_Coches.Primary = False
        Me.btnReportes_Coches.Size = New System.Drawing.Size(222, 36)
        Me.btnReportes_Coches.TabIndex = 13
        Me.btnReportes_Coches.Text = "Reporte de coches rentados"
        Me.btnReportes_Coches.UseVisualStyleBackColor = True
        '
        'lblGestionar_Autos
        '
        Me.lblGestionar_Autos.AutoSize = True
        Me.lblGestionar_Autos.Depth = 0
        Me.lblGestionar_Autos.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblGestionar_Autos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGestionar_Autos.Location = New System.Drawing.Point(25, 83)
        Me.lblGestionar_Autos.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblGestionar_Autos.Name = "lblGestionar_Autos"
        Me.lblGestionar_Autos.Size = New System.Drawing.Size(116, 19)
        Me.lblGestionar_Autos.TabIndex = 14
        Me.lblGestionar_Autos.Text = "Gestionar autos"
        '
        'btnModificar_Auto
        '
        Me.btnModificar_Auto.AutoSize = True
        Me.btnModificar_Auto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnModificar_Auto.Depth = 0
        Me.btnModificar_Auto.Location = New System.Drawing.Point(50, 236)
        Me.btnModificar_Auto.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnModificar_Auto.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnModificar_Auto.Name = "btnModificar_Auto"
        Me.btnModificar_Auto.Primary = False
        Me.btnModificar_Auto.Size = New System.Drawing.Size(124, 36)
        Me.btnModificar_Auto.TabIndex = 15
        Me.btnModificar_Auto.Text = "Modificar auto"
        Me.btnModificar_Auto.UseVisualStyleBackColor = True
        '
        'btnEstado_Autos
        '
        Me.btnEstado_Autos.AutoSize = True
        Me.btnEstado_Autos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEstado_Autos.Depth = 0
        Me.btnEstado_Autos.Location = New System.Drawing.Point(50, 122)
        Me.btnEstado_Autos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEstado_Autos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEstado_Autos.Name = "btnEstado_Autos"
        Me.btnEstado_Autos.Primary = False
        Me.btnEstado_Autos.Size = New System.Drawing.Size(160, 36)
        Me.btnEstado_Autos.TabIndex = 16
        Me.btnEstado_Autos.Text = "Estado de los Autos"
        Me.btnEstado_Autos.UseVisualStyleBackColor = True
        '
        'btnCerrar_Sesion
        '
        Me.btnCerrar_Sesion.Depth = 0
        Me.btnCerrar_Sesion.Location = New System.Drawing.Point(395, 268)
        Me.btnCerrar_Sesion.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCerrar_Sesion.Name = "btnCerrar_Sesion"
        Me.btnCerrar_Sesion.Primary = True
        Me.btnCerrar_Sesion.Size = New System.Drawing.Size(147, 36)
        Me.btnCerrar_Sesion.TabIndex = 74
        Me.btnCerrar_Sesion.Text = "Cerrar sesión"
        Me.btnCerrar_Sesion.UseVisualStyleBackColor = True
        '
        'frmMenu_contador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 320)
        Me.Controls.Add(Me.btnCerrar_Sesion)
        Me.Controls.Add(Me.btnEstado_Autos)
        Me.Controls.Add(Me.btnModificar_Auto)
        Me.Controls.Add(Me.lblGestionar_Autos)
        Me.Controls.Add(Me.btnReportes_Coches)
        Me.Controls.Add(Me.lblReportes)
        Me.Controls.Add(Me.btnReportes_Rentas)
        Me.Controls.Add(Me.btnIngresar_Auto)
        Me.Name = "frmMenu_contador"
        Me.Text = "Menú contador                                                                    " &
    "                 Rent-a-Car"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReportes_Rentas As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnIngresar_Auto As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblReportes As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnReportes_Coches As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblGestionar_Autos As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnModificar_Auto As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnEstado_Autos As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnCerrar_Sesion As MaterialSkin.Controls.MaterialRaisedButton
End Class
