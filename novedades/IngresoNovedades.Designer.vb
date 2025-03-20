<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IngresoNovedades
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresoNovedades))
        Me.TxtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNovedad = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtComprobar = New System.Windows.Forms.TextBox()
        Me.TxtNombres = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtcedula = New System.Windows.Forms.TextBox()
        Me.TxtUbicacion = New System.Windows.Forms.ComboBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TxtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.TxtValidarHoraBase = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtComentario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtFechaInicio
        '
        Me.TxtFechaInicio.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFechaInicio.Location = New System.Drawing.Point(33, 278)
        Me.TxtFechaInicio.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TxtFechaInicio.Name = "TxtFechaInicio"
        Me.TxtFechaInicio.Size = New System.Drawing.Size(204, 26)
        Me.TxtFechaInicio.TabIndex = 1
        Me.TxtFechaInicio.Value = New Date(2022, 2, 25, 10, 29, 44, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(33, 158)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 18)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Ubicacion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(90, 255)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 18)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Inicio"
        '
        'TxtNovedad
        '
        Me.TxtNovedad.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.TxtNovedad.FormattingEnabled = True
        Me.TxtNovedad.Location = New System.Drawing.Point(33, 367)
        Me.TxtNovedad.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TxtNovedad.Name = "TxtNovedad"
        Me.TxtNovedad.Size = New System.Drawing.Size(491, 26)
        Me.TxtNovedad.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(33, 341)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Novedad"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(141, 605)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(257, 65)
        Me.BtnActualizar.TabIndex = 4
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'TxtComprobar
        '
        Me.TxtComprobar.Location = New System.Drawing.Point(305, 115)
        Me.TxtComprobar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TxtComprobar.Name = "TxtComprobar"
        Me.TxtComprobar.Size = New System.Drawing.Size(219, 26)
        Me.TxtComprobar.TabIndex = 76
        Me.TxtComprobar.Visible = False
        '
        'TxtNombres
        '
        Me.TxtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombres.FormattingEnabled = True
        Me.TxtNombres.Location = New System.Drawing.Point(33, 39)
        Me.TxtNombres.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(491, 24)
        Me.TxtNombres.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(33, 14)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 18)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(33, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Cedula"
        '
        'Txtcedula
        '
        Me.Txtcedula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Txtcedula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.Txtcedula.Enabled = False
        Me.Txtcedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcedula.Location = New System.Drawing.Point(33, 112)
        Me.Txtcedula.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Txtcedula.Name = "Txtcedula"
        Me.Txtcedula.Size = New System.Drawing.Size(232, 22)
        Me.Txtcedula.TabIndex = 78
        '
        'TxtUbicacion
        '
        Me.TxtUbicacion.Enabled = False
        Me.TxtUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUbicacion.FormattingEnabled = True
        Me.TxtUbicacion.Location = New System.Drawing.Point(33, 181)
        Me.TxtUbicacion.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TxtUbicacion.Name = "TxtUbicacion"
        Me.TxtUbicacion.Size = New System.Drawing.Size(491, 24)
        Me.TxtUbicacion.TabIndex = 135
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(432, 759)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(125, 32)
        Me.BtnSalir.TabIndex = 136
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'TxtFechaFin
        '
        Me.TxtFechaFin.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFechaFin.Location = New System.Drawing.Point(305, 278)
        Me.TxtFechaFin.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TxtFechaFin.Name = "TxtFechaFin"
        Me.TxtFechaFin.Size = New System.Drawing.Size(219, 26)
        Me.TxtFechaFin.TabIndex = 137
        Me.TxtFechaFin.Value = New Date(2022, 2, 25, 10, 27, 22, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(240, 223)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Fechas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(397, 255)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 18)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Fin"
        '
        'TxtFechaIngreso
        '
        Me.TxtFechaIngreso.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFechaIngreso.Location = New System.Drawing.Point(141, 765)
        Me.TxtFechaIngreso.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TxtFechaIngreso.Name = "TxtFechaIngreso"
        Me.TxtFechaIngreso.Size = New System.Drawing.Size(232, 26)
        Me.TxtFechaIngreso.TabIndex = 140
        Me.TxtFechaIngreso.Visible = False
        '
        'TxtValidarHoraBase
        '
        Me.TxtValidarHoraBase.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValidarHoraBase.CustomFormat = "HH:mm:ss"
        Me.TxtValidarHoraBase.Enabled = False
        Me.TxtValidarHoraBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValidarHoraBase.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtValidarHoraBase.Location = New System.Drawing.Point(197, 628)
        Me.TxtValidarHoraBase.Name = "TxtValidarHoraBase"
        Me.TxtValidarHoraBase.Size = New System.Drawing.Size(155, 29)
        Me.TxtValidarHoraBase.TabIndex = 146
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(90, 708)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(382, 36)
        Me.Label11.TabIndex = 163
        Me.Label11.Text = "Nota: El ingreso de la novedad es de todo el dia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           NO de un tiempo parc" &
    "ial."
        '
        'TxtComentario
        '
        Me.TxtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtComentario.Location = New System.Drawing.Point(33, 439)
        Me.TxtComentario.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TxtComentario.Multiline = True
        Me.TxtComentario.Name = "TxtComentario"
        Me.TxtComentario.Size = New System.Drawing.Size(491, 115)
        Me.TxtComentario.TabIndex = 164
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(33, 417)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 18)
        Me.Label8.TabIndex = 165
        Me.Label8.Text = "Comentario"
        '
        'IngresoNovedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(571, 804)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtComentario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtFechaIngreso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtFechaFin)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.TxtUbicacion)
        Me.Controls.Add(Me.TxtNombres)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtcedula)
        Me.Controls.Add(Me.TxtComprobar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNovedad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtFechaInicio)
        Me.Controls.Add(Me.TxtValidarHoraBase)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IngresoNovedades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Novedades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNovedad As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents TxtComprobar As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombres As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtcedula As System.Windows.Forms.TextBox
    Friend WithEvents TxtUbicacion As ComboBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtFechaFin As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtFechaIngreso As DateTimePicker
    Friend WithEvents TxtValidarHoraBase As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtComentario As TextBox
    Friend WithEvents Label8 As Label
End Class
