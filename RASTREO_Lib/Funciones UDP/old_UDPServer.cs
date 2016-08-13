/** Servidor UDP - Basado en trabajos 
 * opensource sobre TCP/IP 
 * http://www.codeproject.com/KB/IP/CommLibrary.aspx
 **/
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections;
using System.Threading;
//using System.Windows.Forms;
using Npgsql;

namespace RASTREO_Lib
{
    public class RASTREO_UDPServerDEPRECATED
    {
        class QueueUDP
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
        class QueueACKUDP
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

        public class UDPServer
        {
            private QueueUDP colaUDP;
            private QueueACKUDP colaACKUDP;

            private bool _puerto_en_uso = false;
            public bool Puerto_en_Uso
            {
                get { return _puerto_en_uso; }
            }

            private bool _rebootserver = false;
            public bool Reboot_UDPServer
            {
                get { return _rebootserver; }
            }

            private RASTREO_SQLThreads GPS_SQLthread = new RASTREO_SQLThreads();
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
            private bool _UDPRunning = false;
            public bool IsRunning
            {
                get { return _UDPRunning; }
                set { _UDPRunning = value; }
            }
            private IPEndPoint IPep = null;
            private UdpClient ClientSocket;
            private byte[] bytes; 		// Buffer de datos para los datos entrantes.
            private StringBuilder sb = new StringBuilder(); // string de datos entrantes
            //public string OldData = null;

            public string IPResend = string.Empty;
            public string PORTResend = string.Empty;
            public bool Resend = false;
            public string Protocolo = string.Empty;

            private Thread threadsaveUDP;
            private Thread threadACKUDP;

            public UDPServer(int Puerto_de_escucha, string IP, string PORT, string PROTO)
            {
                try
                {
                    Puerto = Puerto_de_escucha;
                    IPResend = IP;
                    PORTResend = PORT;
                    Protocolo = PROTO;
                    Resend = true;
                }
                catch (Exception Ex) { Funciones_de_soporte.Manejador_de_Excepciones(Ex); }
            }

            public UDPServer(int Puerto_de_escucha)
            {
                try
                {
                    Puerto = Puerto_de_escucha;
                }
                catch (Exception Ex) { Funciones_de_soporte.Manejador_de_Excepciones(Ex); }
            }



            public void StopListening()
            {
                try
                {
                    if (IsRunning)
                    {
                        IsRunning = false;
                        if (this.threadsaveUDP != null && this.threadsaveUDP.IsAlive)
                            this.threadsaveUDP.Join();
                        if (this.threadACKUDP != null && this.threadACKUDP.IsAlive)
                            this.threadACKUDP.Join();
                        UdpClient C = new UdpClient(IPAddress.Loopback.ToString(), Puerto);
                        StringBuilder endresponse = new StringBuilder("cmdsrv::close_port");
                        C.Send(Encoding.ASCII.GetBytes(endresponse.ToString()), endresponse.Length);
                    }
                    //se puede utitizar "127.0.0.1" en caso de que el servidor no tenga seteado el "loopback"
                }
                catch (Exception Ex) { Funciones_de_soporte.Manejador_de_Excepciones(Ex); }
            }

            public void StartListening()
            {
                // Pool de conexiones de clientes.
                try
                {
                    this.colaUDP = new QueueUDP();
                    this.colaACKUDP = new QueueACKUDP();
                    GPS_SQLthread = new RASTREO_SQLThreads(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).TotalHours, Puerto);
                    if (IPResend != string.Empty && PORTResend != string.Empty)
                    {
                        GPS_SQLthread.Reenvio_activado = Resend;
                        GPS_SQLthread.IP_a_Reenviar = IPResend;
                        GPS_SQLthread.Puerto_para_reenvio = Convert.ToInt32(PORTResend);
                        GPS_SQLthread.Protocolo_a_reenviar = Protocolo;
                    }
                    ClientSocket = new UdpClient(Puerto);//new IPEndPoint(IPAddress.Any,Puerto));
                    ClientSocket.EnableBroadcast = true;
                    IsRunning = true;
                    // Iniciar la escucha para conexiones entrantes.
                    Funciones_de_soporte.Mensaje_de_Log_PORT("UDP_" + Puerto.ToString(), "Escucha de puerto UDP [" + Puerto + "] iniciada.");
                    this.threadsaveUDP = new Thread(new ThreadStart(this.ProcessDataReceived));
                    this.threadsaveUDP.Start();
                    this.threadACKUDP = new Thread(new ThreadStart(this.qSendACK));
                    this.threadACKUDP.Start();
                    while (IsRunning)
                    {
                        try
                        {
                            Process();
                            //sThread.Sleep(1);
                        }
                        catch (SocketException NetEX)
                        {
                            switch (NetEX.SocketErrorCode)
                            {
                                case SocketError.ConnectionReset:
                                    ClientSocket = new UdpClient(Puerto);
                                    continue;
                            }
                        }
                        catch (NullReferenceException)
                        {
                            continue;
                        }
                        catch (Exception EX)
                        {
                            Funciones_de_soporte.Manejador_de_Excepciones(EX);
                            continue;
                        }
                    }
                    // Detener el Servidor UDP
                    ClientSocket.Close();
                    Funciones_de_soporte.Mensaje_de_Log_PORT("UDP_" +
                        Puerto.ToString(), "Escucha de puerto UDP [" + Puerto + "] detenida.");
                    Funciones_de_soporte.Mensaje_de_Log_PORT("UDP_" +
                            Puerto.ToString(), "Total de paquetes recibidos en esta sesión [" +
                            myGPS_SQLThread.TotalInsertado.ToString() + "].");
                }
                catch (ThreadAbortException tX)
                {
                    Funciones_de_soporte.Manejador_de_Excepciones(tX);
                }
                catch (System.Net.Sockets.SocketException exNET)
                {
                    switch (exNET.SocketErrorCode)
                    {
                        case SocketError.AddressAlreadyInUse:
                            // Detener el Servidor UDP
                            UdpClient C = new UdpClient(IPAddress.Loopback.ToString(), Puerto);
                            StringBuilder endresponse = new StringBuilder("cmdsrv::close_port");
                            C.Send(Encoding.ASCII.GetBytes(endresponse.ToString()), endresponse.Length);
                            if (ClientSocket != null)
                            {
                                ClientSocket.Close();
                            }
                            _rebootserver = true;
                            _puerto_en_uso = true;
                            //MessageBox.Show("El puerto [" +
                            //    Puerto + "] está en uso. Verifique configuraciones." +
                            //    Environment.NewLine + DateTime.Now.ToString(), "Puerto en uso")
                            // Detener la conexion con el cliente.
                            break;
                        default:
                            Funciones_de_soporte.Manejador_de_Excepciones(exNET);
                            break;
                    }
                    //exNET.SocketErrorCode 
                }
                catch (Exception e)
                {
                    Funciones_de_soporte.Manejador_de_Excepciones(e);
                }
                finally
                {
                    if (GPS_SQLthread != null)
                        GPS_SQLthread.DetenerSQLThreads();
                    if (ClientSocket != null)
                        ClientSocket.Close();
                }
            }

            public void Process()
            {
                try
                {
                    if (this.ClientSocket != null)
                    {
                        bytes = this.ClientSocket.Receive(ref IPep);
                        sb.Append(Encoding.Default.GetString(bytes, 0, bytes.Length));
                        //// Todos los datos han sido capturados, se inicia respuesta al cliente si fuere necesario.
                        if (sb.ToString().Contains("cmdsrv::"))
                        {
                            if (sb.ToString() == ("cmdsrv::hello\r\n"))
                            {
                                StringBuilder Mensaje = new StringBuilder("Hello! Port[" +
                                    Puerto.ToString() + "] Still Alive...");
                                NpgsqlConnection _cnn = new NpgsqlConnection(Properties.Settings.Default.RS_ServerCNNSTR);
                                NpgsqlCommand _cmd =
                                    new NpgsqlCommand(
                                        "SELECT MAX(gps_fecha), (SELECT DISTINCT count(gps_fecha) FROM rsview_vehiculo_bandejaentrada_cliente_equipogps WHERE gps_fecha >= to_char(now(), 'dd/MM/yyyy HH24:mi')::timestamp) as count FROM rsview_vehiculo_bandejaentrada_cliente_equipogps LIMIT 1",
                                        _cnn);
                                _cmd.CommandTimeout = 20;
                                _cmd.Connection.Open();
                                NpgsqlDataReader _rdr = _cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                                if (_rdr.HasRows)
                                {
                                    _rdr.Read();
                                    Mensaje.Append(_rdr.GetDateTime(0).ToString() +
                                        " - Report count: " +
                                        _rdr.GetInt64(1).ToString() +
                                        "\r\n");
                                }
                                else
                                    Mensaje.Append("BUT DB DOWN! :(\r\n");
                                this.ClientSocket.Send(Encoding.ASCII.GetBytes(Mensaje.ToString()),
                                    Mensaje.Length, IPep);
                                _rdr.Close();
                                _rdr.Dispose();
                                _cnn.Close();
                                _cnn.Dispose();
                            }
                        }
                        else
                        {
                            //if (OldData != sb.ToString())
                            {
                                if (!string.IsNullOrEmpty(sb.ToString()) && IPep != null)
                                {
                                    Object[] myData = new Object[2];
                                    myData[0] = sb.ToString();
                                    myData[1] = IPep;
                                    this.colaUDP.Enqueue(myData);
                                    this.colaACKUDP.Enqueue(myData);
                                }
                            }
                            //OldData = sb.ToString();
                        }
                    }
                }
                catch (ObjectDisposedException)
                {
                    return;
                }
                catch (IOException IOEX)
                {
                    // Todos los datos han llegado, iniciar respuesta al cliente si es necesario.
                    Funciones_de_soporte.Manejador_de_Excepciones(IOEX);
                }
                catch (SocketException)
                {
                    //if (ClientSocket != null)
                    //    ClientSocket.Close();
                    //Funciones_de_soporte.Manejador_de_Excepciones(sckEX);
                    //throw sckEX;
                    //Console.WriteLine("Conexión rota!");
                }
                catch (Exception X)
                {
                    Funciones_de_soporte.Manejador_de_Excepciones(X);
                }
                finally
                {
                    sb.Length = 0;
                }
            }  // Process()

            private void ProcessDataReceived()
            {
                try
                {
                    while (this.IsRunning)
                    {
                        try
                        {
                            lock (this.colaUDP.SyncRoot)
                            {
                                if (this.colaUDP.Count > 0)
                                {
                                    Object[] theData = this.colaUDP.Dequeue();
                                    string data = (string)theData[0]; // data entrante del cliente.
                                    IPEndPoint myIPEp = (IPEndPoint)theData[1]; // data entrante del cliente.
                                    try
                                    {
                                        if (data.Length > 0)
                                        {
                                            try
                                            {
                                                //EstructuraGPS Info_GPS = new EstructuraGPS();
                                                Funciones_de_soporte.Mensaje_de_Log_PORT("UDP_" + Puerto.ToString(),
                                                    data + "\t" + myIPEp.ToString());
                                                data = data.Replace("", ""); // el caracter de control ACK, lo elimino...                            
                                                //[Aqui se hace desglose del DATA recibido]
                                                if (data.Contains("\n"))
                                                {
                                                    foreach (string splitty in data.Split('\n'))
                                                    {
                                                        string datty = splitty.Trim();
                                                        if (string.IsNullOrEmpty(datty)) continue;
                                                        //GPS_SQLthread.SaveGPSInfo(datty, myIPEp);
                                                    }
                                                }
                                                else
                                                {
                                                    //GPS_SQLthread.SaveGPSInfo(data, myIPEp);
                                                }
                                                //}
                                            }
                                            catch (SocketException Nex)
                                            {
                                                Funciones_de_soporte.Manejador_de_Excepciones(Nex);
                                            }
                                            catch (Exception EX)
                                            {
                                                Funciones_de_soporte.Manejador_de_Excepciones(EX);
                                            }

                                        }
                                    }
                                    catch (System.IO.IOException IOEX)
                                    {
                                        //IO Exception
                                        Funciones_de_soporte.Manejador_de_Excepciones(IOEX);
                                    }
                                    catch (System.NullReferenceException NULLEX)
                                    {
                                        //Excepcion de nulos
                                        Funciones_de_soporte.Manejador_de_Excepciones(NULLEX);//, data);
                                    }
                                    catch (Exception EX)
                                    {
                                        Funciones_de_soporte.Manejador_de_Excepciones(EX);//, data);
                                    }
                                }
                                Thread.Sleep(1);
                            }
                        }
                        catch (Exception XX)
                        {
                            Funciones_de_soporte.Manejador_de_Excepciones(XX);
                        }
                    }
                }
                catch (Exception XX)
                {
                    Funciones_de_soporte.Manejador_de_Excepciones(XX);
                }
            }

            /*
            public void ProcessDataReceived(Object parsedata)
            {
                Object[] theData = (Object[])parsedata;
                string data = (string)theData[0]; // data entrante del cliente.
                IPEndPoint myIPEp= (IPEndPoint)theData[1]; // data entrante del cliente.
                try
                {
                    if (data.Length > 0)
                    {
                        try
                        {
                            EstructuraGPS Info_GPS = new EstructuraGPS();
                            Funciones_de_soporte.Mensaje_de_Log_PORT("UDP_" + Puerto.ToString(),
                                data + "\t" + myIPEp.ToString());
                            data = data.Replace("", ""); // el caracter de control ACK, lo elimino...                            
                            //[Aqui se hace desglose del DATA recibido]
                            if (data.Contains("\n"))
                            {
                                foreach (string splitty in data.Split('\n'))
                                {
                                    string datty = splitty.Trim();
                                    if (string.IsNullOrEmpty(datty)) continue;
                                    SendACK(RASTREO_SQLThreads.byte_GetACK(datty), myIPEp);
                                    GPS_SQLthread.SaveGPSInfo(datty, ref Info_GPS, myIPEp);
                                    if (Info_GPS != null)
                                        if (Info_GPS.Estado_de_Poscionamiento)
                                            GPS_SQLthread.TotalRecibido += 1;
                                }
                            }
                            else
                            {
                                SendACK(RASTREO_SQLThreads.byte_GetACK(data),myIPEp);
                                GPS_SQLthread.SaveGPSInfo(data, ref Info_GPS, myIPEp);
                                if (Info_GPS != null)
                                    if (Info_GPS.Estado_de_Poscionamiento)
                                        GPS_SQLthread.TotalRecibido += 1;
                            }                            
                            //}
                        }
                        catch (SocketException Nex)
                        {
                            Funciones_de_soporte.Manejador_de_Excepciones(Nex);
                        }
                        catch (Exception EX)
                        {
                            Funciones_de_soporte.Manejador_de_Excepciones(EX);
                        }

                    }
                }
                catch (System.IO.IOException IOEX)
                {
                    //IO Exception
                    Funciones_de_soporte.Manejador_de_Excepciones(IOEX);
                }
                catch (System.NullReferenceException NULLEX)
                {
                    //Excepcion de nulos
                    Funciones_de_soporte.Manejador_de_Excepciones(NULLEX);//, data);
                }
                catch (Exception EX)
                {
                    Funciones_de_soporte.Manejador_de_Excepciones(EX);//, data);
                }
                finally
                {
                    ;
                }
            }
            */

            private void qSendACK()
            {
                try
                {
                    int maxi = 0, maxo = 0;
                    ThreadPool.GetMaxThreads(out maxi, out maxo);
                    while (this.IsRunning)
                    {
                        lock (this.colaACKUDP.SyncRoot)
                        {
                            while (this.colaACKUDP.Count > 0)
                            {
                                Object[] theData = this.colaACKUDP.Dequeue();
                                if (theData != null)
                                {
                                    try
                                    {
                                        int i = 0, o = 0;
                                        ThreadPool.GetAvailableThreads(out i, out o);
                                        if (i > (maxi - 20))//(i > mini)
                                        {
                                            ThreadPool.QueueUserWorkItem(sendACKnow, theData);
                                        }   //Byte[] sendBytes = RASTREO_SQLThreads.byte_GetACK(data);
                                        //this.ClientSocket.Send(sendBytes, sendBytes.Length, myIPEp);
                                        //RASTREO_UDPClient.SendDataUDP(IPPORT, sendBytes);
                                        //RASTREO_UDPClient.SendDataUDP(IPPORT.Address.ToString(), IPPORT.Port.ToString(), sendBytes);
                                    }
                                    catch (InvalidOperationException IOEx)
                                    {
                                        Funciones_de_soporte.Manejador_de_Excepciones(IOEx);
                                    }
                                    catch (Exception Ex)
                                    {
                                        Funciones_de_soporte.Manejador_de_Excepciones(Ex);
                                    }
                                }
                            }
                            Thread.Sleep(1);
                        }
                    }
                }
                catch (Exception XX)
                {
                    Funciones_de_soporte.Manejador_de_Excepciones(XX);
                }
            }

            private void sendACKnow(Object ACKDATA)
            {
                try
                {
                    Object[] theData = (Object[])ACKDATA;
                    string data = (string)theData[0]; // data entrante del cliente.
                    IPEndPoint myIPEp = (IPEndPoint)theData[1]; // data entrante del cliente.
                    data = data.Replace("", "").Replace("\r", "").Replace("\n", "").Trim();
                    if (!string.IsNullOrEmpty(data))
                    {
                        Byte[] sendBytes = RASTREO_SQLThreads.byte_GetACK(data);
                        if (sendBytes != null)
                            this.ClientSocket.Send(sendBytes, sendBytes.Length, myIPEp);
                    }
                }
                catch (Exception XX)
                {
                    Funciones_de_soporte.Manejador_de_Excepciones(XX);
                }
            }


            private void SendACK(byte[] sendBytes, IPEndPoint IPPORT)
            {
                if (sendBytes != null)
                {
                    try
                    {
                        this.ClientSocket.Send(sendBytes, sendBytes.Length, IPPORT);
                        //RASTREO_UDPClient.SendDataUDP(IPPORT, sendBytes);
                        //RASTREO_UDPClient.SendDataUDP(IPPORT.Address.ToString(), IPPORT.Port.ToString(), sendBytes);
                    }
                    catch (InvalidOperationException IOEx)
                    {
                        Funciones_de_soporte.Manejador_de_Excepciones(IOEx);
                    }
                    catch (Exception Ex)
                    {
                        Funciones_de_soporte.Manejador_de_Excepciones(Ex);
                    }
                }
            }
        }// class UDPSocketListener

    }
}