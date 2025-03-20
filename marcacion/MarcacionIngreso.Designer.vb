<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MarcacionIngreso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MarcacionIngreso))
        Me.TxtMensajes = New System.Windows.Forms.TextBox()
        Me.Txtvercedula = New System.Windows.Forms.TextBox()
        Me.TxtverNombre = New System.Windows.Forms.TextBox()
        Me.TxtFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Hora = New System.Windows.Forms.Timer(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TxtHoraIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelFestivo = New System.Windows.Forms.Label()
        Me.LabelDomingo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtpuntos = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtValidarHora = New System.Windows.Forms.DateTimePicker()
        Me.HuellaCorrecta = New System.Windows.Forms.PictureBox()
        Me.HuellaIncorrecta = New System.Windows.Forms.PictureBox()
        Me.HuellaNormal = New System.Windows.Forms.PictureBox()
        Me.TiempoCierre1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtValidarHoraLlegadaTarde = New System.Windows.Forms.DateTimePicker()
        Me.TxtValidarHoraBase = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtValidarTiempoAlmuerzo = New System.Windows.Forms.DateTimePicker()
        Me.TxtValidarTarde = New System.Windows.Forms.DateTimePicker()
        CType(Me.HuellaCorrecta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HuellaIncorrecta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HuellaNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtMensajes
        '
        Me.TxtMensajes.Enabled = False
        Me.TxtMensajes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.TxtMensajes.Location = New System.Drawing.Point(17, 236)
        Me.TxtMensajes.Multiline = True
        Me.TxtMensajes.Name = "TxtMensajes"
        Me.TxtMensajes.Size = New System.Drawing.Size(370, 124)
        Me.TxtMensajes.TabIndex = 0
        '
        'Txtvercedula
        '
        Me.Txtvercedula.Enabled = False
        Me.Txtvercedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtvercedula.Location = New System.Drawing.Point(15, 80)
        Me.Txtvercedula.Name = "Txtvercedula"
        Me.Txtvercedula.Size = New System.Drawing.Size(141, 29)
        Me.Txtvercedula.TabIndex = 17
        '
        'TxtverNombre
        '
        Me.TxtverNombre.Enabled = False
        Me.TxtverNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtverNombre.Location = New System.Drawing.Point(177, 80)
        Me.TxtverNombre.Name = "TxtverNombre"
        Me.TxtverNombre.Size = New System.Drawing.Size(352, 29)
        Me.TxtverNombre.TabIndex = 18
        '
        'TxtFechaIngreso
        '
        Me.TxtFechaIngreso.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaIngreso.Enabled = False
        Me.TxtFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFechaIngreso.Location = New System.Drawing.Point(15, 181)
        Me.TxtFechaIngreso.Name = "TxtFechaIngreso"
        Me.TxtFechaIngreso.Size = New System.Drawing.Size(157, 29)
        Me.TxtFechaIngreso.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Cedula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(174, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nombre"
        '
        'Hora
        '
        Me.Hora.Enabled = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(454, 376)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 29
        Me.BtnSalir.TabStop = False
        Me.BtnSalir.Text = "Cerrar"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'TxtHoraIngreso
        '
        Me.TxtHoraIngreso.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHoraIngreso.CustomFormat = "HH:mm:ss"
        Me.TxtHoraIngreso.Enabled = False
        Me.TxtHoraIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtHoraIngreso.Location = New System.Drawing.Point(230, 181)
        Me.TxtHoraIngreso.Name = "TxtHoraIngreso"
        Me.TxtHoraIngreso.Size = New System.Drawing.Size(155, 29)
        Me.TxtHoraIngreso.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Dia"
        Me.Label3.Visible = False
        '
        'LabelFestivo
        '
        Me.LabelFestivo.AutoSize = True
        Me.LabelFestivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFestivo.ForeColor = System.Drawing.Color.Blue
        Me.LabelFestivo.Location = New System.Drawing.Point(111, 213)
        Me.LabelFestivo.Name = "LabelFestivo"
        Me.LabelFestivo.Size = New System.Drawing.Size(51, 20)
        Me.LabelFestivo.TabIndex = 34
        Me.LabelFestivo.Text = "Nada"
        Me.LabelFestivo.Visible = False
        '
        'LabelDomingo
        '
        Me.LabelDomingo.AutoSize = True
        Me.LabelDomingo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDomingo.ForeColor = System.Drawing.Color.Red
        Me.LabelDomingo.Location = New System.Drawing.Point(53, 213)
        Me.LabelDomingo.Name = "LabelDomingo"
        Me.LabelDomingo.Size = New System.Drawing.Size(51, 20)
        Me.LabelDomingo.TabIndex = 35
        Me.LabelDomingo.Text = "Nada"
        Me.LabelDomingo.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(18, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 18)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "Ubicacion de Marcacion"
        '
        'Txtpuntos
        '
        Me.Txtpuntos.Enabled = False
        Me.Txtpuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpuntos.FormattingEnabled = True
        Me.Txtpuntos.Items.AddRange(New Object() {"HOTEL", "INTER BOGOTA", "INTER OVIEDO 1", "INTER OVIEDO 4", "INTER SANTAFE", "INTER TESORO", "LESENTIER OVIEDO", "LESENTIER TESORO", "MENSAJERO", "NEWCHATEL", "OFICINA", "TAG", "TALLER", "TECNICO"})
        Me.Txtpuntos.Location = New System.Drawing.Point(230, 129)
        Me.Txtpuntos.Name = "Txtpuntos"
        Me.Txtpuntos.Size = New System.Drawing.Size(299, 32)
        Me.Txtpuntos.TabIndex = 127
        Me.Txtpuntos.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 16)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Hora Validacion oculta arriba"
        Me.Label7.Visible = False
        '
        'TxtValidarHora
        '
        Me.TxtValidarHora.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValidarHora.CustomFormat = "HH:mm:ss"
        Me.TxtValidarHora.Enabled = False
        Me.TxtValidarHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValidarHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtValidarHora.Location = New System.Drawing.Point(17, 253)
        Me.TxtValidarHora.Name = "TxtValidarHora"
        Me.TxtValidarHora.Size = New System.Drawing.Size(155, 29)
        Me.TxtValidarHora.TabIndex = 136
        '
        'HuellaCorrecta
        '
        Me.HuellaCorrecta.Image = Global.WindowsApplication1.My.Resources.Resources.huella_correcta1
        Me.HuellaCorrecta.Location = New System.Drawing.Point(406, 187)
        Me.HuellaCorrecta.Name = "HuellaCorrecta"
        Me.HuellaCorrecta.Size = New System.Drawing.Size(123, 169)
        Me.HuellaCorrecta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HuellaCorrecta.TabIndex = 133
        Me.HuellaCorrecta.TabStop = False
        Me.HuellaCorrecta.Visible = False
        '
        'HuellaIncorrecta
        '
        Me.HuellaIncorrecta.Image = Global.WindowsApplication1.My.Resources.Resources.huella_incorrecta
        Me.HuellaIncorrecta.Location = New System.Drawing.Point(406, 187)
        Me.HuellaIncorrecta.Name = "HuellaIncorrecta"
        Me.HuellaIncorrecta.Size = New System.Drawing.Size(123, 169)
        Me.HuellaIncorrecta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HuellaIncorrecta.TabIndex = 132
        Me.HuellaIncorrecta.TabStop = False
        Me.HuellaIncorrecta.Visible = False
        '
        'HuellaNormal
        '
        Me.HuellaNormal.Image = CType(resources.GetObject("HuellaNormal.Image"), System.Drawing.Image)
        Me.HuellaNormal.Location = New System.Drawing.Point(406, 187)
        Me.HuellaNormal.Name = "HuellaNormal"
        Me.HuellaNormal.Size = New System.Drawing.Size(123, 169)
        Me.HuellaNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HuellaNormal.TabIndex = 131
        Me.HuellaNormal.TabStop = False
        '
        'TiempoCierre1
        '
        Me.TiempoCierre1.Enabled = True
        Me.TiempoCierre1.Interval = 60000
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(35, 382)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(358, 16)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "El módulo se cierra automáticamente en 1 minuto!!!"
        '
        'TxtValidarHoraLlegadaTarde
        '
        Me.TxtValidarHoraLlegadaTarde.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValidarHoraLlegadaTarde.CustomFormat = "HH:mm:ss"
        Me.TxtValidarHoraLlegadaTarde.Enabled = False
        Me.TxtValidarHoraLlegadaTarde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValidarHoraLlegadaTarde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtValidarHoraLlegadaTarde.Location = New System.Drawing.Point(17, 323)
        Me.TxtValidarHoraLlegadaTarde.Name = "TxtValidarHoraLlegadaTarde"
        Me.TxtValidarHoraLlegadaTarde.Size = New System.Drawing.Size(155, 29)
        Me.TxtValidarHoraLlegadaTarde.TabIndex = 138
        '
        'TxtValidarHoraBase
        '
        Me.TxtValidarHoraBase.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValidarHoraBase.CustomFormat = "HH:mm:ss"
        Me.TxtValidarHoraBase.Enabled = False
        Me.TxtValidarHoraBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValidarHoraBase.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtValidarHoraBase.Location = New System.Drawing.Point(17, 288)
        Me.TxtValidarHoraBase.Name = "TxtValidarHoraBase"
        Me.TxtValidarHoraBase.Size = New System.Drawing.Size(155, 29)
        Me.TxtValidarHoraBase.TabIndex = 139
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(78, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(383, 32)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "Marcación de Ingreso Inicial"
        '
        'TxtValidarTiempoAlmuerzo
        '
        Me.TxtValidarTiempoAlmuerzo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValidarTiempoAlmuerzo.CustomFormat = "HH:mm:ss"
        Me.TxtValidarTiempoAlmuerzo.Enabled = False
        Me.TxtValidarTiempoAlmuerzo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValidarTiempoAlmuerzo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtValidarTiempoAlmuerzo.Location = New System.Drawing.Point(194, 253)
        Me.TxtValidarTiempoAlmuerzo.Name = "TxtValidarTiempoAlmuerzo"
        Me.TxtValidarTiempoAlmuerzo.Size = New System.Drawing.Size(155, 29)
        Me.TxtValidarTiempoAlmuerzo.TabIndex = 141
        '
        'TxtValidarTarde
        '
        Me.TxtValidarTarde.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValidarTarde.CustomFormat = "HH:mm:ss"
        Me.TxtValidarTarde.Enabled = False
        Me.TxtValidarTarde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValidarTarde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtValidarTarde.Location = New System.Drawing.Point(194, 288)
        Me.TxtValidarTarde.Name = "TxtValidarTarde"
        Me.TxtValidarTarde.Size = New System.Drawing.Size(155, 29)
        Me.TxtValidarTarde.TabIndex = 142
        '
        'MarcacionIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(544, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtMensajes)
        Me.Controls.Add(Me.TxtValidarTiempoAlmuerzo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtValidarHoraBase)
        Me.Controls.Add(Me.TxtValidarHoraLlegadaTarde)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtValidarHora)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.HuellaCorrecta)
        Me.Controls.Add(Me.HuellaIncorrecta)
        Me.Controls.Add(Me.HuellaNormal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txtpuntos)
        Me.Controls.Add(Me.LabelFestivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtHoraIngreso)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFechaIngreso)
        Me.Controls.Add(Me.TxtverNombre)
        Me.Controls.Add(Me.Txtvercedula)
        Me.Controls.Add(Me.LabelDomingo)
        Me.Controls.Add(Me.TxtValidarTarde)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MarcacionIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcacion Ingreso"
        CType(Me.HuellaCorrecta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HuellaIncorrecta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HuellaNormal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtMensajes As System.Windows.Forms.TextBox
    Friend WithEvents Txtvercedula As System.Windows.Forms.TextBox
    Friend WithEvents TxtverNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Hora As System.Windows.Forms.Timer
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents TxtHoraIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelFestivo As System.Windows.Forms.Label
    Friend WithEvents LabelDomingo As System.Windows.Forms.Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtpuntos As ComboBox
    Friend WithEvents HuellaCorrecta As PictureBox
    Friend WithEvents HuellaIncorrecta As PictureBox
    Friend WithEvents HuellaNormal As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtValidarHora As DateTimePicker
    Friend WithEvents TiempoCierre1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtValidarHoraLlegadaTarde As DateTimePicker
    Friend WithEvents TxtValidarHoraBase As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtValidarTiempoAlmuerzo As DateTimePicker
    Friend WithEvents TxtValidarTarde As DateTimePicker
End Class
