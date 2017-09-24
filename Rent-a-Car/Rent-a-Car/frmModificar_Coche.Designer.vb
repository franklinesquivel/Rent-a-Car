<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificar_Coche
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
        Me.rdbMicrobuses = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdbPickups = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdbSedan = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btnModificar_Coche = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblTipo_Coche = New MaterialSkin.Controls.MaterialLabel()
        Me.btnFoto = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblAgencia_Coche = New MaterialSkin.Controls.MaterialLabel()
        Me.lblPrecio_Alquiler = New MaterialSkin.Controls.MaterialLabel()
        Me.txbPrecio_Alquiler = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblNumero_Pasajeros = New MaterialSkin.Controls.MaterialLabel()
        Me.txbNumero_Pasajeros = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblKilometraje = New MaterialSkin.Controls.MaterialLabel()
        Me.txbKilometraje = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblFoto = New MaterialSkin.Controls.MaterialLabel()
        Me.txbAgencia_Coche = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblColor = New MaterialSkin.Controls.MaterialLabel()
        Me.txbColor = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblModelo = New MaterialSkin.Controls.MaterialLabel()
        Me.txbModelo = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblMarca = New MaterialSkin.Controls.MaterialLabel()
        Me.txbMarca = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblMatricula = New MaterialSkin.Controls.MaterialLabel()
        Me.txbMatricula = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txbBuscar_Coche = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblBuscar_Coche = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvBuscar_Coche = New System.Windows.Forms.DataGridView()
        Me.btnRegresar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ofdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnsCerrar_Sesion = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvBuscar_Coche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdbMicrobuses
        '
        Me.rdbMicrobuses.AutoSize = True
        Me.rdbMicrobuses.Depth = 0
        Me.rdbMicrobuses.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbMicrobuses.Location = New System.Drawing.Point(508, 496)
        Me.rdbMicrobuses.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbMicrobuses.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbMicrobuses.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbMicrobuses.Name = "rdbMicrobuses"
        Me.rdbMicrobuses.Ripple = True
        Me.rdbMicrobuses.Size = New System.Drawing.Size(101, 30)
        Me.rdbMicrobuses.TabIndex = 51
        Me.rdbMicrobuses.TabStop = True
        Me.rdbMicrobuses.Text = "Microbuses"
        Me.rdbMicrobuses.UseVisualStyleBackColor = True
        '
        'rdbPickups
        '
        Me.rdbPickups.AutoSize = True
        Me.rdbPickups.Depth = 0
        Me.rdbPickups.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbPickups.Location = New System.Drawing.Point(377, 496)
        Me.rdbPickups.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbPickups.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbPickups.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbPickups.Name = "rdbPickups"
        Me.rdbPickups.Ripple = True
        Me.rdbPickups.Size = New System.Drawing.Size(78, 30)
        Me.rdbPickups.TabIndex = 50
        Me.rdbPickups.TabStop = True
        Me.rdbPickups.Text = "Pickups"
        Me.rdbPickups.UseVisualStyleBackColor = True
        '
        'rdbSedan
        '
        Me.rdbSedan.AutoSize = True
        Me.rdbSedan.Depth = 0
        Me.rdbSedan.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdbSedan.Location = New System.Drawing.Point(269, 496)
        Me.rdbSedan.Margin = New System.Windows.Forms.Padding(0)
        Me.rdbSedan.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdbSedan.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdbSedan.Name = "rdbSedan"
        Me.rdbSedan.Ripple = True
        Me.rdbSedan.Size = New System.Drawing.Size(67, 30)
        Me.rdbSedan.TabIndex = 49
        Me.rdbSedan.TabStop = True
        Me.rdbSedan.Text = "Sedan"
        Me.rdbSedan.UseVisualStyleBackColor = True
        '
        'btnModificar_Coche
        '
        Me.btnModificar_Coche.AutoSize = True
        Me.btnModificar_Coche.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnModificar_Coche.Depth = 0
        Me.btnModificar_Coche.Location = New System.Drawing.Point(311, 548)
        Me.btnModificar_Coche.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnModificar_Coche.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnModificar_Coche.Name = "btnModificar_Coche"
        Me.btnModificar_Coche.Primary = False
        Me.btnModificar_Coche.Size = New System.Drawing.Size(133, 36)
        Me.btnModificar_Coche.TabIndex = 48
        Me.btnModificar_Coche.Text = "Modificar coche"
        Me.btnModificar_Coche.UseVisualStyleBackColor = True
        '
        'lblTipo_Coche
        '
        Me.lblTipo_Coche.AutoSize = True
        Me.lblTipo_Coche.Depth = 0
        Me.lblTipo_Coche.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblTipo_Coche.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTipo_Coche.Location = New System.Drawing.Point(137, 501)
        Me.lblTipo_Coche.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTipo_Coche.Name = "lblTipo_Coche"
        Me.lblTipo_Coche.Size = New System.Drawing.Size(104, 19)
        Me.lblTipo_Coche.TabIndex = 47
        Me.lblTipo_Coche.Text = "Tipo de coche"
        '
        'btnFoto
        '
        Me.btnFoto.AutoSize = True
        Me.btnFoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFoto.Depth = 0
        Me.btnFoto.Location = New System.Drawing.Point(519, 345)
        Me.btnFoto.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnFoto.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Primary = False
        Me.btnFoto.Size = New System.Drawing.Size(141, 36)
        Me.btnFoto.TabIndex = 46
        Me.btnFoto.Text = "+Agrege una foto"
        Me.btnFoto.UseVisualStyleBackColor = True
        '
        'lblAgencia_Coche
        '
        Me.lblAgencia_Coche.AutoSize = True
        Me.lblAgencia_Coche.Depth = 0
        Me.lblAgencia_Coche.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblAgencia_Coche.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAgencia_Coche.Location = New System.Drawing.Point(396, 411)
        Me.lblAgencia_Coche.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAgencia_Coche.Name = "lblAgencia_Coche"
        Me.lblAgencia_Coche.Size = New System.Drawing.Size(132, 19)
        Me.lblAgencia_Coche.TabIndex = 45
        Me.lblAgencia_Coche.Text = "Agencia del coche"
        '
        'lblPrecio_Alquiler
        '
        Me.lblPrecio_Alquiler.AutoSize = True
        Me.lblPrecio_Alquiler.Depth = 0
        Me.lblPrecio_Alquiler.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPrecio_Alquiler.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPrecio_Alquiler.Location = New System.Drawing.Point(29, 456)
        Me.lblPrecio_Alquiler.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPrecio_Alquiler.Name = "lblPrecio_Alquiler"
        Me.lblPrecio_Alquiler.Size = New System.Drawing.Size(126, 19)
        Me.lblPrecio_Alquiler.TabIndex = 44
        Me.lblPrecio_Alquiler.Text = "Precio de alquiler"
        '
        'txbPrecio_Alquiler
        '
        Me.txbPrecio_Alquiler.Depth = 0
        Me.txbPrecio_Alquiler.Hint = ""
        Me.txbPrecio_Alquiler.Location = New System.Drawing.Point(172, 452)
        Me.txbPrecio_Alquiler.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbPrecio_Alquiler.Name = "txbPrecio_Alquiler"
        Me.txbPrecio_Alquiler.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbPrecio_Alquiler.SelectedText = ""
        Me.txbPrecio_Alquiler.SelectionLength = 0
        Me.txbPrecio_Alquiler.SelectionStart = 0
        Me.txbPrecio_Alquiler.Size = New System.Drawing.Size(183, 23)
        Me.txbPrecio_Alquiler.TabIndex = 43
        Me.txbPrecio_Alquiler.UseSystemPasswordChar = False
        '
        'lblNumero_Pasajeros
        '
        Me.lblNumero_Pasajeros.AutoSize = True
        Me.lblNumero_Pasajeros.Depth = 0
        Me.lblNumero_Pasajeros.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblNumero_Pasajeros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNumero_Pasajeros.Location = New System.Drawing.Point(29, 411)
        Me.lblNumero_Pasajeros.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblNumero_Pasajeros.Name = "lblNumero_Pasajeros"
        Me.lblNumero_Pasajeros.Size = New System.Drawing.Size(153, 19)
        Me.lblNumero_Pasajeros.TabIndex = 42
        Me.lblNumero_Pasajeros.Text = "Número de pasajeros"
        '
        'txbNumero_Pasajeros
        '
        Me.txbNumero_Pasajeros.Depth = 0
        Me.txbNumero_Pasajeros.Hint = ""
        Me.txbNumero_Pasajeros.Location = New System.Drawing.Point(209, 407)
        Me.txbNumero_Pasajeros.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbNumero_Pasajeros.Name = "txbNumero_Pasajeros"
        Me.txbNumero_Pasajeros.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbNumero_Pasajeros.SelectedText = ""
        Me.txbNumero_Pasajeros.SelectionLength = 0
        Me.txbNumero_Pasajeros.SelectionStart = 0
        Me.txbNumero_Pasajeros.Size = New System.Drawing.Size(146, 23)
        Me.txbNumero_Pasajeros.TabIndex = 41
        Me.txbNumero_Pasajeros.UseSystemPasswordChar = False
        '
        'lblKilometraje
        '
        Me.lblKilometraje.AutoSize = True
        Me.lblKilometraje.Depth = 0
        Me.lblKilometraje.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblKilometraje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblKilometraje.Location = New System.Drawing.Point(29, 358)
        Me.lblKilometraje.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblKilometraje.Name = "lblKilometraje"
        Me.lblKilometraje.Size = New System.Drawing.Size(86, 19)
        Me.lblKilometraje.TabIndex = 40
        Me.lblKilometraje.Text = "Kilometraje"
        '
        'txbKilometraje
        '
        Me.txbKilometraje.Depth = 0
        Me.txbKilometraje.Hint = ""
        Me.txbKilometraje.Location = New System.Drawing.Point(137, 358)
        Me.txbKilometraje.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbKilometraje.Name = "txbKilometraje"
        Me.txbKilometraje.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbKilometraje.SelectedText = ""
        Me.txbKilometraje.SelectionLength = 0
        Me.txbKilometraje.SelectionStart = 0
        Me.txbKilometraje.Size = New System.Drawing.Size(218, 23)
        Me.txbKilometraje.TabIndex = 39
        Me.txbKilometraje.UseSystemPasswordChar = False
        '
        'lblFoto
        '
        Me.lblFoto.AutoSize = True
        Me.lblFoto.Depth = 0
        Me.lblFoto.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblFoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFoto.Location = New System.Drawing.Point(396, 353)
        Me.lblFoto.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFoto.Name = "lblFoto"
        Me.lblFoto.Size = New System.Drawing.Size(78, 19)
        Me.lblFoto.TabIndex = 38
        Me.lblFoto.Text = "Fotografía"
        '
        'txbAgencia_Coche
        '
        Me.txbAgencia_Coche.Depth = 0
        Me.txbAgencia_Coche.Hint = ""
        Me.txbAgencia_Coche.Location = New System.Drawing.Point(534, 407)
        Me.txbAgencia_Coche.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbAgencia_Coche.Name = "txbAgencia_Coche"
        Me.txbAgencia_Coche.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbAgencia_Coche.SelectedText = ""
        Me.txbAgencia_Coche.SelectionLength = 0
        Me.txbAgencia_Coche.SelectionStart = 0
        Me.txbAgencia_Coche.Size = New System.Drawing.Size(171, 23)
        Me.txbAgencia_Coche.TabIndex = 37
        Me.txbAgencia_Coche.UseSystemPasswordChar = False
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Depth = 0
        Me.lblColor.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblColor.Location = New System.Drawing.Point(396, 303)
        Me.lblColor.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(46, 19)
        Me.lblColor.TabIndex = 36
        Me.lblColor.Text = "Color"
        '
        'txbColor
        '
        Me.txbColor.Depth = 0
        Me.txbColor.Hint = ""
        Me.txbColor.Location = New System.Drawing.Point(482, 299)
        Me.txbColor.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbColor.Name = "txbColor"
        Me.txbColor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbColor.SelectedText = ""
        Me.txbColor.SelectionLength = 0
        Me.txbColor.SelectionStart = 0
        Me.txbColor.Size = New System.Drawing.Size(218, 23)
        Me.txbColor.TabIndex = 35
        Me.txbColor.UseSystemPasswordChar = False
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Depth = 0
        Me.lblModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblModelo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblModelo.Location = New System.Drawing.Point(396, 261)
        Me.lblModelo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(58, 18)
        Me.lblModelo.TabIndex = 34
        Me.lblModelo.Text = "Modelo"
        '
        'txbModelo
        '
        Me.txbModelo.Depth = 0
        Me.txbModelo.Hint = ""
        Me.txbModelo.Location = New System.Drawing.Point(482, 261)
        Me.txbModelo.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbModelo.Name = "txbModelo"
        Me.txbModelo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbModelo.SelectedText = ""
        Me.txbModelo.SelectionLength = 0
        Me.txbModelo.SelectionStart = 0
        Me.txbModelo.Size = New System.Drawing.Size(218, 23)
        Me.txbModelo.TabIndex = 33
        Me.txbModelo.UseSystemPasswordChar = False
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Depth = 0
        Me.lblMarca.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblMarca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMarca.Location = New System.Drawing.Point(29, 303)
        Me.lblMarca.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(51, 19)
        Me.lblMarca.TabIndex = 32
        Me.lblMarca.Text = "Marca"
        '
        'txbMarca
        '
        Me.txbMarca.Depth = 0
        Me.txbMarca.Hint = ""
        Me.txbMarca.Location = New System.Drawing.Point(137, 299)
        Me.txbMarca.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbMarca.Name = "txbMarca"
        Me.txbMarca.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbMarca.SelectedText = ""
        Me.txbMarca.SelectionLength = 0
        Me.txbMarca.SelectionStart = 0
        Me.txbMarca.Size = New System.Drawing.Size(218, 23)
        Me.txbMarca.TabIndex = 31
        Me.txbMarca.UseSystemPasswordChar = False
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Depth = 0
        Me.lblMatricula.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblMatricula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMatricula.Location = New System.Drawing.Point(29, 261)
        Me.lblMatricula.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(72, 19)
        Me.lblMatricula.TabIndex = 30
        Me.lblMatricula.Text = "Matrícula"
        '
        'txbMatricula
        '
        Me.txbMatricula.Depth = 0
        Me.txbMatricula.Hint = ""
        Me.txbMatricula.Location = New System.Drawing.Point(137, 261)
        Me.txbMatricula.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbMatricula.Name = "txbMatricula"
        Me.txbMatricula.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbMatricula.SelectedText = ""
        Me.txbMatricula.SelectionLength = 0
        Me.txbMatricula.SelectionStart = 0
        Me.txbMatricula.Size = New System.Drawing.Size(218, 23)
        Me.txbMatricula.TabIndex = 29
        Me.txbMatricula.UseSystemPasswordChar = False
        '
        'txbBuscar_Coche
        '
        Me.txbBuscar_Coche.Depth = 0
        Me.txbBuscar_Coche.Hint = ""
        Me.txbBuscar_Coche.Location = New System.Drawing.Point(265, 81)
        Me.txbBuscar_Coche.MouseState = MaterialSkin.MouseState.HOVER
        Me.txbBuscar_Coche.Name = "txbBuscar_Coche"
        Me.txbBuscar_Coche.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbBuscar_Coche.SelectedText = ""
        Me.txbBuscar_Coche.SelectionLength = 0
        Me.txbBuscar_Coche.SelectionStart = 0
        Me.txbBuscar_Coche.Size = New System.Drawing.Size(344, 23)
        Me.txbBuscar_Coche.TabIndex = 74
        Me.txbBuscar_Coche.UseSystemPasswordChar = False
        '
        'lblBuscar_Coche
        '
        Me.lblBuscar_Coche.AutoSize = True
        Me.lblBuscar_Coche.Depth = 0
        Me.lblBuscar_Coche.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblBuscar_Coche.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBuscar_Coche.Location = New System.Drawing.Point(129, 81)
        Me.lblBuscar_Coche.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBuscar_Coche.Name = "lblBuscar_Coche"
        Me.lblBuscar_Coche.Size = New System.Drawing.Size(100, 19)
        Me.lblBuscar_Coche.TabIndex = 73
        Me.lblBuscar_Coche.Text = "Buscar coche"
        '
        'dgvBuscar_Coche
        '
        Me.dgvBuscar_Coche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscar_Coche.Location = New System.Drawing.Point(133, 114)
        Me.dgvBuscar_Coche.Name = "dgvBuscar_Coche"
        Me.dgvBuscar_Coche.Size = New System.Drawing.Size(476, 132)
        Me.dgvBuscar_Coche.TabIndex = 72
        '
        'btnRegresar
        '
        Me.btnRegresar.Depth = 0
        Me.btnRegresar.Location = New System.Drawing.Point(590, 548)
        Me.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Primary = True
        Me.btnRegresar.Size = New System.Drawing.Size(115, 32)
        Me.btnRegresar.TabIndex = 75
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'ofdFoto
        '
        Me.ofdFoto.FileName = "Elija un archivo"
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsCerrar_Sesion})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(740, 27)
        Me.mnsMenu.TabIndex = 76
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'mnsCerrar_Sesion
        '
        Me.mnsCerrar_Sesion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mnsCerrar_Sesion.Name = "mnsCerrar_Sesion"
        Me.mnsCerrar_Sesion.Size = New System.Drawing.Size(102, 23)
        Me.mnsCerrar_Sesion.Text = "Cerrar Sesión"
        '
        'frmModificar_Coche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 598)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.txbBuscar_Coche)
        Me.Controls.Add(Me.lblBuscar_Coche)
        Me.Controls.Add(Me.dgvBuscar_Coche)
        Me.Controls.Add(Me.rdbMicrobuses)
        Me.Controls.Add(Me.rdbPickups)
        Me.Controls.Add(Me.rdbSedan)
        Me.Controls.Add(Me.btnModificar_Coche)
        Me.Controls.Add(Me.lblTipo_Coche)
        Me.Controls.Add(Me.btnFoto)
        Me.Controls.Add(Me.lblAgencia_Coche)
        Me.Controls.Add(Me.lblPrecio_Alquiler)
        Me.Controls.Add(Me.txbPrecio_Alquiler)
        Me.Controls.Add(Me.lblNumero_Pasajeros)
        Me.Controls.Add(Me.txbNumero_Pasajeros)
        Me.Controls.Add(Me.lblKilometraje)
        Me.Controls.Add(Me.txbKilometraje)
        Me.Controls.Add(Me.lblFoto)
        Me.Controls.Add(Me.txbAgencia_Coche)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.txbColor)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.txbModelo)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.txbMarca)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.txbMatricula)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmModificar_Coche"
        Me.Text = "Modificar Coche                                                                  " &
    "                                                          Rent-a-Car"
        CType(Me.dgvBuscar_Coche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdbMicrobuses As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdbPickups As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdbSedan As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btnModificar_Coche As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblTipo_Coche As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnFoto As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblAgencia_Coche As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPrecio_Alquiler As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbPrecio_Alquiler As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblNumero_Pasajeros As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbNumero_Pasajeros As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblKilometraje As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbKilometraje As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblFoto As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbAgencia_Coche As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblColor As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbColor As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblModelo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbModelo As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblMarca As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbMarca As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblMatricula As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txbMatricula As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txbBuscar_Coche As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblBuscar_Coche As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvBuscar_Coche As DataGridView
    Friend WithEvents btnRegresar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ofdFoto As OpenFileDialog
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents mnsCerrar_Sesion As ToolStripMenuItem
End Class
