/** Servidor TCP - Basado en trabajos
 * opensource sobre TCP/IP
 * http://www.codeproject.com/KB/IP/CommLibrary.aspx
 **/

using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Npgsql;

//using System.Windows.Forms;

namespace RASTREO_Lib
{
    public class RASTREO_TCPServer
    {
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

        public class TCPServer
        {
            public string Protocolo = string.Empty;
            public string IPResend = string.Empty;
            public string PORTResend = string.Empty;
            public bool Resend = false;

            private bool _puerto_en_uso = false;

            public bool Puerto_en_Uso
            {
                get { return _puerto_en_uso; }
            }

            private bool TCPRunning = false;

            public bool Running
            {
                get { return TCPRunning; }
                set { TCPRunning = value; }
            }

            private RASTREO_SQLThreads _myGPS_SQLthread;

            public RASTREO_SQLThreads myGPS_SQLThread
            {
                set { _myGPS_SQLthread = value; }
                get { return _myGPS_SQLthread; }
            }

            private int _tcp_port = 0;

            public int Puerto
            {
                get { return _tcp_port; }
                set { _tcp_port = value; }
            }

            private long conteoAnterior = 0;

            public TCPServer(string Puerto_de_escucha, string IP, string PORT, string PROTO)
            {
                try
                {
                    IPResend = IP;
                    PORTResend = PORT;
                    Puerto = Convert.ToInt32(Puerto_de_escucha);
                    Protocolo = PROTO;
                }
                catch (Exception Ex) { Funciones_de_soporte.Manejador_de_Excepciones(Ex); }
            }

            public TCPServer(string Puerto_de_escucha, string IP, string PORT, string PROTO, long ConteoAnterior)
            {
                try
                {
                    IPResend = IP;
                    PORTResend = PORT;
                    Puerto = Convert.ToInt32(Puerto_de_escucha);
                    Protocolo = PROTO;
                    conteoAnterior = ConteoAnterior;
                }
                catch (Exception Ex) { Funciones_de_soporte.Manejador_de_Excepciones(Ex); }
            }

            public TCPServer(int Puerto_de_escucha)
            {
                try
                {
                    Puerto = Puerto_de_escucha;
                }
                catch (Exception Ex) { Funciones_de_soporte.Manejador_de_Excepciones(Ex); }
            }

            public TCPServer(int Puerto_de_escucha, long ConteoAnterior)
            {
                try
                {
                    Puerto = Puerto_de_escucha;
                    conteoAnterior = ConteoAnterior;
                }
                catch (Exception Ex) { Funciones_de_soporte.Manejador_de_Excepciones(Ex); }
            }

            public TCPServer(string Puerto_de_escucha, long ConteoAnterior)
            {
                try
                {
                    Puerto = Convert.ToInt32(Puerto_de_escucha);
                    conteoAnterior = ConteoAnterior;
                }
                catch (Exception Ex) { Funciones_de_soporte.Manejador_de_Excepciones(Ex); }
            }

            public void StopListening()
            {
                try
                {
                    if (Running)
                    {
                        Running = false;
                        if (this.myGPS_SQLThread != null)
                            this.myGPS_SQLThread.DetenerSQLThreads();
                        //_myGPS_SQLthread = null;
                        TcpClient TC = new TcpClient("127.0.0.1", Puerto);
                    }
                    //se puede utitizar "127.0.0.1" en caso de que el servidor no tenga seteado el "loopback"
                }
                //catch(Exception Ex) { Funciones_de_soporte.Manejador_de_Excepciones(Ex); }
                catch (Exception) { }
                //finally { GC.Collect(); }
            }

            public void StartListening()
            {
                if (!Running)
                {
                    TCPClientConnectionPool ConnectionPool = new TCPClientConnectionPool();
                    TCPClientService ClientTask;

                    this.myGPS_SQLThread = new RASTREO_SQLThreads(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).TotalHours, Puerto);

                    if (conteoAnterior > 0)
                    {
                        this.myGPS_SQLThread.TotalInsertado = conteoAnterior;
                        this.myGPS_SQLThread.TotalRecibido = conteoAnterior;
                    }

                    if (IPResend != string.Empty && PORTResend != string.Empty)
                    {
                        this.myGPS_SQLThread.Reenvio_activado = true;
                        this.myGPS_SQLThread.IP_a_Reenviar = IPResend;
                        this.myGPS_SQLThread.Puerto_para_reenvio = Convert.ToInt32(PORTResend);
                        this.myGPS_SQLThread.Protocolo_a_reenviar = Protocolo;
                    }

                    // Pool de conexiones de clientes.

                    // Tareas para manejar los pedidos de los clientes.
                    ClientTask = new TCPClientService(ConnectionPool);

                    ClientTask.Start();

                    TcpListener listener = new TcpListener(System.Net.IPAddress.Any, Puerto);

                    try
                    {
                        listener.Start();
                        Funciones_de_soporte.Mensaje_de_Log_PORT("TCP_" + Puerto.ToString(), "Escucha de puerto TCP [" + Puerto + "] iniciada.");
                        // Iniciar la escucha para conexiones entrantes.
                        Running = true;
                        while (Running)
                        {
                            try
                            {
                                TcpClient handler = listener.AcceptTcpClient();
                                if (handler != null)
                                {
                                    // Una conexion entrate debe ser procesada.
                                    ConnectionPool.Enqueue(new ClientHandler(handler, Puerto, ref this._myGPS_SQLthread));
                                }
                                //else
                                //    break;
                            }
                            catch (SocketException NetEX)
                            {
                                switch (NetEX.SocketErrorCode)
                                {
                                    case SocketError.ConnectionReset:
                                        continue;
                                }
                            }
                            Thread.Sleep(150);
                        }
                        // Detengo el Servidor TCP

                        listener.Stop();
                        // Detengo la conexion con el cliente.
                        ClientTask.Stop();
                        Funciones_de_soporte.Mensaje_de_Log_PORT("TCP_" +
                            Puerto.ToString(), "Escucha de puerto TCP [" + Puerto + "] detenida.");
                        if (myGPS_SQLThread != null)
                        {
                            Funciones_de_soporte.Mensaje_de_Log_PORT("TCP_" +
                                Puerto.ToString(), "Total de paquetes recibidos en esta sesión [" +
                                myGPS_SQLThread.TotalInsertado.ToString() + "].");
                        }
                    }
                    catch (System.Net.Sockets.SocketException exNET)
                    {
                        switch (exNET.SocketErrorCode)
                        {
                            case SocketError.AddressAlreadyInUse:
                                //MessageBox.Show("El puerto TCP " + Puerto.ToString() +
                                //" está en uso, por favor verifique la configuración.",
                                //"Error de conexión.", MessageBoxButtons.OK);
                                _puerto_en_uso = true;
                                // Detengo el Servidor TCP
                                listener.Stop();
                                // Detengo la conexion con el cliente.
                                ClientTask.Stop();
                                break;
                            default:
                                exNET.Data.Add("rawdata", "PuertoTCP " + Puerto);
                                Funciones_de_soporte.Manejador_de_Excepciones(exNET);
                                break;
                        }
                        //exNET.SocketErrorCode
                    }
                    catch (Exception e)
                    {
                        e.Data.Add("rawdata", "PuertoTCP " + Puerto);
                        Funciones_de_soporte.Manejador_de_Excepciones(e);
                    }
                    finally
                    {
                        if (_myGPS_SQLthread != null)
                            _myGPS_SQLthread.DetenerSQLThreads();
                    }
                }
            }
        } //clase TCPServer - princpial clase de uso para servidor TCP

        private class TCPClientConnectionPool
        {
            // Crea un "envoltorio" sincronizado alrededor de la cola UDP.
            private Queue SyncdQ = Queue.Synchronized(new Queue());

            public void Enqueue(ClientHandler client)
            {
                SyncdQ.Enqueue(client);
            }

            public ClientHandler Dequeue()
            {
                return (ClientHandler)(SyncdQ.Dequeue());
            }

            public int Count
            {
                get { return SyncdQ.Count; }
            }

            public object SyncRoot
            {
                get { return SyncdQ.SyncRoot; }
            }
        } // clase ClientConnectionPool - helper para TCPServer

        private class TCPClientService
        {
            const int NUM_OF_THREAD = 20;

            private TCPClientConnectionPool ConnectionPool;
            private bool ContinueProcess = false;
            private Thread[] ThreadTask = new Thread[NUM_OF_THREAD];

            public TCPClientService(TCPClientConnectionPool ConnectionPool)
            {
                this.ConnectionPool = ConnectionPool;
            }

            public void Start()
            {
                ContinueProcess = true;
                // Iniciar threads para manejar las tareas de los clientes.
                for (int i = 0; i < ThreadTask.Length; i++)
                {
                    ThreadTask[i] = new Thread(new ThreadStart(this.Process));
                    ThreadTask[i].Start();
                }
            }

            private void Process()
            {
                while (ContinueProcess)
                {
                    ClientHandler client = null;
                    lock (ConnectionPool.SyncRoot)
                    {
                        if (ConnectionPool.Count > 0)
                            client = ConnectionPool.Dequeue();
                    }
                    if (client != null)
                    {
                        client.Process(); // Invocar procesos para manejar el cliente.
                        // Si el cliente está todavia conectado, se coloca en cola para procesarlo luego.
                        if (client.Alive)
                            ConnectionPool.Enqueue(client);
                    }
                    Thread.Sleep(150);
                }
            }

            public void Stop()
            {
                ContinueProcess = false;
                for (int i = 0; i < ThreadTask.Length; i++)
                {
                    if (ThreadTask[i] != null)
                        if (ThreadTask[i].IsAlive)
                            ThreadTask[i].Join(1);
                }

                // Cerrar todas las conexiones con los clientes.
                lock (ConnectionPool.SyncRoot)
                {
                    while (ConnectionPool.Count > 0)
                    {
                        ClientHandler client = ConnectionPool.Dequeue();
                        client.Close();
                        Thread.Sleep(150);
                        //return "Conexión con el cliente ha sido cerrada.";
                    }
                }
            }
        } // clase ClientService  - helper para TCPServer

        private class ClientHandler
        {
            private int PuertoTCP = 0;
            private RASTREO_SQLThreads GPSSQLThread;
            private EstructuraGPS Info_GPS = new EstructuraGPS();
            private TcpClient ClientSocket;
            private NetworkStream networkStream;
            bool ContinueProcess = false;
            private byte[] bytes; 		// Buffer de datos para los datos entrantes.
            private StringBuilder sb = new StringBuilder(); // string de datos entrantes
            private string data = null; // data entrante del cliente.

            //private int maxWorkThreads = 0;//, maxIOThreads = 0;
            private Thread myQueueCMD;

            public void QueueCMDEquipos_DataThread()
            {
                NpgsqlConnection pg_CNN = new NpgsqlConnection(Properties.Settings.Default.RS_ServerCNNSTR);
                try
                {
                    pg_CNN.Open();
                    while (this.ClientSocket.Connected)
                    {
                        try
                        {
                            int idequipogps = -1;
                            string Select_Query =
                                "SELECT * FROM rsview_equipogps_comandos WHERE id_equipo_gps = '" +
                                Info_GPS.IdEquipo + "' " +
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
                                        StringBuilder sbCMD =
                                            new StringBuilder((string)viewcmd_reader["comando"]);
                                        this.networkStream.Write(Encoding.ASCII.GetBytes(sbCMD.ToString()), 0, sbCMD.Length);
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
                        catch (Exception EX)
                        {
                            Funciones_de_soporte.Informaciones_del_sistema("Falla en QueueCMDEquipos_DataThread" +
                                Environment.NewLine + EX.ToString());
                        }
                        Thread.Sleep(150);
                    }
                }
                catch (Exception EX)
                {
                    Funciones_de_soporte.Informaciones_del_sistema("Falla en QueueCMDEquipos_DataThread" +
                        Environment.NewLine + EX.ToString());
                }
                finally
                {
                    if (pg_CNN.State != System.Data.ConnectionState.Closed)
                        pg_CNN.Close();
                    pg_CNN.Dispose();
                    pg_CNN = null;
                }
            }

            public ClientHandler(TcpClient ClientSocket, int Puerto, ref RASTREO_SQLThreads _GPSSQLThread)
            {
                try
                {
                    ClientSocket.ReceiveTimeout = 500; // 100 miliseconds
                    this.ClientSocket = ClientSocket;
                    networkStream = ClientSocket.GetStream();
                    bytes = new byte[ClientSocket.ReceiveBufferSize];
                    GPSSQLThread = _GPSSQLThread;
                    PuertoTCP = Puerto;
                    ContinueProcess = true;
                    this.myQueueCMD = new Thread(new ThreadStart(this.QueueCMDEquipos_DataThread));
                    //this.myQueueCMD.Start();
                }
                catch (Exception EX)
                {
                    EX.Data.Add("rawdata", "PuertoTCP " + PuertoTCP + " - Datos: " + data);
                    Funciones_de_soporte.Manejador_de_Excepciones(EX);
                }
            }

            public void Process()
            {
                try
                {
                    int BytesRead = 0;
                    if (ClientSocket.Connected)
                    {
                        if (networkStream.DataAvailable)
                        {
                            BytesRead = networkStream.Read(bytes, 0, (int)bytes.Length);
                            if (BytesRead > 0)
                            {
                                // Puede que hayan mas datos, .entonces se guardan los actuales.
                                sb.Append(Encoding.Default.GetString(bytes, 0, BytesRead));
                            }
                        }
                        else
                        {
                            // Todos los datos han llegado, iniciar respuesta al cliente si es necesario.
                            if (sb.ToString().Contains("cmdsrv::"))
                            {
                                if (sb.ToString() == ("cmdsrv::hello\r\n"))
                                {
                                    StringBuilder Mensaje = new StringBuilder("Hello! Port[" +
                                        PuertoTCP.ToString() + "] Still Alive...");
                                    NpgsqlConnection _cnn = new NpgsqlConnection(Properties.Settings.Default.RS_ServerCNNSTR);
                                    NpgsqlCommand _cmd =
                                        new NpgsqlCommand(
                                            "SELECT MAX(gps_fecha), (SELECT DISTINCT count(gps_fecha) FROM rsview_vehiculo_bandejaentrada_cliente_equipogps WHERE gps_fecha >= to_char(now(), 'dd/MM/yyyy HH24:mi')::timestamp) as count FROM rsview_vehiculo_bandejaentrada_cliente_equipogps LIMIT 1",
                                            _cnn);
                                    try
                                    {
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
                                        networkStream.Write(Encoding.ASCII.GetBytes(Mensaje.ToString()), 0,
                                            Mensaje.Length);
                                        _rdr.Close();
                                        _rdr.Dispose();
                                    }
                                    catch
                                    {
                                    }
                                    finally
                                    {
                                        _cnn.Close();
                                        _cnn.Dispose();
                                        _cnn = null;
                                    }
                                }
                                //    if (sb.ToString().Contains("cmdsrv::close_port"))
                                //        Running = false;
                                //    if (sb.ToString().Contains("cmdsrv::open_port"))
                                //        Running = true;
                                sb.Length = 0;
                            }
                            else
                            {
                                //if (OldData != sb.ToString())
                                {
                                    ProcessDataReceived();
                                }
                                //OldData = sb.ToString();
                            }
                        }
                        //    if (sb.Length > 0)
                        //    {
                        //        ProcessDataReceived();
                        //    }
                        //}
                    }
                    else
                    {
                        networkStream.Close();
                        ClientSocket.Close();
                        ContinueProcess = false;
                    }
                }
                catch (IOException)
                {
                    // Todos los datos han llegado, iniciar respuesta al cliente si es necesario.
                    if (sb.Length > 0)
                        ProcessDataReceived();
                    networkStream.Close();
                    ClientSocket.Close();
                    ContinueProcess = false;
                }
                catch (SocketException)
                {
                    networkStream.Close();
                    ClientSocket.Close();
                    ContinueProcess = false;
                    //Console.WriteLine("Conexión rota!");
                }
            }  // Process()

            private void ProcessDataReceived()
            {
                try
                {
                    if (sb.Length > 0)
                    {
                        data = sb.ToString();

                        sb.Length = 0; // Clear buffer

                        Funciones_de_soporte.Mensaje_de_Log_PORT("TCP_" + PuertoTCP.ToString(), data);

                        GPSSQLThread.SaveGPSInfo(data, ClientSocket.Client.RemoteEndPoint);
                    }
                }
                catch (System.IO.IOException ioEX)
                {
                    //IO Exception
                    Funciones_de_soporte.Manejador_de_Excepciones(ioEX);
                }
                catch (System.NullReferenceException nullEX)
                {
                    //Excepcion de nulos
                    Funciones_de_soporte.Manejador_de_Excepciones(nullEX);
                }
                catch (Exception EX)
                {
                    Funciones_de_soporte.Manejador_de_Excepciones(EX);
                }
            }

            public void Close()
            {
                try
                {
                    if (myQueueCMD.IsAlive)
                        myQueueCMD.Join(1);
                    networkStream.Close();
                    ClientSocket.Close();
                }
                catch (Exception EX)
                {
                    Funciones_de_soporte.Manejador_de_Excepciones(EX);
                }
            }

            public bool Alive
            {
                get
                {
                    return ContinueProcess;
                }
            }
        } // clase ClientHandler  - helper para TCPServer
    } // Clase servidor TCP Multithread / Safe - Multiclient /Safe
}