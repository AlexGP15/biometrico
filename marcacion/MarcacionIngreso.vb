Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlServerCe
Imports System.Data.SqlClient

Public Class MarcacionIngreso

    Dim MOSTRAR As String
    Dim WithEvents FpVer As FlexCodeSDK.FinFPVer
    Dim EmpID As String
    Dim FpIndex As Byte
    Dim ComprobarHora As String
    Dim CONEXION As SqlConnection

    Private Sub MarcacionIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Using CONEXION = New SqlConnection()
        '    conexion.ConnectionString = ConexionDali.ToString
        '    CONEXION.Open()

        '    MsgBox("Hola estoy conectado")

        'End Using
        'Try
        'Crear instancia conexion

        Dim cadenaConexion As String = "Server = 92.249.47.80;Database=u900412310_InterBiometric;Uid=u900412310_HuellasJoyeria;Pwd='Alexgp@2016';"
        Dim conexion As New MySqlConnection(cadenaConexion)

        conexion.Open()




        ''Funcion para Verificar dia
        'ValidarDia()

        'If myDB.State = ConnectionState.Open Then

        '    Dim sqlCommand As New MySqlCommand
        '    sqlCommand.Connection = myDB

        '    FpVer = New FlexCodeSDK.FinFPVer
        '    FpVer.AddDeviceInfo("C700F001339", "1SX-J98-067-81L-40X", "VLT1-FF2F-6C40-5A20-4058-62GV")

        '    sqlCommand.Connection = myDB
        '    sqlCommand.CommandText = "SELECT Cedula, Nombre, Dedo, RegistroHuella FROM Registro"
        '    Dim rd As MySqlDataReader
        '    rd = sqlCommand.ExecuteReader

        '    While rd.Read
        '        FpVer.FPLoad(rd.GetString(0), rd.GetString(2), rd.GetString(3), "YourSecretKey" & rd.GetString(0))
        '    End While

        '    FpVer.FPVerificationStart()

        '    rd.Close()

        '    TiempoCierre1.Start()
        '    Hora.Start()
        '    myDB.Close()


        'End If



        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
        '                                   MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        'End Try

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
                LabelFestivo.Text = MOSTRAR

                sqlCommand.CommandText = "SELECT Nombre FROM Domingos where Fecha = '" & ConsultaFecha & "';"
                sqlCommand.ExecuteNonQuery()
                MOSTRAR = sqlCommand.ExecuteScalar
                LabelDomingo.Text = MOSTRAR

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
                ComprobarHora = MOSTRAR

                myDB.Close()


            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

        Return True
    End Function

    Public Function ValidarHoraIngreso()

        Dim sqlCommand As New MySqlCommand
        Dim rd3 As MySqlDataReader

        Try
            'Crear instancia conexion
            Using myDB = New MySqlConnection

                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                If LabelDomingo.Text = "Domingo" Then

                    sqlCommand.Connection = myDB
                    sqlCommand.CommandText = "SELECT IngresoDomingo FROM Ubicaciones where Descripcion ='" & Txtpuntos.Text & "';"
                    rd3 = sqlCommand.ExecuteReader
                    rd3.Read()

                    TxtValidarHora.Text = rd3.GetString(0)
                    rd3.Close()

                ElseIf LabelFestivo.Text = "Festivo" Then

                    sqlCommand.Connection = myDB
                    sqlCommand.CommandText = "SELECT IngresoFestivo FROM Ubicaciones where Descripcion ='" & Txtpuntos.Text & "';"
                    rd3 = sqlCommand.ExecuteReader
                    rd3.Read()

                    TxtValidarHora.Text = rd3.GetString(0)
                    rd3.Close()

                Else

                    sqlCommand.Connection = myDB
                    sqlCommand.CommandText = "SELECT IngresoNormal FROM Ubicaciones where Descripcion ='" & Txtpuntos.Text & "';"
                    rd3 = sqlCommand.ExecuteReader
                    rd3.Read()

                    TxtValidarHora.Text = rd3.GetString(0)
                    rd3.Close()

                End If

                myDB.Close()


            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

        Return True
    End Function

    Public Function ValidarHoraLlegadaTarde()

        Dim sqlCommand As New MySqlCommand
        Dim rd3 As MySqlDataReader

        Try
            'Crear instancia conexion
            Using myDB = New MySqlConnection

                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                sqlCommand.Connection = myDB
                sqlCommand.CommandText = "SELECT HoraLlegadaTarde FROM Ubicaciones where Descripcion ='" & Txtpuntos.Text & "';"
                rd3 = sqlCommand.ExecuteReader
                rd3.Read()

                TxtValidarHoraLlegadaTarde.Text = rd3.GetString(0)

                rd3.Close()

                myDB.Close()


            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

        Return True
    End Function

    Public Function ValidarHoraBase()

        Dim sqlCommand As New MySqlCommand
        Dim rd3 As MySqlDataReader

        Try
            'Crear instancia conexion
            Using myDB = New MySqlConnection

                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                sqlCommand.Connection = myDB
                sqlCommand.CommandText = "SELECT BaseHoraExtra FROM Ubicaciones where Descripcion ='" & Txtpuntos.Text & "';"
                rd3 = sqlCommand.ExecuteReader
                rd3.Read()

                TxtValidarHoraBase.Text = rd3.GetString(0)

                rd3.Close()

                myDB.Close()


            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

        Return True
    End Function

    Public Function ValidarTiempoAlmuerzo()

        Dim sqlCommand As New MySqlCommand
        Dim rd3 As MySqlDataReader

        Try
            'Crear instancia conexion
            Using myDB = New MySqlConnection

                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                sqlCommand.Connection = myDB
                sqlCommand.CommandText = "SELECT TiempoAlmuerzo FROM Ubicaciones where Descripcion ='" & Txtpuntos.Text & "';"
                rd3 = sqlCommand.ExecuteReader
                rd3.Read()

                TxtValidarTiempoAlmuerzo.Text = rd3.GetString(0)

                rd3.Close()

                myDB.Close()


            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

        Return True
    End Function

    Public Function operacionesTiempoLlegadaTarde()

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


                strSQL2 = "SELECT Hora,HoraIngresoNormal FROM LlegadasTarde where Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"

                cmd2 = New MySqlCommand()
                cmd2.CommandText = strSQL2
                cmd2.CommandType = CommandType.Text
                cmd2.Connection = myDB

                Dim reader As MySqlDataReader = cmd2.ExecuteReader()

                While reader.Read()
                    ' Obtener las horas de inicio y fin desde MySQL
                    Dim horaLlegada As TimeSpan = reader.GetTimeSpan("Hora")
                    Dim horaIngreso As TimeSpan = reader.GetTimeSpan("HoraIngresoNormal")


                    ' Realizar la resta de horas
                    Dim tiempoTrabajado As TimeSpan = horaLlegada - horaIngreso

                    ' Mostrar el resultado en un TextBox (por ejemplo)
                    TxtValidarTarde.Text = tiempoTrabajado.ToString()

                End While

                reader.Close()

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

                    TxtMensajes.Text = ""

                    '**** comandos para Ingreso****

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

                    ValidarHoraIngreso()

                    ValidarHoraLlegadaTarde()

                    ValidarHoraBase()

                    ValidarTiempoAlmuerzo()

                    '*********ingreso de datos ***************

                    Dim sqlCommand As New MySqlCommand
                    sqlCommand.Connection = myDB

                    If LabelDomingo.Text = "Domingo" Then

                        '******INGRESO DOMINGO*****

                        If ComprobarHora = "" Then
                            HuellaIncorrecta.Visible = False

                            'entrada despues de la hora de ingreso normal
                            If TxtHoraIngreso.Text > TxtValidarHora.Text Then

                                sqlCommand.CommandText = "INSERT INTO IngresosHoras(Cedula, Nombre, Ubicacion, Fecha, HoraIngreso, HoraSalida, Dia, HoraBase, TiempoAlmuerzo) VALUES('" & Txtvercedula.Text & "','" & TxtverNombre.Text & "','" & Txtpuntos.Text & "','" & ConsultaFecha & "','" & TxtHoraIngreso.Text & "',0,'Domingo','" & TxtValidarHoraBase.Text & "','" & TxtValidarTiempoAlmuerzo.Text & "')"
                                sqlCommand.ExecuteNonQuery()

                                ComprobarHora = ""

                                '*********ingreso de datos a tabla TotalHoras***************

                                Dim sqlCommand3 As New MySqlCommand
                                sqlCommand3.Connection = myDB
                                sqlCommand3.CommandText = "INSERT INTO TotalHoras(Cedula, Fecha, Horas) VALUES('" & Txtvercedula.Text & "','" & ConsultaFecha & "','')"
                                sqlCommand3.ExecuteNonQuery()

                                MessageBox.Show("Registro correcto de Ingreso, que tengas lindo día!!", "Informacion", MessageBoxButtons.OK,
                                               MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                            Else
                                'entrada antes de la hora de ingreso normal
                                sqlCommand.CommandText = "INSERT INTO IngresosHoras(Cedula, Nombre, Ubicacion, Fecha, HoraIngreso, HoraSalida, Dia, HoraBase, TiempoAlmuerzo) VALUES('" & Txtvercedula.Text & "','" & TxtverNombre.Text & "','" & Txtpuntos.Text & "','" & ConsultaFecha & "','" & TxtValidarHora.Text & "',0,'Domingo','" & TxtValidarHoraBase.Text & "','" & TxtValidarTiempoAlmuerzo.Text & "')"
                                sqlCommand.ExecuteNonQuery()

                                ComprobarHora = ""

                                '*********ingreso de datos a tabla TotalHoras***************

                                Dim sqlCommand3 As New MySqlCommand
                                sqlCommand3.Connection = myDB
                                sqlCommand3.CommandText = "INSERT INTO TotalHoras(Cedula, Fecha, Horas) VALUES('" & Txtvercedula.Text & "','" & ConsultaFecha & "','')"
                                sqlCommand3.ExecuteNonQuery()

                                MessageBox.Show("Registro correcto de Ingreso, que tengas lindo día!!", "Informacion", MessageBoxButtons.OK,
                                               MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                            End If

                            '*********ingreso de datos a tabla LlegadasTarde***************

                            If TxtHoraIngreso.Text >= TxtValidarHoraLlegadaTarde.Text Then
                                Dim sqlCommand4 As New MySqlCommand
                                sqlCommand4.Connection = myDB
                                sqlCommand4.CommandText = "INSERT INTO LlegadasTarde(Cedula,Nombre,Fecha,Ubicacion,Hora,HoraIngresoNormal,Notas) VALUES('" & Txtvercedula.Text & "','" & TxtverNombre.Text & "','" & ConsultaFecha & "','" & Txtpuntos.Text & "','" & TxtHoraIngreso.Text & "','" & TxtValidarHoraLlegadaTarde.Text & "','Ingreso Auto')"
                                sqlCommand4.ExecuteNonQuery()

                                operacionesTiempoLlegadaTarde()

                                Dim sqlCommand5 As New MySqlCommand
                                sqlCommand5.Connection = myDB
                                sqlCommand5.CommandText = "UPDATE LlegadasTarde SET Diferencia = '" & TxtValidarTarde.Text & "' where Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                                sqlCommand5.ExecuteNonQuery()

                                TxtValidarHora.Text = DateTime.Now
                                TxtValidarHoraLlegadaTarde.Text = DateTime.Now

                            End If

                            '***************************************************************

                            TxtMensajes.Text = ""
                            Txtvercedula.Text = ""
                            TxtverNombre.Text = ""
                            Txtpuntos.Text = ""
                            HuellaCorrecta.Visible = False
                            HuellaIncorrecta.Visible = False
                            HuellaNormal.Visible = True

                        Else

                            HuellaCorrecta.Visible = True
                            HuellaIncorrecta.Visible = False
                            TxtMensajes.Text = ""
                            Txtvercedula.Text = ""
                            TxtverNombre.Text = ""
                            Txtpuntos.Text = ""

                            MessageBox.Show("Ya realizo el registro de Ingreso de este día!!!", "Informacion", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

                            ComprobarHora = ""
                            HuellaCorrecta.Visible = False
                            HuellaNormal.Visible = True

                            TxtValidarHora.Text = DateTime.Now
                            TxtValidarHoraLlegadaTarde.Text = DateTime.Now

                        End If


                    ElseIf LabelFestivo.Text = "Festivo" Then

                        '******INGRESO FESTIVO*****

                        If ComprobarHora = "" Then
                            HuellaIncorrecta.Visible = False

                            'entrada despues de la hora de ingreso normal
                            If TxtHoraIngreso.Text > TxtValidarHora.Text Then

                                sqlCommand.CommandText = "INSERT INTO IngresosHoras(Cedula, Nombre, Ubicacion, Fecha, HoraIngreso, HoraSalida, Dia, HoraBase, TiempoAlmuerzo) VALUES('" & Txtvercedula.Text & "','" & TxtverNombre.Text & "','" & Txtpuntos.Text & "','" & ConsultaFecha & "','" & TxtHoraIngreso.Text & "',0,'Festivo','" & TxtValidarHoraBase.Text & "','" & TxtValidarTiempoAlmuerzo.Text & "')"
                                sqlCommand.ExecuteNonQuery()

                                ComprobarHora = ""

                                '*********ingreso de datos a tabla TotalHoras***************

                                Dim sqlCommand3 As New MySqlCommand
                                sqlCommand3.Connection = myDB
                                sqlCommand3.CommandText = "INSERT INTO TotalHoras(Cedula, Fecha, Horas) VALUES('" & Txtvercedula.Text & "','" & ConsultaFecha & "','')"
                                sqlCommand3.ExecuteNonQuery()

                                MessageBox.Show("Registro correcto de Ingreso, que tengas lindo día!!", "Informacion", MessageBoxButtons.OK,
                                               MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                            Else
                                'entrada antes de la hora de ingreso normal
                                sqlCommand.CommandText = "INSERT INTO IngresosHoras(Cedula, Nombre, Ubicacion, Fecha, HoraIngreso, HoraSalida, Dia, HoraBase, TiempoAlmuerzo) VALUES('" & Txtvercedula.Text & "','" & TxtverNombre.Text & "','" & Txtpuntos.Text & "','" & ConsultaFecha & "','" & TxtValidarHora.Text & "',0,'Festivo','" & TxtValidarHoraBase.Text & "','" & TxtValidarTiempoAlmuerzo.Text & "')"
                                sqlCommand.ExecuteNonQuery()

                                ComprobarHora = ""

                                '*********ingreso de datos a tabla TotalHoras***************

                                Dim sqlCommand3 As New MySqlCommand
                                sqlCommand3.Connection = myDB
                                sqlCommand3.CommandText = "INSERT INTO TotalHoras(Cedula, Fecha, Horas) VALUES('" & Txtvercedula.Text & "','" & ConsultaFecha & "','')"
                                sqlCommand3.ExecuteNonQuery()

                                MessageBox.Show("Registro correcto de Ingreso, que tengas lindo día!!", "Informacion", MessageBoxButtons.OK,
                                               MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                            End If

                            '*********ingreso de datos a tabla LlegadasTarde***************

                            If TxtHoraIngreso.Text >= TxtValidarHoraLlegadaTarde.Text Then
                                Dim sqlCommand4 As New MySqlCommand
                                sqlCommand4.Connection = myDB
                                sqlCommand4.CommandText = "INSERT INTO LlegadasTarde(Cedula,Nombre,Fecha,Ubicacion,Hora,HoraIngresoNormal,Notas) VALUES('" & Txtvercedula.Text & "','" & TxtverNombre.Text & "','" & ConsultaFecha & "','" & Txtpuntos.Text & "','" & TxtHoraIngreso.Text & "','" & TxtValidarHoraLlegadaTarde.Text & "','Ingreso Auto')"
                                sqlCommand4.ExecuteNonQuery()

                                operacionesTiempoLlegadaTarde()

                                Dim sqlCommand5 As New MySqlCommand
                                sqlCommand5.Connection = myDB
                                sqlCommand5.CommandText = "UPDATE LlegadasTarde SET Diferencia = '" & TxtValidarTarde.Text & "' where Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                                sqlCommand5.ExecuteNonQuery()

                                TxtValidarHora.Text = DateTime.Now
                                TxtValidarHoraLlegadaTarde.Text = DateTime.Now

                            End If

                            '***************************************************************

                            TxtMensajes.Text = ""
                            Txtvercedula.Text = ""
                            TxtverNombre.Text = ""
                            Txtpuntos.Text = ""
                            HuellaCorrecta.Visible = False
                            HuellaIncorrecta.Visible = False
                            HuellaNormal.Visible = True

                        Else

                            HuellaCorrecta.Visible = True
                            HuellaIncorrecta.Visible = False
                            TxtMensajes.Text = ""
                            Txtvercedula.Text = ""
                            TxtverNombre.Text = ""
                            Txtpuntos.Text = ""

                            MessageBox.Show("Ya realizo el registro de Ingreso de este día!!!", "Informacion", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

                            ComprobarHora = ""
                            HuellaCorrecta.Visible = False
                            HuellaNormal.Visible = True

                            TxtValidarHora.Text = DateTime.Now
                            TxtValidarHoraLlegadaTarde.Text = DateTime.Now

                        End If

                    Else

                        '******INGRESO NORMAL*****

                        If ComprobarHora = "" Then
                            HuellaIncorrecta.Visible = False

                            'entrada despues de la hora de ingreso normal
                            If TxtHoraIngreso.Text > TxtValidarHora.Text Then

                                sqlCommand.CommandText = "INSERT INTO IngresosHoras(Cedula, Nombre, Ubicacion, Fecha, HoraIngreso, HoraSalida, Dia, HoraBase, TiempoAlmuerzo) VALUES('" & Txtvercedula.Text & "','" & TxtverNombre.Text & "','" & Txtpuntos.Text & "','" & ConsultaFecha & "','" & TxtHoraIngreso.Text & "',0,'Normal','" & TxtValidarHoraBase.Text & "','" & TxtValidarTiempoAlmuerzo.Text & "')"
                                sqlCommand.ExecuteNonQuery()

                                ComprobarHora = ""

                                '*********ingreso de datos a tabla TotalHoras***************

                                Dim sqlCommand3 As New MySqlCommand
                                sqlCommand3.Connection = myDB
                                sqlCommand3.CommandText = "INSERT INTO TotalHoras(Cedula, Fecha, Horas) VALUES('" & Txtvercedula.Text & "','" & ConsultaFecha & "','')"
                                sqlCommand3.ExecuteNonQuery()

                                MessageBox.Show("Registro correcto de Ingreso, que tengas lindo día!!", "Informacion", MessageBoxButtons.OK,
                                               MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                            Else
                                'entrada antes de la hora de ingreso normal
                                sqlCommand.CommandText = "INSERT INTO IngresosHoras(Cedula, Nombre, Ubicacion, Fecha, HoraIngreso, HoraSalida, Dia, HoraBase, TiempoAlmuerzo) VALUES('" & Txtvercedula.Text & "','" & TxtverNombre.Text & "','" & Txtpuntos.Text & "','" & ConsultaFecha & "','" & TxtValidarHora.Text & "',0,'Normal','" & TxtValidarHoraBase.Text & "','" & TxtValidarTiempoAlmuerzo.Text & "')"
                                sqlCommand.ExecuteNonQuery()

                                ComprobarHora = ""

                                '*********ingreso de datos a tabla TotalHoras***************

                                Dim sqlCommand3 As New MySqlCommand
                                sqlCommand3.Connection = myDB
                                sqlCommand3.CommandText = "INSERT INTO TotalHoras(Cedula, Fecha, Horas) VALUES('" & Txtvercedula.Text & "','" & ConsultaFecha & "','')"
                                sqlCommand3.ExecuteNonQuery()

                                MessageBox.Show("Registro correcto de Ingreso, que tengas lindo día!!", "Informacion", MessageBoxButtons.OK,
                                               MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                            End If

                            '*********ingreso de datos a tabla LlegadasTarde***************

                            If TxtHoraIngreso.Text >= TxtValidarHoraLlegadaTarde.Text Then
                                Dim sqlCommand4 As New MySqlCommand
                                sqlCommand4.Connection = myDB
                                sqlCommand4.CommandText = "INSERT INTO LlegadasTarde(Cedula,Nombre,Fecha,Ubicacion,Hora,HoraIngresoNormal,Notas) VALUES('" & Txtvercedula.Text & "','" & TxtverNombre.Text & "','" & ConsultaFecha & "','" & Txtpuntos.Text & "','" & TxtHoraIngreso.Text & "','" & TxtValidarHoraLlegadaTarde.Text & "','Ingreso Auto')"
                                sqlCommand4.ExecuteNonQuery()

                                operacionesTiempoLlegadaTarde()

                                Dim sqlCommand5 As New MySqlCommand
                                sqlCommand5.Connection = myDB
                                sqlCommand5.CommandText = "UPDATE LlegadasTarde SET Diferencia = '" & TxtValidarTarde.Text & "' where Cedula='" & Txtvercedula.Text & "' and Fecha = '" & ConsultaFecha & "';"
                                sqlCommand5.ExecuteNonQuery()

                                TxtValidarHora.Text = DateTime.Now
                                TxtValidarHoraLlegadaTarde.Text = DateTime.Now

                            End If

                            '***************************************************************

                            TxtMensajes.Text = ""
                            Txtvercedula.Text = ""
                            TxtverNombre.Text = ""
                            Txtpuntos.Text = ""
                            HuellaCorrecta.Visible = False
                            HuellaIncorrecta.Visible = False
                            HuellaNormal.Visible = True

                        Else

                            HuellaCorrecta.Visible = True
                            HuellaIncorrecta.Visible = False
                            TxtMensajes.Text = ""
                            Txtvercedula.Text = ""
                            TxtverNombre.Text = ""
                            Txtpuntos.Text = ""

                            MessageBox.Show("Ya realizo el registro de Ingreso de este día!!!", "Informacion", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

                            ComprobarHora = ""
                            HuellaCorrecta.Visible = False
                            HuellaNormal.Visible = True

                            TxtValidarHora.Text = DateTime.Now
                            TxtValidarHoraLlegadaTarde.Text = DateTime.Now

                        End If

                    End If

                    myDB.Close()


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
        TxtHoraIngreso.Text = DateTime.Now
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click

        Principal.BntMarcacionIngresolat.Enabled = True
        ComprobarHora = ""
        HuellaCorrecta.Visible = False
        HuellaNormal.Visible = True

        TxtValidarHora.Text = DateTime.Now
        FpVer.FPVerificationStop()
        TiempoCierre1.Stop()
        Hora.Stop()
        Me.Close()

    End Sub

    Private Sub TiempoCierre1_Tick(sender As Object, e As EventArgs) Handles TiempoCierre1.Tick
        Principal.BntMarcacionIngresolat.Enabled = True
        ComprobarHora = ""
        HuellaCorrecta.Visible = False
        HuellaNormal.Visible = True

        TxtValidarHora.Text = DateTime.Now
        FpVer.FPVerificationStop()

        Me.Close()
    End Sub
End Class