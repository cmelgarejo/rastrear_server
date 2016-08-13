Imports RASTREO_Lib
Imports RASTREO_Lib.RASTREO_TCPServer
Imports RASTREO_Lib.RASTREO_UDPServer
Imports System.Threading
Imports System.Diagnostics
Imports System.Speech.Synthesis
Imports System.Text
Imports Npgsql
Imports System.Data
Imports System.ComponentModel

Public Class RASTREO_MainForm

    Dim wrk As Integer = 0
    Dim IO As Integer = 0

    Private gForcedInactivity As Boolean = False

    Private g_TITULO As String = String.Empty
    Private PuertosInactivos As Boolean = False
    Private program_running As Boolean = True
    Private ThreadSound As New Thread(AddressOf AsyncPlaySound)

    Private _CountPOPO As Integer = 0

    Private _TCPServers As New List(Of TCPServer)
    Private _UDPServers As New List(Of UDPServer)
    Private _TCPServerThreads As New List(Of Thread)
    Private _UDPServerThreads As New List(Of Thread)
    Private DirectorioLOGS As String = "\RASTREAR_SRV\PORT_LOGS\"
#Region "Rutinas de Threading para los puertos TCP y UDP"

    Private Function _StartServerTCP(ByVal _tcpSRV As Object) As Boolean
        DirectCast(_tcpSRV, TCPServer).StartListening()
    End Function
    Private Function _StartServerUDP(ByVal _udpSRV As Object) As Boolean
        DirectCast(_udpSRV, UDPServer).StartListening()
    End Function

    Private Function StartTCPServers() As Boolean
        TCPStartServers()
        TCPStartThreads()
    End Function
    Private Function TCPStartServers() As Boolean
        Try
            With My.Settings
                Dim _running As Boolean = False
                For Each svr As TCPServer In _TCPServers
                    If svr.Running Then
                        _running = True
                        Exit For
                    End If
                Next
                If Not _running Then
                    _TCPServers.Clear()
                    If .RS_Server_useTCP Then
                        For Each Puerto As String In .RS_PuertosTCP
                            If (threads_packetcountTCP(CInt(Puerto)) Is Nothing) Then
                                threads_packetcountTCP.Add(CInt(Puerto), 0)
                            End If
                            If My.Settings.RS_Server_reenvio Then
                                _TCPServers.Add(New TCPServer(Puerto, .RS_Server_IPReenvio, _
                                        .RS_Server_PortReenvio, .RS_Server_ProtocoloIP, CLng(threads_packetcountTCP(CInt(Puerto)))))
                            Else
                                _TCPServers.Add(New TCPServer(Puerto, CLng(threads_packetcountTCP(CInt(Puerto)))))
                            End If
                        Next
                    End If
                End If
            End With
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
        End Try
    End Function

    Private Function TCPStartThreads() As Boolean
        For Each Srv As TCPServer In _TCPServers
            If Not Srv.Running Then
                Dim myParamStart As New ParameterizedThreadStart(AddressOf _StartServerTCP)
                Dim myThreadWithParam As New Thread(myParamStart)
                myThreadWithParam.Start(Srv)
                _TCPServerThreads.Add(myThreadWithParam)
            End If
        Next
    End Function

    Private Function TCPStopServers() As Boolean
        Try
            For Each srv As TCPServer In _TCPServers
                srv.StopListening()
            Next
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
        End Try
    End Function
    Private Function TCPStopThreads() As Boolean
        Try
            For Each Hilo As Thread In _TCPServerThreads
                Hilo.Join(1)
                Hilo = Nothing
            Next
            _TCPServerThreads.Clear()
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
        End Try
    End Function
    Private Function StopTCPServers() As Boolean
        TCPStopServers()
        TCPStopThreads()
    End Function

    Private Function StartUDPServers() As Boolean
        UDPStartServers()
        UDPStartThreads()
    End Function
    Private Function UDPStartServers() As Boolean
        Try
            With My.Settings
                Dim _running As Boolean = False
                For Each svr As UDPServer In _UDPServers ''UDPSERVER!
                    If svr.IsRunning Then
                        _running = True
                        Exit For
                    End If
                Next
                If Not _running Then
                    _UDPServers.Clear()
                    If .RS_Server_useUDP Then
                        For Each Puerto As String In .RS_PuertosUDP
                            'Dim _UDP As UDPServer = New UDPServer(Convert.ToInt32(Puerto))
                            Dim server As UDPServer = New UDPServer(Convert.ToInt32(Puerto))
                            If My.Settings.RS_Server_reenvio Then
                                server.REsend = .RS_Server_reenvio
                                server.IPresend = .RS_Server_IPReenvio
                                server.PORTResend = .RS_Server_PortReenvio
                                server.PROTOresend = .RS_Server_ProtocoloIP
                            End If
                            '_UDP.StartListening()
                            _UDPServers.Add(server) ''UDPSERVER!
                        Next
                    End If
                End If
            End With
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
        End Try
    End Function
    Private Function UDPStartThreads() As Boolean
        For Each Srv As UDPServer In _UDPServers ''UDPSERVER!
            If Not Srv.IsRunning Then
                Dim myParamStart As New ParameterizedThreadStart(AddressOf _StartServerUDP)
                Dim myThreadWithParam As New Thread(myParamStart)
                myThreadWithParam.Start(Srv)
                _UDPServerThreads.Add(myThreadWithParam)
            End If
        Next
    End Function

    Private Function UDPStopServers() As Boolean
        Try
            For Each srv As UDPServer In _UDPServers ''UDPSERVER!
                srv.StopListening()
            Next
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
        End Try
    End Function
    Private Function UDPStopThreads() As Boolean
        Try
            For Each Hilo As Thread In _UDPServerThreads
                If Hilo.IsAlive Then
                    Hilo = Nothing
                End If
            Next
            _UDPServerThreads.Clear()
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
            '
        End Try
    End Function
    Private Function StopUDPServers() As Boolean
        UDPStopServers()
        UDPStopThreads()
    End Function

    Public Function StartServers() As Boolean
        lbINFO.Items.Add("Inicializando servidor [" & Now.ToString() & "]")
        StartServers = False
        StartTCPServers()
        StartUDPServers()
        Thread.Sleep(1)
        Timer_ChkStats.Enabled = True
        StartServers = True
        lbINFO.Items.Add("Server iniciado con éxito a las [" & Now.ToString() & "]")
        lbINFO.TopIndex = lbINFO.Items.Count - 1
    End Function

    Public Function StopServers() As Boolean
        lbINFO.Items.Add("Deteniendo server [" & Now.ToString() & "]")
        StopTCPServers()
        StopUDPServers()
        lbINFO.Items.Add("Server detenido con éxito a las [" & Now.ToString() & "]")
        lbINFO.TopIndex = lbINFO.Items.Count - 1
    End Function

#End Region

    Private Sub RASTREO_MainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            Funciones_de_soporte.Informaciones_del_sistema("Se ha cerrado la ventana del servidor a las " & Now.ToString())
            ThreadSound.Join(1)
        Catch AppEx As ApplicationException
            Funciones_de_soporte.Manejador_de_Excepciones(AppEx)
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
        End Try
    End Sub

    Private Sub RASTREO_MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Not gForcedInactivity Then
                If MessageBox.Show("Esta seguro de cerrar el programa? Perderá información de los GPS si lo hace.", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    gForcedInactivity = True
                Else
                    gForcedInactivity = False
                    e.Cancel = True
                    Funciones_de_soporte.Informaciones_del_sistema("Se ha intentado cerrar la ventana del servidor a las " & Now.ToString())
                End If
            End If

            If gForcedInactivity Then
                gForcedInactivity = True
                Funciones_de_soporte.Informaciones_del_sistema("Se esta intentado cerrar la ventana del servidor a las " & Now.ToString())
                lbUDP.Items.Clear()
                lbTCP.Items.Clear()
                lbTCP.Items.Add("Cerrando servidor...")
                lbUDP.Items.Add("Cerrando servidor...")
                Me.Refresh()
                program_running = False
                StopServers()
            End If

        Catch AppEx As ApplicationException
            Funciones_de_soporte.Manejador_de_Excepciones(AppEx)
        Catch Ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(Ex)
        End Try
    End Sub

    Dim appsrvMain As New appMain_AppSrv

    Private Sub RASTREO_MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'STARTPOPOTE()
            Control.CheckForIllegalCrossThreadCalls = False

            STARTPOPOTE()
            Button1.Enabled = False

            appsrvMain.Show(Me)

            RASTREOServerToolStripMenuItem.Text += " v" & My.Application.Info.Version.ToString() + " CMSoft(C) "
            nfIcon.BalloonTipTitle = RASTREOServerToolStripMenuItem.Text
            nfIcon.Text = RASTREOServerToolStripMenuItem.Text
            nfIcon.BalloonTipIcon = ToolTipIcon.Info
            nfIcon.BalloonTipText = "Iniciando servicio " & RASTREOServerToolStripMenuItem.Text
            nfIcon.ShowBalloonTip(5000)
            nfIcon.BalloonTipText = "Servicio " & RASTREOServerToolStripMenuItem.Text
            Me.Text = RASTREOServerToolStripMenuItem.Text
            g_TITULO = Me.Text
            btnStartServer.Enabled = False
            btnRestartServer.Enabled = True
            If My.Settings.g_InstaladoComoServicio Then
                InstalarComoServicio_ToolStripMenuItem.Text = "Desinstalar servicio"
            Else
                InstalarComoServicio_ToolStripMenuItem.Text = "Instalar como servicio"
            End If
            StartServers()
            'Me.ShowInTaskbar = False
            'Me.Visible = False
            Me.Top = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
            Me.Left = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            ThreadSound.Start()
        Catch Ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(Ex)
        End Try
    End Sub

    Private Sub btnStartServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartServer.Click
        Try
            gForcedInactivity = False
            btnStartServer.Enabled = False
            btnStopServer.Enabled = True
            btnRestartServer.Enabled = True
            StartServers()
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
        End Try
    End Sub

    Private Sub btnStopServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopServer.Click
        Try
            gForcedInactivity = True
            StopServers()
            btnStartServer.Enabled = True
            btnStopServer.Enabled = False
            btnRestartServer.Enabled = True
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
        End Try
    End Sub

    Private Sub AjustesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjustesToolStripMenuItem.Click
        Try
            If RASTREO_Settings.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Restart()
            End If
        Catch Ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(Ex)
        End Try
    End Sub

    Private Sub AjustesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjustesToolStripMenuItem1.Click
        Try
            If RASTREO_Settings.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Restart()
            End If
        Catch Ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(Ex)
        End Try
    End Sub

    Private sonido As String = ""

    Public Sub AsyncPlaySound()
        Try
            Dim Voz As New SpeechSynthesizer
            Voz.SelectVoice("Jorge")
            While program_running
                sonido = My.Settings.g_Mensajes_Eventos + sonido
                If Not String.IsNullOrEmpty(sonido) Then
                    If Not sonido.ToLower().Contains("geocerca") And Not sonido.ToLower().Contains("salida") And Not sonido.ToLower().Contains("entrada") Then
                        Voz.Speak(sonido)
                    End If
                End If
                Thread.Sleep(1000)
            End While
        Catch Ex As Exception
            'Funciones_de_soporte.Manejador_de_Excepciones(Ex)
        End Try
    End Sub

    Private Sub ConsolaDeDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsolaDeDatosToolStripMenuItem.Click
        If Not RASTREO_dataconsole.Visible Then
            RASTREO_dataconsole.Show(Me)
        Else
            RASTREO_dataconsole.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub nfIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles nfIcon.MouseDoubleClick
        Me.Visible = True
        Me.ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        Me.BringToFront()
        Me.Refresh()
    End Sub

    Private Sub VerArchivosDeLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerArchivosDeLogToolStripMenuItem.Click
        Process.Start("explorer", DirectorioLOGS)
    End Sub

    Private Sub MostrarVentanaPrincipalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarVentanaPrincipalToolStripMenuItem.Click
        Me.Visible = True
        Me.ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        Me.BringToFront()
        Me.Refresh()
    End Sub

    Private Sub VerArchivosDeLOGToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerArchivosDeLOGToolStripMenuItem1.Click
        Process.Start("explorer", DirectorioLOGS)
    End Sub

    Private Sub OcultarVentnaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OcultarVentnaToolStripMenuItem.Click
        Me.ShowInTaskbar = False
        Me.Visible = False
    End Sub

    Private Sub ReiniciarEscuchaDePuertosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReiniciarEscuchaDePuertosToolStripMenuItem.Click
        Try
            Restart()
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
            '
        End Try
    End Sub

    Private Sub btnRestartServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestartServer.Click
        Try
            Restart()
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
            '
        End Try
    End Sub

    Private Sub Restart()
        Try
            lbTCP.Items.Clear()
            lbTCP.Items.Add("Reiniciando escucha programada...")
            lbUDP.Items.Clear()
            lbUDP.Items.Add("Reiniciando escucha programada...")
            Me.Cursor = Cursors.WaitCursor
            btnStartServer.Enabled = False
            btnStopServer.Enabled = False
            PuertosInactivos = False
            gForcedInactivity = True
            StopServers()
            lbUDP.Items.Clear()
            lbTCP.Items.Clear()
            StartServers()
            btnStopServer.Enabled = True
            Me.Cursor = Cursors.Default
            gForcedInactivity = False
            btnStartServer.Enabled = False
            btnStopServer.Enabled = True
            btnRestartServer.Enabled = True
            STARTPOPOTE()
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
            '
        End Try
    End Sub

    Private Sub RestartTCPPorts()
        Try
            'lbTCP.Items.Clear()
            lbTCP.Items.Add("Reiniciando escucha TCP programada...")
            StopTCPServers()
            lbTCP.Items.Clear()
            StartTCPServers()
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
            '
        End Try
    End Sub

    Private Sub OcultarVentanaPrincipalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OcultarVentanaPrincipalToolStripMenuItem.Click
        Me.ShowInTaskbar = False
        Me.Visible = False
    End Sub

    Private Sub CerrarServidorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarServidorToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RASTREOServerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RASTREOServerToolStripMenuItem.Click
        Me.Visible = True
        Me.ShowInTaskbar = True
        Me.BringToFront()
        Me.Refresh()
    End Sub

    Private Sub ConsolaDeDatosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsolaDeDatosToolStripMenuItem1.Click
        RASTREO_dataconsole.Show(Me)
    End Sub

    Private Sub nfIcon_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles nfIcon.MouseMove
        'nfIcon.ShowBalloonTip(100)
    End Sub

    Private Sub rastrear_AppSrv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rastrear_AppSrv.Click
        'appMain_AppSrv.Show(Me)
    End Sub

    Private Sub InstalarComoServicio_ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstalarComoServicio_ToolStripMenuItem.Click
        CheckService()
    End Sub

    Private Sub CheckService()
        Dim mi_directorio As String = My.Computer.FileSystem.CurrentDirectory & "\"
        If Not My.Settings.g_InstaladoComoServicio Then
            InstalarComoServicio_ToolStripMenuItem.Text = "Desinstalar servicio"
            Process.Start(mi_directorio & "XYNTService.exe", "-i")
            My.Settings.g_InstaladoComoServicio = True
        Else
            InstalarComoServicio_ToolStripMenuItem.Text = "Instalar como servicio"
            Process.Start(mi_directorio & "XYNTService.exe", "-u")
            My.Settings.g_InstaladoComoServicio = False
        End If
        My.Settings.Save()
    End Sub

    ''' <summary>
    ''' Gets a list of all the Speech Synthesis voices installed on the computer.
    ''' </summary>
    ''' <returns>A string array of all the voices installed</returns>
    ''' <remarks>Make sure you have the System.Speech namespace reference added to your project</remarks>
    Function ReturnAllSpeechSynthesisVoices() As String()
        Dim oSpeech As New System.Speech.Synthesis.SpeechSynthesizer()
        Dim installedVoices As System.Collections.ObjectModel. _
                                ReadOnlyCollection(Of System.Speech.Synthesis.InstalledVoice) _
                                = oSpeech.GetInstalledVoices

        Dim names(installedVoices.Count - 1) As String
        For i As Integer = 0 To installedVoices.Count - 1
            names(i) = installedVoices(i).VoiceInfo.Name
        Next

        Return names
    End Function

    Private Sub AbrirDirectorioDelAppToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirDirectorioDelAppToolStripMenuItem.Click
        Process.Start("explorer", Application.LocalUserAppDataPath)
    End Sub

    Private Sub Timer_ChkStats_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_ChkStats.Tick
        Try
            Dim puertos As String = String.Empty

            tcpCOLA = 0
            For Each svr As TCPServer In _TCPServers
                If svr.myGPS_SQLThread Is Nothing Then
                    Continue For
                End If
                If Not svr.Running Or Not svr.myGPS_SQLThread.ColaActiva Then
                    puertos = My.Settings.g_Mensaje_Inactivos
                End If
                Dim ItemAnt As String = String.Empty
                Dim ItemAdd As String = _
                    "Puerto:" + svr.Puerto.ToString().Trim().PadLeft(5, Convert.ToChar("0")) + " - " + Convert.ToString(IIf(svr.Running And svr.myGPS_SQLThread.ColaActiva, "Activo", "Inactivo")) & _
                    " - En cola: " + svr.myGPS_SQLThread.Total_en_cola.ToString() & _
                    " - Paq. recibidos: " + svr.myGPS_SQLThread.TotalRecibido.ToString() & _
                    " - Insertados: " + svr.myGPS_SQLThread.TotalInsertado.ToString()

                'If (svr.myGPS_SQLThread.TotalInsertado > 0) Then
                tcpCOLA += svr.myGPS_SQLThread.Total_en_cola
                threads_packetcountTCP(svr.Puerto) = svr.myGPS_SQLThread.TotalInsertado
                'End If

                For Each itm As String In lbTCP.Items
                    If itm.Contains("Puerto:" + svr.Puerto.ToString().Trim().PadLeft(5, Convert.ToChar("0"))) Then
                        ItemAnt = itm
                        Exit For
                    End If
                Next
                If ItemAnt <> String.Empty Then
                    If Not ItemAnt = ItemAdd Then
                        lbTCP.Items.Item(lbTCP.Items.IndexOf(ItemAnt)) = ItemAdd
                    End If
                Else
                    lbTCP.Items.Add(ItemAdd)
                End If
            Next

            For Each svr In _UDPServers
                If svr.myGPS_SQLThread Is Nothing Then
                    Continue For
                End If
                If Not svr.IsRunning Or Not svr.myGPS_SQLThread.ColaActiva Then
                    puertos = My.Settings.g_Mensaje_Inactivos
                End If
                Dim ItemAnt As String = String.Empty
                Dim ItemAdd As String = _
                    "Puerto:" + svr.Puerto.ToString().Trim().PadLeft(5, Convert.ToChar("0")) + " - " + Convert.ToString(IIf(svr.IsRunning And svr.myGPS_SQLThread.ColaActiva, "Activo", "Inactivo")) & _
                    " - En cola: " + svr.myGPS_SQLThread.Total_en_cola.ToString() & _
                    " - Paq. recibidos: " + svr.myGPS_SQLThread.TotalRecibido.ToString() & _
                    " - Insertados: " + svr.myGPS_SQLThread.TotalInsertado.ToString()
                For Each itm As String In lbUDP.Items
                    If itm.Contains("Puerto:" + svr.Puerto.ToString().Trim().PadLeft(5, Convert.ToChar("0"))) Then
                        ItemAnt = itm
                        Exit For
                    End If
                Next
                If ItemAnt <> String.Empty Then
                    If Not ItemAnt = ItemAdd Then
                        lbUDP.Items.Item(lbUDP.Items.IndexOf(ItemAnt)) = ItemAdd
                    End If
                Else
                    lbUDP.Items.Add(ItemAdd)
                End If
            Next

            sonido = puertos

            If puertos = My.Settings.g_Mensaje_Inactivos And Not gForcedInactivity Then
                PuertosInactivos = True
                _CountPOPO += Timer_ChkStats.Interval
                If _CountPOPO > 15000 Then
                    _CountPOPO = 0
                    gForcedInactivity = True
                    Application.Exit()
                End If
            End If

            'If (Now.TimeOfDay >= Convert.ToDateTime("08:00").TimeOfDay And Now.TimeOfDay <= Convert.ToDateTime("18:00").TimeOfDay) Then
            '    throttledIniReinicioTCP = 1
            'Else
            '    throttledIniReinicioTCP = 1
            'End If

            If My.Settings.TCPPatch Then
                If (DateTime.Now.Subtract(dInicioGlobal).TotalMinutes > cerrarPrograma_Minutes) Then
                    gForcedInactivity = True
                    StopServers()
                    Thread.Sleep(5000)
                    Application.Exit(New System.ComponentModel.CancelEventArgs(False))
                    For Each p As Process In System.Diagnostics.Process.GetProcessesByName(NombreAplicacionEXE)
                        Try
                            p.Kill()
                            ' possibly with a timeout
                            p.WaitForExit(5000)
                            Application.Exit(New System.ComponentModel.CancelEventArgs(False))
                            ' process was terminating or can't be terminated - deal with it
                        Catch winException As Win32Exception
                            ' process has already exited - might be able to let this one go
                        Catch invalidException As InvalidOperationException
                        End Try
                    Next
                End If
                If (DateTime.Now.Subtract(dIniReinicioTCP).TotalMinutes > throttledIniReinicioTCP And tcpCOLA > 10) Then
                    RestartTCPPorts()
                    dIniReinicioTCP = DateTime.Now
                End If
            End If

        Catch Ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(Ex)
        End Try
    End Sub

    Dim threads_packetcountTCP As New Hashtable

    Dim dIniReinicioTCP As DateTime = DateTime.Now
    Dim dInicioGlobal As DateTime = DateTime.Now
    Dim tcpCOLA As Long = 0
    Dim throttledIniReinicioTCP As Integer = 3
    Dim cerrarPrograma_Minutes As Integer = 480
    Dim NombreAplicacionEXE As String = "RASTREAR2srv"

    Private Sub STARTPOPOTE()
        ThreadPool.UnsafeQueueUserWorkItem(AddressOf POPOTE, 0)
    End Sub

    Delegate Sub COLLBAK()
    Public Function POPOTE(ByVal popotito As Object) As COLLBAK
        MapMissingDirections()
        Return Nothing
    End Function

    Public Sub MapMissingDirections()
        Dim pg_Conn As NpgsqlConnection = New NpgsqlConnection(RASTREOmw.cnn_str.CadenaDeConexion)
        Dim pg_ConnUDP As NpgsqlConnection = New NpgsqlConnection(RASTREOmw.cnn_str.CadenaDeConexion)
        Try
            'Dim T As New RASTREOmw.reportesgps(RASTREOmw.cnn_str.CadenaDeConexion)
            Dim Avisos As New RASTREOmw.rastreogps_avisos(RASTREOmw.cnn_str.CadenaDeConexion)
            Dim i As Long = 0
            pg_ConnUDP.Open()
            pg_Conn.Open()

            While gForcedInactivity = False
                Dim tabla_reportesGPS As String = "reportesgps" + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString()
                Dim ID_reportesGPS As String = "idreportesgps" + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString()
                Dim Select_Query As String = "SELECT * FROM " + tabla_reportesGPS +
                                            " WHERE gps_dir IS NULL ORDER BY gps_fechahora_reporte DESC LIMIT 1000"
                Dim pg_SelectCMD As New NpgsqlCommand(Select_Query, pg_Conn)
                pg_SelectCMD.CommandTimeout = 120
                Dim pg_RDR As NpgsqlDataReader = pg_SelectCMD.ExecuteReader()
                If pg_RDR.HasRows Then
                    Dim start As DateTime = Now
                    lbSTATUS.Items.Clear()
                    lbSTATUS.SelectedIndex = lbSTATUS.Items.Add("Mapeando nuevas direcciones " & Now.ToString())
                    While pg_RDR.Read() And Not gForcedInactivity
                        Dim dir As String =
                            FuncionesUtiles.mapserver_ReverseGeocode(Convert.ToDouble(pg_RDR("gps_latitud")),
                                                                     Convert.ToDouble(pg_RDR("gps_longitud")))
                        If dir <> String.Empty Then
                            Dim Update_Query As String = "UPDATE " + tabla_reportesGPS + " SET gps_dir = '" +
                                dir.Replace("'", "") + "' WHERE " + ID_reportesGPS + " = " + pg_RDR(ID_reportesGPS).ToString()
                            Dim pg_UpdateCMD As New NpgsqlCommand(Update_Query, pg_ConnUDP)
                            pg_UpdateCMD.CommandTimeout = 120
                            Try
                                Dim pgqupd As Integer = pg_UpdateCMD.ExecuteNonQuery()
                            Catch X As Exception
                                Funciones_de_soporte.Informaciones_del_sistema(Update_Query)
                            End Try
                            i += 1
                            lbSTATUS.SelectedIndex = _
                                lbSTATUS.Items.Add("Direccion: " & dir & " - numero de iteracion: " & i.ToString())
                        End If
                        Thread.Sleep(1)
                    End While
                    Dim finish As DateTime = Now
                    lbSTATUS.SelectedIndex = lbSTATUS.Items.Add("Listo! " & i & " en total. [start] " & start.ToString("HH:mm:ss") & " || [finish] " & finish.ToString("HH:mm:ss"))
                End If
                pg_RDR.Close()
                Thread.Sleep(5000)
            End While
            Button1.Enabled = True
        Catch memex As InsufficientMemoryException
            Application.Exit()
        Catch x As Exception
            If x.Message.ToLowerInvariant().Contains("memoria") And x.Message.ToLowerInvariant().Contains("insuficiente") Then
                gForcedInactivity = True
                Thread.Sleep(1000)
                Application.Exit()
            End If
            Funciones_de_soporte.Manejador_de_Excepciones(x)
            Button1.Enabled = True
        Finally
            pg_Conn.Close()
            pg_ConnUDP.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        STARTPOPOTE()
        Button1.Enabled = False
    End Sub
End Class
