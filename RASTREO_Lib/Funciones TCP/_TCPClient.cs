/** Cliente TCP - Basado en trabajos 
 * opensource sobre TCP/IP 
 * http://www.codeproject.com/KB/IP/CommLibrary.aspx
 **/
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace RASTREO_Lib
{
    class RASTREO_TCPClient
    {
        public void SendDataTCP(IPEndPoint remoteEP, string DataToSend)
        {
            TcpClient tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(remoteEP.Address, remoteEP.Port);
                NetworkStream networkStream = tcpClient.GetStream();
                if (networkStream.CanWrite && networkStream.CanRead)
                {
                    if (DataToSend.Length == 0) return;
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(DataToSend);
                    bool Sended = false;
                    while(!Sended)
                    {
                        try
                        {
                            networkStream.Write(sendBytes, 0, sendBytes.Length);
                            Sended = true;
                        }
                        catch (SocketException)
                        {
                            continue;
                        }
                    }
                    // Lee del NetworkStream y coloca datos en el buffer de bytes.
                    //byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
                    //int BytesRead = networkStream.Read(bytes, 0, (int)tcpClient.ReceiveBufferSize);
                    // Retorna los datos que envia el servidor si este contestara.
                    //string returndata = Encoding.ASCII.GetString(bytes, 0, BytesRead);
                    //Console.WriteLine("El retorno del servidor: \r\n{0}", returndata);
                    networkStream.Close();
                    tcpClient.Close();
                }
                else if (!networkStream.CanRead)
                {
                    //Console.WriteLine("No se pueden escribir datos en el NetStream");
                    tcpClient.Close();
                }
                else if (!networkStream.CanWrite)
                {
                    //Console.WriteLine("No se pueden leer datos de el NetStream");
                    tcpClient.Close();
                }
            }
            catch (SocketException NetEX)
            {
                //Console.WriteLine("Servidor no disponible!");
                //Funciones_de_soporte.Manejador_de_Excepciones(NetEX);
                string Mensaje = string.Empty;
                switch(NetEX.SocketErrorCode)
                {
                    case SocketError.AddressNotAvailable:
                        Mensaje = "La direccion IP  [" + remoteEP.Address.ToString() + "] no está disponible.";
                        break;
                    case SocketError.ConnectionRefused:
                        Mensaje = "El servidor al que intenta conectar [" + remoteEP.Address.ToString() + "] no está disponible o ha rechazado la conexión.";
                        break;
                    default:
                        Mensaje = NetEX.SocketErrorCode.ToString();
                        break;
                }
                Funciones_de_soporte.Informaciones_del_sistema(Mensaje);
        }
            catch (System.IO.IOException)
            {
                //Console.WriteLine("Servidor no disponible!");
                tcpClient.Close();
            }
            catch (Exception EX)
            {
                //Console.WriteLine(e.ToString());
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
            }
        } // SendDataTCP() usando IpEndPoint

        public void SendDataTCP(string IP, string PORT, string DataToSend)
        {
            TcpClient tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(IPAddress.Parse(IP), Convert.ToInt32(PORT));
                NetworkStream networkStream = tcpClient.GetStream();
                if (networkStream.CanWrite && networkStream.CanRead)
                {
                    if (DataToSend.Length == 0) return;
                    DataToSend = DataToSend.Trim().Replace("\r\n", "") + "\r\n";
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(DataToSend);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    // Lee del NetworkStream y coloca datos en el buffer de bytes.
                    //byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
                    //int BytesRead = networkStream.Read(bytes, 0, (int)tcpClient.ReceiveBufferSize);
                    // Retorna los datos que envia el servidor si este contestara.
                    //string returndata = Encoding.ASCII.GetString(bytes, 0, BytesRead);
                    //Console.WriteLine("El retorno del servidor: \r\n{0}", returndata);
                    networkStream.Close();
                    tcpClient.Close();
                }
                else if (!networkStream.CanRead)
                {
                    //Console.WriteLine("No se pueden escribir datos en el NetStream");
                    tcpClient.Close();
                }
                else if (!networkStream.CanWrite)
                {
                    //Console.WriteLine("No se pueden leer datos de el NetStream");
                    tcpClient.Close();
                }
            }
            catch (SocketException NetEX)
            {
                //Console.WriteLine("El Servidor no está disponible!");
                //Funciones_de_soporte.Manejador_de_Excepciones(NetEX);
                string Mensaje = string.Empty;
                switch (NetEX.SocketErrorCode)
                {
                    case SocketError.AddressNotAvailable:
                        Mensaje = "La direccion IP  [" + IP + "] no está disponible.";
                        break;
                    case SocketError.ConnectionRefused:
                        Mensaje = "El servidor al que intenta conectar [" + IP + "] no no está disponible o ha rechazado la conexión.";
                        break;
                    default:
                        Mensaje = NetEX.SocketErrorCode.ToString();
                        break;
                }
                Funciones_de_soporte.Informaciones_del_sistema(Mensaje);
            }
            catch (System.IO.IOException)
            {
                //Console.WriteLine("El Servidor no está disponible!");
            }
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
            }
        } // SendDataTCP() usando Strings

    } // class RASTREO_TcpCLIENT

}