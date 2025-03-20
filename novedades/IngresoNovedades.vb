Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlServerCe

Public Class IngresoNovedades
    Dim myDB As MySqlConnection
    Dim MYADAPTER As MySqlDataReader
    Dim MOSTRAR As String

    Private Sub IngresoNovedades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TxtFechaInicio.Value = DateTime.Now
        TxtFechaFin.Value = DateTime.Now
        '*************************************************************************************************************
        Try

            'Crear instancia conexion
            Using myDB = New MySqlConnection


                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If


                '*****Cargar datos en combox desde Mysql******************
                Dim strSQL As String
                Dim da As New MySqlDataAdapter
                Dim ds As New DataSet
                Dim cmd As New MySqlCommand

                strSQL = "SELECT DISTINCT Nombre FROM Registro order by Nombre"

                cmd = New MySqlCommand()
                cmd.CommandText = strSQL
                cmd.CommandType = CommandType.Text
                cmd.Connection = myDB

                ds = New DataSet()
                da.SelectCommand = cmd
                da.Fill(ds, "Registro")
                TxtNombres.DataSource = ds.Tables(0)
                TxtNombres.DisplayMember = "Nombre"
                '**********************************************************

                '*****Cargar datos en combox Novedades desde Mysql******************
                Dim strSQL2 As String
                Dim da2 As New MySqlDataAdapter
                Dim ds2 As New DataSet
                Dim cmd2 As New MySqlCommand

                strSQL2 = "SELECT DISTINCT Descripcion FROM MaestroNovedades order by Descripcion"

                cmd2 = New MySqlCommand()
                cmd2.CommandText = strSQL2
                cmd2.CommandType = CommandType.Text
                cmd2.Connection = myDB

                ds2 = New DataSet()
                da2.SelectCommand = cmd2
                da2.Fill(ds2, "MaestroNovedades")
                TxtNovedad.DataSource = ds2.Tables(0)
                TxtNovedad.DisplayMember = "Descripcion"
                '**********************************************************

                TxtNombres.Text = ""
                TxtNovedad.Text = ""
                Txtcedula.Text = ""
                TxtUbicacion.Text = ""

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

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
                sqlCommand.CommandText = "SELECT BaseHoraExtra FROM Ubicaciones where Descripcion ='" & TxtUbicacion.Text & "';"
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


    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        Try

            'Crear instancia conexion
            Using myDB = New MySqlConnection


                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                ValidarHoraBase()

                If Txtcedula.Text <> "" And TxtNombres.Text <> "" And TxtNovedad.Text <> "Escoge la Novedad..." Then

                    Dim sqlCommand As New MySqlCommand
                    sqlCommand.Connection = myDB

                    Dim ConsultaFechaInicio As String
                    'Extraemos el año, mes y dia de los DateTimePicker
                    ConsultaFechaInicio = TxtFechaInicio.Value.Year & "," & TxtFechaInicio.Value.Month & "," & TxtFechaInicio.Value.Day

                    Dim ConsultaFechaFin As String
                    'Extraemos el año, mes y dia de los DateTimePicker
                    ConsultaFechaFin = TxtFechaFin.Value.Year & "," & TxtFechaFin.Value.Month & "," & TxtFechaFin.Value.Day

                    '*******selecciona el campo para comprobar si ya ingreso

                    sqlCommand.Connection = myDB
                    sqlCommand.CommandText = "SELECT Nombre FROM IngresosHoras where Cedula='" & Txtcedula.Text & "' and Fecha = '" & ConsultaFechaInicio & "';"
                    sqlCommand.ExecuteNonQuery()
                    MOSTRAR = sqlCommand.ExecuteScalar
                    Me.TxtComprobar.Text = MOSTRAR
                    '***********************************************
                    TxtFechaIngreso.Text = TxtFechaInicio.Text


                    If TxtComprobar.Text = "" Then

                        Dim Contador_Fecha As DateTime = TxtFechaInicio.Value
                        Dim Fecha_Fin As DateTime = TxtFechaFin.Value


                        While Contador_Fecha <= Fecha_Fin
                            Dim ConsultaFechaIngreso As String
                            'Extraemos el año, mes y dia de los DateTimePicker
                            ConsultaFechaIngreso = TxtFechaIngreso.Value.Year & "," & TxtFechaIngreso.Value.Month & "," & TxtFechaIngreso.Value.Day


                            sqlCommand.CommandText = "INSERT INTO IngresosHoras(Cedula, Nombre, Ubicacion,Fecha,HoraIngreso,HoraSalida,Dia,HoraBase,Comentarios) VALUES('" & Txtcedula.Text & "','" & TxtNombres.Text & "','" & TxtUbicacion.Text & "','" & ConsultaFechaIngreso & "',0,0,'" & TxtNovedad.Text & "','" & TxtValidarHoraBase.Text & "','" & TxtComentario.Text & "')"
                            sqlCommand.ExecuteNonQuery()

                            '*********ingreso de datos a tabla TotalHoras***************

                            Dim sqlCommand3 As New MySqlCommand
                            sqlCommand3.Connection = myDB
                            sqlCommand3.CommandText = "INSERT INTO TotalHoras(Cedula, Fecha, Horas) VALUES('" & Txtcedula.Text & "','" & ConsultaFechaIngreso & "','" & TxtValidarHoraBase.Text & "')"
                            sqlCommand3.ExecuteNonQuery()

                            TxtFechaIngreso.Value = TxtFechaIngreso.Value.AddDays(1)

                            Contador_Fecha = Contador_Fecha.AddDays(1)


                        End While


                        TxtComprobar.Text = ""

                        MessageBox.Show("Se ingreso la novedad correctamente!!!", "Informacion", MessageBoxButtons.OK,
                                      MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                        TxtFechaIngreso.Text = DateTime.Now
                        TxtFechaInicio.Focus()

                    Else
                        MessageBox.Show("Ya realizo un registro en este dia!!!", "Informacion", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        TxtComprobar.Text = ""

                    End If

                Else

                    MessageBox.Show("Falta informacion no fue posible actualizar!!!", "Advertencia", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

    End Sub


    Private Sub TxtNombres_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNombres.SelectedIndexChanged
        Try

            'Crear instancia conexion
            Using myDB = New MySqlConnection


                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                '*******selecciona el campo de cedula
                Dim sqlCommand2 As New MySqlCommand
                sqlCommand2 = New MySqlCommand()
                sqlCommand2.Connection = myDB
                sqlCommand2.CommandText = "SELECT Cedula FROM Registro where Nombre='" & TxtNombres.Text & "';"
                sqlCommand2.ExecuteNonQuery()
                MOSTRAR = sqlCommand2.ExecuteScalar
                Me.Txtcedula.Text = MOSTRAR
                '***********************************************
                Dim sqlCommand As New MySqlCommand
                sqlCommand.Connection = myDB
                sqlCommand.CommandText = "SELECT Ubicacion FROM Registro where Cedula='" & Txtcedula.Text & "' ;"
                sqlCommand.ExecuteNonQuery()
                MOSTRAR = sqlCommand.ExecuteScalar
                Me.TxtUbicacion.Text = MOSTRAR

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub Txtcedula_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtcedula.LostFocus
        Try

            'Crear instancia conexion
            Using myDB = New MySqlConnection


                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                Dim cmd As New MySqlCommand
                cmd.Connection = myDB
                cmd.CommandText = "SELECT DISTINCT Nombre FROM Registro where Cedula='" & Txtcedula.Text & "';"
                cmd.ExecuteNonQuery()
                MOSTRAR = cmd.ExecuteScalar
                Me.TxtNombres.Text = MOSTRAR

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub Txtcedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcedula.TextChanged
        TxtNombres.Text = ""
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

End Class