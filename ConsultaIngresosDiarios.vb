Imports System.Data.SqlClient

Public Class ConsultaIngresosDiarios
    Dim MYCOMANDO As SqlCommand
    Dim myDB As SqlConnection
    Dim MYADAPTER As SqlDataReader
    Dim MYDATA As New DataTable
    Dim MYDATASET As DataSet
    Dim FILA As DataRow
    Dim MOSTRAR As String

    Private Sub ConsultaIngresosDiarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            'Crear instancia conexion
            Using myDB = New SqlConnection


                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

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

                '*****Cargar datos en combox desde Mysql******************
                Dim strSQL2 As String
                Dim da2 As New SqlDataAdapter
                Dim ds2 As New DataSet
                Dim cmd2 As New SqlCommand

                strSQL2 = "SELECT DISTINCT Descripcion FROM Ubicaciones order by Descripcion"

                cmd2 = New SqlCommand()
                cmd2.CommandText = strSQL2
                cmd2.CommandType = CommandType.Text
                cmd2.Connection = myDB

                ds2 = New DataSet()
                da2.SelectCommand = cmd2
                da2.Fill(ds2, "Registro")
                TxtUbicacion.DataSource = ds2.Tables(0)
                TxtUbicacion.DisplayMember = "Descripcion"
                '**********************************************************

                TxtNombres.Text = ""
                Txtcedula.Text = ""
                TxtUbicacion.Text = ""

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Public Function sumaHorasPermisos()

        Try

            'Crear instancia conexion
            Using myDB = New SqlConnection

                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                Dim strSQL As String
                Dim da2 As New SqlDataAdapter
                Dim ds2 As New DataSet
                Dim cmd2 As New SqlCommand


                Dim ConsultaFechaInicial As DateTime = TxtFechaInicial.Value.Date
                Dim ConsultaFechaFinal As DateTime = TxtFechaFinal.Value.Date


                strSQL = "SELECT HorasPermisos FROM TotalHoras where Cedula='" & Txtcedula.Text & "' and Fecha between '" & ConsultaFechaInicial & "' and '" & ConsultaFechaFinal & "';"

                cmd2 = New SqlCommand()
                cmd2.CommandText = strSQL
                cmd2.CommandType = CommandType.Text
                cmd2.Connection = myDB

                Dim reader As SqlDataReader = cmd2.ExecuteReader()

                While reader.Read()

                    Dim horas As TimeSpan = reader.GetTimeSpan(reader.GetOrdinal("HorasPermisos"))

                    ' Variable para almacenar la sumatoria total
                    Dim totalHoras As TimeSpan = totalHoras.Add(horas)

                    Dim dias As Integer = totalHoras.Days
                    Dim horasRestantes As Integer = totalHoras.Hours

                    TotalTiempoPermisos.Text = $"{dias} días y {horasRestantes} horas"

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


    Public Function sumaHorasTrabajadas()

        Try

            'Crear instancia conexion
            Using myDB = New SqlConnection

                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                Dim strSQL As String
                Dim da2 As New SqlDataAdapter
                Dim ds2 As New DataSet
                Dim cmd2 As New SqlCommand

                Dim ConsultaFechaInicial As DateTime = TxtFechaInicial.Value.Date
                Dim ConsultaFechaFinal As DateTime = TxtFechaFinal.Value.Date


                strSQL = "SELECT Horas FROM TotalHoras where Cedula='" & Txtcedula.Text & "' and Fecha between '" & ConsultaFechaInicial & "' and '" & ConsultaFechaFinal & "';"

                cmd2 = New SqlCommand()
                cmd2.CommandText = strSQL
                cmd2.CommandType = CommandType.Text
                cmd2.Connection = myDB

                Dim reader As SqlDataReader = cmd2.ExecuteReader()

                While reader.Read()
                    Dim horas As TimeSpan = reader.GetTimeSpan(reader.GetOrdinal("Horas"))

                    Dim totalHoras As TimeSpan = totalHoras.Add(horas)

                    Dim dias As Integer = totalHoras.Days
                    Dim horasRestantes As Integer = totalHoras.Hours

                    TotalTiempoTrabajado.Text = $"{dias} días y {horasRestantes} horas"

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


    Public Function sumaHorasExtras()

        Try

            'Crear instancia conexion
            Using myDB = New SqlConnection

                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                Dim strSQL As String
                Dim da2 As New SqlDataAdapter
                Dim ds2 As New DataSet
                Dim cmd2 As New SqlCommand

                Dim ConsultaFechaInicial As DateTime = TxtFechaInicial.Value.Date
                Dim ConsultaFechaFinal As DateTime = TxtFechaFinal.Value.Date


                strSQL = "SELECT HorasExtras FROM TotalHoras where Cedula='" & Txtcedula.Text & "' and Fecha between '" & ConsultaFechaInicial & "' and '" & ConsultaFechaFinal & "';"

                cmd2 = New SqlCommand()
                cmd2.CommandText = strSQL
                cmd2.CommandType = CommandType.Text
                cmd2.Connection = myDB

                Dim reader As SqlDataReader = cmd2.ExecuteReader()

                While reader.Read()

                    Dim horas As TimeSpan = reader.GetTimeSpan(reader.GetOrdinal("HorasExtras"))

                    Dim totalHoras As TimeSpan = totalHoras.Add(horas)

                    Dim dias As Integer = totalHoras.Days
                    Dim horasRestantes As Integer = totalHoras.Hours

                    TotalHorasExtras.Text = $"{dias} días y {horasRestantes} horas"

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

    Public Function sumaHorasFestivas()

        Try

            'Crear instancia conexion
            Using myDB = New SqlConnection

                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                Dim strSQL As String
                Dim da2 As New SqlDataAdapter
                Dim ds2 As New DataSet
                Dim cmd2 As New SqlCommand

                Dim ConsultaFechaInicial As DateTime = TxtFechaInicial.Value.Date
                Dim ConsultaFechaFinal As DateTime = TxtFechaFinal.Value.Date

                strSQL = "SELECT HorasFestivas FROM TotalHoras where Cedula='" & Txtcedula.Text & "' and Fecha between '" & ConsultaFechaInicial & "' and '" & ConsultaFechaFinal & "';"

                cmd2 = New SqlCommand()
                cmd2.CommandText = strSQL
                cmd2.CommandType = CommandType.Text
                cmd2.Connection = myDB

                Dim reader As SqlDataReader = cmd2.ExecuteReader()

                While reader.Read()

                    Dim horas As TimeSpan = reader.GetTimeSpan(reader.GetOrdinal("HorasFestivas"))

                    Dim totalHoras As TimeSpan = totalHoras.Add(horas)

                    Dim dias As Integer = totalHoras.Days
                    Dim horasRestantes As Integer = totalHoras.Hours

                    TotalHorasFestivas.Text = $"{dias} días y {horasRestantes} horas"

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


    Private Sub BtnConsultaCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultaCedula.Click

        If Txtcedula.Text = "" Then
                MessageBox.Show("Debe seleccionar a una persona para consultar !!!", "Informacion", MessageBoxButtons.OK,
                                  MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else

            Try

                'Crear instancia conexion
                Using myDB = New SqlConnection


                    myDB.ConnectionString = ConexionHuellas.ToString
                    'llamar la funcion de las clase

                    If (myDB.State = ConnectionState.Closed) Then

                        myDB.Open()

                    End If

                    sumaHorasPermisos()
                    sumaHorasTrabajadas()
                    sumaHorasExtras()
                    sumaHorasFestivas()

                    TotalTiempoPermisos.Text = "00:00:00"
                    TotalTiempoTrabajado.Text = "00:00:00"
                    TotalHorasExtras.Text = "00:00:00"
                    TotalHorasFestivas.Text = "00:00:00"


                    ' Crear un DataSet y llenar los datos
                    Dim MYDATA As New DataSet()

                    ' Extraer el año, mes y día de los DateTimePicker
                    Dim FI As String = TxtFechaInicial.Value.ToString("yyyy-MM-dd")
                    Dim FF As String = TxtFechaFinal.Value.ToString("yyyy-MM-dd")
                    Dim Cedula As String = Txtcedula.Text
                    Dim Ubicacion As String = Nothing


                    ' Crear y llenar un SqlDataAdapter con el procedimiento almacenado
                    Dim MYADAPTER As New SqlDataAdapter("GetDataHoras", myDB)
                    MYADAPTER.SelectCommand.CommandType = CommandType.StoredProcedure
                    MYADAPTER.SelectCommand.Parameters.AddWithValue("@FechaInicial", FI)
                    MYADAPTER.SelectCommand.Parameters.AddWithValue("@FechaFinal", FF)
                    MYADAPTER.SelectCommand.Parameters.AddWithValue("@Cedula", Cedula)
                    MYADAPTER.SelectCommand.Parameters.AddWithValue("@Ubicacion", If(Ubicacion Is Nothing, DBNull.Value, Ubicacion)) ' Asignar DBNull.Value si Ubicacion es Nothing



                    ' Llenar el DataSet con los resultados del procedimiento almacenado
                    MYADAPTER.Fill(MYDATA, "GetDataHoras")


                    Dim ocRep As New RpHoras()
                    ' Asignar el DataSet al informe
                    ocRep.SetDataSource(MYDATA)

                    ocRep.SetParameterValue("totalHorasPermisos", TotalTiempoPermisos.Text)
                    ocRep.SetParameterValue("totalHorasTrabajadas", TotalTiempoTrabajado.Text)
                    ocRep.SetParameterValue("totalHorasExtras", TotalHorasExtras.Text)
                    ocRep.SetParameterValue("totalHorasFestivas", TotalHorasFestivas.Text)


                    ' cargar informe en el visualizador
                    Me.CrystalReportViewer1.ReportSource = ocRep

                End Using

            Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End Try

        End If


    End Sub

    Private Sub BtnConsultaFechas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultaFechas.Click
        Try

            'Crear instancia conexion
            Using myDB = New SqlConnection


                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                TotalTiempoPermisos.Text = "00:00:00"
                TotalTiempoTrabajado.Text = "00:00:00"
                TotalHorasExtras.Text = "00:00:00"
                TotalHorasFestivas.Text = "00:00:00"

                ' Crear un DataSet y llenar los datos
                Dim MYDATA As New DataSet()

                ' Extraer el año, mes y día de los DateTimePicker
                Dim FI As String = TxtFechaInicial.Value.ToString("yyyy-MM-dd")
                Dim FF As String = TxtFechaFinal.Value.ToString("yyyy-MM-dd")
                Dim Cedula As String = Nothing
                Dim Ubicacion As String = Nothing

                ' Crear y llenar un SqlDataAdapter con el procedimiento almacenado
                Dim MYADAPTER As New SqlDataAdapter("GetDataHoras", myDB)
                MYADAPTER.SelectCommand.CommandType = CommandType.StoredProcedure
                MYADAPTER.SelectCommand.Parameters.AddWithValue("@FechaInicial", FI)
                MYADAPTER.SelectCommand.Parameters.AddWithValue("@FechaFinal", FF)
                MYADAPTER.SelectCommand.Parameters.AddWithValue("@Cedula", If(Cedula Is Nothing, DBNull.Value, Cedula))
                MYADAPTER.SelectCommand.Parameters.AddWithValue("@Ubicacion", If(Ubicacion Is Nothing, DBNull.Value, Ubicacion)) ' Asignar DBNull.Value si Ubicacion es Nothing

                ' Llenar el DataSet con los resultados del procedimiento almacenado
                MYADAPTER.Fill(MYDATA, "GetDataHoras")

                ' Crear un informe de Crystal Reports
                Dim ocRep As New RpHoras()

                ' Asignar el DataSet al informe
                ocRep.SetDataSource(MYDATA)

                ocRep.SetParameterValue("totalHorasPermisos", TotalTiempoPermisos.Text)
                ocRep.SetParameterValue("totalHorasTrabajadas", TotalTiempoTrabajado.Text)
                ocRep.SetParameterValue("totalHorasExtras", TotalHorasExtras.Text)
                ocRep.SetParameterValue("totalHorasFestivas", TotalHorasFestivas.Text)

                ' cargar informe en el visualizador
                Me.CrystalReportViewer1.ReportSource = ocRep

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub BtnConsultaTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultaTodo.Click

        If TxtUbicacion.Text = "" Then
            MessageBox.Show("Debe seleccionar una Ubicacion para consultar !!!", "Informacion", MessageBoxButtons.OK,
                                  MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else

            Try

                'Crear instancia conexion
                Using myDB = New SqlConnection


                    myDB.ConnectionString = ConexionHuellas.ToString
                    'llamar la funcion de las clase

                    If (myDB.State = ConnectionState.Closed) Then

                        myDB.Open()

                    End If

                    TotalTiempoPermisos.Text = "00:00:00"
                    TotalTiempoTrabajado.Text = "00:00:00"
                    TotalHorasExtras.Text = "00:00:00"
                    TotalHorasFestivas.Text = "00:00:00"

                    ' Crear un DataSet y llenar los datos
                    Dim MYDATA As New DataSet()

                    ' Extraer el año, mes y día de los DateTimePicker
                    Dim FI As String = TxtFechaInicial.Value.ToString("yyyy-MM-dd")
                    Dim FF As String = TxtFechaFinal.Value.ToString("yyyy-MM-dd")
                    Dim Cedula As String = Nothing
                    Dim Ubicacion As String = TxtUbicacion.Text

                    ' Crear y llenar un SqlDataAdapter con el procedimiento almacenado
                    Dim MYADAPTER As New SqlDataAdapter("GetDataHoras", myDB)
                    MYADAPTER.SelectCommand.CommandType = CommandType.StoredProcedure
                    MYADAPTER.SelectCommand.Parameters.AddWithValue("@FechaInicial", FI)
                    MYADAPTER.SelectCommand.Parameters.AddWithValue("@FechaFinal", FF)
                    MYADAPTER.SelectCommand.Parameters.AddWithValue("@Cedula", If(Cedula Is Nothing, DBNull.Value, Cedula))
                    MYADAPTER.SelectCommand.Parameters.AddWithValue("@Ubicacion", If(Ubicacion Is Nothing, DBNull.Value, Ubicacion)) ' Asignar DBNull.Value si Ubicacion es Nothing

                    ' Llenar el DataSet con los resultados del procedimiento almacenado
                    MYADAPTER.Fill(MYDATA, "GetDataHoras")

                    ' Crear un informe de Crystal Reports
                    Dim ocRep As New RpHoras()

                    ' Asignar el DataSet al informe
                    ocRep.SetDataSource(MYDATA)

                    ocRep.SetParameterValue("totalHorasPermisos", TotalTiempoPermisos.Text)
                    ocRep.SetParameterValue("totalHorasTrabajadas", TotalTiempoTrabajado.Text)
                    ocRep.SetParameterValue("totalHorasExtras", TotalHorasExtras.Text)
                    ocRep.SetParameterValue("totalHorasFestivas", TotalHorasFestivas.Text)

                    ' cargar informe en el visualizador
                    Me.CrystalReportViewer1.ReportSource = ocRep

                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                               MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End Try


        End If

    End Sub

    Private Sub TxtNombres_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNombres.SelectedIndexChanged
        Try

            'Crear instancia conexion
            Using myDB = New SqlConnection


                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                '*******selecciona el campo de cedula
                Dim sqlCommand2 As New SqlCommand
                sqlCommand2 = New SqlCommand()
                sqlCommand2.Connection = myDB
                sqlCommand2.CommandText = "SELECT Cedula FROM Registro where Nombre='" & TxtNombres.Text & "';"
                sqlCommand2.ExecuteNonQuery()
                MOSTRAR = sqlCommand2.ExecuteScalar
                Me.Txtcedula.Text = MOSTRAR
                '***********************************************
            End Using

        Catch ex As Exception
        MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub Txtcedula_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtcedula.LostFocus
        Try

            'Crear instancia conexion
            Using myDB = New SqlConnection


                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If
                Dim cmd As New SqlCommand
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

    Private Sub BtnVerHoras_Click(sender As Object, e As EventArgs) Handles BtnVerHoras.Click
        ConsultaHorasTotales.Show()
    End Sub

    Private Sub CopiaPermiso_Click(sender As Object, e As EventArgs) Handles CopiaPermiso.Click
        ' Obtén el texto del TextBox
        Dim textoParaCopiar As String = TotalTiempoPermisos.Text

        ' Copia el texto al portapapeles
        Clipboard.SetText(textoParaCopiar)

        ' Ahora puedes pegar el contenido en cualquier lugar (por ejemplo, en una aplicación como Excel o Word) usando Ctrl+V o la opción "Pegar".
        MessageBox.Show("Horas copiadas al portapapeles.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub CopiarTrabajado_Click(sender As Object, e As EventArgs) Handles CopiarTrabajado.Click
        ' Obtén el texto del TextBox
        Dim textoParaCopiar As String = TotalTiempoTrabajado.Text

        ' Copia el texto al portapapeles
        Clipboard.SetText(textoParaCopiar)

        ' Ahora puedes pegar el contenido en cualquier lugar (por ejemplo, en una aplicación como Excel o Word) usando Ctrl+V o la opción "Pegar".
        MessageBox.Show("Horas copiadas al portapapeles.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub CopiarExtras_Click(sender As Object, e As EventArgs) Handles CopiarExtras.Click
        ' Obtén el texto del TextBox
        Dim textoParaCopiar As String = TotalHorasExtras.Text

        ' Copia el texto al portapapeles
        Clipboard.SetText(textoParaCopiar)

        ' Ahora puedes pegar el contenido en cualquier lugar (por ejemplo, en una aplicación como Excel o Word) usando Ctrl+V o la opción "Pegar".
        MessageBox.Show("Horas copiadas al portapapeles.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub CopiarFestivas_Click(sender As Object, e As EventArgs) Handles CopiarFestivas.Click
        ' Obtén el texto del TextBox
        Dim textoParaCopiar As String = TotalHorasFestivas.Text

        ' Copia el texto al portapapeles
        Clipboard.SetText(textoParaCopiar)

        ' Ahora puedes pegar el contenido en cualquier lugar (por ejemplo, en una aplicación como Excel o Word) usando Ctrl+V o la opción "Pegar".
        MessageBox.Show("Horas copiadas al portapapeles.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Txtcedula.Enabled = True
            TxtNombres.Enabled = True
            TxtFechaFinal.Enabled = True
            TxtUbicacion.Enabled = False
            TxtFechaInicial.Enabled = True
            BtnConsultaCedula.Visible = True
            BtnConsultaFechas.Visible = False
            BtnConsultaTodo.Visible = False
            TotalHorasFestivas.Visible = False
            TotalTiempoTrabajado.Visible = False
            TotalHorasExtras.Visible = False
            LabelTotalExtra.Visible = False
            LabelTotalFestivas.Visible = False
            LabelTotalTrabajada.Visible = False
            TotalTiempoPermisos.Visible = False
            LabelTotalPermisos.Visible = False
            CopiaPermiso.Visible = False
            CopiarFestivas.Visible = False
            CopiarTrabajado.Visible = False
            CopiarExtras.Visible = False
            Txtcedula.Text = ""
            TxtUbicacion.Text = ""
            TxtFechaFinal.Text = Date.Now
            TxtFechaInicial.Text = Date.Now
            TxtNombres.Focus()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Txtcedula.Enabled = False
            TxtNombres.Enabled = False
            TxtFechaFinal.Enabled = True
            TxtFechaInicial.Enabled = True
            TxtUbicacion.Enabled = False
            BtnConsultaCedula.Visible = False
            BtnConsultaFechas.Visible = True
            BtnConsultaTodo.Visible = False
            TotalHorasFestivas.Visible = False
            TotalTiempoTrabajado.Visible = False
            TotalHorasExtras.Visible = False
            LabelTotalExtra.Visible = False
            LabelTotalFestivas.Visible = False
            LabelTotalTrabajada.Visible = False
            TotalTiempoPermisos.Visible = False
            LabelTotalPermisos.Visible = False
            CopiaPermiso.Visible = False
            CopiarFestivas.Visible = False
            CopiarTrabajado.Visible = False
            CopiarExtras.Visible = False
            Txtcedula.Text = ""
            TxtUbicacion.Text = ""
            TxtFechaFinal.Text = Date.Now
            TxtFechaInicial.Text = Date.Now
            TxtFechaInicial.Focus()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Txtcedula.Enabled = False
            TxtNombres.Enabled = False
            TxtFechaFinal.Enabled = True
            TxtFechaInicial.Enabled = True
            TxtUbicacion.Enabled = True
            BtnConsultaCedula.Visible = False
            BtnConsultaFechas.Visible = False
            BtnConsultaTodo.Visible = True
            TotalHorasFestivas.Visible = False
            TotalTiempoTrabajado.Visible = False
            TotalHorasExtras.Visible = False
            LabelTotalExtra.Visible = False
            LabelTotalFestivas.Visible = False
            LabelTotalTrabajada.Visible = False
            TotalTiempoPermisos.Visible = False
            LabelTotalPermisos.Visible = False
            CopiaPermiso.Visible = False
            CopiarFestivas.Visible = False
            CopiarTrabajado.Visible = False
            CopiarExtras.Visible = False
            Txtcedula.Text = ""
            TxtFechaFinal.Text = Date.Now
            TxtFechaInicial.Text = Date.Now
            BtnConsultaTodo.Focus()
        End If
    End Sub

End Class