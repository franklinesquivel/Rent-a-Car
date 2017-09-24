<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialSingleLineTextField7 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialSingleLineTextField6 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField5 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialSingleLineTextField2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialSingleLineTextField3 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField4 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(304, 314)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(142, 36)
        Me.MaterialFlatButton1.TabIndex = 36
        Me.MaterialFlatButton1.Text = "+ Agregar cliente"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel9.Location = New System.Drawing.Point(395, 221)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(47, 19)
        Me.MaterialLabel9.TabIndex = 35
        Me.MaterialLabel9.Text = "Email"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(395, 178)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(55, 19)
        Me.MaterialLabel7.TabIndex = 34
        Me.MaterialLabel7.Text = "Ciudad"
        '
        'MaterialSingleLineTextField7
        '
        Me.MaterialSingleLineTextField7.Depth = 0
        Me.MaterialSingleLineTextField7.Hint = ""
        Me.MaterialSingleLineTextField7.Location = New System.Drawing.Point(466, 174)
        Me.MaterialSingleLineTextField7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField7.Name = "MaterialSingleLineTextField7"
        Me.MaterialSingleLineTextField7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField7.SelectedText = ""
        Me.MaterialSingleLineTextField7.SelectionLength = 0
        Me.MaterialSingleLineTextField7.SelectionStart = 0
        Me.MaterialSingleLineTextField7.Size = New System.Drawing.Size(237, 23)
        Me.MaterialSingleLineTextField7.TabIndex = 33
        Me.MaterialSingleLineTextField7.UseSystemPasswordChar = False
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(31, 220)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(73, 19)
        Me.MaterialLabel6.TabIndex = 32
        Me.MaterialLabel6.Text = "Dirección"
        '
        'MaterialSingleLineTextField6
        '
        Me.MaterialSingleLineTextField6.Depth = 0
        Me.MaterialSingleLineTextField6.Hint = ""
        Me.MaterialSingleLineTextField6.Location = New System.Drawing.Point(115, 220)
        Me.MaterialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField6.Name = "MaterialSingleLineTextField6"
        Me.MaterialSingleLineTextField6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField6.SelectedText = ""
        Me.MaterialSingleLineTextField6.SelectionLength = 0
        Me.MaterialSingleLineTextField6.SelectionStart = 0
        Me.MaterialSingleLineTextField6.Size = New System.Drawing.Size(255, 23)
        Me.MaterialSingleLineTextField6.TabIndex = 31
        Me.MaterialSingleLineTextField6.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField5
        '
        Me.MaterialSingleLineTextField5.Depth = 0
        Me.MaterialSingleLineTextField5.Hint = ""
        Me.MaterialSingleLineTextField5.Location = New System.Drawing.Point(466, 221)
        Me.MaterialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField5.Name = "MaterialSingleLineTextField5"
        Me.MaterialSingleLineTextField5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField5.SelectedText = ""
        Me.MaterialSingleLineTextField5.SelectionLength = 0
        Me.MaterialSingleLineTextField5.SelectionStart = 0
        Me.MaterialSingleLineTextField5.Size = New System.Drawing.Size(237, 23)
        Me.MaterialSingleLineTextField5.TabIndex = 29
        Me.MaterialSingleLineTextField5.UseSystemPasswordChar = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(31, 122)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(63, 19)
        Me.MaterialLabel2.TabIndex = 24
        Me.MaterialLabel2.Text = "Nombre"
        '
        'MaterialSingleLineTextField2
        '
        Me.MaterialSingleLineTextField2.Depth = 0
        Me.MaterialSingleLineTextField2.Hint = ""
        Me.MaterialSingleLineTextField2.Location = New System.Drawing.Point(111, 122)
        Me.MaterialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField2.Name = "MaterialSingleLineTextField2"
        Me.MaterialSingleLineTextField2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField2.SelectedText = ""
        Me.MaterialSingleLineTextField2.SelectionLength = 0
        Me.MaterialSingleLineTextField2.SelectionStart = 0
        Me.MaterialSingleLineTextField2.Size = New System.Drawing.Size(374, 23)
        Me.MaterialSingleLineTextField2.TabIndex = 23
        Me.MaterialSingleLineTextField2.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(31, 178)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(117, 19)
        Me.MaterialLabel1.TabIndex = 22
        Me.MaterialLabel1.Text = "DUI o pasaporte"
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = ""
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(162, 174)
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(208, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 21
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(395, 267)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(143, 19)
        Me.MaterialLabel3.TabIndex = 40
        Me.MaterialLabel3.Text = "Número de telefono"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(40, 267)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(38, 19)
        Me.MaterialLabel4.TabIndex = 39
        Me.MaterialLabel4.Text = "País"
        '
        'MaterialSingleLineTextField3
        '
        Me.MaterialSingleLineTextField3.Depth = 0
        Me.MaterialSingleLineTextField3.Hint = ""
        Me.MaterialSingleLineTextField3.Location = New System.Drawing.Point(111, 267)
        Me.MaterialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField3.Name = "MaterialSingleLineTextField3"
        Me.MaterialSingleLineTextField3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField3.SelectedText = ""
        Me.MaterialSingleLineTextField3.SelectionLength = 0
        Me.MaterialSingleLineTextField3.SelectionStart = 0
        Me.MaterialSingleLineTextField3.Size = New System.Drawing.Size(259, 23)
        Me.MaterialSingleLineTextField3.TabIndex = 38
        Me.MaterialSingleLineTextField3.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField4
        '
        Me.MaterialSingleLineTextField4.Depth = 0
        Me.MaterialSingleLineTextField4.Hint = ""
        Me.MaterialSingleLineTextField4.Location = New System.Drawing.Point(544, 267)
        Me.MaterialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField4.Name = "MaterialSingleLineTextField4"
        Me.MaterialSingleLineTextField4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField4.SelectedText = ""
        Me.MaterialSingleLineTextField4.SelectionLength = 0
        Me.MaterialSingleLineTextField4.SelectionStart = 0
        Me.MaterialSingleLineTextField4.Size = New System.Drawing.Size(159, 23)
        Me.MaterialSingleLineTextField4.TabIndex = 37
        Me.MaterialSingleLineTextField4.UseSystemPasswordChar = False
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(597, 336)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(106, 27)
        Me.MaterialRaisedButton1.TabIndex = 52
        Me.MaterialRaisedButton1.Text = "Regresar"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(733, 27)
        Me.MenuStrip1.TabIndex = 53
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(102, 23)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 385)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialSingleLineTextField3)
        Me.Controls.Add(Me.MaterialSingleLineTextField4)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.MaterialLabel9)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.MaterialSingleLineTextField7)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialSingleLineTextField6)
        Me.Controls.Add(Me.MaterialSingleLineTextField5)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialSingleLineTextField2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmClientes"
        Me.Text = "Registro de usuarios                                                             " &
    "                                                      Rent-a-Car"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialSingleLineTextField7 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialSingleLineTextField6 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField5 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialSingleLineTextField2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialSingleLineTextField3 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField4 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
End Class
