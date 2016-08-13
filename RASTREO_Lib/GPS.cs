/**
 * Funciones GPS varias
 * Author: Christian A. Melgarejo Bresanovich
 * Program: RASTREO System 
 * Created: 19 Feb , 2009
**/
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace Utilidades
{
    public static class Funciones_Utiles_GPS
    {
        //private static string _GMAPS_API_KEY = "ABQIAAAA_r2VgoolhB6iO9xSBULQFxSKuZp3SzIZBr90mN7FkilXSG4VSRRoO9BOIhmhhgkSvwCeYRsokCi_iw";

        /// <summary>
        /// Retorna la distancia en METROS de un punto geoposicional a otro.
        /// </summary>
        /// <param name="lat1">Latitud punto 1</param>
        /// <param name="lon1">Longitud punto 1</param>
        /// <param name="lat2">Latitud punto 2</param>
        /// <param name="lon2">Latitud punto 2</param>
        /// <returns></returns>
        public static double Calcular_distancia_entre_dos_puntos_METROS(double lat1, double lon1,
                                                          double lat2, double lon2)
        {
            int R = 6371; // km
            double dLat = (lat2-lat1) * Math.PI / 180;
            double dLon = (lon2 - lon1) * Math.PI / 180;
            double a = Math.Sin(dLat/2) * Math.Sin(dLat/2) +
                    Math.Cos(toRad(lat1)) * Math.Cos(toRad(lat2)) * 
                    Math.Sin(dLon/2) * Math.Sin(dLon/2); 
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1-a));
            double d = R * c * 1000;
            return d;
        }
        
        public static double toRad(double nro)
        {
            return nro * Math.PI / 180;
        }

        /// <summary>
        /// Esta funcion retorna TRUE si el punto se encuentra en la geozona FALSE en caso contrario.
        /// </summary>
        /// <param name="GeoFence">Geocerca, formatio WKF (Ej:
        /// POLYGON(-57.623291015625 -25.224820176765,-57.293701171875 -24.926294766396,-56.964111328125 -25.423431426334,-57.41455078125 -25.740529092773,-57.67822265625 -25.284437746983,-57.623291015625 -25.224820176765))</param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool Chequear_punto_en_geocerca(string GeoFence, double xp, double yp)
        {
            GeoFence = GeoFence.Replace("(", "").Replace(")", "").Replace("POLYGON", "").Trim();
            List<double> geoX = new List<double>();
            List<double> geoY = new List<double>();
            string[] split_GeoFence = GeoFence.Split(',');
            int nPuntosGeo = split_GeoFence.Length;
            foreach (string GeoPoint in GeoFence.Split(','))
            {
                string Vertice = GeoPoint.Trim();
                if (Vertice != string.Empty)
                {
                    float Lon = 0, Lat = 0;
                    if (float.TryParse(Vertice.Split(' ')[1].Replace('.', ','), out Lon) &&
                        float.TryParse(Vertice.Split(' ')[0].Replace('.', ','), out Lat))
                    {
                        geoX.Add(Lon);
                        geoY.Add(Lat);
                    }
                }
            }
            int i, j;
            bool c = false;

            for (i = 0, j = nPuntosGeo - 1; i < nPuntosGeo; j = i++)
            {
                if ((((geoY[i] <= yp) && (yp < geoY[j])) ||
                     ((geoY[j] <= yp) && (yp < geoY[i]))) &&
                    (xp < (geoX[j] - geoX[i]) * (yp - geoY[i]) / (geoY[j] - geoY[i]) + geoX[i]))
                    c = !c;
            }
            return c;
        }

        public static string reverse_GeoCode(StringBuilder data, string sourcePath)
        {
            Stream aStream = null;
            try
            {
                int timeOut = 10000;

                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(sourcePath);

                req.Method = "GET";
                req.ContentType = "text/xml";
                req.Timeout = timeOut;
                req.Credentials = CredentialCache.DefaultCredentials;

                if (data.Length > 0)
                {
                    req.ContentLength = data.Length;
                    StreamWriter sw = new StreamWriter(req.GetRequestStream());
                    sw.Write(data.ToString());
                    sw.Flush();
                    sw.Close();
                }
                // Create The Response Object And Fill It By Sending The Request;
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                aStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(aStream);

                StringBuilder sbOutput = new StringBuilder();

                char[] buffer = new char[1024];

                int r;
                while ((r = sr.Read(buffer, 0, buffer.Length)) > 0)
                {
                    sbOutput.Append(buffer, 0, r);
                }
                return sbOutput.ToString();
            }
            catch (WebException ex)
            {
                return ex.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                aStream.Close();
            }

        }

        public static string mapserver_ReverseGeocode(string mapserverIP, string mapserverPORT, double vlat, double vlng)
        {
            string functionReturnValue = string.Empty;
            try
            {
                string lat = vlat.ToString().Replace(",", ".");
                string lng = vlng.ToString().Replace(",", ".");
                string direccionweb = "http://" + mapserverIP + ":" + mapserverPORT + "/machear?POSX=" + lng + "&POSY=" + lat;
                HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(direccionweb);
                webReq.Timeout = 500;
                HttpWebResponse WebResp = (HttpWebResponse)webReq.GetResponse();
                Stream Answer = WebResp.GetResponseStream();
                StreamReader _Answer = new StreamReader(Answer, Encoding.UTF7);
                string resultado = _Answer.ReadToEnd();
                //mapserver_ReverseGeocode = resultado
                if (resultado != "|||||" & resultado.Contains("|"))
                {
                    string[] direccion = resultado.Split(Convert.ToChar("|"));
                    if (direccion.Length > 0)
                    {
                        functionReturnValue = Convert.ToString((string.IsNullOrEmpty(direccion[4]) ? "S/N" : direccion[4])) + ", " + Convert.ToString((string.IsNullOrEmpty(direccion[3]) ? "S/N" : direccion[3])) + ", " + Convert.ToString((string.IsNullOrEmpty(direccion[1]) ? "S/N" : direccion[1]));
                    }
                }
                else
                {
                    //functionReturnValue = geonames_ReverseGeocode(vlat, vlng, true);
                }
                return functionReturnValue.ToUpperInvariant();
            }
            catch
            {
                //functionReturnValue = geonames_ReverseGeocode(vlat, vlng, true);
                return functionReturnValue.ToUpperInvariant();
            }
            //return functionReturnValue;
        }

        public static string google_ReverseGeocode(double vlat, double vlng)
        {
            string functionReturnValue = null;
            try
            {
                functionReturnValue = "No se ha podido obtener dirección.";
                string lat = Convert.ToString(vlat).Replace(",", ".");
                string lng = Convert.ToString(vlng).Replace(",", ".");
                HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create("http://maps.google.com/maps/api/geocode/xml?latlng=" + lat + "," + lng + "&sensor=false");
                webReq.Timeout = 2000;
                HttpWebResponse WebResp = (HttpWebResponse)webReq.GetResponse();
                Stream Answer = WebResp.GetResponseStream();
                StreamReader _Answer = new StreamReader(Answer);
                string resultado = _Answer.ReadToEnd();
                if(resultado.ToLowerInvariant().Contains("<status>ok</status>"))
                {
                    if(resultado.ToLowerInvariant().Contains("<formatted_address>"))
                    {
                        resultado = resultado.Substring(0, resultado.IndexOf("</formatted_address>"));
                        resultado = resultado.Substring(resultado.LastIndexOf(">") + 1, resultado.Length - (resultado.LastIndexOf(">") + 1));
                    }
                }
                else
                    resultado = "S/N";
                functionReturnValue = resultado;
                if(resultado.Contains("200,"))
                {
                    resultado = resultado.Substring(resultado.IndexOf("\""), resultado.Length - resultado.IndexOf("\""));
                    functionReturnValue = resultado.Replace("\"", "");
                }
                else if(resultado.Contains("620,"))
                {
                    functionReturnValue = "S/N";
                }
                return functionReturnValue.ToUpperInvariant();
            }
            catch
            {
                //functionReturnValue = geonames_ReverseGeocode(vlat, vlng, true);
                return functionReturnValue = "S/N";
            }
            //return functionReturnValue;
        }
        public static string geonames_ReverseGeocode(double vlat, double vlng, bool Callback)
        {
            string Pais = "-";
            string Distrito = "-";
            string Localidad1 = "-";
            string Localidad2 = "-";
            string Direccion = "-";
            string address = string.Empty;
            try
            {
                string lat = Convert.ToString(vlat).Replace(",", ".");
                string lng = Convert.ToString(vlng).Replace(",", ".");
                HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create("http://ws.geonames.org/extendedFindNearby?lat=" + lat + "&lng=" + lng);
                //webReq.TransferEncoding = "UTF8"
                webReq.Timeout = 2345;
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

                try
                {
                    Pais = xml.SelectNodes("/geonames")[0].ChildNodes[2].ChildNodes[0].InnerText;
                    Distrito = xml.SelectNodes("/geonames")[0].ChildNodes[3].ChildNodes[0].InnerText;
                    Localidad1 = xml.SelectNodes("/geonames")[0].ChildNodes[4].ChildNodes[0].InnerText;
                    Localidad2 = xml.SelectNodes("/geonames")[0].ChildNodes[5].ChildNodes[0].InnerText.Replace("Banco San Miguel", "Barrio San Miguel");
                }
                catch
                {
                    address = Pais + ", " + Distrito + ", " + Localidad1 + ", " + Localidad2 + ", " + Direccion;
                    return address.ToUpperInvariant();
                }
                address = Pais + ", " + Distrito + ", " + Localidad1 + ", " + Localidad2 + ", " + Direccion;
                return address.ToUpperInvariant();
            }
            catch
            {
                if (!Callback)
                {
                    //address = mapserver_ReverseGeocode(vlat, vlng);
                }
                else
                {
                    address = Pais + ", " + Distrito + ", " + Localidad1 + ", " + Localidad2 + ", " + Direccion;
                }
                return address.ToUpperInvariant();
            }
        }

    }
}
