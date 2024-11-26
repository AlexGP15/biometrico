Imports System.Data.SqlClient
Imports System.Globalization

Public Class CronogramaVacaciones
    Dim myDB As SqlConnection
    Dim MYADAPTER As SqlDataReader
    Dim MOSTRAR As String

    Private Sub IngresoNovedades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            'Crear instancia conexion
            Using myDB = New SqlConnection


                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                TxtFechaActual.Value = DateTime.Now
                TxtAno.Text = DateTime.Now.Year

                '*****Cargar datos en combox desde Mysql******************
                Dim strSQL As String
                Dim da As New SqlDataAdapter
                Dim ds As New DataSet
                Dim cmd As New SqlCommand

                strSQL = "SELECT DISTINCT Nombre FROM Registro order by Nombre"

                cmd = New SqlCommand()
                cmd.CommandText = strSQL
                cmd.CommandType = CommandType.Text
                cmd.Connection = myDB

                ds = New DataSet()
                da.SelectCommand = cmd
                da.Fill(ds, "Registro")
                TxtNombres.DataSource = ds.Tables(0)
                TxtNombres.DisplayMember = "Nombre"

                '**********************************************************

                ' Obtener el valor actual del DateTimePicker
                Dim fechaActual As DateTime = TxtFechaActual.Value

                ' Sumar un mes a la fecha actual
                Dim nuevaFecha As DateTime = fechaActual.AddMonths(1)

                ' Actualizar el valor del DateTimePicker con la nueva fecha
                TxtFechaSiguiente.Value = nuevaFecha


                Dim ConsultaFechaMesActual As String
                Dim ConsultaFechaanoActual As String
                Dim ConsultaFechaMesSiguiente As String
                Dim ConsultaFechaanoSiguiente As String
                'Extraemos el año, mes y dia de los DateTimePicker
                ConsultaFechaMesActual = TxtFechaActual.Value.Month
                ConsultaFechaanoActual = TxtFechaActual.Value.Year
                ConsultaFechaMesSiguiente = TxtFechaSiguiente.Value.Month
                ConsultaFechaanoSiguiente = TxtFechaSiguiente.Value.Year

                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = myDB

                Dim DS2 As New DataSet 'para actualizar
                Dim TABLA2 As New DataTable 'para actualizar
                Dim DA2 As New SqlDataAdapter("SELECT Nombre, FechaInicio FROM Vacaciones where MONTH(FechaInicio) = '" & ConsultaFechaMesActual & "' and YEAR(FechaInicio) = '" & ConsultaFechaanoActual & "' order by FechaInicio asc;", myDB) 'para actualizar

                ' de aqui para abajo para actualizar en el datagri.

                Dim CMD2 As New SqlCommandBuilder(DA2)
                DA2.Fill(TABLA2)
                DataGridMesActual.DataSource = TABLA2
                DataGridMesActual.Columns(1).HeaderText = "Fecha Inicio"

                DataGridMesActual.Columns(0).Width = 243

                '**********************************************************


                Dim DS3 As New DataSet 'para actualizar
                Dim TABLA3 As New DataTable 'para actualizar
                Dim DA3 As New SqlDataAdapter("SELECT Nombre, FechaInicio FROM Vacaciones where MONTH(FechaInicio) = '" & ConsultaFechaMesSiguiente & "' and YEAR(FechaInicio) = '" & ConsultaFechaanoSiguiente & "' order by FechaInicio asc;", myDB) 'para actualizar

                ' de aqui para abajo para actualizar en el datagri.

                Dim CMD3 As New SqlCommandBuilder(DA3)
                DA3.Fill(TABLA3)
                DataGridMesSiguiente.DataSource = TABLA3
                DataGridMesSiguiente.Columns(1).HeaderText = "Fecha Inicio"

                DataGridMesSiguiente.Columns(0).Width = 243


                TxtNombres.Text = ""

            End Using

        Catch ex As Exception
        MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                       MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub VerCalendario_Click(sender As Object, e As EventArgs) Handles VerCalendario.Click
        CalendarioVacaciones.Show()
    End Sub

    Private Sub BtnConsultarTienda_Click(sender As Object, e As EventArgs) Handles BtnConsultarTienda.Click
        Try

            'Crear instancia conexion
            Using myDB = New SqlConnection


                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                If RadioTesoro.Checked Then

                    Dim sqlCommand As New SqlCommand
                    sqlCommand.Connection = myDB

                    Dim DS As New DataSet 'para actualizar
                    Dim TABLA As New DataTable 'para actualizar
                    Dim DA As New SqlDataAdapter("SELECT Nombre, Dias, FechaInicio, FechaFin, FechaIngreso FROM Vacaciones where Ubicacion ='INTER TESORO' and YEAR(FechaInicio) = '" & TxtAno.Text & "' order by FechaInicio asc;", myDB) 'para actualizar

                    ' de aqui para abajo para actualizar en el datagri.

                    Dim CMD As New SqlCommandBuilder(DA)
                    DA.Fill(TABLA)
                    DataGridVacacionesTienda.DataSource = TABLA
                    DataGridVacacionesTienda.Columns(2).HeaderText = "Fecha Inicio"
                    DataGridVacacionesTienda.Columns(3).HeaderText = "Fecha Fin"
                    DataGridVacacionesTienda.Columns(4).HeaderText = "Fecha Reingreso"

                    DataGridVacacionesTienda.Columns(0).Width = 365
                    DataGridVacacionesTienda.Columns(1).Width = 60


                ElseIf RadioOviedo1.Checked Then

                    Dim sqlCommand As New SqlCommand
                    sqlCommand.Connection = myDB

                    Dim DS As New DataSet 'para actualizar
                    Dim TABLA As New DataTable 'para actualizar
                    Dim DA As New SqlDataAdapter("SELECT Nombre, Dias, FechaInicio, FechaFin, FechaIngreso FROM Vacaciones where Ubicacion ='INTER OVIEDO 1' and YEAR(FechaInicio) = '" & TxtAno.Text & "' order by FechaInicio asc;", myDB) 'para actualizar

                    ' de aqui para abajo para actualizar en el datagri.

                    Dim CMD As New SqlCommandBuilder(DA)
                    DA.Fill(TABLA)
                    DataGridVacacionesTienda.DataSource = TABLA
                    DataGridVacacionesTienda.Columns(2).HeaderText = "Fecha Inicio"
                    DataGridVacacionesTienda.Columns(3).HeaderText = "Fecha Fin"
                    DataGridVacacionesTienda.Columns(4).HeaderText = "Fecha Reingreso"

                    DataGridVacacionesTienda.Columns(0).Width = 365
                    DataGridVacacionesTienda.Columns(1).Width = 60

                ElseIf RadioOviedo2.Checked Then

                    Dim sqlCommand As New SqlCommand
                    sqlCommand.Connection = myDB

                    Dim DS As New DataSet 'para actualizar
                    Dim TABLA As New DataTable 'para actualizar
                    Dim DA As New SqlDataAdapter("SELECT Nombre, Dias, FechaInicio, FechaFin, FechaIngreso FROM Vacaciones where Ubicacion ='INTER OVIEDO 2' and YEAR(FechaInicio) = '" & TxtAno.Text & "' order by FechaInicio asc;", myDB) 'para actualizar

                    ' de aqui para abajo para actualizar en el datagri.

                    Dim CMD As New SqlCommandBuilder(DA)
                    DA.Fill(TABLA)
                    DataGridVacacionesTienda.DataSource = TABLA
                    DataGridVacacionesTienda.Columns(2).HeaderText = "Fecha Inicio"
                    DataGridVacacionesTienda.Columns(3).HeaderText = "Fecha Fin"
                    DataGridVacacionesTienda.Columns(4).HeaderText = "Fecha Reingreso"

                    DataGridVacacionesTienda.Columns(0).Width = 365
                    DataGridVacacionesTienda.Columns(1).Width = 60

                ElseIf RadioJardines.Checked Then

                    Dim sqlCommand As New SqlCommand
                    sqlCommand.Connection = myDB

                    Dim DS As New DataSet 'para actualizar
                    Dim TABLA As New DataTable 'para actualizar
                    Dim DA As New SqlDataAdapter("SELECT Nombre, Dias, FechaInicio, FechaFin, FechaIngreso FROM Vacaciones where Ubicacion ='INTER JARDINES' and YEAR(FechaInicio) = '" & TxtAno.Text & "' order by FechaInicio asc;", myDB) 'para actualizar

                    ' de aqui para abajo para actualizar en el datagri.

                    Dim CMD As New SqlCommandBuilder(DA)
                    DA.Fill(TABLA)
                    DataGridVacacionesTienda.DataSource = TABLA
                    DataGridVacacionesTienda.Columns(2).HeaderText = "Fecha Inicio"
                    DataGridVacacionesTienda.Columns(3).HeaderText = "Fecha Fin"
                    DataGridVacacionesTienda.Columns(4).HeaderText = "Fecha Reingreso"

                    DataGridVacacionesTienda.Columns(0).Width = 365
                    DataGridVacacionesTienda.Columns(1).Width = 60

                ElseIf RadioOnline.Checked Then

                    Dim sqlCommand As New SqlCommand
                    sqlCommand.Connection = myDB

                    Dim DS As New DataSet 'para actualizar
                    Dim TABLA As New DataTable 'para actualizar
                    Dim DA As New SqlDataAdapter("SELECT Nombre, Dias, FechaInicio, FechaFin, FechaIngreso FROM Vacaciones where Ubicacion ='INTER ONLINE' and YEAR(FechaInicio) = '" & TxtAno.Text & "' order by FechaInicio asc;", myDB) 'para actualizar

                    ' de aqui para abajo para actualizar en el datagri.

                    Dim CMD As New SqlCommandBuilder(DA)
                    DA.Fill(TABLA)
                    DataGridVacacionesTienda.DataSource = TABLA
                    DataGridVacacionesTienda.Columns(2).HeaderText = "Fecha Inicio"
                    DataGridVacacionesTienda.Columns(3).HeaderText = "Fecha Fin"
                    DataGridVacacionesTienda.Columns(4).HeaderText = "Fecha Reingreso"

                    DataGridVacacionesTienda.Columns(0).Width = 365
                    DataGridVacacionesTienda.Columns(1).Width = 60

                ElseIf RadioSupernumerarios.Checked Then

                    Dim sqlCommand As New SqlCommand
                    sqlCommand.Connection = myDB

                    Dim DS As New DataSet 'para actualizar
                    Dim TABLA As New DataTable 'para actualizar
                    Dim DA As New SqlDataAdapter("SELECT Nombre, Dias, FechaInicio, FechaFin, FechaIngreso FROM Vacaciones where Ubicacion like 'SUPER%' and YEAR(FechaInicio) = '" & TxtAno.Text & "' order by FechaInicio asc;", myDB) 'para actualizar

                    ' de aqui para abajo para actualizar en el datagri.

                    Dim CMD As New SqlCommandBuilder(DA)
                    DA.Fill(TABLA)
                    DataGridVacacionesTienda.DataSource = TABLA
                    DataGridVacacionesTienda.Columns(2).HeaderText = "Fecha Inicio"
                    DataGridVacacionesTienda.Columns(3).HeaderText = "Fecha Fin"
                    DataGridVacacionesTienda.Columns(4).HeaderText = "Fecha Reingreso"

                    DataGridVacacionesTienda.Columns(0).Width = 365
                    DataGridVacacionesTienda.Columns(1).Width = 60

                End If

            End Using

        Catch ex As Exception
        MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                       MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub BtnConsultarEmpleado_Click(sender As Object, e As EventArgs) Handles BtnConsultarEmpleado.Click

        Try

            'Crear instancia conexion
            Using myDB = New SqlConnection


                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If



                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = myDB

                Dim DS As New DataSet 'para actualizar
                Dim TABLA As New DataTable 'para actualizar
                Dim DA As New SqlDataAdapter("SELECT Nombre, Dias, FechaInicio, FechaFin, FechaIngreso FROM Vacaciones where Nombre = '" & TxtNombres.Text & "' order by FechaInicio asc;", myDB) 'para actualizar

                ' de aqui para abajo para actualizar en el datagri.

                Dim CMD As New SqlCommandBuilder(DA)
                DA.Fill(TABLA)
                DataGridVacacionesEmpleado.DataSource = TABLA
                DataGridVacacionesEmpleado.Columns(2).HeaderText = "Fecha Inicio"
                DataGridVacacionesEmpleado.Columns(3).HeaderText = "Fecha Fin"
                DataGridVacacionesEmpleado.Columns(4).HeaderText = "Fecha Reingreso"

                DataGridVacacionesEmpleado.Columns(0).Width = 365
                DataGridVacacionesEmpleado.Columns(1).Width = 60




            End Using

        Catch ex As Exception
        MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                       MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

    End Sub
End Class
