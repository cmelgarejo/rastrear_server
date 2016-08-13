/** Servidor UDP - Basado en trabajos
 * OpenSource sobre TCP/IP y UDP
 * http://www.codeproject.com/KB/IP/CommLibrary.aspx
 * http://clutch-inc.com/blog/?p=4
 * http://www.clrsoft.net/
 **/

using System;
using System.Collections;
using System.Data;
using System.Net;
using System.Text;
using System.Threading;
using Npgsql;

namespace RASTREO_Lib
{
    public class RASTREO_UDPServer
    {
        private class QueueGPSData
        {
            // Crea un wrapper sincronizado alrededor de la cola de ACK's para los equipos GPS.

            private Queue SyncdQ = new Queue(); //Queue.Synchronized(new Queue());

            public void Enqueue(Object[] parsing_data)
            {
                SyncdQ.Enqueue(parsing_data);
            }

            public Object[] Dequeue()
            {
                return (Object[])(SyncdQ.Dequeue());
            }

            public int Count
            {
                get { return SyncdQ.Count; }
            }

            public object SyncRoot
            {
                get { return SyncdQ.SyncRoot; }
            }
        } // class QueueUDP, Provides a syncronized Queue for parsing UDP data.

        private class QueueUDPAnwser
        {
            // Crea un wrapper sincronizado alrededor de la cola de ACK's para los equipos GPS.

            private Queue SyncdQ = new Queue(); //Queue.Synchronized(new Queue());

            public void Enqueue(Object[] parsing_data)
            {
                SyncdQ.Enqueue(parsing_data);
            }

            public Object[] Dequeue()
            {
                return (Object[])(SyncdQ.Dequeue());
            }

            public int Count
            {
                get { return SyncdQ.Count; }
            }

            public object SyncRoot
            {
                get { return SyncdQ.SyncRoot; }
            }
        } // class QueueACKUDP, Provides a syncronized Queue for sending ACK UDP data.

        private class QueueCMDData
        {
            // Crea un wrapper sincronizado alrededor de la cola de comandos para equipos GPS.

            private Queue SyncdQ = new Queue(); //Queue.Synchronized(new Queue());

            public void Enqueue(EstructuraCMD ComandoGPS)
            {
                SyncdQ.Enqueue(ComandoGPS);
            }

            public EstructuraCMD Dequeue()
            {
                return (EstructuraCMD)(SyncdQ.Dequeue());
            }

            public int Count
            {
                get { return SyncdQ.Count; }
            }

            public object SyncRoot
            {
                get { return SyncdQ.SyncRoot; }
            }
        } // class QueueString, Provides a syncronized Queue of command for GPS equipment.

        private class QueueStringData
        {
            // Crea un wrapper sincronizado alrededor de la cola de comandos para equipos GPS.

            private Queue SyncdQ = new Queue(); //Queue.Synchronized(new Queue());

            public void Enqueue(string ComandoGPS)
            {
                SyncdQ.Enqueue(ComandoGPS);
            }

            public string Dequeue()
            {
                return (string)(SyncdQ.Dequeue());
            }

            public int Count
            {
                get { return SyncdQ.Count; }
            }

            public object SyncRoot
            {
                get { return SyncdQ.SyncRoot; }
            }
        } // class QueueString, Provides a syncronized Queue of command for GPS equipment.

        public class UDPServer : _UDPServer
        {
            private static DateTime startTime = DateTime.Now;

            //private int maxWorkThreads = 0, maxIOThreads = 0;
            private QueueGPSData queueUDPData;

            private QueueUDPAnwser queueAnwser;
            private QueueCMDData queueCMD;
            private QueueStringData queueIDEQUIPOS = new QueueStringData();
            //private QueueGPSData queueParaEnvioDeMails;

            private RASTREO_SQLThreads GPS_SQLthread;

            public RASTREO_SQLThreads myGPS_SQLThread
            {
                get { return GPS_SQLthread; }
            }

            private int _UDPPort = 0;

            public int Puerto
            {
                get { return _UDPPort; }
                set { _UDPPort = value; }
            }

            private string _IPresend = string.Empty;

            public string IPresend
            { get { return _IPresend; } set { _IPresend = value; } }

            private string _PORTresend = string.Empty;

            public string PORTResend
            { get { return _PORTresend; } set { _PORTresend = value; } }

            private bool _REsend = false;

            public bool REsend
            { get { return _REsend; } set { _REsend = value; } }

            private string _PROTOresend = string.Empty;

            public string PROTOresend
            { get { return _PROTOresend; } set { _PROTOresend = value; } }

            //private Thread threadSaveData;
            //private Thread threadSendAwnser;
            private Thread threadSendCMD;

            private Thread _threadSendCMD;

            public UDPServer(int _puerto)
                : base(_puerto)
            {
                try
                {
                    Puerto = _puerto;
                }
                catch (Exception Ex)
                {
                    Funciones_de_soporte.Manejador_de_Excepciones(Ex);
                }
            }

            override protected void PacketReceived(UDPPacketBuffer buffer)
            {
                //Console.WriteLine("Packet received!");
                // echo the packet back
                Object[] receivedData = new Object[2];
                StringBuilder szData = new StringBuilder();
                string receivedMsg = string.Empty;
                try
                {
                    if (buffer.Data != null)
                    {
                        //this.GPS_SQLthread.TotalRecibido += 1;
                        szData.Append(Encoding.Default.GetString(buffer.Data, 0, buffer.Data.Length));
                        receivedMsg = szData.ToString().Replace("\0", "").Replace("\r", "").Replace("\n", "").Replace("", "");
                        receivedData[0] = receivedMsg;
                        receivedData[1] = buffer.RemoteEndPoint;
                        //this.queueUDPData.Enqueue(receivedData);
                        //this.queueAnwser.Enqueue(receivedData);
                        sendAnwser(receivedMsg, buffer.RemoteEndPoint as IPEndPoint);
                        insertGPSData(receivedMsg, buffer.RemoteEndPoint as IPEndPoint);
                    }
                }
                catch (Exception EX) { Funciones_de_soporte.Manejador_de_Excepciones(EX); }
            }

            private void sendAnwser(string receivedMsg, IPEndPoint sendEP)
            {
                Byte[] awnser = null;
                try
                {
                    if (receivedMsg != null && sendEP != null)
                    {
                        if (receivedMsg.Contains("cmdsrv::"))
                        {
                            //cool code, bro
                            if (receivedMsg.Contains("cmdsrv::fuckyou"))
                            {
                                this.FuckYou();
                                this.StopListening();
                            }
                            if (receivedMsg.Contains("cmdsrv::close"))
                            {
                                this.StopListening();
                            }
                            else if (receivedMsg.Contains("cmdsrv::status"))
                            {
                                StringBuilder Mensaje =
                                    new StringBuilder("[STATUS: Start " + startTime.ToString() + "] Port[" + Puerto.ToString().PadLeft(4, '0') + "]" + getStatus() + "\r\n");
                                awnser = Encoding.ASCII.GetBytes(Mensaje.ToString());
                            }
                        }
                        else
                        {
                            awnser = RASTREO_SQLThreads.byte_GetACK(receivedMsg);
                        }
                        if (awnser != null)
                        {
                            UDPPacketBuffer UDPAnwser = new UDPPacketBuffer();
                            UDPAnwser.Data = awnser;
                            UDPAnwser.DataLength = awnser.Length;
                            UDPAnwser.RemoteEndPoint = (EndPoint)sendEP;
                            AsyncBeginSend(UDPAnwser);
                        }
                        Funciones_de_soporte.Mensaje_de_Log_PORT("UDP_" + this.Puerto.ToString(),
                                receivedMsg + "\t" + sendEP.ToString());
                    }
                }
                catch (Exception EX) { Funciones_de_soporte.Manejador_de_Excepciones(EX); }
            }

            private void insertGPSData(string data, IPEndPoint theIPep)
            {
                try
                {
                    if (data != null && theIPep != null)
                    {
                        EstructuraGPS theData = GPS_SQLthread.SaveGPSData(data, theIPep);
                        if (theData != null)
                        {
                            this.queueIDEQUIPOS.Enqueue(theData.IdEquipo + ":"
                                + theIPep.Address.ToString() + ":"
                                + theIPep.Port.ToString());
                        }
                    }
                }
                catch (Exception EXCEPTION) { Funciones_de_soporte.Manejador_de_Excepciones(EXCEPTION); }
            }

            //private void QueueAwnser()
            //{
            //    int wrk = 2;//, IO = 0;
            //    while (this.IsRunning)
            //    {
            //        try
            //        {
            //            lock (this.queueAnwser.SyncRoot)
            //            {
            //                if (this.queueAnwser.Count > 0)
            //                {
            //                    //ThreadPool.GetAvailableThreads(out wrk, out IO);
            //                    if (wrk > 1)//(maxWorkThreads - 90))
            //                    {
            //                        Object awnser = this.queueAnwser.Dequeue();
            //                        if (awnser != null)
            //                        {
            //                            ThreadPool.UnsafeQueueUserWorkItem(sendAnwser, awnser);
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //        catch (Exception EXCEPTION) { Funciones_de_soporte.Manejador_de_Excepciones(EXCEPTION); }
            //        Thread.Sleep(2);
            //    }
            //}

            //private void sendAnwser(Object _anwserData)
            //{
            //    string receivedMsg = null;
            //    IPEndPoint sendEP = null;
            //    Byte[] awnser = null;
            //    Object[] receivedData = (Object[])_anwserData;
            //    receivedMsg = (string)receivedData[0];
            //    sendEP = (IPEndPoint)receivedData[1];
            //    try
            //    {
            //        if (receivedMsg != null && sendEP != null)
            //        {
            //            if (receivedMsg.Contains("cmdsrv::"))
            //            {
            //                if (receivedMsg.Contains("cmdsrv::fuckyou"))
            //                {
            //                    this.FuckYou();
            //                    this.StopListening();
            //                }
            //                if (receivedMsg.Contains("cmdsrv::close"))
            //                {
            //                    this.StopListening();
            //                }
            //                else if (receivedMsg.Contains("cmdsrv::status"))
            //                {
            //                    StringBuilder Mensaje =
            //                        new StringBuilder("[STATUStart " + startTime.ToString() + "]Port[" + Puerto.ToString().PadLeft(4, '0') + "]" + getStatus() + "\r\n");
            //                    awnser = Encoding.ASCII.GetBytes(Mensaje.ToString());
            //                }
            //            }
            //            else
            //            {
            //                awnser = RASTREO_SQLThreads.byte_GetACK(receivedMsg);
            //            }
            //            if (awnser != null)
            //            {
            //                UDPPacketBuffer UDPAnwser = new UDPPacketBuffer();
            //                UDPAnwser.Data = awnser;
            //                UDPAnwser.DataLength = awnser.Length;
            //                UDPAnwser.RemoteEndPoint = (EndPoint)sendEP;
            //                AsyncBeginSend(UDPAnwser);
            //            }
            //            Funciones_de_soporte.Mensaje_de_Log_PORT("UDP_" + this.Puerto.ToString(),
            //                    receivedMsg + "\t" + sendEP.ToString());
            //        }
            //    }
            //    catch (Exception EX) { Funciones_de_soporte.Manejador_de_Excepciones(EX); }
            //}

            //private void QueueGPSData()
            //{
            //    int wrk = 2;//, IO = 0;
            //    try
            //    {
            //        while (this.IsRunning)
            //        {
            //            try
            //            {
            //                lock (this.queueUDPData.SyncRoot)
            //                {
            //                    if (this.queueUDPData.Count > 0)
            //                    {
            //                        //ThreadPool.GetAvailableThreads(out wrk, out IO);
            //                        if (wrk > 1)
            //                        {
            //                            Object queueData = this.queueUDPData.Dequeue();
            //                            if (queueData != null)
            //                            {
            //                                ThreadPool.UnsafeQueueUserWorkItem(insertGPSData, queueData);
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //            catch (Exception EXCEPTION) { Funciones_de_soporte.Manejador_de_Excepciones(EXCEPTION); }
            //            Thread.Sleep(2);
            //        }
            //    }
            //    catch (Exception EXCEPTION) { Funciones_de_soporte.Manejador_de_Excepciones(EXCEPTION); }
            //}

            //private void insertGPSData(Object _GPSData)
            //{
            //    try
            //    {
            //        Object[] queueData = (Object[])_GPSData;
            //        string data = (string)queueData[0]; // data entrante del cliente.
            //        IPEndPoint theIPep = (IPEndPoint)queueData[1]; // data entrante del cliente.
            //        if (data != null && theIPep != null)
            //        {
            //            EstructuraGPS theData = GPS_SQLthread.SaveGPSData(data, theIPep);
            //            if (theData != null)
            //            {
            //                this.queueIDEQUIPOS.Enqueue(theData.IdEquipo + ":"
            //                    + theIPep.Address.ToString() + ":"
            //                    + theIPep.Port.ToString());
            //            }
            //        }
            //    }
            //    catch (Exception EXCEPTION) { Funciones_de_soporte.Manejador_de_Excepciones(EXCEPTION); }
            //}

            public void QueueCMDEquipos_DataThread()
            {
                int wrk = 2;//, IO = 0;
                NpgsqlConnection pg_CNN = new NpgsqlConnection(Properties.Settings.Default.RS_ServerCNNSTR);
                try
                {
                    pg_CNN.Open();
                    while (this.IsRunning)
                    {
                        try
                        {
                            lock (this.queueIDEQUIPOS.SyncRoot)
                            {
                                if (this.queueIDEQUIPOS.Count > 0)
                                {
                                    //ThreadPool.GetAvailableThreads(out wrk, out IO);
                                    if (wrk > 1)//(maxWorkThreads - 90))
                                    {
                                        if (this.queueIDEQUIPOS != null)
                                        {
                                            string data = string.Empty;
                                            try
                                            {
                                                data = this.queueIDEQUIPOS.Dequeue();
                                            }
                                            catch (Exception)
                                            {
                                                data = string.Empty;
                                                continue;
                                            }

                                            if (data == null) continue;
                                            if (data == string.Empty) continue;

                                            string[] thisData = data.Split(':');
                                            string IdEquipo = thisData[0];
                                            int idequipogps = -1;
                                            EstructuraCMD CMD = null;

                                            string Select_Query =
                                                "SELECT * FROM rsview_equipogps_comandos WHERE id_equipo_gps = '" + IdEquipo + "' " +
                                                " AND enviado = FALSE";
                                            string Update_Query =
                                                "UPDATE rastreogps_cola_de_comandos SET enviado = TRUE" +
                                                " WHERE idequipogps = ";
                                            try
                                            {
                                                NpgsqlCommand pg_CMD = new NpgsqlCommand(Select_Query, pg_CNN);
                                                pg_CMD.CommandTimeout = 10; //timeout para q no joda tanto
                                                NpgsqlDataReader viewcmd_reader = pg_CMD.ExecuteReader();
                                                if (viewcmd_reader.HasRows)
                                                {
                                                    while (viewcmd_reader.Read())
                                                    {
                                                        if (idequipogps <= 0)
                                                            idequipogps = (int)viewcmd_reader["idrastreogps_equipogps"];
                                                        CMD = new EstructuraCMD();
                                                        CMD.Comando = (string)viewcmd_reader["comando"];
                                                        CMD.IdEquipo = (string)viewcmd_reader["id_equipo_gps"];
                                                        //string[] IpPort = Convert.ToString(viewcmd_reader["gps_ip"]).Split(':');
                                                        CMD.IP = thisData[1];
                                                        CMD.Puerto = thisData[2];
                                                        IPEndPoint dataIPEP = new IPEndPoint(IPAddress.Parse(CMD.IP), Int32.Parse(CMD.Puerto));
                                                        CMD.cmdEndPoint = dataIPEP;
                                                        this.queueCMD.Enqueue(CMD);
                                                    }
                                                    viewcmd_reader.Close();
                                                    if (idequipogps > -1)
                                                    {
                                                        NpgsqlCommand pgUPD_CMD =
                                                           new NpgsqlCommand(Update_Query + idequipogps.ToString(), pg_CNN);
                                                        pgUPD_CMD.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                            catch (Exception EX)
                                            {
                                                Funciones_de_soporte.Informaciones_del_sistema("Falla en QueueCMDEquipos_DataThread" +
                                                    Environment.NewLine + EX.ToString());
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception EX)
                        {
                            Funciones_de_soporte.Informaciones_del_sistema("Falla en QueueCMDEquipos_DataThread" +
                                Environment.NewLine + EX.ToString());
                        }
                        Thread.Sleep(2);
                    }
                }
                catch (Exception EX)
                {
                    Funciones_de_soporte.Informaciones_del_sistema("Falla en QueueCMDEquipos_DataThread" +
                        Environment.NewLine + EX.ToString());
                }
                finally
                {
                    if (pg_CNN.State != ConnectionState.Closed)
                        pg_CNN.Close();
                    pg_CNN.Dispose();
                    pg_CNN = null;
                }
            }

            public void QueueCMD_DataThread()
            {
                EstructuraCMD CMD = null;
                NpgsqlConnection pg_CNN = new NpgsqlConnection(Properties.Settings.Default.RS_ServerCNNSTR);
                string Select_Query =
                    "SELECT comando, id_equipo_gps, gps_ip FROM rsview_equipogps_comandos WHERE enviado = FALSE;";
                string Update_Query =
                    "UPDATE rastreogps_cola_de_comandos SET enviado = TRUE" +
                    " WHERE idequipogps IN (SELECT idequipogps FROM rsview_equipogps_comandos WHERE enviado = FALSE);";
                try
                {
                    if (pg_CNN.State != ConnectionState.Open)
                        pg_CNN.Open();
                    while (this.IsRunning)
                    {
                        try
                        {
                            NpgsqlCommand pg_CMD = new NpgsqlCommand(Select_Query, pg_CNN);
                            NpgsqlDataReader viewcmd_reader = pg_CMD.ExecuteReader();
                            if (viewcmd_reader.HasRows)
                            {
                                while (viewcmd_reader.Read())
                                {
                                    CMD = new EstructuraCMD();
                                    CMD.Comando = (string)viewcmd_reader["comando"];
                                    CMD.IdEquipo = (string)viewcmd_reader["id_equipo_gps"];
                                    string[] IPPORT = null;
                                    IPPORT = ((string)viewcmd_reader["gps_ip"]).Split(':');
                                    if (IPPORT.Length > 1)
                                    {
                                        CMD.IP = IPPORT[0];
                                        CMD.Puerto = IPPORT[1];
                                        CMD.cmdEndPoint =
                                            new IPEndPoint(IPAddress.Parse(CMD.IP), Int32.Parse(CMD.Puerto));
                                        this.queueCMD.Enqueue(CMD);
                                    }
                                }
                                viewcmd_reader.Close();
                                NpgsqlCommand pgUPD_CMD =
                                   new NpgsqlCommand(Update_Query, pg_CNN);
                                pgUPD_CMD.ExecuteNonQuery();
                                //pg_CNN = null;
                            }
                        }
                        catch (Exception EX)
                        {
                            Funciones_de_soporte.Informaciones_del_sistema("Falla en SHIT" +
                                Environment.NewLine + EX.ToString());
                            //if (pg_CNN.State != ConnectionState.Closed)
                            //    pg_CNN.Close();
                            //pg_CNN = null;
                        }
                        Thread.Sleep(2);
                    }
                }
                catch { }

                finally
                {
                    if (pg_CNN.State != ConnectionState.Closed)
                        pg_CNN.Close();
                    pg_CNN.Dispose();
                    pg_CNN = null;
                }
            }

            private void sendCMD()
            {
                //int wrk = 0, IO = 0;
                while (this.IsRunning)
                {
                    try
                    {
                        lock (this.queueCMD.SyncRoot)
                        {
                            if (this.queueCMD.Count > 0)
                            {
                                EstructuraCMD comando = this.queueCMD.Dequeue();
                                if (comando != null)
                                {
                                    UDPPacketBuffer sendCMD = new UDPPacketBuffer();
                                    sendCMD.Data = Encoding.ASCII.GetBytes(comando.Comando);
                                    sendCMD.DataLength = sendCMD.Data.Length;
                                    sendCMD.RemoteEndPoint = comando.cmdEndPoint;
                                    AsyncBeginSend(sendCMD);
                                }
                            }
                        }
                    }
                    catch (Exception EXCEPTION) { Funciones_de_soporte.Manejador_de_Excepciones(EXCEPTION); }
                    Thread.Sleep(10);
                }
            }

            override protected void PacketSent(UDPPacketBuffer buffer, int bytesSent)
            {
            }

            public void StartListening()
            {
                // Pool de conexiones UDP.
                try
                {
                    //ThreadPool.GetMaxThreads(out maxWorkThreads, out maxIOThreads);
                    this.queueUDPData = new QueueGPSData();
                    this.queueAnwser = new QueueUDPAnwser();
                    this.queueCMD = new QueueCMDData();
                    this.queueIDEQUIPOS = new QueueStringData();
                    GPS_SQLthread = new RASTREO_SQLThreads(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).TotalHours, Puerto);
                    if (IPresend != string.Empty && PORTResend != string.Empty)
                    {
                        GPS_SQLthread.Reenvio_activado = REsend;
                        GPS_SQLthread.IP_a_Reenviar = IPresend;
                        GPS_SQLthread.Puerto_para_reenvio = Convert.ToInt32(PORTResend);
                        GPS_SQLthread.Protocolo_a_reenviar = PROTOresend;
                    }
                    Funciones_de_soporte.Mensaje_de_Log_PORT("UDP_" + Puerto.ToString(), "Escucha de puerto UDP [" + Puerto + "] iniciada.");
                    this.Start();
                    //this.threadSaveData = new Thread(new ThreadStart(this.QueueGPSData));
                    //this.threadSaveData.Start();
                    //this.threadSendAwnser = new Thread(new ThreadStart(this.QueueAwnser));
                    //this.threadSendAwnser.Start();
                    this.threadSendCMD = new Thread(new ThreadStart(this.sendCMD));
                    this.threadSendCMD.Start();
                    this._threadSendCMD = new Thread(new ThreadStart(this.QueueCMDEquipos_DataThread));
                    this._threadSendCMD.Start();
                    // Iniciar la escucha para conexiones entrantes.
                }
                catch (Exception e)
                {
                    Funciones_de_soporte.Manejador_de_Excepciones(e);
                }
            }

            public void FuckYou()
            {
                string myDir = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                System.Diagnostics.Process.Start(myDir + "\\XYNTService.exe", "-u");
            }

            public void StopListening()
            {
                try
                {
                    if (this.IsRunning)
                    {
                        this.Stop();
                        //if (this.threadSendAwnser != null && this.threadSendAwnser.IsAlive)
                        //    this.threadSendAwnser.Join(1);
                        //if (this.threadSaveData != null && this.threadSaveData.IsAlive)
                        //    this.threadSaveData.Join(1);
                        if (this.threadSendCMD != null)
                            if (this.threadSendCMD.IsAlive)
                                this.threadSendCMD.Join(1);
                        if (this._threadSendCMD != null) if
                             (this._threadSendCMD.IsAlive)
                                this._threadSendCMD.Join(1);
                        GPS_SQLthread.DetenerSQLThreads();
                        Funciones_de_soporte.Mensaje_de_Log_PORT("UDP_" +
                                Puerto.ToString(), "Escucha de puerto UDP [" + Puerto + "] detenida.");
                        Funciones_de_soporte.Mensaje_de_Log_PORT("UDP_" +
                                Puerto.ToString(), "Total de paquetes recibidos en esta sesión [" +
                                GPS_SQLthread.TotalInsertado.ToString() + "].");
                    }
                }
                catch (Exception Ex) { Funciones_de_soporte.Manejador_de_Excepciones(Ex); }
                //finally { GC.Collect(); }
            }

            public string getStatus()
            {
                long count = 0; DateTime currentDT = DateTime.Now;
                NpgsqlConnection _cnn = new NpgsqlConnection(Properties.Settings.Default.RS_ServerCNNSTR);
                NpgsqlCommand _cmd =
                new NpgsqlCommand(
                "SELECT MAX(gps_fecha), (SELECT DISTINCT count(gps_fecha) FROM rsview_vehiculo_bandejaentrada_cliente_equipogps WHERE gps_fecha >= to_char(now(), 'dd/MM/yyyy HH24:mi')::timestamp) as count FROM rsview_vehiculo_bandejaentrada_cliente_equipogps LIMIT 1",
                _cnn);
                NpgsqlDataReader _rdr = null;
                try
                {
                    _cmd.CommandTimeout = 1;
                    _cmd.Connection.Open();
                    _rdr = _cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (_rdr.HasRows)
                    {
                        _rdr.Read();
                        count = _rdr.GetInt64(1);
                        currentDT = _rdr.GetDateTime(0);
                    }
                    return "Time[" + currentDT.ToString() + "] Count[" + count.ToString().PadLeft(4, '0') + "]";
                }
                catch (Exception X)
                {
                    Funciones_de_soporte.Manejador_de_Excepciones(X);
                    return "Time[" + currentDT.ToString() + "] Count[" + count.ToString().PadLeft(4, '0') + "]";
                }
                finally
                {
                    if (_rdr != null)
                    {
                        _rdr.Close();
                        _rdr.Dispose();
                    }
                    _cnn.Close();
                    _cnn.Dispose();
                    _cnn = null;
                }
            }

            public long getCount()
            {
                long count = 0;
                NpgsqlConnection _cnn = new NpgsqlConnection(Properties.Settings.Default.RS_ServerCNNSTR);
                NpgsqlCommand _cmd =
                new NpgsqlCommand(
                "SELECT MAX(gps_fecha), (SELECT DISTINCT count(gps_fecha) FROM rsview_vehiculo_bandejaentrada_cliente_equipogps WHERE gps_fecha >= to_char(now(), 'dd/MM/yyyy HH24:mi')::timestamp) as count FROM rsview_vehiculo_bandejaentrada_cliente_equipogps LIMIT 1",
                _cnn);
                NpgsqlDataReader _rdr = null;
                try
                {
                    _cmd.CommandTimeout = 1;
                    _cmd.Connection.Open();
                    _rdr = _cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    if (_rdr.HasRows)
                    {
                        _rdr.Read();
                        count = _rdr.GetInt64(1);
                    }
                    else
                        count = 0;
                    return count;
                }
                catch (Exception X)
                {
                    Funciones_de_soporte.Manejador_de_Excepciones(X);
                    return 0;
                }
                finally
                {
                    if (_rdr != null)
                    {
                        _rdr.Close();
                        _rdr.Dispose();
                    }
                    _cnn.Close();
                    _cnn.Dispose();
                    _cnn = null;
                }
            }
        }// class UDPServer
    }
}