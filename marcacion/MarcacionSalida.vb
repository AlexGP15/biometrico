Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlServerCe

Public Class MarcacionSalida
    Dim myDB As MySqlConnection
    Dim MYADAPTER As MySqlDataReader
    Dim MOSTRAR As String
    Dim MOSTRAR2 As String
    Dim WithEvents FpVer As FlexCodeSDK.FinFPVer
    Dim EmpID As String
    Dim FpIndex As Byte

    Private Sub MarcacionSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Crear instancia conexion
            Using myDB = New MySqlConnection

                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If


                ''Funcion para Verificar dia
                ValidarDia()

                If myDB.State = ConnectionState.Open Then

                    Dim sqlCommand As New MySqlCommand
                    sqlCommand.Connection = myDB

                    FpVer = New FlexCodeSDK.FinFPVer
                    FpVer.AddDeviceInfo("C700F001339", "1SX-J98-067-81L-40X", "VLT1-FF2F-6C40-5A20-4058-62GV")

                    sqlCommand.Connection = myDB
                    sqlCommand.CommandText = "SELECT Cedula, Nombre, Dedo, RegistroHuella FROM Registro"
                    Dim rd As MySqlDataReader
                    rd = sqlCommand.ExecuteReader

                    While rd.Read
                        FpVer.FPLoad(rd.GetString(0), rd.GetString(2), rd.GetString(3), "YourSecretKey" & rd.GetString(0))
                    End While

                    FpVer.FPVerificationStart()

                    rd.Close()
                    TiempoCierre2.Start()
                    Hora.Start()
                    myDB.Close()

                End If

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Public Function ValidarDia()

        Try
            'Crear instancia conexion
            Using myDB = New MySqlConnection

                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase
                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                Dim ConsultaFecha As String
                'Extraemos el año, mes y dia de los DateTimePicker
                ConsultaFecha = TxtFechaIngreso.Value.Year & "," & TxtFechaIngreso.Value.Month & "," & TxtFechaIngreso.Value.Day

                Dim sqlCommand As New MySqlCommand
                sqlCommand.Connection = myDB

                sqlCommand.CommandText = "SELECT Nombre FROM Festivos where Fecha = '" & ConsultaFecha & "';"
                sqlCommand.ExecuteNonQuery()
                MOSTRAR = sqlCommand.ExecuteScalar
                Me.LabelFestivo.Text = MOSTRAR


                sqlCommand.CommandText = "SELECT Nombre FROM Domingos where Fecha = '" & ConsultaFecha & "';"
                sqlCommand.ExecuteNonQuery()
                MOSTRAR = sqlCommand.ExecuteScalar
                Me.LabelDomingo.Text = MOSTRAR

                myDB.Close()

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

        Return True

    End Function

    Public Function ComprobarIngreso()
        Try

            'Crear instancia conexion
            Using myDB = New MySqlConnection

                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase
                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                Dim ConsultaFecha As String
                'Extraemos el año, mes y dia de los DateTimePicker
                ConsultaFecha = TxtFechaIngreso.Value.Year & "," & TxtFechaIngreso.Value.Month & "," & TxtFechaIngreso.Value.Day

                Dim sqlCommand As New MySqlCommand
                sqlCommand.Connection = myDB
                sqlCommand.CommandText = "SELECT Nombre FROM IngresosHoras where Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                sqlCommand.ExecuteNonQuery()
                MOSTRAR = sqlCommand.ExecuteScalar
                Me.TxtComprobar.Text = MOSTRAR

                myDB.Close()


            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

        Return True

    End Function

    Public Function ComprobarSalida()

        Try
            'Crear instancia conexion
            Using myDB = New MySqlConnection

                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                Dim ConsultaFecha As String
                'Extraemos el año, mes y dia de los DateTimePicker
                ConsultaFecha = TxtFechaIngreso.Value.Year & "," & TxtFechaIngreso.Value.Month & "," & TxtFechaIngreso.Value.Day

                Dim sqlCommand As New MySqlCommand
                sqlCommand.Connection = myDB
                sqlCommand.CommandText = "SELECT Nombre FROM IngresosHoras where Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "' and HoraSalida=0;"
                sqlCommand.ExecuteNonQuery()
                MOSTRAR = sqlCommand.ExecuteScalar
                Me.TxtValidarSalida.Text = MOSTRAR

                myDB.Close()


            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

        Return True

    End Function

    Public Function ComprobarHorario()

        Try
            'Crear instancia conexion
            Using myDB = New MySqlConnection

                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                Dim ConsultaFecha As String
                'Extraemos el año, mes y dia de los DateTimePicker
                ConsultaFecha = TxtFechaIngreso.Value.Year & "," & TxtFechaIngreso.Value.Month & "," & TxtFechaIngreso.Value.Day

                Dim sqlCommand As New MySqlCommand
                sqlCommand.Connection = myDB
                sqlCommand.CommandText = "SELECT IngresosHoras FROM HoraIngreso where Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                sqlCommand.ExecuteNonQuery()
                MOSTRAR = sqlCommand.ExecuteScalar
                Me.HoraIngreso.Text = MOSTRAR

                Dim sqlCommand2 As New MySqlCommand
                sqlCommand2.Connection = myDB
                sqlCommand2.CommandText = "SELECT IngresosHoras FROM HoraSalida where Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                sqlCommand2.ExecuteNonQuery()
                MOSTRAR2 = sqlCommand2.ExecuteScalar
                Me.HoraSalida.Text = MOSTRAR2

                myDB.Close()


            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

        Return True

    End Function

    Public Function operacionesTiempo()

        Try
            'Crear instancia conexion
            Using myDB = New MySqlConnection

                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                Dim strSQL2 As String
                Dim da2 As New MySqlDataAdapter
                Dim ds2 As New DataSet
                Dim cmd2 As New MySqlCommand

                Dim ConsultaFecha As String
                'Extraemos el año, mes y dia de los DateTimePicker
                ConsultaFecha = TxtFechaIngreso.Value.Year & "," & TxtFechaIngreso.Value.Month & "," & TxtFechaIngreso.Value.Day


                strSQL2 = "SELECT HoraIngreso,HoraSalida,TiempoAlmuerzo FROM IngresosHoras where Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"

                cmd2 = New MySqlCommand()
                cmd2.CommandText = strSQL2
                cmd2.CommandType = CommandType.Text
                cmd2.Connection = myDB

                Dim reader As MySqlDataReader = cmd2.ExecuteReader()

                While reader.Read()
                    ' Obtener las horas de inicio y fin desde MySQL
                    Dim horaInicio As TimeSpan = reader.GetTimeSpan("HoraIngreso")
                    Dim horaFin As TimeSpan = reader.GetTimeSpan("HoraSalida")
                    Dim tiempoAlmuerzo As TimeSpan = reader.GetTimeSpan("TiempoAlmuerzo")

                    ' Realizar la resta de horas
                    Dim tiempoTrabajado As TimeSpan = horaFin - horaInicio - tiempoAlmuerzo

                    ' Mostrar el resultado en un TextBox (por ejemplo)
                    DateTimeHoraBase.Text = tiempoTrabajado.ToString()
                End While

                If Not reader.IsClosed Then
                    reader.Close()
                End If

                myDB.Close()

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

        Return True

    End Function

    Private Sub FpVer_FPVerificationID(ByVal ID As String, ByVal FingerNr As FlexCodeSDK.FingerNumber) Handles FpVer.FPVerificationID
        Try
            EmpID = ID
            FpIndex = FingerNr
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                          MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub FpVer_FPVerificationStatus(ByVal Status As FlexCodeSDK.VerificationStatus) Handles FpVer.FPVerificationStatus

        Try

            'Crear instancia conexion
            Using myDB = New MySqlConnection


                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                If Status = FlexCodeSDK.VerificationStatus.v_OK Then

                    '**** comandos para Salir****


                    Dim ConsultaFecha As String
                    'Extraemos el año, mes y dia de los DateTimePicker
                    ConsultaFecha = TxtFechaIngreso.Value.Year & "," & TxtFechaIngreso.Value.Month & "," & TxtFechaIngreso.Value.Day


                    Dim sqlCommand2 As New MySqlCommand
                    sqlCommand2 = New MySqlCommand()
                    sqlCommand2.Connection = myDB
                    sqlCommand2.CommandText = "SELECT Nombre,Ubicacion FROM Registro WHERE Cedula = '" & EmpID & "'"
                    Dim rd2 As MySqlDataReader
                    rd2 = sqlCommand2.ExecuteReader
                    rd2.Read()


                    TxtMensajes.Text = TxtMensajes.Text & vbNewLine & "Cedula: " & EmpID & ", Nombre : " & rd2.GetString(0) & ",** 0=Indice Derecho y 1=Indice Izquierdo ** Dedo Registrado: " & Str(FpIndex)
                    Txtvercedula.Text = EmpID
                    TxtverNombre.Text = rd2.GetString(0)
                    Txtpuntos.Text = rd2.GetString(1)
                    HuellaCorrecta.Visible = True
                    HuellaIncorrecta.Visible = False
                    HuellaNormal.Visible = False


                    EmpID = ""

                    rd2.Close()


                    ''Funcion para Verificar Ingreso
                    ComprobarIngreso()

                    ''Funcion para Verificar si ya existe Salida
                    ComprobarSalida()


                    Dim sqlCommand As New MySqlCommand
                    sqlCommand.Connection = myDB


                    If TxtComprobar.Text = "" Then
                        Txtvercedula.Text = ""
                        TxtverNombre.Text = ""
                        Txtpuntos.Text = ""
                        TxtMensajes.Text = ""
                        HuellaCorrecta.Visible = True
                        HuellaIncorrecta.Visible = False

                        MessageBox.Show("Aun no se ha realizado la marcaciòn de ingreso de este día !!!", "Informacion", MessageBoxButtons.OK,
                              MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

                        TxtComprobar.Text = ""
                        TxtValidarSalida.Text = ""
                        HuellaCorrecta.Visible = False
                        HuellaNormal.Visible = True
                    Else

                        If TxtValidarSalida.Text = "" Then
                            Txtvercedula.Text = ""
                            TxtverNombre.Text = ""
                            Txtpuntos.Text = ""
                            TxtMensajes.Text = ""
                            HuellaCorrecta.Visible = True
                            HuellaIncorrecta.Visible = False

                            MessageBox.Show("Ya realizo el registro de Salida de este día!!!", "Informacion", MessageBoxButtons.OK,
                               MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                            TxtComprobar.Text = ""
                            TxtValidarSalida.Text = ""
                            HuellaCorrecta.Visible = False
                            HuellaNormal.Visible = True

                        Else

                            sqlCommand.CommandText = "UPDATE IngresosHoras SET HoraSalida = '" & TxtHoraRegistroSalida.Text & "' WHERE Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                            sqlCommand.ExecuteNonQuery()

                            TxtComprobar.Text = ""
                            TxtValidarSalida.Text = ""


                            ''********************consultar la diferencia de horas y actualizar el campo Hora Extra y Festiva******************

                            Dim strSQL2 As String
                            Dim da2 As New MySqlDataAdapter
                            Dim ds2 As New DataSet
                            Dim cmd2 As New MySqlCommand

                            strSQL2 = "SELECT HoraIngreso,HoraSalida FROM IngresosHoras where Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"

                            cmd2 = New MySqlCommand()
                            cmd2.CommandText = strSQL2
                            cmd2.CommandType = CommandType.Text
                            cmd2.Connection = myDB


                            Dim readerTiempo As MySqlDataReader = cmd2.ExecuteReader()

                            While readerTiempo.Read()
                                ' Obtener las horas de inicio y fin desde MySQL
                                Dim horaInicio As TimeSpan = readerTiempo.GetTimeSpan("HoraIngreso")
                                Dim horaFin As TimeSpan = readerTiempo.GetTimeSpan("HoraSalida")


                                ' Realizar la resta de horas
                                Dim tiempoTrabajado As TimeSpan = horaFin - horaInicio

                                ' Definir la medida de tiempo deseada (en horas, por ejemplo)
                                Dim medidaTiempoDeseada As Double = 1 ' puedes ajustar esto según tus necesidades

                                ' Comparar el tiempo trabajado con la medida deseada
                                If tiempoTrabajado.TotalHours >= medidaTiempoDeseada Then

                                    ' Si el lector de datos no está cerrado, entonces ciérralo
                                    If Not readerTiempo.IsClosed Then
                                        readerTiempo.Close()
                                    End If

                                    ' Salir del bucle después de cerrar el lector


                                    If LabelDomingo.Text = "Domingo" Then

                                        operacionesTiempo()

                                        Dim sqlCommand3 As New MySqlCommand
                                        sqlCommand3.Connection = myDB
                                        sqlCommand3.CommandText = "UPDATE TotalHoras SET Horas = '" & DateTimeHoraBase.Text & "' where Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                                        sqlCommand3.ExecuteNonQuery()

                                        ''-------------Fechas y Hora domingos y festivos --------------

                                        Dim sqlCommand4 As New MySqlCommand
                                        sqlCommand4.Connection = myDB
                                        sqlCommand4.CommandText = "UPDATE TotalHoras SET HorasFestivas = '" & DateTimeHoraBase.Text & "' where Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                                        sqlCommand4.ExecuteNonQuery()

                                        Dim sqlCommand7 As New MySqlCommand
                                        sqlCommand7.Connection = myDB
                                        sqlCommand7.CommandText = "UPDATE TotalHoras SET InicioFestiva = '" & HoraIngreso.Text & "' WHERE Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                                        sqlCommand7.ExecuteNonQuery()

                                        Dim sqlCommand8 As New MySqlCommand
                                        sqlCommand8.Connection = myDB
                                        sqlCommand8.CommandText = "UPDATE TotalHoras SET FinFestiva = '" & HoraSalida.Text & "' WHERE Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                                        sqlCommand8.ExecuteNonQuery()


                                    ElseIf LabelFestivo.Text = "Festivo" Then

                                        operacionesTiempo()

                                        Dim sqlCommand3 As New MySqlCommand
                                        sqlCommand3.Connection = myDB
                                        sqlCommand3.CommandText = "UPDATE TotalHoras SET Horas = '" & DateTimeHoraBase.Text & "' where Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                                        sqlCommand3.ExecuteNonQuery()

                                        ''-------------Fechas y Hora domingos y festivos --------------

                                        Dim sqlCommand4 As New MySqlCommand
                                        sqlCommand4.Connection = myDB
                                        sqlCommand4.CommandText = "UPDATE TotalHoras SET HorasFestivas = '" & DateTimeHoraBase.Text & "' where Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                                        sqlCommand4.ExecuteNonQuery()

                                        Dim sqlCommand7 As New MySqlCommand
                                        sqlCommand7.Connection = myDB
                                        sqlCommand7.CommandText = "UPDATE TotalHoras SET InicioFestiva = '" & HoraIngreso.Text & "' WHERE Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                                        sqlCommand7.ExecuteNonQuery()

                                        Dim sqlCommand8 As New MySqlCommand
                                        sqlCommand8.Connection = myDB
                                        sqlCommand8.CommandText = "UPDATE TotalHoras SET FinFestiva = '" & HoraSalida.Text & "' WHERE Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                                        sqlCommand8.ExecuteNonQuery()

                                    Else

                                        operacionesTiempo()

                                        Dim sqlCommand5 As New MySqlCommand
                                        sqlCommand5.Connection = myDB
                                        sqlCommand5.CommandText = "UPDATE TotalHoras SET Horas = '" & DateTimeHoraBase.Text & "' where Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                                        sqlCommand5.ExecuteNonQuery()

                                        ''-------------Fechas y Hora de extras --------------

                                        Dim sqlCommand6 As New MySqlCommand
                                        sqlCommand6.Connection = myDB
                                        sqlCommand6.CommandText = "UPDATE TotalHoras I1 SET I1.HorasExtras = (SELECT timediff(I1.Horas,I2.HoraBase) FROM IngresosHoras I2 where I1.Horas >=I2.HoraBase and I2.Cedula='" & Txtvercedula.Text & "' and I2.Fecha = '" & ConsultaFecha & "') WHERE I1.Cedula='" & Txtvercedula.Text & "' and I1.Fecha = '" & ConsultaFecha & "';"
                                        sqlCommand6.ExecuteNonQuery()

                                        Dim sqlCommand7 As New MySqlCommand
                                        sqlCommand7.Connection = myDB
                                        sqlCommand7.CommandText = "UPDATE TotalHoras I1 SET I1.InicioExtra = (SELECT timediff(I2.HoraSalida,I1.HorasExtras) FROM IngresosHoras I2 where I1.Horas >= I2.HoraBase and I2.Cedula='" & Txtvercedula.Text & "' and I2.Fecha = '" & ConsultaFecha & "') WHERE I1.Cedula='" & Txtvercedula.Text & "' and I1.Fecha = '" & ConsultaFecha & "';"
                                        sqlCommand7.ExecuteNonQuery()

                                        Dim sqlCommand8 As New MySqlCommand
                                        sqlCommand8.Connection = myDB
                                        sqlCommand8.CommandText = "UPDATE TotalHoras SET FinExtra = '" & TxtHoraRegistroSalida.Text & "' WHERE Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                                        sqlCommand8.ExecuteNonQuery()


                                    End If

                                    HuellaIncorrecta.Visible = False
                                    HuellaCorrecta.Visible = True

                                    MessageBox.Show("Registro de Salida correcto, descansa mucho!!", "Informacion", MessageBoxButtons.OK,
                                                   MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                                    Txtvercedula.Text = ""
                                    TxtverNombre.Text = ""
                                    Txtpuntos.Text = ""
                                    TxtMensajes.Text = ""
                                    HuellaCorrecta.Visible = False
                                    HuellaIncorrecta.Visible = False
                                    HuellaNormal.Visible = True

                                    Exit While

                                Else
                                    MessageBox.Show("El tiempo trabajado es inferior a la permitido debe informar a su Coordinador para realizar el registro manual gracias.", "Informacion", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

                                    Txtvercedula.Text = ""
                                    TxtverNombre.Text = ""
                                    Txtpuntos.Text = ""
                                    TxtMensajes.Text = ""
                                    HuellaCorrecta.Visible = False
                                    HuellaIncorrecta.Visible = False
                                    HuellaNormal.Visible = True

                                End If

                            End While

                            ' Si el lector de datos no está cerrado, entonces ciérralo
                            If Not readerTiempo.IsClosed Then
                                readerTiempo.Close()
                            End If

                        End If

                    End If


                ElseIf Status = FlexCodeSDK.VerificationStatus.v_NotMatch Then
                    TxtMensajes.Text = ""
                    TxtMensajes.Text = TxtMensajes.Text & vbNewLine & "No se reconoce la Huella!"
                    HuellaIncorrecta.Visible = True
                    Txtvercedula.Text = ""
                    TxtverNombre.Text = ""
                    Txtpuntos.Text = ""


                ElseIf Status = FlexCodeSDK.VerificationStatus.v_VerifyCaptureFingerTouch Then
                    TxtMensajes.Text = ""
                    TxtMensajes.Text = TxtMensajes.Text & vbNewLine & "Validando Huella..."

                Else
                    TxtMensajes.Text = ""
                    TxtMensajes.Text = TxtMensajes.Text & vbNewLine & "Estado : " & Str(Status)

                End If


            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub Hora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hora.Tick
        TxtHoraRegistroSalida.Text = DateTime.Now
    End Sub


    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click

        Principal.BtnMarcacionSalidalat.Enabled = True
        TxtComprobar.Text = ""
        HuellaCorrecta.Visible = False
        HuellaNormal.Visible = True
        HoraSalida.Text = DateTime.Now
        HoraIngreso.Text = DateTime.Now
        FpVer.FPVerificationStop()
        TiempoCierre2.Stop()
        Hora.Stop()

        Me.Close()

    End Sub

    Private Sub TiempoCierre2_Tick(sender As Object, e As EventArgs) Handles TiempoCierre2.Tick

        Principal.BtnMarcacionSalidalat.Enabled = True
        TxtComprobar.Text = ""
        HuellaCorrecta.Visible = False
        HuellaNormal.Visible = True
        HoraSalida.Text = DateTime.Now
        HoraIngreso.Text = DateTime.Now
        FpVer.FPVerificationStop()

        Me.Close()

    End Sub

End Class