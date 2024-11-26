Imports System.Data.SqlClient



Public Class Principal

    Dim myDB As SqlConnection
    Dim MYADAPTER As SqlDataReader
    Dim MOSTRARPERFIL As String
    Dim MOSTRARNOMBREUSUARIO As String
    Dim MYCOMANDO As SqlCommand

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsuario.Focus()

        OcultarSubMenu()
        BtnLogout.Visible = False
        LabelUsuario.Visible = False
        BtnMenuReportesPpl.Visible = False
        BtnMenuGestionPpl.Visible = False
        BtnMenuConfiguracionPpl.Visible = False
        PanelSubMenuReportes.Visible = False
        PanelSubMenuGestion.Visible = False
        PanelSubMenuConfiguracion.Visible = False
        PanelLogo.Size = New Size(350, 158)

    End Sub

    '******************Codificacion de Menu lateral*******************'

    Private Sub OcultarSubMenu()
        PanelSubMenuReportes.Visible = False
        PanelSubMenuGestion.Visible = False
        PanelSubMenuConfiguracion.Visible = False
    End Sub

    Private Sub MostrarSubMenu(submenu As Panel)

        If submenu.Visible = False Then
            OcultarSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub
    Private Sub BtnMenuReportesPpl_Click(sender As Object, e As EventArgs) Handles BtnMenuReportesPpl.Click
        MostrarSubMenu(PanelSubMenuReportes)
    End Sub

    Private Sub BtnMenuGestionPpl_Click(sender As Object, e As EventArgs) Handles BtnMenuGestionPpl.Click
        MostrarSubMenu(PanelSubMenuGestion)
    End Sub

    Private Sub BtnMenuConfiguracionPpl_Click(sender As Object, e As EventArgs) Handles BtnMenuConfiguracionPpl.Click
        MostrarSubMenu(PanelSubMenuConfiguracion)
    End Sub

    '----------------------fin menu-----------------------'

    '----------------------Permisos de Session Usuario----------------------------
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try

            'Crear instancia conexion
            Using myDB = New SqlConnection


                myDB.ConnectionString = ConexionHuellas.ToString
                'llamar la funcion de las clase

                If (myDB.State = ConnectionState.Closed) Then

                    myDB.Open()

                End If

                Dim ConsultarPerfil As String
                Dim ConsultaNombreUsuario As String

                Dim sqlCommand As New SqlCommand
                sqlCommand.Connection = myDB
                sqlCommand.CommandText = "SELECT Perfil FROM Perfiles where Usuario='" & TxtUsuario.Text & "' and Clave='" & TxtClave.Text & "';"
                sqlCommand.ExecuteNonQuery()
                MOSTRARPERFIL = sqlCommand.ExecuteScalar
                ConsultarPerfil = MOSTRARPERFIL

                sqlCommand.CommandText = "SELECT NombreUsuario FROM Perfiles where Usuario='" & TxtUsuario.Text & "' and Clave='" & TxtClave.Text & "';"
                sqlCommand.ExecuteNonQuery()
                MOSTRARNOMBREUSUARIO = sqlCommand.ExecuteScalar
                ConsultaNombreUsuario = MOSTRARNOMBREUSUARIO

                LabelUsuario.Text = "¡Bienvenido, " & ConsultaNombreUsuario & "!"
                LabelRol.Text = "Rol: " & ConsultarPerfil

                PanelLogo.Size = New Size(350, 237)

                '+++++++++++++++++++++++++++++++++++Permisos para el perfil Administrador++++++++++++++++++++++++++++
                If ConsultarPerfil = "Administrador" Then

                    PanelInicioSession.Visible = False

                    BtnLogout.Visible = True
                    BtnLogin.Visible = False
                    LabelUsuario.Visible = True
                    BtnMenuReportesPpl.Visible = True
                    BtnMenuGestionPpl.Visible = True
                    BtnMenuConfiguracionPpl.Visible = True

                    'permisos de ingreso a subMenus
                    BtnSubMenuReport1.Enabled = True
                    BtnSubMenuReport2.Enabled = True
                    BtnSubMenuReport3.Enabled = True
                    BtnSubMenuReport4.Enabled = True

                    BtnSubMenuGest1.Enabled = True
                    BtnSubMenuGest2.Enabled = True
                    BtnSubMenuGest3.Enabled = True
                    BtnSubMenuGest4.Enabled = True
                    BtnSubMenuGest5.Enabled = True
                    BtnSubMenuGest6.Enabled = True
                    BtnSubMenuGest7.Enabled = True
                    BtnSubMenuGest8.Enabled = True
                    BtnSubMenuGest9.Enabled = True
                    BtnSubMenuGest10.Enabled = True
                    BtnSubMenuGest11.Enabled = True

                    BtnSubMenuConfi1.Enabled = True
                    BtnSubMenuConfi2.Enabled = True
                    BtnSubMenuConfi3.Enabled = True
                    BtnSubMenuConfi4.Enabled = True
                    BtnSubMenuConfi5.Enabled = True


                    'Permisos para el perfil Gestion Humana
                ElseIf ConsultarPerfil = "Gestion Humana" Then
                    'Visualizacion general
                    PanelInicioSession.Visible = False

                    BtnLogout.Visible = True
                    BtnLogin.Visible = False
                    LabelUsuario.Visible = True
                    BtnMenuReportesPpl.Visible = True
                    BtnMenuGestionPpl.Visible = True
                    BtnMenuConfiguracionPpl.Visible = True

                    'permisos de ingreso a subMenus
                    BtnSubMenuReport1.Enabled = True
                    BtnSubMenuReport2.Enabled = True
                    BtnSubMenuReport3.Enabled = True
                    BtnSubMenuReport4.Enabled = True

                    BtnSubMenuGest1.Enabled = True
                    BtnSubMenuGest2.Enabled = True
                    BtnSubMenuGest3.Enabled = True
                    BtnSubMenuGest4.Enabled = True
                    BtnSubMenuGest5.Enabled = True
                    BtnSubMenuGest6.Enabled = True
                    BtnSubMenuGest7.Enabled = True
                    BtnSubMenuGest8.Enabled = True
                    BtnSubMenuGest9.Enabled = True
                    BtnSubMenuGest10.Enabled = True
                    BtnSubMenuGest11.Enabled = True

                    BtnSubMenuConfi1.Enabled = True
                    BtnSubMenuConfi2.Enabled = True
                    BtnSubMenuConfi3.Enabled = True
                    BtnSubMenuConfi4.Enabled = True
                    BtnSubMenuConfi5.Enabled = True

                    '++++++++++++++++++++++++++++++Permisos para el perfil Coor Comercial+++++++++++++++++++++++++++
                ElseIf ConsultarPerfil = "Coor Comercial" Then

                    'Visualizacion general
                    PanelInicioSession.Visible = False

                    BtnLogout.Visible = True
                    BtnLogin.Visible = False
                    LabelUsuario.Visible = True
                    BtnMenuReportesPpl.Visible = True
                    BtnMenuGestionPpl.Visible = True
                    BtnMenuConfiguracionPpl.Visible = True

                    'permisos de ingreso a subMenus NEGADOS
                    BtnSubMenuConfi1.Enabled = False
                    BtnSubMenuConfi2.Enabled = False
                    BtnSubMenuConfi3.Enabled = False
                    BtnSubMenuConfi4.Enabled = False
                    BtnSubMenuConfi5.Enabled = False

                    'permisos de ingreso a subMenus PERMITIDOS
                    BtnSubMenuReport1.Enabled = True
                    BtnSubMenuReport2.Enabled = True
                    BtnSubMenuReport3.Enabled = True
                    BtnSubMenuReport4.Enabled = True

                    BtnSubMenuGest1.Enabled = True
                    BtnSubMenuGest2.Enabled = True
                    BtnSubMenuGest3.Enabled = True
                    BtnSubMenuGest4.Enabled = True
                    BtnSubMenuGest5.Enabled = True
                    BtnSubMenuGest6.Enabled = True
                    BtnSubMenuGest7.Enabled = True
                    BtnSubMenuGest8.Enabled = True
                    BtnSubMenuGest9.Enabled = True
                    BtnSubMenuGest10.Enabled = True
                    BtnSubMenuGest11.Enabled = True


                    '++++++++++++++++++++++++++++++Permisos para el perfil Coor Talleres+++++++++++++++++++++++++++++
                ElseIf ConsultarPerfil = "Coor Talleres" Then

                    'Visualizacion general
                    PanelInicioSession.Visible = False

                    BtnLogout.Visible = True
                    BtnLogin.Visible = False
                    LabelUsuario.Visible = True
                    BtnMenuReportesPpl.Visible = True
                    BtnMenuGestionPpl.Visible = True
                    BtnMenuConfiguracionPpl.Visible = True

                    'permisos de ingreso a subMenus NEGADOS
                    BtnSubMenuGest3.Enabled = False
                    BtnSubMenuGest4.Enabled = False
                    BtnSubMenuGest7.Enabled = False
                    BtnSubMenuGest8.Enabled = False
                    BtnSubMenuGest9.Enabled = False
                    BtnSubMenuGest10.Enabled = False
                    BtnSubMenuGest11.Enabled = False

                    BtnSubMenuConfi1.Enabled = False
                    BtnSubMenuConfi2.Enabled = False
                    BtnSubMenuConfi3.Enabled = False
                    BtnSubMenuConfi4.Enabled = False
                    BtnSubMenuConfi5.Enabled = False

                    'permisos de ingreso a subMenus PERMITIDOS
                    BtnSubMenuReport1.Enabled = True
                    BtnSubMenuReport2.Enabled = True
                    BtnSubMenuReport3.Enabled = True
                    BtnSubMenuReport4.Enabled = True

                    BtnSubMenuGest1.Enabled = True
                    BtnSubMenuGest2.Enabled = True
                    BtnSubMenuGest5.Enabled = True
                    BtnSubMenuGest6.Enabled = True


                    '++++++++++++++++++++++++++++++Permisos para el perfil Taller Relojeria++++++++++++++++++++++++++
                ElseIf ConsultarPerfil = "Taller Relojeria" Then

                    'Visualizacion general
                    PanelInicioSession.Visible = False

                    BtnLogout.Visible = True
                    BtnLogin.Visible = False
                    LabelUsuario.Visible = True
                    BtnMenuReportesPpl.Visible = True
                    BtnMenuGestionPpl.Visible = True
                    BtnMenuConfiguracionPpl.Visible = True

                    'permisos de ingreso a subMenus NEGADOS
                    BtnSubMenuGest3.Enabled = False
                    BtnSubMenuGest4.Enabled = False
                    BtnSubMenuGest5.Enabled = False
                    BtnSubMenuGest6.Enabled = False
                    BtnSubMenuGest7.Enabled = False
                    BtnSubMenuGest8.Enabled = False
                    BtnSubMenuGest9.Enabled = False
                    BtnSubMenuGest10.Enabled = False
                    BtnSubMenuGest11.Enabled = False

                    BtnSubMenuConfi1.Enabled = False
                    BtnSubMenuConfi2.Enabled = False
                    BtnSubMenuConfi3.Enabled = False
                    BtnSubMenuConfi4.Enabled = False
                    BtnSubMenuConfi5.Enabled = False

                    'permisos de ingreso a subMenus PERMITIDOS
                    BtnSubMenuReport1.Enabled = True
                    BtnSubMenuReport2.Enabled = True
                    BtnSubMenuReport3.Enabled = True
                    BtnSubMenuReport4.Enabled = True

                    BtnSubMenuGest1.Enabled = True
                    BtnSubMenuGest2.Enabled = True


                    '++++++++++++++++++++++++++++++Permisos para el perfil Taller Joyeria+++++++++++++++++++++++++++
                ElseIf ConsultarPerfil = "Taller Joyeria" Then

                    'Visualizacion general
                    PanelInicioSession.Visible = False

                    BtnLogout.Visible = True
                    BtnLogin.Visible = False
                    LabelUsuario.Visible = True
                    BtnMenuReportesPpl.Visible = True
                    BtnMenuGestionPpl.Visible = True
                    BtnMenuConfiguracionPpl.Visible = True

                    'permisos de ingreso a subMenus NEGADOS
                    BtnSubMenuGest3.Enabled = False
                    BtnSubMenuGest4.Enabled = False
                    BtnSubMenuGest5.Enabled = False
                    BtnSubMenuGest6.Enabled = False
                    BtnSubMenuGest7.Enabled = False
                    BtnSubMenuGest8.Enabled = False
                    BtnSubMenuGest9.Enabled = False
                    BtnSubMenuGest10.Enabled = False
                    BtnSubMenuGest11.Enabled = False

                    BtnSubMenuConfi1.Enabled = False
                    BtnSubMenuConfi2.Enabled = False
                    BtnSubMenuConfi3.Enabled = False
                    BtnSubMenuConfi4.Enabled = False
                    BtnSubMenuConfi5.Enabled = False

                    'permisos de ingreso a subMenus PERMITIDOS
                    BtnSubMenuReport1.Enabled = True
                    BtnSubMenuReport2.Enabled = True
                    BtnSubMenuReport3.Enabled = True
                    BtnSubMenuReport4.Enabled = True

                    BtnSubMenuGest1.Enabled = True
                    BtnSubMenuGest2.Enabled = True


                    '++++++++++++++++++++++++++++++Permisos para el perfil Monitoreo++++++++++++++++++++++++++++++++
                ElseIf ConsultarPerfil = "Monitoreo" Then

                    'Visualizacion general
                    PanelInicioSession.Visible = False

                    BtnLogout.Visible = True
                    BtnLogin.Visible = False
                    LabelUsuario.Visible = True
                    BtnMenuReportesPpl.Visible = True
                    BtnMenuGestionPpl.Visible = True
                    BtnMenuConfiguracionPpl.Visible = True

                    'permisos de ingreso a subMenus NEGADOS
                    BtnSubMenuReport1.Enabled = False
                    BtnSubMenuReport2.Enabled = False
                    BtnSubMenuReport3.Enabled = False
                    BtnSubMenuReport4.Enabled = False

                    BtnSubMenuGest1.Enabled = False
                    BtnSubMenuGest3.Enabled = False
                    BtnSubMenuGest4.Enabled = False
                    BtnSubMenuGest5.Enabled = False
                    BtnSubMenuGest6.Enabled = False
                    BtnSubMenuGest7.Enabled = False
                    BtnSubMenuGest8.Enabled = False
                    BtnSubMenuGest9.Enabled = False
                    BtnSubMenuGest10.Enabled = False
                    BtnSubMenuGest11.Enabled = False

                    BtnSubMenuConfi1.Enabled = False
                    BtnSubMenuConfi2.Enabled = False
                    BtnSubMenuConfi3.Enabled = False
                    BtnSubMenuConfi4.Enabled = False
                    BtnSubMenuConfi5.Enabled = False

                    'permisos de ingreso a subMenus PERMITIDOS
                    BtnSubMenuGest2.Enabled = True


                    '************************no se usan por el momento************************

                    'Permisos para el perfil Mensajeria
                ElseIf ConsultarPerfil = "Mensajeria" Then


                Else
                    PanelLogo.Size = New Size(350, 158)

                    MessageBox.Show("El Usuario o Clave estan Errados favor verificar los datos!!!", "Informacion", MessageBoxButtons.OK,
                                              MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)


                    TxtUsuario.Text = ""
                    TxtClave.Text = ""
                    TxtUsuario.Focus()

                End If

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

    End Sub
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        PanelInicioSession.Visible = True
        BtnLogin.Visible = True
        BtnLogout.Visible = False
        LabelUsuario.Visible = False
        LabelRol.Visible = False
        BtnMenuReportesPpl.Visible = False
        BtnMenuGestionPpl.Visible = False
        BtnMenuConfiguracionPpl.Visible = False
        PanelSubMenuReportes.Visible = False
        PanelSubMenuGestion.Visible = False
        PanelSubMenuConfiguracion.Visible = False
        TxtUsuario.Text = ""
        TxtClave.Text = ""
        PanelLogo.Size = New Size(350, 158)

        'permisos de ingreso a subMenus
        BtnSubMenuReport1.Enabled = False
        BtnSubMenuReport2.Enabled = False
        BtnSubMenuReport3.Enabled = False
        BtnSubMenuReport4.Enabled = False

        BtnSubMenuGest1.Enabled = False
        BtnSubMenuGest2.Enabled = False
        BtnSubMenuGest3.Enabled = False
        BtnSubMenuGest4.Enabled = False
        BtnSubMenuGest5.Enabled = False
        BtnSubMenuGest6.Enabled = False
        BtnSubMenuGest7.Enabled = False
        BtnSubMenuGest8.Enabled = False
        BtnSubMenuGest9.Enabled = False
        BtnSubMenuGest10.Enabled = False

        BtnSubMenuConfi1.Enabled = False
        BtnSubMenuConfi2.Enabled = False
        BtnSubMenuConfi3.Enabled = False
        BtnSubMenuConfi4.Enabled = False
        BtnSubMenuConfi5.Enabled = False

        TxtUsuario.Focus()

    End Sub

    '----------------------fin permisos-----------------------'
    Private Sub BntMarcacionIngresolat_Click(sender As Object, e As EventArgs) Handles BntMarcacionIngresolat.Click
        BntMarcacionIngresolat.Enabled = False
        MarcacionIngreso.ShowDialog()
    End Sub

    Private Sub BtnMarcacionSalidalat_Click(sender As Object, e As EventArgs) Handles BtnMarcacionSalidalat.Click
        BtnMarcacionSalidalat.Enabled = False
        MarcacionSalida.ShowDialog()
    End Sub

    Private Sub BtnAlmuerzoIniciolat_Click(sender As Object, e As EventArgs) Handles BtnAlmuerzoIniciolat.Click
        BtnAlmuerzoIniciolat.Enabled = False
        MarcacionInicioAlmuerzo.ShowDialog()
    End Sub

    Private Sub BtnAlmuerzoFinlat_Click(sender As Object, e As EventArgs) Handles BtnAlmuerzoFinlat.Click
        BtnAlmuerzoFinlat.Enabled = False
        MarcacionFinAlmuerzo.ShowDialog()
    End Sub

    Private Sub BtnMarcaPermisolat_Click(sender As Object, e As EventArgs) Handles BtnMarcaPermisolat.Click
        BtnMarcaPermisolat.Enabled = False
        MarcacionPermisos.ShowDialog()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles BtnInfo.Click
        Acerca.Show()
    End Sub

    Private Sub BtnVacacioneslat_Click(sender As Object, e As EventArgs) Handles BtnVacacioneslat.Click
        CronogramaVacaciones.Show()
    End Sub

    'botones de sub menu reportes
    Private Sub BtnSubMenuReport1_Click(sender As Object, e As EventArgs) Handles BtnSubMenuReport1.Click
        ConsultaIngresosDiarios.Show()
    End Sub

    Private Sub BtnSubMenuReport2_Click(sender As Object, e As EventArgs) Handles BtnSubMenuReport2.Click
        ConsultaAlmuerzo.Show()
    End Sub

    Private Sub BtnSubMenuReport3_Click(sender As Object, e As EventArgs) Handles BtnSubMenuReport3.Click
        ConsultaPermisos.Show()
    End Sub

    Private Sub BtnSubMenuReport4_Click(sender As Object, e As EventArgs) Handles BtnSubMenuReport4.Click
        ConsultaLlegadasTarde.Show()
    End Sub


    'botones de sub menu Gestion
    Private Sub BtnSubMenuGest1_Click(sender As Object, e As EventArgs) Handles BtnSubMenuGest1.Click
        IngresoNovedades.Show()
    End Sub

    Private Sub BtnSubMenuGest2_Click(sender As Object, e As EventArgs) Handles BtnSubMenuGest2.Click
        UbicacionEmpleado.Show()
    End Sub

    Private Sub BtnSubMenuGest3_Click(sender As Object, e As EventArgs) Handles BtnSubMenuGest3.Click
        RegistroAlmuerzoManual.Show()
    End Sub

    Private Sub BtnSubMenuGest4_Click(sender As Object, e As EventArgs) Handles BtnSubMenuGest4.Click
        RegistroIngresosManuales.Show()
    End Sub

    Private Sub BtnSubMenuGest5_Click(sender As Object, e As EventArgs) Handles BtnSubMenuGest5.Click
        CambioHoraAlmuerzo.Show()
    End Sub

    Private Sub BtnSubMenuGest6_Click(sender As Object, e As EventArgs) Handles BtnSubMenuGest6.Click
        CambioHoraIngresoYSalida.Show()
    End Sub

    Private Sub BtnSubMenuGest7_Click(sender As Object, e As EventArgs) Handles BtnSubMenuGest7.Click
        MarcacionPermisosManual.Show()
    End Sub

    Private Sub BtnSubMenuGest8_Click(sender As Object, e As EventArgs) Handles BtnSubMenuGest8.Click
        MaestroNovedades.Show()
    End Sub

    Private Sub BtnSubMenuGest9_Click(sender As Object, e As EventArgs) Handles BtnSubMenuGest9.Click
        RegistroIngresosCapacitaciones.Show()
    End Sub

    Private Sub BtnSubMenuGest10_Click(sender As Object, e As EventArgs) Handles BtnSubMenuGest10.Click
        IngresoComentarios.Show()
    End Sub

    Private Sub BtnSubMenuGest11_Click(sender As Object, e As EventArgs) Handles BtnSubMenuGest11.Click
        IngresoVacaciones.Show()
    End Sub

    'botones de sub menu Configuracion
    Private Sub BtnSubMenuConfi1_Click(sender As Object, e As EventArgs) Handles BtnSubMenuConfi1.Click
        RegistroEmpleado.Show()
    End Sub

    Private Sub BtnSubMenuConfi2_Click(sender As Object, e As EventArgs) Handles BtnSubMenuConfi2.Click
        MaestroUbicaciones.Show()
    End Sub

    Private Sub BtnSubMenuConfi3_Click(sender As Object, e As EventArgs) Handles BtnSubMenuConfi3.Click
        Calendario.Show()
    End Sub

    Private Sub BtnSubMenuConfi4_Click(sender As Object, e As EventArgs) Handles BtnSubMenuConfi4.Click
        EliminacionEmpleado.Show()
    End Sub

    Private Sub BtnSubMenuConfi5_Click(sender As Object, e As EventArgs) Handles BtnSubMenuConfi5.Click
        GestionUsuarios.Show()
    End Sub


End Class
