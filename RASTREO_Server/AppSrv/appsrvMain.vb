Imports Utilidades
Imports System.Threading
Imports System.Diagnostics
Imports System.Data
Imports System.Text
Imports System.Net
Imports System.IO
Imports MyGeneration.dOOdads
Imports RASTREOmw
Imports RASTREO_Lib
'Imports Npgsql
Imports System.Speech.Synthesis
Imports Npgsql

Public Class appMain_AppSrv

    Class QueueEnvioDeMails
        ' Crea un wrapper sincronizado alrededor de las cola de posiciones GPS.

        Private SyncdQ As New Queue()
        'Queue.Synchronized(new Queue());

        Public Sub Enqueue(ByVal Mail As String)
            SyncdQ.Enqueue(Mail)
        End Sub

        Public Function Dequeue() As String
            Return DirectCast((SyncdQ.Dequeue()), String)
        End Function

        Public ReadOnly Property Count() As Integer
            Get
                Return SyncdQ.Count
            End Get
        End Property

        Public ReadOnly Property SyncRoot() As Object
            Get
                Return SyncdQ.SyncRoot
            End Get
        End Property

    End Class
    ' class QueueEnvioDeMails, Provides a syncronized Queue for 'to be sent' mails to customers.

    Class QueueEnvioDeMails_mobilephone
        ' Crea un wrapper sincronizado alrededor de las cola de posiciones GPS.

        Private SyncdQ As New Queue()
        'Queue.Synchronized(new Queue());

        Public Sub Enqueue(ByVal Mail As String)
            SyncdQ.Enqueue(Mail)
        End Sub

        Public Function Dequeue() As String
            Return DirectCast((SyncdQ.Dequeue()), String)
        End Function

        Public ReadOnly Property Count() As Integer
            Get
                Return SyncdQ.Count
            End Get
        End Property

        Public ReadOnly Property SyncRoot() As Object
            Get
                Return SyncdQ.SyncRoot
            End Get
        End Property

    End Class
    ' class QueueEnvioDeMails_mobilephone, Provides a syncronized Queue for 'to be sent' mails to customers.

    '"SELECT DISTINCT ON (reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_fechahora_reporte) " & _
    '"	rastreogps_tipoevento.idrastreogps_tipo_evento as id_evento," & _
    '"	CASE " & _
    '"       WHEN rastreogps_equipo_eventos.evento IS NULL THEN " & _
    '"        rastreogps_tipoevento.descripcion " & _
    '"	    WHEN rastreogps_tipoevento.descripcion IS NULL THEN " & _
    '"        reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".Gps_evento " & _
    '"	    WHEN rastreogps_equipo_eventos.evento IS NOT NULL THEN" & _
    '"        rastreogps_equipo_eventos.evento " & _
    '"	END as evento," & _
    '"	rastreogps_tipoevento.color as color_evento," & _
    '"	rastreogps_equipo_eventos.habilitado as evento_habilitado," & _
    '"	reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".idreportesgps" + Now.Month.ToString() + Now.Year.ToString() & ", reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".id_equipogps, " & _
    '"	reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_longitud, reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_latitud, " & _
    '"	reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_fechahora_reporte, reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_velocidad," & _
    '"	reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo, " & _
    '"	CASE" & _
    '"	    WHEN (reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo >= 0   AND reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo <= 23 ) OR" & _
    '"		 (reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo >= 345 AND reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo <= 360) THEN " & _
    '"		('NORTE'::text)" & _
    '"	    WHEN reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo > 23 AND reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo <= 69 THEN " & _
    '"		('NORESTE'::text)" & _
    '"	    WHEN reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo > 69 AND reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo <= 115 THEN " & _
    '"	    ('ESTE'::text)" & _
    '"	    WHEN reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo > 115 AND reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo <= 161 THEN " & _
    '"	    ('SURESTE'::text)" & _
    '"	    WHEN reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo > 161 AND reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo <= 207 THEN " & _
    '"	    ('SUR'::text)" & _
    '"	    WHEN reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo > 207 AND reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo <= 253 THEN " & _
    '"	    ('SUROESTE'::text)" & _
    '"	    WHEN reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo > 253 AND reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo <= 299 THEN " & _
    '"	    ('OESTE'::text)	" & _
    '"	    WHEN reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo > 299 AND reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_rumbo <= 345 THEN " & _
    '"	    ('NOROESTE'::text)" & _
    '"	END as rumbo, " & _
    '"	reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_evento," & _
    '"	reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_edaddeldato, reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_hdop, " & _
    '"	reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_satstatus, reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_gsmstatus, " & _
    '"	reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_estado_io, reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_tipodeposicion, " & _
    '"	reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_ip, reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_obs," & _
    '"	reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_ip, reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".gps_dir," & _
    '"   rastreo_persona.idrastreo_persona AS idcliente, " & _
    '"   rastreo_vehiculo.identificador_rastreo, rastreo_vehiculo.idrastreo_vehiculo AS id_vehiculo, " & _
    '"   rastreo_vehiculo.consumo_aprox, " & _
    '"   rastreogps_equipogps.idrastreogps_equipogps AS idequipogps, " & _
    '"   rastreogps_tipoequipo.idrastreogps_tipoequipo AS id_tipoequipogps, rastreogps_tipoequipo.tipo_equipo AS tipoequipogps, " & _
    '"   rastreogps_equipogps.id_equipo_gps, " & _
    '"   rastreogps_equipogps.Nro_serie_gps" & _
    Private gSQLCOMMAND_REPORTES As String = _
                "SELECT gps_latitud, gps_longitud, rastreo_cliente.id_cliente, rastreo_persona.idrastreo_persona as id_persona, rastreo_vehiculo.idrastreo_vehiculo as id_vehiculo " & _
                "   FROM reportesgps" + Now.Month.ToString() + Now.Year.ToString() & _
                " LEFT JOIN rastreo_vehiculo 			ON reportesgps" + Now.Month.ToString() + Now.Year.ToString() & ".id_equipogps  = rastreo_vehiculo.id_equipogps " & _
                " LEFT JOIN rastreo_persona 			ON rastreo_vehiculo.id_cliente       = rastreo_persona.idrastreo_persona " & _
                " LEFT JOIN rastreo_cliente 			ON rastreo_vehiculo.id_cliente = rastreo_cliente.id_cliente "
    Private DirectorioLOGS As String = Application.StartupPath + "\PORT_LOGS\"
    Dim chkGEOwrk As Boolean = False
    Dim chkHDRwrk As Boolean = False
    Dim chkEVENTO As Boolean = False
    Dim sysRUNNING As Boolean = True
    Dim sendMails As QueueEnvioDeMails
    Dim sendMobileMails As QueueEnvioDeMails_mobilephone
    Private Shared continueQUEUE As Boolean = True
    Private THREAD_NUM As Integer = 4
    Private THREAD_NUM_SERVICIOS As Integer = 5
    Private ThreadSafeQUEUES() As Thread
    Private ThreadSafeSERVICIOS() As Thread
    Private ThreadCheckEventos As Thread
    Public Sub IniciarServiceThreads()
        ReDim ThreadSafeSERVICIOS(THREAD_NUM_SERVICIOS)
        chkGEOwrk = True
        chkHDRwrk = True
        chkEVENTO = True
        sysRUNNING = True
        ThreadCheckEventos = New Thread(New ThreadStart(AddressOf LoadGridEVENTOS))
        ThreadSafeSERVICIOS(0) = New Thread(New ThreadStart(AddressOf thread_wrkGEOCERCA))
        ThreadSafeSERVICIOS(1) = New Thread(New ThreadStart(AddressOf thread_wrkHOJADERUTA))
        'ThreadSafeSERVICIOS(2) = New Thread(New ThreadStart(AddressOf thread_wrkREPORTESAUTOMATICOS))
        ThreadCheckEventos.Start()
        For Each T As Thread In ThreadSafeSERVICIOS
            If T IsNot Nothing Then
                T.Start()
            End If
        Next
    End Sub

    Public Sub DetenerServiceThreads()
        chkGEOwrk = False
        chkHDRwrk = False

        If Not ThreadSafeSERVICIOS Is Nothing Then
            For i As Integer = 0 To Me.ThreadSafeSERVICIOS.Length - 1
                If Me.ThreadSafeSERVICIOS(i) IsNot Nothing AndAlso Me.ThreadSafeSERVICIOS(i).IsAlive Then
                    Me.ThreadSafeSERVICIOS(i).Join(10)
                End If
            Next
        End If

    End Sub

    Private Function thread_wrkGEOCERCA() As Boolean

        While chkGEOwrk
            Try
                Dim tblGeocercas As New rsview_cliente_vehiculo_equipogps_geocercas(RASTREOmw.cnn_str.CadenaDeConexion)
                With tblGeocercas
                    If .LoadAll() Then
                        Dim progreso As Integer = 0
                        While Not .EOF And chkGEOwrk
                            Dim mensajes As List(Of String) = CheckGeoFence(.Idrastreo_geocercas)
                            For Each msg In mensajes
                                Dim subject As String = _
                                        msg.Split(CChar("-"))(0) + " - Vehiculo: " + .Identificador_rastreo
                                For Each telmov As String In .Tel_movil.Split(CChar(";"))
                                    sendMobileMails.Enqueue(telmov + ";" + subject + ";" + msg)
                                Next
                                For Each mailTO As String In .Mails.Split(CChar(";"))
                                    sendMails.Enqueue(mailTO + ";" + subject + ";" + msg)
                                Next
                                '' IMPORTANTE!!!!!
                                '' Hay que insertar un evento a cada tipo de equipo eventoraw = "GC"
                                '' Y colocar en la descripcion ALERTA GEOCERCA o GEOCERCA
                                'SaveEvento(.Idrastreogps_equipogps, msg)
                                'MsgBox(msg, MsgBoxStyle.Information, subject)
                                Thread.Sleep(100)
                            Next
                            .MoveNext()
                            progreso += 1
                            Try
                                setText_lbGEOProgress(((progreso * 100) / .RowCount).ToString() & "%")
                            Catch ex As Exception

                            End Try
                            Thread.Sleep(10)
                        End While
                    End If
                End With
            Catch ex As ThreadAbortException

            Catch ex As Exception
                Funciones_de_soporte.Manejador_de_Excepciones(ex)
            End Try
            Dim total_sleep As Integer = My.Settings.g_EsperaSegundos
            Dim inc_Sleep As Integer = 1
            While chkGEOwrk And inc_Sleep <= total_sleep
                setText_lbGEOProgress("Proximo chequeo en " + ((total_sleep - inc_Sleep) \ 60).ToString("F0") + " minutos, " + ((total_sleep - inc_Sleep) Mod 60).ToString() + " segundos.")
                Thread.Sleep(1000)
                inc_Sleep += 1
            End While
            Thread.Sleep(10)
        End While
        Return chkGEOwrk
    End Function

    Delegate Function setText_lbGEOProgressCALLBACK(ByVal texto As String) As Boolean
    Private Function setText_lbGEOProgress(ByVal texto As String) As Boolean
        Try
            If lbGEOCProgress.InvokeRequired Then
                Dim callback As New setText_lbGEOProgressCALLBACK(AddressOf setText_lbGEOProgress)
                Invoke(callback, New Object() {texto})
            Else
                Me.lbGEOCProgress.Text = texto
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Function thread_wrkHOJADERUTA() As Boolean
        While chkHDRwrk
            Try
                Dim tblHojasDeRuta As New rastreo_hojaderuta_has_vehiculo(RASTREOmw.cnn_str.CadenaDeConexion)
                Dim Vehiculo As _
                    New rastreo_vehiculo(RASTREOmw.cnn_str.CadenaDeConexion)
                'Dim Personas As _
                '    New rastreo_persona(RASTREOmw.cnn_str.CadenaDeConexion)
                With tblHojasDeRuta
                    If .LoadAll() Then
                        Dim progreso As Integer = 0
                        While Not .EOF And chkHDRwrk
                            Dim mensaje As String = Check_HojaDeRuta(.Idhoja_de_ruta, .Id_cliente, .Id_vehiculo)
                            If Not String.IsNullOrEmpty(mensaje) Then
                                'Personas.LoadByPrimaryKey(.Id_cliente)
                                Vehiculo.LoadByPrimaryKey(.Id_vehiculo, .Id_cliente)
                                'If Personas.Email <> String.Empty And Vehiculo.Identificador_rastreo <> String.Empty Then
                                Dim subject As String = "Hoja de ruta: " + Vehiculo.Identificador_rastreo
                                Dim tblHOJADERUTA As New rastreo_hoja_de_ruta(RASTREOmw.cnn_str.CadenaDeConexion)
                                If tblHOJADERUTA.LoadByPrimaryKey(tblHojasDeRuta.Idhoja_de_ruta) Then
                                    For Each telmov As String In tblHOJADERUTA.Tel_movil.Split(CChar(";"))
                                        sendMobileMails.Enqueue(telmov + ";" + subject + ";" + mensaje)
                                        'MsgBox(telmov + " ; " + subject + " ; " + mensaje)
                                    Next
                                    For Each mailTO As String In tblHOJADERUTA.Mails.Split(CChar(";"))
                                        sendMails.Enqueue(mailTO + ";" + subject + ";" + mensaje)
                                        'MsgBox(mailTO + " ; " + subject + " ; " + mensaje)
                                    Next
                                    SaveEvento(Vehiculo.Id_equipogps, subject & " " & mensaje)
                                    'MsgBox(mensaje, MsgBoxStyle.Information, subject)
                                End If
                                'End If
                            End If
                            .MoveNext()
                            progreso += 1
                            Try
                                setText_lbHDRProgress(((progreso * 100) / .RowCount).ToString & "%")
                            Catch ex As Exception

                            End Try
                            Thread.Sleep(10)
                        End While
                    End If
                End With
            Catch ex As Exception
                Funciones_de_soporte.Manejador_de_Excepciones(ex)
            End Try
            Dim total_sleep As Integer = My.Settings.g_EsperaSegundos
            Dim inc_Sleep As Integer = 1
            While chkHDRwrk And inc_Sleep <= total_sleep
                setText_lbHDRProgress("Proximo chequeo en " + ((total_sleep - inc_Sleep) \ 60).ToString("F0") + " minutos, " + ((total_sleep - inc_Sleep) Mod 60).ToString() + " segundos.")
                inc_Sleep += 1
                Thread.Sleep(1000)
            End While
            Thread.Sleep(100)
        End While
        Return chkHDRwrk
    End Function
    Private Sub SaveEvento(ByVal id_equipogps As Integer, ByVal Evento As String)
        Dim revento As New rastreogps_avisos(RASTREOmw.cnn_str.CadenaDeConexion)
        Try
            With revento
                .AddNew()
                .Atendido = False
                .Evento = Evento
                .Evento_fechahora = Now()
                .Id_equipogps = id_equipogps
                .Save()
            End With
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
        End Try
    End Sub

    Delegate Function setText_lbHDRProgressCALLBACK(ByVal texto As String) As Boolean
    Private Function setText_lbHDRProgress(ByVal texto As String) As Boolean
        If lbHRDProgress.InvokeRequired Then
            Dim callback As New setText_lbHDRProgressCALLBACK(AddressOf setText_lbHDRProgress)
            Try
                Invoke(callback, New Object() {texto})
            Catch ex As Exception

            End Try
        Else
            Me.lbHRDProgress.Text = texto
        End If
    End Function

    Public Sub IniciarQueueThreads()
        ReDim ThreadSafeQUEUES(THREAD_NUM)
        sendMails = New QueueEnvioDeMails()
        sendMobileMails = New QueueEnvioDeMails_mobilephone()
        continueQUEUE = True
        Me.ThreadSafeQUEUES(0) = New Thread(New ThreadStart(AddressOf Me.ProcesarCola_Mails))
        Me.ThreadSafeQUEUES(1) = New Thread(New ThreadStart(AddressOf Me.ProcesarCola_Mails_to_mobile))
        For Each T As Thread In ThreadSafeQUEUES
            If T IsNot Nothing Then
                T.Start()
            End If
        Next
    End Sub

    Public Sub DetenerQueueThreads()
        continueQUEUE = False
        If Not ThreadSafeQUEUES Is Nothing Then
            For i As Integer = 0 To Me.ThreadSafeQUEUES.Length - 1
                If Me.ThreadSafeQUEUES(i) IsNot Nothing AndAlso Me.ThreadSafeQUEUES(i).IsAlive Then
                    Me.ThreadSafeQUEUES(i).Join(10)
                End If
            Next
        End If
    End Sub

    Private Sub ProcesarCola_Mails()
        While continueQUEUE
            Try
                SyncLock Me.sendMails.SyncRoot
                    If Me.sendMails.Count > 0 Then
                        Dim mail_to_send As String

                        mail_to_send = Me.sendMails.Dequeue()
                        'Total_en_Queue += 1
                        If mail_to_send.Split(CChar(";")).Length > 2 Then
                            Dim mailTO As String = mail_to_send.Split(CChar(";"))(0)
                            Dim subject As String = mail_to_send.Split(CChar(";"))(1)
                            Dim msg As String = mail_to_send.Split(CChar(";"))(2)
                            Dim filename_attch As String = String.Empty
                            If mail_to_send.Split(CChar(";")).Length > 3 Then
                                If mail_to_send.Split(CChar(";"))(3).Contains(".xls") And (Not mail_to_send.Split(CChar(";"))(3).Contains(" ")) Then
                                    filename_attch = mail_to_send.Split(CChar(";"))(3)
                                End If
                            End If
                            If Not String.IsNullOrEmpty(mailTO) Then
                                If filename_attch <> String.Empty Then
                                    Mail.SendMailTo(My.Settings.mailFROM, mailTO, subject, msg, filename_attch,
                                                My.Settings.mailSERVER, My.Settings.mailPORT,
                                                My.Settings.mailUSER, My.Settings.mailPASS, My.Settings.mailSSL)
                                    ' aca creo que envia el correo por mas que no hayan archivos adjuntos
                                Else
                                    Mail.SendMailTo(My.Settings.mailFROM, mailTO, subject, msg,
                                                    My.Settings.mailSERVER, My.Settings.mailPORT,
                                                    My.Settings.mailUSER, My.Settings.mailPASS, My.Settings.mailSSL)
                                End If
                            End If
                            'If Total_en_Queue > 0 Then
                            '    Total_en_Queue -= 1
                            'End If
                        End If
                    End If
                End SyncLock
            Catch tEX As System.Threading.ThreadAbortException

            Catch EX As Exception
                Funciones_de_soporte.Manejador_de_Excepciones(EX)
                'If Total_en_Queue > 0 Then
                '    Total_en_Queue -= 1
                'End If
            End Try
            Thread.Sleep(500)
        End While
    End Sub
    Private Sub ProcesarCola_Mails_to_mobile()
        While continueQUEUE
            Try
                SyncLock Me.sendMobileMails.SyncRoot
                    If Me.sendMobileMails.Count > 0 Then
                        Dim mail_to_send As String
                        mail_to_send = Me.sendMobileMails.Dequeue()
                        'Total_en_Queue += 1
                        If mail_to_send.Split(CChar(";")).Length > 2 Then
                            Dim mailTO As String = mail_to_send.Split(CChar(";"))(0)
                            Dim subject As String = mail_to_send.Split(CChar(";"))(1)
                            Dim msg As String = mail_to_send.Split(CChar(";"))(2)
                            If Not String.IsNullOrEmpty(mailTO) Then
                                Mail.SendMailToMovil(My.Settings.mailFROM, mailTO, subject, msg, _
                                                My.Settings.mailSERVER, My.Settings.mailPORT, _
                                                My.Settings.mailUSER, My.Settings.mailPASS, False)
                            End If
                            'If Total_en_Queue > 0 Then
                            '    Total_en_Queue -= 1
                            'End If
                        End If
                    End If
                End SyncLock
            Catch EX As Exception
                Funciones_de_soporte.Manejador_de_Excepciones(EX)
                'If Total_en_Queue > 0 Then
                '    Total_en_Queue -= 1
                'End If
                '    
            End Try
            Thread.Sleep(500)
        End While
    End Sub

    Private Function Check_HojaDeRutaMOCKUP(ByVal idhoja_de_ruta As Integer, ByVal idcliente As Integer, ByVal idvehiculo As Integer) As String
        Return String.Empty
    End Function


    ''' <summary>
    ''' Esta funcion retorna una lista de string que contiene la info
    ''' de el ultimo punto de hoja de ruta que tiene q llegar el vehiculo
    ''' Working!
    ''' </summary>
    ''' <param name="idcliente"></param>
    ''' <param name="idvehiculo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Check_HojaDeRuta(ByVal idhoja_de_ruta As Integer, ByVal idcliente As Integer, ByVal idvehiculo As Integer) As String
        Dim Punto_a_llegar As String = String.Empty
        Dim npgsql_CNN As New NpgsqlConnection(RASTREOmw.cnn_str.CadenaDeConexion)
        Dim npgsql_CMD As New Npgsql.NpgsqlCommand
        Try
            Dim tblHojaDeRuta As New rastreo_hoja_de_ruta(RASTREOmw.cnn_str.CadenaDeConexion)
            Dim puntos_de_ruta As New rastreo_hoja_de_ruta_puntos(RASTREOmw.cnn_str.CadenaDeConexion)
            Dim bandeja_de_entrada As New rsview_vehiculo_bandejaentrada_cliente_equipogps(RASTREOmw.cnn_str.CadenaDeConexion)
            Dim vehiculo_hora_Actual As DateTime
            Dim vehiculo_lon As Double
            Dim vehiculo_lat As Double
            Dim vehiculo_ID As String = String.Empty
            Dim vehiculo_idequipogps As Integer = 0
            With bandeja_de_entrada
                .Where.Id_vehiculo.Value = idvehiculo
                .Where.Id_cliente.Value = idcliente
                If .Query.Load() Then
                    vehiculo_hora_Actual = .Gps_fecha
                    vehiculo_lat = .Gps_latitud
                    vehiculo_lon = .Gps_longitud
                    'vehiculo_ID = .Identificador_rastreo
                    vehiculo_idequipogps = .Id_equipogps
                Else
                    Return String.Empty
                End If
            End With
            Dim nombre_ruta As String = String.Empty
            If tblHojaDeRuta.LoadByPrimaryKey(idhoja_de_ruta) Then
                If Not String.IsNullOrEmpty(tblHojaDeRuta.s_Hora_activacion) And _
                   Not String.IsNullOrEmpty(tblHojaDeRuta.s_Hora_desactivacion) Then
                    If tblHojaDeRuta.Hora_activacion <= CDate(Now.ToShortTimeString()) And _
                       tblHojaDeRuta.Hora_desactivacion >= CDate(Now.ToShortTimeString()) Then
                        nombre_ruta = tblHojaDeRuta.Descripcion
                        puntos_de_ruta.Where.Idhoja_de_ruta.Value = idhoja_de_ruta
                        puntos_de_ruta.Where.Hora_llegada.Operator = WhereParameter.Operand.LessThanOrEqual
                        puntos_de_ruta.Where.Hora_llegada.Value = _
                                CDate(Now.ToShortTimeString())
                        puntos_de_ruta.Query.AddOrderBy(rastreo_hoja_de_ruta_puntos.ColumnNames.Hora_llegada, _
                                                                                    WhereParameter.Dir.DESC)
                        puntos_de_ruta.Query.AddOrderBy(rastreo_hoja_de_ruta_puntos.ColumnNames.Orden, _
                                                        WhereParameter.Dir.ASC)
                        puntos_de_ruta.Query.Top = 1
                        If puntos_de_ruta.Query.Load() Then
                            While Not puntos_de_ruta.EOF
                                Dim distancia_del_punto As Double = 0
                                Dim llego As Boolean = False
                                Dim recorrido As NpgsqlDataReader
                                npgsql_CNN.Open()
                                npgsql_CMD = New NpgsqlCommand(gSQLCOMMAND_REPORTES & _
                                " WHERE rastreo_vehiculo.idrastreo_vehiculo = " & idvehiculo.ToString() & _
                                " AND rastreo_cliente.id_cliente = " & idcliente.ToString() & _
                                " AND gps_fechahora_reporte BETWEEN '" & _
                                Now.ToShortDateString() & " " & tblHojaDeRuta.Hora_activacion.ToString("HH:mm:ss") & "' AND '" & _
                                Now.ToShortDateString() & " " & tblHojaDeRuta.Hora_desactivacion.ToString("HH:mm:ss") & "';", npgsql_CNN)
                                recorrido = npgsql_CMD.ExecuteReader()
                                With recorrido
                                    '.Where.Id_vehiculo.Value = idvehiculo
                                    '.Where.Idcliente.Value = idcliente
                                    '.Where.Gps_fechahora_reporte.Operator = WhereParameter.Operand.Between
                                    '.Where.Gps_fechahora_reporte.BetweenBeginValue = _
                                    ' CDate( _
                                    ' Now.ToShortDateString() + " " + _
                                    ' tblHojaDeRuta.Hora_activacion.ToShortTimeString())
                                    '.Where.Gps_fechahora_reporte.BetweenEndValue = _
                                    ' CDate( _
                                    ' Now.ToShortDateString() + " " + _
                                    ' tblHojaDeRuta.Hora_desactivacion.ToShortTimeString())
                                    If .HasRows Then
                                        While .Read()
                                            distancia_del_punto = _
                                                Funciones_Utiles_GPS.Calcular_distancia_entre_dos_puntos_METROS( _
                                                                        puntos_de_ruta.Lat, puntos_de_ruta.Lon, _
                                                                        Convert.ToDouble(recorrido("gps_latitud")), _
                                                                        Convert.ToDouble(recorrido("gps_longitud")))
                                            If distancia_del_punto < 200 Then
                                                llego = True
                                                Exit While
                                            End If
                                        End While
                                    End If
                                End With
                                If Not llego Then
                                    If vehiculo_hora_Actual.TimeOfDay >= puntos_de_ruta.Hora_llegada.AddMinutes(puntos_de_ruta.Minutos_demora).TimeOfDay Then
                                        Dim dis As String = String.Empty
                                        distancia_del_punto = Funciones_Utiles_GPS.Calcular_distancia_entre_dos_puntos_METROS( _
                                                                    puntos_de_ruta.Lat, puntos_de_ruta.Lon, _
                                                                    vehiculo_lat, vehiculo_lon)
                                        If distancia_del_punto < 1000 Then
                                            dis = distancia_del_punto.ToString("F2") + " mts."
                                        Else
                                            dis = (distancia_del_punto / 1000).ToString("F2") + " kms."
                                        End If
                                        Punto_a_llegar = _
                                            "Se encuentra en " + FuncionesUtiles.mapserver_ReverseGeocode(vehiculo_lat, vehiculo_lon) + _
                                            " a " + dis + " del siguiente punto de " + vbCrLf + "Hoja de Ruta: " + nombre_ruta + vbCrLf + _
                                            "Punto: " + puntos_de_ruta.s_Nombre + vbCrLf + _
                                            "Orden: " + puntos_de_ruta.s_Orden + vbCrLf + _
                                            "Hora de Llegada: " + puntos_de_ruta.Hora_llegada.ToShortTimeString() + vbCrLf + _
                                            "Minutos de demora: " + puntos_de_ruta.s_Minutos_demora + vbCrLf
                                        'MsgBox(Punto_a_llegar)
                                    End If
                                End If
                                puntos_de_ruta.MoveNext()
                            End While
                        End If
                    End If
                End If
            End If
            Return Punto_a_llegar
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
            Return Punto_a_llegar
        Finally
            npgsql_CNN.Close()
            npgsql_CNN.Dispose()
            npgsql_CMD.Dispose()
            npgsql_CMD = Nothing
            npgsql_CNN = Nothing
            '
        End Try
    End Function

    ''' <summary>
    ''' Esta funcion retorna una lista de string que contiene el/los 
    ''' nombre(s) de la(s) geocerca(s) de la cual(es) se encuentra FUERA el vehiculo
    ''' Working!
    ''' </summary>
    ''' <param name="Idrastreo_geocercas">id de la geocerca a chequear</param>
    ''' <returns>Lista de integers</returns>
    ''' <remarks></remarks>
    Private Function CheckGeoFence(ByVal Idrastreo_geocercas As Integer) As List(Of String)
        Dim GeoLista As New List(Of String)
        Dim Vehiculos_con_Geocerca As New rsview_cliente_vehiculo_equipogps_geocercas(RASTREOmw.cnn_str.CadenaDeConexion)
        Dim BandejaEntrada As New rastreogps_bandeja_de_entrada(RASTREOmw.cnn_str.CadenaDeConexion)
        Try
            With Vehiculos_con_Geocerca
                .Where.Idrastreo_geocercas.Value = Idrastreo_geocercas
                '.Where.Idrastreo_vehiculo.Value = id_vehiculo
                '.Where.Geocerca_activa.Value = True
                If .Query.Load() Then
                    'If .s_Idrastreo_vehiculo <> String.Empty Then
                    While Not .EOF
                        'If .Geocerca_activa Then
                        If .s_Activo_siempre <> String.Empty Then
                            If .Activo_siempre Or .s_Hora_activacion <> String.Empty Or .s_Horas_activa <> String.Empty Or .s_Dia_activacion <> String.Empty Then
                                Dim mytimeOfDay As DateTime = DateTime.MinValue
                                If .s_Hora_activacion.Trim <> String.Empty Then
                                    Try
                                        mytimeOfDay = .Hora_activacion
                                    Catch ex As Exception
                                        Continue While
                                    End Try
                                End If
                                If (.s_Horas_activa = String.Empty) Then
                                    .Horas_activa = 1
                                End If
                                If (.s_Activo = String.Empty) Then
                                    .Activo = False
                                End If
                                If .Activo And ((Now.TimeOfDay >= mytimeOfDay.TimeOfDay And _
                                    Now.TimeOfDay <= mytimeOfDay.AddHours(.Horas_activa).TimeOfDay) Or _
                                    .Activo_siempre Or .s_Dia_activacion <> String.Empty) Then
                                    If .s_Dia_activacion <> String.Empty Then
                                        If Not .Dia_activacion.DayOfYear = Now.DayOfYear Then
                                            Return GeoLista
                                        End If
                                    End If
                                    BandejaEntrada.Where.Id_equipogps.Value = .Idrastreogps_equipogps
                                    If BandejaEntrada.Query.Load Then
                                        'Si el vehiculo esta fuera de la geocerca
                                        If .s_Avisos_activado = String.Empty Then
                                            .Avisos_activado = False
                                        End If
                                        If .s_Aviso_entradasalida = String.Empty Then
                                            .Aviso_entradasalida = False
                                        End If
                                        If .Puntos = String.Empty Then Continue While
                                        Try
                                            If Not Funciones_Utiles_GPS.Chequear_punto_en_geocerca(.Puntos, _
                                                    BandejaEntrada.Gps_latitud, BandejaEntrada.Gps_longitud) Then
                                                If Not .Avisos_activado Or .Aviso_entradasalida Then
                                                    GeoLista.Add("SALIDA " + .Descripcion + " - " + _
                                                                 FuncionesUtiles.mapserver_ReverseGeocode(BandejaEntrada.Gps_latitud, BandejaEntrada.Gps_longitud))
                                                    Dim GeoTbl As New rastreo_geocercas(RASTREOmw.cnn_str.CadenaDeConexion)
                                                    GeoTbl.LoadByPrimaryKey(.Idrastreo_geocercas)
                                                    GeoTbl.Avisos_activado = True
                                                    GeoTbl.Save()
                                                    GeoTbl = Nothing
                                                End If
                                                If .s_Avisar_entrada <> String.Empty Then
                                                    If .Avisar_entrada Then
                                                        If .s_Avisos_activado <> String.Empty Then
                                                            If .Avisos_activado Then
                                                                Dim GeoTbl As New rastreo_geocercas(RASTREOmw.cnn_str.CadenaDeConexion)
                                                                GeoTbl.LoadByPrimaryKey(.Idrastreo_geocercas)
                                                                GeoTbl.Avisos_activado = True
                                                                GeoTbl.Save()
                                                                GeoTbl = Nothing
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            Else
                                                If .s_Avisos_activado <> String.Empty Then
                                                    If .Avisos_activado Then
                                                        Dim GeoTbl As New rastreo_geocercas(RASTREOmw.cnn_str.CadenaDeConexion)
                                                        GeoTbl.LoadByPrimaryKey(.Idrastreo_geocercas)
                                                        GeoTbl.Avisos_activado = False
                                                        GeoTbl.Save()
                                                        GeoTbl = Nothing
                                                        If .s_Aviso_entradasalida <> String.Empty Then
                                                            If .Aviso_entradasalida Then
                                                                If .s_Avisar_entrada <> String.Empty Then
                                                                    If .Avisar_entrada Then
                                                                        GeoLista.Add("ENTRADA " + .Descripcion + " - " + _
                                                                             FuncionesUtiles.mapserver_ReverseGeocode(BandejaEntrada.Gps_latitud, BandejaEntrada.Gps_longitud))
                                                                        GeoTbl.Avisos_activado = True
                                                                        GeoTbl.Save()
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        Catch ex As Exception

                                        End Try
                                    End If
                                End If
                            End If
                        End If
                        .MoveNext()
                    End While
                    'End If
                End If
            End With
            Return GeoLista
        Catch ex As Exception
            'Funciones_de_soporte.Manejador_de_Excepciones(ex)
            Return GeoLista
        End Try
    End Function



    Delegate Function set_listEVENTO_DS_CALLBACK(ByVal datasource As Data.DataView) As Boolean
    Private Function set_listEVENTO_DS(ByVal datasource As Data.DataView) As Boolean
        If listEventos.InvokeRequired Then
            Dim callback As New set_listEVENTO_DS_CALLBACK(AddressOf set_listEVENTO_DS)
            Invoke(callback, New Object() {datasource})
        Else
            Me.listEventos.DataSource = datasource
        End If
    End Function
    Delegate Function set_listEVENTO_column_visible_CALLBACK(ByVal columnname As String, ByVal visible As Boolean) As Boolean
    Private Function set_listEVENTO_column_visible(ByVal columnname As String, ByVal visible As Boolean) As Boolean
        If listEventos.InvokeRequired Then
            Dim callback As New set_listEVENTO_column_visible_CALLBACK(AddressOf set_listEVENTO_column_visible)
            Invoke(callback, New Object() {columnname, visible})
        Else
            Me.listEventos.Columns(columnname).Visible = visible
        End If
    End Function
    Delegate Function set_listEVENTO_columnname_headertext_CALLBACK(ByVal columnname As String, ByVal headertext As String, ByVal autosize As Boolean) As Boolean
    Private Function set_listEVENTO_columnname_headertext(ByVal columnname As String, ByVal headertext As String, ByVal autosize As Boolean) As Boolean
        If listEventos.InvokeRequired Then
            Dim callback As New set_listEVENTO_columnname_headertext_CALLBACK(AddressOf set_listEVENTO_columnname_headertext)
            Invoke(callback, New Object() {columnname, headertext, autosize})
        Else
            Me.listEventos.Columns(columnname).HeaderText = headertext
            If autosize Then
                Me.listEventos.Columns(columnname).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End If
        End If
    End Function

    Private Sub LoadGridEVENTOS()
        Dim tblEVENTOS As New rsview_avisos_equipo_vehiculo_cliente(RASTREOmw.cnn_str.CadenaDeConexion)
        tblEVENTOS.Where.Atendido.Value = False
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Identificador_rastreo)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Evento_fechahora)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Evento)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Cliente)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Tel_part)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Tel_movil)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Tel_ofi)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Idrastreogps_avisos)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Sonoro)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Soundfile_sonoro_tipoevento)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Sendmail)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Sonoro_tipoevento)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Arch_sonido)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Atendido)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Clave_personal)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Color_evento)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Descripcion)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Email)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Estado_cliente)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_fechahora_reporte)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_latitud)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_longitud)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_rumbo)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_velocidad)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_dir)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Habilitado)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Id_equipo_gps)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Id_equipogps)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Id_persona)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Id_vehiculo)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Idrastreogps_tipo_evento)
        tblEVENTOS.Query.AddResultColumn(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Rumbo)
        While sysRUNNING
            Dim evento As String = String.Empty
            Try
                tblEVENTOS.Query.Load()
                Dim direccion As String = String.Empty

                If tblEVENTOS.RowCount > 0 Then
                    Dim tmpevento As String = String.Empty
                    For Each datyrow As DataRowView In tblEVENTOS.DefaultView
                        Try
                            'tmpevento = _
                            '    Convert.ToString(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Soundfile_sonoro_tipoevento)) & _
                            '    "&" & _
                            '    Convert.ToString(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Evento)).Split(Convert.ToChar(":"))(0) & _
                            '    " del vehiculo " & _
                            '    Convert.ToString(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Identificador_rastreo)) + Environment.NewLine
                            'If Not datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Sonoro) Is DBNull.Value Then
                            '    If Convert.ToBoolean(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Sonoro)) Then
                            '        Dim ThreadSound As New Thread(AddressOf AsyncPlaySound)
                            '        ThreadSound.Start(tmpevento)
                            '    End If
                            'End If

                            Try
                                If Convert.ToString(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_dir)) Is DBNull.Value Or Convert.ToString(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_dir)) = "" Then
                                    direccion = Utilidades.Funciones_Utiles_GPS.mapserver_ReverseGeocode(My.Settings.g_MapServerIP, My.Settings.g_MapServerPORT, Convert.ToDouble(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_latitud)), Convert.ToDouble(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_longitud)))
                                End If
                            Catch ex As Exception
                                direccion = "SIN DIRECCION"
                            End Try

                            datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_dir) = direccion
                        Catch ex As Exception
                            Funciones_de_soporte.Manejador_de_Excepciones(ex)
                        End Try

                        Try
                            If Not String.IsNullOrEmpty(Convert.ToString(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Sendmail))) Then
                                Dim colemail As String = Convert.ToString(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Sendmail))
                                colemail = colemail.Replace(",", ";").Trim()
                                Dim emails() As String = colemail.Split(Convert.ToChar(";"))
                                Dim mEvento As String


                                mEvento = _
                                    Convert.ToString(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Evento)).Split(Convert.ToChar(":"))(0) & _
                                    " del vehiculo " & _
                                    Convert.ToString(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Identificador_rastreo)) & Environment.NewLine & _
                                    "a las " & Convert.ToString(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_fechahora_reporte)) & _
                                    " en " & direccion & " a " & _
                                    Convert.ToString(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_velocidad)) & "Km./h."
                                For Each mailTO In emails
                                    Dim subject As String = "Aviso.RASTREAR: " & Convert.ToString(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Evento)).Split(Convert.ToChar(":"))(0) & _
                                        " - Movil: " & Convert.ToString(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Identificador_rastreo))
                                    sendMails.Enqueue(mailTO + ";" + subject + ";" + mEvento)
                                Next
                                Dim idrastreoaviso As Integer = Convert.ToInt32(datyrow(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Idrastreogps_avisos))
                                Dim tblEVENTOSEQUIPO As New rastreogps_avisos(RASTREOmw.cnn_str.CadenaDeConexion)
                                If tblEVENTOSEQUIPO.LoadByPrimaryKey(idrastreoaviso) Then
                                    tblEVENTOSEQUIPO.Atendido = True
                                    tblEVENTOSEQUIPO.Save()
                                End If
                            End If
                            If tmpevento.ToUpperInvariant().Contains("EXCESO") Then
                                'datyrow.Delete()
                            Else
                                evento += tmpevento
                            End If
                        Catch ex As Exception
                            Funciones_de_soporte.Manejador_de_Excepciones(ex)
                        End Try
                    Next
                    set_listEVENTO_DS(tblEVENTOS.DefaultView)
                    set_listEVENTO_columnname_headertext(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Identificador_rastreo, "Identificador", False)
                    set_listEVENTO_columnname_headertext(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Evento_fechahora, "Fecha y Hora", True)
                    set_listEVENTO_columnname_headertext(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Evento, "Evento", False)
                    set_listEVENTO_columnname_headertext(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_dir, "Direccion", False)
                    set_listEVENTO_columnname_headertext(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Cliente, "Cliente", False)
                    set_listEVENTO_columnname_headertext(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Tel_movil, "Movil", False)
                    set_listEVENTO_columnname_headertext(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Tel_part, "Tel. Part.", False)
                    set_listEVENTO_columnname_headertext(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Tel_ofi, "Tel. Oficina", False)
                    set_listEVENTO_column_visible( _
                                rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Sendmail, False)
                    set_listEVENTO_column_visible( _
                                rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Idrastreogps_avisos, False)
                    set_listEVENTO_column_visible( _
                                rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Sonoro, False)
                    set_listEVENTO_column_visible( _
                                rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Soundfile_sonoro_tipoevento, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Soundfile_sonoro_tipoevento, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Sonoro_tipoevento, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Arch_sonido, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Atendido, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Clave_personal, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Color_evento, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Descripcion, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Email, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Estado_cliente, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_fechahora_reporte, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_latitud, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_longitud, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_rumbo, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Gps_velocidad, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Habilitado, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Id_equipo_gps, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Id_equipogps, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Id_persona, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Id_vehiculo, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Idrastreogps_avisos, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Idrastreogps_tipo_evento, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Rumbo, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Sendmail, False)
                    set_listEVENTO_column_visible(rsview_avisos_equipo_vehiculo_cliente.ColumnNames.Sonoro, False)
                Else
                    set_listEVENTO_DS(Nothing)
                End If
                PlayEventos(evento)
            Catch ex As Exception
                'If Not ex.Message.ToLowerInvariant.Contains("subproceso anulado") Then
                ' Funciones_de_soporte.Manejador_de_Excepciones(ex)
                'End If
                'Finally
                '    
            End Try
            Thread.Sleep(10000)
        End While
    End Sub

    Public Sub PlayEventos(ByVal sound As Object)
        Try
            Dim mi_directorio As String = My.Computer.FileSystem.CurrentDirectory & "\"
            Dim sonidos() As String
            Dim Eventos As String = String.Empty
            sonidos = Convert.ToString(sound).Split(Convert.ToChar(vbCr))
            Try
                For Each sonidoevento In sonidos
                    If Not String.IsNullOrEmpty(sonidoevento) Then
                        Dim sonido As String() = Convert.ToString(sonidoevento).Split(Convert.ToChar("&"))
                        If Not Eventos.Contains(sonido(1)) Then
                            Eventos += sonido(1)
                        End If
                    End If
                Next
            Catch

            End Try
            ''Lol
            My.Settings.g_Mensajes_Eventos = Eventos
            'Dim Voz As New SpeechSynthesizer
            'Voz.SelectVoice("Jorge")
            'Voz.Speak(sonido(1).ToLowerInvariant())
            ''Lol
        Catch Ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(Ex)
        End Try
    End Sub

    Public Sub AsyncPlaySound(ByVal sound As Object)
        Try
            Dim mi_directorio As String = My.Computer.FileSystem.CurrentDirectory & "\"
            Dim sonido As String()
            sonido = Convert.ToString(sound).Split(Convert.ToChar("&"))
            Try
                If Not String.IsNullOrEmpty(sonido(0)) Then
                    My.Computer.Audio.Play(mi_directorio + sonido(0), AudioPlayMode.WaitToComplete)
                Else
                    'My.Computer.Audio.Play(mi_directorio + "panic.wav", AudioPlayMode.WaitToComplete)
                End If
            Catch
            End Try
            ''Lol
            'Dim Voz As New SpeechSynthesizer
            'Voz.SelectVoice("Jorge")
            'Voz.Speak(sonido(1).ToLowerInvariant())
            ''Lol
        Catch Ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(Ex)
        End Try
    End Sub

    Private Sub appMain_AppSrv_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            sysRUNNING = False
            Thread.Sleep(100)
            If ThreadCheckEventos.IsAlive Then
                ThreadCheckEventos.Join(1)
            End If
            Funciones_de_soporte.Informaciones_del_sistema("Se esta cerrando la ventana de aplicaciones a las " & Now.ToString())
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Hacer multi threads para que se ejecuten estas funciones.
    ''' re/pensar como corno para q funcione check_hojaderuta
    ''' bye
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub appMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Top = 0
        Me.Left = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        IniciarApp()
        'My.Settings.mail.SendMy.Settings.mailToMovil(My.Settings.mailFROM, "595981566234@tigo.com.py", "HOLA: FUCK", "FUUUUUUCK", My.Settings.mailSERVER, My.Settings.mailPORT, My.Settings.mailUSER, My.Settings.mailPASS, False)
    End Sub

    Private Sub appMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Funciones_de_soporte.Informaciones_del_sistema("Se ha cerrado la ventana de aplicaciones a las " & Now.ToString())
        DetenerApp()
    End Sub

    Private Sub btnIniciarServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciarServicio.Click
        IniciarApp()
    End Sub

    Private Sub btnStopService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopService.Click
        DetenerApp()
    End Sub

    Public Sub IniciarApp()
        'LoadGridEVENTOS()
        IniciarQueueThreads()
        IniciarServiceThreads()
        lbGEOCProgress.Text = "Iniciando..."
        lbHRDProgress.Text = "Iniciando..."
    End Sub

    Public Sub DetenerApp()
        DetenerQueueThreads()
        DetenerServiceThreads()
        lbGEOCProgress.Text = "Detenido."
        lbHRDProgress.Text = "Detenido."
    End Sub

    Private Sub ni_appTray_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ni_appTray.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ni_appTray_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ni_appTray.MouseDoubleClick
        'Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ni_appTray_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ni_appTray.MouseMove
        'ni_appTray.BalloonTipText = "Status del servicio:" + Environment.NewLine
        'ni_appTray.BalloonTipText += "Geocercas: " + lbGEOCProgress.Text + Environment.NewLine
        'ni_appTray.BalloonTipText += "Hojas de ruta: " + lbHRDProgress.Text + Environment.NewLine
        'ni_appTray.ShowBalloonTip(100)
    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpcionesToolStripMenuItem.Click
        Settings.ShowDialog(Me)
    End Sub

    Private Sub btnAtenderEVENTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtenderEvento.Click
        SetEVENTOff()
    End Sub

    Private Sub listEVENTOS_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles listEventos.CellDoubleClick
        SetEVENTOff()
        listEventos.Rows.RemoveAt(e.RowIndex)
    End Sub

    Private Sub SetEVENTOff()
        If listEventos.SelectedRows.Count > 0 Then
            Dim tblEVENTOS As New rastreogps_avisos(RASTREOmw.cnn_str.CadenaDeConexion)
            For Each selectedrow As DataGridViewRow In listEventos.SelectedRows
                If tblEVENTOS.LoadByPrimaryKey(Convert.ToInt32(selectedrow.Cells("Idrastreogps_avisos").Value)) Then
                    tblEVENTOS.Atendido = True
                    tblEVENTOS.Save()
                End If
            Next
        End If
    End Sub

    Private Sub btnApagarTodosLosEVENTOs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApagarTodosLosEvento.Click
        If listEventos.Rows.Count > 0 Then
            Dim tblEVENTOS As New rastreogps_avisos(RASTREOmw.cnn_str.CadenaDeConexion)
            Try
                'For Each selectedrow As DataGridViewRow In listEventos.SelectedRows
                tblEVENTOS.Where.Atendido.Value = False
                If tblEVENTOS.Query.Load() Then
                    While Not tblEVENTOS.EOF
                        tblEVENTOS.Atendido = True
                        tblEVENTOS.Save()
                        tblEVENTOS.MoveNext()
                    End While
                End If
                'Next
            Catch ex As Exception

            End Try
            'listEventos.Rows.Clear()
        End If
    End Sub

    Private Sub btnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfig.Click
        If Settings.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            DetenerApp()
            IniciarApp()
        End If
    End Sub

    Private Sub listEventos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles listEventos.CellContentClick

    End Sub

    Private Sub listEventos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles listEventos.DataError
        Funciones_de_soporte.Manejador_de_Excepciones(e.Exception)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Utilidades.Mail.SendMailTo("camb24@gmail.com", "LOL", "LOL")
        'MessageBox.Show(RASTREO_Lib.cnn_str.MailServer)
        'MessageBox.Show(RASTREO_Lib.cnn_str.MailPort)
        'MessageBox.Show(RASTREO_Lib.cnn_str.MailUser)
        'MessageBox.Show(RASTREO_Lib.cnn_str.MailPassword)
        'MessageBox.Show(RASTREO_Lib.cnn_str.MailFrom)
        'sendMails.Enqueue("camb24@gmail.com" + ";" + "Reporte automatico de mi PRUEBA!" + ";" + "ESPERO YA ME SALGA" + ";" + FuncionesUtiles.GetRecorridoDiario("2778"))
        'Dim client As Net.Mail.SmtpClient = New Net.Mail.SmtpClient("smtp.gmail.com", 587)
        'client.Credentials = New NetworkCredential("inforastreo@gmail.com", "inforastreo1341")
        'client.EnableSsl = True
        'client.Send("info@rastreo.com.py", "camb24@gmail.com", "test", "testbody")
        'MessageBox.Show("Sent")
    End Sub

    'Private Function thread_wrkREPORTESAUTOMATICOS() As Boolean
    '    While sysRUNNING
    '        Try
    '            Dim tblClientes As New rastreo_cliente(RASTREOmw.cnn_str.CadenaDeConexion)
    '            With tblClientes
    '                .Where.Reporte_automatico.Value = True
    '                .Where.Estado_cliente.Value = True
    '                If .Query.Load() Then
    '                    While Not .EOF
    '                        If .s_Ra_horaenvio <> String.Empty Then
    '                            If Now >= .Ra_horaenvio Then
    '                                Dim tblPersona As New rastreo_persona(RASTREOmw.cnn_str.CadenaDeConexion)
    '                                Dim tblVehiculos As New rastreo_vehiculo(RASTREOmw.cnn_str.CadenaDeConexion)
    '                                tblPersona.Where.Idrastreo_persona.Value = .Id_cliente
    '                                If tblPersona.Query.Load() Then
    '                                    tblVehiculos.Where.Id_cliente.Value = .Id_cliente
    '                                    tblVehiculos.Where.Activo_ra.Value = True
    '                                    tblVehiculos.Where.Activo.Value = True
    '                                    If tblVehiculos.Query.Load() Then
    '                                        While Not tblVehiculos.EOF
    '                                            Dim reporte_file As String = FuncionesUtiles.GetRecorridoDiario(tblVehiculos.Idrastreo_vehiculo.ToString())
    '                                            If File.Exists(reporte_file) Then
    '                                                For Each Mail As String In tblPersona.Email.Split()
    '                                                    sendMails.Enqueue(Mail + ";" + "Reporte automatico diario del vehiculo " & tblVehiculos.Identificador_rastreo + ";" + "Ver archivo adjunto" + ";" + reporte_file)
    '                                                Next Mail
    '                                            End If
    '                                            tblVehiculos.MoveNext()
    '                                        End While
    '                                    End If
    '                                End If
    '                                .Ra_horaenvio = DateTime.Now.AddDays(1).Date + .Ra_horaenvio.TimeOfDay
    '                                .Save()
    '                            End If
    '                        End If
    '                        .MoveNext()
    '                    End While
    '                End If
    '            End With
    '        Catch ex As Exception
    '            Funciones_de_soporte.Manejador_de_Excepciones(ex)
    '            Funciones_de_soporte.Informaciones_del_sistema(ex.ToString())
    '        End Try
    '        Thread.Sleep(1000)
    '    End While
    '    Return sysRUNNING
    'End Function

    Private Sub GruServicios_Enter(sender As System.Object, e As System.EventArgs) Handles GruServicios.Enter

    End Sub
End Class

