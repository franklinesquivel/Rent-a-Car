<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentar_Autos
    Inherits System.Windows.Forms.Form

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
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnRentar_Autos = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txbCodigo_Reserva = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblCodigo_Reserva = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvRentar_Autos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvRentar_Autos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegresar
        '
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(443, 215)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(106, 27)
        Me.btnRegresar.TabIndex = 72
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnRentar_Autos
        '
        Me.btnRentar_Autos.AutoSize = True
        Me.btnRentar_Autos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRentar_Autos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRentar_Autos.Depth = 0
        Me.btnRentar_Autos.Location = New System.Drawing.Point(249, 181)
        Me.btnRentar_Autos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRentar_Autos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRentar_Autos.Name = "btnRentar_Autos"
        Me.btnRentar_Autos.Primary = False
        Me.btnRentar_Autos.Size = New System.Drawing.Size(131, 36)
        Me.btnRentar_Autos.TabIndex = 71
        Me.btnRentar_Autos.Text = "Registrar Renta"
        Me.btnRentar_Autos.UseVisualStyleBackColor = True
        '
        'txbCodigo_Reserva
        '
        Me.txbCodigo_Reserva.Depth = 0
        Me.txbCodigo_Reserva.Hint = ""
        Me.txbCodigo_Reserva.Location = New System.Drawing.Point(260, 20)
        Me.txbCodigo_Reserva.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbCodigo_Reserva.Name = "txbCodigo_Reserva"
        Me.txbCodigo_Reserva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbCodigo_Reserva.SelectedText = ""
        Me.txbCodigo_Reserva.SelectionLength = 0
        Me.txbCodigo_Reserva.SelectionStart = 0
        Me.txbCodigo_Reserva.Size = New System.Drawing.Size(289, 23)
        Me.txbCodigo_Reserva.TabIndex = 70
        Me.txbCodigo_Reserva.UseSystemPasswordChar = False
        '
        'lblCodigo_Reserva
        '
        Me.lblCodigo_Reserva.AutoSize = True
        Me.lblCodigo_Reserva.Depth = 0
        Me.lblCodigo_Reserva.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblCodigo_Reserva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCodigo_Reserva.Location = New System.Drawing.Point(69, 20)
        Me.lblCodigo_Reserva.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCodigo_Reserva.Name = "lblCodigo_Reserva"
        Me.lblCodigo_Reserva.Size = New System.Drawing.Size(178, 19)
        Me.lblCodigo_Reserva.TabIndex = 69
        Me.lblCodigo_Reserva.Text = "Buscar código de reserva"
        '
        'dgvRentar_Autos
        '
        Me.dgvRentar_Autos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRentar_Autos.Location = New System.Drawing.Point(73, 59)
        Me.dgvRentar_Autos.Name = "dgvRentar_Autos"
        Me.dgvRentar_Autos.ReadOnly = True
        Me.dgvRentar_Autos.Size = New System.Drawing.Size(476, 93)
        Me.dgvRentar_Autos.TabIndex = 68
        '
        'frmRentar_Autos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 262)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnRentar_Autos)
        Me.Controls.Add(Me.txbCodigo_Reserva)
        Me.Controls.Add(Me.lblCodigo_Reserva)
        Me.Controls.Add(Me.dgvRentar_Autos)
        Me.Name = "frmRentar_Autos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rentar Autos"
        CType(Me.dgvRentar_Autos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnRentar_Autos As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txbCodigo_Reserva As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblCodigo_Reserva As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvRentar_Autos As DataGridView
End Class
