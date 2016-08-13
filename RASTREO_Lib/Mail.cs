/**
 * Funciones de envio de MAIL
 * Author: Christian A. Melgarejo Bresanovich
 * Program: RASTREO System 
 * Created: 19 Mar, 2009
**/
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace Utilidades
{
    public class Mail
    {

        public static bool SendMailTo(string from, string To, string subject, string Message, string SERVER, int PORT, string USER, string PASSWORD, bool SSL)
        {
            try
            {
                MailMessage MSG = new MailMessage(from, To, subject, Message);
                MSG.IsBodyHtml = true;
                SmtpClient smtpSender = new SmtpClient(SERVER, PORT);
                smtpSender.EnableSsl = SSL;
                smtpSender.Host = SERVER;
                //smtpSender.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpSender.UseDefaultCredentials = false;
                smtpSender.Credentials = new System.Net.NetworkCredential(USER, PASSWORD);
                smtpSender.Send(MSG);
                smtpSender = null;
                MSG.Dispose();
                return true;
            }
            catch(System.Threading.ThreadAbortException)
            { return false; }
            catch(Exception Exy)
            {
                RASTREO_Lib.Funciones_de_soporte.Manejador_de_Excepciones(Exy);
                return false;
            }
        }


        static string _from = RASTREO_Lib.Properties.Settings.Default.MailFrom;//"RASTREO Informaciones";
        static string _USER = RASTREO_Lib.Properties.Settings.Default.MailUser;//"info@rastreo.com.py";
        static string _PASSWORD = RASTREO_Lib.Properties.Settings.Default.MailPassword;// "inforastreo";
        static string _SERVER = RASTREO_Lib.Properties.Settings.Default.MailServer;//"smtp.gmail.com";
        static int _PORT = RASTREO_Lib.Properties.Settings.Default.MailPort;// 587;

        public static bool SendMailTo(string To, string subject, string Message, bool SSL)
        {
            try
            {
                MailMessage MSG = new MailMessage(_from, To, subject, Message);
                MSG.IsBodyHtml = true;
                SmtpClient smtpSender = new SmtpClient(_SERVER, _PORT);
                smtpSender.Timeout = 20000;
                smtpSender.EnableSsl = SSL;
                smtpSender.Host = _SERVER;
                //smtpSender.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpSender.UseDefaultCredentials = false;
                smtpSender.Credentials = new System.Net.NetworkCredential(_USER, _PASSWORD);
                smtpSender.Send(MSG);
                smtpSender = null;
                MSG.Dispose();
                return true;
            }
            catch(System.Threading.ThreadAbortException)
            { return false; }
            catch(Exception Exy)
            {
                RASTREO_Lib.Funciones_de_soporte.Manejador_de_Excepciones(Exy); return false;
            }
        }

        public static bool SendMailToMovil(string from, string To, string subject, string Message, string SERVER, int PORT, string USER, string PASSWORD, bool SSL)
        {
            try
            {
                if (To.Contains("59598") || To.Contains("098"))
                {
                    if (To.Contains("098")) To = To.Replace("098", "59598");
                    To = To + "@tigo.com.py";
                }
                else if (To.Contains("59597") || To.Contains("097"))
                {
                    if (To.Contains("097")) To = To.Replace("097", "59597");
                    To = To + "@personal.net.py";
                }
                else if (To.Contains("59596") || To.Contains("096"))
                {
                    if (To.Contains("096")) To = To.Replace("096", "59596");
                    To = To + "@vox.com.py";
                }
                else if (To.Contains("59599") || To.Contains("099"))
                {
                    if (To.Contains("099")) To = To.Replace("099", "59599");
                    To = To + "@claro.com.py";
                }
                MailMessage MSG = new MailMessage(from, To, subject, Message);
                MSG.IsBodyHtml = false;
                SmtpClient smtpSender = new SmtpClient(SERVER, PORT);
                smtpSender.EnableSsl = SSL;
                smtpSender.Host = SERVER;
                //smtpSender.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpSender.UseDefaultCredentials = false;
                smtpSender.Credentials = new System.Net.NetworkCredential(USER, PASSWORD);
                smtpSender.Send(MSG);
                smtpSender = null;
                MSG.Dispose();
                return true;
            }
            catch(System.Threading.ThreadAbortException)
            { return false; }
            catch(Exception Exy)
            {
                RASTREO_Lib.Funciones_de_soporte.Manejador_de_Excepciones(Exy);
                return false;
            }
        }

        public static bool SendMailTo(string from, string To, string subject, string Message, string FileNameAttach,
                                string SERVER, int PORT, string USER, string PASSWORD, bool SSL)
        {
            try
            {
                MailMessage MSG = new MailMessage(from, To, subject, Message);
                MSG.IsBodyHtml = true;
                Attachment Mailattach = new Attachment(FileNameAttach);
                MSG.Attachments.Add(Mailattach);
                SmtpClient smtpSender = new SmtpClient(SERVER, PORT);
                smtpSender.EnableSsl = SSL;
                smtpSender.Host = SERVER;
                //smtpSender.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpSender.UseDefaultCredentials = false;
                smtpSender.Credentials = new System.Net.NetworkCredential(USER, PASSWORD);
                smtpSender.Send(MSG);
                Mailattach.Dispose();
                smtpSender = null;
                MSG.Dispose();
                //;
                return true;
            }
            catch(System.Threading.ThreadAbortException)
            { return false; }
            catch(Exception Exy)
            {
                RASTREO_Lib.Funciones_de_soporte.Manejador_de_Excepciones(Exy);
                return false;
            }
        }

    }

}