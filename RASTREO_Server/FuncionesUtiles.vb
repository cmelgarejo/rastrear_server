Imports System.Net
Imports System.IO
Imports System.Text
Imports RASTREO_Lib
Imports System.Collections.Specialized

Public Class FuncionesUtiles

    ''' <summary>
    ''' localhost          = ABQIAAAA_r2VgoolhB6iO9xSBULQFxT2yXp_ZAY8_ufC3CFXhHIE1NvwkxS1gjBoSBKGYRWyikSCEeYHX8hJdQ
    ''' localhost:54321    = ABQIAAAA_r2VgoolhB6iO9xSBULQFxQ9pzGUvE4e-uE6JwppIOBVvhvAmRQysIA9otMz1DX9na4y4LGsV3YqDA
    ''' www.rastreo.com.py = ABQIAAAA_r2VgoolhB6iO9xSBULQFxRdTSOwTklp1zijXobIFghLmD1QXxQLokJLv163qA8gkCWwJOxR5oDSOQ
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared _GMAPS_API_KEY As String = "ABQIAAAA_r2VgoolhB6iO9xSBULQFxSKuZp3SzIZBr90mN7FkilXSG4VSRRoO9BOIhmhhgkSvwCeYRsokCi_iw"

    Public Shared Property GMAPS_KEY() As String
        Get
            Return _GMAPS_API_KEY
        End Get
        Set(ByVal value As String)
            _GMAPS_API_KEY = value
        End Set
    End Property

    Public Shared Function mapserver_ReverseGeocode(ByVal vlat As Double, ByVal vlng As Double) As String
        mapserver_ReverseGeocode = String.Empty
        Try
            Dim lat As String = vlat.ToString().Replace(",", ".")
            Dim lng As String = vlng.ToString().Replace(",", ".")
            Dim direccionweb As String = "http://" & My.Settings.g_MapServerIP & _
                                      ":" & My.Settings.g_MapServerPORT & _
                                      "/machear?POSX=" & lng & "&POSY=" & lat
            Dim webReq As HttpWebRequest = CType(WebRequest.Create(direccionweb), HttpWebRequest)
            webReq.Timeout = 200
            Dim WebResp As HttpWebResponse = DirectCast(webReq.GetResponse(), HttpWebResponse)
            Dim Answer As Stream = WebResp.GetResponseStream()
            Dim _Answer As New StreamReader(Answer, Encoding.UTF7)
            Dim resultado As String = _Answer.ReadToEnd()
            'mapserver_ReverseGeocode = resultado
            If resultado <> "|||||" And resultado.Contains("|") Then
                Dim direccion As String() = resultado.Split(Convert.ToChar("|"))
                If direccion.Length > 0 Then
                    mapserver_ReverseGeocode = _
                           Convert.ToString(IIf(String.IsNullOrEmpty(direccion(4)), "S/N", direccion(4))) & ", " & _
                           Convert.ToString(IIf(String.IsNullOrEmpty(direccion(3)), "S/N", direccion(3))) & ", " & _
                           Convert.ToString(IIf(String.IsNullOrEmpty(direccion(1)), "S/N", direccion(1)))
                End If
            Else
                'mapserver_ReverseGeocode = geonames_ReverseGeocode(vlat, vlng, True)
            End If
            Return mapserver_ReverseGeocode.ToUpperInvariant()
        Catch
            'mapserver_ReverseGeocode = geonames_ReverseGeocode(vlat, vlng, True)
            Return mapserver_ReverseGeocode.ToUpperInvariant()
        End Try
    End Function

    Public Shared Function google_ReverseGeocode(ByVal vlat As Double, ByVal vlng As Double, ByVal Callback As Boolean) As String
        Try
            google_ReverseGeocode = "No se ha podido obtener dirección."
            Dim lat As String = Convert.ToString(vlat).Replace(",", ".")
            Dim lng As String = Convert.ToString(vlng).Replace(",", ".")
            Dim webReq As HttpWebRequest = CType( _
                    WebRequest.Create("http://maps.google.com/maps/geo?q=" + lat + "," + lng + "&output=csv&key=" + _
                                      GMAPS_KEY),  _
                    HttpWebRequest)
            webReq.Timeout = 2000
            Dim WebResp As HttpWebResponse = DirectCast(webReq.GetResponse(), HttpWebResponse)
            Dim Answer As Stream = WebResp.GetResponseStream()
            Dim _Answer As New StreamReader(Answer)
            Dim resultado As String = _Answer.ReadToEnd()
            google_ReverseGeocode = resultado
            If resultado.Contains("200,") Then
                resultado = resultado.Substring(resultado.IndexOf(""""), resultado.Length - resultado.IndexOf(""""))
                google_ReverseGeocode = resultado.Replace("""", "")
            ElseIf resultado.Contains("620,") Then
                If Callback Then
                    google_ReverseGeocode = geonames_ReverseGeocode(vlat, vlng, True)
                Else
                    google_ReverseGeocode = mapserver_ReverseGeocode(vlat, vlng)
                End If
            End If
            Return google_ReverseGeocode.ToUpperInvariant()
        Catch
            google_ReverseGeocode = geonames_ReverseGeocode(vlat, vlng, True)
            Return google_ReverseGeocode.ToUpperInvariant()
        End Try
    End Function

    Public Shared Function geonames_ReverseGeocode(ByVal vlat As Double, ByVal vlng As Double, ByVal Callback As Boolean) As String
        Dim Pais As String = "-"
        Dim Distrito As String = "-"
        Dim Localidad1 As String = "-"
        Dim Localidad2 As String = "-"
        Dim Direccion As String = "-"
        Dim address As String = String.Empty
        Try
            Dim lat As String = Convert.ToString(vlat).Replace(",", ".")
            Dim lng As String = Convert.ToString(vlng).Replace(",", ".")
            Dim webReq As HttpWebRequest = CType(WebRequest.Create("http://ws.geonames.org/extendedFindNearby?lat=" + lat + "&lng=" + lng), HttpWebRequest)
            'webReq.TransferEncoding = "UTF8"
            webReq.Timeout = 2345
            'From here on, it's all the same as above.
            Dim WebResp As HttpWebResponse = DirectCast(webReq.GetResponse(), HttpWebResponse)
            'Let's show some information about the response
            'Now, we read the response (the string), and output it.
            Dim Answer As Stream = WebResp.GetResponseStream()
            Dim _Answer As New StreamReader(Answer)

            'Congratulations, with these two functions in basic form, you just learned
            'the two basic forms of web surfing
            'This proves how easy it can be.
            Dim resultado As String = _Answer.ReadToEnd()

            Dim xml As New System.Xml.XmlDocument()

            xml.LoadXml(resultado)

            Try
                Pais = xml.SelectNodes("/geonames")(0).ChildNodes(2).ChildNodes(0).InnerText
                Distrito = xml.SelectNodes("/geonames")(0).ChildNodes(3).ChildNodes(0).InnerText
                Localidad1 = xml.SelectNodes("/geonames")(0).ChildNodes(4).ChildNodes(0).InnerText
                Localidad2 = xml.SelectNodes("/geonames")(0).ChildNodes(5).ChildNodes(0).InnerText.Replace("Banco San Miguel", "Barrio San Miguel")
            Catch
                address = Pais + ", " + Distrito + ", " + Localidad1 + _
                    ", " + Localidad2 + ", " + Direccion
                Return address.ToUpperInvariant()
            End Try
            address = Pais + ", " + Distrito + ", " + Localidad1 + _
                    ", " + Localidad2 + ", " + Direccion
            Return address.ToUpperInvariant()
        Catch
            If Not Callback Then
                address = mapserver_ReverseGeocode(vlat, vlng)
            Else
                address = Pais + ", " + Distrito + ", " + Localidad1 + _
                        ", " + Localidad2 + ", " + Direccion
            End If
            Return address.ToUpperInvariant()
        End Try
    End Function

    ''Hacer que el recorrido lo saque del v2, mas rapido sera
    Public Shared Function GetRecorridoDiario(ByVal vid As String) As String
        Try
            Dim webReq As HttpWebRequest = CType(WebRequest.Create("http://" & My.Settings.g_DNSWeb & "/reporte_diario.aspx?vid=" & vid), HttpWebRequest)
            'Dim webReq As HttpWebRequest = CType(WebRequest.Create("http://localhost:8081/RASTREO_WebSite" & "/reporte_diario.aspx?vid=" & vid), HttpWebRequest)
            webReq.Timeout = 60 * 1000 * 20
            'From here on, it's all the same as above.
            'Dim WebResp As HttpWebResponse = DirectCast(webReq.GetResponse(), HttpWebResponse)
            Dim WebResp As HttpWebResponse
            WebResp = DirectCast(webReq.GetResponse(), HttpWebResponse)
            'Let's show some information about the response
            'Now, we read the response (the string), and output it.
            Dim filename As String = String.Empty
            For Each Header As String In WebResp.Headers
                If Header.Contains("Content-Disposition") Then
                    filename = WebResp.Headers("Content-Disposition").Replace("attachment;filename=", "")
                End If
            Next
            Dim Answer As Stream = WebResp.GetResponseStream()
            Dim _Answer As New StreamReader(Answer)
            Dim resultado As String = _Answer.ReadToEnd()
            Dim AppPath As New DirectoryInfo("C:\RASTREAR_SRV\")
            If Not AppPath.Exists Then AppPath.Create()
            AppPath = New DirectoryInfo("C:\RASTREAR_SRV\recorridos_enviados\")
            If Not AppPath.Exists Then AppPath.Create()
            SyncLock AppPath
                Dim archivoPOS As New StreamWriter(New FileStream("C:\RASTREAR_SRV\recorridos_enviados\" & filename, FileMode.Create, FileAccess.ReadWrite))

                archivoPOS.Write(resultado)
                archivoPOS.Flush()
                archivoPOS.Close()
            End SyncLock
            'Return (AppPath.Root.ToString() & AppPath.ToString() & filename).Replace("\\", "\")
            Return (AppPath.ToString() & filename).Replace("\\", "\")
        Catch ex As Exception
            Funciones_de_soporte.Manejador_de_Excepciones(ex)
            Return String.Empty
        End Try
    End Function

End Class
