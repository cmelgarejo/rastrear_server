/**
 * Processing SQL Threading class
 * Author: Christian A. Melgarejo Bresanovich
 * Program: RASTREO System
 * Created: 09 Feb , 2009
**/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Text;
using System.Threading;

//using System.Windows.Forms;
//using RASTREOmw;
using Npgsql;
using Utilidades;

namespace RASTREO_Lib
{
    internal class Reenvio_de_Reporte
    {
        private EstructuraGPS _PosicionGPS;
        private IPEndPoint _Ip_y_puerto_a_enviar;
        private bool _tcp = false;
        private bool _udp = false;

        public bool enviarTCP
        {
            get { return _tcp; }
            set { _tcp = value; }
        }

        public bool enviarUDP
        {
            get { return _udp; }
            set { _udp = value; }
        }

        public IPEndPoint IPPORT
        {
            set { _Ip_y_puerto_a_enviar = value; }
            get { return _Ip_y_puerto_a_enviar; }
        }

        private string _reporte_a_enviar = string.Empty;

        public string Reporte_a_Enviar
        {
            set { _reporte_a_enviar = value; }
            get { return _reporte_a_enviar; }
        }

        /// <summary>
        /// Constructor de la clase de reenvio de reportes a una ip y puerto
        /// determinados, con su respectivo protocolo seteado.
        /// </summary>
        /// <param name="PosGPS">estructura que contiene la posicion gps a ser reenviada</param>
        /// <param name="Tipo_de_reporte">tipo de reporte que será reenviado,
        /// valores posibles: "RGP"</param>
        /// <param name="IP">ip a la que será reenvida la posición</param>
        /// <param name="PORT">puerto destino</param>
        /// <param name="Protocolo">protocolo ip, valores posibles: "TCP" y "UDP"</param>
        //public Reenvio_de_Reporte(EstructuraGPS PosGPS, string Tipo_de_reporte, string IP, int PORT, string Protocolo)
        //{
        //    try
        //    {
        //        _PosicionGPS = PosGPS;
        //        IPEndPoint IPPORT = new IPEndPoint(IPAddress.Parse(IP), PORT);
        //        _Ip_y_puerto_a_enviar = IPPORT;
        //        if (Protocolo.ToUpper().Contains("TCP"))
        //        { enviarTCP = true; }
        //        else if (Protocolo.ToUpper().Contains("UDP"))
        //        { enviarUDP = true; }
        //        if (Tipo_de_reporte.ToUpper().Contains("RGP"))
        //        {
        //            Reporte_a_Enviar = Transformar_a_RGP(false);
        //        }
        //        else
        //            Reporte_a_Enviar = _PosicionGPS.trama;
        //    }
        //    catch (Exception Ex)
        //    {
        //        Funciones_de_soporte.Manejador_de_Excepciones(Ex);
        //    }
        //}

        public Reenvio_de_Reporte(string gpsData, string Tipo_de_reporte, string IP, int PORT, string Protocolo)
        {
            try
            {
                _PosicionGPS = new EstructuraGPS();
                Reporte_a_Enviar = gpsData;
                IPEndPoint IPPORT = new IPEndPoint(IPAddress.Parse(IP), PORT);
                _Ip_y_puerto_a_enviar = IPPORT;
                if (Protocolo.ToUpper().Contains("TCP"))
                    enviarTCP = true;
                else if (Protocolo.ToUpper().Contains("UDP"))
                    enviarUDP = true;
            }
            catch (Exception Ex)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(Ex);
            }
        }

        ///// <summary>
        ///// RGP220800000621-3463425-05862602000053300FD0002
        ///// 220800   (DDMMAA) Fecha del momento en que se genera el reporte.
        ///// 000621   (HHMMSS) Hora (GMT) del momento que se genera el reporte.
        ///// -3463425 Latitud de la última posición valida con grados y decimales (ej : -34,63425°)
        ///// -05862602 Longitud de la última posición valida con grados y decimales (ej : -058,62602°)
        ///// 000   Velocidad en kilómetros por hora de la ultima posición valida (0 ..999).
        ///// 053  Orientación  de la ultima posición valida (0 ..359), Norte = 0, Este = 90, Sur = 180, Oeste = 270.
        ///// 3   Estado del posicionamiento del GPS  de la ultima posición valida
        /////     0 = Posicionando con solo 1 satélite.
        /////     1 = Posicionando con 2 satélites
        /////     2 = Posicionando con 3 satélites (2D).
        /////     3 = Posicionando con 4 o más satélites (3D).
        /////     4 = Posición en 2D calculada por aproximación de cuadrados mínimos.
        /////     5 = Posición en 3D calculada por aproximación de cuadrados mínimos.
        /////     6 = Posición calculada sin satélites, por velocidad, sentido y tiempo.
        /////     8 = Antena en corto circuito
        /////     9 = Antena no conectada
        ///// 00 Cantidad de segundos desde que se tomó la última posición, respecto al momento de generar el reporte.
        ///// (En Hexadecimal) .
        ///// FD Estado de las entradas digitales en Hexadecimal
        /////     bit 7 Ignición.
        /////     bit 6 Fuente de poder principal.
        /////     bit 5 Entrada digital 5
        /////     bit 4 Entrada digital 4
        /////     bit 3 Entrada digital 3.
        /////     bit 2 Entrada digital 2.
        /////     bit 1 Entrada digital 1.
        /////     bit 0 Entrada digital 0.
        ///// 00 Numero de evento generado expresado en decimal.
        ///// 02 Dilución horizontal de la precisión HDOP (0..50) de la ultima posición valida
        ///// Ej: >RGP070109030217-2529430-057561010001763009F2101;ID=3154;#00C7;*58<
        /////     >RGP180509145214-2531373-05757238000000300BF0000;ID=1157;#007C;*2B<\r\n /// TRAX TRANSFORMADO RN RGP
        ///// </summary>
        ///// <returns>posicion convertida a un reporte rgp con checksum incluido</returns>
        //public string Transformar_a_RGP(bool DoZH)
        //{
        //    try
        //    {
        //        string RGPString = ">RGP";
        //        if (DoZH)
        //        {
        //            double ZonaHoraria = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).TotalHours;
        //            _PosicionGPS.Fecha = _PosicionGPS.Fecha.AddHours(ZonaHoraria);
        //        }
        //        RGPString += _PosicionGPS.Fecha.ToString("ddMMyyHHmmss");
        //        string Latitud = _PosicionGPS.Latitud.ToString().Replace(".", string.Empty).Replace(",", string.Empty);
        //        if (_PosicionGPS.Latitud > 0 && _PosicionGPS.TipoReporte != "G381")
        //        {
        //            Latitud = "+" + Latitud;
        //        }
        //        else if (!Latitud.Contains("-"))
        //        {
        //            Latitud = "-" + Latitud;
        //        }
        //        if (Latitud.Length < 8)
        //        {
        //            while (Latitud.Length < 8)
        //            {
        //                Latitud += "0";
        //            }
        //        }
        //        else
        //        {
        //            Latitud = Latitud.Substring(0, 8);
        //        }
        //        RGPString += Latitud;
        //        string Longitud = _PosicionGPS.Longitud.ToString().Replace(".", string.Empty).Replace(",", string.Empty);
        //        string addFront = "+";
        //        if (_PosicionGPS.Longitud > 0 && _PosicionGPS.TipoReporte != "G381")
        //        {
        //            addFront = "+";
        //            if (Math.Abs(_PosicionGPS.Longitud) < 100)
        //            {
        //                addFront += "0";
        //            }
        //        }
        //        else
        //        {
        //            addFront = "-";
        //            if (Math.Abs(_PosicionGPS.Longitud) < 100)
        //            {
        //                addFront += "0";
        //            }
        //        }
        //        Longitud = addFront + Longitud.Replace("-", "");
        //        if (Longitud.Length < 9)
        //        {
        //            while (Longitud.Length < 9)
        //            {
        //                Longitud += "0";
        //            }
        //        }
        //        else
        //        {
        //            Longitud = Longitud.Substring(0, 9);
        //        }
        //        RGPString += Longitud;
        //        RGPString += _PosicionGPS.Velocidad.ToString("000");
        //        RGPString += _PosicionGPS.Rumbo.ToString("000");
        //        RGPString += _PosicionGPS.Status_SAT.ToString();
        //        RGPString += "00";// _PosicionGPS.EdadDelDato.Substring(0, 2);
        //        RGPString += _PosicionGPS.EstadoIO.Substring(0, 2).Replace("7F", "BF");//"FF";
        //        RGPString += "00";//_PosicionGPS.Evento.PadLeft(2, '0').Substring(0, 2);
        //        RGPString += "00";// _PosicionGPS.HDOP.ToString("00");
        //        RGPString += ";ID=" + _PosicionGPS.IdEquipo + ";";
        //        RGPString += "#00" + new Random().Next(0, 99).ToString("00") + ";";
        //        RGPString += "*" + GPS_Class.GetCheckSum(RGPString) + "<\r\n";
        //        return RGPString;
        //    }
        //    catch (Exception Ex)
        //    {
        //        Funciones_de_soporte.Manejador_de_Excepciones(Ex);
        //        return string.Empty;
        //    }
        //}
    }

    internal class QueueEnvioExcesoVelocidad
    {
        // Crea un wrapper sincronizado alrededor de la cola de ACK's para los equipos GPS.

        private Queue SyncdQ = new Queue(); //Queue.Synchronized(new Queue());

        public void Enqueue(EstructuraGPS miPos)
        {
            SyncdQ.Enqueue(miPos);
        }

        public EstructuraGPS Dequeue()
        {
            return (EstructuraGPS)(SyncdQ.Dequeue());
        }

        public int Count
        {
            get { return SyncdQ.Count; }
        }

        public object SyncRoot
        {
            get { return SyncdQ.SyncRoot; }
        }
    } // class QueueEnvioACK, Provides a syncronized Queue Array for send a ACK to a GPS hardware.

    internal class QueueEnvioACK
    {
        // Crea un wrapper sincronizado alrededor de la cola de ACK's para los equipos GPS.

        private Queue SyncdQ = new Queue(); //Queue.Synchronized(new Queue());

        public void Enqueue(EstructuraGPS ACK)
        {
            SyncdQ.Enqueue(ACK);
        }

        public EstructuraGPS Dequeue()
        {
            return (EstructuraGPS)(SyncdQ.Dequeue());
        }

        public long Count
        {
            get { return SyncdQ.Count; }
        }

        public object SyncRoot
        {
            get { return SyncdQ.SyncRoot; }
        }
    } // class QueueEnvioACK, Provides a syncronized Queue Array for send a ACK to a GPS hardware.

    internal class QueueReenvioPosiciones
    {
        // Crea un wrapper sincronizado alrededor de la cola de re-posiciones GPS.

        private Queue SyncdQ = new Queue(); //Queue.Synchronized(new Queue());

        public void Enqueue(Reenvio_de_Reporte PosicionGPS)
        {
            SyncdQ.Enqueue(PosicionGPS);
        }

        public Reenvio_de_Reporte Dequeue()
        {
            return (Reenvio_de_Reporte)(SyncdQ.Dequeue());
        }

        public long Count
        {
            get { return SyncdQ.Count; }
        }

        public object SyncRoot
        {
            get { return SyncdQ.SyncRoot; }
        }
    } // class QueueReenvioPosiciones, Provides a syncronized Queue Array for re-send a GPS Position Array.

    internal class QueuePosicionesGPS
    {
        // Crea un wrapper sincronizado alrededor de la cola de posiciones GPS.

        private Queue SyncdQ = new Queue(); //Queue.Synchronized(new Queue());

        public void Enqueue(EstructuraGPS PosicionGPS)
        {
            SyncdQ.Enqueue(PosicionGPS);
        }

        public EstructuraGPS Dequeue()
        {
            EstructuraGPS Deq = new EstructuraGPS();
            Deq = (EstructuraGPS)(SyncdQ.Dequeue());
            return Deq;
        }

        public long Count
        {
            get { return SyncdQ.Count; }
        }

        public object SyncRoot
        {
            get { return SyncdQ.SyncRoot; }
        }
    } // class QueuePosicionesGPS, Provides a syncronized Queue Array for a GPS Position Array.

    internal class _QueueCMD
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

    public class RASTREO_SQLThreads
    {
        //private int maxWorkThreads = 0, maxIOThreads = 0;
        private string _Protocolo_a_reenviar = string.Empty;

        private string _Convertir_a_ProtocoloGPS = "NO";
        private string _IP_para_reenvio = string.Empty;
        private int _Puerto_para_reenvio = 1;
        private bool _ReenvioActivado = false;

        public string Convertir_a_ProtocoloGPS
        {
            get { return _Convertir_a_ProtocoloGPS; }
            set { _Convertir_a_ProtocoloGPS = value; }
        }

        public string Protocolo_a_reenviar
        {
            get { return _Protocolo_a_reenviar; }
            set { _Protocolo_a_reenviar = value; }
        }

        public string IP_a_Reenviar
        {
            get { return _IP_para_reenvio; }
            set { _IP_para_reenvio = value; }
        }

        public int Puerto_para_reenvio
        {
            get { return _Puerto_para_reenvio; }
            set { _Puerto_para_reenvio = value; }
        }

        private int listen_port = 0;

        public int Puerto_escucha
        {
            get { return listen_port; }
        }

        public bool Reenvio_activado
        {
            get { return _ReenvioActivado; }
            set { _ReenvioActivado = value; }
        }

        private double _ZonaHoraria = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).TotalHours;

        public double ZonaHoraria
        {
            get { return _ZonaHoraria; }
            set { _ZonaHoraria = value; }
        }

        private long _TotalRecibido = 0;

        public long TotalRecibido
        {
            get { return _TotalRecibido; }
            set { _TotalRecibido = value; }
        }

        private long _TotalInsertado = 0;

        public long TotalInsertado
        {
            get { return _TotalInsertado; }
            set { _TotalInsertado = value; }
        }

        private long Total_en_Queue = 0;
        private long Total_en_Queue_Comandos = 0;

        public long Total_en_cola
        {
            get { return Total_en_Queue; }
        }

        public long Total_en_cola_de_comandos
        {
            get { return Total_en_Queue_Comandos; }
        }

        private bool ContinueQueue = true;

        public bool ColaActiva
        { get { return ContinueQueue; } set { ContinueQueue = value; } }

        //private QueueEnvioACK SQLACKs;
        private QueueEnvioExcesoVelocidad ExcesoQueue;

        private QueuePosicionesGPS SQLInsert;

        //private QueuePosicionesGPS EmailEnvioQueue;
        private QueueReenvioPosiciones SQLReSendtoIP;

        private _QueueCMD SQLSendCommands;
        private int THREAD_NUM_RASTREAR = 3;
        private static int THREAD_NUM_RASTREAR_INSERT = 20;
        private QueuePosicionesGPS[] InsertQueues = new QueuePosicionesGPS[THREAD_NUM_RASTREAR_INSERT];

        //private int THREAD_NUM_GUARDARPOSICIONES = 30;
        private Thread[] ThreadSafeRASTREAR;

        //private Thread[] ThreadSafe_GuardaPosiciones;

        public RASTREO_SQLThreads(double Zona_Horaria)
        {
            this.ZonaHoraria = Zona_Horaria;
            this.ThreadSafeRASTREAR = new Thread[THREAD_NUM_RASTREAR];
            //this.ThreadSafe_GuardaPosiciones = new Thread[THREAD_NUM_GUARDARPOSICIONES];
            //this.SQLACKs = new QueueEnvioACK();
            this.SQLInsert = new QueuePosicionesGPS();
            this.ExcesoQueue = new QueueEnvioExcesoVelocidad();
            //this.EmailEnvioQueue = new QueuePosicionesGPS();
            this.SQLReSendtoIP = new QueueReenvioPosiciones();
            this.SQLSendCommands = new _QueueCMD();
            this.IniciarSQLThreads();
        }

        public RASTREO_SQLThreads(double Zona_Horaria, int puerto_que_escucha)
        {
            this.ZonaHoraria = Zona_Horaria;
            this.listen_port = puerto_que_escucha;
            this.ThreadSafeRASTREAR = new Thread[THREAD_NUM_RASTREAR];
            this.SQLInsert = new QueuePosicionesGPS();
            this.ExcesoQueue = new QueueEnvioExcesoVelocidad();
            //this.EmailEnvioQueue = new QueuePosicionesGPS();
            this.SQLReSendtoIP = new QueueReenvioPosiciones();
            this.SQLSendCommands = new _QueueCMD();
            this.IniciarSQLThreads();
        }

        public RASTREO_SQLThreads()
        {
            this.ThreadSafeRASTREAR = new Thread[THREAD_NUM_RASTREAR];
            this.SQLInsert = new QueuePosicionesGPS();
            this.ExcesoQueue = new QueueEnvioExcesoVelocidad();
            //this.EmailEnvioQueue = new QueuePosicionesGPS();
            this.SQLReSendtoIP = new QueueReenvioPosiciones();
            this.SQLSendCommands = new _QueueCMD();
            this.IniciarSQLThreads();
        }

        public void IniciarSQLThreads()
        {
            //ThreadPool.GetMaxThreads(out maxWorkThreads, out maxIOThreads);
            //Ver donde poner el inicio del loggin npgsql, si no anda aqui, puede ser en el
            //GuardarPosiciones
            //NpgsqlEventLog.Level = LogLevel.Debug;
            //NpgsqlEventLog.LogName = "\\RASTREAR_SRV\\PORT_LOGS\\NpgsqlDebug.log";
            this.ColaActiva = true;
            this.ThreadSafeRASTREAR[0] = new Thread(new ThreadStart(this.ProcesarCola_PosicionesGPS));
            this.ThreadSafeRASTREAR[1] = new Thread(new ThreadStart(this.ExcesoDeVelocidadThread));
            this.ThreadSafeRASTREAR[2] = new Thread(new ThreadStart(this.ProcesarCola_ReSendIP));
            //this.ThreadSafeRASTREAR[2] = new Thread(new ThreadStart(this.ProcesarCola_EnvioDeEmail));
            //this.ThreadSafeRASTREAR[2] = new Thread(new ThreadStart(this.ProcesarCola_SendCommands));
            //this.ThreadSafeRASTREAR[THREAD_NUM_RASTREAR - 3] = new Thread(new ThreadStart(this.ProcesarCola_ACKs));
            foreach (Thread T in ThreadSafeRASTREAR)
            {
                if (T != null)
                    T.Start();
            }
        }

        public void DetenerSQLThreads()
        {
            //while (this.ColaActiva)
            //{
            //    lock (this.SQLInsert.SyncRoot)
            //    {
            //        if(this.SQLInsert.Count < 1)
            //        {
            //            this.ColaActiva = false;
            //        }
            //    }
            //    Thread.Sleep(1);
            //}
            this.ColaActiva = false;
            try
            {
                #region ProcesarCola_PosicionesGPS_old()

                foreach (Thread t in myThreadPool)
                {
                    Thread.Sleep(0);
                    if (t != null)
                        if (t.IsAlive)
                            t.Join(1);
                }

                #endregion ProcesarCola_PosicionesGPS_old()
            }
            catch (Exception)
            {
                //throw;
            }

            Thread.Sleep(10);

            for (int i = 0; i < this.ThreadSafeRASTREAR.Length; i++)
            {
                if (this.ThreadSafeRASTREAR[i] != null)
                    if (this.ThreadSafeRASTREAR[i].IsAlive)
                        this.ThreadSafeRASTREAR[i].Join(1);
            }
            Thread.Sleep(10);
        }

        #region "Procesadores de Colas"

        string cnnSTRRastrear = Properties.Settings.Default.RS_ServerCNNSTR;

        private void ExcesoDeVelocidadThread()
        {
            NpgsqlConnection pg_ExcesoConn = new NpgsqlConnection(cnnSTRRastrear);
            NpgsqlCommand pg_ExcesoCMD = null;
            NpgsqlDataReader pg_ExcesoRDR = null;

            try
            {
                pg_ExcesoConn.Open();
                while (this.ContinueQueue && this.Puerto_escucha > 0)
                {
                    lock (ExcesoQueue.SyncRoot)
                    {
                        if (ExcesoQueue.Count > 0)
                        {
                            EstructuraGPS MiPos = ExcesoQueue.Dequeue();
                            try
                            {
                                if (MiPos != null)
                                {
                                    if (MiPos.Estado_de_Poscionamiento)
                                    {
                                        string qryExcesoVelocidad =
                                            "SELECT vehiculo.identificador_rastreo identficador, ex.*, u.emails emailtosend " +
                                            "   FROM rastreo_vehiculo vehiculo " +
                                            "   LEFT JOIN rastreogps_equipogps eq ON " +
                                            "   eq.idrastreogps_equipogps = vehiculo.id_equipogps " +
                                            "   LEFT JOIN rastreo_excesovel ex ON " +
                                            "   ex.idvehiculo = vehiculo.idrastreo_vehiculo " +
                                            "   LEFT JOIN rastreo_usuarios u on " +
                                            "   vehiculo.id_cliente = u.id_persona " +
                                            " WHERE " +
                                            "  eq.id_equipo_gps = '" + MiPos.IdEquipo + "'" +
                                            " AND u.emails IS NOT NULL " +
                                            " AND ex.limite > 0 ";
                                        pg_ExcesoCMD = new NpgsqlCommand(qryExcesoVelocidad, pg_ExcesoConn);
                                        pg_ExcesoRDR = pg_ExcesoCMD.ExecuteReader(CommandBehavior.SingleRow);
                                        if (pg_ExcesoRDR.HasRows)
                                        {
                                            while (pg_ExcesoRDR.Read())
                                            {
                                                int limite = Convert.ToInt32(pg_ExcesoRDR["limite"]);
                                                if (limite > 0)
                                                {
                                                    if (MiPos.Velocidad >= limite)
                                                    {
                                                        string Emails = (string)pg_ExcesoRDR["emailtosend"];
                                                        string Identficador = (string)pg_ExcesoRDR["identficador"];
                                                        string Direccion =
                                                            Funciones_Utiles_GPS.mapserver_ReverseGeocode
                                                            (Properties.Settings.Default.mapserverIP, Properties.Settings.Default.mapserverPORT,
                                                            MiPos.Latitud, MiPos.Longitud);
                                                        string Msg = "{0} ha superado limite de velocidad a {1} Km/h sobre {2} a las {3}";
                                                        Msg = string.Format(Msg, Identficador, MiPos.Velocidad.ToString(), Direccion, MiPos.Fecha.ToString());
                                                        if ((Emails.Contains("@") && Emails.Contains(".")) && !Emails.Contains(";"))
                                                            Mail.SendMailTo(Emails, "Exceso de velocidad de " + Identficador, Msg, Properties.Settings.Default.MailSSL);
                                                        else
                                                        {
                                                            foreach (string email in Emails.Trim().Split(';'))
                                                            {
                                                                if (email.Contains("@") && email.Contains("."))
                                                                    Mail.SendMailTo(email, "Exceso de velocidad de " + Identficador, Msg, Properties.Settings.Default.MailSSL);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        pg_ExcesoCMD.Dispose();
                                        pg_ExcesoRDR.Close();
                                        pg_ExcesoRDR.Dispose();
                                    }
                                }
                            }
                            catch (NpgsqlException)// NPGSQLex)
                            {
                                //Funciones_de_soporte.Manejador_de_Excepciones(NPGSQLex);
                                if (pg_ExcesoConn.State != ConnectionState.Open)
                                    pg_ExcesoConn.Open();
                                pg_ExcesoCMD.Dispose();
                                pg_ExcesoRDR.Close();
                                pg_ExcesoRDR.Dispose();
                            }
                            catch (Exception xy)
                            {
                                Funciones_de_soporte.Informaciones_del_sistema(xy.ToString(), System.Diagnostics.EventLogEntryType.Error);
                                pg_ExcesoCMD.Dispose();
                                pg_ExcesoRDR.Close();
                                pg_ExcesoRDR.Dispose();
                            }
                        }
                    }
                    Thread.Sleep(1);
                }
            }
            catch (Exception xy)
            {
                Funciones_de_soporte.Informaciones_del_sistema(xy.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                if (pg_ExcesoConn != null)
                {
                    if (pg_ExcesoConn.State == ConnectionState.Open)
                        pg_ExcesoConn.Close();
                    pg_ExcesoConn = null;
                }
                pg_ExcesoCMD = null;
                if (pg_ExcesoRDR != null)
                {
                    pg_ExcesoRDR.Close();
                    pg_ExcesoRDR.Dispose();
                }
            }
        }

        List<Thread> myThreadPool = new List<Thread>(THREAD_NUM_RASTREAR_INSERT);

        private void ThreadPooler(object param)
        {
            int threadNum = (int)param;
            try
            {
                ThreadColaGPS(threadNum);
            }
            catch (ThreadAbortException)
            {
            }
            catch (Exception ex)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(ex);
            }
            lock (this.InsertQueues[threadNum].SyncRoot)
            {
                while (this.InsertQueues[threadNum].Count > 0)
                    this.SQLInsert.Enqueue(this.InsertQueues[threadNum].Dequeue());
            }
        }

        private void ProcesarCola_PosicionesGPS()
        {
            int merryGoAround = 0;
            try
            {
                for (int i = 0; i < THREAD_NUM_RASTREAR_INSERT; i++)
                    InsertQueues[i] = new QueuePosicionesGPS();

                for (int xx = 0; xx < THREAD_NUM_RASTREAR_INSERT; xx++)
                {
                    Thread TT = new Thread(ThreadPooler);
                    TT.Name = xx.ToString();
                    TT.Start(xx);
                    myThreadPool.Add(TT);
                }

                long queueCount = 0;
                while (this.ContinueQueue && this.Puerto_escucha > 0)
                {
                    try
                    {
                        try
                        {
                            int deadThreadIndex = myThreadPool.FindIndex(thread => !thread.IsAlive);
                            if (deadThreadIndex >= 0)
                                myThreadPool[deadThreadIndex].Start();
                        }
                        catch (Exception)
                        {
                        }

                        lock (this.SQLInsert.SyncRoot)
                        {
                            queueCount = this.SQLInsert.Count;

                            //tengo que hacer de alguna manera poder verificar si algun thread murio
                            // y la cola esta estancada y desencolar en algun otro thread.
                            foreach (QueuePosicionesGPS q in InsertQueues)
                                queueCount += q.Count;
                            this.Total_en_Queue = queueCount;
                            if (this.SQLInsert.Count > 0)
                            {
                                EstructuraGPS p = this.SQLInsert.Dequeue();
                                lock (this.InsertQueues[merryGoAround].SyncRoot)
                                {
                                    this.InsertQueues[merryGoAround].Enqueue(p);
                                }
                                merryGoAround++;
                                if (merryGoAround >= THREAD_NUM_RASTREAR_INSERT)
                                    merryGoAround = 0;
                            }
                        }
                    }
                    catch (Exception EX)
                    {
                        Funciones_de_soporte.Manejador_de_Excepciones(EX);
                        this.TotalRecibido -= 1;
                        if (this.TotalRecibido < 0) this.TotalRecibido = this.TotalInsertado;
                    }
                    Thread.Sleep(0);
                }
            }
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
                this.TotalRecibido -= 1;
                if (this.TotalRecibido < 0) this.TotalRecibido = this.TotalInsertado;
            }
            this.ColaActiva = false;
        }

        private void ThreadColaGPS(int threadNum)
        {
            int id_equipogps = 0;
            NpgsqlConnection localpg_Conn = new NpgsqlConnection(cnnSTRRastrear);
            try
            {
                localpg_Conn.Open();
                while (this.ContinueQueue && this.Puerto_escucha > 0)
                {
                    id_equipogps = 0;
                    NpgsqlCommand pg_SelectCMD = null;
                    NpgsqlDataReader pg_RDR = null;
                    try
                    {
                        lock (this.InsertQueues[threadNum].SyncRoot)
                        {
                            while (this.InsertQueues[threadNum].Count > 0)
                            {
                                EstructuraGPS MiPos = this.InsertQueues[threadNum].Dequeue();
                                if (MiPos == null) continue;
                                if (MiPos.IdEquipo == null) continue;
                                if (MiPos.IdEquipo.Trim() == string.Empty) continue;

                                string Select_Query = string.Format(
                                    "SELECT * FROM rsview_help_for_insert " +
                                    "WHERE id_equipo_gps = '{0}' LIMIT 1", MiPos.IdEquipo);
                                pg_SelectCMD = new NpgsqlCommand(Select_Query, localpg_Conn);
                                pg_SelectCMD.CommandTimeout = 100;
                                pg_RDR = null;
                                try
                                {
                                    if (!MiPos.IdEquipo.Contains("#") &&
                                        MiPos.IdEquipo != string.Empty &&
                                        pg_SelectCMD.CommandText != "SELECT * FROM rsview_help_for_insert WHERE id_equipo_gps = '#")
                                        pg_RDR = pg_SelectCMD.ExecuteReader(CommandBehavior.SingleRow);
                                    else
                                        continue;
                                }
                                catch (NpgsqlException e)
                                {
                                    id_equipogps = 0;
                                    this.TotalRecibido -= 1;
                                    if (this.TotalRecibido < 0) this.TotalRecibido = this.TotalInsertado;
                                    if (MiPos.IdEquipo != string.Empty ||
                                        !MiPos.IdEquipo.Contains("#"))
                                        this.SQLInsert.Enqueue(MiPos);
                                    string error =
                                        string.Format("Puerto[{0}]", this.listen_port.ToString()) + Environment.NewLine +
                                        string.Format("ThreadNum[{0}]", threadNum) + Environment.NewLine +
                                        e.Message + Environment.NewLine +
                                        e.Code + Environment.NewLine +
                                        e.ErrorCode + Environment.NewLine +
                                        e.ErrorSql + Environment.NewLine +
                                        e.Detail + Environment.NewLine;
                                    Funciones_de_soporte.Informaciones_del_sistema(error,
                                        System.Diagnostics.EventLogEntryType.FailureAudit);
                                    try
                                    {
                                        if (localpg_Conn.State != ConnectionState.Closed)
                                            localpg_Conn.Close();
                                    }
                                    catch (Exception)
                                    { }

                                    if (localpg_Conn.State != ConnectionState.Open)
                                    {
                                        localpg_Conn = new NpgsqlConnection(cnnSTRRastrear);
                                        localpg_Conn.Open();
                                    }
                                    //Thread.Sleep(0);
                                    continue;
                                }
                                try
                                {
                                    if (MiPos.ToString() != "NULO")
                                    {
                                        if (pg_RDR.HasRows)
                                        {
                                            pg_RDR.Read();
                                            string tiporeporte = (string)pg_RDR["Tipo_de_reporte"];
                                            id_equipogps = (int)pg_RDR["idrastreogps_equipogps"];
                                            if (string.Compare(tiporeporte.Trim(), MiPos.TipoReporte.Trim(), false) != 0)
                                            {
                                                string tde_err = string.Empty;
                                                tde_err += "El reporte enviado por el equipo " + pg_RDR["Id_equipo_gps"];
                                                tde_err += " no coincide con los datos cargados." + Environment.NewLine;
                                                tde_err += "El equipo tiene seteado estos datos en la base de datos:" + Environment.NewLine;
                                                tde_err += "Vehiculo asociado: " + pg_RDR["Identificador_rastreo"] + Environment.NewLine;
                                                tde_err += "Tipo de equipo: " + pg_RDR["Tipo_equipo"] + Environment.NewLine;
                                                tde_err += "Tipo de reporte del tipo de equipo: " + pg_RDR["Tipo_de_reporte"] + Environment.NewLine;
                                                tde_err += "Y estos son los datos que ha recibido el servidor: " + Environment.NewLine;
                                                tde_err += MiPos.ToString();
                                                Funciones_de_soporte.Informaciones_del_sistema(tde_err);
                                            }
                                            string Insert_Reporte = string.Empty;
                                            pg_RDR.Close();
                                            Insert_Reporte =
                                                    "INSERT INTO reportesgps" + MiPos.Fecha.Month.ToString() +
                                                    MiPos.Fecha.Year.ToString() + "(gps_temp,gps_edaddeldato,gps_estado_io,gps_evento," +
                                                    "gps_fechahora_reporte,gps_hdop,gps_ip,gps_latitud,gps_longitud,gps_rumbo," +
                                                    "gps_satstatus, gps_gsmstatus,gps_tipodeposicion,gps_velocidad, id_equipogps) " +
                                                    "VALUES (" +
                                                    MiPos.Temperatura + "," +
                                                    "'" + MiPos.EdadDelDato + "'," +
                                                    "'" + MiPos.EstadoIO + "'," +
                                                    "'" + MiPos.Evento + "'," +
                                                    "'" + MiPos.Fecha.ToString() + "'," +
                                                    "'" + MiPos.HDOP.ToString() + "'," +
                                                    "'" + MiPos.IP + ":" + MiPos.Puerto + "'," +
                                                    MiPos.Latitud.ToString().Replace(',', '.') + "," +
                                                    MiPos.Longitud.ToString().Replace(',', '.') + "," +
                                                    MiPos.Rumbo.ToString() + "," +
                                                    "'" + MiPos.Status_SAT.ToString() + "'," +
                                                    "'" + MiPos.Status_GSM.ToString() + "'," +
                                                    "'" + MiPos.Status_SAT.ToString() + "'," +
                                                    MiPos.Velocidad.ToString() + ", '" +
                                                    id_equipogps +
                                                    "');";
                                            NpgsqlCommand pg_InsertCMD = new NpgsqlCommand(Insert_Reporte, localpg_Conn);
                                            pg_InsertCMD.CommandTimeout = 100;
                                            int rowcount = 0;
                                            try
                                            {
                                                rowcount = pg_InsertCMD.ExecuteNonQuery();
                                            }
                                            catch (NpgsqlException NPGEX)
                                            {
                                                switch (NPGEX.Code)
                                                {
                                                    case "21000":
                                                        this.TotalRecibido -= 1;
                                                        if (this.TotalRecibido < 0) this.TotalRecibido = this.TotalInsertado;
                                                        break;
                                                    case "23505":
                                                        this.TotalRecibido -= 1;
                                                        if (this.TotalRecibido < 0) this.TotalRecibido = this.TotalInsertado;
                                                        Funciones_de_soporte.Mensaje_de_Log_PORT("REPETIDOS_puerto" + this.listen_port.ToString(), Environment.NewLine + "Posicion repetida: " + Environment.NewLine + MiPos.ToString());
                                                        break;
                                                    case "42P01":
                                                        string create_table = " BEGIN; " +
                                                            "CREATE TABLE reportesgps" + MiPos.Fecha.Month.ToString() + MiPos.Fecha.Year.ToString() +
                                                            "(" +
                                                            "  idreportesgps" + MiPos.Fecha.Month.ToString() + MiPos.Fecha.Year.ToString() + " serial NOT NULL," +
                                                            "  id_equipogps integer NOT NULL," +
                                                            "  gps_longitud double precision," +
                                                            "  gps_latitud double precision," +
                                                            "  gps_fechahora_reporte timestamp without time zone DEFAULT now()," +
                                                            "  gps_velocidad integer," +
                                                            "  gps_rumbo integer," +
                                                            "  gps_evento character varying(32)," +
                                                            "  gps_edaddeldato character varying(32)," +
                                                            "  gps_hdop character varying(32)," +
                                                            "  gps_satstatus character varying(32)," +
                                                            "  gps_gsmstatus character varying(32)," +
                                                            "  gps_estado_io character varying(32)," +
                                                            "  gps_tipodeposicion character varying(32)," +
                                                            "  gps_ip character varying(128)," +
                                                            "  gps_obs text," +
                                                            "  gps_dir text," +
                                                            "  gps_temp integer," +
                                                            "  CONSTRAINT reportesgps" + MiPos.Fecha.Month.ToString() + MiPos.Fecha.Year.ToString() + "_pk PRIMARY KEY (idreportesgps" + MiPos.Fecha.Month.ToString() + MiPos.Fecha.Year.ToString() + ")," +
                                                            "  CONSTRAINT reportesgps" + MiPos.Fecha.Month.ToString() + MiPos.Fecha.Year.ToString() + "_unique UNIQUE (gps_fechahora_reporte, id_equipogps)" +
                                                            ")" +
                                                            "WITH (" +
                                                            "  OIDS=FALSE" +
                                                            ");" +
                                                            "ALTER TABLE reportesgps" + MiPos.Fecha.Month.ToString() + MiPos.Fecha.Year.ToString() + " OWNER TO rastreo_admin;" +
                                                            "DROP TRIGGER IF EXISTS reportesgps" + MiPos.Fecha.Month.ToString() + MiPos.Fecha.Year.ToString() + "_update_bandeja_entrada ON reportesgps" + MiPos.Fecha.Month.ToString() + MiPos.Fecha.Year.ToString() + ";" +
                                                            "CREATE TRIGGER reportesgps" + MiPos.Fecha.Month.ToString() + MiPos.Fecha.Year.ToString() + "_update_bandeja_entrada" +
                                                            "  AFTER INSERT" +
                                                            "  ON reportesgps" + MiPos.Fecha.Month.ToString() + MiPos.Fecha.Year.ToString() +
                                                            "  FOR EACH ROW" +
                                                            "  EXECUTE PROCEDURE rstrigger_rastreogps_reportes_update_bandeja_entrada();" +
                                                            " END;";
                                                        NpgsqlCommand pg_CreateTBLCMD = new NpgsqlCommand(create_table, localpg_Conn);
                                                        pg_CreateTBLCMD.CommandTimeout = 200;
                                                        if (pg_CreateTBLCMD.ExecuteNonQuery() > 0)
                                                            Thread.Sleep(5);
                                                        this.TotalRecibido -= 1;
                                                        if (this.TotalRecibido < 0) this.TotalRecibido = this.TotalInsertado;
                                                        this.SQLInsert.Enqueue(MiPos);
                                                        break;
                                                    default:
                                                        this.TotalRecibido -= 1;
                                                        if (this.TotalRecibido < 0) this.TotalRecibido = this.TotalInsertado;
                                                        Funciones_de_soporte.Manejador_de_Excepciones(NPGEX);
                                                        break;
                                                }
                                            }
                                            catch (Exception TrnEX)
                                            {
                                                Funciones_de_soporte.Manejador_de_Excepciones(TrnEX);
                                                this.TotalRecibido -= 1;
                                                if (this.TotalRecibido < 0) this.TotalRecibido = this.TotalInsertado;
                                            }

                                            if (rowcount > 0)
                                                this.TotalInsertado += 1;

                                            ExcesoQueue.Enqueue(MiPos);
                                        }
                                        else
                                        {
                                            this.TotalRecibido -= 1;
                                            if (this.TotalRecibido < 0) this.TotalRecibido = this.TotalInsertado;
                                            //string myError = "El equipo con el id " +
                                            //    MiPos.IdEquipo + " NO se encuentra registrado en la base de datos. \r\n" +
                                            //    "\r\nDatos del reporte:\r\n" +
                                            //    MiPos.ToString();
                                            //Funciones_de_soporte.Informaciones_del_sistema(myError,
                                            //    System.Diagnostics.EventLogEntryType.Warning);
                                        }
                                    }
                                    else
                                    {
                                        this.TotalRecibido -= 1;
                                        if (this.TotalRecibido < 0) this.TotalRecibido = this.TotalInsertado;
                                        string myError = "NULO, LA PUTA!";
                                        Funciones_de_soporte.Informaciones_del_sistema(myError, System.Diagnostics.EventLogEntryType.Error);
                                    }
                                }
                                catch (Exception Exy)
                                {
                                    this.TotalRecibido -= 1;
                                    if (this.TotalRecibido < 0) this.TotalRecibido = this.TotalInsertado;
                                    Exy.Data.Add("POS_ERR", Environment.NewLine + "\n ULTIMO CATCH -- PosError: " + MiPos.ToString());
                                    Funciones_de_soporte.Informaciones_del_sistema(Exy.ToString(),
                                        System.Diagnostics.EventLogEntryType.FailureAudit);
                                }
                                Thread.Sleep(0);
                            }
                        }
                    }
                    catch (Exception EX)
                    {
                        Funciones_de_soporte.Manejador_de_Excepciones(EX);
                        this.TotalRecibido -= 1;
                        if (this.TotalRecibido < 0) this.TotalRecibido = this.TotalInsertado;
                    }
                    finally
                    {
                        if (pg_RDR != null)
                            pg_RDR.Close();
                        pg_RDR = null;
                    }
                    //if (this.TotalRecibido - this.TotalInsertado > 250) this.TotalRecibido = this.TotalInsertado;
                    Thread.Sleep(0);
                }
            }
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
                this.TotalRecibido -= 1;
                if (this.TotalRecibido < 0) this.TotalRecibido = this.TotalInsertado;
            }
            finally
            {
                if (localpg_Conn.State == ConnectionState.Open)
                    localpg_Conn.Close();
                if (localpg_Conn != null)
                    localpg_Conn.Dispose();
                localpg_Conn = null;
            }
        }

        private void ProcesarCola_ReSendIP()
        {
            try
            {
                while (ContinueQueue && Reenvio_activado)
                {
                    lock (this.SQLReSendtoIP.SyncRoot)
                    {
                        if (this.SQLReSendtoIP.Count > 0)
                        {
                            Reenvio_de_Reporte resend = this.SQLReSendtoIP.Dequeue();
                            if (resend.enviarUDP)
                                RASTREO_UDPClient.SendDataUDP(resend.IPPORT,
                                    resend.Reporte_a_Enviar, true);
                            else if (resend.enviarTCP)
                            {
                                RASTREO_TCPClient tcpcli = new RASTREO_TCPClient();
                                tcpcli.SendDataTCP(resend.IPPORT, resend.Reporte_a_Enviar);
                            }
                        }
                    }
                    Thread.Sleep(1); //1 milisegundo
                }
            }
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
            }
        }

        private void ProcesarCola_SendCommands()
        {
            EstructuraCMD CMD = new EstructuraCMD();
            try
            {
                while (ContinueQueue && this.Puerto_escucha > 0)
                {
                    try
                    {
                        lock (this.SQLSendCommands.SyncRoot)
                        {
                            if (this.SQLSendCommands.Count > 0)
                            {
                                CMD = SQLSendCommands.Dequeue();
                                if (!RASTREO_UDPClient.SendDataUDP(CMD.IP, CMD.Puerto, CMD.Comando))
                                {
                                    Exception xxx = new Exception("El comando " + CMD.Comando +
                                        "al vehiculo con idequipo ID=" + CMD.IdEquipo + " no ha sido enviado\r\n" +
                                        "ip: " + CMD.IP + " puerto: " + CMD.Puerto);
                                    Funciones_de_soporte.Manejador_de_Excepciones(xxx);
                                }
                            }
                        }
                    }
                    catch (Exception EX)
                    {
                        this.SQLSendCommands.Enqueue(CMD);
                        Funciones_de_soporte.Manejador_de_Excepciones(EX);
                    }
                    Thread.Sleep(10);
                }
            }
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
            }
        }

        #endregion "Procesadores de Colas"

        #region "Parsers"

        public EstructuraGPS ParseTK1000(string data, string IpPort)
        {
            //HeadID,status,GPS_fix,fecha,hora,longitud,latitud,Respuesta,velocidad,orientación,GSM_CSQ,EventoReportado,ADC0-ADC1,Pulso,Salidas,TESTSTRING*checksum! HeadID,status,GPS_fix,fecha,hora,longitud,latitud,Respuesta,velocidad,orientación,GSM_CSQ,EventoReportado,ADC0-ADC1,Pulso,Salidas,TESTSTRING*checksum!
            //>00006030,4,1,090218,170738,W05649.6636,S2528.5522,,00,000,12,00,000-000,0,0,01111111*37!
            //>00006018,3,0,000000,000000,E00000.0000,N0000.0000,CHK,00,000,17,00,001-000,0,0,01111110*7f!
            //>00006012,4,1,090922,164326,W05735.3074,S2517.0758,,05,102,26,00,000-000,0,0,11111111*32!
            /*
             * Creado por: Christian Melgarejo
             * Fecha: 17/02/2009
             * Recepcionador y parseador de datos tipo TK-1000
             * data es la linea reporte en formato tk-1000 y IPPORT es el IP y el
             * puerto de donde viene.
             */
            EstructuraGPS TK1000 = new EstructuraGPS();
            string IP = IpPort.Split(':')[0];
            string PORT = IpPort.Split(':')[1];
            try
            {
                TK1000 = GPS_Class.LoadTK1000(data, ZonaHoraria);
                TK1000.IP = IP;
                TK1000.Puerto = PORT;
                //TK1000.ACK = GetACK(data);
                if (TK1000.Estado_de_Poscionamiento)
                {
                    //Insertar_Comando_en_colaSQL(TK1000);

                    //lock(this.SQLInsert)
                    {
                        this.SQLInsert.Enqueue(TK1000);
                    }
                    this.TotalRecibido += 1;
                }
                else
                {
                    Funciones_de_soporte.Informaciones_del_sistema("[TK1000]\r\n " +
                    "No se ha guardado este reporte: " + data);
                }
                return TK1000;
            }
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
                TK1000.Estado_de_Poscionamiento = false;
                return TK1000;
            }
        }

        public EstructuraGPS ParseG381(string data, string IpPort)
        {
            ////$B,6035,956,2517.8910,05730.8360,0,  0,384,180209,1706  ,1,   *49
            /*
             * Creado por: Christian Melgarejo
             * Fecha: 17/02/2009
             * Recepcionador y parseador de datos tipo G381
             * data es la linea reporte en formato G381 y IPPORT es el IP y el
             * puerto de donde viene.
             */
            EstructuraGPS G381 = new EstructuraGPS();
            string IP = IpPort.Split(':')[0];
            string PORT = IpPort.Split(':')[1];
            try
            {
                G381 = GPS_Class.LoadG381(data, ZonaHoraria);
                G381.IP = IP;
                G381.Puerto = PORT;
                //G381.ACK = GetACK(data);
                if (G381.Estado_de_Poscionamiento)
                {
                    //Insertar_Comando_en_colaSQL(G381);
                    //lock(this.SQLInsert)
                    {
                        this.SQLInsert.Enqueue(G381);
                    }
                    this.TotalRecibido += 1;
                }
                else
                {
                    //if(data.Replace("$$", "$").Trim().Length > 10 && data.Trim() != "$$")
                    //    Funciones_de_soporte.Informaciones_del_sistema(
                    //        "[G381]\r\n No se ha guardado este reporte: " + data);
                }
                return G381;
            }
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
                G381.Estado_de_Poscionamiento = false;
                return G381;
            }
        }

        public EstructuraGPS ParseRPRASTREAR(string data, string IpPort)
        {
            /*
             * Creado por: Christian Melgarejo
             * Fecha: 03/07/2009
             * Recepcionador y parseador de datos tipo RP (Equipo prueba RASTREAR)
             * data es la linea reporte en RP y IPPORT es el IP y el
             * puerto de donde viene, formato de esta string es
             * IP:PUERTO Ej. 127.0.0.1:1111
             */
            EstructuraGPS RPRASTREAR = new EstructuraGPS();
            string[] IPPORT = IpPort.Split(':');
            //string IP = IPPORT[0];
            //string PORT = IPPORT[1];
            try
            {
                RPRASTREAR = GPS_Class.LoadRPRASTREAR(data, ZonaHoraria);
                RPRASTREAR.IP = IPPORT[0];
                RPRASTREAR.Puerto = IPPORT[1];
                //RGPTRAXS4.ACK = GetACK(data);
                if (RPRASTREAR.Estado_de_Poscionamiento)
                {
                    //Insertar_Comando_en_colaSQL(RPRASTREAR);
                    //lock(this.SQLInsert)
                    {
                        this.SQLInsert.Enqueue(RPRASTREAR);
                    }
                    this.TotalRecibido += 1;
                }
                else
                {
                    Funciones_de_soporte.Informaciones_del_sistema(
                        "[ParseRPRASTREAR]\r\n No se ha guardado este reporte: " + data);
                }
                return RPRASTREAR;
            }
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
                RPRASTREAR.Estado_de_Poscionamiento = false;
                return RPRASTREAR;
            }
        }

        public EstructuraGPS ParseRGPTRAXS4(string data, string IpPort)
        {
            /*
             * Creado por: Christian Melgarejo
             * Fecha: 17/02/2009
             * Recepcionador y parseador de datos tipo RGP (TRAXS4)
             * data es la linea reporte en RGP y IPPORT es el IP y el
             * puerto de donde viene, formato de esta string es
             * IP:PUERTO Ej. 127.0.0.1:1111
             */
            EstructuraGPS RGPTRAXS4 = new EstructuraGPS();
            string[] IPPORT = IpPort.Split(':');
            //string IP = IPPORT[0];
            //string PORT = IPPORT[1];
            try
            {
                RGPTRAXS4 = GPS_Class.LoadTRAXS4(data, ZonaHoraria);
                RGPTRAXS4.IP = IPPORT[0];
                RGPTRAXS4.Puerto = IPPORT[1];
                //RGPTRAXS4.ACK = GetACK(data);
                if (RGPTRAXS4.Estado_de_Poscionamiento)
                {
                    //Insertar_Comando_en_colaSQL(RGPTRAXS4);
                    //lock(this.SQLInsert)
                    {
                        this.SQLInsert.Enqueue(RGPTRAXS4);
                    }
                    this.TotalRecibido += 1;
                }
                else
                {
                    Funciones_de_soporte.Informaciones_del_sistema(
                        "[ParseRGPTRAXS4]\r\n No se ha guardado este reporte: " + data);
                }
                return RGPTRAXS4;
            }
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
                RGPTRAXS4.Estado_de_Poscionamiento = false;
                return RGPTRAXS4;
            }
        }

        public EstructuraGPS ParseRIMTRAX(string data, string IpPort)
        {
            /*
             * Creado por: Christian Melgarejo
             * Fecha: 17/09/2009
             * Recepcionador y parseador de datos tipo RGP (TRAXS4)
             * data es la linea reporte en RGP y IPPORT es el IP y el
             * puerto de donde viene, formato de esta string es
             * IP:PUERTO Ej. 127.0.0.1:1111
             */
            EstructuraGPS RIMTRAX = new EstructuraGPS();
            string[] IPPORT = IpPort.Split(':');
            //string IP = IPPORT[0];
            //string PORT = IPPORT[1];
            try
            {
                RIMTRAX = GPS_Class.LoadRIMTRAX(data, ZonaHoraria);
                RIMTRAX.IP = IPPORT[0];
                RIMTRAX.Puerto = IPPORT[1];
                //RGPTRAXS4.ACK = GetACK(data);
                if (RIMTRAX.Estado_de_Poscionamiento)
                {
                    //lock(this.SQLInsert)
                    {
                        this.SQLInsert.Enqueue(RIMTRAX);
                    }
                    this.TotalRecibido += 1;
                }
                else
                {
                    Funciones_de_soporte.Informaciones_del_sistema(
                        "[ParseRGPTRAXS4]\r\n No se ha guardado este reporte: " + data);
                }
                return RIMTRAX;
            }
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
                RIMTRAX.Estado_de_Poscionamiento = false;
                return RIMTRAX;
            }
        }

        public EstructuraGPS ParseRGPVirloc(string data, string IpPort)
        {
            /*
             * Creado por: Christian Melgarejo
             * Fecha: 14/02/2009
             * Recepcionador y parseador de datos tipo RGP (VIRLOC)
             * data es la linea reporte en bruto RGP y IPPORT es el IP y el
             * puerto de donde viene, formato de esta string es
             * IP:PUERTO Ej. 127.0.0.1:1111
             */
            EstructuraGPS VirlocRGP = new EstructuraGPS();
            string IP = IpPort.Split(':')[0];
            string PORT = IpPort.Split(':')[1];
            try
            {
                VirlocRGP = GPS_Class.LoadRGP(data, ZonaHoraria);
                VirlocRGP.IP = IP;
                VirlocRGP.Puerto = PORT;
                //VirlocRGP.ACK = GetACK(data);
                if (VirlocRGP.Estado_de_Poscionamiento)
                {
                    //lock(this.SQLInsert)
                    {
                        this.SQLInsert.Enqueue(VirlocRGP);
                    }
                    this.TotalRecibido += 1;
                }
                else
                {
                    Funciones_de_soporte.Informaciones_del_sistema(
                        "[ParseRGPVirloc]\r\n No se ha guardado este reporte: " + data);
                }
                return VirlocRGP;
            }
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
                VirlocRGP.Estado_de_Poscionamiento = false;
                return VirlocRGP;
            }
        }

        public EstructuraGPS ParseGPRMC(string data, string IpPort)
        {
            /*
             * Creado por: Christian Melgarejo
             * Fecha: 14/02/2009
             * Recepcionador y parseador de datos tipo NMEA (GPRMC)
             * data es la linea reporte en bruto GPRMC y IPPORT es el IP y el
             * puerto de donde viene, formato de esta string es
             * IP:PUERTO Ej. 127.0.0.1:1111
             */
            EstructuraGPS GPRMC = new EstructuraGPS();
            string IP = IpPort.Split(':')[0];
            string PORT = IpPort.Split(':')[1];
            try
            {
                GPRMC = GPS_Class.LoadRMC(data, ZonaHoraria);
                GPRMC.IP = IP;
                GPRMC.Puerto = PORT;
                //GPRMC.ACK = GetACK(data);
                if (GPRMC.Estado_de_Poscionamiento)
                {
                    //Insertar_Comando_en_colaSQL(GPRMC);

                    //lock(this.SQLInsert)
                    {
                        this.SQLInsert.Enqueue(GPRMC);
                    }
                    this.TotalRecibido += 1;
                }
                else
                {
                    Funciones_de_soporte.Informaciones_del_sistema(
                        "[ParseGPRMC]\r\n No se ha guardado este reporte: " + data);
                }
                return GPRMC;
            }
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
                GPRMC.Estado_de_Poscionamiento = false;
                return GPRMC;
            }
        }

        public EstructuraGPS ParseVT300(string data, string IpPort)
        {
            /*
             * Creado por: Christian Melgarejo
             * Fecha: 11/01/2010
             * Recepcionador y parseador de datos tipo $$ (VT300)
             * data es la linea reporte en $$ y IPPORT es el IP y el
             * puerto de donde viene, formato de esta string es
             * IP:PUERTO Ej. 127.0.0.1:1111
             * $$8205??????????&A0000##$$8205??????????&A9955&B214741.000,A,2522.4067,S,05736.4264,W,0.00,0.00,070911,,,A*6B|1.2|&C0000000000&D005;9734&E00000000##
             * $$108???????????&A9955&B192757.000,A,2517.5173,S,05737.4095,W,0.00,172.13,120110,,,A*64|1.2|&C01000000&D00000000&E00000000##
             */
            EstructuraGPS VT300 = new EstructuraGPS();
            string[] IPPORT = IpPort.Split(':');
            //string IP = IPPORT[0];
            //string PORT = IPPORT[1];
            try
            {
                VT300 = GPS_Class.LoadVT300(data, ZonaHoraria);
                VT300.IP = IPPORT[0];
                VT300.Puerto = IPPORT[1];
                //RGPTRAXS4.ACK = GetACK(data);
                if (VT300.Estado_de_Poscionamiento)
                {
                    //Insertar_Comando_en_colaSQL(RGPTRAXS4);
                    //lock(this.SQLInsert)
                    {
                        this.SQLInsert.Enqueue(VT300);
                    }
                    this.TotalRecibido += 1;
                }
                else
                {
                    //Funciones_de_soporte.Informaciones_del_sistema(
                    //	"[ParseVT300]\r\n No se ha guardado este reporte: " + data);
                }
                return VT300;
            }
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
                VT300.Estado_de_Poscionamiento = false;
                return VT300;
            }
        }

        #endregion "Parsers"

        public void Insertar_Comando_en_colaSQL(EstructuraGPS ToSend)
        {
            int idequipogps = -1;
            EstructuraCMD CMD;
            NpgsqlConnection pg_CNN = new NpgsqlConnection(cnnSTRRastrear);
            string Select_Query =
                "SELECT * FROM rsview_equipogps_comandos WHERE id_equipo_gps = '" + ToSend.IdEquipo + "' " +
                "AND enviado = FALSE";
            string Update_Query =
                "UPDATE rastreogps_cola_de_comandos SET enviado = TRUE" +
                " WHERE idequipogps = ";
            try
            {
                pg_CNN.Open();
                NpgsqlCommand pg_CMD = new NpgsqlCommand(Select_Query, pg_CNN);
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
                        CMD.IP = ToSend.IP;
                        CMD.Puerto = ToSend.Puerto;
                        //CMD.Protocolo
                        this.SQLSendCommands.Enqueue(CMD);
                        Thread.Sleep(10);
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
                Funciones_de_soporte.Informaciones_del_sistema("Falla en InsertCommand" +
                    Environment.NewLine + EX.ToString());
            }
            finally
            {
                if (pg_CNN.State != ConnectionState.Closed)
                    pg_CNN.Close();
                pg_CNN = null;
            }
        }

        public void SaveGPSInfo(string data, EndPoint Cliente)
        {
            if (Reenvio_activado)
                this.SQLReSendtoIP.Enqueue(new Reenvio_de_Reporte(data, Convertir_a_ProtocoloGPS,
                    IP_a_Reenviar, Puerto_para_reenvio, Protocolo_a_reenviar));
            EstructuraGPS InfoGPS = new EstructuraGPS();
            //Reportes de VT300 - RST202 y demas
            if (data.Contains("$$") && data.Contains(",") && data.Contains("*") && data.Contains("&"))
            {
                string[] sb = data.Split('$');//.Replace("##", "|").Split('|');
                foreach (string q in sb)
                {
                    if (!string.IsNullOrEmpty(q))
                    {
                        InfoGPS = this.ParseVT300(q, Cliente.ToString());
                    }
                }
                //else
                //    InfoGPS = this.ParseVT300(data, Cliente.ToString());
            }
            else if ((data.Contains(">RGP") || data.Contains("RGL") || data.Contains("RIM")) &&
                (data.Contains("#IP") || data.Contains("#SM") || data.Contains("#LOG")))
            //Para reportes TRAX-S4
            {
                string[] splitData = data.Split('<');
                foreach (string entry in splitData)
                    InfoGPS = this.ParseRGPTRAXS4(entry, Cliente.ToString());
            }
            else if ((data.Contains("RGP") || data.Contains("RGL")) &&
                    (!data.Contains("#IP") && !data.Contains("#SM") && !data.Contains("#LOG")))
            //Para reportes de VIRLOC, T-1000 y otros que usan VIRLOC RGP
            {
                InfoGPS = this.ParseRGPVirloc(data, Cliente.ToString());
            }
            //Reportes de TK1000
            else if (data.Contains(">") && data.Contains("!") &&
                    data.Contains(",") && data.Contains("*") && data.Contains("-"))
            {
                InfoGPS = this.ParseTK1000(data, Cliente.ToString());
            }
            //Reportes de G831
            else if (data.Contains("$") && data.Contains(",") && data.Contains("*"))
            {
                InfoGPS = this.ParseG381(data, Cliente.ToString());
            }
            //Reportes de DELTA BETA
            else if (data.Contains("RP") && data.Contains(">") && data.Contains("<"))
            {
                InfoGPS = this.ParseRPRASTREAR(data, Cliente.ToString());
            }
        }

        public EstructuraGPS SaveGPSData(string data, EndPoint Cliente)
        {
            if (Reenvio_activado)
                this.SQLReSendtoIP.Enqueue(new Reenvio_de_Reporte(data, Convertir_a_ProtocoloGPS,
                    IP_a_Reenviar, Puerto_para_reenvio, Protocolo_a_reenviar));
            try
            {
                if ((data.Contains("RGP") || data.Contains("RGL") || data.Contains("RIM")) &&
                   (data.Contains("#IP") || data.Contains("#SM") || data.Contains("#LOG")))
                //Para reportes TRAX-S4
                {
                    if (!data.Contains("RIM"))
                        return ParseRGPTRAXS4(data, Cliente.ToString());
                    else
                        return ParseRIMTRAX(data, Cliente.ToString());
                }
                //Para reportes VT-300
                else if (data.Contains("$$") && data.Contains(",") && data.Contains("*") && data.Contains("&"))
                {
                    //return this.ParseVT300(data, Cliente.ToString());
                    EstructuraGPS InfoGPS = new EstructuraGPS();
                    string[] sb = data.Split('$');//.Replace("##", "|").Split('|');
                    foreach (string q in sb)
                    {
                        if (!string.IsNullOrEmpty(q))
                        {
                            InfoGPS = this.ParseVT300(q, Cliente.ToString());
                        }
                    }
                    return InfoGPS;
                }
                else if ((data.Contains("RGP") || data.Contains("RGL")) &&
                        (!data.Contains("#IP") && !data.Contains("#SM") && !data.Contains("#LOG")))
                //Para reportes de VIRLOC, T-1000 y otros que usan VIRLOC RGP
                {
                    return this.ParseRGPVirloc(data, Cliente.ToString());
                }
                //Reportes de TK1000
                else if (data.Contains(">") && data.Contains("!") &&
                        data.Contains(",") && data.Contains("*") && data.Contains("-"))
                {
                    return this.ParseTK1000(data, Cliente.ToString());
                }
                //Reportes de G831
                else if (data.Contains("$") && data.Contains(",") && data.Contains("*"))
                {
                    return this.ParseG381(data, Cliente.ToString());
                }
                else if (data.Contains("RP") && data.Contains(">") && data.Contains("<"))
                {
                    return this.ParseRPRASTREAR(data, Cliente.ToString());
                }
            }
            catch (Exception X)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(X);
            }
            return null;
        }

        public static byte[] byte_GetACK(string data)
        {
            StringBuilder respuesta = new StringBuilder();
            byte[] sendBytes = null;
            if ((data.Contains("RGP") || data.Contains("RGL") || data.Contains("RIM")) &&
                (data.Contains("#IP") || data.Contains("#SM") || data.Contains("#LOG")))
            //Para reportes TRAX-S4
            {
                respuesta.Append(GPS_Class.ACK_TRAXS4(data));
                sendBytes = Encoding.ASCII.GetBytes(respuesta.ToString());
            }
            else if ((data.Contains("RGP") || data.Contains("RGL")) &&
                    (!data.Contains("#IP") && !data.Contains("#SM") && !data.Contains("#LOG")))
            //Para reportes de VIRLOC, T-1000 y otros que usan VIRLOC RGP
            {
                respuesta.Append(GPS_Class.ACK_VIRLOC(data));
                sendBytes = Encoding.ASCII.GetBytes(respuesta.ToString());
            }
            //Reportes de TK1000
            else if (data.Contains(">") && data.Contains("!") &&
                    data.Contains(",") && data.Contains("*") && data.Contains("-"))
            {
                respuesta.Append(GPS_Class.ACK_TK1000());
                sendBytes = Encoding.ASCII.GetBytes(respuesta.ToString());
            }
            //Reportes de G831
            else if (data.Contains("$") && data.Contains(",") && data.Contains("*"))
            {
                respuesta.Append(GPS_Class.ACK_G381(data));
                sendBytes = Encoding.ASCII.GetBytes(respuesta.ToString());
            }
            return sendBytes;
        }

        public static string GetACK(string data)
        {
            if ((data.Contains("RGP") || data.Contains("RGL")) &&
                (data.Contains("#IP") || data.Contains("#SM") || data.Contains("#LOG")))
            //Para reportes TRAX-S4
            {
                return GPS_Class.ACK_TRAXS4(data);
            }
            else if ((data.Contains("RGP") || data.Contains("RGL")) &&
                    (!data.Contains("#IP") && !data.Contains("#SM") && !data.Contains("#LOG")))
            //Para reportes de VIRLOC, T-1000 y otros que usan VIRLOC RGP
            {
                return GPS_Class.ACK_VIRLOC(data);
            }
            //Reportes de TK1000
            else if (data.Contains(">") && data.Contains("!") &&
                    data.Contains(",") && data.Contains("*") && data.Contains("-"))
            {
                return GPS_Class.ACK_TK1000();
            }
            //Reportes de G831
            else if (data.Contains("$") && data.Contains(",") && data.Contains("*"))
            {
                return GPS_Class.ACK_G381(data);
            }
            return "NO_ACK";
        }
    }
}