/*
 * Clase de funciones de apoyo para el programa IncoopProcessParser
 * Autor: Christian Melgarejo Bresanovich
 * Fecha: Viernes, 05 de Setiembre de 2008, 09:15:26 a.m.
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Net;

//using System.Windows.Forms;
//using Microsoft.Data.ConnectionUI;

namespace RASTREO_Lib
{
    public class EstructuraCMD
    {
        private string _cmd = string.Empty;
        private string _idequipo = string.Empty;
        private string _ip = string.Empty;
        private string _port = string.Empty;
        private EndPoint _ipep = null;
        private string _protocolo = string.Empty;

        public string Protocolo
        {
            set { _protocolo = value; }
            get { return _protocolo; }
        }

        public string Comando
        {
            set { _cmd = value; }
            get { return _cmd; }
        }

        public string IdEquipo
        {
            set { _idequipo = value; }
            get { return _idequipo; }
        }

        public string IP
        {
            set { _ip = value; }
            get { return _ip; }
        }

        public string Puerto
        {
            set { _port = value; }
            get { return _port; }
        }

        public EndPoint cmdEndPoint
        {
            get { return _ipep; }
            set { _ipep = value; }
        }
    }

    public class EstructuraGPS
    {
        public string trama { get; set; }

        private DateTime FechaPosicion = DateTime.MinValue;
        public string EstadoIO = string.Empty;
        public string EdadDelDato = string.Empty;
        public string IdEquipo = string.Empty;
        public string TipoReporte = string.Empty;
        public string Status_SAT = string.Empty;
        public string Status_GSM = "0";
        public string Evento = string.Empty;
        //public string
        public int HDOP = 0;
        public int Velocidad = 0;
        public int Odometro = 0;
        public int Temperatura = 0;
        public int Rumbo = 0;
        public double Latitud = 0;
        public double Longitud = 0;
        public bool Estado_de_Poscionamiento = false;
        public string IP = string.Empty;
        public string Puerto = string.Empty;
        public string ACK = string.Empty;

        public void Limpiar()
        {
            this.IP = string.Empty;
            this.Puerto = string.Empty;
            this.IdEquipo = null;
            this.Latitud = 0;
            this.Longitud = 0;
            this.Velocidad = 0;
            this.Odometro = 0;
            this.Rumbo = 0;
            this.Evento = string.Empty;
            this.FechaPosicion = DateTime.Now;
            this.EstadoIO = null;
            this.HDOP = 0;
            this.EdadDelDato = string.Empty;
            this.Status_SAT = string.Empty;
            this.Status_GSM = string.Empty;
            this.Estado_de_Poscionamiento = false;
        }

        public override string ToString()
        {
            string ToString;
            try
            {
                ToString =
                    "Trama: " + this.trama ?? "(no seteado)" + Environment.NewLine +
                    "ID Equipo: " + this.IdEquipo + Environment.NewLine +
                    " Fecha    : " + this.Fecha.ToString() + Environment.NewLine +
                    " Latitud  : " + this.Latitud + Environment.NewLine +
                    " Longitud : " + this.Longitud + Environment.NewLine +
                    " Velocidad: " + this.Velocidad + Environment.NewLine +
                    " Odometro : " + this.Odometro + Environment.NewLine +
                    " Temperatura : " + this.Temperatura + Environment.NewLine +
                    " Rumbo    : " + this.Rumbo + Environment.NewLine +
                    " Estado IO: " + this.EstadoIO.ToString() + Environment.NewLine +
                    " IP       : " + this.IP + Environment.NewLine +
                    " Puerto   : " + this.Puerto + Environment.NewLine +
                    " Status SAT - " + this.Status_SAT.ToString() + Environment.NewLine +
                    " Status GSM - " + this.Status_GSM.ToString() + Environment.NewLine +
                    " Edad del Dato - " + this.EdadDelDato.ToString() + Environment.NewLine +
                    " Tipo de Reporte - " + this.TipoReporte;
                return ToString;
            }
            catch
            {
                ToString = "-NULLPOS-";
                return ToString;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return this.FechaPosicion;
            }
            set
            {
                this.FechaPosicion = value;
            }
        }

        public void FechaGMT(string FechaHora, double ZonaHoraria)
        {
            //® by Christian Melgarejo
            //Esta funcion convierte 1 string [FechaHora] a un dato DateTime
            //primeramente este parametro deben ser de 12 caracteres de
            //manera a ser parseado para convertirlo en valores validos de
            //fecha y hora.
            System.DateTime FechaEnvio;
            string Hora, Fecha;
            try
            {
                Fecha = FechaHora.Substring(0, 6);
                Hora = FechaHora.Substring(6, 6);
                if (Fecha.Length >= 6 && Hora.Length >= 6)
                {
                    Hora = Hora.PadRight(6, '0');
                    Hora = Hora.Substring(0, 2) + ":" +
                        Hora.Substring(2, 2) + ":" +
                        Hora.Substring(4, 2);
                    Fecha = Fecha.Substring(0, 2) + "/" +
                        Fecha.Substring(2, 2) + "/" +
                        Fecha.Substring(4, 2);
                }
                FechaEnvio = Convert.ToDateTime(Fecha + " " + Hora);
                FechaEnvio = FechaEnvio.AddHours(ZonaHoraria);
                this.FechaPosicion = FechaEnvio;
            }
            catch //(Exception TimeZoneEx)
            {
                //Guardar error plx
                FechaEnvio = System.DateTime.Now;
                this.FechaPosicion = FechaEnvio;
            }
        }

        public void FechaGMT_inverso(string FechaHora, double ZonaHoraria)
        {
            //® by Christian Melgarejo
            //Esta funcion convierte 1 string [FechaHora] formato YYMMDD a un dato DateTime
            //primeramente este parametro deben ser de 12 caracteres de
            //manera a ser parseado para convertirlo en valores validos de
            //fecha y hora.
            System.DateTime FechaEnvio;
            string Hora, Fecha;
            try
            {
                Fecha = FechaHora.Substring(0, 6);
                Hora = FechaHora.Substring(6, 6);
                if (Fecha.Length >= 6 && Hora.Length >= 6)
                {
                    Hora = Hora.PadRight(6, '0');
                    Hora = Hora.Substring(0, 2) + ":" +
                        Hora.Substring(2, 2) + ":" +
                        Hora.Substring(4, 2);
                    Fecha = Fecha.Substring(4, 2) + "/" +
                        Fecha.Substring(2, 2) + "/" +
                        Fecha.Substring(0, 2);
                }
                FechaEnvio = Convert.ToDateTime(Fecha + " " + Hora);
                FechaEnvio = FechaEnvio.AddHours(ZonaHoraria);
                this.FechaPosicion = FechaEnvio;
            }
            catch //(Exception TimeZoneEx)
            {
                //Guardar error plx
                FechaEnvio = System.DateTime.Now;
                this.FechaPosicion = FechaEnvio;
            }
        }
    }

    public class GPS_Class
    {
        #region "Funciones de Conversion de stream data a posiciones GPS"

        static public EstructuraGPS LoadG381(string tramaG381, double ZH)
        {
            //Autor: Christian Melgarejo
            //Funcion: Toma un string de posicionamiento RMC formato TK1000 y lo desglosa
            //de manera a que pueda utilizarse en una estructura de datos ordenada

            #region "Extracto del manual de G381"

            //           FORMATO DE MENSAJE DE RESPUESTA GPRS (Mensaje 2)
            //Un mensaje con este formato será transmitido únicamente por GPRS y SMS en caso de
            //pánico.

            //$B,6035,956,2517.8910,05730.8360,0,  0,384,180209,1706  ,1,   *49
            //$B,1555,777,3435.2320,05829.2680,0,248,256,310105,142016,1,512*41
            //$B,6035,1471,2516.8490,05737.9170,0,0,384,160709,1333,1*78

            //Campo 1      = Start string
            //Campo 2      = ID
            //Campo 3      = Secuencia de paquete
            //Campo 4      = Latitud
            //Campo 5      = Longitud
            //Campo 6      = Velocidad (nudo)
            //Campo 7      = Rumbo
            //Campo 8      = Estado de entradas y salidas  *
            //Campo 9      = Fecha
            //Campo 10    = Hora
            //Campo 11    = Validez
            //Campo 12    = Eventos especiales **
            //Campo 13     = Checksum

            //* Estado de entradas y salidas

            //bit 0 = Entrada 1        (1)
            //bit 1 = Entrada 2        (2)
            //bit 2 = Entrada 3        (4)
            //bit 3 = Entrada 4        (8)
            //bit 4 = Entrada 5        (16)
            //bit 5 = Bateria            (32)
            //bit 6 = Puerta             (64)
            //bit 7 = Salida 1         (128)
            //bit 8 = Salida 2         (256)
            //bit 9 = Señal de test  (512)

            //** Estado de eventos especiales
            //Página 10 de 22
            //bit1 = WP1      (1)
            //bit2 = WP2      (2)
            //bit3 = WP3      (4)
            //bit4 = WP4      (8)
            //bit5 = WP5      (16)
            //bit6 = WP6      (32)
            //bit7 = WP7      (64)
            //bit8 = WP8      (128)
            //bit9 = Falta de señal GPS   (256)
            //bit10 = Exceso de velocidad  (512)

            #endregion "Extracto del manual de G381"

            char[] delimitador = (",").ToCharArray();
            EstructuraGPS Posicion = new EstructuraGPS();
            string[] reporte_descompuesto = tramaG381.Split(delimitador);
            try
            {
                try
                {
                    Posicion.IdEquipo = Convert.ToInt32(reporte_descompuesto[1].Replace(">", "")).ToString();
                }
                catch
                {
                    Posicion.Estado_de_Poscionamiento = false;
                    return Posicion;
                }
                Posicion.EdadDelDato = "00";
                string Longi = reporte_descompuesto[4].Trim();

                //Como se cuando es negativo o no este asunto?????
                Posicion.Longitud = Convert.ToSingle(Convert.ToSingle(Longi.Substring(0, 3).Trim()) +
                                   Convert.ToSingle(Longi.Substring(3, Longi.Length - Longi.IndexOf('.') - 3)) / 60 +
                                   Convert.ToSingle(Longi.Substring(Longi.IndexOf('.') + 1)) / 600000);
                Posicion.Longitud *= -1;
                //if (reporte_descompuesto[5].Contains("W")) Posicion.Longitud *= -1;
                string Lat = reporte_descompuesto[3].Trim();
                Posicion.Latitud = Convert.ToSingle(Convert.ToSingle(Lat.Substring(0, 2).Trim()) +
                                   Convert.ToSingle(Lat.Substring(2, Lat.Length - Lat.IndexOf('.') - 3)) / 60 +
                                   Convert.ToSingle(Lat.Substring(Lat.IndexOf('.') + 1)) / 600000);
                Posicion.Latitud *= -1;
                //if (reporte_descompuesto[6].Contains("S")) Posicion.Latitud *= -1;

                Posicion.Velocidad = Convert.ToInt32(Convert.ToInt32(reporte_descompuesto[5].Trim()) * 1.8520043f);
                Posicion.Rumbo = Convert.ToInt32(reporte_descompuesto[6].Trim());
                Posicion.EstadoIO = reporte_descompuesto[7].Trim();
                Posicion.FechaGMT(reporte_descompuesto[8].Trim() + reporte_descompuesto[9].Trim(), ZH);
                if (reporte_descompuesto.Length < 12)
                {
                    Posicion.Status_SAT = reporte_descompuesto[10].Trim().Split("*".ToCharArray())[0];
                }
                else
                {
                    Posicion.Status_SAT = reporte_descompuesto[10].Trim();
                    Posicion.Evento = reporte_descompuesto[11].Trim().Split("*".ToCharArray())[0];
                }
                //Posicion.Evento=
                Posicion.TipoReporte = "G381";
                Posicion.Estado_de_Poscionamiento = true;
                return Posicion;
            }
            catch (Exception LoadG381ex)
            {
                LoadG381ex.Data.Add("POS_ERR", tramaG381);
                Funciones_de_soporte.Manejador_de_Excepciones(LoadG381ex);
                Posicion.Estado_de_Poscionamiento = false;
                return Posicion;
            }
        }

        static public EstructuraGPS LoadTK1000(string tramaTK, double ZH)
        {
            //Autor: Christian Melgarejo
            //Funcion: Toma un string de posicionamiento RMC formato TK1000 y lo desglosa
            //de manera a que pueda utilizarse en una estructura de datos ordenada

            #region "Extracto del manual de TK1000"

            //HeadID,status,GPS_fix,fecha,hora,longitud,latitud,Respuesta,velocidad,orientación,GSM_CSQ,EventoReportado,ADC0-ADC1,Pulso,Salidas,TESTSTRING*checksum! HeadID,status,GPS_fix,fecha,hora,longitud,latitud,Respuesta,velocidad,orientación,GSM_CSQ,EventoReportado,ADC0-ADC1,Pulso,Salidas,TESTSTRING*checksum!
            // Example 1.
            ////>12345678,1,1,070201,144111,W05829.2613,S3435.2313,,00,034,25,00,126-124,0,3,11111111*2d!
            // RASTREO Example
            ////>00006030,4,1,090218,170738,W05649.6636,S2528.5522,,00,000,12,00,000-000,0,0,01111111*37!
            ////>00006006,1,1,090605,194835,W05733.0997,S2519.4844,,00,299,11,00,000-000,0,0,01111111*36!
            ////>00006030,4,1,090218,170738,W05649.6636,S2528.5522,,00,000,12,00,000-000,0,0,01111111*37!
            ////>00006018,3,0,000000,000000,E00000.0000,N0000.0000,CHK,00,000,17,00,001-000,0,0,01111110*7f!
            ////>12345678,        --> Encabezado + ID
            ////1,                --> Period report
            ////1,                --> GPS Fixed
            ////070101,           --> Date AAMMDD
            ////144111,           --> Hora universal
            ////W05829.2613,      --> Longitud
            ////S3435.2313,       --> Latitud
            ////,                 --> Campo de comandos.  Este aparece el comando por el cual se solicito envio del paquete.
            ////00,               --> Velocidad en Knots
            ////034,              --> Rumbo en grados
            ////25,               --> Calidad de señal GSM (actualiza una vez por minuto)
            ////00,               --> Codigo de evento reportado.
            ////126-124,          --> ADC1 y ADC2
            ////0,                --> cantidad de pulsos contados
            ////3                 --> Estado de las salidas.  este momento estan activados salidas uno y dos.
            ////11111111          --> Test string.
            ////*fd!              --> Check sum y fin de paquete.

            #endregion "Extracto del manual de TK1000"

            EstructuraGPS Posicion = new EstructuraGPS();
            string[] reporte_TK1000 = tramaTK.Split(',');
            try
            {
                Posicion.IdEquipo = Convert.ToInt32(reporte_TK1000[0].Trim().Replace(">", "")).ToString();
                Posicion.EdadDelDato = "00";
                Posicion.Status_SAT = (reporte_TK1000[2].Trim() == "1") ? "OK" : "NOSIGNAL";
                Posicion.FechaGMT_inverso(reporte_TK1000[3].Trim() + reporte_TK1000[4].Trim(), ZH);
                string Longi = reporte_TK1000[5].Trim().Substring(1, reporte_TK1000[5].Length - 1);
                Posicion.Longitud = Convert.ToDouble(Convert.ToSingle(Longi.Substring(0, 3).Trim()) +
                                   Convert.ToDouble(Longi.Substring(3, Longi.IndexOf('.') - 3)) / 60 +
                                   Convert.ToDouble(Longi.Substring(Longi.IndexOf('.') + 1)) / 600000);
                if (reporte_TK1000[5].Contains("W")) Posicion.Longitud *= -1;
                string Lat = reporte_TK1000[6].Trim().Substring(1, reporte_TK1000[6].Length - 1);
                Posicion.Latitud = Convert.ToDouble(Convert.ToSingle(Lat.Substring(0, 2).Trim()) +
                                   Convert.ToDouble(Lat.Substring(2, Lat.IndexOf('.') - 2)) / 60 +
                                   Convert.ToDouble(Lat.Substring(Lat.IndexOf('.') + 1)) / 600000);
                if (reporte_TK1000[6].Contains("S")) Posicion.Latitud *= -1;
                //reporte_descompuesto[7]; //Campo de comandos.  Este aparece el comando por el cual se solicito envio del paquete.
                if (reporte_TK1000[8].Trim() != string.Empty)
                {
                    //if (reporte_TK1000[8].Trim().PadLeft(3, '0') == "CHK")
                    //    Posicion.Velocidad = 0;
                    //else
                    Posicion.Velocidad = Convert.ToInt32(Convert.ToInt32(reporte_TK1000[8].Trim().PadLeft(3, '0')) * 1.8520043f);
                }
                else
                {
                    Posicion.Velocidad = 0;
                }
                if (reporte_TK1000[9].Trim() != string.Empty)
                {
                    Posicion.Rumbo = Convert.ToInt32(reporte_TK1000[8].Trim());
                }
                else
                {
                    Posicion.Rumbo = 0;
                }
                Posicion.Status_GSM = reporte_TK1000[10].Trim();
                Posicion.Evento = reporte_TK1000[11].Trim();
                //reporte_descompuesto[11];
                //reporte_descompuesto[12];
                Posicion.EstadoIO = reporte_TK1000[12].Trim();
                //Posicion.Evento=
                Posicion.Estado_de_Poscionamiento = true;
                Posicion.TipoReporte = "TK1000";
                return Posicion;
            }
            catch (Exception LoadRGPex)
            {
                LoadRGPex.Data.Add("POS_ERR", Environment.NewLine + "\nReporte: \n" + tramaTK);
                Funciones_de_soporte.Informaciones_del_sistema(LoadRGPex.ToString() + "n" + tramaTK);
                Posicion.Estado_de_Poscionamiento = false;
                return Posicion;
            }
        }

        static public EstructuraGPS LoadTRAXS4(string tramaRGPTRAX, double ZH)
        {
            //Autor: Christian Melgarejo
            //Funcion: Toma un string de posicionamiento RGP tipo TRAXS4 y lo desglosa
            //de manera a que pueda utilizarse en una estructura de datos ordenada
            string tmpFH = string.Empty;
            EstructuraGPS Posicion = new EstructuraGPS();
            if (tramaRGPTRAX.Length < 45) { Posicion.Estado_de_Poscionamiento = false; return Posicion; }
            Posicion.trama = tramaRGPTRAX;

            try
            {
                #region "Extracto del manual de TRAXS4"

                //                RGP241207150026-3460180-05847823018156300F400
                //2412071 Fecha (DDMMAA)
                //150026 Hora (HHMMSS)
                //-3460180 Latitud (Ej : -34.60180°)
                //-05847823 Longitud (Ej : -58.47823°)
                //018 Velocidad en MPH (0..999)
                //156 Dirección (0..359)
                //Norte = 0, Este = 90, Sur = 180, Oeste = 270
                //3 3 = Posición 3D, 2 = Posición 2D
                //00 Edad del dato en hexadecimal (00..FF)
                //F4 Estado de las entradas digitales en hexadecimal
                //    0x80 Estado de Contacto o Ignición
                //    0x40 Estado de Alimentación Principal
                //    0x20 Entrada digital 5
                //    0x10 Entrada digital 4
                //    0x08 Entrada digital 3
                //    0x04 Entrada digital 2
                //    0x02 Entrada digital 1
                //    0x01 Entrada digital 0
                //00 Número de evento que generó el reporte en decimal.
                //Cuando el reporte es generado por una consulta es 00

                #endregion "Extracto del manual de TRAXS4"

                tramaRGPTRAX = tramaRGPTRAX.Substring(tramaRGPTRAX.IndexOf("RG")).Trim();
                tmpFH = tramaRGPTRAX.Substring(3, 12);
                Posicion.IdEquipo = tramaRGPTRAX.Substring(tramaRGPTRAX.IndexOf("ID=") + 3).Split(';')[0];
                Posicion.FechaGMT(tmpFH, ZH);
                Posicion.Latitud = Convert.ToSingle(tramaRGPTRAX.Substring(15, 8)) / 100000;
                Posicion.Longitud = Convert.ToSingle(tramaRGPTRAX.Substring(23, 9)) / 100000;
                string Vel = tramaRGPTRAX.Substring(32, 3);
                double mph = Convert.ToSingle(Vel) * 1.8520043f;
                Posicion.Velocidad = Convert.ToInt32(mph);
                Posicion.Rumbo = Convert.ToInt16(tramaRGPTRAX.Substring(35, 3));
                Posicion.Status_SAT = tramaRGPTRAX.Substring(38, 1);
                Posicion.EdadDelDato = tramaRGPTRAX.Substring(39, 2);
                Posicion.EstadoIO = tramaRGPTRAX.Substring(41, 2);
                try
                {
                    Posicion.Evento = tramaRGPTRAX.Substring(43, 2);
                }
                catch (FormatException)
                {
                    Posicion.Evento = string.Empty;
                }
                //if (!isRGL)
                //{
                //    try
                //    {
                //        Posicion.HDOP = Convert.ToInt16(RGPString.Substring(45, 2));
                //    }
                //    catch (FormatException)
                //    {
                //        Posicion.HDOP = 0;
                //    }
                //}
                Posicion.Estado_de_Poscionamiento = true;
                Posicion.TipoReporte = "RGPTRAX";
                return Posicion;
            }
            catch (Exception LoadRGPex)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(LoadRGPex);
                Posicion.Estado_de_Poscionamiento = false;
                return Posicion;
            }
        }

        static public EstructuraGPS LoadRIMTRAX(string tramaRIMTRAX, double ZH)
        {
            //Autor: Christian Melgarejo
            //Funcion: Toma un string de posicionamiento RGP tipo TRAXS4 y lo desglosa
            //de manera a que pueda utilizarse en una estructura de datos ordenada

            string tmpFH = string.Empty;
            EstructuraGPS Posicion = new EstructuraGPS();
            Posicion.trama = tramaRIMTRAX;
            //bool isRGL = false;
            try
            {
                #region "Extracto del manual de TRAXS4

                //    RIM261207140452-3460183-058478210600010360540000042782000000072000000F400
                //261207 Fecha Actual (DDMMAA)
                //140452 Hora Actual (HHMMSS)
                //-3460183 Latitud (Ej : -34.60183°)
                //-05847821 Longitud (Ej : -58.47821°)
                //06 Cantidad de satélites detectados en la última posición válida
                //000 Edad de señal GPS de la última posición válida en segundos (000 a 255)
                //1 Estado de energía del GPS (0=apagado 1=prendido)
                //036 Dirección (0..359) de la última posición valida
                //054 Velocidad en KPH (0..999) de la última posición válida
                //0000042782 Odómetro Total en Metros
                //0000000720 Odómetro Parcial en Metros
                //00000 Revoluciones del Motor (solo si hay un dispositivo que la entrege)
                //F4 Estado de las entradas digitales en hexadecimal
                //    0x80 Estado de Contacto o Ignición
                //    0x40 Estado de Alimentación Principal
                //    0x20 Entrada digital 5
                //    0x10 Entrada digital 4
                //    0x08 Entrada digital 3
                //    0x04 Entrada digital 2
                //    0x02 Entrada digital 1
                //    0x01 Entrada digital 0
                //00 Número de evento que generó el reporte en decimal.
                //Cuando el reporte es generado por una consulta es 00

                #endregion "Extracto del manual de TRAXS4

                //if (RGPString.IndexOf("RGL") > 0) isRGL = true;
                tramaRIMTRAX = tramaRIMTRAX.Substring(tramaRIMTRAX.IndexOf("RIM")).Trim();
                tmpFH = tramaRIMTRAX.Substring(3, 12);
                Posicion.IdEquipo = tramaRIMTRAX.Substring(tramaRIMTRAX.IndexOf("ID=") + 3).Split(';')[0];
                Posicion.FechaGMT(tmpFH, ZH);
                Posicion.Latitud = Convert.ToSingle(tramaRIMTRAX.Substring(15, 8)) / 100000;
                Posicion.Longitud = Convert.ToSingle(tramaRIMTRAX.Substring(23, 9)) / 100000;
                string Vel = tramaRIMTRAX.Substring(41, 3);
                //32,2 es cantidad de satelites ; 34,3 es edad senial gps ; 37,1 estado energia GPS
                //38,3 es direccion -rumbo ; 41,3 es velocidad ; 44,10 es odometro total en metros
                //54,10 es odometro parcial en metros ; 64,5 es RPM del motor ; 69,2 IO ; 71,2 Evento
                double mph = Convert.ToSingle(Vel) * 1.8520043f;
                Posicion.Velocidad = Convert.ToInt32(mph);
                Posicion.Odometro = Convert.ToInt32(tramaRIMTRAX.Substring(44, 10));
                Posicion.Rumbo = Convert.ToInt16(tramaRIMTRAX.Substring(38, 3));
                Posicion.Status_SAT = tramaRIMTRAX.Substring(32, 2);
                Posicion.EdadDelDato = tramaRIMTRAX.Substring(34, 3);
                Posicion.EstadoIO = tramaRIMTRAX.Substring(69, 2);
                try
                {
                    Posicion.Evento = tramaRIMTRAX.Substring(71, 2);
                }
                catch (FormatException)
                {
                    Posicion.Evento = string.Empty;
                }
                Posicion.Estado_de_Poscionamiento = true;
                Posicion.TipoReporte = "RGPTRAX";
                return Posicion;
            }
            catch (Exception LoadRGPex)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(LoadRGPex);
                Posicion.Estado_de_Poscionamiento = false;
                return Posicion;
            }
        }

        static public EstructuraGPS LoadRPRASTREAR(string tramaRP, double ZH)
        {
            //Autor: Christian Melgarejo
            //Funcion: Toma un string de posicionamiento RP tipo equipo TEST RASTREAR y lo desglosa
            //de manera a que pueda utilizarse en una estructura de datos ordenada

            string tmpFH = string.Empty;
            EstructuraGPS Posicion = new EstructuraGPS();
            Posicion.trama = tramaRP;
            //bool isRGL = false;
            try
            {
                #region "Extracto del manual de RASTREAR

                #endregion "Extracto del manual de RASTREAR

                tramaRP = tramaRP.Substring(tramaRP.IndexOf("RP")).Trim();
                tmpFH = tramaRP.Substring(2, 12);
                Posicion.IdEquipo = tramaRP.Split(';')[1].Trim();
                Posicion.FechaGMT(tmpFH, ZH);
                //Posicion.Latitud = Convert.ToSingle(RGPString.Substring(14, 9)) / 1000000;
                string tmp = tramaRP.Substring(15, 8);
                Posicion.Latitud = Convert.ToSingle(Convert.ToSingle(tmp.Substring(0, 2).Trim()) +
                                   Convert.ToSingle(tmp.Substring(2, 2)) / 60 +
                                   Convert.ToSingle(tmp.Substring(4, tmp.Length - 4)) / 600000);
                if (tramaRP.Substring(14, 1) == "-") Posicion.Latitud *= -1;
                //Posicion.Longitud = Convert.ToSingle(RGPString.Substring(23, 10)) / 1000000;
                tmp = tramaRP.Substring(24, 9);
                Posicion.Longitud = Convert.ToSingle(Convert.ToSingle(tmp.Substring(0, 3).Trim()) +
                                   Convert.ToSingle(tmp.Substring(3, 2)) / 60 +
                                   Convert.ToSingle(tmp.Substring(5, tmp.Length - 5)) / 600000);
                if (tramaRP.Substring(23, 1) == "-") Posicion.Longitud *= -1;
                string Vel = tramaRP.Substring(33, 3);
                Posicion.Velocidad = Convert.ToInt32(Convert.ToSingle(Vel) * 1.853248f);
                Posicion.Rumbo = Convert.ToInt16(tramaRP.Substring(36, 3));
                //Posicion.Status_SAT = RGPString.Substring(38, 1);
                //Posicion.EdadDelDato = RGPString.Substring(39, 2);
                Posicion.EstadoIO = tramaRP.Substring(39, 2);
                /*try
                {
                    Posicion.Evento = RGPString.Substring(43, 2);
                }
                catch (FormatException)
                {
                    Posicion.Evento = string.Empty;
                }*/
                //if (!isRGL)
                //{
                //    try
                //    {
                //        Posicion.HDOP = Convert.ToInt16(RGPString.Substring(45, 2));
                //    }
                //    catch (FormatException)
                //    {
                //        Posicion.HDOP = 0;
                //    }
                //}
                Posicion.Estado_de_Poscionamiento = true;
                Posicion.TipoReporte = "RPRASTREAR";
                return Posicion;
            }
            catch (Exception LoadRGPex)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(LoadRGPex);
                Posicion.Estado_de_Poscionamiento = false;
                return Posicion;
            }
        }

        static public EstructuraGPS LoadRGP(string tramaRGP, double ZH)
        {
            //Autor: Christian Melgarejo
            //Funcion: Toma un string de posicionamiento RGP tipo VIRLOC y lo desglosa
            //de manera a que pueda utilizarse en una estructura de datos ordenada
            string tmpFH = string.Empty;
            EstructuraGPS Posicion = new EstructuraGPS();
            Posicion.trama = tramaRGP;
            bool isRGL = false;
            try
            {
                #region "Extracto del manual de VIRLOC"

                //QGP  Pregunta por la posición. El dispositivo responde

                //RGP220800000621-3463425-05862602000053300FD0002

                //220800   (DDMMAA) Fecha del momento en que se genera el reporte.
                //000621   (HHMMSS) Hora (GMT) del momento que se genera el reporte.
                //-3463425 Latitud de la última posición valida con grados y decimales (ej : -34,63425°)
                //-05862602 Longitud de la última posición valida con grados y decimales (ej : -058,62602°)
                //000   Velocidad en kilómetros por hora de la ultima posición valida (0 ..999).
                //053  Orientación  de la ultima posición valida (0 ..359), Norte = 0, Este = 90, Sur = 180, Oeste = 270.
                //3   Estado del posicionamiento del GPS  de la ultima posición valida
                //0 = Posicionando con solo 1 satélite.
                //1 = Posicionando con 2 satélites
                //2 = Posicionando con 3 satélites (2D).
                //3 = Posicionando con 4 o más satélites (3D).
                //4 = Posición en 2D calculada por aproximación de cuadrados mínimos.
                //5 = Posición en 3D calculada por aproximación de cuadrados mínimos.
                //6 = Posición calculada sin satélites, por velocidad, sentido y tiempo.
                //8 = Antena en corto circuito
                //9 = Antena no conectada
                //00 Cantidad de segundos desde que se tomó la última posición, respecto al momento de generar el reporte.
                //(En Hexadecimal) .
                //FD Estado de las entradas digitales en Hexadecimal
                //bit 7 Ignición.
                //bit 6 Fuente de poder principal.
                //bit 5 Entrada digital 5
                //bit 4 Entrada digital 4
                //bit 3 Entrada digital 3.
                //bit 2 Entrada digital 2.
                //bit 1 Entrada digital 1.
                //bit 0 Entrada digital 0.
                //00 Numero de evento generado expresado en decimal.
                //02 Dilución horizontal de la precisión HDOP (0..50) de la ultima posición valida
                //[space]

                #endregion "Extracto del manual de VIRLOC"

                if (tramaRGP.IndexOf("RGL") > 0) isRGL = true;
                tramaRGP = tramaRGP.Substring(tramaRGP.IndexOf("RG")).Trim();
                tmpFH = tramaRGP.Substring(3, 12);
                Posicion.IdEquipo = tramaRGP.Substring(tramaRGP.IndexOf("ID=") + 3).Split(';')[0];
                Posicion.FechaGMT(tmpFH, ZH);
                Posicion.Latitud = Convert.ToSingle(tramaRGP.Substring(15, 8)) / 100000;
                Posicion.Longitud = Convert.ToSingle(tramaRGP.Substring(23, 9)) / 100000;
                Posicion.Velocidad = Convert.ToInt16(tramaRGP.Substring(32, 3));
                Posicion.Rumbo = Convert.ToInt16(tramaRGP.Substring(35, 3));
                Posicion.Status_SAT = tramaRGP.Substring(38, 1);
                Posicion.EdadDelDato = tramaRGP.Substring(39, 2);
                Posicion.EstadoIO = tramaRGP.Substring(41, 2);
                try
                {
                    Posicion.Evento = tramaRGP.Substring(43, 2);
                }
                catch (FormatException)
                {
                    Posicion.Evento = string.Empty;
                }
                if (!isRGL)
                {
                    try
                    {
                        Posicion.HDOP = Convert.ToInt16(tramaRGP.Substring(45, 2));
                    }
                    catch (FormatException)
                    {
                        Posicion.HDOP = 0;
                    }
                }
                Posicion.Estado_de_Poscionamiento = true;
                Posicion.TipoReporte = "RGP";
                return Posicion;
            }
            catch (Exception LoadRGPex)
            {
                LoadRGPex.Data.Add("POS_ERR", tramaRGP);
                Funciones_de_soporte.Manejador_de_Excepciones(LoadRGPex);
                Posicion.Estado_de_Poscionamiento = false;
                return Posicion;
            }
        }

        static public EstructuraGPS LoadRMC(string tramaRMC, double ZH)
        {
            //Autor: Christian Melgarejo
            //Funcion: Toma un string de posicionamiento RMC y lo desglosa
            //de manera a que pueda utilizarse en una estructura de datos ordenada
            //ID=0817;$GPRMC,192208.594,A,2518.6426,S,05735.4873,W,0.4,353.9,090806,,*0F
            float tmpFloat; int tmpInt = 0; string tmpStr;
            char[] delimitador = (",").ToCharArray();
            EstructuraGPS Posicion = new EstructuraGPS();
            Posicion.trama = tramaRMC;
            Posicion.EdadDelDato = "00";
            try
            {
                tmpInt = tramaRMC.IndexOf("ID");
                if (tmpInt >= 0) tramaRMC = tramaRMC.Substring(tramaRMC.IndexOf("ID"));
                string[] sRMC = tramaRMC.Split(delimitador);
                tmpInt = sRMC[3].IndexOf(".");
                if (tmpInt >= 0 && tramaRMC.IndexOf("ID") >= 0)
                {
                    /*
                    Posicion.Latitud = Convert.ToSingle(Convert.ToSingle(sRMC[3].Substring(0, 2).Trim()) +
                        Convert.ToSingle(sRMC[3].Substring(2, 2)) / 60 +
                        Convert.ToSingle(sRMC[3].Substring(5, 4)) / 600000);
                    */
                    Posicion.Latitud = Convert.ToSingle(Convert.ToSingle(sRMC[3].Substring(0, 2).Trim()) +
                                       Convert.ToSingle(sRMC[3].Substring(2, sRMC[3].Length - sRMC[3].IndexOf('.') - 3)) / 60 +
                                       Convert.ToSingle(sRMC[3].Substring(sRMC[3].IndexOf('.') + 1)) / 600000);

                    if (sRMC[4] == "S") Posicion.Latitud *= -1;
                    /*
                    Posicion.Longitud = Convert.ToSingle(Convert.ToSingle(sRMC[5].Substring(0, 3).Trim()) +
                        Convert.ToSingle(Convert.ToSingle(sRMC[5].Substring(3, 2)) / Convert.ToSingle(60)) +
                        Convert.ToSingle(Convert.ToSingle(sRMC[5].Substring(6, 4)) / Convert.ToSingle(600000)));
                    */
                    Posicion.Longitud = Convert.ToSingle(Convert.ToSingle(sRMC[5].Substring(0, 3).Trim()) +
                                       Convert.ToSingle(sRMC[5].Substring(3, sRMC[5].Length - sRMC[5].IndexOf('.') - 3)) / 60 +
                                       Convert.ToSingle(sRMC[5].Substring(sRMC[5].IndexOf('.') + 1)) / 600000);

                    if (sRMC[6] == "W") Posicion.Longitud *= -1;
                    tmpInt = sRMC[7].IndexOf(".");
                    if (tmpInt >= 0)
                    {
                        int cantzero = 1;
                        tmpInt++;
                        tmpStr = sRMC[7].Substring(tmpInt);
                        tmpInt = tmpStr.Length;
                        for (int i = 0; i < tmpInt; i++)
                            cantzero *= 10;
                        tmpFloat = Convert.ToSingle(sRMC[7].Substring(0, sRMC[7].IndexOf("."))) +
                            Convert.ToSingle(tmpStr) / cantzero;
                        tmpFloat *= 1.853248f;
                    }
                    else
                    {
                        if (String.Compare(sRMC[7].ToString().Trim(), "") == 0)
                            tmpFloat = 0;
                        else
                            tmpFloat = Convert.ToSingle(sRMC[7].ToString().Trim());
                        tmpFloat *= 1.853248f;
                    }
                    Posicion.Velocidad = Convert.ToInt32(Math.Floor(tmpFloat));
                    tmpInt = sRMC[8].IndexOf(".");
                    if (tmpInt >= 0)
                    {
                        int cantzero = 1;
                        tmpInt++;
                        tmpStr = sRMC[8].Substring(tmpInt);
                        tmpInt = tmpStr.Length;
                        for (int i = 0; i < tmpInt; i++)
                            cantzero *= 10;
                        tmpFloat = Convert.ToSingle(sRMC[8].Substring(0, sRMC[8].IndexOf("."))) +
                            Convert.ToSingle(tmpStr) / cantzero;
                    }
                    else
                    {
                        if (tmpInt < 0)
                            tmpFloat = 0;
                        else
                            tmpFloat = Convert.ToSingle(sRMC[8].ToString().Trim());
                    }
                    Posicion.Rumbo = Convert.ToInt16(Math.Floor(tmpFloat));
                    Posicion.IdEquipo = sRMC[0].Substring(3, (sRMC[0].IndexOf(";") - 3)).Trim();
                    if (sRMC[9].Length > 6)
                        sRMC[9] = sRMC[9].Substring(0, 6);
                    Posicion.FechaGMT((sRMC[9] + sRMC[1]), ZH);
                    Posicion.EstadoIO = sRMC[2];
                    Posicion.Status_SAT = sRMC[2].Trim(); // mientras tanto, luego hay q comprar con el V o el A.
                    //if (sRMC[2].Trim() == "V")
                    //    Posicion.Status_SAT = "1";
                    //else if (sRMC[2].Trim() == "A")
                    //    Posicion.Status_SAT = "3";
                    Posicion.Estado_de_Poscionamiento = true;
                    Posicion.TipoReporte = "RMC";
                    return Posicion;
                }
                else
                    Posicion.Estado_de_Poscionamiento = false;
                return Posicion;
            }
            catch (Exception LoadRGPex)
            {
                Funciones_de_soporte.Manejador_de_Excepciones(LoadRGPex);
                Posicion.Estado_de_Poscionamiento = false;
                return Posicion;
            }
        }

        static public EstructuraGPS LoadVT300(string tramaVT300, double ZH)
        {
            float tmpFloat;
            int tmpInt = 0;
            string tmpStr;
            EstructuraGPS Posicion = new EstructuraGPS();
            //Autor: Christian Melgarejo
            //Funcion: Toma un string de posicionamiento RMC del VT300 y lo desglosa
            //de manera a que pueda utilizarse en una estructura de datos ordenada
            //$$108???????????&A9955&B192757.000,A,2517.5173,S,05737.4095,W,0.00,172.13,120110,,,A*64|1.2|&C01000000&D00000000&E00000000##
            try
            {
                string tramaRMC = string.Empty;
                Posicion.trama = tramaVT300;
                Posicion.Estado_de_Poscionamiento = false;

                if (tramaVT300.Length < 80)
                    return Posicion;

                string[] vt300 = tramaVT300.Split('&');
                Posicion.IdEquipo = vt300[0].Replace("$", "").Replace("?", "").Replace("\n", "").Trim();
                Posicion.EdadDelDato = "00";

                if (vt300.Length > 2)
                {
                    if (vt300[2][0] == 'B')
                    {
                        tramaRMC = "$GPRMC," + vt300[2].Substring(1);
                    }
                }

                if (tramaRMC != string.Empty && vt300.Length > 1)
                {
                    Posicion.Evento = vt300[1].Replace("A99", "");
                    string[] sRMC = tramaRMC.Split(',');
                    tmpInt = sRMC[3].IndexOf(".");
                    Posicion.Latitud = Convert.ToSingle(Convert.ToSingle(sRMC[3].Substring(0, 2).Trim()) +
                                       Convert.ToSingle(sRMC[3].Substring(2, sRMC[3].Length - sRMC[3].IndexOf('.') - 3)) / 60 +
                                       Convert.ToSingle(sRMC[3].Substring(sRMC[3].IndexOf('.') + 1)) / 600000);
                    //Posicion.Latitud = Convert.ToSingle(Convert.ToSingle(sRMC[3].Substring(0, 2).Trim()) +
                    //                    Convert.ToSingle(sRMC[3].Substring(2, (sRMC[3].Length - 2))) / 60);
                    if (sRMC[4] == "S") Posicion.Latitud *= -1;
                    Posicion.Longitud = Convert.ToSingle(Convert.ToSingle(sRMC[5].Substring(0, 3).Trim()) +
                                       Convert.ToSingle(sRMC[5].Substring(3, sRMC[5].Length - sRMC[5].IndexOf('.') - 3)) / 60 +
                                       Convert.ToSingle(sRMC[5].Substring(sRMC[5].IndexOf('.') + 1)) / 600000);
                    //Posicion.Longitud = Convert.ToSingle(Convert.ToSingle(sRMC[5].Substring(0, 3).Trim()) +
                    //                    Convert.ToSingle(sRMC[5].Substring(2, (sRMC[5].Length - 3))) / 60);
                    if (sRMC[6] == "W") Posicion.Longitud *= -1;
                    tmpInt = sRMC[7].IndexOf(".");
                    if (tmpInt >= 0)
                    {
                        int cantzero = 1;
                        tmpInt++;
                        tmpStr = sRMC[7].Substring(tmpInt);
                        tmpInt = tmpStr.Length;
                        for (int i = 0; i < tmpInt; i++)
                            cantzero *= 10;
                        tmpFloat = Convert.ToSingle(sRMC[7].Substring(0, sRMC[7].IndexOf("."))) +
                            Convert.ToSingle(tmpStr) / cantzero;
                        tmpFloat *= 1.853248f;
                    }
                    else
                    {
                        if (String.Compare(sRMC[7].ToString().Trim(), "") == 0)
                            tmpFloat = 0;
                        else
                            tmpFloat = Convert.ToSingle(sRMC[7].ToString().Trim());
                        tmpFloat *= 1.853248f;
                    }
                    tmpFloat = (tmpFloat > 10) ? tmpFloat : 0;
                    Posicion.Velocidad = Convert.ToInt32(Math.Floor(tmpFloat));
                    tmpInt = sRMC[8].IndexOf(".");
                    if (tmpInt >= 0)
                    {
                        int cantzero = 1;
                        tmpInt++;
                        tmpStr = sRMC[8].Substring(tmpInt);
                        tmpInt = tmpStr.Length;
                        for (int i = 0; i < tmpInt; i++)
                            cantzero *= 10;
                        tmpFloat = Convert.ToSingle(sRMC[8].Substring(0, sRMC[8].IndexOf("."))) +
                            Convert.ToSingle(tmpStr) / cantzero;
                    }
                    else
                    {
                        if (tmpInt < 0)
                            tmpFloat = 0;
                        else
                            tmpFloat = Convert.ToSingle(sRMC[8].ToString().Trim());
                    }
                    Posicion.Rumbo = Convert.ToInt16(Math.Floor(tmpFloat));
                    if (sRMC[9].Length > 6)
                        sRMC[9] = sRMC[9].Substring(0, 6);
                    Posicion.FechaGMT((sRMC[9] + sRMC[1]), ZH);
                    Posicion.EstadoIO = sRMC[2];
                    Posicion.Status_SAT = sRMC[2].Trim(); // mientras tanto, luego hay q comprar con el V o el A.
                    Posicion.Status_GSM = "OK";
                    //if (sRMC[2].Trim() == "V")
                    //    Posicion.Status_SAT = "1";
                    //else if (sRMC[2].Trim() == "A")
                    //    Posicion.Status_SAT = "3";
                    foreach (string q in vt300)
                    {
                        if (q.Contains("Y"))
                        {
                            string t1 = q.Substring(1, 4);
                            string t2 = q.Substring(5, 4);
                            t1 = t1.Replace(":", "A").Replace(";", "B").Replace("<", "C").Replace("=", "D").Replace(">", "E").Replace("?", "F");
                            t2 = t2.Replace(":", "A").Replace(";", "B").Replace("<", "C").Replace("=", "D").Replace(">", "E").Replace("?", "F");
                            int AD1 = Convert.ToInt32(t1, 16);
                            int AD2 = Convert.ToInt32(t2, 16);
                            Posicion.Temperatura = getTemperatura(AD1);
                            //Posicion.Temperatura = getTemperatura(AD2); //si es que usa otra conexion hay que ver...
                        }
                    }
                    Posicion.Estado_de_Poscionamiento = true;
                    Posicion.TipoReporte = "VT300";
                }
                return Posicion;
            }
            catch (Exception LoadVT300ex)
            {
                LoadVT300ex.Data.Add("POS_ERR", tramaVT300);
                Funciones_de_soporte.Informaciones_del_sistema(LoadVT300ex.ToString(),
                    System.Diagnostics.EventLogEntryType.FailureAudit);
                Posicion.Estado_de_Poscionamiento = false;
                return Posicion;
            }
        }

        private static int getTemperatura(int ADVal)
        {
            int temp = 0;
            try
            {
                //int tmp = 0;
                if (ADVal > 0 && ADVal <= 16)
                {
                    temp = -40;
                    //tmp = (ADVal * 40 / 16) - 40; //yapiro la conversion, los chinos no explican nada bien.
                }
                else if (ADVal > 16 && ADVal < 33)
                {
                    temp = -35;
                }
                else if (ADVal >= 33 && ADVal < 50)
                {
                    temp = -30;
                }
                else if (ADVal >= 50 && ADVal < 66)
                {
                    temp = -20;
                }
                else if (ADVal >= 66 && ADVal < 83)
                {
                    temp = -10;
                }
                else if (ADVal >= 83 && ADVal < 100)
                {
                    temp = 0;
                }
                else if (ADVal >= 100 && ADVal < 116)
                {
                    temp = 10;
                }
                else if (ADVal >= 116 && ADVal < 133)
                {
                    temp = 20;
                }
                else if (ADVal >= 133 && ADVal < 150)
                {
                    temp = 30;
                }
                else if (ADVal >= 150 && ADVal < 166)
                {
                    temp = 40;
                }
                else if (ADVal >= 166 && ADVal < 182)
                {
                    temp = 50;
                }
                else if (ADVal >= 182 && ADVal < 198)
                {
                    temp = 60;
                }
                else if (ADVal >= 198 && ADVal < 214)
                {
                    temp = 70;
                }
                else if (ADVal >= 214 && ADVal < 230)
                {
                    temp = 80;
                }
                else if (ADVal >= 230 && ADVal < 246)
                {
                    temp = 90;
                }
                else if (ADVal >= 246 && ADVal < 264)
                {
                    temp = 100;
                }
                else if (ADVal >= 264 && ADVal < 280)
                {
                    temp = 110;
                }
                else if (ADVal >= 280 && ADVal < 296)
                {
                    temp = 120;
                }
                else if (ADVal >= 296 && ADVal < 312)
                {
                    temp = 130;
                }
                else if (ADVal >= 312 && ADVal < 328)
                {
                    temp = 140;
                }
                else if (ADVal >= 328)
                {
                    temp = 150;
                }
            }
            catch (Exception ex)
            {
                Funciones_de_soporte.Informaciones_del_sistema(ex.ToString(),
                    System.Diagnostics.EventLogEntryType.Warning);
                temp = 0;
            }
            return temp;
        }

        #endregion "Funciones de Conversion de stream data a posiciones GPS"

        #region "Funciones Varias: CheckSum, Re-envio de Paquetes"

        static public string GetCheckSum(string msg)
        {
            int ChkSum = 0;
            foreach (char r in msg)
            {
                if (r == '*')
                    break;
                else
                    ChkSum = ChkSum ^ r;
            }
            string resultado = Convert.ToString(ChkSum, 16).ToUpper();
            if (resultado.Length < 2)
                return "0" + resultado;
            else
                return resultado;
        }

        static public string ACK_TK1000()
        {
            //string ACKMsg = String.Concat("$OK!\r\n");
            return "$OK!\r\n";
        }

        static public string ACK_G381(string paquete)
        {
            //$B, ID, Str (2048 + Val(paquete)), 00, $E
            string ID = string.Empty;
            string ACKMsg = String.Empty;
            char[] separator = ",".ToCharArray();
            ID = paquete.Split(separator)[1];
            paquete = paquete.Split(separator)[2];
            int Paq = 0;
            if (Int32.TryParse(paquete, out Paq))
            {
                Paq += 2048;
                ACKMsg = "$B," + ID + "," + Paq.ToString() + ",00,$E\r\n";
            }
            return ACKMsg;
        }

        static public string ACK_TRAXS4(string Mensaje)
        {
            try
            {
                //string ACKMsg = String.Concat(">SAK;", Mensaje.Split(';')[1], ";",
                //    Mensaje.Split(';')[2], "<\r\n");
                return ">SAK;" + Mensaje.Split(';')[1] + ";" + Mensaje.Split(';')[2] + "<\r\n";
            }
            catch (Exception EX)
            {
                EX.Data.Add("[POS_ERR]", Mensaje);
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
                return string.Empty;
            }
        }

        static public string ACK_VIRLOC(string Mensaje)
        {
            try
            {
                string ACKMsg = ">ACK;" + Mensaje.Split(';')[1] + ";" + Mensaje.Split(';')[2] + ";*";
                return ACKMsg + GetCheckSum(ACKMsg) + "<\r\n";
            }
            catch (Exception EX)
            {
                EX.Data.Add("POS_ERR", Mensaje);
                Funciones_de_soporte.Manejador_de_Excepciones(EX);
                return string.Empty;
            }
        }

        #endregion "Funciones Varias: CheckSum, Re-envio de Paquetes"
    }

    public class Funciones_de_soporte
    {
        /// <summary>
        /// Genera la locacion a partir de una longitud y latitud definidas
        /// </summary>
        /// <param name="lat">latitud</param>
        /// <param name="lng">longitud</param>
        /// <returns></returns>
        public static string getLocation_ReverseGeocode(string lat, string lng)
        {
            string Pais = "-";
            string Distrito = "-";
            string Localidad1 = "-";
            string Localidad2 = "-";
            string Direccion = "-";
            string Obs = string.Empty;
            try
            {
                lat = lat.Replace(",", ".");
                lng = lng.Replace(",", ".");
                HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create("http://ws.geonames.org/extendedFindNearby?lat=" + lat + "&lng=" + lng);
                //webReq.TransferEncoding = "UTF8"
                webReq.Timeout = 3000;
                //From here on, it's all the same as above.
                HttpWebResponse WebResp = (HttpWebResponse)webReq.GetResponse();
                //Let's show some information about the response
                //Now, we read the response (the string), and output it.
                Stream Answer = WebResp.GetResponseStream();
                StreamReader _Answer = new StreamReader(Answer);

                //Congratulations, with these two functions in basic form, you just learned
                //the two basic forms of web surfing
                //This proves how easy it can be.
                string resultado = _Answer.ReadToEnd();

                System.Xml.XmlDocument xml = new System.Xml.XmlDocument();

                xml.LoadXml(resultado);

                Pais = xml.SelectNodes("/geonames")[0].ChildNodes[2].ChildNodes[0].InnerText;
                Distrito = xml.SelectNodes("/geonames")[0].ChildNodes[3].ChildNodes[0].InnerText;
                Localidad1 = xml.SelectNodes("/geonames")[0].ChildNodes[4].ChildNodes[0].InnerText;
                Localidad2 = xml.SelectNodes("/geonames")[0].ChildNodes[5].ChildNodes[0].InnerText.Replace("Banco San Miguel", "Barrio San Miguel");

                Obs = Pais + ", " + Distrito + ", " + Localidad1 + ", " + Localidad2 + ", " + Direccion;
                return Obs;
            }
            catch
            {
                Obs = Pais + ", " + Distrito + ", " + Localidad1 + ", " + Localidad2 + ", " + Direccion;
                return Obs;
            }
        }

        ///// <summary>
        ///// Instancia un dialogo de creación de Cadena de Conexión.
        ///// Utiliza: Microsoft.Data.ConnectionUI.Dialog.dll
        ///// </summary>
        ///// <remarks>
        ///// Utiliza los siguientes nombres de espacios:
        ///// - System;
        ///// - System.IO;
        ///// - System.Text;
        ///// - System.Windows.Forms;
        ///// - Microsoft.Data.ConnectionUI;
        ///// </remarks>
        //static public string fxCAM_Crear_Cadena_de_Conexion()
        //{
        //    // Instancio el diálogo...
        //    // Hago using, porque es necesario hacer un dispose al final
        //    // utilizando "using" .NET hace un dispose automático de la instancia.
        //    try
        //    {
        //        using (DataConnectionDialog dlg = new DataConnectionDialog())
        //        {
        //            // Cargar en el diálogo los providers disponibles en el sistema
        //            DataSource.AddStandardDataSources(dlg);
        //            // Mostrar el diálogo
        //            bool Oki = false;
        //            while (!Oki)
        //            {
        //                if (DataConnectionDialog.Show(dlg) == DialogResult.OK)
        //                    Oki = true;
        //            }
        //            return dlg.ConnectionString;
        //        }
        //    }
        //    catch
        //    {
        //        return string.Empty;
        //    }
        //}

        /// <summary>
        /// Función para crear un archivo de LOG a partir de
        /// una lista de Items del tipo ListBox.ObjectCollection
        /// </summary>
        /// <remarks>
        /// Utiliza los siguientes nombres de espacios:
        /// - System;
        /// - System.IO;
        /// - System.Text;
        /// - System.Windows.Forms;
        /// - System.Collections.Generic;
        /// </remarks>
        /// <param name="LOG">
        /// Variable comprendida por una lista del tipo
        /// ListBox.ObjectCollection cada uno de los items
        /// representa una linea en el archivo de LOG.
        /// </param>
        /// <returns>
        /// Si ha sido completado satisfactoriamente el proceso.
        /// </returns>
        ///

        //Windows.FORMS
        /*
        public static void Tail(string fileName, ref System.Windows.Forms.TextBox Consola)
        {
            using (StreamReader reader = new StreamReader(new FileStream(fileName,
                 FileMode.Open, FileAccess.Read, FileShare.Read)))
            {
                //start at the end of the file

                long lastMaxOffset = reader.BaseStream.Length;

                while (true)
                {
                    System.Threading.Thread.Sleep(300);

                    //if the file size has not changed, idle

                    if (reader.BaseStream.Length == lastMaxOffset)
                        continue;

                    //seek to the last max offset

                    reader.BaseStream.Seek(lastMaxOffset, SeekOrigin.Begin);

                    //read out of the file until the EOF

                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        Consola.Text += Environment.NewLine + line;
                        Consola.SelectionStart = Consola.Text.Length;
                    }
                    //update the last max offset

                    lastMaxOffset = reader.BaseStream.Position;
                }
            }
        }

        static public bool fxCAM_DumpLog(ListBox.ObjectCollection LOG, bool showme)
        {
            try
            {
                //Obtengo el nombre del directorio en el cual se está
                //ejecutando el programa actual utilizando GetDirectoryName
                string myAppPath = "\\RASTREAR_SRV\\PORT_LOGS";//Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                //Crea un objeto DirectoryInfo para almacenar datos de mi directorio LOG
                DirectoryInfo AppPath = new DirectoryInfo(myAppPath + "\\LOGS");
                //Si no existe el directorio LOG, lo creo.
                if (!AppPath.Exists) AppPath.Create();
                //Ahora creo el archivo de LOG mismo...
                //Datetime para guardar el momento justo de creacion de archivo.
                string Datez = DateTime.Now.ToString("ddMMyy_hhmmss");
                StreamWriter LogFile = File.CreateText(AppPath.FullName + "\\LOG_" + Datez + ".log");
                foreach (string LOG_Line in LOG)
                {
                    LogFile.WriteLine(LOG_Line);
                    LogFile.Flush();
                }
                LogFile.Close();
                if (showme) System.Diagnostics.Process.Start("notepad", AppPath.FullName + "\\LOG_" + Datez + ".log");
                return true;
            }
            catch
            {
                return false;
            }
        }
        */

        static public bool Manejador_de_Excepciones(string miApp, Exception myError)
        {
            try
            {
                string eventLog = miApp + "_Excepciones";
                string eventSource = miApp;
                string myErrorMessage = String.Empty;

                myErrorMessage += "Mensaje:\r\n" +
                        myError.Message.ToString() + "\r\n\r\n";
                myErrorMessage += "Origen:\r\n" +
                    myError.Source + "\r\n\r\n";
                myErrorMessage += "Stack trace:\r\n" +
                    myError.StackTrace + "\r\n\r\n";
                myErrorMessage += "Target site:\r\n" +
                    myError.TargetSite.ToString() + "\r\n\r\n";
                //Si nuestra excepcion es producida dentro de otra.
                while (myError.InnerException != null)
                {
                    myErrorMessage += "Stack trace:\r\n" +
                        myError.StackTrace + "\r\n\r\n";
                    myErrorMessage += "Mensaje:\r\n" +
                            myError.Message.ToString() + "\r\n\r\n";
                    myErrorMessage += "Origen:\r\n" +
                        myError.Source + "\r\n\r\n";
                    myErrorMessage += "Target site:\r\n" +
                        myError.TargetSite.ToString() + "\r\n\r\n";
                    myError = myError.InnerException;
                }

                // Asegurate que nuestro EventLog exista, sino lo creamos
                if (!EventLog.SourceExists(eventLog))
                    EventLog.CreateEventSource(eventSource, eventLog);

                // Crea una instancia de nuestro EventLog y asignamos a nuestro 'Source'.
                EventLog myLog = new EventLog(eventLog);
                myLog.Source = eventSource;

                // Write the error entry to the event log.
                myLog.WriteEntry("Error ocurrido en : "
                  + eventSource + Environment.NewLine + myErrorMessage,
                    EventLogEntryType.Error);
                return true;
            }
            catch (Exception ERROR)
            {
                Console.WriteLine("Mensaje de Error:{0}", ERROR.ToString());
                Mensaje_de_Log_PORT("ERROR", ERROR.ToString());
                return false;
            }
        }

        static public bool Manejador_de_Excepciones(Exception myError)
        {
            try
            {
                string eventLog = "RASTREOError_server";
                string eventSource = "RASTREOSRV - Aplicación servidor de RASTREO";
                string myErrorMessage = String.Empty;

                myErrorMessage += "ErrCode:\r\n" +
                        myError.Message.ToString() + "\r\n\r\n";
                myErrorMessage += "RawData:\r\n" +
                        myError.Message.ToString() + "\r\n\r\n";
                myErrorMessage += "Mensaje:\r\n" +
                        myError.Message.ToString() + "\r\n\r\n";
                myErrorMessage += "Origen:\r\n" +
                    myError.Source + "\r\n\r\n";
                myErrorMessage += "Target site:\r\n" +
                    myError.TargetSite.ToString() + "\r\n\r\n";
                myErrorMessage += "Stack trace:\r\n" +
                    myError.StackTrace + "\r\n\r\n";
                myErrorMessage += ".ToString():\r\n\r\n" +
                    myError.ToString();
                if (myError.Data["POS_ERR"] != null)
                    myErrorMessage += myError.Data["POS_ERR"];

                while (myError.InnerException != null)
                {
                    myErrorMessage += "RawData:\r\n" +
                        myError.Message.ToString() + "\r\n\r\n";
                    myErrorMessage += "Mensaje:\r\n" +
                            myError.Message.ToString() + "\r\n\r\n";
                    myErrorMessage += "Origen:\r\n" +
                        myError.Source + "\r\n\r\n";
                    myErrorMessage += "Target site:\r\n" +
                        myError.TargetSite.ToString() + "\r\n\r\n";
                    myErrorMessage += "Stack trace:\r\n" +
                        myError.StackTrace + "\r\n\r\n";
                    myErrorMessage += ".ToString():\r\n\r\n" +
                        myError.ToString();

                    myError = myError.InnerException;
                }

                // Make sure the Eventlog Exists
                if (!EventLog.SourceExists(eventLog))
                    EventLog.CreateEventSource(eventSource, eventLog);

                // Create an EventLog instance and assign its source.
                EventLog myLog = new EventLog(eventLog);
                myLog.Source = eventSource;

                // Write the error entry to the event log.
                myLog.WriteEntry("Error ocurrido en : "
                  + eventSource + "\r\n\r\n" + myErrorMessage,
                    EventLogEntryType.Error);
                return true;
            }
            catch (Exception ERROR)
            {
                Console.WriteLine("Mensaje de Error:{0}", ERROR.ToString());
                Mensaje_de_Log_PORT("ERROR", ERROR.ToString());
                return false;
            }
        }

        static public bool Informaciones_del_sistema(string miMensaje)
        {
            try
            {
                string eventLog = "RASTREOInfo_server";
                string eventSource = "RASTREOSRV - Aplicación servidor de RASTREO Informaciones";
                string myErrorMessage = miMensaje;

                // Make sure the Eventlog Exists
                if (!EventLog.SourceExists(eventLog))
                    EventLog.CreateEventSource(eventSource, eventLog);

                EventLog myLog = new EventLog(eventLog);
                myLog.Source = eventSource;

                // Write the error entry to the event log.
                myLog.WriteEntry("Informacion proveniente de : "
                  + eventSource + "\r\n\r\n" + myErrorMessage,
                    EventLogEntryType.Information);
                return true;
                //}
            }
            catch (Exception ERROR)
            {
                Console.WriteLine("Mensaje de Error:{0}", ERROR.ToString());
                Mensaje_de_Log_PORT("ERROR", ERROR.ToString());
                return false;
            }
        }

        static public bool Informaciones_del_sistema(string miMensaje, EventLogEntryType TipoMensaje)
        {
            try
            {
                string eventLog = "RASTREOInfo_server";
                string eventSource = "RASTREOSRV - Aplicación servidor de RASTREO Informaciones";
                string myErrorMessage = miMensaje;

                // Make sure the Eventlog Exists
                if (!EventLog.SourceExists(eventLog))
                    EventLog.CreateEventSource(eventSource, eventLog);

                EventLog myLog = new EventLog(eventLog);
                myLog.Source = eventSource;

                // Write the error entry to the event log.
                myLog.WriteEntry("Informacion proveniente de : "
                  + eventSource + "\r\n\r\n" + myErrorMessage,
                    TipoMensaje);
                return true;
                //}
            }
            catch (Exception ERROR)
            {
                Console.WriteLine("Mensaje de Error:{0}", ERROR.ToString());
                Mensaje_de_Log_PORT("ERROR", ERROR.ToString());
                return false;
            }
        }

        static public bool Mensaje_de_Log_PORT(string Numero_de_puerto, string Mensaje)
        {
            try
            {
                //Obtengo el nombre del directorio en el cual se está
                //ejecutando el programa actual utilizando GetDirectoryName
                string myAppPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                //Crea un objeto DirectoryInfo para almacenar datos de mi directorio LOG
                DirectoryInfo AppPath = new DirectoryInfo("\\RASTREAR_SRV\\PORT_LOGS");
                //Si no existe el directorio LOG, lo creo.
                if (!AppPath.Exists) AppPath.Create();
                //Ahora creo el archivo de LOG mismo...
                //Datetime para guardar el momento justo de creacion de archivo.
                string file = AppPath.FullName + "\\LOG_PORT_" + Numero_de_puerto + DateTime.Now.ToString("_ddMMyy") + ".log";
                StreamWriter LogFile =
                new StreamWriter(new FileStream(file, FileMode.Append, FileAccess.Write, FileShare.ReadWrite));
                //Objeto semaforo para bloqueo mientras se obtiene el handle del archivo utilizado
                Object Locksem = new Object();
                lock (Locksem)
                {
                    if (Mensaje == string.Empty) return false;
                    if (Mensaje.Contains(Environment.NewLine) || Mensaje.Contains("\r") || Mensaje.Contains("\n"))
                    {
                        Mensaje =
                               Mensaje.Replace(Environment.NewLine, string.Empty).Replace("\r", string.Empty).Replace("\n", "");
                    }
                    LogFile.WriteLine("[" + DateTime.Now.ToString() + "]:\t" + Mensaje.Replace("\n", ""));
                    LogFile.Flush();
                }
                LogFile.Close();
                return true;
            }
            catch (Exception X)
            {
                Manejador_de_Excepciones(X);
                return false;
            }
        }
    }
}