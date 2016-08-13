/** Cliente UDP - Basado en trabajos
 * opensource sobre TCP/IP
 * http://www.codeproject.com/KB/IP/CommLibrary.aspx
 **/

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RASTREO_Lib
{
    public class RASTREO_UDPClient
    {
        public static void SendDataUDP(IPEndPoint remoteEP, string DataToSend)
        {
            UdpClient udpClient = new UdpClient();
            try
            {
                if (DataToSend.Length == 0) return;
                DataToSend = DataToSend.Trim();
                //.Replace("\r\n", ""), "\r\n" + Environment.NewLine);
                Byte[] sendBytes = Encoding.ASCII.GetBytes(DataToSend);
                udpClient.Send(sendBytes, sendBytes.Length, remoteEP);
                //sendBytes = udpClient.Receive(ref remoteEP); // no se si sacar...
                udpClient.Close();
            }
            catch (System.IO.IOException IOEX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(IOEX);
            }
            catch (SocketException NetEX)
            {
                //Console.WriteLine("Servidor no disponible!");
                //Funciones_de_soporte.Manejador_de_Excepciones(NetEX);
                string Mensaje = string.Empty;
                switch (NetEX.SocketErrorCode)
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
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
            }
        } // SendDataUDP() usando IpEndPoint

        public static void SendDataUDP(IPEndPoint remoteEP, Byte[] sendBytes)
        {
            UdpClient udpClient = new UdpClient();
            try
            {
                udpClient.Send(sendBytes, sendBytes.Length, remoteEP);
                udpClient.Close();
            }
            catch (System.IO.IOException IOEX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(IOEX);
            }
            catch (SocketException NetEX)
            {
                string Mensaje = string.Empty;
                switch (NetEX.SocketErrorCode)
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
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
            }
        } // SendDataUDP() usando IpEndPoint y directamente Bytes

        public static void SendDataUDP(IPEndPoint remoteEP, string DataToSend, bool ServerData)
        {
            UdpClient udpClient = new UdpClient();
            try
            {
                if (string.IsNullOrEmpty(DataToSend)) return;
                if (ServerData)
                    DataToSend = DataToSend.Trim().Replace("\r\n", "") + "\r\n";
                else
                    DataToSend = String.Concat(DataToSend.Trim());
                Byte[] sendBytes = Encoding.ASCII.GetBytes(DataToSend);
                udpClient.Send(sendBytes, sendBytes.Length, remoteEP);
                udpClient.Close();
            }
            catch (System.IO.IOException IOEX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(IOEX);
            }
            catch (SocketException NetEX)
            {
                //Console.WriteLine("Servidor no disponible!");
                //Funciones_de_soporte.Manejador_de_Excepciones(NetEX);
                string Mensaje = string.Empty;
                switch (NetEX.SocketErrorCode)
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
            catch (Exception EX)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
            }
        } // SendDataUDP() usando IpEndPoint

        public static bool SendDataUDP(string IP, string PORT, string DataToSend)
        {
            UdpClient udpClient = new UdpClient();
            try
            {
                if (DataToSend.Length == 0) return false;
                udpClient.EnableBroadcast = true;
                DataToSend = String.Concat(DataToSend.Trim() + '\n');
                Byte[] sendBytes = Encoding.ASCII.GetBytes(DataToSend);
                int purt = 0;
                if (Int32.TryParse(PORT, out purt))
                {
                    udpClient.Send(sendBytes, sendBytes.Length, IP, purt);
                    udpClient.Close();
                }
                else
                {
                    return false;
                }
                return true;
            }
            catch (System.IO.IOException)
            {
                return false;
                //Console.WriteLine("Servidor no disponible!");
            }
            catch (Exception EX)
            {
                //Console.WriteLine(e.ToString());
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
                return false;
            }
        } // SendDataUDP() usando Strings

        public static bool SendDataUDP(string IP, string PORT, Byte[] sendBytes)
        {
            UdpClient udpClient = new UdpClient();
            try
            {
                //if (DataToSend.Length == 0) return false;
                //DataToSend = String.Concat(DataToSend.Trim(), "\r\n");
                //Byte[] sendBytes = Encoding.ASCII.GetBytes(DataToSend);
                int purt = 0;
                if (Int32.TryParse(PORT, out purt))
                {
                    udpClient.Send(sendBytes, sendBytes.Length, IP, purt);
                    udpClient.Close();
                }
                else
                {
                    return false;
                }
                return true;
            }
            catch (System.IO.IOException)
            {
                return false;
                //Console.WriteLine("Servidor no disponible!");
            }
            catch (Exception EX)
            {
                //Console.WriteLine(e.ToString());
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
                return false;
            }
        } // SendDataUDP() usando Strings
    } // class RASTREO_TcpCLIENT
}