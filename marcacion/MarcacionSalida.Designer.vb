<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MarcacionSalida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MarcacionSalida))
        Me.TxtMensajes = New System.Windows.Forms.TextBox()
        Me.Txtvercedula = New System.Windows.Forms.TextBox()
        Me.TxtverNombre = New System.Windows.Forms.TextBox()
        Me.TxtFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Hora = New System.Windows.Forms.Timer(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TxtHoraRegistroSalida = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelFestivo = New System.Windows.Forms.Label()
        Me.LabelDomingo = New System.Windows.Forms.Label()
        Me.TxtComprobar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtClaveConexion = New System.Windows.Forms.TextBox()
        Me.HuellaNormal = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtpuntos = New System.Windows.Forms.ComboBox()
        Me.HuellaIncorrecta = New System.Windows.Forms.PictureBox()
        Me.HuellaCorrecta = New System.Windows.Forms.PictureBox()
        Me.TxtValidarSalida = New System.Windows.Forms.TextBox()
        Me.HoraIngreso = New System.Windows.Forms.DateTimePicker()
        Me.HoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TiempoCierre2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimeHoraBase = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.HuellaNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HuellaIncorrecta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HuellaCorrecta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtMensajes
        '
        Me.TxtMensajes.Enabled = False
        Me.TxtMensajes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.TxtMensajes.Location = New System.Drawing.Point(15, 227)
        Me.TxtMensajes.Multiline = True
        Me.TxtMensajes.Name = "TxtMensajes"
        Me.TxtMensajes.Size = New System.Drawing.Size(370, 124)
        Me.TxtMensajes.TabIndex = 0
        '
        'Txtvercedula
        '
        Me.Txtvercedula.Enabled = False
        Me.Txtvercedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtvercedula.Location = New System.Drawing.Point(15, 72)
        Me.Txtvercedula.Name = "Txtvercedula"
        Me.Txtvercedula.Size = New System.Drawing.Size(141, 29)
        Me.Txtvercedula.TabIndex = 17
        '
        'TxtverNombre
        '
        Me.TxtverNombre.Enabled = False
        Me.TxtverNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtverNombre.Location = New System.Drawing.Point(177, 72)
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
        Me.TxtFechaIngreso.Location = New System.Drawing.Point(15, 173)
        Me.TxtFechaIngreso.Name = "TxtFechaIngreso"
        Me.TxtFechaIngreso.Size = New System.Drawing.Size(157, 29)
        Me.TxtFechaIngreso.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Cedula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(174, 53)
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
        Me.BtnSalir.Location = New System.Drawing.Point(454, 368)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 29
        Me.BtnSalir.Text = "Cerrar"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'TxtHoraRegistroSalida
        '
        Me.TxtHoraRegistroSalida.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHoraRegistroSalida.CustomFormat = "HH:mm:ss"
        Me.TxtHoraRegistroSalida.Enabled = False
        Me.TxtHoraRegistroSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHoraRegistroSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtHoraRegistroSalida.Location = New System.Drawing.Point(230, 173)
        Me.TxtHoraRegistroSalida.Name = "TxtHoraRegistroSalida"
        Me.TxtHoraRegistroSalida.Size = New System.Drawing.Size(155, 29)
        Me.TxtHoraRegistroSalida.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 205)
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
        Me.LabelFestivo.Location = New System.Drawing.Point(120, 205)
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
        Me.LabelDomingo.Location = New System.Drawing.Point(62, 205)
        Me.LabelDomingo.Name = "LabelDomingo"
        Me.LabelDomingo.Size = New System.Drawing.Size(51, 20)
        Me.LabelDomingo.TabIndex = 35
        Me.LabelDomingo.Text = "Nada"
        Me.LabelDomingo.Visible = False
        '
        'TxtComprobar
        '
        Me.TxtComprobar.Location = New System.Drawing.Point(177, 207)
        Me.TxtComprobar.Name = "TxtComprobar"
        Me.TxtComprobar.Size = New System.Drawing.Size(90, 20)
        Me.TxtComprobar.TabIndex = 40
        Me.TxtComprobar.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 355)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 125
        Me.Label8.Text = "Conexion"
        Me.Label8.Visible = False
        '
        'TxtClaveConexion
        '
        Me.TxtClaveConexion.Location = New System.Drawing.Point(91, 365)
        Me.TxtClaveConexion.Name = "TxtClaveConexion"
        Me.TxtClaveConexion.Size = New System.Drawing.Size(100, 20)
        Me.TxtClaveConexion.TabIndex = 124
        Me.TxtClaveConexion.Visible = False
        '
        'HuellaNormal
        '
        Me.HuellaNormal.Image = CType(resources.GetObject("HuellaNormal.Image"), System.Drawing.Image)
        Me.HuellaNormal.Location = New System.Drawing.Point(406, 179)
        Me.HuellaNormal.Name = "HuellaNormal"
        Me.HuellaNormal.Size = New System.Drawing.Size(123, 169)
        Me.HuellaNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HuellaNormal.TabIndex = 126
        Me.HuellaNormal.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(18, 130)
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
        Me.Txtpuntos.Location = New System.Drawing.Point(230, 121)
        Me.Txtpuntos.Name = "Txtpuntos"
        Me.Txtpuntos.Size = New System.Drawing.Size(299, 32)
        Me.Txtpuntos.TabIndex = 127
        Me.Txtpuntos.TabStop = False
        '
        'HuellaIncorrecta
        '
        Me.HuellaIncorrecta.Image = Global.WindowsApplication1.My.Resources.Resources.huella_incorrecta
        Me.HuellaIncorrecta.Location = New System.Drawing.Point(406, 179)
        Me.HuellaIncorrecta.Name = "HuellaIncorrecta"
        Me.HuellaIncorrecta.Size = New System.Drawing.Size(123, 169)
        Me.HuellaIncorrecta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HuellaIncorrecta.TabIndex = 129
        Me.HuellaIncorrecta.TabStop = False
        Me.HuellaIncorrecta.Visible = False
        '
        'HuellaCorrecta
        '
        Me.HuellaCorrecta.Image = Global.WindowsApplication1.My.Resources.Resources.huella_correcta1
        Me.HuellaCorrecta.Location = New System.Drawing.Point(406, 179)
        Me.HuellaCorrecta.Name = "HuellaCorrecta"
        Me.HuellaCorrecta.Size = New System.Drawing.Size(123, 169)
        Me.HuellaCorrecta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HuellaCorrecta.TabIndex = 130
        Me.HuellaCorrecta.TabStop = False
        Me.HuellaCorrecta.Visible = False
        '
        'TxtValidarSalida
        '
        Me.TxtValidarSalida.Location = New System.Drawing.Point(279, 207)
        Me.TxtValidarSalida.Name = "TxtValidarSalida"
        Me.TxtValidarSalida.Size = New System.Drawing.Size(96, 20)
        Me.TxtValidarSalida.TabIndex = 131
        Me.TxtValidarSalida.Visible = False
        '
        'HoraIngreso
        '
        Me.HoraIngreso.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraIngreso.CustomFormat = "HH:mm:ss"
        Me.HoraIngreso.Enabled = False
        Me.HoraIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.HoraIngreso.Location = New System.Drawing.Point(78, 257)
        Me.HoraIngreso.Name = "HoraIngreso"
        Me.HoraIngreso.Size = New System.Drawing.Size(113, 29)
        Me.HoraIngreso.TabIndex = 132
        '
        'HoraSalida
        '
        Me.HoraSalida.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraSalida.CustomFormat = "HH:mm:ss"
        Me.HoraSalida.Enabled = False
        Me.HoraSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.HoraSalida.Location = New System.Drawing.Point(252, 257)
        Me.HoraSalida.Name = "HoraSalida"
        Me.HoraSalida.Size = New System.Drawing.Size(113, 29)
        Me.HoraSalida.TabIndex = 133
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Entrada"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(199, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 16)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "Salida"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(48, 371)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(358, 16)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "El módulo se cierra automáticamente en 1 minuto!!!"
        '
        'TiempoCierre2
        '
        Me.TiempoCierre2.Enabled = True
        Me.TiempoCierre2.Interval = 60000
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(126, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(280, 32)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "Marcación de Salida"
        '
        'DateTimeHoraBase
        '
        Me.DateTimeHoraBase.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeHoraBase.CustomFormat = "HH:mm:ss"
        Me.DateTimeHoraBase.Enabled = False
        Me.DateTimeHoraBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeHoraBase.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeHoraBase.Location = New System.Drawing.Point(89, 297)
        Me.DateTimeHoraBase.Name = "DateTimeHoraBase"
        Me.DateTimeHoraBase.Size = New System.Drawing.Size(113, 29)
        Me.DateTimeHoraBase.TabIndex = 142
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Hora Base"
        '
        'MarcacionSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(541, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtMensajes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimeHoraBase)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.HoraSalida)
        Me.Controls.Add(Me.HoraIngreso)
        Me.Controls.Add(Me.TxtValidarSalida)
        Me.Controls.Add(Me.HuellaCorrecta)
        Me.Controls.Add(Me.HuellaIncorrecta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txtpuntos)
        Me.Controls.Add(Me.HuellaNormal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtClaveConexion)
        Me.Controls.Add(Me.TxtComprobar)
        Me.Controls.Add(Me.LabelFestivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtHoraRegistroSalida)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFechaIngreso)
        Me.Controls.Add(Me.TxtverNombre)
        Me.Controls.Add(Me.Txtvercedula)
        Me.Controls.Add(Me.LabelDomingo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MarcacionSalida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcacion Salida"
        CType(Me.HuellaNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HuellaIncorrecta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HuellaCorrecta, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TxtHoraRegistroSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelFestivo As System.Windows.Forms.Label
    Friend WithEvents LabelDomingo As System.Windows.Forms.Label
    Friend WithEvents TxtComprobar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtClaveConexion As System.Windows.Forms.TextBox
    Friend WithEvents HuellaNormal As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtpuntos As ComboBox
    Friend WithEvents HuellaIncorrecta As PictureBox
    Friend WithEvents HuellaCorrecta As PictureBox
    Friend WithEvents TxtValidarSalida As TextBox
    Friend WithEvents HoraIngreso As DateTimePicker
    Friend WithEvents HoraSalida As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TiempoCierre2 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimeHoraBase As DateTimePicker
    Friend WithEvents Label4 As Label
End Class
